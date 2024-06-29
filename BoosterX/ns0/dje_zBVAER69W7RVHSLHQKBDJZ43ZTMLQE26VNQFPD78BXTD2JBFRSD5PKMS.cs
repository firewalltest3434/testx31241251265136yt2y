using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000761 RID: 1889
	public sealed class dje_zBVAER69W7RVHSLHQKBDJZ43ZTMLQE26VNQFPD78BXTD2JBFRSD5PKMSQS49MXGDAS2_ejd : Page, IComponentConnector
	{
		// Token: 0x0600270E RID: 9998 RVA: 0x000A3D94 File Offset: 0x000A1F94
		public dje_zBVAER69W7RVHSLHQKBDJZ43ZTMLQE26VNQFPD78BXTD2JBFRSD5PKMSQS49MXGDAS2_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zBVAER69W7RVHSLHQKBDJZ43ZTMLQE26VNQFPD78BXTD2JBFRSD5PKMSQS49MXGDAS2_ejd_Loaded;
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x000A3DC0 File Offset: 0x000A1FC0
		private void dje_zBVAER69W7RVHSLHQKBDJZ43ZTMLQE26VNQFPD78BXTD2JBFRSD5PKMSQS49MXGDAS2_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			base.DataContext = this.gclass224_0;
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x000A3DD0 File Offset: 0x000A1FD0
		private void method_0(object sender, SelectionChangedEventArgs p1)
		{
			this.textBox_0.DataContext = this.gclass224_0.SelectedProfile;
			this.itemsControl_0.ItemsSource = null;
			this.itemsControl_0.ItemsSource = this.gclass224_0.SelectedProfile.CSGOLaunchOptionsVMs;
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x000A3E10 File Offset: 0x000A2010
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/cs2/views/cs2launchoptions.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x000A3E40 File Offset: 0x000A2040
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((ComboBox)target).SelectionChanged += this.method_0;
				return;
			case 2:
				this.textBox_0 = (TextBox)target;
				return;
			case 3:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 4:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001C97 RID: 7319
		private GClass224 gclass224_0 = new GClass224();

		// Token: 0x04001C98 RID: 7320
		internal TextBox textBox_0;

		// Token: 0x04001C99 RID: 7321
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001C9A RID: 7322
		internal ItemsControl itemsControl_0;

		// Token: 0x04001C9B RID: 7323
		private bool bool_0;
	}
}
