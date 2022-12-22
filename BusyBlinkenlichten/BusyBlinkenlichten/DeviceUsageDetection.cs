using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BusyBlinkenlichten
{
    class AppInformation
    {
        public RegistryHive Hive { get; set; }
        public string SubKey { get; set; }
        public bool WindowsApp { get; set; }
        public string Path { 
            get
            {
                return WindowsApp ? null : SubKey.Replace('#', '\\');
            }
        }
        public long LastUsedTimeStart { get; set; }
        public long LastUsedTimeStop { get; set; }
        public bool InUse { get { return (LastUsedTimeStop == 0); } }
        
    }
    class DeviceUsageDetection
    {
        public delegate void DeviceUsageDetectedCallback();

        #region Events
        public event DeviceUsageDetectedCallback DeviceUsageDetected;
        #endregion

        /// <summary>
        /// Checks the Target of each delegate in the event's invocation list, and marshal the call to the target thread if that target is ISynchronizeInvoke:
        /// </summary>
        /// <param name="theEvent"></param>
        /// <param name="args"></param>
        private void RaiseEventOnUIThread(Delegate theEvent, object[] args)
        {
            foreach (Delegate d in theEvent.GetInvocationList())
            {
                ISynchronizeInvoke syncer = d.Target as ISynchronizeInvoke;
                if (syncer == null)
                {
                    d.DynamicInvoke(args);
                }
                else
                {
                    syncer.BeginInvoke(d, args);
                }
            }
        }

        public bool IsMicrophoneInUse { get; private set; }

        public AppInformation LastMicrophoneApplication { get; private set; }

        public bool IsWebcamInUse { get; private set; }
        public AppInformation LastWebcamApplication { get; private set; }
        public List<AppInformation> MicrophoneApps { get; private set; }
        public List<AppInformation> WebcamApps { get; private set; }

        private RegistryChangeMonitor rmLm;
        private RegistryChangeMonitor rmCu;

        public enum DeviceType
        {
            Microhpone,
            Webcam
        }

        public DeviceUsageDetection()
        {
            MicrophoneApps = new List<AppInformation>();
            WebcamApps = new List<AppInformation>();

            GetUsageAllHives();

            this.rmLm = new RegistryChangeMonitor(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore");
            this.rmLm.Changed += ConsentStoreChanged;
            this.rmLm.Start();

            this.rmCu = new RegistryChangeMonitor(RegistryHive.CurrentUser, @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore");
            this.rmCu.Changed += ConsentStoreChanged;
            this.rmCu.Start();

        }

        public void StartMonitoring()
        {
            this.rmLm.Start();
            this.rmCu.Start();
        }

        public void StopMonitoring()
        {
            this.rmLm.Stop();
            this.rmCu.Stop();
        }
        private void ConsentStoreChanged(object sender, RegistryChangeEventArgs e)
        {
            GetUsageAllHives();
            RaiseEventOnUIThread(DeviceUsageDetected, new object[] { });
        }

        void GetUsageAllHives()
        {
            MicrophoneApps.Clear();
            WebcamApps.Clear();
            this.IsMicrophoneInUse = false;
            this.IsWebcamInUse = false;
            GetUsage(RegistryHive.LocalMachine, DeviceType.Microhpone);
            GetUsage(RegistryHive.LocalMachine, DeviceType.Webcam);
            GetUsage(RegistryHive.CurrentUser, DeviceType.Microhpone);
            GetUsage(RegistryHive.CurrentUser, DeviceType.Webcam);
        }

        private RegistryKey GetRegistryHive(RegistryHive Hive)
        {
            return RegistryKey.OpenBaseKey(Hive, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
        }

        private void GetUsage(RegistryHive Hive, DeviceType Device)
        {

            string dev = "microphone";
            switch (Device)
            {
                case DeviceType.Microhpone:
                    dev = "microphone";
                    break;
                case DeviceType.Webcam:
                    dev = "webcam";
                    break;
            }
            try
            {
                RegistryKey basekey = GetRegistryHive(Hive).OpenSubKey(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\" + dev + @"\");

                // Windows Apps
                string[] subs = basekey.GetSubKeyNames();
                foreach (string sub in subs)
                {
                    if (sub == "NonPackaged")
                        continue;

                    long? lastUsedTimeStart = (long?)basekey.OpenSubKey(sub).GetValue("LastUsedTimeStart");
                    long? lastUsedTimeStop = (long?)basekey.OpenSubKey(sub).GetValue("LastUsedTimeStop");

                    if (lastUsedTimeStop == null)
                        continue;

                    AppInformation ai = new AppInformation();
                    ai.WindowsApp = true;
                    ai.SubKey = sub;
                    ai.Hive = Hive;

                    ai.LastUsedTimeStart = lastUsedTimeStart != null ? (long)lastUsedTimeStart : 0;
                    ai.LastUsedTimeStop = lastUsedTimeStop != null ? (long)lastUsedTimeStop : 0;

                    if (Device == DeviceType.Microhpone)
                    {
                        if (ai.InUse)
                        {
                            this.IsMicrophoneInUse = true;
                            this.LastMicrophoneApplication = ai;
                        }
                        MicrophoneApps.Add(ai);
                    }

                    else if (Device == DeviceType.Webcam)
                    {
                        if (ai.InUse)
                        {
                            this.IsWebcamInUse = true;
                            this.LastWebcamApplication = ai;
                        }
                        
                        WebcamApps.Add(ai);
                    }
                }

                // "NonPackaged" Apps
                string[] subsNonPackaged = basekey.OpenSubKey("NonPackaged").GetSubKeyNames();
                foreach (string sub in subsNonPackaged)
                {
                    long? lastUsedTimeStart = (long?)basekey.OpenSubKey("NonPackaged").OpenSubKey(sub).GetValue("LastUsedTimeStart");
                    long? lastUsedTimeStop = (long?)basekey.OpenSubKey("NonPackaged").OpenSubKey(sub).GetValue("LastUsedTimeStop");

                    if (lastUsedTimeStop == null)
                        continue;

                    AppInformation ai = new AppInformation();
                    ai.WindowsApp = false;
                    ai.SubKey = sub;
                    ai.Hive = Hive;
                    ai.LastUsedTimeStart = lastUsedTimeStart != null ? (long)lastUsedTimeStart : 0;
                    ai.LastUsedTimeStop = lastUsedTimeStop != null ? (long)lastUsedTimeStop : 0;

                    if (Device == DeviceType.Microhpone)
                    {
                        if (ai.InUse)
                        {
                            this.IsMicrophoneInUse = true;
                            this.LastMicrophoneApplication = ai;
                        }
                        MicrophoneApps.Add(ai);
                    }

                    else if (Device == DeviceType.Webcam)
                    {
                        if (ai.InUse)
                        {
                            this.IsWebcamInUse = true;
                            this.LastWebcamApplication = ai;
                        }
                            
                        WebcamApps.Add(ai);
                    }
                }
            ;
            }
            catch(Exception ex)
            {
                System.IO.File.AppendAllText("BusyBlinkenlichten.log", ex.Message + Environment.NewLine + ex.StackTrace);
                //System.IO.File.AppendAllText("BusyBlinkenlichten.log", ex.StackTrace);
            }
        
        }
    }
}
