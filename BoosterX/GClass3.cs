using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020000DF RID: 223
public sealed class GClass3
{
	// Token: 0x17000048 RID: 72
	// (get) Token: 0x06000686 RID: 1670 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
	// (set) Token: 0x06000687 RID: 1671 RVA: 0x0001FFDC File Offset: 0x0001E1DC
	[JsonProperty("WuBundleId")]
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

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000688 RID: 1672 RVA: 0x0001FFE8 File Offset: 0x0001E1E8
	// (set) Token: 0x06000689 RID: 1673 RVA: 0x0001FFF0 File Offset: 0x0001E1F0
	[JsonProperty("WuCategoryId")]
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

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x0600068A RID: 1674 RVA: 0x0001FFFC File Offset: 0x0001E1FC
	// (set) Token: 0x0600068B RID: 1675 RVA: 0x00020004 File Offset: 0x0001E204
	[JsonProperty("PackageFamilyName")]
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

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x0600068C RID: 1676 RVA: 0x00020010 File Offset: 0x0001E210
	// (set) Token: 0x0600068D RID: 1677 RVA: 0x00020018 File Offset: 0x0001E218
	[JsonProperty("SkuId")]
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

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x0600068E RID: 1678 RVA: 0x00020024 File Offset: 0x0001E224
	// (set) Token: 0x0600068F RID: 1679 RVA: 0x0002002C File Offset: 0x0001E22C
	[JsonProperty("Content")]
	public object Content
	{
		[CompilerGenerated]
		get
		{
			return this.object_0;
		}
		[CompilerGenerated]
		set
		{
			this.object_0 = value;
		}
	}

	// Token: 0x04000343 RID: 835
	private string string_0;

	// Token: 0x04000344 RID: 836
	private string string_1;

	// Token: 0x04000345 RID: 837
	private string string_2;

	// Token: 0x04000346 RID: 838
	private string string_3;

	// Token: 0x04000347 RID: 839
	private object object_0;
}
