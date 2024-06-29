using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

// Token: 0x020002D1 RID: 721
internal sealed class Class730 : GClass211
{
	// Token: 0x060010A9 RID: 4265 RVA: 0x00046380 File Offset: 0x00044580
	public Class730()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_1_CollectionChanged;
		this.observableCollection_1.CollectionChanged += this.observableCollection_1_CollectionChanged;
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x000463D8 File Offset: 0x000445D8
	private void observableCollection_1_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("UpdateCollectionProperty");
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x000463E8 File Offset: 0x000445E8
	internal void method_1()
	{
		this.WinUwpAppsModels.Clear();
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x060010AC RID: 4268 RVA: 0x000463F8 File Offset: 0x000445F8
	// (set) Token: 0x060010AD RID: 4269 RVA: 0x00046400 File Offset: 0x00044600
	public ObservableCollection<Class713> WinUwpAppsModels
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("WinUwpAppsModels");
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x060010AE RID: 4270 RVA: 0x00046414 File Offset: 0x00044614
	// (set) Token: 0x060010AF RID: 4271 RVA: 0x0004641C File Offset: 0x0004461C
	public ObservableCollection<Class745> CustomDebloatList
	{
		get
		{
			return this.observableCollection_1;
		}
		set
		{
			this.observableCollection_1 = value;
			base.method_0("CustomDebloatList");
		}
	}

	// Token: 0x04000A00 RID: 2560
	private ObservableCollection<Class713> observableCollection_0 = new ObservableCollection<Class713>();

	// Token: 0x04000A01 RID: 2561
	private ObservableCollection<Class745> observableCollection_1 = new ObservableCollection<Class745>();
}
