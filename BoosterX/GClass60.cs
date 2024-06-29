using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000235 RID: 565
public sealed class GClass60
{
	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000D64 RID: 3428 RVA: 0x0003BA60 File Offset: 0x00039C60
	// (set) Token: 0x06000D65 RID: 3429 RVA: 0x0003BA68 File Offset: 0x00039C68
	[JsonProperty("ClientConditions")]
	public GClass62 GClass62_0
	{
		get
		{
			return this.gclass62_0;
		}
		set
		{
			this.gclass62_0 = value;
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000D66 RID: 3430 RVA: 0x0003BA74 File Offset: 0x00039C74
	// (set) Token: 0x06000D67 RID: 3431 RVA: 0x0003BA7C File Offset: 0x00039C7C
	[JsonProperty("EndDate")]
	public DateTime DateTime_0
	{
		get
		{
			return this.dateTime_0;
		}
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000D68 RID: 3432 RVA: 0x0003BA88 File Offset: 0x00039C88
	// (set) Token: 0x06000D69 RID: 3433 RVA: 0x0003BA90 File Offset: 0x00039C90
	[JsonProperty("ResourceSetIds")]
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

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0003BA9C File Offset: 0x00039C9C
	// (set) Token: 0x06000D6B RID: 3435 RVA: 0x0003BAA4 File Offset: 0x00039CA4
	[JsonProperty("StartDate")]
	public DateTime DateTime_1
	{
		get
		{
			return this.dateTime_1;
		}
		set
		{
			this.dateTime_1 = value;
		}
	}

	// Token: 0x04000854 RID: 2132
	private GClass62 gclass62_0;

	// Token: 0x04000855 RID: 2133
	private DateTime dateTime_0;

	// Token: 0x04000856 RID: 2134
	private List<string> list_0;

	// Token: 0x04000857 RID: 2135
	private DateTime dateTime_1;
}
