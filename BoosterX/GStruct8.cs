using System;
using System.Runtime.InteropServices;

// Token: 0x0200052C RID: 1324
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 8)]
public struct GStruct8
{
	// Token: 0x04001456 RID: 5206
	public uint uint_0;

	// Token: 0x04001457 RID: 5207
	public uint uint_1;

	// Token: 0x04001458 RID: 5208
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_0;

	// Token: 0x04001459 RID: 5209
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_1;

	// Token: 0x0400145A RID: 5210
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_2;
}
