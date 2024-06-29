using System;
using Newtonsoft.Json;

// Token: 0x020005E6 RID: 1510
public sealed class GClass185
{
	// Token: 0x17000550 RID: 1360
	// (get) Token: 0x060020E0 RID: 8416 RVA: 0x00084F60 File Offset: 0x00083160
	// (set) Token: 0x060020E1 RID: 8417 RVA: 0x00084F68 File Offset: 0x00083168
	[JsonProperty("platform.maxVersionTested")]
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

	// Token: 0x17000551 RID: 1361
	// (get) Token: 0x060020E2 RID: 8418 RVA: 0x00084F74 File Offset: 0x00083174
	// (set) Token: 0x060020E3 RID: 8419 RVA: 0x00084F7C File Offset: 0x0008317C
	[JsonProperty("platform.minVersion")]
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

	// Token: 0x17000552 RID: 1362
	// (get) Token: 0x060020E4 RID: 8420 RVA: 0x00084F88 File Offset: 0x00083188
	// (set) Token: 0x060020E5 RID: 8421 RVA: 0x00084F90 File Offset: 0x00083190
	[JsonProperty("platform.target")]
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

	// Token: 0x040016B6 RID: 5814
	private long long_0;

	// Token: 0x040016B7 RID: 5815
	private long long_1;

	// Token: 0x040016B8 RID: 5816
	private int int_0;
}
