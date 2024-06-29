using System;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Resources;

// Token: 0x02000516 RID: 1302
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
internal sealed class Class603
{
	// Token: 0x06001C81 RID: 7297 RVA: 0x00074678 File Offset: 0x00072878
	internal Class603()
	{
	}

	// Token: 0x06001C82 RID: 7298 RVA: 0x00074680 File Offset: 0x00072880
	internal static ResourceManager smethod_0()
	{
		if (Class603.resourceManager_0 == null)
		{
			Class603.resourceManager_0 = new ResourceManager("BoosterX.Properties.Resources", typeof(Class603).Assembly);
		}
		return Class603.resourceManager_0;
	}

	// Token: 0x06001C83 RID: 7299 RVA: 0x000746AC File Offset: 0x000728AC
	internal static CultureInfo smethod_1()
	{
		return Class603.cultureInfo_0;
	}

	// Token: 0x06001C84 RID: 7300 RVA: 0x000746B4 File Offset: 0x000728B4
	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		Class603.cultureInfo_0 = cultureInfo_1;
	}

	// Token: 0x06001C85 RID: 7301 RVA: 0x000746BC File Offset: 0x000728BC
	internal static byte[] smethod_3()
	{
		return (byte[])Class603.smethod_0().GetObject("CustomSettingNames", Class603.cultureInfo_0);
	}

	// Token: 0x06001C86 RID: 7302 RVA: 0x000746D8 File Offset: 0x000728D8
	internal static string smethod_4()
	{
		return Class603.smethod_0().GetString("String1", Class603.cultureInfo_0);
	}

	// Token: 0x040013F6 RID: 5110
	private static ResourceManager resourceManager_0;

	// Token: 0x040013F7 RID: 5111
	private static CultureInfo cultureInfo_0;
}
