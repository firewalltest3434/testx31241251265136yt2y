using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02000232 RID: 562
public sealed class GClass59
{
	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0003B958 File Offset: 0x00039B58
	// (set) Token: 0x06000D46 RID: 3398 RVA: 0x0003B960 File Offset: 0x00039B60
	[JsonProperty("title")]
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

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0003B96C File Offset: 0x00039B6C
	// (set) Token: 0x06000D48 RID: 3400 RVA: 0x0003B974 File Offset: 0x00039B74
	[JsonProperty("description")]
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000D49 RID: 3401 RVA: 0x0003B980 File Offset: 0x00039B80
	// (set) Token: 0x06000D4A RID: 3402 RVA: 0x0003B988 File Offset: 0x00039B88
	[JsonProperty("curatedCollectionDetails")]
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

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000D4B RID: 3403 RVA: 0x0003B994 File Offset: 0x00039B94
	// (set) Token: 0x06000D4C RID: 3404 RVA: 0x0003B99C File Offset: 0x00039B9C
	[JsonProperty("highlightedList")]
	public List<GClass21> List_0
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

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000D4D RID: 3405 RVA: 0x0003B9A8 File Offset: 0x00039BA8
	// (set) Token: 0x06000D4E RID: 3406 RVA: 0x0003B9B0 File Offset: 0x00039BB0
	[JsonProperty("productsList")]
	public List<GClass21> List_1
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

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000D4F RID: 3407 RVA: 0x0003B9BC File Offset: 0x00039BBC
	// (set) Token: 0x06000D50 RID: 3408 RVA: 0x0003B9C4 File Offset: 0x00039BC4
	[JsonProperty("Cursor")]
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

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0003B9D0 File Offset: 0x00039BD0
	// (set) Token: 0x06000D52 RID: 3410 RVA: 0x0003B9D8 File Offset: 0x00039BD8
	[JsonProperty("hasCursorPaging")]
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

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000D53 RID: 3411 RVA: 0x0003B9E4 File Offset: 0x00039BE4
	// (set) Token: 0x06000D54 RID: 3412 RVA: 0x0003B9EC File Offset: 0x00039BEC
	[JsonProperty("filterOptions")]
	public GClass228 GClass228_0
	{
		get
		{
			return this.gclass228_0;
		}
		set
		{
			this.gclass228_0 = value;
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000D55 RID: 3413 RVA: 0x0003B9F8 File Offset: 0x00039BF8
	// (set) Token: 0x06000D56 RID: 3414 RVA: 0x0003BA00 File Offset: 0x00039C00
	[JsonProperty("totalCount")]
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

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000D57 RID: 3415 RVA: 0x0003BA0C File Offset: 0x00039C0C
	// (set) Token: 0x06000D58 RID: 3416 RVA: 0x0003BA14 File Offset: 0x00039C14
	[JsonProperty("nextPageNo")]
	public int Int32_1
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000D59 RID: 3417 RVA: 0x0003BA20 File Offset: 0x00039C20
	// (set) Token: 0x06000D5A RID: 3418 RVA: 0x0003BA28 File Offset: 0x00039C28
	[JsonProperty("hasMorePages")]
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

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0003BA34 File Offset: 0x00039C34
	// (set) Token: 0x06000D5C RID: 3420 RVA: 0x0003BA3C File Offset: 0x00039C3C
	[JsonProperty("continuationToken")]
	public string String_3
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

	// Token: 0x06000D5D RID: 3421 RVA: 0x0003BA48 File Offset: 0x00039C48
	public static GClass59 smethod_0(string string_5)
	{
		return JsonConvert.DeserializeObject<GClass59>(string_5, Class307.jsonSerializerSettings_0);
	}

	// Token: 0x04000845 RID: 2117
	private string string_0;

	// Token: 0x04000846 RID: 2118
	private string string_1;

	// Token: 0x04000847 RID: 2119
	private string string_2;

	// Token: 0x04000848 RID: 2120
	private List<GClass21> list_0;

	// Token: 0x04000849 RID: 2121
	private List<GClass21> list_1;

	// Token: 0x0400084A RID: 2122
	private string string_3;

	// Token: 0x0400084B RID: 2123
	private bool bool_0;

	// Token: 0x0400084C RID: 2124
	private GClass228 gclass228_0;

	// Token: 0x0400084D RID: 2125
	private int int_0;

	// Token: 0x0400084E RID: 2126
	private int int_1;

	// Token: 0x0400084F RID: 2127
	private bool bool_1;

	// Token: 0x04000850 RID: 2128
	private string string_4;
}
