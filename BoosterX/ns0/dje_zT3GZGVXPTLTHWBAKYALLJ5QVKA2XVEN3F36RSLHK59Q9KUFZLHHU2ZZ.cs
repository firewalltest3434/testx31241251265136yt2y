using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007EC RID: 2028
	public sealed class dje_zT3GZGVXPTLTHWBAKYALLJ5QVKA2XVEN3F36RSLHK59Q9KUFZLHHU2ZZXJUEA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060029A0 RID: 10656 RVA: 0x000B3544 File Offset: 0x000B1744
		public dje_zT3GZGVXPTLTHWBAKYALLJ5QVKA2XVEN3F36RSLHK59Q9KUFZLHHU2ZZXJUEA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x000B3554 File Offset: 0x000B1754
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/cleanupucs/cleanupuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000B3584 File Offset: 0x000B1784
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
			this.textBlock_0 = (TextBlock)target;
		}

		// Token: 0x04001F9A RID: 8090
		internal CheckBox checkBox_0;

		// Token: 0x04001F9B RID: 8091
		internal TextBlock textBlock_0;

		// Token: 0x04001F9C RID: 8092
		private bool bool_0;
	}
}
