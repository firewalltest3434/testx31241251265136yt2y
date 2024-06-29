using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020006F7 RID: 1783
	public sealed class dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd : Page, IComponentConnector
	{
		// Token: 0x060025E0 RID: 9696 RVA: 0x0009C52C File Offset: 0x0009A72C
		public dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd_Loaded;
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x0009C54C File Offset: 0x0009A74C
		private void dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			if (Class334.bool_1)
			{
				Class334.bool_1 = false;
			}
			base.DataContext = new Class719();
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x0009C568 File Offset: 0x0009A768
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0();
			Class178.dictionary_0.Clear();
			Application.Current.Dispatcher.Invoke(new Action(dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd.Class782.class782_0.method_0));
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x0009C5A8 File Offset: 0x0009A7A8
		private void method_0()
		{
			dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd.Struct449 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd.Struct449>(ref @struct);
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x0009C5D8 File Offset: 0x0009A7D8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/bupage/backupchoose.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x0009C608 File Offset: 0x0009A808
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.itemsControl_0 = (ItemsControl)target;
		}

		// Token: 0x04001AF3 RID: 6899
		internal Button button_0;

		// Token: 0x04001AF4 RID: 6900
		internal ItemsControl itemsControl_0;

		// Token: 0x04001AF5 RID: 6901
		private bool bool_0;

		// Token: 0x020006F8 RID: 1784
		[StructLayout(LayoutKind.Auto)]
		private struct Struct449 : IAsyncStateMachine
		{
			// Token: 0x060025E6 RID: 9702 RVA: 0x0009C660 File Offset: 0x0009A860
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class704.smethod_0().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd.Struct449>(ref awaiter, ref this);
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

			// Token: 0x060025E7 RID: 9703 RVA: 0x0009C70C File Offset: 0x0009A90C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AF6 RID: 6902
			public int int_0;

			// Token: 0x04001AF7 RID: 6903
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001AF8 RID: 6904
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006F9 RID: 1785
		[Serializable]
		private sealed class Class782
		{
			// Token: 0x060025EA RID: 9706 RVA: 0x0009C730 File Offset: 0x0009A930
			internal void method_0()
			{
				Page page = Class358.smethod_0().list_2.FirstOrDefault(new Func<Page, bool>(dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd.Class782.class782_0.method_1));
				(((page != null) ? page.DataContext : null) as Class755).method_1();
				Class358.smethod_0().method_3(typeof(dje_zS47NUGZB4NMDHDGFGZN8R6MZMSTZC22PP5QJMCVY7U78FP549R6VZ_ejd), Class358.smethod_0().frame_0);
			}

			// Token: 0x060025EB RID: 9707 RVA: 0x0009C7A0 File Offset: 0x0009A9A0
			internal bool method_1(Page page_0)
			{
				return page_0.GetType() == typeof(dje_zS47NUGZB4NMDHDGFGZN8R6MZMSTZC22PP5QJMCVY7U78FP549R6VZ_ejd);
			}

			// Token: 0x04001AF9 RID: 6905
			public static readonly dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd.Class782 class782_0 = new dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd.Class782();

			// Token: 0x04001AFA RID: 6906
			public static Func<Page, bool> func_0;

			// Token: 0x04001AFB RID: 6907
			public static Action action_0;
		}
	}
}
