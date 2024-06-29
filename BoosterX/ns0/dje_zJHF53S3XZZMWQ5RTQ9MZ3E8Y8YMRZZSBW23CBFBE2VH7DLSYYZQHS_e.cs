using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace ns0
{
	// Token: 0x020007A7 RID: 1959
	public sealed class dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002842 RID: 10306 RVA: 0x000AC518 File Offset: 0x000AA718
		public dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x000AC554 File Offset: 0x000AA754
		private void button_0_MouseMove(object sender, MouseEventArgs p1)
		{
			dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.Struct541 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd_0 = this;
			@struct.mouseEventArgs_0 = p1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.Struct541>(ref @struct);
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x000AC594 File Offset: 0x000AA794
		private void button_0_MouseLeave(object sender, MouseEventArgs p1)
		{
			dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.Struct540 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.Struct540>(ref @struct);
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x000AC5CC File Offset: 0x000AA7CC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/buttonsucs/coolbutton.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x000AC5FC File Offset: 0x000AA7FC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.border_0 = (Border)target;
				return;
			case 2:
				this.radialGradientBrush_0 = (RadialGradientBrush)target;
				return;
			case 3:
				this.button_0 = (Button)target;
				this.button_0.MouseLeave += this.button_0_MouseLeave;
				this.button_0.MouseMove += this.button_0_MouseMove;
				return;
			case 4:
				this.dropShadowEffect_0 = (DropShadowEffect)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001E22 RID: 7714
		private readonly object object_0 = new object();

		// Token: 0x04001E23 RID: 7715
		private DateTime dateTime_0 = DateTime.MinValue;

		// Token: 0x04001E24 RID: 7716
		private readonly object object_1 = new object();

		// Token: 0x04001E25 RID: 7717
		private DateTime dateTime_1 = DateTime.MinValue;

		// Token: 0x04001E26 RID: 7718
		internal Border border_0;

		// Token: 0x04001E27 RID: 7719
		internal RadialGradientBrush radialGradientBrush_0;

		// Token: 0x04001E28 RID: 7720
		internal Button button_0;

		// Token: 0x04001E29 RID: 7721
		internal DropShadowEffect dropShadowEffect_0;

		// Token: 0x04001E2A RID: 7722
		private bool bool_0;

		// Token: 0x020007A8 RID: 1960
		[StructLayout(LayoutKind.Auto)]
		private struct Struct540 : IAsyncStateMachine
		{
			// Token: 0x06002847 RID: 10311 RVA: 0x000AC68C File Offset: 0x000AA88C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd = this.dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						object object_ = dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.object_1;
						bool flag = false;
						try
						{
							Monitor.Enter(object_, ref flag);
							DateTime now = DateTime.Now;
							if ((now - dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.dateTime_1).TotalMilliseconds < 16.0)
							{
								goto IL_123;
							}
							dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.dateTime_1 = now;
						}
						finally
						{
							if (num < 0 && flag)
							{
								Monitor.Exit(object_);
							}
						}
						dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.radialGradientBrush_0.GradientOrigin = new Point(0.5, 0.5);
						dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.radialGradientBrush_0.Center = new Point(0.5, 0.5);
						awaiter = Task.Delay(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.Struct540>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_123:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002848 RID: 10312 RVA: 0x000AC7EC File Offset: 0x000AA9EC
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E2B RID: 7723
			public int int_0;

			// Token: 0x04001E2C RID: 7724
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001E2D RID: 7725
			public dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd_0;

			// Token: 0x04001E2E RID: 7726
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007A9 RID: 1961
		[StructLayout(LayoutKind.Auto)]
		private struct Struct541 : IAsyncStateMachine
		{
			// Token: 0x06002849 RID: 10313 RVA: 0x000AC7FC File Offset: 0x000AA9FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd = this.dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						object object_ = dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.object_0;
						bool flag = false;
						try
						{
							Monitor.Enter(object_, ref flag);
							DateTime now = DateTime.Now;
							if ((now - dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.dateTime_0).TotalMilliseconds < 16.0)
							{
								goto IL_148;
							}
							dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.dateTime_0 = now;
						}
						finally
						{
							if (num < 0 && flag)
							{
								Monitor.Exit(object_);
							}
						}
						Point position = this.mouseEventArgs_0.GetPosition(dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.button_0);
						double x = position.X;
						double y = position.Y;
						double x2 = x / dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.button_0.Width;
						double y2 = y / dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.button_0.Height;
						dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.radialGradientBrush_0.GradientOrigin = new Point(x2, y2);
						dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.radialGradientBrush_0.Center = new Point(x2, y2);
						awaiter = Task.Delay(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd.Struct541>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_148:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600284A RID: 10314 RVA: 0x000AC998 File Offset: 0x000AAB98
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E2F RID: 7727
			public int int_0;

			// Token: 0x04001E30 RID: 7728
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001E31 RID: 7729
			public dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd dje_zJHF53S3XZZMWQ5RTQ9MZ3E8Y8YMRZZSBW23CBFBE2VH7DLSYYZQHS_ejd_0;

			// Token: 0x04001E32 RID: 7730
			public MouseEventArgs mouseEventArgs_0;

			// Token: 0x04001E33 RID: 7731
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
