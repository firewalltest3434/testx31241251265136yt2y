using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020006FB RID: 1787
	public sealed class dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd : Page, IComponentConnector
	{
		// Token: 0x060025EF RID: 9711 RVA: 0x0009C804 File Offset: 0x0009AA04
		public dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd()
		{
			this.InitializeComponent();
			Class358.smethod_0().frame_3 = this.frame_0;
			base.DataContext = Class278.class748_0;
			GClass93 gclass = GClass93.smethod_0();
			GClass93.GDelegate3 gdelegate3_;
			if ((gdelegate3_ = dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd.Class783.gdelegate3_0) == null)
			{
				gdelegate3_ = (dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd.Class783.gdelegate3_0 = new GClass93.GDelegate3(Class278.smethod_0));
			}
			gclass.method_2(gdelegate3_);
			base.Dispatcher.Invoke<bool>(new Func<bool>(this.method_3));
			GClass93.smethod_0().method_2(new GClass93.GDelegate3(this.method_0));
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x0009C88C File Offset: 0x0009AA8C
		private void method_0()
		{
			dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd.Struct451 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd.Struct451>(ref @struct);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x0009C8C4 File Offset: 0x0009AAC4
		private void method_1(object sender, SizeChangedEventArgs p1)
		{
			if (this.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Visible)
			{
				this.stackPanel_0.Margin = new Thickness(10.0, 0.0, 0.0, 10.0);
			}
			if (this.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Collapsed)
			{
				this.stackPanel_0.Margin = new Thickness(10.0, 0.0, 10.0, 10.0);
			}
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x0009C954 File Offset: 0x0009AB54
		public void method_2(object sender, RoutedEventArgs p1)
		{
			dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd.Struct450 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd.Struct450>(ref @struct);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x0009C984 File Offset: 0x0009AB84
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x0009C9A4 File Offset: 0x0009ABA4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/customizationmainpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x0009C9D4 File Offset: 0x0009ABD4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd)target).SizeChanged += this.method_1;
				return;
			case 2:
				this.button_0 = (Button)target;
				return;
			case 3:
				((Button)target).Click += this.method_2;
				return;
			case 4:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 5:
				this.image_0 = (Image)target;
				return;
			case 6:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 7:
				this.radioButton_0 = (RadioButton)target;
				return;
			case 8:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 9:
				this.grid_0 = (Grid)target;
				return;
			case 10:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 11:
				this.frame_0 = (Frame)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x0009CAD8 File Offset: 0x0009ACD8
		private bool method_3()
		{
			this.button_1.IsEnabled = false;
			return false;
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x0009CAF4 File Offset: 0x0009ACF4
		private void method_4()
		{
			if (GClass93.smethod_0().method_19().Count <= 0 && dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_4.Count <= 0)
			{
				base.Dispatcher.Invoke<bool>(new Func<bool>(this.method_6));
				return;
			}
			base.Dispatcher.Invoke<bool>(new Func<bool>(this.method_5));
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x0009CB5C File Offset: 0x0009AD5C
		private bool method_5()
		{
			this.button_1.IsEnabled = true;
			return true;
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x0009CB78 File Offset: 0x0009AD78
		private bool method_6()
		{
			this.button_1.IsEnabled = false;
			return false;
		}

		// Token: 0x04001AFD RID: 6909
		internal Button button_0;

		// Token: 0x04001AFE RID: 6910
		internal TextBlock textBlock_0;

		// Token: 0x04001AFF RID: 6911
		internal Image image_0;

		// Token: 0x04001B00 RID: 6912
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001B01 RID: 6913
		internal RadioButton radioButton_0;

		// Token: 0x04001B02 RID: 6914
		internal StackPanel stackPanel_0;

		// Token: 0x04001B03 RID: 6915
		internal Grid grid_0;

		// Token: 0x04001B04 RID: 6916
		internal Button button_1;

		// Token: 0x04001B05 RID: 6917
		internal Frame frame_0;

		// Token: 0x04001B06 RID: 6918
		private bool bool_0;

		// Token: 0x020006FC RID: 1788
		private static class Class783
		{
			// Token: 0x04001B07 RID: 6919
			public static GClass93.GDelegate3 gdelegate3_0;
		}

		// Token: 0x020006FD RID: 1789
		[StructLayout(LayoutKind.Auto)]
		private struct Struct450 : IAsyncStateMachine
		{
			// Token: 0x060025FA RID: 9722 RVA: 0x0009CB94 File Offset: 0x0009AD94
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class704.smethod_0().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd.Struct450>(ref awaiter, ref this);
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

			// Token: 0x060025FB RID: 9723 RVA: 0x0009CC40 File Offset: 0x0009AE40
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B08 RID: 6920
			public int int_0;

			// Token: 0x04001B09 RID: 6921
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001B0A RID: 6922
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006FE RID: 1790
		[StructLayout(LayoutKind.Auto)]
		private struct Struct451 : IAsyncStateMachine
		{
			// Token: 0x060025FC RID: 9724 RVA: 0x0009CC50 File Offset: 0x0009AE50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd @object = this.dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(@object.method_4)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd.Struct451>(ref awaiter, ref this);
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

			// Token: 0x060025FD RID: 9725 RVA: 0x0009CD10 File Offset: 0x0009AF10
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B0B RID: 6923
			public int int_0;

			// Token: 0x04001B0C RID: 6924
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001B0D RID: 6925
			public dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd dje_z9PRB5J2FLZMB93NX5XBZCGU4J26PW4GDULDYD3GB52QB6LZ_ejd_0;

			// Token: 0x04001B0E RID: 6926
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
