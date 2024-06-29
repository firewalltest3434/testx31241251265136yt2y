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
	// Token: 0x0200075D RID: 1885
	public sealed class dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd : Page, IComponentConnector
	{
		// Token: 0x06002701 RID: 9985 RVA: 0x000A39C4 File Offset: 0x000A1BC4
		public dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x000A39DC File Offset: 0x000A1BDC
		private void method_0(bool bool_1)
		{
			dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.Struct503 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.Struct503>(ref @struct);
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x000A3A1C File Offset: 0x000A1C1C
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0(true);
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000A3A28 File Offset: 0x000A1C28
		public void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_11(base.GetType());
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x000A3A38 File Offset: 0x000A1C38
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_13(base.GetType());
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000A3A48 File Offset: 0x000A1C48
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/telemetrypage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000A3A78 File Offset: 0x000A1C78
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
				this.checkBox_0 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001C85 RID: 7301
		internal Button button_0;

		// Token: 0x04001C86 RID: 7302
		internal Button button_1;

		// Token: 0x04001C87 RID: 7303
		internal Button button_2;

		// Token: 0x04001C88 RID: 7304
		internal CheckBox checkBox_0;

		// Token: 0x04001C89 RID: 7305
		private bool bool_0;

		// Token: 0x0200075E RID: 1886
		private sealed class Class821
		{
			// Token: 0x06002709 RID: 9993 RVA: 0x000A3B28 File Offset: 0x000A1D28
			internal Task method_0()
			{
				dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.Class821.Struct502 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class821_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.Class821.Struct502>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x04001C8A RID: 7306
			public dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd_0;

			// Token: 0x04001C8B RID: 7307
			public bool bool_0;

			// Token: 0x04001C8C RID: 7308
			public ObservableCollection<Class745> observableCollection_0;

			// Token: 0x0200075F RID: 1887
			[StructLayout(LayoutKind.Auto)]
			private struct Struct502 : IAsyncStateMachine
			{
				// Token: 0x0600270A RID: 9994 RVA: 0x000A3B6C File Offset: 0x000A1D6C
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.Class821 @class = this.class821_0;
					try
					{
						TaskAwaiter<ObservableCollection<Class745>> awaiter;
						if (num != 0)
						{
							awaiter = Class588.smethod_2(@class.dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd_0.GetType(), @class.bool_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.Class821.Struct502>(ref awaiter, ref this);
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

				// Token: 0x0600270B RID: 9995 RVA: 0x000A3C38 File Offset: 0x000A1E38
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x04001C8D RID: 7309
				public int int_0;

				// Token: 0x04001C8E RID: 7310
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x04001C8F RID: 7311
				public dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.Class821 class821_0;

				// Token: 0x04001C90 RID: 7312
				private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
			}
		}

		// Token: 0x02000760 RID: 1888
		[StructLayout(LayoutKind.Auto)]
		private struct Struct503 : IAsyncStateMachine
		{
			// Token: 0x0600270C RID: 9996 RVA: 0x000A3C48 File Offset: 0x000A1E48
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd = this.dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class821_0 = new dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.Class821();
						this.class821_0.dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd_0 = this.dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd_0;
						this.class821_0.bool_0 = this.bool_0;
						dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.button_2.IsEnabled = false;
						dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.DataContext = null;
						this.class821_0.observableCollection_0 = null;
						awaiter = Task.Run(new Func<Task>(this.class821_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.Struct503>(ref awaiter, ref this);
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
					dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.DataContext = this.class821_0.observableCollection_0;
					dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.button_2.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class821_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class821_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600270D RID: 9997 RVA: 0x000A3D84 File Offset: 0x000A1F84
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C91 RID: 7313
			public int int_0;

			// Token: 0x04001C92 RID: 7314
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001C93 RID: 7315
			public dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd_0;

			// Token: 0x04001C94 RID: 7316
			public bool bool_0;

			// Token: 0x04001C95 RID: 7317
			private dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd.Class821 class821_0;

			// Token: 0x04001C96 RID: 7318
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
