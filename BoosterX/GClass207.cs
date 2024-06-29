using System;
using System.IO;
using Newtonsoft.Json;

// Token: 0x02000674 RID: 1652
public class GClass207
{
	// Token: 0x06002350 RID: 9040 RVA: 0x0008D504 File Offset: 0x0008B704
	public T method_0<T>(string string_0)
	{
		return JsonConvert.DeserializeObject<T>(File.ReadAllText(string_0));
	}

	// Token: 0x06002351 RID: 9041 RVA: 0x0008D514 File Offset: 0x0008B714
	public void method_1<T>(string string_0, T gparam_0)
	{
		string contents = JsonConvert.SerializeObject(gparam_0, 1);
		File.WriteAllText(string_0, contents);
	}

	// Token: 0x06002352 RID: 9042 RVA: 0x0008D538 File Offset: 0x0008B738
	public T method_2<T>(string string_0)
	{
		return JsonConvert.DeserializeObject<T>(GClass40.smethod_0(string_0));
	}
}
