using System;

// Token: 0x02000012 RID: 18
internal sealed class Class14
{
	// Token: 0x06000069 RID: 105 RVA: 0x000030DC File Offset: 0x000012DC
	public void method_0(bool bool_0, Class89 class89_1)
	{
		this.class89_0 = class89_1;
		this.int_0 = this.class89_0.method_1().method_1();
		this.method_2(Class14.smethod_0(this.int_0, bool_0));
		this.method_4(Class14.smethod_1(this.int_0, bool_0));
	}

	// Token: 0x0600006A RID: 106 RVA: 0x0000312C File Offset: 0x0000132C
	public int method_1()
	{
		return this.int_1;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00003134 File Offset: 0x00001334
	private void method_2(int int_3)
	{
		this.int_1 = int_3;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00003140 File Offset: 0x00001340
	public int method_3()
	{
		return this.int_2;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00003148 File Offset: 0x00001348
	private void method_4(int int_3)
	{
		this.int_2 = int_3;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00003154 File Offset: 0x00001354
	private static int smethod_0(int int_3, bool bool_0)
	{
		if (!bool_0)
		{
			return (int_3 + 7) / 8;
		}
		return (int_3 - 1) / 8;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00003164 File Offset: 0x00001364
	private static int smethod_1(int int_3, bool bool_0)
	{
		if (!bool_0)
		{
			return (int_3 - 1) / 8;
		}
		return (int_3 + 7) / 8;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00003174 File Offset: 0x00001374
	public Class39 method_5(byte[] byte_0, int int_3, int int_4)
	{
		return new Class39(1, byte_0, int_3, int_4);
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00003180 File Offset: 0x00001380
	public int method_6(Class39 class39_0, byte[] byte_0, int int_3)
	{
		int num = this.method_3() - class39_0.method_10();
		Array.Clear(byte_0, int_3, num);
		int_3 += num;
		class39_0.method_11(byte_0, int_3);
		return this.method_3();
	}

	// Token: 0x06000072 RID: 114 RVA: 0x000031BC File Offset: 0x000013BC
	public Class39 method_7(Class39 class39_0)
	{
		return class39_0.method_5(this.class89_0.method_2(), this.class89_0.method_1());
	}

	// Token: 0x04000022 RID: 34
	private Class89 class89_0;

	// Token: 0x04000023 RID: 35
	private int int_0;

	// Token: 0x04000024 RID: 36
	private int int_1;

	// Token: 0x04000025 RID: 37
	private int int_2;
}
