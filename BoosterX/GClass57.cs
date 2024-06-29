using System;
using System.Security.Principal;

// Token: 0x0200022F RID: 559
public sealed class GClass57
{
	// Token: 0x06000D39 RID: 3385 RVA: 0x0003B86C File Offset: 0x00039A6C
	public static bool smethod_0()
	{
		return GClass57.bool_0;
	}

	// Token: 0x0400083F RID: 2111
	private static bool bool_0 = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
}
