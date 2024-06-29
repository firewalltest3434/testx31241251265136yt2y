using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200080F RID: 2063
	public sealed class dje_zWYLUM7PRN5ZQYB58M6EUK9ZYMT6DFLL9SBAHAETKABRYXX2BNKY7UJ8X3G58ZHV8QS_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002A28 RID: 10792 RVA: 0x000B5AF0 File Offset: 0x000B3CF0
		public dje_zWYLUM7PRN5ZQYB58M6EUK9ZYMT6DFLL9SBAHAETKABRYXX2BNKY7UJ8X3G58ZHV8QS_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x000B5B00 File Offset: 0x000B3D00
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/csgoucs/csgoruncommandsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x000B5B30 File Offset: 0x000B3D30
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x0400202B RID: 8235
		private bool bool_0;
	}
}
