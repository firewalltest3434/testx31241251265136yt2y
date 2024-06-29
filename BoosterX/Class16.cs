using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000016 RID: 22
internal static class Class16
{
	// Token: 0x0600007F RID: 127 RVA: 0x000032EC File Offset: 0x000014EC
	public static byte[] smethod_0(object object_0, ulong ulong_0, Interface6 interface6_0, RandomNumberGenerator randomNumberGenerator_0)
	{
		return Class16.smethod_1(Class16.smethod_3(object_0), Class16.smethod_9(ulong_0), interface6_0, randomNumberGenerator_0);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00003304 File Offset: 0x00001504
	public static byte[] smethod_1(byte[] byte_0, byte[] byte_1, Interface6 interface6_0, RandomNumberGenerator randomNumberGenerator_0)
	{
		int num = byte_0.Length;
		if (num == 0)
		{
			throw new ArgumentException();
		}
		int num2 = interface6_0.imethod_0();
		int num3 = interface6_0.imethod_1();
		int num4 = num % num2;
		int num5 = (num + (num2 - 1)) / num2;
		byte[] array;
		if (num4 == 0)
		{
			array = new byte[num];
			Buffer.BlockCopy(byte_0, 0, array, 0, num);
		}
		else
		{
			int int_ = Class16.smethod_2(num4);
			byte[] bytes = new Class123(byte_0, byte_1, int_).GetBytes(num2);
			if (num5 == 1)
			{
				array = bytes;
			}
			else
			{
				array = new byte[num2 * num5];
				Buffer.BlockCopy(bytes, 0, array, num2 * (num5 - 1), num2);
			}
			Buffer.BlockCopy(byte_0, 0, array, 0, byte_0.Length);
		}
		Class9.smethod_1(array, 0, array.Length / 4 * 4, byte_1);
		byte[] array2 = new byte[interface6_0.imethod_1() * num5];
		for (int i = 0; i < num5; i++)
		{
			interface6_0.imethod_2(array, num2 * i, num2, array2, num3 * i, randomNumberGenerator_0);
		}
		return array2;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x000033F4 File Offset: 0x000015F4
	private static int smethod_2(int int_0)
	{
		if (int_0 < 8)
		{
			return 200;
		}
		return 1;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00003404 File Offset: 0x00001604
	public static byte[] smethod_3(object object_0)
	{
		if (object_0 is sbyte)
		{
			sbyte b = (sbyte)object_0;
			return new byte[]
			{
				(byte)b
			};
		}
		if (object_0 is byte)
		{
			byte b2 = (byte)object_0;
			return new byte[]
			{
				b2
			};
		}
		if (object_0 is short)
		{
			short short_ = (short)object_0;
			return Class16.smethod_4(short_);
		}
		if (object_0 is ushort)
		{
			ushort ushort_ = (ushort)object_0;
			return Class16.smethod_5(ushort_);
		}
		if (object_0 is int)
		{
			int int_ = (int)object_0;
			return Class16.smethod_6(int_);
		}
		if (object_0 is uint)
		{
			uint uint_ = (uint)object_0;
			return Class16.smethod_7(uint_);
		}
		if (object_0 is long)
		{
			long long_ = (long)object_0;
			return Class16.smethod_8(long_);
		}
		if (object_0 is ulong)
		{
			ulong ulong_ = (ulong)object_0;
			return Class16.smethod_9(ulong_);
		}
		byte[] array = object_0 as byte[];
		if (array != null)
		{
			return array;
		}
		string text = object_0 as string;
		if (text != null)
		{
			return Encoding.Unicode.GetBytes(text);
		}
		IEnumerable enumerable = object_0 as IEnumerable;
		if (enumerable == null)
		{
			throw new ArgumentOutOfRangeException("#=zakh_yIU=");
		}
		MemoryStream memoryStream = new MemoryStream();
		foreach (object object_ in enumerable)
		{
			byte[] array2 = Class16.smethod_3(object_);
			memoryStream.Write(array2, 0, array2.Length);
		}
		return memoryStream.ToArray();
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00003578 File Offset: 0x00001778
	private static byte[] smethod_4(short short_0)
	{
		return Class16.smethod_5((ushort)short_0);
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00003584 File Offset: 0x00001784
	private static byte[] smethod_5(ushort ushort_0)
	{
		byte[] array = new byte[]
		{
			0,
			(byte)ushort_0
		};
		array[0] = (byte)(ushort_0 >> 8);
		return array;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00003598 File Offset: 0x00001798
	private static byte[] smethod_6(int int_0)
	{
		return Class16.smethod_7((uint)int_0);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000035A0 File Offset: 0x000017A0
	private static byte[] smethod_7(uint uint_0)
	{
		byte[] array = new byte[]
		{
			0,
			0,
			0,
			(byte)uint_0
		};
		array[2] = (byte)(uint_0 >> 8);
		array[1] = (byte)(uint_0 >> 16);
		array[0] = (byte)(uint_0 >> 24);
		return array;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x000035C4 File Offset: 0x000017C4
	private static byte[] smethod_8(long long_0)
	{
		return Class16.smethod_9((ulong)long_0);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x000035CC File Offset: 0x000017CC
	private static byte[] smethod_9(ulong ulong_0)
	{
		byte[] array = new byte[]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			(byte)ulong_0
		};
		array[6] = (byte)(ulong_0 >> 8);
		array[5] = (byte)(ulong_0 >> 16);
		array[4] = (byte)(ulong_0 >> 24);
		array[3] = (byte)(ulong_0 >> 32);
		array[2] = (byte)(ulong_0 >> 40);
		array[1] = (byte)(ulong_0 >> 48);
		array[0] = (byte)(ulong_0 >> 56);
		return array;
	}
}
