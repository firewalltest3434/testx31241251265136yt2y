using System;

// Token: 0x02000074 RID: 116
internal sealed class Class54 : Class44
{
	// Token: 0x060003F1 RID: 1009 RVA: 0x000161A8 File Offset: 0x000143A8
	public Class54() : base(7)
	{
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x000161B4 File Offset: 0x000143B4
	public Class54(int int_2) : this()
	{
		this.int_1 = int_2;
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x000161C4 File Offset: 0x000143C4
	public int method_3()
	{
		return this.int_1;
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x000161CC File Offset: 0x000143CC
	public void method_4(int int_2)
	{
		this.int_1 = int_2;
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x000161D8 File Offset: 0x000143D8
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x000161E8 File Offset: 0x000143E8
	public override void vmethod_1(object object_0)
	{
		if (object_0 is long)
		{
			this.method_4((int)((long)object_0));
			return;
		}
		if (object_0 is ushort)
		{
			this.method_4((int)((ushort)object_0));
			return;
		}
		if (object_0 is uint)
		{
			this.method_4((int)((uint)object_0));
			return;
		}
		if (object_0 is ulong)
		{
			this.method_4((int)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((int)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((int)((double)object_0));
			return;
		}
		this.method_4(Convert.ToInt32(object_0));
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00016284 File Offset: 0x00014484
	public override Class44 vmethod_3()
	{
		Class54 @class = new Class54();
		@class.method_4(this.int_1);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x000162A4 File Offset: 0x000144A4
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 2:
			this.method_4(Convert.ToInt32(((Class53)class44_0).method_3()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 6:
			this.method_4((int)((uint)((Class50)class44_0).method_3()));
			break;
		case 7:
			this.method_4(((Class54)class44_0).method_3());
			break;
		case 8:
			this.method_4((int)((Class58)class44_0).method_3());
			break;
		case 12:
			this.method_4((int)((Class69)class44_0).method_3());
			break;
		case 14:
			this.method_4((int)Convert.ToByte(((Class52)class44_0).method_3()));
			break;
		case 15:
			this.method_4((int)((Class49)class44_0).method_3());
			break;
		case 16:
			this.method_4((int)((Class47)class44_0).method_3());
			break;
		case 17:
			this.method_4(Convert.ToInt32(((Class51)class44_0).method_3()));
			break;
		case 19:
			this.method_4((int)((Class59)class44_0).method_3());
			break;
		case 20:
			this.method_4((int)((Class60)class44_0).method_3());
			break;
		case 22:
			this.method_4(Convert.ToInt32(((Class56)class44_0).method_3()));
			break;
		case 24:
			this.method_4((int)((Class57)class44_0).method_3());
			break;
		case 25:
			this.method_4((int)((Class68)class44_0).method_3());
			break;
		case 26:
			this.method_4((int)((Class48)class44_0).method_3());
			break;
		}
		return this;
	}

	// Token: 0x040000E1 RID: 225
	private int int_1;
}
