using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using Microsoft.Win32;
using ns0;

// Token: 0x020003DE RID: 990
internal sealed class Class453
{
	// Token: 0x060015BE RID: 5566 RVA: 0x0005B058 File Offset: 0x00059258
	public static bool smethod_0(GClass179 gclass179_0)
	{
		if (gclass179_0.List_1.Count == 0)
		{
			return true;
		}
		bool? flag;
		if (gclass179_0.List_1.Contains("EXPERIMENTAL"))
		{
			flag = Class389.class504_0.method_52();
			return (flag.GetValueOrDefault() & flag != null) && Class585.struct13_0.method_0();
		}
		flag = Class389.class504_0.method_54();
		return ((flag.GetValueOrDefault() & flag != null) && Class585.struct13_0.method_0()) || ((!gclass179_0.List_1.Contains("AMD") || !((dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_3 != null) ? (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_3).Value : (0 == 0))) && (!gclass179_0.List_1.Contains("22H2+") || (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_5 != null && !dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_5.Value)) && (!gclass179_0.List_1.Contains("21H2-") || !((dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_5 != null) ? (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_5.Value) : (1 == 0))) && (!gclass179_0.List_1.Contains("W11") || (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_0 == null || !dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_0.Value)) && (!gclass179_0.List_1.Contains("W10") || (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_1 != null && !dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_1.Value)) && (!gclass179_0.List_1.Contains("LAPTOP") || (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_2 == null || !dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_2.Value)) && (!gclass179_0.List_1.Contains("PC") || !((dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_2 != null) ? (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_2.Value) : (0 == 0))) && (!gclass179_0.List_1.Contains("HDD") || !((dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_4 != null) ? (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_4.Value) : (GClass159.smethod_1("C", (GEnum40)0, true).method_16() != (GEnum53)2))));
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x0005B2A8 File Offset: 0x000594A8
	public static bool smethod_1(List<string> list_0)
	{
		return (!list_0.Contains("AMD") || !((dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_3 != null) ? (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_3).Value : (0 == 0))) && (!list_0.Contains("22H2+") || (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_5 != null && !dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_5.Value)) && (!list_0.Contains("21H2-") || !((dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_5 != null) ? (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_5.Value) : (1 == 0))) && (!list_0.Contains("W11") || (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_0 == null || !dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_0.Value)) && (!list_0.Contains("W10") || (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_1 != null && !dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_1.Value)) && (!list_0.Contains("LAPTOP") || (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_2 == null || !dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_2.Value)) && (!list_0.Contains("HDD") || !((dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_4 != null) ? (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_4.Value) : (GClass159.smethod_1("C", (GEnum40)0, true).method_16() != (GEnum53)2)));
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x0005B428 File Offset: 0x00059628
	public static string smethod_2(GClass179 gclass179_0, bool bool_0)
	{
		string result = "BEST";
		foreach (GClass67 gclass in gclass179_0.List_4)
		{
			try
			{
				if (gclass.String_0 == "REG" || gclass.String_0 == "REG_SZ" || gclass.String_0 == "REG_BINARY" || gclass.String_0 == "REG_EXPAND_SZ")
				{
					string text = Class168.smethod_0(gclass.Path, gclass.Key);
					if (bool_0 && text == "Null")
					{
						if (!gclass.Values.Any(new Func<GClass72, bool>(Class453.Class454.class454_0.method_0)))
						{
							result = "DEFAULT";
						}
					}
					bool flag = false;
					if (gclass179_0.Type == "CUSTOM_VALUE" && text.smethod_4())
					{
						try
						{
							text = Convert.ToString(Convert.ToInt32(text), 16);
						}
						catch (object obj)
						{
						}
					}
					foreach (GClass72 gclass2 in gclass.Values)
					{
						if (gclass2.String_0.ToLower() == text.ToLower())
						{
							flag = true;
							if (gclass2.List_0.Contains("DEFAULT"))
							{
								result = "DEFAULT";
								break;
							}
							if (gclass2.List_0.Contains("OPTIMAL") && !gclass2.List_0.Contains("ON") && !gclass2.List_0.Contains("OFF") && !gclass2.List_0.Contains("BEST"))
							{
								result = "OPTIMAL";
							}
						}
					}
					if (!flag && gclass179_0.Type == "CUSTOM_VALUE")
					{
						result = "CUSTOM";
					}
				}
				if (gclass.String_0 == "BCDEDIT")
				{
					string text2 = Class375.smethod_0(gclass.Path);
					foreach (GClass72 gclass3 in gclass.Values)
					{
						if (gclass3.String_0.ToLower() == text2.ToLower() && gclass3.List_0.Contains("DEFAULT"))
						{
							result = "DEFAULT";
							break;
						}
					}
				}
				if (gclass.String_0 == "DEVICE")
				{
					result = (Class137.smethod_0().method_1(gclass.Path) ? "DEFAULT" : "BEST");
				}
				if (gclass.String_0 == "TASK")
				{
					result = (Class210.smethod_0().method_0(gclass.Path) ? "DEFAULT" : "BEST");
				}
				if (gclass.String_0 == "WEVTUTIL")
				{
					result = (Class417.smethod_2(gclass.Path) ? "DEFAULT" : "BEST");
				}
				if (gclass.String_0 == "DISM")
				{
					result = (Class491.smethod_6(gclass.Path) ? "DEFAULT" : "BEST");
				}
			}
			catch
			{
				result = "DEFAULT";
			}
		}
		return result;
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x0005B860 File Offset: 0x00059A60
	public static string smethod_3(GClass179 gclass179_0)
	{
		string value = string.Empty;
		foreach (GClass67 gclass in gclass179_0.List_4)
		{
			value = Class168.smethod_0(gclass.Path, gclass.Key);
		}
		string text;
		try
		{
			text = Convert.ToString(Convert.ToInt32(value), 16);
		}
		catch
		{
			text = "0";
		}
		if (text.Length < 8)
		{
			text = text.PadLeft(8, '0');
		}
		return text;
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x0005B900 File Offset: 0x00059B00
	public static string smethod_4(string string_0)
	{
		if (string_0 != null)
		{
			int length = string_0.Length;
			switch (length)
			{
			case 4:
				if (string_0 == "HPET")
				{
					return "DEFAULT";
				}
				break;
			case 5:
			case 6:
				break;
			case 7:
			{
				char c = string_0[1];
				if (c != 'V')
				{
					if (c == 'Y')
					{
						if (string_0 == "SYSMAIN")
						{
							return "BEST";
						}
					}
				}
				else if (string_0 == "SVCHOST")
				{
					return "BEST";
				}
				break;
			}
			case 8:
			{
				char c = string_0[0];
				if (c != 'D')
				{
					if (c == 'W')
					{
						if (string_0 == "WUPDATES")
						{
							return "DEFAULT";
						}
					}
				}
				else if (string_0 == "DEFENDER")
				{
					return "BEST";
				}
				break;
			}
			default:
				if (length != 11)
				{
					if (length == 15)
					{
						char c = string_0[0];
						if (c != 'D')
						{
							if (c != 'O')
							{
								if (c == 'R')
								{
									if (string_0 == "RESERVEDSTORAGE")
									{
										return "BEST";
									}
								}
							}
							else if (string_0 == "ONEDRIVEDEBLOAT")
							{
								return "BEST";
							}
						}
						else if (string_0 == "DEFENDERDEBLOAT")
						{
							return "BEST";
						}
					}
				}
				else if (string_0 == "EDGEDEBLOAT")
				{
					return "DEFAULT";
				}
				break;
			}
		}
		return "DEFAULT";
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x0005BA80 File Offset: 0x00059C80
	private static string smethod_5()
	{
		try
		{
			if (Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\SysMain").GetValue("Start").ToString() == "4")
			{
				return "BEST";
			}
			if (Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters").GetValue("EnableSuperfetch").ToString() == "2")
			{
				return "OPTIMAL";
			}
		}
		catch (object obj)
		{
		}
		return "DEFAULT";
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x0005BB10 File Offset: 0x00059D10
	private static string smethod_6()
	{
		if (!Directory.Exists("C:\\Program Files (x86)\\Microsoft\\Edge"))
		{
			return "BEST";
		}
		if ((double)Class650.smethod_12(new List<string>
		{
			"C:\\Program Files (x86)\\Microsoft\\Edge"
		}, "*", true) / 1048576.0 > 10.0)
		{
			return "DEFAULT";
		}
		return "BEST";
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x0005BB6C File Offset: 0x00059D6C
	public static string smethod_7()
	{
		Directory.GetDirectories("C:\\Windows\\SystemApps\\").Any(new Func<string, bool>(Class453.Class454.class454_0.method_1));
		if (!Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services").GetSubKeyNames().Any(new Func<string, bool>(Class453.Class454.class454_0.method_2)))
		{
			return "BEST";
		}
		return "DEFAULT";
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x0005BBF8 File Offset: 0x00059DF8
	private static string smethod_8()
	{
		foreach (RegistryKey registryKey in new List<RegistryKey>
		{
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall"),
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall")
		})
		{
			try
			{
				string[] subKeyNames = registryKey.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Length; i++)
				{
					if (subKeyNames[i] == "OneDriveSetup.exe")
					{
						return "DEFAULT";
					}
				}
			}
			catch (object obj)
			{
			}
		}
		return "BEST";
	}

	// Token: 0x060015C7 RID: 5575 RVA: 0x0005BCD4 File Offset: 0x00059ED4
	private static string smethod_9()
	{
		string text = string.Empty;
		Process process = new Process();
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.FileName = "DISM.exe";
		process.StartInfo.Arguments = "/English /Online /Get-ReservedStorageState";
		process.Start();
		text = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		if (!text.ToLower().Contains("enabled"))
		{
			return "BEST";
		}
		return "DEFAULT";
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x0005BD74 File Offset: 0x00059F74
	public static string smethod_10(string string_0)
	{
		ServiceController[] services = ServiceController.GetServices();
		string result;
		try
		{
			Class453.registryKey_0 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + string_0);
			ServiceController[] array = services;
			int i = 0;
			while (i < array.Length)
			{
				ServiceController serviceController = array[i];
				if (!(serviceController.ServiceName.ToLower() == string_0.ToLower()))
				{
					i++;
				}
				else
				{
					if (Class453.registryKey_0.GetValue("Start").ToString() == "4")
					{
						return "BEST";
					}
					if (serviceController.Status.ToString() != "Running" && Class453.registryKey_0.GetValue("Start").ToString() == "3")
					{
						return "BEST";
					}
					return "DEFAULT";
				}
			}
			result = "BEST";
		}
		catch
		{
			result = "BEST";
		}
		return result;
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x0005BE90 File Offset: 0x0005A090
	public static string smethod_11(string string_0)
	{
		ServiceController[] services = ServiceController.GetServices();
		string result;
		try
		{
			Class453.registryKey_0 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + string_0);
			ServiceController[] array = services;
			int i = 0;
			while (i < array.Length)
			{
				if (!(array[i].ServiceName.ToLower() == string_0.ToLower()))
				{
					i++;
				}
				else
				{
					if (Class453.registryKey_0.GetValue("Start").ToString() == "4")
					{
						return "BEST";
					}
					return "DEFAULT";
				}
			}
			result = "BEST";
		}
		catch
		{
			result = "BEST";
		}
		return result;
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x0005BF54 File Offset: 0x0005A154
	public static string smethod_12()
	{
		string text = string.Empty;
		Process process = new Process();
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.FileName = "bcdedit.exe";
		process.StartInfo.Arguments = "/enum {current} /v";
		process.Start();
		text = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		bool flag;
		if (!flag)
		{
			return "DEFAULT";
		}
		return "BEST";
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x0005BFE8 File Offset: 0x0005A1E8
	public static string smethod_13()
	{
		string result;
		try
		{
			result = ((Convert.ToInt32(Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Control").GetValue("SvcHostSplitThresholdInKB")) == 3670016) ? "DEFAULT" : "BEST");
		}
		catch
		{
			result = "DEFAULT";
		}
		return result;
	}

	// Token: 0x04000DCE RID: 3534
	private static RegistryKey registryKey_0;

	// Token: 0x020003DF RID: 991
	[Serializable]
	private sealed class Class454
	{
		// Token: 0x060015CE RID: 5582 RVA: 0x0005C068 File Offset: 0x0005A268
		internal bool method_0(GClass72 gclass72_0)
		{
			return gclass72_0.String_0 == "Null";
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0005C07C File Offset: 0x0005A27C
		internal bool method_1(string string_0)
		{
			return string_0.StartsWith("Microsoft.Windows.SecHealthUI", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0005C08C File Offset: 0x0005A28C
		internal bool method_2(string string_0)
		{
			return string_0 == "WinDefend";
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0005C09C File Offset: 0x0005A29C
		internal bool method_3(string string_0)
		{
			return string_0.Contains("disabledynamictick") && string_0.Contains("Yes");
		}

		// Token: 0x04000DCF RID: 3535
		public static readonly Class453.Class454 class454_0 = new Class453.Class454();

		// Token: 0x04000DD0 RID: 3536
		public static Func<GClass72, bool> func_0;

		// Token: 0x04000DD1 RID: 3537
		public static Func<string, bool> func_1;

		// Token: 0x04000DD2 RID: 3538
		public static Func<string, bool> func_2;

		// Token: 0x04000DD3 RID: 3539
		public static Func<string, bool> func_3;
	}
}
