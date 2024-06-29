using System;

// Token: 0x0200007C RID: 124
internal static class Class91
{
	// Token: 0x06000429 RID: 1065 RVA: 0x000171E8 File Offset: 0x000153E8
	public static void smethod_0(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < 4; i++)
		{
			int num = int_0++;
			byte_0[num] ^= (byte)(int_1 >> i * 8);
		}
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00017228 File Offset: 0x00015428
	public static void smethod_1(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < 4; i++)
		{
			if (int_0 >= byte_0.Length)
			{
				return;
			}
			int num = int_0++;
			byte_0[num] ^= (byte)(int_1 >> i * 8);
		}
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00017270 File Offset: 0x00015470
	public static void smethod_2(byte[] byte_0, int int_0, long long_0)
	{
		for (int i = 0; i < 8; i++)
		{
			int num = int_0++;
			byte_0[num] ^= (byte)(long_0 >> i * 8);
		}
	}
}
