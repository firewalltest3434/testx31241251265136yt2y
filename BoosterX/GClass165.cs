using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000571 RID: 1393
public sealed class GClass165
{
	// Token: 0x170004B9 RID: 1209
	// (get) Token: 0x06001E3B RID: 7739 RVA: 0x0007EA40 File Offset: 0x0007CC40
	// (set) Token: 0x06001E3C RID: 7740 RVA: 0x0007EA48 File Offset: 0x0007CC48
	[JsonProperty("OriginalReleaseDate")]
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

	// Token: 0x170004BA RID: 1210
	// (get) Token: 0x06001E3D RID: 7741 RVA: 0x0007EA54 File Offset: 0x0007CC54
	// (set) Token: 0x06001E3E RID: 7742 RVA: 0x0007EA5C File Offset: 0x0007CC5C
	[JsonProperty("OriginalReleaseDateFriendlyName")]
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

	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x06001E3F RID: 7743 RVA: 0x0007EA68 File Offset: 0x0007CC68
	// (set) Token: 0x06001E40 RID: 7744 RVA: 0x0007EA70 File Offset: 0x0007CC70
	[JsonProperty("MinimumUserAge")]
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

	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x06001E41 RID: 7745 RVA: 0x0007EA7C File Offset: 0x0007CC7C
	// (set) Token: 0x06001E42 RID: 7746 RVA: 0x0007EA84 File Offset: 0x0007CC84
	[JsonProperty("ContentRatings")]
	public List<GClass22> List_0
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

	// Token: 0x170004BD RID: 1213
	// (get) Token: 0x06001E43 RID: 7747 RVA: 0x0007EA90 File Offset: 0x0007CC90
	// (set) Token: 0x06001E44 RID: 7748 RVA: 0x0007EA98 File Offset: 0x0007CC98
	[JsonProperty("RelatedProducts")]
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

	// Token: 0x170004BE RID: 1214
	// (get) Token: 0x06001E45 RID: 7749 RVA: 0x0007EAA4 File Offset: 0x0007CCA4
	// (set) Token: 0x06001E46 RID: 7750 RVA: 0x0007EAAC File Offset: 0x0007CCAC
	[JsonProperty("UsageData")]
	public List<GClass156> List_2
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

	// Token: 0x170004BF RID: 1215
	// (get) Token: 0x06001E47 RID: 7751 RVA: 0x0007EAB8 File Offset: 0x0007CCB8
	// (set) Token: 0x06001E48 RID: 7752 RVA: 0x0007EAC0 File Offset: 0x0007CCC0
	[JsonProperty("BundleConfig")]
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

	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x06001E49 RID: 7753 RVA: 0x0007EACC File Offset: 0x0007CCCC
	// (set) Token: 0x06001E4A RID: 7754 RVA: 0x0007EAD4 File Offset: 0x0007CCD4
	[JsonProperty("Markets")]
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

	// Token: 0x0400155B RID: 5467
	private DateTime dateTime_0;

	// Token: 0x0400155C RID: 5468
	private string string_0;

	// Token: 0x0400155D RID: 5469
	private long long_0;

	// Token: 0x0400155E RID: 5470
	private List<GClass22> list_0;

	// Token: 0x0400155F RID: 5471
	private List<object> list_1;

	// Token: 0x04001560 RID: 5472
	private List<GClass156> list_2;

	// Token: 0x04001561 RID: 5473
	private object object_0;

	// Token: 0x04001562 RID: 5474
	private List<string> list_3;
}
