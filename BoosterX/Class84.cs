using System;
using System.Security.Cryptography;

// Token: 0x0200006E RID: 110
internal abstract class Class84
{
	// Token: 0x060003BF RID: 959 RVA: 0x000152C8 File Offset: 0x000134C8
	public Class84(byte[] byte_0, long long_0) : this(byte_0, Class84.smethod_2(long_0))
	{
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x000152D8 File Offset: 0x000134D8
	public Class84(byte[] byte_0, byte[] byte_1)
	{
		Class123 @class = new Class123(byte_0, byte_1, 1);
		SymmetricAlgorithm[] array = new SymmetricAlgorithm[5];
		for (int i = 0; i < 5; i++)
		{
			Class6 class2 = new Class6(new SymmetricAlgorithm[]
			{
				new Class106()
			});
			class2.Key = @class.GetBytes(class2.KeySize / 8);
			class2.IV = @class.GetBytes(class2.method_0() / 8);
			array[i] = class2;
		}
		this.symmetricAlgorithm_0 = array;
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x0001535C File Offset: 0x0001355C
	protected static int smethod_0(int int_0)
	{
		return (int_0 + 3) / 4 * 4;
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00015368 File Offset: 0x00013568
	public static int smethod_1(int int_0)
	{
		return Class84.smethod_0(int_0 + 4);
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x00015374 File Offset: 0x00013574
	protected static byte[] smethod_2(long long_0)
	{
		byte[] array = new byte[8];
		Class84.smethod_3(long_0, array, 0);
		return array;
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00015394 File Offset: 0x00013594
	protected static void smethod_3(long long_0, byte[] byte_0, int int_0)
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

	// Token: 0x060003C5 RID: 965 RVA: 0x000153EC File Offset: 0x000135EC
	protected static int smethod_4(byte[] byte_0, int int_0)
	{
		return (int)byte_0[int_0] | (int)byte_0[int_0 + 1] << 8 | (int)byte_0[int_0 + 2] << 16 | (int)byte_0[int_0 + 3] << 24;
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x0001540C File Offset: 0x0001360C
	protected static void smethod_5(int int_0, byte[] byte_0, int int_1)
	{
		byte_0[int_1] = (byte)int_0;
		byte_0[int_1 + 1] = (byte)(int_0 >> 8);
		byte_0[int_1 + 2] = (byte)(int_0 >> 16);
		byte_0[int_1 + 3] = (byte)(int_0 >> 24);
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00015430 File Offset: 0x00013630
	protected byte[] method_0(byte[] byte_0, bool bool_0)
	{
		if (bool_0)
		{
			SymmetricAlgorithm[] array = this.symmetricAlgorithm_0;
			int i = 0;
			while (i < array.Length)
			{
				SymmetricAlgorithm symmetricAlgorithm = array[i];
				if (bool_0)
				{
					using (ICryptoTransform cryptoTransform = symmetricAlgorithm.CreateEncryptor())
					{
						byte_0 = cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length);
						goto IL_7C;
					}
					goto IL_53;
				}
				goto IL_53;
				IL_7C:
				bool_0 = !bool_0;
				i++;
				continue;
				IL_53:
				using (ICryptoTransform cryptoTransform2 = symmetricAlgorithm.CreateDecryptor())
				{
					byte_0 = cryptoTransform2.TransformFinalBlock(byte_0, 0, byte_0.Length);
				}
				goto IL_7C;
			}
		}
		else
		{
			int j = 4;
			while (j >= 0)
			{
				SymmetricAlgorithm symmetricAlgorithm2 = this.symmetricAlgorithm_0[j];
				if (bool_0)
				{
					using (ICryptoTransform cryptoTransform3 = symmetricAlgorithm2.CreateEncryptor())
					{
						byte_0 = cryptoTransform3.TransformFinalBlock(byte_0, 0, byte_0.Length);
						goto IL_106;
					}
					goto IL_D9;
				}
				goto IL_D9;
				IL_106:
				bool_0 = !bool_0;
				j--;
				continue;
				IL_D9:
				using (ICryptoTransform cryptoTransform4 = symmetricAlgorithm2.CreateDecryptor())
				{
					byte_0 = cryptoTransform4.TransformFinalBlock(byte_0, 0, byte_0.Length);
				}
				goto IL_106;
			}
		}
		return byte_0;
	}

	// Token: 0x040000D2 RID: 210
	private readonly SymmetricAlgorithm[] symmetricAlgorithm_0;
}
