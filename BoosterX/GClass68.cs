using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02000263 RID: 611
public sealed class GClass68
{
	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0003E4D4 File Offset: 0x0003C6D4
	// (set) Token: 0x06000E56 RID: 3670 RVA: 0x0003E4DC File Offset: 0x0003C6DC
	[JsonProperty("text")]
	public string Text
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000E57 RID: 3671 RVA: 0x0003E4E8 File Offset: 0x0003C6E8
	// (set) Token: 0x06000E58 RID: 3672 RVA: 0x0003E4F0 File Offset: 0x0003C6F0
	[JsonProperty("index")]
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000E59 RID: 3673 RVA: 0x0003E4FC File Offset: 0x0003C6FC
	// (set) Token: 0x06000E5A RID: 3674 RVA: 0x0003E504 File Offset: 0x0003C704
	[JsonProperty("logprobs")]
	public GClass23 GClass23_0
	{
		get
		{
			return this.gclass23_0;
		}
		set
		{
			this.gclass23_0 = value;
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0003E510 File Offset: 0x0003C710
	// (set) Token: 0x06000E5C RID: 3676 RVA: 0x0003E518 File Offset: 0x0003C718
	[JsonProperty("finish_reason")]
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

	// Token: 0x06000E5D RID: 3677 RVA: 0x0003E524 File Offset: 0x0003C724
	public override string ToString()
	{
		return this.Text;
	}

	// Token: 0x040008C0 RID: 2240
	private string string_0;

	// Token: 0x040008C1 RID: 2241
	private int int_0;

	// Token: 0x040008C2 RID: 2242
	private GClass23 gclass23_0;

	// Token: 0x040008C3 RID: 2243
	private string string_1;
}
