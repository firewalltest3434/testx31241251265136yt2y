using System;

// Token: 0x02000009 RID: 9
internal sealed class Class10
{
	// Token: 0x0600002F RID: 47 RVA: 0x00002954 File Offset: 0x00000B54
	public Class37[] method_0()
	{
		return this.class37_0;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x0000295C File Offset: 0x00000B5C
	public void method_1(Class37[] class37_1)
	{
		this.class37_0 = class37_1;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002968 File Offset: 0x00000B68
	public Class126[] method_2()
	{
		return this.class126_0;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002970 File Offset: 0x00000B70
	public void method_3(Class126[] class126_1)
	{
		this.class126_0 = class126_1;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x0000297C File Offset: 0x00000B7C
	public string method_4()
	{
		return this.string_0;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002984 File Offset: 0x00000B84
	public void method_5(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002990 File Offset: 0x00000B90
	public int method_6()
	{
		return this.int_0;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002998 File Offset: 0x00000B98
	public void method_7(int int_2)
	{
		this.int_0 = int_2;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x000029A4 File Offset: 0x00000BA4
	public int method_8()
	{
		return this.int_1;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000029AC File Offset: 0x00000BAC
	public void method_9(int int_2)
	{
		this.int_1 = int_2;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x000029B8 File Offset: 0x00000BB8
	public byte method_10()
	{
		return this.byte_0;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x000029C0 File Offset: 0x00000BC0
	public void method_11(byte byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000029CC File Offset: 0x00000BCC
	public bool method_12()
	{
		return (this.method_10() & 2) > 0;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000029DC File Offset: 0x00000BDC
	public bool method_13()
	{
		return (this.method_10() & 1) > 0;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000029EC File Offset: 0x00000BEC
	public bool method_14()
	{
		return (this.method_10() & 4) > 0;
	}

	// Token: 0x0400000F RID: 15
	private int int_0;

	// Token: 0x04000010 RID: 16
	private string string_0;

	// Token: 0x04000011 RID: 17
	private Class126[] class126_0;

	// Token: 0x04000012 RID: 18
	private byte byte_0;

	// Token: 0x04000013 RID: 19
	private Class37[] class37_0;

	// Token: 0x04000014 RID: 20
	private int int_1;
}
