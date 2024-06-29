using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000351 RID: 849
public sealed class GClass105
{
	// Token: 0x1700027E RID: 638
	// (get) Token: 0x06001332 RID: 4914 RVA: 0x0004E43C File Offset: 0x0004C63C
	// (set) Token: 0x06001333 RID: 4915 RVA: 0x0004E444 File Offset: 0x0004C644
	[JsonProperty("FirstAvailableDate")]
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

	// Token: 0x1700027F RID: 639
	// (get) Token: 0x06001334 RID: 4916 RVA: 0x0004E450 File Offset: 0x0004C650
	// (set) Token: 0x06001335 RID: 4917 RVA: 0x0004E458 File Offset: 0x0004C658
	[JsonProperty("SupportedLanguages")]
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

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x06001336 RID: 4918 RVA: 0x0004E464 File Offset: 0x0004C664
	// (set) Token: 0x06001337 RID: 4919 RVA: 0x0004E46C File Offset: 0x0004C66C
	[JsonProperty("PackageIds")]
	public object Object_0
	{
		get
		{
			return this.object_0;
		}
		set
		{
			this.object_0 = value;
		}
	}

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x06001338 RID: 4920 RVA: 0x0004E478 File Offset: 0x0004C678
	// (set) Token: 0x06001339 RID: 4921 RVA: 0x0004E480 File Offset: 0x0004C680
	[JsonProperty("Markets")]
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

	// Token: 0x04000BC0 RID: 3008
	private string string_0;

	// Token: 0x04000BC1 RID: 3009
	private List<string> list_0;

	// Token: 0x04000BC2 RID: 3010
	private object object_0;

	// Token: 0x04000BC3 RID: 3011
	private List<string> list_1;
}
