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
	// Token: 0x02000784 RID: 1924
	public sealed class dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd : Page, IComponentConnector
	{
		// Token: 0x060027B4 RID: 10164 RVA: 0x000A8108 File Offset: 0x000A6308
		public dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000A8120 File Offset: 0x000A6320
		private void method_0(bool bool_1)
		{
			dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.Struct521 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.Struct521>(ref @struct);
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x000A8160 File Offset: 0x000A6360
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0(true);
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x000A816C File Offset: 0x000A636C
		public void button_2_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_11(base.GetType());
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x000A817C File Offset: 0x000A637C
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_13(base.GetType());
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x000A818C File Offset: 0x000A638C
		public void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_12(base.GetType());
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x000A819C File Offset: 0x000A639C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/taskspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x000A81CC File Offset: 0x000A63CC
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
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001D5A RID: 7514
		internal RowDefinition rowDefinition_0;

		// Token: 0x04001D5B RID: 7515
		internal Button button_0;

		// Token: 0x04001D5C RID: 7516
		internal Button button_1;

		// Token: 0x04001D5D RID: 7517
		internal Button button_2;

		// Token: 0x04001D5E RID: 7518
		internal Button button_3;

		// Token: 0x04001D5F RID: 7519
		internal CheckBox checkBox_0;

		// Token: 0x04001D60 RID: 7520
		private bool bool_0;

		// Token: 0x02000785 RID: 1925
		private sealed class Class828
		{
			// Token: 0x060027BD RID: 10173 RVA: 0x000A82B4 File Offset: 0x000A64B4
			internal Task method_0()
			{
				dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.Class828.Struct520 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class828_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.Class828.Struct520>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x04001D61 RID: 7521
			public dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd_0;

			// Token: 0x04001D62 RID: 7522
			public bool bool_0;

			// Token: 0x04001D63 RID: 7523
			public ObservableCollection<Class745> observableCollection_0;

			// Token: 0x02000786 RID: 1926
			[StructLayout(LayoutKind.Auto)]
			private struct Struct520 : IAsyncStateMachine
			{
				// Token: 0x060027BE RID: 10174 RVA: 0x000A82F8 File Offset: 0x000A64F8
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.Class828 @class = this.class828_0;
					try
					{
						TaskAwaiter<ObservableCollection<Class745>> awaiter;
						if (num != 0)
						{
							awaiter = Class588.smethod_2(@class.dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd_0.GetType(), @class.bool_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.Class828.Struct520>(ref awaiter, ref this);
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

				// Token: 0x060027BF RID: 10175 RVA: 0x000A83C4 File Offset: 0x000A65C4
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x04001D64 RID: 7524
				public int int_0;

				// Token: 0x04001D65 RID: 7525
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x04001D66 RID: 7526
				public dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.Class828 class828_0;

				// Token: 0x04001D67 RID: 7527
				private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
			}
		}

		// Token: 0x02000787 RID: 1927
		[StructLayout(LayoutKind.Auto)]
		private struct Struct521 : IAsyncStateMachine
		{
			// Token: 0x060027C0 RID: 10176 RVA: 0x000A83D4 File Offset: 0x000A65D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd = this.dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class828_0 = new dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.Class828();
						this.class828_0.dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd_0 = this.dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd_0;
						this.class828_0.bool_0 = this.bool_0;
						dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.button_3.IsEnabled = false;
						dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.DataContext = null;
						this.class828_0.observableCollection_0 = null;
						awaiter = Task.Run(new Func<Task>(this.class828_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.Struct521>(ref awaiter, ref this);
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
					dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.DataContext = this.class828_0.observableCollection_0;
					dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.button_3.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class828_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class828_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060027C1 RID: 10177 RVA: 0x000A8510 File Offset: 0x000A6710
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D68 RID: 7528
			public int int_0;

			// Token: 0x04001D69 RID: 7529
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D6A RID: 7530
			public dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd_0;

			// Token: 0x04001D6B RID: 7531
			public bool bool_0;

			// Token: 0x04001D6C RID: 7532
			private dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd.Class828 class828_0;

			// Token: 0x04001D6D RID: 7533
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
