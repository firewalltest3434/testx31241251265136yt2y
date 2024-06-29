using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Win32;

// Token: 0x020000E0 RID: 224
internal sealed class Class137
{
	// Token: 0x06000690 RID: 1680 RVA: 0x00020038 File Offset: 0x0001E238
	private Class137()
	{
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x0002004C File Offset: 0x0001E24C
	public static Class137 smethod_0()
	{
		if (Class137.class137_0 == null)
		{
			Class137.class137_0 = new Class137();
		}
		return Class137.class137_0;
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00020064 File Offset: 0x0001E264
	public void method_0(string string_0, bool bool_0)
	{
		GStruct5 gstruct5_ = default(GStruct5);
		gstruct5_.string_2 = string_0;
		Class137.gclass99_0.method_1(gstruct5_, bool_0);
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00020090 File Offset: 0x0001E290
	public bool method_1(string string_0)
	{
		Class137.Class138 @class = new Class137.Class138();
		@class.string_0 = string_0;
		return Class137.gclass99_0.method_0().First(new Func<GStruct5, bool>(@class.method_0)).genum64_0 == (GEnum64)1;
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x000200D0 File Offset: 0x0001E2D0
	public List<GStruct5> method_2()
	{
		return Class137.gclass99_0.method_0();
	}

	// Token: 0x06000696 RID: 1686
	[DllImport("SetupApi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SetupDiGetClassDevs(ref Guid guid_0, string string_0, IntPtr intptr_0, int int_0);

	// Token: 0x06000697 RID: 1687
	[DllImport("SetupApi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SetupDiEnumDeviceInfo(IntPtr intptr_0, int int_0, ref Class137.Struct28 struct28_0);

	// Token: 0x06000698 RID: 1688
	[DllImport("SetupApi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SetupDiGetDeviceRegistryProperty(IntPtr intptr_0, ref Class137.Struct28 struct28_0, int int_0, out int int_1, IntPtr intptr_1, int int_2, out int int_3);

	// Token: 0x06000699 RID: 1689 RVA: 0x000200DC File Offset: 0x0001E2DC
	public bool method_3(string string_0)
	{
		bool result;
		try
		{
			string text = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + string_0 + "\\Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties").GetValue("MSISupported").ToString();
			if (text == null && !(text != string.Empty))
			{
				result = false;
			}
			else
			{
				result = true;
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00020144 File Offset: 0x0001E344
	public bool method_4(string string_0)
	{
		bool result;
		try
		{
			result = (Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + string_0 + "\\Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties").GetValue("MSISupported").ToString() == "1");
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x04000348 RID: 840
	private static Class137 class137_0;

	// Token: 0x04000349 RID: 841
	private static GClass99 gclass99_0 = new GClass99();

	// Token: 0x020000E1 RID: 225
	public struct Struct28
	{
		// Token: 0x0400034A RID: 842
		public int int_0;

		// Token: 0x0400034B RID: 843
		public Guid guid_0;

		// Token: 0x0400034C RID: 844
		public int int_1;

		// Token: 0x0400034D RID: 845
		public IntPtr intptr_0;
	}

	// Token: 0x020000E2 RID: 226
	private sealed class Class138
	{
		// Token: 0x0600069C RID: 1692 RVA: 0x000201A8 File Offset: 0x0001E3A8
		internal bool method_0(GStruct5 gstruct5_0)
		{
			return gstruct5_0.string_2.ToLower() == this.string_0.ToLower();
		}

		// Token: 0x0400034E RID: 846
		public string string_0;
	}
}
