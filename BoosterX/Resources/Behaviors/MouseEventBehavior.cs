using System;
using System.Windows;
using System.Windows.Input;

namespace BoosterX.Resources.Behaviors
{
	// Token: 0x0200083D RID: 2109
	public static class MouseEventBehavior
	{
		// Token: 0x06002AF9 RID: 11001 RVA: 0x000BA31C File Offset: 0x000B851C
		public static ICommand GetMouseMoveCommand(UIElement element)
		{
			return (ICommand)element.GetValue(MouseEventBehavior.MouseMoveCommandProperty);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000BA330 File Offset: 0x000B8530
		public static void SetMouseMoveCommand(UIElement element, ICommand value)
		{
			element.SetValue(MouseEventBehavior.MouseMoveCommandProperty, value);
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x000BA340 File Offset: 0x000B8540
		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			UIElement uielement = dependencyObject_0 as UIElement;
			if (uielement != null)
			{
				if (dependencyPropertyChangedEventArgs_0.OldValue != null)
				{
					UIElement uielement2 = uielement;
					MouseEventHandler value;
					if ((value = MouseEventBehavior.Class863.mouseEventHandler_0) == null)
					{
						value = (MouseEventBehavior.Class863.mouseEventHandler_0 = new MouseEventHandler(MouseEventBehavior.smethod_1));
					}
					uielement2.MouseMove -= value;
				}
				if (dependencyPropertyChangedEventArgs_0.NewValue != null)
				{
					UIElement uielement3 = uielement;
					MouseEventHandler value2;
					if ((value2 = MouseEventBehavior.Class863.mouseEventHandler_0) == null)
					{
						value2 = (MouseEventBehavior.Class863.mouseEventHandler_0 = new MouseEventHandler(MouseEventBehavior.smethod_1));
					}
					uielement3.MouseMove += value2;
				}
			}
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x000BA3AC File Offset: 0x000B85AC
		private static void smethod_1(object sender, MouseEventArgs p1)
		{
			UIElement uielement = sender as UIElement;
			ICommand mouseMoveCommand = MouseEventBehavior.GetMouseMoveCommand(uielement);
			if (mouseMoveCommand != null && mouseMoveCommand.CanExecute(p1))
			{
				mouseMoveCommand.Execute(new GClass176(uielement, p1));
			}
		}

		// Token: 0x04002104 RID: 8452
		public static readonly DependencyProperty MouseMoveCommandProperty = DependencyProperty.RegisterAttached("MouseMoveCommand", typeof(ICommand), typeof(MouseEventBehavior), new PropertyMetadata(null, new PropertyChangedCallback(MouseEventBehavior.smethod_0)));

		// Token: 0x0200083E RID: 2110
		private static class Class863
		{
			// Token: 0x04002105 RID: 8453
			public static MouseEventHandler mouseEventHandler_0;
		}
	}
}
