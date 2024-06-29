using System;
using System.Reflection;

// Token: 0x02000075 RID: 117
internal sealed class Class55 : Class44
{
	// Token: 0x060003F9 RID: 1017 RVA: 0x000164A0 File Offset: 0x000146A0
	public Class55() : base(4)
	{
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x000164AC File Offset: 0x000146AC
	public MethodBase method_3()
	{
		return this.methodBase_0;
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x000164B4 File Offset: 0x000146B4
	public void method_4(MethodBase methodBase_1)
	{
		this.methodBase_0 = methodBase_1;
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x000164C0 File Offset: 0x000146C0
	public IntPtr method_5()
	{
		return this.method_3().MethodHandle.GetFunctionPointer();
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x000164E0 File Offset: 0x000146E0
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x000164E8 File Offset: 0x000146E8
	public override void vmethod_1(object object_0)
	{
		this.method_4((MethodBase)object_0);
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x000164F8 File Offset: 0x000146F8
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		if (class44_0.method_0() == 4)
		{
			this.method_4(((Class55)class44_0).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x0001652C File Offset: 0x0001472C
	public override Class44 vmethod_3()
	{
		Class55 @class = new Class55();
		@class.method_4(this.methodBase_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x040000E2 RID: 226
	private MethodBase methodBase_0;
}
