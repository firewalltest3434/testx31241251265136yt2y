using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

// Token: 0x02000226 RID: 550
public sealed class GClass37 : GClass32
{
	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0003AE44 File Offset: 0x00039044
	// (set) Token: 0x06000D13 RID: 3347 RVA: 0x0003AE4C File Offset: 0x0003904C
	[JsonProperty("results")]
	public List<GClass103> List_0
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

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0003AE58 File Offset: 0x00039058
	// (set) Token: 0x06000D15 RID: 3349 RVA: 0x0003AE60 File Offset: 0x00039060
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

	// Token: 0x06000D16 RID: 3350 RVA: 0x0003AE6C File Offset: 0x0003906C
	public override string ToString()
	{
		List<GClass103> list = this.List_0;
		if (list == null)
		{
			return null;
		}
		GClass103 gclass = list.First<GClass103>();
		if (gclass == null)
		{
			return null;
		}
		return gclass.MainContentFlag;
	}

	// Token: 0x04000829 RID: 2089
	private List<GClass103> list_0;

	// Token: 0x0400082A RID: 2090
	private string string_4;
}
