using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007C4 RID: 1988
	public sealed class dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060028D8 RID: 10456 RVA: 0x000AF1C4 File Offset: 0x000AD3C4
		public dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd_Loaded;
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000AF1E4 File Offset: 0x000AD3E4
		private void dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			if (this.class717_0 == null)
			{
				base.DataContext = (this.class717_0 = new Class717());
			}
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000AF210 File Offset: 0x000AD410
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd.Struct555 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd.Struct555>(ref @struct);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x000AF248 File Offset: 0x000AD448
		private void method_0(object sender, SizeChangedEventArgs p1)
		{
			this.scrollViewer_0.MaxHeight = base.ActualHeight - this.grid_0.ActualHeight - 48.0;
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x000AF274 File Offset: 0x000AD474
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/news/newsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x000AF2A4 File Offset: 0x000AD4A4
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd)target).SizeChanged += this.method_0;
				return;
			case 2:
				this.grid_0 = (Grid)target;
				return;
			case 3:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 4:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001EC8 RID: 7880
		private Class717 class717_0;

		// Token: 0x04001EC9 RID: 7881
		internal Grid grid_0;

		// Token: 0x04001ECA RID: 7882
		internal Button button_0;

		// Token: 0x04001ECB RID: 7883
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001ECC RID: 7884
		private bool bool_0;

		// Token: 0x020007C5 RID: 1989
		[StructLayout(LayoutKind.Auto)]
		private struct Struct555 : IAsyncStateMachine
		{
			// Token: 0x060028DE RID: 10462 RVA: 0x000AF328 File Offset: 0x000AD528
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd = this.dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd.button_0.IsEnabled = false;
						dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd.DataContext = (dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd.class717_0 = null);
						dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd.DataContext = (dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd.class717_0 = new Class717());
						awaiter = Task.Delay(10000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd.Struct555>(ref awaiter, ref this);
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
					dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd.button_0.IsEnabled = true;
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

			// Token: 0x060028DF RID: 10463 RVA: 0x000AF41C File Offset: 0x000AD61C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001ECD RID: 7885
			public int int_0;

			// Token: 0x04001ECE RID: 7886
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001ECF RID: 7887
			public dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd dje_zNDRBXMEK34T2X27PZ22V98QHMM2FBWDW5NNBLELRYZT93GFNHNJURT22BARBCJ33N2_ejd_0;

			// Token: 0x04001ED0 RID: 7888
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
