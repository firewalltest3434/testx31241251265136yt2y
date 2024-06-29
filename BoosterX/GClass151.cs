using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Threading;
using BoosterX.Classes.Tweaks.Expert.ServicesTweak;

// Token: 0x020004E7 RID: 1255
public sealed class GClass151 : INotifyPropertyChanged
{
	// Token: 0x06001B87 RID: 7047 RVA: 0x00071320 File Offset: 0x0006F520
	public GClass151(GClass110 gclass110_1)
	{
		this.gclass110_0 = gclass110_1;
		this.gclass110_0.PropertyChanged += this.gclass110_0_PropertyChanged;
		this.DependenciesTree = this.gclass110_0.DependenciesTree.Select(new Func<GClass110, GClass151>(GClass151.Class583.class583_0.method_0)).ToList<GClass151>();
		this.PropertyChanged += this.GClass151_PropertyChanged;
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x000713C0 File Offset: 0x0006F5C0
	private void GClass151_PropertyChanged(object sender, PropertyChangedEventArgs p1)
	{
		string propertyName = p1.PropertyName;
		if (propertyName == "NewStatus" || propertyName == "NewStartMode")
		{
			this.method_0();
		}
	}

	// Token: 0x06001B89 RID: 7049 RVA: 0x00071400 File Offset: 0x0006F600
	private void method_0()
	{
		if (this.DisableChildren && this.NewStartMode == ServiceStartMode.Disabled)
		{
			ServiceStartMode? defaultStartMode = this.Service.DefaultStartMode;
			if (!(defaultStartMode.GetValueOrDefault() == ServiceStartMode.Disabled & defaultStartMode != null))
			{
				if (this.IsUserChecked)
				{
					this.method_3(this);
				}
				this.DependenciesTree.ForEach(new Action<GClass151>(GClass151.Class583.class583_0.method_1));
			}
		}
		bool flag;
		if (flag = this.EnableParents)
		{
			ServiceStartMode newStartMode = this.NewStartMode;
			bool flag2 = newStartMode - ServiceStartMode.Automatic <= 1;
			flag = flag2;
		}
		if (flag)
		{
			this.DependOn.ForEach(new Action<GClass110>(GClass151.Class583.class583_0.method_2));
		}
		if (!this.HasChanges)
		{
			this.method_2();
			return;
		}
		this.method_1();
	}

	// Token: 0x06001B8A RID: 7050 RVA: 0x00071500 File Offset: 0x0006F700
	private void method_1()
	{
		GClass93.smethod_0().method_9<ServicesTweak>(this.WinServiceViewModel.ServicesTweak.ServiceName, new Func<ServicesTweak>(this.method_9), this.WinServiceViewModel.method_4());
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x00071534 File Offset: 0x0006F734
	private void method_2()
	{
		GClass93.smethod_0().method_14<ServicesTweak>(this.WinServiceViewModel.ServicesTweak.ServiceName);
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x00071554 File Offset: 0x0006F754
	private void method_3(GClass151 gclass151_0)
	{
		gclass151_0.method_4();
		gclass151_0.DependenciesTree.ForEach(new Action<GClass151>(this.method_3));
	}

	// Token: 0x17000436 RID: 1078
	// (get) Token: 0x06001B8D RID: 7053 RVA: 0x00071574 File Offset: 0x0006F774
	// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0007157C File Offset: 0x0006F77C
	public GClass110 WinServiceViewModel
	{
		get
		{
			return this.gclass110_0;
		}
		set
		{
			this.gclass110_0 = value;
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x06001B8F RID: 7055 RVA: 0x00071588 File Offset: 0x0006F788
	// (remove) Token: 0x06001B90 RID: 7056 RVA: 0x000715C0 File Offset: 0x0006F7C0
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

	// Token: 0x06001B91 RID: 7057 RVA: 0x000715F8 File Offset: 0x0006F7F8
	protected void vmethod_0([CallerMemberName] string string_0)
	{
		if (this.propertyChangedEventHandler_0 != null)
		{
			this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(string_0));
		}
	}

	// Token: 0x17000437 RID: 1079
	// (get) Token: 0x06001B92 RID: 7058 RVA: 0x00071614 File Offset: 0x0006F814
	// (set) Token: 0x06001B93 RID: 7059 RVA: 0x0007161C File Offset: 0x0006F81C
	public bool Loaded
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			if (value == this.bool_2)
			{
				return;
			}
			this.bool_2 = value;
			this.vmethod_0("Loaded");
		}
	}

	// Token: 0x17000438 RID: 1080
	// (get) Token: 0x06001B94 RID: 7060 RVA: 0x0007163C File Offset: 0x0006F83C
	// (set) Token: 0x06001B95 RID: 7061 RVA: 0x00071644 File Offset: 0x0006F844
	public bool ShowDescription
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			if (value == this.bool_0)
			{
				return;
			}
			this.bool_0 = value;
			this.vmethod_0("ShowDescription");
		}
	}

	// Token: 0x17000439 RID: 1081
	// (get) Token: 0x06001B96 RID: 7062 RVA: 0x00071664 File Offset: 0x0006F864
	// (set) Token: 0x06001B97 RID: 7063 RVA: 0x0007166C File Offset: 0x0006F86C
	public bool ShowChildList
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			if (value == this.bool_1)
			{
				return;
			}
			this.bool_1 = value;
			this.vmethod_0("ShowChildList");
		}
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x0007168C File Offset: 0x0006F88C
	public void method_4()
	{
		if (this.DependenciesTreeHasValue)
		{
			this.ShowChildList = true;
		}
	}

	// Token: 0x1700043A RID: 1082
	// (get) Token: 0x06001B99 RID: 7065 RVA: 0x000716A0 File Offset: 0x0006F8A0
	// (set) Token: 0x06001B9A RID: 7066 RVA: 0x000716A8 File Offset: 0x0006F8A8
	public bool EnableParents
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			if (value == this.bool_3)
			{
				return;
			}
			this.bool_3 = value;
			this.vmethod_0("EnableParents");
		}
	}

	// Token: 0x1700043B RID: 1083
	// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000716C8 File Offset: 0x0006F8C8
	// (set) Token: 0x06001B9C RID: 7068 RVA: 0x000716D0 File Offset: 0x0006F8D0
	public bool DisableChildren
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			if (value == this.bool_4)
			{
				return;
			}
			this.bool_4 = value;
			this.vmethod_0("DisableChildren");
		}
	}

	// Token: 0x1700043C RID: 1084
	// (get) Token: 0x06001B9D RID: 7069 RVA: 0x000716F0 File Offset: 0x0006F8F0
	public GClass134 RevertCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_10), null));
			}
			return result;
		}
	}

	// Token: 0x1700043D RID: 1085
	// (get) Token: 0x06001B9E RID: 7070 RVA: 0x00071724 File Offset: 0x0006F924
	public GClass134 RevertTreeCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_1) == null)
			{
				result = (this.gclass134_1 = new GClass134(new Action<object>(this.method_11), null));
			}
			return result;
		}
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x00071758 File Offset: 0x0006F958
	private void method_5(GClass151 gclass151_0)
	{
		gclass151_0.WinServiceViewModel.method_3();
		gclass151_0.DependenciesTree.ForEach(new Action<GClass151>(this.method_5));
	}

	// Token: 0x1700043E RID: 1086
	// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0007177C File Offset: 0x0006F97C
	// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x0007178C File Offset: 0x0006F98C
	public GClass97 Service
	{
		get
		{
			return this.WinServiceViewModel.Service;
		}
		set
		{
			this.WinServiceViewModel.Service = value;
		}
	}

	// Token: 0x1700043F RID: 1087
	// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x0007179C File Offset: 0x0006F99C
	public string DisplayName
	{
		get
		{
			return this.WinServiceViewModel.DisplayName;
		}
	}

	// Token: 0x17000440 RID: 1088
	// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x000717AC File Offset: 0x0006F9AC
	public string CurrentLocalization
	{
		get
		{
			return Class364.smethod_0("CurrentLocalization");
		}
	}

	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x000717B8 File Offset: 0x0006F9B8
	public string WillBrake
	{
		get
		{
			GClass151.Class584 @class = new GClass151.Class584();
			if (this.WinServiceViewModel.WillBrake == null)
			{
				return Class364.smethod_0("Unknown");
			}
			if (this.WinServiceViewModel.WillBrake[0] == string.Empty)
			{
				return Class364.smethod_0("Unknown");
			}
			@class.list_0 = new List<string>();
			this.WinServiceViewModel.WillBrake.ForEach(new Action<string>(@class.method_0));
			return string.Join(", ", @class.list_0);
		}
	}

	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x00071844 File Offset: 0x0006FA44
	public bool IsService
	{
		get
		{
			return this.WinServiceViewModel.IsService;
		}
	}

	// Token: 0x17000443 RID: 1091
	// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00071854 File Offset: 0x0006FA54
	public string ServiceName
	{
		get
		{
			return this.WinServiceViewModel.ServiceName;
		}
	}

	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x00071864 File Offset: 0x0006FA64
	// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x00071874 File Offset: 0x0006FA74
	public string Description
	{
		get
		{
			return this.WinServiceViewModel.Description;
		}
		set
		{
			this.WinServiceViewModel.Description = value;
		}
	}

	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x00071884 File Offset: 0x0006FA84
	public List<GClass110> DependenciesLinear
	{
		get
		{
			return this.WinServiceViewModel.DependenciesLinear;
		}
	}

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x06001BAA RID: 7082 RVA: 0x00071894 File Offset: 0x0006FA94
	// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0007189C File Offset: 0x0006FA9C
	public List<GClass151> DependenciesTree
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
			this.list_0.ForEach(new Action<GClass151>(this.method_12));
			this.list_0 = value;
			this.list_0.ForEach(new Action<GClass151>(this.method_13));
			this.vmethod_0("DependenciesTree");
			this.vmethod_0("DependenciesTreeHasChanges");
		}
	}

	// Token: 0x06001BAC RID: 7084 RVA: 0x00071904 File Offset: 0x0006FB04
	private void method_6(object sender, PropertyChangedEventArgs p1)
	{
		string propertyName = p1.PropertyName;
		if (propertyName == "DependenciesTreeHasChanges" || propertyName == "HasChanges")
		{
			this.vmethod_0("DependenciesTreeHasChanges");
		}
	}

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x06001BAD RID: 7085 RVA: 0x00071948 File Offset: 0x0006FB48
	public bool DependenciesTreeHasValue
	{
		get
		{
			return this.WinServiceViewModel.DependenciesTreeHasValue;
		}
	}

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00071958 File Offset: 0x0006FB58
	public bool DependenciesTreeHasChanges
	{
		get
		{
			return this.method_7(this.DependenciesTree);
		}
	}

	// Token: 0x06001BAF RID: 7087 RVA: 0x00071968 File Offset: 0x0006FB68
	private bool method_7(List<GClass151> list_1)
	{
		return list_1.Any(new Func<GClass151, bool>(this.method_8));
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x0007197C File Offset: 0x0006FB7C
	private bool method_8(GClass151 gclass151_0)
	{
		return gclass151_0.HasChanges || gclass151_0.DependenciesTree.Any(new Func<GClass151, bool>(this.method_8));
	}

	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x000719A0 File Offset: 0x0006FBA0
	public List<GClass110> DependOn
	{
		get
		{
			return this.WinServiceViewModel.DependOn;
		}
	}

	// Token: 0x1700044A RID: 1098
	// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x000719B0 File Offset: 0x0006FBB0
	public bool ShowDisplayName
	{
		set
		{
			this.WinServiceViewModel.ShowDisplayName = value;
		}
	}

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x000719C0 File Offset: 0x0006FBC0
	// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x000719D0 File Offset: 0x0006FBD0
	public ServiceStartMode NewStartMode
	{
		get
		{
			return this.WinServiceViewModel.NewStartMode;
		}
		set
		{
			if (!Class585.struct13_0.method_0())
			{
				return;
			}
			this.WinServiceViewModel.NewStartMode = value;
		}
	}

	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x000719EC File Offset: 0x0006FBEC
	public bool NewStartModeChanged
	{
		get
		{
			return this.WinServiceViewModel.NewStartModeChanged;
		}
	}

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x000719FC File Offset: 0x0006FBFC
	// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x00071A0C File Offset: 0x0006FC0C
	public ServiceControllerStatus NewStatus
	{
		get
		{
			return this.WinServiceViewModel.NewStatus;
		}
		set
		{
			if (!Class585.struct13_0.method_0())
			{
				return;
			}
			this.WinServiceViewModel.NewStatus = value;
		}
	}

	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x00071A28 File Offset: 0x0006FC28
	public bool NewStatusChanged
	{
		get
		{
			return this.WinServiceViewModel.NewStatusChanged;
		}
	}

	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00071A38 File Offset: 0x0006FC38
	public bool HasChanges
	{
		get
		{
			return this.WinServiceViewModel.HasChanges;
		}
	}

	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00071A48 File Offset: 0x0006FC48
	// (set) Token: 0x06001BBB RID: 7099 RVA: 0x00071A58 File Offset: 0x0006FC58
	public string ServiceViewName
	{
		get
		{
			return this.WinServiceViewModel.ServiceViewName;
		}
		set
		{
			this.WinServiceViewModel.ServiceViewName = value;
		}
	}

	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00071A68 File Offset: 0x0006FC68
	public ServiceStartMode? DefaultStartMode
	{
		get
		{
			return this.WinServiceViewModel.DefaultStartMode;
		}
	}

	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00071A78 File Offset: 0x0006FC78
	public bool DefaultStartNodeExists
	{
		get
		{
			return this.WinServiceViewModel.DefaultStartNodeExists;
		}
	}

	// Token: 0x17000453 RID: 1107
	// (get) Token: 0x06001BBE RID: 7102 RVA: 0x00071A88 File Offset: 0x0006FC88
	public string DependOnString
	{
		get
		{
			return this.WinServiceViewModel.DependOnString;
		}
	}

	// Token: 0x17000454 RID: 1108
	// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00071A98 File Offset: 0x0006FC98
	public string ServiceDependencies
	{
		get
		{
			return this.WinServiceViewModel.ServiceDependencies;
		}
	}

	// Token: 0x17000455 RID: 1109
	// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x00071AA8 File Offset: 0x0006FCA8
	public bool IsBlocked
	{
		get
		{
			return this.WinServiceViewModel.IsBlocked;
		}
	}

	// Token: 0x17000456 RID: 1110
	// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x00071AB8 File Offset: 0x0006FCB8
	public bool CheckBoxEnabled
	{
		get
		{
			return this.WinServiceViewModel.CheckBoxEnabled;
		}
	}

	// Token: 0x17000457 RID: 1111
	// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00071AC8 File Offset: 0x0006FCC8
	// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x00071AD8 File Offset: 0x0006FCD8
	public bool IsChecked
	{
		get
		{
			return this.WinServiceViewModel.IsChecked;
		}
		set
		{
			if (!Class585.struct13_0.method_0())
			{
				return;
			}
			this.WinServiceViewModel.IsChecked = value;
		}
	}

	// Token: 0x17000458 RID: 1112
	// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00071AF4 File Offset: 0x0006FCF4
	public bool IsDefault
	{
		get
		{
			return this.WinServiceViewModel.IsDefault;
		}
	}

	// Token: 0x17000459 RID: 1113
	// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00071B04 File Offset: 0x0006FD04
	public bool IsDisabled
	{
		get
		{
			return this.WinServiceViewModel.IsDisabled;
		}
	}

	// Token: 0x1700045A RID: 1114
	// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00071B14 File Offset: 0x0006FD14
	// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x00071B1C File Offset: 0x0006FD1C
	public bool IsClickable
	{
		get
		{
			return this.bool_5;
		}
		set
		{
			if (value == this.bool_5)
			{
				return;
			}
			this.bool_5 = value;
			this.vmethod_0("IsClickable");
		}
	}

	// Token: 0x1700045B RID: 1115
	// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00071B3C File Offset: 0x0006FD3C
	// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x00071B44 File Offset: 0x0006FD44
	public bool IsUserChecked
	{
		[CompilerGenerated]
		get
		{
			return this.bool_6;
		}
		[CompilerGenerated]
		set
		{
			this.bool_6 = value;
		}
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x00071B50 File Offset: 0x0006FD50
	private void gclass110_0_PropertyChanged(object sender, PropertyChangedEventArgs p1)
	{
		this.vmethod_0(p1.PropertyName);
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x00071B60 File Offset: 0x0006FD60
	private ServicesTweak method_9()
	{
		return this.WinServiceViewModel.ServicesTweak;
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x00071B70 File Offset: 0x0006FD70
	private void method_10(object object_0)
	{
		this.WinServiceViewModel.method_3();
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x00071B80 File Offset: 0x0006FD80
	private void method_11(object object_0)
	{
		this.method_5(this);
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x00071B8C File Offset: 0x0006FD8C
	private void method_12(GClass151 gclass151_0)
	{
		gclass151_0.PropertyChanged -= this.method_6;
	}

	// Token: 0x06001BCF RID: 7119 RVA: 0x00071BA0 File Offset: 0x0006FDA0
	private void method_13(GClass151 gclass151_0)
	{
		gclass151_0.PropertyChanged += this.method_6;
	}

	// Token: 0x0400135B RID: 4955
	private GClass110 gclass110_0;

	// Token: 0x0400135C RID: 4956
	private List<GClass151> list_0 = new List<GClass151>();

	// Token: 0x0400135D RID: 4957
	private bool bool_0;

	// Token: 0x0400135E RID: 4958
	private bool bool_1;

	// Token: 0x0400135F RID: 4959
	private bool bool_2;

	// Token: 0x04001360 RID: 4960
	private bool bool_3 = true;

	// Token: 0x04001361 RID: 4961
	private bool bool_4 = true;

	// Token: 0x04001362 RID: 4962
	private PropertyChangedEventHandler propertyChangedEventHandler_0;

	// Token: 0x04001363 RID: 4963
	private GClass134 gclass134_0;

	// Token: 0x04001364 RID: 4964
	private GClass134 gclass134_1;

	// Token: 0x04001365 RID: 4965
	private bool bool_5 = true;

	// Token: 0x04001366 RID: 4966
	private bool bool_6;

	// Token: 0x020004E8 RID: 1256
	[Serializable]
	private sealed class Class583
	{
		// Token: 0x06001BD2 RID: 7122 RVA: 0x00071BC8 File Offset: 0x0006FDC8
		internal GClass151 method_0(GClass110 gclass110_0)
		{
			return new GClass151(gclass110_0);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00071BD0 File Offset: 0x0006FDD0
		internal void method_1(GClass151 gclass151_0)
		{
			gclass151_0.WinServiceViewModel.method_1();
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00071BE0 File Offset: 0x0006FDE0
		internal void method_2(GClass110 gclass110_0)
		{
			gclass110_0.method_2();
		}

		// Token: 0x04001367 RID: 4967
		public static readonly GClass151.Class583 class583_0 = new GClass151.Class583();

		// Token: 0x04001368 RID: 4968
		public static Func<GClass110, GClass151> func_0;

		// Token: 0x04001369 RID: 4969
		public static Action<GClass151> action_0;

		// Token: 0x0400136A RID: 4970
		public static Action<GClass110> action_1;
	}

	// Token: 0x020004E9 RID: 1257
	private sealed class Class584
	{
		// Token: 0x06001BD6 RID: 7126 RVA: 0x00071BF0 File Offset: 0x0006FDF0
		internal void method_0(string string_0)
		{
			this.list_0.Add(Class364.smethod_0(string_0));
		}

		// Token: 0x0400136B RID: 4971
		public List<string> list_0;
	}
}
