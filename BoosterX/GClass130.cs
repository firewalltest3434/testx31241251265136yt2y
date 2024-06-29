using System;

// Token: 0x020001D1 RID: 465
public sealed class GClass130 : GClass129
{
	// Token: 0x06000AF7 RID: 2807 RVA: 0x00033594 File Offset: 0x00031794
	public void method_7(Action<GClass130> action_4)
	{
		this.action_2 = action_4;
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x000335A0 File Offset: 0x000317A0
	public void method_8(Action<GClass130> action_4)
	{
		this.action_3 = action_4;
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x000335AC File Offset: 0x000317AC
	public void method_9(Action<string, GEnum93> action_4)
	{
		base.imethod_2(action_4);
	}

	// Token: 0x170000FD RID: 253
	// (set) Token: 0x06000AFA RID: 2810 RVA: 0x000335B8 File Offset: 0x000317B8
	public string Name
	{
		set
		{
			base.method_1(value);
		}
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x000335C4 File Offset: 0x000317C4
	protected override void vmethod_0()
	{
		this.action_2(this);
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x000335E0 File Offset: 0x000317E0
	protected override void vmethod_1()
	{
		this.action_2(this);
	}

	// Token: 0x040006BE RID: 1726
	private Action<GClass130> action_2;

	// Token: 0x040006BF RID: 1727
	private Action<GClass130> action_3;
}
