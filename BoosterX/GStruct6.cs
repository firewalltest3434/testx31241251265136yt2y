using System;
using System.Runtime.InteropServices;

// Token: 0x02000344 RID: 836
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 8)]
public struct GStruct6
{
	// Token: 0x04000B98 RID: 2968
	public uint uint_0;

	// Token: 0x04000B99 RID: 2969
	public uint uint_1;

	// Token: 0x04000B9A RID: 2970
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_0;

	// Token: 0x04000B9B RID: 2971
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_1;

	// Token: 0x04000B9C RID: 2972
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_2;

	// Token: 0x04000B9D RID: 2973
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_3;
}
