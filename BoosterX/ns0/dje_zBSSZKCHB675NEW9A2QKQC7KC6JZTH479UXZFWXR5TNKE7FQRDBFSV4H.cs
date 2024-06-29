using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x02000753 RID: 1875
	public sealed class dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd : Page, IComponentConnector
	{
		// Token: 0x060026DC RID: 9948 RVA: 0x000A2448 File Offset: 0x000A0648
		public dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd()
		{
			this.InitializeComponent();
			this.grid_2.Opacity = 0.0;
			this.stackPanel_0.Opacity = 0.0;
			this.stackPanel_1.Opacity = 0.0;
			this.grid_1.Opacity = 0.0;
			this.grid_0.Opacity = 0.0;
			this.grid_2.Visibility = Visibility.Collapsed;
			this.stackPanel_0.Visibility = Visibility.Collapsed;
			this.stackPanel_1.Visibility = Visibility.Collapsed;
			this.grid_1.Visibility = Visibility.Collapsed;
			this.grid_0.Visibility = Visibility.Collapsed;
			this.method_0(this.grid_0);
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x000A2518 File Offset: 0x000A0718
		public void method_0(UIElement uielement_0)
		{
			dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class819 @class = new dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class819();
			@class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0 = this;
			@class.uielement_0 = uielement_0;
			base.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x000A2550 File Offset: 0x000A0750
		private void method_1(object sender, DragEventArgs p1)
		{
			if (!Class585.struct13_0.method_0())
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_1, Class364.smethod_0("prorequired"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
				return;
			}
			if (p1.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] array = (string[])p1.Data.GetData(DataFormats.FileDrop);
				this.method_3(File.ReadAllText(array[0]));
			}
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x000A25BC File Offset: 0x000A07BC
		private void method_2(object sender, MouseButtonEventArgs p1)
		{
			if (!Class585.struct13_0.method_0())
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(this.textBlock_1, Class364.smethod_0("prorequired"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
				return;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All files (*.*)|*.*";
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			openFileDialog.Title = Class364.smethod_0("ChooseFile");
			bool? flag = openFileDialog.ShowDialog();
			if (!(flag.GetValueOrDefault() & flag != null))
			{
				return;
			}
			this.method_3(File.ReadAllText(openFileDialog.FileName));
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x000A264C File Offset: 0x000A084C
		private void method_3(string string_1)
		{
			dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct500 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0 = this;
			@struct.string_0 = string_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct500>(ref @struct);
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x000A268C File Offset: 0x000A088C
		private void method_4(object sender, RoutedEventArgs p1)
		{
			Class389.class504_0.method_23(new bool?(true));
			((dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)Window.GetWindow(this)).radioButton_3.IsChecked = new bool?(true);
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x000A26BC File Offset: 0x000A08BC
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct499 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct499>(ref @struct);
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x000A26F4 File Offset: 0x000A08F4
		private Task<bool> method_5(string string_1)
		{
			dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct498 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
			@struct.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0 = this;
			@struct.string_0 = string_1;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct498>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x000A2740 File Offset: 0x000A0940
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct497 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct497>(ref @struct);
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x000A2778 File Offset: 0x000A0978
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0(this.grid_0);
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x000A2788 File Offset: 0x000A0988
		private string method_6(string string_1)
		{
			string text = string_1;
			string[] array = string_1.Split(new string[]
			{
				"```"
			}, StringSplitOptions.None);
			if (array.Length >= 2)
			{
				text = array[1].Trim();
			}
			int num = text.IndexOf('[');
			if (num != -1)
			{
				text = text.Substring(num);
			}
			return text;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x000A27DC File Offset: 0x000A09DC
		private void textBox_0_GotFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == Class364.smethod_0("EnterTweakFileForAIDesc"))
			{
				this.textBox_0.Text = string.Empty;
			}
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x000A280C File Offset: 0x000A0A0C
		private void textBox_0_LostFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text.smethod_7())
			{
				this.textBox_0.Text = Class364.smethod_0("EnterTweakFileForAIDesc");
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000A2838 File Offset: 0x000A0A38
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class820 @class = new dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class820();
			@class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0 = this;
			if (!Class585.struct13_0.method_0())
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_8(this.textBlock_0, Class364.smethod_0("prorequired"), true);
				return;
			}
			this.method_0(this.grid_2);
			GClass179 gclass = new GClass179();
			gclass.IsEditable = true;
			gclass.Name = Class364.smethod_0("EnterName");
			gclass.Description = Class364.smethod_0("EnterDesc");
			gclass.String_2 = "EmoticonCool";
			gclass.List_0 = new List<string>
			{
				"VISIBLETWEAKS"
			};
			gclass.Type = "DOUBLE";
			gclass.List_4 = new List<GClass67>
			{
				new GClass67
				{
					String_0 = "REG",
					Path = Class364.smethod_0("EnterRegPath"),
					Key = Class364.smethod_0("EnterRegKey"),
					Values = new List<GClass72>
					{
						new GClass72
						{
							List_0 = new List<string>
							{
								"DEFAULT"
							},
							String_0 = Class364.smethod_0("EnterDefaultRegValue")
						},
						new GClass72
						{
							List_0 = new List<string>
							{
								"BEST"
							},
							String_0 = Class364.smethod_0("EnterBestRegValue")
						}
					}
				}
			};
			@class.class745_0 = new Class745(gclass, new Class525(gclass), true, false);
			@class.class745_0.ShowDescription = true;
			@class.class745_0.ShowTweaks = true;
			@class.class745_0.IsEditable = true;
			@class.class745_0.ApplyVisibility = Visibility.Visible;
			@class.class745_0.AddVisibility = Visibility.Visible;
			base.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000A29F0 File Offset: 0x000A0BF0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/mytweaks/addtweakpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000A2A20 File Offset: 0x000A0C20
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.grid_0 = (Grid)target;
				return;
			case 2:
				((Button)target).Click += this.method_4;
				return;
			case 3:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 4:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 5:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 6:
				((Grid)target).Drop += this.method_1;
				((Grid)target).MouseLeftButtonUp += this.method_2;
				return;
			case 7:
				this.border_0 = (Border)target;
				return;
			case 8:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				return;
			case 9:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 10:
				this.grid_1 = (Grid)target;
				return;
			case 11:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 12:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 13:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 14:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 15:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 16:
				this.grid_2 = (Grid)target;
				return;
			case 17:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000A2C14 File Offset: 0x000A0E14
		private bool method_7()
		{
			return this.itemsControl_0.Items.Count > 0;
		}

		// Token: 0x04001C4E RID: 7246
		private GClass41 gclass41_0;

		// Token: 0x04001C4F RID: 7247
		private string string_0 = string.Empty;

		// Token: 0x04001C50 RID: 7248
		internal Grid grid_0;

		// Token: 0x04001C51 RID: 7249
		internal TextBlock textBlock_0;

		// Token: 0x04001C52 RID: 7250
		internal Button button_0;

		// Token: 0x04001C53 RID: 7251
		internal TextBlock textBlock_1;

		// Token: 0x04001C54 RID: 7252
		internal Border border_0;

		// Token: 0x04001C55 RID: 7253
		internal TextBox textBox_0;

		// Token: 0x04001C56 RID: 7254
		internal Button button_1;

		// Token: 0x04001C57 RID: 7255
		internal Grid grid_1;

		// Token: 0x04001C58 RID: 7256
		internal StackPanel stackPanel_0;

		// Token: 0x04001C59 RID: 7257
		internal StackPanel stackPanel_1;

		// Token: 0x04001C5A RID: 7258
		internal TextBlock textBlock_2;

		// Token: 0x04001C5B RID: 7259
		internal Button button_2;

		// Token: 0x04001C5C RID: 7260
		internal Button button_3;

		// Token: 0x04001C5D RID: 7261
		internal Grid grid_2;

		// Token: 0x04001C5E RID: 7262
		internal ItemsControl itemsControl_0;

		// Token: 0x04001C5F RID: 7263
		private bool bool_0;

		// Token: 0x02000754 RID: 1876
		[StructLayout(LayoutKind.Auto)]
		private struct Struct497 : IAsyncStateMachine
		{
			// Token: 0x060026ED RID: 9965 RVA: 0x000A2C2C File Offset: 0x000A0E2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd = this.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.button_3.IsEnabled = false;
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_0(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.stackPanel_0);
						awaiter = dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_5(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.string_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct497>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<bool>);
						this.int_0 = -1;
					}
					if (awaiter.GetResult())
					{
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.textBlock_2, Class364.smethod_0("CannotGenerateTweakTryAgain"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_0(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.stackPanel_1);
					}
					else
					{
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_0(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.grid_2);
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.button_3.IsEnabled = true;
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

			// Token: 0x060026EE RID: 9966 RVA: 0x000A2D44 File Offset: 0x000A0F44
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C60 RID: 7264
			public int int_0;

			// Token: 0x04001C61 RID: 7265
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001C62 RID: 7266
			public dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0;

			// Token: 0x04001C63 RID: 7267
			private TaskAwaiter<bool> taskAwaiter_0;
		}

		// Token: 0x02000755 RID: 1877
		private sealed class Class817
		{
			// Token: 0x060026F0 RID: 9968 RVA: 0x000A2D5C File Offset: 0x000A0F5C
			internal void method_0()
			{
				this.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.itemsControl_0.Items.Clear();
				this.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.itemsControl_0.Items.Add(this.class745_0);
				this.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.itemsControl_0.Items.Refresh();
			}

			// Token: 0x04001C64 RID: 7268
			public Class745 class745_0;

			// Token: 0x04001C65 RID: 7269
			public dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0;
		}

		// Token: 0x02000756 RID: 1878
		[StructLayout(LayoutKind.Auto)]
		private struct Struct498 : IAsyncStateMachine
		{
			// Token: 0x060026F1 RID: 9969 RVA: 0x000A2DB0 File Offset: 0x000A0FB0
			void IAsyncStateMachine.MoveNext()
			{
				/*
An exception occurred when decompiling this method (060026F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ns0.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd/Struct498::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_24C:; 	brtrue(IL_2DC, logicnot:bool(ldfld:class [mscorlib]System.Collections.Generic.List`1<class GClass179>[exp:bool](Struct498::list_0, ldloc:valuetype ns0.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd/Struct498&(this)))); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x060026F2 RID: 9970 RVA: 0x000A3228 File Offset: 0x000A1428
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C66 RID: 7270
			public int int_0;

			// Token: 0x04001C67 RID: 7271
			public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

			// Token: 0x04001C68 RID: 7272
			public dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0;

			// Token: 0x04001C69 RID: 7273
			public string string_0;

			// Token: 0x04001C6A RID: 7274
			private string string_1;

			// Token: 0x04001C6B RID: 7275
			private List<GClass179> list_0;

			// Token: 0x04001C6C RID: 7276
			private bool bool_0;

			// Token: 0x04001C6D RID: 7277
			private int int_1;

			// Token: 0x04001C6E RID: 7278
			private TaskAwaiter<GClass41> taskAwaiter_0;

			// Token: 0x04001C6F RID: 7279
			private TaskAwaiter<string> taskAwaiter_1;
		}

		// Token: 0x02000757 RID: 1879
		[StructLayout(LayoutKind.Auto)]
		private struct Struct499 : IAsyncStateMachine
		{
			// Token: 0x060026F3 RID: 9971 RVA: 0x000A3238 File Offset: 0x000A1438
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd = this.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						if (!Class585.struct13_0.method_0())
						{
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.textBlock_1, Class364.smethod_0("prorequired"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
							goto IL_12F;
						}
						if (dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.textBox_0.Text.smethod_7())
						{
							goto IL_12F;
						}
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.button_1.IsEnabled = false;
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_0(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.stackPanel_0);
						awaiter = dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_5(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.textBox_0.Text).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct499>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<bool>);
						this.int_0 = -1;
					}
					if (!awaiter.GetResult())
					{
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.textBlock_2, Class364.smethod_0("CannotGenerateTweakTryAgain"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_0(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.stackPanel_1);
					}
					else
					{
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_0(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.grid_2);
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.button_1.IsEnabled = true;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_12F:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060026F4 RID: 9972 RVA: 0x000A33A4 File Offset: 0x000A15A4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C70 RID: 7280
			public int int_0;

			// Token: 0x04001C71 RID: 7281
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001C72 RID: 7282
			public dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0;

			// Token: 0x04001C73 RID: 7283
			private TaskAwaiter<bool> taskAwaiter_0;
		}

		// Token: 0x02000758 RID: 1880
		[StructLayout(LayoutKind.Auto)]
		private struct Struct500 : IAsyncStateMachine
		{
			// Token: 0x060026F5 RID: 9973 RVA: 0x000A33B4 File Offset: 0x000A15B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd = this.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0;
				try
				{
					try
					{
						TaskAwaiter awaiter2;
						if (num != 0)
						{
							TaskAwaiter<bool> awaiter;
							if (num != 1)
							{
								if (!this.string_0.smethod_7() && this.string_0.Length >= 5)
								{
									dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_0(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.stackPanel_0);
									awaiter = dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_5(this.string_0).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										this.int_0 = 1;
										this.taskAwaiter_1 = awaiter;
										this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct500>(ref awaiter, ref this);
										return;
									}
								}
								else
								{
									dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.textBlock_1, Class364.smethod_0("EmptyFile"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
									awaiter2 = Task.Delay(1500).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										this.int_0 = 0;
										this.taskAwaiter_0 = awaiter2;
										this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Struct500>(ref awaiter2, ref this);
										return;
									}
									goto IL_166;
								}
							}
							else
							{
								awaiter = this.taskAwaiter_1;
								this.taskAwaiter_1 = default(TaskAwaiter<bool>);
								this.int_0 = -1;
							}
							if (!awaiter.GetResult())
							{
								dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.textBlock_2, Class364.smethod_0("CannotGenerateTweakTryAgain"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
								dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_0(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.stackPanel_1);
								goto IL_1CF;
							}
							dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_0(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.grid_2);
							goto IL_1AE;
						}
						else
						{
							awaiter2 = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
						}
						IL_166:
						awaiter2.GetResult();
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.textBlock_1, string.Empty);
					}
					catch
					{
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.textBlock_2, Class364.smethod_0("CannotGenerateTweakTryAgain"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_0(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.stackPanel_1);
					}
					IL_1AE:;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1CF:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060026F6 RID: 9974 RVA: 0x000A35D8 File Offset: 0x000A17D8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C74 RID: 7284
			public int int_0;

			// Token: 0x04001C75 RID: 7285
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001C76 RID: 7286
			public string string_0;

			// Token: 0x04001C77 RID: 7287
			public dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0;

			// Token: 0x04001C78 RID: 7288
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x04001C79 RID: 7289
			private TaskAwaiter<bool> taskAwaiter_1;
		}

		// Token: 0x02000759 RID: 1881
		[Serializable]
		private sealed class Class818
		{
			// Token: 0x060026F9 RID: 9977 RVA: 0x000A35FC File Offset: 0x000A17FC
			internal bool method_0(GClass179 gclass179_0)
			{
				return !gclass179_0.method_2();
			}

			// Token: 0x060026FA RID: 9978 RVA: 0x000A3608 File Offset: 0x000A1808
			internal bool method_1(GClass179 gclass179_0)
			{
				return !gclass179_0.method_1();
			}

			// Token: 0x04001C7A RID: 7290
			public static readonly dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class818 class818_0 = new dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class818();

			// Token: 0x04001C7B RID: 7291
			public static Func<GClass179, bool> func_0;

			// Token: 0x04001C7C RID: 7292
			public static Func<GClass179, bool> func_1;
		}

		// Token: 0x0200075A RID: 1882
		private sealed class Class819
		{
			// Token: 0x060026FC RID: 9980 RVA: 0x000A361C File Offset: 0x000A181C
			internal void method_0()
			{
				dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class819.Struct501 @struct;
				@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
				@struct.class819_0 = this;
				@struct.int_0 = -1;
				@struct.asyncVoidMethodBuilder_0.Start<dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class819.Struct501>(ref @struct);
			}

			// Token: 0x04001C7D RID: 7293
			public dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0;

			// Token: 0x04001C7E RID: 7294
			public UIElement uielement_0;

			// Token: 0x0200075B RID: 1883
			[StructLayout(LayoutKind.Auto)]
			private struct Struct501 : IAsyncStateMachine
			{
				// Token: 0x060026FD RID: 9981 RVA: 0x000A3654 File Offset: 0x000A1854
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class819 @class = this.class819_0;
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
							goto IL_EB;
						case 2:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_150;
						case 3:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_1B5;
						case 4:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_21A;
						default:
							awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.grid_2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class819.Struct501>(ref awaiter, ref this);
								return;
							}
							break;
						}
						awaiter.GetResult();
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.grid_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class819.Struct501>(ref awaiter, ref this);
							return;
						}
						IL_EB:
						awaiter.GetResult();
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.stackPanel_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 2;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class819.Struct501>(ref awaiter, ref this);
							return;
						}
						IL_150:
						awaiter.GetResult();
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.stackPanel_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 3;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class819.Struct501>(ref awaiter, ref this);
							return;
						}
						IL_1B5:
						awaiter.GetResult();
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.grid_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 4;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class819.Struct501>(ref awaiter, ref this);
							return;
						}
						IL_21A:
						awaiter.GetResult();
						if (@class.uielement_0 == @class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.stackPanel_1)
						{
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(@class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.grid_1);
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(@class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.stackPanel_1);
						}
						else if (@class.uielement_0 == @class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.stackPanel_0)
						{
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(@class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.grid_1);
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(@class.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.stackPanel_0);
						}
						else
						{
							dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(@class.uielement_0);
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

				// Token: 0x060026FE RID: 9982 RVA: 0x000A3940 File Offset: 0x000A1B40
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x04001C7F RID: 7295
				public int int_0;

				// Token: 0x04001C80 RID: 7296
				public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

				// Token: 0x04001C81 RID: 7297
				public dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.Class819 class819_0;

				// Token: 0x04001C82 RID: 7298
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x0200075C RID: 1884
		private sealed class Class820
		{
			// Token: 0x06002700 RID: 9984 RVA: 0x000A3958 File Offset: 0x000A1B58
			internal void method_0()
			{
				this.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.itemsControl_0.Items.Clear();
				this.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.itemsControl_0.Items.Add(this.class745_0);
				this.dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0.itemsControl_0.Items.Refresh();
				this.class745_0.OnEdit = true;
				this.class745_0.method_22();
			}

			// Token: 0x04001C83 RID: 7299
			public dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd_0;

			// Token: 0x04001C84 RID: 7300
			public Class745 class745_0;
		}
	}
}
