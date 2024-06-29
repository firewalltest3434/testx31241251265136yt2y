using System;
using Newtonsoft.Json;

// Token: 0x0200058D RID: 1421
public sealed class GClass167
{
	// Token: 0x170004C9 RID: 1225
	// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0007FCF0 File Offset: 0x0007DEF0
	// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x0007FCF8 File Offset: 0x0007DEF8
	[JsonProperty("model")]
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

	// Token: 0x170004CA RID: 1226
	// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x0007FD04 File Offset: 0x0007DF04
	// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x0007FD0C File Offset: 0x0007DF0C
	[JsonProperty("input")]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x170004CB RID: 1227
	// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x0007FD18 File Offset: 0x0007DF18
	// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x0007FD20 File Offset: 0x0007DF20
	[JsonProperty("voice")]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x170004CC RID: 1228
	// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x0007FD2C File Offset: 0x0007DF2C
	// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x0007FD34 File Offset: 0x0007DF34
	[JsonProperty("response_format", DefaultValueHandling = 1)]
	public string String_3
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x170004CD RID: 1229
	// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x0007FD40 File Offset: 0x0007DF40
	// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x0007FD48 File Offset: 0x0007DF48
	[JsonProperty("speed", DefaultValueHandling = 1)]
	public double? Nullable_0
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

	// Token: 0x0400158F RID: 5519
	private string string_0 = GClass89.smethod_4();

	// Token: 0x04001590 RID: 5520
	private string string_1;

	// Token: 0x04001591 RID: 5521
	private string string_2 = "alloy";

	// Token: 0x04001592 RID: 5522
	private string string_3;

	// Token: 0x04001593 RID: 5523
	private double? nullable_0;

	// Token: 0x0200058E RID: 1422
	public static class GClass168
	{
	}

	// Token: 0x0200058F RID: 1423
	public static class GClass169
	{
	}
}
