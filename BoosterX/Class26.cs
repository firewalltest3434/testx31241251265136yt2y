using System;
using System.Collections;
using System.IO;

// Token: 0x02000028 RID: 40
internal static class Class26
{
	// Token: 0x060000F4 RID: 244 RVA: 0x00004EE4 File Offset: 0x000030E4
	private static void smethod_0()
	{
		if (Class26.bool_0)
		{
			return;
		}
		object obj = Class26.object_0;
		lock (obj)
		{
			if (!Class26.bool_0)
			{
				Class39 class39_ = new Class39(1, Class26.byte_0);
				Class89 class89_ = new Class89(false, class39_, Class26.class39_0);
				Class26.class121_0 = new Class121(true, class89_, false);
				Class26.bool_0 = true;
			}
		}
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00004F54 File Offset: 0x00003154
	private static byte[] smethod_1()
	{
		return null;
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00004F58 File Offset: 0x00003158
	public static bool smethod_2(object object_1, byte[] byte_1, ulong ulong_0, int int_0)
	{
		if (byte_1 == null)
		{
			return false;
		}
		if (!Class26.smethod_5(object_1))
		{
			Class26.smethod_0();
			byte[] byte_2 = Class16.smethod_0(object_1, ulong_0, Class26.class121_0, null);
			return Class26.smethod_3(byte_1, byte_2);
		}
		switch (int_0)
		{
		case 0:
			return false;
		case 1:
			throw new ArgumentNullException("value");
		case 2:
			throw new NullReferenceException("value");
		default:
			throw new ArgumentOutOfRangeException("nullArgBehaviour");
		}
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00004FC4 File Offset: 0x000031C4
	private static bool smethod_3(byte[] byte_1, byte[] byte_2)
	{
		if (byte_1.Length != byte_2.Length)
		{
			return false;
		}
		for (int i = 0; i < byte_1.Length; i++)
		{
			if (byte_1[i] != byte_2[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00005008 File Offset: 0x00003208
	public static byte[] smethod_4(object[] object_1, byte[] byte_1, ulong ulong_0)
	{
		if (object_1 == null)
		{
			throw new ArgumentNullException("#=zakh_yIU=");
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException("#=zt5lpyKI=");
		}
		byte[] array2;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			for (int i = 0; i < object_1.Length; i++)
			{
				byte[] array = Class16.smethod_3(object_1[i]);
				memoryStream.Write(array, 0, array.Length);
			}
			array2 = memoryStream.ToArray();
		}
		return new Class85(array2, (long)ulong_0).method_2(byte_1);
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x000050A4 File Offset: 0x000032A4
	internal static bool smethod_5(object object_1)
	{
		if (object_1 == null)
		{
			return true;
		}
		if (!(object_1 is string))
		{
			IEnumerable enumerable = object_1 as IEnumerable;
			if (enumerable != null)
			{
				using (IEnumerator enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (Class26.smethod_5(enumerator.Current))
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
		}
		return false;
	}

	// Token: 0x04000049 RID: 73
	private static readonly Class39 class39_0 = Class39.smethod_18(65537UL);

	// Token: 0x0400004A RID: 74
	private static readonly byte[] byte_0 = Class26.smethod_1();

	// Token: 0x0400004B RID: 75
	private static Class121 class121_0;

	// Token: 0x0400004C RID: 76
	private static readonly object object_0 = new object();

	// Token: 0x0400004D RID: 77
	private static bool bool_0;
}
