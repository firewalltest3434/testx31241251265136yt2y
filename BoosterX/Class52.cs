using System;

// Token: 0x02000057 RID: 87
internal sealed class Class52 : Class44
{
	// Token: 0x0600033F RID: 831 RVA: 0x000132C0 File Offset: 0x000114C0
	public Class52() : base(14)
	{
	}

	// Token: 0x06000340 RID: 832 RVA: 0x000132CC File Offset: 0x000114CC
	public bool method_3()
	{
		return this.bool_0;
	}

	// Token: 0x06000341 RID: 833 RVA: 0x000132D4 File Offset: 0x000114D4
	public void method_4(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x06000342 RID: 834 RVA: 0x000132E0 File Offset: 0x000114E0
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000343 RID: 835 RVA: 0x000132F0 File Offset: 0x000114F0
	public override void vmethod_1(object object_0)
	{
		this.method_4(Convert.ToBoolean(object_0));
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00013300 File Offset: 0x00011500
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 2:
			this.method_4(Convert.ToBoolean(((Class53)class44_0).method_3()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 6:
			this.method_4(Convert.ToBoolean(((Class50)class44_0).method_3()));
			break;
		case 7:
			this.method_4(Convert.ToBoolean(((Class54)class44_0).method_3()));
			break;
		case 12:
			this.method_4(Convert.ToBoolean(((Class69)class44_0).method_3()));
			break;
		case 14:
			this.method_4(((Class52)class44_0).method_3());
			break;
		case 15:
			this.method_4(Convert.ToBoolean(((Class49)class44_0).method_3()));
			break;
		case 16:
			this.method_4(Convert.ToBoolean(((Class47)class44_0).method_3()));
			break;
		case 17:
			this.method_4(Convert.ToBoolean(((Class51)class44_0).method_3()));
			break;
		case 19:
			this.method_4(Convert.ToBoolean(((Class59)class44_0).method_3()));
			break;
		case 20:
			this.method_4(Convert.ToBoolean(((Class60)class44_0).method_3()));
			break;
		case 22:
			this.method_4(Convert.ToBoolean(((Class56)class44_0).method_3()));
			break;
		case 25:
			this.method_4(Convert.ToBoolean(((Class68)class44_0).method_3()));
			break;
		case 26:
			this.method_4(Convert.ToBoolean(((Class48)class44_0).method_3()));
			break;
		}
		return this;
	}

	// Token: 0x06000345 RID: 837 RVA: 0x000134F4 File Offset: 0x000116F4
	public override Class44 vmethod_3()
	{
		Class52 @class = new Class52();
		@class.method_4(this.bool_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x040000A1 RID: 161
	private bool bool_0;
}
