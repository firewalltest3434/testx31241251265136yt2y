using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000438 RID: 1080
public sealed class GClass121
{
	// Token: 0x17000366 RID: 870
	// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00064DFC File Offset: 0x00062FFC
	// (set) Token: 0x060017D1 RID: 6097 RVA: 0x00064E04 File Offset: 0x00063004
	[JsonProperty("ageRating")]
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

	// Token: 0x17000367 RID: 871
	// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00064E10 File Offset: 0x00063010
	// (set) Token: 0x060017D3 RID: 6099 RVA: 0x00064E18 File Offset: 0x00063018
	[JsonProperty("optOut.DVR")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x17000368 RID: 872
	// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00064E24 File Offset: 0x00063024
	// (set) Token: 0x060017D5 RID: 6101 RVA: 0x00064E2C File Offset: 0x0006302C
	[JsonProperty("thirdPartyAppRatings")]
	public List<GClass227> List_0
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

	// Token: 0x040010E0 RID: 4320
	private int int_0;

	// Token: 0x040010E1 RID: 4321
	private bool bool_0;

	// Token: 0x040010E2 RID: 4322
	private List<GClass227> list_0;
}
