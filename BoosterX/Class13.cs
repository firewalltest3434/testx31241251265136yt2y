using System;

// Token: 0x02000010 RID: 16
internal static class Class13
{
	// Token: 0x0600005E RID: 94 RVA: 0x00002ED0 File Offset: 0x000010D0
	static Class13()
	{
		try
		{
			Class13.bool_0 = (Type.GetType("Mono.Runtime") != null);
		}
		catch
		{
			Class13.bool_0 = false;
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002F0C File Offset: 0x0000110C
	public static bool smethod_0()
	{
		return Class13.bool_0;
	}

	// Token: 0x04000020 RID: 32
	private static readonly bool bool_0;
}
