using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace BusyLightConsole
{
    #region Delegates
    public delegate void RegistryChangeHandler(object sender, RegistryChangeEventArgs e);
    #endregion

    public class RegistryChangeMonitor : IDisposable
    {
        #region Fields
        private RegistryHive _registryHive;
        private string _registryKey;

        private REG_NOTIFY_CHANGE _filter;
        private Thread _monitorThread;
        private RegistryKey _monitorKey;
        #endregion

        #region Imports
        [DllImport("Advapi32.dll")]
        private static extern int RegNotifyChangeKeyValue(
           IntPtr hKey,
           bool watchSubtree,
           REG_NOTIFY_CHANGE notifyFilter,
           IntPtr hEvent,
           bool asynchronous
           );
        #endregion

        #region Enumerations
        [Flags]
        public enum REG_NOTIFY_CHANGE : uint
        {
            NAME = 0x1,
            ATTRIBUTES = 0x2,
            LAST_SET = 0x4,
            SECURITY = 0x8
        }
        #endregion

        #region Constructors
        public RegistryChangeMonitor(RegistryHive Hive, string Key) : this(Hive, Key, REG_NOTIFY_CHANGE.LAST_SET) {; }
        public RegistryChangeMonitor(RegistryHive Hive, string Key, REG_NOTIFY_CHANGE Filter)
        {
            this._registryHive = Hive;
            this._registryKey = Key;
            this._filter = Filter;
        }
        ~RegistryChangeMonitor()
        {
            this.Dispose(false);
        }
        #endregion

        #region Methods
        private void Dispose(bool disposing)
        {
            if (disposing)
                GC.SuppressFinalize(this);

            this.Stop();
        }
        public void Dispose()
        {
            this.Dispose(true);
        }
        public void Start()
        {
            lock (this)
            {
                if (this._monitorThread == null)
                {
                    ThreadStart ts = new ThreadStart(this.MonitorThread);
                    this._monitorThread = new Thread(ts);
                    this._monitorThread.IsBackground = true;
                }

                if (!this._monitorThread.IsAlive)
                {
                    this._monitorThread.Start();
                }
            }
        }
        public void Stop()
        {
            lock (this)
            {
                this.Changed = null;
                this.Error = null;

                if (this._monitorThread != null)
                {
                    this._monitorThread = null;
                }

                // The "Close()" will trigger RegNotifyChangeKeyValue if it is still listening
                if (this._monitorKey != null)
                {
                    this._monitorKey.Close();
                    this._monitorKey = null;
                }
            }
        }
        private void MonitorThread()
        {
            try
            {
                IntPtr ptr = IntPtr.Zero;

                lock (this)
                {
                    RegistryKey localKey = RegistryKey.OpenBaseKey(this._registryHive, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
                    this._monitorKey = localKey.OpenSubKey(this._registryKey);

                    // Fetch the native handle
                    if (this._monitorKey != null)
                    {
                        object hkey = typeof(RegistryKey).InvokeMember(
                           "hkey",
                           BindingFlags.GetField | BindingFlags.Instance | BindingFlags.NonPublic,
                           null,
                           this._monitorKey,
                           null
                           );

                        ptr = (IntPtr)typeof(SafeHandle).InvokeMember(
                           "handle",
                           BindingFlags.GetField | BindingFlags.Instance | BindingFlags.NonPublic,
                           null,
                           hkey,
                           null);
                    }
                }

                if (ptr != IntPtr.Zero)
                {
                    while (true)
                    {
                        // If this._monitorThread is null that probably means Dispose is being called. Don't monitor anymore.
                        if ((this._monitorThread == null) || (this._monitorKey == null))
                            break;

                        // RegNotifyChangeKeyValue blocks until a change occurs.
                        int result = RegNotifyChangeKeyValue(ptr, true, this._filter, IntPtr.Zero, false);

                        if ((this._monitorThread == null) || (this._monitorKey == null))
                            break;

                        if (result == 0)
                        {
                            if (this.Changed != null)
                            {
                                RegistryChangeEventArgs e = new RegistryChangeEventArgs(this);
                                this.Changed(this, e);

                                if (e.Stop) break;
                            }
                        }
                        else
                        {
                            if (this.Error != null)
                            {
                                Win32Exception ex = new Win32Exception();

                                // Unless the exception is thrown, nobody is nice enough to set a good stacktrace for us. Set it ourselves.
                                typeof(Exception).InvokeMember(
                                "_stackTrace",
                                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetField,
                                null,
                                ex,
                                new object[] { new StackTrace(true) }
                                );

                                RegistryChangeEventArgs e = new RegistryChangeEventArgs(this);
                                e.Exception = ex;
                                this.Error(this, e);
                            }

                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (this.Error != null)
                {
                    RegistryChangeEventArgs e = new RegistryChangeEventArgs(this);
                    e.Exception = ex;
                    this.Error(this, e);
                }
            }
            finally
            {
                this.Stop();
            }
        }
        #endregion

        #region Events
        public event RegistryChangeHandler Changed;
        public event RegistryChangeHandler Error;
        #endregion

        #region Properties
        public bool Monitoring
        {
            get
            {
                if (this._monitorThread != null)
                    return this._monitorThread.IsAlive;

                return false;
            }
        }
        #endregion
    }
    public class RegistryChangeEventArgs : EventArgs
    {
        #region Fields
        private bool _stop;
        private Exception _exception;
        private RegistryChangeMonitor _monitor;
        #endregion

        #region Constructor
        public RegistryChangeEventArgs(RegistryChangeMonitor monitor)
        {
            this._monitor = monitor;
        }
        #endregion

        #region Properties
        public RegistryChangeMonitor Monitor
        {
            get { return this._monitor; }
        }

        public Exception Exception
        {
            get { return this._exception; }
            set { this._exception = value; }
        }

        public bool Stop
        {
            get { return this._stop; }
            set { this._stop = value; }
        }
        #endregion
    }
}
