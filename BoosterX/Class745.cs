using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using BoosterX.Classes.Tweaks.OptimizationTweaks.GlobalTweak;
using Material.Icons;
using Microsoft.Dism;
using ns0;

// Token: 0x02000413 RID: 1043
internal sealed class Class745 : GClass211
{
	// Token: 0x06001692 RID: 5778 RVA: 0x0005E8FC File Offset: 0x0005CAFC
	public Class745(GClass179 gclass179_1, Class525 class525_1, bool bool_6 = false, bool bool_7 = false)
	{
		this.gclass179_0 = gclass179_1;
		this.class525_0 = class525_1;
		this.method_8(bool_6, bool_7);
		this.method_7();
		this.method_1();
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		if (bool_7)
		{
			this.method_2();
		}
	}

	// Token: 0x06001693 RID: 5779 RVA: 0x0005EA04 File Offset: 0x0005CC04
	private void method_1()
	{
		Class745.Struct230 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class745_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class745.Struct230>(ref @struct);
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x0005EA3C File Offset: 0x0005CC3C
	private void method_2()
	{
		Class745.Struct227 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class745_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class745.Struct227>(ref @struct);
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x0005EA74 File Offset: 0x0005CC74
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("ColChanged");
	}

	// Token: 0x17000307 RID: 775
	// (get) Token: 0x06001696 RID: 5782 RVA: 0x0005EA84 File Offset: 0x0005CC84
	// (set) Token: 0x06001697 RID: 5783 RVA: 0x0005EA8C File Offset: 0x0005CC8C
	public ObservableCollection<Class745> Childs
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("Childs");
		}
	}

	// Token: 0x17000308 RID: 776
	// (get) Token: 0x06001698 RID: 5784 RVA: 0x0005EAA0 File Offset: 0x0005CCA0
	public GClass179 JsonTweakDto
	{
		get
		{
			return this.gclass179_0;
		}
	}

	// Token: 0x17000309 RID: 777
	// (get) Token: 0x06001699 RID: 5785 RVA: 0x0005EAA8 File Offset: 0x0005CCA8
	public int Level
	{
		get
		{
			return this.gclass179_0.Int32_0;
		}
	}

	// Token: 0x1700030A RID: 778
	// (get) Token: 0x0600169A RID: 5786 RVA: 0x0005EAB8 File Offset: 0x0005CCB8
	public string NameRawIcon
	{
		get
		{
			return this.gclass179_0.String_0;
		}
	}

	// Token: 0x1700030B RID: 779
	// (get) Token: 0x0600169B RID: 5787 RVA: 0x0005EAC8 File Offset: 0x0005CCC8
	public Guid Id
	{
		get
		{
			return this.gclass179_0.Guid_0;
		}
	}

	// Token: 0x1700030C RID: 780
	// (get) Token: 0x0600169C RID: 5788 RVA: 0x0005EAD8 File Offset: 0x0005CCD8
	public string GroupName
	{
		get
		{
			return Class364.smethod_0(this.gclass179_0.String_1);
		}
	}

	// Token: 0x1700030D RID: 781
	// (get) Token: 0x0600169D RID: 5789 RVA: 0x0005EAEC File Offset: 0x0005CCEC
	public List<GClass67> jsonTweakStepDtos
	{
		get
		{
			return this.gclass179_0.List_4;
		}
	}

	// Token: 0x1700030E RID: 782
	// (get) Token: 0x0600169E RID: 5790 RVA: 0x0005EAFC File Offset: 0x0005CCFC
	public bool LevelCount
	{
		get
		{
			return this.gclass179_0.List_0.Contains("LEVEL");
		}
	}

	// Token: 0x1700030F RID: 783
	// (get) Token: 0x0600169F RID: 5791 RVA: 0x0005EB14 File Offset: 0x0005CD14
	public bool ShowIncluded
	{
		get
		{
			return this.gclass179_0.List_0.Contains("VISIBLETWEAKS") && Class585.struct13_0.method_0();
		}
	}

	// Token: 0x17000310 RID: 784
	// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0005EB3C File Offset: 0x0005CD3C
	public bool ShowIncluded2
	{
		get
		{
			return this.gclass179_0.List_0.Contains("VISIBLETWEAKS");
		}
	}

	// Token: 0x060016A1 RID: 5793 RVA: 0x0005EB54 File Offset: 0x0005CD54
	private MaterialIconKind method_3()
	{
		return this.materialIconKind_0;
	}

	// Token: 0x060016A2 RID: 5794 RVA: 0x0005EB5C File Offset: 0x0005CD5C
	private void method_4(MaterialIconKind materialIconKind_2)
	{
		this.materialIconKind_0 = materialIconKind_2;
	}

	// Token: 0x17000311 RID: 785
	// (get) Token: 0x060016A3 RID: 5795 RVA: 0x0005EB68 File Offset: 0x0005CD68
	// (set) Token: 0x060016A4 RID: 5796 RVA: 0x0005EB70 File Offset: 0x0005CD70
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_3();
		}
		set
		{
			this.method_4(value);
			base.method_0("Icon");
		}
	}

	// Token: 0x17000312 RID: 786
	// (get) Token: 0x060016A5 RID: 5797 RVA: 0x0005EB84 File Offset: 0x0005CD84
	public List<Class658> TweakInfoVMs
	{
		get
		{
			Class745.Class479 @class = new Class745.Class479();
			@class.class745_0 = this;
			@class.list_0 = new List<Class658>();
			this.gclass179_0.List_4.ForEach(new Action<GClass67>(@class.method_0));
			return @class.list_0;
		}
	}

	// Token: 0x17000313 RID: 787
	// (get) Token: 0x060016A6 RID: 5798 RVA: 0x0005EBCC File Offset: 0x0005CDCC
	// (set) Token: 0x060016A7 RID: 5799 RVA: 0x0005EBD4 File Offset: 0x0005CDD4
	public string CurrentValueType
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

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x060016A8 RID: 5800 RVA: 0x0005EBE0 File Offset: 0x0005CDE0
	public bool AddToConfig
	{
		get
		{
			return (!this.IsEditable || Class585.struct13_0.method_0()) && (!this.gclass179_0.List_0.Contains("PRO") || Class585.struct13_0.method_0());
		}
	}

	// Token: 0x17000315 RID: 789
	// (get) Token: 0x060016A9 RID: 5801 RVA: 0x0005EC1C File Offset: 0x0005CE1C
	public bool IsPRO
	{
		get
		{
			return this.gclass179_0.List_0.Contains("PRO");
		}
	}

	// Token: 0x17000316 RID: 790
	// (get) Token: 0x060016AA RID: 5802 RVA: 0x0005EC34 File Offset: 0x0005CE34
	public bool IsExp
	{
		get
		{
			return this.gclass179_0.List_1.Contains("EXPERIMENTAL");
		}
	}

	// Token: 0x17000317 RID: 791
	// (get) Token: 0x060016AB RID: 5803 RVA: 0x0005EC4C File Offset: 0x0005CE4C
	public bool IsSupported
	{
		get
		{
			return Class453.smethod_1(this.gclass179_0.List_1);
		}
	}

	// Token: 0x17000318 RID: 792
	// (get) Token: 0x060016AC RID: 5804 RVA: 0x0005EC60 File Offset: 0x0005CE60
	public string Name
	{
		get
		{
			return Class364.smethod_0(this.gclass179_0.Name);
		}
	}

	// Token: 0x17000319 RID: 793
	// (get) Token: 0x060016AD RID: 5805 RVA: 0x0005EC74 File Offset: 0x0005CE74
	public string NameRaw
	{
		get
		{
			return this.gclass179_0.Name;
		}
	}

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x060016AE RID: 5806 RVA: 0x0005EC84 File Offset: 0x0005CE84
	public List<string> WillBrake
	{
		get
		{
			return this.gclass179_0.WillBrake;
		}
	}

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x060016AF RID: 5807 RVA: 0x0005EC94 File Offset: 0x0005CE94
	public string Description
	{
		get
		{
			return Class364.smethod_0(this.gclass179_0.Description);
		}
	}

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x060016B0 RID: 5808 RVA: 0x0005ECA8 File Offset: 0x0005CEA8
	public string TmType
	{
		get
		{
			return this.gclass179_0.Type;
		}
	}

	// Token: 0x1700031D RID: 797
	// (get) Token: 0x060016B1 RID: 5809 RVA: 0x0005ECB8 File Offset: 0x0005CEB8
	public bool IsCheckReversed
	{
		get
		{
			bool value = this.nullable_0.GetValueOrDefault();
			if (this.nullable_0 == null)
			{
				value = (this.gclass179_0.Type == "DOUBLE" && this.gclass179_0.method_0());
				this.nullable_0 = new bool?(value);
			}
			return this.nullable_0.Value;
		}
	}

	// Token: 0x1700031E RID: 798
	// (get) Token: 0x060016B2 RID: 5810 RVA: 0x0005ED1C File Offset: 0x0005CF1C
	// (set) Token: 0x060016B3 RID: 5811 RVA: 0x0005ED24 File Offset: 0x0005CF24
	public bool ShowDescription
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			base.method_0("ShowDescription");
		}
	}

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x060016B4 RID: 5812 RVA: 0x0005ED38 File Offset: 0x0005CF38
	// (set) Token: 0x060016B5 RID: 5813 RVA: 0x0005ED40 File Offset: 0x0005CF40
	public bool ShowTweaks
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
			base.method_0("ShowTweaks");
			base.method_0("ShowTweaks");
		}
	}

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x060016B6 RID: 5814 RVA: 0x0005ED60 File Offset: 0x0005CF60
	// (set) Token: 0x060016B7 RID: 5815 RVA: 0x0005ED68 File Offset: 0x0005CF68
	public bool OnEdit
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			if (!this.IsEditable)
			{
				return;
			}
			this.bool_3 = value;
			base.method_0("OnEdit");
			base.method_0("IsScript");
		}
	}

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x060016B8 RID: 5816 RVA: 0x0005ED90 File Offset: 0x0005CF90
	// (set) Token: 0x060016B9 RID: 5817 RVA: 0x0005ED98 File Offset: 0x0005CF98
	public Visibility AddVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("AddVisibility");
		}
	}

	// Token: 0x17000322 RID: 802
	// (get) Token: 0x060016BA RID: 5818 RVA: 0x0005EDAC File Offset: 0x0005CFAC
	// (set) Token: 0x060016BB RID: 5819 RVA: 0x0005EDB4 File Offset: 0x0005CFB4
	public Visibility ApplyVisibility
	{
		get
		{
			return this.visibility_1;
		}
		set
		{
			this.visibility_1 = value;
			base.method_0("ApplyVisibility");
		}
	}

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x060016BC RID: 5820 RVA: 0x0005EDC8 File Offset: 0x0005CFC8
	// (set) Token: 0x060016BD RID: 5821 RVA: 0x0005EDD0 File Offset: 0x0005CFD0
	public Visibility DoubleCBVisibility
	{
		get
		{
			return this.visibility_2;
		}
		set
		{
			this.visibility_2 = value;
			base.method_0("DoubleCBVisibility");
		}
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x060016BE RID: 5822 RVA: 0x0005EDE4 File Offset: 0x0005CFE4
	// (set) Token: 0x060016BF RID: 5823 RVA: 0x0005EDEC File Offset: 0x0005CFEC
	public Visibility DoubleReversedCBVisibility
	{
		get
		{
			return this.visibility_3;
		}
		set
		{
			this.visibility_3 = value;
			base.method_0("DoubleReversedCBVisibility");
		}
	}

	// Token: 0x17000325 RID: 805
	// (get) Token: 0x060016C0 RID: 5824 RVA: 0x0005EE00 File Offset: 0x0005D000
	// (set) Token: 0x060016C1 RID: 5825 RVA: 0x0005EE08 File Offset: 0x0005D008
	public Visibility MultiVisibility
	{
		get
		{
			return this.visibility_4;
		}
		set
		{
			this.visibility_4 = value;
			base.method_0("MultiVisibility");
		}
	}

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x060016C2 RID: 5826 RVA: 0x0005EE1C File Offset: 0x0005D01C
	// (set) Token: 0x060016C3 RID: 5827 RVA: 0x0005EE24 File Offset: 0x0005D024
	public Visibility CustomVisibility
	{
		get
		{
			return this.visibility_5;
		}
		set
		{
			this.visibility_5 = value;
			base.method_0("CustomVisibility");
		}
	}

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x060016C4 RID: 5828 RVA: 0x0005EE38 File Offset: 0x0005D038
	// (set) Token: 0x060016C5 RID: 5829 RVA: 0x0005EE40 File Offset: 0x0005D040
	public Visibility ImportVisibility
	{
		get
		{
			return this.visibility_6;
		}
		set
		{
			this.visibility_6 = value;
			base.method_0("ImportVisibility");
		}
	}

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x060016C6 RID: 5830 RVA: 0x0005EE54 File Offset: 0x0005D054
	// (set) Token: 0x060016C7 RID: 5831 RVA: 0x0005EE5C File Offset: 0x0005D05C
	public Visibility ScriptVisibility
	{
		get
		{
			return this.visibility_7;
		}
		set
		{
			this.visibility_7 = value;
			base.method_0("ScriptVisibility");
		}
	}

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x060016C8 RID: 5832 RVA: 0x0005EE70 File Offset: 0x0005D070
	// (set) Token: 0x060016C9 RID: 5833 RVA: 0x0005EE78 File Offset: 0x0005D078
	public Visibility DebloatVisibility
	{
		get
		{
			return this.visibility_8;
		}
		set
		{
			this.visibility_8 = value;
			base.method_0("DebloatVisibility");
		}
	}

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x060016CA RID: 5834 RVA: 0x0005EE8C File Offset: 0x0005D08C
	// (set) Token: 0x060016CB RID: 5835 RVA: 0x0005EE94 File Offset: 0x0005D094
	public Visibility W11Visibility
	{
		get
		{
			return this.visibility_9;
		}
		set
		{
			this.visibility_9 = value;
			base.method_0("W11Visibility");
		}
	}

	// Token: 0x1700032B RID: 811
	// (get) Token: 0x060016CC RID: 5836 RVA: 0x0005EEA8 File Offset: 0x0005D0A8
	// (set) Token: 0x060016CD RID: 5837 RVA: 0x0005EEB0 File Offset: 0x0005D0B0
	public Visibility W10Visibility
	{
		get
		{
			return this.visibility_10;
		}
		set
		{
			this.visibility_10 = value;
			base.method_0("W10Visibility");
		}
	}

	// Token: 0x1700032C RID: 812
	// (get) Token: 0x060016CE RID: 5838 RVA: 0x0005EEC4 File Offset: 0x0005D0C4
	// (set) Token: 0x060016CF RID: 5839 RVA: 0x0005EECC File Offset: 0x0005D0CC
	public Visibility LAPVisibility
	{
		get
		{
			return this.visibility_11;
		}
		set
		{
			this.visibility_11 = value;
			base.method_0("LAPVisibility");
		}
	}

	// Token: 0x1700032D RID: 813
	// (get) Token: 0x060016D0 RID: 5840 RVA: 0x0005EEE0 File Offset: 0x0005D0E0
	// (set) Token: 0x060016D1 RID: 5841 RVA: 0x0005EEE8 File Offset: 0x0005D0E8
	public Visibility PCVisibility
	{
		get
		{
			return this.visibility_12;
		}
		set
		{
			this.visibility_12 = value;
			base.method_0("PCVisibility");
		}
	}

	// Token: 0x1700032E RID: 814
	// (get) Token: 0x060016D2 RID: 5842 RVA: 0x0005EEFC File Offset: 0x0005D0FC
	// (set) Token: 0x060016D3 RID: 5843 RVA: 0x0005EF04 File Offset: 0x0005D104
	public Visibility AMDVisibility
	{
		get
		{
			return this.visibility_13;
		}
		set
		{
			this.visibility_13 = value;
			base.method_0("AMDVisibility");
		}
	}

	// Token: 0x1700032F RID: 815
	// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0005EF18 File Offset: 0x0005D118
	public Visibility ProVisibility
	{
		get
		{
			if (!this.IsPRO)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x17000330 RID: 816
	// (get) Token: 0x060016D5 RID: 5845 RVA: 0x0005EF28 File Offset: 0x0005D128
	public Visibility ExpVisibility
	{
		get
		{
			if (!this.IsExp)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x17000331 RID: 817
	// (get) Token: 0x060016D6 RID: 5846 RVA: 0x0005EF38 File Offset: 0x0005D138
	public Visibility ForceOnOffVisibility
	{
		get
		{
			if (!(this.TmType == "DOUBLE"))
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x17000332 RID: 818
	// (get) Token: 0x060016D7 RID: 5847 RVA: 0x0005EF50 File Offset: 0x0005D150
	public bool SignVisibility
	{
		get
		{
			return this.Childs.Count<Class745>() > 0;
		}
	}

	// Token: 0x17000333 RID: 819
	// (get) Token: 0x060016D8 RID: 5848 RVA: 0x0005EF60 File Offset: 0x0005D160
	// (set) Token: 0x060016D9 RID: 5849 RVA: 0x0005EF68 File Offset: 0x0005D168
	public bool ShowChildList
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			this.bool_4 = value;
			base.method_0("ShowChildList");
		}
	}

	// Token: 0x17000334 RID: 820
	// (get) Token: 0x060016DA RID: 5850 RVA: 0x0005EF7C File Offset: 0x0005D17C
	// (set) Token: 0x060016DB RID: 5851 RVA: 0x0005EF84 File Offset: 0x0005D184
	public bool? CurrentStatusDouble
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_1;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_1 = value;
		}
	}

	// Token: 0x17000335 RID: 821
	// (get) Token: 0x060016DC RID: 5852 RVA: 0x0005EF90 File Offset: 0x0005D190
	// (set) Token: 0x060016DD RID: 5853 RVA: 0x0005EF98 File Offset: 0x0005D198
	public bool? IsChecked
	{
		get
		{
			return this.nullable_2;
		}
		set
		{
			if (this.CurrentStatusDouble == null)
			{
				this.CurrentStatusDouble = value;
			}
			this.nullable_2 = value;
			base.method_0("IsChecked");
			base.method_0("HasChanges");
			this.method_9();
			this.method_18();
		}
	}

	// Token: 0x17000336 RID: 822
	// (get) Token: 0x060016DE RID: 5854 RVA: 0x0005EFE8 File Offset: 0x0005D1E8
	// (set) Token: 0x060016DF RID: 5855 RVA: 0x0005EFF0 File Offset: 0x0005D1F0
	public int? CurrentSelectedIndex
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_3;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_3 = value;
		}
	}

	// Token: 0x17000337 RID: 823
	// (get) Token: 0x060016E0 RID: 5856 RVA: 0x0005EFFC File Offset: 0x0005D1FC
	// (set) Token: 0x060016E1 RID: 5857 RVA: 0x0005F004 File Offset: 0x0005D204
	public int? SelectedIndex
	{
		get
		{
			return this.nullable_4;
		}
		set
		{
			if (this.CurrentSelectedIndex == null)
			{
				this.CurrentSelectedIndex = value;
			}
			this.nullable_4 = value;
			base.method_0("SelectedIndex");
			base.method_0("HasChanges");
			this.method_9();
			this.method_18();
		}
	}

	// Token: 0x17000338 RID: 824
	// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0005F054 File Offset: 0x0005D254
	public bool HasChanges
	{
		get
		{
			bool? isChecked = this.IsChecked;
			bool? currentStatusDouble = this.CurrentStatusDouble;
			if (isChecked.GetValueOrDefault() == currentStatusDouble.GetValueOrDefault() & isChecked != null == (currentStatusDouble != null))
			{
				int? selectedIndex = this.SelectedIndex;
				int? currentSelectedIndex = this.CurrentSelectedIndex;
				if (selectedIndex.GetValueOrDefault() == currentSelectedIndex.GetValueOrDefault() & selectedIndex != null == (currentSelectedIndex != null))
				{
					return this.CurrentCustomValue != this.CustomValue;
				}
			}
			return true;
		}
	}

	// Token: 0x17000339 RID: 825
	// (get) Token: 0x060016E3 RID: 5859 RVA: 0x0005F0D8 File Offset: 0x0005D2D8
	// (set) Token: 0x060016E4 RID: 5860 RVA: 0x0005F0E0 File Offset: 0x0005D2E0
	public string CurrentCustomValue
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

	// Token: 0x060016E5 RID: 5861 RVA: 0x0005F0EC File Offset: 0x0005D2EC
	private string method_5()
	{
		return this.string_2;
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x0005F0F4 File Offset: 0x0005D2F4
	private void method_6(string string_6)
	{
		this.string_2 = string_6;
	}

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0005F100 File Offset: 0x0005D300
	// (set) Token: 0x060016E8 RID: 5864 RVA: 0x0005F108 File Offset: 0x0005D308
	public string CustomValue
	{
		get
		{
			return this.method_5();
		}
		set
		{
			if (value.Length < 8)
			{
				value = value.PadLeft(8, '0');
			}
			if (this.CurrentCustomValue == null)
			{
				this.CurrentCustomValue = value;
			}
			this.method_6(value);
			base.method_0("HasChanges");
			base.method_0("CustomValue");
			this.method_9();
			this.method_18();
		}
	}

	// Token: 0x1700033B RID: 827
	// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0005F164 File Offset: 0x0005D364
	// (set) Token: 0x060016EA RID: 5866 RVA: 0x0005F174 File Offset: 0x0005D374
	public bool IsEditable
	{
		get
		{
			return this.gclass179_0.IsEditable;
		}
		set
		{
			this.gclass179_0.IsEditable = value;
			base.method_0("IsEditable");
		}
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x0005F190 File Offset: 0x0005D390
	private void method_7()
	{
		Class745.Struct229 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class745_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class745.Struct229>(ref @struct);
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x0005F1C8 File Offset: 0x0005D3C8
	public void method_8(bool bool_6, bool bool_7)
	{
		Class745.Struct225 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class745_0 = this;
		@struct.bool_1 = bool_6;
		@struct.bool_0 = bool_7;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class745.Struct225>(ref @struct);
	}

	// Token: 0x060016ED RID: 5869 RVA: 0x0005F210 File Offset: 0x0005D410
	private void method_9()
	{
		Class745.Struct224 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class745_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class745.Struct224>(ref @struct);
	}

	// Token: 0x060016EE RID: 5870 RVA: 0x0005F248 File Offset: 0x0005D448
	private void method_10()
	{
		Class745.Struct223 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class745_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class745.Struct223>(ref @struct);
	}

	// Token: 0x060016EF RID: 5871 RVA: 0x0005F280 File Offset: 0x0005D480
	private void method_11()
	{
		if (this.AddToConfig)
		{
			GClass93.smethod_0().method_15(typeof(Class525), this.Name);
		}
	}

	// Token: 0x060016F0 RID: 5872 RVA: 0x0005F2A8 File Offset: 0x0005D4A8
	private JsonTweakArgument method_12()
	{
		return new JsonTweakArgument
		{
			NewTweakStatus = this.method_13(),
			CustomValue = this.CustomValue
		};
	}

	// Token: 0x060016F1 RID: 5873 RVA: 0x0005F2C8 File Offset: 0x0005D4C8
	public string method_13()
	{
		if (!(this.gclass179_0.Type == "DOUBLE") && !(this.gclass179_0.Type == "DEBLOAT"))
		{
			if (this.gclass179_0.Type == "MULTI")
			{
				int? selectedIndex = this.SelectedIndex;
				if (selectedIndex != null)
				{
					switch (selectedIndex.GetValueOrDefault())
					{
					case 0:
						return "DEFAULT";
					case 1:
						return "OPTIMAL";
					case 2:
						return "BEST";
					}
				}
				if (this.IsChecked != null && this.IsChecked.Value)
				{
					return "DEFAULT";
				}
				return "BEST";
			}
			else
			{
				if (this.gclass179_0.Type == "CUSTOM_VALUE")
				{
					int? selectedIndex = this.SelectedIndex;
					if (selectedIndex.GetValueOrDefault() == 3 & selectedIndex != null)
					{
						return "CUSTOM";
					}
					selectedIndex = this.SelectedIndex;
					if (selectedIndex != null)
					{
						switch (selectedIndex.GetValueOrDefault())
						{
						case 0:
							return "DEFAULT";
						case 1:
							return "OPTIMAL";
						case 2:
							return "BEST";
						}
					}
				}
				if (this.gclass179_0.Type == "IMPORT")
				{
					if (this.IsChecked != null && this.IsChecked.Value)
					{
						return "BEST";
					}
					return "DEFAULT";
				}
				else
				{
					if (this.gclass179_0.Type == "SCRIPT")
					{
						return "BEST";
					}
					throw new Exception("Неопределённый ValueType");
				}
			}
		}
		else if (!this.IsCheckReversed)
		{
			if (this.IsChecked != null && this.IsChecked.Value)
			{
				return "BEST";
			}
			return "DEFAULT";
		}
		else
		{
			if (this.IsChecked != null && this.IsChecked.Value)
			{
				return "DEFAULT";
			}
			return "BEST";
		}
	}

	// Token: 0x060016F2 RID: 5874 RVA: 0x0005F508 File Offset: 0x0005D708
	public void method_14()
	{
		if (this.gclass179_0.Type == "DOUBLE")
		{
			this.IsChecked = new bool?(!this.IsCheckReversed);
			return;
		}
		if (!(this.gclass179_0.Type == "MULTI") && !(this.gclass179_0.Type == "CUSTOM_VALUE"))
		{
			if (this.gclass179_0.Type == "IMPORT" && this.gclass179_0.method_5())
			{
				this.IsChecked = new bool?(true);
			}
			return;
		}
		this.SelectedIndex = new int?(2);
	}

	// Token: 0x060016F3 RID: 5875 RVA: 0x0005F5AC File Offset: 0x0005D7AC
	public void method_15()
	{
		if (this.gclass179_0.method_4())
		{
			if (this.gclass179_0.Type == "DOUBLE")
			{
				this.IsChecked = new bool?(!this.IsCheckReversed);
				return;
			}
			if (this.gclass179_0.Type == "MULTI" || this.gclass179_0.Type == "CUSTOM_VALUE")
			{
				this.SelectedIndex = new int?(1);
				return;
			}
			if (this.gclass179_0.Type == "IMPORT")
			{
				this.IsChecked = new bool?(true);
			}
		}
	}

	// Token: 0x060016F4 RID: 5876 RVA: 0x0005F658 File Offset: 0x0005D858
	public void method_16()
	{
		if (this.gclass179_0.Type == "DOUBLE")
		{
			this.IsChecked = new bool?(!this.gclass179_0.method_6());
			return;
		}
		if (this.gclass179_0.Type == "MULTI" || this.gclass179_0.Type == "CUSTOM_VALUE")
		{
			this.SelectedIndex = new int?(0);
		}
	}

	// Token: 0x060016F5 RID: 5877 RVA: 0x0005F6D0 File Offset: 0x0005D8D0
	public void method_17()
	{
		if (this.gclass179_0.Type == "DOUBLE")
		{
			this.IsChecked = this.CurrentStatusDouble;
			return;
		}
		if (this.gclass179_0.Type == "MULTI" || this.gclass179_0.Type == "CUSTOM_VALUE")
		{
			this.SelectedIndex = this.CurrentSelectedIndex;
		}
	}

	// Token: 0x1700033C RID: 828
	// (get) Token: 0x060016F6 RID: 5878 RVA: 0x0005F73C File Offset: 0x0005D93C
	public GClass134 ForceOn
	{
		get
		{
			return new GClass134(new Action<object>(this.method_28), null);
		}
	}

	// Token: 0x1700033D RID: 829
	// (get) Token: 0x060016F7 RID: 5879 RVA: 0x0005F750 File Offset: 0x0005D950
	public GClass134 ForceOff
	{
		get
		{
			return new GClass134(new Action<object>(this.method_29), null);
		}
	}

	// Token: 0x1700033E RID: 830
	// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0005F764 File Offset: 0x0005D964
	public GClass134 EditCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_30), null));
			}
			return result;
		}
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x0005F798 File Offset: 0x0005D998
	private void method_18()
	{
		Class745.Struct228 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class745_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class745.Struct228>(ref @struct);
	}

	// Token: 0x1700033F RID: 831
	// (get) Token: 0x060016FA RID: 5882 RVA: 0x0005F7D0 File Offset: 0x0005D9D0
	// (set) Token: 0x060016FB RID: 5883 RVA: 0x0005F7D8 File Offset: 0x0005D9D8
	public string StatusText
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x17000340 RID: 832
	// (get) Token: 0x060016FC RID: 5884 RVA: 0x0005F7EC File Offset: 0x0005D9EC
	// (set) Token: 0x060016FD RID: 5885 RVA: 0x0005F7F4 File Offset: 0x0005D9F4
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("StatusColor");
		}
	}

	// Token: 0x17000341 RID: 833
	// (get) Token: 0x060016FE RID: 5886 RVA: 0x0005F808 File Offset: 0x0005DA08
	// (set) Token: 0x060016FF RID: 5887 RVA: 0x0005F810 File Offset: 0x0005DA10
	public double StatusOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06001700 RID: 5888 RVA: 0x0005F824 File Offset: 0x0005DA24
	private void method_19(string string_6, SolidColorBrush solidColorBrush_1)
	{
		Class745.Struct231 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class745_0 = this;
		@struct.string_0 = string_6;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class745.Struct231>(ref @struct);
	}

	// Token: 0x17000342 RID: 834
	// (get) Token: 0x06001701 RID: 5889 RVA: 0x0005F86C File Offset: 0x0005DA6C
	// (set) Token: 0x06001702 RID: 5890 RVA: 0x0005F89C File Offset: 0x0005DA9C
	public string NameB
	{
		get
		{
			if (this.string_4.smethod_7())
			{
				this.string_4 = (this.Name ?? Class364.smethod_0("EnterName"));
			}
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
			base.method_0("NameB");
		}
	}

	// Token: 0x17000343 RID: 835
	// (get) Token: 0x06001703 RID: 5891 RVA: 0x0005F8B0 File Offset: 0x0005DAB0
	// (set) Token: 0x06001704 RID: 5892 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
	public string DescB
	{
		get
		{
			if (this.string_5.smethod_7())
			{
				this.string_5 = (this.Description ?? Class364.smethod_0("EnterDesc"));
			}
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
			base.method_0("DescB");
		}
	}

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x06001705 RID: 5893 RVA: 0x0005F8F4 File Offset: 0x0005DAF4
	public ObservableCollection<MaterialIconKind> AllIcons
	{
		get
		{
			if (!this.OnEdit)
			{
				return null;
			}
			return Class397.smethod_6();
		}
	}

	// Token: 0x17000345 RID: 837
	// (get) Token: 0x06001706 RID: 5894 RVA: 0x0005F908 File Offset: 0x0005DB08
	// (set) Token: 0x06001707 RID: 5895 RVA: 0x0005F910 File Offset: 0x0005DB10
	public MaterialIconKind IconB
	{
		get
		{
			return this.materialIconKind_1;
		}
		set
		{
			this.materialIconKind_1 = value;
			base.method_0("IconB");
		}
	}

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x06001708 RID: 5896 RVA: 0x0005F924 File Offset: 0x0005DB24
	// (set) Token: 0x06001709 RID: 5897 RVA: 0x0005F92C File Offset: 0x0005DB2C
	public bool ChoosingIcon
	{
		get
		{
			return this.bool_5;
		}
		set
		{
			this.bool_5 = value;
			base.method_0("ChoosingIcon");
			base.method_0("AllIcons");
		}
	}

	// Token: 0x17000347 RID: 839
	// (get) Token: 0x0600170A RID: 5898 RVA: 0x0005F94C File Offset: 0x0005DB4C
	// (set) Token: 0x0600170B RID: 5899 RVA: 0x0005F99C File Offset: 0x0005DB9C
	public bool? IsScript
	{
		get
		{
			bool value = this.nullable_5.GetValueOrDefault();
			if (this.nullable_5 == null)
			{
				value = (this.gclass179_0.Type == "SCRIPT");
				this.nullable_5 = new bool?(value);
			}
			return this.nullable_5;
		}
		set
		{
			this.nullable_5 = value;
			base.method_0("IsScript");
		}
	}

	// Token: 0x17000348 RID: 840
	// (get) Token: 0x0600170C RID: 5900 RVA: 0x0005F9B0 File Offset: 0x0005DBB0
	public GClass134 ChangeIcon
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_1) == null)
			{
				result = (this.gclass134_1 = new GClass134(new Action<object>(this.method_32), null));
			}
			return result;
		}
	}

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x0600170D RID: 5901 RVA: 0x0005F9E4 File Offset: 0x0005DBE4
	public GClass134 IconChangeRequest
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_2) == null)
			{
				result = (this.gclass134_2 = new GClass134(new Action<object>(this.method_33), null));
			}
			return result;
		}
	}

	// Token: 0x1700034A RID: 842
	// (get) Token: 0x0600170E RID: 5902 RVA: 0x0005FA18 File Offset: 0x0005DC18
	public GClass134 CancelEditCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_3) == null)
			{
				result = (this.gclass134_3 = new GClass134(new Action<object>(this.method_34), null));
			}
			return result;
		}
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x0005FA4C File Offset: 0x0005DC4C
	public void method_20(Class751 class751_0)
	{
		this.TweakStepsScript.Remove(class751_0);
		this.TweakStepsDouble.Remove(class751_0);
		base.method_0("TweakStepsScript");
		base.method_0("TweakStepsDouble");
	}

	// Token: 0x1700034B RID: 843
	// (get) Token: 0x06001710 RID: 5904 RVA: 0x0005FA80 File Offset: 0x0005DC80
	// (set) Token: 0x06001711 RID: 5905 RVA: 0x0005FB70 File Offset: 0x0005DD70
	public ObservableCollection<Class751> TweakStepsScript
	{
		get
		{
			if (!this.IsEditable)
			{
				return this.observableCollection_1;
			}
			if (this.observableCollection_1.Count<Class751>() == 0 && this.gclass179_0.Type == "SCRIPT" && this.jsonTweakStepDtos.Count<GClass67>() > 0)
			{
				this.observableCollection_1.Add(new Class751(this.jsonTweakStepDtos.First(new Func<GClass67, bool>(Class745.Class480.class480_0.method_2)), this));
			}
			else
			{
				this.observableCollection_1.Add(new Class751(new GClass67
				{
					String_0 = "SCRIPT",
					Values = new List<GClass72>
					{
						new GClass72
						{
							List_0 = new List<string>
							{
								"BEST"
							},
							String_0 = Class364.smethod_0("EnterScriptHere")
						}
					}
				}, this));
			}
			return this.observableCollection_1;
		}
		set
		{
			this.observableCollection_1 = value;
			base.method_0("TweakStepsScript");
		}
	}

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x06001712 RID: 5906 RVA: 0x0005FB84 File Offset: 0x0005DD84
	// (set) Token: 0x06001713 RID: 5907 RVA: 0x0005FC2C File Offset: 0x0005DE2C
	public ObservableCollection<Class751> TweakStepsDouble
	{
		get
		{
			if (!this.IsEditable)
			{
				return this.observableCollection_1;
			}
			if (this.observableCollection_2.Count<Class751>() == 0 && this.jsonTweakStepDtos.Count<GClass67>() > 0 && this.gclass179_0.Type == "DOUBLE")
			{
				foreach (GClass67 gclass67_ in this.jsonTweakStepDtos)
				{
					this.observableCollection_2.Add(new Class751(gclass67_, this));
				}
			}
			return this.observableCollection_2;
		}
		set
		{
			this.observableCollection_2 = value;
			base.method_0("TweakStepsDouble");
		}
	}

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x06001714 RID: 5908 RVA: 0x0005FC40 File Offset: 0x0005DE40
	public GClass134 AddRegistry
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_4) == null)
			{
				result = (this.gclass134_4 = new GClass134(new Action<object>(this.method_35), null));
			}
			return result;
		}
	}

	// Token: 0x1700034E RID: 846
	// (get) Token: 0x06001715 RID: 5909 RVA: 0x0005FC74 File Offset: 0x0005DE74
	public GClass134 AddTask
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_5) == null)
			{
				result = (this.gclass134_5 = new GClass134(new Action<object>(this.method_36), null));
			}
			return result;
		}
	}

	// Token: 0x1700034F RID: 847
	// (get) Token: 0x06001716 RID: 5910 RVA: 0x0005FCA8 File Offset: 0x0005DEA8
	public GClass134 AddBcdedit
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_6) == null)
			{
				result = (this.gclass134_6 = new GClass134(new Action<object>(this.method_37), null));
			}
			return result;
		}
	}

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x06001717 RID: 5911 RVA: 0x0005FCDC File Offset: 0x0005DEDC
	public GClass134 AddDevice
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_7) == null)
			{
				result = (this.gclass134_7 = new GClass134(new Action<object>(this.method_38), null));
			}
			return result;
		}
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x0005FD10 File Offset: 0x0005DF10
	public void method_21()
	{
		this.gclass179_0.Name = this.NameB;
		this.gclass179_0.Description = this.DescB;
		this.gclass179_0.List_4.Clear();
		if (this.materialIconKind_1 != 2639)
		{
			this.gclass179_0.String_2 = this.materialIconKind_1.ToString();
		}
		bool? isScript = this.IsScript;
		if (isScript.GetValueOrDefault() & isScript != null)
		{
			foreach (Class751 @class in this.TweakStepsScript)
			{
				this.gclass179_0.List_4.Add(@class.gclass67_0);
			}
		}
		isScript = this.IsScript;
		if (!isScript.GetValueOrDefault() & isScript != null)
		{
			foreach (Class751 class2 in this.TweakStepsDouble)
			{
				this.gclass179_0.List_4.Add(class2.gclass67_0);
			}
		}
		base.method_0("Name");
		base.method_0("Description");
		base.method_0("jsonTweakStepDtos");
		foreach (GClass67 gclass in this.jsonTweakStepDtos)
		{
			base.method_0("Key");
			base.method_0("Path");
			foreach (GClass72 gclass2 in gclass.Values)
			{
				base.method_0("Value");
			}
		}
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x0005FF38 File Offset: 0x0005E138
	internal void method_22()
	{
		base.method_0("OnPropertyChangedForce");
	}

	// Token: 0x0600171A RID: 5914 RVA: 0x0005FF48 File Offset: 0x0005E148
	private void method_23()
	{
		bool? flag = Class389.class504_0.method_54();
		if (!(flag.GetValueOrDefault() & flag != null))
		{
			return;
		}
		if (this.gclass179_0.List_1.Contains("W11"))
		{
			flag = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_0;
			if (flag.GetValueOrDefault() & flag != null)
			{
				this.W11Visibility = Visibility.Visible;
			}
		}
		if (this.gclass179_0.List_1.Contains("W10"))
		{
			flag = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_1;
			if (flag.GetValueOrDefault() & flag != null)
			{
				this.W10Visibility = Visibility.Visible;
			}
		}
		if (this.gclass179_0.List_1.Contains("LAPTOP"))
		{
			flag = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_2;
			if (flag.GetValueOrDefault() & flag != null)
			{
				this.LAPVisibility = Visibility.Visible;
			}
		}
		if (this.gclass179_0.List_1.Contains("PC"))
		{
			flag = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_2;
			if (!flag.GetValueOrDefault() & flag != null)
			{
				this.PCVisibility = Visibility.Visible;
			}
		}
		if (this.gclass179_0.List_1.Contains("AMD"))
		{
			flag = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_3;
			if (!flag.GetValueOrDefault() & flag != null)
			{
				this.AMDVisibility = Visibility.Visible;
			}
		}
	}

	// Token: 0x0600171B RID: 5915 RVA: 0x00060090 File Offset: 0x0005E290
	private void method_24()
	{
		DismFeatureInfo dismFeatureInfo = Class203.smethod_7(this.NameRawIcon);
		if (!dismFeatureInfo.DisplayName.smethod_7() && !dismFeatureInfo.Description.smethod_7())
		{
			this.gclass179_0.Name = dismFeatureInfo.DisplayName;
			this.gclass179_0.Description = dismFeatureInfo.Description;
			base.method_0("Name");
			base.method_0("Description");
			return;
		}
		this.gclass179_0.Name = this.NameRawIcon;
		base.method_0("Name");
	}

	// Token: 0x0600171C RID: 5916 RVA: 0x00060118 File Offset: 0x0005E318
	private void method_25()
	{
		if (this.gclass179_0.String_2 != null && this.gclass179_0.String_2 != string.Empty && this.gclass179_0.String_2 != "CHANGE")
		{
			Class745.Class477 @class = new Class745.Class477();
			@class.string_0 = string.Empty;
			this.gclass179_0.String_2.Split(new char[]
			{
				'-'
			}).ToList<string>().ForEach(new Action<string>(@class.method_0));
			MaterialIconKind icon;
			if (Enum.TryParse<MaterialIconKind>(@class.string_0, out icon))
			{
				this.Icon = icon;
			}
		}
		MaterialIconKind icon2 = 0;
		if (!this.gclass179_0.String_0.smethod_7() && Class570.dictionary_0.TryGetValue(this.gclass179_0.String_0, out icon2))
		{
			this.Icon = icon2;
		}
	}

	// Token: 0x0600171D RID: 5917 RVA: 0x000601F0 File Offset: 0x0005E3F0
	private void method_26()
	{
		if ((this.Childs.Count > 0 || this.list_0.Count > 0) && this.bool_0)
		{
			if (this.IsChecked.Value)
			{
				this.Childs.smethod_0(new Action<Class745>(Class745.Class480.class480_0.method_0));
			}
			else
			{
				this.list_0.ForEach(new Action<Class745>(Class745.Class480.class480_0.method_1));
			}
		}
		if (!this.HasChanges)
		{
			this.method_11();
			return;
		}
		this.method_10();
	}

	// Token: 0x0600171E RID: 5918 RVA: 0x000602B8 File Offset: 0x0005E4B8
	private Class525 method_27()
	{
		return this.class525_0;
	}

	// Token: 0x0600171F RID: 5919 RVA: 0x000602C0 File Offset: 0x0005E4C0
	private void method_28(object object_0)
	{
		if (this.gclass179_0.Type != "DOUBLE")
		{
			return;
		}
		this.CurrentStatusDouble = new bool?(true);
		this.IsChecked = new bool?(false);
	}

	// Token: 0x06001720 RID: 5920 RVA: 0x000602F4 File Offset: 0x0005E4F4
	private void method_29(object object_0)
	{
		if (this.gclass179_0.Type != "DOUBLE")
		{
			return;
		}
		this.CurrentStatusDouble = new bool?(false);
		this.IsChecked = new bool?(true);
	}

	// Token: 0x06001721 RID: 5921 RVA: 0x00060328 File Offset: 0x0005E528
	private void method_30(object object_0)
	{
		if (this.IsEditable && Class585.struct13_0.method_0())
		{
			this.OnEdit = true;
			base.method_0("EditCommand");
			return;
		}
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x00060354 File Offset: 0x0005E554
	private void method_31()
	{
		if (this.TmType != "IMPORT" && this.TmType != "DEBLOAT" && this.TmType != "SCRIPT")
		{
			if (this.HasChanges && this.IsCheckReversed)
			{
				bool? isChecked = this.IsChecked;
				if (!isChecked.GetValueOrDefault() & isChecked != null)
				{
					this.method_19(Class364.smethod_0("willbeenabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				}
			}
			if (this.HasChanges && this.IsCheckReversed)
			{
				bool? isChecked = this.IsChecked;
				if (isChecked.GetValueOrDefault() & isChecked != null)
				{
					this.method_19(Class364.smethod_0("willbedisabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
				}
			}
			if (!this.HasChanges && this.IsCheckReversed)
			{
				bool? isChecked = this.IsChecked;
				if (!isChecked.GetValueOrDefault() & isChecked != null)
				{
					this.method_19(Class364.smethod_0("enabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				}
			}
			if (!this.HasChanges && this.IsCheckReversed)
			{
				bool? isChecked = this.IsChecked;
				if (isChecked.GetValueOrDefault() & isChecked != null)
				{
					this.method_19(Class364.smethod_0("disabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
				}
			}
			if (this.HasChanges && !this.IsCheckReversed)
			{
				bool? isChecked = this.IsChecked;
				if (!isChecked.GetValueOrDefault() & isChecked != null)
				{
					this.method_19(Class364.smethod_0("willbeenabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
				}
			}
			if (this.HasChanges && !this.IsCheckReversed)
			{
				bool? isChecked = this.IsChecked;
				if (isChecked.GetValueOrDefault() & isChecked != null)
				{
					this.method_19(Class364.smethod_0("willbedisabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				}
			}
			if (!this.HasChanges && !this.IsCheckReversed)
			{
				bool? isChecked = this.IsChecked;
				if (!isChecked.GetValueOrDefault() & isChecked != null)
				{
					this.method_19(Class364.smethod_0("enabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
				}
			}
			if (!this.HasChanges && !this.IsCheckReversed)
			{
				bool? isChecked = this.IsChecked;
				if (isChecked.GetValueOrDefault() & isChecked != null)
				{
					this.method_19(Class364.smethod_0("disabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				}
			}
			if (!this.HasChanges && this.IsChecked == null)
			{
				this.method_19(" ", dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
			if (this.HasChanges && this.IsChecked == null)
			{
				this.method_19(Class364.smethod_0("willbechanged"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
		}
		if (this.TmType == "DEBLOAT" && !this.HasChanges)
		{
			bool? isChecked = this.IsChecked;
			if (isChecked.GetValueOrDefault() & isChecked != null)
			{
				this.method_19(" ", dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
		}
		if (this.TmType == "DEBLOAT" && !this.HasChanges)
		{
			bool? isChecked = this.IsChecked;
			if (!isChecked.GetValueOrDefault() & isChecked != null)
			{
				this.method_19(" ", dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
		}
		if (this.TmType == "DEBLOAT" && this.HasChanges)
		{
			bool? isChecked = this.IsChecked;
			if (isChecked.GetValueOrDefault() & isChecked != null)
			{
				this.method_19(Class364.smethod_0("willbedeleted"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
		}
		if (this.TmType == "IMPORT" && !this.HasChanges)
		{
			bool? isChecked = this.IsChecked;
			if (isChecked.GetValueOrDefault() & isChecked != null)
			{
				this.method_19(" ", dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
		}
		if (this.TmType == "IMPORT" && !this.HasChanges)
		{
			bool? isChecked = this.IsChecked;
			if (!isChecked.GetValueOrDefault() & isChecked != null)
			{
				this.method_19(" ", dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
		}
		if (this.TmType == "IMPORT" && this.HasChanges)
		{
			bool? isChecked = this.IsChecked;
			if (isChecked.GetValueOrDefault() & isChecked != null)
			{
				this.method_19(Class364.smethod_0("ProfileWillBeImported"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
		}
		if (this.TmType == "SCRIPT" && !this.HasChanges)
		{
			bool? isChecked = this.IsChecked;
			if (isChecked.GetValueOrDefault() & isChecked != null)
			{
				this.method_19(" ", dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
		}
		if (this.TmType == "SCRIPT" && !this.HasChanges)
		{
			bool? isChecked = this.IsChecked;
			if (!isChecked.GetValueOrDefault() & isChecked != null)
			{
				this.method_19(" ", dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
		}
		if (this.TmType == "SCRIPT" && this.HasChanges)
		{
			bool? isChecked = this.IsChecked;
			if (isChecked.GetValueOrDefault() & isChecked != null)
			{
				this.method_19(Class364.smethod_0("WillBeExecuted"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
		}
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x00060874 File Offset: 0x0005EA74
	private void method_32(object object_0)
	{
		this.ChoosingIcon = true;
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x00060880 File Offset: 0x0005EA80
	private void method_33(object object_0)
	{
		if (object_0 is MaterialIconKind)
		{
			this.IconB = (MaterialIconKind)object_0;
			this.ChoosingIcon = false;
		}
	}

	// Token: 0x06001725 RID: 5925 RVA: 0x000608A0 File Offset: 0x0005EAA0
	private void method_34(object object_0)
	{
		this.OnEdit = false;
		this.string_4 = null;
		this.string_5 = null;
		this.nullable_5 = null;
		this.observableCollection_1 = null;
		this.observableCollection_1 = new ObservableCollection<Class751>();
		this.observableCollection_2 = null;
		this.observableCollection_2 = new ObservableCollection<Class751>();
	}

	// Token: 0x06001726 RID: 5926 RVA: 0x000608F4 File Offset: 0x0005EAF4
	private void method_35(object object_0)
	{
		this.TweakStepsDouble.Add(new Class751(new GClass67
		{
			String_0 = "REG",
			Path = Class364.smethod_0("EnterRegPath"),
			Key = Class364.smethod_0("EnterRegKey"),
			Values = new List<GClass72>
			{
				new GClass72
				{
					List_0 = new List<string>
					{
						"DEFAULT"
					},
					String_0 = Class364.smethod_0("EnterDefaultRegValue")
				},
				new GClass72
				{
					List_0 = new List<string>
					{
						"BEST"
					},
					String_0 = Class364.smethod_0("EnterBestRegValue")
				}
			}
		}, this));
		base.method_0("TweakStepsDouble");
	}

	// Token: 0x06001727 RID: 5927 RVA: 0x000609BC File Offset: 0x0005EBBC
	private void method_36(object object_0)
	{
		this.TweakStepsDouble.Add(new Class751(new GClass67
		{
			String_0 = "TASK",
			Path = Class364.smethod_0("EnterTaskPath"),
			Values = new List<GClass72>
			{
				new GClass72
				{
					List_0 = new List<string>
					{
						"DEFAULT"
					},
					String_0 = "Enable"
				},
				new GClass72
				{
					List_0 = new List<string>
					{
						"BEST"
					},
					String_0 = "Disable"
				}
			}
		}, this));
		base.method_0("TweakStepsDouble");
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x00060A68 File Offset: 0x0005EC68
	private void method_37(object object_0)
	{
		this.TweakStepsDouble.Add(new Class751(new GClass67
		{
			String_0 = "BCDEDIT",
			Path = Class364.smethod_0("EnterBcdeditPath"),
			Values = new List<GClass72>
			{
				new GClass72
				{
					List_0 = new List<string>
					{
						"DEFAULT"
					},
					String_0 = Class364.smethod_0("EnterDefaultRegValue")
				},
				new GClass72
				{
					List_0 = new List<string>
					{
						"BEST"
					},
					String_0 = Class364.smethod_0("EnterBestRegValue")
				}
			}
		}, this));
		base.method_0("TweakStepsDouble");
	}

	// Token: 0x06001729 RID: 5929 RVA: 0x00060B20 File Offset: 0x0005ED20
	private void method_38(object object_0)
	{
		this.TweakStepsDouble.Add(new Class751(new GClass67
		{
			String_0 = "DEVICE",
			Path = Class364.smethod_0("EnterDevicePath"),
			Values = new List<GClass72>
			{
				new GClass72
				{
					List_0 = new List<string>
					{
						"DEFAULT"
					},
					String_0 = "Enable"
				},
				new GClass72
				{
					List_0 = new List<string>
					{
						"BEST"
					},
					String_0 = "Disable"
				}
			}
		}, this));
		base.method_0("TweakStepsDouble");
	}

	// Token: 0x0400102E RID: 4142
	private readonly GClass179 gclass179_0;

	// Token: 0x0400102F RID: 4143
	private Class525 class525_0;

	// Token: 0x04001030 RID: 4144
	public bool bool_0;

	// Token: 0x04001031 RID: 4145
	public List<Class745> list_0 = new List<Class745>();

	// Token: 0x04001032 RID: 4146
	private ObservableCollection<Class745> observableCollection_0 = new ObservableCollection<Class745>();

	// Token: 0x04001033 RID: 4147
	private MaterialIconKind materialIconKind_0;

	// Token: 0x04001034 RID: 4148
	private string string_0;

	// Token: 0x04001035 RID: 4149
	private bool? nullable_0;

	// Token: 0x04001036 RID: 4150
	private bool bool_1;

	// Token: 0x04001037 RID: 4151
	private bool bool_2;

	// Token: 0x04001038 RID: 4152
	private bool bool_3;

	// Token: 0x04001039 RID: 4153
	private Visibility visibility_0 = Visibility.Collapsed;

	// Token: 0x0400103A RID: 4154
	private Visibility visibility_1 = Visibility.Collapsed;

	// Token: 0x0400103B RID: 4155
	private Visibility visibility_2 = Visibility.Collapsed;

	// Token: 0x0400103C RID: 4156
	private Visibility visibility_3 = Visibility.Collapsed;

	// Token: 0x0400103D RID: 4157
	private Visibility visibility_4 = Visibility.Collapsed;

	// Token: 0x0400103E RID: 4158
	private Visibility visibility_5 = Visibility.Collapsed;

	// Token: 0x0400103F RID: 4159
	private Visibility visibility_6 = Visibility.Collapsed;

	// Token: 0x04001040 RID: 4160
	private Visibility visibility_7 = Visibility.Collapsed;

	// Token: 0x04001041 RID: 4161
	private Visibility visibility_8 = Visibility.Collapsed;

	// Token: 0x04001042 RID: 4162
	private Visibility visibility_9 = Visibility.Collapsed;

	// Token: 0x04001043 RID: 4163
	private Visibility visibility_10 = Visibility.Collapsed;

	// Token: 0x04001044 RID: 4164
	private Visibility visibility_11 = Visibility.Collapsed;

	// Token: 0x04001045 RID: 4165
	private Visibility visibility_12 = Visibility.Collapsed;

	// Token: 0x04001046 RID: 4166
	private Visibility visibility_13 = Visibility.Collapsed;

	// Token: 0x04001047 RID: 4167
	private bool bool_4;

	// Token: 0x04001048 RID: 4168
	private bool? nullable_1;

	// Token: 0x04001049 RID: 4169
	private bool? nullable_2;

	// Token: 0x0400104A RID: 4170
	private int? nullable_3;

	// Token: 0x0400104B RID: 4171
	private int? nullable_4;

	// Token: 0x0400104C RID: 4172
	private string string_1;

	// Token: 0x0400104D RID: 4173
	private string string_2;

	// Token: 0x0400104E RID: 4174
	private GClass134 gclass134_0;

	// Token: 0x0400104F RID: 4175
	private string string_3 = string.Empty;

	// Token: 0x04001050 RID: 4176
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x04001051 RID: 4177
	private double double_0;

	// Token: 0x04001052 RID: 4178
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x04001053 RID: 4179
	private string string_4;

	// Token: 0x04001054 RID: 4180
	private string string_5;

	// Token: 0x04001055 RID: 4181
	private MaterialIconKind materialIconKind_1 = 2639;

	// Token: 0x04001056 RID: 4182
	private bool bool_5;

	// Token: 0x04001057 RID: 4183
	private bool? nullable_5;

	// Token: 0x04001058 RID: 4184
	private GClass134 gclass134_1;

	// Token: 0x04001059 RID: 4185
	private GClass134 gclass134_2;

	// Token: 0x0400105A RID: 4186
	private GClass134 gclass134_3;

	// Token: 0x0400105B RID: 4187
	private ObservableCollection<Class751> observableCollection_1 = new ObservableCollection<Class751>();

	// Token: 0x0400105C RID: 4188
	private ObservableCollection<Class751> observableCollection_2 = new ObservableCollection<Class751>();

	// Token: 0x0400105D RID: 4189
	public GClass134 gclass134_4;

	// Token: 0x0400105E RID: 4190
	public GClass134 gclass134_5;

	// Token: 0x0400105F RID: 4191
	public GClass134 gclass134_6;

	// Token: 0x04001060 RID: 4192
	public GClass134 gclass134_7;

	// Token: 0x02000414 RID: 1044
	[StructLayout(LayoutKind.Auto)]
	private struct Struct223 : IAsyncStateMachine
	{
		// Token: 0x0600172A RID: 5930 RVA: 0x00060BCC File Offset: 0x0005EDCC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class745 @class = this.class745_0;
			try
			{
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_183;
					}
					if (!@class.AddToConfig)
					{
						goto IL_26C;
					}
					if (@class.gclass179_0.List_3 == null || @class.gclass179_0.List_3.Count <= 0 || @class.IsChecked.Value)
					{
						goto IL_133;
					}
					this.enumerator_0 = @class.gclass179_0.List_3.GetEnumerator();
				}
				try
				{
					if (num != 0)
					{
						goto IL_B4;
					}
					TaskAwaiter<Class745> awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class745>);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					IL_9A:
					Class745 result = awaiter.GetResult();
					if (result != null)
					{
						result.ForceOn.Execute(null);
					}
					IL_B4:
					if (this.enumerator_0.MoveNext())
					{
						awaiter = Class588.smethod_8(this.enumerator_0.Current).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.int_0 = num3;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class745>, Class745.Struct223>(ref awaiter, ref this);
							return;
						}
						goto IL_9A;
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)this.enumerator_0).Dispose();
					}
				}
				this.enumerator_0 = default(List<string>.Enumerator);
				IL_133:
				if (@class.gclass179_0.List_2 == null || @class.gclass179_0.List_2.Count <= 0 || !@class.IsChecked.Value)
				{
					goto IL_249;
				}
				this.enumerator_0 = @class.gclass179_0.List_2.GetEnumerator();
				try
				{
					IL_183:
					if (num != 1)
					{
						goto IL_1CA;
					}
					TaskAwaiter<Class745> awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class745>);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
					IL_1AD:
					Class745 result2 = awaiter.GetResult();
					if (result2 != null)
					{
						result2.ForceOff.Execute(null);
					}
					IL_1CA:
					if (this.enumerator_0.MoveNext())
					{
						awaiter = Class588.smethod_8(this.enumerator_0.Current).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.int_0 = num5;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class745>, Class745.Struct223>(ref awaiter, ref this);
							return;
						}
						goto IL_1AD;
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)this.enumerator_0).Dispose();
					}
				}
				this.enumerator_0 = default(List<string>.Enumerator);
				IL_249:
				GClass93.smethod_0().method_9<Class525>(@class.Name, new Func<Class525>(@class.method_27), @class.method_12());
				IL_26C:;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00060EC8 File Offset: 0x0005F0C8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001061 RID: 4193
		public int int_0;

		// Token: 0x04001062 RID: 4194
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001063 RID: 4195
		public Class745 class745_0;

		// Token: 0x04001064 RID: 4196
		private List<string>.Enumerator enumerator_0;

		// Token: 0x04001065 RID: 4197
		private TaskAwaiter<Class745> taskAwaiter_0;
	}

	// Token: 0x02000415 RID: 1045
	[StructLayout(LayoutKind.Auto)]
	private struct Struct224 : IAsyncStateMachine
	{
		// Token: 0x0600172C RID: 5932 RVA: 0x00060ED8 File Offset: 0x0005F0D8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class745 @object = this.class745_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_26)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class745.Struct224>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00060F98 File Offset: 0x0005F198
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001066 RID: 4198
		public int int_0;

		// Token: 0x04001067 RID: 4199
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001068 RID: 4200
		public Class745 class745_0;

		// Token: 0x04001069 RID: 4201
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000416 RID: 1046
	[StructLayout(LayoutKind.Auto)]
	private struct Struct225 : IAsyncStateMachine
	{
		// Token: 0x0600172E RID: 5934 RVA: 0x00060FA8 File Offset: 0x0005F1A8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new Class745.Class481
					{
						class745_0 = this.class745_0,
						bool_0 = this.bool_0,
						bool_1 = this.bool_1
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class745.Struct225>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00061088 File Offset: 0x0005F288
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400106A RID: 4202
		public int int_0;

		// Token: 0x0400106B RID: 4203
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400106C RID: 4204
		public Class745 class745_0;

		// Token: 0x0400106D RID: 4205
		public bool bool_0;

		// Token: 0x0400106E RID: 4206
		public bool bool_1;

		// Token: 0x0400106F RID: 4207
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000417 RID: 1047
	private sealed class Class477
	{
		// Token: 0x06001731 RID: 5937 RVA: 0x000610A0 File Offset: 0x0005F2A0
		internal void method_0(string string_1)
		{
			this.string_0 += string_1.smethod_3();
		}

		// Token: 0x04001070 RID: 4208
		public string string_0;
	}

	// Token: 0x02000418 RID: 1048
	private sealed class Class478
	{
		// Token: 0x06001733 RID: 5939 RVA: 0x000610C4 File Offset: 0x0005F2C4
		internal Task method_0()
		{
			Class745.Class478.Struct226 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class478_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class745.Class478.Struct226>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001071 RID: 4209
		public Class745 class745_0;

		// Token: 0x04001072 RID: 4210
		public CancellationToken cancellationToken_0;

		// Token: 0x04001073 RID: 4211
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001074 RID: 4212
		public string string_0;

		// Token: 0x02000419 RID: 1049
		[StructLayout(LayoutKind.Auto)]
		private struct Struct226 : IAsyncStateMachine
		{
			// Token: 0x06001734 RID: 5940 RVA: 0x00061108 File Offset: 0x0005F308
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class745.Class478 @class = this.class478_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_B4;
					}
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_188;
					}
					IL_3E:
					if (@class.class745_0.StatusOpacity <= 0.0 || @class.cancellationToken_0.IsCancellationRequested)
					{
						@class.class745_0.StatusColor = @class.solidColorBrush_0;
						@class.class745_0.StatusText = @class.string_0;
						goto IL_18F;
					}
					@class.class745_0.StatusOpacity = Math.Max(0.0, @class.class745_0.StatusOpacity - 0.2);
					awaiter = Task.Delay(16, @class.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class745.Class478.Struct226>(ref awaiter, ref this);
						return;
					}
					IL_B4:
					awaiter.GetResult();
					goto IL_3E;
					IL_188:
					awaiter.GetResult();
					IL_18F:
					if (@class.class745_0.StatusOpacity < 1.0 && !@class.cancellationToken_0.IsCancellationRequested)
					{
						@class.class745_0.StatusOpacity = Math.Min(1.0, @class.class745_0.StatusOpacity + 0.2);
						awaiter = Task.Delay(16, @class.cancellationToken_0).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_188;
						}
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class745.Class478.Struct226>(ref awaiter, ref this);
						return;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06001735 RID: 5941 RVA: 0x00061334 File Offset: 0x0005F534
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001075 RID: 4213
			public int int_0;

			// Token: 0x04001076 RID: 4214
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001077 RID: 4215
			public Class745.Class478 class478_0;

			// Token: 0x04001078 RID: 4216
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x0200041A RID: 1050
	[StructLayout(LayoutKind.Auto)]
	private struct Struct227 : IAsyncStateMachine
	{
		// Token: 0x06001736 RID: 5942 RVA: 0x00061344 File Offset: 0x0005F544
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class745 @object = this.class745_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_24)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class745.Struct227>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00061404 File Offset: 0x0005F604
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001079 RID: 4217
		public int int_0;

		// Token: 0x0400107A RID: 4218
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400107B RID: 4219
		public Class745 class745_0;

		// Token: 0x0400107C RID: 4220
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200041B RID: 1051
	[StructLayout(LayoutKind.Auto)]
	private struct Struct228 : IAsyncStateMachine
	{
		// Token: 0x06001738 RID: 5944 RVA: 0x00061414 File Offset: 0x0005F614
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class745 @object = this.class745_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_31)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class745.Struct228>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x000614D4 File Offset: 0x0005F6D4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400107D RID: 4221
		public int int_0;

		// Token: 0x0400107E RID: 4222
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400107F RID: 4223
		public Class745 class745_0;

		// Token: 0x04001080 RID: 4224
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200041C RID: 1052
	private sealed class Class479
	{
		// Token: 0x0600173B RID: 5947 RVA: 0x000614EC File Offset: 0x0005F6EC
		internal void method_0(GClass67 gclass67_0)
		{
			this.list_0.Add(new Class658(gclass67_0, this.class745_0.ShowIncluded));
		}

		// Token: 0x04001081 RID: 4225
		public List<Class658> list_0;

		// Token: 0x04001082 RID: 4226
		public Class745 class745_0;
	}

	// Token: 0x0200041D RID: 1053
	[Serializable]
	private sealed class Class480
	{
		// Token: 0x0600173E RID: 5950 RVA: 0x00061520 File Offset: 0x0005F720
		internal void method_0(Class745 class745_0)
		{
			class745_0.IsChecked = new bool?(true);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00061530 File Offset: 0x0005F730
		internal void method_1(Class745 class745_0)
		{
			class745_0.IsChecked = new bool?(false);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00061540 File Offset: 0x0005F740
		internal bool method_2(GClass67 gclass67_0)
		{
			return gclass67_0.String_0 == "SCRIPT";
		}

		// Token: 0x04001083 RID: 4227
		public static readonly Class745.Class480 class480_0 = new Class745.Class480();

		// Token: 0x04001084 RID: 4228
		public static Action<Class745> action_0;

		// Token: 0x04001085 RID: 4229
		public static Action<Class745> action_1;

		// Token: 0x04001086 RID: 4230
		public static Func<GClass67, bool> func_0;
	}

	// Token: 0x0200041E RID: 1054
	[StructLayout(LayoutKind.Auto)]
	private struct Struct229 : IAsyncStateMachine
	{
		// Token: 0x06001741 RID: 5953 RVA: 0x00061554 File Offset: 0x0005F754
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class745 @object = this.class745_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_25)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class745.Struct229>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00061614 File Offset: 0x0005F814
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001087 RID: 4231
		public int int_0;

		// Token: 0x04001088 RID: 4232
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001089 RID: 4233
		public Class745 class745_0;

		// Token: 0x0400108A RID: 4234
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200041F RID: 1055
	[StructLayout(LayoutKind.Auto)]
	private struct Struct230 : IAsyncStateMachine
	{
		// Token: 0x06001743 RID: 5955 RVA: 0x00061624 File Offset: 0x0005F824
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class745 @object = this.class745_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_23)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class745.Struct230>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x000616E4 File Offset: 0x0005F8E4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400108B RID: 4235
		public int int_0;

		// Token: 0x0400108C RID: 4236
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400108D RID: 4237
		public Class745 class745_0;

		// Token: 0x0400108E RID: 4238
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000420 RID: 1056
	private sealed class Class481
	{
		// Token: 0x06001746 RID: 5958 RVA: 0x000616FC File Offset: 0x0005F8FC
		internal void method_0()
		{
			this.class745_0.CurrentStatusDouble = null;
			this.class745_0.CurrentValueType = (this.bool_0 ? Class491.smethod_8(this.class745_0.NameRawIcon, this.class745_0.gclass179_0) : this.class745_0.gclass179_0.method_7(this.bool_1));
			if (this.class745_0.gclass179_0.Type == "DOUBLE")
			{
				if (this.class745_0.IsCheckReversed)
				{
					this.class745_0.IsChecked = new bool?(this.class745_0.CurrentValueType != "BEST");
					this.class745_0.DoubleReversedCBVisibility = Visibility.Visible;
				}
				else
				{
					this.class745_0.IsChecked = new bool?(this.class745_0.CurrentValueType != "DEFAULT");
					this.class745_0.DoubleCBVisibility = Visibility.Visible;
				}
			}
			else if (this.class745_0.gclass179_0.Type == "DEBLOAT")
			{
				this.class745_0.IsChecked = new bool?(this.class745_0.CurrentValueType != "DEFAULT");
				this.class745_0.DebloatVisibility = Visibility.Visible;
			}
			else if (!(this.class745_0.gclass179_0.Type == "MULTI") && !(this.class745_0.gclass179_0.Type == "CUSTOM_VALUE"))
			{
				if (this.class745_0.gclass179_0.Type == "IMPORT" || this.class745_0.gclass179_0.Type == "SCRIPT")
				{
					if (this.class745_0.gclass179_0.Type == "IMPORT")
					{
						this.class745_0.ImportVisibility = Visibility.Visible;
					}
					if (this.class745_0.gclass179_0.Type == "SCRIPT")
					{
						this.class745_0.ScriptVisibility = Visibility.Visible;
					}
					this.class745_0.IsChecked = new bool?(false);
				}
			}
			else
			{
				if (this.class745_0.gclass179_0.Type == "MULTI")
				{
					this.class745_0.MultiVisibility = Visibility.Visible;
				}
				if (this.class745_0.gclass179_0.Type == "CUSTOM_VALUE")
				{
					this.class745_0.CustomVisibility = Visibility.Visible;
				}
				this.class745_0.SelectedIndex = new int?((this.class745_0.CurrentValueType == "DEFAULT") ? 0 : ((this.class745_0.CurrentValueType == "OPTIMAL") ? 1 : ((this.class745_0.CurrentValueType == "CUSTOM") ? 3 : 2)));
				int? selectedIndex = this.class745_0.SelectedIndex;
				if (selectedIndex.GetValueOrDefault() == 3 & selectedIndex != null)
				{
					this.class745_0.CustomValue = this.class745_0.gclass179_0.method_8();
				}
			}
			this.class745_0.method_0("IsChecked");
			this.class745_0.method_0("SetCurrentValues");
			this.class745_0.bool_0 = true;
		}

		// Token: 0x0400108F RID: 4239
		public Class745 class745_0;

		// Token: 0x04001090 RID: 4240
		public bool bool_0;

		// Token: 0x04001091 RID: 4241
		public bool bool_1;
	}

	// Token: 0x02000421 RID: 1057
	[StructLayout(LayoutKind.Auto)]
	private struct Struct231 : IAsyncStateMachine
	{
		// Token: 0x06001747 RID: 5959 RVA: 0x00061A44 File Offset: 0x0005FC44
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class745 @class = this.class745_0;
			try
			{
				Class745.Class478 class2;
				if (num != 0)
				{
					class2 = new Class745.Class478();
					class2.class745_0 = this.class745_0;
					class2.solidColorBrush_0 = this.solidColorBrush_0;
					class2.string_0 = this.string_0;
					CancellationTokenSource cancellationTokenSource_ = @class.cancellationTokenSource_0;
					if (cancellationTokenSource_ != null)
					{
						cancellationTokenSource_.Cancel();
					}
					@class.cancellationTokenSource_0 = new CancellationTokenSource();
					class2.cancellationToken_0 = @class.cancellationTokenSource_0.Token;
				}
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Func<Task>(class2.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class745.Struct231>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (TaskCanceledException ex)
				{
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00061B8C File Offset: 0x0005FD8C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001092 RID: 4242
		public int int_0;

		// Token: 0x04001093 RID: 4243
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001094 RID: 4244
		public Class745 class745_0;

		// Token: 0x04001095 RID: 4245
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001096 RID: 4246
		public string string_0;

		// Token: 0x04001097 RID: 4247
		private TaskAwaiter taskAwaiter_0;
	}
}
