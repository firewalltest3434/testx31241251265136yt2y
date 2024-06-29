using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200051F RID: 1311
public sealed class GClass157
{
	// Token: 0x1700048B RID: 1163
	// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x000751C0 File Offset: 0x000733C0
	// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x000751C8 File Offset: 0x000733C8
	[JsonProperty("MinimumHardware")]
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

	// Token: 0x1700048C RID: 1164
	// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000751D4 File Offset: 0x000733D4
	// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x000751DC File Offset: 0x000733DC
	[JsonProperty("RecommendedHardware")]
	public List<string> List_1
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

	// Token: 0x1700048D RID: 1165
	// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x000751E8 File Offset: 0x000733E8
	// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x000751F0 File Offset: 0x000733F0
	[JsonProperty("MinimumProcessor")]
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

	// Token: 0x1700048E RID: 1166
	// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000751FC File Offset: 0x000733FC
	// (set) Token: 0x06001CDB RID: 7387 RVA: 0x00075204 File Offset: 0x00073404
	[JsonProperty("RecommendedProcessor")]
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

	// Token: 0x1700048F RID: 1167
	// (get) Token: 0x06001CDC RID: 7388 RVA: 0x00075210 File Offset: 0x00073410
	// (set) Token: 0x06001CDD RID: 7389 RVA: 0x00075218 File Offset: 0x00073418
	[JsonProperty("MinimumGraphics")]
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

	// Token: 0x17000490 RID: 1168
	// (get) Token: 0x06001CDE RID: 7390 RVA: 0x00075224 File Offset: 0x00073424
	// (set) Token: 0x06001CDF RID: 7391 RVA: 0x0007522C File Offset: 0x0007342C
	[JsonProperty("RecommendedGraphics")]
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

	// Token: 0x04001417 RID: 5143
	private List<object> list_0;

	// Token: 0x04001418 RID: 5144
	private List<string> list_1;

	// Token: 0x04001419 RID: 5145
	private string string_0;

	// Token: 0x0400141A RID: 5146
	private string string_1;

	// Token: 0x0400141B RID: 5147
	private string string_2;

	// Token: 0x0400141C RID: 5148
	private string string_3;
}
