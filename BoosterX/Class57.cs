using System;

// Token: 0x02000082 RID: 130
internal sealed class Class57 : Class44
{
	// Token: 0x0600043F RID: 1087 RVA: 0x000175C0 File Offset: 0x000157C0
	public Class57() : base(24)
	{
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x000175CC File Offset: 0x000157CC
	public float method_3()
	{
		return this.float_0;
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x000175D4 File Offset: 0x000157D4
	public void method_4(float float_1)
	{
		this.float_0 = float_1;
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x000175E0 File Offset: 0x000157E0
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x000175F0 File Offset: 0x000157F0
	public override void vmethod_1(object object_0)
	{
		this.method_4(Convert.ToSingle(object_0));
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00017600 File Offset: 0x00015800
	public override Class44 vmethod_3()
	{
		Class57 @class = new Class57();
		@class.method_4(this.float_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00017620 File Offset: 0x00015820
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		int num = class44_0.method_0();
		if (num != 2)
		{
			switch (num)
			{
			case 7:
				this.method_4((float)((Class54)class44_0).method_3());
				break;
			case 8:
				this.method_4((float)((Class58)class44_0).method_3());
				break;
			default:
				throw new ArgumentOutOfRangeException();
			case 12:
				this.method_4((float)((Class69)class44_0).method_3());
				break;
			case 16:
				this.method_4((float)((Class47)class44_0).method_3());
				break;
			case 17:
				this.method_4((float)((Class51)class44_0).method_3());
				break;
			case 19:
				this.method_4(((Class59)class44_0).method_3());
				break;
			case 20:
				this.method_4((float)((Class60)class44_0).method_3());
				break;
			case 22:
				this.method_4((float)((Class56)class44_0).method_3());
				break;
			case 24:
				this.method_4(((Class57)class44_0).method_3());
				break;
			case 25:
				this.method_4(((Class68)class44_0).method_3());
				break;
			case 26:
				this.method_4((float)((Class48)class44_0).method_3());
				break;
			}
		}
		else
		{
			this.method_4(Convert.ToSingle(((Class53)class44_0).method_3()));
		}
		return this;
	}

	// Token: 0x04000102 RID: 258
	private float float_0;
}
