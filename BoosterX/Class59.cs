using System;

// Token: 0x02000087 RID: 135
internal sealed class Class59 : Class44
{
	// Token: 0x06000465 RID: 1125 RVA: 0x00017A90 File Offset: 0x00015C90
	public Class59() : base(19)
	{
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00017A9C File Offset: 0x00015C9C
	public uint method_3()
	{
		return this.uint_0;
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00017AA4 File Offset: 0x00015CA4
	public void method_4(uint uint_1)
	{
		this.uint_0 = uint_1;
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00017AB0 File Offset: 0x00015CB0
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00017AC0 File Offset: 0x00015CC0
	public override void vmethod_1(object object_0)
	{
		if (object_0 is short)
		{
			this.method_4((uint)((short)object_0));
			return;
		}
		if (object_0 is int)
		{
			this.method_4((uint)((int)object_0));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((uint)((long)object_0));
			return;
		}
		if (object_0 is ulong)
		{
			this.method_4((uint)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((uint)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((uint)((double)object_0));
			return;
		}
		this.method_4(Convert.ToUInt32(object_0));
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00017B5C File Offset: 0x00015D5C
	public override Class44 vmethod_3()
	{
		Class59 @class = new Class59();
		@class.method_4(this.uint_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00017B7C File Offset: 0x00015D7C
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 2:
			this.method_4(Convert.ToUInt32(((Class53)class44_0).method_3()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 6:
			this.method_4((uint)((Class50)class44_0).method_3());
			break;
		case 7:
			this.method_4((uint)((Class54)class44_0).method_3());
			break;
		case 8:
			this.method_4((uint)((Class58)class44_0).method_3());
			break;
		case 12:
			this.method_4((uint)((Class69)class44_0).method_3());
			break;
		case 14:
			this.method_4((uint)Convert.ToByte(((Class52)class44_0).method_3()));
			break;
		case 15:
			this.method_4((uint)((int)((Class49)class44_0).method_3()));
			break;
		case 16:
			this.method_4((uint)((Class47)class44_0).method_3());
			break;
		case 17:
			this.method_4(Convert.ToUInt32(((Class51)class44_0).method_3()));
			break;
		case 19:
			this.method_4(((Class59)class44_0).method_3());
			break;
		case 20:
			this.method_4((uint)((Class60)class44_0).method_3());
			break;
		case 22:
			this.method_4((uint)((Class56)class44_0).method_3());
			break;
		case 24:
			this.method_4((uint)((Class57)class44_0).method_3());
			break;
		case 25:
			this.method_4((uint)((Class68)class44_0).method_3());
			break;
		case 26:
			this.method_4((uint)((Class48)class44_0).method_3());
			break;
		}
		return this;
	}

	// Token: 0x0400010D RID: 269
	private uint uint_0;
}
