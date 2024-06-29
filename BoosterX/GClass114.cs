using System;
using Newtonsoft.Json;

// Token: 0x020003A7 RID: 935
public sealed class GClass114
{
	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x060014E6 RID: 5350 RVA: 0x000557DC File Offset: 0x000539DC
	// (set) Token: 0x060014E7 RID: 5351 RVA: 0x000557E4 File Offset: 0x000539E4
	[JsonProperty("Uri")]
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

	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x060014E8 RID: 5352 RVA: 0x000557F0 File Offset: 0x000539F0
	// (set) Token: 0x060014E9 RID: 5353 RVA: 0x000557F8 File Offset: 0x000539F8
	[JsonProperty("Rank")]
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			this.long_0 = value;
		}
	}

	// Token: 0x04000CC0 RID: 3264
	private string string_0;

	// Token: 0x04000CC1 RID: 3265
	private long long_0;
}
