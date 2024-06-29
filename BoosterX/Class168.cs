using System;
using Microsoft.Win32;

// Token: 0x02000134 RID: 308
internal sealed class Class168
{
	// Token: 0x06000804 RID: 2052 RVA: 0x00026C24 File Offset: 0x00024E24
	public static string smethod_0(string string_0, string string_1)
	{
		string text = string_0.Split(new char[]
		{
			'\\'
		})[0].ToLower();
		RegistryKey registryKey = Class168.smethod_1(text);
		string name = string_0.ToLower().Replace(text + "\\", string.Empty);
		string result;
		try
		{
			result = registryKey.OpenSubKey(name).GetValue((string_1 == "/ve") ? string.Empty : string_1).ToString();
		}
		catch
		{
			result = "Null";
		}
		return result;
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00026CB0 File Offset: 0x00024EB0
	private static RegistryKey smethod_1(string string_0)
	{
		if (string_0 == "hklm")
		{
			return Registry.LocalMachine;
		}
		if (string_0 == "hkey_local_machine")
		{
			return Registry.LocalMachine;
		}
		if (string_0 == "hkcu")
		{
			return Registry.CurrentUser;
		}
		if (string_0 == "hkey_current_user")
		{
			return Registry.CurrentUser;
		}
		if (string_0 == "hkcr")
		{
			return Registry.ClassesRoot;
		}
		if (!(string_0 == "hkey_classes_root"))
		{
			return Registry.LocalMachine;
		}
		return Registry.ClassesRoot;
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00026D34 File Offset: 0x00024F34
	public static bool smethod_2(string string_0, string string_1)
	{
		string text = string_0.Split(new char[]
		{
			'\\'
		})[0].ToLower();
		RegistryKey registryKey = Class168.smethod_1(text);
		string name = string_0.ToLower().Replace(text + "\\", string.Empty);
		bool result;
		try
		{
			registryKey.OpenSubKey(name).GetValue((string_1 == "/ve") ? string.Empty : string_1).ToString();
			result = true;
		}
		catch
		{
			result = false;
		}
		return result;
	}
}
