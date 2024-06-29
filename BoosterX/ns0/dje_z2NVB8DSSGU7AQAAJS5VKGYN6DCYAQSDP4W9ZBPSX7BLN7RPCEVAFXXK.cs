using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200068C RID: 1676
	public sealed class dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd : Page, IComponentConnector
	{
		// Token: 0x060023F0 RID: 9200 RVA: 0x0008E83C File Offset: 0x0008CA3C
		public dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
			base.Loaded += this.dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd_Loaded;
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x0008E864 File Offset: 0x0008CA64
		private void dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.Struct389 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.Struct389>(ref @struct);
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x0008E89C File Offset: 0x0008CA9C
		private void method_0(bool bool_1)
		{
			base.DataContext = Class147.smethod_0(bool_1);
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x0008E8AC File Offset: 0x0008CAAC
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.Struct387 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.Struct387>(ref @struct);
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x0008E8DC File Offset: 0x0008CADC
		public void button_2_Click(object sender, RoutedEventArgs p1)
		{
			Class147.smethod_4();
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x0008E8E4 File Offset: 0x0008CAE4
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class147.smethod_5();
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x0008E8EC File Offset: 0x0008CAEC
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			this.button_3.IsEnabled = false;
			this.method_0(true);
			this.button_3.IsEnabled = true;
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x0008E910 File Offset: 0x0008CB10
		private void method_1(object sender, RoutedEventArgs p1)
		{
			dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.Struct388 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.Struct388>(ref @struct);
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x0008E948 File Offset: 0x0008CB48
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/mytweaks/mytweakspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x0008E978 File Offset: 0x0008CB78
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
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
				this.checkBox_0 = (CheckBox)target;
				return;
			case 6:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 7:
				((Button)target).Click += this.button_0_Click;
				return;
			case 8:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 9:
				((Button)target).Click += this.method_1;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001873 RID: 6259
		internal Button button_0;

		// Token: 0x04001874 RID: 6260
		internal Button button_1;

		// Token: 0x04001875 RID: 6261
		internal Button button_2;

		// Token: 0x04001876 RID: 6262
		internal Button button_3;

		// Token: 0x04001877 RID: 6263
		internal CheckBox checkBox_0;

		// Token: 0x04001878 RID: 6264
		internal StackPanel stackPanel_0;

		// Token: 0x04001879 RID: 6265
		internal StackPanel stackPanel_1;

		// Token: 0x0400187A RID: 6266
		private bool bool_0;

		// Token: 0x0200068D RID: 1677
		[StructLayout(LayoutKind.Auto)]
		private struct Struct387 : IAsyncStateMachine
		{
			// Token: 0x060023FA RID: 9210 RVA: 0x0008EAA0 File Offset: 0x0008CCA0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<object> awaiter;
					if (num != 0)
					{
						Class358.smethod_0().method_3(typeof(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd), Class358.smethod_0().frame_2);
						awaiter = Class358.smethod_0().method_1(typeof(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<object>, dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.Struct387>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<object>);
						this.int_0 = -1;
					}
					object result = awaiter.GetResult();
					if (result != null)
					{
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20((result as dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd).button_1);
					}
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

			// Token: 0x060023FB RID: 9211 RVA: 0x0008EB90 File Offset: 0x0008CD90
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400187B RID: 6267
			public int int_0;

			// Token: 0x0400187C RID: 6268
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400187D RID: 6269
			private TaskAwaiter<object> taskAwaiter_0;
		}

		// Token: 0x0200068E RID: 1678
		[StructLayout(LayoutKind.Auto)]
		private struct Struct388 : IAsyncStateMachine
		{
			// Token: 0x060023FC RID: 9212 RVA: 0x0008EBA0 File Offset: 0x0008CDA0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd dependencyObject = this.dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						((dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)Window.GetWindow(dependencyObject)).radioButton_0.IsChecked = new bool?(true);
						awaiter = Task.Delay(10).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.Struct388>(ref awaiter, ref this);
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
					Class358.smethod_0().method_3(typeof(dje_zN8S5HA5EL9Z3S3PMRKLJ777U7ADRNX8TYKTNLMCQMURXVDQ_ejd), Class358.smethod_0().frame_0);
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

			// Token: 0x060023FD RID: 9213 RVA: 0x0008EC8C File Offset: 0x0008CE8C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400187E RID: 6270
			public int int_0;

			// Token: 0x0400187F RID: 6271
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001880 RID: 6272
			public dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd_0;

			// Token: 0x04001881 RID: 6273
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200068F RID: 1679
		[StructLayout(LayoutKind.Auto)]
		private struct Struct389 : IAsyncStateMachine
		{
			// Token: 0x060023FE RID: 9214 RVA: 0x0008EC9C File Offset: 0x0008CE9C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd = this.dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!Class585.struct13_0.method_0())
						{
							dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.checkBox_0.IsChecked = new bool?(true);
							dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.stackPanel_0.Visibility = Visibility.Collapsed;
							goto IL_116;
						}
						dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.stackPanel_1.Visibility = Visibility.Collapsed;
						awaiter = Task.Delay(500).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.Struct389>(ref awaiter, ref this);
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
					if ((dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.DataContext as Class726).Tweaks.Count<Class745>() != 0)
					{
						dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.checkBox_0.IsChecked = new bool?(false);
						dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.stackPanel_0.Visibility = Visibility.Collapsed;
					}
					else
					{
						dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.stackPanel_0.Visibility = Visibility.Visible;
						dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd.checkBox_0.IsChecked = new bool?(true);
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_116:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060023FF RID: 9215 RVA: 0x0008EDE4 File Offset: 0x0008CFE4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001882 RID: 6274
			public int int_0;

			// Token: 0x04001883 RID: 6275
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001884 RID: 6276
			public dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd_0;

			// Token: 0x04001885 RID: 6277
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
