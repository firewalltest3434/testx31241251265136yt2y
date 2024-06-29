using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000241 RID: 577
public sealed class GClass62
{
	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000DAD RID: 3501 RVA: 0x0003C4D0 File Offset: 0x0003A6D0
	// (set) Token: 0x06000DAE RID: 3502 RVA: 0x0003C4D8 File Offset: 0x0003A6D8
	[JsonProperty("AllowedPlatforms")]
	public List<GClass96> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x0400086C RID: 2156
	private List<GClass96> list_0;
}
