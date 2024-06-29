using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020006A0 RID: 1696
	public sealed class dje_z56D5ZH8KZ97SR682KHYABNBNV9NYU7TG6H7MALM96MKJP5JRS3J2QRA5336E6B5TG3_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002469 RID: 9321 RVA: 0x0009101C File Offset: 0x0008F21C
		public dje_z56D5ZH8KZ97SR682KHYABNBNV9NYU7TG6H7MALM96MKJP5JRS3J2QRA5336E6B5TG3_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x0009102C File Offset: 0x0008F22C
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			if (!(Class389.class504_0.method_62() == "ru-RU") && !(Class389.class504_0.method_62() == "uk-UA"))
			{
				Process.Start("https://discord.gg/uNasSb9Dhc");
				return;
			}
			Process.Start("https://discord.gg/ios1ph");
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x00091084 File Offset: 0x0008F284
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Process.Start("www.youtube.com/iosiph");
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00091094 File Offset: 0x0008F294
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			Process.Start("www.vk.com/ios1phvk");
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x000910A4 File Offset: 0x0008F2A4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/customsocialnetborder/socialuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x000910D4 File Offset: 0x0008F2D4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x000910E0 File Offset: 0x0008F2E0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
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
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040018F7 RID: 6391
		internal Button button_0;

		// Token: 0x040018F8 RID: 6392
		internal Button button_1;

		// Token: 0x040018F9 RID: 6393
		internal Button button_2;

		// Token: 0x040018FA RID: 6394
		private bool bool_0;
	}
}
