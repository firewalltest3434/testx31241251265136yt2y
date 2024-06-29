using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

// Token: 0x0200040C RID: 1036
internal sealed class Class744 : GClass211
{
	// Token: 0x0600165F RID: 5727 RVA: 0x0005E158 File Offset: 0x0005C358
	public Class744()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_1_CollectionChanged;
		this.observableCollection_1.CollectionChanged += this.observableCollection_1_CollectionChanged;
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x0005E1B0 File Offset: 0x0005C3B0
	private void observableCollection_1_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("ColChanged");
	}

	// Token: 0x170002F9 RID: 761
	// (get) Token: 0x06001661 RID: 5729 RVA: 0x0005E1C0 File Offset: 0x0005C3C0
	// (set) Token: 0x06001662 RID: 5730 RVA: 0x0005E1C8 File Offset: 0x0005C3C8
	public ObservableCollection<Class716> DeviceViewModels
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("DeviceViewModels");
		}
	}

	// Token: 0x170002FA RID: 762
	// (get) Token: 0x06001663 RID: 5731 RVA: 0x0005E1DC File Offset: 0x0005C3DC
	// (set) Token: 0x06001664 RID: 5732 RVA: 0x0005E1E4 File Offset: 0x0005C3E4
	public ObservableCollection<Class756> ChoosenDevThreads
	{
		get
		{
			return this.observableCollection_1;
		}
		set
		{
			this.observableCollection_1 = value;
			base.method_0("ChoosenDevThreads");
		}
	}

	// Token: 0x04001019 RID: 4121
	private ObservableCollection<Class716> observableCollection_0 = new ObservableCollection<Class716>();

	// Token: 0x0400101A RID: 4122
	private ObservableCollection<Class756> observableCollection_1 = new ObservableCollection<Class756>();
}
