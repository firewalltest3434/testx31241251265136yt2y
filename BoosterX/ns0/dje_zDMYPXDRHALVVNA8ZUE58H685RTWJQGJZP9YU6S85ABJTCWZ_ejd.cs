using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200077A RID: 1914
	public sealed class dje_zDMYPXDRHALVVNA8ZUE58H685RTWJQGJZP9YU6S85ABJTCWZ_ejd : Page, IComponentConnector
	{
		// Token: 0x06002772 RID: 10098 RVA: 0x000A7708 File Offset: 0x000A5908
		public dje_zDMYPXDRHALVVNA8ZUE58H685RTWJQGJZP9YU6S85ABJTCWZ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x000A7718 File Offset: 0x000A5918
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/loginpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x000A7748 File Offset: 0x000A5948
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04001D2F RID: 7471
		private bool bool_0;
	}
}
