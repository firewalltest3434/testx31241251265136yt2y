using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200077D RID: 1917
	public sealed class dje_zF5RBQBAG5YAJ8ZN4XLUCQ6DCAWKZ7LNPXW2R3TZDK3BHNS2_ejd : Page, IComponentConnector
	{
		// Token: 0x06002780 RID: 10112 RVA: 0x000A7958 File Offset: 0x000A5B58
		public dje_zF5RBQBAG5YAJ8ZN4XLUCQ6DCAWKZ7LNPXW2R3TZDK3BHNS2_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new Class757();
			Class585.smethod_0(new Class585.Delegate28(this.method_0));
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x000A7984 File Offset: 0x000A5B84
		private void method_0()
		{
			base.Dispatcher.Invoke(new Action(this.method_1));
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000A79A0 File Offset: 0x000A5BA0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/settingspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000A79D0 File Offset: 0x000A5BD0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x000A79DC File Offset: 0x000A5BDC
		private void method_1()
		{
			(base.DataContext as Class757).SettingsVMs = null;
		}

		// Token: 0x04001D3B RID: 7483
		private bool bool_0;
	}
}
