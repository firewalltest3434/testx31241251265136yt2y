using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;

// Token: 0x0200059C RID: 1436
internal sealed class Class757 : GClass211
{
	// Token: 0x06001EE6 RID: 7910 RVA: 0x00080464 File Offset: 0x0007E664
	public Class757()
	{
		this.SettingItemsCollectionView = CollectionViewSource.GetDefaultView(this.SettingsVMs);
		this.SettingItemsCollectionView.GroupDescriptions.Add(new PropertyGroupDescription("Group"));
	}

	// Token: 0x170004D1 RID: 1233
	// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x00080498 File Offset: 0x0007E698
	// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x000804A0 File Offset: 0x0007E6A0
	public ICollectionView SettingItemsCollectionView
	{
		[CompilerGenerated]
		get
		{
			return this.icollectionView_0;
		}
		[CompilerGenerated]
		private set
		{
			this.icollectionView_0 = value;
		}
	}

	// Token: 0x170004D2 RID: 1234
	// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x000804AC File Offset: 0x0007E6AC
	// (set) Token: 0x06001EEA RID: 7914 RVA: 0x000804C4 File Offset: 0x0007E6C4
	public ObservableCollection<Class749> SettingsVMs
	{
		get
		{
			if (this.observableCollection_0 == null)
			{
				this.method_1();
			}
			return this.observableCollection_0;
		}
		set
		{
			if (value == null)
			{
				this.observableCollection_0 = null;
				this.method_1();
				base.method_0("SettingsVMs");
			}
		}
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x000804E4 File Offset: 0x0007E6E4
	public void method_1()
	{
		this.observableCollection_0 = new ObservableCollection<Class749>
		{
			new Class749
			{
				Group = "Performance",
				NameRaw = "SlowPCMode",
				IsPRO = false,
				RegistryValue = "SlowPCMode",
				IconString = "FanChevronDown"
			},
			new Class749
			{
				Group = "OptimizationSettings",
				NameRaw = "ShowGroupServices",
				IsPRO = false,
				RegistryValue = "ShowServicesPage",
				IconString = "Cogs"
			},
			new Class749
			{
				Group = "OptimizationSettings",
				NameRaw = "ShowServicesManagerPage",
				IsPRO = false,
				RegistryValue = "ShowServicesManagerPage",
				IconString = "TableCog"
			},
			new Class749
			{
				Group = "OptimizationSettings",
				NameRaw = "ShowAffinityPage",
				IsPRO = false,
				RegistryValue = "ShowAffinityPage",
				IconString = "Counter"
			},
			new Class749
			{
				Group = "OptimizationSettings",
				NameRaw = "NvidiaHardmode",
				IsPRO = false,
				RegistryValue = "IsNvidiaHardMode",
				IconString = "EyeLockOpen"
			},
			new Class749
			{
				Group = "OptimizationSettings",
				NameRaw = "ShowHiddenTweaks",
				IsPRO = false,
				RegistryValue = "ShowHiddenTweaks",
				IconString = "FileHidden"
			},
			new Class749
			{
				Group = "OptimizationSettings",
				NameRaw = "ShowExperimentalTweaks",
				IsPRO = true,
				RegistryValue = "ShowExperimentalTweaks",
				IconString = "TestTube"
			},
			new Class749
			{
				Group = "BoosterX",
				NameRaw = "ShowErrors",
				IsPRO = false,
				RegistryValue = "ShowErrors",
				IconString = "AlertCircle"
			},
			new Class749
			{
				Group = "Performance",
				NameRaw = "ShowMetrics",
				IsPRO = false,
				RegistryValue = "ShowMetrics",
				IconString = "CarSpeedLimiter"
			},
			new Class749
			{
				Group = "Performance",
				NameRaw = "ShowRAMMetrics",
				IsPRO = false,
				RegistryValue = "ShowRAMMetrics",
				IconString = "Memory"
			},
			new Class749
			{
				Group = "Performance",
				NameRaw = "ShowDISKMetrics",
				IsPRO = false,
				RegistryValue = "ShowDISKMetrics",
				IconString = "Harddisk"
			},
			new Class749
			{
				Group = "BoosterX",
				NameRaw = "ShowDiscordRPC",
				IsPRO = false,
				RegistryValue = "ShowDiscordRPC",
				IconString = "HumanMaleBoard"
			},
			new Class749
			{
				Group = "SkipPagesSettings",
				NameRaw = "DoNotShowILTFirstPage",
				IsPRO = false,
				RegistryValue = "DoNotShowILTFirstPage",
				IconString = "ImageOffOutline"
			},
			new Class749
			{
				Group = "SkipPagesSettings",
				NameRaw = "DoNotShowStoreXFirstPage",
				IsPRO = false,
				RegistryValue = "DoNotShowStoreXFirstPage",
				IconString = "ImageOffOutline"
			},
			new Class749
			{
				Group = "BoosterX",
				NameRaw = "AutoUpdate",
				IsPRO = false,
				RegistryValue = "AutoUpdate",
				IconString = "ProgressDownload"
			}
		};
	}

	// Token: 0x040015AE RID: 5550
	private ICollectionView icollectionView_0;

	// Token: 0x040015AF RID: 5551
	public ObservableCollection<Class749> observableCollection_0;
}
