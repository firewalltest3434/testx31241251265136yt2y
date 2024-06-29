using System;

// Token: 0x0200027C RID: 636
public static class GClass73
{
	// Token: 0x06000EC0 RID: 3776 RVA: 0x0003F9E0 File Offset: 0x0003DBE0
	public static Uri smethod_0(GEnum97 genum97_0)
	{
		switch (genum97_0)
		{
		case (GEnum97)0:
			return GClass20.uri_8;
		case (GEnum97)1:
			return GClass20.uri_9;
		case (GEnum97)2:
			return GClass20.uri_10;
		case (GEnum97)3:
			return GClass20.uri_11;
		case (GEnum97)4:
			return GClass20.uri_12;
		case (GEnum97)5:
			return GClass20.uri_13;
		case (GEnum97)6:
			return GClass20.uri_14;
		default:
			return GClass20.uri_8;
		}
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x0003FA40 File Offset: 0x0003DC40
	public static Uri smethod_1(GEnum97 genum97_0)
	{
		if (genum97_0 == (GEnum97)0)
		{
			return GClass20.uri_15;
		}
		if (genum97_0 != (GEnum97)1)
		{
			return GClass20.uri_15;
		}
		return GClass20.uri_16;
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x0003FA64 File Offset: 0x0003DC64
	public static string smethod_2(GEnum49 genum49_0)
	{
		switch (genum49_0)
		{
		case GEnum49.Desktop:
			return "Windows.Desktop";
		case GEnum49.Mobile:
			return "Windows.Mobile";
		case GEnum49.Xbox:
			return "Windows.Xbox";
		case GEnum49.ServerCore:
			return "Windows.Server";
		case GEnum49.IotCore:
			return "Windows.Iot";
		case GEnum49.HoloLens:
			return "Windows.Holographic";
		case GEnum49.Andromeda:
			return "Windows.8828080";
		case GEnum49.Universal:
			return "Windows.Universal";
		case GEnum49.WCOS:
			return "Windows.Core";
		default:
			throw new GException4("Undefined DeviceFamily " + genum49_0.ToString());
		}
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x0003FAF8 File Offset: 0x0003DCF8
	public static GEnum29 smethod_3(string string_0)
	{
		if (string_0 == "XAP")
		{
			return (GEnum29)1;
		}
		if (string_0 == "AppX")
		{
			return (GEnum29)2;
		}
		if (!(string_0 == "UAP"))
		{
			return (GEnum29)3;
		}
		return (GEnum29)0;
	}
}
