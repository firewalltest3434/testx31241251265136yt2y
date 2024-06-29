using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x020007CE RID: 1998
	public sealed class dje_zNSYZJS6E2WJ959D8WYQ8M825ZA6W5QZW3LWVURMRV7P3RHJSJV8YWRGHAZRWGJRKSW_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002901 RID: 10497 RVA: 0x000B023C File Offset: 0x000AE43C
		public dje_zNSYZJS6E2WJ959D8WYQ8M825ZA6W5QZW3LWVURMRV7P3RHJSJV8YWRGHAZRWGJRKSW_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x000B024C File Offset: 0x000AE44C
		private void method_0(object sender, RoutedEventArgs p1)
		{
			Class720 @class = (Class720)base.DataContext;
			dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd type = ((Class720)base.DataContext).Type;
			if (type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.File)
			{
				if (!Class585.struct13_0.method_0())
				{
					return;
				}
				Class185.smethod_24("explorer \"" + @class.Path + "\"");
				return;
			}
			else
			{
				if (type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Registry || type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Service)
				{
					Class185.smethod_22("taskkill /F /IM regedit.exe");
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit", "LastKey", @class.Path);
					Class185.smethod_24("regedit");
					return;
				}
				if (type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Task)
				{
					Class185.smethod_24("control schedtasks");
				}
				return;
			}
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x000B02F4 File Offset: 0x000AE4F4
		private void method_1(object sender, RoutedEventArgs p1)
		{
			((Class720)base.DataContext).NewStatus = null;
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x000B031C File Offset: 0x000AE51C
		private void method_2(object sender, RoutedEventArgs p1)
		{
			Class720 @class = (Class720)base.DataContext;
			if (@class == null && @class.Runs.smethod_7())
			{
				return;
			}
			string arguments = "/select, " + @class.Runs;
			Process.Start("explorer.exe", arguments);
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x000B036C File Offset: 0x000AE56C
		private void method_3(object sender, RoutedEventArgs p1)
		{
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x000B0370 File Offset: 0x000AE570
		private void method_4(object sender, RoutedEventArgs p1)
		{
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x000B0374 File Offset: 0x000AE574
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/autorunsucs/autorunuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x000B03A4 File Offset: 0x000AE5A4
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
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
				((Button)target).Click += this.method_0;
				return;
			case 4:
				((Button)target).Click += this.method_2;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001EF4 RID: 7924
		internal CheckBox checkBox_0;

		// Token: 0x04001EF5 RID: 7925
		internal TextBlock textBlock_0;

		// Token: 0x04001EF6 RID: 7926
		private bool bool_0;
	}
}
