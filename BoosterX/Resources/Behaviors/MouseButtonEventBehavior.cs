using System;
using System.Windows;
using System.Windows.Input;

namespace BoosterX.Resources.Behaviors
{
	// Token: 0x0200083B RID: 2107
	public static class MouseButtonEventBehavior
	{
		// Token: 0x06002AF3 RID: 10995 RVA: 0x000BA1A8 File Offset: 0x000B83A8
		public static ICommand GetMouseButtonCommand(UIElement element)
		{
			return (ICommand)element.GetValue(MouseButtonEventBehavior.MouseButtonCommandProperty);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x000BA1BC File Offset: 0x000B83BC
		public static void SetMouseButtonCommand(UIElement element, ICommand value)
		{
			element.SetValue(MouseButtonEventBehavior.MouseButtonCommandProperty, value);
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x000BA1CC File Offset: 0x000B83CC
		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			UIElement uielement = dependencyObject_0 as UIElement;
			if (uielement != null)
			{
				if (dependencyPropertyChangedEventArgs_0.OldValue != null)
				{
					UIElement uielement2 = uielement;
					MouseButtonEventHandler value;
					if ((value = MouseButtonEventBehavior.Class862.mouseButtonEventHandler_0) == null)
					{
						value = (MouseButtonEventBehavior.Class862.mouseButtonEventHandler_0 = new MouseButtonEventHandler(MouseButtonEventBehavior.smethod_1));
					}
					uielement2.MouseDown -= value;
					UIElement uielement3 = uielement;
					MouseButtonEventHandler value2;
					if ((value2 = MouseButtonEventBehavior.Class862.mouseButtonEventHandler_1) == null)
					{
						value2 = (MouseButtonEventBehavior.Class862.mouseButtonEventHandler_1 = new MouseButtonEventHandler(MouseButtonEventBehavior.smethod_2));
					}
					uielement3.MouseUp -= value2;
				}
				if (dependencyPropertyChangedEventArgs_0.NewValue != null)
				{
					UIElement uielement4 = uielement;
					MouseButtonEventHandler value3;
					if ((value3 = MouseButtonEventBehavior.Class862.mouseButtonEventHandler_0) == null)
					{
						value3 = (MouseButtonEventBehavior.Class862.mouseButtonEventHandler_0 = new MouseButtonEventHandler(MouseButtonEventBehavior.smethod_1));
					}
					uielement4.MouseDown += value3;
					UIElement uielement5 = uielement;
					MouseButtonEventHandler value4;
					if ((value4 = MouseButtonEventBehavior.Class862.mouseButtonEventHandler_1) == null)
					{
						value4 = (MouseButtonEventBehavior.Class862.mouseButtonEventHandler_1 = new MouseButtonEventHandler(MouseButtonEventBehavior.smethod_2));
					}
					uielement5.MouseUp += value4;
				}
			}
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x000BA27C File Offset: 0x000B847C
		private static void smethod_1(object sender, MouseButtonEventArgs p1)
		{
			UIElement uielement = sender as UIElement;
			ICommand mouseButtonCommand = MouseButtonEventBehavior.GetMouseButtonCommand(uielement);
			if (mouseButtonCommand != null && mouseButtonCommand.CanExecute(p1))
			{
				mouseButtonCommand.Execute(new GClass102(uielement, p1));
			}
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x000BA2B0 File Offset: 0x000B84B0
		private static void smethod_2(object sender, MouseButtonEventArgs p1)
		{
			UIElement uielement = sender as UIElement;
			ICommand mouseButtonCommand = MouseButtonEventBehavior.GetMouseButtonCommand(uielement);
			if (mouseButtonCommand != null && mouseButtonCommand.CanExecute(p1))
			{
				mouseButtonCommand.Execute(new GClass102(uielement, p1));
			}
		}

		// Token: 0x04002101 RID: 8449
		public static readonly DependencyProperty MouseButtonCommandProperty = DependencyProperty.RegisterAttached("MouseButtonCommand", typeof(ICommand), typeof(MouseButtonEventBehavior), new PropertyMetadata(null, new PropertyChangedCallback(MouseButtonEventBehavior.smethod_0)));

		// Token: 0x0200083C RID: 2108
		private static class Class862
		{
			// Token: 0x04002102 RID: 8450
			public static MouseButtonEventHandler mouseButtonEventHandler_0;

			// Token: 0x04002103 RID: 8451
			public static MouseButtonEventHandler mouseButtonEventHandler_1;
		}
	}
}
