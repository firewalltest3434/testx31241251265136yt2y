using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02000126 RID: 294
public sealed class GClass34 : GClass32
{
	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060007C9 RID: 1993 RVA: 0x0002636C File Offset: 0x0002456C
	// (set) Token: 0x060007CA RID: 1994 RVA: 0x00026374 File Offset: 0x00024574
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

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060007CB RID: 1995 RVA: 0x00026380 File Offset: 0x00024580
	// (set) Token: 0x060007CC RID: 1996 RVA: 0x00026388 File Offset: 0x00024588
	[JsonProperty("filename")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return this.string_5;
		}
		[CompilerGenerated]
		set
		{
			this.string_5 = value;
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060007CD RID: 1997 RVA: 0x00026394 File Offset: 0x00024594
	// (set) Token: 0x060007CE RID: 1998 RVA: 0x0002639C File Offset: 0x0002459C
	[JsonProperty("purpose")]
	public string String_5
	{
		get
		{
			return this.string_6;
		}
		set
		{
			this.string_6 = value;
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060007CF RID: 1999 RVA: 0x000263A8 File Offset: 0x000245A8
	// (set) Token: 0x060007D0 RID: 2000 RVA: 0x000263B0 File Offset: 0x000245B0
	[JsonProperty("bytes")]
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

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060007D1 RID: 2001 RVA: 0x000263BC File Offset: 0x000245BC
	// (set) Token: 0x060007D2 RID: 2002 RVA: 0x000263C4 File Offset: 0x000245C4
	[JsonProperty("created_at")]
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

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060007D3 RID: 2003 RVA: 0x000263D0 File Offset: 0x000245D0
	// (set) Token: 0x060007D4 RID: 2004 RVA: 0x000263D8 File Offset: 0x000245D8
	[JsonProperty("deleted")]
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

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060007D5 RID: 2005 RVA: 0x000263E4 File Offset: 0x000245E4
	// (set) Token: 0x060007D6 RID: 2006 RVA: 0x000263EC File Offset: 0x000245EC
	[JsonProperty("status")]
	public string Status
	{
		[CompilerGenerated]
		get
		{
			return this.string_7;
		}
		[CompilerGenerated]
		set
		{
			this.string_7 = value;
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060007D7 RID: 2007 RVA: 0x000263F8 File Offset: 0x000245F8
	// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00026400 File Offset: 0x00024600
	[JsonProperty("status_details")]
	public string String_6
	{
		get
		{
			return this.string_8;
		}
		set
		{
			this.string_8 = value;
		}
	}

	// Token: 0x04000438 RID: 1080
	private string string_4;

	// Token: 0x04000439 RID: 1081
	private string string_5;

	// Token: 0x0400043A RID: 1082
	private string string_6;

	// Token: 0x0400043B RID: 1083
	private long long_0;

	// Token: 0x0400043C RID: 1084
	private long long_1;

	// Token: 0x0400043D RID: 1085
	private bool bool_0;

	// Token: 0x0400043E RID: 1086
	private string string_7;

	// Token: 0x0400043F RID: 1087
	private string string_8;
}
