using System;
using Newtonsoft.Json;

// Token: 0x02000626 RID: 1574
public static class GClass199
{
	// Token: 0x060021F8 RID: 8696 RVA: 0x0008A2A0 File Offset: 0x000884A0
	public static string smethod_0(this GClass18 gclass18_0)
	{
		return JsonConvert.SerializeObject(gclass18_0, GClass0.jsonSerializerSettings_0);
	}
}
