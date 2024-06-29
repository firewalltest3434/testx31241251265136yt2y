using System;
using System.IO;

// Token: 0x02000025 RID: 37
internal static class Class23
{
	// Token: 0x060000DE RID: 222 RVA: 0x00004654 File Offset: 0x00002854
	public static void smethod_0(int int_0, byte[] byte_0, int int_1)
	{
		byte_0[int_1] = (byte)int_0;
		byte_0[int_1 + 1] = (byte)(int_0 >> 8);
		byte_0[int_1 + 2] = (byte)(int_0 >> 16);
		byte_0[int_1 + 3] = (byte)(int_0 >> 24);
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00004678 File Offset: 0x00002878
	public static void smethod_1(long long_0, byte[] byte_0, int int_0)
	{
		byte_0[int_0] = (byte)long_0;
		byte_0[int_0 + 1] = (byte)(long_0 >> 8);
		byte_0[int_0 + 2] = (byte)(long_0 >> 16);
		byte_0[int_0 + 3] = (byte)(long_0 >> 24);
		byte_0[int_0 + 4] = (byte)(long_0 >> 32);
		byte_0[int_0 + 5] = (byte)(long_0 >> 40);
		byte_0[int_0 + 6] = (byte)(long_0 >> 48);
		byte_0[int_0 + 7] = (byte)(long_0 >> 56);
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x000046D0 File Offset: 0x000028D0
	public static byte[] smethod_2(int int_0)
	{
		if (BitConverter.IsLittleEndian)
		{
			return BitConverter.GetBytes(int_0);
		}
		byte[] array = new byte[4];
		Class23.smethod_0(int_0, array, 0);
		return array;
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x000046FC File Offset: 0x000028FC
	public static byte[] smethod_3(long long_0)
	{
		if (BitConverter.IsLittleEndian)
		{
			return BitConverter.GetBytes(long_0);
		}
		byte[] array = new byte[8];
		Class23.smethod_1(long_0, array, 0);
		return array;
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00004728 File Offset: 0x00002928
	public static int smethod_4(byte[] byte_0, int int_0)
	{
		if (BitConverter.IsLittleEndian)
		{
			return BitConverter.ToInt32(byte_0, int_0);
		}
		return (int)byte_0[int_0] | (int)byte_0[int_0 + 1] << 8 | (int)byte_0[int_0 + 2] << 16 | (int)byte_0[int_0 + 3] << 24;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00004758 File Offset: 0x00002958
	public static long smethod_5(byte[] byte_0, int int_0)
	{
		if (BitConverter.IsLittleEndian)
		{
			return BitConverter.ToInt64(byte_0, int_0);
		}
		return (long)((ulong)byte_0[int_0] | (ulong)byte_0[int_0 + 1] << 8 | (ulong)byte_0[int_0 + 2] << 16 | (ulong)byte_0[int_0 + 3] << 24 | (ulong)byte_0[int_0 + 4] << 32 | (ulong)byte_0[int_0 + 5] << 40 | (ulong)byte_0[int_0 + 6] << 48 | (ulong)byte_0[int_0 + 7] << 56);
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x000047C0 File Offset: 0x000029C0
	public static float smethod_6(byte[] byte_0, int int_0)
	{
		if (BitConverter.IsLittleEndian && Struct12.bool_0)
		{
			return BitConverter.ToSingle(byte_0, int_0);
		}
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(byte_0, int_0, 4, false));
		float result = binaryReader.ReadSingle();
		binaryReader.Close();
		return result;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00004800 File Offset: 0x00002A00
	public static double smethod_7(byte[] byte_0, int int_0)
	{
		if (BitConverter.IsLittleEndian && Struct10.bool_0)
		{
			return BitConverter.ToDouble(byte_0, int_0);
		}
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(byte_0, int_0, 8, false));
		double result = binaryReader.ReadDouble();
		binaryReader.Close();
		return result;
	}
}
