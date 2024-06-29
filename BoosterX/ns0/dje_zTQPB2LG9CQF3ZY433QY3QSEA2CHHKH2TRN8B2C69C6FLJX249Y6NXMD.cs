using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x020007F2 RID: 2034
	public sealed class dje_zTQPB2LG9CQF3ZY433QY3QSEA2CHHKH2TRN8B2C69C6FLJX249Y6NXMD429MMT7SYYYT3TH5PWT39R2Z_ejd : UserControl, IComponentConnector, IStyleConnector
	{
		// Token: 0x060029B1 RID: 10673 RVA: 0x000B39C4 File Offset: 0x000B1BC4
		public dje_zTQPB2LG9CQF3ZY433QY3QSEA2CHHKH2TRN8B2C69C6FLJX249Y6NXMD429MMT7SYYYT3TH5PWT39R2Z_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000B39D4 File Offset: 0x000B1BD4
		private void method_0(object sender, RoutedEventArgs p1)
		{
			Class658 @class = (Class658)base.DataContext;
			if (!@class.bool_0)
			{
				return;
			}
			GClass67 gclass67_ = @class.gclass67_0;
			if (gclass67_.String_0 == "REG" || gclass67_.String_0 == "REG_SZ" || gclass67_.String_0 == "REG_BINARY" || gclass67_.String_0 == "REG_EXPAND_SZ")
			{
				Class185.smethod_22("taskkill /F /IM regedit.exe");
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit", "LastKey", gclass67_.Path);
				Class185.smethod_24("regedit");
				return;
			}
			if (gclass67_.String_0 == "BAT")
			{
				Class185.smethod_24("cmd");
				return;
			}
			if (gclass67_.String_0 == "TASK")
			{
				Class185.smethod_24("control schedtasks");
				return;
			}
			if (gclass67_.String_0 == "DEVICE")
			{
				Class185.smethod_24("devmgmt.msc");
				return;
			}
			if (gclass67_.String_0 == "WEVTUTIL")
			{
				Class185.smethod_24("eventvwr.msc");
			}
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x000B3B00 File Offset: 0x000B1D00
		private void method_1(object sender, MouseButtonEventArgs p1)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null && !textBox.IsKeyboardFocusWithin)
			{
				p1.Handled = true;
				textBox.Focus();
				textBox.SelectAll();
			}
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x000B3B34 File Offset: 0x000B1D34
		private void textBox_1_PreviewMouseDown(object sender, MouseButtonEventArgs p1)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null && !textBox.IsKeyboardFocusWithin)
			{
				p1.Handled = true;
				textBox.Focus();
				textBox.SelectAll();
			}
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000B3B68 File Offset: 0x000B1D68
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/maintweakucs/maintweakshowtweaksuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000B3B98 File Offset: 0x000B1D98
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Button)target).Click += this.method_0;
				return;
			case 2:
				((TextBox)target).PreviewMouseDown += this.method_1;
				return;
			case 3:
				this.textBox_0 = (TextBox)target;
				return;
			case 4:
				this.textBox_1 = (TextBox)target;
				this.textBox_1.PreviewMouseDown += this.textBox_1_PreviewMouseDown;
				return;
			default:
				this.bool_0 = true;
				return;
			case 6:
				((TextBox)target).PreviewMouseDown += this.method_1;
				return;
			case 7:
				this.textBox_2 = (TextBox)target;
				return;
			case 8:
				this.comboBox_0 = (ComboBox)target;
				return;
			}
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000B3C68 File Offset: 0x000B1E68
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 5)
			{
				((TextBox)target).PreviewMouseDown += this.method_1;
				return;
			}
			if (connectionId != 9)
			{
				return;
			}
			((TextBox)target).PreviewMouseDown += this.method_1;
		}

		// Token: 0x04001FB5 RID: 8117
		internal TextBox textBox_0;

		// Token: 0x04001FB6 RID: 8118
		internal TextBox textBox_1;

		// Token: 0x04001FB7 RID: 8119
		internal TextBox textBox_2;

		// Token: 0x04001FB8 RID: 8120
		internal ComboBox comboBox_0;

		// Token: 0x04001FB9 RID: 8121
		private bool bool_0;
	}
}
