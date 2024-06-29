using System;
using System.Runtime.InteropServices;

namespace NvidiaX.NVIDIA.Native.NVAPI
{
	// Token: 0x0200084C RID: 2124
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct NVDRS_SETTING_VALUES
	{
		// Token: 0x0400218F RID: 8591
		public uint version;

		// Token: 0x04002190 RID: 8592
		public uint numSettingValues;

		// Token: 0x04002191 RID: 8593
		public NVDRS_SETTING_TYPE settingType;

		// Token: 0x04002192 RID: 8594
		public NVDRS_SETTING_UNION defaultValue;

		// Token: 0x04002193 RID: 8595
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
		public NVDRS_SETTING_UNION[] settingValues;
	}
}
