using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007E8 RID: 2024
	public sealed class dje_zS47NUGZB4NMDHDGFGZN8R6MZMSTZC22PP5QJMCVY7U78FP549R6VZ_ejd : Page, IComponentConnector
	{
		// Token: 0x06002991 RID: 10641 RVA: 0x000B30D0 File Offset: 0x000B12D0
		public dje_zS47NUGZB4NMDHDGFGZN8R6MZMSTZC22PP5QJMCVY7U78FP549R6VZ_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new Class755();
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000B30EC File Offset: 0x000B12EC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/bupage/backuppage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000B311C File Offset: 0x000B131C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			case 2:
				this.image_0 = (Image)target;
				return;
			case 3:
				this.itemsControl_1 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001F8C RID: 8076
		internal ItemsControl itemsControl_0;

		// Token: 0x04001F8D RID: 8077
		internal Image image_0;

		// Token: 0x04001F8E RID: 8078
		internal ItemsControl itemsControl_1;

		// Token: 0x04001F8F RID: 8079
		private bool bool_0;
	}
}
