using System;
using System.Runtime.CompilerServices;
using ns0;

// Token: 0x020002B4 RID: 692
public sealed class GClass79
{
	// Token: 0x06000FF5 RID: 4085 RVA: 0x00043F58 File Offset: 0x00042158
	public uint method_0()
	{
		return this.uint_0;
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x00043F60 File Offset: 0x00042160
	public void method_1(uint uint_1)
	{
		this.uint_0 = uint_1;
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x00043F6C File Offset: 0x0004216C
	public string method_2()
	{
		return this.string_0;
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x00043F74 File Offset: 0x00042174
	public void method_3(string string_4)
	{
		this.string_0 = string_4;
	}

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00043F80 File Offset: 0x00042180
	public string SettingTextLoc
	{
		get
		{
			return Class364.smethod_0(this.method_2());
		}
	}

	// Token: 0x170001EB RID: 491
	// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00043F90 File Offset: 0x00042190
	public string SettingTextDescLoc
	{
		get
		{
			return Class364.smethod_0(this.method_2() + "Desc");
		}
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x00043FA8 File Offset: 0x000421A8
	public string method_4()
	{
		return this.string_1;
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x00043FB0 File Offset: 0x000421B0
	public void method_5(string string_4)
	{
		this.string_1 = string_4;
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x00043FBC File Offset: 0x000421BC
	public string method_6()
	{
		return this.string_2;
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x00043FC4 File Offset: 0x000421C4
	public void method_7(string string_4)
	{
		this.string_2 = string_4;
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x00043FD0 File Offset: 0x000421D0
	public object method_8()
	{
		return this.object_0;
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x00043FD8 File Offset: 0x000421D8
	public void method_9(object object_1)
	{
		this.object_0 = object_1;
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x00043FE4 File Offset: 0x000421E4
	public string method_10()
	{
		return this.string_3;
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x00043FEC File Offset: 0x000421EC
	public void method_11(string string_4)
	{
		this.string_3 = string_4;
	}

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x06001003 RID: 4099 RVA: 0x00043FF8 File Offset: 0x000421F8
	// (set) Token: 0x06001004 RID: 4100 RVA: 0x00044000 File Offset: 0x00042200
	public dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd State
	{
		[CompilerGenerated]
		get
		{
			return this.dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd_0;
		}
		[CompilerGenerated]
		set
		{
			this.dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd_0 = value;
		}
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x0004400C File Offset: 0x0004220C
	public bool method_12()
	{
		return this.bool_0;
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x00044014 File Offset: 0x00042214
	public void method_13(bool bool_3)
	{
		this.bool_0 = bool_3;
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x00044020 File Offset: 0x00042220
	public bool method_14()
	{
		return this.bool_1;
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00044028 File Offset: 0x00042228
	public void method_15(bool bool_3)
	{
		this.bool_1 = bool_3;
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x00044034 File Offset: 0x00042234
	public bool method_16()
	{
		return this.bool_2;
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x0004403C File Offset: 0x0004223C
	public void method_17(bool bool_3)
	{
		this.bool_2 = bool_3;
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x00044048 File Offset: 0x00042248
	public override string ToString()
	{
		return string.Format("{0}; 0x{1:X8}; {2}; {3}; {4};", new object[]
		{
			this.State,
			this.method_0(),
			this.method_2(),
			this.method_4(),
			this.method_6()
		});
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x0004409C File Offset: 0x0004229C
	public string method_18()
	{
		return string.Format("(ID: {0}) {1} = {2}", this.method_0(), this.method_2(), this.method_4());
	}

	// Token: 0x04000999 RID: 2457
	private uint uint_0;

	// Token: 0x0400099A RID: 2458
	private string string_0;

	// Token: 0x0400099B RID: 2459
	private string string_1;

	// Token: 0x0400099C RID: 2460
	private string string_2;

	// Token: 0x0400099D RID: 2461
	private object object_0;

	// Token: 0x0400099E RID: 2462
	private string string_3;

	// Token: 0x0400099F RID: 2463
	private dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd_0;

	// Token: 0x040009A0 RID: 2464
	private bool bool_0;

	// Token: 0x040009A1 RID: 2465
	private bool bool_1;

	// Token: 0x040009A2 RID: 2466
	private bool bool_2;
}
