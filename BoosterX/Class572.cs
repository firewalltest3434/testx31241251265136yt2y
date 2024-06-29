using System;
using System.Runtime.InteropServices;

// Token: 0x020004CB RID: 1227
internal static class Class572
{
	// Token: 0x06001AE9 RID: 6889
	[DllImport("Wintrust.dll")]
	private static extern uint WinVerifyTrust(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	// Token: 0x06001AEA RID: 6890 RVA: 0x0006EE94 File Offset: 0x0006D094
	private static uint smethod_0(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (uint)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebiN()KOV", object_);
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x0006EECC File Offset: 0x0006D0CC
	public static bool smethod_1(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (bool)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebi'()KUX", object_);
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x0006EF04 File Offset: 0x0006D104
	public static bool smethod_2(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (bool)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebgW()I,h", object_);
	}
}
