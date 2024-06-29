using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007DE RID: 2014
	public sealed class dje_zR5YC9WYSNQVRBNY45JDVB59GK5LN6CGKY8URCZB3NJ7LLVVKT45D79Z5ZH6A_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002952 RID: 10578 RVA: 0x000B1F78 File Offset: 0x000B0178
		public dje_zR5YC9WYSNQVRBNY45JDVB59GK5LN6CGKY8URCZB3NJ7LLVVKT45D79Z5ZH6A_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000B1F88 File Offset: 0x000B0188
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/fixes/usercontrols/problemuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000B1FB8 File Offset: 0x000B01B8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.checkBox_0 = (CheckBox)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04001F49 RID: 8009
		internal CheckBox checkBox_0;

		// Token: 0x04001F4A RID: 8010
		private bool bool_0;
	}
}
