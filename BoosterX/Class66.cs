using System;

// Token: 0x02000029 RID: 41
internal sealed class Class66 : Class65
{
	// Token: 0x060000FA RID: 250 RVA: 0x00005114 File Offset: 0x00003314
	public Class66() : base(1)
	{
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00005120 File Offset: 0x00003320
	public Array method_5()
	{
		return this.array_0;
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00005128 File Offset: 0x00003328
	public void method_6(Array array_1)
	{
		this.array_0 = array_1;
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00005134 File Offset: 0x00003334
	public int[] method_7()
	{
		return this.int_1;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x0000513C File Offset: 0x0000333C
	public void method_8(int[] int_2)
	{
		this.int_1 = int_2;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00005148 File Offset: 0x00003348
	public override object vmethod_4()
	{
		return this.method_5().GetValue(this.method_7());
	}

	// Token: 0x06000100 RID: 256 RVA: 0x0000515C File Offset: 0x0000335C
	public override void vmethod_5(object object_0)
	{
		this.method_5().SetValue(object_0, this.method_7());
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00005170 File Offset: 0x00003370
	public override Class44 vmethod_3()
	{
		Class66 @class = new Class66();
		@class.method_6(this.method_5());
		@class.method_8(this.method_7());
		@class.method_4(base.method_3());
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000102 RID: 258 RVA: 0x000051A8 File Offset: 0x000033A8
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		if (class44_0.method_0() == 1)
		{
			Class66 @class = (Class66)class44_0;
			this.method_6(@class.method_5());
			this.method_8(@class.method_7());
			base.method_4(@class.method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00005200 File Offset: 0x00003400
	public override bool vmethod_6(Class65 class65_0)
	{
		Class66 @class = (Class66)class65_0;
		return this.method_5() == @class.method_5() && Class78.smethod_0(this.method_7(), @class.method_7());
	}

	// Token: 0x0400004E RID: 78
	private Array array_0;

	// Token: 0x0400004F RID: 79
	private int[] int_1;
}
