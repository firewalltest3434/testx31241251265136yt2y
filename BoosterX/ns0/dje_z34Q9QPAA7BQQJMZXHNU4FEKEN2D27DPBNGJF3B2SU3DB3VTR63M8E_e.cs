using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200069A RID: 1690
	public sealed class dje_z34Q9QPAA7BQQJMZXHNU4FEKEN2D27DPBNGJF3B2SU3DB3VTR63M8E_ejd : Page, IComponentConnector
	{
		// Token: 0x06002441 RID: 9281 RVA: 0x000906B0 File Offset: 0x0008E8B0
		public dje_z34Q9QPAA7BQQJMZXHNU4FEKEN2D27DPBNGJF3B2SU3DB3VTR63M8E_ejd()
		{
			this.InitializeComponent();
			base.DataContext = (this.class752_0 = new Class752());
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x000906E0 File Offset: 0x0008E8E0
		private void textBox_0_GotFocus(object sender, RoutedEventArgs p1)
		{
			this.textBox_0.Text = string.Empty;
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x000906F4 File Offset: 0x0008E8F4
		private void textBox_0_LostFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = Class364.smethod_0("SearchAllStore");
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00090724 File Offset: 0x0008E924
		private void textBox_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs p1)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				textBox.SelectAll();
			}
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00090744 File Offset: 0x0008E944
		private void textBox_0_KeyUp(object sender, KeyEventArgs p1)
		{
			if (p1.Key == Key.Return)
			{
				this.class752_0.SearchCommand.Execute(null);
			}
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00090760 File Offset: 0x0008E960
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/storex/storexpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x00090790 File Offset: 0x0008E990
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.KeyUp += this.textBox_0_KeyUp;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				this.textBox_0.MouseLeftButtonUp += this.textBox_0_MouseLeftButtonUp;
				return;
			case 2:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			case 3:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 4:
				this.itemsControl_1 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040018D3 RID: 6355
		private Class752 class752_0;

		// Token: 0x040018D4 RID: 6356
		internal TextBox textBox_0;

		// Token: 0x040018D5 RID: 6357
		internal ItemsControl itemsControl_0;

		// Token: 0x040018D6 RID: 6358
		internal ScrollViewer scrollViewer_0;

		// Token: 0x040018D7 RID: 6359
		internal ItemsControl itemsControl_1;

		// Token: 0x040018D8 RID: 6360
		private bool bool_0;
	}
}
