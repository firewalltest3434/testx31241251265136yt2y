using System;

// Token: 0x02000051 RID: 81
internal sealed class Class39
{
	// Token: 0x060002FA RID: 762 RVA: 0x00011DFC File Offset: 0x0000FFFC
	static Class39()
	{
		Class39.class39_0 = new Class39(0, Class39.int_0, false);
		Class39.class39_0.int_3 = 0;
		Class39.class39_1 = Class39.smethod_17(1UL);
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00011E60 File Offset: 0x00010060
	public Class39(int int_5, int[] int_6, bool bool_0)
	{
		if (!bool_0)
		{
			this.int_2 = int_5;
			this.int_1 = int_6;
			return;
		}
		int num = 0;
		while (num < int_6.Length && int_6[num] == 0)
		{
			num++;
		}
		if (num == int_6.Length)
		{
			this.int_2 = 0;
			this.int_1 = Class39.int_0;
			return;
		}
		this.int_2 = int_5;
		if (num == 0)
		{
			this.int_1 = int_6;
			return;
		}
		this.int_1 = new int[int_6.Length - num];
		Array.Copy(int_6, num, this.int_1, 0, this.int_1.Length);
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00011F04 File Offset: 0x00010104
	public Class39(int int_5, byte[] byte_1) : this(int_5, byte_1, 0, byte_1.Length)
	{
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00011F14 File Offset: 0x00010114
	public Class39(int int_5, byte[] byte_1, int int_6, int int_7)
	{
		if (int_5 == 0)
		{
			this.int_2 = 0;
			this.int_1 = Class39.int_0;
			return;
		}
		this.int_1 = Class39.smethod_1(byte_1, int_6, int_7);
		this.int_2 = ((this.int_1.Length < 1) ? 0 : int_5);
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00011F74 File Offset: 0x00010174
	public int[] method_0()
	{
		return this.int_1;
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00011F7C File Offset: 0x0001017C
	private static int smethod_0(int int_5)
	{
		return (int_5 + 8 - 1) / 8;
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00011F88 File Offset: 0x00010188
	private static int[] smethod_1(byte[] byte_1, int int_5, int int_6)
	{
		int num = int_5 + int_6;
		int num2 = int_5;
		while (num2 < num && byte_1[num2] == 0)
		{
			num2++;
		}
		if (num2 >= num)
		{
			return Class39.int_0;
		}
		int num3 = (num - num2 + 3) / 4;
		int num4 = (num - num2) % 4;
		if (num4 == 0)
		{
			num4 = 4;
		}
		if (num3 < 1)
		{
			return Class39.int_0;
		}
		int[] array = new int[num3];
		int num5 = 0;
		int num6 = 0;
		for (int i = num2; i < num; i++)
		{
			num5 <<= 8;
			num5 |= (int)(byte_1[i] & byte.MaxValue);
			num4--;
			if (num4 <= 0)
			{
				array[num6] = num5;
				num6++;
				num4 = 4;
				num5 = 0;
			}
		}
		if (num6 < array.Length)
		{
			array[num6] = num5;
		}
		return array;
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00012050 File Offset: 0x00010250
	private static int smethod_2(int int_5, int int_6, int[] int_7)
	{
		while (int_6 < int_7.Length)
		{
			if (int_7[int_6] != 0)
			{
				int num = 32 * (int_7.Length - int_6 - 1);
				int int_8 = int_7[int_6];
				return num + Class39.smethod_3(int_8);
			}
			int_6++;
		}
		return 0;
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00012088 File Offset: 0x00010288
	public int method_1()
	{
		if (this.int_3 == -1)
		{
			this.int_3 = ((this.int_2 == 0) ? 0 : Class39.smethod_2(this.int_2, 0, this.int_1));
		}
		return this.int_3;
	}

	// Token: 0x06000303 RID: 771 RVA: 0x000120BC File Offset: 0x000102BC
	private static int smethod_3(int int_5)
	{
		uint num = (uint)int_5 >> 24;
		if (num != 0U)
		{
			return (int)(24 + Class39.byte_0[(int)num]);
		}
		num = (uint)int_5 >> 16;
		if (num != 0U)
		{
			return (int)(16 + Class39.byte_0[(int)num]);
		}
		num = (uint)int_5 >> 8;
		if (num != 0U)
		{
			return (int)(8 + Class39.byte_0[(int)num]);
		}
		return (int)Class39.byte_0[int_5];
	}

	// Token: 0x06000304 RID: 772 RVA: 0x0001210C File Offset: 0x0001030C
	public int method_2(object object_0)
	{
		return this.method_3((Class39)object_0);
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0001211C File Offset: 0x0001031C
	private static int smethod_4(int int_5, int[] int_6, int int_7, int[] int_8)
	{
		while (int_5 != int_6.Length && int_6[int_5] == 0)
		{
			int_5++;
		}
		while (int_7 != int_8.Length && int_8[int_7] == 0)
		{
			int_7++;
		}
		return Class39.smethod_5(int_5, int_6, int_7, int_8);
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00012178 File Offset: 0x00010378
	private static int smethod_5(int int_5, int[] int_6, int int_7, int[] int_8)
	{
		int num = int_6.Length - int_8.Length - (int_5 - int_7);
		if (num == 0)
		{
			while (int_5 < int_6.Length)
			{
				uint num2 = (uint)int_6[int_5++];
				uint num3 = (uint)int_8[int_7++];
				if (num2 != num3)
				{
					if (num2 >= num3)
					{
						return 1;
					}
					return -1;
				}
			}
			return 0;
		}
		if (num >= 0)
		{
			return 1;
		}
		return -1;
	}

	// Token: 0x06000307 RID: 775 RVA: 0x000121DC File Offset: 0x000103DC
	public int method_3(Class39 class39_2)
	{
		if (this.int_2 < class39_2.int_2)
		{
			return -1;
		}
		if (this.int_2 > class39_2.int_2)
		{
			return 1;
		}
		if (this.int_2 != 0)
		{
			return this.int_2 * Class39.smethod_5(0, this.int_1, 0, class39_2.int_1);
		}
		return 0;
	}

	// Token: 0x06000308 RID: 776 RVA: 0x0001223C File Offset: 0x0001043C
	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		Class39 @class = obj as Class39;
		return @class != null && this.int_2 == @class.int_2 && this.method_4(@class);
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00012274 File Offset: 0x00010474
	public override int GetHashCode()
	{
		int num = this.int_1.Length;
		if (this.int_1.Length != 0)
		{
			num ^= this.int_1[0];
			if (this.int_1.Length > 1)
			{
				num ^= this.int_1[this.int_1.Length - 1];
			}
		}
		return num;
	}

	// Token: 0x0600030A RID: 778 RVA: 0x000122C0 File Offset: 0x000104C0
	private bool method_4(Class39 class39_2)
	{
		if (this.int_1.Length != class39_2.int_1.Length)
		{
			return false;
		}
		for (int i = 0; i < this.int_1.Length; i++)
		{
			if (this.int_1[i] != class39_2.int_1[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600030B RID: 779 RVA: 0x0001231C File Offset: 0x0001051C
	public Class39 method_5(Class39 class39_2, Class39 class39_3)
	{
		if (class39_3.Equals(Class39.class39_1))
		{
			return Class39.class39_0;
		}
		if (class39_2.int_2 == 0)
		{
			return Class39.class39_1;
		}
		if (this.int_2 == 0)
		{
			return Class39.class39_0;
		}
		Class39 @class = this;
		if (!class39_2.Equals(Class39.class39_1))
		{
			@class = Class39.smethod_6(@class, class39_2.int_1[0], class39_3);
		}
		return @class;
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00012378 File Offset: 0x00010578
	private static Class39 smethod_6(Class39 class39_2, int int_5, Class39 class39_3)
	{
		int num = class39_3.int_1.Length;
		int num2 = 32 * num;
		bool bool_ = class39_3.method_1() + 2 <= num2;
		uint uint_ = (uint)class39_3.method_6();
		class39_2 = class39_2.method_7(num2).method_12(class39_3);
		int[] int_6 = new int[num + 1];
		int[] array = class39_2.int_1;
		if (array.Length < num)
		{
			int[] array2 = new int[num];
			Buffer.BlockCopy(array, 0, array2, num - array.Length, array.Length * 4);
			array = array2;
		}
		int[] array3 = Class39.smethod_20(array);
		Class39.smethod_10(int_6, array3, class39_3.int_1, uint_, bool_);
		int[] array4 = Class39.smethod_12(int_5);
		int num3 = array4[0];
		int num4 = num3 >> 8;
		num4--;
		int num5 = 1;
		while ((num3 = array4[num5++]) != -1)
		{
			int num6 = num4 + 1;
			for (int i = 0; i < num6; i++)
			{
				Class39.smethod_10(int_6, array3, class39_3.int_1, uint_, bool_);
			}
			Class39.smethod_9(int_6, array3, array, class39_3.int_1, uint_, bool_);
			num4 = num3 >> 8;
		}
		for (int j = 0; j < num4; j++)
		{
			Class39.smethod_10(int_6, array3, class39_3.int_1, uint_, bool_);
		}
		Class39.smethod_8(array3, class39_3.int_1, uint_);
		return new Class39(1, array3, true);
	}

	// Token: 0x0600030D RID: 781 RVA: 0x000124CC File Offset: 0x000106CC
	private static int smethod_7(int int_5)
	{
		int num = int_5 + ((int_5 + 1 & 4) << 1);
		num *= 2 - int_5 * num;
		num *= 2 - int_5 * num;
		return num * (2 - int_5 * num);
	}

	// Token: 0x0600030E RID: 782 RVA: 0x000124FC File Offset: 0x000106FC
	private int method_6()
	{
		if (this.int_4 != 0)
		{
			return this.int_4;
		}
		int int_ = -this.int_1[this.int_1.Length - 1];
		return this.int_4 = Class39.smethod_7(int_);
	}

	// Token: 0x0600030F RID: 783 RVA: 0x0001253C File Offset: 0x0001073C
	private static void smethod_8(int[] int_5, int[] int_6, uint uint_0)
	{
		int num = int_6.Length;
		for (int i = num - 1; i >= 0; i--)
		{
			uint num2 = (uint)int_5[num - 1];
			ulong num3 = (ulong)(num2 * uint_0);
			ulong num4 = num3 * (ulong)int_6[num - 1] + (ulong)num2;
			num4 >>= 32;
			for (int j = num - 2; j >= 0; j--)
			{
				num4 += num3 * (ulong)int_6[j] + (ulong)int_5[j];
				int_5[j + 1] = (int)num4;
				num4 >>= 32;
			}
			int_5[0] = (int)num4;
		}
		if (Class39.smethod_4(0, int_5, 0, int_6) >= 0)
		{
			Class39.smethod_16(0, int_5, 0, int_6);
		}
	}

	// Token: 0x06000310 RID: 784 RVA: 0x000125D4 File Offset: 0x000107D4
	private static void smethod_9(int[] int_5, int[] int_6, int[] int_7, int[] int_8, uint uint_0, bool bool_0)
	{
		int num = int_8.Length;
		if (num == 1)
		{
			int_6[0] = (int)Class39.smethod_11((uint)int_6[0], (uint)int_7[0], (uint)int_8[0], uint_0);
			return;
		}
		uint num2 = (uint)int_7[num - 1];
		ulong num3 = (ulong)int_6[num - 1];
		ulong num4 = num3 * (ulong)num2;
		ulong num5 = (ulong)((uint)num4 * uint_0);
		ulong num6 = num5 * (ulong)int_8[num - 1];
		num4 += (ulong)((uint)num6);
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int i = num - 2; i >= 0; i--)
		{
			ulong num7 = num3 * (ulong)int_7[i];
			num6 = num5 * (ulong)int_8[i];
			num4 += (num7 & 4294967295UL) + (ulong)((uint)num6);
			int_5[i + 2] = (int)num4;
			num4 = (num4 >> 32) + (num7 >> 32) + (num6 >> 32);
		}
		int_5[1] = (int)num4;
		int num8 = (int)(num4 >> 32);
		for (int j = num - 2; j >= 0; j--)
		{
			uint num9 = (uint)int_5[num];
			ulong num10 = (ulong)int_6[j];
			ulong num11 = num10 * (ulong)num2;
			ulong num12 = (num11 & 4294967295UL) + (ulong)num9;
			ulong num13 = (ulong)((uint)num12 * uint_0);
			ulong num14 = num13 * (ulong)int_8[num - 1];
			num12 += (ulong)((uint)num14);
			num12 = (num12 >> 32) + (num11 >> 32) + (num14 >> 32);
			for (int k = num - 2; k >= 0; k--)
			{
				num11 = num10 * (ulong)int_7[k];
				num14 = num13 * (ulong)int_8[k];
				num12 += (num11 & 4294967295UL) + (ulong)((uint)num14) + (ulong)int_5[k + 1];
				int_5[k + 2] = (int)num12;
				num12 = (num12 >> 32) + (num11 >> 32) + (num14 >> 32);
			}
			num12 += (ulong)num8;
			int_5[1] = (int)num12;
			num8 = (int)(num12 >> 32);
		}
		int_5[0] = num8;
		if (!bool_0 && Class39.smethod_4(0, int_5, 0, int_8) >= 0)
		{
			Class39.smethod_16(0, int_5, 0, int_8);
		}
		Array.Copy(int_5, 1, int_6, 0, num);
	}

	// Token: 0x06000311 RID: 785 RVA: 0x000127A4 File Offset: 0x000109A4
	private static void smethod_10(int[] int_5, int[] int_6, int[] int_7, uint uint_0, bool bool_0)
	{
		int num = int_7.Length;
		if (num == 1)
		{
			uint num2 = (uint)int_6[0];
			int_6[0] = (int)Class39.smethod_11(num2, num2, (uint)int_7[0], uint_0);
			return;
		}
		ulong num3 = (ulong)int_6[num - 1];
		ulong num4 = num3 * num3;
		ulong num5 = (ulong)((uint)num4 * uint_0);
		ulong num6 = num5 * (ulong)int_7[num - 1];
		num4 += (ulong)((uint)num6);
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int i = num - 2; i >= 0; i--)
		{
			ulong num7 = num3 * (ulong)int_6[i];
			num6 = num5 * (ulong)int_7[i];
			num4 += (num6 & 4294967295UL) + (ulong)((ulong)((uint)num7) << 1);
			int_5[i + 2] = (int)num4;
			num4 = (num4 >> 32) + (num7 >> 31) + (num6 >> 32);
		}
		int_5[1] = (int)num4;
		int num8 = (int)(num4 >> 32);
		for (int j = num - 2; j >= 0; j--)
		{
			uint num9 = (uint)int_5[num];
			ulong num10 = (ulong)(num9 * uint_0);
			ulong num11 = num10 * (ulong)int_7[num - 1] + (ulong)num9;
			num11 >>= 32;
			for (int k = num - 2; k > j; k--)
			{
				num11 += num10 * (ulong)int_7[k] + (ulong)int_5[k + 1];
				int_5[k + 2] = (int)num11;
				num11 >>= 32;
			}
			ulong num12 = (ulong)int_6[j];
			ulong num13 = num12 * num12;
			ulong num14 = num10 * (ulong)int_7[j];
			num11 += (num13 & 4294967295UL) + (ulong)((uint)num14) + (ulong)int_5[j + 1];
			int_5[j + 2] = (int)num11;
			num11 = (num11 >> 32) + (num13 >> 32) + (num14 >> 32);
			for (int l = j - 1; l >= 0; l--)
			{
				ulong num15 = num12 * (ulong)int_6[l];
				ulong num16 = num10 * (ulong)int_7[l];
				num11 += (num16 & 4294967295UL) + (ulong)((ulong)((uint)num15) << 1) + (ulong)int_5[l + 1];
				int_5[l + 2] = (int)num11;
				num11 = (num11 >> 32) + (num15 >> 31) + (num16 >> 32);
			}
			num11 += (ulong)num8;
			int_5[1] = (int)num11;
			num8 = (int)(num11 >> 32);
		}
		int_5[0] = num8;
		if (!bool_0 && Class39.smethod_4(0, int_5, 0, int_7) >= 0)
		{
			Class39.smethod_16(0, int_5, 0, int_7);
		}
		Array.Copy(int_5, 1, int_6, 0, num);
	}

	// Token: 0x06000312 RID: 786 RVA: 0x000129C8 File Offset: 0x00010BC8
	private static uint smethod_11(uint uint_0, uint uint_1, uint uint_2, uint uint_3)
	{
		ulong num = (ulong)uint_0 * (ulong)uint_1;
		uint num2 = (uint)num * uint_3;
		ulong num3 = (ulong)uint_2;
		ulong num4 = num3 * (ulong)num2;
		num += (ulong)((uint)num4);
		num = (num >> 32) + (num4 >> 32);
		if (num > num3)
		{
			num -= num3;
		}
		return (uint)num;
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00012A04 File Offset: 0x00010C04
	private static int[] smethod_12(int int_5)
	{
		int num = Class39.smethod_3(int_5);
		int[] array = new int[num + 2];
		int num2 = 0;
		int i = 33 - num;
		int_5 <<= i;
		int num3 = 0;
		while (i < 32)
		{
			if (int_5 < 0)
			{
				array[num2++] = (1 | num3 << 8);
				num3 = 0;
			}
			else
			{
				num3++;
			}
			int_5 <<= 1;
			i++;
		}
		array[num2++] = (1 | num3 << 8);
		array[num2] = -1;
		return array;
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00012A80 File Offset: 0x00010C80
	private static int[] smethod_13(int[] int_5, int int_6)
	{
		int num = (int)((uint)int_6 >> 5);
		int num2 = int_6 & 31;
		int num3 = int_5.Length;
		int[] array;
		if (num2 == 0)
		{
			array = new int[num3 + num];
			int_5.CopyTo(array, 0);
		}
		else
		{
			int num4 = 0;
			int num5 = 32 - num2;
			int num6 = (int)((uint)int_5[0] >> num5);
			if (num6 != 0)
			{
				array = new int[num3 + num + 1];
				array[num4++] = num6;
			}
			else
			{
				array = new int[num3 + num];
			}
			int num7 = int_5[0];
			for (int i = 0; i < num3 - 1; i++)
			{
				int num8 = int_5[i + 1];
				array[num4++] = (num7 << num2 | (int)((uint)num8 >> num5));
				num7 = num8;
			}
			array[num4] = int_5[num3 - 1] << num2;
		}
		return array;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00012B48 File Offset: 0x00010D48
	private Class39 method_7(int int_5)
	{
		if (this.int_2 == 0 || this.int_1.Length == 0)
		{
			return Class39.class39_0;
		}
		if (int_5 == 0)
		{
			return this;
		}
		Class39 @class = new Class39(this.int_2, Class39.smethod_13(this.int_1, int_5), true);
		if (this.int_3 != -1)
		{
			@class.int_3 = this.int_3 + int_5;
		}
		return @class;
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00012BB0 File Offset: 0x00010DB0
	private static void smethod_14(int int_5, int[] int_6, int int_7)
	{
		int num = (int)(((uint)int_7 >> 5) + (uint)int_5);
		int num2 = int_7 & 31;
		int num3 = int_6.Length - 1;
		if (num != int_5)
		{
			int num4 = num - int_5;
			for (int i = num3; i >= num; i--)
			{
				int_6[i] = int_6[i - num4];
			}
			for (int j = num - 1; j >= int_5; j--)
			{
				int_6[j] = 0;
			}
		}
		if (num2 != 0)
		{
			int num5 = 32 - num2;
			int num6 = int_6[num3];
			for (int k = num3; k > num; k--)
			{
				int num7 = int_6[k - 1];
				int_6[k] = (int)((uint)num6 >> num2 | (uint)((uint)num7 << num5));
				num6 = num7;
			}
			int_6[num] = (int)((uint)int_6[num] >> num2);
		}
	}

	// Token: 0x06000317 RID: 791 RVA: 0x00012C68 File Offset: 0x00010E68
	private static void smethod_15(int int_5, int[] int_6)
	{
		int num = int_6.Length;
		int num2 = int_6[num - 1];
		while (--num > int_5)
		{
			int num3 = int_6[num - 1];
			int_6[num] = (int)((uint)num2 >> 1 | (uint)((uint)num3 << 31));
			num2 = num3;
		}
		int_6[int_5] = (int)((uint)int_6[int_5] >> 1);
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00012CAC File Offset: 0x00010EAC
	public int method_8()
	{
		return this.int_2;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00012CB4 File Offset: 0x00010EB4
	private static int[] smethod_16(int int_5, int[] int_6, int int_7, int[] int_8)
	{
		int num = int_6.Length;
		int num2 = int_8.Length;
		int num3 = 0;
		do
		{
			long num4 = ((long)int_6[--num] & 4294967295L) - ((long)int_8[--num2] & 4294967295L) + (long)num3;
			int_6[num] = (int)num4;
			num3 = (int)(num4 >> 63);
		}
		while (num2 > int_7);
		if (num3 != 0)
		{
			int num6;
			do
			{
				int num5 = --num;
				num6 = int_6[num5] - 1;
				int_6[num5] = num6;
			}
			while (num6 == -1);
		}
		return int_6;
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00012D30 File Offset: 0x00010F30
	public byte[] method_9()
	{
		if (this.int_2 == 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[Class39.smethod_0(this.method_1())];
		this.method_11(array, 0);
		return array;
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00012D68 File Offset: 0x00010F68
	public int method_10()
	{
		return this.method_11(null, 0);
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00012D74 File Offset: 0x00010F74
	public int method_11(byte[] byte_1, int int_5)
	{
		if (this.int_2 == 0)
		{
			return 0;
		}
		int num = Class39.smethod_0(this.method_1());
		if (byte_1 == null)
		{
			return num;
		}
		int i = this.int_1.Length;
		int num2 = int_5 + num;
		if (num2 > byte_1.Length)
		{
			throw new IndexOutOfRangeException();
		}
		while (i > 1)
		{
			uint num3 = (uint)this.int_1[--i];
			byte_1[--num2] = (byte)num3;
			byte_1[--num2] = (byte)(num3 >> 8);
			byte_1[--num2] = (byte)(num3 >> 16);
			byte_1[--num2] = (byte)(num3 >> 24);
		}
		uint num4;
		for (num4 = (uint)this.int_1[0]; num4 > 255U; num4 >>= 8)
		{
			byte_1[--num2] = (byte)num4;
		}
		byte_1[num2 - 1] = (byte)num4;
		return num;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x00012E38 File Offset: 0x00011038
	private static Class39 smethod_17(ulong ulong_0)
	{
		int num = (int)(ulong_0 >> 32);
		int num2 = (int)ulong_0;
		if (num != 0)
		{
			return new Class39(1, new int[]
			{
				num,
				num2
			}, false);
		}
		if (num2 != 0)
		{
			return new Class39(1, new int[]
			{
				num2
			}, false);
		}
		return Class39.class39_0;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00012E84 File Offset: 0x00011084
	public static Class39 smethod_18(ulong ulong_0)
	{
		return Class39.smethod_17(ulong_0);
	}

	// Token: 0x0600031F RID: 799 RVA: 0x00012E8C File Offset: 0x0001108C
	private static int[] smethod_19(int[] int_5, int[] int_6)
	{
		int num = 0;
		while (num < int_5.Length && int_5[num] == 0)
		{
			num++;
		}
		int num2 = 0;
		while (num2 < int_6.Length && int_6[num2] == 0)
		{
			num2++;
		}
		int num3 = Class39.smethod_5(num, int_5, num2, int_6);
		if (num3 > 0)
		{
			int num4 = Class39.smethod_2(1, num2, int_6);
			int num5 = Class39.smethod_2(1, num, int_5);
			int num6 = num5 - num4;
			int num7 = 0;
			int num8 = num4;
			int[] array;
			if (num6 > 0)
			{
				array = Class39.smethod_13(int_6, num6);
				num8 += num6;
			}
			else
			{
				int num9 = int_6.Length - num2;
				array = new int[num9];
				Array.Copy(int_6, num2, array, 0, num9);
			}
			for (;;)
			{
				if (num8 < num5 || Class39.smethod_5(num, int_5, num7, array) >= 0)
				{
					Class39.smethod_16(num, int_5, num7, array);
					while (int_5[num] == 0)
					{
						if (++num == int_5.Length)
						{
							return int_5;
						}
					}
					num5 = 32 * (int_5.Length - num - 1) + Class39.smethod_3(int_5[num]);
					if (num5 <= num4)
					{
						if (num5 < num4)
						{
							return int_5;
						}
						num3 = Class39.smethod_5(num, int_5, num2, int_6);
						if (num3 <= 0)
						{
							goto IL_188;
						}
					}
				}
				num6 = num8 - num5;
				if (num6 == 1)
				{
					uint num10 = (uint)array[num7] >> 1;
					uint num11 = (uint)int_5[num];
					if (num10 > num11)
					{
						num6++;
					}
				}
				if (num6 < 2)
				{
					Class39.smethod_15(num7, array);
					num8--;
				}
				else
				{
					Class39.smethod_14(num7, array, num6);
					num8 -= num6;
				}
				while (array[num7] == 0)
				{
					num7++;
				}
			}
			return int_5;
		}
		IL_188:
		if (num3 == 0)
		{
			Array.Clear(int_5, num, int_5.Length - num);
		}
		return int_5;
	}

	// Token: 0x06000320 RID: 800 RVA: 0x00013038 File Offset: 0x00011238
	private Class39 method_12(Class39 class39_2)
	{
		if (this.int_2 == 0)
		{
			return Class39.class39_0;
		}
		if (Class39.smethod_5(0, this.int_1, 0, class39_2.int_1) < 0)
		{
			return this;
		}
		int[] array = (int[])this.int_1.Clone();
		array = Class39.smethod_19(array, class39_2.int_1);
		return new Class39(this.int_2, array, true);
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00013098 File Offset: 0x00011298
	private static int[] smethod_20(int[] int_5)
	{
		int[] array = new int[int_5.Length];
		Buffer.BlockCopy(int_5, 0, array, 0, int_5.Length * 4);
		return array;
	}

	// Token: 0x04000092 RID: 146
	private static readonly int[] int_0 = new int[0];

	// Token: 0x04000093 RID: 147
	public static readonly Class39 class39_0;

	// Token: 0x04000094 RID: 148
	public static readonly Class39 class39_1;

	// Token: 0x04000095 RID: 149
	private static readonly byte[] byte_0 = new byte[]
	{
		0,
		1,
		2,
		2,
		3,
		3,
		3,
		3,
		4,
		4,
		4,
		4,
		4,
		4,
		4,
		4,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8
	};

	// Token: 0x04000096 RID: 150
	private int[] int_1;

	// Token: 0x04000097 RID: 151
	private int int_2;

	// Token: 0x04000098 RID: 152
	private int int_3 = -1;

	// Token: 0x04000099 RID: 153
	private int int_4;
}
