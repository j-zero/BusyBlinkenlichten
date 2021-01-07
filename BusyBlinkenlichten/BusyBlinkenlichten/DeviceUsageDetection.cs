using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BusyBlinkenlichten
{
    class AppInformation
    {
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
        public bool IsWebcamInUse { get; private set; }

        public List<AppInformation> MicrophoneApps { get; private set; }
        public List<AppInformation> WebcamApps { get; private set; }

        private RegistryChangeMonitor rm;

        public enum DeviceType
        {
            Microhpone,
            Webcam
        }

        public DeviceUsageDetection()
        {
            MicrophoneApps = new List<AppInformation>();
            WebcamApps = new List<AppInformation>();

            GetUsage(DeviceType.Microhpone);
            GetUsage(DeviceType.Webcam);

            this.rm = new RegistryChangeMonitor(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore");
            this.rm.Changed += ConsentStoreChanged;
            this.rm.Start();
            
        }

        public void StartMonitoring()
        {
            this.rm.Start();
        }

        public void StopMonitoring()
        {
            this.rm.Stop();
        }
        private void ConsentStoreChanged(object sender, RegistryChangeEventArgs e)
        {
            GetUsage(DeviceType.Microhpone);
            GetUsage(DeviceType.Webcam);
            RaiseEventOnUIThread(DeviceUsageDetected, new object[] { });
        }

        private RegistryKey GetRegistryHive(RegistryHive Hive)
        {
            return RegistryKey.OpenBaseKey(Hive, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
        }

        public void GetUsage(DeviceType Device)
        {
            string dev = "microphone";
            switch (Device)
            {
                case DeviceType.Microhpone:
                    dev = "microphone";
                    MicrophoneApps.Clear();
                    this.IsMicrophoneInUse = false;
                    break;
                case DeviceType.Webcam:
                    dev = "webcam";
                    WebcamApps.Clear();
                    this.IsWebcamInUse = false;
                    break;
            }

            RegistryKey basekey = GetRegistryHive(RegistryHive.LocalMachine).OpenSubKey(
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\" + dev + @"\");

            // Windows Apps
            string[] subs = basekey.GetSubKeyNames();
            foreach (string sub in subs)
            {
                if (sub == "NonPackaged")
                    continue;
                long lastUsedTimeStart = (long)basekey.OpenSubKey(sub).GetValue("LastUsedTimeStart");
                long lastUsedTimeStop = (long)basekey.OpenSubKey(sub).GetValue("LastUsedTimeStop");
                AppInformation ai = new AppInformation();
                ai.WindowsApp = true;
                ai.SubKey = sub;
                ai.LastUsedTimeStart = lastUsedTimeStart;
                ai.LastUsedTimeStop = lastUsedTimeStop;
                if (Device == DeviceType.Microhpone)
                {
                    if (ai.InUse)
                        this.IsMicrophoneInUse = true;
                    MicrophoneApps.Add(ai);
                }
                    
                else if (Device == DeviceType.Webcam) 
                {
                    if (ai.InUse)
                        this.IsWebcamInUse = true;
                    WebcamApps.Add(ai);
                } 
            }

            // "NonPackaged" Apps
            string[] subsNonPackaged = basekey.OpenSubKey("NonPackaged").GetSubKeyNames();
            foreach (string sub in subsNonPackaged)
            {
                long lastUsedTimeStart = (long)basekey.OpenSubKey("NonPackaged").OpenSubKey(sub).GetValue("LastUsedTimeStart");
                long lastUsedTimeStop = (long)basekey.OpenSubKey("NonPackaged").OpenSubKey(sub).GetValue("LastUsedTimeStop");
                AppInformation ai = new AppInformation();
                ai.WindowsApp = true;
                ai.SubKey = sub;
                ai.LastUsedTimeStart = lastUsedTimeStart;
                ai.LastUsedTimeStop = lastUsedTimeStop;
                if (Device == DeviceType.Microhpone)
                {
                    if (ai.InUse)
                        this.IsMicrophoneInUse = true;
                    MicrophoneApps.Add(ai);
                }

                else if (Device == DeviceType.Webcam)
                {
                    if (ai.InUse)
                        this.IsWebcamInUse = true;
                    WebcamApps.Add(ai);
                }
            }
            ;
        }
    }
}
