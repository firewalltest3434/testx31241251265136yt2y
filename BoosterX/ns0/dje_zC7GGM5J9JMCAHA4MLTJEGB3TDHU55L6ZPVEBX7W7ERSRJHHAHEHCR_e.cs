using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x02000766 RID: 1894
	public sealed class dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600271D RID: 10013 RVA: 0x000A43F4 File Offset: 0x000A25F4
		public dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000A4404 File Offset: 0x000A2604
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Task.Run(new Action(this.method_0));
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000A4418 File Offset: 0x000A2618
		private void method_0()
		{
			dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref @struct);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000A4450 File Offset: 0x000A2650
		public static void smethod_0(dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0)
		{
			dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct507 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0 = dje_z8KW56LJY9U4NE627Q7PL4_ejd_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct507>(ref @struct);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x000A4488 File Offset: 0x000A2688
		public static void smethod_1(dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0)
		{
			dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct506 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0 = dje_z8KW56LJY9U4NE627Q7PL4_ejd_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct506>(ref @struct);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000A44C0 File Offset: 0x000A26C0
		private static dje_z8KW56LJY9U4NE627Q7PL4_ejd smethod_2(IEnumerable<dje_z8KW56LJY9U4NE627Q7PL4_ejd> ienumerable_0)
		{
			dje_z8KW56LJY9U4NE627Q7PL4_ejd result = ienumerable_0.OrderBy(new Func<dje_z8KW56LJY9U4NE627Q7PL4_ejd, int>(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Class825.class825_0.method_0)).First<dje_z8KW56LJY9U4NE627Q7PL4_ejd>();
			Console.WriteLine();
			return result;
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000A44F4 File Offset: 0x000A26F4
		private static void smethod_3(string string_0, double double_3)
		{
			Console.WriteLine("{0} speed: {1} Mbps", string_0, Math.Round(double_3 / 1024.0, 2));
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000A4518 File Offset: 0x000A2718
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/internetspeeduc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000A4548 File Offset: 0x000A2748
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.arc_0 = (Arc)target;
				return;
			case 2:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 3:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 4:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 5:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 6:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 7:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 8:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 9:
				this.textBlock_4 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000A4614 File Offset: 0x000A2814
		private void method_1()
		{
			this.button_0.IsEnabled = false;
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x000A4624 File Offset: 0x000A2824
		private void method_2()
		{
			this.textBlock_1.Text = Class489.smethod_14((dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_2 / 1024.0).ToString(), 2);
			int num = ((int)dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_2 / 1024 > 100) ? 100 : ((int)dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_2 / 1024);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.arc_0, TimeSpan.FromSeconds(0.1), Arc.EndAngleProperty, (double)num * 1.8);
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000A46B4 File Offset: 0x000A28B4
		private void method_3()
		{
			this.textBlock_1.Text = Class489.smethod_14((dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_0 / 1024.0).ToString(), 2);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_3, this.textBlock_1.Text + " Mbps");
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x000A470C File Offset: 0x000A290C
		private void method_4()
		{
			this.textBlock_1.Text = "0";
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x000A4720 File Offset: 0x000A2920
		private void method_5()
		{
			this.textBlock_2.Text = Class489.smethod_14((dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_2 / 1024.0).ToString(), 2);
			int num = ((int)dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_2 / 1024 > 100) ? 100 : ((int)dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_2 / 1024);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.arc_0, TimeSpan.FromSeconds(0.1), Arc.EndAngleProperty, (double)num * 1.8);
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x000A47B0 File Offset: 0x000A29B0
		private void method_6()
		{
			this.textBlock_2.Text = Class489.smethod_14((dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_1 / 1024.0).ToString(), 2);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_4, this.textBlock_2.Text + " Mbps");
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x000A4808 File Offset: 0x000A2A08
		private void method_7()
		{
			this.button_0.IsEnabled = true;
		}

		// Token: 0x04001CAF RID: 7343
		private static GClass16 gclass16_0;

		// Token: 0x04001CB0 RID: 7344
		private static dje_zCAP6BWWS6CCL7H9NW6P82_ejd dje_zCAP6BWWS6CCL7H9NW6P82_ejd_0;

		// Token: 0x04001CB1 RID: 7345
		private static double double_0;

		// Token: 0x04001CB2 RID: 7346
		private static double double_1;

		// Token: 0x04001CB3 RID: 7347
		public static double double_2;

		// Token: 0x04001CB4 RID: 7348
		internal Arc arc_0;

		// Token: 0x04001CB5 RID: 7349
		internal TextBlock textBlock_0;

		// Token: 0x04001CB6 RID: 7350
		internal StackPanel stackPanel_0;

		// Token: 0x04001CB7 RID: 7351
		internal TextBlock textBlock_1;

		// Token: 0x04001CB8 RID: 7352
		internal StackPanel stackPanel_1;

		// Token: 0x04001CB9 RID: 7353
		internal TextBlock textBlock_2;

		// Token: 0x04001CBA RID: 7354
		internal Button button_0;

		// Token: 0x04001CBB RID: 7355
		internal TextBlock textBlock_3;

		// Token: 0x04001CBC RID: 7356
		internal TextBlock textBlock_4;

		// Token: 0x04001CBD RID: 7357
		private bool bool_0;

		// Token: 0x02000767 RID: 1895
		private sealed class Class823
		{
			// Token: 0x0600272E RID: 10030 RVA: 0x000A4820 File Offset: 0x000A2A20
			internal double method_0()
			{
				return dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_0 = dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.gclass16_0.imethod_2(this.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.dje_zCAP6BWWS6CCL7H9NW6P82_ejd_0.Download.ThreadsPerUrl, 2);
			}

			// Token: 0x04001CBE RID: 7358
			public dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0;
		}

		// Token: 0x02000768 RID: 1896
		private sealed class Class824
		{
			// Token: 0x06002730 RID: 10032 RVA: 0x000A4850 File Offset: 0x000A2A50
			internal double method_0()
			{
				return dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_1 = dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.gclass16_0.imethod_3(this.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.dje_zCAP6BWWS6CCL7H9NW6P82_ejd_0.Download.ThreadsPerUrl, 2);
			}

			// Token: 0x04001CBF RID: 7359
			public dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0;
		}

		// Token: 0x02000769 RID: 1897
		[StructLayout(LayoutKind.Auto)]
		private struct Struct506 : IAsyncStateMachine
		{
			// Token: 0x06002731 RID: 10033 RVA: 0x000A4878 File Offset: 0x000A2A78
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<double> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<double>(new Func<double>(new dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Class824
						{
							dje_z8KW56LJY9U4NE627Q7PL4_ejd_0 = this.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0
						}.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<double>, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct506>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<double>);
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

			// Token: 0x06002732 RID: 10034 RVA: 0x000A4940 File Offset: 0x000A2B40
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CC0 RID: 7360
			public int int_0;

			// Token: 0x04001CC1 RID: 7361
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001CC2 RID: 7362
			public dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0;

			// Token: 0x04001CC3 RID: 7363
			private TaskAwaiter<double> taskAwaiter_0;
		}

		// Token: 0x0200076A RID: 1898
		[StructLayout(LayoutKind.Auto)]
		private struct Struct507 : IAsyncStateMachine
		{
			// Token: 0x06002733 RID: 10035 RVA: 0x000A4950 File Offset: 0x000A2B50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<double> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<double>(new Func<double>(new dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Class823
						{
							dje_z8KW56LJY9U4NE627Q7PL4_ejd_0 = this.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0
						}.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<double>, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct507>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<double>);
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

			// Token: 0x06002734 RID: 10036 RVA: 0x000A4A18 File Offset: 0x000A2C18
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CC4 RID: 7364
			public int int_0;

			// Token: 0x04001CC5 RID: 7365
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001CC6 RID: 7366
			public dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0;

			// Token: 0x04001CC7 RID: 7367
			private TaskAwaiter<double> taskAwaiter_0;
		}

		// Token: 0x0200076B RID: 1899
		[Serializable]
		private sealed class Class825
		{
			// Token: 0x06002737 RID: 10039 RVA: 0x000A4A3C File Offset: 0x000A2C3C
			internal int method_0(dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0)
			{
				return dje_z8KW56LJY9U4NE627Q7PL4_ejd_0.Latency;
			}

			// Token: 0x04001CC8 RID: 7368
			public static readonly dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Class825 class825_0 = new dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Class825();

			// Token: 0x04001CC9 RID: 7369
			public static Func<dje_z8KW56LJY9U4NE627Q7PL4_ejd, int> func_0;
		}

		// Token: 0x0200076C RID: 1900
		[StructLayout(LayoutKind.Auto)]
		private struct Struct508 : IAsyncStateMachine
		{
			// Token: 0x06002738 RID: 10040 RVA: 0x000A4A44 File Offset: 0x000A2C44
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd = this.dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd_0;
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
						goto IL_16F;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_1D2;
					case 3:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_26F;
					case 4:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_2F6;
					case 5:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_359;
					case 6:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_468;
					case 7:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_4B3;
					case 8:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_516;
					case 9:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_64C;
					case 10:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_699;
					case 11:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_6FE;
					default:
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Dispatcher.Invoke(new Action(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.method_1));
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_0 = 0.0;
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_1 = 0.0;
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_2 = 0.0;
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, 0.0);
						awaiter = Task.Delay(500).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.button_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
						return;
					}
					IL_16F:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.textBlock_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
						return;
					}
					IL_1D2:
					awaiter.GetResult();
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.gclass16_0 = null;
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.gclass16_0 = new GClass16();
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.dje_zCAP6BWWS6CCL7H9NW6P82_ejd_0 = null;
					int num2 = 0;
					try
					{
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.dje_zCAP6BWWS6CCL7H9NW6P82_ejd_0 = dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.gclass16_0.imethod_0();
					}
					catch
					{
						num2 = 1;
					}
					if (num2 != 1)
					{
						goto IL_285;
					}
					awaiter = Task.Delay(5000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
						return;
					}
					IL_26F:
					awaiter.GetResult();
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.dje_zCAP6BWWS6CCL7H9NW6P82_ejd_0 = dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.gclass16_0.imethod_0();
					IL_285:
					this.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0 = dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.smethod_2(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.dje_zCAP6BWWS6CCL7H9NW6P82_ejd_0.Servers);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.textBlock_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 4;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
						return;
					}
					IL_2F6:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.stackPanel_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 5;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
						return;
					}
					IL_359:
					awaiter.GetResult();
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.smethod_0(this.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0);
					IL_36B:
					if (dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_0 != 0.0)
					{
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Dispatcher.Invoke(new Action(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.method_3));
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.arc_0, TimeSpan.FromSeconds(0.1), Arc.EndAngleProperty, 0.0);
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.stackPanel_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 7;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
							return;
						}
						goto IL_4B3;
					}
					else
					{
						if (dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_2 != 0.0)
						{
							dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Dispatcher.Invoke(new Action(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.method_2));
						}
						awaiter = Task.Delay(5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 6;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
							return;
						}
					}
					IL_468:
					awaiter.GetResult();
					goto IL_36B;
					IL_4B3:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.stackPanel_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 8;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
						return;
					}
					IL_516:
					awaiter.GetResult();
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_2 = 0.0;
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Dispatcher.Invoke(new Action(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.method_4));
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.smethod_1(this.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0);
					IL_54D:
					if (dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_1 != 0.0)
					{
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Dispatcher.Invoke(new Action(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.method_6));
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, 0.0);
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.stackPanel_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 10;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
							return;
						}
						goto IL_699;
					}
					else
					{
						if (dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_2 != 0.0)
						{
							dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Dispatcher.Invoke(new Action(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.method_5));
						}
						awaiter = Task.Delay(5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 9;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
							return;
						}
					}
					IL_64C:
					awaiter.GetResult();
					goto IL_54D;
					IL_699:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.button_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 11;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Struct508>(ref awaiter, ref this);
						return;
					}
					IL_6FE:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, 180.0);
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.Dispatcher.Invoke(new Action(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.method_7));
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002739 RID: 10041 RVA: 0x000A5210 File Offset: 0x000A3410
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CCA RID: 7370
			public int int_0;

			// Token: 0x04001CCB RID: 7371
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001CCC RID: 7372
			public dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd_0;

			// Token: 0x04001CCD RID: 7373
			private dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0;

			// Token: 0x04001CCE RID: 7374
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
