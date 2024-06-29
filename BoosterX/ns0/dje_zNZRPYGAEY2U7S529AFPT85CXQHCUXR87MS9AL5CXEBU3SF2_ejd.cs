using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007D6 RID: 2006
	public sealed class dje_zNZRPYGAEY2U7S529AFPT85CXQHCUXR87MS9AL5CXEBU3SF2_ejd : ListView, IComponentConnector
	{
		// Token: 0x0600292B RID: 10539 RVA: 0x000B11B8 File Offset: 0x000AF3B8
		public dje_zNZRPYGAEY2U7S529AFPT85CXQHCUXR87MS9AL5CXEBU3SF2_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000B11C8 File Offset: 0x000AF3C8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/services/nvidiax/mvvm/views/usercontrols/nvlistview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000B11F8 File Offset: 0x000AF3F8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04001F1D RID: 7965
		private bool bool_0;
	}
}
