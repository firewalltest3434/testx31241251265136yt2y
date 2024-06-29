using System;
using System.Windows;
using System.Windows.Input;

// Token: 0x02000345 RID: 837
public sealed class GClass102
{
	// Token: 0x060012F4 RID: 4852 RVA: 0x0004DD98 File Offset: 0x0004BF98
	public GClass102(UIElement uielement_1, MouseButtonEventArgs mouseButtonEventArgs_1)
	{
		this.uielement_0 = uielement_1;
		this.mouseButtonEventArgs_0 = mouseButtonEventArgs_1;
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x0004DDB0 File Offset: 0x0004BFB0
	public UIElement method_0()
	{
		return this.uielement_0;
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x0004DDB8 File Offset: 0x0004BFB8
	public MouseButtonEventArgs method_1()
	{
		return this.mouseButtonEventArgs_0;
	}

	// Token: 0x04000B9E RID: 2974
	private readonly UIElement uielement_0;

	// Token: 0x04000B9F RID: 2975
	private readonly MouseButtonEventArgs mouseButtonEventArgs_0;
}
