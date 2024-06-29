using System;
using Newtonsoft.Json;

// Token: 0x020001DC RID: 476
public abstract class GClass32
{
	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00034174 File Offset: 0x00032374
	[JsonIgnore]
	public DateTime? Nullable_0
	{
		get
		{
			if (this.Nullable_1 == null)
			{
				return null;
			}
			return new DateTime?(DateTimeOffset.FromUnixTimeSeconds(this.Nullable_1.Value).DateTime);
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000B2A RID: 2858 RVA: 0x000341BC File Offset: 0x000323BC
	// (set) Token: 0x06000B2B RID: 2859 RVA: 0x000341C4 File Offset: 0x000323C4
	[JsonProperty("created")]
	public long? Nullable_1
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

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000B2C RID: 2860 RVA: 0x000341D0 File Offset: 0x000323D0
	// (set) Token: 0x06000B2D RID: 2861 RVA: 0x000341D8 File Offset: 0x000323D8
	[JsonProperty("model")]
	public GClass89 GClass89_0
	{
		get
		{
			return this.gclass89_0;
		}
		set
		{
			this.gclass89_0 = value;
		}
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06000B2E RID: 2862 RVA: 0x000341E4 File Offset: 0x000323E4
	// (set) Token: 0x06000B2F RID: 2863 RVA: 0x000341EC File Offset: 0x000323EC
	[JsonProperty("object")]
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

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06000B30 RID: 2864 RVA: 0x000341F8 File Offset: 0x000323F8
	// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00034200 File Offset: 0x00032400
	[JsonIgnore]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		internal set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0003420C File Offset: 0x0003240C
	// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00034214 File Offset: 0x00032414
	[JsonIgnore]
	public TimeSpan TimeSpan_0
	{
		get
		{
			return this.timeSpan_0;
		}
		internal set
		{
			this.timeSpan_0 = value;
		}
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00034220 File Offset: 0x00032420
	// (set) Token: 0x06000B35 RID: 2869 RVA: 0x00034228 File Offset: 0x00032428
	[JsonIgnore]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		internal set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00034234 File Offset: 0x00032434
	// (set) Token: 0x06000B37 RID: 2871 RVA: 0x0003423C File Offset: 0x0003243C
	[JsonIgnore]
	public string String_3
	{
		get
		{
			return this.string_3;
		}
		internal set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x040006E6 RID: 1766
	private long? nullable_0;

	// Token: 0x040006E7 RID: 1767
	private GClass89 gclass89_0;

	// Token: 0x040006E8 RID: 1768
	private string string_0;

	// Token: 0x040006E9 RID: 1769
	private string string_1;

	// Token: 0x040006EA RID: 1770
	private TimeSpan timeSpan_0;

	// Token: 0x040006EB RID: 1771
	private string string_2;

	// Token: 0x040006EC RID: 1772
	private string string_3;
}
