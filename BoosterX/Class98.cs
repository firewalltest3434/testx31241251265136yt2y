using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Token: 0x02000091 RID: 145
internal sealed class Class98 : Interface6
{
	// Token: 0x0600049B RID: 1179 RVA: 0x00018798 File Offset: 0x00016998
	public Class98(bool bool_0, Class89 class89_0)
	{
		this.class14_0 = new Class14();
		this.class14_0.method_0(bool_0, class89_0);
		this.int_0 = this.class14_0.method_1();
		this.int_1 = this.class14_0.method_3();
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x000187E8 File Offset: 0x000169E8
	[CompilerGenerated]
	public int imethod_0()
	{
		return this.int_0;
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x000187F0 File Offset: 0x000169F0
	[CompilerGenerated]
	public int imethod_1()
	{
		return this.int_1;
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x000187F8 File Offset: 0x000169F8
	public int imethod_2(byte[] byte_0, int int_2, int int_3, byte[] byte_1, int int_4, RandomNumberGenerator randomNumberGenerator_0)
	{
		Class39 class39_ = this.class14_0.method_5(byte_0, int_2, int_3);
		Class39 class39_2 = this.class14_0.method_7(class39_);
		return this.class14_0.method_6(class39_2, byte_1, int_4);
	}

	// Token: 0x0400011D RID: 285
	private Class14 class14_0;

	// Token: 0x0400011E RID: 286
	private readonly int int_0;

	// Token: 0x0400011F RID: 287
	private readonly int int_1;
}
