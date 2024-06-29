using System;
using Newtonsoft.Json;

// Token: 0x020000D7 RID: 215
public sealed class GClass1
{
	// Token: 0x06000650 RID: 1616 RVA: 0x0001F8E4 File Offset: 0x0001DAE4
	public GClass1()
	{
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x0001F920 File Offset: 0x0001DB20
	public GClass1(string string_4, GClass89 gclass89_0, GClass101 gclass101_1 = null, string string_5 = "standard", string string_6 = null, GClass144 gclass144_1 = null)
	{
		this.String_0 = string_4;
		this.String_1 = (gclass89_0 ?? GClass89.smethod_28());
		this.String_3 = (string_5 ?? "standard");
		this.String_2 = string_6;
		this.GClass101_0 = (gclass101_1 ?? GClass101.smethod_2());
		this.GClass144_0 = (gclass144_1 ?? GClass144.smethod_0());
		if (this.String_1 == GClass89.smethod_29())
		{
			if (this.GClass101_0 == GClass101.smethod_0() || this.GClass101_0 == GClass101.smethod_1())
			{
				throw new ArgumentException("For DALL-E 3, only sizes 1024x1024, 1024x1792, or 1792x1024 are allowed.");
			}
			if (this.string_0 != "standard" && this.string_0 != "hd")
			{
				throw new ArgumentException("Quality must be one of 'standard' or 'hd'");
			}
		}
		else
		{
			if (this.GClass101_0 == GClass101.smethod_4() || this.GClass101_0 == GClass101.smethod_3())
			{
				throw new ArgumentException("For DALL-E 2, only sizes 256x256, 512x512, or 1024x1024 are allowed.");
			}
			if (this.string_0 != "standard")
			{
				throw new ArgumentException("For DALL-E 2, only 'standard' quality is available");
			}
		}
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
	public GClass1(string string_4, int? nullable_1 = null, GClass101 gclass101_1 = null, string string_5 = null, GClass144 gclass144_1 = null)
	{
		this.String_0 = string_4;
		this.Nullable_0 = nullable_1;
		this.String_2 = string_5;
		this.GClass101_0 = (gclass101_1 ?? GClass101.smethod_2());
		this.GClass144_0 = (gclass144_1 ?? GClass144.smethod_0());
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000653 RID: 1619 RVA: 0x0001FB1C File Offset: 0x0001DD1C
	// (set) Token: 0x06000654 RID: 1620 RVA: 0x0001FB24 File Offset: 0x0001DD24
	[JsonProperty("prompt")]
	public string String_0
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

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000655 RID: 1621 RVA: 0x0001FB30 File Offset: 0x0001DD30
	// (set) Token: 0x06000656 RID: 1622 RVA: 0x0001FB80 File Offset: 0x0001DD80
	[JsonProperty("n")]
	public int? Nullable_0
	{
		get
		{
			if (this.String_1 == GClass89.smethod_29())
			{
				int? num = this.nullable_0;
				if (!(num.GetValueOrDefault() == 1 & num != null))
				{
					throw new ArgumentException("For DALL-E 3, only 1 NumOfImages is allowed.");
				}
			}
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000657 RID: 1623 RVA: 0x0001FB8C File Offset: 0x0001DD8C
	// (set) Token: 0x06000658 RID: 1624 RVA: 0x0001FB94 File Offset: 0x0001DD94
	[JsonProperty("model")]
	public string String_1
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

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000659 RID: 1625 RVA: 0x0001FBA0 File Offset: 0x0001DDA0
	// (set) Token: 0x0600065A RID: 1626 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
	[JsonProperty("user")]
	public string String_2
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

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x0600065B RID: 1627 RVA: 0x0001FBB4 File Offset: 0x0001DDB4
	// (set) Token: 0x0600065C RID: 1628 RVA: 0x0001FC68 File Offset: 0x0001DE68
	[JsonConverter]
	[JsonProperty("size")]
	public GClass101 GClass101_0
	{
		get
		{
			if (this.String_1 == GClass89.smethod_29() && (this.gclass101_0 == GClass101.smethod_0() || this.gclass101_0 == GClass101.smethod_1()))
			{
				throw new ArgumentException("For DALL-E 3, only 1024x1024, 1024x1792, or 1792x1024 is allowed.");
			}
			if (this.String_1 == GClass89.smethod_28() && (this.gclass101_0 == GClass101.smethod_4() || this.gclass101_0 == GClass101.smethod_3()))
			{
				throw new ArgumentException("For DALL-E 2, only 256x256, 512x512, or 1024x1024 is allowed.");
			}
			return this.gclass101_0;
		}
		set
		{
			this.gclass101_0 = value;
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x0600065D RID: 1629 RVA: 0x0001FC74 File Offset: 0x0001DE74
	// (set) Token: 0x0600065E RID: 1630 RVA: 0x0001FCE8 File Offset: 0x0001DEE8
	[JsonProperty("quality", NullValueHandling = 1)]
	public string String_3
	{
		get
		{
			if (this.String_1 == GClass89.smethod_28() && this.string_0 == "hd")
			{
				throw new ArgumentException("For DALL-E 2, hd quality is not available.");
			}
			if (this.String_1 == GClass89.smethod_29() && this.string_0 == "standard")
			{
				return null;
			}
			return this.string_0;
		}
		set
		{
			string a = value.ToLower().Trim();
			if (a == "standard")
			{
				this.string_0 = "standard";
				return;
			}
			if (!(a == "hd"))
			{
				throw new ArgumentException("Quality must be either 'standard' or 'hd'.");
			}
			this.string_0 = "hd";
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600065F RID: 1631 RVA: 0x0001FD40 File Offset: 0x0001DF40
	// (set) Token: 0x06000660 RID: 1632 RVA: 0x0001FD48 File Offset: 0x0001DF48
	[JsonConverter]
	[JsonProperty("response_format")]
	public GClass144 GClass144_0
	{
		get
		{
			return this.gclass144_0;
		}
		set
		{
			this.gclass144_0 = value;
		}
	}

	// Token: 0x0400032B RID: 811
	private int? nullable_0 = new int?(1);

	// Token: 0x0400032C RID: 812
	private GClass101 gclass101_0 = GClass101.smethod_2();

	// Token: 0x0400032D RID: 813
	private string string_0 = "standard";

	// Token: 0x0400032E RID: 814
	private string string_1;

	// Token: 0x0400032F RID: 815
	private string string_2 = GClass89.smethod_28();

	// Token: 0x04000330 RID: 816
	private string string_3;

	// Token: 0x04000331 RID: 817
	private GClass144 gclass144_0;
}
