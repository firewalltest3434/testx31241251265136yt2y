using System;

// Token: 0x020005BD RID: 1469
public abstract class GClass132 : GClass128<string>
{
	// Token: 0x06001FD7 RID: 8151 RVA: 0x00082DDC File Offset: 0x00080FDC
	protected GClass132()
	{
		base.method_0(new Action<GInterface11<string>, string>(this.method_5));
	}

	// Token: 0x06001FD8 RID: 8152 RVA: 0x00082DF8 File Offset: 0x00080FF8
	protected string method_2()
	{
		return base.imethod_0();
	}

	// Token: 0x06001FD9 RID: 8153 RVA: 0x00082E00 File Offset: 0x00081000
	protected void method_3(string string_1)
	{
		base.method_1(string_1);
	}

	// Token: 0x06001FDA RID: 8154 RVA: 0x00082E0C File Offset: 0x0008100C
	public void method_4(Action<string, GEnum93> action_2)
	{
		base.imethod_2(action_2);
	}

	// Token: 0x06001FDB RID: 8155
	protected abstract void vmethod_0(string string_1);

	// Token: 0x06001FDC RID: 8156 RVA: 0x00082E18 File Offset: 0x00081018
	private void method_5(GInterface11<string> ginterface11_0, string string_1)
	{
		this.vmethod_0(string_1);
	}
}
