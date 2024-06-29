using System;
using System.IO;
using System.Text;

// Token: 0x02000066 RID: 102
internal sealed class Class79 : IDisposable
{
	// Token: 0x06000384 RID: 900 RVA: 0x000143F4 File Offset: 0x000125F4
	public Class79(Class41 class41_1) : this(class41_1, new UTF8Encoding())
	{
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00014404 File Offset: 0x00012604
	private Class79(Class41 class41_1, Encoding encoding_0)
	{
		if (class41_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (encoding_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (!class41_1.vmethod_0())
		{
			throw new ArgumentException();
		}
		this.class41_0 = class41_1;
		this.decoder_0 = encoding_0.GetDecoder();
		this.int_0 = encoding_0.GetMaxCharCount(128);
		int num = encoding_0.GetMaxByteCount(1);
		if (num < 16)
		{
			num = 16;
		}
		this.byte_0 = new byte[num];
		this.char_1 = null;
		this.byte_1 = null;
		this.bool_0 = (encoding_0 is UnicodeEncoding);
		this.bool_1 = (this.class41_0 is Class43);
	}

	// Token: 0x06000386 RID: 902 RVA: 0x000144A8 File Offset: 0x000126A8
	public Class41 method_0()
	{
		return this.class41_0;
	}

	// Token: 0x06000387 RID: 903 RVA: 0x000144B0 File Offset: 0x000126B0
	public void method_1()
	{
		this.method_2(true);
	}

	// Token: 0x06000388 RID: 904 RVA: 0x000144BC File Offset: 0x000126BC
	private void method_2(bool bool_2)
	{
		if (bool_2)
		{
			Class41 @class = this.class41_0;
			this.class41_0 = null;
			if (@class != null)
			{
				@class.vmethod_6();
			}
		}
		this.class41_0 = null;
		this.byte_0 = null;
		this.decoder_0 = null;
		this.byte_1 = null;
		this.char_0 = null;
		this.char_1 = null;
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00014510 File Offset: 0x00012710
	void IDisposable.Dispose()
	{
		this.method_2(true);
	}

	// Token: 0x0600038A RID: 906 RVA: 0x0001451C File Offset: 0x0001271C
	public int method_3()
	{
		this.method_15();
		if (!this.class41_0.vmethod_2())
		{
			return -1;
		}
		long long_ = this.class41_0.vmethod_4();
		int result = this.method_4();
		this.class41_0.vmethod_5(long_);
		return result;
	}

	// Token: 0x0600038B RID: 907 RVA: 0x0001455C File Offset: 0x0001275C
	public int method_4()
	{
		this.method_15();
		return this.method_12();
	}

	// Token: 0x0600038C RID: 908 RVA: 0x0001456C File Offset: 0x0001276C
	public bool method_5()
	{
		this.method_17(1);
		return this.byte_0[0] > 0;
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00014580 File Offset: 0x00012780
	public byte method_6()
	{
		this.method_15();
		int num = this.class41_0.vmethod_12();
		if (num == -1)
		{
			throw new Exception();
		}
		return (byte)num;
	}

	// Token: 0x0600038E RID: 910 RVA: 0x000145A0 File Offset: 0x000127A0
	public sbyte method_7()
	{
		this.method_17(1);
		return (sbyte)this.byte_0[0];
	}

	// Token: 0x0600038F RID: 911 RVA: 0x000145B4 File Offset: 0x000127B4
	public char method_8()
	{
		int num = this.method_4();
		if (num == -1)
		{
			throw new Exception();
		}
		return (char)num;
	}

	// Token: 0x06000390 RID: 912 RVA: 0x000145C8 File Offset: 0x000127C8
	private static decimal smethod_0(int int_1, int int_2, int int_3, int int_4)
	{
		bool isNegative = (int_4 & int.MinValue) != 0;
		byte scale = (byte)(int_4 >> 16);
		return new decimal(int_1, int_2, int_3, isNegative, scale);
	}

	// Token: 0x06000391 RID: 913 RVA: 0x000145F0 File Offset: 0x000127F0
	internal static decimal smethod_1(byte[] byte_3)
	{
		int int_ = (int)byte_3[0] | (int)byte_3[1] << 8 | (int)byte_3[2] << 16 | (int)byte_3[3] << 24;
		int int_2 = (int)byte_3[4] | (int)byte_3[5] << 8 | (int)byte_3[6] << 16 | (int)byte_3[7] << 24;
		int int_3 = (int)byte_3[8] | (int)byte_3[9] << 8 | (int)byte_3[10] << 16 | (int)byte_3[11] << 24;
		int int_4 = (int)byte_3[12] | (int)byte_3[13] << 8 | (int)byte_3[14] << 16 | (int)byte_3[15] << 24;
		return Class79.smethod_0(int_, int_2, int_3, int_4);
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0001466C File Offset: 0x0001286C
	public string method_9()
	{
		int num = 0;
		this.method_15();
		int num2 = this.method_18();
		if (num2 < 0)
		{
			throw new IOException();
		}
		if (num2 == 0)
		{
			return string.Empty;
		}
		if (this.byte_1 == null)
		{
			this.byte_1 = new byte[128];
		}
		if (this.char_1 == null)
		{
			this.char_1 = new char[this.int_0];
		}
		StringBuilder stringBuilder = null;
		int chars;
		for (;;)
		{
			int int_ = (num2 - num > 128) ? 128 : (num2 - num);
			int num3 = this.class41_0.vmethod_11(this.byte_1, 0, int_);
			if (num3 == 0)
			{
				goto IL_103;
			}
			chars = this.decoder_0.GetChars(this.byte_1, 0, num3, this.char_1, 0);
			if (num == 0 && num3 == num2)
			{
				break;
			}
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder(num2);
			}
			stringBuilder.Append(this.char_1, 0, chars);
			num += num3;
			if (num >= num2)
			{
				goto Block_10;
			}
		}
		return new string(this.char_1, 0, chars);
		Block_10:
		return stringBuilder.ToString();
		IL_103:
		throw new Exception();
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00014784 File Offset: 0x00012984
	public int method_10(char[] char_2, int int_1, int int_2)
	{
		if (char_2 == null)
		{
			throw new ArgumentNullException("#=zakh_yIU=", "ArgumentNull_Buffer");
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (char_2.Length - int_1 < int_2)
		{
			throw new ArgumentException();
		}
		this.method_15();
		return this.method_11(char_2, int_1, int_2);
	}

	// Token: 0x06000394 RID: 916 RVA: 0x000147D8 File Offset: 0x000129D8
	private int method_11(char[] char_2, int int_1, int int_2)
	{
		int i = int_2;
		if (this.byte_1 == null)
		{
			this.byte_1 = new byte[128];
		}
		while (i > 0)
		{
			int num = i;
			if (this.bool_0)
			{
				num <<= 1;
			}
			if (num > 128)
			{
				num = 128;
			}
			int chars;
			if (this.bool_1)
			{
				Class43 @class = (Class43)this.class41_0;
				int byteIndex = @class.method_3();
				num = @class.method_4(num);
				if (num == 0)
				{
					return int_2 - i;
				}
				chars = this.decoder_0.GetChars(@class.method_1(), byteIndex, num, char_2, int_1);
			}
			else
			{
				num = this.class41_0.vmethod_11(this.byte_1, 0, num);
				if (num == 0)
				{
					return int_2 - i;
				}
				chars = this.decoder_0.GetChars(this.byte_1, 0, num, char_2, int_1);
			}
			i -= chars;
			int_1 += chars;
		}
		return int_2;
	}

	// Token: 0x06000395 RID: 917 RVA: 0x000148C4 File Offset: 0x00012AC4
	private int method_12()
	{
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		num3 = num2;
		if (this.class41_0.vmethod_2())
		{
			num3 = this.class41_0.vmethod_4();
		}
		if (this.byte_1 == null)
		{
			this.byte_1 = new byte[128];
		}
		if (this.char_0 == null)
		{
			this.char_0 = new char[1];
		}
		while (num == 0)
		{
			int num4 = this.bool_0 ? 2 : 1;
			int num5 = this.class41_0.vmethod_12();
			this.byte_1[0] = (byte)num5;
			if (num5 == -1)
			{
				num4 = 0;
			}
			if (num4 != 2)
			{
				goto IL_C6;
			}
			num5 = this.class41_0.vmethod_12();
			this.byte_1[1] = (byte)num5;
			if (num5 != -1)
			{
				goto IL_C6;
			}
			Block_8:
			try
			{
				num = this.decoder_0.GetChars(this.byte_1, 0, num4, this.char_0, 0);
			}
			catch
			{
				if (this.class41_0.vmethod_2())
				{
					this.class41_0.vmethod_9(num3 - this.class41_0.vmethod_4(), 1);
				}
				throw;
			}
			continue;
			IL_C6:
			if (num4 != 0)
			{
				goto Block_8;
			}
			return -1;
		}
		if (num == 0)
		{
			return -1;
		}
		return (int)this.char_0[0];
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00014A14 File Offset: 0x00012C14
	public char[] method_13(int int_1)
	{
		this.method_15();
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		char[] array = new char[int_1];
		int num = this.method_11(array, 0, int_1);
		if (num != int_1)
		{
			char[] array2 = new char[num];
			Buffer.BlockCopy(array, 0, array2, 0, 2 * num);
			array = array2;
		}
		return array;
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00014A64 File Offset: 0x00012C64
	public int method_14(byte[] byte_3, int int_1, int int_2)
	{
		if (byte_3 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_3.Length - int_1 < int_2)
		{
			throw new ArgumentException();
		}
		this.method_15();
		return this.class41_0.vmethod_11(byte_3, int_1, int_2);
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00014AB0 File Offset: 0x00012CB0
	private void method_15()
	{
		if (this.class41_0 == null)
		{
			throw new Exception();
		}
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00014AC0 File Offset: 0x00012CC0
	public byte[] method_16(int int_1)
	{
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.method_15();
		byte[] array = new byte[int_1];
		int num = 0;
		do
		{
			int num2 = this.class41_0.vmethod_11(array, num, int_1);
			if (num2 == 0)
			{
				break;
			}
			num += num2;
			int_1 -= num2;
		}
		while (int_1 > 0);
		if (num != array.Length)
		{
			byte[] array2 = new byte[num];
			Buffer.BlockCopy(array, 0, array2, 0, num);
			array = array2;
		}
		return array;
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00014B34 File Offset: 0x00012D34
	private void method_17(int int_1)
	{
		this.method_15();
		int num = 0;
		int num2;
		if (int_1 != 1)
		{
			for (;;)
			{
				num2 = this.class41_0.vmethod_11(this.byte_0, num, int_1 - num);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				if (num >= int_1)
				{
					return;
				}
			}
			throw new Exception();
		}
		num2 = this.class41_0.vmethod_12();
		if (num2 == -1)
		{
			throw new Exception();
		}
		this.byte_0[0] = (byte)num2;
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00014B98 File Offset: 0x00012D98
	internal int method_18()
	{
		int num = 0;
		int num2 = 0;
		while (num2 != 35)
		{
			byte b = this.method_6();
			num |= (int)(b & 127) << num2;
			num2 += 7;
			if ((b & 128) == 0)
			{
				return num;
			}
		}
		throw new FormatException();
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00014BD8 File Offset: 0x00012DD8
	public int method_19()
	{
		if (this.bool_1)
		{
			return ((Class43)this.class41_0).method_9();
		}
		this.method_17(4);
		return (int)this.byte_0[2] << 8 | (int)this.byte_0[3] << 16 | (int)this.byte_0[0] << 24 | (int)this.byte_0[1];
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00014C30 File Offset: 0x00012E30
	public uint method_20()
	{
		this.method_17(4);
		return (uint)((int)this.byte_0[2] << 16 | (int)this.byte_0[0] << 8 | (int)this.byte_0[1] | (int)this.byte_0[3] << 24);
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00014C64 File Offset: 0x00012E64
	public long method_21()
	{
		this.method_17(8);
		byte[] array = this.byte_0;
		return (long)((ulong)((int)array[7] << 16 | (int)array[3] | (int)array[1] << 24 | (int)array[6] << 8) | (ulong)((ulong)((long)((int)array[5] << 8 | (int)array[4] << 24 | (int)array[0] | (int)array[2] << 16)) << 32));
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00014CB4 File Offset: 0x00012EB4
	public ulong method_22()
	{
		this.method_17(8);
		byte[] array = this.byte_0;
		return (ulong)((int)array[4] | (int)array[0] << 16 | (int)array[1] << 24 | (int)array[2] << 8) | (ulong)((ulong)((long)((int)array[5] | (int)array[6] << 24 | (int)array[7] << 16 | (int)array[3] << 8)) << 32);
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00014D04 File Offset: 0x00012F04
	public short method_23()
	{
		this.method_17(2);
		byte[] array = this.byte_0;
		return (short)((int)array[0] << 8 | (int)array[1]);
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00014D2C File Offset: 0x00012F2C
	public ushort method_24()
	{
		this.method_17(2);
		byte[] array = this.byte_0;
		return (ushort)((int)array[1] << 8 | (int)array[0]);
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00014D54 File Offset: 0x00012F54
	private byte[] method_25()
	{
		byte[] array = this.byte_2;
		if (array == null)
		{
			array = (this.byte_2 = new byte[16]);
		}
		return array;
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00014D7C File Offset: 0x00012F7C
	public float method_26()
	{
		this.method_17(4);
		byte[] array = this.byte_0;
		byte[] array2 = this.method_25();
		array2[1] = array[0];
		array2[3] = array[3];
		array2[0] = array[1];
		array2[2] = array[2];
		return this.method_29(array2).ReadSingle();
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00014DC4 File Offset: 0x00012FC4
	public double method_27()
	{
		this.method_17(8);
		byte[] array = this.byte_0;
		byte[] array2 = this.method_25();
		array2[6] = array[5];
		array2[5] = array[6];
		array2[1] = array[4];
		array2[3] = array[3];
		array2[2] = array[1];
		array2[7] = array[0];
		array2[4] = array[2];
		array2[0] = array[7];
		return this.method_29(array2).ReadDouble();
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00014E24 File Offset: 0x00013024
	public decimal method_28()
	{
		this.method_17(16);
		byte[] array = this.byte_0;
		byte[] array2 = this.method_25();
		array2[14] = array[12];
		array2[8] = array[2];
		array2[12] = array[4];
		array2[11] = array[6];
		array2[9] = array[14];
		array2[5] = array[5];
		array2[10] = array[9];
		array2[6] = array[13];
		array2[1] = array[3];
		array2[4] = array[0];
		array2[13] = array[1];
		array2[0] = array[15];
		array2[15] = array[7];
		array2[7] = array[11];
		array2[3] = array[8];
		array2[2] = array[10];
		return Class79.smethod_1(array2);
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00014EBC File Offset: 0x000130BC
	private BinaryReader method_29(byte[] byte_3)
	{
		MemoryStream memoryStream = this.memoryStream_0;
		BinaryReader binaryReader = this.binaryReader_0;
		if (memoryStream == null)
		{
			memoryStream = (this.memoryStream_0 = new MemoryStream(8));
			binaryReader = (this.binaryReader_0 = new BinaryReader(memoryStream));
		}
		else
		{
			binaryReader.BaseStream.Position = 0L;
		}
		memoryStream.Write(byte_3, 0, byte_3.Length);
		memoryStream.Position = 0L;
		return binaryReader;
	}

	// Token: 0x040000BA RID: 186
	private Class41 class41_0;

	// Token: 0x040000BB RID: 187
	private byte[] byte_0;

	// Token: 0x040000BC RID: 188
	private Decoder decoder_0;

	// Token: 0x040000BD RID: 189
	private byte[] byte_1;

	// Token: 0x040000BE RID: 190
	private char[] char_0;

	// Token: 0x040000BF RID: 191
	private char[] char_1;

	// Token: 0x040000C0 RID: 192
	private int int_0;

	// Token: 0x040000C1 RID: 193
	private bool bool_0;

	// Token: 0x040000C2 RID: 194
	private bool bool_1;

	// Token: 0x040000C3 RID: 195
	private byte[] byte_2;

	// Token: 0x040000C4 RID: 196
	private MemoryStream memoryStream_0;

	// Token: 0x040000C5 RID: 197
	private BinaryReader binaryReader_0;
}
