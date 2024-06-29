using System;
using Newtonsoft.Json;

// Token: 0x0200031F RID: 799
public sealed class GClass96
{
	// Token: 0x17000241 RID: 577
	// (get) Token: 0x06001243 RID: 4675 RVA: 0x0004B930 File Offset: 0x00049B30
	// (set) Token: 0x06001244 RID: 4676 RVA: 0x0004B938 File Offset: 0x00049B38
	[JsonProperty("MaxVersion")]
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

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x06001245 RID: 4677 RVA: 0x0004B944 File Offset: 0x00049B44
	// (set) Token: 0x06001246 RID: 4678 RVA: 0x0004B94C File Offset: 0x00049B4C
	[JsonProperty("MinVersion")]
	public long Int64_1
	{
		get
		{
			return this.long_1;
		}
		set
		{
			this.long_1 = value;
		}
	}

	// Token: 0x17000243 RID: 579
	// (get) Token: 0x06001247 RID: 4679 RVA: 0x0004B958 File Offset: 0x00049B58
	// (set) Token: 0x06001248 RID: 4680 RVA: 0x0004B960 File Offset: 0x00049B60
	[JsonProperty("PlatformName")]
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

	// Token: 0x04000B2D RID: 2861
	private long long_0;

	// Token: 0x04000B2E RID: 2862
	private long long_1;

	// Token: 0x04000B2F RID: 2863
	private string string_0;
}
