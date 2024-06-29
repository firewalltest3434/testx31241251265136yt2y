using System;

// Token: 0x0200009C RID: 156
internal sealed class Class70 : Class44
{
	// Token: 0x060004EF RID: 1263 RVA: 0x0001A534 File Offset: 0x00018734
	public Class70() : base(0)
	{
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x0001A540 File Offset: 0x00018740
	public Array method_3()
	{
		return this.array_0;
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x0001A548 File Offset: 0x00018748
	public void method_4(Array array_1)
	{
		this.array_0 = array_1;
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x0001A554 File Offset: 0x00018754
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x0001A55C File Offset: 0x0001875C
	public override void vmethod_1(object object_0)
	{
		this.method_4((Array)object_0);
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x0001A56C File Offset: 0x0001876C
	public override Class44 vmethod_3()
	{
		Class70 @class = new Class70();
		@class.method_4(this.array_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x0001A58C File Offset: 0x0001878C
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		int num = class44_0.method_0();
		if (num != 0)
		{
			if (num != 17)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.method_4((Array)((Class51)class44_0).method_3());
		}
		else
		{
			this.method_4(((Class70)class44_0).method_3());
		}
		return this;
	}

	// Token: 0x04000210 RID: 528
	private Array array_0;
}
