using System;
using Newtonsoft.Json;

// Token: 0x02000128 RID: 296
public sealed class GClass30 : GClass29
{
	// Token: 0x1700007D RID: 125
	// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00026458 File Offset: 0x00024658
	// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00026460 File Offset: 0x00024660
	[JsonProperty("completion_tokens")]
	public short Int16_0
	{
		get
		{
			return this.short_0;
		}
		set
		{
			this.short_0 = value;
		}
	}

	// Token: 0x04000443 RID: 1091
	private short short_0;
}
