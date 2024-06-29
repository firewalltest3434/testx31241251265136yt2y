using System;

// Token: 0x02000021 RID: 33
internal sealed class Class49 : Class44
{
	// Token: 0x060000C5 RID: 197 RVA: 0x000040C4 File Offset: 0x000022C4
	public Class49() : base(15)
	{
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x000040D0 File Offset: 0x000022D0
	public IntPtr method_3()
	{
		return this.intptr_0;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000040D8 File Offset: 0x000022D8
	public void method_4(IntPtr intptr_1)
	{
		this.intptr_0 = intptr_1;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x000040E4 File Offset: 0x000022E4
	public override Class44 vmethod_3()
	{
		Class49 @class = new Class49();
		@class.method_4(this.intptr_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00004104 File Offset: 0x00002304
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00004114 File Offset: 0x00002314
	public override void vmethod_1(object object_0)
	{
		this.method_4((IntPtr)object_0);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00004124 File Offset: 0x00002324
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 2:
			this.method_4(new IntPtr(Convert.ToInt64(((Class53)class44_0).method_3())));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 4:
		{
			Class55 @class = (Class55)class44_0;
			this.method_4(@class.method_5());
			break;
		}
		case 7:
			this.method_4((IntPtr)((Class54)class44_0).method_3());
			break;
		case 8:
			this.method_4((IntPtr)((long)((Class58)class44_0).method_3()));
			break;
		case 12:
			this.method_4((IntPtr)((int)((Class69)class44_0).method_3()));
			break;
		case 15:
			this.method_4(((Class49)class44_0).method_3());
			break;
		case 16:
			this.method_4((IntPtr)((int)((Class47)class44_0).method_3()));
			break;
		case 17:
			this.method_4((IntPtr)((Class51)class44_0).method_3());
			break;
		case 19:
			this.method_4((IntPtr)((long)((ulong)((Class59)class44_0).method_3())));
			break;
		case 20:
			this.method_4((IntPtr)((int)((Class60)class44_0).method_3()));
			break;
		case 22:
			this.method_4((IntPtr)((Class56)class44_0).method_3());
			break;
		case 24:
			this.method_4((IntPtr)((long)((Class57)class44_0).method_3()));
			break;
		case 25:
			this.method_4((IntPtr)((long)((Class68)class44_0).method_3()));
			break;
		case 26:
			this.method_4((IntPtr)((int)((Class48)class44_0).method_3()));
			break;
		}
		return this;
	}

	// Token: 0x04000038 RID: 56
	private IntPtr intptr_0;
}
