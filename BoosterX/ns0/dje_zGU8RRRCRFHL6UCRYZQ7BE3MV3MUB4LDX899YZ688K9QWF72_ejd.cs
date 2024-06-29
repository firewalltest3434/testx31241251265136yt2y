using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000788 RID: 1928
	public sealed class dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd : Page, IComponentConnector, IStyleConnector
	{
		// Token: 0x060027C2 RID: 10178 RVA: 0x000A8520 File Offset: 0x000A6720
		public dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd()
		{
			this.InitializeComponent();
			bool? flag = Class389.class504_0.method_22();
			if (flag.GetValueOrDefault() & flag != null)
			{
				this.checkBox_0.IsChecked = new bool?(true);
			}
			this.method_0(false);
			base.Loaded += this.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_Loaded;
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x000A8598 File Offset: 0x000A6798
		private void dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			if (Window.GetWindow(this).GetType() == typeof(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd) && Class358.smethod_0().method_5(typeof(dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd)) != null)
			{
				this.bool_0 = false;
				Class358.smethod_0().method_5(typeof(dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd)).Close();
			}
			if (this.bool_0)
			{
				this.button_1.Visibility = Visibility.Collapsed;
				return;
			}
			this.button_1.Visibility = Visibility.Visible;
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x000A8618 File Offset: 0x000A6818
		private void textBox_0_GotFocus(object sender, RoutedEventArgs p1)
		{
			this.textBox_0.Text = string.Empty;
			this.textBox_0.Foreground = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.solidColorBrush_3;
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x000A863C File Offset: 0x000A683C
		private void textBox_0_LostFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = (Application.Current.FindResource("AskSomething") as string);
				this.textBox_0.Foreground = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z2NVHWHQTTE97LGZ_ejd;
			}
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x000A8690 File Offset: 0x000A6890
		private void textBox_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs p1)
		{
			TextBox textBox = sender as TextBox;
			if (textBox == null)
			{
				return;
			}
			textBox.SelectAll();
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000A86A4 File Offset: 0x000A68A4
		private void method_0(bool bool_4)
		{
			if (!bool_4)
			{
				this.itemsControl_0.ItemsSource = this.class711_0.observableCollection_0;
				this.method_1(false);
				this.class711_0.observableCollection_0.Add(new Class131.Class712
				{
					IsUser = false,
					Message = (this.bool_1 ? Class364.smethod_0("AiGenFirstWords") : Class364.smethod_0("AiAssistantFirstWords")),
					IsSystemMessage = true
				});
				return;
			}
			this.string_0 = string.Empty;
			this.itemsControl_0.ItemsSource = null;
			this.class711_0 = null;
			this.class711_0 = new Class131.Class711();
			this.itemsControl_0.ItemsSource = this.class711_0.observableCollection_0;
			this.method_1(false);
			this.class711_0.observableCollection_0.Add(new Class131.Class712
			{
				IsUser = false,
				Message = Class364.smethod_0("TweaXHasBeenReloaded") + "\n\n",
				IsSystemMessage = true
			});
			if (this.bool_1)
			{
				Class131.Class712 @class = this.class711_0.observableCollection_0.Last<Class131.Class712>();
				@class.Message += Class364.smethod_0("AiGenFirstWords");
				return;
			}
			Class131.Class712 class2 = this.class711_0.observableCollection_0.Last<Class131.Class712>();
			class2.Message += Class364.smethod_0("AiAssistantFirstWords");
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x000A8808 File Offset: 0x000A6A08
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Struct522 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0 = this;
			@struct.object_0 = sender;
			@struct.routedEventArgs_0 = p1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Struct522>(ref @struct);
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x000A8850 File Offset: 0x000A6A50
		private void method_1(bool bool_4)
		{
			dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Struct523 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0 = this;
			@struct.bool_0 = bool_4;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Struct523>(ref @struct);
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x000A8890 File Offset: 0x000A6A90
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			this.button_0.IsEnabled = false;
			this.button_2.IsEnabled = true;
			this.method_0(true);
			this.button_0.IsEnabled = true;
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x000A88C0 File Offset: 0x000A6AC0
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			this.bool_0 = true;
			((dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)Window.GetWindow(this)).radioButton_0.IsChecked = new bool?(true);
			Class358.smethod_0().method_4(typeof(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd));
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x000A88F8 File Offset: 0x000A6AF8
		private void textBox_0_PreviewKeyDown(object sender, KeyEventArgs p1)
		{
			if (p1.Key == Key.Return && Keyboard.Modifiers == ModifierKeys.Shift)
			{
				TextBox textBox = (TextBox)sender;
				int caretIndex = textBox.CaretIndex;
				textBox.Text = textBox.Text.Insert(caretIndex, Environment.NewLine);
				textBox.CaretIndex = caretIndex + Environment.NewLine.Length;
				p1.Handled = true;
				return;
			}
			if (p1.Key == Key.Return && this.button_2.IsEnabled)
			{
				this.button_2_Click(sender, p1);
			}
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x000A8974 File Offset: 0x000A6B74
		private void checkBox_0_Checked(object sender, RoutedEventArgs p1)
		{
			Class389.class504_0.method_23(new bool?(true));
			this.bool_1 = true;
			this.method_1(false);
			this.class711_0.observableCollection_0.Where(new Func<Class131.Class712, bool>(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class831.class831_0.method_2)).smethod_0(new Action<Class131.Class712>(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class831.class831_0.method_3));
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x000A89F4 File Offset: 0x000A6BF4
		private void checkBox_0_Unchecked(object sender, RoutedEventArgs p1)
		{
			Class389.class504_0.method_23(new bool?(false));
			this.bool_1 = false;
			this.method_1(false);
			this.class711_0.observableCollection_0.Where(new Func<Class131.Class712, bool>(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class831.class831_0.method_4)).smethod_0(new Action<Class131.Class712>(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class831.class831_0.method_5));
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x000A8A74 File Offset: 0x000A6C74
		private void method_2(object sender, RoutedEventArgs p1)
		{
			if (this.class711_0.observableCollection_0.Where(new Func<Class131.Class712, bool>(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class831.class831_0.method_6)).Count<Class131.Class712>() == 0)
			{
				return;
			}
			int num = this.class711_0.observableCollection_0.IndexOf((sender as Button).DataContext as Class131.Class712);
			this.textBox_0.Text = this.class711_0.observableCollection_0[num - 1].Message;
			this.button_2_Click(null, null);
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x000A8B04 File Offset: 0x000A6D04
		private void method_3(object sender, RoutedEventArgs p1)
		{
			this.bool_2 = true;
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x000A8B10 File Offset: 0x000A6D10
		private string method_4(string string_1)
		{
			string text = string_1;
			string[] array = string_1.Split(new string[]
			{
				"|||"
			}, StringSplitOptions.None);
			string[] array2 = string_1.Split(new string[]
			{
				"```"
			}, StringSplitOptions.None);
			if (array.Length >= 2 || array2.Length >= 2)
			{
				text = ((array.Length >= 2) ? array : array2)[1].Trim();
			}
			try
			{
				int num = text.IndexOf('[');
				if (num != -1)
				{
					text = text.Substring(num);
				}
			}
			catch (object obj)
			{
			}
			return text;
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x000A8BB0 File Offset: 0x000A6DB0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_3)
			{
				return;
			}
			this.bool_3 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/aihelperpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x000A8BE0 File Offset: 0x000A6DE0
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
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 4:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_3 = true;
				return;
			case 7:
				this.checkBox_0 = (CheckBox)target;
				this.checkBox_0.Checked += this.checkBox_0_Checked;
				this.checkBox_0.Unchecked += this.checkBox_0_Unchecked;
				return;
			case 8:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				this.textBox_0.MouseLeftButtonUp += this.textBox_0_MouseLeftButtonUp;
				this.textBox_0.PreviewKeyDown += this.textBox_0_PreviewKeyDown;
				return;
			case 9:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			}
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x000A8D4C File Offset: 0x000A6F4C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 5)
			{
				((Button)target).Click += this.method_2;
				return;
			}
			if (connectionId != 6)
			{
				return;
			}
			((Button)target).Click += this.method_3;
		}

		// Token: 0x04001D6E RID: 7534
		public bool bool_0;

		// Token: 0x04001D6F RID: 7535
		private Class131.Class711 class711_0 = new Class131.Class711();

		// Token: 0x04001D70 RID: 7536
		private GClass41 gclass41_0;

		// Token: 0x04001D71 RID: 7537
		private bool bool_1;

		// Token: 0x04001D72 RID: 7538
		private bool bool_2;

		// Token: 0x04001D73 RID: 7539
		private string string_0 = string.Empty;

		// Token: 0x04001D74 RID: 7540
		internal Button button_0;

		// Token: 0x04001D75 RID: 7541
		internal Button button_1;

		// Token: 0x04001D76 RID: 7542
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001D77 RID: 7543
		internal ItemsControl itemsControl_0;

		// Token: 0x04001D78 RID: 7544
		internal CheckBox checkBox_0;

		// Token: 0x04001D79 RID: 7545
		internal TextBox textBox_0;

		// Token: 0x04001D7A RID: 7546
		internal Button button_2;

		// Token: 0x04001D7B RID: 7547
		private bool bool_3;

		// Token: 0x02000789 RID: 1929
		[StructLayout(LayoutKind.Auto)]
		private struct Struct522 : IAsyncStateMachine
		{
			// Token: 0x060027D5 RID: 10197 RVA: 0x000A8D9C File Offset: 0x000A6F9C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd = this.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0;
				try
				{
					TaskAwaiter<string> awaiter;
					switch (num)
					{
					case 0:
						break;
					case 1:
					{
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<string>);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_528;
					}
					case 2:
					{
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<string>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
						goto IL_655;
					}
					case 3:
						IL_683:
						try
						{
							TaskAwaiter awaiter2;
							if (num != 3)
							{
								awaiter2 = dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_19(new Action<string>(this.class830_0.method_1)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num4 = 3;
									num = 3;
									this.int_0 = num4;
									this.taskAwaiter_0 = awaiter2;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Struct522>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = this.taskAwaiter_0;
								this.taskAwaiter_0 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.int_0 = num5;
							}
							awaiter2.GetResult();
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.string_0 = string.Empty;
						}
						catch
						{
							this.class830_0.class712_0.Message = Class364.smethod_0("AIHelperError");
						}
						this.class830_0.class712_0.IsGenerating = false;
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.bool_2 = false;
						this.class830_0.class712_0.IsMessageOnWrite = false;
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.scrollViewer_0.ScrollToEnd();
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.button_2.IsEnabled = true;
						goto IL_79C;
					default:
						this.class830_0 = new dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class830();
						this.class830_0.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0 = this.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0;
						if (!Class585.struct13_0.method_0())
						{
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.class711_0.observableCollection_0.Add(new Class131.Class712
							{
								IsUser = false,
								Message = Class364.smethod_0("AIOnlyPro"),
								IsSystemMessage = true
							});
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.textBox_0.Text = string.Empty;
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.scrollViewer_0.ScrollToEnd();
							goto IL_79C;
						}
						if (dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.string_0.smethod_7())
						{
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.string_0 = dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.textBox_0.Text;
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.textBox_0.Text = string.Empty;
						}
						if (dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.string_0.smethod_7())
						{
							goto IL_79C;
						}
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.button_2.IsEnabled = false;
						this.class830_0.string_0 = dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.string_0;
						this.class830_0.string_1 = string.Empty;
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.class711_0.observableCollection_0.Add(new Class131.Class712
						{
							IsUser = true,
							Message = this.class830_0.string_0
						});
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.scrollViewer_0.ScrollToEnd();
						this.class830_0.class712_0 = new Class131.Class712
						{
							IsUser = false,
							Message = string.Empty
						};
						if (dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.class711_0.observableCollection_0.Last<Class131.Class712>().Message != string.Empty)
						{
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.class711_0.observableCollection_0.Add(this.class830_0.class712_0);
						}
						else
						{
							this.class830_0.class712_0 = dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.class711_0.observableCollection_0.Last<Class131.Class712>();
						}
						if (!dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.bool_1)
						{
							goto IL_296;
						}
						this.class829_0 = new dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class829();
						this.class829_0.class830_0 = this.class830_0;
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_9(this.class829_0.class830_0.string_0, Array.Empty<GClass163.GClass164>());
						this.class829_0.string_0 = string.Empty;
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.scrollViewer_0.ScrollToEnd();
						break;
					}
					try
					{
						TaskAwaiter awaiter2;
						if (num != 0)
						{
							this.class829_0.bool_0 = false;
							awaiter2 = dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_19(new Action<string>(this.class829_0.method_0)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 0;
								num = 0;
								this.int_0 = num6;
								this.taskAwaiter_0 = awaiter2;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Struct522>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num7 = -1;
							num = -1;
							this.int_0 = num7;
						}
						awaiter2.GetResult();
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.string_0 = string.Empty;
						goto IL_3DF;
						IL_296:
						awaiter = Task.Run<string>(new Func<Task<string>>(this.class830_0.method_0)).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_655;
						}
						int num8 = 2;
						num = 2;
						this.int_0 = num8;
						this.taskAwaiter_1 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Struct522>(ref awaiter, ref this);
						return;
					}
					catch (Exception ex)
					{
						if (ex.Message.Contains("maximum context length"))
						{
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.method_1(false);
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.button_2_Click(this.object_0, this.routedEventArgs_0);
							goto IL_79C;
						}
						if (ex.Message.Contains("Rate limit"))
						{
							this.class829_0.class830_0.class712_0.Message = Class364.smethod_0("RateLimitError");
						}
						else
						{
							if (ex.Message.Contains("insufficient_quota"))
							{
								dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.method_1(true);
								dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.button_2_Click(this.object_0, this.routedEventArgs_0);
								goto IL_79C;
							}
							this.class829_0.class830_0.class712_0.Message = Class364.smethod_0("AIHelperError");
						}
					}
					IL_3DF:
					string text = Class606.smethod_1(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.method_4(this.class829_0.string_0));
					List<GClass179> list = null;
					try
					{
						list = JsonConvert.DeserializeObject<List<GClass179>>(text);
					}
					catch
					{
						this.class829_0.class830_0.class712_0.IsGenerating = false;
						this.class829_0.class830_0.class712_0.IsMessageOnWrite = false;
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.scrollViewer_0.ScrollToEnd();
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.button_2.IsEnabled = true;
						goto IL_79C;
					}
					if (list == null)
					{
						goto IL_5F0;
					}
					if (!list.Any(new Func<GClass179, bool>(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class831.class831_0.method_0)))
					{
						goto IL_547;
					}
					if (!list.Any(new Func<GClass179, bool>(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class831.class831_0.method_1)))
					{
						goto IL_547;
					}
					dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_9(Class364.smethod_0("AskAIForAddArgs"), Array.Empty<GClass163.GClass164>());
					awaiter = dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_17().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num9 = 1;
						num = 1;
						this.int_0 = num9;
						this.taskAwaiter_1 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Struct522>(ref awaiter, ref this);
						return;
					}
					IL_528:
					string result = awaiter.GetResult();
					string text2 = dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.method_4(result);
					text = Class606.smethod_1(text2);
					list = JsonConvert.DeserializeObject<List<GClass179>>(text2);
					IL_547:
					List<GClass179>.Enumerator enumerator = list.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							GClass179 gclass179_ = enumerator.Current;
							Class745 @class = new Class745(gclass179_, new Class525(gclass179_), true, false);
							@class.ShowDescription = true;
							@class.ShowTweaks = true;
							@class.IsEditable = true;
							@class.ApplyVisibility = Visibility.Visible;
							@class.AddVisibility = Visibility.Visible;
							this.class829_0.class830_0.class712_0.Tweaks.Add(@class);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					if (list.Count > 0)
					{
						this.class829_0.class830_0.class712_0.HasTweak = Visibility.Visible;
					}
					IL_5F0:
					this.class829_0.class830_0.class712_0.IsGenerating = false;
					this.class829_0.class830_0.class712_0.IsMessageOnWrite = false;
					dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.scrollViewer_0.ScrollToEnd();
					dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.button_2.IsEnabled = true;
					goto IL_79C;
					IL_655:
					awaiter.GetResult();
					dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.scrollViewer_0.ScrollToEnd();
					dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_9(this.class830_0.string_1, Array.Empty<GClass163.GClass164>());
					goto IL_683;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class830_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_79C:
				this.int_0 = -2;
				this.class830_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060027D6 RID: 10198 RVA: 0x000A95DC File Offset: 0x000A77DC
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D7C RID: 7548
			public int int_0;

			// Token: 0x04001D7D RID: 7549
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D7E RID: 7550
			public dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0;

			// Token: 0x04001D7F RID: 7551
			public object object_0;

			// Token: 0x04001D80 RID: 7552
			public RoutedEventArgs routedEventArgs_0;

			// Token: 0x04001D81 RID: 7553
			private dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class829 class829_0;

			// Token: 0x04001D82 RID: 7554
			private dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class830 class830_0;

			// Token: 0x04001D83 RID: 7555
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x04001D84 RID: 7556
			private TaskAwaiter<string> taskAwaiter_1;
		}

		// Token: 0x0200078A RID: 1930
		private sealed class Class829
		{
			// Token: 0x060027D8 RID: 10200 RVA: 0x000A95F4 File Offset: 0x000A77F4
			internal void method_0(string string_1)
			{
				if (this.class830_0.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0.bool_2)
				{
					this.class830_0.class712_0.IsMessageOnWrite = false;
					this.class830_0.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0.scrollViewer_0.ScrollToEnd();
					this.class830_0.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0.button_2.IsEnabled = true;
					return;
				}
				if (!string_1.Contains("|") && !string_1.Contains("`") && !this.bool_0)
				{
					Class131.Class712 class712_ = this.class830_0.class712_0;
					class712_.Message += string_1;
				}
				if ((string_1.Contains("|") || string_1.Contains("`")) && !this.bool_0)
				{
					this.bool_0 = true;
					Class131.Class712 class712_2 = this.class830_0.class712_0;
					class712_2.Message += string_1.Replace("|", string.Empty).Replace("`", string.Empty).Replace("\n", string.Empty);
				}
				if (this.bool_0)
				{
					this.class830_0.class712_0.IsGenerating = true;
				}
				this.string_0 += string_1;
			}

			// Token: 0x04001D85 RID: 7557
			public string string_0;

			// Token: 0x04001D86 RID: 7558
			public bool bool_0;

			// Token: 0x04001D87 RID: 7559
			public dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class830 class830_0;
		}

		// Token: 0x0200078B RID: 1931
		[StructLayout(LayoutKind.Auto)]
		private struct Struct523 : IAsyncStateMachine
		{
			// Token: 0x060027D9 RID: 10201 RVA: 0x000A972C File Offset: 0x000A792C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd = this.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0;
				try
				{
					TaskAwaiter<GClass41> awaiter;
					if (num != 0)
					{
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0 = null;
						awaiter = Class176.smethod_0(this.bool_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass41>, dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Struct523>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass41>);
						this.int_0 = -1;
					}
					GClass41 result = awaiter.GetResult();
					dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0 = result;
					if (dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.bool_1)
					{
						if (Class364.smethod_0("CurrentLocalization") == "ru-RU")
						{
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_11(Class605.string_1);
						}
						else if (Class364.smethod_0("CurrentLocalization") == "uk-UA")
						{
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_11(Class605.string_2);
						}
						else if (Class364.smethod_0("CurrentLocalization") == "zh-CN")
						{
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_11(Class605.string_3);
						}
						else
						{
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_11(Class605.string_0);
						}
					}
					else
					{
						dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_11(Class364.smethod_0("ChatGPTBase"));
						for (int i = 1; i > 5; i++)
						{
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_9(Class364.smethod_0("AppendUserInput" + i.ToString()), Array.Empty<GClass163.GClass164>());
							dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.gclass41_0.method_12(Class364.smethod_0("ExampleChatbotOutput" + i.ToString()));
						}
					}
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

			// Token: 0x060027DA RID: 10202 RVA: 0x000A992C File Offset: 0x000A7B2C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D88 RID: 7560
			public int int_0;

			// Token: 0x04001D89 RID: 7561
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D8A RID: 7562
			public dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0;

			// Token: 0x04001D8B RID: 7563
			public bool bool_0;

			// Token: 0x04001D8C RID: 7564
			private TaskAwaiter<GClass41> taskAwaiter_0;
		}

		// Token: 0x0200078C RID: 1932
		private sealed class Class830
		{
			// Token: 0x060027DC RID: 10204 RVA: 0x000A9944 File Offset: 0x000A7B44
			internal Task<string> method_0()
			{
				dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class830.Struct524 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
				@struct.class830_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class830.Struct524>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x060027DD RID: 10205 RVA: 0x000A9988 File Offset: 0x000A7B88
			internal void method_1(string string_2)
			{
				if (this.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0.bool_2)
				{
					this.class712_0.IsMessageOnWrite = false;
					this.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0.scrollViewer_0.ScrollToEnd();
					this.dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0.button_2.IsEnabled = true;
					return;
				}
				Class131.Class712 @class = this.class712_0;
				@class.Message += string_2;
			}

			// Token: 0x04001D8D RID: 7565
			public dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd_0;

			// Token: 0x04001D8E RID: 7566
			public Class131.Class712 class712_0;

			// Token: 0x04001D8F RID: 7567
			public string string_0;

			// Token: 0x04001D90 RID: 7568
			public string string_1;

			// Token: 0x0200078D RID: 1933
			[StructLayout(LayoutKind.Auto)]
			private struct Struct524 : IAsyncStateMachine
			{
				// Token: 0x060027DE RID: 10206 RVA: 0x000A99E8 File Offset: 0x000A7BE8
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class830 @class = this.class830_0;
					string result2;
					try
					{
						TaskAwaiter<string> awaiter;
						if (num != 0)
						{
							awaiter = Class245.smethod_0(@class.string_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class830.Struct524>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<string>);
							this.int_0 = -1;
						}
						string result = awaiter.GetResult();
						result2 = (@class.string_1 = "#" + result + "# " + @class.string_0);
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetResult(result2);
				}

				// Token: 0x060027DF RID: 10207 RVA: 0x000A9ACC File Offset: 0x000A7CCC
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x04001D91 RID: 7569
				public int int_0;

				// Token: 0x04001D92 RID: 7570
				public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

				// Token: 0x04001D93 RID: 7571
				public dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class830 class830_0;

				// Token: 0x04001D94 RID: 7572
				private TaskAwaiter<string> taskAwaiter_0;
			}
		}

		// Token: 0x0200078E RID: 1934
		[Serializable]
		private sealed class Class831
		{
			// Token: 0x060027E2 RID: 10210 RVA: 0x000A9AF0 File Offset: 0x000A7CF0
			internal bool method_0(GClass179 gclass179_0)
			{
				return !gclass179_0.method_2();
			}

			// Token: 0x060027E3 RID: 10211 RVA: 0x000A9AFC File Offset: 0x000A7CFC
			internal bool method_1(GClass179 gclass179_0)
			{
				return !gclass179_0.method_1();
			}

			// Token: 0x060027E4 RID: 10212 RVA: 0x000A9B08 File Offset: 0x000A7D08
			internal bool method_2(Class131.Class712 class712_0)
			{
				return class712_0.Message.Contains(Class364.smethod_0("AiAssistantFirstWords"));
			}

			// Token: 0x060027E5 RID: 10213 RVA: 0x000A9B20 File Offset: 0x000A7D20
			internal void method_3(Class131.Class712 class712_0)
			{
				class712_0.Message = Class364.smethod_0("AiGenFirstWords");
			}

			// Token: 0x060027E6 RID: 10214 RVA: 0x000A9B34 File Offset: 0x000A7D34
			internal bool method_4(Class131.Class712 class712_0)
			{
				return class712_0.Message.Contains(Class364.smethod_0("AiGenFirstWords"));
			}

			// Token: 0x060027E7 RID: 10215 RVA: 0x000A9B4C File Offset: 0x000A7D4C
			internal void method_5(Class131.Class712 class712_0)
			{
				class712_0.Message = Class364.smethod_0("AiAssistantFirstWords");
			}

			// Token: 0x060027E8 RID: 10216 RVA: 0x000A9B60 File Offset: 0x000A7D60
			internal bool method_6(Class131.Class712 class712_0)
			{
				return class712_0.IsUser;
			}

			// Token: 0x04001D95 RID: 7573
			public static readonly dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class831 class831_0 = new dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd.Class831();

			// Token: 0x04001D96 RID: 7574
			public static Func<GClass179, bool> func_0;

			// Token: 0x04001D97 RID: 7575
			public static Func<GClass179, bool> func_1;

			// Token: 0x04001D98 RID: 7576
			public static Func<Class131.Class712, bool> func_2;

			// Token: 0x04001D99 RID: 7577
			public static Action<Class131.Class712> action_0;

			// Token: 0x04001D9A RID: 7578
			public static Func<Class131.Class712, bool> func_3;

			// Token: 0x04001D9B RID: 7579
			public static Action<Class131.Class712> action_1;

			// Token: 0x04001D9C RID: 7580
			public static Func<Class131.Class712, bool> func_4;
		}
	}
}
