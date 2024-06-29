using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020001F8 RID: 504
public sealed class GClass47
{
	// Token: 0x1700013F RID: 319
	// (get) Token: 0x06000C29 RID: 3113 RVA: 0x000371E8 File Offset: 0x000353E8
	// (set) Token: 0x06000C2A RID: 3114 RVA: 0x000371F0 File Offset: 0x000353F0
	[JsonProperty("ApplicationId")]
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

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06000C2B RID: 3115 RVA: 0x000371FC File Offset: 0x000353FC
	// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00037204 File Offset: 0x00035404
	[JsonProperty("DeclarationOrder")]
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

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00037210 File Offset: 0x00035410
	// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00037218 File Offset: 0x00035418
	[JsonProperty("Extensions")]
	public List<string> List_0
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

	// Token: 0x0400077A RID: 1914
	private string string_0;

	// Token: 0x0400077B RID: 1915
	private long long_0;

	// Token: 0x0400077C RID: 1916
	private List<string> list_0;
}
