using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000803 RID: 2051
	public sealed class dje_zVJLFRS3DWLQEJ89U7HKWXHQTZ7FD4YB2FAE4CBZX8WAEHFWNE9LQNK2ZE7LMBJKA3Q_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002A02 RID: 10754 RVA: 0x000B5070 File Offset: 0x000B3270
		public dje_zVJLFRS3DWLQEJ89U7HKWXHQTZ7FD4YB2FAE4CBZX8WAEHFWNE9LQNK2ZE7LMBJKA3Q_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x000B5080 File Offset: 0x000B3280
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/inputlagtest/usercontrols/ilcompare.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x000B50B0 File Offset: 0x000B32B0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x0400200A RID: 8202
		private bool bool_0;
	}
}
