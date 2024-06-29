using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000149 RID: 329
public sealed class GClass18
{
	// Token: 0x1700008B RID: 139
	// (get) Token: 0x0600085E RID: 2142 RVA: 0x00028A44 File Offset: 0x00026C44
	// (set) Token: 0x0600085F RID: 2143 RVA: 0x00028A4C File Offset: 0x00026C4C
	[JsonProperty("Product")]
	public GClass209 GClass209_0
	{
		get
		{
			return this.gclass209_0;
		}
		set
		{
			this.gclass209_0 = value;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000860 RID: 2144 RVA: 0x00028A58 File Offset: 0x00026C58
	// (set) Token: 0x06000861 RID: 2145 RVA: 0x00028A60 File Offset: 0x00026C60
	[JsonProperty("BigIds")]
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

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x06000862 RID: 2146 RVA: 0x00028A6C File Offset: 0x00026C6C
	// (set) Token: 0x06000863 RID: 2147 RVA: 0x00028A74 File Offset: 0x00026C74
	[JsonProperty("HasMorePages")]
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

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06000864 RID: 2148 RVA: 0x00028A80 File Offset: 0x00026C80
	// (set) Token: 0x06000865 RID: 2149 RVA: 0x00028A88 File Offset: 0x00026C88
	[JsonProperty("Products")]
	public List<GClass209> List_1
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

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000866 RID: 2150 RVA: 0x00028A94 File Offset: 0x00026C94
	// (set) Token: 0x06000867 RID: 2151 RVA: 0x00028A9C File Offset: 0x00026C9C
	[JsonProperty("TotalResultCount")]
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

	// Token: 0x06000868 RID: 2152 RVA: 0x00028AA8 File Offset: 0x00026CA8
	public static GClass18 smethod_0(string string_0)
	{
		return JsonConvert.DeserializeObject<GClass18>(string_0, GClass0.jsonSerializerSettings_0);
	}

	// Token: 0x040004AA RID: 1194
	private GClass209 gclass209_0;

	// Token: 0x040004AB RID: 1195
	private List<string> list_0;

	// Token: 0x040004AC RID: 1196
	private bool bool_0;

	// Token: 0x040004AD RID: 1197
	private List<GClass209> list_1;

	// Token: 0x040004AE RID: 1198
	private int int_0;
}
