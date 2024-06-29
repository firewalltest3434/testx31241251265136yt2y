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
	// Token: 0x020006C0 RID: 1728
	public sealed class dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd : Page, IComponentConnector
	{
		// Token: 0x060024ED RID: 9453 RVA: 0x00094EF8 File Offset: 0x000930F8
		public dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00094F10 File Offset: 0x00093110
		private void method_0(bool bool_1)
		{
			dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.Struct419 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.Struct419>(ref @struct);
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00094F50 File Offset: 0x00093150
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0(true);
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00094F5C File Offset: 0x0009315C
		public void button_2_Click(object sender, RoutedEventArgs p1)
		{
			Class271.smethod_2();
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00094F64 File Offset: 0x00093164
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class271.smethod_1();
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00094F6C File Offset: 0x0009316C
		public void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class271.smethod_3();
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00094F74 File Offset: 0x00093174
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/features/featurespage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00094FA4 File Offset: 0x000931A4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_1(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x00094FB0 File Offset: 0x000931B0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.rowDefinition_0 = (RowDefinition)target;
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
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 6:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 7:
				this.dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0 = (dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd)target;
				return;
			case 8:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040019AB RID: 6571
		internal RowDefinition rowDefinition_0;

		// Token: 0x040019AC RID: 6572
		internal Button button_0;

		// Token: 0x040019AD RID: 6573
		internal Button button_1;

		// Token: 0x040019AE RID: 6574
		internal Button button_2;

		// Token: 0x040019AF RID: 6575
		internal Button button_3;

		// Token: 0x040019B0 RID: 6576
		internal CheckBox checkBox_0;

		// Token: 0x040019B1 RID: 6577
		internal dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0;

		// Token: 0x040019B2 RID: 6578
		internal ItemsControl itemsControl_0;

		// Token: 0x040019B3 RID: 6579
		private bool bool_0;

		// Token: 0x020006C1 RID: 1729
		[StructLayout(LayoutKind.Auto)]
		private struct Struct419 : IAsyncStateMachine
		{
			// Token: 0x060024F6 RID: 9462 RVA: 0x000950B0 File Offset: 0x000932B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd = this.dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<Class718> awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<Class718>);
						this.int_0 = -1;
						goto IL_FB;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_15F;
					case 3:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_1BC;
					default:
						dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.button_3.IsEnabled = false;
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.itemsControl_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.Struct419>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0);
					dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.DataContext = null;
					awaiter2 = Class271.smethod_0(this.bool_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class718>, dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.Struct419>(ref awaiter2, ref this);
						return;
					}
					IL_FB:
					Class718 result = awaiter2.GetResult();
					dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.DataContext = result;
					awaiter = Class271.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.Struct419>(ref awaiter, ref this);
						return;
					}
					IL_15F:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.Struct419>(ref awaiter, ref this);
						return;
					}
					IL_1BC:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.itemsControl_0);
					dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd.button_3.IsEnabled = true;
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

			// Token: 0x060024F7 RID: 9463 RVA: 0x000952E4 File Offset: 0x000934E4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040019B4 RID: 6580
			public int int_0;

			// Token: 0x040019B5 RID: 6581
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040019B6 RID: 6582
			public dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd_0;

			// Token: 0x040019B7 RID: 6583
			public bool bool_0;

			// Token: 0x040019B8 RID: 6584
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x040019B9 RID: 6585
			private TaskAwaiter<Class718> taskAwaiter_1;
		}
	}
}
