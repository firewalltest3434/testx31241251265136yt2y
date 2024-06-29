using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using ns0;

// Token: 0x020001FC RID: 508
public sealed class GClass48
{
	// Token: 0x06000C3B RID: 3131 RVA: 0x00037678 File Offset: 0x00035878
	public static GClass48.GClass213 smethod_0()
	{
		GClass48.GClass213 gclass = new GClass48.GClass213();
		Collection<GClass48.GClass49> appsX = gclass.AppsX;
		GClass48.GClass49 gclass2 = new GClass48.GClass49();
		gclass2.Background = "/Resources/Images/Apps/StoreMain.png";
		gclass2.Stroke = "/Resources/Images/Apps/StoreStroke.png";
		gclass2.NavigateTo = new GClass134(new Action<object>(GClass48.Class270.class270_0.method_0), null);
		appsX.Add(gclass2);
		Collection<GClass48.GClass49> appsX2 = gclass.AppsX;
		GClass48.GClass49 gclass3 = new GClass48.GClass49();
		gclass3.Background = "/Resources/Images/Apps/GMXMain.png";
		gclass3.Stroke = "/Resources/Images/Apps/GMXStroke.png";
		gclass3.NavigateTo = new GClass134(new Action<object>(GClass48.Class270.class270_0.method_1), null);
		appsX2.Add(gclass3);
		Collection<GClass48.GClass49> appsX3 = gclass.AppsX;
		GClass48.GClass49 gclass4 = new GClass48.GClass49();
		gclass4.Background = "/Resources/Images/Apps/GodModeMain.png";
		gclass4.Stroke = "/Resources/Images/Apps/GodModeStroke.png";
		gclass4.NavigateTo = new GClass134(new Action<object>(GClass48.Class270.class270_0.method_2), null);
		appsX3.Add(gclass4);
		Collection<GClass48.GClass49> appsX4 = gclass.AppsX;
		GClass48.GClass49 gclass5 = new GClass48.GClass49();
		gclass5.Background = "/Resources/Images/Apps/LatencyTestMain.png";
		gclass5.Stroke = "/Resources/Images/Apps/LatencyTestStroke.png";
		gclass5.NavigateTo = new GClass134(new Action<object>(GClass48.Class270.class270_0.method_3), null);
		appsX4.Add(gclass5);
		Collection<GClass48.GClass49> games = gclass.Games;
		GClass48.GClass49 gclass6 = new GClass48.GClass49();
		gclass6.Background = "/Resources/Images/Games/CS2Main.png";
		gclass6.Stroke = "/Resources/Images/Games/CSGOStroke.png";
		gclass6.NavigateTo = new GClass134(new Action<object>(GClass48.Class270.class270_0.method_4), null);
		games.Add(gclass6);
		gclass.Games.Add(new GClass48.GClass49
		{
			Background = "/Resources/Images/Games/ValorantMain.png",
			Stroke = "/Resources/Images/Games/ValorantStroke.png"
		});
		Collection<GClass48.GClass49> launchers = gclass.Launchers;
		GClass48.GClass49 gclass7 = new GClass48.GClass49();
		gclass7.Background = "/Resources/Images/Launchers/SteamMain.png";
		gclass7.Stroke = "/Resources/Images/Launchers/SteamStroke.png";
		gclass7.NavigateTo = new GClass134(new Action<object>(GClass48.Class270.class270_0.method_5), null);
		launchers.Add(gclass7);
		gclass.Launchers.Add(new GClass48.GClass49
		{
			Background = "/Resources/Images/Launchers/EpicGamesMain.png",
			Stroke = "/Resources/Images/Launchers/EpicGamesStroke.png"
		});
		return gclass;
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x000378BC File Offset: 0x00035ABC
	public static void smethod_1(Type type_0)
	{
		Class358.smethod_0().method_3(type_0, Class358.smethod_0().frame_0);
	}

	// Token: 0x020001FD RID: 509
	public sealed class GClass49
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x000378DC File Offset: 0x00035ADC
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x000378E4 File Offset: 0x00035AE4
		public string Background
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000378F0 File Offset: 0x00035AF0
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x000378F8 File Offset: 0x00035AF8
		public string Stroke
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00037904 File Offset: 0x00035B04
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x0003790C File Offset: 0x00035B0C
		public GClass134 NavigateTo
		{
			[CompilerGenerated]
			get
			{
				return this.gclass134_0;
			}
			[CompilerGenerated]
			set
			{
				this.gclass134_0 = value;
			}
		}

		// Token: 0x04000782 RID: 1922
		private string string_0;

		// Token: 0x04000783 RID: 1923
		private string string_1;

		// Token: 0x04000784 RID: 1924
		private GClass134 gclass134_0;
	}

	// Token: 0x020001FE RID: 510
	public sealed class GClass213 : GClass211
	{
		// Token: 0x06000C44 RID: 3140 RVA: 0x00037918 File Offset: 0x00035B18
		public GClass213()
		{
			this.observableCollection_0 = new ObservableCollection<GClass48.GClass49>();
			this.observableCollection_1 = new ObservableCollection<GClass48.GClass49>();
			this.observableCollection_2 = new ObservableCollection<GClass48.GClass49>();
			this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
			this.observableCollection_1.CollectionChanged += this.observableCollection_1_CollectionChanged;
			this.observableCollection_2.CollectionChanged += this.observableCollection_2_CollectionChanged;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00037994 File Offset: 0x00035B94
		private void method_1(string string_0)
		{
			base.method_0(string_0);
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x000379A0 File Offset: 0x00035BA0
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x000379A8 File Offset: 0x00035BA8
		public ObservableCollection<GClass48.GClass49> AppsX
		{
			get
			{
				return this.observableCollection_0;
			}
			set
			{
				this.observableCollection_0 = value;
				base.method_0("AppsX");
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x000379BC File Offset: 0x00035BBC
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x000379C4 File Offset: 0x00035BC4
		public ObservableCollection<GClass48.GClass49> Games
		{
			get
			{
				return this.observableCollection_1;
			}
			set
			{
				this.observableCollection_1 = value;
				base.method_0("Games");
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x000379D8 File Offset: 0x00035BD8
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x000379E0 File Offset: 0x00035BE0
		public ObservableCollection<GClass48.GClass49> Launchers
		{
			get
			{
				return this.observableCollection_2;
			}
			set
			{
				this.observableCollection_2 = value;
				base.method_0("Launchers");
			}
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000379F4 File Offset: 0x00035BF4
		private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
		{
			this.method_1("AppsX");
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00037A04 File Offset: 0x00035C04
		private void observableCollection_1_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
		{
			this.method_1("Games");
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00037A14 File Offset: 0x00035C14
		private void observableCollection_2_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
		{
			this.method_1("Launchers");
		}

		// Token: 0x04000785 RID: 1925
		private ObservableCollection<GClass48.GClass49> observableCollection_0;

		// Token: 0x04000786 RID: 1926
		private ObservableCollection<GClass48.GClass49> observableCollection_1;

		// Token: 0x04000787 RID: 1927
		private ObservableCollection<GClass48.GClass49> observableCollection_2;
	}

	// Token: 0x020001FF RID: 511
	[Serializable]
	private sealed class Class270
	{
		// Token: 0x06000C51 RID: 3153 RVA: 0x00037A38 File Offset: 0x00035C38
		internal void method_0(object object_0)
		{
			bool? flag = Class389.class504_0.method_34();
			if (flag.GetValueOrDefault() & flag != null)
			{
				GClass48.smethod_1(typeof(dje_z34Q9QPAA7BQQJMZXHNU4FEKEN2D27DPBNGJF3B2SU3DB3VTR63M8E_ejd));
				return;
			}
			GClass48.smethod_1(typeof(dje_zA5RTAEEE3XHQPNAYMRCT986HPGHEJ5QA749XT7ZYCA74C2NQUGXW7A6QAX3Q_ejd));
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00037A84 File Offset: 0x00035C84
		internal void method_1(object object_0)
		{
			GClass48.smethod_1(typeof(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd));
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00037A98 File Offset: 0x00035C98
		internal void method_2(object object_0)
		{
			GClass48.smethod_1(typeof(dje_zHVE2FBBGL295YFHV5QPLKEJL3MFJW2HAT6494R6Y2TY52S85NBHXV_ejd));
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00037AAC File Offset: 0x00035CAC
		internal void method_3(object object_0)
		{
			GClass48.smethod_1(typeof(dje_zW872XD8R3NK2QETYFM4JBH5HYW76YR7RXYE5RU7GJHLYCQNLGL3C8MKN8L2Q_ejd));
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00037AC0 File Offset: 0x00035CC0
		internal void method_4(object object_0)
		{
			GClass48.smethod_1(typeof(dje_zN37RFS283H4JQWNDWXSGQDQ84CPM3FE2BM88N9WCCDK8M4Q5V7SF2_ejd));
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00037AD4 File Offset: 0x00035CD4
		internal void method_5(object object_0)
		{
			GClass48.smethod_1(typeof(dje_zSRVK68463RMM4E69GYWWX7JSMQAUHKRLTQ45FZP6VGUM2NKHQJ7HD_ejd));
		}

		// Token: 0x04000788 RID: 1928
		public static readonly GClass48.Class270 class270_0 = new GClass48.Class270();

		// Token: 0x04000789 RID: 1929
		public static Action<object> action_0;

		// Token: 0x0400078A RID: 1930
		public static Action<object> action_1;

		// Token: 0x0400078B RID: 1931
		public static Action<object> action_2;

		// Token: 0x0400078C RID: 1932
		public static Action<object> action_3;

		// Token: 0x0400078D RID: 1933
		public static Action<object> action_4;

		// Token: 0x0400078E RID: 1934
		public static Action<object> action_5;
	}
}
