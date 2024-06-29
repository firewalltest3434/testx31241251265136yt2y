using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000858 RID: 2136
public sealed class dje_zQE7X9KAD45FPNM2_ejd
{
	// Token: 0x06002BC2 RID: 11202
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr RegisterDeviceNotification(IntPtr intptr_0, dje_zQE7X9KAD45FPNM2_ejd.GClass233 gclass233_0, uint uint_0);

	// Token: 0x06002BC3 RID: 11203
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern uint UnregisterDeviceNotification(IntPtr intptr_0);

	// Token: 0x06002BC4 RID: 11204
	[DllImport("setupapi.dll", SetLastError = true)]
	public static extern IntPtr SetupDiGetClassDevs(ref Guid guid_0, uint uint_0, IntPtr intptr_0, uint uint_1);

	// Token: 0x06002BC5 RID: 11205
	[DllImport("setupapi.dll", SetLastError = true)]
	public static extern int SetupDiDestroyDeviceInfoList(IntPtr intptr_0);

	// Token: 0x06002BC6 RID: 11206
	[DllImport("setupapi.dll", SetLastError = true)]
	public static extern bool SetupDiEnumDeviceInfo(IntPtr intptr_0, uint uint_0, dje_zQE7X9KAD45FPNM2_ejd.GClass231 gclass231_0);

	// Token: 0x06002BC7 RID: 11207
	[DllImport("setupapi.dll", SetLastError = true)]
	public static extern bool SetupDiGetDeviceRegistryProperty(IntPtr intptr_0, dje_zQE7X9KAD45FPNM2_ejd.GClass231 gclass231_0, uint uint_0, uint uint_1, StringBuilder stringBuilder_0, uint uint_2, IntPtr intptr_1);

	// Token: 0x06002BC8 RID: 11208
	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SetupDiSetClassInstallParams(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

	// Token: 0x06002BC9 RID: 11209
	[DllImport("setupapi.dll", CharSet = CharSet.Auto)]
	public static extern bool SetupDiCallClassInstaller(uint uint_0, IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x06002BCA RID: 11210
	[DllImport("setupapi.dll", SetLastError = true)]
	public static extern int CM_Get_DevNode_Status(out uint uint_0, out uint uint_1, uint uint_2, int int_0);

	// Token: 0x06002BCB RID: 11211
	[DllImport("setupapi.dll", SetLastError = true)]
	public static extern bool SetupDiChangeState(IntPtr intptr_0, [In] ref dje_zQE7X9KAD45FPNM2_ejd.GClass231 gclass231_0);

	// Token: 0x02000859 RID: 2137
	[StructLayout(LayoutKind.Sequential)]
	public sealed class GClass231
	{
		// Token: 0x040021D2 RID: 8658
		public int int_0;

		// Token: 0x040021D3 RID: 8659
		public Guid guid_0;

		// Token: 0x040021D4 RID: 8660
		public uint uint_0;

		// Token: 0x040021D5 RID: 8661
		public ulong ulong_0;
	}

	// Token: 0x0200085A RID: 2138
	[StructLayout(LayoutKind.Sequential)]
	public sealed class GClass232
	{
		// Token: 0x040021D6 RID: 8662
		public int int_0;

		// Token: 0x040021D7 RID: 8663
		public int int_1;

		// Token: 0x040021D8 RID: 8664
		public int int_2;

		// Token: 0x040021D9 RID: 8665
		public IntPtr intptr_0;

		// Token: 0x040021DA RID: 8666
		public IntPtr intptr_1;

		// Token: 0x040021DB RID: 8667
		public IntPtr intptr_2;

		// Token: 0x040021DC RID: 8668
		public IntPtr intptr_3;

		// Token: 0x040021DD RID: 8669
		public IntPtr intptr_4;

		// Token: 0x040021DE RID: 8670
		public int int_3;

		// Token: 0x040021DF RID: 8671
		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_0;
	}

	// Token: 0x0200085B RID: 2139
	[StructLayout(LayoutKind.Sequential)]
	public sealed class GClass233
	{
		// Token: 0x040021E0 RID: 8672
		public int int_0;

		// Token: 0x040021E1 RID: 8673
		public int int_1;

		// Token: 0x040021E2 RID: 8674
		public int int_2;
	}

	// Token: 0x0200085C RID: 2140
	public struct GStruct12
	{
		// Token: 0x040021E3 RID: 8675
		public int int_0;

		// Token: 0x040021E4 RID: 8676
		public int int_1;

		// Token: 0x040021E5 RID: 8677
		public int int_2;

		// Token: 0x040021E6 RID: 8678
		public IntPtr intptr_0;

		// Token: 0x040021E7 RID: 8679
		public IntPtr intptr_1;

		// Token: 0x040021E8 RID: 8680
		public Guid guid_0;

		// Token: 0x040021E9 RID: 8681
		public long long_0;

		// Token: 0x040021EA RID: 8682
		public byte byte_0;

		// Token: 0x040021EB RID: 8683
		public byte byte_1;
	}

	// Token: 0x0200085D RID: 2141
	[StructLayout(LayoutKind.Sequential)]
	public class SP_CLASSINSTALL_HEADER
	{
		// Token: 0x040021EC RID: 8684
		public int cbSize;

		// Token: 0x040021ED RID: 8685
		public int InstallFunction;
	}

	// Token: 0x0200085E RID: 2142
	[StructLayout(LayoutKind.Sequential)]
	public class SP_PROPCHANGE_PARAMS
	{
		// Token: 0x040021EE RID: 8686
		public dje_zQE7X9KAD45FPNM2_ejd.SP_CLASSINSTALL_HEADER ClassInstallHeader = new dje_zQE7X9KAD45FPNM2_ejd.SP_CLASSINSTALL_HEADER();

		// Token: 0x040021EF RID: 8687
		public int StateChange;

		// Token: 0x040021F0 RID: 8688
		public int Scope;

		// Token: 0x040021F1 RID: 8689
		public int HwProfile;
	}
}
