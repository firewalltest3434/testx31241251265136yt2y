using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020004A9 RID: 1193
public sealed class GClass140
{
	// Token: 0x170003F5 RID: 1013
	// (get) Token: 0x06001A42 RID: 6722 RVA: 0x0006C344 File Offset: 0x0006A544
	// (set) Token: 0x06001A43 RID: 6723 RVA: 0x0006C34C File Offset: 0x0006A54C
	[JsonProperty("type")]
	public string Type
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

	// Token: 0x170003F6 RID: 1014
	// (get) Token: 0x06001A44 RID: 6724 RVA: 0x0006C358 File Offset: 0x0006A558
	// (set) Token: 0x06001A45 RID: 6725 RVA: 0x0006C360 File Offset: 0x0006A560
	[JsonProperty("alternateIdType")]
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

	// Token: 0x170003F7 RID: 1015
	// (get) Token: 0x06001A46 RID: 6726 RVA: 0x0006C36C File Offset: 0x0006A56C
	// (set) Token: 0x06001A47 RID: 6727 RVA: 0x0006C374 File Offset: 0x0006A574
	[JsonProperty("alternateIdValue")]
	public string String_1
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

	// Token: 0x170003F8 RID: 1016
	// (get) Token: 0x06001A48 RID: 6728 RVA: 0x0006C380 File Offset: 0x0006A580
	// (set) Token: 0x06001A49 RID: 6729 RVA: 0x0006C388 File Offset: 0x0006A588
	[JsonProperty("alternatedIdTypeString")]
	public string String_2
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

	// Token: 0x04001275 RID: 4725
	private string string_0;

	// Token: 0x04001276 RID: 4726
	private string string_1;

	// Token: 0x04001277 RID: 4727
	private string string_2;

	// Token: 0x04001278 RID: 4728
	private string string_3;
}
