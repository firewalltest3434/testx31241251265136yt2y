using System;

// Token: 0x0200007B RID: 123
internal sealed class Class56 : Class44
{
	// Token: 0x06000421 RID: 1057 RVA: 0x00016F30 File Offset: 0x00015130
	public Class56() : base(22)
	{
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00016F3C File Offset: 0x0001513C
	public Class56(long long_1) : this()
	{
		this.long_0 = long_1;
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00016F4C File Offset: 0x0001514C
	public long method_3()
	{
		return this.long_0;
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00016F54 File Offset: 0x00015154
	public void method_4(long long_1)
	{
		this.long_0 = long_1;
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00016F60 File Offset: 0x00015160
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00016F70 File Offset: 0x00015170
	public override void vmethod_1(object object_0)
	{
		if (object_0 is ulong)
		{
			this.method_4((long)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((long)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((long)((double)object_0));
			return;
		}
		this.method_4(Convert.ToInt64(object_0));
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00016FCC File Offset: 0x000151CC
	public override Class44 vmethod_3()
	{
		Class56 @class = new Class56();
		@class.method_4(this.long_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00016FEC File Offset: 0x000151EC
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 2:
			this.method_4(Convert.ToInt64(((Class53)class44_0).method_3()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 6:
			this.method_4((long)((ulong)((Class50)class44_0).method_3()));
			break;
		case 7:
			this.method_4((long)((Class54)class44_0).method_3());
			break;
		case 8:
			this.method_4((long)((Class58)class44_0).method_3());
			break;
		case 12:
			this.method_4((long)((ulong)((Class69)class44_0).method_3()));
			break;
		case 14:
			this.method_4((long)((ulong)Convert.ToByte(((Class52)class44_0).method_3())));
			break;
		case 15:
			this.method_4((long)((Class49)class44_0).method_3());
			break;
		case 16:
			this.method_4((long)((Class47)class44_0).method_3());
			break;
		case 17:
			this.method_4(Convert.ToInt64(((Class51)class44_0).method_3()));
			break;
		case 19:
			this.method_4((long)((ulong)((Class59)class44_0).method_3()));
			break;
		case 20:
			this.method_4((long)((Class60)class44_0).method_3());
			break;
		case 22:
			this.method_4(((Class56)class44_0).method_3());
			break;
		case 24:
			this.method_4((long)((Class57)class44_0).method_3());
			break;
		case 25:
			this.method_4((long)((Class68)class44_0).method_3());
			break;
		case 26:
			this.method_4((long)((ulong)((Class48)class44_0).method_3()));
			break;
		}
		return this;
	}

	// Token: 0x040000F1 RID: 241
	private long long_0;
}
