using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Token: 0x02000466 RID: 1126
internal sealed class Class530
{
	// Token: 0x060018FA RID: 6394 RVA: 0x00067064 File Offset: 0x00065264
	internal static void smethod_0()
	{
		Class650.smethod_4("BoosterX", Class186.string_4, "Resources.EmbedRes.Tweaks.Defender", "disable.bat", false);
		GClass104.smethod_0("cmd.exe /c " + Path.Combine(Class186.string_4, "disable.bat"), false);
		File.Delete(Path.Combine(Class186.string_4, "disable.bat"));
		foreach (string str in Class530.hashSet_0)
		{
			Class185.smethod_22("taskkill.exe /f /im \"" + str + "\"");
			GClass104.smethod_0("cmd.exe /c taskkill.exe /f /im \"" + str + "\"", false);
		}
		IEnumerable<string> source = Directory.GetDirectories("C:\\Program Files\\WindowsApps").Where(new Func<string, bool>(Class530.Class531.class531_0.method_0));
		if (source.Count<string>() > 0)
		{
			source.ToList<string>().ForEach(new Action<string>(Class530.Class531.class531_0.method_1));
		}
		string text = Path.Combine(Class186.string_4, "RemoveDefenderRegs.bat");
		Class650.smethod_4("BoosterX", Class186.string_4, "Resources.EmbedRes.Tweaks.Defender", "RemoveDefenderRegs.bat", false);
		GClass104.smethod_0("cmd.exe /c \"" + text + "\"", false);
		File.Delete(text);
		foreach (string str2 in Class530.hashSet_3)
		{
			GClass104.smethod_0("cmd.exe /c del /f /q \"" + str2 + "\"", false);
		}
		foreach (string searchPattern in Class530.hashSet_4)
		{
			Directory.GetFiles("C:\\Windows\\WinSxS\\FileMaps", searchPattern).ToList<string>().ForEach(new Action<string>(Class530.Class531.class531_0.method_2));
		}
		foreach (string str3 in Class530.hashSet_2)
		{
			GClass104.smethod_0("cmd.exe /c rmdir /s /q \"" + str3 + "\"", false);
		}
		foreach (string path in Class530.hashSet_1)
		{
			try
			{
				IEnumerable<string> source2 = Directory.GetDirectories(path).Where(new Func<string, bool>(Class530.Class531.class531_0.method_3));
				if (source2.Count<string>() > 0)
				{
					source2.ToList<string>().ForEach(new Action<string>(Class530.Class531.class531_0.method_4));
				}
			}
			catch (object obj)
			{
			}
		}
		Class185.smethod_22("start %windir%\\explorer.exe");
	}

	// Token: 0x060018FB RID: 6395 RVA: 0x000673A8 File Offset: 0x000655A8
	internal static void smethod_1()
	{
		throw new NotImplementedException();
	}

	// Token: 0x04001160 RID: 4448
	private static HashSet<string> hashSet_0 = new HashSet<string>
	{
		"explorer.exe",
		"CompatTelRunner.exe",
		"DWWIN.exe",
		"DeviceCensus.exe",
		"GameBarPresenceWriter.exe",
		"SecurityHealthHost.exe",
		"SecurityHealthService.exe",
		"SecurityHealthSystray.exe",
		"smartscreen.exe",
		"MsMpEng.exe"
	};

	// Token: 0x04001161 RID: 4449
	private static HashSet<string> hashSet_1 = new HashSet<string>
	{
		"C:\\Windows\\WinSxS\\amd64_security-octagon*",
		"C:\\Windows\\WinSxS\\amd64_windows-defender*",
		"C:\\Windows\\WinSxS\\wow64_windows-defender*",
		"C:\\Windows\\WinSxS\\x86_windows-defender*",
		"C:\\Windows\\SystemApps\\Microsoft.Windows.SecHealthUI*"
	};

	// Token: 0x04001162 RID: 4450
	private static HashSet<string> hashSet_2 = new HashSet<string>
	{
		"C:\\Program Files (x86)\\Windows Defender",
		"C:\\Program Files (x86)\\Windows Defender Advanced Threat Protection",
		"C:\\Program Files\\Windows Defender",
		"C:\\Program Files\\Windows Defender Advanced Threat Protection",
		"C:\\ProgramData\\Microsoft\\Storage Health",
		"C:\\ProgramData\\Microsoft\\Windows Defender",
		"C:\\ProgramData\\Microsoft\\Windows Defender Advanced Threat Protection",
		"C:\\ProgramData\\Microsoft\\Windows Security Health",
		"C:\\WINDOWS\\System32\\drivers\\wd",
		"C:\\Windows\\Containers\\WindowsDefenderApplicationGuard.wim",
		"C:\\Windows\\Containers\\serviced\\WindowsDefenderApplicationGuard.wim",
		"C:\\Windows\\GameBarPresenceWriter",
		"C:\\Windows\\SysWOW64\\WindowsPowerShell\\v1.0\\Modules\\Defender",
		"C:\\Windows\\SysWOW64\\WindowsPowerShell\\v1.0\\Modules\\DefenderPerformance",
		"C:\\Windows\\System32\\HealthAttestationClient",
		"C:\\Windows\\System32\\SecurityHealth",
		"C:\\Windows\\System32\\Sgrm",
		"C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Windows Defender",
		"C:\\Windows\\System32\\Tasks_Migrated\\Microsoft\\Windows\\Windows Defender",
		"C:\\Windows\\System32\\WebThreatDefSvc",
		"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\Modules\\Defender",
		"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\Modules\\DefenderPerformance",
		"C:\\Windows\\SystemApps\\Microsoft.Windows.AppRep.ChxApp_cw5n1h2txyewy",
		"C:\\Windows\\bcastdvr"
	};

	// Token: 0x04001163 RID: 4451
	private static HashSet<string> hashSet_3 = new HashSet<string>
	{
		"C:\\Windows\\SysWOW64\\CompatTelRunner.exe",
		"C:\\Windows\\SysWOW64\\DeviceCensus.exe",
		"C:\\Windows\\SysWOW64\\GameBarPresenceWriter.exe",
		"C:\\Windows\\SysWOW64\\smartscreen.dll",
		"C:\\Windows\\SysWOW64\\smartscreen.exe",
		"C:\\Windows\\SysWOW64\\smartscreenps.dll",
		"C:\\Windows\\System32\\DWWIN.exe",
		"C:\\Windows\\System32\\GameBarPresenceWriter.exe",
		"C:\\Windows\\System32\\SecurityAndMaintenance.png",
		"C:\\Windows\\System32\\SecurityAndMaintenance_Error.png",
		"C:\\Windows\\System32\\SecurityHealthAgent.dll",
		"C:\\Windows\\System32\\SecurityHealthCore.dll",
		"C:\\Windows\\System32\\SecurityHealthHost.exe",
		"C:\\Windows\\System32\\SecurityHealthProxyStub.dll",
		"C:\\Windows\\System32\\SecurityHealthService.exe",
		"C:\\Windows\\System32\\SecurityHealthSsoUdk.dll",
		"C:\\Windows\\System32\\SecurityHealthSystray.exe",
		"C:\\Windows\\System32\\SecurityHealthUdk.dll",
		"C:\\Windows\\System32\\drivers\\SgrmAgent.sys",
		"C:\\Windows\\System32\\drivers\\WdBoot.sys",
		"C:\\Windows\\System32\\drivers\\WdDevFlt.sys",
		"C:\\Windows\\System32\\drivers\\WdFilter.sys",
		"C:\\Windows\\System32\\drivers\\WdNisDrv.sys",
		"C:\\Windows\\System32\\smartscreen.dll",
		"C:\\Windows\\System32\\smartscreen.exe",
		"C:\\Windows\\System32\\smartscreenps.dll",
		"C:\\Windows\\System32\\wscadminui.exe",
		"C:\\Windows\\System32\\wscapi.dll",
		"C:\\Windows\\System32\\wscisvif.dll",
		"C:\\Windows\\System32\\wscproxystub.dll",
		"C:\\Windows\\System32\\wscsvc.dll",
		"C:\\Windows\\system32\\drivers\\msseccore.sys"
	};

	// Token: 0x04001164 RID: 4452
	private static HashSet<string> hashSet_4 = new HashSet<string>
	{
		"amd64_windows-defender*.manifest",
		"wow64_windows-defender*.manifest",
		"x86_windows-defender*.manifest"
	};

	// Token: 0x02000467 RID: 1127
	[Serializable]
	private sealed class Class531
	{
		// Token: 0x060018FE RID: 6398 RVA: 0x000673C4 File Offset: 0x000655C4
		internal bool method_0(string string_0)
		{
			return string_0.StartsWith("Microsoft.SecHealthUI", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x000673D4 File Offset: 0x000655D4
		internal void method_1(string string_0)
		{
			GClass104.smethod_0("cmd.exe /c rmdir /s /q \"" + string_0 + "\"", false);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000673F0 File Offset: 0x000655F0
		internal void method_2(string string_0)
		{
			GClass104.smethod_0("cmd.exe /c del /f /q \"" + string_0 + "\"", false);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0006740C File Offset: 0x0006560C
		internal bool method_3(string string_0)
		{
			return string_0.StartsWith("Microsoft.SecHealthUI", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0006741C File Offset: 0x0006561C
		internal void method_4(string string_0)
		{
			GClass104.smethod_0("cmd.exe /c rmdir /s /q \"" + string_0 + "\"", false);
		}

		// Token: 0x04001165 RID: 4453
		public static readonly Class530.Class531 class531_0 = new Class530.Class531();

		// Token: 0x04001166 RID: 4454
		public static Func<string, bool> func_0;

		// Token: 0x04001167 RID: 4455
		public static Action<string> action_0;

		// Token: 0x04001168 RID: 4456
		public static Action<string> action_1;

		// Token: 0x04001169 RID: 4457
		public static Func<string, bool> func_1;

		// Token: 0x0400116A RID: 4458
		public static Action<string> action_2;
	}
}
