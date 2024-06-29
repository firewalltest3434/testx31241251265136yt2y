using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200081F RID: 2079
	public sealed class dje_zYTQHPKUT45J7Z2YZNM2YCGCWHTKQEDGM5UA8T5Y9MRHNC7GL3SNRKA8RVERA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002A68 RID: 10856 RVA: 0x000B744C File Offset: 0x000B564C
		public dje_zYTQHPKUT45J7Z2YZNM2YCGCWHTKQEDGM5UA8T5Y9MRHNC7GL3SNRKA8RVERA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x000B745C File Offset: 0x000B565C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/cleanupucs/deviceremoveucs.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x000B748C File Offset: 0x000B568C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.checkBox_0 = (CheckBox)target;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.textBlock_0 = (TextBlock)target;
		}

		// Token: 0x04002085 RID: 8325
		internal CheckBox checkBox_0;

		// Token: 0x04002086 RID: 8326
		internal TextBlock textBlock_0;

		// Token: 0x04002087 RID: 8327
		private bool bool_0;
	}
}
