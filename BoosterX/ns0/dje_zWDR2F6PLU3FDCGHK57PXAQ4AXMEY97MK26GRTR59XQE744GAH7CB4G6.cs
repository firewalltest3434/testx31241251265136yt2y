using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200080E RID: 2062
	public sealed class dje_zWDR2F6PLU3FDCGHK57PXAQ4AXMEY97MK26GRTR59XQE744GAH7CB4G685WY7T6WSLQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002A25 RID: 10789 RVA: 0x000B5AA4 File Offset: 0x000B3CA4
		public dje_zWDR2F6PLU3FDCGHK57PXAQ4AXMEY97MK26GRTR59XQE744GAH7CB4G685WY7T6WSLQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x000B5AB4 File Offset: 0x000B3CB4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/gamemodexucs/gmxaddgameuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x000B5AE4 File Offset: 0x000B3CE4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x0400202A RID: 8234
		private bool bool_0;
	}
}
