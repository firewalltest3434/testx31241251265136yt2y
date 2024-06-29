using System;
using System.Windows;
using System.Windows.Media;

// Token: 0x02000186 RID: 390
internal sealed class Class209
{
	// Token: 0x060009FA RID: 2554 RVA: 0x0002DCD4 File Offset: 0x0002BED4
	public static Point smethod_0(UIElement uielement_0, Point point_0)
	{
		if (uielement_0 != null)
		{
			Visual visual = Class209.smethod_1(uielement_0);
			if (visual != null)
			{
				return visual.PointToScreen(point_0);
			}
		}
		return default(Point);
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x0002DD00 File Offset: 0x0002BF00
	private static Visual smethod_1(UIElement uielement_0)
	{
		DependencyObject parent = VisualTreeHelper.GetParent(uielement_0);
		Visual visual = uielement_0;
		while (parent != null && visual == null)
		{
			visual = (parent as Visual);
			parent = VisualTreeHelper.GetParent(parent);
		}
		return visual;
	}
}
