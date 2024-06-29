using System;
using System.Runtime.InteropServices;

// Token: 0x02000590 RID: 1424
internal sealed class Class644
{
	// Token: 0x06001EBB RID: 7867
	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SystemParametersInfo(uint uint_0, uint uint_1, bool bool_0, uint uint_2);

	// Token: 0x06001EBC RID: 7868
	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SystemParametersInfo(uint uint_0, uint uint_1, ref Class644.Struct335 struct335_0, uint uint_2);

	// Token: 0x06001EBD RID: 7869
	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool SystemParametersInfo(uint uint_0, uint uint_1, uint uint_2, uint uint_3);

	// Token: 0x06001EBE RID: 7870 RVA: 0x0007FD5C File Offset: 0x0007DF5C
	public static void smethod_0(bool bool_0)
	{
		Class644.SystemParametersInfo(4163U, 0U, bool_0, 3U);
		Class644.SystemParametersInfo(4159U, 0U, bool_0, 3U);
		Class644.SystemParametersInfo(4119U, 0U, bool_0, 3U);
		Class644.SystemParametersInfo(4099U, 0U, bool_0, 3U);
		Class644.SystemParametersInfo(4101U, 0U, bool_0, 3U);
		Class644.Struct335 @struct = new Class644.Struct335(0);
		Class644.SystemParametersInfo(73U, @struct.uint_0, ref @struct, 3U);
	}

	// Token: 0x02000591 RID: 1425
	public struct Struct335
	{
		// Token: 0x06001EBF RID: 7871 RVA: 0x0007FDC8 File Offset: 0x0007DFC8
		public Struct335(int int_1)
		{
			this.uint_0 = (uint)Marshal.SizeOf(typeof(Class644.Struct335));
			this.int_0 = int_1;
		}

		// Token: 0x04001594 RID: 5524
		public uint uint_0;

		// Token: 0x04001595 RID: 5525
		public int int_0;
	}
}
