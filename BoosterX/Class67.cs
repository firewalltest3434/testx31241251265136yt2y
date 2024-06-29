using System;

// Token: 0x020000B0 RID: 176
internal sealed class Class67 : Class65
{
	// Token: 0x0600056A RID: 1386 RVA: 0x0001D1D0 File Offset: 0x0001B3D0
	public Class67() : base(21)
	{
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x0001D1DC File Offset: 0x0001B3DC
	public Array method_5()
	{
		return this.array_0;
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x0001D1E4 File Offset: 0x0001B3E4
	public void method_6(Array array_1)
	{
		this.array_0 = array_1;
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
	public long method_7()
	{
		return this.long_0;
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x0001D1F8 File Offset: 0x0001B3F8
	public void method_8(long long_1)
	{
		this.long_0 = long_1;
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x0001D204 File Offset: 0x0001B404
	public override object vmethod_4()
	{
		return this.array_0.GetValue(this.long_0);
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0001D218 File Offset: 0x0001B418
	public override void vmethod_5(object object_0)
	{
		this.array_0.SetValue(object_0, this.long_0);
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x0001D22C File Offset: 0x0001B42C
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		if (class44_0.method_0() == 21)
		{
			Class67 @class = (Class67)class44_0;
			this.method_6(@class.method_5());
			this.method_8(@class.method_7());
			base.method_4(@class.method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x0001D284 File Offset: 0x0001B484
	public override Class44 vmethod_3()
	{
		Class67 @class = new Class67();
		@class.method_6(this.array_0);
		@class.method_8(this.long_0);
		@class.method_4(base.method_3());
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x0001D2BC File Offset: 0x0001B4BC
	public override bool vmethod_6(Class65 class65_0)
	{
		Class67 @class = (Class67)class65_0;
		return this.method_7() == @class.method_7() && this.method_5() == @class.method_5();
	}

	// Token: 0x04000240 RID: 576
	private Array array_0;

	// Token: 0x04000241 RID: 577
	private long long_0;
}
