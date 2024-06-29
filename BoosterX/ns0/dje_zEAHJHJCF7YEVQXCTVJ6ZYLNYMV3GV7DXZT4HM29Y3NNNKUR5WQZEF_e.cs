using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200077B RID: 1915
	public sealed class dje_zEAHJHJCF7YEVQXCTVJ6ZYLNYMV3GV7DXZT4HM29Y3NNNKUR5WQZEF_ejd : Page, IComponentConnector
	{
		// Token: 0x06002775 RID: 10101 RVA: 0x000A7754 File Offset: 0x000A5954
		public dje_zEAHJHJCF7YEVQXCTVJ6ZYLNYMV3GV7DXZT4HM29Y3NNNKUR5WQZEF_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000A776C File Offset: 0x000A596C
		private void method_0(bool bool_1)
		{
			this.button_3.IsEnabled = false;
			base.DataContext = null;
			base.DataContext = GClass161.smethod_0(bool_1);
			this.button_3.IsEnabled = true;
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x000A779C File Offset: 0x000A599C
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0(true);
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x000A77A8 File Offset: 0x000A59A8
		public void button_1_Click(object sender, RoutedEventArgs p1)
		{
			GClass161.smethod_2();
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x000A77B0 File Offset: 0x000A59B0
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			GClass161.smethod_4();
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x000A77B8 File Offset: 0x000A59B8
		public void button_2_Click(object sender, RoutedEventArgs p1)
		{
			GClass161.smethod_3();
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x000A77C0 File Offset: 0x000A59C0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/devicespage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000A77F0 File Offset: 0x000A59F0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 2:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 3:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 4:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 5:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 6:
				this.checkBox_1 = (CheckBox)target;
				return;
			case 7:
				this.checkBox_2 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001D30 RID: 7472
		internal Button button_0;

		// Token: 0x04001D31 RID: 7473
		internal Button button_1;

		// Token: 0x04001D32 RID: 7474
		internal Button button_2;

		// Token: 0x04001D33 RID: 7475
		internal Button button_3;

		// Token: 0x04001D34 RID: 7476
		internal CheckBox checkBox_0;

		// Token: 0x04001D35 RID: 7477
		internal CheckBox checkBox_1;

		// Token: 0x04001D36 RID: 7478
		internal CheckBox checkBox_2;

		// Token: 0x04001D37 RID: 7479
		private bool bool_0;
	}
}
