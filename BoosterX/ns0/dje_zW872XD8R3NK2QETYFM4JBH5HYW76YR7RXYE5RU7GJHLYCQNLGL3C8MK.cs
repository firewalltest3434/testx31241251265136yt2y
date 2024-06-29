using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200080C RID: 2060
	public sealed class dje_zW872XD8R3NK2QETYFM4JBH5HYW76YR7RXYE5RU7GJHLYCQNLGL3C8MKN8L2Q_ejd : Page, IComponentConnector
	{
		// Token: 0x06002A1D RID: 10781 RVA: 0x000B5860 File Offset: 0x000B3A60
		public dje_zW872XD8R3NK2QETYFM4JBH5HYW76YR7RXYE5RU7GJHLYCQNLGL3C8MKN8L2Q_ejd()
		{
			this.InitializeComponent();
			Class358.smethod_0().frame_1 = this.frame_0;
			bool? flag = Class389.class504_0.method_32();
			if (flag.GetValueOrDefault() & flag != null)
			{
				Class358.smethod_0().method_3(typeof(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd), Class358.smethod_0().frame_1);
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_z54EU2PBC73EVAHMNF76GZE7TS8FYLVMZNZ5SEDYPKLJAD2P9RW73EJBU583KVQ6T9Q_ejd), Class358.smethod_0().frame_1);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000B58E8 File Offset: 0x000B3AE8
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			if (this.frame_0.Content.GetType() == typeof(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd))
			{
				bool? flag = Class389.class504_0.method_32();
				if (!(flag.GetValueOrDefault() & flag != null))
				{
					Class358.smethod_0().method_3(typeof(dje_z54EU2PBC73EVAHMNF76GZE7TS8FYLVMZNZ5SEDYPKLJAD2P9RW73EJBU583KVQ6T9Q_ejd), Class358.smethod_0().frame_1);
					return;
				}
			}
			if (this.frame_0.Content.GetType() == typeof(dje_zA8MZB43GAWBMP3BDRAMW2CKRCB3DE8SXGT8W2GGA5ACYRD64ZNY27AJEKDGDGG5VVX_ejd))
			{
				Class358.smethod_0().method_3(typeof(dje_z54EU2PBC73EVAHMNF76GZE7TS8FYLVMZNZ5SEDYPKLJAD2P9RW73EJBU583KVQ6T9Q_ejd), Class358.smethod_0().frame_1);
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_zA6HRDGVQ449XDH4D5NPJHBXAQ5BZC26NDGXJQ5PLSURH2QZ_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x000B59B4 File Offset: 0x000B3BB4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/inputlagtest/iltpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x000B59E4 File Offset: 0x000B3BE4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.frame_0 = (Frame)target;
		}

		// Token: 0x04002026 RID: 8230
		internal Button button_0;

		// Token: 0x04002027 RID: 8231
		internal Frame frame_0;

		// Token: 0x04002028 RID: 8232
		private bool bool_0;
	}
}
