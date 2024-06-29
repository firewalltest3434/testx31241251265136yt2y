using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Effects;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x02000810 RID: 2064
	public sealed class dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002A2B RID: 10795 RVA: 0x000B5B3C File Offset: 0x000B3D3C
		public dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd()
		{
			this.InitializeComponent();
			Class253.smethod_0(new Class253.Delegate24(this.method_0));
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x000B5B5C File Offset: 0x000B3D5C
		private void method_0()
		{
			dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd.Struct578 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd.Struct578>(ref @struct);
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000B5B94 File Offset: 0x000B3D94
		private void method_1(object sender, DependencyPropertyChangedEventArgs p1)
		{
			bool? flag = Class389.class504_0.method_28();
			if (!(flag.GetValueOrDefault() & flag != null))
			{
				this.blurEffect_0.Radius = 15.0;
				this.blurEffect_1.Radius = 15.0;
				this.stackPanel_0.Opacity = 0.3;
				this.stackPanel_1.Opacity = 0.3;
				this.textBlock_4.Opacity = 1.0;
				this.textBlock_9.Opacity = 1.0;
				this.textBlock_4.Visibility = Visibility.Visible;
				this.textBlock_9.Visibility = Visibility.Visible;
				return;
			}
			this.blurEffect_0.Radius = 0.0;
			this.blurEffect_1.Radius = 0.0;
			this.stackPanel_0.Opacity = 1.0;
			this.stackPanel_1.Opacity = 1.0;
			this.textBlock_4.Opacity = 0.0;
			this.textBlock_9.Opacity = 0.0;
			this.textBlock_4.Visibility = Visibility.Collapsed;
			this.textBlock_9.Visibility = Visibility.Collapsed;
			if (base.IsVisible)
			{
				Class253.smethod_5();
				return;
			}
			Class253.smethod_6();
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x000B5CF8 File Offset: 0x000B3EF8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/cpucpuuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x000B5D28 File Offset: 0x000B3F28
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_2(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x000B5D34 File Offset: 0x000B3F34
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd)target).IsVisibleChanged += this.method_1;
				return;
			case 2:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 3:
				this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0 = (dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd)target;
				return;
			case 4:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 5:
				this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_1 = (dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd)target;
				return;
			case 6:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 7:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 8:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 9:
				this.blurEffect_0 = (BlurEffect)target;
				return;
			case 10:
				this.textBlock_4 = (TextBlock)target;
				return;
			case 11:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 12:
				this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_2 = (dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd)target;
				return;
			case 13:
				this.textBlock_5 = (TextBlock)target;
				return;
			case 14:
				this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_3 = (dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd)target;
				return;
			case 15:
				this.textBlock_6 = (TextBlock)target;
				return;
			case 16:
				this.textBlock_7 = (TextBlock)target;
				return;
			case 17:
				this.textBlock_8 = (TextBlock)target;
				return;
			case 18:
				this.blurEffect_1 = (BlurEffect)target;
				return;
			case 19:
				this.textBlock_9 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x000B5EA0 File Offset: 0x000B40A0
		private void method_3()
		{
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, (double)Class253.float_0 * 3.6);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_36(this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0, Class253.float_0);
			this.textBlock_0.Text = Class253.float_0.ToString();
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_1.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, (double)Class253.float_1 * 3.6);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_36(this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_1, Class253.float_1);
			this.textBlock_1.Text = (Class253.float_1.ToString().Replace(',', '.').Contains(".") ? Class253.float_1.ToString().Substring(0, Class253.float_1.ToString().Replace(',', '.').IndexOf('.')) : Class253.float_1.ToString());
			this.textBlock_3.Text = Class253.float_2.ToString().Replace(',', '.').Split(new char[]
			{
				'.'
			})[0];
			this.textBlock_2.Text = Class253.float_3.ToString().Replace(',', '.').Split(new char[]
			{
				'.'
			})[0];
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_2.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, (double)Class253.float_4 * 3.6);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_36(this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_2, Class253.float_4);
			this.textBlock_5.Text = Class253.float_4.ToString();
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_3.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, (double)Class253.float_5 * 3.6);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_36(this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_3, Class253.float_5);
			this.textBlock_6.Text = (Class253.float_5.ToString().Replace(',', '.').Contains(".") ? Class253.float_5.ToString().Substring(0, Class253.float_5.ToString().Replace(',', '.').IndexOf('.')) : Class253.float_5.ToString());
			this.textBlock_8.Text = Class253.float_7.ToString().Replace(',', '.').Split(new char[]
			{
				'.'
			})[0];
			this.textBlock_7.Text = Class253.float_6.ToString().Replace(',', '.').Split(new char[]
			{
				'.'
			})[0];
		}

		// Token: 0x0400202C RID: 8236
		internal StackPanel stackPanel_0;

		// Token: 0x0400202D RID: 8237
		internal dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0;

		// Token: 0x0400202E RID: 8238
		internal TextBlock textBlock_0;

		// Token: 0x0400202F RID: 8239
		internal dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_1;

		// Token: 0x04002030 RID: 8240
		internal TextBlock textBlock_1;

		// Token: 0x04002031 RID: 8241
		internal TextBlock textBlock_2;

		// Token: 0x04002032 RID: 8242
		internal TextBlock textBlock_3;

		// Token: 0x04002033 RID: 8243
		internal BlurEffect blurEffect_0;

		// Token: 0x04002034 RID: 8244
		internal TextBlock textBlock_4;

		// Token: 0x04002035 RID: 8245
		internal StackPanel stackPanel_1;

		// Token: 0x04002036 RID: 8246
		internal dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_2;

		// Token: 0x04002037 RID: 8247
		internal TextBlock textBlock_5;

		// Token: 0x04002038 RID: 8248
		internal dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_3;

		// Token: 0x04002039 RID: 8249
		internal TextBlock textBlock_6;

		// Token: 0x0400203A RID: 8250
		internal TextBlock textBlock_7;

		// Token: 0x0400203B RID: 8251
		internal TextBlock textBlock_8;

		// Token: 0x0400203C RID: 8252
		internal BlurEffect blurEffect_1;

		// Token: 0x0400203D RID: 8253
		internal TextBlock textBlock_9;

		// Token: 0x0400203E RID: 8254
		private bool bool_0;

		// Token: 0x02000811 RID: 2065
		[StructLayout(LayoutKind.Auto)]
		private struct Struct578 : IAsyncStateMachine
		{
			// Token: 0x06002A32 RID: 10802 RVA: 0x000B6178 File Offset: 0x000B4378
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd = this.dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd.Dispatcher.InvokeAsync(new Action(dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd.method_3)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd.Struct578>(ref awaiter, ref this);
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

			// Token: 0x06002A33 RID: 10803 RVA: 0x000B623C File Offset: 0x000B443C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400203F RID: 8255
			public int int_0;

			// Token: 0x04002040 RID: 8256
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002041 RID: 8257
			public dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd_0;

			// Token: 0x04002042 RID: 8258
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
