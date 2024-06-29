using System;
using System.Reflection;

// Token: 0x02000002 RID: 2
internal sealed class Class62 : Class61
{
	// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
	public Class62(FieldInfo fieldInfo_1, object object_1) : this()
	{
		this.method_6(fieldInfo_1);
		this.method_4(object_1);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002084 File Offset: 0x00000284
	public Class62(FieldInfo fieldInfo_1, object object_1, Class61 class61_1) : this(fieldInfo_1, object_1)
	{
		this.method_8(class61_1);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002098 File Offset: 0x00000298
	private Class62() : base(18)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000020A4 File Offset: 0x000002A4
	public object method_3()
	{
		return this.object_0;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020AC File Offset: 0x000002AC
	private void method_4(object object_1)
	{
		this.object_0 = object_1;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000020B8 File Offset: 0x000002B8
	public FieldInfo method_5()
	{
		return this.fieldInfo_0;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000020C0 File Offset: 0x000002C0
	private void method_6(FieldInfo fieldInfo_1)
	{
		this.fieldInfo_0 = fieldInfo_1;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000020CC File Offset: 0x000002CC
	public Class61 method_7()
	{
		return this.class61_0;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000020D4 File Offset: 0x000002D4
	private void method_8(Class61 class61_1)
	{
		this.class61_0 = class61_1;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000020E0 File Offset: 0x000002E0
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		if (class44_0.method_0() == 18)
		{
			Class62 @class = (Class62)class44_0;
			this.method_4(@class.method_3());
			this.method_6(@class.method_5());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000212C File Offset: 0x0000032C
	public override Class44 vmethod_3()
	{
		Class62 @class = new Class62();
		@class.method_4(this.method_3());
		@class.method_6(this.method_5());
		@class.method_8(this.method_7());
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x04000001 RID: 1
	private object object_0;

	// Token: 0x04000002 RID: 2
	private FieldInfo fieldInfo_0;

	// Token: 0x04000003 RID: 3
	private Class61 class61_0;
}
