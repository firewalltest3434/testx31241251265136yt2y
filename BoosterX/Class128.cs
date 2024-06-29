using System;

// Token: 0x020000C2 RID: 194
internal abstract class Class128 : Interface4
{
	// Token: 0x060005D6 RID: 1494
	public abstract string imethod_0();

	// Token: 0x060005D7 RID: 1495
	public abstract void imethod_1(bool bool_0, Interface1 interface1_0);

	// Token: 0x060005D8 RID: 1496
	public abstract int imethod_2();

	// Token: 0x060005D9 RID: 1497
	public abstract int imethod_3(int int_0);

	// Token: 0x060005DA RID: 1498
	public abstract int imethod_4(int int_0);

	// Token: 0x060005DB RID: 1499 RVA: 0x0001E390 File Offset: 0x0001C590
	public virtual byte[] imethod_5(byte[] byte_1)
	{
		return this.imethod_6(byte_1, 0, byte_1.Length);
	}

	// Token: 0x060005DC RID: 1500
	public abstract byte[] imethod_6(byte[] byte_1, int int_0, int int_1);

	// Token: 0x060005DD RID: 1501 RVA: 0x0001E3A0 File Offset: 0x0001C5A0
	public virtual int imethod_7(byte[] byte_1, byte[] byte_2, int int_0)
	{
		return this.imethod_8(byte_1, 0, byte_1.Length, byte_2, int_0);
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0001E3B0 File Offset: 0x0001C5B0
	public virtual int imethod_8(byte[] byte_1, int int_0, int int_1, byte[] byte_2, int int_2)
	{
		byte[] array = this.imethod_6(byte_1, int_0, int_1);
		if (array == null)
		{
			return 0;
		}
		if (int_2 + array.Length > byte_2.Length)
		{
			throw new Exception2("output buffer too short");
		}
		array.CopyTo(byte_2, int_2);
		return array.Length;
	}

	// Token: 0x060005DF RID: 1503
	public abstract byte[] imethod_9();

	// Token: 0x060005E0 RID: 1504 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
	public virtual byte[] imethod_10(byte[] byte_1)
	{
		return this.imethod_11(byte_1, 0, byte_1.Length);
	}

	// Token: 0x060005E1 RID: 1505
	public abstract byte[] imethod_11(byte[] byte_1, int int_0, int int_1);

	// Token: 0x060005E2 RID: 1506 RVA: 0x0001E400 File Offset: 0x0001C600
	public virtual int imethod_12(byte[] byte_1, int int_0)
	{
		byte[] array = this.imethod_9();
		if (int_0 + array.Length > byte_1.Length)
		{
			throw new Exception2("output buffer too short");
		}
		array.CopyTo(byte_1, int_0);
		return array.Length;
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0001E434 File Offset: 0x0001C634
	public virtual int imethod_13(byte[] byte_1, byte[] byte_2, int int_0)
	{
		return this.imethod_14(byte_1, 0, byte_1.Length, byte_2, int_0);
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0001E444 File Offset: 0x0001C644
	public virtual int imethod_14(byte[] byte_1, int int_0, int int_1, byte[] byte_2, int int_2)
	{
		int num = this.imethod_8(byte_1, int_0, int_1, byte_2, int_2);
		return num + this.imethod_12(byte_2, int_2 + num);
	}

	// Token: 0x060005E5 RID: 1509
	public abstract void imethod_15();

	// Token: 0x04000270 RID: 624
	protected static readonly byte[] byte_0 = new byte[0];
}
