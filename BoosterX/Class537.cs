using System;
using System.Linq;
using System.Management;
using System.Security.Principal;
using Microsoft.Win32;

// Token: 0x0200047E RID: 1150
internal sealed class Class537
{
	// Token: 0x06001986 RID: 6534 RVA: 0x00068838 File Offset: 0x00066A38
	public static string smethod_0()
	{
		object obj = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>().Select(new Func<ManagementObject, object>(Class537.Class538.class538_0.method_0)).FirstOrDefault<object>();
		if (obj == null)
		{
			return "Unknown";
		}
		return obj.ToString();
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x00068894 File Offset: 0x00066A94
	public static string smethod_1()
	{
		string result;
		try
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion"))
			{
				result = registryKey.GetValue("DisplayVersion").ToString();
			}
		}
		catch
		{
			result = "Unknown";
		}
		return result;
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x000688F4 File Offset: 0x00066AF4
	public static int smethod_2()
	{
		return new ManagementObjectSearcher("Select * from Win32_Processor").Get().Cast<ManagementBaseObject>().Sum(new Func<ManagementBaseObject, int>(Class537.Class538.class538_0.method_1));
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x00068930 File Offset: 0x00066B30
	public static int smethod_3()
	{
		return new ManagementObjectSearcher("Select * from Win32_Processor").Get().Cast<ManagementBaseObject>().Sum(new Func<ManagementBaseObject, int>(Class537.Class538.class538_0.method_2));
	}

	// Token: 0x0600198A RID: 6538 RVA: 0x0006896C File Offset: 0x00066B6C
	public static void smethod_4(string string_1, bool bool_0)
	{
		string text = null;
		try
		{
			text = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer").GetValue("SettingsPageVisibility").ToString();
		}
		catch
		{
			if (bool_0)
			{
				return;
			}
		}
		if (bool_0 && text != null)
		{
			if (!text.EndsWith(";") && !text.EndsWith(":"))
			{
				text += ";";
			}
			string str = text.Replace(string_1 + ";", string.Empty);
			Class185.smethod_22("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v SettingsPageVisibility /t REG_SZ /d " + str + " /f");
			return;
		}
		if (!bool_0 && text != null)
		{
			if (!text.EndsWith(";") && !text.EndsWith(":"))
			{
				text += ";";
			}
			string str = text + string_1 + ";";
			Class185.smethod_22("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v SettingsPageVisibility /t REG_SZ /d " + str + " /f");
			return;
		}
		if (!bool_0 && text == null)
		{
			string str = "hide:" + string_1 + ";";
			Class185.smethod_22("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v SettingsPageVisibility /t REG_SZ /d " + str + " /f");
			return;
		}
	}

	// Token: 0x0600198B RID: 6539 RVA: 0x00068A8C File Offset: 0x00066C8C
	public static string smethod_5()
	{
		if (!Class537.string_0.smethod_7())
		{
			return Class537.string_0;
		}
		Class537.string_0 = WindowsIdentity.GetCurrent().User.Value;
		return Class537.string_0;
	}

	// Token: 0x0600198C RID: 6540 RVA: 0x00068ABC File Offset: 0x00066CBC
	public static bool smethod_6()
	{
		if (Class537.nullable_0 != null)
		{
			return Class537.nullable_0.Value;
		}
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem WHERE BootupState LIKE 'Fail-safe%'");
			try
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					Class537.nullable_0 = new bool?(managementObjectCollection.Count > 0);
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch
		{
			Class537.nullable_0 = new bool?(false);
		}
		return Class537.nullable_0.Value;
	}

	// Token: 0x040011C2 RID: 4546
	public static string string_0 = string.Empty;

	// Token: 0x040011C3 RID: 4547
	private static bool? nullable_0;

	// Token: 0x0200047F RID: 1151
	[Serializable]
	private sealed class Class538
	{
		// Token: 0x0600198F RID: 6543 RVA: 0x00068B84 File Offset: 0x00066D84
		internal object method_0(ManagementObject managementObject_0)
		{
			return managementObject_0.GetPropertyValue("Caption");
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00068B94 File Offset: 0x00066D94
		internal int method_1(ManagementBaseObject managementBaseObject_0)
		{
			return int.Parse(managementBaseObject_0["NumberOfLogicalProcessors"].ToString());
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00068BAC File Offset: 0x00066DAC
		internal int method_2(ManagementBaseObject managementBaseObject_0)
		{
			return int.Parse(managementBaseObject_0["NumberOfCores"].ToString());
		}

		// Token: 0x040011C4 RID: 4548
		public static readonly Class537.Class538 class538_0 = new Class537.Class538();

		// Token: 0x040011C5 RID: 4549
		public static Func<ManagementObject, object> func_0;

		// Token: 0x040011C6 RID: 4550
		public static Func<ManagementBaseObject, int> func_1;

		// Token: 0x040011C7 RID: 4551
		public static Func<ManagementBaseObject, int> func_2;
	}
}
