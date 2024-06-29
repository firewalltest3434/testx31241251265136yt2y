using System;

// Token: 0x0200000A RID: 10
internal sealed class Class45 : Class44
{
	// Token: 0x0600003E RID: 62 RVA: 0x000029FC File Offset: 0x00000BFC
	public Class45() : base(3)
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002A08 File Offset: 0x00000C08
	public char method_3()
	{
		return this.char_0;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002A10 File Offset: 0x00000C10
	public void method_4(char char_1)
	{
		this.char_0 = char_1;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002A1C File Offset: 0x00000C1C
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002A2C File Offset: 0x00000C2C
	public override void vmethod_1(object object_0)
	{
		this.method_4(Convert.ToChar(object_0));
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002A3C File Offset: 0x00000C3C
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		switch (class44_0.method_0())
		{
		case 2:
			this.method_4(Convert.ToChar(((Class53)class44_0).method_3()));
			break;
		case 3:
			this.method_4(((Class45)class44_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 6:
			this.method_4((char)((uint)((Class50)class44_0).method_3()));
			break;
		case 7:
			this.method_4((char)((Class54)class44_0).method_3());
			break;
		case 12:
			this.method_4((char)((Class69)class44_0).method_3());
			break;
		case 14:
			this.method_4(Convert.ToChar(((Class52)class44_0).method_3()));
			break;
		case 15:
			this.method_4((char)((int)((Class49)class44_0).method_3()));
			break;
		case 16:
			this.method_4((char)((Class47)class44_0).method_3());
			break;
		case 17:
			this.method_4(Convert.ToChar(((Class51)class44_0).method_3()));
			break;
		case 19:
			this.method_4((char)((Class59)class44_0).method_3());
			break;
		case 20:
			this.method_4((char)((Class60)class44_0).method_3());
			break;
		case 22:
			this.method_4((char)((Class56)class44_0).method_3());
			break;
		case 25:
			this.method_4((char)((Class68)class44_0).method_3());
			break;
		case 26:
			this.method_4((char)((Class48)class44_0).method_3());
			break;
		}
		return this;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002C20 File Offset: 0x00000E20
	public override Class44 vmethod_3()
	{
		Class45 @class = new Class45();
		@class.method_4(this.char_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x04000015 RID: 21
	private char char_0;
}
