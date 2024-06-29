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
	// Token: 0x02000790 RID: 1936
	public sealed class dje_zHVE2FBBGL295YFHV5QPLKEJL3MFJW2HAT6494R6Y2TY52S85NBHXV_ejd : Page, IComponentConnector
	{
		// Token: 0x060027EC RID: 10220 RVA: 0x000A9BF8 File Offset: 0x000A7DF8
		public dje_zHVE2FBBGL295YFHV5QPLKEJL3MFJW2HAT6494R6Y2TY52S85NBHXV_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x000A9C08 File Offset: 0x000A7E08
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Application.Current.Dispatcher.Invoke(new Action(dje_zHVE2FBBGL295YFHV5QPLKEJL3MFJW2HAT6494R6Y2TY52S85NBHXV_ejd.Class832.class832_0.method_0));
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000A9C38 File Offset: 0x000A7E38
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All files (*.*)|*.*";
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			openFileDialog.Title = Class364.smethod_0("ChooseFile");
			bool? flag = openFileDialog.ShowDialog();
			if (flag.GetValueOrDefault() & flag != null)
			{
				Class400.smethod_0(openFileDialog.FileName);
			}
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000A9C98 File Offset: 0x000A7E98
		private void method_0(object sender, DragEventArgs p1)
		{
			if (p1.Data.GetDataPresent(DataFormats.FileDrop))
			{
				Class400.smethod_0(((string[])p1.Data.GetData(DataFormats.FileDrop))[0]);
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000A9CC8 File Offset: 0x000A7EC8
		private void textBox_0_GotFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == Class364.smethod_0("TrustedCmdText"))
			{
				this.textBox_0.Text = string.Empty;
			}
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x000A9CF8 File Offset: 0x000A7EF8
		private void textBox_0_LostFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text.smethod_7())
			{
				this.textBox_0.Text = Class364.smethod_0("TrustedCmdText");
			}
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000A9D24 File Offset: 0x000A7F24
		private void textBox_0_KeyUp(object sender, KeyEventArgs p1)
		{
			if (p1.Key == Key.Return && !this.textBox_0.Text.smethod_7())
			{
				Class400.smethod_0(this.textBox_0.Text);
			}
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x000A9D54 File Offset: 0x000A7F54
		private void method_1(object sender, RoutedEventArgs p1)
		{
			if (!this.textBox_0.Text.smethod_7())
			{
				Class400.smethod_0(this.textBox_0.Text);
			}
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x000A9D78 File Offset: 0x000A7F78
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/godmodepage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x000A9DA8 File Offset: 0x000A7FA8
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
				((Grid)target).Drop += this.method_0;
				return;
			case 3:
				this.border_0 = (Border)target;
				return;
			case 4:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 5:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.KeyUp += this.textBox_0_KeyUp;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				return;
			case 6:
				((Button)target).Click += this.method_1;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001DA1 RID: 7585
		internal Button button_0;

		// Token: 0x04001DA2 RID: 7586
		internal Border border_0;

		// Token: 0x04001DA3 RID: 7587
		internal Button button_1;

		// Token: 0x04001DA4 RID: 7588
		internal TextBox textBox_0;

		// Token: 0x04001DA5 RID: 7589
		private bool bool_0;

		// Token: 0x02000791 RID: 1937
		[Serializable]
		private sealed class Class832
		{
			// Token: 0x060027F8 RID: 10232 RVA: 0x000A9EC8 File Offset: 0x000A80C8
			internal void method_0()
			{
				Class358.smethod_0().method_3(typeof(dje_zA6HRDGVQ449XDH4D5NPJHBXAQ5BZC26NDGXJQ5PLSURH2QZ_ejd), Class358.smethod_0().frame_0);
			}

			// Token: 0x04001DA6 RID: 7590
			public static readonly dje_zHVE2FBBGL295YFHV5QPLKEJL3MFJW2HAT6494R6Y2TY52S85NBHXV_ejd.Class832 class832_0 = new dje_zHVE2FBBGL295YFHV5QPLKEJL3MFJW2HAT6494R6Y2TY52S85NBHXV_ejd.Class832();

			// Token: 0x04001DA7 RID: 7591
			public static Action action_0;
		}
	}
}
