using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace ns0
{
	// Token: 0x020007B1 RID: 1969
	public sealed class dje_zKPT2ADYDPEEN43JS3FFLDVW655PTPVWA56YMFS4ME6PDTZB2TYZY7S36XYHA_ejd : Border, IComponentConnector
	{
		// Token: 0x06002865 RID: 10341 RVA: 0x000AD520 File Offset: 0x000AB720
		public dje_zKPT2ADYDPEEN43JS3FFLDVW655PTPVWA56YMFS4ME6PDTZB2TYZY7S36XYHA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x000AD530 File Offset: 0x000AB730
		private void dje_zKPT2ADYDPEEN43JS3FFLDVW655PTPVWA56YMFS4ME6PDTZB2TYZY7S36XYHA_ejd_0_MouseMove(object sender, MouseEventArgs p1)
		{
			Point position = p1.GetPosition(this.dje_zKPT2ADYDPEEN43JS3FFLDVW655PTPVWA56YMFS4ME6PDTZB2TYZY7S36XYHA_ejd_0);
			double x = position.X;
			double y = position.Y;
			this.radialGradientBrush_0.GradientOrigin = new Point(x, y);
			this.radialGradientBrush_0.Center = new Point(x, y);
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x000AD580 File Offset: 0x000AB780
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/customborderstyle/gradientbackgroundborderstyle.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x000AD5B0 File Offset: 0x000AB7B0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.dje_zKPT2ADYDPEEN43JS3FFLDVW655PTPVWA56YMFS4ME6PDTZB2TYZY7S36XYHA_ejd_0 = (dje_zKPT2ADYDPEEN43JS3FFLDVW655PTPVWA56YMFS4ME6PDTZB2TYZY7S36XYHA_ejd)target;
				this.dje_zKPT2ADYDPEEN43JS3FFLDVW655PTPVWA56YMFS4ME6PDTZB2TYZY7S36XYHA_ejd_0.MouseMove += this.dje_zKPT2ADYDPEEN43JS3FFLDVW655PTPVWA56YMFS4ME6PDTZB2TYZY7S36XYHA_ejd_0_MouseMove;
				return;
			case 2:
				this.radialGradientBrush_0 = (RadialGradientBrush)target;
				return;
			case 3:
				this.gradientStop_0 = (GradientStop)target;
				return;
			case 4:
				this.gradientStop_1 = (GradientStop)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001E5B RID: 7771
		internal dje_zKPT2ADYDPEEN43JS3FFLDVW655PTPVWA56YMFS4ME6PDTZB2TYZY7S36XYHA_ejd dje_zKPT2ADYDPEEN43JS3FFLDVW655PTPVWA56YMFS4ME6PDTZB2TYZY7S36XYHA_ejd_0;

		// Token: 0x04001E5C RID: 7772
		internal RadialGradientBrush radialGradientBrush_0;

		// Token: 0x04001E5D RID: 7773
		internal GradientStop gradientStop_0;

		// Token: 0x04001E5E RID: 7774
		internal GradientStop gradientStop_1;

		// Token: 0x04001E5F RID: 7775
		private bool bool_0;
	}
}
