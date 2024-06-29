using System;
using System.Windows;
using System.Windows.Input;

// Token: 0x020005A5 RID: 1445
public sealed class GClass176
{
	// Token: 0x06001F04 RID: 7940 RVA: 0x00080E00 File Offset: 0x0007F000
	public GClass176(UIElement uielement_1, MouseEventArgs mouseEventArgs_1)
	{
		this.uielement_0 = uielement_1;
		this.mouseEventArgs_0 = mouseEventArgs_1;
	}

	// Token: 0x06001F05 RID: 7941 RVA: 0x00080E18 File Offset: 0x0007F018
	public UIElement method_0()
	{
		return this.uielement_0;
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x00080E20 File Offset: 0x0007F020
	public MouseEventArgs method_1()
	{
		return this.mouseEventArgs_0;
	}

	// Token: 0x040015C4 RID: 5572
	private readonly UIElement uielement_0;

	// Token: 0x040015C5 RID: 5573
	private readonly MouseEventArgs mouseEventArgs_0;
}
