using System;

// Token: 0x02000083 RID: 131
internal sealed class Class4 : Class0
{
	// Token: 0x06000447 RID: 1095 RVA: 0x000177C8 File Offset: 0x000159C8
	public byte method_0()
	{
		return this.byte_0;
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x000177D0 File Offset: 0x000159D0
	public void method_1(byte byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x000177DC File Offset: 0x000159DC
	public bool method_2()
	{
		return (this.method_0() & 2) > 0;
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x000177EC File Offset: 0x000159EC
	public bool method_3()
	{
		return (this.method_0() & 1) > 0;
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x000177FC File Offset: 0x000159FC
	public Class93 method_4()
	{
		return this.class93_0;
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00017804 File Offset: 0x00015A04
	public void method_5(Class93 class93_4)
	{
		this.class93_0 = class93_4;
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00017810 File Offset: 0x00015A10
	public string method_6()
	{
		return this.string_0;
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00017818 File Offset: 0x00015A18
	public void method_7(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00017824 File Offset: 0x00015A24
	public Class93[] method_8()
	{
		return this.class93_1;
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x0001782C File Offset: 0x00015A2C
	public void method_9(Class93[] class93_4)
	{
		this.class93_1 = class93_4;
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00017838 File Offset: 0x00015A38
	public Class93[] method_10()
	{
		return this.class93_2;
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00017840 File Offset: 0x00015A40
	public void method_11(Class93[] class93_4)
	{
		this.class93_2 = class93_4;
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x0001784C File Offset: 0x00015A4C
	public Class93 method_12()
	{
		return this.class93_3;
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00017854 File Offset: 0x00015A54
	public void method_13(Class93 class93_4)
	{
		this.class93_3 = class93_4;
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00017860 File Offset: 0x00015A60
	public override byte vmethod_0()
	{
		return 1;
	}

	// Token: 0x04000103 RID: 259
	private byte byte_0;

	// Token: 0x04000104 RID: 260
	private Class93 class93_0;

	// Token: 0x04000105 RID: 261
	private string string_0;

	// Token: 0x04000106 RID: 262
	private Class93[] class93_1;

	// Token: 0x04000107 RID: 263
	private Class93[] class93_2;

	// Token: 0x04000108 RID: 264
	private Class93 class93_3;
}
