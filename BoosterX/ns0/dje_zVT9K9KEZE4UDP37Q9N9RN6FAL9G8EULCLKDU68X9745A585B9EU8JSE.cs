using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200080B RID: 2059
	public sealed class dje_zVT9K9KEZE4UDP37Q9N9RN6FAL9G8EULCLKDU68X9745A585B9EU8JSEW7CFQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002A1A RID: 10778 RVA: 0x000B5814 File Offset: 0x000B3A14
		public dje_zVT9K9KEZE4UDP37Q9N9RN6FAL9G8EULCLKDU68X9745A585B9EU8JSEW7CFQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000B5824 File Offset: 0x000B3A24
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/storex/usercontrols/appxuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000B5854 File Offset: 0x000B3A54
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04002025 RID: 8229
		private bool bool_0;
	}
}
