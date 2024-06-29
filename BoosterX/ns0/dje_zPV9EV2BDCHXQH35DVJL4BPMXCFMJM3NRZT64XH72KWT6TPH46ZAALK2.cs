using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007D8 RID: 2008
	public sealed class dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd : Page, IComponentConnector
	{
		// Token: 0x06002932 RID: 10546 RVA: 0x000B1268 File Offset: 0x000AF468
		public dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x000B1280 File Offset: 0x000AF480
		public void method_0(bool bool_1)
		{
			dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.Struct565 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.Struct565>(ref @struct);
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x000B12C0 File Offset: 0x000AF4C0
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0(true);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000B12CC File Offset: 0x000AF4CC
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class683.smethod_6();
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000B12D4 File Offset: 0x000AF4D4
		public void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class683.smethod_4();
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000B12DC File Offset: 0x000AF4DC
		public void button_2_Click(object sender, RoutedEventArgs p1)
		{
			Class683.smethod_5(p1);
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000B12E4 File Offset: 0x000AF4E4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/winservices.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x000B1314 File Offset: 0x000AF514
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_1(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x000B1320 File Offset: 0x000AF520
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 2:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 3:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 4:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 5:
				this.dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0 = (dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd)target;
				return;
			case 6:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001F1F RID: 7967
		internal Button button_0;

		// Token: 0x04001F20 RID: 7968
		internal Button button_1;

		// Token: 0x04001F21 RID: 7969
		internal Button button_2;

		// Token: 0x04001F22 RID: 7970
		internal Button button_3;

		// Token: 0x04001F23 RID: 7971
		internal dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0;

		// Token: 0x04001F24 RID: 7972
		internal ItemsControl itemsControl_0;

		// Token: 0x04001F25 RID: 7973
		private bool bool_0;

		// Token: 0x020007D9 RID: 2009
		[StructLayout(LayoutKind.Auto)]
		private struct Struct565 : IAsyncStateMachine
		{
			// Token: 0x0600293B RID: 10555 RVA: 0x000B1400 File Offset: 0x000AF600
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd = this.dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_102;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_15F;
					default:
						dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.button_3.IsEnabled = false;
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.itemsControl_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.Struct565>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0);
					dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.DataContext = null;
					dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.DataContext = Class683.smethod_1(this.bool_0);
					awaiter = Class683.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.Struct565>(ref awaiter, ref this);
						return;
					}
					IL_102:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.Struct565>(ref awaiter, ref this);
						return;
					}
					IL_15F:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.itemsControl_0);
					dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd.button_3.IsEnabled = true;
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

			// Token: 0x0600293C RID: 10556 RVA: 0x000B15D4 File Offset: 0x000AF7D4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F26 RID: 7974
			public int int_0;

			// Token: 0x04001F27 RID: 7975
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F28 RID: 7976
			public dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd_0;

			// Token: 0x04001F29 RID: 7977
			public bool bool_0;

			// Token: 0x04001F2A RID: 7978
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
