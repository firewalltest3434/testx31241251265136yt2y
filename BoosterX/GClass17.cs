using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000146 RID: 326
public sealed class GClass17
{
	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06000854 RID: 2132 RVA: 0x00028A00 File Offset: 0x00026C00
	// (set) Token: 0x06000855 RID: 2133 RVA: 0x00028A08 File Offset: 0x00026C08
	[JsonProperty("GrantedEntitlementKeys")]
	public List<object> List_0
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

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x06000856 RID: 2134 RVA: 0x00028A14 File Offset: 0x00026C14
	// (set) Token: 0x06000857 RID: 2135 RVA: 0x00028A1C File Offset: 0x00026C1C
	[JsonProperty("PIFilter")]
	public GClass71 GClass71_0
	{
		get
		{
			return this.gclass71_0;
		}
		set
		{
			this.gclass71_0 = value;
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x06000858 RID: 2136 RVA: 0x00028A28 File Offset: 0x00026C28
	// (set) Token: 0x06000859 RID: 2137 RVA: 0x00028A30 File Offset: 0x00026C30
	[JsonProperty("Price")]
	public GClass177 GClass177_0
	{
		get
		{
			return this.gclass177_0;
		}
		set
		{
			this.gclass177_0 = value;
		}
	}

	// Token: 0x040004A6 RID: 1190
	private List<object> list_0;

	// Token: 0x040004A7 RID: 1191
	private GClass71 gclass71_0;

	// Token: 0x040004A8 RID: 1192
	private GClass177 gclass177_0;
}
