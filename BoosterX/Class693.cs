using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x0200060D RID: 1549
internal sealed class Class693
{
	// Token: 0x17000566 RID: 1382
	// (get) Token: 0x06002198 RID: 8600 RVA: 0x00087E10 File Offset: 0x00086010
	// (set) Token: 0x06002199 RID: 8601 RVA: 0x00087E18 File Offset: 0x00086018
	[JsonProperty("C")]
	public string ChoosenArea
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x17000567 RID: 1383
	// (get) Token: 0x0600219A RID: 8602 RVA: 0x00087E24 File Offset: 0x00086024
	// (set) Token: 0x0600219B RID: 8603 RVA: 0x00087E2C File Offset: 0x0008602C
	[JsonProperty("P")]
	public string String_0
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

	// Token: 0x17000568 RID: 1384
	// (get) Token: 0x0600219C RID: 8604 RVA: 0x00087E38 File Offset: 0x00086038
	// (set) Token: 0x0600219D RID: 8605 RVA: 0x00087E40 File Offset: 0x00086040
	[JsonProperty("N")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000569 RID: 1385
	// (get) Token: 0x0600219E RID: 8606 RVA: 0x00087E4C File Offset: 0x0008604C
	// (set) Token: 0x0600219F RID: 8607 RVA: 0x00087E54 File Offset: 0x00086054
	[JsonProperty("K")]
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

	// Token: 0x1700056A RID: 1386
	// (get) Token: 0x060021A0 RID: 8608 RVA: 0x00087E60 File Offset: 0x00086060
	// (set) Token: 0x060021A1 RID: 8609 RVA: 0x00087E68 File Offset: 0x00086068
	[JsonProperty("D")]
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

	// Token: 0x1700056B RID: 1387
	// (get) Token: 0x060021A2 RID: 8610 RVA: 0x00087E74 File Offset: 0x00086074
	// (set) Token: 0x060021A3 RID: 8611 RVA: 0x00087E7C File Offset: 0x0008607C
	[JsonProperty("V")]
	public List<double> Values
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
		[CompilerGenerated]
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x0400170E RID: 5902
	private string string_0;

	// Token: 0x0400170F RID: 5903
	private string string_1;

	// Token: 0x04001710 RID: 5904
	private string string_2;

	// Token: 0x04001711 RID: 5905
	private int int_0;

	// Token: 0x04001712 RID: 5906
	private DateTime dateTime_0;

	// Token: 0x04001713 RID: 5907
	private List<double> list_0 = new List<double>();
}
