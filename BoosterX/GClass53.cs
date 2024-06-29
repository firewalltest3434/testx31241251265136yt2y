using System;
using Newtonsoft.Json;

// Token: 0x0200022A RID: 554
public sealed class GClass53
{
	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0003AFA4 File Offset: 0x000391A4
	// (set) Token: 0x06000D2E RID: 3374 RVA: 0x0003AFAC File Offset: 0x000391AC
	[JsonProperty("SearchTitleString")]
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

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0003AFB8 File Offset: 0x000391B8
	// (set) Token: 0x06000D30 RID: 3376 RVA: 0x0003AFC0 File Offset: 0x000391C0
	[JsonProperty("SearchTitleType")]
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

	// Token: 0x04000835 RID: 2101
	private string string_0;

	// Token: 0x04000836 RID: 2102
	private string string_1;
}
