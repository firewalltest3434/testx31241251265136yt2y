using System;
using System.Runtime.CompilerServices;

// Token: 0x02000099 RID: 153
internal static class Class101
{
	// Token: 0x060004E7 RID: 1255 RVA: 0x000196B0 File Offset: 0x000178B0
	public static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		Class101.delegate22_0(array_0, runtimeFieldHandle_0);
	}

	// Token: 0x04000137 RID: 311
	private static readonly Class101.Delegate22 delegate22_0 = new Class101.Delegate22(RuntimeHelpers.InitializeArray);

	// Token: 0x0200009A RID: 154
	// (Invoke) Token: 0x060004E9 RID: 1257
	private delegate void Delegate22(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0);
}
