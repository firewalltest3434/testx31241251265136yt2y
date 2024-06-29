using System;

// Token: 0x0200045A RID: 1114
public abstract class GClass128<T> : GInterface11<T>, GInterface15
{
	// Token: 0x060018B5 RID: 6325 RVA: 0x000668CC File Offset: 0x00064ACC
	protected void method_0(Action<GInterface11<T>, T> action_2)
	{
		this.action_0 = action_2;
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x000668D8 File Offset: 0x00064AD8
	public void imethod_3(T gparam_0)
	{
		try
		{
			Action<GInterface11<T>, T> action = this.action_0;
			if (action != null)
			{
				action(this, gparam_0);
			}
		}
		catch (Exception exception_)
		{
			GClass141.smethod_2("Enable tweak error", exception_);
		}
	}

	// Token: 0x060018B7 RID: 6327 RVA: 0x0006691C File Offset: 0x00064B1C
	public void imethod_2(Action<string, GEnum93> action_2)
	{
		this.action_1 = action_2;
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x00066928 File Offset: 0x00064B28
	protected void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x00066934 File Offset: 0x00064B34
	public string imethod_0()
	{
		return this.string_0;
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x0006693C File Offset: 0x00064B3C
	public void imethod_1(string string_1, GEnum93 genum93_0 = (GEnum93)1)
	{
		Action<string, GEnum93> action = this.action_1;
		if (action == null)
		{
			return;
		}
		action(string_1, genum93_0);
	}

	// Token: 0x04001145 RID: 4421
	private Action<GInterface11<T>, T> action_0;

	// Token: 0x04001146 RID: 4422
	private Action<string, GEnum93> action_1;

	// Token: 0x04001147 RID: 4423
	private string string_0;
}
