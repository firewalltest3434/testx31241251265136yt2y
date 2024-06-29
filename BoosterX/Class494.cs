using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

// Token: 0x0200043B RID: 1083
internal sealed class Class494
{
	// Token: 0x17000369 RID: 873
	// (get) Token: 0x060017E4 RID: 6116 RVA: 0x00064F58 File Offset: 0x00063158
	public GClass134 MouseMoveCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_0), null));
			}
			return result;
		}
	}

	// Token: 0x1700036A RID: 874
	// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00064F8C File Offset: 0x0006318C
	public GClass134 MouseDownCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_1) == null)
			{
				result = (this.gclass134_1 = new GClass134(new Action<object>(this.method_1), null));
			}
			return result;
		}
	}

	// Token: 0x060017E6 RID: 6118 RVA: 0x00064FC0 File Offset: 0x000631C0
	public void method_0(object object_0)
	{
		GClass176 gclass = object_0 as GClass176;
		Border border = gclass.method_0() as Border;
		if (gclass.method_1().LeftButton != MouseButtonState.Pressed)
		{
			return;
		}
		Window window = Window.GetWindow(border);
		if (window.WindowState == WindowState.Maximized)
		{
			window.WindowStyle = WindowStyle.None;
			Point point = Class209.smethod_0(window, gclass.method_1().MouseDevice.GetPosition(border));
			window.Left = point.X - window.RestoreBounds.Width * 0.5;
			window.Top = point.Y;
			window.WindowState = WindowState.Normal;
			window.WindowStyle = WindowStyle.SingleBorderWindow;
		}
		window.DragMove();
	}

	// Token: 0x060017E7 RID: 6119 RVA: 0x00065070 File Offset: 0x00063270
	public void method_1(object object_0)
	{
		GClass102 gclass = object_0 as GClass102;
		Border dependencyObject = gclass.method_0() as Border;
		MouseButtonEventArgs mouseButtonEventArgs = gclass.method_1();
		Window window = Window.GetWindow(dependencyObject);
		if (mouseButtonEventArgs.ClickCount > 1)
		{
			window.WindowState = ((window.WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized);
		}
	}

	// Token: 0x040010E8 RID: 4328
	private GClass134 gclass134_0;

	// Token: 0x040010E9 RID: 4329
	private GClass134 gclass134_1;
}
