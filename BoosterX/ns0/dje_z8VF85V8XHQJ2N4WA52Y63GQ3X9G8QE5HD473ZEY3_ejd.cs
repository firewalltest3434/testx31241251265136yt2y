using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ns0
{
	// Token: 0x020006EF RID: 1775
	public sealed class dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd : Window, IComponentConnector, IStyleConnector
	{
		// Token: 0x060025BD RID: 9661 RVA: 0x0009B7BC File Offset: 0x000999BC
		public dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd(Type type_1)
		{
			this.InitializeComponent();
			this.type_0 = type_1;
			Class358.smethod_0().method_3(type_1, this.frame_0);
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0009B7E4 File Offset: 0x000999E4
		private void method_0(object sender, MouseButtonEventArgs p1)
		{
			if (p1.LeftButton == MouseButtonState.Pressed)
			{
				base.DragMove();
			}
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0009B7F8 File Offset: 0x000999F8
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd.Struct445 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd.Struct445>(ref @struct);
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x0009B830 File Offset: 0x00099A30
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			base.WindowState = WindowState.Minimized;
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0009B83C File Offset: 0x00099A3C
		private void method_1(object sender, SizeChangedEventArgs p1)
		{
			this.rectangleGeometry_0.Rect = new Rect(0.0, 0.0, base.ActualWidth, base.ActualWidth);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x0009B86C File Offset: 0x00099A6C
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			if (this.bool_0)
			{
				this.border_0.CornerRadius = new CornerRadius(20.0);
				this.rectangleGeometry_0.RadiusX = 20.0;
				this.rectangleGeometry_0.RadiusY = 20.0;
				base.WindowState = WindowState.Normal;
				base.Width = 1050.0;
				base.Height = 750.0;
				this.bool_0 = false;
				return;
			}
			this.border_0.CornerRadius = new CornerRadius(0.0);
			this.rectangleGeometry_0.RadiusX = 0.0;
			this.rectangleGeometry_0.RadiusY = 0.0;
			base.WindowState = WindowState.Maximized;
			this.bool_0 = true;
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x0009B940 File Offset: 0x00099B40
		private void method_2(object sender, MouseButtonEventArgs p1)
		{
			Rectangle rectangle = sender as Rectangle;
			if (rectangle != null)
			{
				this.bool_1 = true;
				rectangle.CaptureMouse();
			}
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x0009B968 File Offset: 0x00099B68
		private void method_3(object sender, MouseButtonEventArgs p1)
		{
			Rectangle rectangle = sender as Rectangle;
			if (rectangle != null)
			{
				this.bool_1 = false;
				rectangle.ReleaseMouseCapture();
			}
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0009B98C File Offset: 0x00099B8C
		private void method_4(object sender, MouseEventArgs p1)
		{
			if (this.bool_1 & (base.Width >= 900.0 & base.Height >= 700.0) & !this.bool_0)
			{
				Rectangle rectangle = sender as Rectangle;
				Window window = rectangle.Tag as Window;
				if (rectangle != null)
				{
					double num = p1.GetPosition(window).X;
					double num2 = p1.GetPosition(window).Y;
					rectangle.CaptureMouse();
					if (rectangle.Name.ToLower().Contains("right"))
					{
						num += 5.0;
						if (num > 0.0)
						{
							window.Width = num;
						}
					}
					if (rectangle.Name.ToLower().Contains("left"))
					{
						num -= 5.0;
						window.Left += num;
						num = window.Width - num;
						if (num > 0.0)
						{
							window.Width = num;
						}
					}
					if (rectangle.Name.ToLower().Contains("bottom"))
					{
						num2 += 5.0;
						if (num2 > 0.0)
						{
							window.Height = num2;
						}
					}
					if (rectangle.Name.ToLower().Contains("top"))
					{
						num2 -= 5.0;
						window.Top += num2;
						num2 = window.Height - num2;
						if (num2 > 0.0)
						{
							window.Height = num2;
						}
					}
				}
			}
			if (base.Width < 900.0)
			{
				base.Width = 900.0;
			}
			if (base.Height < 700.0)
			{
				base.Height = 700.0;
			}
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x0009BB60 File Offset: 0x00099D60
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_2)
			{
				return;
			}
			this.bool_2 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/windows/customwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x0009BB90 File Offset: 0x00099D90
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd)target).SizeChanged += this.method_1;
				return;
			default:
				this.bool_2 = true;
				return;
			case 3:
				this.border_0 = (Border)target;
				return;
			case 4:
				this.rectangleGeometry_0 = (RectangleGeometry)target;
				return;
			case 5:
				this.rectangle_0 = (Rectangle)target;
				return;
			case 6:
				this.rectangle_1 = (Rectangle)target;
				return;
			case 7:
				this.rectangle_2 = (Rectangle)target;
				return;
			case 8:
				this.grid_0 = (Grid)target;
				return;
			case 9:
				this.frame_0 = (Frame)target;
				return;
			case 10:
				((Border)target).MouseDown += this.method_0;
				return;
			case 11:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 12:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 13:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 14:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			}
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x0009BCE8 File Offset: 0x00099EE8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 2)
			{
				EventSetter eventSetter = new EventSetter();
				eventSetter.Event = UIElement.MouseLeftButtonDownEvent;
				eventSetter.Handler = new MouseButtonEventHandler(this.method_2);
				((Style)target).Setters.Add(eventSetter);
				eventSetter = new EventSetter();
				eventSetter.Event = UIElement.MouseLeftButtonUpEvent;
				eventSetter.Handler = new MouseButtonEventHandler(this.method_3);
				((Style)target).Setters.Add(eventSetter);
				eventSetter = new EventSetter();
				eventSetter.Event = UIElement.MouseMoveEvent;
				eventSetter.Handler = new MouseEventHandler(this.method_4);
				((Style)target).Setters.Add(eventSetter);
			}
		}

		// Token: 0x04001AC9 RID: 6857
		public Type type_0;

		// Token: 0x04001ACA RID: 6858
		private bool bool_0;

		// Token: 0x04001ACB RID: 6859
		private bool bool_1;

		// Token: 0x04001ACC RID: 6860
		internal Border border_0;

		// Token: 0x04001ACD RID: 6861
		internal RectangleGeometry rectangleGeometry_0;

		// Token: 0x04001ACE RID: 6862
		internal Rectangle rectangle_0;

		// Token: 0x04001ACF RID: 6863
		internal Rectangle rectangle_1;

		// Token: 0x04001AD0 RID: 6864
		internal Rectangle rectangle_2;

		// Token: 0x04001AD1 RID: 6865
		internal Grid grid_0;

		// Token: 0x04001AD2 RID: 6866
		internal Frame frame_0;

		// Token: 0x04001AD3 RID: 6867
		public StackPanel stackPanel_0;

		// Token: 0x04001AD4 RID: 6868
		internal Button button_0;

		// Token: 0x04001AD5 RID: 6869
		internal Button button_1;

		// Token: 0x04001AD6 RID: 6870
		internal Button button_2;

		// Token: 0x04001AD7 RID: 6871
		private bool bool_2;

		// Token: 0x020006F0 RID: 1776
		[StructLayout(LayoutKind.Auto)]
		private struct Struct445 : IAsyncStateMachine
		{
			// Token: 0x060025C9 RID: 9673 RVA: 0x0009BD98 File Offset: 0x00099F98
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd = this.dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd.frame_0.Content.GetType() == typeof(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd))
						{
							((dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd)Class358.smethod_0().list_2.First(new Func<Page, bool>(dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd.Class781.class781_0.method_0))).bool_0 = false;
						}
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd.Struct445>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd.Close();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060025CA RID: 9674 RVA: 0x0009BEB0 File Offset: 0x0009A0B0
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AD8 RID: 6872
			public int int_0;

			// Token: 0x04001AD9 RID: 6873
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001ADA RID: 6874
			public dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd_0;

			// Token: 0x04001ADB RID: 6875
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006F1 RID: 1777
		[Serializable]
		private sealed class Class781
		{
			// Token: 0x060025CD RID: 9677 RVA: 0x0009BED4 File Offset: 0x0009A0D4
			internal bool method_0(Page page_0)
			{
				return page_0.GetType() == typeof(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd);
			}

			// Token: 0x04001ADC RID: 6876
			public static readonly dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd.Class781 class781_0 = new dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd.Class781();

			// Token: 0x04001ADD RID: 6877
			public static Func<Page, bool> func_0;
		}
	}
}
