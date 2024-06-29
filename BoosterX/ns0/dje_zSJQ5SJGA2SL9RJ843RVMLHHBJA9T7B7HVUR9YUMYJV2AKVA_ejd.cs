using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007E9 RID: 2025
	public sealed class dje_zSJQ5SJGA2SL9RJ843RVMLHHBJA9T7B7HVUR9YUMYJV2AKVA_ejd : Grid, IComponentConnector
	{
		// Token: 0x06002994 RID: 10644 RVA: 0x000B316C File Offset: 0x000B136C
		public dje_zSJQ5SJGA2SL9RJ843RVMLHHBJA9T7B7HVUR9YUMYJV2AKVA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000B317C File Offset: 0x000B137C
		private void method_0(object sender, SizeChangedEventArgs p1)
		{
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000B3180 File Offset: 0x000B1380
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/servicescontroller/servicedescription.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000B31B0 File Offset: 0x000B13B0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((dje_zSJQ5SJGA2SL9RJ843RVMLHHBJA9T7B7HVUR9YUMYJV2AKVA_ejd)target).SizeChanged += this.method_0;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.border_0 = (Border)target;
		}

		// Token: 0x04001F90 RID: 8080
		internal Border border_0;

		// Token: 0x04001F91 RID: 8081
		private bool bool_0;
	}
}
