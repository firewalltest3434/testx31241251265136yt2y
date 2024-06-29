using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000681 RID: 1665
public sealed class GClass228
{
	// Token: 0x170005AD RID: 1453
	// (get) Token: 0x060023A9 RID: 9129 RVA: 0x0008E324 File Offset: 0x0008C524
	// (set) Token: 0x060023AA RID: 9130 RVA: 0x0008E32C File Offset: 0x0008C52C
	[JsonProperty("mediaType")]
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

	// Token: 0x170005AE RID: 1454
	// (get) Token: 0x060023AB RID: 9131 RVA: 0x0008E338 File Offset: 0x0008C538
	// (set) Token: 0x060023AC RID: 9132 RVA: 0x0008E340 File Offset: 0x0008C540
	[JsonProperty("Category")]
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

	// Token: 0x170005AF RID: 1455
	// (get) Token: 0x060023AD RID: 9133 RVA: 0x0008E34C File Offset: 0x0008C54C
	// (set) Token: 0x060023AE RID: 9134 RVA: 0x0008E354 File Offset: 0x0008C554
	[JsonProperty("UserAge")]
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

	// Token: 0x170005B0 RID: 1456
	// (get) Token: 0x060023AF RID: 9135 RVA: 0x0008E360 File Offset: 0x0008C560
	// (set) Token: 0x060023B0 RID: 9136 RVA: 0x0008E368 File Offset: 0x0008C568
	[JsonProperty("PriceType")]
	public List<string> List_3
	{
		get
		{
			return this.list_3;
		}
		set
		{
			this.list_3 = value;
		}
	}

	// Token: 0x04001851 RID: 6225
	private List<string> list_0;

	// Token: 0x04001852 RID: 6226
	private List<string> list_1;

	// Token: 0x04001853 RID: 6227
	private List<string> list_2;

	// Token: 0x04001854 RID: 6228
	private List<string> list_3;
}
