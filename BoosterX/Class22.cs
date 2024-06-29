using System;
using System.Diagnostics;

// Token: 0x02000023 RID: 35
internal static class Class22
{
	// Token: 0x060000D3 RID: 211 RVA: 0x00004540 File Offset: 0x00002740
	static Class22()
	{
		OperatingSystem osversion = Environment.OSVersion;
		Class22.bool_0 = (osversion.Platform == PlatformID.Win32NT && osversion.Version >= new Version(6, 0));
		try
		{
			Class22.bool_1 = Class22.smethod_2(osversion);
		}
		catch
		{
			Class22.bool_1 = false;
		}
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0000459C File Offset: 0x0000279C
	public static bool smethod_0()
	{
		return Class22.bool_0;
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x000045A4 File Offset: 0x000027A4
	public static bool smethod_1()
	{
		return Class22.bool_1;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x000045AC File Offset: 0x000027AC
	private static bool smethod_2(OperatingSystem operatingSystem_0)
	{
		return operatingSystem_0.Platform != PlatformID.Win32NT || !(operatingSystem_0.Version < new Version(6, 2, 9200)) || Process.GetCurrentProcess().SessionId != 0;
	}

	// Token: 0x0400003A RID: 58
	private static readonly bool bool_0;

	// Token: 0x0400003B RID: 59
	private static readonly bool bool_1;
}
