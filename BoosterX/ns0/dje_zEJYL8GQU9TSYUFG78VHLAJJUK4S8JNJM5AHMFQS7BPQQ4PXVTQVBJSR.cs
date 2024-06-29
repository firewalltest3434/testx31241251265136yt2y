using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200077C RID: 1916
	public sealed class dje_zEJYL8GQU9TSYUFG78VHLAJJUK4S8JNJM5AHMFQS7BPQQ4PXVTQVBJSRPKAZA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600277D RID: 10109 RVA: 0x000A78E0 File Offset: 0x000A5AE0
		public dje_zEJYL8GQU9TSYUFG78VHLAJJUK4S8JNJM5AHMFQS7BPQQ4PXVTQVBJSRPKAZA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000A78F0 File Offset: 0x000A5AF0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/csgoucs/csgosettingsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000A7920 File Offset: 0x000A5B20
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.checkBox_0 = (CheckBox)target;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.checkBox_1 = (CheckBox)target;
		}

		// Token: 0x04001D38 RID: 7480
		internal CheckBox checkBox_0;

		// Token: 0x04001D39 RID: 7481
		internal CheckBox checkBox_1;

		// Token: 0x04001D3A RID: 7482
		private bool bool_0;
	}
}
