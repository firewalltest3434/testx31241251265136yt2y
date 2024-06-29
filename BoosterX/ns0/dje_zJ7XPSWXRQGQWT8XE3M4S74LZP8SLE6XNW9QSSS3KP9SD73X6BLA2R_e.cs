using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000792 RID: 1938
	public sealed class dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd : Page, IComponentConnector
	{
		// Token: 0x060027F9 RID: 10233 RVA: 0x000A9EE8 File Offset: 0x000A80E8
		public dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000A9F00 File Offset: 0x000A8100
		private void method_0(bool bool_1)
		{
			dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.Struct526 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.Struct526>(ref @struct);
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000A9F40 File Offset: 0x000A8140
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0(true);
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000A9F4C File Offset: 0x000A814C
		public void button_2_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_11(base.GetType());
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000A9F5C File Offset: 0x000A815C
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_13(base.GetType());
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000A9F6C File Offset: 0x000A816C
		public void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_12(base.GetType());
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000A9F7C File Offset: 0x000A817C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/customizationpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x000A9FAC File Offset: 0x000A81AC
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
				this.checkBox_0 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001DA8 RID: 7592
		internal Button button_0;

		// Token: 0x04001DA9 RID: 7593
		internal Button button_1;

		// Token: 0x04001DAA RID: 7594
		internal Button button_2;

		// Token: 0x04001DAB RID: 7595
		internal Button button_3;

		// Token: 0x04001DAC RID: 7596
		internal CheckBox checkBox_0;

		// Token: 0x04001DAD RID: 7597
		private bool bool_0;

		// Token: 0x02000793 RID: 1939
		private sealed class Class833
		{
			// Token: 0x06002802 RID: 10242 RVA: 0x000AA084 File Offset: 0x000A8284
			internal Task method_0()
			{
				dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.Class833.Struct525 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class833_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.Class833.Struct525>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x04001DAE RID: 7598
			public dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd_0;

			// Token: 0x04001DAF RID: 7599
			public bool bool_0;

			// Token: 0x04001DB0 RID: 7600
			public ObservableCollection<Class745> observableCollection_0;

			// Token: 0x02000794 RID: 1940
			[StructLayout(LayoutKind.Auto)]
			private struct Struct525 : IAsyncStateMachine
			{
				// Token: 0x06002803 RID: 10243 RVA: 0x000AA0C8 File Offset: 0x000A82C8
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.Class833 @class = this.class833_0;
					try
					{
						TaskAwaiter<ObservableCollection<Class745>> awaiter;
						if (num != 0)
						{
							awaiter = Class588.smethod_2(@class.dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd_0.GetType(), @class.bool_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.Class833.Struct525>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
							this.int_0 = -1;
						}
						ObservableCollection<Class745> result = awaiter.GetResult();
						@class.observableCollection_0 = result;
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetResult();
				}

				// Token: 0x06002804 RID: 10244 RVA: 0x000AA194 File Offset: 0x000A8394
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x04001DB1 RID: 7601
				public int int_0;

				// Token: 0x04001DB2 RID: 7602
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x04001DB3 RID: 7603
				public dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.Class833 class833_0;

				// Token: 0x04001DB4 RID: 7604
				private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
			}
		}

		// Token: 0x02000795 RID: 1941
		[StructLayout(LayoutKind.Auto)]
		private struct Struct526 : IAsyncStateMachine
		{
			// Token: 0x06002805 RID: 10245 RVA: 0x000AA1A4 File Offset: 0x000A83A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd = this.dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class833_0 = new dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.Class833();
						this.class833_0.dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd_0 = this.dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd_0;
						this.class833_0.bool_0 = this.bool_0;
						dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.button_3.IsEnabled = false;
						dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.DataContext = null;
						this.class833_0.observableCollection_0 = null;
						awaiter = Task.Run(new Func<Task>(this.class833_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.Struct526>(ref awaiter, ref this);
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
					dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.DataContext = this.class833_0.observableCollection_0;
					dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.button_3.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class833_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class833_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002806 RID: 10246 RVA: 0x000AA2E0 File Offset: 0x000A84E0
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DB5 RID: 7605
			public int int_0;

			// Token: 0x04001DB6 RID: 7606
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001DB7 RID: 7607
			public dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd_0;

			// Token: 0x04001DB8 RID: 7608
			public bool bool_0;

			// Token: 0x04001DB9 RID: 7609
			private dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd.Class833 class833_0;

			// Token: 0x04001DBA RID: 7610
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
