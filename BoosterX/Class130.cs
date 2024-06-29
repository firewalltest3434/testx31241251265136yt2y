using System;

// Token: 0x02000079 RID: 121
internal sealed class Class130 : Class129
{
	// Token: 0x06000419 RID: 1049 RVA: 0x00016C18 File Offset: 0x00014E18
	public Class130(Interface5 interface5_1, Interface0 interface0_1)
	{
		this.interface5_0 = interface5_1;
		this.interface0_0 = interface0_1;
		this.byte_1 = new byte[interface5_1.imethod_2()];
		this.int_0 = 0;
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x00016C48 File Offset: 0x00014E48
	public Class130(Interface5 interface5_1) : this(interface5_1, new Class15())
	{
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00016C58 File Offset: 0x00014E58
	public override void imethod_1(bool bool_1, Interface1 interface1_0)
	{
		this.bool_0 = bool_1;
		this.imethod_15();
		this.interface0_0.imethod_0();
		this.interface5_0.imethod_1(bool_1, interface1_0);
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00016C80 File Offset: 0x00014E80
	public override int imethod_3(int int_1)
	{
		int num = int_1 + this.int_0;
		int num2 = num % this.byte_1.Length;
		if (num2 != 0)
		{
			return num - num2 + this.byte_1.Length;
		}
		if (this.bool_0)
		{
			return num + this.byte_1.Length;
		}
		return num;
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x00016CC8 File Offset: 0x00014EC8
	public override int imethod_4(int int_1)
	{
		int num = int_1 + this.int_0;
		int num2 = num % this.byte_1.Length;
		if (num2 == 0)
		{
			return num - this.byte_1.Length;
		}
		return num - num2;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00016CFC File Offset: 0x00014EFC
	public override int imethod_8(byte[] byte_2, int int_1, int int_2, byte[] byte_3, int int_3)
	{
		if (int_2 < 0)
		{
			throw new ArgumentException("Can't have a negative input length!");
		}
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
		return num3;
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00016E00 File Offset: 0x00015000
	public override int imethod_12(byte[] byte_2, int int_1)
	{
		int num = this.interface5_0.imethod_2();
		int num2 = 0;
		if (!this.bool_0)
		{
			if (this.int_0 == num)
			{
				num2 = this.interface5_0.imethod_4(this.byte_1, 0, this.byte_1, 0);
				this.int_0 = 0;
				try
				{
					num2 -= this.interface0_0.imethod_3(this.byte_1);
					Array.Copy(this.byte_1, 0, byte_2, int_1, num2);
					return num2;
				}
				finally
				{
					this.imethod_15();
				}
			}
			this.imethod_15();
			throw new Exception2("last block incomplete in decryption");
		}
		if (this.int_0 == num)
		{
			if (int_1 + 2 * num > byte_2.Length)
			{
				this.imethod_15();
				throw new Exception2("output buffer too short");
			}
			num2 = this.interface5_0.imethod_4(this.byte_1, 0, byte_2, int_1);
			this.int_0 = 0;
		}
		this.interface0_0.imethod_2(this.byte_1, this.int_0);
		num2 += this.interface5_0.imethod_4(this.byte_1, 0, byte_2, int_1 + num2);
		this.imethod_15();
		return num2;
	}

	// Token: 0x040000F0 RID: 240
	private readonly Interface0 interface0_0;
}
