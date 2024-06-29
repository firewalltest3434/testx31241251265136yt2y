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
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x020007B4 RID: 1972
	public sealed class dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002871 RID: 10353 RVA: 0x000AD758 File Offset: 0x000AB958
		public dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd()
		{
			this.InitializeComponent();
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_16(new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42(this.method_0));
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_14(new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43(this.method_1));
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x000AD788 File Offset: 0x000AB988
		private void method_0()
		{
			dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Struct547 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Struct547>(ref @struct);
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x000AD7C0 File Offset: 0x000AB9C0
		private void method_1()
		{
			dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Struct545 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Struct545>(ref @struct);
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x000AD7F8 File Offset: 0x000AB9F8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/optlevelucs/fatoptlevel.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x000AD828 File Offset: 0x000ABA28
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_2(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000AD834 File Offset: 0x000ABA34
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 2:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 3:
				this.ellipse_0 = (Ellipse)target;
				return;
			case 4:
				this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0 = (dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x000AD894 File Offset: 0x000ABA94
		private void method_3()
		{
			this.textBlock_0.Text = "0";
			this.textBlock_0.Foreground = Brushes.White;
			this.textBlock_1.Foreground = Brushes.White;
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_37(this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0.arc_0, 0f);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0.arc_0, TimeSpan.FromSeconds(0.1), Arc.EndAngleProperty, 0.0);
			((Storyboard)this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0.Resources["HideShadow"]).Begin();
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x000AD938 File Offset: 0x000ABB38
		private Task method_4()
		{
			dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Struct546 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Struct546>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001E64 RID: 7780
		internal TextBlock textBlock_0;

		// Token: 0x04001E65 RID: 7781
		internal TextBlock textBlock_1;

		// Token: 0x04001E66 RID: 7782
		internal Ellipse ellipse_0;

		// Token: 0x04001E67 RID: 7783
		internal dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0;

		// Token: 0x04001E68 RID: 7784
		private bool bool_0;

		// Token: 0x020007B5 RID: 1973
		[StructLayout(LayoutKind.Auto)]
		private struct Struct545 : IAsyncStateMachine
		{
			// Token: 0x06002879 RID: 10361 RVA: 0x000AD97C File Offset: 0x000ABB7C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd = this.dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd_0;
				try
				{
					TaskAwaiter<Task> awaiter;
					if (num != 0)
					{
						awaiter = dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Dispatcher.InvokeAsync<Task>(new Func<Task>(dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.method_4)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Struct545>(ref awaiter, ref this);
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
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600287A RID: 10362 RVA: 0x000ADA40 File Offset: 0x000ABC40
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E69 RID: 7785
			public int int_0;

			// Token: 0x04001E6A RID: 7786
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001E6B RID: 7787
			public dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd_0;

			// Token: 0x04001E6C RID: 7788
			private TaskAwaiter<Task> taskAwaiter_0;
		}

		// Token: 0x020007B6 RID: 1974
		[StructLayout(LayoutKind.Auto)]
		private struct Struct546 : IAsyncStateMachine
		{
			// Token: 0x0600287B RID: 10363 RVA: 0x000ADA50 File Offset: 0x000ABC50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd = this.dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_BC;
					}
					if (num != 1)
					{
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Struct546>(ref awaiter, ref this);
							return;
						}
						goto IL_BC;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_75:
					awaiter.GetResult();
					((Storyboard)dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0.Resources["ShowShadow"]).Begin();
					goto IL_18A;
					IL_BC:
					awaiter.GetResult();
					double double_ = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.double_0;
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_40(dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.textBlock_0, double_);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_38(dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.textBlock_0, (float)double_);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_38(dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.textBlock_1, (float)double_);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0.arc_0, TimeSpan.FromSeconds(3.0), Arc.EndAngleProperty, double_ * 3.6);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_36(dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0, (float)double_);
					awaiter = Task.Delay(3000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Struct546>(ref awaiter, ref this);
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
				IL_18A:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x0600287C RID: 10364 RVA: 0x000ADC18 File Offset: 0x000ABE18
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E6D RID: 7789
			public int int_0;

			// Token: 0x04001E6E RID: 7790
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001E6F RID: 7791
			public dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd_0;

			// Token: 0x04001E70 RID: 7792
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007B7 RID: 1975
		[StructLayout(LayoutKind.Auto)]
		private struct Struct547 : IAsyncStateMachine
		{
			// Token: 0x0600287D RID: 10365 RVA: 0x000ADC28 File Offset: 0x000ABE28
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd = this.dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Dispatcher.InvokeAsync(new Action(dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.method_3)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd.Struct547>(ref awaiter, ref this);
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

			// Token: 0x0600287E RID: 10366 RVA: 0x000ADCEC File Offset: 0x000ABEEC
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E71 RID: 7793
			public int int_0;

			// Token: 0x04001E72 RID: 7794
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001E73 RID: 7795
			public dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd dje_zM7VSBNUZX8CN4EHBVCUW9WX3JP74HJ4KFJBTFZTGBB3XYBWU4JLU999QL88A_ejd_0;

			// Token: 0x04001E74 RID: 7796
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
