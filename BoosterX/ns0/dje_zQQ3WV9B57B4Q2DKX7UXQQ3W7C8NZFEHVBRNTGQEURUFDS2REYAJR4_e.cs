using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007DA RID: 2010
	public sealed class dje_zQQ3WV9B57B4Q2DKX7UXQQ3W7C8NZFEHVBRNTGQEURUFDS2REYAJR4_ejd : Page, IComponentConnector
	{
		// Token: 0x0600293D RID: 10557 RVA: 0x000B15E4 File Offset: 0x000AF7E4
		public dje_zQQ3WV9B57B4Q2DKX7UXQQ3W7C8NZFEHVBRNTGQEURUFDS2REYAJR4_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new Class721(this.listView_0);
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x000B1604 File Offset: 0x000AF804
		private void textBox_0_GotFocus(object sender, RoutedEventArgs p1)
		{
			this.textBox_0.Text = string.Empty;
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x000B1618 File Offset: 0x000AF818
		private void textBox_0_LostFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = (Application.Current.FindResource("Search") as string);
			}
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x000B1650 File Offset: 0x000AF850
		private void textBox_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs p1)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				textBox.SelectAll();
			}
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000B1670 File Offset: 0x000AF870
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/fixes/fixespage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x000B16A0 File Offset: 0x000AF8A0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				this.textBox_0.MouseLeftButtonUp += this.textBox_0_MouseLeftButtonUp;
				return;
			case 2:
				this.radioButton_0 = (RadioButton)target;
				return;
			case 3:
				this.radioButton_1 = (RadioButton)target;
				return;
			case 4:
				this.image_0 = (Image)target;
				return;
			case 5:
				this.listView_0 = (ListView)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001F2B RID: 7979
		internal TextBox textBox_0;

		// Token: 0x04001F2C RID: 7980
		internal RadioButton radioButton_0;

		// Token: 0x04001F2D RID: 7981
		internal RadioButton radioButton_1;

		// Token: 0x04001F2E RID: 7982
		internal Image image_0;

		// Token: 0x04001F2F RID: 7983
		internal ListView listView_0;

		// Token: 0x04001F30 RID: 7984
		private bool bool_0;
	}
}
