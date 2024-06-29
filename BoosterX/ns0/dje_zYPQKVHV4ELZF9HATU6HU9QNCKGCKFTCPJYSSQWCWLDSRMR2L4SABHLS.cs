using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000817 RID: 2071
	public sealed class dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd : Page, IComponentConnector
	{
		// Token: 0x06002A4C RID: 10828 RVA: 0x000B67EC File Offset: 0x000B49EC
		public dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x000B6804 File Offset: 0x000B4A04
		private void method_0(bool bool_1)
		{
			dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd.Struct579 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd.Struct579>(ref @struct);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x000B6844 File Offset: 0x000B4A44
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0(true);
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x000B6850 File Offset: 0x000B4A50
		public void button_2_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_11(base.GetType());
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x000B6860 File Offset: 0x000B4A60
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_13(base.GetType());
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x000B6870 File Offset: 0x000B4A70
		public void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_12(base.GetType());
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x000B6880 File Offset: 0x000B4A80
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/dwmexplorerpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x000B68B0 File Offset: 0x000B4AB0
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
				this.grid_0 = (Grid)target;
				return;
			case 7:
				this.grid_1 = (Grid)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002059 RID: 8281
		internal Button button_0;

		// Token: 0x0400205A RID: 8282
		internal Button button_1;

		// Token: 0x0400205B RID: 8283
		internal Button button_2;

		// Token: 0x0400205C RID: 8284
		internal Button button_3;

		// Token: 0x0400205D RID: 8285
		internal CheckBox checkBox_0;

		// Token: 0x0400205E RID: 8286
		internal Grid grid_0;

		// Token: 0x0400205F RID: 8287
		internal Grid grid_1;

		// Token: 0x04002060 RID: 8288
		private bool bool_0;

		// Token: 0x02000818 RID: 2072
		[StructLayout(LayoutKind.Auto)]
		private struct Struct579 : IAsyncStateMachine
		{
			// Token: 0x06002A54 RID: 10836 RVA: 0x000B69A0 File Offset: 0x000B4BA0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd = this.dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num != 0)
					{
						dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd.button_3.IsEnabled = false;
						dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd.DataContext = null;
						awaiter = Class588.smethod_2(dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd.GetType(), this.bool_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd.Struct579>(ref awaiter, ref this);
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
					dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd.DataContext = result;
					dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd.button_3.IsEnabled = true;
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

			// Token: 0x06002A55 RID: 10837 RVA: 0x000B6A88 File Offset: 0x000B4C88
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002061 RID: 8289
			public int int_0;

			// Token: 0x04002062 RID: 8290
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002063 RID: 8291
			public dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd_0;

			// Token: 0x04002064 RID: 8292
			public bool bool_0;

			// Token: 0x04002065 RID: 8293
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
		}
	}
}
