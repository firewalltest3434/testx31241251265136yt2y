using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020006FF RID: 1791
	public sealed class dje_zA5RTAEEE3XHQPNAYMRCT986HPGHEJ5QA749XT7ZYCA74C2NQUGXW7A6QAX3Q_ejd : Page, IComponentConnector
	{
		// Token: 0x060025FE RID: 9726 RVA: 0x0009CD20 File Offset: 0x0009AF20
		public dje_zA5RTAEEE3XHQPNAYMRCT986HPGHEJ5QA749XT7ZYCA74C2NQUGXW7A6QAX3Q_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x0009CD30 File Offset: 0x0009AF30
		private void method_0(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_z34Q9QPAA7BQQJMZXHNU4FEKEN2D27DPBNGJF3B2SU3DB3VTR63M8E_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x0009CD50 File Offset: 0x0009AF50
		private void method_1(object sender, RoutedEventArgs p1)
		{
			Class389.class504_0.method_35(new bool?(true));
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x0009CD64 File Offset: 0x0009AF64
		private void method_2(object sender, RoutedEventArgs p1)
		{
			Class389.class504_0.method_35(new bool?(false));
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x0009CD78 File Offset: 0x0009AF78
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_zA6HRDGVQ449XDH4D5NPJHBXAQ5BZC26NDGXJQ5PLSURH2QZ_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x0009CD98 File Offset: 0x0009AF98
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/storex/storexwelcomepage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x0009CDC8 File Offset: 0x0009AFC8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.grid_0 = (Grid)target;
				return;
			case 2:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 3:
				((CheckBox)target).Checked += this.method_1;
				((CheckBox)target).Unchecked += this.method_2;
				return;
			case 4:
				((Button)target).Click += this.method_0;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001B0F RID: 6927
		internal Grid grid_0;

		// Token: 0x04001B10 RID: 6928
		internal Button button_0;

		// Token: 0x04001B11 RID: 6929
		private bool bool_0;
	}
}
