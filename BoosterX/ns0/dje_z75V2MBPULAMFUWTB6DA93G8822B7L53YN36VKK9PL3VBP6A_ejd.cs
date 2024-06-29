using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020006C3 RID: 1731
	public sealed class dje_z75V2MBPULAMFUWTB6DA93G8822B7L53YN36VKK9PL3VBP6A_ejd : Page, IComponentConnector
	{
		// Token: 0x06002508 RID: 9480 RVA: 0x00095654 File Offset: 0x00093854
		public dje_z75V2MBPULAMFUWTB6DA93G8822B7L53YN36VKK9PL3VBP6A_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00095664 File Offset: 0x00093864
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00095684 File Offset: 0x00093884
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/aboutpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000956B4 File Offset: 0x000938B4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x040019C1 RID: 6593
		internal Button button_0;

		// Token: 0x040019C2 RID: 6594
		private bool bool_0;
	}
}
