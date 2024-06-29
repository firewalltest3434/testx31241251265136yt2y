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
	// Token: 0x020007BA RID: 1978
	public sealed class dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd : Page, IComponentConnector, IStyleConnector
	{
		// Token: 0x0600288B RID: 10379 RVA: 0x000AE0F4 File Offset: 0x000AC2F4
		public dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd()
		{
			this.InitializeComponent();
			base.DataContext = (this.class728_0 = new Class728(this));
			this.radioButton_0.IsChecked = new bool?(true);
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x000AE134 File Offset: 0x000AC334
		private void method_0()
		{
			this.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.Opacity = 0.0;
			this.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.Visibility = Visibility.Collapsed;
			this.dje_zVJLFRS3DWLQEJ89U7HKWXHQTZ7FD4YB2FAE4CBZX8WAEHFWNE9LQNK2ZE7LMBJKA3Q_ejd_0.Opacity = 0.0;
			this.dje_zVJLFRS3DWLQEJ89U7HKWXHQTZ7FD4YB2FAE4CBZX8WAEHFWNE9LQNK2ZE7LMBJKA3Q_ejd_0.Visibility = Visibility.Collapsed;
			this.dje_z7Y8Z8F4VS9QRSLQS4KDTVYHFV4F44MVL5LNURSJZMAMWZCYVTXB6DMWEHCW7SW29RX_ejd_0.Opacity = 0.0;
			this.dje_z7Y8Z8F4VS9QRSLQS4KDTVYHFV4F44MVL5LNURSJZMAMWZCYVTXB6DMWEHCW7SW29RX_ejd_0.Visibility = Visibility.Collapsed;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x000AE1A4 File Offset: 0x000AC3A4
		private void radioButton_0_Checked(object sender, RoutedEventArgs p1)
		{
			this.class728_0.byte_0 = 0;
			this.method_0();
			this.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.Visibility = Visibility.Visible;
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0);
			if (this.class728_0.Models.Count == 0)
			{
				return;
			}
			if (this.class728_0.Models.All(new Func<Class715, bool>(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.Class836.class836_0.method_0)))
			{
				this.class728_0.Models.First<Class715>().IsChoosen = true;
				return;
			}
			if (this.class728_0.Models.Where(new Func<Class715, bool>(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.Class836.class836_0.method_1)).Count<Class715>() >= 2)
			{
				this.class728_0.Models.First<Class715>().IsChoosen = true;
				return;
			}
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x000AE294 File Offset: 0x000AC494
		private void radioButton_1_Checked(object sender, RoutedEventArgs p1)
		{
			this.class728_0.byte_0 = 1;
			this.class728_0.method_5();
			this.class728_0.Models.smethod_0(new Action<Class715>(this.method_5));
			this.method_0();
			this.dje_zVJLFRS3DWLQEJ89U7HKWXHQTZ7FD4YB2FAE4CBZX8WAEHFWNE9LQNK2ZE7LMBJKA3Q_ejd_0.Visibility = Visibility.Visible;
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.dje_zVJLFRS3DWLQEJ89U7HKWXHQTZ7FD4YB2FAE4CBZX8WAEHFWNE9LQNK2ZE7LMBJKA3Q_ejd_0);
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x000AE2F4 File Offset: 0x000AC4F4
		private void radioButton_2_Checked(object sender, RoutedEventArgs p1)
		{
			this.class728_0.byte_0 = 2;
			this.method_0();
			this.dje_z7Y8Z8F4VS9QRSLQS4KDTVYHFV4F44MVL5LNURSJZMAMWZCYVTXB6DMWEHCW7SW29RX_ejd_0.Visibility = Visibility.Visible;
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.dje_z7Y8Z8F4VS9QRSLQS4KDTVYHFV4F44MVL5LNURSJZMAMWZCYVTXB6DMWEHCW7SW29RX_ejd_0);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x000AE320 File Offset: 0x000AC520
		private void method_1(object sender, RoutedEventArgs p1)
		{
			dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.Struct549 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.Struct549>(ref @struct);
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000AE358 File Offset: 0x000AC558
		private void method_2(object sender, RoutedEventArgs p1)
		{
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000AE35C File Offset: 0x000AC55C
		private void method_3(object sender, SizeChangedEventArgs p1)
		{
			if (this.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Visible)
			{
				this.scrollViewer_0.Margin = new Thickness(10.0, 10.0, 0.0, 10.0);
			}
			if (this.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Collapsed)
			{
				this.stackPanel_0.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
				this.scrollViewer_0.Margin = new Thickness(10.0, 10.0, 10.0, 10.0);
			}
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x000AE420 File Offset: 0x000AC620
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/inputlagtest/pages/originaltest.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x000AE450 File Offset: 0x000AC650
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_4(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x000AE45C File Offset: 0x000AC65C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd)target).SizeChanged += this.method_3;
				return;
			case 2:
				this.radioButton_0 = (RadioButton)target;
				this.radioButton_0.Checked += this.radioButton_0_Checked;
				return;
			case 3:
				this.radioButton_1 = (RadioButton)target;
				this.radioButton_1.Checked += this.radioButton_1_Checked;
				return;
			case 4:
				this.radioButton_2 = (RadioButton)target;
				this.radioButton_2.Checked += this.radioButton_2_Checked;
				return;
			case 5:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 6:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 7:
				((Button)target).Click += this.method_1;
				return;
			default:
				this.bool_0 = true;
				return;
			case 9:
				this.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0 = (dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd)target;
				return;
			case 10:
				this.dje_zVJLFRS3DWLQEJ89U7HKWXHQTZ7FD4YB2FAE4CBZX8WAEHFWNE9LQNK2ZE7LMBJKA3Q_ejd_0 = (dje_zVJLFRS3DWLQEJ89U7HKWXHQTZ7FD4YB2FAE4CBZX8WAEHFWNE9LQNK2ZE7LMBJKA3Q_ejd)target;
				return;
			case 11:
				this.dje_z7Y8Z8F4VS9QRSLQS4KDTVYHFV4F44MVL5LNURSJZMAMWZCYVTXB6DMWEHCW7SW29RX_ejd_0 = (dje_z7Y8Z8F4VS9QRSLQS4KDTVYHFV4F44MVL5LNURSJZMAMWZCYVTXB6DMWEHCW7SW29RX_ejd)target;
				return;
			}
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x000AE584 File Offset: 0x000AC784
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 8)
			{
				((Button)target).Click += this.method_1;
			}
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000AE5A4 File Offset: 0x000AC7A4
		private void method_5(Class715 class715_0)
		{
			if (class715_0.IsChoosen)
			{
				this.class728_0.method_3(class715_0);
			}
		}

		// Token: 0x04001E84 RID: 7812
		private Class728 class728_0;

		// Token: 0x04001E85 RID: 7813
		internal RadioButton radioButton_0;

		// Token: 0x04001E86 RID: 7814
		internal RadioButton radioButton_1;

		// Token: 0x04001E87 RID: 7815
		internal RadioButton radioButton_2;

		// Token: 0x04001E88 RID: 7816
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001E89 RID: 7817
		internal StackPanel stackPanel_0;

		// Token: 0x04001E8A RID: 7818
		internal dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0;

		// Token: 0x04001E8B RID: 7819
		internal dje_zVJLFRS3DWLQEJ89U7HKWXHQTZ7FD4YB2FAE4CBZX8WAEHFWNE9LQNK2ZE7LMBJKA3Q_ejd dje_zVJLFRS3DWLQEJ89U7HKWXHQTZ7FD4YB2FAE4CBZX8WAEHFWNE9LQNK2ZE7LMBJKA3Q_ejd_0;

		// Token: 0x04001E8C RID: 7820
		internal dje_z7Y8Z8F4VS9QRSLQS4KDTVYHFV4F44MVL5LNURSJZMAMWZCYVTXB6DMWEHCW7SW29RX_ejd dje_z7Y8Z8F4VS9QRSLQS4KDTVYHFV4F44MVL5LNURSJZMAMWZCYVTXB6DMWEHCW7SW29RX_ejd_0;

		// Token: 0x04001E8D RID: 7821
		private bool bool_0;

		// Token: 0x020007BB RID: 1979
		[StructLayout(LayoutKind.Auto)]
		private struct Struct549 : IAsyncStateMachine
		{
			// Token: 0x06002898 RID: 10392 RVA: 0x000AE5BC File Offset: 0x000AC7BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd = this.dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(50).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.Struct549>(ref awaiter, ref this);
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
					if (dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Visible)
					{
						dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.scrollViewer_0.Margin = new Thickness(10.0, 10.0, 0.0, 10.0);
					}
					if (dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Collapsed)
					{
						dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.stackPanel_0.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
						dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.scrollViewer_0.Margin = new Thickness(10.0, 10.0, 10.0, 10.0);
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

			// Token: 0x06002899 RID: 10393 RVA: 0x000AE738 File Offset: 0x000AC938
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E8E RID: 7822
			public int int_0;

			// Token: 0x04001E8F RID: 7823
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001E90 RID: 7824
			public dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd_0;

			// Token: 0x04001E91 RID: 7825
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007BC RID: 1980
		[Serializable]
		private sealed class Class836
		{
			// Token: 0x0600289C RID: 10396 RVA: 0x000AE75C File Offset: 0x000AC95C
			internal bool method_0(Class715 class715_0)
			{
				return !class715_0.IsChoosen;
			}

			// Token: 0x0600289D RID: 10397 RVA: 0x000AE768 File Offset: 0x000AC968
			internal bool method_1(Class715 class715_0)
			{
				return class715_0.IsChoosen;
			}

			// Token: 0x04001E92 RID: 7826
			public static readonly dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.Class836 class836_0 = new dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd.Class836();

			// Token: 0x04001E93 RID: 7827
			public static Func<Class715, bool> func_0;

			// Token: 0x04001E94 RID: 7828
			public static Func<Class715, bool> func_1;
		}
	}
}
