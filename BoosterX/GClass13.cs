using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x0200010A RID: 266
public sealed class GClass13
{
	// Token: 0x0600078B RID: 1931 RVA: 0x00024B54 File Offset: 0x00022D54
	public static T smethod_0<T>(IntPtr intptr_0)
	{
		return (T)((object)Marshal.PtrToStructure(intptr_0, typeof(T)));
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00024B6C File Offset: 0x00022D6C
	public static T[] smethod_1<T>(IntPtr intptr_0, int int_0)
	{
		List<T> list = new List<T>();
		if (intptr_0 != IntPtr.Zero && int_0 > 0)
		{
			int num = Marshal.SizeOf(typeof(T));
			for (int i = 0; i < int_0; i++)
			{
				list.Add(GClass13.smethod_0<T>(intptr_0 + num * i));
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00024BD4 File Offset: 0x00022DD4
	public static void smethod_2<T>(T[] gparam_0, out IntPtr intptr_0)
	{
		if (gparam_0 != null && gparam_0.Length != 0)
		{
			int num = Marshal.SizeOf(typeof(T));
			intptr_0 = Marshal.AllocHGlobal(num * gparam_0.Length);
			for (int i = 0; i < gparam_0.Length; i++)
			{
				Marshal.StructureToPtr<T>(gparam_0[i], intptr_0 + num * i, true);
			}
			return;
		}
		intptr_0 = IntPtr.Zero;
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00024C40 File Offset: 0x00022E40
	public static void smethod_3<T>(T gparam_0, out IntPtr intptr_0)
	{
		int cb = Marshal.SizeOf(typeof(T));
		intptr_0 = Marshal.AllocHGlobal(cb);
		Marshal.StructureToPtr<T>(gparam_0, intptr_0, true);
	}
}
