using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000814 RID: 2068
	public sealed class dje_zY8D98CM86NAZ467A5YJ3QKTYXZ87Y2M6SQHFCLG2G5TRFYKJZUFCT8UEDEZA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002A3D RID: 10813 RVA: 0x000B6450 File Offset: 0x000B4650
		public dje_zY8D98CM86NAZ467A5YJ3QKTYXZ87Y2M6SQHFCLG2G5TRFYKJZUFCT8UEDEZA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x000B6460 File Offset: 0x000B4660
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/cleanupucs/deleteduwpcleanuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x000B6490 File Offset: 0x000B4690
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
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

		// Token: 0x0400204A RID: 8266
		internal CheckBox checkBox_0;

		// Token: 0x0400204B RID: 8267
		internal TextBlock textBlock_0;

		// Token: 0x0400204C RID: 8268
		private bool bool_0;
	}
}
