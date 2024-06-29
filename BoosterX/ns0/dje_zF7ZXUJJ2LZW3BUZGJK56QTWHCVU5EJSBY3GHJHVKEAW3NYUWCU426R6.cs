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

namespace ns0
{
	// Token: 0x0200077E RID: 1918
	public sealed class dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002785 RID: 10117 RVA: 0x000A79F0 File Offset: 0x000A5BF0
		public dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x000A7A14 File Offset: 0x000A5C14
		private void method_0(object sender, MouseEventArgs p1)
		{
			dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd.Struct519 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd_0 = this;
			@struct.mouseEventArgs_0 = p1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd.Struct519>(ref @struct);
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000A7A54 File Offset: 0x000A5C54
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/appspageucs/bignicebutton.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x000A7A84 File Offset: 0x000A5C84
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Grid)target).MouseMove += this.method_0;
				return;
			case 2:
				this.border_0 = (Border)target;
				return;
			case 3:
				this.radialGradientBrush_0 = (RadialGradientBrush)target;
				return;
			case 4:
				this.button_0 = (Button)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001D3C RID: 7484
		private readonly object object_0 = new object();

		// Token: 0x04001D3D RID: 7485
		private DateTime dateTime_0 = DateTime.MinValue;

		// Token: 0x04001D3E RID: 7486
		internal Border border_0;

		// Token: 0x04001D3F RID: 7487
		internal RadialGradientBrush radialGradientBrush_0;

		// Token: 0x04001D40 RID: 7488
		internal Button button_0;

		// Token: 0x04001D41 RID: 7489
		private bool bool_0;

		// Token: 0x0200077F RID: 1919
		[StructLayout(LayoutKind.Auto)]
		private struct Struct519 : IAsyncStateMachine
		{
			// Token: 0x06002789 RID: 10121 RVA: 0x000A7AF0 File Offset: 0x000A5CF0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd = this.dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						object object_ = dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd.object_0;
						bool flag = false;
						try
						{
							Monitor.Enter(object_, ref flag);
							DateTime now = DateTime.Now;
							if ((now - dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd.dateTime_0).TotalMilliseconds < 16.0)
							{
								goto IL_148;
							}
							dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd.dateTime_0 = now;
						}
						finally
						{
							if (num < 0 && flag)
							{
								Monitor.Exit(object_);
							}
						}
						Point position = this.mouseEventArgs_0.GetPosition(dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd.button_0);
						double x = position.X;
						double y = position.Y;
						double x2 = x / dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd.border_0.Width;
						double y2 = y / dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd.border_0.Height;
						dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd.radialGradientBrush_0.GradientOrigin = new Point(x2, y2);
						dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd.radialGradientBrush_0.Center = new Point(x2, y2);
						awaiter = Task.Delay(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd.Struct519>(ref awaiter, ref this);
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

			// Token: 0x0600278A RID: 10122 RVA: 0x000A7C8C File Offset: 0x000A5E8C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D42 RID: 7490
			public int int_0;

			// Token: 0x04001D43 RID: 7491
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D44 RID: 7492
			public dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd dje_zF7ZXUJJ2LZW3BUZGJK56QTWHCVU5EJSBY3GHJHVKEAW3NYUWCU426R6HKL5Q_ejd_0;

			// Token: 0x04001D45 RID: 7493
			public MouseEventArgs mouseEventArgs_0;

			// Token: 0x04001D46 RID: 7494
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
