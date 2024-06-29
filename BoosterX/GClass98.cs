using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200032E RID: 814
public sealed class GClass98
{
	// Token: 0x17000254 RID: 596
	// (get) Token: 0x06001288 RID: 4744 RVA: 0x0004C8F4 File Offset: 0x0004AAF4
	// (set) Token: 0x06001289 RID: 4745 RVA: 0x0004C8FC File Offset: 0x0004AAFC
	[JsonProperty("Sku")]
	public GClass109 GClass109_0
	{
		get
		{
			return this.gclass109_0;
		}
		set
		{
			this.gclass109_0 = value;
		}
	}

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x0600128A RID: 4746 RVA: 0x0004C908 File Offset: 0x0004AB08
	// (set) Token: 0x0600128B RID: 4747 RVA: 0x0004C910 File Offset: 0x0004AB10
	[JsonProperty("Availabilities")]
	public List<GClass19> List_0
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

	// Token: 0x04000B60 RID: 2912
	private GClass109 gclass109_0;

	// Token: 0x04000B61 RID: 2913
	private List<GClass19> list_0;
}
