using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Effects;

namespace ns0
{
	// Token: 0x020006B6 RID: 1718
	public sealed class dje_z5QYU3UGZZK8P6HBXCSHD2BMW75JBJUSKUZRNPAVJABKCJXRZFRF6Z_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060024C0 RID: 9408 RVA: 0x00093D04 File Offset: 0x00091F04
		public dje_z5QYU3UGZZK8P6HBXCSHD2BMW75JBJUSKUZRNPAVJABKCJXRZFRF6Z_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00093D14 File Offset: 0x00091F14
		private void method_0(object sender, RoutedEventArgs p1)
		{
			if (this.checkBox_0.Foreground == dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd && !this.bool_0)
			{
				return;
			}
			this.checkBox_1.IsChecked = new bool?(true);
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x00093D44 File Offset: 0x00091F44
		private void method_1(object sender, RoutedEventArgs p1)
		{
			this.checkBox_1.IsChecked = new bool?(false);
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x00093D58 File Offset: 0x00091F58
		private void method_2(object sender, KeyEventArgs p1)
		{
			if (p1.Key == Key.LeftShift || p1.Key == Key.RightShift)
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00093D80 File Offset: 0x00091F80
		private void method_3(object sender, KeyEventArgs p1)
		{
			this.bool_0 = false;
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00093D8C File Offset: 0x00091F8C
		private void method_4(object sender, RoutedEventArgs p1)
		{
			this.checkBox_1.IsChecked = !this.checkBox_1.IsChecked;
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00093DD4 File Offset: 0x00091FD4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/servicesgroupcontroller/threestatecheckbox.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x00093E04 File Offset: 0x00092004
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_z5QYU3UGZZK8P6HBXCSHD2BMW75JBJUSKUZRNPAVJABKCJXRZFRF6Z_ejd)target).KeyDown += this.method_2;
				((dje_z5QYU3UGZZK8P6HBXCSHD2BMW75JBJUSKUZRNPAVJABKCJXRZFRF6Z_ejd)target).KeyUp += this.method_3;
				return;
			case 2:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 3:
				this.dropShadowEffect_0 = (DropShadowEffect)target;
				return;
			case 4:
				this.dropShadowEffect_1 = (DropShadowEffect)target;
				return;
			case 5:
				this.checkBox_1 = (CheckBox)target;
				return;
			case 6:
				((Button)target).Click += this.method_0;
				return;
			case 7:
				((Button)target).Click += this.method_1;
				return;
			case 8:
				((Button)target).Click += this.method_4;
				return;
			default:
				this.bool_1 = true;
				return;
			}
		}

		// Token: 0x04001972 RID: 6514
		private bool bool_0;

		// Token: 0x04001973 RID: 6515
		internal CheckBox checkBox_0;

		// Token: 0x04001974 RID: 6516
		internal DropShadowEffect dropShadowEffect_0;

		// Token: 0x04001975 RID: 6517
		internal DropShadowEffect dropShadowEffect_1;

		// Token: 0x04001976 RID: 6518
		internal CheckBox checkBox_1;

		// Token: 0x04001977 RID: 6519
		private bool bool_1;
	}
}
