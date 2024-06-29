using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200068B RID: 1675
	public sealed class dje_z2M6TTNW33EBGDLZAHAPXBZ8G6KNLADV4NBYZWAV2K2PH4D2_ejd : Grid, IComponentConnector
	{
		// Token: 0x060023ED RID: 9197 RVA: 0x0008E7E0 File Offset: 0x0008C9E0
		public dje_z2M6TTNW33EBGDLZAHAPXBZ8G6KNLADV4NBYZWAV2K2PH4D2_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x0008E7F0 File Offset: 0x0008C9F0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/servicescontroller/statusselector.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x0008E820 File Offset: 0x0008CA20
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.stackPanel_0 = (StackPanel)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04001871 RID: 6257
		internal StackPanel stackPanel_0;

		// Token: 0x04001872 RID: 6258
		private bool bool_0;
	}
}
