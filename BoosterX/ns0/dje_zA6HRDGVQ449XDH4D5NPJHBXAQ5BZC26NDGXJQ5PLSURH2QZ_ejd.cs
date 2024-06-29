using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000700 RID: 1792
	public sealed class dje_zA6HRDGVQ449XDH4D5NPJHBXAQ5BZC26NDGXJQ5PLSURH2QZ_ejd : Page, IComponentConnector
	{
		// Token: 0x06002605 RID: 9733 RVA: 0x0009CE6C File Offset: 0x0009B06C
		public dje_zA6HRDGVQ449XDH4D5NPJHBXAQ5BZC26NDGXJQ5PLSURH2QZ_ejd()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x0009CE80 File Offset: 0x0009B080
		private void method_0()
		{
			base.DataContext = GClass48.smethod_0();
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x0009CE90 File Offset: 0x0009B090
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/appspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x0009CEC0 File Offset: 0x0009B0C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.grid_0 = (Grid)target;
		}

		// Token: 0x04001B12 RID: 6930
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001B13 RID: 6931
		internal Grid grid_0;

		// Token: 0x04001B14 RID: 6932
		private bool bool_0;
	}
}
