using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007BD RID: 1981
	public sealed class dje_zN37RFS283H4JQWNDWXSGQDQ84CPM3FE2BM88N9WCCDK8M4Q5V7SF2_ejd : Page, IComponentConnector
	{
		// Token: 0x0600289E RID: 10398 RVA: 0x000AE770 File Offset: 0x000AC970
		public dje_zN37RFS283H4JQWNDWXSGQDQ84CPM3FE2BM88N9WCCDK8M4Q5V7SF2_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new Class736(this.frame_0);
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x000AE790 File Offset: 0x000AC990
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/cs2/cs2page.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x000AE7C0 File Offset: 0x000AC9C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.grid_0 = (Grid)target;
				return;
			case 2:
				this.button_0 = (Button)target;
				return;
			case 3:
				this.grid_1 = (Grid)target;
				return;
			case 4:
				this.radioButton_0 = (RadioButton)target;
				return;
			case 5:
				this.radioButton_1 = (RadioButton)target;
				return;
			case 6:
				this.frame_0 = (Frame)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001E95 RID: 7829
		internal Grid grid_0;

		// Token: 0x04001E96 RID: 7830
		internal Button button_0;

		// Token: 0x04001E97 RID: 7831
		internal Grid grid_1;

		// Token: 0x04001E98 RID: 7832
		internal RadioButton radioButton_0;

		// Token: 0x04001E99 RID: 7833
		internal RadioButton radioButton_1;

		// Token: 0x04001E9A RID: 7834
		internal Frame frame_0;

		// Token: 0x04001E9B RID: 7835
		private bool bool_0;
	}
}
