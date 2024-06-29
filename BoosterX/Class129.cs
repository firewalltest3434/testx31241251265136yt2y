using System;

// Token: 0x02000092 RID: 146
internal class Class129 : Class128
{
	// Token: 0x0600049F RID: 1183 RVA: 0x00018834 File Offset: 0x00016A34
	protected Class129()
	{
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x0001883C File Offset: 0x00016A3C
	public Class129(Interface5 interface5_1)
	{
		if (interface5_1 == null)
		{
			throw new ArgumentNullException("cipher");
		}
		this.interface5_0 = interface5_1;
		this.byte_1 = new byte[interface5_1.imethod_2()];
		this.int_0 = 0;
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00018874 File Offset: 0x00016A74
	public override string imethod_0()
	{
		return this.interface5_0.imethod_0();
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x00018884 File Offset: 0x00016A84
	public override void imethod_1(bool bool_1, Interface1 interface1_0)
	{
		this.bool_0 = bool_1;
		this.imethod_15();
		this.interface5_0.imethod_1(bool_1, interface1_0);
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x000188A0 File Offset: 0x00016AA0
	public override int imethod_2()
	{
		return this.interface5_0.imethod_2();
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x000188B0 File Offset: 0x00016AB0
	public override int imethod_4(int int_1)
	{
		int num = int_1 + this.int_0;
		int num2 = num % this.byte_1.Length;
		return num - num2;
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x000188D4 File Offset: 0x00016AD4
	public override int imethod_3(int int_1)
	{
		return int_1 + this.int_0;
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x000188E0 File Offset: 0x00016AE0
	public override byte[] imethod_6(byte[] byte_2, int int_1, int int_2)
	{
		if (byte_2 == null)
		{
			throw new ArgumentNullException("#=zakh_yIU=");
		}
		if (int_2 < 1)
		{
			return null;
		}
		int num = this.imethod_4(int_2);
		byte[] array = (num > 0) ? new byte[num] : null;
		int num2 = this.imethod_8(byte_2, int_1, int_2, array, 0);
		if (num > 0 && num2 < num)
		{
			byte[] array2 = new byte[num2];
			Array.Copy(array, 0, array2, 0, num2);
			array = array2;
		}
		return array;
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00018954 File Offset: 0x00016B54
	public override int imethod_8(byte[] byte_2, int int_1, int int_2, byte[] byte_3, int int_3)
	{
		if (int_2 < 1)
		{
			if (int_2 < 0)
			{
				throw new ArgumentException("Can't have a negative input length!");
			}
			return 0;
		}
		else
		{
			int num = this.imethod_2();
			int num2 = this.imethod_4(int_2);
			if (num2 > 0 && int_3 + num2 > byte_3.Length)
			{
				throw new Exception2("output buffer too short");
			}
			int num3 = 0;
			int num4 = this.byte_1.Length - this.int_0;
			if (int_2 > num4)
			{
				Array.Copy(byte_2, int_1, this.byte_1, this.int_0, num4);
				num3 += this.interface5_0.imethod_4(this.byte_1, 0, byte_3, int_3);
				this.int_0 = 0;
				int_2 -= num4;
				int_1 += num4;
				while (int_2 > this.byte_1.Length)
				{
					num3 += this.interface5_0.imethod_4(byte_2, int_1, byte_3, int_3 + num3);
					int_2 -= num;
					int_1 += num;
				}
			}
			Array.Copy(byte_2, int_1, this.byte_1, this.int_0, int_2);
			this.int_0 += int_2;
			if (this.int_0 == this.byte_1.Length)
			{
				num3 += this.interface5_0.imethod_4(this.byte_1, 0, byte_3, int_3 + num3);
				this.int_0 = 0;
			}
			return num3;
		}
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x00018A98 File Offset: 0x00016C98
	public override byte[] imethod_9()
	{
		byte[] array = Class128.byte_0;
		int num = this.imethod_3(0);
		if (num > 0)
		{
			array = new byte[num];
			int num2 = this.imethod_12(array, 0);
			if (num2 < array.Length)
			{
				byte[] array2 = new byte[num2];
				Array.Copy(array, 0, array2, 0, num2);
				array = array2;
			}
		}
		else
		{
			this.imethod_15();
		}
		return array;
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00018AEC File Offset: 0x00016CEC
	public override byte[] imethod_11(byte[] byte_2, int int_1, int int_2)
	{
		if (byte_2 == null)
		{
			throw new ArgumentNullException("#=zakh_yIU=");
		}
		int num = this.imethod_3(int_2);
		byte[] array = Class128.byte_0;
		if (num > 0)
		{
			array = new byte[num];
			int num2 = (int_2 > 0) ? this.imethod_8(byte_2, int_1, int_2, array, 0) : 0;
			num2 += this.imethod_12(array, num2);
			if (num2 < array.Length)
			{
				byte[] array2 = new byte[num2];
				Array.Copy(array, 0, array2, 0, num2);
				array = array2;
			}
		}
		else
		{
			this.imethod_15();
		}
		return array;
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00018B74 File Offset: 0x00016D74
	public override int imethod_12(byte[] byte_2, int int_1)
	{
		int result;
		try
		{
			if (this.int_0 != 0)
			{
				if (!this.interface5_0.imethod_3())
				{
					throw new Exception2("data not block size aligned");
				}
				if (int_1 + this.int_0 > byte_2.Length)
				{
					throw new Exception2("output buffer too short for DoFinal()");
				}
				this.interface5_0.imethod_4(this.byte_1, 0, this.byte_1, 0);
				Array.Copy(this.byte_1, 0, byte_2, int_1, this.int_0);
			}
			result = this.int_0;
		}
		finally
		{
			this.imethod_15();
		}
		return result;
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00018C08 File Offset: 0x00016E08
	public override void imethod_15()
	{
		Array.Clear(this.byte_1, 0, this.byte_1.Length);
		this.int_0 = 0;
		this.interface5_0.imethod_5();
	}

	// Token: 0x04000120 RID: 288
	internal byte[] byte_1;

	// Token: 0x04000121 RID: 289
	internal int int_0;

	// Token: 0x04000122 RID: 290
	internal bool bool_0;

	// Token: 0x04000123 RID: 291
	internal Interface5 interface5_0;
}
