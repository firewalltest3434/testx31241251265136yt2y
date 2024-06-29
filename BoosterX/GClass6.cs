using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

// Token: 0x020000E7 RID: 231
public static class GClass6
{
	// Token: 0x060006B8 RID: 1720 RVA: 0x00020750 File Offset: 0x0001E950
	public static string smethod_0()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x0002075C File Offset: 0x0001E95C
	public static bool smethod_1()
	{
		return "Microsoft Windows 10 Pro".Contains("11");
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00020770 File Offset: 0x0001E970
	public static bool smethod_2()
	{
		return "Microsoft Windows 10 Pro".Contains("10");
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00020784 File Offset: 0x0001E984
	public static bool smethod_3()
	{
		string text = "22H2";
		return text.Count<char>() == 4 && Convert.ToInt32(text.Substring(0, 2)) > 21;
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x000207B4 File Offset: 0x0001E9B4
	public static bool smethod_4()
	{
		return SystemInformation.PowerStatus.BatteryChargeStatus != BatteryChargeStatus.NoSystemBattery;
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x000207CC File Offset: 0x0001E9CC
	public static bool smethod_5()
	{
		bool result;
		try
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0"))
			{
				result = registryKey.GetValue("ProcessorNameString").ToString().Contains("Intel(R)");
			}
		}
		catch
		{
			result = true;
		}
		return result;
	}
}
