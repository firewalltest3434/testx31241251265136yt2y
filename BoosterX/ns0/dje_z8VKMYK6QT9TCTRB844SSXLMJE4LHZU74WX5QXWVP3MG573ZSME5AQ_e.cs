using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media.Effects;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x020006F2 RID: 1778
	public sealed class dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd : dje_zW8YUDP3S7HTY5MN9SNJXVW52MTUD3QFQ6D5EZFR25X369NQ_ejd, IComponentConnector
	{
		// Token: 0x060025CE RID: 9678 RVA: 0x0009BEEC File Offset: 0x0009A0EC
		public dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x0009BEFC File Offset: 0x0009A0FC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/customprogressbar/circleuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x0009BF2C File Offset: 0x0009A12C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x0009BF38 File Offset: 0x0009A138
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0 = (dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd)target;
				return;
			case 2:
				this.arc_0 = (Arc)target;
				return;
			case 3:
				this.dropShadowEffect_0 = (DropShadowEffect)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001ADE RID: 6878
		internal dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd_0;

		// Token: 0x04001ADF RID: 6879
		internal Arc arc_0;

		// Token: 0x04001AE0 RID: 6880
		internal DropShadowEffect dropShadowEffect_0;

		// Token: 0x04001AE1 RID: 6881
		private bool bool_0;
	}
}
