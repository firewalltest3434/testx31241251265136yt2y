using System;

// Token: 0x02000086 RID: 134
internal sealed class Class58 : Class44
{
	// Token: 0x0600045E RID: 1118 RVA: 0x000178B4 File Offset: 0x00015AB4
	public Class58() : base(8)
	{
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x000178C0 File Offset: 0x00015AC0
	public double method_3()
	{
		return this.double_0;
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x000178C8 File Offset: 0x00015AC8
	public void method_4(double double_1)
	{
		this.double_0 = double_1;
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x000178D4 File Offset: 0x00015AD4
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x000178E4 File Offset: 0x00015AE4
	public override void vmethod_1(object object_0)
	{
		this.method_4(Convert.ToDouble(object_0));
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x000178F4 File Offset: 0x00015AF4
	public override Class44 vmethod_3()
	{
		Class58 @class = new Class58();
		@class.method_4(this.double_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00017914 File Offset: 0x00015B14
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 7:
			this.method_4((double)((Class54)class44_0).method_3());
			break;
		case 8:
			this.method_4(((Class58)class44_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 12:
			this.method_4((double)((Class69)class44_0).method_3());
			break;
		case 16:
			this.method_4((double)((Class47)class44_0).method_3());
			break;
		case 17:
			this.method_4((double)((Class51)class44_0).method_3());
			break;
		case 19:
			this.method_4(((Class59)class44_0).method_3());
			break;
		case 20:
			this.method_4((double)((Class60)class44_0).method_3());
			break;
		case 22:
			this.method_4((double)((Class56)class44_0).method_3());
			break;
		case 24:
			this.method_4((double)((Class57)class44_0).method_3());
			break;
		case 25:
			this.method_4(((Class68)class44_0).method_3());
			break;
		case 26:
			this.method_4((double)((Class48)class44_0).method_3());
			break;
		}
		return this;
	}

	// Token: 0x0400010C RID: 268
	private double double_0;
}
