using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ElevRightsX;
using Microsoft.Win32;

// Token: 0x02000129 RID: 297
internal sealed class Class164
{
	// Token: 0x060007E4 RID: 2020 RVA: 0x00026474 File Offset: 0x00024674
	public static void smethod_0()
	{
		string text = "C:\\Windows\\System32\\IntegratedServicesRegionPolicySet.json";
		TrustedBypass.TrustedCrack("cmd /c del \"" + text + "\"", false);
		Class650.smethod_4("BoosterX", Class186.string_4, "Resources.EmbedRes.Tweaks.Debloat", "edge.json", false);
		TrustedBypass.TrustedCrack(string.Concat(new string[]
		{
			"cmd /c move \"",
			Path.Combine(Class186.string_4, "edge.json"),
			"\" \"",
			text,
			"\""
		}), false);
		Class185.smethod_22("taskkill /F /IM msedge.exe");
		Class185.smethod_22("taskkill /F /IM MicrosoftEdgeUpdate.exe");
		Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Microsoft Edge\" /v \"NoRemove\" /t REG_DWORD /d 0 /f");
		Class185.smethod_22("reg delete \"HKLM\\SOFTWARE\\WOW6432Node\\Microsoft\\EdgeUpdate\\ClientState\\{56EB18F8-B008-4CBD-B6D2-8C97FE7E9062}\" /v \"experiment_control_labels\" /f");
		Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\WOW6432Node\\Microsoft\\EdgeUpdateDev\" /v \"AllowUninstall\" /t REG_DWORD /d 1 /f");
		List<string> list = new List<string>();
		try
		{
			list.AddRange(Directory.GetDirectories("C:\\Program Files (x86)\\Microsoft\\Edge\\Application").ToList<string>().Where(new Func<string, bool>(Class164.Class165.class165_0.method_0)).ToList<string>());
			foreach (string str in list)
			{
				Class185.smethod_22("\"" + str + "\\Installer\\setup.exe\" --uninstall --force-uninstall --msedge --system-level --verbose-logging");
				Class185.smethod_22("\"" + str + "\\Installer\\setup.exe\" --uninstall --force-uninstall --msedge --system-level --verbose-logging");
				Class185.smethod_23("Get-AppxPackage *MicrosoftEdge* | Remove-AppxPackage");
			}
		}
		catch (Exception exception_)
		{
			GClass141.smethod_0(exception_);
		}
		if (list != null || list.Count > 0)
		{
			list.Clear();
		}
		try
		{
			list.AddRange(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages").GetSubKeyNames().ToList<string>().Where(new Func<string, bool>(Class164.Class165.class165_0.method_1)).ToList<string>());
			foreach (string text2 in list)
			{
				Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages\\" + text2 + "\" /v Visibility /t REG_DWORD /d 1 /f");
				Class185.smethod_22("reg delete \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages\\" + text2 + "\\Owners\" /va /f");
				Class491.smethod_5(text2);
				Class185.smethod_23("Get-AppxPackage *MicrosoftEdge* | Remove-AppxPackage");
			}
		}
		catch (object obj)
		{
		}
		if (list != null || list.Count > 0)
		{
			list.Clear();
		}
		try
		{
			list.AddRange(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages").GetSubKeyNames().ToList<string>().Where(new Func<string, bool>(Class164.Class165.class165_0.method_2)).ToList<string>());
			foreach (string text3 in list)
			{
				Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages\\" + text3 + "\" /v Visibility /t REG_DWORD /d 1 /f");
				Class185.smethod_22("reg delete \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages\\" + text3 + "\\Owners\" /va /f");
				Class491.smethod_5(text3);
				Class185.smethod_23("Get-AppxPackage *edge* | Remove-AppxPackage");
			}
		}
		catch (object obj2)
		{
		}
		Class185.smethod_22("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\EdgeUpdate\" /v \"DoNotUpdateToEdgeWithChromium\" /t REG_DWORD /d 1 /f");
	}

	// Token: 0x0200012A RID: 298
	[Serializable]
	private sealed class Class165
	{
		// Token: 0x060007E7 RID: 2023 RVA: 0x00026814 File Offset: 0x00024A14
		internal bool method_0(string string_0)
		{
			return string_0 != "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\SetupMetrics";
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00026824 File Offset: 0x00024A24
		internal bool method_1(string string_0)
		{
			return string_0.StartsWith("Microsoft-Windows-Internet-Browser-Package");
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00026834 File Offset: 0x00024A34
		internal bool method_2(string string_0)
		{
			return string_0.StartsWith("Microsoft-Windows-MicrosoftEdgeDevToolsClient-Package");
		}

		// Token: 0x04000444 RID: 1092
		public static readonly Class164.Class165 class165_0 = new Class164.Class165();

		// Token: 0x04000445 RID: 1093
		public static Func<string, bool> func_0;

		// Token: 0x04000446 RID: 1094
		public static Func<string, bool> func_1;

		// Token: 0x04000447 RID: 1095
		public static Func<string, bool> func_2;
	}
}
