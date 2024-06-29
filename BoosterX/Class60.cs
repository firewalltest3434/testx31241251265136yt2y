using System;

// Token: 0x02000088 RID: 136
internal sealed class Class60 : Class44
{
	// Token: 0x0600046C RID: 1132 RVA: 0x00017D74 File Offset: 0x00015F74
	public Class60() : base(20)
	{
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00017D80 File Offset: 0x00015F80
	public sbyte method_3()
	{
		return this.sbyte_0;
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x00017D88 File Offset: 0x00015F88
	public void method_4(sbyte sbyte_1)
	{
		this.sbyte_0 = sbyte_1;
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00017D94 File Offset: 0x00015F94
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00017DA4 File Offset: 0x00015FA4
	public override void vmethod_1(object object_0)
	{
		if (object_0 is byte)
		{
			this.method_4((sbyte)((byte)object_0));
			return;
		}
		if (object_0 is short)
		{
			this.method_4((sbyte)((short)object_0));
			return;
		}
		if (object_0 is int)
		{
			this.method_4((sbyte)((int)object_0));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((sbyte)((long)object_0));
			return;
		}
		if (object_0 is ushort)
		{
			this.method_4((sbyte)((ushort)object_0));
			return;
		}
		if (object_0 is uint)
		{
			this.method_4((sbyte)((uint)object_0));
			return;
		}
		if (object_0 is ulong)
		{
			this.method_4((sbyte)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((sbyte)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((sbyte)((double)object_0));
			return;
		}
		this.method_4(Convert.ToSByte(object_0));
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00017E84 File Offset: 0x00016084
	public override Class44 vmethod_3()
	{
		Class60 @class = new Class60();
		@class.method_4(this.sbyte_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00017EA4 File Offset: 0x000160A4
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 2:
			this.method_4(Convert.ToSByte(((Class53)class44_0).method_3()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 7:
			this.method_4((sbyte)((Class54)class44_0).method_3());
			break;
		case 8:
			this.method_4((sbyte)((Class58)class44_0).method_3());
			break;
		case 12:
			this.method_4((sbyte)((Class69)class44_0).method_3());
			break;
		case 14:
			this.method_4(Convert.ToSByte(((Class52)class44_0).method_3()));
			break;
		case 15:
			this.method_4((sbyte)((int)((Class49)class44_0).method_3()));
			break;
		case 16:
			this.method_4((sbyte)((Class47)class44_0).method_3());
			break;
		case 17:
			this.method_4(Convert.ToSByte(((Class51)class44_0).method_3()));
			break;
		case 19:
			this.method_4((sbyte)((Class59)class44_0).method_3());
			break;
		case 20:
			this.method_4(((Class60)class44_0).method_3());
			break;
		case 22:
			this.method_4((sbyte)((Class56)class44_0).method_3());
			break;
		case 24:
			this.method_4((sbyte)((Class57)class44_0).method_3());
			break;
		case 25:
			this.method_4((sbyte)((Class68)class44_0).method_3());
			break;
		case 26:
			this.method_4((sbyte)((Class48)class44_0).method_3());
			break;
		}
		return this;
	}

	// Token: 0x0400010E RID: 270
	private sbyte sbyte_0;
}
