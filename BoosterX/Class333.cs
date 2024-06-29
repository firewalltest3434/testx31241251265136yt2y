using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x0200029C RID: 668
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal static class Class333
{
	// Token: 0x06000F5C RID: 3932 RVA: 0x0004275C File Offset: 0x0004095C
	internal static T smethod_0<T>(List<T> list_0)
	{
		if (list_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (list_0.Count > 0)
		{
			return list_0[0];
		}
		return default(T);
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x0004278C File Offset: 0x0004098C
	internal static bool smethod_1(byte[] byte_0, byte[] byte_1)
	{
		if (byte_0 == null || byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (byte_0 == byte_1)
		{
			return true;
		}
		if (byte_0.Length != byte_1.Length)
		{
			return false;
		}
		for (int i = 0; i < byte_0.Length; i++)
		{
			if (byte_0[i] != byte_1[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x000427EC File Offset: 0x000409EC
	internal static T smethod_2<T>(T[] gparam_0)
	{
		if (gparam_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (gparam_0.Length != 0)
		{
			return gparam_0[0];
		}
		return default(T);
	}
}
