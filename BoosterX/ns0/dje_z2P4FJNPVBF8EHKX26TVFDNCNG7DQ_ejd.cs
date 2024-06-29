using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;

namespace ns0
{
	// Token: 0x02000690 RID: 1680
	public sealed class dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd : Window, IComponentConnector
	{
		// Token: 0x06002400 RID: 9216 RVA: 0x0008EDF4 File Offset: 0x0008CFF4
		public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd(Type type_0 = null)
		{
			if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Count<Process>() > 1)
			{
				Process.GetCurrentProcess().Kill();
			}
			this.InitializeComponent();
			Class358.smethod_0().frame_0 = this.frame_0;
			base.DataContext = new Class494();
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_16(new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42(this.method_0));
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_14(new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43(this.method_1));
			bool? flag = Class389.class504_0.method_56();
			if (!(flag.GetValueOrDefault() & flag != null))
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.grid_1);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(this.grid_1);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(this.grid_2);
				return;
			}
			if (type_0 == null)
			{
				this.radioButton_0.IsChecked = new bool?(true);
				return;
			}
			if (type_0 == typeof(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd))
			{
				Class358.smethod_0().method_3(typeof(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd), this.frame_0);
				return;
			}
			if (type_0 == typeof(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd))
			{
				Class358.smethod_0().method_3(typeof(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd), this.frame_0);
			}
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x0008EF28 File Offset: 0x0008D128
		private void method_0()
		{
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct391 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct391>(ref @struct);
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0008EF60 File Offset: 0x0008D160
		private void method_1()
		{
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct394 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct394>(ref @struct);
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x0008EF98 File Offset: 0x0008D198
		public void method_2()
		{
			double primaryScreenWidth = SystemParameters.PrimaryScreenWidth;
			double primaryScreenHeight = SystemParameters.PrimaryScreenHeight;
			double width = base.Width;
			double height = base.Height;
			base.Left = primaryScreenWidth / 2.0 - width / 2.0;
			base.Top = primaryScreenHeight / 2.0 - height / 2.0;
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0008EFFC File Offset: 0x0008D1FC
		private void method_3(object sender, RoutedEventArgs p1)
		{
			if (!Class389.class504_0.method_12().smethod_1())
			{
				double? num = Class389.class504_0.method_12();
				double num2 = 0.0;
				if ((num.GetValueOrDefault() > num2 & num != null) && !Class389.class504_0.method_14().smethod_1())
				{
					num = Class389.class504_0.method_14();
					num2 = 0.0;
					if ((num.GetValueOrDefault() > num2 & num != null) && !Class389.class504_0.method_14().smethod_1())
					{
						num = Class389.class504_0.method_14();
						num2 = 0.0;
						if ((num.GetValueOrDefault() > num2 & num != null) && !Class389.class504_0.Width.smethod_1())
						{
							num = Class389.class504_0.Width;
							num2 = 0.0;
							if (num.GetValueOrDefault() > num2 & num != null)
							{
								base.Top = Class389.class504_0.method_12().Value;
								base.Left = Class389.class504_0.method_14().Value;
								base.Height = Class389.class504_0.Height.Value;
								base.Width = Class389.class504_0.Width.Value;
							}
						}
					}
				}
			}
			this.bool_1 = true;
			bool? flag = Class389.class504_0.method_16();
			if (flag.GetValueOrDefault() & flag != null)
			{
				this.button_1_Click(sender, p1);
			}
			if (base.WindowState == WindowState.Minimized)
			{
				base.WindowState = WindowState.Normal;
			}
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0008F1A8 File Offset: 0x0008D3A8
		public void button_2_Click(object sender, RoutedEventArgs p1)
		{
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct393 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct393>(ref @struct);
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0008F1E0 File Offset: 0x0008D3E0
		private void method_4()
		{
			try
			{
				Class253.smethod_3();
			}
			catch (object obj)
			{
			}
			try
			{
				Class380.smethod_1();
			}
			catch (object obj2)
			{
			}
			Class354.smethod_0();
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0008F224 File Offset: 0x0008D424
		private void method_5(object sender, MouseButtonEventArgs p1)
		{
			if (p1.LeftButton == MouseButtonState.Pressed)
			{
				base.DragMove();
			}
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0008F238 File Offset: 0x0008D438
		private void method_6()
		{
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct392 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct392>(ref @struct);
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0008F270 File Offset: 0x0008D470
		private void method_7(object sender, MouseButtonEventArgs p1)
		{
			if (p1.LeftButton == MouseButtonState.Pressed)
			{
				base.DragMove();
			}
			if (p1.LeftButton == MouseButtonState.Released && this.bool_2)
			{
				this.button_1_Click(sender, p1);
				return;
			}
			this.method_6();
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0008F2A0 File Offset: 0x0008D4A0
		private void method_8(object sender, EventArgs p1)
		{
			this.button_2_Click(null, null);
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0008F2AC File Offset: 0x0008D4AC
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			base.WindowState = WindowState.Minimized;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0008F2B8 File Offset: 0x0008D4B8
		private void method_9(object sender, SizeChangedEventArgs p1)
		{
			if (base.Width == 1072.0 && this.bool_0)
			{
				this.bool_0 = false;
			}
			this.method_16();
			this.rectangleGeometry_0.Rect = new Rect(0.0, 0.0, base.ActualWidth, base.ActualWidth);
			if (this.bool_1)
			{
				Class389.class504_0.Height = new double?(base.ActualHeight);
				Class389.class504_0.Width = new double?(base.ActualWidth);
			}
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x0008F34C File Offset: 0x0008D54C
		private void method_10(object sender, EventArgs p1)
		{
			if (this.bool_1)
			{
				Class389.class504_0.method_13(new double?(base.Top));
				Class389.class504_0.method_15(new double?(base.Left));
			}
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0008F380 File Offset: 0x0008D580
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			if (this.bool_0)
			{
				this.border_0.CornerRadius = new CornerRadius(20.0);
				this.rectangleGeometry_0.RadiusX = 20.0;
				this.rectangleGeometry_0.RadiusY = 20.0;
				base.WindowState = WindowState.Normal;
				base.Width = 1072.0;
				base.Height = 754.0;
				this.bool_0 = false;
			}
			else
			{
				this.border_0.CornerRadius = new CornerRadius(0.0);
				this.rectangleGeometry_0.RadiusX = 0.0;
				this.rectangleGeometry_0.RadiusY = 0.0;
				base.WindowState = WindowState.Maximized;
				this.bool_0 = true;
			}
			if (this.bool_1)
			{
				Class389.class504_0.method_17(new bool?(base.WindowState == WindowState.Maximized));
			}
			this.method_16();
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x0008F47C File Offset: 0x0008D67C
		private void grid_1_MouseEnter(object sender, MouseEventArgs p1)
		{
			if (base.ActualWidth <= 1500.0)
			{
				this.method_14();
				this.method_11();
				this.method_17();
			}
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x0008F4A8 File Offset: 0x0008D6A8
		private void grid_1_MouseLeave(object sender, MouseEventArgs p1)
		{
			if (base.ActualWidth <= 1500.0)
			{
				this.method_13();
				this.method_12();
				this.method_18();
			}
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0008F4D4 File Offset: 0x0008D6D4
		private void method_11()
		{
			Task.Run(new Action(this.method_25));
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0008F4E8 File Offset: 0x0008D6E8
		private void method_12()
		{
			Task.Run(new Action(this.method_27));
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x0008F4FC File Offset: 0x0008D6FC
		private void method_13()
		{
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.grid_1, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1, FrameworkElement.WidthProperty, 100.0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.border_4, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1, FrameworkElement.WidthProperty, 100.0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.border_2, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1, FrameworkElement.WidthProperty, 100.0);
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x0008F574 File Offset: 0x0008D774
		private void method_14()
		{
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.grid_1, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1, FrameworkElement.WidthProperty, 230.0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.border_4, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1, FrameworkElement.WidthProperty, 230.0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.border_2, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1, FrameworkElement.WidthProperty, 310.0);
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x0008F5EC File Offset: 0x0008D7EC
		private void method_15()
		{
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.grid_1, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1, FrameworkElement.WidthProperty, 230.0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.border_4, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1, FrameworkElement.WidthProperty, 230.0);
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x0008F640 File Offset: 0x0008D840
		private void method_16()
		{
			if (base.ActualWidth <= 1500.0)
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.border_1, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1, FrameworkElement.WidthProperty, 140.0);
				this.method_13();
				this.method_18();
			}
			else
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(this.border_1, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1, FrameworkElement.WidthProperty, 270.0);
				this.method_15();
				this.method_17();
			}
			this.border_4.Height = base.ActualHeight - 40.0;
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x0008F6E4 File Offset: 0x0008D8E4
		private void method_17()
		{
			base.Dispatcher.Invoke(new Action(this.method_29));
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x0008F700 File Offset: 0x0008D900
		private void method_18()
		{
			base.Dispatcher.Invoke(new Action(this.method_30));
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x0008F71C File Offset: 0x0008D91C
		private void radioButton_0_Checked(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd), this.frame_0);
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x0008F738 File Offset: 0x0008D938
		private void radioButton_1_Checked(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd), this.frame_0);
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0008F754 File Offset: 0x0008D954
		private void radioButton_4_Checked(object sender, RoutedEventArgs p1)
		{
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x0008F758 File Offset: 0x0008D958
		private void radioButton_3_Checked(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd), this.frame_0);
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x0008F774 File Offset: 0x0008D974
		private void radioButton_6_Checked(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_zQQ3WV9B57B4Q2DKX7UXQQ3W7C8NZFEHVBRNTGQEURUFDS2REYAJR4_ejd), this.frame_0);
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x0008F790 File Offset: 0x0008D990
		private void radioButton_7_Checked(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_zF5RBQBAG5YAJ8ZN4XLUCQ6DCAWKZ7LNPXW2R3TZDK3BHNS2_ejd), this.frame_0);
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x0008F7AC File Offset: 0x0008D9AC
		private void radioButton_2_Checked(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_zA6HRDGVQ449XDH4D5NPJHBXAQ5BZC26NDGXJQ5PLSURH2QZ_ejd), this.frame_0);
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x0008F7C8 File Offset: 0x0008D9C8
		private void radioButton_5_Checked(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_zS47NUGZB4NMDHDGFGZN8R6MZMSTZC22PP5QJMCVY7U78FP549R6VZ_ejd), this.frame_0);
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0008F7E4 File Offset: 0x0008D9E4
		private void method_19(object sender, RoutedEventArgs p1)
		{
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0008F7E8 File Offset: 0x0008D9E8
		private void button_4_Click(object sender, RoutedEventArgs p1)
		{
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct390 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct390>(ref @struct);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0008F820 File Offset: 0x0008DA20
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			Process.Start("https://boosterx.org/useragreement");
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0008F830 File Offset: 0x0008DA30
		public void method_20(double double_0)
		{
			BlurEffect effect = new BlurEffect
			{
				KernelType = KernelType.Gaussian,
				Radius = 0.0
			};
			this.border_0.Effect = effect;
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x0008F868 File Offset: 0x0008DA68
		public void method_21()
		{
			this.border_0.Effect = null;
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0008F878 File Offset: 0x0008DA78
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_3)
			{
				return;
			}
			this.bool_3 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mainwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x0008F8A8 File Offset: 0x0008DAA8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_22(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x0008F8B4 File Offset: 0x0008DAB4
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)target).Closed += this.method_8;
				((dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)target).Loaded += this.method_3;
				((dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)target).LocationChanged += this.method_10;
				((dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)target).SizeChanged += this.method_9;
				return;
			case 2:
				this.border_0 = (Border)target;
				return;
			case 3:
				this.rectangleGeometry_0 = (RectangleGeometry)target;
				return;
			case 4:
				this.grid_0 = (Grid)target;
				return;
			case 5:
				this.border_1 = (Border)target;
				return;
			case 6:
				this.frame_0 = (Frame)target;
				return;
			case 7:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 8:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 9:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 10:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 11:
				this.border_2 = (Border)target;
				return;
			case 12:
				this.grid_1 = (Grid)target;
				this.grid_1.MouseEnter += this.grid_1_MouseEnter;
				this.grid_1.MouseLeave += this.grid_1_MouseLeave;
				return;
			case 13:
				this.border_3 = (Border)target;
				return;
			case 14:
				this.border_4 = (Border)target;
				return;
			case 15:
				this.radioButton_0 = (RadioButton)target;
				this.radioButton_0.Checked += this.radioButton_0_Checked;
				return;
			case 16:
				this.geometryDrawing_0 = (GeometryDrawing)target;
				return;
			case 17:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 18:
				this.radioButton_1 = (RadioButton)target;
				this.radioButton_1.Checked += this.radioButton_1_Checked;
				return;
			case 19:
				this.geometryDrawing_1 = (GeometryDrawing)target;
				return;
			case 20:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 21:
				this.radioButton_2 = (RadioButton)target;
				this.radioButton_2.Checked += this.radioButton_2_Checked;
				return;
			case 22:
				this.geometryDrawing_2 = (GeometryDrawing)target;
				return;
			case 23:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 24:
				this.radioButton_3 = (RadioButton)target;
				this.radioButton_3.Checked += this.radioButton_3_Checked;
				return;
			case 25:
				this.geometryDrawing_3 = (GeometryDrawing)target;
				return;
			case 26:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 27:
				this.radioButton_4 = (RadioButton)target;
				this.radioButton_4.Checked += this.radioButton_4_Checked;
				return;
			case 28:
				this.geometryDrawing_4 = (GeometryDrawing)target;
				return;
			case 29:
				this.textBlock_4 = (TextBlock)target;
				return;
			case 30:
				this.radioButton_5 = (RadioButton)target;
				this.radioButton_5.Checked += this.radioButton_5_Checked;
				return;
			case 31:
				this.textBlock_5 = (TextBlock)target;
				return;
			case 32:
				this.radioButton_6 = (RadioButton)target;
				this.radioButton_6.Checked += this.radioButton_6_Checked;
				return;
			case 33:
				this.geometryDrawing_5 = (GeometryDrawing)target;
				return;
			case 34:
				this.textBlock_6 = (TextBlock)target;
				return;
			case 35:
				this.radioButton_7 = (RadioButton)target;
				this.radioButton_7.Checked += this.radioButton_7_Checked;
				return;
			case 36:
				this.geometryDrawing_6 = (GeometryDrawing)target;
				return;
			case 37:
				this.textBlock_7 = (TextBlock)target;
				return;
			case 38:
				this.textBlock_8 = (TextBlock)target;
				return;
			case 39:
				this.grid_2 = (Grid)target;
				return;
			case 40:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 41:
				this.button_4 = (Button)target;
				this.button_4.Click += this.button_4_Click;
				return;
			case 42:
				((Button)target).Click += this.button_2_Click;
				return;
			default:
				this.bool_3 = true;
				return;
			}
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x0008FD50 File Offset: 0x0008DF50
		private void method_23()
		{
			this.textBlock_8.Text = Class364.smethod_0("Checkingtext");
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x0008FD68 File Offset: 0x0008DF68
		private Task method_24()
		{
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct395 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct395>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0008FDAC File Offset: 0x0008DFAC
		private void method_25()
		{
			base.Dispatcher.Invoke(new Action(this.method_26));
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0008FDC8 File Offset: 0x0008DFC8
		private void method_26()
		{
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				Duration = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1,
				AccelerationRatio = 0.5,
				DecelerationRatio = 0.5
			};
			Timeline.SetDesiredFrameRate(doubleAnimation, new int?(60));
			doubleAnimation.To = new double?(0.5);
			this.border_2.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
			doubleAnimation.To = new double?((double)1f);
			this.border_3.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x0008FE5C File Offset: 0x0008E05C
		private void method_27()
		{
			base.Dispatcher.Invoke(new Action(this.method_28));
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x0008FE78 File Offset: 0x0008E078
		private void method_28()
		{
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				Duration = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.timeSpan_1,
				AccelerationRatio = 0.5,
				DecelerationRatio = 0.5
			};
			Timeline.SetDesiredFrameRate(doubleAnimation, new int?(60));
			doubleAnimation.To = new double?(0.0);
			this.border_2.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
			this.border_3.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x0008FEFC File Offset: 0x0008E0FC
		private void method_29()
		{
			((Storyboard)base.FindResource("GoVisibleWithVisibility")).Begin(this.textBlock_0);
			((Storyboard)base.FindResource("GoVisibleWithVisibility")).Begin(this.textBlock_1);
			((Storyboard)base.FindResource("GoVisibleWithVisibility")).Begin(this.textBlock_4);
			((Storyboard)base.FindResource("GoVisibleWithVisibility")).Begin(this.textBlock_6);
			((Storyboard)base.FindResource("GoVisibleWithVisibility")).Begin(this.textBlock_7);
			((Storyboard)base.FindResource("GoVisibleWithVisibility")).Begin(this.textBlock_2);
			((Storyboard)base.FindResource("GoVisibleWithVisibility")).Begin(this.textBlock_3);
			((Storyboard)base.FindResource("GoVisibleWithVisibility")).Begin(this.textBlock_5);
			((Storyboard)base.FindResource("GoVisibleWithVisibility")).Begin(this.textBlock_8);
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0008FFFC File Offset: 0x0008E1FC
		private void method_30()
		{
			((Storyboard)base.FindResource("GoDarkWithVisibility")).Begin(this.textBlock_0);
			((Storyboard)base.FindResource("GoDarkWithVisibility")).Begin(this.textBlock_1);
			((Storyboard)base.FindResource("GoDarkWithVisibility")).Begin(this.textBlock_4);
			((Storyboard)base.FindResource("GoDarkWithVisibility")).Begin(this.textBlock_6);
			((Storyboard)base.FindResource("GoDarkWithVisibility")).Begin(this.textBlock_7);
			((Storyboard)base.FindResource("GoDarkWithVisibility")).Begin(this.textBlock_2);
			((Storyboard)base.FindResource("GoDarkWithVisibility")).Begin(this.textBlock_3);
			((Storyboard)base.FindResource("GoDarkWithVisibility")).Begin(this.textBlock_5);
			((Storyboard)base.FindResource("GoDarkWithVisibility")).Begin(this.textBlock_8);
		}

		// Token: 0x04001886 RID: 6278
		public bool bool_0;

		// Token: 0x04001887 RID: 6279
		public bool bool_1;

		// Token: 0x04001888 RID: 6280
		private bool bool_2;

		// Token: 0x04001889 RID: 6281
		internal Border border_0;

		// Token: 0x0400188A RID: 6282
		internal RectangleGeometry rectangleGeometry_0;

		// Token: 0x0400188B RID: 6283
		internal Grid grid_0;

		// Token: 0x0400188C RID: 6284
		internal Border border_1;

		// Token: 0x0400188D RID: 6285
		internal Frame frame_0;

		// Token: 0x0400188E RID: 6286
		public StackPanel stackPanel_0;

		// Token: 0x0400188F RID: 6287
		internal Button button_0;

		// Token: 0x04001890 RID: 6288
		internal Button button_1;

		// Token: 0x04001891 RID: 6289
		internal Button button_2;

		// Token: 0x04001892 RID: 6290
		internal Border border_2;

		// Token: 0x04001893 RID: 6291
		internal Grid grid_1;

		// Token: 0x04001894 RID: 6292
		internal Border border_3;

		// Token: 0x04001895 RID: 6293
		internal Border border_4;

		// Token: 0x04001896 RID: 6294
		internal RadioButton radioButton_0;

		// Token: 0x04001897 RID: 6295
		internal GeometryDrawing geometryDrawing_0;

		// Token: 0x04001898 RID: 6296
		internal TextBlock textBlock_0;

		// Token: 0x04001899 RID: 6297
		internal RadioButton radioButton_1;

		// Token: 0x0400189A RID: 6298
		internal GeometryDrawing geometryDrawing_1;

		// Token: 0x0400189B RID: 6299
		internal TextBlock textBlock_1;

		// Token: 0x0400189C RID: 6300
		internal RadioButton radioButton_2;

		// Token: 0x0400189D RID: 6301
		internal GeometryDrawing geometryDrawing_2;

		// Token: 0x0400189E RID: 6302
		internal TextBlock textBlock_2;

		// Token: 0x0400189F RID: 6303
		internal RadioButton radioButton_3;

		// Token: 0x040018A0 RID: 6304
		internal GeometryDrawing geometryDrawing_3;

		// Token: 0x040018A1 RID: 6305
		internal TextBlock textBlock_3;

		// Token: 0x040018A2 RID: 6306
		internal RadioButton radioButton_4;

		// Token: 0x040018A3 RID: 6307
		internal GeometryDrawing geometryDrawing_4;

		// Token: 0x040018A4 RID: 6308
		internal TextBlock textBlock_4;

		// Token: 0x040018A5 RID: 6309
		internal RadioButton radioButton_5;

		// Token: 0x040018A6 RID: 6310
		internal TextBlock textBlock_5;

		// Token: 0x040018A7 RID: 6311
		internal RadioButton radioButton_6;

		// Token: 0x040018A8 RID: 6312
		internal GeometryDrawing geometryDrawing_5;

		// Token: 0x040018A9 RID: 6313
		internal TextBlock textBlock_6;

		// Token: 0x040018AA RID: 6314
		internal RadioButton radioButton_7;

		// Token: 0x040018AB RID: 6315
		internal GeometryDrawing geometryDrawing_6;

		// Token: 0x040018AC RID: 6316
		internal TextBlock textBlock_7;

		// Token: 0x040018AD RID: 6317
		internal TextBlock textBlock_8;

		// Token: 0x040018AE RID: 6318
		internal Grid grid_2;

		// Token: 0x040018AF RID: 6319
		internal Button button_3;

		// Token: 0x040018B0 RID: 6320
		internal Button button_4;

		// Token: 0x040018B1 RID: 6321
		private bool bool_3;

		// Token: 0x02000691 RID: 1681
		public struct GStruct10
		{
			// Token: 0x06002431 RID: 9265 RVA: 0x000900FC File Offset: 0x0008E2FC
			public GStruct10(int int_2, int int_3)
			{
				this.int_0 = int_2;
				this.int_1 = int_3;
			}

			// Token: 0x040018B2 RID: 6322
			public int int_0;

			// Token: 0x040018B3 RID: 6323
			public int int_1;
		}

		// Token: 0x02000692 RID: 1682
		[StructLayout(LayoutKind.Auto)]
		private struct Struct390 : IAsyncStateMachine
		{
			// Token: 0x06002432 RID: 9266 RVA: 0x0009010C File Offset: 0x0008E30C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd = this.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						Class389.class504_0.method_57(new bool?(true));
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_4();
						dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.radioButton_0.IsChecked = new bool?(true);
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.grid_2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct390>(ref awaiter, ref this);
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
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.grid_1);
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

			// Token: 0x06002433 RID: 9267 RVA: 0x000901F4 File Offset: 0x0008E3F4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040018B4 RID: 6324
			public int int_0;

			// Token: 0x040018B5 RID: 6325
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040018B6 RID: 6326
			public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;

			// Token: 0x040018B7 RID: 6327
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000693 RID: 1683
		public struct GStruct11
		{
			// Token: 0x040018B8 RID: 6328
			public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.GStruct10 gstruct10_0;

			// Token: 0x040018B9 RID: 6329
			public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.GStruct10 gstruct10_1;

			// Token: 0x040018BA RID: 6330
			public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.GStruct10 gstruct10_2;

			// Token: 0x040018BB RID: 6331
			public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.GStruct10 gstruct10_3;

			// Token: 0x040018BC RID: 6332
			public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.GStruct10 gstruct10_4;
		}

		// Token: 0x02000694 RID: 1684
		[StructLayout(LayoutKind.Auto)]
		private struct Struct391 : IAsyncStateMachine
		{
			// Token: 0x06002434 RID: 9268 RVA: 0x00090204 File Offset: 0x0008E404
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd = this.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Dispatcher.InvokeAsync(new Action(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.method_23)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct391>(ref awaiter, ref this);
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

			// Token: 0x06002435 RID: 9269 RVA: 0x000902C8 File Offset: 0x0008E4C8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040018BD RID: 6333
			public int int_0;

			// Token: 0x040018BE RID: 6334
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040018BF RID: 6335
			public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;

			// Token: 0x040018C0 RID: 6336
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000695 RID: 1685
		[StructLayout(LayoutKind.Auto)]
		private struct Struct392 : IAsyncStateMachine
		{
			// Token: 0x06002436 RID: 9270 RVA: 0x000902D8 File Offset: 0x0008E4D8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd = this.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.bool_2 = true;
						awaiter = Task.Delay(200).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct392>(ref awaiter, ref this);
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
					dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.bool_2 = false;
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

			// Token: 0x06002437 RID: 9271 RVA: 0x0009039C File Offset: 0x0008E59C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040018C1 RID: 6337
			public int int_0;

			// Token: 0x040018C2 RID: 6338
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040018C3 RID: 6339
			public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;

			// Token: 0x040018C4 RID: 6340
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000696 RID: 1686
		[StructLayout(LayoutKind.Auto)]
		private struct Struct393 : IAsyncStateMachine
		{
			// Token: 0x06002438 RID: 9272 RVA: 0x000903AC File Offset: 0x0008E5AC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd = this.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						Class627.smethod_1();
						dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.method_4();
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct393>(ref awaiter, ref this);
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
					Application.Current.Shutdown();
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

			// Token: 0x06002439 RID: 9273 RVA: 0x00090474 File Offset: 0x0008E674
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040018C5 RID: 6341
			public int int_0;

			// Token: 0x040018C6 RID: 6342
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040018C7 RID: 6343
			public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;

			// Token: 0x040018C8 RID: 6344
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000697 RID: 1687
		[StructLayout(LayoutKind.Auto)]
		private struct Struct394 : IAsyncStateMachine
		{
			// Token: 0x0600243A RID: 9274 RVA: 0x00090484 File Offset: 0x0008E684
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd = this.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;
				try
				{
					TaskAwaiter<Task> awaiter;
					if (num != 0)
					{
						awaiter = dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Dispatcher.InvokeAsync<Task>(new Func<Task>(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.method_24)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct394>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Task>);
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

			// Token: 0x0600243B RID: 9275 RVA: 0x00090548 File Offset: 0x0008E748
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040018C9 RID: 6345
			public int int_0;

			// Token: 0x040018CA RID: 6346
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040018CB RID: 6347
			public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;

			// Token: 0x040018CC RID: 6348
			private TaskAwaiter<Task> taskAwaiter_0;
		}

		// Token: 0x02000698 RID: 1688
		[StructLayout(LayoutKind.Auto)]
		private struct Struct395 : IAsyncStateMachine
		{
			// Token: 0x0600243C RID: 9276 RVA: 0x00090558 File Offset: 0x0008E758
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd = this.dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.double_0 = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.double_0;
						if (this.double_0 < 0.0)
						{
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.textBlock_8, Class364.smethod_0("unknowserror"));
							goto IL_B1;
						}
						awaiter = Task.Delay(3000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Struct395>(ref awaiter, ref this);
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
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_39(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.textBlock_8, this.double_0);
					IL_B1:;
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

			// Token: 0x0600243D RID: 9277 RVA: 0x00090654 File Offset: 0x0008E854
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040018CD RID: 6349
			public int int_0;

			// Token: 0x040018CE RID: 6350
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040018CF RID: 6351
			public dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd_0;

			// Token: 0x040018D0 RID: 6352
			private double double_0;

			// Token: 0x040018D1 RID: 6353
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
