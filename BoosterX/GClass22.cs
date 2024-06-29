using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200017B RID: 379
public sealed class GClass22
{
	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0002CCF4 File Offset: 0x0002AEF4
	// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0002CCFC File Offset: 0x0002AEFC
	[JsonProperty("RatingSystem")]
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

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0002CD08 File Offset: 0x0002AF08
	// (set) Token: 0x060009C5 RID: 2501 RVA: 0x0002CD10 File Offset: 0x0002AF10
	[JsonProperty("RatingId")]
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

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0002CD1C File Offset: 0x0002AF1C
	// (set) Token: 0x060009C7 RID: 2503 RVA: 0x0002CD24 File Offset: 0x0002AF24
	[JsonProperty("RatingDescriptors")]
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

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0002CD30 File Offset: 0x0002AF30
	// (set) Token: 0x060009C9 RID: 2505 RVA: 0x0002CD38 File Offset: 0x0002AF38
	[JsonProperty("RatingDisclaimers")]
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

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x060009CA RID: 2506 RVA: 0x0002CD44 File Offset: 0x0002AF44
	// (set) Token: 0x060009CB RID: 2507 RVA: 0x0002CD4C File Offset: 0x0002AF4C
	[JsonProperty("InteractiveElements")]
	public List<string> List_2
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

	// Token: 0x040005A8 RID: 1448
	private string string_0;

	// Token: 0x040005A9 RID: 1449
	private string string_1;

	// Token: 0x040005AA RID: 1450
	private List<string> list_0;

	// Token: 0x040005AB RID: 1451
	private List<object> list_1;

	// Token: 0x040005AC RID: 1452
	private List<string> list_2;
}
