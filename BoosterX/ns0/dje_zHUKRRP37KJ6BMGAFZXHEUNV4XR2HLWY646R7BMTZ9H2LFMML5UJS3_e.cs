using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200078F RID: 1935
	public sealed class dje_zHUKRRP37KJ6BMGAFZXHEUNV4XR2HLWY646R7BMTZ9H2LFMML5UJS3_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060027E9 RID: 10217 RVA: 0x000A9B68 File Offset: 0x000A7D68
		public dje_zHUKRRP37KJ6BMGAFZXHEUNV4XR2HLWY646R7BMTZ9H2LFMML5UJS3_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x000A9B78 File Offset: 0x000A7D78
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/devicepageucs/disabledeviceuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x000A9BA8 File Offset: 0x000A7DA8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 2:
				this.checkBox_1 = (CheckBox)target;
				return;
			case 3:
				this.textBlock_0 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001D9D RID: 7581
		internal CheckBox checkBox_0;

		// Token: 0x04001D9E RID: 7582
		internal CheckBox checkBox_1;

		// Token: 0x04001D9F RID: 7583
		internal TextBlock textBlock_0;

		// Token: 0x04001DA0 RID: 7584
		private bool bool_0;
	}
}
