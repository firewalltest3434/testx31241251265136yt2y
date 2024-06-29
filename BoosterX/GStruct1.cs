using System;
using System.Runtime.InteropServices;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x02000150 RID: 336
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 8)]
public struct GStruct1
{
	// Token: 0x040004C7 RID: 1223
	public uint uint_0;

	// Token: 0x040004C8 RID: 1224
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string string_0;

	// Token: 0x040004C9 RID: 1225
	public uint uint_1;

	// Token: 0x040004CA RID: 1226
	public NVDRS_SETTING_TYPE nvdrs_SETTING_TYPE_0;

	// Token: 0x040004CB RID: 1227
	public GEnum1 genum1_0;

	// Token: 0x040004CC RID: 1228
	public uint uint_2;

	// Token: 0x040004CD RID: 1229
	public uint uint_3;

	// Token: 0x040004CE RID: 1230
	public NVDRS_SETTING_UNION nvdrs_SETTING_UNION_0;

	// Token: 0x040004CF RID: 1231
	public NVDRS_SETTING_UNION nvdrs_SETTING_UNION_1;
}
