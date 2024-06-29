using System;
using System.Diagnostics;

// Token: 0x020004AA RID: 1194
public sealed class GClass141
{
	// Token: 0x06001A4A RID: 6730 RVA: 0x0006C394 File Offset: 0x0006A594
	private GClass141()
	{
	}

	// Token: 0x06001A4B RID: 6731 RVA: 0x0006C39C File Offset: 0x0006A59C
	public static void smethod_0(Exception exception_0)
	{
		Trace.WriteLine(exception_0);
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x0006C3A4 File Offset: 0x0006A5A4
	public static void smethod_1(string string_0)
	{
		Trace.WriteLine(string_0);
	}

	// Token: 0x06001A4D RID: 6733 RVA: 0x0006C3AC File Offset: 0x0006A5AC
	public static void smethod_2(string string_0, Exception exception_0)
	{
		Trace.WriteLine(string_0);
		Trace.WriteLine(exception_0);
	}
}
