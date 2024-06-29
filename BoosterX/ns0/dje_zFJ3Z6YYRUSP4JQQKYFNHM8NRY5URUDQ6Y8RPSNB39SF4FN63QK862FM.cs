using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000782 RID: 1922
	public sealed class dje_zFJ3Z6YYRUSP4JQQKYFNHM8NRY5URUDQ6Y8RPSNB39SF4FN63QK862FMXA5FBRWSQ5Q_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060027AC RID: 10156 RVA: 0x000A7FCC File Offset: 0x000A61CC
		public dje_zFJ3Z6YYRUSP4JQQKYFNHM8NRY5URUDQ6Y8RPSNB39SF4FN63QK862FMXA5FBRWSQ5Q_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x000A7FDC File Offset: 0x000A61DC
		private void method_0(object sender, RoutedEventArgs p1)
		{
			if (!(base.DataContext as Class754).bool_0)
			{
				(base.DataContext as Class754).AppXIsChecked = false;
			}
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000A8004 File Offset: 0x000A6204
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/storex/usercontrols/appxinstalluc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x000A8034 File Offset: 0x000A6234
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((Button)target).Click += this.method_0;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04001D54 RID: 7508
		private bool bool_0;
	}
}
