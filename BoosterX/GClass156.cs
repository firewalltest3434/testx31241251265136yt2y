using System;
using Newtonsoft.Json;

// Token: 0x0200051C RID: 1308
public sealed class GClass156
{
	// Token: 0x17000484 RID: 1156
	// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x00074958 File Offset: 0x00072B58
	// (set) Token: 0x06001CC1 RID: 7361 RVA: 0x00074960 File Offset: 0x00072B60
	[JsonProperty("AverageRating")]
	public double Double_0
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
		}
	}

	// Token: 0x17000485 RID: 1157
	// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x0007496C File Offset: 0x00072B6C
	// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x00074974 File Offset: 0x00072B74
	[JsonProperty("AggregateTimeSpan")]
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

	// Token: 0x17000486 RID: 1158
	// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00074980 File Offset: 0x00072B80
	// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00074988 File Offset: 0x00072B88
	[JsonProperty("RatingCount")]
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

	// Token: 0x17000487 RID: 1159
	// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x00074994 File Offset: 0x00072B94
	// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0007499C File Offset: 0x00072B9C
	[JsonProperty("PurchaseCount")]
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

	// Token: 0x17000488 RID: 1160
	// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x000749A8 File Offset: 0x00072BA8
	// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x000749B0 File Offset: 0x00072BB0
	[JsonProperty("TrialCount")]
	public long? Nullable_0
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

	// Token: 0x17000489 RID: 1161
	// (get) Token: 0x06001CCA RID: 7370 RVA: 0x000749BC File Offset: 0x00072BBC
	// (set) Token: 0x06001CCB RID: 7371 RVA: 0x000749C4 File Offset: 0x00072BC4
	[JsonProperty("RentalCount")]
	public long Int64_2
	{
		get
		{
			return this.long_2;
		}
		set
		{
			this.long_2 = value;
		}
	}

	// Token: 0x1700048A RID: 1162
	// (get) Token: 0x06001CCC RID: 7372 RVA: 0x000749D0 File Offset: 0x00072BD0
	// (set) Token: 0x06001CCD RID: 7373 RVA: 0x000749D8 File Offset: 0x00072BD8
	[JsonProperty("PlayCount")]
	public long Int64_3
	{
		get
		{
			return this.long_3;
		}
		set
		{
			this.long_3 = value;
		}
	}

	// Token: 0x0400140D RID: 5133
	private double double_0;

	// Token: 0x0400140E RID: 5134
	private string string_0;

	// Token: 0x0400140F RID: 5135
	private long long_0;

	// Token: 0x04001410 RID: 5136
	private long long_1;

	// Token: 0x04001411 RID: 5137
	private long? nullable_0;

	// Token: 0x04001412 RID: 5138
	private long long_2;

	// Token: 0x04001413 RID: 5139
	private long long_3;
}
