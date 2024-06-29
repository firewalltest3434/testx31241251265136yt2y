using System;
using Newtonsoft.Json;

// Token: 0x0200067F RID: 1663
public sealed class GClass227
{
	// Token: 0x170005AB RID: 1451
	// (get) Token: 0x060023A3 RID: 9123 RVA: 0x0008E2CC File Offset: 0x0008C4CC
	// (set) Token: 0x060023A4 RID: 9124 RVA: 0x0008E2D4 File Offset: 0x0008C4D4
	[JsonProperty("level")]
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

	// Token: 0x170005AC RID: 1452
	// (get) Token: 0x060023A5 RID: 9125 RVA: 0x0008E2E0 File Offset: 0x0008C4E0
	// (set) Token: 0x060023A6 RID: 9126 RVA: 0x0008E2E8 File Offset: 0x0008C4E8
	[JsonProperty("systemId")]
	public int Int32_1
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x0400184E RID: 6222
	private int int_0;

	// Token: 0x0400184F RID: 6223
	private int int_1;
}
