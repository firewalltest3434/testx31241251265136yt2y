using System;

// Token: 0x020000BC RID: 188
internal sealed class Class71 : Class44
{
	// Token: 0x060005CD RID: 1485 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
	public Class71() : base(9)
	{
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x0001E2C4 File Offset: 0x0001C4C4
	public string method_3()
	{
		return this.string_0;
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x0001E2CC File Offset: 0x0001C4CC
	public void method_4(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x0001E2D8 File Offset: 0x0001C4D8
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0001E2E0 File Offset: 0x0001C4E0
	public override void vmethod_1(object object_0)
	{
		this.method_4((string)object_0);
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0001E2F0 File Offset: 0x0001C4F0
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		int num = class44_0.method_0();
		if (num != 9)
		{
			if (num != 17)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.method_4((string)((Class51)class44_0).method_3());
		}
		else
		{
			this.method_4(((Class71)class44_0).method_3());
		}
		return this;
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x0001E358 File Offset: 0x0001C558
	public override Class44 vmethod_3()
	{
		Class71 @class = new Class71();
		@class.method_4(this.string_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x04000269 RID: 617
	private string string_0;
}
