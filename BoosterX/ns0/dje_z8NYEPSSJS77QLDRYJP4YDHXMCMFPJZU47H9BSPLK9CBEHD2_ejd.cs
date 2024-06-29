using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Material.Icons.WPF;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x020006D4 RID: 1748
	public sealed class dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd : Page, IComponentConnector
	{
		// Token: 0x06002547 RID: 9543 RVA: 0x0009740C File Offset: 0x0009560C
		public dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd()
		{
			this.InitializeComponent();
			this.method_0();
			base.DataContext = new Class714();
			Class358.smethod_0().dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0 = this;
			base.Loaded += this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_Loaded;
			this.method_6();
			Class585.smethod_0(new Class585.Delegate28(this.method_4));
			Class585.smethod_2(new Class585.Delegate29(this.method_3));
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x0009747C File Offset: 0x0009567C
		private void method_0()
		{
			this.class292_0 = Class292.smethod_0();
			this.class292_0.method_0(new Class292.Delegate25(this.method_1));
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x000974A0 File Offset: 0x000956A0
		private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs p1)
		{
			string a = this.comboBox_0.SelectedItem.ToString().Split(new string[]
			{
				": "
			}, StringSplitOptions.None).Last<string>();
			if (a == "Русский")
			{
				this.class292_0.method_4("ru-RU");
				return;
			}
			if (a == "Українська")
			{
				this.class292_0.method_4("uk-UA");
				return;
			}
			if (a == "简体中文")
			{
				this.class292_0.method_4("zh-CN");
				return;
			}
			this.class292_0.method_4("en-US");
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00097544 File Offset: 0x00095744
		private void method_1(CultureInfo cultureInfo_0)
		{
			if (cultureInfo_0.Name == "ru-RU")
			{
				this.comboBox_0.SelectedIndex = 1;
				return;
			}
			if (cultureInfo_0.Name == "uk-UA")
			{
				this.comboBox_0.SelectedIndex = 2;
				return;
			}
			if (cultureInfo_0.Name == "zh-CN")
			{
				this.comboBox_0.SelectedIndex = 3;
				return;
			}
			this.comboBox_0.SelectedIndex = 0;
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x000975BC File Offset: 0x000957BC
		private void dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct432 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct432>(ref @struct);
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000975F4 File Offset: 0x000957F4
		private void method_2()
		{
			dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct433 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct433>(ref @struct);
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x0009762C File Offset: 0x0009582C
		private void method_3()
		{
			dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct434 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct434>(ref @struct);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00097664 File Offset: 0x00095864
		private void method_4()
		{
			dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct431 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct431>(ref @struct);
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x0009769C File Offset: 0x0009589C
		private void method_5(object sender, SizeChangedEventArgs p1)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds(0.2);
			bool? flag = Class389.class504_0.method_24();
			if (flag.GetValueOrDefault() & flag != null)
			{
				timeSpan = TimeSpan.Zero;
			}
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				AccelerationRatio = 0.5,
				DecelerationRatio = 0.5
			};
			if (base.ActualWidth < 1138.0)
			{
				doubleAnimation.Duration = TimeSpan.FromMilliseconds(1.0);
				doubleAnimation.To = new double?(base.ActualWidth - 20.0);
				this.border_1.BeginAnimation(FrameworkElement.WidthProperty, doubleAnimation);
				this.border_1.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
				doubleAnimation.Duration = timeSpan;
				doubleAnimation.To = new double?(0.0);
				this.stackPanel_0.BeginAnimation(FrameworkElement.WidthProperty, doubleAnimation);
				this.stackPanel_0.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
				this.stackPanel_2.BeginAnimation(FrameworkElement.WidthProperty, doubleAnimation);
				this.stackPanel_2.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_30(this.dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd_0, timeSpan);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_30(this.dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0, timeSpan);
			}
			if (base.ActualWidth >= 1138.0)
			{
				doubleAnimation.Duration = TimeSpan.FromMilliseconds(1.0);
				doubleAnimation.To = new double?(base.ActualWidth - 535.0 - 20.0);
				this.stackPanel_2.BeginAnimation(FrameworkElement.WidthProperty, doubleAnimation);
				doubleAnimation.Duration = timeSpan;
				doubleAnimation.To = new double?((double)476f);
				this.border_1.BeginAnimation(FrameworkElement.WidthProperty, doubleAnimation);
				this.border_1.Margin = new Thickness(0.0, 0.0, 60.0, 0.0);
				doubleAnimation.To = new double?((double)258f);
				this.stackPanel_0.BeginAnimation(FrameworkElement.WidthProperty, doubleAnimation);
				this.stackPanel_0.Opacity = 0.0;
				doubleAnimation.To = new double?((double)1f);
				this.stackPanel_0.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
				this.stackPanel_2.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_29(this.dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd_0, timeSpan);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_29(this.dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0, timeSpan);
			}
			if (base.ActualWidth < 1500.0)
			{
				doubleAnimation.Duration = timeSpan;
				doubleAnimation.To = new double?(0.0);
				this.stackPanel_1.BeginAnimation(FrameworkElement.WidthProperty, doubleAnimation);
				this.stackPanel_1.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
				doubleAnimation.BeginTime = new TimeSpan?(timeSpan);
				doubleAnimation.To = new double?((double)416f);
				this.grid_1.BeginAnimation(FrameworkElement.HeightProperty, doubleAnimation);
			}
			if (base.ActualWidth >= 1500.0)
			{
				doubleAnimation.Duration = timeSpan;
				this.stackPanel_1.Opacity = 0.0;
				doubleAnimation.To = new double?((double)1f);
				this.stackPanel_1.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
				doubleAnimation.To = new double?((double)468f);
				this.stackPanel_1.BeginAnimation(FrameworkElement.WidthProperty, doubleAnimation);
				doubleAnimation.To = new double?((double)625f);
				this.stackPanel_2.BeginAnimation(FrameworkElement.WidthProperty, doubleAnimation);
				doubleAnimation.BeginTime = new TimeSpan?(timeSpan);
				doubleAnimation.To = new double?((double)639f);
				this.grid_1.BeginAnimation(FrameworkElement.HeightProperty, doubleAnimation);
			}
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00097A9C File Offset: 0x00095C9C
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			base.Dispatcher.Invoke<Task>(new Func<Task>(this.method_10));
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00097AB8 File Offset: 0x00095CB8
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			((dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)Class358.smethod_0().method_5(typeof(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd))).radioButton_0.IsChecked = new bool?(false);
			Class358.smethod_0().method_3(typeof(dje_zN8S5HA5EL9Z3S3PMRKLJ777U7ADRNX8TYKTNLMCQMURXVDQ_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00097B0C File Offset: 0x00095D0C
		private void method_6()
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.dje_zKWDWM2LA_ejd = Environment.UserName;
			if (!Class585.struct1_1.method_1().smethod_7() && Class585.struct1_1.method_1() != "notfound")
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class585.struct1_1.method_1().Split(new char[]
				{
					'#'
				})[0]);
				return;
			}
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.dje_zKWDWM2LA_ejd);
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x00097B84 File Offset: 0x00095D84
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_z75V2MBPULAMFUWTB6DA93G8822B7L53YN36VKK9PL3VBP6A_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00097BA4 File Offset: 0x00095DA4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/mainpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00097BD4 File Offset: 0x00095DD4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_7(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00097BE0 File Offset: 0x00095DE0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd)target).SizeChanged += this.method_5;
				return;
			case 2:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 3:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 4:
				this.border_0 = (Border)target;
				return;
			case 5:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 6:
				this.progressBar_0 = (ProgressBar)target;
				return;
			case 7:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 8:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 9:
				this.dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd_0 = (dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd)target;
				return;
			case 10:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 11:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 12:
				this.comboBox_0 = (ComboBox)target;
				this.comboBox_0.SelectionChanged += this.comboBox_0_SelectionChanged;
				return;
			case 13:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 14:
				this.textBlock_4 = (TextBlock)target;
				return;
			case 15:
				this.image_0 = (Image)target;
				return;
			case 16:
				this.materialIcon_0 = (MaterialIcon)target;
				return;
			case 17:
				this.textBlock_5 = (TextBlock)target;
				return;
			case 18:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 19:
				this.textBlock_6 = (TextBlock)target;
				return;
			case 20:
				this.grid_0 = (Grid)target;
				return;
			case 21:
				this.grid_1 = (Grid)target;
				return;
			case 22:
				this.grid_2 = (Grid)target;
				return;
			case 23:
				this.border_1 = (Border)target;
				return;
			case 24:
				this.stackPanel_2 = (StackPanel)target;
				return;
			case 25:
				this.dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0 = (dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00097E0C File Offset: 0x0009600C
		private void method_8()
		{
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(this.image_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(this.materialIcon_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.image_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.materialIcon_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_5, Class364.smethod_0("Checkingtext"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00097E60 File Offset: 0x00096060
		private void method_9()
		{
			if (!Class585.struct13_0.method_0())
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_5, Class364.smethod_0("notactivated"), Brushes.White);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_6, Class364.smethod_0("activate"));
				return;
			}
			this.method_6();
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_6, Class364.smethod_0("propage"));
			int num = Convert.ToInt32(Class585.timeSpan_0.TotalSeconds);
			int num2 = num;
			if (num2 < 60)
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(this.materialIcon_0);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.materialIcon_0);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_5, Class364.smethod_0("almostdeact"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
				return;
			}
			num2 = num / 60;
			if (num2 < 60)
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(this.materialIcon_0);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.materialIcon_0);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_5, Class364.smethod_0("lessthathour"), Brushes.White);
				return;
			}
			num2 = num / 60 / 60;
			if (num2 < 24)
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(this.materialIcon_0);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.materialIcon_0);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_5, string.Format("{0} {1} {2}", Class364.smethod_0("timeleft"), num2, Class364.smethod_0("hours")), Brushes.White);
				return;
			}
			num2 = num / 60 / 60 / 24;
			if (num2 < 400)
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(this.materialIcon_0);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.materialIcon_0);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_5, string.Format("{0} {1} {2}", Class364.smethod_0("timeleft"), num2, Class364.smethod_0("days")), Brushes.White);
				return;
			}
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(this.image_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.image_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_5, Class364.smethod_0("lifetime"), Brushes.White);
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00098030 File Offset: 0x00096230
		private Task method_10()
		{
			dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct435 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct435>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00098074 File Offset: 0x00096274
		private void method_11(object sender, DownloadProgressChangedEventArgs p1)
		{
			this.progressBar_0.Value = (double)p1.ProgressPercentage;
		}

		// Token: 0x04001A20 RID: 6688
		private Class292 class292_0;

		// Token: 0x04001A21 RID: 6689
		internal TextBlock textBlock_0;

		// Token: 0x04001A22 RID: 6690
		internal TextBlock textBlock_1;

		// Token: 0x04001A23 RID: 6691
		internal Border border_0;

		// Token: 0x04001A24 RID: 6692
		internal TextBlock textBlock_2;

		// Token: 0x04001A25 RID: 6693
		internal ProgressBar progressBar_0;

		// Token: 0x04001A26 RID: 6694
		internal Button button_0;

		// Token: 0x04001A27 RID: 6695
		internal StackPanel stackPanel_0;

		// Token: 0x04001A28 RID: 6696
		internal dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd dje_zY3PA294L7V6XC98ME6F2TNTEGK2RHRXDV8RMDMFFY8SC5PFVT6XHUEFYZ3EQ_ejd_0;

		// Token: 0x04001A29 RID: 6697
		internal StackPanel stackPanel_1;

		// Token: 0x04001A2A RID: 6698
		internal Button button_1;

		// Token: 0x04001A2B RID: 6699
		internal ComboBox comboBox_0;

		// Token: 0x04001A2C RID: 6700
		internal TextBlock textBlock_3;

		// Token: 0x04001A2D RID: 6701
		internal TextBlock textBlock_4;

		// Token: 0x04001A2E RID: 6702
		internal Image image_0;

		// Token: 0x04001A2F RID: 6703
		internal MaterialIcon materialIcon_0;

		// Token: 0x04001A30 RID: 6704
		internal TextBlock textBlock_5;

		// Token: 0x04001A31 RID: 6705
		internal Button button_2;

		// Token: 0x04001A32 RID: 6706
		internal TextBlock textBlock_6;

		// Token: 0x04001A33 RID: 6707
		internal Grid grid_0;

		// Token: 0x04001A34 RID: 6708
		internal Grid grid_1;

		// Token: 0x04001A35 RID: 6709
		internal Grid grid_2;

		// Token: 0x04001A36 RID: 6710
		internal Border border_1;

		// Token: 0x04001A37 RID: 6711
		internal StackPanel stackPanel_2;

		// Token: 0x04001A38 RID: 6712
		internal dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd dje_zJVWKGATLT7VT7VSSZ3EV7XPMRFL8PDNBDCBMYMGLD36PVMP29F8XS_ejd_0;

		// Token: 0x04001A39 RID: 6713
		private bool bool_0;

		// Token: 0x020006D5 RID: 1749
		[StructLayout(LayoutKind.Auto)]
		private struct Struct431 : IAsyncStateMachine
		{
			// Token: 0x0600255B RID: 9563 RVA: 0x00098088 File Offset: 0x00096288
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd @object = this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(@object.method_9)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct431>(ref awaiter, ref this);
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

			// Token: 0x0600255C RID: 9564 RVA: 0x00098148 File Offset: 0x00096348
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A3A RID: 6714
			public int int_0;

			// Token: 0x04001A3B RID: 6715
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A3C RID: 6716
			public dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;

			// Token: 0x04001A3D RID: 6717
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006D6 RID: 1750
		[StructLayout(LayoutKind.Auto)]
		private struct Struct432 : IAsyncStateMachine
		{
			// Token: 0x0600255D RID: 9565 RVA: 0x00098158 File Offset: 0x00096358
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd @object = this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(@object.method_2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct432>(ref awaiter, ref this);
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

			// Token: 0x0600255E RID: 9566 RVA: 0x00098218 File Offset: 0x00096418
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A3E RID: 6718
			public int int_0;

			// Token: 0x04001A3F RID: 6719
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A40 RID: 6720
			public dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;

			// Token: 0x04001A41 RID: 6721
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006D7 RID: 1751
		[StructLayout(LayoutKind.Auto)]
		private struct Struct433 : IAsyncStateMachine
		{
			// Token: 0x0600255F RID: 9567 RVA: 0x00098228 File Offset: 0x00096428
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd = this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_FF;
					}
					if (num != 1)
					{
						this.class770_0 = new dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Class770();
						this.class770_0.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0 = this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;
						dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Dispatcher.Invoke(new Action(this.class770_0.method_0));
						this.class770_0.class289_0 = new Class289(false, string.Empty, string.Empty);
						awaiter = Task.Run(new Func<Task>(this.class770_0.method_1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct433>(ref awaiter, ref this);
							return;
						}
						goto IL_FF;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_D7:
					awaiter.GetResult();
					goto IL_2A8;
					IL_FF:
					awaiter.GetResult();
					if (!this.class770_0.class289_0.Success)
					{
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.textBlock_1, this.class770_0.class289_0.Message, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
						if (!Class389.class504_0.method_64().smethod_7())
						{
							dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Dispatcher.Invoke(new Action(this.class770_0.method_2));
						}
						else
						{
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.textBlock_3, this.class770_0.class289_0.Message, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
							dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Dispatcher.Invoke(new Action(this.class770_0.method_3));
						}
						goto IL_2EA;
					}
					dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Dispatcher.Invoke(new Action(this.class770_0.method_4));
					Class535 @class = JsonConvert.DeserializeObject<Class535>(this.class770_0.class289_0.Message);
					Class389.class504_0.method_65(@class.Users.smethod_0());
					if (Class475.smethod_4(@class.Version))
					{
						Class389.class504_0.method_67(@class.NewVersionLink);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.textBlock_1, Class364.smethod_0("updavail"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
						dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Dispatcher.Invoke(new Action(this.class770_0.method_5));
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.button_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct433>(ref awaiter, ref this);
							return;
						}
						goto IL_D7;
					}
					else
					{
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.textBlock_1, Class364.smethod_0("uptodate"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					}
					IL_2A8:
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.textBlock_3, Class389.class504_0.method_64(), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class770_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_2EA:
				this.int_0 = -2;
				this.class770_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002560 RID: 9568 RVA: 0x00098558 File Offset: 0x00096758
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A42 RID: 6722
			public int int_0;

			// Token: 0x04001A43 RID: 6723
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A44 RID: 6724
			public dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;

			// Token: 0x04001A45 RID: 6725
			private dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Class770 class770_0;

			// Token: 0x04001A46 RID: 6726
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006D8 RID: 1752
		[StructLayout(LayoutKind.Auto)]
		private struct Struct434 : IAsyncStateMachine
		{
			// Token: 0x06002561 RID: 9569 RVA: 0x00098568 File Offset: 0x00096768
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd @object = this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(@object.method_8)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct434>(ref awaiter, ref this);
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

			// Token: 0x06002562 RID: 9570 RVA: 0x00098628 File Offset: 0x00096828
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A47 RID: 6727
			public int int_0;

			// Token: 0x04001A48 RID: 6728
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A49 RID: 6729
			public dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;

			// Token: 0x04001A4A RID: 6730
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006D9 RID: 1753
		[StructLayout(LayoutKind.Auto)]
		private struct Struct435 : IAsyncStateMachine
		{
			// Token: 0x06002563 RID: 9571 RVA: 0x00098638 File Offset: 0x00096838
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd = this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
					case 1:
					case 2:
					case 3:
						break;
					case 4:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_2F1;
					}
					case 5:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
						goto IL_3D5;
					}
					default:
						this.process_0 = Process.GetCurrentProcess();
						this.string_0 = this.process_0.MainModule.FileName;
						this.string_1 = Class186.string_4 + "\\BoosterX.exe";
						this.webClient_0 = new WebClient();
						break;
					}
					try
					{
						switch (num)
						{
						case 0:
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.int_0 = num4;
							break;
						}
						case 1:
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
							goto IL_14D;
						}
						case 2:
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num6 = -1;
							num = -1;
							this.int_0 = num6;
							goto IL_1E5;
						}
						case 3:
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num7 = -1;
							num = -1;
							this.int_0 = num7;
							goto IL_271;
						}
						default:
							this.webClient_0.Credentials = CredentialCache.DefaultNetworkCredentials;
							awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.textBlock_1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num8 = 0;
								num = 0;
								this.int_0 = num8;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct435>(ref awaiter, ref this);
								return;
							}
							break;
						}
						awaiter.GetResult();
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.button_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num9 = 1;
							num = 1;
							this.int_0 = num9;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct435>(ref awaiter, ref this);
							return;
						}
						IL_14D:
						awaiter.GetResult();
						dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.textBlock_1.Visibility = Visibility.Collapsed;
						dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.button_0.Visibility = Visibility.Collapsed;
						dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.progressBar_0.Opacity = 0.0;
						dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.progressBar_0.Visibility = Visibility.Visible;
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.progressBar_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num10 = 2;
							num = 2;
							this.int_0 = num10;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct435>(ref awaiter, ref this);
							return;
						}
						IL_1E5:
						awaiter.GetResult();
						this.webClient_0.DownloadProgressChanged += dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.method_11;
						awaiter = this.webClient_0.DownloadFileTaskAsync(new Uri(Class389.class504_0.method_66()), this.string_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num11 = 3;
							num = 3;
							this.int_0 = num11;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct435>(ref awaiter, ref this);
							return;
						}
						IL_271:
						awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.webClient_0 != null)
						{
							((IDisposable)this.webClient_0).Dispose();
						}
					}
					this.webClient_0 = null;
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num12 = 4;
						num = 4;
						this.int_0 = num12;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct435>(ref awaiter, ref this);
						return;
					}
					IL_2F1:
					awaiter.GetResult();
					FileStream fileStream = new FileStream(Class186.string_4 + "\\updatevals.txt", FileMode.Create);
					try
					{
						StreamWriter streamWriter = new StreamWriter(fileStream);
						try
						{
							streamWriter.WriteLine(this.process_0.ProcessName);
							streamWriter.WriteLine(this.string_1);
							streamWriter.WriteLine(this.string_0);
						}
						finally
						{
							if (num < 0 && streamWriter != null)
							{
								((IDisposable)streamWriter).Dispose();
							}
						}
					}
					finally
					{
						if (num < 0 && fileStream != null)
						{
							((IDisposable)fileStream).Dispose();
						}
					}
					Class650.smethod_4("BoosterX", Class186.string_4, "Resources.EmbedRes.Exes", "Updater.exe", false);
					awaiter = Task.Delay(200).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num13 = 5;
						num = 5;
						this.int_0 = num13;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Struct435>(ref awaiter, ref this);
						return;
					}
					IL_3D5:
					awaiter.GetResult();
					Process.Start(Class186.string_4 + "\\Updater.exe");
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.process_0 = null;
					this.string_0 = null;
					this.string_1 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.process_0 = null;
				this.string_0 = null;
				this.string_1 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06002564 RID: 9572 RVA: 0x00098AF4 File Offset: 0x00096CF4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A4B RID: 6731
			public int int_0;

			// Token: 0x04001A4C RID: 6732
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001A4D RID: 6733
			public dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;

			// Token: 0x04001A4E RID: 6734
			private Process process_0;

			// Token: 0x04001A4F RID: 6735
			private string string_0;

			// Token: 0x04001A50 RID: 6736
			private string string_1;

			// Token: 0x04001A51 RID: 6737
			private WebClient webClient_0;

			// Token: 0x04001A52 RID: 6738
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006DA RID: 1754
		private sealed class Class770
		{
			// Token: 0x06002566 RID: 9574 RVA: 0x00098B0C File Offset: 0x00096D0C
			internal void method_0()
			{
				this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0.textBlock_3.Text = Class364.smethod_0("Checkingtext");
				this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0.textBlock_1.Text = Class364.smethod_0("Checkingtext");
				this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0.textBlock_2.Text = "2.0";
			}

			// Token: 0x06002567 RID: 9575 RVA: 0x00098B64 File Offset: 0x00096D64
			internal Task method_1()
			{
				dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Class770.Struct436 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class770_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Class770.Struct436>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x06002568 RID: 9576 RVA: 0x00098BA8 File Offset: 0x00096DA8
			internal void method_2()
			{
				this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0.textBlock_3.Text = Class389.class504_0.method_64();
			}

			// Token: 0x06002569 RID: 9577 RVA: 0x00098BC4 File Offset: 0x00096DC4
			internal void method_3()
			{
				this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0.textBlock_3.FontSize = 13.0;
				this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0.textBlock_4.Visibility = Visibility.Collapsed;
			}

			// Token: 0x0600256A RID: 9578 RVA: 0x00098BF0 File Offset: 0x00096DF0
			internal void method_4()
			{
				this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0.textBlock_3.FontSize = 20.0;
				this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0.textBlock_4.Visibility = Visibility.Visible;
			}

			// Token: 0x0600256B RID: 9579 RVA: 0x00098C1C File Offset: 0x00096E1C
			internal void method_5()
			{
				this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0.button_0.Visibility = Visibility.Visible;
				this.dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0.border_0.Visibility = Visibility.Collapsed;
			}

			// Token: 0x04001A53 RID: 6739
			public dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;

			// Token: 0x04001A54 RID: 6740
			public Class289 class289_0;

			// Token: 0x020006DB RID: 1755
			[StructLayout(LayoutKind.Auto)]
			private struct Struct436 : IAsyncStateMachine
			{
				// Token: 0x0600256C RID: 9580 RVA: 0x00098C40 File Offset: 0x00096E40
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Class770 @class = this.class770_0;
					try
					{
						TaskAwaiter<Class289> awaiter;
						if (num != 0)
						{
							awaiter = Class166.smethod_1(Class193.uri_2, null).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Class770.Struct436>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<Class289>);
							this.int_0 = -1;
						}
						Class289 result = awaiter.GetResult();
						@class.class289_0 = result;
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

				// Token: 0x0600256D RID: 9581 RVA: 0x00098D04 File Offset: 0x00096F04
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x04001A55 RID: 6741
				public int int_0;

				// Token: 0x04001A56 RID: 6742
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x04001A57 RID: 6743
				public dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd.Class770 class770_0;

				// Token: 0x04001A58 RID: 6744
				private TaskAwaiter<Class289> taskAwaiter_0;
			}
		}
	}
}
