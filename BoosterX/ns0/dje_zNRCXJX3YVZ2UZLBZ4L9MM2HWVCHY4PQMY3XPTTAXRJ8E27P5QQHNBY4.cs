using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x020007CA RID: 1994
	public sealed class dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060028F3 RID: 10483 RVA: 0x000AFC60 File Offset: 0x000ADE60
		public dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd()
		{
			this.InitializeComponent();
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_16(new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42(this.method_1));
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_14(new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43(this.method_2));
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000AFC90 File Offset: 0x000ADE90
		private void method_0(object sender, RoutedEventArgs p1)
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_18();
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x000AFC98 File Offset: 0x000ADE98
		private void method_1()
		{
			dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Struct558 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Struct558>(ref @struct);
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000AFCD0 File Offset: 0x000ADED0
		private void method_2()
		{
			dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Struct557 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Struct557>(ref @struct);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x000AFD08 File Offset: 0x000ADF08
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/optlevelmainpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x000AFD38 File Offset: 0x000ADF38
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd)target).Loaded += this.method_0;
				return;
			case 2:
				this.arc_0 = (Arc)target;
				return;
			case 3:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 4:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 5:
				this.textBlock_2 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x000AFDB4 File Offset: 0x000ADFB4
		private void method_3()
		{
			this.textBlock_0.Text = "0";
			this.textBlock_0.Foreground = Brushes.White;
			this.textBlock_1.Foreground = Brushes.White;
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_37(this.arc_0, 0f);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.arc_0, TimeSpan.FromSeconds(0.1), Arc.EndAngleProperty, 0.0);
			this.textBlock_2.Text = Class364.smethod_0("Checkingtext");
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000AFE44 File Offset: 0x000AE044
		private Task method_4()
		{
			dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Struct559 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Struct559>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001EE2 RID: 7906
		internal Arc arc_0;

		// Token: 0x04001EE3 RID: 7907
		internal TextBlock textBlock_0;

		// Token: 0x04001EE4 RID: 7908
		internal TextBlock textBlock_1;

		// Token: 0x04001EE5 RID: 7909
		internal TextBlock textBlock_2;

		// Token: 0x04001EE6 RID: 7910
		private bool bool_0;

		// Token: 0x020007CB RID: 1995
		[StructLayout(LayoutKind.Auto)]
		private struct Struct557 : IAsyncStateMachine
		{
			// Token: 0x060028FB RID: 10491 RVA: 0x000AFE88 File Offset: 0x000AE088
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd = this.dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd_0;
				try
				{
					TaskAwaiter<Task> awaiter;
					if (num != 0)
					{
						if (!dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.IsVisible)
						{
							goto IL_A1;
						}
						awaiter = dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Dispatcher.InvokeAsync<Task>(new Func<Task>(dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.method_4)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Struct557>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Task>);
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
				IL_A1:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060028FC RID: 10492 RVA: 0x000AFF5C File Offset: 0x000AE15C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EE7 RID: 7911
			public int int_0;

			// Token: 0x04001EE8 RID: 7912
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001EE9 RID: 7913
			public dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd_0;

			// Token: 0x04001EEA RID: 7914
			private TaskAwaiter<Task> taskAwaiter_0;
		}

		// Token: 0x020007CC RID: 1996
		[StructLayout(LayoutKind.Auto)]
		private struct Struct558 : IAsyncStateMachine
		{
			// Token: 0x060028FD RID: 10493 RVA: 0x000AFF6C File Offset: 0x000AE16C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd = this.dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.IsVisible)
						{
							goto IL_A0;
						}
						awaiter = dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Dispatcher.InvokeAsync(new Action(dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.method_3)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Struct558>(ref awaiter, ref this);
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
				IL_A0:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060028FE RID: 10494 RVA: 0x000B003C File Offset: 0x000AE23C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EEB RID: 7915
			public int int_0;

			// Token: 0x04001EEC RID: 7916
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001EED RID: 7917
			public dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd_0;

			// Token: 0x04001EEE RID: 7918
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007CD RID: 1997
		[StructLayout(LayoutKind.Auto)]
		private struct Struct559 : IAsyncStateMachine
		{
			// Token: 0x060028FF RID: 10495 RVA: 0x000B004C File Offset: 0x000AE24C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd = this.dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_BE;
					}
					if (num != 1)
					{
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Struct559>(ref awaiter, ref this);
							return;
						}
						goto IL_BE;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_75:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_39(dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.textBlock_2, this.double_0);
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.string_3 = dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.textBlock_0.Text;
					goto IL_1A3;
					IL_BE:
					awaiter.GetResult();
					this.double_0 = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.double_0;
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_40(dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.textBlock_0, this.double_0);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_38(dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.textBlock_0, (float)this.double_0);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_38(dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.textBlock_1, (float)this.double_0);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.arc_0, TimeSpan.FromSeconds(3.0), Arc.EndAngleProperty, this.double_0 * 3.6);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_37(dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.arc_0, (float)this.double_0);
					awaiter = Task.Delay(3000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd.Struct559>(ref awaiter, ref this);
						return;
					}
					goto IL_75;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1A3:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06002900 RID: 10496 RVA: 0x000B022C File Offset: 0x000AE42C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EEF RID: 7919
			public int int_0;

			// Token: 0x04001EF0 RID: 7920
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001EF1 RID: 7921
			public dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd dje_zNRCXJX3YVZ2UZLBZ4L9MM2HWVCHY4PQMY3XPTTAXRJ8E27P5QQHNBY44TMAA_ejd_0;

			// Token: 0x04001EF2 RID: 7922
			private double double_0;

			// Token: 0x04001EF3 RID: 7923
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
