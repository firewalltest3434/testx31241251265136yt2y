using System;

// Token: 0x0200007E RID: 126
internal sealed class Class92 : Interface5
{
	// Token: 0x0600042D RID: 1069 RVA: 0x000172EC File Offset: 0x000154EC
	public Class92(Interface5 interface5_1)
	{
		this.interface5_0 = interface5_1;
		this.int_0 = interface5_1.imethod_2();
		this.byte_0 = new byte[this.int_0];
		this.byte_1 = new byte[this.int_0];
		this.byte_2 = new byte[this.int_0];
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00017348 File Offset: 0x00015548
	public Interface5 method_0()
	{
		return this.interface5_0;
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00017350 File Offset: 0x00015550
	public void imethod_1(bool bool_1, Interface1 interface1_0)
	{
		this.bool_0 = bool_1;
		if (interface1_0 is Class104)
		{
			Class104 @class = (Class104)interface1_0;
			byte[] array = @class.method_0();
			if (array.Length != this.int_0)
			{
				throw new ArgumentException("initialisation vector must be the same length as block size");
			}
			Array.Copy(array, 0, this.byte_0, 0, array.Length);
			interface1_0 = @class.method_1();
		}
		this.imethod_5();
		this.interface5_0.imethod_1(this.bool_0, interface1_0);
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x000173CC File Offset: 0x000155CC
	public string imethod_0()
	{
		return this.interface5_0.imethod_0() + "/CBC";
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x000173E4 File Offset: 0x000155E4
	public bool imethod_3()
	{
		return false;
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x000173E8 File Offset: 0x000155E8
	public int imethod_2()
	{
		return this.interface5_0.imethod_2();
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x000173F8 File Offset: 0x000155F8
	public int imethod_4(byte[] byte_3, int int_1, byte[] byte_4, int int_2)
	{
		if (!this.bool_0)
		{
			return this.method_2(byte_3, int_1, byte_4, int_2);
		}
		return this.method_1(byte_3, int_1, byte_4, int_2);
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x0001741C File Offset: 0x0001561C
	public void imethod_5()
	{
		Array.Copy(this.byte_0, 0, this.byte_1, 0, this.byte_0.Length);
		Array.Clear(this.byte_2, 0, this.byte_2.Length);
		this.interface5_0.imethod_5();
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00017458 File Offset: 0x00015658
	private int method_1(byte[] byte_3, int int_1, byte[] byte_4, int int_2)
	{
		if (int_1 + this.int_0 > byte_3.Length)
		{
			throw new Exception2("input buffer too short");
		}
		for (int i = 0; i < this.int_0; i++)
		{
			byte[] array = this.byte_1;
			int num = i;
			array[num] ^= byte_3[int_1 + i];
		}
		int result = this.interface5_0.imethod_4(this.byte_1, 0, byte_4, int_2);
		Array.Copy(byte_4, int_2, this.byte_1, 0, this.byte_1.Length);
		return result;
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x000174DC File Offset: 0x000156DC
	private int method_2(byte[] byte_3, int int_1, byte[] byte_4, int int_2)
	{
		if (int_1 + this.int_0 > byte_3.Length)
		{
			throw new Exception2("input buffer too short");
		}
		Array.Copy(byte_3, int_1, this.byte_2, 0, this.int_0);
		int result = this.interface5_0.imethod_4(byte_3, int_1, byte_4, int_2);
		for (int i = 0; i < this.int_0; i++)
		{
			int num = int_2 + i;
			byte_4[num] ^= this.byte_1[i];
		}
		byte[] array = this.byte_1;
		this.byte_1 = this.byte_2;
		this.byte_2 = array;
		return result;
	}

	// Token: 0x040000F5 RID: 245
	private byte[] byte_0;

	// Token: 0x040000F6 RID: 246
	private byte[] byte_1;

	// Token: 0x040000F7 RID: 247
	private byte[] byte_2;

	// Token: 0x040000F8 RID: 248
	private int int_0;

	// Token: 0x040000F9 RID: 249
	private Interface5 interface5_0;

	// Token: 0x040000FA RID: 250
	private bool bool_0;
}
