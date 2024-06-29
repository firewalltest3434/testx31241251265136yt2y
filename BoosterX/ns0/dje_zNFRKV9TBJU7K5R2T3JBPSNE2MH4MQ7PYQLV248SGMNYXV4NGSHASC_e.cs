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
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x020007C6 RID: 1990
	public sealed class dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd : Page, IComponentConnector
	{
		// Token: 0x060028E0 RID: 10464 RVA: 0x000AF42C File Offset: 0x000AD62C
		public dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000AF43C File Offset: 0x000AD63C
		private void textBox_0_GotFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == Class364.smethod_0("EnterKey"))
			{
				this.textBox_0.Text = string.Empty;
			}
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x000AF46C File Offset: 0x000AD66C
		private void textBox_0_LostFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = Class364.smethod_0("EnterKey");
			}
			if (this.textBox_0.Text == Class364.smethod_0("EnterKey"))
			{
				DoubleAnimation doubleAnimation = new DoubleAnimation
				{
					Duration = TimeSpan.FromSeconds(0.1),
					To = new double?(0.0),
					AccelerationRatio = 0.5,
					DecelerationRatio = 0.5
				};
				Timeline.SetDesiredFrameRate(doubleAnimation, new int?(60));
				this.blurEffect_0.BeginAnimation(BlurEffect.RadiusProperty, doubleAnimation);
			}
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000AF530 File Offset: 0x000AD730
		private void textBox_0_MouseEnter(object sender, MouseEventArgs p1)
		{
			if (this.textBox_0.Text != Class364.smethod_0("EnterKey"))
			{
				DoubleAnimation doubleAnimation = new DoubleAnimation
				{
					Duration = TimeSpan.FromSeconds(0.1),
					To = new double?(0.0),
					AccelerationRatio = 0.5,
					DecelerationRatio = 0.5
				};
				Timeline.SetDesiredFrameRate(doubleAnimation, new int?(60));
				this.blurEffect_0.BeginAnimation(BlurEffect.RadiusProperty, doubleAnimation);
			}
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000AF5C8 File Offset: 0x000AD7C8
		private void textBox_0_MouseLeave(object sender, MouseEventArgs p1)
		{
			if (this.textBox_0.Text != Class364.smethod_0("EnterKey"))
			{
				DoubleAnimation doubleAnimation = new DoubleAnimation
				{
					Duration = TimeSpan.FromSeconds(0.1),
					To = new double?((double)10f),
					AccelerationRatio = 0.5,
					DecelerationRatio = 0.5
				};
				Timeline.SetDesiredFrameRate(doubleAnimation, new int?(60));
				this.blurEffect_0.BeginAnimation(BlurEffect.RadiusProperty, doubleAnimation);
			}
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000AF65C File Offset: 0x000AD85C
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.Struct556 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.Struct556>(ref @struct);
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x000AF694 File Offset: 0x000AD894
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Application.Current.Dispatcher.Invoke(new Action(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.Class837.class837_0.method_0));
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x000AF6C4 File Offset: 0x000AD8C4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/bupage/importfromkeypage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000AF6F4 File Offset: 0x000AD8F4
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
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				this.textBox_0.MouseEnter += this.textBox_0_MouseEnter;
				this.textBox_0.MouseLeave += this.textBox_0_MouseLeave;
				return;
			case 3:
				this.blurEffect_0 = (BlurEffect)target;
				return;
			case 4:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 5:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 6:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000AF800 File Offset: 0x000ADA00
		private void method_0()
		{
			this.itemsControl_0.Items.Clear();
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000AF814 File Offset: 0x000ADA14
		private void method_1(GClass112 gclass112_0)
		{
			dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.Class838 @class = new dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.Class838();
			@class.dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd_0 = this;
			@class.gclass112_0 = gclass112_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x04001ED1 RID: 7889
		internal Button button_0;

		// Token: 0x04001ED2 RID: 7890
		internal TextBox textBox_0;

		// Token: 0x04001ED3 RID: 7891
		internal BlurEffect blurEffect_0;

		// Token: 0x04001ED4 RID: 7892
		internal Button button_1;

		// Token: 0x04001ED5 RID: 7893
		internal TextBlock textBlock_0;

		// Token: 0x04001ED6 RID: 7894
		internal ItemsControl itemsControl_0;

		// Token: 0x04001ED7 RID: 7895
		private bool bool_0;

		// Token: 0x020007C7 RID: 1991
		[StructLayout(LayoutKind.Auto)]
		private struct Struct556 : IAsyncStateMachine
		{
			// Token: 0x060028EB RID: 10475 RVA: 0x000AF850 File Offset: 0x000ADA50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd = this.dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd_0;
				try
				{
					TaskAwaiter awaiter2;
					if (num != 0)
					{
						TaskAwaiter<Class289> awaiter;
						if (num != 1)
						{
							if (dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.textBox_0.Text == Class585.struct1_0.method_1())
							{
								goto IL_2FB;
							}
							dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.button_1.IsEnabled = false;
							if (!(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.textBox_0.Text == string.Empty) && !(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.textBox_0.Text == Class364.smethod_0("EnterKey")) && dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.textBox_0.Text.Length >= 25 && dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.textBox_0.Text.Contains("-"))
							{
								dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.textBlock_0, Class364.smethod_0("CheckingKey"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z2NVHWHQTTE97LGZ_ejd);
								if (!Class585.struct13_0.method_0())
								{
									goto IL_2FB;
								}
								awaiter = Class166.smethod_1(Class193.uri_10, dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.textBox_0.Text).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 1;
									this.taskAwaiter_1 = awaiter;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.Struct556>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.textBlock_0, Class364.smethod_0("incorrectkey"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
								awaiter2 = Task.Delay(1000).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									this.int_0 = 0;
									this.taskAwaiter_0 = awaiter2;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.Struct556>(ref awaiter2, ref this);
									return;
								}
								goto IL_2C7;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<Class289>);
							this.int_0 = -1;
						}
						Class289 result = awaiter.GetResult();
						if (!result.Success)
						{
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.textBlock_0, result.Message, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
							goto IL_2FB;
						}
						List<GClass112> list = JsonConvert.DeserializeObject<List<GClass112>>(result.Message);
						Application.Current.Dispatcher.Invoke(new Action(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.method_0));
						list.ForEach(new Action<GClass112>(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.method_1));
						if (dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.itemsControl_0.Items.Count == 0)
						{
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.textBlock_0, Class364.smethod_0("ProfilesNotFound"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
							goto IL_2FB;
						}
						if (dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.itemsControl_0.Items.Count > 0)
						{
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.textBlock_0, Class364.smethod_0("Found") + " " + dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.itemsControl_0.Items.Count.ToString(), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
							goto IL_2FB;
						}
						dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.button_1.IsEnabled = true;
						goto IL_2FB;
					}
					else
					{
						awaiter2 = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_2C7:
					awaiter2.GetResult();
					dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.button_1.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_2FB:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060028EC RID: 10476 RVA: 0x000AFB88 File Offset: 0x000ADD88
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001ED8 RID: 7896
			public int int_0;

			// Token: 0x04001ED9 RID: 7897
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001EDA RID: 7898
			public dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd_0;

			// Token: 0x04001EDB RID: 7899
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x04001EDC RID: 7900
			private TaskAwaiter<Class289> taskAwaiter_1;
		}

		// Token: 0x020007C8 RID: 1992
		[Serializable]
		private sealed class Class837
		{
			// Token: 0x060028EF RID: 10479 RVA: 0x000AFBAC File Offset: 0x000ADDAC
			internal void method_0()
			{
				Page page = Class358.smethod_0().list_2.FirstOrDefault(new Func<Page, bool>(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.Class837.class837_0.method_1));
				(((page != null) ? page.DataContext : null) as Class755).method_1();
				Class358.smethod_0().method_3(typeof(dje_zS47NUGZB4NMDHDGFGZN8R6MZMSTZC22PP5QJMCVY7U78FP549R6VZ_ejd), Class358.smethod_0().frame_0);
			}

			// Token: 0x060028F0 RID: 10480 RVA: 0x000AFC1C File Offset: 0x000ADE1C
			internal bool method_1(Page page_0)
			{
				return page_0.GetType() == typeof(dje_zS47NUGZB4NMDHDGFGZN8R6MZMSTZC22PP5QJMCVY7U78FP549R6VZ_ejd);
			}

			// Token: 0x04001EDD RID: 7901
			public static readonly dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.Class837 class837_0 = new dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd.Class837();

			// Token: 0x04001EDE RID: 7902
			public static Func<Page, bool> func_0;

			// Token: 0x04001EDF RID: 7903
			public static Action action_0;
		}

		// Token: 0x020007C9 RID: 1993
		private sealed class Class838
		{
			// Token: 0x060028F2 RID: 10482 RVA: 0x000AFC3C File Offset: 0x000ADE3C
			internal void method_0()
			{
				this.dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd_0.itemsControl_0.Items.Add(new Class725(this.gclass112_0, null));
			}

			// Token: 0x04001EE0 RID: 7904
			public GClass112 gclass112_0;

			// Token: 0x04001EE1 RID: 7905
			public dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd_0;
		}
	}
}
