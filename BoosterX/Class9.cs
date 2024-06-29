using System;

// Token: 0x02000008 RID: 8
internal static class Class9
{
	// Token: 0x06000029 RID: 41 RVA: 0x000026EC File Offset: 0x000008EC
	private static uint smethod_0(uint uint_0, uint uint_1, uint uint_2, int int_0, uint uint_3, uint[] uint_4)
	{
		return (uint_2 >> 5 ^ uint_1 << 2) + (uint_1 >> 3 ^ uint_2 << 4) ^ (uint_0 ^ uint_1) + (uint_4[(int)(checked((IntPtr)(unchecked((long)(int_0 & 3) ^ (long)((ulong)uint_3)))))] ^ uint_2);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002710 File Offset: 0x00000910
	public static void smethod_1(byte[] byte_0, int int_0, int int_1, byte[] byte_1)
	{
		if (byte_0.Length == 0 || byte_0.Length == 0)
		{
			return;
		}
		if (int_0 + int_1 > byte_0.Length || int_1 % 4 != 0 || int_1 < 8)
		{
			throw new ArgumentException("data");
		}
		if (byte_1 != null && byte_1.Length <= 16)
		{
			uint[] array = new uint[int_1 / 4];
			Class9.smethod_3(byte_0, int_0, int_1, array, 0);
			uint[] array2 = new uint[4];
			Class9.smethod_3(byte_1, 0, byte_1.Length, array2, 0);
			Class9.smethod_2(array, array2);
			Class9.smethod_4(array, 0, array.Length, byte_0, int_0);
			return;
		}
		throw new ArgumentNullException("#=zoAY20qU=");
	}

	// Token: 0x0600002B RID: 43 RVA: 0x000027B0 File Offset: 0x000009B0
	private static void smethod_2(uint[] uint_0, uint[] uint_1)
	{
		int num = uint_0.Length - 1;
		if (num < 1)
		{
			return;
		}
		uint uint_2 = uint_0[num];
		uint num2 = 0U;
		int num3 = 6 + 52 / (num + 1);
		while (0 < num3--)
		{
			num2 += 2654435769U;
			uint uint_3 = num2 >> 2 & 3U;
			int i;
			uint uint_4;
			for (i = 0; i < num; i++)
			{
				uint_4 = uint_0[i + 1];
				uint_2 = (uint_0[i] += Class9.smethod_0(num2, uint_4, uint_2, i, uint_3, uint_1));
			}
			uint_4 = uint_0[0];
			uint_2 = (uint_0[num] += Class9.smethod_0(num2, uint_4, uint_2, i, uint_3, uint_1));
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000285C File Offset: 0x00000A5C
	private static uint[] smethod_3(byte[] byte_0, int int_0, int int_1, uint[] uint_0, int int_2)
	{
		if (int_0 + int_1 > byte_0.Length)
		{
			throw new ArgumentException();
		}
		int num = int_1 / 4;
		if (int_2 + num > uint_0.Length)
		{
			throw new ArgumentException();
		}
		int num2 = int_0 + int_1;
		for (int i = int_0; i < num2; i += 4)
		{
			uint_0[int_2 + (i - int_0) / 4] = (uint)((int)byte_0[i] | (int)byte_0[i + 1] << 8 | (int)byte_0[i + 2] << 16 | (int)byte_0[i + 3] << 24);
		}
		return uint_0;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000028D0 File Offset: 0x00000AD0
	private static void smethod_4(uint[] uint_0, int int_0, int int_1, byte[] byte_0, int int_2)
	{
		if (int_0 + int_1 > uint_0.Length)
		{
			throw new ArgumentException();
		}
		int num = int_1 * 4;
		if (int_2 + num > byte_0.Length)
		{
			throw new ArgumentException();
		}
		int num2 = int_2 + num;
		for (int i = int_2; i < num2; i += 4)
		{
			uint num3 = uint_0[(i - int_2) / 4 + int_0];
			byte_0[i] = (byte)num3;
			byte_0[i + 1] = (byte)(num3 >> 8);
			byte_0[i + 2] = (byte)(num3 >> 16);
			byte_0[i + 3] = (byte)(num3 >> 24);
		}
	}
}
