using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020003E4 RID: 996
public sealed class GClass117
{
	// Token: 0x170002F3 RID: 755
	// (get) Token: 0x060015E4 RID: 5604 RVA: 0x0005C264 File Offset: 0x0005A464
	// (set) Token: 0x060015E5 RID: 5605 RVA: 0x0005C26C File Offset: 0x0005A46C
	[JsonProperty("url")]
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

	// Token: 0x170002F4 RID: 756
	// (get) Token: 0x060015E6 RID: 5606 RVA: 0x0005C278 File Offset: 0x0005A478
	// (set) Token: 0x060015E7 RID: 5607 RVA: 0x0005C280 File Offset: 0x0005A480
	[JsonProperty("b64_json")]
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

	// Token: 0x170002F5 RID: 757
	// (get) Token: 0x060015E8 RID: 5608 RVA: 0x0005C28C File Offset: 0x0005A48C
	// (set) Token: 0x060015E9 RID: 5609 RVA: 0x0005C294 File Offset: 0x0005A494
	public string RevisedPrompt
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x04000DD6 RID: 3542
	private string string_0;

	// Token: 0x04000DD7 RID: 3543
	private string string_1;

	// Token: 0x04000DD8 RID: 3544
	private string string_2;
}
