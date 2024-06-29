using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007B0 RID: 1968
	public sealed class dje_zKNF25HCRGE9EBEMF5H7K7S4QW63NPK724AL2S5MCXNTPPNH9KF8GF_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002862 RID: 10338 RVA: 0x000AD4C4 File Offset: 0x000AB6C4
		public dje_zKNF25HCRGE9EBEMF5H7K7S4QW63NPK724AL2S5MCXNTPPNH9KF8GF_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x000AD4D4 File Offset: 0x000AB6D4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/settingsucs/settingsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000AD504 File Offset: 0x000AB704
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.checkBox_0 = (CheckBox)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04001E59 RID: 7769
		internal CheckBox checkBox_0;

		// Token: 0x04001E5A RID: 7770
		private bool bool_0;
	}
}
