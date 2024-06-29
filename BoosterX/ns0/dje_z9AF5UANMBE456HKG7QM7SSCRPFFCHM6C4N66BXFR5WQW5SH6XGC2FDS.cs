using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020006FA RID: 1786
	public sealed class dje_z9AF5UANMBE456HKG7QM7SSCRPFFCHM6C4N66BXFR5WQW5SH6XGC2FDSNUDRA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060025EC RID: 9708 RVA: 0x0009C7B8 File Offset: 0x0009A9B8
		public dje_z9AF5UANMBE456HKG7QM7SSCRPFFCHM6C4N66BXFR5WQW5SH6XGC2FDSNUDRA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x0009C7C8 File Offset: 0x0009A9C8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/expapplying/usercontrols/wbuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x0009C7F8 File Offset: 0x0009A9F8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04001AFC RID: 6908
		private bool bool_0;
	}
}
