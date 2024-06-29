using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200014E RID: 334
public sealed class GClass19
{
	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000875 RID: 2165 RVA: 0x00028E08 File Offset: 0x00027008
	// (set) Token: 0x06000876 RID: 2166 RVA: 0x00028E10 File Offset: 0x00027010
	[JsonProperty("Actions")]
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

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000877 RID: 2167 RVA: 0x00028E1C File Offset: 0x0002701C
	// (set) Token: 0x06000878 RID: 2168 RVA: 0x00028E24 File Offset: 0x00027024
	[JsonProperty("AvailabilityASchema")]
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

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000879 RID: 2169 RVA: 0x00028E30 File Offset: 0x00027030
	// (set) Token: 0x0600087A RID: 2170 RVA: 0x00028E38 File Offset: 0x00027038
	[JsonProperty("AvailabilityBSchema")]
	public string String_1
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

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x0600087B RID: 2171 RVA: 0x00028E44 File Offset: 0x00027044
	// (set) Token: 0x0600087C RID: 2172 RVA: 0x00028E4C File Offset: 0x0002704C
	[JsonProperty("AvailabilityId")]
	public string String_2
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

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x0600087D RID: 2173 RVA: 0x00028E58 File Offset: 0x00027058
	// (set) Token: 0x0600087E RID: 2174 RVA: 0x00028E60 File Offset: 0x00027060
	[JsonProperty("Conditions")]
	public GClass60 GClass60_0
	{
		get
		{
			return this.gclass60_0;
		}
		set
		{
			this.gclass60_0 = value;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x0600087F RID: 2175 RVA: 0x00028E6C File Offset: 0x0002706C
	// (set) Token: 0x06000880 RID: 2176 RVA: 0x00028E74 File Offset: 0x00027074
	[JsonProperty("LastModifiedDate")]
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

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000881 RID: 2177 RVA: 0x00028E80 File Offset: 0x00027080
	// (set) Token: 0x06000882 RID: 2178 RVA: 0x00028E88 File Offset: 0x00027088
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

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000883 RID: 2179 RVA: 0x00028E94 File Offset: 0x00027094
	// (set) Token: 0x06000884 RID: 2180 RVA: 0x00028E9C File Offset: 0x0002709C
	[JsonProperty("OrderManagementData")]
	public GClass17 GClass17_0
	{
		get
		{
			return this.gclass17_0;
		}
		set
		{
			this.gclass17_0 = value;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06000885 RID: 2181 RVA: 0x00028EA8 File Offset: 0x000270A8
	// (set) Token: 0x06000886 RID: 2182 RVA: 0x00028EB0 File Offset: 0x000270B0
	[JsonProperty("Properties")]
	public GClass100 GClass100_0
	{
		get
		{
			return this.gclass100_0;
		}
		set
		{
			this.gclass100_0 = value;
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000887 RID: 2183 RVA: 0x00028EBC File Offset: 0x000270BC
	// (set) Token: 0x06000888 RID: 2184 RVA: 0x00028EC4 File Offset: 0x000270C4
	[JsonProperty("SkuId")]
	public string String_3
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

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000889 RID: 2185 RVA: 0x00028ED0 File Offset: 0x000270D0
	// (set) Token: 0x0600088A RID: 2186 RVA: 0x00028ED8 File Offset: 0x000270D8
	[JsonProperty("DisplayRank")]
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

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x0600088B RID: 2187 RVA: 0x00028EE4 File Offset: 0x000270E4
	// (set) Token: 0x0600088C RID: 2188 RVA: 0x00028EEC File Offset: 0x000270EC
	[JsonProperty("RemediationRequired")]
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

	// Token: 0x040004BB RID: 1211
	private List<string> list_0;

	// Token: 0x040004BC RID: 1212
	private string string_0;

	// Token: 0x040004BD RID: 1213
	private string string_1;

	// Token: 0x040004BE RID: 1214
	private string string_2;

	// Token: 0x040004BF RID: 1215
	private GClass60 gclass60_0;

	// Token: 0x040004C0 RID: 1216
	private DateTime dateTime_0;

	// Token: 0x040004C1 RID: 1217
	private List<string> list_1;

	// Token: 0x040004C2 RID: 1218
	private GClass17 gclass17_0;

	// Token: 0x040004C3 RID: 1219
	private GClass100 gclass100_0;

	// Token: 0x040004C4 RID: 1220
	private string string_3;

	// Token: 0x040004C5 RID: 1221
	private long long_0;

	// Token: 0x040004C6 RID: 1222
	private bool bool_0;
}
