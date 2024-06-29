using System;

// Token: 0x020000E3 RID: 227
public sealed class GClass4
{
	// Token: 0x0600069D RID: 1693 RVA: 0x000201C8 File Offset: 0x0001E3C8
	public GClass4(GEnum70 genum70_1, GEnum68 genum68_1, bool bool_0)
	{
		this.method_1(genum70_1);
		this.method_3(genum68_1);
		this.method_5(genum70_1.ToString());
		this.method_7(genum68_1.ToString());
		if (bool_0)
		{
			this.method_9(string.Concat(new string[]
			{
				"market=",
				this.method_4(),
				"&languages=",
				this.method_6(),
				"-",
				this.method_4(),
				",",
				this.method_6(),
				",neutral"
			}));
			return;
		}
		this.method_9(string.Concat(new string[]
		{
			"market=",
			this.method_4(),
			"&languages=",
			this.method_6(),
			"-",
			this.method_4(),
			",",
			this.method_6()
		}));
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x000202C8 File Offset: 0x0001E4C8
	public GEnum70 method_0()
	{
		return this.genum70_0;
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x000202D0 File Offset: 0x0001E4D0
	private void method_1(GEnum70 genum70_1)
	{
		this.genum70_0 = genum70_1;
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x000202DC File Offset: 0x0001E4DC
	public GEnum68 method_2()
	{
		return this.genum68_0;
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x000202E4 File Offset: 0x0001E4E4
	private void method_3(GEnum68 genum68_1)
	{
		this.genum68_0 = genum68_1;
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x000202F0 File Offset: 0x0001E4F0
	public string method_4()
	{
		return this.string_0;
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x000202F8 File Offset: 0x0001E4F8
	private void method_5(string string_3)
	{
		this.string_0 = string_3;
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00020304 File Offset: 0x0001E504
	public string method_6()
	{
		return this.string_1;
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x0002030C File Offset: 0x0001E50C
	private void method_7(string string_3)
	{
		this.string_1 = string_3;
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00020318 File Offset: 0x0001E518
	public string method_8()
	{
		return this.string_2;
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00020320 File Offset: 0x0001E520
	private void method_9(string string_3)
	{
		this.string_2 = string_3;
	}

	// Token: 0x0400034F RID: 847
	private GEnum70 genum70_0;

	// Token: 0x04000350 RID: 848
	private GEnum68 genum68_0;

	// Token: 0x04000351 RID: 849
	private string string_0;

	// Token: 0x04000352 RID: 850
	private string string_1;

	// Token: 0x04000353 RID: 851
	private string string_2;
}
