using System;

// Token: 0x02000073 RID: 115
internal sealed class Class64 : Class61
{
	// Token: 0x060003EC RID: 1004 RVA: 0x00016134 File Offset: 0x00014334
	public Class64() : base(23)
	{
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00016140 File Offset: 0x00014340
	public Class44 method_3()
	{
		return this.class44_0;
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00016148 File Offset: 0x00014348
	public void method_4(Class44 class44_1)
	{
		this.class44_0 = class44_1;
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00016154 File Offset: 0x00014354
	public override Class44 vmethod_2(Class44 class44_1)
	{
		base.method_2(class44_1.method_1());
		if (class44_1.method_0() == 23)
		{
			this.method_4(((Class64)class44_1).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00016188 File Offset: 0x00014388
	public override Class44 vmethod_3()
	{
		Class64 @class = new Class64();
		@class.method_4(this.method_3());
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x040000E0 RID: 224
	private Class44 class44_0;
}
