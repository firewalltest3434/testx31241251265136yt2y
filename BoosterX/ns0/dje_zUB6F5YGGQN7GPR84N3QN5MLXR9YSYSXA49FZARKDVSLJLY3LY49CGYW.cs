using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007FF RID: 2047
	public sealed class dje_zUB6F5YGGQN7GPR84N3QN5MLXR9YSYSXA49FZARKDVSLJLY3LY49CGYWDHST48PN758S3FTRL_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060029F6 RID: 10742 RVA: 0x000B4E18 File Offset: 0x000B3018
		public dje_zUB6F5YGGQN7GPR84N3QN5MLXR9YSYSXA49FZARKDVSLJLY3LY49CGYWDHST48PN758S3FTRL_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000B4E28 File Offset: 0x000B3028
		private void method_0(object sender, MouseButtonEventArgs p1)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null && !textBox.IsKeyboardFocusWithin)
			{
				p1.Handled = true;
				textBox.Focus();
				textBox.SelectAll();
			}
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x000B4E5C File Offset: 0x000B305C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/maintweakucs/maintweakvaluesuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x000B4E8C File Offset: 0x000B308C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((TextBox)target).PreviewMouseDown += this.method_0;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			((TextBox)target).PreviewMouseDown += this.method_0;
		}

		// Token: 0x04001FF6 RID: 8182
		private bool bool_0;
	}
}
