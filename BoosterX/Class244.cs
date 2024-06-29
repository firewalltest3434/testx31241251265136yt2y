using System;
using System.Runtime.InteropServices;

// Token: 0x020001BE RID: 446
internal static class Class244
{
	// Token: 0x06000AAE RID: 2734
	[DllImport("ntdll.dll")]
	internal static extern uint NtSetSystemInformation(int int_0, IntPtr intptr_0, int int_1);

	// Token: 0x06000AAF RID: 2735
	[DllImport("psapi.dll")]
	internal static extern int EmptyWorkingSet(IntPtr intptr_0);

	// Token: 0x06000AB0 RID: 2736
	[DllImport("user32.dll")]
	internal static extern bool RegisterHotKey(IntPtr intptr_0, int int_0, uint uint_0, uint uint_1);

	// Token: 0x06000AB1 RID: 2737
	[DllImport("user32.dll")]
	internal static extern bool UnregisterHotKey(IntPtr intptr_0, int int_0);

	// Token: 0x06000AB2 RID: 2738
	[DllImport("user32.dll")]
	internal static extern bool OpenClipboard(IntPtr intptr_0);

	// Token: 0x06000AB3 RID: 2739
	[DllImport("user32.dll")]
	internal static extern bool EmptyClipboard();

	// Token: 0x06000AB4 RID: 2740
	[DllImport("user32.dll")]
	internal static extern bool CloseClipboard();
}
