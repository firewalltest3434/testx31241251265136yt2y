using System;

// Token: 0x020001F6 RID: 502
public abstract class GClass129 : GClass128<bool>
{
	// Token: 0x06000C1E RID: 3102 RVA: 0x00037098 File Offset: 0x00035298
	protected GClass129()
	{
		base.method_0(new Action<GInterface11<bool>, bool>(this.method_6));
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x000370B4 File Offset: 0x000352B4
	protected string method_2()
	{
		return base.imethod_0();
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x000370BC File Offset: 0x000352BC
	protected void method_3(string string_1)
	{
		base.method_1(string_1);
	}

	// Token: 0x06000C21 RID: 3105
	protected abstract void vmethod_0();

	// Token: 0x06000C22 RID: 3106
	protected abstract void vmethod_1();

	// Token: 0x06000C23 RID: 3107 RVA: 0x000370C8 File Offset: 0x000352C8
	public void method_4()
	{
		base.imethod_3(true);
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x000370D4 File Offset: 0x000352D4
	public void method_5()
	{
		base.imethod_3(false);
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x000370E0 File Offset: 0x000352E0
	private void method_6(GInterface11<bool> ginterface11_0, bool bool_0)
	{
		if (bool_0)
		{
			this.vmethod_0();
			return;
		}
		this.vmethod_1();
	}
}
