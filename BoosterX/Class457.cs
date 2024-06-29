using System;
using System.Runtime.InteropServices;

// Token: 0x020003E5 RID: 997
internal sealed class Class457
{
	// Token: 0x060015EB RID: 5611
	[DllImport("mpr.dll", CharSet = CharSet.Auto)]
	public static extern int WNetGetUniversalName(string string_0, Class457.Enum19 enum19_0, ref Class457.Struct211 struct211_0, ref int int_0);

	// Token: 0x060015EC RID: 5612
	[DllImport("mpr.dll", CharSet = CharSet.Auto)]
	public static extern int WNetGetUniversalName(string string_0, Class457.Enum19 enum19_0, IntPtr intptr_0, ref int int_0);

	// Token: 0x020003E6 RID: 998
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct Struct211
	{
		// Token: 0x04000DD9 RID: 3545
		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_0;
	}

	// Token: 0x020003E7 RID: 999
	public enum Enum19
	{

	}
}
