using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using ns0;
using NvidiaX.NVIDIA.Classes;
using NvidiaX.NVIDIA.Classes.Import;

// Token: 0x02000496 RID: 1174
public sealed class GClass222 : GClass211
{
	// Token: 0x060019D2 RID: 6610 RVA: 0x0006A108 File Offset: 0x00068308
	public GClass222()
	{
		this.bool_0 = true;
		this.SettingItemsCollectionView = CollectionViewSource.GetDefaultView(this.SettingModels);
		this.SettingItemsCollectionView.GroupDescriptions.Add(new PropertyGroupDescription("GroupName"));
		this.SettingItemsCollectionView.SortDescriptions.Add(new SortDescription("GroupName", ListSortDirection.Ascending));
		this.RefreshCommand.Execute(null);
	}

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x060019D3 RID: 6611 RVA: 0x0006A1BC File Offset: 0x000683BC
	// (set) Token: 0x060019D4 RID: 6612 RVA: 0x0006A1C4 File Offset: 0x000683C4
	public double AnimationOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("AnimationOpacity");
		}
	}

	// Token: 0x170003DB RID: 987
	// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0006A1D8 File Offset: 0x000683D8
	// (set) Token: 0x060019D6 RID: 6614 RVA: 0x0006A1E0 File Offset: 0x000683E0
	public Visibility AnimationVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("AnimationVisibility");
		}
	}

	// Token: 0x170003DC RID: 988
	// (get) Token: 0x060019D7 RID: 6615 RVA: 0x0006A1F4 File Offset: 0x000683F4
	// (set) Token: 0x060019D8 RID: 6616 RVA: 0x0006A1FC File Offset: 0x000683FC
	public double MainOpacity
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
			base.method_0("MainOpacity");
		}
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x0006A210 File Offset: 0x00068410
	private void method_1()
	{
		GClass222.Struct245 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass222_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass222.Struct245>(ref @struct);
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x0006A248 File Offset: 0x00068448
	private void method_2()
	{
		GClass222.Struct253 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass222_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass222.Struct253>(ref @struct);
	}

	// Token: 0x170003DD RID: 989
	// (get) Token: 0x060019DB RID: 6619 RVA: 0x0006A280 File Offset: 0x00068480
	public bool IsHardMode
	{
		get
		{
			bool? flag = Class389.class504_0.method_50();
			return flag.GetValueOrDefault() & flag != null;
		}
	}

	// Token: 0x170003DE RID: 990
	// (get) Token: 0x060019DC RID: 6620 RVA: 0x0006A2AC File Offset: 0x000684AC
	public Visibility IsHardModeVisibility
	{
		get
		{
			if (!this.IsHardMode)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x170003DF RID: 991
	// (get) Token: 0x060019DD RID: 6621 RVA: 0x0006A2BC File Offset: 0x000684BC
	// (set) Token: 0x060019DE RID: 6622 RVA: 0x0006A2C4 File Offset: 0x000684C4
	public bool IsScannedForPredefined
	{
		get
		{
			return this.bool_1;
		}
		private set
		{
			this.bool_1 = value;
			base.method_0("IsScannedForPredefined");
		}
	}

	// Token: 0x170003E0 RID: 992
	// (get) Token: 0x060019DF RID: 6623 RVA: 0x0006A2D8 File Offset: 0x000684D8
	// (set) Token: 0x060019E0 RID: 6624 RVA: 0x0006A2E0 File Offset: 0x000684E0
	public GClass136 BaseProfile
	{
		get
		{
			return this.gclass136_0;
		}
		private set
		{
			this.gclass136_0 = value;
			base.method_0("BaseProfile");
		}
	}

	// Token: 0x170003E1 RID: 993
	// (get) Token: 0x060019E1 RID: 6625 RVA: 0x0006A2F4 File Offset: 0x000684F4
	// (set) Token: 0x060019E2 RID: 6626 RVA: 0x0006A2FC File Offset: 0x000684FC
	public GClass136 CurrentProfile
	{
		get
		{
			return this.gclass136_1;
		}
		private set
		{
			this.gclass136_1 = value;
			this.method_10(Class364.smethod_0(value.ProfileName), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			base.method_0("CurrentProfile");
		}
	}

	// Token: 0x170003E2 RID: 994
	// (get) Token: 0x060019E3 RID: 6627 RVA: 0x0006A328 File Offset: 0x00068528
	// (set) Token: 0x060019E4 RID: 6628 RVA: 0x0006A330 File Offset: 0x00068530
	public Dictionary<string, string> Applications
	{
		get
		{
			return this.dictionary_0;
		}
		private set
		{
			if (value != this.dictionary_0)
			{
				this.dictionary_0 = value;
				base.method_0("Applications");
				base.method_0("ApplicationsFormatted");
			}
		}
	}

	// Token: 0x170003E3 RID: 995
	// (get) Token: 0x060019E5 RID: 6629 RVA: 0x0006A360 File Offset: 0x00068560
	// (set) Token: 0x060019E6 RID: 6630 RVA: 0x0006A368 File Offset: 0x00068568
	public int EditCount
	{
		get
		{
			return dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_0;
		}
		set
		{
			if (value != dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_0)
			{
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_0 = value;
				GClass93.smethod_0().method_10();
				base.method_0("EditCount");
			}
		}
	}

	// Token: 0x170003E4 RID: 996
	// (get) Token: 0x060019E7 RID: 6631 RVA: 0x0006A394 File Offset: 0x00068594
	public string ApplicationsFormatted
	{
		get
		{
			return string.Join(" ; ", this.dictionary_0.Values);
		}
	}

	// Token: 0x170003E5 RID: 997
	// (get) Token: 0x060019E8 RID: 6632 RVA: 0x0006A3AC File Offset: 0x000685AC
	// (set) Token: 0x060019E9 RID: 6633 RVA: 0x0006A3B4 File Offset: 0x000685B4
	public ObservableCollection<GClass136> Profiles
	{
		get
		{
			return this.observableCollection_0;
		}
		private set
		{
			if (value != this.observableCollection_0)
			{
				this.observableCollection_0 = value;
				base.method_0("Profiles");
			}
		}
	}

	// Token: 0x170003E6 RID: 998
	// (get) Token: 0x060019EA RID: 6634 RVA: 0x0006A3D8 File Offset: 0x000685D8
	// (set) Token: 0x060019EB RID: 6635 RVA: 0x0006A3E0 File Offset: 0x000685E0
	public ObservableCollection<GClass219> SettingModels
	{
		get
		{
			return this.observableCollection_1;
		}
		private set
		{
			if (value != this.observableCollection_1)
			{
				this.observableCollection_1 = value;
				base.method_0("SettingModels");
			}
		}
	}

	// Token: 0x170003E7 RID: 999
	// (get) Token: 0x060019EC RID: 6636 RVA: 0x0006A404 File Offset: 0x00068604
	// (set) Token: 0x060019ED RID: 6637 RVA: 0x0006A40C File Offset: 0x0006860C
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

	// Token: 0x170003E8 RID: 1000
	// (get) Token: 0x060019EE RID: 6638 RVA: 0x0006A418 File Offset: 0x00068618
	public GClass134 RefreshCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_11), null));
			}
			return result;
		}
	}

	// Token: 0x170003E9 RID: 1001
	// (get) Token: 0x060019EF RID: 6639 RVA: 0x0006A44C File Offset: 0x0006864C
	public GClass134 OnProfileChangedCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_1) == null)
			{
				result = (this.gclass134_1 = new GClass134(new Action<object>(this.method_12), null));
			}
			return result;
		}
	}

	// Token: 0x170003EA RID: 1002
	// (get) Token: 0x060019F0 RID: 6640 RVA: 0x0006A480 File Offset: 0x00068680
	public GClass134 OnSettingValueChangedCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_2) == null)
			{
				result = (this.gclass134_2 = new GClass134(new Action<object>(this.method_13), null));
			}
			return result;
		}
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x0006A4B4 File Offset: 0x000686B4
	public void method_3()
	{
		GClass222.Struct247 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass222_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass222.Struct247>(ref @struct);
	}

	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x060019F2 RID: 6642 RVA: 0x0006A4EC File Offset: 0x000686EC
	// (set) Token: 0x060019F3 RID: 6643 RVA: 0x0006A4F4 File Offset: 0x000686F4
	public bool IsProfileExport
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.bool_3 = value;
			base.method_0("IsProfileExport");
		}
	}

	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x060019F4 RID: 6644 RVA: 0x0006A508 File Offset: 0x00068708
	public GClass134 ExportClickCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_3) == null)
			{
				result = (this.gclass134_3 = new GClass134(new Action<object>(this.method_15), null));
			}
			return result;
		}
	}

	// Token: 0x170003ED RID: 1005
	// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0006A53C File Offset: 0x0006873C
	// (set) Token: 0x060019F6 RID: 6646 RVA: 0x0006A544 File Offset: 0x00068744
	public bool IsProfileImport
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			this.bool_4 = value;
			base.method_0("IsProfileImport");
		}
	}

	// Token: 0x060019F7 RID: 6647 RVA: 0x0006A558 File Offset: 0x00068758
	private string method_4()
	{
		return this.string_0;
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x0006A560 File Offset: 0x00068760
	private void method_5(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x170003EE RID: 1006
	// (get) Token: 0x060019F9 RID: 6649 RVA: 0x0006A56C File Offset: 0x0006876C
	public GClass134 ImportClickCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_4) == null)
			{
				result = (this.gclass134_4 = new GClass134(new Action<object>(this.method_16), null));
			}
			return result;
		}
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x0006A5A0 File Offset: 0x000687A0
	public void method_6(string string_2)
	{
		this.method_5(string_2);
		GClass93.smethod_0().method_9<Class522>("import", new Func<Class522>(GClass222.Class561.class561_0.method_4), this);
		this.method_10(Class364.smethod_0("ProfileWillBeImported"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
	}

	// Token: 0x170003EF RID: 1007
	// (get) Token: 0x060019FB RID: 6651 RVA: 0x0006A5FC File Offset: 0x000687FC
	public GClass134 OptimalClickCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_5) == null)
			{
				result = (this.gclass134_5 = new GClass134(new Action<object>(this.method_17), null));
			}
			return result;
		}
	}

	// Token: 0x170003F0 RID: 1008
	// (get) Token: 0x060019FC RID: 6652 RVA: 0x0006A630 File Offset: 0x00068830
	public GClass134 ResetProfileClickCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_6) == null)
			{
				result = (this.gclass134_6 = new GClass134(new Action<object>(this.method_18), new Func<object, bool>(this.method_19)));
			}
			return result;
		}
	}

	// Token: 0x170003F1 RID: 1009
	// (get) Token: 0x060019FD RID: 6653 RVA: 0x0006A670 File Offset: 0x00068870
	// (set) Token: 0x060019FE RID: 6654 RVA: 0x0006A678 File Offset: 0x00068878
	public GEnum60 ResetType
	{
		get
		{
			return this.genum60_0;
		}
		private set
		{
			this.genum60_0 = value;
			base.method_0("ResetType");
		}
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x0006A68C File Offset: 0x0006888C
	public Task method_7(CancellationToken cancellationToken_0)
	{
		GClass222.Struct248 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass222_0 = this;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass222.Struct248>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x0006A6D8 File Offset: 0x000688D8
	public Task method_8(GClass136 gclass136_2, GEnum78 genum78_0, CancellationToken cancellationToken_0)
	{
		GClass222.Struct250 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass222_0 = this;
		@struct.gclass136_0 = gclass136_2;
		@struct.genum78_0 = genum78_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass222.Struct250>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x0006A734 File Offset: 0x00068934
	public Task method_9(CancellationToken cancellationToken_0)
	{
		GClass222.Struct251 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass222_0 = this;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass222.Struct251>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x170003F2 RID: 1010
	// (get) Token: 0x06001A02 RID: 6658 RVA: 0x0006A780 File Offset: 0x00068980
	// (set) Token: 0x06001A03 RID: 6659 RVA: 0x0006A788 File Offset: 0x00068988
	public string StatusText
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x170003F3 RID: 1011
	// (get) Token: 0x06001A04 RID: 6660 RVA: 0x0006A79C File Offset: 0x0006899C
	// (set) Token: 0x06001A05 RID: 6661 RVA: 0x0006A7A4 File Offset: 0x000689A4
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

	// Token: 0x170003F4 RID: 1012
	// (get) Token: 0x06001A06 RID: 6662 RVA: 0x0006A7B8 File Offset: 0x000689B8
	// (set) Token: 0x06001A07 RID: 6663 RVA: 0x0006A7C0 File Offset: 0x000689C0
	public double StatusOpacity
	{
		get
		{
			return this.double_2;
		}
		set
		{
			this.double_2 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x0006A7D4 File Offset: 0x000689D4
	private void method_10(string string_2, SolidColorBrush solidColorBrush_1)
	{
		GClass222.Struct254 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass222_0 = this;
		@struct.string_0 = string_2;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass222.Struct254>(ref @struct);
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x0006A81C File Offset: 0x00068A1C
	private void method_11(object object_0)
	{
		GClass222.Struct252 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass222_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass222.Struct252>(ref @struct);
	}

	// Token: 0x06001A0A RID: 6666 RVA: 0x0006A854 File Offset: 0x00068A54
	private void method_12(object object_0)
	{
		GClass222.Struct244 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass222_0 = this;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass222.Struct244>(ref @struct);
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x0006A894 File Offset: 0x00068A94
	private void method_13(object object_0)
	{
		if (object_0 == null)
		{
			return;
		}
		this.IsProfileImport = false;
		this.IsProfileExport = false;
		ComboBox comboBox = (ComboBox)object_0;
		if (comboBox.Items.Count < 1)
		{
			return;
		}
		GClass219 gclass = (GClass219)comboBox.DataContext;
		GInterface5 ginterface = (GInterface5)comboBox.SelectedItem;
		int editCount;
		if (ginterface == gclass.ginterface5_1)
		{
			GClass93.smethod_0().method_15(typeof(Class522), gclass.SettingMeta.method_4());
			editCount = this.EditCount;
			this.EditCount = editCount - 1;
			gclass.IsEdited = false;
			return;
		}
		editCount = this.EditCount;
		this.EditCount = editCount + 1;
		GClass93.smethod_0().method_9<Class522>(gclass.SettingMeta.method_4(), new Func<Class522>(GClass222.Class561.class561_0.method_0), gclass.SettingItem.method_4());
		this.ResetType = (GEnum60)2;
		gclass.IsEdited = true;
		GClass79 settingItem = gclass.SettingItem;
		string string_;
		if (ginterface == null)
		{
			string_ = null;
		}
		else
		{
			object obj = ginterface.imethod_0();
			string_ = ((obj != null) ? obj.ToString() : null);
		}
		settingItem.method_5(string_);
	}

	// Token: 0x06001A0C RID: 6668 RVA: 0x0006A9A4 File Offset: 0x00068BA4
	private Task method_14()
	{
		GClass222.Struct243 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass222_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass222.Struct243>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001A0D RID: 6669 RVA: 0x0006A9E8 File Offset: 0x00068BE8
	private void method_15(object object_0)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog
		{
			Filter = "NVIDIA Profiles (*.nvx) | *.nvx",
			CheckPathExists = true
		};
		if (saveFileDialog.ShowDialog().Value)
		{
			this.IsProfileExport = true;
			this.CurrentProfile.smethod_17(saveFileDialog.FileName, true);
		}
	}

	// Token: 0x06001A0E RID: 6670 RVA: 0x0006AA38 File Offset: 0x00068C38
	private void method_16(object object_0)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Filter = "NVIDIA Profiles (*.nvx; *.nip) | *.nvx; *.nip",
			CheckFileExists = true,
			CheckPathExists = true
		};
		if (openFileDialog.ShowDialog().Value)
		{
			this.EditCount = 1;
			this.IsProfileImport = true;
			this.IsProfileExport = false;
			this.method_5(openFileDialog.FileName);
			GClass93.smethod_0().method_9<Class522>("import", new Func<Class522>(GClass222.Class561.class561_0.method_3), this);
			this.method_10(Class364.smethod_0("ProfileWillBeImported"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
		}
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x0006AADC File Offset: 0x00068CDC
	private void method_17(object object_0)
	{
		GClass222.Struct249 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass222_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass222.Struct249>(ref @struct);
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x0006AB14 File Offset: 0x00068D14
	private void method_18(object object_0)
	{
		if (Keyboard.IsKeyDown(Key.LeftShift))
		{
			foreach (GClass219 gclass in this.SettingModels)
			{
				if (gclass.CurrentValue != gclass.SettingMeta.DefaultValue)
				{
					gclass.IsEdited = true;
					gclass.CurrentValue = gclass.SettingMeta.DefaultValue;
				}
			}
			this.ResetType = (GEnum60)0;
			this.method_10(Class364.smethod_0("CurrentProfileWillBeDefault"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
		}
		else
		{
			this.ResetType = (GEnum60)1;
			this.method_10(Class364.smethod_0("AllProfilesWillBeDefault"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
		}
		this.EditCount = 1;
		this.IsProfileImport = false;
		this.IsProfileExport = false;
		GClass93.smethod_0().method_9<Class522>("reset", new Func<Class522>(GClass222.Class561.class561_0.method_6), this);
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x0006AC28 File Offset: 0x00068E28
	private bool method_19(object object_0)
	{
		return this.CurrentProfile != null;
	}

	// Token: 0x04001205 RID: 4613
	public bool bool_0 = true;

	// Token: 0x04001206 RID: 4614
	private double double_0;

	// Token: 0x04001207 RID: 4615
	private Visibility visibility_0;

	// Token: 0x04001208 RID: 4616
	private double double_1;

	// Token: 0x04001209 RID: 4617
	private bool bool_1;

	// Token: 0x0400120A RID: 4618
	private GClass136 gclass136_0;

	// Token: 0x0400120B RID: 4619
	private GClass136 gclass136_1;

	// Token: 0x0400120C RID: 4620
	private Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	// Token: 0x0400120D RID: 4621
	private ObservableCollection<GClass136> observableCollection_0 = new ObservableCollection<GClass136>();

	// Token: 0x0400120E RID: 4622
	private ObservableCollection<GClass219> observableCollection_1 = new ObservableCollection<GClass219>();

	// Token: 0x0400120F RID: 4623
	private ICollectionView icollectionView_0;

	// Token: 0x04001210 RID: 4624
	public bool bool_2;

	// Token: 0x04001211 RID: 4625
	private GClass134 gclass134_0;

	// Token: 0x04001212 RID: 4626
	private GClass134 gclass134_1;

	// Token: 0x04001213 RID: 4627
	private GClass134 gclass134_2;

	// Token: 0x04001214 RID: 4628
	private bool bool_3;

	// Token: 0x04001215 RID: 4629
	private GClass134 gclass134_3;

	// Token: 0x04001216 RID: 4630
	private bool bool_4;

	// Token: 0x04001217 RID: 4631
	private string string_0;

	// Token: 0x04001218 RID: 4632
	private GClass134 gclass134_4;

	// Token: 0x04001219 RID: 4633
	private GClass134 gclass134_5;

	// Token: 0x0400121A RID: 4634
	private GClass134 gclass134_6;

	// Token: 0x0400121B RID: 4635
	private GEnum60 genum60_0 = (GEnum60)2;

	// Token: 0x0400121C RID: 4636
	private string string_1 = string.Empty;

	// Token: 0x0400121D RID: 4637
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x0400121E RID: 4638
	private double double_2;

	// Token: 0x02000497 RID: 1175
	[StructLayout(LayoutKind.Auto)]
	private struct Struct243 : IAsyncStateMachine
	{
		// Token: 0x06001A12 RID: 6674 RVA: 0x0006AC34 File Offset: 0x00068E34
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass222 gclass = this.gclass222_0;
			try
			{
				TaskAwaiter awaiter;
				TaskAwaiter<bool> awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<bool>);
					this.int_0 = -1;
					goto IL_159;
				case 2:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<bool>);
					this.int_0 = -1;
					goto IL_1BD;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_227;
				default:
				{
					if (gclass.method_4() != null)
					{
						GClass113.smethod_22(gclass.method_4());
						goto IL_249;
					}
					IEnumerable<GClass79> ienumerable_ = gclass.SettingModels.Where(new Func<GClass219, bool>(GClass222.Class561.class561_0.method_1)).Select(new Func<GClass219, GClass79>(GClass222.Class561.class561_0.method_2));
					awaiter = gclass.CurrentProfile.smethod_13(ienumerable_, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct243>(ref awaiter, ref this);
						return;
					}
					break;
				}
				}
				awaiter.GetResult();
				if (gclass.ResetType != (GEnum60)0)
				{
					goto IL_161;
				}
				awaiter2 = gclass.CurrentProfile.smethod_25().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, GClass222.Struct243>(ref awaiter2, ref this);
					return;
				}
				IL_159:
				awaiter2.GetResult();
				IL_161:
				if (gclass.ResetType != (GEnum60)1)
				{
					goto IL_1C5;
				}
				awaiter2 = GClass113.smethod_26().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, GClass222.Struct243>(ref awaiter2, ref this);
					return;
				}
				IL_1BD:
				awaiter2.GetResult();
				IL_1C5:
				awaiter = gclass.method_8(gclass.CurrentProfile, (GEnum78)0, default(CancellationToken)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct243>(ref awaiter, ref this);
					return;
				}
				IL_227:
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_249:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0006AEBC File Offset: 0x000690BC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400121F RID: 4639
		public int int_0;

		// Token: 0x04001220 RID: 4640
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001221 RID: 4641
		public GClass222 gclass222_0;

		// Token: 0x04001222 RID: 4642
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04001223 RID: 4643
		private TaskAwaiter<bool> taskAwaiter_1;
	}

	// Token: 0x02000498 RID: 1176
	[StructLayout(LayoutKind.Auto)]
	private struct Struct244 : IAsyncStateMachine
	{
		// Token: 0x06001A14 RID: 6676 RVA: 0x0006AECC File Offset: 0x000690CC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass222 gclass = this.gclass222_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (this.object_0 == null)
					{
						goto IL_BE;
					}
					gclass.IsProfileImport = false;
					gclass.IsProfileExport = false;
					GClass136 gclass2 = (GClass136)this.object_0;
					gclass.CurrentProfile = gclass2;
					awaiter = gclass.method_8(gclass2, (GEnum78)1, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct244>(ref awaiter, ref this);
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
			IL_BE:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0006AFBC File Offset: 0x000691BC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001224 RID: 4644
		public int int_0;

		// Token: 0x04001225 RID: 4645
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001226 RID: 4646
		public object object_0;

		// Token: 0x04001227 RID: 4647
		public GClass222 gclass222_0;

		// Token: 0x04001228 RID: 4648
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000499 RID: 1177
	[StructLayout(LayoutKind.Auto)]
	private struct Struct245 : IAsyncStateMachine
	{
		// Token: 0x06001A16 RID: 6678 RVA: 0x0006AFCC File Offset: 0x000691CC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass222 gclass = this.gclass222_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_B6;
				}
				gclass.MainOpacity = 0.0;
				gclass.AnimationVisibility = Visibility.Visible;
				IL_2A:
				if (gclass.AnimationOpacity == 1.0)
				{
					goto IL_FF;
				}
				gclass.AnimationOpacity += 0.13333333333333333;
				if (gclass.AnimationOpacity > 0.95)
				{
					gclass.AnimationOpacity = 1.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct245>(ref awaiter, ref this);
					return;
				}
				IL_B6:
				awaiter.GetResult();
				goto IL_2A;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_FF:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0006B0FC File Offset: 0x000692FC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001229 RID: 4649
		public int int_0;

		// Token: 0x0400122A RID: 4650
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400122B RID: 4651
		public GClass222 gclass222_0;

		// Token: 0x0400122C RID: 4652
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200049A RID: 1178
	private sealed class Class556
	{
		// Token: 0x06001A19 RID: 6681 RVA: 0x0006B114 File Offset: 0x00069314
		internal void method_0(ImportExportProfileSetting importExportProfileSetting_0)
		{
			GClass222.Class560 @class = new GClass222.Class560();
			@class.importExportProfileSetting_0 = importExportProfileSetting_0;
			try
			{
				if (this.gclass219_0.SettingItem.method_0() == @class.importExportProfileSetting_0.SettingId && this.gclass219_0.CurrentValue.imethod_0().ToString() != @class.importExportProfileSetting_0.SettingValue)
				{
					this.class558_0.bool_0 = true;
					this.gclass219_0.IsEdited = true;
					this.gclass219_0.CurrentValue = this.gclass219_0.Values.FirstOrDefault(new Func<GInterface5, bool>(@class.method_0));
				}
			}
			catch
			{
				this.class558_0.bool_1 = true;
			}
		}

		// Token: 0x0400122D RID: 4653
		public GClass219 gclass219_0;

		// Token: 0x0400122E RID: 4654
		public GClass222.Class558 class558_0;
	}

	// Token: 0x0200049B RID: 1179
	private sealed class Class557
	{
		// Token: 0x06001A1B RID: 6683 RVA: 0x0006B1DC File Offset: 0x000693DC
		internal Task method_0()
		{
			GClass222.Class557.Struct246 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class557_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass222.Class557.Struct246>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0006B220 File Offset: 0x00069420
		internal void method_1(GStruct0 gstruct0_0)
		{
			this.gclass222_0.SettingModels.Add(new GClass219(gstruct0_0, this.gclass222_0.IsHardMode));
		}

		// Token: 0x0400122F RID: 4655
		public GClass136 gclass136_0;

		// Token: 0x04001230 RID: 4656
		public GEnum78 genum78_0;

		// Token: 0x04001231 RID: 4657
		public CancellationToken cancellationToken_0;

		// Token: 0x04001232 RID: 4658
		public GClass222 gclass222_0;

		// Token: 0x04001233 RID: 4659
		public Action<GStruct0> action_0;

		// Token: 0x0200049C RID: 1180
		[StructLayout(LayoutKind.Auto)]
		private struct Struct246 : IAsyncStateMachine
		{
			// Token: 0x06001A1D RID: 6685 RVA: 0x0006B244 File Offset: 0x00069444
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				GClass222.Class557 @class = this.class557_0;
				try
				{
					TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> awaiter;
					if (num != 0)
					{
						this.class559_0 = new GClass222.Class559();
						this.class559_0.class557_0 = @class;
						awaiter = @class.gclass136_0.smethod_8(@class.genum78_0, false, @class.cancellationToken_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>, GClass222.Class557.Struct246>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>);
						this.int_0 = -1;
					}
					ValueTuple<List<GStruct0>, Dictionary<string, string>> result = awaiter.GetResult();
					this.class559_0.valueTuple_0 = result;
					this.class559_0.ienumerable_0 = this.class559_0.valueTuple_0.Item1.Where(new Func<GStruct0, bool>(GClass222.Class561.class561_0.method_8));
					if (!@class.gclass222_0.IsHardMode)
					{
						this.class559_0.ienumerable_0 = this.class559_0.ienumerable_0.Where(new Func<GStruct0, bool>(GClass222.Class561.class561_0.method_9));
					}
					Application.Current.Dispatcher.Invoke(new Action(this.class559_0.method_0));
					@class.gclass222_0.bool_2 = false;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class559_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class559_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06001A1E RID: 6686 RVA: 0x0006B400 File Offset: 0x00069600
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001234 RID: 4660
			public int int_0;

			// Token: 0x04001235 RID: 4661
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001236 RID: 4662
			public GClass222.Class557 class557_0;

			// Token: 0x04001237 RID: 4663
			private GClass222.Class559 class559_0;

			// Token: 0x04001238 RID: 4664
			private TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> taskAwaiter_0;
		}
	}

	// Token: 0x0200049D RID: 1181
	private sealed class Class558
	{
		// Token: 0x04001239 RID: 4665
		public bool bool_0;

		// Token: 0x0400123A RID: 4666
		public bool bool_1;
	}

	// Token: 0x0200049E RID: 1182
	[StructLayout(LayoutKind.Auto)]
	private struct Struct247 : IAsyncStateMachine
	{
		// Token: 0x06001A20 RID: 6688 RVA: 0x0006B418 File Offset: 0x00069618
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass222 @object = this.gclass222_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_14)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct247>(ref awaiter, ref this);
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

		// Token: 0x06001A21 RID: 6689 RVA: 0x0006B4D8 File Offset: 0x000696D8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400123B RID: 4667
		public int int_0;

		// Token: 0x0400123C RID: 4668
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400123D RID: 4669
		public GClass222 gclass222_0;

		// Token: 0x0400123E RID: 4670
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200049F RID: 1183
	[StructLayout(LayoutKind.Auto)]
	private struct Struct248 : IAsyncStateMachine
	{
		// Token: 0x06001A22 RID: 6690 RVA: 0x0006B4E8 File Offset: 0x000696E8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass222 gclass = this.gclass222_0;
			try
			{
				TaskAwaiter<GStruct9> awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GStruct9>);
					this.int_0 = -1;
					goto IL_AD;
				}
				TaskAwaiter awaiter2;
				if (num != 1)
				{
					awaiter = GClass113.smethod_4(this.cancellationToken_0, true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GStruct9>, GClass222.Struct248>(ref awaiter, ref this);
						return;
					}
					goto IL_AD;
				}
				else
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_7A:
				awaiter2.GetResult();
				gclass.method_0("LoadProfilesAsync");
				goto IL_191;
				IL_AD:
				GStruct9 result = awaiter.GetResult();
				gclass.CurrentProfile = (gclass.BaseProfile = result.method_0());
				if (!gclass.IsHardMode)
				{
					gclass.Profiles = new ObservableCollection<GClass136>(result.Profiles);
				}
				else
				{
					gclass.Profiles = new ObservableCollection<GClass136>(result.Profiles.Where(new Func<GClass136, bool>(GClass222.Class561.class561_0.method_7)));
				}
				awaiter2 = gclass.method_8(gclass.gclass136_0, (GEnum78)0, default(CancellationToken)).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct248>(ref awaiter2, ref this);
					return;
				}
				goto IL_7A;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_191:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0006B6B8 File Offset: 0x000698B8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400123F RID: 4671
		public int int_0;

		// Token: 0x04001240 RID: 4672
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001241 RID: 4673
		public CancellationToken cancellationToken_0;

		// Token: 0x04001242 RID: 4674
		public GClass222 gclass222_0;

		// Token: 0x04001243 RID: 4675
		private TaskAwaiter<GStruct9> taskAwaiter_0;

		// Token: 0x04001244 RID: 4676
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020004A0 RID: 1184
	private sealed class Class559
	{
		// Token: 0x06001A25 RID: 6693 RVA: 0x0006B6D0 File Offset: 0x000698D0
		internal void method_0()
		{
			this.class557_0.gclass222_0.SettingModels.Clear();
			this.class557_0.gclass222_0.Applications = this.valueTuple_0.Item2;
			IEnumerable<GStruct0> enumerable = this.ienumerable_0;
			Action<GStruct0> action_;
			if ((action_ = this.class557_0.action_0) == null)
			{
				action_ = (this.class557_0.action_0 = new Action<GStruct0>(this.class557_0.method_1));
			}
			enumerable.smethod_0(action_);
		}

		// Token: 0x04001245 RID: 4677
		public ValueTuple<List<GStruct0>, Dictionary<string, string>> valueTuple_0;

		// Token: 0x04001246 RID: 4678
		public IEnumerable<GStruct0> ienumerable_0;

		// Token: 0x04001247 RID: 4679
		public GClass222.Class557 class557_0;
	}

	// Token: 0x020004A1 RID: 1185
	[StructLayout(LayoutKind.Auto)]
	private struct Struct249 : IAsyncStateMachine
	{
		// Token: 0x06001A26 RID: 6694 RVA: 0x0006B748 File Offset: 0x00069948
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass222 gclass = this.gclass222_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					goto IL_CE;
				}
				if (num != 1)
				{
					this.class558_0 = new GClass222.Class558();
					this.int_1 = 0;
					goto IL_AA;
				}
				awaiter = this.taskAwaiter_0;
				this.taskAwaiter_0 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				this.int_0 = num3;
				IL_50:
				awaiter.GetResult();
				gclass.method_10(Class364.smethod_0(gclass.CurrentProfile.ProfileName), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				goto IL_2DE;
				IL_AA:
				if (!gclass.bool_2)
				{
					goto IL_10F;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num4 = 0;
					num = 0;
					this.int_0 = num4;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct249>(ref awaiter, ref this);
					return;
				}
				IL_CE:
				awaiter.GetResult();
				if (this.int_1 <= 500)
				{
					int num5 = this.int_1;
					this.int_1 = num5 + 1;
					goto IL_AA;
				}
				IL_10F:
				if (gclass.CurrentProfile.ProfileName != "Base Profile")
				{
					gclass.CurrentProfile = gclass.Profiles.FirstOrDefault(new Func<GClass136, bool>(GClass222.Class561.class561_0.method_5));
				}
				Class650.smethod_4("BoosterX", Class186.string_4, "Resources.EmbedRes.Tweaks.Nvidia", "BestProfile.nvx", false);
				ImportExportProfiles importExportProfiles = GClass113.smethod_23(Path.Combine(Class186.string_4, "BestProfile.nvx"));
				this.class558_0.bool_1 = false;
				this.class558_0.bool_0 = false;
				IEnumerator<GClass219> enumerator = gclass.SettingModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass222.Class556 @class = new GClass222.Class556();
						@class.class558_0 = this.class558_0;
						@class.gclass219_0 = enumerator.Current;
						Class333.smethod_0<ImportExportProfile>(importExportProfiles.Profiles).Settings.ForEach(new Action<ImportExportProfileSetting>(@class.method_0));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (!this.class558_0.bool_0)
				{
					gclass.method_10(Class364.smethod_0("AllSettingsAreAlreadyOptimal"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					awaiter = Task.Delay(1500).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num6 = 1;
						num = 1;
						this.int_0 = num6;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct249>(ref awaiter, ref this);
						return;
					}
					goto IL_50;
				}
				else
				{
					gclass.method_10(this.class558_0.bool_1 ? Class364.smethod_0("OldDriverSkippedSome") : Class364.smethod_0("willbeoptimal"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class558_0 = null;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_2DE:
			this.int_0 = -2;
			this.class558_0 = null;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0006BA84 File Offset: 0x00069C84
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001248 RID: 4680
		public int int_0;

		// Token: 0x04001249 RID: 4681
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400124A RID: 4682
		public GClass222 gclass222_0;

		// Token: 0x0400124B RID: 4683
		private GClass222.Class558 class558_0;

		// Token: 0x0400124C RID: 4684
		private int int_1;

		// Token: 0x0400124D RID: 4685
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004A2 RID: 1186
	private sealed class Class560
	{
		// Token: 0x06001A29 RID: 6697 RVA: 0x0006BA9C File Offset: 0x00069C9C
		internal bool method_0(GInterface5 ginterface5_0)
		{
			return ginterface5_0.imethod_0().ToString() == this.importExportProfileSetting_0.SettingValue;
		}

		// Token: 0x0400124E RID: 4686
		public ImportExportProfileSetting importExportProfileSetting_0;
	}

	// Token: 0x020004A3 RID: 1187
	[Serializable]
	private sealed class Class561
	{
		// Token: 0x06001A2C RID: 6700 RVA: 0x0006BAD0 File Offset: 0x00069CD0
		internal Class522 method_0()
		{
			return new Class522();
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0006BAD8 File Offset: 0x00069CD8
		internal bool method_1(GClass219 gclass219_0)
		{
			return gclass219_0.IsEdited;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0006BAE0 File Offset: 0x00069CE0
		internal GClass79 method_2(GClass219 gclass219_0)
		{
			return gclass219_0.SettingItem;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0006BAE8 File Offset: 0x00069CE8
		internal Class522 method_3()
		{
			return new Class522();
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0006BAF0 File Offset: 0x00069CF0
		internal Class522 method_4()
		{
			return new Class522();
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0006BAF8 File Offset: 0x00069CF8
		internal bool method_5(GClass136 gclass136_0)
		{
			return gclass136_0.ProfileName == "Base Profile";
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0006BB0C File Offset: 0x00069D0C
		internal Class522 method_6()
		{
			return new Class522();
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0006BB14 File Offset: 0x00069D14
		internal bool method_7(GClass136 gclass136_0)
		{
			return !gclass136_0.ProfileName.StartsWith("0x", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0006BB2C File Offset: 0x00069D2C
		internal bool method_8(GStruct0 gstruct0_0)
		{
			return gstruct0_0.method_0().Values.Count<GInterface5>() > 1;
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0006BB44 File Offset: 0x00069D44
		internal bool method_9(GStruct0 gstruct0_0)
		{
			if (Class387.list_0.Contains(gstruct0_0.SettingItem.method_2()))
			{
				return gstruct0_0.method_0().Values.Count(new Func<GInterface5, bool>(GClass222.Class561.class561_0.method_10)) > 0;
			}
			return false;
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0006BBA0 File Offset: 0x00069DA0
		internal bool method_10(GInterface5 ginterface5_0)
		{
			return !ginterface5_0.imethod_1().StartsWith("0x");
		}

		// Token: 0x0400124F RID: 4687
		public static readonly GClass222.Class561 class561_0 = new GClass222.Class561();

		// Token: 0x04001250 RID: 4688
		public static Func<Class522> func_0;

		// Token: 0x04001251 RID: 4689
		public static Func<GClass219, bool> func_1;

		// Token: 0x04001252 RID: 4690
		public static Func<GClass219, GClass79> func_2;

		// Token: 0x04001253 RID: 4691
		public static Func<Class522> func_3;

		// Token: 0x04001254 RID: 4692
		public static Func<Class522> func_4;

		// Token: 0x04001255 RID: 4693
		public static Func<GClass136, bool> func_5;

		// Token: 0x04001256 RID: 4694
		public static Func<Class522> func_6;

		// Token: 0x04001257 RID: 4695
		public static Func<GClass136, bool> func_7;

		// Token: 0x04001258 RID: 4696
		public static Func<GStruct0, bool> func_8;

		// Token: 0x04001259 RID: 4697
		public static Func<GInterface5, bool> func_9;

		// Token: 0x0400125A RID: 4698
		public static Func<GStruct0, bool> func_10;
	}

	// Token: 0x020004A4 RID: 1188
	[StructLayout(LayoutKind.Auto)]
	private struct Struct250 : IAsyncStateMachine
	{
		// Token: 0x06001A37 RID: 6711 RVA: 0x0006BBB8 File Offset: 0x00069DB8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(new GClass222.Class557
					{
						gclass136_0 = this.gclass136_0,
						genum78_0 = this.genum78_0,
						cancellationToken_0 = this.cancellationToken_0,
						gclass222_0 = this.gclass222_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct250>(ref awaiter, ref this);
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
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0006BCA4 File Offset: 0x00069EA4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400125B RID: 4699
		public int int_0;

		// Token: 0x0400125C RID: 4700
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400125D RID: 4701
		public GClass136 gclass136_0;

		// Token: 0x0400125E RID: 4702
		public GEnum78 genum78_0;

		// Token: 0x0400125F RID: 4703
		public CancellationToken cancellationToken_0;

		// Token: 0x04001260 RID: 4704
		public GClass222 gclass222_0;

		// Token: 0x04001261 RID: 4705
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004A5 RID: 1189
	[StructLayout(LayoutKind.Auto)]
	private struct Struct251 : IAsyncStateMachine
	{
		// Token: 0x06001A39 RID: 6713 RVA: 0x0006BCB4 File Offset: 0x00069EB4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass222 gclass = this.gclass222_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = GClass113.smethod_10(this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct251>(ref awaiter, ref this);
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
				gclass.IsScannedForPredefined = true;
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

		// Token: 0x06001A3A RID: 6714 RVA: 0x0006BD74 File Offset: 0x00069F74
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001262 RID: 4706
		public int int_0;

		// Token: 0x04001263 RID: 4707
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001264 RID: 4708
		public CancellationToken cancellationToken_0;

		// Token: 0x04001265 RID: 4709
		public GClass222 gclass222_0;

		// Token: 0x04001266 RID: 4710
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004A6 RID: 1190
	[StructLayout(LayoutKind.Auto)]
	private struct Struct252 : IAsyncStateMachine
	{
		// Token: 0x06001A3B RID: 6715 RVA: 0x0006BD84 File Offset: 0x00069F84
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass222 gclass = this.gclass222_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_FD;
				}
				if (num != 1)
				{
					if (gclass.bool_2)
					{
						goto IL_164;
					}
					gclass.bool_2 = true;
					gclass.bool_0 = true;
					gclass.method_1();
					gclass.EditCount = 0;
					GClass93.smethod_0().method_17<Class522>();
					GClass113.smethod_14();
					awaiter = gclass.method_9(default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct252>(ref awaiter, ref this);
						return;
					}
					goto IL_FD;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_B7:
				awaiter.GetResult();
				GClass93.smethod_0().method_10();
				gclass.bool_0 = false;
				gclass.method_2();
				gclass.bool_2 = false;
				goto IL_164;
				IL_FD:
				awaiter.GetResult();
				awaiter = gclass.method_7(default(CancellationToken)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct252>(ref awaiter, ref this);
					return;
				}
				goto IL_B7;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_164:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0006BF24 File Offset: 0x0006A124
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001267 RID: 4711
		public int int_0;

		// Token: 0x04001268 RID: 4712
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001269 RID: 4713
		public GClass222 gclass222_0;

		// Token: 0x0400126A RID: 4714
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004A7 RID: 1191
	[StructLayout(LayoutKind.Auto)]
	private struct Struct253 : IAsyncStateMachine
	{
		// Token: 0x06001A3D RID: 6717 RVA: 0x0006BF34 File Offset: 0x0006A134
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass222 gclass = this.gclass222_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_D1;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_12F;
				}
				IL_1D:
				if (gclass.AnimationOpacity == 0.0)
				{
					gclass.AnimationVisibility = Visibility.Collapsed;
					goto IL_136;
				}
				gclass.AnimationOpacity -= 0.1;
				if (gclass.AnimationOpacity < 0.05)
				{
					gclass.AnimationOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct253>(ref awaiter, ref this);
					return;
				}
				IL_D1:
				awaiter.GetResult();
				goto IL_1D;
				IL_12F:
				awaiter.GetResult();
				IL_136:
				if (gclass.MainOpacity != 1.0)
				{
					gclass.MainOpacity += 0.13333333333333333;
					if (gclass.MainOpacity > 0.95)
					{
						gclass.MainOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_12F;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct253>(ref awaiter, ref this);
					return;
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

		// Token: 0x06001A3E RID: 6718 RVA: 0x0006C120 File Offset: 0x0006A320
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400126B RID: 4715
		public int int_0;

		// Token: 0x0400126C RID: 4716
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400126D RID: 4717
		public GClass222 gclass222_0;

		// Token: 0x0400126E RID: 4718
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004A8 RID: 1192
	[StructLayout(LayoutKind.Auto)]
	private struct Struct254 : IAsyncStateMachine
	{
		// Token: 0x06001A3F RID: 6719 RVA: 0x0006C130 File Offset: 0x0006A330
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass222 gclass = this.gclass222_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_E2;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_140;
				}
				IL_1D:
				if (gclass.StatusOpacity == 0.0)
				{
					gclass.StatusColor = this.solidColorBrush_0;
					gclass.StatusText = this.string_0;
					goto IL_147;
				}
				gclass.StatusOpacity -= 0.1;
				if (gclass.StatusOpacity < 0.05)
				{
					gclass.StatusOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct254>(ref awaiter, ref this);
					return;
				}
				IL_E2:
				awaiter.GetResult();
				goto IL_1D;
				IL_140:
				awaiter.GetResult();
				IL_147:
				if (gclass.StatusOpacity != 1.0)
				{
					gclass.StatusOpacity += 0.13333333333333333;
					if (gclass.StatusOpacity > 0.95)
					{
						gclass.StatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_140;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass222.Struct254>(ref awaiter, ref this);
					return;
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

		// Token: 0x06001A40 RID: 6720 RVA: 0x0006C32C File Offset: 0x0006A52C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400126F RID: 4719
		public int int_0;

		// Token: 0x04001270 RID: 4720
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001271 RID: 4721
		public GClass222 gclass222_0;

		// Token: 0x04001272 RID: 4722
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001273 RID: 4723
		public string string_0;

		// Token: 0x04001274 RID: 4724
		private TaskAwaiter taskAwaiter_0;
	}
}
