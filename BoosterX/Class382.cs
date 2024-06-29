using System;
using System.Linq;
using Newtonsoft.Json;

// Token: 0x0200033B RID: 827
internal sealed class Class382
{
	// Token: 0x1700025E RID: 606
	// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0004D1A4 File Offset: 0x0004B3A4
	// (set) Token: 0x060012B1 RID: 4785 RVA: 0x0004D1AC File Offset: 0x0004B3AC
	[JsonProperty("ip")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x1700025F RID: 607
	// (get) Token: 0x060012B2 RID: 4786 RVA: 0x0004D1B8 File Offset: 0x0004B3B8
	// (set) Token: 0x060012B3 RID: 4787 RVA: 0x0004D1C0 File Offset: 0x0004B3C0
	[JsonProperty("hostname")]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000260 RID: 608
	// (get) Token: 0x060012B4 RID: 4788 RVA: 0x0004D1CC File Offset: 0x0004B3CC
	// (set) Token: 0x060012B5 RID: 4789 RVA: 0x0004D1D4 File Offset: 0x0004B3D4
	[JsonProperty("city")]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000261 RID: 609
	// (get) Token: 0x060012B6 RID: 4790 RVA: 0x0004D1E0 File Offset: 0x0004B3E0
	// (set) Token: 0x060012B7 RID: 4791 RVA: 0x0004D1E8 File Offset: 0x0004B3E8
	[JsonProperty("region")]
	public string String_3
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x17000262 RID: 610
	// (get) Token: 0x060012B8 RID: 4792 RVA: 0x0004D1F4 File Offset: 0x0004B3F4
	// (set) Token: 0x060012B9 RID: 4793 RVA: 0x0004D1FC File Offset: 0x0004B3FC
	[JsonProperty("country")]
	public string String_4
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x17000263 RID: 611
	// (get) Token: 0x060012BA RID: 4794 RVA: 0x0004D208 File Offset: 0x0004B408
	// (set) Token: 0x060012BB RID: 4795 RVA: 0x0004D210 File Offset: 0x0004B410
	[JsonProperty("loc")]
	public string String_5
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
		}
	}

	// Token: 0x17000264 RID: 612
	// (get) Token: 0x060012BC RID: 4796 RVA: 0x0004D21C File Offset: 0x0004B41C
	// (set) Token: 0x060012BD RID: 4797 RVA: 0x0004D224 File Offset: 0x0004B424
	[JsonProperty("org")]
	public string String_6
	{
		get
		{
			return this.string_6;
		}
		set
		{
			this.string_6 = value;
		}
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x0004D230 File Offset: 0x0004B430
	public double method_0()
	{
		string text = this.String_5;
		string s;
		if (text != null)
		{
			string[] array = text.Split(new char[]
			{
				','
			});
			if (array != null)
			{
				string text2 = Class333.smethod_2<string>(array);
				if (text2 != null)
				{
					if ((s = text2.Trim()) != null)
					{
						goto IL_3E;
					}
				}
			}
		}
		s = "0";
		IL_3E:
		return double.Parse(s);
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x0004D280 File Offset: 0x0004B480
	public double method_1()
	{
		string text = this.String_5;
		string s;
		if (text != null)
		{
			string[] array = text.Split(new char[]
			{
				','
			});
			if (array != null)
			{
				string text2 = array.LastOrDefault<string>();
				if (text2 != null)
				{
					if ((s = text2.Trim()) != null)
					{
						goto IL_3E;
					}
				}
			}
		}
		s = "0";
		IL_3E:
		return double.Parse(s);
	}

	// Token: 0x04000B83 RID: 2947
	private string string_0;

	// Token: 0x04000B84 RID: 2948
	private string string_1;

	// Token: 0x04000B85 RID: 2949
	private string string_2;

	// Token: 0x04000B86 RID: 2950
	private string string_3;

	// Token: 0x04000B87 RID: 2951
	private string string_4;

	// Token: 0x04000B88 RID: 2952
	private string string_5;

	// Token: 0x04000B89 RID: 2953
	private string string_6;
}
