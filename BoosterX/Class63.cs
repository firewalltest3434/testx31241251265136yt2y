using System;

// Token: 0x02000054 RID: 84
internal sealed class Class63 : Class61
{
	// Token: 0x06000329 RID: 809 RVA: 0x000131E0 File Offset: 0x000113E0
	public Class63() : base(13)
	{
	}

	// Token: 0x0600032A RID: 810 RVA: 0x000131EC File Offset: 0x000113EC
	public int method_3()
	{
		return this.int_1;
	}

	// Token: 0x0600032B RID: 811 RVA: 0x000131F4 File Offset: 0x000113F4
	public void method_4(int int_2)
	{
		this.int_1 = int_2;
	}

	// Token: 0x0600032C RID: 812 RVA: 0x00013200 File Offset: 0x00011400
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		if (class44_0.method_0() == 13)
		{
			this.method_4(((Class63)class44_0).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00013234 File Offset: 0x00011434
	public override Class44 vmethod_3()
	{
		Class63 @class = new Class63();
		@class.method_4(this.int_1);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0400009C RID: 156
	private int int_1;
}
