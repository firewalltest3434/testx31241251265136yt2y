using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace ns0
{
	// Token: 0x020007AA RID: 1962
	public sealed class dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600284B RID: 10315 RVA: 0x000AC9A8 File Offset: 0x000AABA8
		public dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd()
		{
			this.InitializeComponent();
			Class533.smethod_0(new Class533.Delegate27(this.method_1));
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x000AC9C8 File Offset: 0x000AABC8
		private void method_0(object sender, DependencyPropertyChangedEventArgs p1)
		{
			bool? flag = Class389.class504_0.method_36();
			if (!(flag.GetValueOrDefault() & flag != null))
			{
				this.blurEffect_0.Radius = 15.0;
				this.stackPanel_0.Opacity = 0.3;
				this.textBlock_6.Opacity = 1.0;
				this.stackPanel_0.IsEnabled = false;
				this.textBlock_6.Visibility = Visibility.Visible;
				return;
			}
			this.blurEffect_0.Radius = 0.0;
			this.stackPanel_0.Opacity = 1.0;
			this.textBlock_6.Opacity = 0.0;
			this.stackPanel_0.IsEnabled = true;
			this.textBlock_6.Visibility = Visibility.Collapsed;
			if (base.IsVisible)
			{
				Class533.smethod_3();
				return;
			}
			Class533.smethod_4();
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x000ACAB0 File Offset: 0x000AACB0
		private void method_1()
		{
			dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Struct542 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Struct542>(ref @struct);
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x000ACAE8 File Offset: 0x000AACE8
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Struct544 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Struct544>(ref @struct);
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x000ACB20 File Offset: 0x000AAD20
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Struct543 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Struct543>(ref @struct);
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x000ACB58 File Offset: 0x000AAD58
		private void method_2(object sender, SizeChangedEventArgs p1)
		{
			if (base.ActualWidth < 41.0)
			{
				return;
			}
			this.border_0.Width = base.ActualWidth - 40.0;
			this.rectangleGeometry_0.Rect = new Rect(0.0, 0.0, base.ActualWidth - 40.0, 10.0);
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x000ACBD0 File Offset: 0x000AADD0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/memoryreviewuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x000ACC00 File Offset: 0x000AAE00
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd)target).IsVisibleChanged += this.method_0;
				((dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd)target).SizeChanged += this.method_2;
				return;
			case 2:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 3:
				this.border_0 = (Border)target;
				return;
			case 4:
				this.rectangleGeometry_0 = (RectangleGeometry)target;
				return;
			case 5:
				this.border_1 = (Border)target;
				return;
			case 6:
				this.border_2 = (Border)target;
				return;
			case 7:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 8:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 9:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 10:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 11:
				this.textBlock_4 = (TextBlock)target;
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
				this.textBlock_5 = (TextBlock)target;
				return;
			case 15:
				this.blurEffect_0 = (BlurEffect)target;
				return;
			case 16:
				this.textBlock_6 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x000ACD7C File Offset: 0x000AAF7C
		private void method_3()
		{
			this.textBlock_0.Text = Class533.float_4.smethod_12() + " MB";
			this.textBlock_1.Text = Class533.float_0.smethod_12() + " MB";
			this.textBlock_2.Text = Class533.float_1.smethod_12() + " MB";
			this.textBlock_3.Text = Class533.float_2.smethod_12() + " MB";
			this.textBlock_4.Text = Class533.float_3.smethod_12() + " MB";
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.border_2, TimeSpan.FromSeconds(0.5), FrameworkElement.WidthProperty, (double)(Class533.float_0 / Class533.float_4) * this.border_0.ActualWidth);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.border_1, TimeSpan.FromSeconds(0.5), FrameworkElement.WidthProperty, (double)((Class533.float_0 + Class533.float_1) / Class533.float_4) * this.border_0.ActualWidth);
		}

		// Token: 0x04001E34 RID: 7732
		public static float float_0;

		// Token: 0x04001E35 RID: 7733
		public static float float_1;

		// Token: 0x04001E36 RID: 7734
		public static float float_2;

		// Token: 0x04001E37 RID: 7735
		public static float float_3;

		// Token: 0x04001E38 RID: 7736
		public static float float_4;

		// Token: 0x04001E39 RID: 7737
		internal StackPanel stackPanel_0;

		// Token: 0x04001E3A RID: 7738
		internal Border border_0;

		// Token: 0x04001E3B RID: 7739
		internal RectangleGeometry rectangleGeometry_0;

		// Token: 0x04001E3C RID: 7740
		internal Border border_1;

		// Token: 0x04001E3D RID: 7741
		internal Border border_2;

		// Token: 0x04001E3E RID: 7742
		internal TextBlock textBlock_0;

		// Token: 0x04001E3F RID: 7743
		internal TextBlock textBlock_1;

		// Token: 0x04001E40 RID: 7744
		internal TextBlock textBlock_2;

		// Token: 0x04001E41 RID: 7745
		internal TextBlock textBlock_3;

		// Token: 0x04001E42 RID: 7746
		internal TextBlock textBlock_4;

		// Token: 0x04001E43 RID: 7747
		internal Button button_0;

		// Token: 0x04001E44 RID: 7748
		internal Button button_1;

		// Token: 0x04001E45 RID: 7749
		internal TextBlock textBlock_5;

		// Token: 0x04001E46 RID: 7750
		internal BlurEffect blurEffect_0;

		// Token: 0x04001E47 RID: 7751
		internal TextBlock textBlock_6;

		// Token: 0x04001E48 RID: 7752
		private bool bool_0;

		// Token: 0x020007AB RID: 1963
		[StructLayout(LayoutKind.Auto)]
		private struct Struct542 : IAsyncStateMachine
		{
			// Token: 0x06002854 RID: 10324 RVA: 0x000ACEBC File Offset: 0x000AB0BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd = this.dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Dispatcher.InvokeAsync(new Action(dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.method_3)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Struct542>(ref awaiter, ref this);
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

			// Token: 0x06002855 RID: 10325 RVA: 0x000ACF80 File Offset: 0x000AB180
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E49 RID: 7753
			public int int_0;

			// Token: 0x04001E4A RID: 7754
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001E4B RID: 7755
			public dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0;

			// Token: 0x04001E4C RID: 7756
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007AC RID: 1964
		[StructLayout(LayoutKind.Auto)]
		private struct Struct543 : IAsyncStateMachine
		{
			// Token: 0x06002856 RID: 10326 RVA: 0x000ACF90 File Offset: 0x000AB190
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd = this.dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_187;
					}
					if (num != 1)
					{
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.textBlock_5, Class364.smethod_0("Cleaning"));
						dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.button_1.IsEnabled = false;
						IEnumerator<Process> enumerator = Process.GetProcesses().Where(new Func<Process, bool>(dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Class835.class835_0.method_0)).GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Process process = enumerator.Current;
								try
								{
									Process process2 = process;
									try
									{
										if (!process.HasExited && Class244.EmptyWorkingSet(process.Handle) == 0)
										{
											throw new Win32Exception(Marshal.GetLastWin32Error());
										}
									}
									finally
									{
										if (num < 0 && process2 != null)
										{
											((IDisposable)process2).Dispose();
										}
									}
								}
								catch (object obj)
								{
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						awaiter = Task.Delay(2000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.int_0 = num3;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Struct543>(ref awaiter, ref this);
							return;
						}
						goto IL_187;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num4 = -1;
						num = -1;
						this.int_0 = num4;
					}
					IL_14F:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.textBlock_5, string.Empty);
					goto IL_20A;
					IL_187:
					awaiter.GetResult();
					dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.button_1.IsEnabled = true;
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.textBlock_5, Class364.smethod_0("Finished"));
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num5 = 1;
						num = 1;
						this.int_0 = num5;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Struct543>(ref awaiter, ref this);
						return;
					}
					goto IL_14F;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_20A:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002857 RID: 10327 RVA: 0x000AD220 File Offset: 0x000AB420
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E4D RID: 7757
			public int int_0;

			// Token: 0x04001E4E RID: 7758
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001E4F RID: 7759
			public dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0;

			// Token: 0x04001E50 RID: 7760
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007AD RID: 1965
		[Serializable]
		private sealed class Class835
		{
			// Token: 0x0600285A RID: 10330 RVA: 0x000AD244 File Offset: 0x000AB444
			internal bool method_0(Process process_0)
			{
				return process_0 != null;
			}

			// Token: 0x04001E51 RID: 7761
			public static readonly dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Class835 class835_0 = new dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Class835();

			// Token: 0x04001E52 RID: 7762
			public static Func<Process, bool> func_0;
		}

		// Token: 0x020007AE RID: 1966
		[StructLayout(LayoutKind.Auto)]
		private struct Struct544 : IAsyncStateMachine
		{
			// Token: 0x0600285B RID: 10331 RVA: 0x000AD24C File Offset: 0x000AB44C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd = this.dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_D6;
					}
					if (num != 1)
					{
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.textBlock_5, Class364.smethod_0("Cleaning"));
						dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.button_0.IsEnabled = false;
						Class655.smethod_1();
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Struct544>(ref awaiter, ref this);
							return;
						}
						goto IL_D6;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_9E:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.textBlock_5, string.Empty);
					goto IL_157;
					IL_D6:
					awaiter.GetResult();
					dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.button_0.IsEnabled = true;
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.textBlock_5, Class364.smethod_0("Finished"));
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd.Struct544>(ref awaiter, ref this);
						return;
					}
					goto IL_9E;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_157:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600285C RID: 10332 RVA: 0x000AD3E0 File Offset: 0x000AB5E0
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E53 RID: 7763
			public int int_0;

			// Token: 0x04001E54 RID: 7764
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001E55 RID: 7765
			public dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0;

			// Token: 0x04001E56 RID: 7766
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
