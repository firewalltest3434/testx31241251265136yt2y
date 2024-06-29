using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

// Token: 0x020005A7 RID: 1447
public sealed class GClass178 : GInterface10
{
	// Token: 0x06001F14 RID: 7956 RVA: 0x00080EA8 File Offset: 0x0007F0A8
	public GClass178(GClass186 gclass186_1 = null)
	{
		this.imethod_5(gclass186_1.smethod_0());
		this.ginterface8_0 = new GClass195(this);
		this.ginterface2_0 = new GClass197(this);
		this.ginterface16_0 = new GClass198(this);
		this.ginterface12_0 = new GClass196(this);
		this.ginterface7_0 = new GClass191(this);
		this.ginterface13_0 = new GClass192(this);
		this.ginterface6_0 = new GClass190(this);
		this.ginterface0_0 = new GClass194(this);
		this.ginterface9_0 = new GClass193(this, false);
		this.ginterface9_1 = new GClass193(this, true);
	}

	// Token: 0x06001F15 RID: 7957 RVA: 0x00080F70 File Offset: 0x0007F170
	[CompilerGenerated]
	public string imethod_0()
	{
		return this.string_0;
	}

	// Token: 0x06001F16 RID: 7958 RVA: 0x00080F78 File Offset: 0x0007F178
	[CompilerGenerated]
	public void imethod_1(string string_4)
	{
		this.string_0 = string_4;
	}

	// Token: 0x06001F17 RID: 7959 RVA: 0x00080F84 File Offset: 0x0007F184
	public string method_0()
	{
		return this.string_1;
	}

	// Token: 0x06001F18 RID: 7960 RVA: 0x00080F8C File Offset: 0x0007F18C
	public void method_1(string string_4)
	{
		this.string_1 = string_4;
	}

	// Token: 0x06001F19 RID: 7961 RVA: 0x00080F98 File Offset: 0x0007F198
	public string method_2()
	{
		return this.string_2;
	}

	// Token: 0x06001F1A RID: 7962 RVA: 0x00080FA0 File Offset: 0x0007F1A0
	public void method_3(string string_4)
	{
		this.string_2 = string_4;
	}

	// Token: 0x06001F1B RID: 7963 RVA: 0x00080FAC File Offset: 0x0007F1AC
	[CompilerGenerated]
	public string imethod_2()
	{
		return this.string_3;
	}

	// Token: 0x06001F1C RID: 7964 RVA: 0x00080FB4 File Offset: 0x0007F1B4
	[CompilerGenerated]
	public void imethod_3(string string_4)
	{
		this.string_3 = string_4;
	}

	// Token: 0x06001F1D RID: 7965 RVA: 0x00080FC0 File Offset: 0x0007F1C0
	[CompilerGenerated]
	public GClass186 imethod_4()
	{
		return this.gclass186_0;
	}

	// Token: 0x06001F1E RID: 7966 RVA: 0x00080FC8 File Offset: 0x0007F1C8
	[CompilerGenerated]
	public void imethod_5(GClass186 gclass186_1)
	{
		this.gclass186_0 = gclass186_1;
	}

	// Token: 0x06001F1F RID: 7967 RVA: 0x00080FD4 File Offset: 0x0007F1D4
	public IHttpClientFactory method_4()
	{
		return this.ihttpClientFactory_0;
	}

	// Token: 0x06001F20 RID: 7968 RVA: 0x00080FDC File Offset: 0x0007F1DC
	public void method_5(IHttpClientFactory ihttpClientFactory_1)
	{
		this.ihttpClientFactory_0 = ihttpClientFactory_1;
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x00080FE8 File Offset: 0x0007F1E8
	public static GClass178 smethod_0(string string_4, string string_5, GClass186 gclass186_1)
	{
		GClass178 gclass = new GClass178(gclass186_1);
		gclass.imethod_3("2023-05-15");
		gclass.imethod_1(string.Concat(new string[]
		{
			"https://",
			string_4,
			".openai.azure.com/openai/deployments/",
			string_5,
			"/{1}?api-version={0}"
		}));
		return gclass;
	}

	// Token: 0x06001F22 RID: 7970 RVA: 0x0008103C File Offset: 0x0007F23C
	[CompilerGenerated]
	public GInterface8 imethod_8()
	{
		return this.ginterface8_0;
	}

	// Token: 0x06001F23 RID: 7971 RVA: 0x00081044 File Offset: 0x0007F244
	[CompilerGenerated]
	public GInterface12 imethod_9()
	{
		return this.ginterface12_0;
	}

	// Token: 0x06001F24 RID: 7972 RVA: 0x0008104C File Offset: 0x0007F24C
	[CompilerGenerated]
	public GInterface7 imethod_6()
	{
		return this.ginterface7_0;
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x00081054 File Offset: 0x0007F254
	[CompilerGenerated]
	public GInterface13 imethod_7()
	{
		return this.ginterface13_0;
	}

	// Token: 0x170004DD RID: 1245
	// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0008105C File Offset: 0x0007F25C
	public GInterface2 Models
	{
		[CompilerGenerated]
		get
		{
			return this.ginterface2_0;
		}
	}

	// Token: 0x06001F27 RID: 7975 RVA: 0x00081064 File Offset: 0x0007F264
	[CompilerGenerated]
	public GInterface16 imethod_10()
	{
		return this.ginterface16_0;
	}

	// Token: 0x06001F28 RID: 7976 RVA: 0x0008106C File Offset: 0x0007F26C
	[CompilerGenerated]
	public GInterface6 imethod_11()
	{
		return this.ginterface6_0;
	}

	// Token: 0x06001F29 RID: 7977 RVA: 0x00081074 File Offset: 0x0007F274
	[CompilerGenerated]
	public GInterface0 imethod_12()
	{
		return this.ginterface0_0;
	}

	// Token: 0x06001F2A RID: 7978 RVA: 0x0008107C File Offset: 0x0007F27C
	[CompilerGenerated]
	public GInterface9 imethod_13()
	{
		return this.ginterface9_0;
	}

	// Token: 0x06001F2B RID: 7979 RVA: 0x00081084 File Offset: 0x0007F284
	[CompilerGenerated]
	public GInterface9 imethod_14()
	{
		return this.ginterface9_1;
	}

	// Token: 0x040015CC RID: 5580
	private string string_0 = "http://gpt.boosterx.org/{0}/{1}";

	// Token: 0x040015CD RID: 5581
	private string string_1 = "https://api.openai.com/{0}/{1}";

	// Token: 0x040015CE RID: 5582
	private string string_2 = "https://api.openai-365pro.com/{0}/{1}";

	// Token: 0x040015CF RID: 5583
	private string string_3 = "v1";

	// Token: 0x040015D0 RID: 5584
	private GClass186 gclass186_0;

	// Token: 0x040015D1 RID: 5585
	private IHttpClientFactory ihttpClientFactory_0;

	// Token: 0x040015D2 RID: 5586
	private readonly GInterface8 ginterface8_0;

	// Token: 0x040015D3 RID: 5587
	private readonly GInterface12 ginterface12_0;

	// Token: 0x040015D4 RID: 5588
	private readonly GInterface7 ginterface7_0;

	// Token: 0x040015D5 RID: 5589
	private readonly GInterface13 ginterface13_0;

	// Token: 0x040015D6 RID: 5590
	private readonly GInterface2 ginterface2_0;

	// Token: 0x040015D7 RID: 5591
	private readonly GInterface16 ginterface16_0;

	// Token: 0x040015D8 RID: 5592
	private readonly GInterface6 ginterface6_0;

	// Token: 0x040015D9 RID: 5593
	private readonly GInterface0 ginterface0_0;

	// Token: 0x040015DA RID: 5594
	private readonly GInterface9 ginterface9_0;

	// Token: 0x040015DB RID: 5595
	private readonly GInterface9 ginterface9_1;
}
