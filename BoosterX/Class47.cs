using System;

// Token: 0x02000017 RID: 23
internal sealed class Class47 : Class44
{
	// Token: 0x06000089 RID: 137 RVA: 0x0000361C File Offset: 0x0000181C
	public Class47() : base(16)
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00003628 File Offset: 0x00001828
	public short method_3()
	{
		return this.short_0;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00003630 File Offset: 0x00001830
	public void method_4(short short_1)
	{
		this.short_0 = short_1;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x0000363C File Offset: 0x0000183C
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000364C File Offset: 0x0000184C
	public override void vmethod_1(object object_0)
	{
		if (object_0 is int)
		{
			this.method_4((short)((int)object_0));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((short)((long)object_0));
			return;
		}
		if (object_0 is ushort)
		{
			this.method_4((short)((ushort)object_0));
			return;
		}
		if (object_0 is uint)
		{
			this.method_4((short)((uint)object_0));
			return;
		}
		if (object_0 is ulong)
		{
			this.method_4((short)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((short)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((short)((double)object_0));
			return;
		}
		this.method_4(Convert.ToInt16(object_0));
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00003700 File Offset: 0x00001900
	public override Class44 vmethod_3()
	{
		Class47 @class = new Class47();
		@class.method_4(this.short_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00003720 File Offset: 0x00001920
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 2:
			this.method_4(Convert.ToInt16(((Class53)class44_0).method_3()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 7:
			this.method_4((short)((Class54)class44_0).method_3());
			break;
		case 8:
			this.method_4((short)((Class58)class44_0).method_3());
			break;
		case 12:
			this.method_4((short)((Class69)class44_0).method_3());
			break;
		case 14:
			this.method_4((short)Convert.ToByte(((Class52)class44_0).method_3()));
			break;
		case 15:
			this.method_4((short)((int)((Class49)class44_0).method_3()));
			break;
		case 16:
			this.method_4(((Class47)class44_0).method_3());
			break;
		case 17:
			this.method_4(Convert.ToInt16(((Class51)class44_0).method_3()));
			break;
		case 19:
			this.method_4((short)((Class59)class44_0).method_3());
			break;
		case 20:
			this.method_4((short)((Class60)class44_0).method_3());
			break;
		case 22:
			this.method_4((short)((Class56)class44_0).method_3());
			break;
		case 24:
			this.method_4((short)((Class57)class44_0).method_3());
			break;
		case 25:
			this.method_4((short)((Class68)class44_0).method_3());
			break;
		case 26:
			this.method_4((short)((Class48)class44_0).method_3());
			break;
		}
		return this;
	}

	// Token: 0x04000028 RID: 40
	private short short_0;
}
