using System;
using Newtonsoft.Json;

// Token: 0x020004B1 RID: 1201
public sealed class GClass142
{
	// Token: 0x170003F9 RID: 1017
	// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0006C890 File Offset: 0x0006AA90
	// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0006C898 File Offset: 0x0006AA98
	[JsonProperty("id")]
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

	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0006C8A4 File Offset: 0x0006AAA4
	// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0006C8AC File Offset: 0x0006AAAC
	[JsonProperty("object")]
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

	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0006C8B8 File Offset: 0x0006AAB8
	[JsonIgnore]
	public DateTime DateTime_0
	{
		get
		{
			return DateTimeOffset.FromUnixTimeSeconds(this.Int64_0).DateTime;
		}
	}

	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x06001A65 RID: 6757 RVA: 0x0006C8D8 File Offset: 0x0006AAD8
	// (set) Token: 0x06001A66 RID: 6758 RVA: 0x0006C8E0 File Offset: 0x0006AAE0
	[JsonProperty("created")]
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

	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06001A67 RID: 6759 RVA: 0x0006C8EC File Offset: 0x0006AAEC
	// (set) Token: 0x06001A68 RID: 6760 RVA: 0x0006C8F4 File Offset: 0x0006AAF4
	[JsonProperty("allow_create_engine")]
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

	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x06001A69 RID: 6761 RVA: 0x0006C900 File Offset: 0x0006AB00
	// (set) Token: 0x06001A6A RID: 6762 RVA: 0x0006C908 File Offset: 0x0006AB08
	[JsonProperty("allow_sampling")]
	public bool Boolean_1
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x170003FF RID: 1023
	// (get) Token: 0x06001A6B RID: 6763 RVA: 0x0006C914 File Offset: 0x0006AB14
	// (set) Token: 0x06001A6C RID: 6764 RVA: 0x0006C91C File Offset: 0x0006AB1C
	[JsonProperty("allow_logprobs")]
	public bool Boolean_2
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
		}
	}

	// Token: 0x17000400 RID: 1024
	// (get) Token: 0x06001A6D RID: 6765 RVA: 0x0006C928 File Offset: 0x0006AB28
	// (set) Token: 0x06001A6E RID: 6766 RVA: 0x0006C930 File Offset: 0x0006AB30
	[JsonProperty("allow_search_indices")]
	public bool Boolean_3
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.bool_3 = value;
		}
	}

	// Token: 0x17000401 RID: 1025
	// (get) Token: 0x06001A6F RID: 6767 RVA: 0x0006C93C File Offset: 0x0006AB3C
	// (set) Token: 0x06001A70 RID: 6768 RVA: 0x0006C944 File Offset: 0x0006AB44
	[JsonProperty("allow_view")]
	public bool Boolean_4
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			this.bool_4 = value;
		}
	}

	// Token: 0x17000402 RID: 1026
	// (get) Token: 0x06001A71 RID: 6769 RVA: 0x0006C950 File Offset: 0x0006AB50
	// (set) Token: 0x06001A72 RID: 6770 RVA: 0x0006C958 File Offset: 0x0006AB58
	[JsonProperty("allow_fine_tuning")]
	public bool Boolean_5
	{
		get
		{
			return this.bool_5;
		}
		set
		{
			this.bool_5 = value;
		}
	}

	// Token: 0x17000403 RID: 1027
	// (get) Token: 0x06001A73 RID: 6771 RVA: 0x0006C964 File Offset: 0x0006AB64
	// (set) Token: 0x06001A74 RID: 6772 RVA: 0x0006C96C File Offset: 0x0006AB6C
	[JsonProperty("organization")]
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

	// Token: 0x17000404 RID: 1028
	// (get) Token: 0x06001A75 RID: 6773 RVA: 0x0006C978 File Offset: 0x0006AB78
	// (set) Token: 0x06001A76 RID: 6774 RVA: 0x0006C980 File Offset: 0x0006AB80
	[JsonProperty("group")]
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

	// Token: 0x17000405 RID: 1029
	// (get) Token: 0x06001A77 RID: 6775 RVA: 0x0006C98C File Offset: 0x0006AB8C
	// (set) Token: 0x06001A78 RID: 6776 RVA: 0x0006C994 File Offset: 0x0006AB94
	[JsonProperty("is_blocking")]
	public bool Boolean_6
	{
		get
		{
			return this.bool_6;
		}
		set
		{
			this.bool_6 = value;
		}
	}

	// Token: 0x04001287 RID: 4743
	private string string_0;

	// Token: 0x04001288 RID: 4744
	private string string_1;

	// Token: 0x04001289 RID: 4745
	private long long_0;

	// Token: 0x0400128A RID: 4746
	private bool bool_0;

	// Token: 0x0400128B RID: 4747
	private bool bool_1;

	// Token: 0x0400128C RID: 4748
	private bool bool_2;

	// Token: 0x0400128D RID: 4749
	private bool bool_3;

	// Token: 0x0400128E RID: 4750
	private bool bool_4;

	// Token: 0x0400128F RID: 4751
	private bool bool_5;

	// Token: 0x04001290 RID: 4752
	private string string_2;

	// Token: 0x04001291 RID: 4753
	private string string_3;

	// Token: 0x04001292 RID: 4754
	private bool bool_6;
}
