using System;
using System.Threading;

// Token: 0x020000A3 RID: 163
internal struct Struct13
{
	// Token: 0x06000518 RID: 1304 RVA: 0x0001B0E8 File Offset: 0x000192E8
	public Struct13(string string_0)
	{
		this.nullable_0 = new int?(Class100.smethod_0(string_0));
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x0001B0FC File Offset: 0x000192FC
	public bool method_0()
	{
		return Class100.smethod_1(this.nullable_0);
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0001B10C File Offset: 0x0001930C
	public void method_1(bool bool_0)
	{
		this.nullable_0 = new int?(Class100.smethod_4(bool_0));
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0001B120 File Offset: 0x00019320
	public bool method_2()
	{
		bool result = Class100.smethod_1(this.nullable_0);
		Thread.MemoryBarrier();
		return result;
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x0001B134 File Offset: 0x00019334
	public void method_3(bool bool_0)
	{
		Thread.MemoryBarrier();
		this.nullable_0 = new int?(Class100.smethod_4(bool_0));
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x0001B14C File Offset: 0x0001934C
	public void method_4()
	{
		this.nullable_0 = new int?(Class100.smethod_4(false));
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x0001B160 File Offset: 0x00019360
	public int method_5()
	{
		return Class100.smethod_1(this.nullable_0).GetHashCode();
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x0001B180 File Offset: 0x00019380
	public bool method_6(bool bool_0)
	{
		return Class100.smethod_1(this.nullable_0).Equals(bool_0);
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0001B1A4 File Offset: 0x000193A4
	public bool method_7(object object_0)
	{
		return Class100.smethod_1(this.nullable_0).Equals(object_0);
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x0001B1C8 File Offset: 0x000193C8
	public int method_8(bool bool_0)
	{
		return Class100.smethod_1(this.nullable_0).CompareTo(bool_0);
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x0001B1EC File Offset: 0x000193EC
	public int method_9(object object_0)
	{
		return Class100.smethod_1(this.nullable_0).CompareTo(object_0);
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x0001B210 File Offset: 0x00019410
	public TypeCode method_10()
	{
		return TypeCode.Boolean;
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x0001B214 File Offset: 0x00019414
	public string method_11()
	{
		return Class100.smethod_1(this.nullable_0).ToString();
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x0001B234 File Offset: 0x00019434
	public string method_12(IFormatProvider iformatProvider_0)
	{
		return Class100.smethod_1(this.nullable_0).ToString(iformatProvider_0);
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0001B258 File Offset: 0x00019458
	public bool method_13()
	{
		return this.method_2();
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x0001B260 File Offset: 0x00019460
	public void method_14(bool bool_0)
	{
		this.method_3(bool_0);
	}

	// Token: 0x0400021E RID: 542
	private int? nullable_0;
}
