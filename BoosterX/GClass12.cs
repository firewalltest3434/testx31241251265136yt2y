using System;
using System.Text;

// Token: 0x02000102 RID: 258
public sealed class GClass12
{
	// Token: 0x06000774 RID: 1908 RVA: 0x0002436C File Offset: 0x0002256C
	static GClass12()
	{
		GClass12.gclass10_0 = new GClass10(GClass12.gclass42_0, GClass12.gclass8_0);
		GClass12.gclass11_0 = new GClass11(GClass12.gclass42_0, GClass12.gclass8_0);
		GClass12.gclass9_0 = new GClass9(GClass12.gclass42_0, GClass12.gclass11_0, GClass12.gclass10_0, GClass12.gclass8_0);
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00024400 File Offset: 0x00022600
	private static GClass143 smethod_0()
	{
		return GClass143.smethod_0(Encoding.Default.GetString(Class603.smethod_3()));
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00024418 File Offset: 0x00022618
	private static GClass143 smethod_1()
	{
		return null;
	}

	// Token: 0x040003DB RID: 987
	private static readonly GClass143 gclass143_0 = GClass12.smethod_0();

	// Token: 0x040003DC RID: 988
	public static readonly GClass143 gclass143_1 = GClass12.smethod_1();

	// Token: 0x040003DD RID: 989
	public static readonly GClass42 gclass42_0 = new GClass42(GClass12.gclass143_0, GClass12.gclass143_1);

	// Token: 0x040003DE RID: 990
	public static readonly GClass11 gclass11_0;

	// Token: 0x040003DF RID: 991
	public static readonly GClass9 gclass9_0;

	// Token: 0x040003E0 RID: 992
	public static readonly GClass10 gclass10_0;

	// Token: 0x040003E1 RID: 993
	public static readonly GClass8 gclass8_0 = new GClass8(GClass12.gclass42_0);
}
