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
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020006A2 RID: 1698
	public sealed class dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd : Page, IComponentConnector
	{
		// Token: 0x06002473 RID: 9331 RVA: 0x000911D0 File Offset: 0x0008F3D0
		public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd()
		{
			this.InitializeComponent();
			Class358.smethod_0().frame_2 = this.frame_0;
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				this.grid_2.Visibility = Visibility.Visible;
				this.grid_4.Visibility = Visibility.Collapsed;
				this.method_3();
			}
			else
			{
				this.grid_2.Visibility = Visibility.Collapsed;
				this.radioButton_1.IsChecked = new bool?(true);
			}
			base.DataContext = Class278.class748_0;
			GClass93 gclass = GClass93.smethod_0();
			GClass93.GDelegate3 gdelegate3_;
			if ((gdelegate3_ = dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Class767.gdelegate3_0) == null)
			{
				gdelegate3_ = (dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Class767.gdelegate3_0 = new GClass93.GDelegate3(Class278.smethod_0));
			}
			gclass.method_2(gdelegate3_);
			base.Dispatcher.Invoke<bool>(new Func<bool>(this.method_6));
			GClass93.smethod_0().method_2(new GClass93.GDelegate3(this.method_0));
			base.Loaded += this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_Loaded;
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x000912B0 File Offset: 0x0008F4B0
		private void dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			Dictionary<Type, Dictionary<string, GClass93.GStruct4>> source = GClass93.smethod_0().method_19();
			bool? flag = Class389.class504_0.method_44();
			if (flag.GetValueOrDefault() & flag != null)
			{
				this.radioButton_7.Visibility = Visibility.Visible;
				this.textBlock_4.Visibility = Visibility.Visible;
			}
			else
			{
				this.radioButton_7.Visibility = Visibility.Collapsed;
				this.textBlock_4.Visibility = Visibility.Collapsed;
			}
			flag = Class389.class504_0.method_40();
			if (flag.GetValueOrDefault() & flag != null)
			{
				this.radioButton_6.Visibility = Visibility.Visible;
				this.textBlock_3.Visibility = Visibility.Visible;
			}
			else
			{
				this.radioButton_6.Visibility = Visibility.Collapsed;
				this.textBlock_3.Visibility = Visibility.Collapsed;
			}
			flag = Class389.class504_0.method_26();
			if (flag.GetValueOrDefault() & flag != null)
			{
				this.radioButton_12.Visibility = Visibility.Visible;
				this.textBlock_5.Visibility = Visibility.Visible;
			}
			else
			{
				this.radioButton_12.Visibility = Visibility.Collapsed;
				this.textBlock_5.Visibility = Visibility.Collapsed;
			}
			if (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_3)
			{
				if (!source.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Class768.class768_0.method_0)))
				{
					this.textBlock_2.Visibility = Visibility.Collapsed;
					this.radioButton_3.Visibility = Visibility.Collapsed;
					goto IL_15E;
				}
			}
			this.textBlock_2.Visibility = Visibility.Visible;
			this.radioButton_3.Visibility = Visibility.Visible;
			IL_15E:
			if (Class334.bool_0)
			{
				Class334.bool_0 = false;
				this.button_0.Visibility = Visibility.Visible;
				GClass93.smethod_0().method_10();
				return;
			}
			this.button_0.Visibility = Visibility.Collapsed;
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x0009144C File Offset: 0x0008F64C
		private void method_0()
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct401 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct401>(ref @struct);
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00091484 File Offset: 0x0008F684
		private void dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0_SizeChanged(object sender, SizeChangedEventArgs p1)
		{
			if (this.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Visible)
			{
				this.stackPanel_0.Margin = new Thickness(10.0, 0.0, 0.0, 10.0);
			}
			if (this.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Collapsed)
			{
				this.stackPanel_0.Margin = new Thickness(10.0, 0.0, 10.0, 10.0);
			}
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00091514 File Offset: 0x0008F714
		private void radioButton_6_Checked(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("GroupServices"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.image_0);
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00091550 File Offset: 0x0008F750
		private void radioButton_1_Checked(object sender, RoutedEventArgs p1)
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				this.method_5();
			}
			Class358.smethod_0().method_3(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("settingsexp"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.image_0);
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x000915A4 File Offset: 0x0008F7A4
		private void radioButton_4_Checked(object sender, RoutedEventArgs p1)
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("powermgmtexp"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.image_0);
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x000915F4 File Offset: 0x0008F7F4
		private void radioButton_5_Checked(object sender, RoutedEventArgs p1)
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_z4EFBE23NRXT78H3EAL45CK9M5K537HLZVTED9PC5FL6WLE8YYJD3VFKL5QNA_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("uwpappsexp"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.image_0);
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x00091644 File Offset: 0x0008F844
		private void radioButton_7_Checked(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct398 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct398>(ref @struct);
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x0009167C File Offset: 0x0008F87C
		private void radioButton_11_Checked(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct400 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct400>(ref @struct);
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x000916B4 File Offset: 0x0008F8B4
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x000916D4 File Offset: 0x0008F8D4
		private void radioButton_12_Checked(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct403 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct403>(ref @struct);
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x0009170C File Offset: 0x0008F90C
		private void radioButton_13_Checked(object sender, RoutedEventArgs p1)
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_zEAHJHJCF7YEVQXCTVJ6ZYLNYMV3GV7DXZT4HM29Y3NNNKUR5WQZEF_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("Devices"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.image_0);
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x0009175C File Offset: 0x0008F95C
		private void radioButton_10_Checked(object sender, RoutedEventArgs p1)
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("registrytweaksexp"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.image_0);
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x000917AC File Offset: 0x0008F9AC
		private void radioButton_8_Checked(object sender, RoutedEventArgs p1)
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_z627PU6QDPF5L5L22PZKAYL8VEPS25LWV7TFR5U5JH6MNTERGA6VSXSKBF49Q_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("cleanupexp"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.image_0);
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x000917FC File Offset: 0x0008F9FC
		private void radioButton_9_Checked(object sender, RoutedEventArgs p1)
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("Telemetry"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.image_0);
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0009184C File Offset: 0x0008FA4C
		private void radioButton_14_Checked(object sender, RoutedEventArgs p1)
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("Tasks"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.image_0);
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0009189C File Offset: 0x0008FA9C
		public void method_1(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct402 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct402>(ref @struct);
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x000918D4 File Offset: 0x0008FAD4
		private void method_2(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct412 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct412>(ref @struct);
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0009190C File Offset: 0x0008FB0C
		private void radioButton_17_Checked(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct405 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct405>(ref @struct);
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x00091944 File Offset: 0x0008FB44
		private void radioButton_18_Checked(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct404 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct404>(ref @struct);
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x0009197C File Offset: 0x0008FB7C
		private void radioButton_19_Checked(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct409 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct409>(ref @struct);
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x000919B4 File Offset: 0x0008FBB4
		private void radioButton_20_Checked(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct408 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct408>(ref @struct);
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x000919EC File Offset: 0x0008FBEC
		private void radioButton_3_Checked(object sender, RoutedEventArgs p1)
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("NvidiaPage"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.image_0);
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00091A3C File Offset: 0x0008FC3C
		private void method_3()
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct396 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct396>(ref @struct);
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00091A74 File Offset: 0x0008FC74
		private void method_4(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct406 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct406>(ref @struct);
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x00091AAC File Offset: 0x0008FCAC
		private void button_4_Click(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct410 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct410>(ref @struct);
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x00091AE4 File Offset: 0x0008FCE4
		private void method_5()
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct399 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct399>(ref @struct);
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x00091B1C File Offset: 0x0008FD1C
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class334.bool_1 = true;
			Class358.smethod_0().method_3(typeof(dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00091B44 File Offset: 0x0008FD44
		private void radioButton_16_Checked(object sender, RoutedEventArgs p1)
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_zYPQKVHV4ELZF9HATU6HU9QNCKGCKFTCPJYSSQWCWLDSRMR2L4SABHLS8Q8KA_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("DwmExplorer"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(this.image_0);
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00091B94 File Offset: 0x0008FD94
		private void radioButton_0_Checked(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct397 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct397>(ref @struct);
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00091BCC File Offset: 0x0008FDCC
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct411 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct411>(ref @struct);
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00091C04 File Offset: 0x0008FE04
		private void radioButton_15_Checked(object sender, RoutedEventArgs p1)
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
			{
				return;
			}
			Class358.smethod_0().method_3(typeof(dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd), this.frame_0);
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(this.textBlock_0, Class364.smethod_0("Features"));
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.image_0);
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00091C54 File Offset: 0x0008FE54
		private void radioButton_2_Checked(object sender, RoutedEventArgs p1)
		{
			dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct407 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct407>(ref @struct);
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00091C8C File Offset: 0x0008FE8C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/tweakingmainpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00091CBC File Offset: 0x0008FEBC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0 = (dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd)target;
				this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0.SizeChanged += this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0_SizeChanged;
				return;
			case 2:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 3:
				((Button)target).Click += this.method_1;
				return;
			case 4:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 5:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 6:
				this.image_0 = (Image)target;
				return;
			case 7:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 8:
				this.radioButton_0 = (RadioButton)target;
				this.radioButton_0.Checked += this.radioButton_0_Checked;
				return;
			case 9:
				this.grid_0 = (Grid)target;
				return;
			case 10:
				this.radioButton_1 = (RadioButton)target;
				this.radioButton_1.Checked += this.radioButton_1_Checked;
				return;
			case 11:
				this.radioButton_2 = (RadioButton)target;
				this.radioButton_2.Checked += this.radioButton_2_Checked;
				return;
			case 12:
				this.radioButton_3 = (RadioButton)target;
				this.radioButton_3.Checked += this.radioButton_3_Checked;
				return;
			case 13:
				this.radioButton_4 = (RadioButton)target;
				this.radioButton_4.Checked += this.radioButton_4_Checked;
				return;
			case 14:
				this.radioButton_5 = (RadioButton)target;
				this.radioButton_5.Checked += this.radioButton_5_Checked;
				return;
			case 15:
				this.radioButton_6 = (RadioButton)target;
				this.radioButton_6.Checked += this.radioButton_6_Checked;
				return;
			case 16:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 17:
				this.radioButton_7 = (RadioButton)target;
				this.radioButton_7.Checked += this.radioButton_7_Checked;
				return;
			case 18:
				this.radioButton_8 = (RadioButton)target;
				this.radioButton_8.Checked += this.radioButton_8_Checked;
				return;
			case 19:
				this.radioButton_9 = (RadioButton)target;
				this.radioButton_9.Checked += this.radioButton_9_Checked;
				return;
			case 20:
				this.radioButton_10 = (RadioButton)target;
				this.radioButton_10.Checked += this.radioButton_10_Checked;
				return;
			case 21:
				this.radioButton_11 = (RadioButton)target;
				this.radioButton_11.Checked += this.radioButton_11_Checked;
				return;
			case 22:
				this.radioButton_12 = (RadioButton)target;
				this.radioButton_12.Checked += this.radioButton_12_Checked;
				return;
			case 23:
				this.radioButton_13 = (RadioButton)target;
				this.radioButton_13.Checked += this.radioButton_13_Checked;
				return;
			case 24:
				this.radioButton_14 = (RadioButton)target;
				this.radioButton_14.Checked += this.radioButton_14_Checked;
				return;
			case 25:
				this.radioButton_15 = (RadioButton)target;
				this.radioButton_15.Checked += this.radioButton_15_Checked;
				return;
			case 26:
				this.radioButton_16 = (RadioButton)target;
				this.radioButton_16.Checked += this.radioButton_16_Checked;
				return;
			case 27:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 28:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 29:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 30:
				this.textBlock_4 = (TextBlock)target;
				return;
			case 31:
				this.textBlock_5 = (TextBlock)target;
				return;
			case 32:
				this.grid_1 = (Grid)target;
				return;
			case 33:
				this.image_1 = (Image)target;
				return;
			case 34:
				this.radioButton_17 = (RadioButton)target;
				this.radioButton_17.Checked += this.radioButton_17_Checked;
				return;
			case 35:
				((Button)target).Click += this.method_2;
				return;
			case 36:
				this.radioButton_18 = (RadioButton)target;
				this.radioButton_18.Checked += this.radioButton_18_Checked;
				return;
			case 37:
				((Button)target).Click += this.method_2;
				return;
			case 38:
				this.radioButton_19 = (RadioButton)target;
				this.radioButton_19.Checked += this.radioButton_19_Checked;
				return;
			case 39:
				((Button)target).Click += this.method_2;
				return;
			case 40:
				this.radioButton_20 = (RadioButton)target;
				this.radioButton_20.Checked += this.radioButton_20_Checked;
				return;
			case 41:
				((Button)target).Click += this.method_2;
				return;
			case 42:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 43:
				this.frame_0 = (Frame)target;
				return;
			case 44:
				this.grid_2 = (Grid)target;
				return;
			case 45:
				this.grid_3 = (Grid)target;
				return;
			case 46:
				this.button_3 = (Button)target;
				return;
			case 47:
				((Button)target).Click += this.method_4;
				return;
			case 48:
				this.grid_4 = (Grid)target;
				return;
			case 49:
				this.button_4 = (Button)target;
				this.button_4.Click += this.button_4_Click;
				return;
			case 50:
				((Button)target).Click += this.method_4;
				return;
			case 51:
				this.grid_5 = (Grid)target;
				return;
			case 52:
				((Button)target).Click += this.method_4;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x000922FC File Offset: 0x000904FC
		private bool method_6()
		{
			this.button_2.IsEnabled = false;
			return false;
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00092318 File Offset: 0x00090518
		private void method_7()
		{
			if (GClass93.smethod_0().method_19().Count <= 0 && dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_4.Count <= 0)
			{
				base.Dispatcher.Invoke<bool>(new Func<bool>(this.method_9));
				return;
			}
			base.Dispatcher.Invoke<bool>(new Func<bool>(this.method_8));
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00092380 File Offset: 0x00090580
		private bool method_8()
		{
			this.button_2.IsEnabled = true;
			return true;
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x0009239C File Offset: 0x0009059C
		private bool method_9()
		{
			this.button_2.IsEnabled = false;
			return false;
		}

		// Token: 0x040018FD RID: 6397
		internal dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

		// Token: 0x040018FE RID: 6398
		internal Button button_0;

		// Token: 0x040018FF RID: 6399
		internal Button button_1;

		// Token: 0x04001900 RID: 6400
		internal TextBlock textBlock_0;

		// Token: 0x04001901 RID: 6401
		internal Image image_0;

		// Token: 0x04001902 RID: 6402
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001903 RID: 6403
		internal RadioButton radioButton_0;

		// Token: 0x04001904 RID: 6404
		internal Grid grid_0;

		// Token: 0x04001905 RID: 6405
		internal RadioButton radioButton_1;

		// Token: 0x04001906 RID: 6406
		internal RadioButton radioButton_2;

		// Token: 0x04001907 RID: 6407
		internal RadioButton radioButton_3;

		// Token: 0x04001908 RID: 6408
		internal RadioButton radioButton_4;

		// Token: 0x04001909 RID: 6409
		internal RadioButton radioButton_5;

		// Token: 0x0400190A RID: 6410
		internal RadioButton radioButton_6;

		// Token: 0x0400190B RID: 6411
		internal TextBlock textBlock_1;

		// Token: 0x0400190C RID: 6412
		internal RadioButton radioButton_7;

		// Token: 0x0400190D RID: 6413
		internal RadioButton radioButton_8;

		// Token: 0x0400190E RID: 6414
		internal RadioButton radioButton_9;

		// Token: 0x0400190F RID: 6415
		internal RadioButton radioButton_10;

		// Token: 0x04001910 RID: 6416
		internal RadioButton radioButton_11;

		// Token: 0x04001911 RID: 6417
		internal RadioButton radioButton_12;

		// Token: 0x04001912 RID: 6418
		internal RadioButton radioButton_13;

		// Token: 0x04001913 RID: 6419
		internal RadioButton radioButton_14;

		// Token: 0x04001914 RID: 6420
		internal RadioButton radioButton_15;

		// Token: 0x04001915 RID: 6421
		internal RadioButton radioButton_16;

		// Token: 0x04001916 RID: 6422
		internal StackPanel stackPanel_0;

		// Token: 0x04001917 RID: 6423
		internal TextBlock textBlock_2;

		// Token: 0x04001918 RID: 6424
		internal TextBlock textBlock_3;

		// Token: 0x04001919 RID: 6425
		internal TextBlock textBlock_4;

		// Token: 0x0400191A RID: 6426
		internal TextBlock textBlock_5;

		// Token: 0x0400191B RID: 6427
		internal Grid grid_1;

		// Token: 0x0400191C RID: 6428
		internal Image image_1;

		// Token: 0x0400191D RID: 6429
		internal RadioButton radioButton_17;

		// Token: 0x0400191E RID: 6430
		internal RadioButton radioButton_18;

		// Token: 0x0400191F RID: 6431
		internal RadioButton radioButton_19;

		// Token: 0x04001920 RID: 6432
		internal RadioButton radioButton_20;

		// Token: 0x04001921 RID: 6433
		internal Button button_2;

		// Token: 0x04001922 RID: 6434
		internal Frame frame_0;

		// Token: 0x04001923 RID: 6435
		internal Grid grid_2;

		// Token: 0x04001924 RID: 6436
		internal Grid grid_3;

		// Token: 0x04001925 RID: 6437
		internal Button button_3;

		// Token: 0x04001926 RID: 6438
		internal Grid grid_4;

		// Token: 0x04001927 RID: 6439
		internal Button button_4;

		// Token: 0x04001928 RID: 6440
		internal Grid grid_5;

		// Token: 0x04001929 RID: 6441
		private bool bool_0;

		// Token: 0x020006A3 RID: 1699
		[StructLayout(LayoutKind.Auto)]
		private struct Struct396 : IAsyncStateMachine
		{
			// Token: 0x0600249B RID: 9371 RVA: 0x000923B8 File Offset: 0x000905B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
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
						goto IL_F1;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_167;
					default:
						awaiter = Task.Delay(300).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct396>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_4);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_16(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_4, TimeSpan.FromSeconds(0.4)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct396>(ref awaiter, ref this);
						return;
					}
					IL_F1:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_1);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_16(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_1, TimeSpan.FromSeconds(0.4)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct396>(ref awaiter, ref this);
						return;
					}
					IL_167:
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

			// Token: 0x0600249C RID: 9372 RVA: 0x0009257C File Offset: 0x0009077C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400192A RID: 6442
			public int int_0;

			// Token: 0x0400192B RID: 6443
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400192C RID: 6444
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x0400192D RID: 6445
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006A4 RID: 1700
		[StructLayout(LayoutKind.Auto)]
		private struct Struct397 : IAsyncStateMachine
		{
			// Token: 0x0600249D RID: 9373 RVA: 0x0009258C File Offset: 0x0009078C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
						{
							goto IL_D0;
						}
						Class358.smethod_0().method_3(typeof(dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd), dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.frame_0);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.textBlock_0, Class364.smethod_0("MyTweaks"));
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_0);
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.button_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct397>(ref awaiter, ref this);
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
				IL_D0:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600249E RID: 9374 RVA: 0x0009268C File Offset: 0x0009088C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400192E RID: 6446
			public int int_0;

			// Token: 0x0400192F RID: 6447
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001930 RID: 6448
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001931 RID: 6449
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006A5 RID: 1701
		[StructLayout(LayoutKind.Auto)]
		private struct Struct398 : IAsyncStateMachine
		{
			// Token: 0x0600249F RID: 9375 RVA: 0x0009269C File Offset: 0x0009089C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
						{
							goto IL_CC;
						}
						Class358.smethod_0().method_3(typeof(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd), dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.frame_0);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.textBlock_0, Class364.smethod_0("SevicesManager"));
						awaiter = Task.Delay(200).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct398>(ref awaiter, ref this);
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
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_0);
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_CC:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060024A0 RID: 9376 RVA: 0x00092798 File Offset: 0x00090998
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001932 RID: 6450
			public int int_0;

			// Token: 0x04001933 RID: 6451
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001934 RID: 6452
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001935 RID: 6453
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006A6 RID: 1702
		[StructLayout(LayoutKind.Auto)]
		private struct Struct399 : IAsyncStateMachine
		{
			// Token: 0x060024A1 RID: 9377 RVA: 0x000927A8 File Offset: 0x000909A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
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
						goto IL_100;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_168;
					default:
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_14(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_5, TimeSpan.FromSeconds(0.2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct399>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_5);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_14(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_0, TimeSpan.FromSeconds(0.2)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct399>(ref awaiter, ref this);
						return;
					}
					IL_100:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_0);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct399>(ref awaiter, ref this);
						return;
					}
					IL_168:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_2);
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

			// Token: 0x060024A2 RID: 9378 RVA: 0x00092978 File Offset: 0x00090B78
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001936 RID: 6454
			public int int_0;

			// Token: 0x04001937 RID: 6455
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001938 RID: 6456
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001939 RID: 6457
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006A7 RID: 1703
		[StructLayout(LayoutKind.Auto)]
		private struct Struct400 : IAsyncStateMachine
		{
			// Token: 0x060024A3 RID: 9379 RVA: 0x00092988 File Offset: 0x00090B88
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
						{
							goto IL_CC;
						}
						Class358.smethod_0().method_3(typeof(dje_z8NYEPSSJS77QLDRYJP4YDHXMCCZX642R76WUWAX6XD7EC3JPH2Y7TCVK5HRQ_ejd), dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.frame_0);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.textBlock_0, Class364.smethod_0("autorunsexp"));
						awaiter = Task.Delay(200).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct400>(ref awaiter, ref this);
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
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_0);
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_CC:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060024A4 RID: 9380 RVA: 0x00092A84 File Offset: 0x00090C84
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400193A RID: 6458
			public int int_0;

			// Token: 0x0400193B RID: 6459
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400193C RID: 6460
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x0400193D RID: 6461
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006A8 RID: 1704
		[StructLayout(LayoutKind.Auto)]
		private struct Struct401 : IAsyncStateMachine
		{
			// Token: 0x060024A5 RID: 9381 RVA: 0x00092A94 File Offset: 0x00090C94
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd @object = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
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
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct401>(ref awaiter, ref this);
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

			// Token: 0x060024A6 RID: 9382 RVA: 0x00092B54 File Offset: 0x00090D54
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400193E RID: 6462
			public int int_0;

			// Token: 0x0400193F RID: 6463
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001940 RID: 6464
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001941 RID: 6465
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006A9 RID: 1705
		[StructLayout(LayoutKind.Auto)]
		private struct Struct402 : IAsyncStateMachine
		{
			// Token: 0x060024A7 RID: 9383 RVA: 0x00092B64 File Offset: 0x00090D64
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
						{
							goto IL_E5;
						}
						dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_17.IsChecked = new bool?(false);
						dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_18.IsChecked = new bool?(false);
						dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_19.IsChecked = new bool?(false);
						dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_20.IsChecked = new bool?(false);
						dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_1.IsChecked = new bool?(true);
						awaiter = Class704.smethod_0().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct402>(ref awaiter, ref this);
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
				IL_E5:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060024A8 RID: 9384 RVA: 0x00092C7C File Offset: 0x00090E7C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001942 RID: 6466
			public int int_0;

			// Token: 0x04001943 RID: 6467
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001944 RID: 6468
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001945 RID: 6469
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006AA RID: 1706
		[StructLayout(LayoutKind.Auto)]
		private struct Struct403 : IAsyncStateMachine
		{
			// Token: 0x060024A9 RID: 9385 RVA: 0x00092C8C File Offset: 0x00090E8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
						{
							goto IL_CC;
						}
						Class358.smethod_0().method_3(typeof(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd), dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.frame_0);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.textBlock_0, Class364.smethod_0("affinityexp"));
						awaiter = Task.Delay(200).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct403>(ref awaiter, ref this);
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
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_0);
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_CC:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060024AA RID: 9386 RVA: 0x00092D88 File Offset: 0x00090F88
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001946 RID: 6470
			public int int_0;

			// Token: 0x04001947 RID: 6471
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001948 RID: 6472
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001949 RID: 6473
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006AB RID: 1707
		[StructLayout(LayoutKind.Auto)]
		private struct Struct404 : IAsyncStateMachine
		{
			// Token: 0x060024AB RID: 9387 RVA: 0x00092D98 File Offset: 0x00090F98
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
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
						goto IL_F0;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_14D;
					default:
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
						{
							goto IL_16D;
						}
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct404>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_1.IsChecked = new bool?(true);
					awaiter = Class704.smethod_2().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct404>(ref awaiter, ref this);
						return;
					}
					IL_F0:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct404>(ref awaiter, ref this);
						return;
					}
					IL_14D:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_16D:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060024AC RID: 9388 RVA: 0x00092F44 File Offset: 0x00091144
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400194A RID: 6474
			public int int_0;

			// Token: 0x0400194B RID: 6475
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400194C RID: 6476
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x0400194D RID: 6477
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006AC RID: 1708
		[StructLayout(LayoutKind.Auto)]
		private struct Struct405 : IAsyncStateMachine
		{
			// Token: 0x060024AD RID: 9389 RVA: 0x00092F54 File Offset: 0x00091154
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
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
						goto IL_F0;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_14D;
					default:
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
						{
							goto IL_16D;
						}
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct405>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_1.IsChecked = new bool?(true);
					awaiter = Class704.smethod_1().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct405>(ref awaiter, ref this);
						return;
					}
					IL_F0:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct405>(ref awaiter, ref this);
						return;
					}
					IL_14D:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_16D:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060024AE RID: 9390 RVA: 0x00093100 File Offset: 0x00091300
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400194E RID: 6478
			public int int_0;

			// Token: 0x0400194F RID: 6479
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001950 RID: 6480
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001951 RID: 6481
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006AD RID: 1709
		[StructLayout(LayoutKind.Auto)]
		private struct Struct406 : IAsyncStateMachine
		{
			// Token: 0x060024AF RID: 9391 RVA: 0x00093110 File Offset: 0x00091310
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4 = false;
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_2);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_2);
						dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_1.IsChecked = new bool?(true);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_12(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_4, TimeSpan.FromSeconds(0.2));
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_4);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_12(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_5, TimeSpan.FromSeconds(0.2));
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_5);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_12(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_1, TimeSpan.FromSeconds(0.2));
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_1);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_12(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_0, TimeSpan.FromSeconds(0.2));
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_0);
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_14(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_1, TimeSpan.FromSeconds(0.2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct406>(ref awaiter, ref this);
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
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_1);
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

			// Token: 0x060024B0 RID: 9392 RVA: 0x000932AC File Offset: 0x000914AC
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001952 RID: 6482
			public int int_0;

			// Token: 0x04001953 RID: 6483
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001954 RID: 6484
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001955 RID: 6485
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006AE RID: 1710
		[StructLayout(LayoutKind.Auto)]
		private struct Struct407 : IAsyncStateMachine
		{
			// Token: 0x060024B1 RID: 9393 RVA: 0x000932BC File Offset: 0x000914BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
						{
							goto IL_C2;
						}
						Class358.smethod_0().method_3(typeof(dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd), dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.frame_0);
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_9(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.textBlock_0, Class364.smethod_0("Customization"));
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct407>(ref awaiter, ref this);
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
				IL_C2:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060024B2 RID: 9394 RVA: 0x000933B0 File Offset: 0x000915B0
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001956 RID: 6486
			public int int_0;

			// Token: 0x04001957 RID: 6487
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001958 RID: 6488
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001959 RID: 6489
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006AF RID: 1711
		[StructLayout(LayoutKind.Auto)]
		private struct Struct408 : IAsyncStateMachine
		{
			// Token: 0x060024B3 RID: 9395 RVA: 0x000933C0 File Offset: 0x000915C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
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
						goto IL_F0;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_14D;
					default:
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
						{
							goto IL_16D;
						}
						if (!Class585.struct13_0.method_0())
						{
							goto IL_16D;
						}
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct408>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = Class704.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct408>(ref awaiter, ref this);
						return;
					}
					IL_F0:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct408>(ref awaiter, ref this);
						return;
					}
					IL_14D:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_16D:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060024B4 RID: 9396 RVA: 0x0009356C File Offset: 0x0009176C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400195A RID: 6490
			public int int_0;

			// Token: 0x0400195B RID: 6491
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400195C RID: 6492
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x0400195D RID: 6493
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006B0 RID: 1712
		[StructLayout(LayoutKind.Auto)]
		private struct Struct409 : IAsyncStateMachine
		{
			// Token: 0x060024B5 RID: 9397 RVA: 0x0009357C File Offset: 0x0009177C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
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
						goto IL_101;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_15E;
					default:
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
						{
							goto IL_17E;
						}
						if (!Class585.struct13_0.method_0())
						{
							goto IL_17E;
						}
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct409>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_1.IsChecked = new bool?(true);
					awaiter = Class704.smethod_3().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct409>(ref awaiter, ref this);
						return;
					}
					IL_101:
					awaiter.GetResult();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.image_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct409>(ref awaiter, ref this);
						return;
					}
					IL_15E:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_17E:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060024B6 RID: 9398 RVA: 0x00093738 File Offset: 0x00091938
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400195E RID: 6494
			public int int_0;

			// Token: 0x0400195F RID: 6495
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001960 RID: 6496
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001961 RID: 6497
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006B1 RID: 1713
		private static class Class767
		{
			// Token: 0x04001962 RID: 6498
			public static GClass93.GDelegate3 gdelegate3_0;
		}

		// Token: 0x020006B2 RID: 1714
		[StructLayout(LayoutKind.Auto)]
		private struct Struct410 : IAsyncStateMachine
		{
			// Token: 0x060024B7 RID: 9399 RVA: 0x00093748 File Offset: 0x00091948
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
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
						goto IL_104;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_188;
					case 3:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_1FE;
					default:
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_14(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_1, TimeSpan.FromSeconds(0.2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct410>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_1);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_14(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_4, TimeSpan.FromSeconds(0.2)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct410>(ref awaiter, ref this);
						return;
					}
					IL_104:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_28(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_4);
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_5);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_16(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_5, TimeSpan.FromSeconds(0.4)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct410>(ref awaiter, ref this);
						return;
					}
					IL_188:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_0);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_16(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.grid_0, TimeSpan.FromSeconds(0.4)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct410>(ref awaiter, ref this);
						return;
					}
					IL_1FE:
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

			// Token: 0x060024B8 RID: 9400 RVA: 0x000939A4 File Offset: 0x00091BA4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001963 RID: 6499
			public int int_0;

			// Token: 0x04001964 RID: 6500
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001965 RID: 6501
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001966 RID: 6502
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020006B3 RID: 1715
		[Serializable]
		private sealed class Class768
		{
			// Token: 0x060024BB RID: 9403 RVA: 0x000939C8 File Offset: 0x00091BC8
			internal bool method_0(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class522);
			}

			// Token: 0x04001967 RID: 6503
			public static readonly dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Class768 class768_0 = new dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Class768();

			// Token: 0x04001968 RID: 6504
			public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_0;
		}

		// Token: 0x020006B4 RID: 1716
		[StructLayout(LayoutKind.Auto)]
		private struct Struct411 : IAsyncStateMachine
		{
			// Token: 0x060024BC RID: 9404 RVA: 0x000939E0 File Offset: 0x00091BE0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
				try
				{
					TaskAwaiter<object> awaiter;
					TaskAwaiter awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<object>);
						this.int_0 = -1;
						break;
					case 1:
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_168;
					case 2:
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_18D;
					default:
						awaiter = Class358.smethod_0().method_1(typeof(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<object>, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct411>(ref awaiter, ref this);
							return;
						}
						break;
					}
					object result = awaiter.GetResult();
					if (result == null)
					{
						awaiter2 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.button_1).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_1 = awaiter2;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct411>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd = result as dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd;
						if (dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.grid_2.Visibility == Visibility.Visible)
						{
							dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.method_0(dje_zBSSZKCHB675NEW9A2QKQC7KC6JZTH479UXZFWXR5TNKE7FQRDBFSV4H8LR9KFVUMXVKKTQY95L878PZ_ejd.grid_0);
							goto IL_1AF;
						}
						Class358.smethod_0().method_3(typeof(dje_z2NVB8DSSGU7AQAAJS5VKGYN6DCYAQSDP4W9ZBPSX7BLN7RPCEVAFXXK6GR83P6RW744TJYKL54ERA6Q_ejd), dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.frame_0);
						awaiter2 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.button_1).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 2;
							this.taskAwaiter_1 = awaiter2;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct411>(ref awaiter2, ref this);
							return;
						}
						goto IL_18D;
					}
					IL_168:
					awaiter2.GetResult();
					goto IL_1AF;
					IL_18D:
					awaiter2.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1AF:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060024BD RID: 9405 RVA: 0x00093BCC File Offset: 0x00091DCC
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001969 RID: 6505
			public int int_0;

			// Token: 0x0400196A RID: 6506
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400196B RID: 6507
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x0400196C RID: 6508
			private TaskAwaiter<object> taskAwaiter_0;

			// Token: 0x0400196D RID: 6509
			private TaskAwaiter taskAwaiter_1;
		}

		// Token: 0x020006B5 RID: 1717
		[StructLayout(LayoutKind.Auto)]
		private struct Struct412 : IAsyncStateMachine
		{
			// Token: 0x060024BE RID: 9406 RVA: 0x00093BDC File Offset: 0x00091DDC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd = this.dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_4)
						{
							goto IL_E5;
						}
						dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_17.IsChecked = new bool?(false);
						dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_18.IsChecked = new bool?(false);
						dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_19.IsChecked = new bool?(false);
						dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_20.IsChecked = new bool?(false);
						dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.radioButton_1.IsChecked = new bool?(true);
						awaiter = Class704.smethod_0().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd.Struct412>(ref awaiter, ref this);
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
				IL_E5:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060024BF RID: 9407 RVA: 0x00093CF4 File Offset: 0x00091EF4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400196E RID: 6510
			public int int_0;

			// Token: 0x0400196F RID: 6511
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001970 RID: 6512
			public dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd dje_z5GYNNFSXJVMGSPQDL5LBW4UHYSL6MMYH9KVTM9CUZV9X6WNAWGMCP376MB6A_ejd_0;

			// Token: 0x04001971 RID: 6513
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
