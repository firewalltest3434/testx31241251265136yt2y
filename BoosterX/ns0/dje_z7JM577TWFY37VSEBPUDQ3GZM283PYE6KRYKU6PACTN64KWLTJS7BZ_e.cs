using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020006C4 RID: 1732
	public sealed class dje_z7JM577TWFY37VSEBPUDQ3GZM283PYE6KRYKU6PACTN64KWLTJS7BZ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600250C RID: 9484 RVA: 0x000956E8 File Offset: 0x000938E8
		public dje_z7JM577TWFY37VSEBPUDQ3GZM283PYE6KRYKU6PACTN64KWLTJS7BZ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x000956F8 File Offset: 0x000938F8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/servicesgroupcontroller/servicegrouplistview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00095728 File Offset: 0x00093928
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.textBlock_0 = (TextBlock)target;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.checkBox_0 = (CheckBox)target;
		}

		// Token: 0x040019C3 RID: 6595
		internal TextBlock textBlock_0;

		// Token: 0x040019C4 RID: 6596
		internal CheckBox checkBox_0;

		// Token: 0x040019C5 RID: 6597
		private bool bool_0;
	}
}
