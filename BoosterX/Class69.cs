using System;

// Token: 0x02000098 RID: 152
internal sealed class Class69 : Class44
{
	// Token: 0x060004DF RID: 1247 RVA: 0x00019384 File Offset: 0x00017584
	public Class69() : base(12)
	{
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00019390 File Offset: 0x00017590
	public byte method_3()
	{
		return this.byte_0;
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x00019398 File Offset: 0x00017598
	public void method_4(byte byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x000193A4 File Offset: 0x000175A4
	public override Class44 vmethod_3()
	{
		Class69 @class = new Class69();
		@class.method_4(this.byte_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x000193C4 File Offset: 0x000175C4
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x000193D4 File Offset: 0x000175D4
	public override void vmethod_1(object object_0)
	{
		if (object_0 is short)
		{
			this.method_4((byte)((short)object_0));
			return;
		}
		if (object_0 is int)
		{
			this.method_4((byte)((int)object_0));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((byte)((long)object_0));
			return;
		}
		if (object_0 is ushort)
		{
			this.method_4((byte)((ushort)object_0));
			return;
		}
		if (object_0 is uint)
		{
			this.method_4((byte)((uint)object_0));
			return;
		}
		if (object_0 is ulong)
		{
			this.method_4((byte)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((byte)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((byte)((double)object_0));
			return;
		}
		this.method_4(Convert.ToByte(object_0));
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x000194A0 File Offset: 0x000176A0
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 2:
			this.method_4(Convert.ToByte(((Class53)class44_0).method_3()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 6:
			this.method_4((byte)((uint)((Class50)class44_0).method_3()));
			break;
		case 7:
			this.method_4((byte)((Class54)class44_0).method_3());
			break;
		case 8:
			this.method_4((byte)((Class58)class44_0).method_3());
			break;
		case 12:
			this.method_4(((Class69)class44_0).method_3());
			break;
		case 14:
			this.method_4(Convert.ToByte(((Class52)class44_0).method_3()));
			break;
		case 15:
			this.method_4((byte)((int)((Class49)class44_0).method_3()));
			break;
		case 16:
			this.method_4((byte)((Class47)class44_0).method_3());
			break;
		case 17:
			this.method_4(Convert.ToByte(((Class51)class44_0).method_3()));
			break;
		case 19:
			this.method_4((byte)((Class59)class44_0).method_3());
			break;
		case 20:
			this.method_4((byte)((Class60)class44_0).method_3());
			break;
		case 22:
			this.method_4((byte)((Class56)class44_0).method_3());
			break;
		case 24:
			this.method_4((byte)((Class57)class44_0).method_3());
			break;
		case 25:
			this.method_4((byte)((Class68)class44_0).method_3());
			break;
		case 26:
			this.method_4((byte)((Class48)class44_0).method_3());
			break;
		}
		return this;
	}

	// Token: 0x04000136 RID: 310
	private byte byte_0;
}
