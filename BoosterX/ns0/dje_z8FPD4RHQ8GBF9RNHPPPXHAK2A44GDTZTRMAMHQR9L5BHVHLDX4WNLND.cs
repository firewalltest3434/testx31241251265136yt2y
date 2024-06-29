using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020006CC RID: 1740
	public sealed class dje_z8FPD4RHQ8GBF9RNHPPPXHAK2A44GDTZTRMAMHQR9L5BHVHLDX4WNLND5FSX8269ELXGENSCU_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002529 RID: 9513 RVA: 0x00096458 File Offset: 0x00094658
		public dje_z8FPD4RHQ8GBF9RNHPPPXHAK2A44GDTZTRMAMHQR9L5BHVHLDX4WNLND5FSX8269ELXGENSCU_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00096468 File Offset: 0x00094668
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/bupage/usercontrols/choosenthings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x00096498 File Offset: 0x00094698
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x040019F3 RID: 6643
		private bool bool_0;
	}
}
