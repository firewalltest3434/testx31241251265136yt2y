using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200069E RID: 1694
	public sealed class dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600245D RID: 9309 RVA: 0x00090E0C File Offset: 0x0008F00C
		public dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00090E20 File Offset: 0x0008F020
		private void method_0()
		{
			for (int i = 0; i <= 10; i++)
			{
				this.itemsControl_0.Items.Add(new object());
			}
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00090E50 File Offset: 0x0008F050
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/loading/loadingelements.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00090E80 File Offset: 0x0008F080
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.itemsControl_0 = (ItemsControl)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x040018F3 RID: 6387
		internal ItemsControl itemsControl_0;

		// Token: 0x040018F4 RID: 6388
		private bool bool_0;
	}
}
