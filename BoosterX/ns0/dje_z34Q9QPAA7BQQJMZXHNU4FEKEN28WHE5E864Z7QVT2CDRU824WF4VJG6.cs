using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000699 RID: 1689
	public sealed class dje_z34Q9QPAA7BQQJMZXHNU4FEKEN28WHE5E864Z7QVT2CDRU824WF4VJG6X8FKRKMRSEW_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600243E RID: 9278 RVA: 0x00090664 File Offset: 0x0008E864
		public dje_z34Q9QPAA7BQQJMZXHNU4FEKEN28WHE5E864Z7QVT2CDRU824WF4VJG6X8FKRKMRSEW_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x00090674 File Offset: 0x0008E874
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/bupage/usercontrols/cloudbackupsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x000906A4 File Offset: 0x0008E8A4
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x040018D2 RID: 6354
		private bool bool_0;
	}
}
