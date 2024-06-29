using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using WinCopies.Util;

namespace ns0
{
	// Token: 0x0200076E RID: 1902
	public sealed class dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd : dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd, IComponentConnector
	{
		// Token: 0x0600273D RID: 10045 RVA: 0x000A526C File Offset: 0x000A346C
		public dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd()
		{
			this.InitializeComponent();
			this.method_1();
			this.method_0();
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000A52A8 File Offset: 0x000A34A8
		private void method_0()
		{
			dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct518 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct518>(ref @struct);
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000A52E0 File Offset: 0x000A34E0
		private void method_1()
		{
			dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct510 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct510>(ref @struct);
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x000A5318 File Offset: 0x000A3518
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct516 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct516>(ref @struct);
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x000A5350 File Offset: 0x000A3550
		private void method_2()
		{
			dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct511 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct511>(ref @struct);
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x000A5388 File Offset: 0x000A3588
		private void method_3(object sender, RoutedEventArgs p1)
		{
			CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
			commonOpenFileDialog.InitialDirectory = "C:\\";
			commonOpenFileDialog.IsFolderPicker = true;
			if (commonOpenFileDialog.ShowDialog() == 1)
			{
				this.textBox_0.Text = commonOpenFileDialog.FileName + "\\GameModeX";
			}
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000A53D4 File Offset: 0x000A35D4
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_1.Text == Class364.smethod_0("ClickOnKeys"))
			{
				this.textBox_1.Text = this.string_2;
			}
			this.string_2 = this.textBox_1.Text;
			this.bool_1 = true;
			this.textBox_1.Text = Class364.smethod_0("ClickOnKeys");
			this.int_0 = 0;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000A5444 File Offset: 0x000A3644
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_1.Text == Class364.smethod_0("ClickOnKeys"))
			{
				this.textBox_1.Text = this.string_2;
			}
			this.string_2 = this.textBox_1.Text;
			this.bool_1 = true;
			this.textBox_1.Text = Class364.smethod_0("ClickOnKeys");
			this.int_0 = 1;
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000A54B4 File Offset: 0x000A36B4
		private void grid_0_KeyDown(object sender, KeyEventArgs p1)
		{
			string[] array = this.string_0.Split(new char[]
			{
				'+'
			});
			if (this.bool_1)
			{
				if (p1.Key.ToString() == "OemQuotes" && !this.string_0.Contains("OEM7"))
				{
					this.string_0 += "OEM7+";
					this.int_1++;
				}
				else if (p1.Key.ToString() == "System" && !this.string_0.Contains("MENU"))
				{
					this.string_0 += "MENU+";
					this.int_1++;
				}
				else if ((p1.Key.ToString() == "LeftShift" || p1.Key.ToString() == "RightShift") && !this.string_0.Contains("SHIFT"))
				{
					this.string_0 += "SHIFT+";
					this.int_1++;
				}
				else if ((p1.Key.ToString() == "LeftCtrl" || p1.Key.ToString() == "RightCtrl") && !this.string_0.Contains("CTRL"))
				{
					this.string_0 += "CTRL+";
					this.int_1++;
				}
				else if (p1.Key.ToString() != "LeftCtrl" && p1.Key.ToString() != "LeftShift" && p1.Key.ToString() != "System" && p1.Key.ToString() != "OemQuotes")
				{
					bool flag = false;
					foreach (string b in array)
					{
						if (p1.Key.ToString() == b)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						this.string_0 = this.string_0 + p1.Key.ToString() + "+";
						this.int_1++;
					}
				}
				if (this.int_0 == 0)
				{
					this.class727_0.OnOffShortcut = this.string_0;
				}
				if (this.int_0 == 1)
				{
					this.class727_0.CleanCacheShortcut = this.string_0;
				}
			}
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x000A57F4 File Offset: 0x000A39F4
		private void grid_0_KeyUp(object sender, KeyEventArgs p1)
		{
			if (this.bool_1)
			{
				if (this.string_0.EndsWith("+"))
				{
					this.string_0 = this.string_0.Remove(this.string_0.Length - 1);
				}
				if (this.int_1 == this.string_0.Split(new char[]
				{
					'+'
				}).Length)
				{
					this.string_1 = this.string_0;
					this.string_0 = string.Empty;
					this.int_1 = 0;
				}
				if (this.int_0 == 0)
				{
					this.class727_0.OnOffShortcut = this.string_1;
				}
				if (this.int_0 == 1)
				{
					this.class727_0.CleanCacheShortcut = this.string_1;
				}
				this.grid_0.IsEnabled = true;
				this.bool_1 = false;
			}
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000A58C0 File Offset: 0x000A3AC0
		private void button_11_Click(object sender, RoutedEventArgs p1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Exe Files (*.exe)|*.exe|All Files (*.*)|*.*";
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			openFileDialog.Title = Class364.smethod_0("GMXChooseExe");
			bool? flag = openFileDialog.ShowDialog();
			if (flag.GetValueOrDefault() & flag != null)
			{
				string fileName = openFileDialog.FileName;
				Class738 @class = new Class738
				{
					Name = fileName.Split(new char[]
					{
						'\\'
					}).Last<string>().Replace(".exe", string.Empty),
					ExeName = fileName.Split(new char[]
					{
						'\\'
					}).Last<string>().Replace(".exe", string.Empty),
					ExeDir = fileName,
					IsAdded = true
				};
				Class294.smethod_3(@class);
				this.itemsControl_3.Items.Add(@class);
				Class294.smethod_2();
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000A59AC File Offset: 0x000A3BAC
		private void button_8_Click(object sender, RoutedEventArgs p1)
		{
			dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct514 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct514>(ref @struct);
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x000A59E4 File Offset: 0x000A3BE4
		private void button_12_Click(object sender, RoutedEventArgs p1)
		{
			dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct515 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct515>(ref @struct);
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x000A5A1C File Offset: 0x000A3C1C
		private void method_4()
		{
			this.itemsControl_1.Items.Clear();
			IList items = this.itemsControl_1.Items;
			IEnumerable enumerable = this.class727_0.GMXStoredSettingsGamesVMs;
			Extensions.AddRange(items, ref enumerable);
			this.itemsControl_2.Items.Clear();
			IList items2 = this.itemsControl_2.Items;
			enumerable = this.class727_0.GMXStoredSettingsAppsVMs;
			Extensions.AddRange(items2, ref enumerable);
			if (this.class727_0.GMXStoredSettingsGamesVMs.Count == 0)
			{
				this.button_7.Visibility = Visibility.Collapsed;
				this.button_8.Visibility = Visibility.Visible;
			}
			else
			{
				this.button_7.Visibility = Visibility.Visible;
				this.button_8.Visibility = Visibility.Collapsed;
			}
			if (this.class727_0.GMXStoredSettingsAppsVMs.Count == 0)
			{
				this.button_9.Visibility = Visibility.Collapsed;
				this.button_10.Visibility = Visibility.Visible;
				return;
			}
			this.button_9.Visibility = Visibility.Visible;
			this.button_10.Visibility = Visibility.Collapsed;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x000A5B0C File Offset: 0x000A3D0C
		private void dje_zQBUDVJDRJQXCFDFEF3AKS8KN29VA_ejd(object sender, RoutedEventArgs p1)
		{
			this.grid_5.IsEnabled = true;
			this.grid_5.DataContext = null;
			RadioButton radioButton = sender as RadioButton;
			this.grid_5.DataContext = (Class742)radioButton.DataContext;
			this.itemsControl_0.ItemsSource = null;
			this.itemsControl_0.ItemsSource = ((Class742)radioButton.DataContext).list_0;
			this.itemsControl_0.Items.Refresh();
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x000A5B88 File Offset: 0x000A3D88
		private void dje_zDC5RQJ78BZZ24WJ4YTKC48S7AURA_ejd(object sender, RoutedEventArgs p1)
		{
			if ((base.DataContext as Class727).GMXStoredSettingsGamesVMs.All(new Func<Class742, bool>(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Class826.class826_0.method_0)))
			{
				this.grid_5.IsEnabled = false;
				this.grid_5.DataContext = null;
			}
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x000A5BE4 File Offset: 0x000A3DE4
		private void button_6_Click(object sender, RoutedEventArgs p1)
		{
			foreach (Class742 @class in (base.DataContext as Class727).GMXStoredSettingsGamesVMs)
			{
				@class.IsChecked = false;
			}
			this.grid_5.IsEnabled = false;
			Class294.smethod_4((Class742)(sender as Button).DataContext);
			this.method_4();
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x000A5C64 File Offset: 0x000A3E64
		private void button_10_Click(object sender, RoutedEventArgs p1)
		{
			dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct513 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct513>(ref @struct);
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x000A5C9C File Offset: 0x000A3E9C
		private void button_14_Click(object sender, RoutedEventArgs p1)
		{
			dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct517 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct517>(ref @struct);
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x000A5CD4 File Offset: 0x000A3ED4
		private void button_13_Click(object sender, RoutedEventArgs p1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Exe Files (*.exe)|*.exe|All Files (*.*)|*.*";
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			openFileDialog.Title = Class364.smethod_0("GMXChooseAppExe");
			bool? flag = openFileDialog.ShowDialog();
			if (flag.GetValueOrDefault() & flag != null)
			{
				string fileName = openFileDialog.FileName;
				Class735 @class = new Class735
				{
					Name = fileName.Split(new char[]
					{
						'\\'
					}).Last<string>().Replace(".exe", string.Empty),
					ExeName = fileName.Split(new char[]
					{
						'\\'
					}).Last<string>(),
					ExeDir = fileName,
					IsAdded = true
				};
				Class294.smethod_5(@class);
				this.itemsControl_3.Items.Add(@class);
				Class294.smethod_2();
			}
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x000A5DB0 File Offset: 0x000A3FB0
		private void button_4_Click(object sender, RoutedEventArgs p1)
		{
			this.button_4.IsEnabled = false;
			if (Process.GetProcessesByName("GameModeX").Length != 0)
			{
				Process.GetProcessesByName("GameModeX")[0].Kill();
			}
			Class185.smethod_4(Class389.class504_0.method_0() + "\\GameModeX.exe");
			this.button_4.IsEnabled = true;
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x000A5E0C File Offset: 0x000A400C
		private void button_5_Click(object sender, RoutedEventArgs p1)
		{
			dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct509 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct509>(ref @struct);
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x000A5E44 File Offset: 0x000A4044
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct512 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct512>(ref @struct);
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x000A5E7C File Offset: 0x000A407C
		private void textBox_3_PreviewTextInput(object sender, TextCompositionEventArgs p1)
		{
			if (!this.method_5(p1.Text) && this.textBox_3.Text.Length >= 3)
			{
				p1.Handled = true;
			}
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x000A5EB0 File Offset: 0x000A40B0
		private bool method_5(string string_3)
		{
			int num;
			return int.TryParse(string_3, out num);
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x000A5EC8 File Offset: 0x000A40C8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_2)
			{
				return;
			}
			this.bool_2 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/gamemodex.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x000A5EF8 File Offset: 0x000A40F8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_6(Type type_0, string string_3)
		{
			return Delegate.CreateDelegate(type_0, this, string_3);
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x000A5F04 File Offset: 0x000A4104
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0 = (dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd)target;
				return;
			case 2:
				this.grid_0 = (Grid)target;
				this.grid_0.KeyDown += this.grid_0_KeyDown;
				this.grid_0.KeyUp += this.grid_0_KeyUp;
				return;
			case 3:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 4:
				this.grid_1 = (Grid)target;
				return;
			case 5:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 6:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 7:
				this.progressBar_0 = (ProgressBar)target;
				return;
			case 8:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 9:
				this.textBox_0 = (TextBox)target;
				return;
			case 10:
				((Button)target).Click += this.method_3;
				return;
			case 11:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 12:
				this.grid_2 = (Grid)target;
				return;
			case 13:
				this.grid_3 = (Grid)target;
				return;
			case 14:
				this.grid_4 = (Grid)target;
				return;
			case 15:
				this.textBox_1 = (TextBox)target;
				return;
			case 16:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 17:
				this.textBox_2 = (TextBox)target;
				return;
			case 18:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 19:
				this.button_4 = (Button)target;
				this.button_4.Click += this.button_4_Click;
				return;
			case 20:
				this.button_5 = (Button)target;
				this.button_5.Click += this.button_5_Click;
				return;
			case 21:
				this.grid_5 = (Grid)target;
				return;
			case 22:
				this.button_6 = (Button)target;
				this.button_6.Click += this.button_6_Click;
				return;
			case 23:
				this.textBox_3 = (TextBox)target;
				this.textBox_3.PreviewTextInput += this.textBox_3_PreviewTextInput;
				return;
			case 24:
				this.stackPanel_2 = (StackPanel)target;
				return;
			case 25:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 26:
				this.grid_6 = (Grid)target;
				return;
			case 27:
				this.grid_7 = (Grid)target;
				return;
			case 28:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			case 29:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 30:
				this.button_7 = (Button)target;
				this.button_7.Click += this.button_8_Click;
				return;
			case 31:
				this.itemsControl_1 = (ItemsControl)target;
				return;
			case 32:
				this.button_8 = (Button)target;
				this.button_8.Click += this.button_8_Click;
				return;
			case 33:
				this.button_9 = (Button)target;
				this.button_9.Click += this.button_10_Click;
				return;
			case 34:
				this.itemsControl_2 = (ItemsControl)target;
				return;
			case 35:
				this.button_10 = (Button)target;
				this.button_10.Click += this.button_10_Click;
				return;
			case 36:
				this.grid_8 = (Grid)target;
				return;
			case 37:
				this.itemsControl_3 = (ItemsControl)target;
				return;
			case 38:
				this.button_11 = (Button)target;
				this.button_11.Click += this.button_11_Click;
				return;
			case 39:
				this.stackPanel_3 = (StackPanel)target;
				return;
			case 40:
				this.button_12 = (Button)target;
				this.button_12.Click += this.button_12_Click;
				return;
			case 41:
				this.grid_9 = (Grid)target;
				return;
			case 42:
				this.itemsControl_4 = (ItemsControl)target;
				return;
			case 43:
				this.button_13 = (Button)target;
				this.button_13.Click += this.button_13_Click;
				return;
			case 44:
				this.stackPanel_4 = (StackPanel)target;
				return;
			case 45:
				this.button_14 = (Button)target;
				this.button_14.Click += this.button_14_Click;
				return;
			default:
				this.bool_2 = true;
				return;
			}
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x000A63C8 File Offset: 0x000A45C8
		private void method_7()
		{
			Application.Current.Dispatcher.Invoke(new Action(this.method_8));
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x000A63E8 File Offset: 0x000A45E8
		private void method_8()
		{
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				Duration = TimeSpan.FromSeconds(2.0),
				To = new double?((double)100f),
				AccelerationRatio = 0.5,
				DecelerationRatio = 0.5
			};
			Timeline.SetDesiredFrameRate(doubleAnimation, new int?(60));
			this.progressBar_0.BeginAnimation(RangeBase.ValueProperty, doubleAnimation);
		}

		// Token: 0x04001CD0 RID: 7376
		private Class727 class727_0;

		// Token: 0x04001CD1 RID: 7377
		private bool bool_0;

		// Token: 0x04001CD2 RID: 7378
		private bool bool_1;

		// Token: 0x04001CD3 RID: 7379
		private int int_0;

		// Token: 0x04001CD4 RID: 7380
		private int int_1;

		// Token: 0x04001CD5 RID: 7381
		private string string_0 = string.Empty;

		// Token: 0x04001CD6 RID: 7382
		private string string_1 = string.Empty;

		// Token: 0x04001CD7 RID: 7383
		private string string_2 = string.Empty;

		// Token: 0x04001CD8 RID: 7384
		internal dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;

		// Token: 0x04001CD9 RID: 7385
		internal Grid grid_0;

		// Token: 0x04001CDA RID: 7386
		internal Button button_0;

		// Token: 0x04001CDB RID: 7387
		internal Grid grid_1;

		// Token: 0x04001CDC RID: 7388
		internal StackPanel stackPanel_0;

		// Token: 0x04001CDD RID: 7389
		internal TextBlock textBlock_0;

		// Token: 0x04001CDE RID: 7390
		internal ProgressBar progressBar_0;

		// Token: 0x04001CDF RID: 7391
		internal StackPanel stackPanel_1;

		// Token: 0x04001CE0 RID: 7392
		internal TextBox textBox_0;

		// Token: 0x04001CE1 RID: 7393
		internal Button button_1;

		// Token: 0x04001CE2 RID: 7394
		internal Grid grid_2;

		// Token: 0x04001CE3 RID: 7395
		internal Grid grid_3;

		// Token: 0x04001CE4 RID: 7396
		internal Grid grid_4;

		// Token: 0x04001CE5 RID: 7397
		internal TextBox textBox_1;

		// Token: 0x04001CE6 RID: 7398
		internal Button button_2;

		// Token: 0x04001CE7 RID: 7399
		internal TextBox textBox_2;

		// Token: 0x04001CE8 RID: 7400
		internal Button button_3;

		// Token: 0x04001CE9 RID: 7401
		internal Button button_4;

		// Token: 0x04001CEA RID: 7402
		internal Button button_5;

		// Token: 0x04001CEB RID: 7403
		internal Grid grid_5;

		// Token: 0x04001CEC RID: 7404
		internal Button button_6;

		// Token: 0x04001CED RID: 7405
		internal TextBox textBox_3;

		// Token: 0x04001CEE RID: 7406
		internal StackPanel stackPanel_2;

		// Token: 0x04001CEF RID: 7407
		internal TextBlock textBlock_1;

		// Token: 0x04001CF0 RID: 7408
		internal Grid grid_6;

		// Token: 0x04001CF1 RID: 7409
		internal Grid grid_7;

		// Token: 0x04001CF2 RID: 7410
		internal ItemsControl itemsControl_0;

		// Token: 0x04001CF3 RID: 7411
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001CF4 RID: 7412
		internal Button button_7;

		// Token: 0x04001CF5 RID: 7413
		internal ItemsControl itemsControl_1;

		// Token: 0x04001CF6 RID: 7414
		internal Button button_8;

		// Token: 0x04001CF7 RID: 7415
		internal Button button_9;

		// Token: 0x04001CF8 RID: 7416
		internal ItemsControl itemsControl_2;

		// Token: 0x04001CF9 RID: 7417
		internal Button button_10;

		// Token: 0x04001CFA RID: 7418
		internal Grid grid_8;

		// Token: 0x04001CFB RID: 7419
		internal ItemsControl itemsControl_3;

		// Token: 0x04001CFC RID: 7420
		internal Button button_11;

		// Token: 0x04001CFD RID: 7421
		internal StackPanel stackPanel_3;

		// Token: 0x04001CFE RID: 7422
		internal Button button_12;

		// Token: 0x04001CFF RID: 7423
		internal Grid grid_9;

		// Token: 0x04001D00 RID: 7424
		internal ItemsControl itemsControl_4;

		// Token: 0x04001D01 RID: 7425
		internal Button button_13;

		// Token: 0x04001D02 RID: 7426
		internal StackPanel stackPanel_4;

		// Token: 0x04001D03 RID: 7427
		internal Button button_14;

		// Token: 0x04001D04 RID: 7428
		private bool bool_2;

		// Token: 0x0200076F RID: 1903
		[StructLayout(LayoutKind.Auto)]
		private struct Struct509 : IAsyncStateMachine
		{
			// Token: 0x0600275B RID: 10075 RVA: 0x000A6460 File Offset: 0x000A4660
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd = this.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_1CE;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_231;
					default:
						dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_5.Content = Class364.smethod_0("Deleting");
						dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_5.IsEnabled = false;
						if (Process.GetProcessesByName("GameModeX").Length != 0)
						{
							Process.GetProcessesByName("GameModeX")[0].Kill();
						}
						awaiter = Task.Delay(500).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct509>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (File.Exists(Class389.class504_0.method_0() + "\\GameModeX.exe"))
					{
						File.Delete(Class389.class504_0.method_0() + "\\GameModeX.exe");
					}
					if (File.Exists(GClass6.smethod_0() + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\GameModeX.lnk"))
					{
						File.Delete(GClass6.smethod_0() + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\GameModeX.lnk");
					}
					Class185.smethod_22("reg delete \"HKCU\\SOFTWARE\\GameModeX\" /f");
					Class185.smethod_22("reg delete \"HKCU\\SOFTWARE\\BoosterX\" /v \"GMXInstallLocation\" /f");
					dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_5.Content = Class364.smethod_0("Delete");
					dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_5.IsEnabled = true;
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.textBlock_0, Class364.smethod_0("InstallLocation"));
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.stackPanel_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct509>(ref awaiter, ref this);
						return;
					}
					IL_1CE:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.stackPanel_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct509>(ref awaiter, ref this);
						return;
					}
					IL_231:
					awaiter.GetResult();
					dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_1.IsEnabled = true;
					dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_1.Content = Class364.smethod_0("Install");
					dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.progressBar_0.Value = 0.0;
					dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.method_1();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600275C RID: 10076 RVA: 0x000A6730 File Offset: 0x000A4930
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D05 RID: 7429
			public int int_0;

			// Token: 0x04001D06 RID: 7430
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D07 RID: 7431
			public dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;

			// Token: 0x04001D08 RID: 7432
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000770 RID: 1904
		[StructLayout(LayoutKind.Auto)]
		private struct Struct510 : IAsyncStateMachine
		{
			// Token: 0x0600275D RID: 10077 RVA: 0x000A6740 File Offset: 0x000A4940
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd = this.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num != 1)
						{
							dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_1.Visibility = Visibility.Collapsed;
							dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_1.Opacity = 0.0;
							dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2.Visibility = Visibility.Collapsed;
							dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2.Opacity = 0.0;
							if (Class389.class504_0.method_0() != null)
							{
								if (Process.GetProcessesByName("GameModeX").Length != 0)
								{
									dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_4.Content = Class364.smethod_0("Restart");
								}
								dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2);
								awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 0;
									this.taskAwaiter_0 = awaiter;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct510>(ref awaiter, ref this);
									return;
								}
								goto IL_185;
							}
							else
							{
								dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_1);
								awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_1).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 1;
									this.taskAwaiter_0 = awaiter;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct510>(ref awaiter, ref this);
									return;
								}
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
						}
						awaiter.GetResult();
						dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.textBox_0.Text = Class186.string_2 + "\\GameModeX";
						goto IL_18C;
					}
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					IL_185:
					awaiter.GetResult();
					IL_18C:;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600275E RID: 10078 RVA: 0x000A6928 File Offset: 0x000A4B28
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D09 RID: 7433
			public int int_0;

			// Token: 0x04001D0A RID: 7434
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D0B RID: 7435
			public dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;

			// Token: 0x04001D0C RID: 7436
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000771 RID: 1905
		[StructLayout(LayoutKind.Auto)]
		private struct Struct511 : IAsyncStateMachine
		{
			// Token: 0x0600275F RID: 10079 RVA: 0x000A6938 File Offset: 0x000A4B38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd @object = this.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(@object.method_7)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct511>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002760 RID: 10080 RVA: 0x000A69F8 File Offset: 0x000A4BF8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D0D RID: 7437
			public int int_0;

			// Token: 0x04001D0E RID: 7438
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D0F RID: 7439
			public dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;

			// Token: 0x04001D10 RID: 7440
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000772 RID: 1906
		[StructLayout(LayoutKind.Auto)]
		private struct Struct512 : IAsyncStateMachine
		{
			// Token: 0x06002761 RID: 10081 RVA: 0x000A6A08 File Offset: 0x000A4C08
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd = this.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_121;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_194;
					default:
						if (dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_8.Visibility != Visibility.Visible && dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_9.Visibility != Visibility.Visible)
						{
							Class358.smethod_0().method_3(typeof(dje_zA6HRDGVQ449XDH4D5NPJHBXAQ5BZC26NDGXJQ5PLSURH2QZ_ejd), Class358.smethod_0().frame_0);
							goto IL_1B4;
						}
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_8).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct512>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_8);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_9).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct512>(ref awaiter, ref this);
						return;
					}
					IL_121:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_9);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct512>(ref awaiter, ref this);
						return;
					}
					IL_194:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1B4:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002762 RID: 10082 RVA: 0x000A6BF8 File Offset: 0x000A4DF8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D11 RID: 7441
			public int int_0;

			// Token: 0x04001D12 RID: 7442
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D13 RID: 7443
			public dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;

			// Token: 0x04001D14 RID: 7444
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000773 RID: 1907
		[StructLayout(LayoutKind.Auto)]
		private struct Struct513 : IAsyncStateMachine
		{
			// Token: 0x06002763 RID: 10083 RVA: 0x000A6C08 File Offset: 0x000A4E08
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd = this.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_A1;
					}
					if (num != 1)
					{
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct513>(ref awaiter, ref this);
							return;
						}
						goto IL_A1;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_79:
					awaiter.GetResult();
					goto IL_118;
					IL_A1:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_9);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_9).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct513>(ref awaiter, ref this);
						return;
					}
					goto IL_79;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_118:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002764 RID: 10084 RVA: 0x000A6D50 File Offset: 0x000A4F50
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D15 RID: 7445
			public int int_0;

			// Token: 0x04001D16 RID: 7446
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D17 RID: 7447
			public dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;

			// Token: 0x04001D18 RID: 7448
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000774 RID: 1908
		[StructLayout(LayoutKind.Auto)]
		private struct Struct514 : IAsyncStateMachine
		{
			// Token: 0x06002765 RID: 10085 RVA: 0x000A6D60 File Offset: 0x000A4F60
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd = this.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_A1;
					}
					if (num != 1)
					{
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct514>(ref awaiter, ref this);
							return;
						}
						goto IL_A1;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_79:
					awaiter.GetResult();
					goto IL_118;
					IL_A1:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_8);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_8).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct514>(ref awaiter, ref this);
						return;
					}
					goto IL_79;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_118:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002766 RID: 10086 RVA: 0x000A6EA8 File Offset: 0x000A50A8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D19 RID: 7449
			public int int_0;

			// Token: 0x04001D1A RID: 7450
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D1B RID: 7451
			public dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;

			// Token: 0x04001D1C RID: 7452
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000775 RID: 1909
		[StructLayout(LayoutKind.Auto)]
		private struct Struct515 : IAsyncStateMachine
		{
			// Token: 0x06002767 RID: 10087 RVA: 0x000A6EB8 File Offset: 0x000A50B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd = this.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_A1;
					}
					if (num != 1)
					{
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_8).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct515>(ref awaiter, ref this);
							return;
						}
						goto IL_A1;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_79:
					awaiter.GetResult();
					goto IL_118;
					IL_A1:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_8);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct515>(ref awaiter, ref this);
						return;
					}
					goto IL_79;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_118:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002768 RID: 10088 RVA: 0x000A7000 File Offset: 0x000A5200
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D1D RID: 7453
			public int int_0;

			// Token: 0x04001D1E RID: 7454
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D1F RID: 7455
			public dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;

			// Token: 0x04001D20 RID: 7456
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000776 RID: 1910
		[StructLayout(LayoutKind.Auto)]
		private struct Struct516 : IAsyncStateMachine
		{
			// Token: 0x06002769 RID: 10089 RVA: 0x000A7010 File Offset: 0x000A5210
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd = this.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_138;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_299;
					case 3:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_31A;
					case 4:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_349;
					case 5:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_3BC;
					default:
						if (!dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.bool_0)
						{
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_1);
							awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.stackPanel_1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct516>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 4;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct516>(ref awaiter, ref this);
								return;
							}
							goto IL_349;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.stackPanel_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct516>(ref awaiter, ref this);
						return;
					}
					IL_138:
					awaiter.GetResult();
					dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.method_2();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.textBlock_0, Class364.smethod_0("Installing"));
					dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_1.IsEnabled = false;
					dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_1.Content = Class364.smethod_0("continue");
					if (!Directory.Exists(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.textBox_0.Text))
					{
						Directory.CreateDirectory(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.textBox_0.Text);
					}
					Class389.class504_0.method_1(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.textBox_0.Text);
					Class650.smethod_4("BoosterX", dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.textBox_0.Text, "Resources.EmbedRes.Exes", "GameModeX.exe", false);
					Class650.Interface16 @interface = (Class650.Interface16)new Class650.Class651();
					@interface.imethod_4("Created by BoosterX");
					@interface.imethod_17(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.textBox_0.Text + "\\GameModeX.exe");
					((Class650.Interface17)@interface).imethod_4(Path.Combine(GClass6.smethod_0() + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\", "GameModeX.lnk"), false);
					Class185.smethod_4(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.textBox_0.Text + "\\GameModeX.exe");
					awaiter = Task.Delay(1500).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct516>(ref awaiter, ref this);
						return;
					}
					IL_299:
					awaiter.GetResult();
					dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_1.IsEnabled = true;
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.textBlock_0, Class364.smethod_0("Installed"));
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.button_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct516>(ref awaiter, ref this);
						return;
					}
					IL_31A:
					awaiter.GetResult();
					dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.bool_0 = true;
					goto IL_3C3;
					IL_349:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_1);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 5;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct516>(ref awaiter, ref this);
						return;
					}
					IL_3BC:
					awaiter.GetResult();
					IL_3C3:;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600276A RID: 10090 RVA: 0x000A7428 File Offset: 0x000A5628
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D21 RID: 7457
			public int int_0;

			// Token: 0x04001D22 RID: 7458
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D23 RID: 7459
			public dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;

			// Token: 0x04001D24 RID: 7460
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000777 RID: 1911
		[Serializable]
		private sealed class Class826
		{
			// Token: 0x0600276D RID: 10093 RVA: 0x000A744C File Offset: 0x000A564C
			internal bool method_0(Class742 class742_0)
			{
				return !class742_0.IsChecked;
			}

			// Token: 0x04001D25 RID: 7461
			public static readonly dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Class826 class826_0 = new dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Class826();

			// Token: 0x04001D26 RID: 7462
			public static Func<Class742, bool> func_0;
		}

		// Token: 0x02000778 RID: 1912
		[StructLayout(LayoutKind.Auto)]
		private struct Struct517 : IAsyncStateMachine
		{
			// Token: 0x0600276E RID: 10094 RVA: 0x000A7458 File Offset: 0x000A5658
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd = this.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_A1;
					}
					if (num != 1)
					{
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_9).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct517>(ref awaiter, ref this);
							return;
						}
						goto IL_A1;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_79:
					awaiter.GetResult();
					goto IL_118;
					IL_A1:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_9);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct517>(ref awaiter, ref this);
						return;
					}
					goto IL_79;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_118:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600276F RID: 10095 RVA: 0x000A75A0 File Offset: 0x000A57A0
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D27 RID: 7463
			public int int_0;

			// Token: 0x04001D28 RID: 7464
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D29 RID: 7465
			public dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;

			// Token: 0x04001D2A RID: 7466
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000779 RID: 1913
		[StructLayout(LayoutKind.Auto)]
		private struct Struct518 : IAsyncStateMachine
		{
			// Token: 0x06002770 RID: 10096 RVA: 0x000A75B0 File Offset: 0x000A57B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd = this.dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_4F;
					}
					IL_2F:
					if (Class250.bool_1)
					{
						dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.DataContext = (dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.class727_0 = new Class727());
						if (!Class250.bool_0)
						{
							dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_6.Visibility = Visibility.Collapsed;
						}
						if (Class250.int_3 == 0)
						{
							dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.grid_7.Visibility = Visibility.Collapsed;
							dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.stackPanel_2.Visibility = Visibility.Collapsed;
						}
						else
						{
							dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.textBlock_1.Text = Class364.smethod_0("CompatibilityWith") + " " + Class250.string_0;
						}
						Class294.smethod_0(new Class294.Delegate26(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.method_4));
						Class294.smethod_2();
						goto IL_115;
					}
					awaiter = Task.Delay(20).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd.Struct518>(ref awaiter, ref this);
						return;
					}
					IL_4F:
					awaiter.GetResult();
					goto IL_2F;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_115:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002771 RID: 10097 RVA: 0x000A76F8 File Offset: 0x000A58F8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D2B RID: 7467
			public int int_0;

			// Token: 0x04001D2C RID: 7468
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D2D RID: 7469
			public dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd_0;

			// Token: 0x04001D2E RID: 7470
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
