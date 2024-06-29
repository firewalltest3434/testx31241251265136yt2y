using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Threading;
using BoosterX.Classes.Tweaks.Expert.ServicesTweak;

// Token: 0x02000380 RID: 896
public sealed class GClass110 : INotifyPropertyChanged
{
	// Token: 0x060013FD RID: 5117 RVA: 0x00052D94 File Offset: 0x00050F94
	public GClass110(GClass97 gclass97_1)
	{
		this.Service = gclass97_1;
		this.ShowDisplayName = true;
		this.NewStartMode = gclass97_1.method_0();
		this.NewStatus = gclass97_1.Status;
		this.ServicesTweak = new ServicesTweak(gclass97_1);
	}

	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x060013FE RID: 5118 RVA: 0x00052DFC File Offset: 0x00050FFC
	// (set) Token: 0x060013FF RID: 5119 RVA: 0x00052E04 File Offset: 0x00051004
	public ServicesTweak ServicesTweak
	{
		get
		{
			return this.servicesTweak_0;
		}
		set
		{
			this.servicesTweak_0 = value;
		}
	}

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x06001400 RID: 5120 RVA: 0x00052E10 File Offset: 0x00051010
	// (set) Token: 0x06001401 RID: 5121 RVA: 0x00052E18 File Offset: 0x00051018
	public GClass97 Service
	{
		get
		{
			return this.gclass97_0;
		}
		set
		{
			if (object.Equals(value, this.gclass97_0))
			{
				return;
			}
			this.gclass97_0 = value;
			this.vmethod_0("Service");
		}
	}

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x06001402 RID: 5122 RVA: 0x00052E3C File Offset: 0x0005103C
	public string DisplayName
	{
		get
		{
			return this.gclass97_0.DisplayName;
		}
	}

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x06001403 RID: 5123 RVA: 0x00052E4C File Offset: 0x0005104C
	public List<string> WillBrake
	{
		get
		{
			return this.gclass97_0.WillBrake;
		}
	}

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x06001404 RID: 5124 RVA: 0x00052E5C File Offset: 0x0005105C
	public bool IsService
	{
		get
		{
			return this.gclass97_0.method_4();
		}
	}

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x06001405 RID: 5125 RVA: 0x00052E6C File Offset: 0x0005106C
	public string ServiceName
	{
		get
		{
			return this.gclass97_0.ServiceName;
		}
	}

	// Token: 0x170002AE RID: 686
	// (get) Token: 0x06001406 RID: 5126 RVA: 0x00052E7C File Offset: 0x0005107C
	// (set) Token: 0x06001407 RID: 5127 RVA: 0x00052E84 File Offset: 0x00051084
	public string Description
	{
		get
		{
			return this.string_0;
		}
		set
		{
			if (value == this.string_0)
			{
				return;
			}
			this.string_0 = value;
			this.vmethod_0("Description");
		}
	}

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x06001408 RID: 5128 RVA: 0x00052EA8 File Offset: 0x000510A8
	public List<GClass110> DependenciesLinear
	{
		get
		{
			return this.list_2;
		}
	}

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x06001409 RID: 5129 RVA: 0x00052EB0 File Offset: 0x000510B0
	public List<GClass110> DependenciesTree
	{
		get
		{
			return this.list_0;
		}
	}

	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x0600140A RID: 5130 RVA: 0x00052EB8 File Offset: 0x000510B8
	public bool DependenciesTreeHasValue
	{
		get
		{
			return this.DependenciesTree.Count > 0;
		}
	}

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x0600140B RID: 5131 RVA: 0x00052EC8 File Offset: 0x000510C8
	public List<GClass110> DependOn
	{
		get
		{
			return this.list_1;
		}
	}

	// Token: 0x170002B3 RID: 691
	// (set) Token: 0x0600140C RID: 5132 RVA: 0x00052ED0 File Offset: 0x000510D0
	public bool ShowDisplayName
	{
		set
		{
			if (value == this.bool_0)
			{
				return;
			}
			this.bool_0 = value;
			this.ServiceViewName = (value ? this.DisplayName : this.ServiceName);
		}
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x0600140D RID: 5133 RVA: 0x00052EFC File Offset: 0x000510FC
	// (set) Token: 0x0600140E RID: 5134 RVA: 0x00052F04 File Offset: 0x00051104
	public ServiceStartMode NewStartMode
	{
		get
		{
			return this.serviceStartMode_0;
		}
		set
		{
			if (value == this.serviceStartMode_0)
			{
				return;
			}
			this.serviceStartMode_0 = value;
			if (value == ServiceStartMode.Automatic && this.NewStatus == ServiceControllerStatus.Stopped)
			{
				this.NewStatus = ServiceControllerStatus.Running;
			}
			else if (value == ServiceStartMode.Disabled && this.NewStatus == ServiceControllerStatus.Running)
			{
				this.NewStatus = ServiceControllerStatus.Stopped;
			}
			this.vmethod_0("NewStartMode");
			this.vmethod_0("IsChecked");
			this.vmethod_0("NewStartModeChanged");
			this.vmethod_0("HasChanges");
			this.vmethod_0("IsDefault");
			this.vmethod_0("IsDisabled");
		}
	}

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x0600140F RID: 5135 RVA: 0x00052F90 File Offset: 0x00051190
	public bool NewStartModeChanged
	{
		get
		{
			return this.NewStartMode != this.Service.method_0();
		}
	}

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x06001410 RID: 5136 RVA: 0x00052FA8 File Offset: 0x000511A8
	// (set) Token: 0x06001411 RID: 5137 RVA: 0x00052FB0 File Offset: 0x000511B0
	public ServiceControllerStatus NewStatus
	{
		get
		{
			return this.serviceControllerStatus_0;
		}
		set
		{
			if (value == this.serviceControllerStatus_0)
			{
				return;
			}
			this.serviceControllerStatus_0 = value;
			this.vmethod_0("NewStatus");
			this.vmethod_0("NewStatusChanged");
			this.vmethod_0("HasChanges");
		}
	}

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x06001412 RID: 5138 RVA: 0x00052FE4 File Offset: 0x000511E4
	public bool NewStatusChanged
	{
		get
		{
			return this.NewStatus != this.Service.Status;
		}
	}

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x06001413 RID: 5139 RVA: 0x00052FFC File Offset: 0x000511FC
	public bool HasChanges
	{
		get
		{
			return this.NewStatusChanged || this.NewStartModeChanged;
		}
	}

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x06001414 RID: 5140 RVA: 0x00053010 File Offset: 0x00051210
	// (set) Token: 0x06001415 RID: 5141 RVA: 0x00053018 File Offset: 0x00051218
	public string ServiceViewName
	{
		get
		{
			return this.string_1;
		}
		set
		{
			if (value == this.string_1)
			{
				return;
			}
			this.string_1 = value;
			this.vmethod_0("ServiceViewName");
		}
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x06001416 RID: 5142 RVA: 0x0005303C File Offset: 0x0005123C
	public ServiceStartMode? DefaultStartMode
	{
		get
		{
			return this.gclass97_0.DefaultStartMode;
		}
	}

	// Token: 0x170002BB RID: 699
	// (get) Token: 0x06001417 RID: 5143 RVA: 0x0005304C File Offset: 0x0005124C
	public bool DefaultStartNodeExists
	{
		get
		{
			return this.DefaultStartMode != null;
		}
	}

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x06001418 RID: 5144 RVA: 0x00053068 File Offset: 0x00051268
	public string DependOnString
	{
		get
		{
			if (this.DependOn.Count == 0)
			{
				return Class364.smethod_0("NoDependOn");
			}
			return string.Join(", ", this.DependOn.Select(new Func<GClass110, string>(GClass110.Class409.class409_0.method_0)).ToList<string>());
		}
	}

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x06001419 RID: 5145 RVA: 0x000530CC File Offset: 0x000512CC
	public string ServiceDependencies
	{
		get
		{
			if (this.DependenciesLinear.Count == 0)
			{
				return Class364.smethod_0("NoDependencies");
			}
			return string.Join(", ", this.DependenciesLinear.Select(new Func<GClass110, string>(GClass110.Class409.class409_0.method_1)).ToList<string>());
		}
	}

	// Token: 0x170002BE RID: 702
	// (get) Token: 0x0600141A RID: 5146 RVA: 0x00053130 File Offset: 0x00051330
	public bool IsBlocked
	{
		get
		{
			return this.Service.IsBlocked;
		}
	}

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x0600141B RID: 5147 RVA: 0x00053140 File Offset: 0x00051340
	// (set) Token: 0x0600141C RID: 5148 RVA: 0x0005314C File Offset: 0x0005134C
	public bool IsChecked
	{
		get
		{
			return this.NewStartMode == ServiceStartMode.Disabled;
		}
		set
		{
			this.method_0(!value);
			this.vmethod_0("IsChecked");
		}
	}

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x0600141D RID: 5149 RVA: 0x00053164 File Offset: 0x00051364
	public bool IsDefault
	{
		get
		{
			if (this.Service.DefaultStartMode != null)
			{
				ServiceStartMode? defaultStartMode = this.Service.DefaultStartMode;
				ServiceStartMode newStartMode = this.NewStartMode;
				return defaultStartMode.GetValueOrDefault() == newStartMode & defaultStartMode != null;
			}
			return false;
		}
	}

	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x0600141E RID: 5150 RVA: 0x000531B0 File Offset: 0x000513B0
	public bool IsDisabled
	{
		get
		{
			if (this.NewStartModeChanged)
			{
				return this.NewStartMode == ServiceStartMode.Disabled;
			}
			return this.Service.method_0() == ServiceStartMode.Disabled;
		}
	}

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x0600141F RID: 5151 RVA: 0x000531D4 File Offset: 0x000513D4
	public bool CheckBoxEnabled
	{
		get
		{
			return this.DefaultStartNodeExists && !this.IsBlocked;
		}
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x000531EC File Offset: 0x000513EC
	public void method_0(bool bool_1)
	{
		if (bool_1)
		{
			this.NewStartMode = (this.Service.DefaultStartMode ?? this.NewStartMode);
			return;
		}
		this.NewStartMode = ServiceStartMode.Disabled;
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x00053230 File Offset: 0x00051430
	public void method_1()
	{
		this.NewStartMode = ServiceStartMode.Disabled;
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x0005323C File Offset: 0x0005143C
	public void method_2()
	{
		if (this.Service.DefaultStartMode != null)
		{
			ServiceStartMode newStartMode = this.NewStartMode;
			ServiceStartMode? defaultStartMode = this.Service.DefaultStartMode;
			if (!(newStartMode == defaultStartMode.GetValueOrDefault() & defaultStartMode != null))
			{
				this.NewStartMode = this.Service.DefaultStartMode.Value;
			}
		}
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x0005329C File Offset: 0x0005149C
	public void method_3()
	{
		if (this.NewStartModeChanged)
		{
			this.NewStartMode = this.Service.method_0();
		}
		if (this.NewStatusChanged)
		{
			this.NewStatus = this.Service.Status;
		}
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x000532D0 File Offset: 0x000514D0
	public string method_4()
	{
		string text = string.Empty;
		if (this.NewStartModeChanged)
		{
			text += this.NewStartMode.ToString();
		}
		if (this.NewStatusChanged)
		{
			text = text + "|" + this.NewStatus.ToString();
		}
		return text;
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06001425 RID: 5157 RVA: 0x00053330 File Offset: 0x00051530
	// (remove) Token: 0x06001426 RID: 5158 RVA: 0x00053368 File Offset: 0x00051568
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

	// Token: 0x06001427 RID: 5159 RVA: 0x000533A0 File Offset: 0x000515A0
	protected void vmethod_0([CallerMemberName] string string_2)
	{
		if (this.propertyChangedEventHandler_0 != null)
		{
			this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(string_2));
		}
	}

	// Token: 0x04000C2C RID: 3116
	private GClass97 gclass97_0;

	// Token: 0x04000C2D RID: 3117
	private string string_0;

	// Token: 0x04000C2E RID: 3118
	private readonly List<GClass110> list_0 = new List<GClass110>();

	// Token: 0x04000C2F RID: 3119
	private readonly List<GClass110> list_1 = new List<GClass110>();

	// Token: 0x04000C30 RID: 3120
	private bool bool_0;

	// Token: 0x04000C31 RID: 3121
	private ServiceStartMode serviceStartMode_0;

	// Token: 0x04000C32 RID: 3122
	private ServiceControllerStatus serviceControllerStatus_0;

	// Token: 0x04000C33 RID: 3123
	private readonly List<GClass110> list_2 = new List<GClass110>();

	// Token: 0x04000C34 RID: 3124
	private string string_1;

	// Token: 0x04000C35 RID: 3125
	private ServicesTweak servicesTweak_0;

	// Token: 0x04000C36 RID: 3126
	private PropertyChangedEventHandler propertyChangedEventHandler_0;

	// Token: 0x02000381 RID: 897
	[Serializable]
	private sealed class Class409
	{
		// Token: 0x0600142A RID: 5162 RVA: 0x000533D0 File Offset: 0x000515D0
		internal string method_0(GClass110 gclass110_0)
		{
			return gclass110_0.ServiceName;
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x000533D8 File Offset: 0x000515D8
		internal string method_1(GClass110 gclass110_0)
		{
			return gclass110_0.ServiceName;
		}

		// Token: 0x04000C37 RID: 3127
		public static readonly GClass110.Class409 class409_0 = new GClass110.Class409();

		// Token: 0x04000C38 RID: 3128
		public static Func<GClass110, string> func_0;

		// Token: 0x04000C39 RID: 3129
		public static Func<GClass110, string> func_1;
	}
}
