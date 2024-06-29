using System;

// Token: 0x0200001E RID: 30
internal sealed class Class48 : Class44
{
	// Token: 0x060000B4 RID: 180 RVA: 0x00003B14 File Offset: 0x00001D14
	public Class48() : base(26)
	{
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00003B20 File Offset: 0x00001D20
	public ushort method_3()
	{
		return this.ushort_0;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00003B28 File Offset: 0x00001D28
	public void method_4(ushort ushort_1)
	{
		this.ushort_0 = ushort_1;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00003B34 File Offset: 0x00001D34
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00003B44 File Offset: 0x00001D44
	public override void vmethod_1(object object_0)
	{
		if (object_0 is short)
		{
			this.method_4((ushort)((short)object_0));
			return;
		}
		if (object_0 is int)
		{
			this.method_4((ushort)((int)object_0));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((ushort)((long)object_0));
			return;
		}
		if (object_0 is uint)
		{
			this.method_4((ushort)((uint)object_0));
			return;
		}
		if (object_0 is ulong)
		{
			this.method_4((ushort)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((ushort)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((ushort)((double)object_0));
			return;
		}
		this.method_4(Convert.ToUInt16(object_0));
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00003BF8 File Offset: 0x00001DF8
	public override Class44 vmethod_3()
	{
		Class48 @class = new Class48();
		@class.method_4(this.ushort_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00003C18 File Offset: 0x00001E18
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 2:
			this.method_4(Convert.ToUInt16(((Class53)class44_0).method_3()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 6:
			this.method_4((ushort)((uint)((Class50)class44_0).method_3()));
			break;
		case 7:
			this.method_4((ushort)((Class54)class44_0).method_3());
			break;
		case 8:
			this.method_4((ushort)((Class58)class44_0).method_3());
			break;
		case 12:
			this.method_4((ushort)((Class69)class44_0).method_3());
			break;
		case 14:
			this.method_4((ushort)Convert.ToByte(((Class52)class44_0).method_3()));
			break;
		case 15:
			this.method_4((ushort)((int)((Class49)class44_0).method_3()));
			break;
		case 16:
			this.method_4((ushort)((Class47)class44_0).method_3());
			break;
		case 17:
			this.method_4(Convert.ToUInt16(((Class51)class44_0).method_3()));
			break;
		case 19:
			this.method_4((ushort)((Class59)class44_0).method_3());
			break;
		case 20:
			this.method_4((ushort)((Class60)class44_0).method_3());
			break;
		case 22:
			this.method_4((ushort)((Class56)class44_0).method_3());
			break;
		case 24:
			this.method_4((ushort)((Class57)class44_0).method_3());
			break;
		case 25:
			this.method_4((ushort)((Class68)class44_0).method_3());
			break;
		case 26:
			this.method_4(((Class48)class44_0).method_3());
			break;
		}
		return this;
	}

	// Token: 0x04000030 RID: 48
	private ushort ushort_0;
}
