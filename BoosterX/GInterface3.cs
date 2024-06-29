using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000287 RID: 647
[Guid("EA502723-A23D-11d1-A7D3-0000F87571E3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface3
{
	// Token: 0x06000EF5 RID: 3829
	uint imethod_0([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] string string_1, uint uint_0);

	// Token: 0x06000EF6 RID: 3830
	uint imethod_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0);

	// Token: 0x06000EF7 RID: 3831
	uint imethod_2(uint uint_0);

	// Token: 0x06000EF8 RID: 3832
	uint imethod_3([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0);

	// Token: 0x06000EF9 RID: 3833
	uint imethod_4([MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, [MarshalAs(UnmanagedType.LPStruct)] Guid guid_1);

	// Token: 0x06000EFA RID: 3834
	uint imethod_5();

	// Token: 0x06000EFB RID: 3835
	uint imethod_6([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000EFC RID: 3836
	uint imethod_7([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000EFD RID: 3837
	uint imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

	// Token: 0x06000EFE RID: 3838
	uint imethod_9([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000EFF RID: 3839
	uint imethod_10(uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000F00 RID: 3840
	uint imethod_11(uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000F01 RID: 3841
	uint imethod_12(uint uint_0, out IntPtr intptr_0);

	// Token: 0x06000F02 RID: 3842
	uint imethod_13(out uint uint_0);

	// Token: 0x06000F03 RID: 3843
	uint imethod_14(uint uint_0, uint uint_1);

	// Token: 0x06000F04 RID: 3844
	uint imethod_15(out IntPtr intptr_0);

	// Token: 0x06000F05 RID: 3845
	uint imethod_16([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000F06 RID: 3846
	uint imethod_17(out IntPtr intptr_0);
}
