using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007B8 RID: 1976
	public sealed class dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd : Page, IComponentConnector
	{
		// Token: 0x0600287F RID: 10367 RVA: 0x000ADCFC File Offset: 0x000ABEFC
		public dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
			base.Loaded += this.dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd_Loaded;
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x000ADD24 File Offset: 0x000ABF24
		private void dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			bool? nullable_ = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_3;
			if (nullable_.GetValueOrDefault() & nullable_ != null)
			{
				this.textBlock_0.Visibility = Visibility.Collapsed;
				return;
			}
			this.textBlock_0.Visibility = Visibility.Visible;
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x000ADD64 File Offset: 0x000ABF64
		private void method_0(bool bool_1)
		{
			dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd.Struct548 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd.Struct548>(ref @struct);
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x000ADDA4 File Offset: 0x000ABFA4
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0(true);
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x000ADDB0 File Offset: 0x000ABFB0
		private void method_1(object sender, SizeChangedEventArgs p1)
		{
			this.scrollViewer_1.MaxHeight = base.ActualHeight - 300.0;
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x000ADDD0 File Offset: 0x000ABFD0
		private void scrollViewer_0_PreviewMouseWheel(object sender, MouseWheelEventArgs p1)
		{
			ScrollViewer scrollViewer = (ScrollViewer)sender;
			if (p1.Delta < 0)
			{
				scrollViewer.LineRight();
			}
			else
			{
				scrollViewer.LineLeft();
			}
			p1.Handled = true;
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x000ADE04 File Offset: 0x000AC004
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class310.smethod_3();
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000ADE0C File Offset: 0x000AC00C
		public void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class310.smethod_2();
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000ADE14 File Offset: 0x000AC014
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/interrupts/interruptspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x000ADE44 File Offset: 0x000AC044
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd)target).SizeChanged += this.method_1;
				return;
			case 2:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 3:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 4:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 5:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 6:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 7:
				this.scrollViewer_0 = (ScrollViewer)target;
				this.scrollViewer_0.PreviewMouseWheel += this.scrollViewer_0_PreviewMouseWheel;
				return;
			case 8:
				this.border_0 = (Border)target;
				return;
			case 9:
				this.scrollViewer_1 = (ScrollViewer)target;
				return;
			case 10:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001E75 RID: 7797
		internal Button button_0;

		// Token: 0x04001E76 RID: 7798
		internal Button button_1;

		// Token: 0x04001E77 RID: 7799
		internal Button button_2;

		// Token: 0x04001E78 RID: 7800
		internal TextBlock textBlock_0;

		// Token: 0x04001E79 RID: 7801
		internal CheckBox checkBox_0;

		// Token: 0x04001E7A RID: 7802
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001E7B RID: 7803
		internal Border border_0;

		// Token: 0x04001E7C RID: 7804
		internal ScrollViewer scrollViewer_1;

		// Token: 0x04001E7D RID: 7805
		internal ItemsControl itemsControl_0;

		// Token: 0x04001E7E RID: 7806
		private bool bool_0;

		// Token: 0x020007B9 RID: 1977
		[StructLayout(LayoutKind.Auto)]
		private struct Struct548 : IAsyncStateMachine
		{
			// Token: 0x06002889 RID: 10377 RVA: 0x000ADF74 File Offset: 0x000AC174
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd = this.dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_B9;
					}
					if (num != 1)
					{
						dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd.button_2.IsEnabled = false;
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd.scrollViewer_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd.Struct548>(ref awaiter, ref this);
							return;
						}
						goto IL_B9;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_85:
					awaiter.GetResult();
					dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd.button_2.IsEnabled = true;
					goto IL_132;
					IL_B9:
					awaiter.GetResult();
					dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd.DataContext = null;
					dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd.DataContext = Class310.smethod_0(this.bool_0);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd.scrollViewer_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd.Struct548>(ref awaiter, ref this);
						return;
					}
					goto IL_85;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_132:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600288A RID: 10378 RVA: 0x000AE0E4 File Offset: 0x000AC2E4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E7F RID: 7807
			public int int_0;

			// Token: 0x04001E80 RID: 7808
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001E81 RID: 7809
			public dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd_0;

			// Token: 0x04001E82 RID: 7810
			public bool bool_0;

			// Token: 0x04001E83 RID: 7811
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
