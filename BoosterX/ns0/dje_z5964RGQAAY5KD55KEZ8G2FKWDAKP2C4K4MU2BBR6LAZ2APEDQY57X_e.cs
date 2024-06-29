using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020006A1 RID: 1697
	public sealed class dje_z5964RGQAAY5KD55KEZ8G2FKWDAKP2C4K4MU2BBR6LAZ2APEDQY57X_ejd : Grid, IComponentConnector
	{
		// Token: 0x06002470 RID: 9328 RVA: 0x00091174 File Offset: 0x0008F374
		public dje_z5964RGQAAY5KD55KEZ8G2FKWDAKP2C4K4MU2BBR6LAZ2APEDQY57X_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x00091184 File Offset: 0x0008F384
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/servicescontroller/startmodeselector.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x000911B4 File Offset: 0x0008F3B4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.stackPanel_0 = (StackPanel)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x040018FB RID: 6395
		internal StackPanel stackPanel_0;

		// Token: 0x040018FC RID: 6396
		private bool bool_0;
	}
}
