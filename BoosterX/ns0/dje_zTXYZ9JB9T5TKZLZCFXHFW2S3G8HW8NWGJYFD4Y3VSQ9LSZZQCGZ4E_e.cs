using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007FD RID: 2045
	public sealed class dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G8HW8NWGJYFD4Y3VSQ9LSZZQCGZ4E_ejd : Page, IComponentConnector
	{
		// Token: 0x060029F0 RID: 10736 RVA: 0x000B4D3C File Offset: 0x000B2F3C
		public dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G8HW8NWGJYFD4Y3VSQ9LSZZQCGZ4E_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x000B4D4C File Offset: 0x000B2F4C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/internettest/internettestpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x000B4D7C File Offset: 0x000B2F7C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04001FF1 RID: 8177
		private bool bool_0;
	}
}
