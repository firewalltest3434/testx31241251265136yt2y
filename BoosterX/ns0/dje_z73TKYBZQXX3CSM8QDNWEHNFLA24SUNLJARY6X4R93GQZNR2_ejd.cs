using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x020006C2 RID: 1730
	public sealed class dje_z73TKYBZQXX3CSM8QDNWEHNFLA24SUNLJARY6X4R93GQZNR2_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060024F8 RID: 9464 RVA: 0x000952F4 File Offset: 0x000934F4
		public dje_z73TKYBZQXX3CSM8QDNWEHNFLA24SUNLJARY6X4R93GQZNR2_ejd()
		{
			base.DataContextChanged += this.dje_z73TKYBZQXX3CSM8QDNWEHNFLA24SUNLJARY6X4R93GQZNR2_ejd_DataContextChanged;
			this.InitializeComponent();
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00095314 File Offset: 0x00093514
		public GClass151 method_0()
		{
			return this.gclass151_0;
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x0009531C File Offset: 0x0009351C
		public void method_1(GClass151 gclass151_1)
		{
			this.gclass151_0 = gclass151_1;
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00095328 File Offset: 0x00093528
		private void method_2(object sender, PropertyChangedEventArgs p1)
		{
			if (p1.PropertyName == "ShowChildList")
			{
				this.method_4();
			}
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00095344 File Offset: 0x00093544
		private void dje_z73TKYBZQXX3CSM8QDNWEHNFLA24SUNLJARY6X4R93GQZNR2_ejd_DataContextChanged(object sender, DependencyPropertyChangedEventArgs p1)
		{
			GClass151 gclass = p1.OldValue as GClass151;
			if (gclass != null)
			{
				gclass.PropertyChanged -= this.method_2;
			}
			GClass151 gclass2 = p1.NewValue as GClass151;
			if (gclass2 != null)
			{
				this.method_1(gclass2);
				this.method_0().PropertyChanged += this.method_2;
				this.method_3();
				this.method_4();
			}
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000953B0 File Offset: 0x000935B0
		private void method_3()
		{
			this.grid_1.Visibility = (this.method_0().ShowDescription ? Visibility.Visible : Visibility.Collapsed);
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000953D0 File Offset: 0x000935D0
		private void method_4()
		{
			this.border_0.Visibility = (this.method_0().ShowChildList ? Visibility.Visible : Visibility.Collapsed);
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000953F0 File Offset: 0x000935F0
		private void method_5(object sender, RoutedEventArgs p1)
		{
			this.method_0().ShowChildList = !this.method_0().ShowChildList;
			p1.Handled = true;
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x00095414 File Offset: 0x00093614
		private void method_6(object sender, RoutedEventArgs p1)
		{
			Class185.smethod_22("taskkill /F /IM regedit.exe");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit", "LastKey", "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\" + this.method_0().ServiceName);
			Class185.smethod_24("regedit");
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x00095450 File Offset: 0x00093650
		private void method_7(object sender, RoutedEventArgs p1)
		{
			this.method_0().IsUserChecked = false;
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00095460 File Offset: 0x00093660
		private void method_8(object sender, MouseButtonEventArgs p1)
		{
			this.method_0().IsUserChecked = true;
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00095470 File Offset: 0x00093670
		private void grid_0_SizeChanged(object sender, SizeChangedEventArgs p1)
		{
			if (this.grid_0.ActualWidth >= 900.0)
			{
				Grid.SetColumn(this.stackPanel_0, 1);
				Grid.SetColumnSpan(this.stackPanel_0, 1);
				Grid.SetRow(this.stackPanel_0, 0);
				return;
			}
			Grid.SetColumn(this.stackPanel_0, 0);
			Grid.SetColumnSpan(this.stackPanel_0, 3);
			Grid.SetRow(this.stackPanel_0, 1);
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x000954E4 File Offset: 0x000936E4
		private void checkBox_0_Checked(object sender, RoutedEventArgs p1)
		{
			this.method_0().ShowDescription = !this.method_0().ShowDescription;
			this.method_3();
			p1.Handled = true;
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x0009550C File Offset: 0x0009370C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/servicescontroller/servicecontroller.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x0009553C File Offset: 0x0009373C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_9(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00095548 File Offset: 0x00093748
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.grid_0 = (Grid)target;
				this.grid_0.SizeChanged += this.grid_0_SizeChanged;
				return;
			case 2:
				((Button)target).Click += this.method_5;
				return;
			case 3:
				this.checkBox_0 = (CheckBox)target;
				this.checkBox_0.Checked += this.checkBox_0_Checked;
				return;
			case 4:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 5:
				((CheckBox)target).Click += this.method_7;
				((CheckBox)target).PreviewMouseDown += this.method_8;
				return;
			case 6:
				this.grid_1 = (Grid)target;
				return;
			case 7:
				((Button)target).Click += this.method_6;
				return;
			case 8:
				this.border_0 = (Border)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040019BA RID: 6586
		private GClass151 gclass151_0;

		// Token: 0x040019BB RID: 6587
		internal Grid grid_0;

		// Token: 0x040019BC RID: 6588
		internal CheckBox checkBox_0;

		// Token: 0x040019BD RID: 6589
		internal StackPanel stackPanel_0;

		// Token: 0x040019BE RID: 6590
		internal Grid grid_1;

		// Token: 0x040019BF RID: 6591
		internal Border border_0;

		// Token: 0x040019C0 RID: 6592
		private bool bool_0;
	}
}
