using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

// Token: 0x020004B2 RID: 1202
[JsonObject]
public sealed class GClass143
{
	// Token: 0x06001A7A RID: 6778 RVA: 0x0006C9B4 File Offset: 0x0006ABB4
	public void method_0(string string_0)
	{
		byte[] bytes = GClass210.smethod_0<GClass143>(this, Encoding.UTF8);
		File.WriteAllBytes(string_0, bytes);
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x0006C9D4 File Offset: 0x0006ABD4
	public static GClass143 smethod_0(string string_0)
	{
		return JsonConvert.DeserializeObject<GClass143>(string_0);
	}

	// Token: 0x04001293 RID: 4755
	[JsonProperty("Settings")]
	public List<GClass150> list_0 = new List<GClass150>();
}
