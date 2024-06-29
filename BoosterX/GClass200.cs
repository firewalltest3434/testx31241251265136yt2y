using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x0200062E RID: 1582
public static class GClass200
{
	// Token: 0x0600220F RID: 8719
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern GEnum65 NtQueryTimerResolution(out uint uint_0, out uint uint_1, out uint uint_2);

	// Token: 0x06002210 RID: 8720
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern GEnum65 NtSetTimerResolution(uint uint_0, bool bool_0, ref uint uint_1);

	// Token: 0x06002211 RID: 8721 RVA: 0x0008A8F0 File Offset: 0x00088AF0
	public static GStruct2 smethod_0()
	{
		GStruct2 result = default(GStruct2);
		GClass200.NtQueryTimerResolution(out result.uint_0, out result.uint_1, out result.uint_2);
		return result;
	}

	// Token: 0x06002212 RID: 8722 RVA: 0x0008A924 File Offset: 0x00088B24
	public static ulong smethod_1(uint uint_0, bool bool_0)
	{
		uint num = 0U;
		GClass200.NtSetTimerResolution(uint_0, bool_0, ref num);
		return (ulong)num;
	}

	// Token: 0x06002213 RID: 8723
	[SuppressUnmanagedCodeSecurity]
	[DllImport("winmm.dll", SetLastError = true)]
	public static extern uint timeBeginPeriod(uint uint_0);

	// Token: 0x06002214 RID: 8724
	[SuppressUnmanagedCodeSecurity]
	[DllImport("winmm.dll", SetLastError = true)]
	public static extern uint timeEndPeriod(uint uint_0);
}
