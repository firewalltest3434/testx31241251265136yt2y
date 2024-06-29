using System;

// Token: 0x02000024 RID: 36
internal sealed class Class51 : Class44
{
	// Token: 0x060000D7 RID: 215 RVA: 0x000045E4 File Offset: 0x000027E4
	public Class51() : base(17)
	{
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x000045F0 File Offset: 0x000027F0
	public object method_3()
	{
		return this.object_0;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x000045F8 File Offset: 0x000027F8
	public void method_4(object object_1)
	{
		this.object_0 = object_1;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00004604 File Offset: 0x00002804
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060000DB RID: 219 RVA: 0x0000460C File Offset: 0x0000280C
	public override void vmethod_1(object object_1)
	{
		this.method_4(object_1);
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00004618 File Offset: 0x00002818
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		this.method_4(class44_0.vmethod_0());
		return this;
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00004634 File Offset: 0x00002834
	public override Class44 vmethod_3()
	{
		Class51 @class = new Class51();
		@class.method_4(this.object_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0400003C RID: 60
	private object object_0;
}
