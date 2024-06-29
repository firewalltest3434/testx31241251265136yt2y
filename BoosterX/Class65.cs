using System;

// Token: 0x020000BB RID: 187
internal abstract class Class65 : Class61
{
	// Token: 0x060005C7 RID: 1479 RVA: 0x0001E298 File Offset: 0x0001C498
	public Class65(int int_1) : base(int_1)
	{
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x0001E2A4 File Offset: 0x0001C4A4
	public Type method_3()
	{
		return this.type_1;
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0001E2AC File Offset: 0x0001C4AC
	public void method_4(Type type_2)
	{
		this.type_1 = type_2;
	}

	// Token: 0x060005CA RID: 1482
	public abstract object vmethod_4();

	// Token: 0x060005CB RID: 1483
	public abstract void vmethod_5(object object_0);

	// Token: 0x060005CC RID: 1484
	public abstract bool vmethod_6(Class65 class65_0);

	// Token: 0x04000268 RID: 616
	private Type type_1;
}
