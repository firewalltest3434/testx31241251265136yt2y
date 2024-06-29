using System;
using System.Drawing;

// Token: 0x02000439 RID: 1081
public sealed class GClass122
{
	// Token: 0x060017D6 RID: 6102 RVA: 0x00064E38 File Offset: 0x00063038
	public GClass122()
	{
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x00064E40 File Offset: 0x00063040
	public GClass122(byte byte_4, byte byte_5, byte byte_6, byte byte_7)
	{
		this.method_1(byte_4);
		this.method_3(byte_5);
		this.method_5(byte_6);
		this.method_7(byte_7);
	}

	// Token: 0x060017D8 RID: 6104 RVA: 0x00064E68 File Offset: 0x00063068
	public byte method_0()
	{
		return this.byte_0;
	}

	// Token: 0x060017D9 RID: 6105 RVA: 0x00064E70 File Offset: 0x00063070
	public void method_1(byte byte_4)
	{
		this.byte_0 = byte_4;
	}

	// Token: 0x060017DA RID: 6106 RVA: 0x00064E7C File Offset: 0x0006307C
	public byte method_2()
	{
		return this.byte_1;
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x00064E84 File Offset: 0x00063084
	public void method_3(byte byte_4)
	{
		this.byte_1 = byte_4;
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x00064E90 File Offset: 0x00063090
	public byte method_4()
	{
		return this.byte_2;
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x00064E98 File Offset: 0x00063098
	public void method_5(byte byte_4)
	{
		this.byte_2 = byte_4;
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x00064EA4 File Offset: 0x000630A4
	public byte method_6()
	{
		return this.byte_3;
	}

	// Token: 0x060017DF RID: 6111 RVA: 0x00064EAC File Offset: 0x000630AC
	public void method_7(byte byte_4)
	{
		this.byte_3 = byte_4;
	}

	// Token: 0x060017E0 RID: 6112 RVA: 0x00064EB8 File Offset: 0x000630B8
	public static string smethod_0(GClass122 gclass122_0)
	{
		return Color.FromArgb((int)gclass122_0.method_0(), (int)gclass122_0.method_2(), (int)gclass122_0.method_4(), (int)gclass122_0.method_6()).ToArgb().ToString("X8");
	}

	// Token: 0x060017E1 RID: 6113 RVA: 0x00064EF8 File Offset: 0x000630F8
	public static GClass122 smethod_1(string string_0)
	{
		Color color = ColorTranslator.FromHtml(string_0);
		GClass122 gclass = new GClass122();
		gclass.method_1(color.A);
		gclass.method_3(color.R);
		gclass.method_5(color.G);
		gclass.method_7(color.B);
		return gclass;
	}

	// Token: 0x060017E2 RID: 6114 RVA: 0x00064F48 File Offset: 0x00063148
	public string method_8()
	{
		return GClass122.smethod_0(this);
	}

	// Token: 0x040010E3 RID: 4323
	private byte byte_0;

	// Token: 0x040010E4 RID: 4324
	private byte byte_1;

	// Token: 0x040010E5 RID: 4325
	private byte byte_2;

	// Token: 0x040010E6 RID: 4326
	private byte byte_3;
}
