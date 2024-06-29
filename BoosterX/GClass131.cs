using System;

// Token: 0x02000446 RID: 1094
public abstract class GClass131 : GClass128<object>
{
	// Token: 0x06001843 RID: 6211 RVA: 0x00065BC4 File Offset: 0x00063DC4
	protected GClass131()
	{
		base.method_0(new Action<GInterface11<object>, object>(this.method_5));
	}

	// Token: 0x06001844 RID: 6212 RVA: 0x00065BE0 File Offset: 0x00063DE0
	protected string method_2()
	{
		return base.imethod_0();
	}

	// Token: 0x06001845 RID: 6213 RVA: 0x00065BE8 File Offset: 0x00063DE8
	protected void method_3(string string_1)
	{
		base.method_1(string_1);
	}

	// Token: 0x06001846 RID: 6214 RVA: 0x00065BF4 File Offset: 0x00063DF4
	public void method_4(Action<string, GEnum93> action_2)
	{
		base.imethod_2(action_2);
	}

	// Token: 0x06001847 RID: 6215
	protected abstract void RunFunction(object argument);

	// Token: 0x06001848 RID: 6216 RVA: 0x00065C00 File Offset: 0x00063E00
	private void method_5(GInterface11<object> ginterface11_0, object object_0)
	{
		this.RunFunction(object_0);
	}
}
