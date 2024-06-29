using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020000CB RID: 203
public sealed class GClass33 : GClass32
{
	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001EBA0 File Offset: 0x0001CDA0
	// (set) Token: 0x06000613 RID: 1555 RVA: 0x0001EBA8 File Offset: 0x0001CDA8
	[JsonProperty("id")]
	public string String_4
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000614 RID: 1556 RVA: 0x0001EBB4 File Offset: 0x0001CDB4
	// (set) Token: 0x06000615 RID: 1557 RVA: 0x0001EBBC File Offset: 0x0001CDBC
	[JsonProperty("choices")]
	public List<GClass68> List_0
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

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001EBC8 File Offset: 0x0001CDC8
	// (set) Token: 0x06000617 RID: 1559 RVA: 0x0001EBD0 File Offset: 0x0001CDD0
	[JsonProperty("usage")]
	public GClass30 GClass30_0
	{
		get
		{
			return this.gclass30_0;
		}
		set
		{
			this.gclass30_0 = value;
		}
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x0001EBDC File Offset: 0x0001CDDC
	public override string ToString()
	{
		if (this.List_0 != null && this.List_0.Count > 0)
		{
			return this.List_0[0].ToString();
		}
		return "CompletionResult " + this.String_4 + " has no valid output";
	}

	// Token: 0x0400028B RID: 651
	private string string_4;

	// Token: 0x0400028C RID: 652
	private List<GClass68> list_0;

	// Token: 0x0400028D RID: 653
	private GClass30 gclass30_0;
}
