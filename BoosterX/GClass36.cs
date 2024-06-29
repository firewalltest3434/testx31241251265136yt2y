using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000167 RID: 359
public sealed class GClass36 : GClass32
{
	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x0600096C RID: 2412 RVA: 0x0002B674 File Offset: 0x00029874
	// (set) Token: 0x0600096D RID: 2413 RVA: 0x0002B67C File Offset: 0x0002987C
	[JsonProperty("data")]
	public List<GClass117> List_0
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

	// Token: 0x0600096E RID: 2414 RVA: 0x0002B688 File Offset: 0x00029888
	public override string ToString()
	{
		List<GClass117> list = this.List_0;
		if (list != null && list.Count > 0)
		{
			return this.List_0[0].String_0 ?? this.List_0[0].String_1;
		}
		return null;
	}

	// Token: 0x04000566 RID: 1382
	private List<GClass117> list_0;
}
