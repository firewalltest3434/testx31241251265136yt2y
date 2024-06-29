using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020006BF RID: 1727
	public sealed class dje_z6BJ2Q9T4F6STBPPLPD75L2JSBNLPLH4A2PBKHRKA_ejd : Window, IComponentConnector
	{
		// Token: 0x060024EA RID: 9450 RVA: 0x00094EAC File Offset: 0x000930AC
		public dje_z6BJ2Q9T4F6STBPPLPD75L2JSBNLPLH4A2PBKHRKA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00094EBC File Offset: 0x000930BC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/services/systemx/sxpost.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00094EEC File Offset: 0x000930EC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x040019AA RID: 6570
		private bool bool_0;
	}
}
