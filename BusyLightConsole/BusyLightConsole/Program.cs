using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace BusyLightConsole
{
    class Program
    {
        static string WindowsVersion = "0";
        enum DeviceType
        {
            Microhpone,
            Webcam
        }

        static void Main(string[] args)
        {
            // HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\ReleaseID
            WindowsVersion = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseID", "0");
            Console.Clear();
            Console.WriteLine("Microphone:");
            ListUsage(DeviceType.Microhpone);
            Console.WriteLine("Webcam:");
            ListUsage(DeviceType.Webcam);

            RegistryChangeMonitor rm = new RegistryChangeMonitor(RegistryHive.CurrentUser, @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore");
            rm.Changed += Rm_Changed;
            rm.Start();

            /*
            RegistryChangeMonitor rw = new RegistryChangeMonitor(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\webcam\NonPackaged");
            rw.Changed += Rm_Changed;
            rw.Start();
            */
            Console.ReadLine();
        }


        static void ListUsage(DeviceType Device)
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

            RegistryKey basekey = GetRegistryHive(RegistryHive.CurrentUser).OpenSubKey(
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\" + dev + @"\");

            // Windows Apps
            string[] subs = basekey.GetSubKeyNames();
            foreach (string sub in subs)
            {
                if (sub == "NonPackaged")
                    continue;

                long? lastUsedTimeStop = (long?)basekey.OpenSubKey(sub).GetValue("LastUsedTimeStop");
                if (lastUsedTimeStop != null)
                {
                    bool inUse = (long)lastUsedTimeStop == 0;
                    Console.ForegroundColor = inUse ? ConsoleColor.Red : ConsoleColor.Gray;
                    Console.WriteLine(inUse.ToString() + "\t" + sub);
                }
            }

            // "NonPackaged" Apps
            string[] subsNonPackaged = basekey.OpenSubKey("NonPackaged").GetSubKeyNames();
            foreach (string sub in subsNonPackaged)
            {
                long? lastUsedTimeStop = (long?)basekey.OpenSubKey("NonPackaged").OpenSubKey(sub).GetValue("LastUsedTimeStop");
                if (lastUsedTimeStop != null)
                {
                    bool inUse = (long)lastUsedTimeStop == 0;
                    string path = sub.Replace('#', '\\');
                    string file = System.IO.Path.GetFileName(path);
                    Console.ForegroundColor = inUse ? ConsoleColor.Red : ConsoleColor.Gray;
                    Console.WriteLine(inUse.ToString() + "\t" + file);
                }
            }
            ;
        }

        static RegistryKey GetRegistryHive(RegistryHive Hive)
        {
            return RegistryKey.OpenBaseKey(Hive, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
        }


        private static void Rm_Changed(object sender, RegistryChangeEventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Microphone:");
            ListUsage(DeviceType.Microhpone);
            Console.WriteLine("Webcam:");
            ListUsage(DeviceType.Webcam);
        }

    }
}
