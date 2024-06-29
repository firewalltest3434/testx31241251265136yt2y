using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media;
using Material.Icons;
using ns0;

// Token: 0x02000237 RID: 567
public sealed class GClass61 : INotifyPropertyChanged
{
	// Token: 0x06000D6C RID: 3436 RVA: 0x0003BAB0 File Offset: 0x00039CB0
	public GClass61(GClass172.GClass173 gclass173_1, List<GClass151> list_1)
	{
		this.ServicesViewGroupName = gclass173_1;
		this.Services = list_1;
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x0003BAD4 File Offset: 0x00039CD4
	private void method_0(object sender, PropertyChangedEventArgs p1)
	{
		if (p1.PropertyName == "IsDefault")
		{
			this.vmethod_0("IsDefault");
		}
		if (p1.PropertyName == "IsDisabled")
		{
			this.vmethod_0("IsDisabled");
		}
		if (p1.PropertyName == "HasChanges")
		{
			this.vmethod_0("HasChanges");
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000D6E RID: 3438 RVA: 0x0003BB38 File Offset: 0x00039D38
	// (set) Token: 0x06000D6F RID: 3439 RVA: 0x0003BB40 File Offset: 0x00039D40
	public GClass172.GClass173 ServicesViewGroupName
	{
		get
		{
			return this.gclass173_0;
		}
		set
		{
			if (object.Equals(value, this.gclass173_0))
			{
				return;
			}
			this.gclass173_0 = value;
			this.vmethod_0("ServicesViewGroupName");
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0003BB64 File Offset: 0x00039D64
	// (set) Token: 0x06000D71 RID: 3441 RVA: 0x0003BB6C File Offset: 0x00039D6C
	public List<GClass151> Services
	{
		get
		{
			return this.list_0;
		}
		set
		{
			if (object.Equals(value, this.list_0))
			{
				return;
			}
			this.list_0.ForEach(new Action<GClass151>(this.method_4));
			this.list_0 = value;
			this.list_0.ForEach(new Action<GClass151>(this.method_5));
			this.vmethod_0("Services");
			this.vmethod_0("IsDefault");
			this.vmethod_0("IsDisabled");
			this.vmethod_0("HasChanges");
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0003BBEC File Offset: 0x00039DEC
	public bool HasChanges
	{
		get
		{
			return this.list_0.Any(new Func<GClass151, bool>(GClass61.Class291.class291_0.method_0));
		}
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000D73 RID: 3443 RVA: 0x0003BC18 File Offset: 0x00039E18
	public bool HasServices
	{
		get
		{
			return this.list_0.Count > 0;
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06000D74 RID: 3444 RVA: 0x0003BC28 File Offset: 0x00039E28
	public string GroupNameLoc
	{
		get
		{
			return Class364.smethod_0(this.GroupName);
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0003BC38 File Offset: 0x00039E38
	// (set) Token: 0x06000D76 RID: 3446 RVA: 0x0003BC48 File Offset: 0x00039E48
	public string GroupName
	{
		get
		{
			return this.gclass173_0.method_0();
		}
		set
		{
			this.gclass173_0.method_1(value);
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06000D77 RID: 3447 RVA: 0x0003BC58 File Offset: 0x00039E58
	public SolidColorBrush IsRed
	{
		get
		{
			if (!this.gclass173_0.IsRed)
			{
				return Brushes.White;
			}
			return dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd;
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0003BC74 File Offset: 0x00039E74
	public MaterialIconKind Icon
	{
		get
		{
			return this.gclass173_0.Icon;
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000D79 RID: 3449 RVA: 0x0003BC84 File Offset: 0x00039E84
	public string GroupDescriptionLoc
	{
		get
		{
			return Class364.smethod_0(this.GroupName + "Desc");
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0003BC9C File Offset: 0x00039E9C
	// (set) Token: 0x06000D7B RID: 3451 RVA: 0x0003BD28 File Offset: 0x00039F28
	public bool? IsDefault
	{
		get
		{
			if (!this.HasServices)
			{
				return new bool?(true);
			}
			if (this.Services.All(new Func<GClass151, bool>(GClass61.Class291.class291_0.method_1)))
			{
				return new bool?(true);
			}
			if (this.Services.All(new Func<GClass151, bool>(GClass61.Class291.class291_0.method_2)))
			{
				return new bool?(false);
			}
			return null;
		}
		set
		{
			if (value == null)
			{
				return;
			}
			if (!value.Value)
			{
				this.method_1();
			}
			else
			{
				this.method_2();
			}
			this.vmethod_0("IsDefault");
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0003BD58 File Offset: 0x00039F58
	// (set) Token: 0x06000D7D RID: 3453 RVA: 0x0003BDD4 File Offset: 0x00039FD4
	public bool? IsDisabled
	{
		get
		{
			if (this.Services.All(new Func<GClass151, bool>(GClass61.Class291.class291_0.method_3)))
			{
				return new bool?(false);
			}
			if (this.Services.All(new Func<GClass151, bool>(GClass61.Class291.class291_0.method_4)))
			{
				return new bool?(true);
			}
			return null;
		}
		set
		{
			if (value == null)
			{
				return;
			}
			if (!value.Value)
			{
				this.method_1();
			}
			else
			{
				this.method_2();
			}
			this.vmethod_0("IsDisabled");
		}
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x0003BE04 File Offset: 0x0003A004
	public void method_1()
	{
		this.Services.ForEach(new Action<GClass151>(GClass61.Class291.class291_0.method_5));
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x0003BE30 File Offset: 0x0003A030
	public void method_2()
	{
		this.Services.ForEach(new Action<GClass151>(GClass61.Class291.class291_0.method_6));
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000D80 RID: 3456 RVA: 0x0003BE5C File Offset: 0x0003A05C
	// (remove) Token: 0x06000D81 RID: 3457 RVA: 0x0003BE94 File Offset: 0x0003A094
	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x0003BECC File Offset: 0x0003A0CC
	protected void vmethod_0([CallerMemberName] string string_0)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
		if (propertyChangedEventHandler == null)
		{
			return;
		}
		propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_0));
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x0003BEE8 File Offset: 0x0003A0E8
	protected bool method_3<T>(ref T gparam_0, T gparam_1, [CallerMemberName] string string_0)
	{
		if (EqualityComparer<T>.Default.Equals(gparam_0, gparam_1))
		{
			return false;
		}
		gparam_0 = gparam_1;
		this.vmethod_0(string_0);
		return true;
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x0003BF10 File Offset: 0x0003A110
	private void method_4(GClass151 gclass151_0)
	{
		gclass151_0.PropertyChanged -= this.method_0;
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x0003BF24 File Offset: 0x0003A124
	private void method_5(GClass151 gclass151_0)
	{
		gclass151_0.PropertyChanged += this.method_0;
	}

	// Token: 0x04000859 RID: 2137
	private GClass172.GClass173 gclass173_0;

	// Token: 0x0400085A RID: 2138
	private List<GClass151> list_0 = new List<GClass151>();

	// Token: 0x0400085B RID: 2139
	private PropertyChangedEventHandler propertyChangedEventHandler_0;

	// Token: 0x02000238 RID: 568
	[Serializable]
	private sealed class Class291
	{
		// Token: 0x06000D88 RID: 3464 RVA: 0x0003BF4C File Offset: 0x0003A14C
		internal bool method_0(GClass151 gclass151_0)
		{
			return gclass151_0.HasChanges;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0003BF54 File Offset: 0x0003A154
		internal bool method_1(GClass151 gclass151_0)
		{
			return !gclass151_0.IsDefault;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0003BF60 File Offset: 0x0003A160
		internal bool method_2(GClass151 gclass151_0)
		{
			return gclass151_0.IsDefault;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0003BF68 File Offset: 0x0003A168
		internal bool method_3(GClass151 gclass151_0)
		{
			return !gclass151_0.IsDisabled;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0003BF74 File Offset: 0x0003A174
		internal bool method_4(GClass151 gclass151_0)
		{
			return gclass151_0.IsDisabled;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0003BF7C File Offset: 0x0003A17C
		internal void method_5(GClass151 gclass151_0)
		{
			gclass151_0.WinServiceViewModel.method_2();
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0003BF8C File Offset: 0x0003A18C
		internal void method_6(GClass151 gclass151_0)
		{
			gclass151_0.WinServiceViewModel.method_1();
		}

		// Token: 0x0400085C RID: 2140
		public static readonly GClass61.Class291 class291_0 = new GClass61.Class291();

		// Token: 0x0400085D RID: 2141
		public static Func<GClass151, bool> func_0;

		// Token: 0x0400085E RID: 2142
		public static Func<GClass151, bool> func_1;

		// Token: 0x0400085F RID: 2143
		public static Func<GClass151, bool> func_2;

		// Token: 0x04000860 RID: 2144
		public static Func<GClass151, bool> func_3;

		// Token: 0x04000861 RID: 2145
		public static Func<GClass151, bool> func_4;

		// Token: 0x04000862 RID: 2146
		public static Action<GClass151> action_0;

		// Token: 0x04000863 RID: 2147
		public static Action<GClass151> action_1;
	}
}
