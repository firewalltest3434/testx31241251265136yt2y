using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007B2 RID: 1970
	public sealed class dje_zLST566LJL74RLLYABMS4C54J2GHTSVEU2AB2P7G7S2ALHY8ZKF436ZKURXH2TSJXZS_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002869 RID: 10345 RVA: 0x000AD628 File Offset: 0x000AB828
		public dje_zLST566LJL74RLLYABMS4C54J2GHTSVEU2AB2P7G7S2ALHY8ZKF436ZKURXH2TSJXZS_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x000AD638 File Offset: 0x000AB838
		private void textBox_0_GotFocus(object sender, RoutedEventArgs p1)
		{
			TextBox textBox = sender as TextBox;
			if (textBox == null)
			{
				return;
			}
			textBox.SelectAll();
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x000AD64C File Offset: 0x000AB84C
		private void textBox_0_PreviewTextInput(object sender, TextCompositionEventArgs p1)
		{
			if (sender is TextBox && !Class650.smethod_0(p1.Text))
			{
				p1.Handled = true;
			}
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x000AD66C File Offset: 0x000AB86C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/bupage/usercontrols/backupsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x000AD69C File Offset: 0x000AB89C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.PreviewTextInput += this.textBox_0_PreviewTextInput;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.button_0 = (Button)target;
		}

		// Token: 0x04001E60 RID: 7776
		internal TextBox textBox_0;

		// Token: 0x04001E61 RID: 7777
		internal Button button_0;

		// Token: 0x04001E62 RID: 7778
		private bool bool_0;
	}
}
