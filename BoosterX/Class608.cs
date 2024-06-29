using System;
using System.Management;
using Microsoft.Win32;

// Token: 0x02000537 RID: 1335
internal sealed class Class608
{
	// Token: 0x06001D2B RID: 7467 RVA: 0x0007A168 File Offset: 0x00078368
	public static void smethod_0(string string_0, string string_1)
	{
		if (string_0 == "SVCHOSTTWEAK")
		{
			Class608.smethod_3(string_1);
			return;
		}
		if (string_0 == "DEBLOATEDGE")
		{
			Class164.smethod_0();
			return;
		}
		if (string_0 == "DEFENDERDEBLOAT")
		{
			Class530.smethod_0();
			return;
		}
		if (string_0 == "VISUALTWEAK")
		{
			Class608.smethod_1(string_1);
			return;
		}
		if (!(string_0 == "DEFENDERTWEAK"))
		{
			return;
		}
		Class608.smethod_2(string_1);
	}

	// Token: 0x06001D2C RID: 7468 RVA: 0x0007A1D8 File Offset: 0x000783D8
	private static void smethod_1(string string_0)
	{
		if (string_0 == "BEST")
		{
			Class644.smethod_0(true);
			return;
		}
		if (string_0 == "OPTIMAL")
		{
			Class644.smethod_0(true);
			return;
		}
		Class644.smethod_0(false);
	}

	// Token: 0x06001D2D RID: 7469 RVA: 0x0007A208 File Offset: 0x00078408
	private static void smethod_2(string string_0)
	{
		if (string_0 == "BEST")
		{
			GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender!DisableAntiSpyware", "1", RegistryValueKind.DWord);
			GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableIOAVProtection", "1", RegistryValueKind.DWord);
			GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			Class576.smethod_2("webthreatdefusersvc");
			Class576.smethod_2("webthreatdefsvc");
			return;
		}
		GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender!DisableAntiSpyware", null, RegistryValueKind.DWord);
		GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableRealtimeMonitoring", null, RegistryValueKind.DWord);
		GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableBehaviorMonitoring", null, RegistryValueKind.DWord);
		GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableIOAVProtection", null, RegistryValueKind.DWord);
		GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableOnAccessProtection", null, RegistryValueKind.DWord);
		GClass25.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableScanOnRealtimeEnable", null, RegistryValueKind.DWord);
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x0007A2E4 File Offset: 0x000784E4
	public static void smethod_3(string string_0)
	{
		if (string_0 == "BEST")
		{
			string value = null;
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher
			{
				Query = new ObjectQuery("Select * From Win32_ComputerSystem")
			}.Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				value = string.Format("{0}", Math.Round(Convert.ToDouble(managementObject["TotalPhysicalMemory"]) / 1073741824.0));
				if (!string.IsNullOrWhiteSpace(value))
				{
					break;
				}
			}
			int num = Convert.ToInt32(value);
			string str;
			if (num <= 10)
			{
				str = string.Format("0x0{0}", num * 1024 * 1024);
			}
			else
			{
				str = string.Format("0x{0}", num * 1024 * 1024);
			}
			Class185.smethod_22("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\" /v \"SvcHostSplitThresholdInKB\" /t REG_DWORD /d \"" + str + "\" /f");
			return;
		}
		Class185.smethod_22("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\" /v \"SvcHostSplitThresholdInKB\" /t REG_DWORD /d \"0x00380000\" /f");
	}
}
