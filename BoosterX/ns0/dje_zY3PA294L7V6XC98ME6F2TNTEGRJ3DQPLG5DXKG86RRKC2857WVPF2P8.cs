using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000812 RID: 2066
	public sealed class dje_zY3PA294L7V6XC98ME6F2TNTEGRJ3DQPLG5DXKG86RRKC2857WVPF2P8MHEZTDKW5GS_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002A34 RID: 10804 RVA: 0x000B624C File Offset: 0x000B444C
		public dje_zY3PA294L7V6XC98ME6F2TNTEGRJ3DQPLG5DXKG86RRKC2857WVPF2P8MHEZTDKW5GS_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x000B625C File Offset: 0x000B445C
		private void textBox_0_GotFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == Class364.smethod_0("EnterOwnValue"))
			{
				this.textBox_0.Text = string.Empty;
			}
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000B628C File Offset: 0x000B448C
		private void textBox_0_LostFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = Class364.smethod_0("EnterOwnValue");
			}
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000B62BC File Offset: 0x000B44BC
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			((GClass224)Class358.smethod_0().list_2.Find(new Predicate<Page>(dje_zY3PA294L7V6XC98ME6F2TNTEGRJ3DQPLG5DXKG86RRKC2857WVPF2P8MHEZTDKW5GS_ejd.Class850.class850_0.method_0)).DataContext).SelectedProfile.Autoexec.method_2(new GClass108(this.checkBox_0.Content.ToString(), this.textBox_0.Text));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_0, Class364.smethod_0("added"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000B634C File Offset: 0x000B454C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/csgoucs/csgosettingscommandsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000B637C File Offset: 0x000B457C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 2:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 3:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				return;
			case 4:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002043 RID: 8259
		internal CheckBox checkBox_0;

		// Token: 0x04002044 RID: 8260
		internal TextBlock textBlock_0;

		// Token: 0x04002045 RID: 8261
		internal TextBox textBox_0;

		// Token: 0x04002046 RID: 8262
		internal Button button_0;

		// Token: 0x04002047 RID: 8263
		private bool bool_0;

		// Token: 0x02000813 RID: 2067
		[Serializable]
		private sealed class Class850
		{
			// Token: 0x06002A3C RID: 10812 RVA: 0x000B6438 File Offset: 0x000B4638
			internal bool method_0(Page page_0)
			{
				return page_0.GetType() == typeof(dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd);
			}

			// Token: 0x04002048 RID: 8264
			public static readonly dje_zY3PA294L7V6XC98ME6F2TNTEGRJ3DQPLG5DXKG86RRKC2857WVPF2P8MHEZTDKW5GS_ejd.Class850 class850_0 = new dje_zY3PA294L7V6XC98ME6F2TNTEGRJ3DQPLG5DXKG86RRKC2857WVPF2P8MHEZTDKW5GS_ejd.Class850();

			// Token: 0x04002049 RID: 8265
			public static Predicate<Page> predicate_0;
		}
	}
}
