using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

public static class RegistrySettings
{
    private static string subkey = "Software\\datenpirat\\BusyBlinkenlichten\\";

    public static bool IsFirstStart
    {
        get
        {
            var isFirstStart = GetValue("IsFirstStart");
            return (isFirstStart == null || isFirstStart == "true");
        }
    }

    public static bool SetValue(string name, string value)
    {
        try
        {
            Registry.CurrentUser.CreateSubKey(subkey);
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey(subkey, true);
            regKey.SetValue(name, value, RegistryValueKind.String);
            regKey.Flush();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool SetValue(string name, bool value)
    {
        return SetValue(name, value.ToString());
    }

    public static string GetValue(string name)
    {
        RegistryKey regKey = Registry.CurrentUser.OpenSubKey(subkey, true);
        try
        {
            object result = regKey.GetValue(name);
            return (string)result;
        }
        catch
        {
            return null;
        }
    }

    public static bool GetValueBool(string name)
    {
        return (GetValue(name)?.ToLower() == "true" ? true : false);
    }

    public static bool InitValue(string name, string value)
    {
        if (GetValue(name) == null)
            return SetValue(name, value);
        return true;
    }
}

