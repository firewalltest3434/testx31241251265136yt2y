using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Imaging;

namespace ns0
{
	// Token: 0x0200069F RID: 1695
	public sealed class dje_z54EU2PBC73EVAHMNF76GZE7TS8FYLVMZNZ5SEDYPKLJAD2P9RW73EJBU583KVQ6T9Q_ejd : Page, IComponentConnector
	{
		// Token: 0x06002461 RID: 9313 RVA: 0x00090E9C File Offset: 0x0008F09C
		public dje_z54EU2PBC73EVAHMNF76GZE7TS8FYLVMZNZ5SEDYPKLJAD2P9RW73EJBU583KVQ6T9Q_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_z54EU2PBC73EVAHMNF76GZE7TS8FYLVMZNZ5SEDYPKLJAD2P9RW73EJBU583KVQ6T9Q_ejd_Loaded;
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x00090EBC File Offset: 0x0008F0BC
		private void dje_z54EU2PBC73EVAHMNF76GZE7TS8FYLVMZNZ5SEDYPKLJAD2P9RW73EJBU583KVQ6T9Q_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			this.image_0.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/InputLag/Input" + Class364.smethod_0("CurrentLocalization") + ".png"));
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x00090EEC File Offset: 0x0008F0EC
		private void method_0(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd), Class358.smethod_0().frame_1);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x00090F0C File Offset: 0x0008F10C
		private void method_1(object sender, RoutedEventArgs p1)
		{
			Class389.class504_0.method_33(new bool?(true));
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x00090F20 File Offset: 0x0008F120
		private void method_2(object sender, RoutedEventArgs p1)
		{
			Class389.class504_0.method_33(new bool?(false));
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00090F34 File Offset: 0x0008F134
		private void method_3(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_zA8MZB43GAWBMP3BDRAMW2CKRCB3DE8SXGT8W2GGA5ACYRD64ZNY27AJEKDGDGG5VVX_ejd), Class358.smethod_0().frame_1);
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00090F54 File Offset: 0x0008F154
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/inputlagtest/pages/ilfirst.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x00090F84 File Offset: 0x0008F184
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.image_0 = (Image)target;
				return;
			case 2:
				((Button)target).Click += this.method_0;
				return;
			case 3:
				((CheckBox)target).Checked += this.method_1;
				((CheckBox)target).Unchecked += this.method_2;
				return;
			case 4:
				((Button)target).Click += this.method_3;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040018F5 RID: 6389
		internal Image image_0;

		// Token: 0x040018F6 RID: 6390
		private bool bool_0;
	}
}
