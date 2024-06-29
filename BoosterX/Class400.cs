using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000365 RID: 869
internal sealed class Class400
{
	// Token: 0x0600137E RID: 4990 RVA: 0x00051A4C File Offset: 0x0004FC4C
	public static void smethod_0(string string_0)
	{
		string text = string_0;
		if (string_0.EndsWith(".lnk"))
		{
			Class400.Class401 @class = new Class400.Class401();
			((Class400.Interface11)@class).imethod_3(string_0, 0U);
			StringBuilder stringBuilder = new StringBuilder(260);
			Class400.Struct177 @struct = default(Class400.Struct177);
			((Class400.Interface13)@class).imethod_0(stringBuilder, stringBuilder.Capacity, out @struct, (Class400.Enum16)0);
			text = stringBuilder.ToString();
		}
		if (text.EndsWith(".reg"))
		{
			GClass104.smethod_1("cmd.exe /c \"" + text + "\"", false);
			return;
		}
		if (text.EndsWith(".bat"))
		{
			GClass104.smethod_1("cmd.exe /c \"" + text + "\"", true);
			return;
		}
		if (text.EndsWith(".ps1"))
		{
			GClass104.smethod_1("cmd.exe /c \"" + text + "\"", true);
			return;
		}
		GClass104.smethod_1(text, true);
	}

	// Token: 0x0600137F RID: 4991
	[DllImport("shfolder.dll", CharSet = CharSet.Auto)]
	internal static extern int SHGetFolderPath(IntPtr intptr_0, int int_0, IntPtr intptr_1, int int_1, StringBuilder stringBuilder_0);

	// Token: 0x02000366 RID: 870
	[Guid("0000010b-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface Interface11 : Class400.Interface12
	{
		// Token: 0x06001380 RID: 4992
		void imethod_1(out Guid guid_0);

		// Token: 0x06001381 RID: 4993
		[PreserveSig]
		int imethod_2();

		// Token: 0x06001382 RID: 4994
		[PreserveSig]
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, uint uint_0);

		// Token: 0x06001383 RID: 4995
		[PreserveSig]
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

		// Token: 0x06001384 RID: 4996
		[PreserveSig]
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

		// Token: 0x06001385 RID: 4997
		[PreserveSig]
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);
	}

	// Token: 0x02000367 RID: 871
	private enum Enum16
	{

	}

	// Token: 0x02000368 RID: 872
	[Guid("00021401-0000-0000-C000-000000000046")]
	[ComImport]
	public sealed class Class401
	{
		// Token: 0x06001386 RID: 4998
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Class401();
	}

	// Token: 0x02000369 RID: 873
	[Guid("0000010c-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface Interface12
	{
		// Token: 0x06001387 RID: 4999
		[PreserveSig]
		void imethod_0(out Guid guid_0);
	}

	// Token: 0x0200036A RID: 874
	[Guid("000214F9-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	private interface Interface13
	{
		// Token: 0x06001388 RID: 5000
		void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out Class400.Struct177 struct177_0, Class400.Enum16 enum16_0);

		// Token: 0x06001389 RID: 5001
		void imethod_1(out IntPtr intptr_0);

		// Token: 0x0600138A RID: 5002
		void imethod_2(IntPtr intptr_0);

		// Token: 0x0600138B RID: 5003
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x0600138C RID: 5004
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x0600138D RID: 5005
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x0600138E RID: 5006
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x0600138F RID: 5007
		void imethod_7([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06001390 RID: 5008
		void imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06001391 RID: 5009
		void imethod_9(out short short_0);

		// Token: 0x06001392 RID: 5010
		void imethod_10(short short_0);

		// Token: 0x06001393 RID: 5011
		void imethod_11(out int int_0);

		// Token: 0x06001394 RID: 5012
		void imethod_12(int int_0);

		// Token: 0x06001395 RID: 5013
		void imethod_13([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out int int_1);

		// Token: 0x06001396 RID: 5014
		void imethod_14([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x06001397 RID: 5015
		void imethod_15([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x06001398 RID: 5016
		void imethod_16(IntPtr intptr_0, Class400.Enum17 enum17_0);

		// Token: 0x06001399 RID: 5017
		void imethod_17([MarshalAs(UnmanagedType.LPWStr)] string string_0);
	}

	// Token: 0x0200036B RID: 875
	private enum Enum17
	{

	}

	// Token: 0x0200036C RID: 876
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct Struct177
	{
		// Token: 0x04000BE9 RID: 3049
		public uint uint_0;

		// Token: 0x04000BEA RID: 3050
		public long long_0;

		// Token: 0x04000BEB RID: 3051
		public long long_1;

		// Token: 0x04000BEC RID: 3052
		public long long_2;

		// Token: 0x04000BED RID: 3053
		public uint uint_1;

		// Token: 0x04000BEE RID: 3054
		public uint uint_2;

		// Token: 0x04000BEF RID: 3055
		public uint uint_3;

		// Token: 0x04000BF0 RID: 3056
		public uint uint_4;

		// Token: 0x04000BF1 RID: 3057
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		// Token: 0x04000BF2 RID: 3058
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string string_1;
	}
}
