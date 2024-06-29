using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200069D RID: 1693
	public sealed class dje_z4EFBE23NRXT78H3EAL45CK9M5K537HLZVTED9PC5FL6WLE8YYJD3VFKL5QNA_ejd : Page, IComponentConnector
	{
		// Token: 0x06002450 RID: 9296 RVA: 0x000909E4 File Offset: 0x0008EBE4
		public dje_z4EFBE23NRXT78H3EAL45CK9M5K537HLZVTED9PC5FL6WLE8YYJD3VFKL5QNA_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x000909FC File Offset: 0x0008EBFC
		private void method_0(bool bool_1)
		{
			this.button_2.IsEnabled = false;
			this.checkBox_0.IsChecked = new bool?(!Class585.struct13_0.method_0());
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_0, Class585.struct13_0.method_0() ? Class364.smethod_0("enabled") : Class364.smethod_0("disabled"), Class585.struct13_0.method_0() ? dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd : dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
			base.DataContext = null;
			base.DataContext = Class462.smethod_0(bool_1);
			this.radioButton_0.IsChecked = new bool?(true);
			this.button_2.IsEnabled = true;
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00090AB4 File Offset: 0x0008ECB4
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0(true);
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x00090AC0 File Offset: 0x0008ECC0
		public void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class462.smethod_2();
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00090AC8 File Offset: 0x0008ECC8
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class462.smethod_3();
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x00090AD0 File Offset: 0x0008ECD0
		private void checkBox_0_Checked(object sender, RoutedEventArgs p1)
		{
			if (!Class585.struct13_0.method_0())
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_0, Class364.smethod_0("prorequired"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				return;
			}
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_1 = false;
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_0, Class364.smethod_0("disabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00090B24 File Offset: 0x0008ED24
		private void checkBox_0_Unchecked(object sender, RoutedEventArgs p1)
		{
			if (!Class585.struct13_0.method_0())
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_0, Class364.smethod_0("prorequired"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				return;
			}
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_1 = true;
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_0, Class364.smethod_0("enabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x00090B78 File Offset: 0x0008ED78
		private void method_1()
		{
			this.stackPanel_0.Visibility = Visibility.Collapsed;
			this.itemsControl_0.Visibility = Visibility.Collapsed;
			this.stackPanel_1.Visibility = Visibility.Collapsed;
			this.itemsControl_1.Visibility = Visibility.Collapsed;
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x00090BAC File Offset: 0x0008EDAC
		private void radioButton_0_Checked(object sender, RoutedEventArgs p1)
		{
			this.stackPanel_0.Visibility = Visibility.Visible;
			this.itemsControl_0.Visibility = Visibility.Visible;
			this.stackPanel_1.Visibility = Visibility.Visible;
			this.itemsControl_1.Visibility = Visibility.Visible;
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x00090BE0 File Offset: 0x0008EDE0
		private void method_2(object sender, RoutedEventArgs p1)
		{
			this.method_1();
			this.stackPanel_0.Visibility = Visibility.Visible;
			this.itemsControl_0.Visibility = Visibility.Visible;
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00090C00 File Offset: 0x0008EE00
		private void method_3(object sender, RoutedEventArgs p1)
		{
			this.method_1();
			this.stackPanel_1.Visibility = Visibility.Visible;
			this.itemsControl_1.Visibility = Visibility.Visible;
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x00090C20 File Offset: 0x0008EE20
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/winappspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00090C50 File Offset: 0x0008EE50
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
				this.textBlock_0 = (TextBlock)target;
				return;
			case 5:
				this.checkBox_0 = (CheckBox)target;
				this.checkBox_0.Checked += this.checkBox_0_Checked;
				this.checkBox_0.Unchecked += this.checkBox_0_Unchecked;
				return;
			case 6:
				this.radioButton_0 = (RadioButton)target;
				this.radioButton_0.Checked += this.radioButton_0_Checked;
				return;
			case 7:
				((RadioButton)target).Checked += this.method_2;
				return;
			case 8:
				((RadioButton)target).Checked += this.method_3;
				return;
			case 9:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 10:
				this.checkBox_1 = (CheckBox)target;
				return;
			case 11:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			case 12:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 13:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 14:
				this.checkBox_2 = (CheckBox)target;
				return;
			case 15:
				this.itemsControl_1 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040018E5 RID: 6373
		internal Button button_0;

		// Token: 0x040018E6 RID: 6374
		internal Button button_1;

		// Token: 0x040018E7 RID: 6375
		internal Button button_2;

		// Token: 0x040018E8 RID: 6376
		internal TextBlock textBlock_0;

		// Token: 0x040018E9 RID: 6377
		internal CheckBox checkBox_0;

		// Token: 0x040018EA RID: 6378
		internal RadioButton radioButton_0;

		// Token: 0x040018EB RID: 6379
		internal StackPanel stackPanel_0;

		// Token: 0x040018EC RID: 6380
		internal CheckBox checkBox_1;

		// Token: 0x040018ED RID: 6381
		internal ItemsControl itemsControl_0;

		// Token: 0x040018EE RID: 6382
		internal StackPanel stackPanel_1;

		// Token: 0x040018EF RID: 6383
		internal TextBlock textBlock_1;

		// Token: 0x040018F0 RID: 6384
		internal CheckBox checkBox_2;

		// Token: 0x040018F1 RID: 6385
		internal ItemsControl itemsControl_1;

		// Token: 0x040018F2 RID: 6386
		private bool bool_0;
	}
}
