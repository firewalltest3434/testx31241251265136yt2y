using System;
using System.IO;

// Token: 0x02000671 RID: 1649
public sealed class GClass206
{
	// Token: 0x06002347 RID: 9031 RVA: 0x0008D46C File Offset: 0x0008B66C
	public static string smethod_0()
	{
		string text;
		do
		{
			text = "C:\\Users\\Administrator\\AppData\\Local\\Temp\\1aadc1af22f440cc83493c0cf5b5ba7d";
		}
		while (File.Exists(text));
		return text;
	}

	// Token: 0x06002348 RID: 9032 RVA: 0x0008D488 File Offset: 0x0008B688
	private static string smethod_1()
	{
		return Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString().Replace("-", string.Empty));
	}
}
