using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using TsudaKageyu;

namespace ns0
{
	// Token: 0x020007EA RID: 2026
	public sealed class dje_zSRVK68463RMM4E69GYWWX7JSMQAUHKRLTQ45FZP6VGUM2NKHQJ7HD_ejd : Page, IComponentConnector
	{
		// Token: 0x06002998 RID: 10648 RVA: 0x000B31F0 File Offset: 0x000B13F0
		public dje_zSRVK68463RMM4E69GYWWX7JSMQAUHKRLTQ45FZP6VGUM2NKHQJ7HD_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000B3200 File Offset: 0x000B1400
		private void method_0(object sender, RoutedEventArgs p1)
		{
			string text = "-dev -console -nofriendsui -no-dwrite -nointro -nobigpicture -nofasthtml -nocrashmonitor -noshaders -no-shared-textures -disablehighdpi -cef-single-process -cef-in-process-gpu -single_core -cef-disable-d3d11 -cef-disable-sandbox -disable-winh264 -no-cef-sandbox -vrdisable -cef-disable-breakpad";
			string text2 = "-cef-single-process -cef-disable-gpu -no-dwrite -skipinitialbootstrap -quicklogin -oldtraymenu -silent -vgui";
			string text3 = GClass88.smethod_0().method_12();
			if (text3 != null && !(text3 == string.Empty))
			{
				try
				{
					File.Delete(Class186.string_0 + "\\StrippedSteam.lnk");
					File.Delete(text3 + "\\StrippedSteam.bat");
					File.Delete(text3 + "\\resource\\steamIcon.icon");
				}
				catch (object obj)
				{
				}
				using (StreamWriter streamWriter = File.AppendText(text3 + "\\StrippedSteam.bat"))
				{
					streamWriter.WriteLine("@echo off");
					streamWriter.WriteLine("taskkill /f /im steam.exe");
					GClass88.smethod_0().method_6(GClass88.smethod_0().method_12());
					string str = (GClass88.smethod_0().method_13().Count == 1) ? text : text2;
					streamWriter.WriteLine("start \"\" \"" + text3 + "\\steam.exe\" " + str);
				}
				Class650.Interface16 @interface = (Class650.Interface16)new Class650.Class651();
				@interface.imethod_4("Created by BoosterX");
				@interface.imethod_17(text3 + "\\StrippedSteam.bat");
				IconExtractor iconExtractor = new IconExtractor(text3 + "\\steam.exe");
				using (FileStream fileStream = File.OpenWrite(text3 + "\\resource\\steamIcon.icon"))
				{
					iconExtractor.Save(0, fileStream);
				}
				@interface.imethod_14(text3 + "\\resource\\steamIcon.icon", 0);
				((Class650.Interface17)@interface).imethod_4(Path.Combine(Class186.string_0, "StrippedSteam.lnk"), false);
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.textBlock_0);
				return;
			}
			this.textBlock_0.Text = Class364.smethod_0("SteamNotFound");
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(this.textBlock_0);
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000B33E8 File Offset: 0x000B15E8
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class358.smethod_0().method_3(typeof(dje_zA6HRDGVQ449XDH4D5NPJHBXAQ5BZC26NDGXJQ5PLSURH2QZ_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000B3408 File Offset: 0x000B1608
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/steampage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x000B3438 File Offset: 0x000B1638
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
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 3:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 4:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 5:
				((Button)target).Click += this.method_0;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001F92 RID: 8082
		internal Grid grid_0;

		// Token: 0x04001F93 RID: 8083
		internal Button button_0;

		// Token: 0x04001F94 RID: 8084
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001F95 RID: 8085
		internal TextBlock textBlock_0;

		// Token: 0x04001F96 RID: 8086
		private bool bool_0;
	}
}
