using System;

// Token: 0x02000015 RID: 21
internal sealed class Class15 : Interface0
{
	// Token: 0x0600007B RID: 123 RVA: 0x0000324C File Offset: 0x0000144C
	public void imethod_0()
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00003250 File Offset: 0x00001450
	public string imethod_1()
	{
		return "PKCS7";
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00003258 File Offset: 0x00001458
	public int imethod_2(byte[] byte_0, int int_0)
	{
		byte b = (byte)(byte_0.Length - int_0);
		while (int_0 < byte_0.Length)
		{
			byte_0[int_0] = b;
			int_0++;
		}
		return (int)b;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00003288 File Offset: 0x00001488
	public int imethod_3(byte[] byte_0)
	{
		int num = (int)byte_0[byte_0.Length - 1];
		if (num >= 1 && num <= byte_0.Length)
		{
			for (int i = 1; i <= num; i++)
			{
				if ((int)byte_0[byte_0.Length - i] != num)
				{
					throw new Exception1("pad block corrupted");
				}
			}
			return num;
		}
		throw new Exception1("pad block corrupted");
	}
}
