using System;
using Newtonsoft.Json;

// Token: 0x020005A6 RID: 1446
public sealed class GClass177
{
	// Token: 0x170004D7 RID: 1239
	// (get) Token: 0x06001F08 RID: 7944 RVA: 0x00080E30 File Offset: 0x0007F030
	// (set) Token: 0x06001F09 RID: 7945 RVA: 0x00080E38 File Offset: 0x0007F038
	[JsonProperty("CurrencyCode")]
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

	// Token: 0x170004D8 RID: 1240
	// (get) Token: 0x06001F0A RID: 7946 RVA: 0x00080E44 File Offset: 0x0007F044
	// (set) Token: 0x06001F0B RID: 7947 RVA: 0x00080E4C File Offset: 0x0007F04C
	[JsonProperty("IsPIRequired")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x170004D9 RID: 1241
	// (get) Token: 0x06001F0C RID: 7948 RVA: 0x00080E58 File Offset: 0x0007F058
	// (set) Token: 0x06001F0D RID: 7949 RVA: 0x00080E60 File Offset: 0x0007F060
	[JsonProperty("ListPrice")]
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

	// Token: 0x170004DA RID: 1242
	// (get) Token: 0x06001F0E RID: 7950 RVA: 0x00080E6C File Offset: 0x0007F06C
	// (set) Token: 0x06001F0F RID: 7951 RVA: 0x00080E74 File Offset: 0x0007F074
	[JsonProperty("MSRP")]
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

	// Token: 0x170004DB RID: 1243
	// (get) Token: 0x06001F10 RID: 7952 RVA: 0x00080E80 File Offset: 0x0007F080
	// (set) Token: 0x06001F11 RID: 7953 RVA: 0x00080E88 File Offset: 0x0007F088
	[JsonProperty("TaxType")]
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

	// Token: 0x170004DC RID: 1244
	// (get) Token: 0x06001F12 RID: 7954 RVA: 0x00080E94 File Offset: 0x0007F094
	// (set) Token: 0x06001F13 RID: 7955 RVA: 0x00080E9C File Offset: 0x0007F09C
	[JsonProperty("WholesaleCurrencyCode")]
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

	// Token: 0x040015C6 RID: 5574
	private string string_0;

	// Token: 0x040015C7 RID: 5575
	private bool bool_0;

	// Token: 0x040015C8 RID: 5576
	private long long_0;

	// Token: 0x040015C9 RID: 5577
	private long long_1;

	// Token: 0x040015CA RID: 5578
	private string string_1;

	// Token: 0x040015CB RID: 5579
	private string string_2;
}
