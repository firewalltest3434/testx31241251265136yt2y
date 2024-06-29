using System;

// Token: 0x02000285 RID: 645
public sealed class GClass74
{
	// Token: 0x06000EF2 RID: 3826 RVA: 0x0003FE48 File Offset: 0x0003E048
	public static T smethod_0<T>(Func<IntPtr, T> func_0, bool bool_1, bool bool_2)
	{
		object obj = GClass74.object_0;
		lock (obj)
		{
			if (!GClass74.bool_0 || bool_1)
			{
				return GClass74.smethod_2<T>(func_0, bool_2);
			}
			if (GClass74.intptr_0 == IntPtr.Zero)
			{
				GEnum0 genum = GClass202.gdelegate21_0(ref GClass74.intptr_0);
				if (genum != GEnum0.NVAPI_OK)
				{
					throw new GException7("DRS_CreateSession", genum);
				}
				if (!bool_2)
				{
					GEnum0 genum2 = GClass202.gdelegate30_0(GClass74.intptr_0);
					if (genum2 != GEnum0.NVAPI_OK)
					{
						throw new GException7("DRS_LoadSettings", genum2);
					}
				}
			}
		}
		if (GClass74.intptr_0 != IntPtr.Zero)
		{
			return func_0(GClass74.intptr_0);
		}
		throw new Exception("GlobalSession is Zero!");
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x0003FF3C File Offset: 0x0003E13C
	public static void smethod_1()
	{
		object obj = GClass74.object_0;
		lock (obj)
		{
			if (GClass74.intptr_0 != IntPtr.Zero)
			{
				GClass202.gdelegate39_0(GClass74.intptr_0);
				GClass74.intptr_0 = IntPtr.Zero;
			}
		}
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x0003FFA8 File Offset: 0x0003E1A8
	private static T smethod_2<T>(Func<IntPtr, T> func_0, bool bool_1)
	{
		IntPtr zero = IntPtr.Zero;
		GEnum0 genum = GClass202.gdelegate21_0(ref zero);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_CreateSession", genum);
		}
		T result;
		try
		{
			if (!bool_1)
			{
				GEnum0 genum2 = GClass202.gdelegate30_0(zero);
				if (genum2 != GEnum0.NVAPI_OK)
				{
					throw new GException7("DRS_LoadSettings", genum2);
				}
			}
			result = func_0(zero);
		}
		finally
		{
			GEnum0 genum3 = GClass202.gdelegate39_0(zero);
			if (genum3 != GEnum0.NVAPI_OK)
			{
				throw new GException7("DRS_DestroySession", genum3);
			}
		}
		return result;
	}

	// Token: 0x0400091A RID: 2330
	public static volatile IntPtr intptr_0;

	// Token: 0x0400091B RID: 2331
	public static volatile bool bool_0 = true;

	// Token: 0x0400091C RID: 2332
	private static object object_0 = new object();
}
