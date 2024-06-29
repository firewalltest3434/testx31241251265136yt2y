using System;
using System.Runtime.InteropServices;

// Token: 0x02000520 RID: 1312
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 8)]
public struct GStruct7
{
	// Token: 0x06001CE0 RID: 7392 RVA: 0x00075238 File Offset: 0x00073438
	public uint method_0()
	{
		return this.uint_2 & 1U;
	}

	// Token: 0x06001CE1 RID: 7393 RVA: 0x00075244 File Offset: 0x00073444
	public void method_1(uint uint_3)
	{
		this.uint_2 = (uint_3 | this.uint_2);
	}

	// Token: 0x0400141D RID: 5149
	public uint uint_0;

	// Token: 0x0400141E RID: 5150
	public uint uint_1;

	// Token: 0x0400141F RID: 5151
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_0;

	// Token: 0x04001420 RID: 5152
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_1;

	// Token: 0x04001421 RID: 5153
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_2;

	// Token: 0x04001422 RID: 5154
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_3;

	// Token: 0x04001423 RID: 5155
	private uint uint_2;
}
