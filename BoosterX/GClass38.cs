using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020002CE RID: 718
public sealed class GClass38 : GClass32
{
	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x06001098 RID: 4248 RVA: 0x000461C0 File Offset: 0x000443C0
	// (set) Token: 0x06001099 RID: 4249 RVA: 0x000461C8 File Offset: 0x000443C8
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

	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x0600109A RID: 4250 RVA: 0x000461D4 File Offset: 0x000443D4
	// (set) Token: 0x0600109B RID: 4251 RVA: 0x000461DC File Offset: 0x000443DC
	[JsonProperty("choices")]
	public IReadOnlyList<GClass70> IReadOnlyList_0
	{
		get
		{
			return this.ireadOnlyList_0;
		}
		set
		{
			this.ireadOnlyList_0 = value;
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x0600109C RID: 4252 RVA: 0x000461E8 File Offset: 0x000443E8
	// (set) Token: 0x0600109D RID: 4253 RVA: 0x000461F0 File Offset: 0x000443F0
	[JsonProperty("usage")]
	public GClass31 GClass31_0
	{
		get
		{
			return this.gclass31_0;
		}
		set
		{
			this.gclass31_0 = value;
		}
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x000461FC File Offset: 0x000443FC
	public override string ToString()
	{
		if (this.IReadOnlyList_0 != null && this.IReadOnlyList_0.Count > 0)
		{
			return this.IReadOnlyList_0[0].ToString();
		}
		return null;
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x0600109F RID: 4255 RVA: 0x00046228 File Offset: 0x00044428
	// (set) Token: 0x060010A0 RID: 4256 RVA: 0x00046230 File Offset: 0x00044430
	[JsonProperty("system_fingerprint")]
	public string String_5
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
		}
	}

	// Token: 0x040009EE RID: 2542
	private string string_4;

	// Token: 0x040009EF RID: 2543
	private IReadOnlyList<GClass70> ireadOnlyList_0;

	// Token: 0x040009F0 RID: 2544
	private GClass31 gclass31_0;

	// Token: 0x040009F1 RID: 2545
	private string string_5;
}
