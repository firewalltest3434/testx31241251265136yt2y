using System;
using Newtonsoft.Json;

// Token: 0x02000339 RID: 825
public sealed class GClass100
{
	// Token: 0x17000256 RID: 598
	// (get) Token: 0x06001299 RID: 4761 RVA: 0x0004D044 File Offset: 0x0004B244
	// (set) Token: 0x0600129A RID: 4762 RVA: 0x0004D04C File Offset: 0x0004B24C
	[JsonProperty("OriginalReleaseDate")]
	public DateTime? Nullable_0
	{
		get
		{
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x04000B7B RID: 2939
	private DateTime? nullable_0;
}
