using System;

// Token: 0x02000072 RID: 114
internal sealed class Class88
{
	// Token: 0x060003D8 RID: 984 RVA: 0x00015780 File Offset: 0x00013980
	public Class88()
	{
		this.byte_0 = new byte[4];
		this.method_9();
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x000157A8 File Offset: 0x000139A8
	public Class88(Class88 class88_0)
	{
		this.method_4(class88_0);
	}

	// Token: 0x060003DA RID: 986 RVA: 0x000157C4 File Offset: 0x000139C4
	public void method_0(byte byte_1)
	{
		byte[] array = this.byte_0;
		int num = this.int_0;
		this.int_0 = num + 1;
		array[num] = byte_1;
		if (this.int_0 == this.byte_0.Length)
		{
			this.method_6(this.byte_0, 0);
			this.int_0 = 0;
		}
		this.long_0 += 1L;
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00015824 File Offset: 0x00013A24
	public void method_1(byte[] byte_1, int int_2, int int_3)
	{
		int_3 = Math.Max(0, int_3);
		int i = 0;
		if (this.int_0 != 0)
		{
			while (i < int_3)
			{
				byte[] array = this.byte_0;
				int num = this.int_0;
				this.int_0 = num + 1;
				array[num] = byte_1[int_2 + i++];
				if (this.int_0 == 4)
				{
					this.method_6(this.byte_0, 0);
					this.int_0 = 0;
					break;
				}
			}
		}
		int num2 = (int_3 - i & -4) + i;
		while (i < num2)
		{
			this.method_6(byte_1, int_2 + i);
			i += 4;
		}
		while (i < int_3)
		{
			byte[] array2 = this.byte_0;
			int num = this.int_0;
			this.int_0 = num + 1;
			array2[num] = byte_1[int_2 + i++];
		}
		this.long_0 += (long)int_3;
	}

	// Token: 0x060003DC RID: 988 RVA: 0x000158FC File Offset: 0x00013AFC
	public void method_2()
	{
		long long_ = this.long_0 << 3;
		this.method_0(128);
		while (this.int_0 != 0)
		{
			this.method_0(0);
		}
		this.method_7(long_);
		this.method_10();
	}

	// Token: 0x060003DD RID: 989 RVA: 0x0001593C File Offset: 0x00013B3C
	public int method_3()
	{
		return 64;
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00015940 File Offset: 0x00013B40
	private void method_4(Class88 class88_0)
	{
		this.byte_0 = new byte[class88_0.byte_0.Length];
		Buffer.BlockCopy(class88_0.byte_0, 0, this.byte_0, 0, class88_0.byte_0.Length);
		this.int_0 = class88_0.int_0;
		this.long_0 = class88_0.long_0;
		this.uint_0 = class88_0.uint_0;
		this.uint_1 = class88_0.uint_1;
		this.uint_2 = class88_0.uint_2;
		this.uint_3 = class88_0.uint_3;
		this.uint_4 = class88_0.uint_4;
		Array.Copy(class88_0.uint_5, 0, this.uint_5, 0, class88_0.uint_5.Length);
		this.int_1 = class88_0.int_1;
	}

	// Token: 0x060003DF RID: 991 RVA: 0x000159F8 File Offset: 0x00013BF8
	public int method_5()
	{
		return 20;
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x000159FC File Offset: 0x00013BFC
	public void method_6(byte[] byte_1, int int_2)
	{
		this.uint_5[this.int_1] = Class88.smethod_4(byte_1, int_2);
		int num = this.int_1 + 1;
		this.int_1 = num;
		if (num == 16)
		{
			this.method_10();
		}
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00015A38 File Offset: 0x00013C38
	public void method_7(long long_1)
	{
		if (this.int_1 > 14)
		{
			this.method_10();
		}
		this.uint_5[14] = (uint)((ulong)long_1 >> 32);
		this.uint_5[15] = (uint)long_1;
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00015A64 File Offset: 0x00013C64
	public int method_8(byte[] byte_1, int int_2)
	{
		this.method_2();
		Class88.smethod_3(this.uint_0, byte_1, int_2);
		Class88.smethod_3(this.uint_1, byte_1, int_2 + 4);
		Class88.smethod_3(this.uint_2, byte_1, int_2 + 8);
		Class88.smethod_3(this.uint_3, byte_1, int_2 + 12);
		Class88.smethod_3(this.uint_4, byte_1, int_2 + 16);
		this.method_9();
		return 20;
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00015ACC File Offset: 0x00013CCC
	public void method_9()
	{
		this.long_0 = 0L;
		this.int_0 = 0;
		Array.Clear(this.byte_0, 0, this.byte_0.Length);
		this.uint_0 = 1732584193U;
		this.uint_1 = 4023233417U;
		this.uint_2 = 2562383102U;
		this.uint_3 = 271733878U;
		this.uint_4 = 3285377520U;
		this.int_1 = 0;
		Array.Clear(this.uint_5, 0, this.uint_5.Length);
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00015B58 File Offset: 0x00013D58
	private static uint smethod_0(uint uint_6, uint uint_7, uint uint_8)
	{
		return (uint_6 & uint_7) | (~uint_6 & uint_8);
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00015B64 File Offset: 0x00013D64
	private static uint smethod_1(uint uint_6, uint uint_7, uint uint_8)
	{
		return uint_6 ^ uint_7 ^ uint_8;
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00015B6C File Offset: 0x00013D6C
	private static uint smethod_2(uint uint_6, uint uint_7, uint uint_8)
	{
		return (uint_6 & uint_7) | (uint_6 & uint_8) | (uint_7 & uint_8);
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00015B7C File Offset: 0x00013D7C
	private void method_10()
	{
		for (int i = 16; i < 80; i++)
		{
			uint num = this.uint_5[i - 3] ^ this.uint_5[i - 8] ^ this.uint_5[i - 14] ^ this.uint_5[i - 16];
			this.uint_5[i] = (num << 1 | num >> 31);
		}
		uint num2 = this.uint_0;
		uint num3 = this.uint_1;
		uint num4 = this.uint_2;
		uint num5 = this.uint_3;
		uint num6 = this.uint_4;
		int num7 = 0;
		for (int j = 0; j < 4; j++)
		{
			num6 += (num2 << 5 | num2 >> 27) + Class88.smethod_0(num3, num4, num5) + this.uint_5[num7++] + 1518500249U;
			num3 = (num3 << 30 | num3 >> 2);
			num5 += (num6 << 5 | num6 >> 27) + Class88.smethod_0(num2, num3, num4) + this.uint_5[num7++] + 1518500249U;
			num2 = (num2 << 30 | num2 >> 2);
			num4 += (num5 << 5 | num5 >> 27) + Class88.smethod_0(num6, num2, num3) + this.uint_5[num7++] + 1518500249U;
			num6 = (num6 << 30 | num6 >> 2);
			num3 += (num4 << 5 | num4 >> 27) + Class88.smethod_0(num5, num6, num2) + this.uint_5[num7++] + 1518500249U;
			num5 = (num5 << 30 | num5 >> 2);
			num2 += (num3 << 5 | num3 >> 27) + Class88.smethod_0(num4, num5, num6) + this.uint_5[num7++] + 1518500249U;
			num4 = (num4 << 30 | num4 >> 2);
		}
		for (int k = 0; k < 4; k++)
		{
			num6 += (num2 << 5 | num2 >> 27) + Class88.smethod_1(num3, num4, num5) + this.uint_5[num7++] + 1859775393U;
			num3 = (num3 << 30 | num3 >> 2);
			num5 += (num6 << 5 | num6 >> 27) + Class88.smethod_1(num2, num3, num4) + this.uint_5[num7++] + 1859775393U;
			num2 = (num2 << 30 | num2 >> 2);
			num4 += (num5 << 5 | num5 >> 27) + Class88.smethod_1(num6, num2, num3) + this.uint_5[num7++] + 1859775393U;
			num6 = (num6 << 30 | num6 >> 2);
			num3 += (num4 << 5 | num4 >> 27) + Class88.smethod_1(num5, num6, num2) + this.uint_5[num7++] + 1859775393U;
			num5 = (num5 << 30 | num5 >> 2);
			num2 += (num3 << 5 | num3 >> 27) + Class88.smethod_1(num4, num5, num6) + this.uint_5[num7++] + 1859775393U;
			num4 = (num4 << 30 | num4 >> 2);
		}
		for (int l = 0; l < 4; l++)
		{
			num6 += (num2 << 5 | num2 >> 27) + Class88.smethod_2(num3, num4, num5) + this.uint_5[num7++] + 2400959708U;
			num3 = (num3 << 30 | num3 >> 2);
			num5 += (num6 << 5 | num6 >> 27) + Class88.smethod_2(num2, num3, num4) + this.uint_5[num7++] + 2400959708U;
			num2 = (num2 << 30 | num2 >> 2);
			num4 += (num5 << 5 | num5 >> 27) + Class88.smethod_2(num6, num2, num3) + this.uint_5[num7++] + 2400959708U;
			num6 = (num6 << 30 | num6 >> 2);
			num3 += (num4 << 5 | num4 >> 27) + Class88.smethod_2(num5, num6, num2) + this.uint_5[num7++] + 2400959708U;
			num5 = (num5 << 30 | num5 >> 2);
			num2 += (num3 << 5 | num3 >> 27) + Class88.smethod_2(num4, num5, num6) + this.uint_5[num7++] + 2400959708U;
			num4 = (num4 << 30 | num4 >> 2);
		}
		for (int m = 0; m < 4; m++)
		{
			num6 += (num2 << 5 | num2 >> 27) + Class88.smethod_1(num3, num4, num5) + this.uint_5[num7++] + 3395469782U;
			num3 = (num3 << 30 | num3 >> 2);
			num5 += (num6 << 5 | num6 >> 27) + Class88.smethod_1(num2, num3, num4) + this.uint_5[num7++] + 3395469782U;
			num2 = (num2 << 30 | num2 >> 2);
			num4 += (num5 << 5 | num5 >> 27) + Class88.smethod_1(num6, num2, num3) + this.uint_5[num7++] + 3395469782U;
			num6 = (num6 << 30 | num6 >> 2);
			num3 += (num4 << 5 | num4 >> 27) + Class88.smethod_1(num5, num6, num2) + this.uint_5[num7++] + 3395469782U;
			num5 = (num5 << 30 | num5 >> 2);
			num2 += (num3 << 5 | num3 >> 27) + Class88.smethod_1(num4, num5, num6) + this.uint_5[num7++] + 3395469782U;
			num4 = (num4 << 30 | num4 >> 2);
		}
		this.uint_0 += num2;
		this.uint_1 += num3;
		this.uint_2 += num4;
		this.uint_3 += num5;
		this.uint_4 += num6;
		this.int_1 = 0;
		Array.Clear(this.uint_5, 0, 16);
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x000160DC File Offset: 0x000142DC
	private static void smethod_3(uint uint_6, byte[] byte_1, int int_2)
	{
		byte_1[int_2] = (byte)(uint_6 >> 24);
		byte_1[int_2 + 1] = (byte)(uint_6 >> 16);
		byte_1[int_2 + 2] = (byte)(uint_6 >> 8);
		byte_1[int_2 + 3] = (byte)uint_6;
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00016100 File Offset: 0x00014300
	private static uint smethod_4(byte[] byte_1, int int_2)
	{
		return (uint)((int)byte_1[int_2] << 24 | (int)byte_1[int_2 + 1] << 16 | (int)byte_1[int_2 + 2] << 8 | (int)byte_1[int_2 + 3]);
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00016120 File Offset: 0x00014320
	public Class88 method_11()
	{
		return new Class88(this);
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00016128 File Offset: 0x00014328
	public void method_12(Class88 class88_0)
	{
		this.method_4(class88_0);
	}

	// Token: 0x040000D6 RID: 214
	private byte[] byte_0;

	// Token: 0x040000D7 RID: 215
	private int int_0;

	// Token: 0x040000D8 RID: 216
	private long long_0;

	// Token: 0x040000D9 RID: 217
	private uint uint_0;

	// Token: 0x040000DA RID: 218
	private uint uint_1;

	// Token: 0x040000DB RID: 219
	private uint uint_2;

	// Token: 0x040000DC RID: 220
	private uint uint_3;

	// Token: 0x040000DD RID: 221
	private uint uint_4;

	// Token: 0x040000DE RID: 222
	private uint[] uint_5 = new uint[80];

	// Token: 0x040000DF RID: 223
	private int int_1;
}
