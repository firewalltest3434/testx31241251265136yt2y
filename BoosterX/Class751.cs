using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

// Token: 0x0200047A RID: 1146
internal sealed class Class751 : GClass211
{
	// Token: 0x0600195F RID: 6495 RVA: 0x000683DC File Offset: 0x000665DC
	public Class751(GClass67 gclass67_1, Class745 class745_1)
	{
		this.class745_0 = class745_1;
		this.gclass67_0 = gclass67_1;
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
	}

	// Token: 0x170003CA RID: 970
	// (get) Token: 0x06001960 RID: 6496 RVA: 0x0006841C File Offset: 0x0006661C
	public bool OnEdit
	{
		get
		{
			return this.class745_0.OnEdit;
		}
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x0006842C File Offset: 0x0006662C
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("ColChandes");
	}

	// Token: 0x170003CB RID: 971
	// (get) Token: 0x06001962 RID: 6498 RVA: 0x0006843C File Offset: 0x0006663C
	public bool IsRegTweakD
	{
		get
		{
			return this.TypeD == "REG";
		}
	}

	// Token: 0x170003CC RID: 972
	// (get) Token: 0x06001963 RID: 6499 RVA: 0x00068450 File Offset: 0x00066650
	// (set) Token: 0x06001964 RID: 6500 RVA: 0x000684DC File Offset: 0x000666DC
	public ObservableCollection<Class729> ValuesD
	{
		get
		{
			if (this.gclass67_0.Values != null && this.gclass67_0.Values.Count<GClass72>() > 0)
			{
				foreach (GClass72 gclass72_ in this.gclass67_0.Values)
				{
					this.observableCollection_0.Add(new Class729(gclass72_, this));
				}
			}
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("ValuesD");
		}
	}

	// Token: 0x170003CD RID: 973
	// (get) Token: 0x06001965 RID: 6501 RVA: 0x000684F0 File Offset: 0x000666F0
	// (set) Token: 0x06001966 RID: 6502 RVA: 0x00068500 File Offset: 0x00066700
	public string TweakTypeD
	{
		get
		{
			return this.gclass67_0.String_0;
		}
		set
		{
			this.gclass67_0.String_0 = value;
			base.method_0("TweakTypeD");
		}
	}

	// Token: 0x170003CE RID: 974
	// (get) Token: 0x06001967 RID: 6503 RVA: 0x0006851C File Offset: 0x0006671C
	// (set) Token: 0x06001968 RID: 6504 RVA: 0x0006852C File Offset: 0x0006672C
	public string PathD
	{
		get
		{
			return this.gclass67_0.Path;
		}
		set
		{
			this.gclass67_0.Path = value;
			base.method_0("PathD");
		}
	}

	// Token: 0x170003CF RID: 975
	// (get) Token: 0x06001969 RID: 6505 RVA: 0x00068548 File Offset: 0x00066748
	// (set) Token: 0x0600196A RID: 6506 RVA: 0x00068558 File Offset: 0x00066758
	public string KeyD
	{
		get
		{
			return this.gclass67_0.Key;
		}
		set
		{
			this.gclass67_0.Key = value;
			base.method_0("KeyD");
		}
	}

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x0600196B RID: 6507 RVA: 0x00068574 File Offset: 0x00066774
	public GClass134 RemoveStepCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_5), null));
			}
			return result;
		}
	}

	// Token: 0x170003D1 RID: 977
	// (get) Token: 0x0600196C RID: 6508 RVA: 0x000685A8 File Offset: 0x000667A8
	public string TypeD
	{
		get
		{
			return this.gclass67_0.Type;
		}
	}

	// Token: 0x170003D2 RID: 978
	// (get) Token: 0x0600196D RID: 6509 RVA: 0x000685B8 File Offset: 0x000667B8
	// (set) Token: 0x0600196E RID: 6510 RVA: 0x000685C8 File Offset: 0x000667C8
	public string RegTypeD
	{
		get
		{
			return this.gclass67_0.RegType;
		}
		set
		{
			this.gclass67_0.RegType = value;
			base.method_0("RegTypeD");
		}
	}

	// Token: 0x170003D3 RID: 979
	// (get) Token: 0x0600196F RID: 6511 RVA: 0x000685E4 File Offset: 0x000667E4
	public ObservableCollection<string> RegTypesD
	{
		get
		{
			if (this.observableCollection_1 == null)
			{
				this.observableCollection_1 = new ObservableCollection<string>
				{
					"REG_DWORD",
					"REG_SZ",
					"REG_BINARY",
					"REG_EXPAND_SZ"
				};
			}
			return this.observableCollection_1;
		}
	}

	// Token: 0x170003D4 RID: 980
	// (get) Token: 0x06001970 RID: 6512 RVA: 0x00068638 File Offset: 0x00066838
	public string HideTip
	{
		get
		{
			if (!(this.TypeD == "REG") && !(this.TypeD == "BCDEDIT"))
			{
				return "HIDE";
			}
			return "SHOW";
		}
	}

	// Token: 0x06001971 RID: 6513 RVA: 0x00068670 File Offset: 0x00066870
	public bool method_1()
	{
		return this.gclass67_0.method_0();
	}

	// Token: 0x06001972 RID: 6514 RVA: 0x00068680 File Offset: 0x00066880
	public bool method_2()
	{
		return this.gclass67_0.method_1();
	}

	// Token: 0x06001973 RID: 6515 RVA: 0x00068690 File Offset: 0x00066890
	public bool method_3()
	{
		return this.gclass67_0.method_2();
	}

	// Token: 0x06001974 RID: 6516 RVA: 0x000686A0 File Offset: 0x000668A0
	public bool method_4()
	{
		return this.gclass67_0.method_3();
	}

	// Token: 0x06001975 RID: 6517 RVA: 0x000686B0 File Offset: 0x000668B0
	private void method_5(object object_0)
	{
		this.class745_0.method_20(this);
	}

	// Token: 0x040011B7 RID: 4535
	public GClass67 gclass67_0;

	// Token: 0x040011B8 RID: 4536
	public Class745 class745_0;

	// Token: 0x040011B9 RID: 4537
	public bool bool_0 = true;

	// Token: 0x040011BA RID: 4538
	public ObservableCollection<Class729> observableCollection_0 = new ObservableCollection<Class729>();

	// Token: 0x040011BB RID: 4539
	private GClass134 gclass134_0;

	// Token: 0x040011BC RID: 4540
	private ObservableCollection<string> observableCollection_1;
}
