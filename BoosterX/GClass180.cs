using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020005AC RID: 1452
public sealed class GClass180
{
	// Token: 0x170004EE RID: 1262
	// (get) Token: 0x06001F63 RID: 8035 RVA: 0x000815A4 File Offset: 0x0007F7A4
	// (set) Token: 0x06001F64 RID: 8036 RVA: 0x000815AC File Offset: 0x0007F7AC
	[JsonProperty("Results")]
	public List<GClass201> List_0
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

	// Token: 0x170004EF RID: 1263
	// (get) Token: 0x06001F65 RID: 8037 RVA: 0x000815B8 File Offset: 0x0007F7B8
	// (set) Token: 0x06001F66 RID: 8038 RVA: 0x000815C0 File Offset: 0x0007F7C0
	[JsonProperty("TotalResultCount")]
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

	// Token: 0x06001F67 RID: 8039 RVA: 0x000815CC File Offset: 0x0007F7CC
	public static GClass180 smethod_0(string string_0)
	{
		return JsonConvert.DeserializeObject<GClass180>(string_0, Class307.jsonSerializerSettings_0);
	}

	// Token: 0x040015F5 RID: 5621
	private List<GClass201> list_0;

	// Token: 0x040015F6 RID: 5622
	private long long_0;
}
