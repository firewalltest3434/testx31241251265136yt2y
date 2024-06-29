using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

// Token: 0x020005C4 RID: 1476
public sealed class GClass226 : GClass211
{
	// Token: 0x0600201D RID: 8221 RVA: 0x000832C8 File Offset: 0x000814C8
	public GClass226()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
	}

	// Token: 0x17000516 RID: 1302
	// (get) Token: 0x0600201E RID: 8222 RVA: 0x000832FC File Offset: 0x000814FC
	// (set) Token: 0x0600201F RID: 8223 RVA: 0x00083304 File Offset: 0x00081504
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x17000517 RID: 1303
	// (get) Token: 0x06002020 RID: 8224 RVA: 0x00083318 File Offset: 0x00081518
	public BitmapSource Icon
	{
		get
		{
			return GClass160.smethod_1(this.observableCollection_0.First<GClass221>().ClassGuid);
		}
	}

	// Token: 0x17000518 RID: 1304
	// (get) Token: 0x06002021 RID: 8225 RVA: 0x00083330 File Offset: 0x00081530
	// (set) Token: 0x06002022 RID: 8226 RVA: 0x00083338 File Offset: 0x00081538
	public string Description
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("Description");
		}
	}

	// Token: 0x06002023 RID: 8227 RVA: 0x0008334C File Offset: 0x0008154C
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("Devices");
	}

	// Token: 0x17000519 RID: 1305
	// (get) Token: 0x06002024 RID: 8228 RVA: 0x0008335C File Offset: 0x0008155C
	// (set) Token: 0x06002025 RID: 8229 RVA: 0x00083364 File Offset: 0x00081564
	public ObservableCollection<GClass221> Devices
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			if (this.observableCollection_0.All(new Func<GClass221, bool>(GClass226.Class657.class657_0.method_0)))
			{
				this.IsDisabled = new bool?(true);
			}
			else if (this.observableCollection_0.All(new Func<GClass221, bool>(GClass226.Class657.class657_0.method_1)))
			{
				this.IsDisabled = new bool?(false);
			}
			else
			{
				this.IsDisabled = null;
			}
			base.method_0("Devices");
		}
	}

	// Token: 0x1700051A RID: 1306
	// (get) Token: 0x06002026 RID: 8230 RVA: 0x00083408 File Offset: 0x00081608
	// (set) Token: 0x06002027 RID: 8231 RVA: 0x00083410 File Offset: 0x00081610
	public bool? CurrentIsDisabled
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_0;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x1700051B RID: 1307
	// (get) Token: 0x06002028 RID: 8232 RVA: 0x0008341C File Offset: 0x0008161C
	// (set) Token: 0x06002029 RID: 8233 RVA: 0x00083424 File Offset: 0x00081624
	public bool? IsDisabled
	{
		get
		{
			return this.nullable_1;
		}
		set
		{
			if (this.bool_0)
			{
				this.CurrentIsDisabled = value;
				this.bool_0 = false;
			}
			this.nullable_1 = value;
			this.method_1();
			base.method_0("IsDisabled");
			base.method_0("HasChanges");
		}
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x00083460 File Offset: 0x00081660
	private void method_1()
	{
		bool? isDisabled = this.IsDisabled;
		if (isDisabled.GetValueOrDefault() & isDisabled != null)
		{
			foreach (GClass221 gclass in this.observableCollection_0)
			{
				gclass.IsEnabled = false;
			}
		}
		isDisabled = this.IsDisabled;
		if (!isDisabled.GetValueOrDefault() & isDisabled != null)
		{
			foreach (GClass221 gclass2 in this.observableCollection_0)
			{
				gclass2.IsEnabled = true;
			}
		}
	}

	// Token: 0x1700051C RID: 1308
	// (get) Token: 0x0600202B RID: 8235 RVA: 0x00083520 File Offset: 0x00081720
	public bool HasChanges
	{
		get
		{
			return this.observableCollection_0.Any(new Func<GClass221, bool>(GClass226.Class657.class657_0.method_2));
		}
	}

	// Token: 0x04001641 RID: 5697
	private string string_0;

	// Token: 0x04001642 RID: 5698
	private string string_1;

	// Token: 0x04001643 RID: 5699
	private ObservableCollection<GClass221> observableCollection_0 = new ObservableCollection<GClass221>();

	// Token: 0x04001644 RID: 5700
	private bool bool_0 = true;

	// Token: 0x04001645 RID: 5701
	private bool? nullable_0;

	// Token: 0x04001646 RID: 5702
	private bool? nullable_1;

	// Token: 0x020005C5 RID: 1477
	[Serializable]
	private sealed class Class657
	{
		// Token: 0x0600202E RID: 8238 RVA: 0x00083560 File Offset: 0x00081760
		internal bool method_0(GClass221 gclass221_0)
		{
			return !gclass221_0.IsEnabled;
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x0008356C File Offset: 0x0008176C
		internal bool method_1(GClass221 gclass221_0)
		{
			return gclass221_0.IsEnabled;
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00083574 File Offset: 0x00081774
		internal bool method_2(GClass221 gclass221_0)
		{
			return gclass221_0.HasChangesEnabled;
		}

		// Token: 0x04001647 RID: 5703
		public static readonly GClass226.Class657 class657_0 = new GClass226.Class657();

		// Token: 0x04001648 RID: 5704
		public static Func<GClass221, bool> func_0;

		// Token: 0x04001649 RID: 5705
		public static Func<GClass221, bool> func_1;

		// Token: 0x0400164A RID: 5706
		public static Func<GClass221, bool> func_2;
	}
}
