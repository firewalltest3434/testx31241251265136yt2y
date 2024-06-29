using System;
using System.Threading;

// Token: 0x0200006F RID: 111
internal static class Class86
{
	// Token: 0x060003C8 RID: 968 RVA: 0x0001558C File Offset: 0x0001378C
	public static Interface2 smethod_0()
	{
		return Class86.smethod_1() ?? new Class97();
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x0001559C File Offset: 0x0001379C
	private static Interface2 smethod_1()
	{
		Interface2 result;
		try
		{
			Class99 @class = new Class99();
			if (!Class86.smethod_3(@class))
			{
				@class.Dispose();
				result = null;
			}
			else
			{
				result = @class;
			}
		}
		catch (Exception exception_) when (!Class86.smethod_2(exception_))
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060003CA RID: 970 RVA: 0x000155F4 File Offset: 0x000137F4
	private static bool smethod_2(Exception exception_0)
	{
		return exception_0 is ThreadAbortException || exception_0 is ThreadInterruptedException;
	}

	// Token: 0x060003CB RID: 971 RVA: 0x0001560C File Offset: 0x0001380C
	private static bool smethod_3(Interface2 interface2_0)
	{
		byte[] array = new byte[]
		{
			0,
			130,
			byte.MaxValue
		};
		for (int i = 0; i < array.Length; i++)
		{
			byte b = array[i];
			interface2_0.imethod_2(i, ref b);
		}
		if (interface2_0.imethod_0() != array.Length)
		{
			return false;
		}
		for (int j = 0; j < array.Length; j++)
		{
			byte b2;
			interface2_0.imethod_1(j, out b2);
			if (b2 != array[j])
			{
				return false;
			}
		}
		interface2_0.imethod_3();
		return interface2_0.imethod_0() == 0;
	}
}
