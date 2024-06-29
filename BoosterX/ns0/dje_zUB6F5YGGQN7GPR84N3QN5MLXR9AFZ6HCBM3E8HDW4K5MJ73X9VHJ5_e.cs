using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007FE RID: 2046
	public sealed class dje_zUB6F5YGGQN7GPR84N3QN5MLXR9AFZ6HCBM3E8HDW4K5MJ73X9VHJ5_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060029F3 RID: 10739 RVA: 0x000B4D88 File Offset: 0x000B2F88
		public dje_zUB6F5YGGQN7GPR84N3QN5MLXR9AFZ6HCBM3E8HDW4K5MJ73X9VHJ5_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000B4D98 File Offset: 0x000B2F98
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/devicepageucs/msideviceuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000B4DC8 File Offset: 0x000B2FC8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
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

		// Token: 0x04001FF2 RID: 8178
		internal CheckBox checkBox_0;

		// Token: 0x04001FF3 RID: 8179
		internal CheckBox checkBox_1;

		// Token: 0x04001FF4 RID: 8180
		internal TextBlock textBlock_0;

		// Token: 0x04001FF5 RID: 8181
		private bool bool_0;
	}
}
