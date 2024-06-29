using System;
using System.Runtime.InteropServices;

// Token: 0x0200031A RID: 794
internal sealed class Class379
{
	// Token: 0x06001240 RID: 4672
	[DllImport("Kernel32.dll", SetLastError = true)]
	private static extern int GetSystemFirmwareTable(uint uint_0, uint uint_1, IntPtr intptr_0, int int_0);

	// Token: 0x06001241 RID: 4673 RVA: 0x0004B818 File Offset: 0x00049A18
	public static void smethod_0()
	{
		if (Class379.GetSystemFirmwareTable(1128878145U, 0U, IntPtr.Zero, 0) == 1)
		{
			Console.WriteLine("System firmware does not support the ACPI tables.");
			return;
		}
		int num = Marshal.SizeOf(typeof(Class379.Struct166));
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		if (Class379.GetSystemFirmwareTable(1128878145U, 0U, intPtr, num) == 0)
		{
			Class379.Struct166 @struct = Marshal.PtrToStructure<Class379.Struct166>(intPtr);
			IntPtr pointer = Marshal.UnsafeAddrOfPinnedArrayElement<byte>(@struct.byte_0, 0);
			int num2 = 0;
			while ((long)num2 < (long)((ulong)@struct.struct167_0.uint_1 - (ulong)((long)Marshal.SizeOf(typeof(Class379.Struct166)))))
			{
				Class379.Struct165 struct2 = Marshal.PtrToStructure<Class379.Struct165>(pointer + num2);
				if ((struct2.uint_0 & 1U) == 1U && (struct2.uint_0 & 1U) == 1U)
				{
					if (struct2.byte_2 <= 7)
					{
						Console.WriteLine(string.Format("Core {0}: High-Performance", struct2.byte_2));
					}
					else
					{
						Console.WriteLine(string.Format("Core {0}: High-Efficiency", struct2.byte_2));
					}
				}
			}
		}
	}

	// Token: 0x0200031B RID: 795
	public struct Struct165
	{
		// Token: 0x04000B1A RID: 2842
		public byte byte_0;

		// Token: 0x04000B1B RID: 2843
		public byte byte_1;

		// Token: 0x04000B1C RID: 2844
		public byte byte_2;

		// Token: 0x04000B1D RID: 2845
		public byte byte_3;

		// Token: 0x04000B1E RID: 2846
		public uint uint_0;
	}

	// Token: 0x0200031C RID: 796
	public struct Struct166
	{
		// Token: 0x04000B1F RID: 2847
		public Class379.Struct167 struct167_0;

		// Token: 0x04000B20 RID: 2848
		public uint uint_0;

		// Token: 0x04000B21 RID: 2849
		public uint uint_1;

		// Token: 0x04000B22 RID: 2850
		public byte[] byte_0;
	}

	// Token: 0x0200031D RID: 797
	public struct Struct167
	{
		// Token: 0x04000B23 RID: 2851
		public uint uint_0;

		// Token: 0x04000B24 RID: 2852
		public uint uint_1;

		// Token: 0x04000B25 RID: 2853
		public byte byte_0;

		// Token: 0x04000B26 RID: 2854
		public byte byte_1;

		// Token: 0x04000B27 RID: 2855
		public byte[] byte_2;

		// Token: 0x04000B28 RID: 2856
		public byte[] byte_3;

		// Token: 0x04000B29 RID: 2857
		public uint uint_2;

		// Token: 0x04000B2A RID: 2858
		public byte[] byte_4;

		// Token: 0x04000B2B RID: 2859
		public uint uint_3;
	}

	// Token: 0x0200031E RID: 798
	private enum Enum15 : uint
	{

	}
}
