using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000274 RID: 628
public sealed class GClass71
{
	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0003F768 File Offset: 0x0003D968
	// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x0003F770 File Offset: 0x0003D970
	[JsonProperty("ExclusionProperties")]
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

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0003F77C File Offset: 0x0003D97C
	// (set) Token: 0x06000EAA RID: 3754 RVA: 0x0003F784 File Offset: 0x0003D984
	[JsonProperty("InclusionProperties")]
	public List<object> List_1
	{
		get
		{
			return this.list_1;
		}
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x040008FC RID: 2300
	private List<object> list_0;

	// Token: 0x040008FD RID: 2301
	private List<object> list_1;
}
