using System;
using System.Text;
using Newtonsoft.Json;

// Token: 0x02000676 RID: 1654
public sealed class GClass210
{
	// Token: 0x06002391 RID: 9105 RVA: 0x0008D7B0 File Offset: 0x0008B9B0
	public static byte[] smethod_0<T>(T gparam_0, Encoding encoding_0)
	{
		string s = JsonConvert.SerializeObject(gparam_0, 0);
		return encoding_0.GetBytes(s).smethod_0();
	}

	// Token: 0x06002392 RID: 9106 RVA: 0x0008D7D8 File Offset: 0x0008B9D8
	public static T smethod_1<T>(byte[] byte_0, Encoding encoding_0)
	{
		byte[] bytes = byte_0.smethod_1();
		return JsonConvert.DeserializeObject<T>(encoding_0.GetString(bytes));
	}
}
