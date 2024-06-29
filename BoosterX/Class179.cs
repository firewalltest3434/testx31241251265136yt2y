using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02000144 RID: 324
internal sealed class Class179
{
	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000841 RID: 2113 RVA: 0x00028938 File Offset: 0x00026B38
	// (set) Token: 0x06000842 RID: 2114 RVA: 0x00028940 File Offset: 0x00026B40
	[JsonProperty("Command")]
	public string Command
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

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000843 RID: 2115 RVA: 0x0002894C File Offset: 0x00026B4C
	// (set) Token: 0x06000844 RID: 2116 RVA: 0x00028954 File Offset: 0x00026B54
	[JsonProperty("DefaultValue")]
	public string DefaultValue
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

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000845 RID: 2117 RVA: 0x00028960 File Offset: 0x00026B60
	// (set) Token: 0x06000846 RID: 2118 RVA: 0x00028968 File Offset: 0x00026B68
	[JsonProperty("IsCheat")]
	public bool IsCheat
	{
		[CompilerGenerated]
		get
		{
			return this.bool_0;
		}
		[CompilerGenerated]
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000847 RID: 2119 RVA: 0x00028974 File Offset: 0x00026B74
	// (set) Token: 0x06000848 RID: 2120 RVA: 0x0002897C File Offset: 0x00026B7C
	[JsonProperty("IsClient")]
	public bool IsClient
	{
		[CompilerGenerated]
		get
		{
			return this.bool_1;
		}
		[CompilerGenerated]
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000849 RID: 2121 RVA: 0x00028988 File Offset: 0x00026B88
	// (set) Token: 0x0600084A RID: 2122 RVA: 0x00028990 File Offset: 0x00026B90
	[JsonProperty("IsServer")]
	public bool IsServer
	{
		[CompilerGenerated]
		get
		{
			return this.bool_2;
		}
		[CompilerGenerated]
		set
		{
			this.bool_2 = value;
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x0600084B RID: 2123 RVA: 0x0002899C File Offset: 0x00026B9C
	// (set) Token: 0x0600084C RID: 2124 RVA: 0x000289A4 File Offset: 0x00026BA4
	[JsonProperty("Description")]
	public Dictionary<string, string> Description
	{
		[CompilerGenerated]
		get
		{
			return this.dictionary_0;
		}
		[CompilerGenerated]
		set
		{
			this.dictionary_0 = value;
		}
	}

	// Token: 0x0400049E RID: 1182
	private string string_0;

	// Token: 0x0400049F RID: 1183
	private string string_1;

	// Token: 0x040004A0 RID: 1184
	private bool bool_0;

	// Token: 0x040004A1 RID: 1185
	private bool bool_1;

	// Token: 0x040004A2 RID: 1186
	private bool bool_2;

	// Token: 0x040004A3 RID: 1187
	private Dictionary<string, string> dictionary_0;
}
