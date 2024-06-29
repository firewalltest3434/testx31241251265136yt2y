using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007EB RID: 2027
	public sealed class dje_zSWR8YBVGPBHM8YHYLDMQPSHUKBL7LU2UX9XAAV25XERGERUGQMBXHCT7QWTS65UKF2_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600299D RID: 10653 RVA: 0x000B34CC File Offset: 0x000B16CC
		public dje_zSWR8YBVGPBHM8YHYLDMQPSHUKBL7LU2UX9XAAV25XERGERUGQMBXHCT7QWTS65UKF2_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x000B34DC File Offset: 0x000B16DC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/csgoucs/csgolaunchoptsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000B350C File Offset: 0x000B170C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
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

		// Token: 0x04001F97 RID: 8087
		internal CheckBox checkBox_0;

		// Token: 0x04001F98 RID: 8088
		internal CheckBox checkBox_1;

		// Token: 0x04001F99 RID: 8089
		private bool bool_0;
	}
}
