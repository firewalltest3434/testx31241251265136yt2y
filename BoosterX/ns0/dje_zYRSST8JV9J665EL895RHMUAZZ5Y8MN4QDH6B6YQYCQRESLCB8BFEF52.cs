using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Effects;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x02000819 RID: 2073
	public sealed class dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002A56 RID: 10838 RVA: 0x000B6A98 File Offset: 0x000B4C98
		public dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_Loaded;
			base.DataContext = Class410.list_0;
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x000B6AC4 File Offset: 0x000B4CC4
		private void dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Struct582 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Struct582>(ref @struct);
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x000B6AFC File Offset: 0x000B4CFC
		private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs p1)
		{
			try
			{
				this.method_0(this.comboBox_0.SelectedIndex);
			}
			catch (object obj)
			{
			}
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x000B6B30 File Offset: 0x000B4D30
		private void method_0(int int_0)
		{
			dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Struct581 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0 = this;
			@struct.int_1 = int_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Struct581>(ref @struct);
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x000B6B70 File Offset: 0x000B4D70
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Struct580 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Struct580>(ref @struct);
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x000B6BA8 File Offset: 0x000B4DA8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/diskreviewandcleantrash.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x000B6BD8 File Offset: 0x000B4DD8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.grid_0 = (Grid)target;
				return;
			case 2:
				this.comboBox_0 = (ComboBox)target;
				this.comboBox_0.SelectionChanged += this.comboBox_0_SelectionChanged;
				return;
			case 3:
				this.arc_0 = (Arc)target;
				return;
			case 4:
				this.arc_1 = (Arc)target;
				return;
			case 5:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 6:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 7:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 8:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 9:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 10:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 11:
				this.blurEffect_0 = (BlurEffect)target;
				return;
			case 12:
				this.textBlock_4 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002066 RID: 8294
		internal Grid grid_0;

		// Token: 0x04002067 RID: 8295
		internal ComboBox comboBox_0;

		// Token: 0x04002068 RID: 8296
		internal Arc arc_0;

		// Token: 0x04002069 RID: 8297
		internal Arc arc_1;

		// Token: 0x0400206A RID: 8298
		internal StackPanel stackPanel_0;

		// Token: 0x0400206B RID: 8299
		internal TextBlock textBlock_0;

		// Token: 0x0400206C RID: 8300
		internal TextBlock textBlock_1;

		// Token: 0x0400206D RID: 8301
		internal TextBlock textBlock_2;

		// Token: 0x0400206E RID: 8302
		internal TextBlock textBlock_3;

		// Token: 0x0400206F RID: 8303
		internal Button button_0;

		// Token: 0x04002070 RID: 8304
		internal BlurEffect blurEffect_0;

		// Token: 0x04002071 RID: 8305
		internal TextBlock textBlock_4;

		// Token: 0x04002072 RID: 8306
		private bool bool_0;

		// Token: 0x0200081A RID: 2074
		[StructLayout(LayoutKind.Auto)]
		private struct Struct580 : IAsyncStateMachine
		{
			// Token: 0x06002A5D RID: 10845 RVA: 0x000B6CF0 File Offset: 0x000B4EF0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd = this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_E6;
					}
					if (num != 1)
					{
						dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.button_0.IsEnabled = false;
						awaiter = Task.Run(new Func<Task>(dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Class852.class852_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Struct580>(ref awaiter, ref this);
							return;
						}
						goto IL_E6;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_A1:
					awaiter.GetResult();
					dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.button_0.IsEnabled = true;
					dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.method_0(dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.comboBox_0.SelectedIndex);
					goto IL_146;
					IL_E6:
					awaiter.GetResult();
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Struct580>(ref awaiter, ref this);
						return;
					}
					goto IL_A1;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_146:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002A5E RID: 10846 RVA: 0x000B6E74 File Offset: 0x000B5074
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002073 RID: 8307
			public int int_0;

			// Token: 0x04002074 RID: 8308
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002075 RID: 8309
			public dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0;

			// Token: 0x04002076 RID: 8310
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200081B RID: 2075
		[Serializable]
		private sealed class Class852
		{
			// Token: 0x06002A61 RID: 10849 RVA: 0x000B6E98 File Offset: 0x000B5098
			internal Task method_0()
			{
				return Class655.smethod_0();
			}

			// Token: 0x04002077 RID: 8311
			public static readonly dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Class852 class852_0 = new dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Class852();

			// Token: 0x04002078 RID: 8312
			public static Func<Task> func_0;
		}

		// Token: 0x0200081C RID: 2076
		[StructLayout(LayoutKind.Auto)]
		private struct Struct581 : IAsyncStateMachine
		{
			// Token: 0x06002A62 RID: 10850 RVA: 0x000B6EA0 File Offset: 0x000B50A0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd = this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class853_0 = new dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Class853();
						this.class853_0.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0 = this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0;
						this.class853_0.int_0 = this.int_1;
						awaiter = Class410.smethod_2(this.class853_0.int_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Struct581>(ref awaiter, ref this);
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
					dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Dispatcher.Invoke(new Action(this.class853_0.method_0));
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class853_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class853_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002A63 RID: 10851 RVA: 0x000B6FB4 File Offset: 0x000B51B4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002079 RID: 8313
			public int int_0;

			// Token: 0x0400207A RID: 8314
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400207B RID: 8315
			public dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0;

			// Token: 0x0400207C RID: 8316
			public int int_1;

			// Token: 0x0400207D RID: 8317
			private dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Class853 class853_0;

			// Token: 0x0400207E RID: 8318
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200081D RID: 2077
		[StructLayout(LayoutKind.Auto)]
		private struct Struct582 : IAsyncStateMachine
		{
			// Token: 0x06002A64 RID: 10852 RVA: 0x000B6FC4 File Offset: 0x000B51C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd = this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						bool? flag = Class389.class504_0.method_36();
						if (!(flag.GetValueOrDefault() & flag != null))
						{
							dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.blurEffect_0.Radius = 15.0;
							dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.grid_0.Opacity = 0.3;
							dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.textBlock_4.Opacity = 1.0;
							dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.grid_0.IsEnabled = false;
							dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.textBlock_4.Visibility = Visibility.Visible;
							goto IL_163;
						}
						dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.blurEffect_0.Radius = 0.0;
						dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.grid_0.Opacity = 1.0;
						dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.textBlock_4.Opacity = 0.0;
						dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.grid_0.IsEnabled = true;
						dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.textBlock_4.Visibility = Visibility.Collapsed;
						awaiter = Class410.smethod_1().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.Struct582>(ref awaiter, ref this);
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
					dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd.comboBox_0.SelectedIndex = 0;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_163:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002A65 RID: 10853 RVA: 0x000B7164 File Offset: 0x000B5364
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400207F RID: 8319
			public int int_0;

			// Token: 0x04002080 RID: 8320
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002081 RID: 8321
			public dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0;

			// Token: 0x04002082 RID: 8322
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200081E RID: 2078
		private sealed class Class853
		{
			// Token: 0x06002A67 RID: 10855 RVA: 0x000B717C File Offset: 0x000B537C
			internal void method_0()
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0.textBlock_1, string.Format("{0:0.## GB}", Class410.list_0[this.int_0].method_2()));
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0.textBlock_3, string.Format("{0:0.## GB}", Class410.list_0[this.int_0].method_4()));
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0.textBlock_0, (100.0 - Class410.list_0[this.int_0].method_4() / Class410.list_0[this.int_0].method_2() * 100.0).ToString().Replace('.', ',').Split(new char[]
				{
					','
				})[0] + "%");
				if (this.int_0 == 0)
				{
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0.textBlock_2, string.Format("{0:0.## GB}", Class410.list_0[this.int_0].method_6()));
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0.arc_0, TimeSpan.FromSeconds(0.2), Arc.EndAngleProperty, Class410.list_0[this.int_0].method_4() / Class410.list_0[this.int_0].method_2() * 100.0 * 3.6);
				}
				else
				{
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0.textBlock_2, string.Format("{0:0.## GB}", 0));
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0.textBlock_3, "0 GB");
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0.arc_0, TimeSpan.FromSeconds(0.2), Arc.EndAngleProperty, 0.0);
				}
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0.arc_1, TimeSpan.FromSeconds(0.2), Arc.EndAngleProperty, Class410.list_0[this.int_0].method_4() / Class410.list_0[this.int_0].method_2() * 100.0 * 3.6);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0.arc_1, TimeSpan.FromSeconds(0.2), Arc.EndAngleProperty, Class410.list_0[this.int_0].method_4() / Class410.list_0[this.int_0].method_2() * 100.0 * 3.6);
			}

			// Token: 0x04002083 RID: 8323
			public dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd dje_zYRSST8JV9J665EL895RHMUAZZ5Y8MN4QDH6B6YQYCQRESLCB8BFEF52ZAQDW654SMQ_ejd_0;

			// Token: 0x04002084 RID: 8324
			public int int_0;
		}
	}
}
