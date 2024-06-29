using System;

// Token: 0x0200000E RID: 14
internal sealed class Class12 : IEquatable<Class12>
{
	// Token: 0x0600004F RID: 79 RVA: 0x00002D6C File Offset: 0x00000F6C
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002D74 File Offset: 0x00000F74
	public void method_1(int int_5)
	{
		this.int_0 = int_5;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002D80 File Offset: 0x00000F80
	public int method_2()
	{
		return this.int_1;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002D88 File Offset: 0x00000F88
	public void method_3(int int_5)
	{
		this.int_1 = int_5;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002D94 File Offset: 0x00000F94
	public int method_4()
	{
		return this.int_2;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002D9C File Offset: 0x00000F9C
	public void method_5(int int_5)
	{
		this.int_2 = int_5;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002DA8 File Offset: 0x00000FA8
	public int method_6()
	{
		return this.int_3;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002DB0 File Offset: 0x00000FB0
	public void method_7(int int_5)
	{
		this.int_3 = int_5;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002DBC File Offset: 0x00000FBC
	public int method_8()
	{
		return this.int_4;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002DC4 File Offset: 0x00000FC4
	public void method_9(int int_5)
	{
		this.int_4 = int_5;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002DD0 File Offset: 0x00000FD0
	public static Class12 smethod_0()
	{
		return Class12.class12_0;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002DD8 File Offset: 0x00000FD8
	public override bool Equals(object obj)
	{
		return Class12.smethod_1(this, obj as Class12);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002DE8 File Offset: 0x00000FE8
	public bool Equals(Class12 other)
	{
		return Class12.smethod_1(this, other);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002DF4 File Offset: 0x00000FF4
	public static bool smethod_1(Class12 class12_1, Class12 class12_2)
	{
		return class12_1 == class12_2 || (class12_1 != null && class12_2 != null && (class12_1.method_0() == class12_2.method_0() && class12_1.method_2() == class12_2.method_2() && class12_1.method_4() == class12_2.method_4() && class12_1.method_6() == class12_2.method_6()) && class12_1.method_8() == class12_2.method_8());
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002E58 File Offset: 0x00001058
	public override int GetHashCode()
	{
		return ((((-8832819 + this.method_0().GetHashCode()) * -1521134295 + this.method_2().GetHashCode()) * -1521134295 + this.method_4().GetHashCode()) * -1521134295 + this.method_6().GetHashCode()) * -1521134295 + this.method_8().GetHashCode();
	}

	// Token: 0x04000019 RID: 25
	private int int_0 = 255;

	// Token: 0x0400001A RID: 26
	private int int_1 = 12;

	// Token: 0x0400001B RID: 27
	private int int_2 = 96;

	// Token: 0x0400001C RID: 28
	private int int_3 = 10;

	// Token: 0x0400001D RID: 29
	private int int_4 = 4;

	// Token: 0x0400001E RID: 30
	private static readonly Class12 class12_0 = new Class12();
}
