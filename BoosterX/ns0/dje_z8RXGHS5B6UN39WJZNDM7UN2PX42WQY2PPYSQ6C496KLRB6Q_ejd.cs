using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using BoosterX.Classes.Tweaks.CleanerModel;
using BoosterX.Classes.Tweaks.Expert.ServicesTweak;
using BoosterX.Classes.Tweaks.OptimizationTweaks.GlobalTweak;
using Microsoft.Win32.TaskScheduler;
using XamlAnimatedGif;

namespace ns0
{
	// Token: 0x020006DC RID: 1756
	public sealed class dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd : Page, IComponentConnector
	{
		// Token: 0x0600256E RID: 9582 RVA: 0x00098D14 File Offset: 0x00096F14
		public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd()
		{
			this.InitializeComponent();
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_11(new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44(this.method_0));
			base.Loaded += this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_Loaded;
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_16(new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42(this.method_3));
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_14(new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43(this.method_4));
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00098DB8 File Offset: 0x00096FB8
		private void method_0()
		{
			this.scrollViewer_0.ScrollToEnd();
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00098DC8 File Offset: 0x00096FC8
		private void dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.list_2.Clear();
			this.itemsControl_0.Items.Clear();
			this.list_0.Clear();
			this.list_1.Clear();
			this.bool_0 = false;
			this.long_0 = 0L;
			this.int_0 = 0;
			this.grid_0.Opacity = 0.0;
			this.grid_0.Visibility = Visibility.Collapsed;
			this.grid_1.Opacity = 0.0;
			this.grid_1.Visibility = Visibility.Collapsed;
			this.grid_3.Opacity = 0.0;
			this.grid_3.Visibility = Visibility.Collapsed;
			this.grid_4.Opacity = 0.0;
			this.grid_4.Visibility = Visibility.Collapsed;
			this.border_1.Visibility = Visibility.Collapsed;
			this.border_2.Visibility = Visibility.Collapsed;
			this.border_0.Visibility = Visibility.Collapsed;
			this.int_1 = 0;
			this.string_0 = string.Empty;
			this.string_1 = string.Empty;
			this.string_2 = string.Empty;
			Class178.int_0 = 0;
			Task.Run(new Action(this.method_7));
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00098F08 File Offset: 0x00097108
		private void method_1()
		{
			dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct437 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct437>(ref @struct);
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00098F40 File Offset: 0x00097140
		private void method_2()
		{
			dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct439 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct439>(ref @struct);
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00098F78 File Offset: 0x00097178
		private void method_3()
		{
			dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct444 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct444>(ref @struct);
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x00098FB0 File Offset: 0x000971B0
		private void method_4()
		{
			dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct442 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct442>(ref @struct);
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00098FE8 File Offset: 0x000971E8
		private Task method_5()
		{
			dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct438 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct438>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x0009902C File Offset: 0x0009722C
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd = (dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)Window.GetWindow(this);
			bool? isChecked = dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.radioButton_1.IsChecked;
			if (isChecked.GetValueOrDefault() & isChecked != null)
			{
				Class358.smethod_0().method_3(typeof(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd), Class358.smethod_0().frame_0);
				return;
			}
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.radioButton_1.IsChecked = new bool?(true);
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00099098 File Offset: 0x00097298
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct441 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct441>(ref @struct);
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x000990D0 File Offset: 0x000972D0
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class185.smethod_24("explorer windowsdefender://ThreatSettings");
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000990DC File Offset: 0x000972DC
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			if (Class334.bool_0)
			{
				Class334.bool_0 = false;
				Class358.smethod_0().method_3(typeof(dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd), Class358.smethod_0().frame_0);
				return;
			}
			if (Class704.bool_0)
			{
				Class358.smethod_0().method_3(typeof(dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd), Class358.smethod_0().frame_0);
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x0009915C File Offset: 0x0009735C
		private void button_4_Click(object sender, RoutedEventArgs p1)
		{
			Process.Start("shutdown.exe", "-r -t 0");
			Application.Current.Shutdown();
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00099178 File Offset: 0x00097378
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/expapplyingpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000991A8 File Offset: 0x000973A8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_6(Type type_0, string string_3)
		{
			return Delegate.CreateDelegate(type_0, this, string_3);
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000991B4 File Offset: 0x000973B4
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Button)target).Click += this.button_1_Click;
				return;
			case 2:
				this.grid_0 = (Grid)target;
				return;
			case 3:
				this.image_0 = (Image)target;
				return;
			case 4:
				this.grid_1 = (Grid)target;
				return;
			case 5:
				this.grid_2 = (Grid)target;
				return;
			case 6:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 7:
				this.image_1 = (Image)target;
				return;
			case 8:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 9:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			case 10:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 11:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 12:
				this.grid_3 = (Grid)target;
				return;
			case 13:
				this.image_2 = (Image)target;
				return;
			case 14:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 15:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 16:
				this.itemsControl_1 = (ItemsControl)target;
				return;
			case 17:
				this.grid_4 = (Grid)target;
				return;
			case 18:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 19:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 20:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 21:
				this.textBlock_4 = (TextBlock)target;
				return;
			case 22:
				this.textBlock_5 = (TextBlock)target;
				return;
			case 23:
				this.textBlock_6 = (TextBlock)target;
				return;
			case 24:
				this.textBlock_7 = (TextBlock)target;
				return;
			case 25:
				this.textBlock_8 = (TextBlock)target;
				return;
			case 26:
				this.border_0 = (Border)target;
				return;
			case 27:
				this.border_1 = (Border)target;
				return;
			case 28:
				this.border_2 = (Border)target;
				return;
			case 29:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 30:
				this.button_4 = (Button)target;
				this.button_4.Click += this.button_4_Click;
				return;
			default:
				this.bool_1 = true;
				return;
			}
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x0009944C File Offset: 0x0009764C
		private void method_7()
		{
			this.method_1();
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00099454 File Offset: 0x00097654
		private void method_8()
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.observableCollection_0.Clear();
			this.itemsControl_1.ItemsSource = null;
			this.itemsControl_1.ItemsSource = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.observableCollection_0;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x0009947C File Offset: 0x0009767C
		private void method_9()
		{
			dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class777 @class = new dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class777();
			if (Class203.bool_1)
			{
				this.border_0.Visibility = Visibility.Visible;
			}
			bool? flag = Class389.class504_0.method_18();
			if (flag.GetValueOrDefault() & flag != null)
			{
				flag = Class389.class504_0.method_20();
				if (flag.GetValueOrDefault() & flag != null)
				{
					Class389.class504_0.method_19(new bool?(false));
					Class389.class504_0.method_21(new bool?(false));
					this.border_2.Visibility = Visibility.Visible;
					goto IL_163;
				}
			}
			flag = Class389.class504_0.method_18();
			if (flag.GetValueOrDefault() & flag != null)
			{
				flag = Class389.class504_0.method_20();
				if (!(flag.GetValueOrDefault() & flag != null))
				{
					TaskService taskService = new TaskService();
					try
					{
						string text = "BoosterXStartupTask";
						TaskDefinition taskDefinition = taskService.NewTask();
						taskDefinition.RegistrationInfo.Description = "Runs BoosterX.exe at system startup with admin rights for av disable";
						taskDefinition.Principal.RunLevel = 1;
						taskDefinition.Triggers.Add<LogonTrigger>(new LogonTrigger());
						taskDefinition.Actions.Add<ExecAction>(new ExecAction(Class389.class504_0.method_2(), "-DisableAV", null));
						taskService.RootFolder.RegisterTaskDefinition(text, taskDefinition);
					}
					finally
					{
						taskService.Dispose();
					}
					this.border_1.Visibility = Visibility.Visible;
				}
			}
			IL_163:
			this.textBlock_4.Text = this.int_0.ToString();
			this.textBlock_5.Text = this.string_1;
			this.textBlock_7.Text = this.string_2;
			this.textBlock_6.Text = this.string_0;
			@class.long_0 = 0L;
			if (this.bool_0)
			{
				dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.list_2.ForEach(new Action<JsonCleanDto>(@class.method_0));
			}
			try
			{
				this.textBlock_3.Text = string.Format("{0:0.## MB}", (this.long_0 - @class.long_0) / 1024L / 1024L);
			}
			catch
			{
				this.textBlock_3.Text = "0 MB";
			}
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x000996D8 File Offset: 0x000978D8
		private void method_10()
		{
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(this.grid_4);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_25(this.grid_4);
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x000996F0 File Offset: 0x000978F0
		private Task method_11()
		{
			dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct443 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct443>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00099734 File Offset: 0x00097934
		private void method_12()
		{
			try
			{
				Dictionary<Type, Dictionary<string, GClass93.GStruct4>> dictionary = GClass93.smethod_0().method_19();
				if (!dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_11)))
				{
					if (!dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_12)))
					{
						if (!dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_13)))
						{
							return;
						}
					}
				}
				foreach (KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair in dictionary)
				{
					if (!(keyValuePair.Key == null))
					{
						Type key = keyValuePair.Key;
						if (key == typeof(ServicesTweak))
						{
							foreach (KeyValuePair<string, GClass93.GStruct4> keyValuePair2 in keyValuePair.Value)
							{
								if (keyValuePair2.Key != null)
								{
									string tweakArgument = keyValuePair2.Value.method_2().ToString();
									ServicesTweak servicesTweak = keyValuePair2.Value.method_0() as ServicesTweak;
									servicesTweak.TweakArgument = tweakArgument;
									ServiceStartMode? newStartMode = servicesTweak.NewStartMode;
									if (newStartMode.GetValueOrDefault() == ServiceStartMode.Disabled & newStartMode != null)
									{
										this.list_1.Add(servicesTweak.ServiceName);
										this.int_0++;
									}
								}
							}
						}
						if (key == typeof(Class525))
						{
							foreach (KeyValuePair<string, GClass93.GStruct4> keyValuePair3 in keyValuePair.Value)
							{
								if (keyValuePair3.Key != null)
								{
									JsonTweakArgument jsonTweakArgument = keyValuePair3.Value.method_2() as JsonTweakArgument;
									Class525 @class = keyValuePair3.Value.method_0() as Class525;
									if (jsonTweakArgument.NewTweakStatus == "BEST" && @class.method_6().WillBrake.Count > 0)
									{
										using (List<string>.Enumerator enumerator3 = @class.method_6().WillBrake.GetEnumerator())
										{
											while (enumerator3.MoveNext())
											{
												dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class771 class2 = new dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class771();
												class2.string_0 = enumerator3.Current;
												bool flag = false;
												foreach (GClass225 gclass in this.list_0)
												{
													if (Class364.smethod_0(class2.string_0) == gclass.WhatWillBrake)
													{
														flag = true;
													}
												}
												if (flag)
												{
													this.list_0.First(new Func<GClass225, bool>(class2.method_0)).TweaksNames.Add(@class.method_6().Name);
												}
												else
												{
													this.list_0.Add(new GClass225(this)
													{
														WhatWillBrakeEng = class2.string_0,
														WhatWillBrake = Class364.smethod_0(class2.string_0),
														TweaksNames = new List<string>
														{
															@class.method_6().Name
														}
													});
												}
											}
										}
									}
								}
							}
						}
						if (key == typeof(Class520))
						{
							foreach (KeyValuePair<string, GClass93.GStruct4> keyValuePair4 in keyValuePair.Value)
							{
								dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class779 class3 = new dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class779();
								if (keyValuePair4.Key != null)
								{
									keyValuePair4.Value.method_2();
									GInterface15 ginterface = keyValuePair4.Value.method_0();
									class3.class520_0 = (ginterface as Class520);
									if (!class3.class520_0.method_6().IsEnabled)
									{
										class3.string_0 = string.Empty;
										if (class3.class520_0.method_6().ClassName == "Bluetooth")
										{
											class3.string_0 = "WBBluetooth";
										}
										if (class3.class520_0.method_6().ClassName == "PrintQueue")
										{
											class3.string_0 = "WBPrinter";
										}
										if (class3.class520_0.method_6().ClassName == "WAN Miniport")
										{
											class3.string_0 = "WBADSL";
										}
										if (class3.string_0 == string.Empty)
										{
											GClass127.list_1.ForEach(new Action<string>(class3.method_0));
										}
										if (!(class3.string_0 == string.Empty))
										{
											bool flag2 = false;
											foreach (GClass225 gclass2 in this.list_0)
											{
												if (Class364.smethod_0(class3.string_0) == gclass2.WhatWillBrake)
												{
													flag2 = true;
												}
											}
											if (flag2)
											{
												this.list_0.First(new Func<GClass225, bool>(class3.method_1)).DevicesNames.Add(class3.class520_0.method_6().Id);
											}
											else
											{
												this.list_0.Add(new GClass225(this)
												{
													WhatWillBrakeEng = class3.string_0,
													WhatWillBrake = Class364.smethod_0(class3.string_0),
													DevicesNames = new List<string>
													{
														class3.class520_0.method_6().Id
													}
												});
											}
										}
									}
								}
							}
						}
					}
				}
				Dictionary<string, GClass155> dictionary2 = GClass139.smethod_0().method_0();
				using (List<string>.Enumerator enumerator3 = this.list_1.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class776 class4 = new dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class776();
						class4.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = this;
						class4.string_0 = enumerator3.Current;
						foreach (KeyValuePair<string, GClass155> keyValuePair5 in dictionary2)
						{
							if (!keyValuePair5.Key.smethod_7() && !(keyValuePair5.Key.ToLower() != class4.string_0.ToLower()))
							{
								List<string> list = keyValuePair5.Value.List_0;
								Action<string> action;
								if ((action = class4.action_0) == null)
								{
									action = (class4.action_0 = new Action<string>(class4.method_0));
								}
								list.ForEach(action);
							}
						}
					}
				}
				using (List<GClass225>.Enumerator enumerator4 = this.list_0.GetEnumerator())
				{
					while (enumerator4.MoveNext())
					{
						dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class780 class5 = new dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class780();
						class5.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = this;
						class5.gclass225_0 = enumerator4.Current;
						base.Dispatcher.Invoke(new Action(class5.method_0));
					}
				}
			}
			catch (object obj)
			{
			}
		}

		// Token: 0x04001A59 RID: 6745
		public List<GClass225> list_0 = new List<GClass225>();

		// Token: 0x04001A5A RID: 6746
		public List<string> list_1 = new List<string>();

		// Token: 0x04001A5B RID: 6747
		public static List<JsonCleanDto> list_2 = new List<JsonCleanDto>();

		// Token: 0x04001A5C RID: 6748
		public int int_0;

		// Token: 0x04001A5D RID: 6749
		public long long_0;

		// Token: 0x04001A5E RID: 6750
		public int int_1;

		// Token: 0x04001A5F RID: 6751
		public string string_0 = string.Empty;

		// Token: 0x04001A60 RID: 6752
		public string string_1 = string.Empty;

		// Token: 0x04001A61 RID: 6753
		public string string_2 = string.Empty;

		// Token: 0x04001A62 RID: 6754
		private bool bool_0;

		// Token: 0x04001A63 RID: 6755
		internal Grid grid_0;

		// Token: 0x04001A64 RID: 6756
		internal Image image_0;

		// Token: 0x04001A65 RID: 6757
		internal Grid grid_1;

		// Token: 0x04001A66 RID: 6758
		internal Grid grid_2;

		// Token: 0x04001A67 RID: 6759
		internal Button button_0;

		// Token: 0x04001A68 RID: 6760
		internal Image image_1;

		// Token: 0x04001A69 RID: 6761
		internal StackPanel stackPanel_0;

		// Token: 0x04001A6A RID: 6762
		internal ItemsControl itemsControl_0;

		// Token: 0x04001A6B RID: 6763
		internal Button button_1;

		// Token: 0x04001A6C RID: 6764
		internal Button button_2;

		// Token: 0x04001A6D RID: 6765
		internal Grid grid_3;

		// Token: 0x04001A6E RID: 6766
		internal Image image_2;

		// Token: 0x04001A6F RID: 6767
		internal TextBlock textBlock_0;

		// Token: 0x04001A70 RID: 6768
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001A71 RID: 6769
		internal ItemsControl itemsControl_1;

		// Token: 0x04001A72 RID: 6770
		internal Grid grid_4;

		// Token: 0x04001A73 RID: 6771
		internal TextBlock textBlock_1;

		// Token: 0x04001A74 RID: 6772
		internal TextBlock textBlock_2;

		// Token: 0x04001A75 RID: 6773
		internal TextBlock textBlock_3;

		// Token: 0x04001A76 RID: 6774
		internal TextBlock textBlock_4;

		// Token: 0x04001A77 RID: 6775
		internal TextBlock textBlock_5;

		// Token: 0x04001A78 RID: 6776
		internal TextBlock textBlock_6;

		// Token: 0x04001A79 RID: 6777
		internal TextBlock textBlock_7;

		// Token: 0x04001A7A RID: 6778
		internal TextBlock textBlock_8;

		// Token: 0x04001A7B RID: 6779
		internal Border border_0;

		// Token: 0x04001A7C RID: 6780
		internal Border border_1;

		// Token: 0x04001A7D RID: 6781
		internal Border border_2;

		// Token: 0x04001A7E RID: 6782
		internal Button button_3;

		// Token: 0x04001A7F RID: 6783
		internal Button button_4;

		// Token: 0x04001A80 RID: 6784
		private bool bool_1;

		// Token: 0x020006DD RID: 1757
		[StructLayout(LayoutKind.Auto)]
		private struct Struct437 : IAsyncStateMachine
		{
			// Token: 0x06002585 RID: 9605 RVA: 0x00099FA8 File Offset: 0x000981A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd = this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<bool> awaiter2;
					TaskAwaiter<ObservableCollection<Class745>> awaiter3;
					switch (num)
					{
					case 0:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						break;
					}
					case 1:
					{
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<bool>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
						goto IL_164;
					}
					case 2:
					{
						awaiter3 = this.taskAwaiter_2;
						this.taskAwaiter_2 = default(TaskAwaiter<ObservableCollection<Class745>>);
						int num4 = -1;
						num = -1;
						this.int_0 = num4;
						goto IL_1D0;
					}
					case 3:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num5 = -1;
						num = -1;
						this.int_0 = num5;
						goto IL_275;
					}
					case 4:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num6 = -1;
						num = -1;
						this.int_0 = num6;
						goto IL_379;
					}
					case 5:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num7 = -1;
						num = -1;
						this.int_0 = num7;
						goto IL_433;
					}
					case 6:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num8 = -1;
						num = -1;
						this.int_0 = num8;
						goto IL_893;
					}
					default:
					{
						this.class774_0 = new dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class774();
						this.class774_0.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;
						dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Dispatcher.Invoke(new Action(this.class774_0.method_0));
						bool? flag = Class389.class504_0.method_18();
						if (!(flag.GetValueOrDefault() & flag != null))
						{
							goto IL_215;
						}
						flag = Class389.class504_0.method_20();
						if (!(flag.GetValueOrDefault() & flag != null))
						{
							goto IL_215;
						}
						awaiter = Class588.smethod_7().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num9 = 0;
							num = 0;
							this.int_0 = num9;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct437>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					awaiter2 = Class588.smethod_10().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						int num10 = 1;
						num = 1;
						this.int_0 = num10;
						this.taskAwaiter_1 = awaiter2;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct437>(ref awaiter2, ref this);
						return;
					}
					IL_164:
					awaiter2.GetResult();
					awaiter3 = Class588.smethod_2(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), false).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						int num11 = 2;
						num = 2;
						this.int_0 = num11;
						this.taskAwaiter_2 = awaiter3;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct437>(ref awaiter3, ref this);
						return;
					}
					IL_1D0:
					Class745 @class = awaiter3.GetResult().FirstOrDefault(new Func<Class745, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_0));
					if (@class != null)
					{
						@class.ForceOff.Execute(null);
					}
					IL_215:
					if (!Class704.bool_0)
					{
						goto IL_27C;
					}
					awaiter = Class704.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num12 = 3;
						num = 3;
						this.int_0 = num12;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct437>(ref awaiter, ref this);
						return;
					}
					IL_275:
					awaiter.GetResult();
					IL_27C:
					this.dictionary_0 = GClass93.smethod_0().method_19();
					Dictionary<Type, Dictionary<string, GClass93.GStruct4>>.Enumerator enumerator = this.dictionary_0.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair = enumerator.Current;
							Dictionary<string, GClass93.GStruct4>.Enumerator enumerator2 = keyValuePair.Value.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									KeyValuePair<string, GClass93.GStruct4> keyValuePair2 = enumerator2.Current;
									Class178.int_0++;
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator2).Dispose();
								}
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					awaiter = Task.Run(new Func<Task>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.method_5)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num13 = 4;
						num = 4;
						this.int_0 = num13;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct437>(ref awaiter, ref this);
						return;
					}
					IL_379:
					awaiter.GetResult();
					if (this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_1)))
					{
						dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.bool_0 = true;
						this.dictionary_0[typeof(Class526)].ToList<KeyValuePair<string, GClass93.GStruct4>>().ForEach(new Action<KeyValuePair<string, GClass93.GStruct4>>(this.class774_0.method_1));
					}
					this.int_1 = 0;
					IL_3F0:
					if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_5)
					{
						int num14 = this.int_1;
						this.int_1 = num14 + 1;
						if (num14 <= 1000)
						{
							awaiter = Task.Delay(20).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_433;
							}
							int num15 = 5;
							num = 5;
							this.int_0 = num15;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct437>(ref awaiter, ref this);
							return;
						}
					}
					dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.int_1 = (int)dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.double_0;
					dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.string_0 = (this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_2)) ? this.dictionary_0[typeof(Class523)].Count<KeyValuePair<string, GClass93.GStruct4>>().ToString() : "0");
					int num16 = 0 + (this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_3)) ? this.dictionary_0[typeof(Class525)].Count<KeyValuePair<string, GClass93.GStruct4>>() : 0);
					dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.string_1 = (num16 + (this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_4)) ? this.dictionary_0[typeof(Class524)].Count<KeyValuePair<string, GClass93.GStruct4>>() : 0)).ToString();
					dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd2 = dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd;
					string string_;
					if (!this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_5)))
					{
						string_ = "0";
					}
					else
					{
						string_ = this.dictionary_0[typeof(Class521)].Where(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_6)).Count<KeyValuePair<string, GClass93.GStruct4>>().ToString();
					}
					dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd2.string_2 = string_;
					this.class774_0.bool_0 = false;
					if (this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_7)))
					{
						this.class774_0.bool_0 = this.dictionary_0[typeof(Class525)].Any(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_8));
						if (this.dictionary_0[typeof(Class525)].Any(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_9)))
						{
							if (((JsonTweakArgument)this.dictionary_0[typeof(Class525)].First(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778.class778_0.method_10)).Value.method_2()).NewTweakStatus == "BEST")
							{
								bool? flag = Class389.class504_0.method_18();
								if (!(flag.GetValueOrDefault() & flag != null))
								{
									flag = Class389.class504_0.method_20();
									if (!(flag.GetValueOrDefault() & flag != null))
									{
										this.class774_0.bool_0 = true;
										Class389.class504_0.method_19(new bool?(true));
										Class389.class504_0.method_21(new bool?(false));
									}
								}
							}
						}
					}
					if (Class178.dictionary_0 != null && Class178.dictionary_0.Count > 0 && Class178.dictionary_0.ContainsKey(Class364.smethod_0("DisableDefender")))
					{
						this.class774_0.bool_0 = true;
					}
					dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Dispatcher.Invoke(new Action(this.class774_0.method_2));
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_13(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.grid_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num17 = 6;
						num = 6;
						this.int_0 = num17;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct437>(ref awaiter, ref this);
						return;
					}
					goto IL_893;
					IL_433:
					awaiter.GetResult();
					goto IL_3F0;
					IL_893:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.grid_0);
					if (dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.list_0.Count > 0 | this.class774_0.bool_0)
					{
						dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Dispatcher.Invoke(new Action(this.class774_0.method_3));
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.grid_1);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_25(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.grid_1);
					}
					else
					{
						dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.method_2();
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class774_0 = null;
					this.dictionary_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class774_0 = null;
				this.dictionary_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002586 RID: 9606 RVA: 0x0009A954 File Offset: 0x00098B54
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A81 RID: 6785
			public int int_0;

			// Token: 0x04001A82 RID: 6786
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A83 RID: 6787
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;

			// Token: 0x04001A84 RID: 6788
			private dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class774 class774_0;

			// Token: 0x04001A85 RID: 6789
			private Dictionary<Type, Dictionary<string, GClass93.GStruct4>> dictionary_0;

			// Token: 0x04001A86 RID: 6790
			private int int_1;

			// Token: 0x04001A87 RID: 6791
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x04001A88 RID: 6792
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x04001A89 RID: 6793
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_2;
		}

		// Token: 0x020006DE RID: 1758
		private sealed class Class771
		{
			// Token: 0x06002588 RID: 9608 RVA: 0x0009A96C File Offset: 0x00098B6C
			internal bool method_0(GClass225 gclass225_0)
			{
				return gclass225_0.WhatWillBrake == Class364.smethod_0(this.string_0);
			}

			// Token: 0x04001A8A RID: 6794
			public string string_0;
		}

		// Token: 0x020006DF RID: 1759
		private sealed class Class772
		{
			// Token: 0x0600258A RID: 9610 RVA: 0x0009A98C File Offset: 0x00098B8C
			internal bool method_0(GClass225 gclass225_0)
			{
				return gclass225_0.WhatWillBrake == Class364.smethod_0(this.string_0);
			}

			// Token: 0x04001A8B RID: 6795
			public string string_0;
		}

		// Token: 0x020006E0 RID: 1760
		private sealed class Class773
		{
			// Token: 0x0600258C RID: 9612 RVA: 0x0009A9AC File Offset: 0x00098BAC
			internal void method_0()
			{
				if (!this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.IsVisible)
				{
					this.bool_0 = true;
				}
			}

			// Token: 0x0600258D RID: 9613 RVA: 0x0009A9C4 File Offset: 0x00098BC4
			internal void method_1()
			{
				this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.textBlock_2.Text = Class364.smethod_0(string.Format("GLHF{0}", this.int_0));
			}

			// Token: 0x0600258E RID: 9614 RVA: 0x0009A9F0 File Offset: 0x00098BF0
			internal void method_2()
			{
				this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.textBlock_1.Text = this.string_0 + this.int_1.ToString().Replace("-", string.Empty) + "%";
			}

			// Token: 0x04001A8C RID: 6796
			public bool bool_0;

			// Token: 0x04001A8D RID: 6797
			public int int_0;

			// Token: 0x04001A8E RID: 6798
			public string string_0;

			// Token: 0x04001A8F RID: 6799
			public int int_1;

			// Token: 0x04001A90 RID: 6800
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;
		}

		// Token: 0x020006E1 RID: 1761
		private sealed class Class774
		{
			// Token: 0x06002590 RID: 9616 RVA: 0x0009AA34 File Offset: 0x00098C34
			internal void method_0()
			{
				this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.grid_0.Visibility = Visibility.Visible;
				this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.grid_0.Opacity = 1.0;
			}

			// Token: 0x06002591 RID: 9617 RVA: 0x0009AA60 File Offset: 0x00098C60
			internal void method_1(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
			{
				if (keyValuePair_0.Value.method_2().GetType() == typeof(Class750))
				{
					Class750 @class = keyValuePair_0.Value.method_2() as Class750;
					this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.long_0 = this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.long_0 + (long)@class.Size * 1024L * 1024L;
				}
				if (keyValuePair_0.Value.method_2().GetType() == typeof(JsonCleanDto))
				{
					JsonCleanDto jsonCleanDto = (JsonCleanDto)keyValuePair_0.Value.method_2();
					dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.list_2.Add(jsonCleanDto);
					this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.long_0 = this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.long_0 + Class650.smethod_12(jsonCleanDto.Paths, jsonCleanDto.SearchPattern, jsonCleanDto.IncludeInsideFolders);
				}
			}

			// Token: 0x06002592 RID: 9618 RVA: 0x0009AB4C File Offset: 0x00098D4C
			internal void method_2()
			{
				this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.textBlock_8.Text = Class178.int_0.ToString();
			}

			// Token: 0x06002593 RID: 9619 RVA: 0x0009AB68 File Offset: 0x00098D68
			internal void method_3()
			{
				if (this.bool_0)
				{
					AnimationBehavior.SetSourceUri(this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.image_1, new Uri("pack://application:,,,/Resources/Images/Apply/DisableTamper" + Class364.smethod_0("CurrentLocalization") + ".gif"));
					this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.grid_2.Visibility = Visibility.Visible;
				}
				else
				{
					this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.grid_2.Visibility = Visibility.Collapsed;
				}
				if (this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.list_0.Count > 0)
				{
					this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.stackPanel_0.Visibility = Visibility.Visible;
					return;
				}
				this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.stackPanel_0.Visibility = Visibility.Collapsed;
			}

			// Token: 0x04001A91 RID: 6801
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;

			// Token: 0x04001A92 RID: 6802
			public bool bool_0;
		}

		// Token: 0x020006E2 RID: 1762
		[StructLayout(LayoutKind.Auto)]
		private struct Struct438 : IAsyncStateMachine
		{
			// Token: 0x06002594 RID: 9620 RVA: 0x0009AC08 File Offset: 0x00098E08
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd @object = this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(@object.method_12)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct438>(ref awaiter, ref this);
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
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06002595 RID: 9621 RVA: 0x0009ACC8 File Offset: 0x00098EC8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A93 RID: 6803
			public int int_0;

			// Token: 0x04001A94 RID: 6804
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001A95 RID: 6805
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;

			// Token: 0x04001A96 RID: 6806
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006E3 RID: 1763
		private sealed class Class775
		{
			// Token: 0x06002597 RID: 9623 RVA: 0x0009ACE0 File Offset: 0x00098EE0
			internal void method_0()
			{
				try
				{
					this.class777_0.long_0 = this.class777_0.long_0 + Class650.smethod_12(this.jsonCleanDto_0.Paths, this.jsonCleanDto_0.SearchPattern, this.jsonCleanDto_0.IncludeInsideFolders);
				}
				catch (object obj)
				{
				}
			}

			// Token: 0x04001A97 RID: 6807
			public JsonCleanDto jsonCleanDto_0;

			// Token: 0x04001A98 RID: 6808
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class777 class777_0;
		}

		// Token: 0x020006E4 RID: 1764
		[StructLayout(LayoutKind.Auto)]
		private struct Struct439 : IAsyncStateMachine
		{
			// Token: 0x06002598 RID: 9624 RVA: 0x0009AD40 File Offset: 0x00098F40
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd = this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_85;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_14C;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_1AF;
					default:
						dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Dispatcher.Invoke(new Action(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.method_8));
						Class704.bool_0 = false;
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.grid_3);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_25(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.grid_3);
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_19();
						break;
					}
					IL_58:
					if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.string_0 != "FINISHED")
					{
						awaiter = Task.Delay(10).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct439>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.string_0 = string.Empty;
						dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Dispatcher.Invoke(new Action(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.method_9));
						awaiter = Class704.smethod_0().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct439>(ref awaiter, ref this);
							return;
						}
						goto IL_14C;
					}
					IL_85:
					awaiter.GetResult();
					goto IL_58;
					IL_14C:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_13(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.grid_3).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct439>(ref awaiter, ref this);
						return;
					}
					IL_1AF:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.grid_3);
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_18();
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

			// Token: 0x06002599 RID: 9625 RVA: 0x0009AF64 File Offset: 0x00099164
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A99 RID: 6809
			public int int_0;

			// Token: 0x04001A9A RID: 6810
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A9B RID: 6811
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;

			// Token: 0x04001A9C RID: 6812
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006E5 RID: 1765
		private sealed class Class776
		{
			// Token: 0x0600259B RID: 9627 RVA: 0x0009AF7C File Offset: 0x0009917C
			internal void method_0(string string_1)
			{
				dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class772 @class = new dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class772();
				@class.string_0 = string_1;
				if (!@class.string_0.smethod_7())
				{
					bool flag = false;
					foreach (GClass225 gclass in this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.list_0)
					{
						if (Class364.smethod_0(@class.string_0) == gclass.WhatWillBrake)
						{
							flag = true;
						}
					}
					if (flag)
					{
						this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.list_0.First(new Func<GClass225, bool>(@class.method_0)).ServicesNames.Add(this.string_0);
						return;
					}
					this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.list_0.Add(new GClass225(this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0)
					{
						WhatWillBrakeEng = @class.string_0,
						WhatWillBrake = Class364.smethod_0(@class.string_0),
						ServicesNames = new List<string>
						{
							this.string_0
						}
					});
				}
			}

			// Token: 0x04001A9D RID: 6813
			public string string_0;

			// Token: 0x04001A9E RID: 6814
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;

			// Token: 0x04001A9F RID: 6815
			public Action<string> action_0;
		}

		// Token: 0x020006E6 RID: 1766
		private sealed class Class777
		{
			// Token: 0x0600259D RID: 9629 RVA: 0x0009B090 File Offset: 0x00099290
			internal void method_0(JsonCleanDto jsonCleanDto_0)
			{
				dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class777.Struct440 @struct;
				@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
				@struct.class777_0 = this;
				@struct.jsonCleanDto_0 = jsonCleanDto_0;
				@struct.int_0 = -1;
				@struct.asyncVoidMethodBuilder_0.Start<dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class777.Struct440>(ref @struct);
			}

			// Token: 0x04001AA0 RID: 6816
			public long long_0;

			// Token: 0x020006E7 RID: 1767
			[StructLayout(LayoutKind.Auto)]
			private struct Struct440 : IAsyncStateMachine
			{
				// Token: 0x0600259E RID: 9630 RVA: 0x0009B0D0 File Offset: 0x000992D0
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class777 @class = this.class777_0;
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(new Action(new dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class775
							{
								class777_0 = @class,
								jsonCleanDto_0 = this.jsonCleanDto_0
							}.method_0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class777.Struct440>(ref awaiter, ref this);
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

				// Token: 0x0600259F RID: 9631 RVA: 0x0009B1A4 File Offset: 0x000993A4
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x04001AA1 RID: 6817
				public int int_0;

				// Token: 0x04001AA2 RID: 6818
				public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

				// Token: 0x04001AA3 RID: 6819
				public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class777 class777_0;

				// Token: 0x04001AA4 RID: 6820
				public JsonCleanDto jsonCleanDto_0;

				// Token: 0x04001AA5 RID: 6821
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x020006E8 RID: 1768
		[Serializable]
		private sealed class Class778
		{
			// Token: 0x060025A2 RID: 9634 RVA: 0x0009B1C8 File Offset: 0x000993C8
			internal bool method_0(Class745 class745_0)
			{
				return class745_0.NameRaw == "DefenderAndSmartScreen";
			}

			// Token: 0x060025A3 RID: 9635 RVA: 0x0009B1DC File Offset: 0x000993DC
			internal bool method_1(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class526);
			}

			// Token: 0x060025A4 RID: 9636 RVA: 0x0009B1F4 File Offset: 0x000993F4
			internal bool method_2(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class523);
			}

			// Token: 0x060025A5 RID: 9637 RVA: 0x0009B20C File Offset: 0x0009940C
			internal bool method_3(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class525);
			}

			// Token: 0x060025A6 RID: 9638 RVA: 0x0009B224 File Offset: 0x00099424
			internal bool method_4(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class524);
			}

			// Token: 0x060025A7 RID: 9639 RVA: 0x0009B23C File Offset: 0x0009943C
			internal bool method_5(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class521);
			}

			// Token: 0x060025A8 RID: 9640 RVA: 0x0009B254 File Offset: 0x00099454
			internal bool method_6(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
			{
				return keyValuePair_0.Value.method_2().ToString() != "Enable";
			}

			// Token: 0x060025A9 RID: 9641 RVA: 0x0009B280 File Offset: 0x00099480
			internal bool method_7(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class525);
			}

			// Token: 0x060025AA RID: 9642 RVA: 0x0009B298 File Offset: 0x00099498
			internal bool method_8(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
			{
				return keyValuePair_0.Key == Class364.smethod_0("DefenderAndSmartScreenDebloat");
			}

			// Token: 0x060025AB RID: 9643 RVA: 0x0009B2B0 File Offset: 0x000994B0
			internal bool method_9(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
			{
				return keyValuePair_0.Key == Class364.smethod_0("DefenderAndSmartScreen");
			}

			// Token: 0x060025AC RID: 9644 RVA: 0x0009B2C8 File Offset: 0x000994C8
			internal bool method_10(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
			{
				return keyValuePair_0.Key == Class364.smethod_0("DefenderAndSmartScreen");
			}

			// Token: 0x060025AD RID: 9645 RVA: 0x0009B2E0 File Offset: 0x000994E0
			internal bool method_11(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(ServicesTweak);
			}

			// Token: 0x060025AE RID: 9646 RVA: 0x0009B2F8 File Offset: 0x000994F8
			internal bool method_12(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class525);
			}

			// Token: 0x060025AF RID: 9647 RVA: 0x0009B310 File Offset: 0x00099510
			internal bool method_13(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class520);
			}

			// Token: 0x04001AA6 RID: 6822
			public static readonly dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778 class778_0 = new dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class778();

			// Token: 0x04001AA7 RID: 6823
			public static Func<Class745, bool> func_0;

			// Token: 0x04001AA8 RID: 6824
			public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_1;

			// Token: 0x04001AA9 RID: 6825
			public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_2;

			// Token: 0x04001AAA RID: 6826
			public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_3;

			// Token: 0x04001AAB RID: 6827
			public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_4;

			// Token: 0x04001AAC RID: 6828
			public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_5;

			// Token: 0x04001AAD RID: 6829
			public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_6;

			// Token: 0x04001AAE RID: 6830
			public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_7;

			// Token: 0x04001AAF RID: 6831
			public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_8;

			// Token: 0x04001AB0 RID: 6832
			public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_9;

			// Token: 0x04001AB1 RID: 6833
			public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_10;

			// Token: 0x04001AB2 RID: 6834
			public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_11;

			// Token: 0x04001AB3 RID: 6835
			public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_12;

			// Token: 0x04001AB4 RID: 6836
			public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_13;
		}

		// Token: 0x020006E9 RID: 1769
		[StructLayout(LayoutKind.Auto)]
		private struct Struct441 : IAsyncStateMachine
		{
			// Token: 0x060025B0 RID: 9648 RVA: 0x0009B328 File Offset: 0x00099528
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd = this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_13(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.grid_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct441>(ref awaiter, ref this);
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
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.grid_1);
					dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.method_2();
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

			// Token: 0x060025B1 RID: 9649 RVA: 0x0009B3F0 File Offset: 0x000995F0
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AB5 RID: 6837
			public int int_0;

			// Token: 0x04001AB6 RID: 6838
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001AB7 RID: 6839
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;

			// Token: 0x04001AB8 RID: 6840
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006EA RID: 1770
		[StructLayout(LayoutKind.Auto)]
		private struct Struct442 : IAsyncStateMachine
		{
			// Token: 0x060025B2 RID: 9650 RVA: 0x0009B400 File Offset: 0x00099600
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd @object = this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Func<Task>(@object.method_11)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct442>(ref awaiter, ref this);
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

			// Token: 0x060025B3 RID: 9651 RVA: 0x0009B4C0 File Offset: 0x000996C0
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AB9 RID: 6841
			public int int_0;

			// Token: 0x04001ABA RID: 6842
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001ABB RID: 6843
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;

			// Token: 0x04001ABC RID: 6844
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006EB RID: 1771
		[StructLayout(LayoutKind.Auto)]
		private struct Struct443 : IAsyncStateMachine
		{
			// Token: 0x060025B4 RID: 9652 RVA: 0x0009B4D0 File Offset: 0x000996D0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd = this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class773 @class = new dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Class773();
						@class.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd;
						@class.bool_0 = false;
						dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Dispatcher.Invoke(new Action(@class.method_0));
						if (@class.bool_0)
						{
							goto IL_151;
						}
						@class.int_0 = Class180.smethod_0(1, 6);
						dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Dispatcher.Invoke(new Action(@class.method_1));
						@class.int_1 = (int)dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.double_0 - dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.int_1;
						@class.string_0 = ((@class.int_1 > 0) ? "+" : ((@class.int_1 < 0) ? "—" : string.Empty));
						awaiter = dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Dispatcher.InvokeAsync(new Action(@class.method_2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct443>(ref awaiter, ref this);
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
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_151:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060025B5 RID: 9653 RVA: 0x0009B660 File Offset: 0x00099860
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001ABD RID: 6845
			public int int_0;

			// Token: 0x04001ABE RID: 6846
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001ABF RID: 6847
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;

			// Token: 0x04001AC0 RID: 6848
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006EC RID: 1772
		[StructLayout(LayoutKind.Auto)]
		private struct Struct444 : IAsyncStateMachine
		{
			// Token: 0x060025B6 RID: 9654 RVA: 0x0009B670 File Offset: 0x00099870
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd = this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Dispatcher.InvokeAsync(new Action(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.method_10)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd.Struct444>(ref awaiter, ref this);
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

			// Token: 0x060025B7 RID: 9655 RVA: 0x0009B734 File Offset: 0x00099934
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AC1 RID: 6849
			public int int_0;

			// Token: 0x04001AC2 RID: 6850
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001AC3 RID: 6851
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;

			// Token: 0x04001AC4 RID: 6852
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006ED RID: 1773
		private sealed class Class779
		{
			// Token: 0x060025B9 RID: 9657 RVA: 0x0009B74C File Offset: 0x0009994C
			internal void method_0(string string_1)
			{
				if (this.class520_0.method_6().Id.ToLower().StartsWith(string_1.ToLower()))
				{
					this.string_0 = "WBWSL";
				}
			}

			// Token: 0x060025BA RID: 9658 RVA: 0x0009B77C File Offset: 0x0009997C
			internal bool method_1(GClass225 gclass225_0)
			{
				return gclass225_0.WhatWillBrake == Class364.smethod_0(this.string_0);
			}

			// Token: 0x04001AC5 RID: 6853
			public Class520 class520_0;

			// Token: 0x04001AC6 RID: 6854
			public string string_0;
		}

		// Token: 0x020006EE RID: 1774
		private sealed class Class780
		{
			// Token: 0x060025BC RID: 9660 RVA: 0x0009B79C File Offset: 0x0009999C
			internal void method_0()
			{
				this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.itemsControl_0.Items.Add(this.gclass225_0);
			}

			// Token: 0x04001AC7 RID: 6855
			public GClass225 gclass225_0;

			// Token: 0x04001AC8 RID: 6856
			public dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;
		}
	}
}
