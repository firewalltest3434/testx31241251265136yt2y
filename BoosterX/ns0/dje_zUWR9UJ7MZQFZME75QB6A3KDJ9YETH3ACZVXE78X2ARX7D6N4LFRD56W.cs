using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000801 RID: 2049
	public sealed class dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060029FD RID: 10749 RVA: 0x000B4F30 File Offset: 0x000B3130
		public dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x000B4F40 File Offset: 0x000B3140
		private void textBox_0_GotFocus(object sender, RoutedEventArgs p1)
		{
			TextBox textBox = sender as TextBox;
			if (textBox == null)
			{
				return;
			}
			textBox.SelectAll();
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x000B4F54 File Offset: 0x000B3154
		private void textBox_0_PreviewTextInput(object sender, TextCompositionEventArgs p1)
		{
			TextBox textBox = sender as TextBox;
			if (textBox == null && textBox.Text.Length < 20)
			{
				return;
			}
			if (!Class650.smethod_0(p1.Text))
			{
				p1.Handled = true;
			}
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x000B4F90 File Offset: 0x000B3190
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/inputlagtest/usercontrols/iltestuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x000B4FC0 File Offset: 0x000B31C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.PreviewTextInput += this.textBox_0_PreviewTextInput;
				return;
			case 2:
				this.button_0 = (Button)target;
				return;
			case 3:
				this.grid_0 = (Grid)target;
				return;
			case 4:
				this.grid_1 = (Grid)target;
				return;
			case 5:
				this.grid_2 = (Grid)target;
				return;
			case 6:
				this.grid_3 = (Grid)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001FF8 RID: 8184
		internal TextBox textBox_0;

		// Token: 0x04001FF9 RID: 8185
		internal Button button_0;

		// Token: 0x04001FFA RID: 8186
		internal Grid grid_0;

		// Token: 0x04001FFB RID: 8187
		internal Grid grid_1;

		// Token: 0x04001FFC RID: 8188
		internal Grid grid_2;

		// Token: 0x04001FFD RID: 8189
		internal Grid grid_3;

		// Token: 0x04001FFE RID: 8190
		private bool bool_0;
	}
}
