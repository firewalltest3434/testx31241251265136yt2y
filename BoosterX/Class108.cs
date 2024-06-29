using System;

// Token: 0x020000A2 RID: 162
internal static class Class108
{
	// Token: 0x06000515 RID: 1301 RVA: 0x0001A954 File Offset: 0x00018B54
	public static byte[] smethod_0(Array array_0, Struct6 struct6_0, Func<byte[]> func_0)
	{
		if (array_0 == null)
		{
			return null;
		}
		if (array_0.Length == 0)
		{
			return new byte[0];
		}
		int num = Buffer.ByteLength(array_0);
		byte[] array = new byte[num];
		byte[] array2 = null;
		byte[] array3 = array_0 as byte[];
		byte[] array4;
		if (array3 != null)
		{
			array4 = array3;
		}
		else
		{
			array2 = new byte[Math.Min(num, 16)];
			array4 = array2;
		}
		int num2 = 0;
		byte[] array5 = null;
		int num3 = num / 16;
		if (num3 > 0)
		{
			array5 = func_0();
			for (int i = 0; i < num3; i++)
			{
				int num4 = 0;
				if (array3 != null)
				{
					num4 = num2;
				}
				else
				{
					Buffer.BlockCopy(array_0, num2, array2, 0, 16);
				}
				int num5 = num2;
				array[num5++] = array4[num4 + (int)array5[0]];
				array[num5++] = array4[num4 + (int)array5[1]];
				array[num5++] = array4[num4 + (int)array5[2]];
				array[num5++] = array4[num4 + (int)array5[3]];
				array[num5++] = array4[num4 + (int)array5[4]];
				array[num5++] = array4[num4 + (int)array5[5]];
				array[num5++] = array4[num4 + (int)array5[6]];
				array[num5++] = array4[num4 + (int)array5[7]];
				array[num5++] = array4[num4 + (int)array5[8]];
				array[num5++] = array4[num4 + (int)array5[9]];
				array[num5++] = array4[num4 + (int)array5[10]];
				array[num5++] = array4[num4 + (int)array5[11]];
				array[num5++] = array4[num4 + (int)array5[12]];
				array[num5++] = array4[num4 + (int)array5[13]];
				array[num5++] = array4[num4 + (int)array5[14]];
				array[num5++] = array4[num4 + (int)array5[15]];
				Class91.smethod_0(array, num2, struct6_0.int_0);
				Class91.smethod_0(array, num2 + 4, struct6_0.int_1);
				Class91.smethod_0(array, num2 + 8, struct6_0.int_2);
				Class91.smethod_0(array, num2 + 12, struct6_0.int_3);
				num2 += 16;
			}
		}
		if (num2 < num)
		{
			num3 = (num - num2) / 4;
			if (num3 > 0)
			{
				if (array5 == null)
				{
					array5 = func_0();
				}
				for (int j = 0; j < num3; j++)
				{
					int num6 = 0;
					if (array3 != null)
					{
						num6 = num2;
					}
					else
					{
						Buffer.BlockCopy(array_0, num2, array2, 0, 4);
					}
					int num7 = num2;
					array[num7++] = array4[num6 + (int)array5[16]];
					array[num7++] = array4[num6 + (int)array5[17]];
					array[num7++] = array4[num6 + (int)array5[18]];
					array[num7++] = array4[num6 + (int)array5[19]];
					Class91.smethod_0(array, num2, struct6_0.int_0);
					num2 += 4;
				}
			}
		}
		int num8 = num - num2;
		if (num8 > 0)
		{
			Buffer.BlockCopy(array_0, num2, array, num2, num8);
			Class91.smethod_1(array, num2, struct6_0.int_0);
		}
		if (array5 != null)
		{
			Array.Clear(array5, 0, array5.Length);
		}
		if (array2 != null)
		{
			Array.Clear(array2, 0, array2.Length);
		}
		return array;
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x0001AC5C File Offset: 0x00018E5C
	public static T[] smethod_1<T>(byte[] byte_0, int int_0, Struct6 struct6_0, Func<byte[]> func_0, bool bool_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		if (byte_0.Length - int_0 <= 0)
		{
			return new T[0];
		}
		int num = byte_0.Length - int_0;
		int int_ = Class95<T>.int_0;
		T[] array = new T[num / int_];
		int num2 = 0;
		byte[] array2 = new byte[Math.Min(num, 16)];
		byte[] array3 = null;
		byte[] array4;
		if (array is byte[])
		{
			array4 = (array as byte[]);
		}
		else
		{
			array3 = new byte[array2.Length];
			array4 = array3;
		}
		byte[] array5 = null;
		int num3 = (num - num2) / 16;
		if (num3 > 0)
		{
			array5 = func_0();
			for (int i = 0; i < num3; i++)
			{
				Array.Copy(byte_0, num2 + int_0, array2, 0, 16);
				Class91.smethod_0(array2, 0, struct6_0.int_0);
				Class91.smethod_0(array2, 4, struct6_0.int_1);
				Class91.smethod_0(array2, 8, struct6_0.int_2);
				Class91.smethod_0(array2, 12, struct6_0.int_3);
				int num4 = 0;
				int num5 = 0;
				if (array4 == array)
				{
					num5 = num2;
				}
				array4[num5 + (int)array5[0]] = array2[num4++];
				array4[num5 + (int)array5[1]] = array2[num4++];
				array4[num5 + (int)array5[2]] = array2[num4++];
				array4[num5 + (int)array5[3]] = array2[num4++];
				array4[num5 + (int)array5[4]] = array2[num4++];
				array4[num5 + (int)array5[5]] = array2[num4++];
				array4[num5 + (int)array5[6]] = array2[num4++];
				array4[num5 + (int)array5[7]] = array2[num4++];
				array4[num5 + (int)array5[8]] = array2[num4++];
				array4[num5 + (int)array5[9]] = array2[num4++];
				array4[num5 + (int)array5[10]] = array2[num4++];
				array4[num5 + (int)array5[11]] = array2[num4++];
				array4[num5 + (int)array5[12]] = array2[num4++];
				array4[num5 + (int)array5[13]] = array2[num4++];
				array4[num5 + (int)array5[14]] = array2[num4++];
				array4[num5 + (int)array5[15]] = array2[num4++];
				if (array4 != array)
				{
					Buffer.BlockCopy(array4, 0, array, num2, 16);
				}
				num2 += 16;
			}
		}
		num3 = (num - num2) / 4;
		if (num3 > 0)
		{
			if (array5 == null)
			{
				array5 = func_0();
			}
			for (int j = 0; j < num3; j++)
			{
				Array.Copy(byte_0, num2 + int_0, array2, 0, 4);
				Class91.smethod_0(array2, 0, struct6_0.int_0);
				int num6 = 0;
				int num7 = 0;
				if (array4 == array)
				{
					num7 = num2;
				}
				array4[num7 + (int)array5[16]] = array2[num6++];
				array4[num7 + (int)array5[17]] = array2[num6++];
				array4[num7 + (int)array5[18]] = array2[num6++];
				array4[num7 + (int)array5[19]] = array2[num6++];
				if (array4 != array)
				{
					Buffer.BlockCopy(array3, 0, array, num2, 4);
				}
				num2 += 4;
			}
		}
		int num8 = num - num2;
		if (num8 > 0)
		{
			Array.Copy(byte_0, num2 + int_0, array2, 0, num8);
			Class91.smethod_1(array2, 0, struct6_0.int_0);
			Buffer.BlockCopy(array2, 0, array, num2, num8);
		}
		if (array5 != null)
		{
			Array.Clear(array5, 0, array5.Length);
		}
		Array.Clear(array2, 0, array2.Length);
		if (array3 != null)
		{
			Array.Clear(array3, 0, array3.Length);
		}
		if (bool_0 && !BitConverter.IsLittleEndian && array.Length != 0 && int_ != 1)
		{
			Class108.smethod_2<T>(array);
		}
		return array;
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0001AFD0 File Offset: 0x000191D0
	private static void smethod_2<T>(T[] gparam_0)
	{
		int int_ = Class95<T>.int_0;
		if (int_ == 1)
		{
			return;
		}
		byte[] array = new byte[int_];
		byte[] array2 = new byte[int_];
		for (int i = 0; i < gparam_0.Length; i++)
		{
			Buffer.BlockCopy(gparam_0, i * int_, array, 0, int_);
			if (typeof(T) == typeof(float) && !Struct12.bool_0)
			{
				gparam_0[i] = (T)((object)Class23.smethod_6(array, 0));
			}
			else if (typeof(T) == typeof(double) && !Struct10.bool_0)
			{
				gparam_0[i] = (T)((object)Class23.smethod_7(array, 0));
			}
			else
			{
				for (int j = 0; j < int_; j++)
				{
					array2[int_ - j - 1] = array[j];
				}
				Buffer.BlockCopy(array2, 0, gparam_0, i * int_, int_);
			}
		}
		Array.Clear(array, 0, array.Length);
		Array.Clear(array2, 0, array2.Length);
	}
}
