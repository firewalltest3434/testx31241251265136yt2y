using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000187 RID: 391
public sealed class GClass23
{
	// Token: 0x170000EF RID: 239
	// (get) Token: 0x060009FD RID: 2557 RVA: 0x0002DD38 File Offset: 0x0002BF38
	// (set) Token: 0x060009FE RID: 2558 RVA: 0x0002DD40 File Offset: 0x0002BF40
	[JsonProperty("tokens")]
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

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x060009FF RID: 2559 RVA: 0x0002DD4C File Offset: 0x0002BF4C
	// (set) Token: 0x06000A00 RID: 2560 RVA: 0x0002DD54 File Offset: 0x0002BF54
	[JsonProperty("token_logprobs")]
	public List<double?> List_1
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

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0002DD60 File Offset: 0x0002BF60
	// (set) Token: 0x06000A02 RID: 2562 RVA: 0x0002DD68 File Offset: 0x0002BF68
	[JsonProperty("top_logprobs")]
	public IList<IDictionary<string, double>> IList_0
	{
		get
		{
			return this.ilist_0;
		}
		set
		{
			this.ilist_0 = value;
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0002DD74 File Offset: 0x0002BF74
	// (set) Token: 0x06000A04 RID: 2564 RVA: 0x0002DD7C File Offset: 0x0002BF7C
	[JsonProperty("text_offset")]
	public List<int> List_2
	{
		get
		{
			return this.list_2;
		}
		set
		{
			this.list_2 = value;
		}
	}

	// Token: 0x040005D3 RID: 1491
	private List<string> list_0;

	// Token: 0x040005D4 RID: 1492
	private List<double?> list_1;

	// Token: 0x040005D5 RID: 1493
	private IList<IDictionary<string, double>> ilist_0;

	// Token: 0x040005D6 RID: 1494
	private List<int> list_2;
}
