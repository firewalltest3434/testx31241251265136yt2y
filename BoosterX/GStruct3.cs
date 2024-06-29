using System;
using System.Runtime.InteropServices;

// Token: 0x0200027A RID: 634
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 8)]
public struct GStruct3
{
	// Token: 0x04000902 RID: 2306
	public uint uint_0;

	// Token: 0x04000903 RID: 2307
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_0;

	// Token: 0x04000904 RID: 2308
	public GEnum79 genum79_0;

	// Token: 0x04000905 RID: 2309
	public uint uint_1;

	// Token: 0x04000906 RID: 2310
	public uint uint_2;

	// Token: 0x04000907 RID: 2311
	public uint uint_3;
}
