using System;

// Token: 0x02000090 RID: 144
internal sealed class Class68 : Class44
{
	// Token: 0x06000494 RID: 1172 RVA: 0x000184C4 File Offset: 0x000166C4
	public Class68() : base(25)
	{
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x000184D0 File Offset: 0x000166D0
	public ulong method_3()
	{
		return this.ulong_0;
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x000184D8 File Offset: 0x000166D8
	public void method_4(ulong ulong_1)
	{
		this.ulong_0 = ulong_1;
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x000184E4 File Offset: 0x000166E4
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x000184F4 File Offset: 0x000166F4
	public override void vmethod_1(object object_0)
	{
		if (object_0 is short)
		{
			this.method_4((ulong)((long)((short)object_0)));
			return;
		}
		if (object_0 is int)
		{
			this.method_4((ulong)((long)((int)object_0)));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((ulong)((long)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((ulong)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((ulong)((double)object_0));
			return;
		}
		this.method_4(Convert.ToUInt64(object_0));
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x0001857C File Offset: 0x0001677C
	public override Class44 vmethod_3()
	{
		Class68 @class = new Class68();
		@class.method_4(this.ulong_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x0001859C File Offset: 0x0001679C
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 2:
			this.method_4(Convert.ToUInt64(((Class53)class44_0).method_3()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 6:
			this.method_4((ulong)((Class50)class44_0).method_3());
			break;
		case 7:
			this.method_4((ulong)((long)((Class54)class44_0).method_3()));
			break;
		case 8:
			this.method_4((ulong)((Class58)class44_0).method_3());
			break;
		case 12:
			this.method_4((ulong)((Class69)class44_0).method_3());
			break;
		case 14:
			this.method_4((ulong)Convert.ToByte(((Class52)class44_0).method_3()));
			break;
		case 15:
			this.method_4((ulong)((long)((Class49)class44_0).method_3()));
			break;
		case 16:
			this.method_4((ulong)((long)((Class47)class44_0).method_3()));
			break;
		case 17:
			this.method_4(Convert.ToUInt64(((Class51)class44_0).method_3()));
			break;
		case 19:
			this.method_4((ulong)((Class59)class44_0).method_3());
			break;
		case 20:
			this.method_4((ulong)((long)((Class60)class44_0).method_3()));
			break;
		case 22:
			this.method_4((ulong)((Class56)class44_0).method_3());
			break;
		case 24:
			this.method_4((ulong)((Class57)class44_0).method_3());
			break;
		case 25:
			this.method_4(((Class68)class44_0).method_3());
			break;
		case 26:
			this.method_4((ulong)((Class48)class44_0).method_3());
			break;
		}
		return this;
	}

	// Token: 0x0400011C RID: 284
	private ulong ulong_0;
}
