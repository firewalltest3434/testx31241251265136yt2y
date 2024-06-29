using System;

// Token: 0x0200027B RID: 635
internal static class Class321
{
	// Token: 0x06000EBF RID: 3775 RVA: 0x0003F9B8 File Offset: 0x0003DBB8
	public static bool? smethod_0(this string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		return new bool?(bool.Parse(string_0));
	}
}
