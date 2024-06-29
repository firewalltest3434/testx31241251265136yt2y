using System;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000401 RID: 1025
internal static class Class467
{
	// Token: 0x0600162E RID: 5678 RVA: 0x0005D944 File Offset: 0x0005BB44
	internal static byte[] smethod_0(string string_0)
	{
		return MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(string_0));
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x0005D95C File Offset: 0x0005BB5C
	internal static string smethod_1(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte b in Class467.smethod_0(string_0))
		{
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString();
	}
}
