using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x020004B3 RID: 1203
internal sealed class Class752 : GClass211
{
	// Token: 0x06001A7C RID: 6780 RVA: 0x0006C9DC File Offset: 0x0006ABDC
	public Class752()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		this.InstallButtonContent = Class364.smethod_0("install");
		this.PopularCommand.Execute(null);
	}

	// Token: 0x06001A7E RID: 6782 RVA: 0x0006CAA0 File Offset: 0x0006ACA0
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("ColChanged");
	}

	// Token: 0x17000406 RID: 1030
	// (get) Token: 0x06001A7F RID: 6783 RVA: 0x0006CAB0 File Offset: 0x0006ACB0
	// (set) Token: 0x06001A80 RID: 6784 RVA: 0x0006CAB8 File Offset: 0x0006ACB8
	public bool AppXListIsEnabled
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("AppXListIsEnabled");
		}
	}

	// Token: 0x17000407 RID: 1031
	// (get) Token: 0x06001A81 RID: 6785 RVA: 0x0006CACC File Offset: 0x0006ACCC
	// (set) Token: 0x06001A82 RID: 6786 RVA: 0x0006CAD4 File Offset: 0x0006ACD4
	public ObservableCollection<Class754> AppXVMs
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("AppXVMs");
		}
	}

	// Token: 0x17000408 RID: 1032
	// (get) Token: 0x06001A83 RID: 6787 RVA: 0x0006CAE8 File Offset: 0x0006ACE8
	// (set) Token: 0x06001A84 RID: 6788 RVA: 0x0006CAF0 File Offset: 0x0006ACF0
	public ObservableCollection<Class754> AppXsInstallVMs
	{
		get
		{
			return this.observableCollection_1;
		}
		set
		{
			this.observableCollection_1 = value;
			base.method_0("AppXsInstallVMs");
		}
	}

	// Token: 0x17000409 RID: 1033
	// (get) Token: 0x06001A85 RID: 6789 RVA: 0x0006CB04 File Offset: 0x0006AD04
	// (set) Token: 0x06001A86 RID: 6790 RVA: 0x0006CB0C File Offset: 0x0006AD0C
	public string SearchText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("SearchText");
		}
	}

	// Token: 0x1700040A RID: 1034
	// (get) Token: 0x06001A87 RID: 6791 RVA: 0x0006CB20 File Offset: 0x0006AD20
	public GClass134 SearchCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_7), null));
			}
			return result;
		}
	}

	// Token: 0x1700040B RID: 1035
	// (get) Token: 0x06001A88 RID: 6792 RVA: 0x0006CB54 File Offset: 0x0006AD54
	public GClass134 GoBackCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_1) == null)
			{
				result = (this.gclass134_1 = new GClass134(new Action<object>(Class752.Class567.class567_0.method_0), null));
			}
			return result;
		}
	}

	// Token: 0x1700040C RID: 1036
	// (get) Token: 0x06001A89 RID: 6793 RVA: 0x0006CB9C File Offset: 0x0006AD9C
	// (set) Token: 0x06001A8A RID: 6794 RVA: 0x0006CBA4 File Offset: 0x0006ADA4
	public string InstallButtonContent
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("InstallButtonContent");
		}
	}

	// Token: 0x1700040D RID: 1037
	// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0006CBB8 File Offset: 0x0006ADB8
	// (set) Token: 0x06001A8C RID: 6796 RVA: 0x0006CBC0 File Offset: 0x0006ADC0
	public bool InstallButtonIsChecked
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			this.bool_4 = value;
			base.method_0("InstallButtonIsChecked");
			this.method_1(value);
		}
	}

	// Token: 0x06001A8D RID: 6797 RVA: 0x0006CBDC File Offset: 0x0006ADDC
	private void method_1(bool bool_7)
	{
		Class752.Struct262 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class752_0 = this;
		@struct.bool_0 = bool_7;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class752.Struct262>(ref @struct);
	}

	// Token: 0x06001A8E RID: 6798 RVA: 0x0006CC1C File Offset: 0x0006AE1C
	public void method_2()
	{
		this.bool_1 = true;
		try
		{
			List<string> list = Directory.GetFiles(Class186.string_10).ToList<string>();
			Action<string> action;
			if ((action = Class752.Class566.action_0) == null)
			{
				action = (Class752.Class566.action_0 = new Action<string>(File.Delete));
			}
			list.ForEach(action);
		}
		catch (Exception exception_)
		{
			GClass141.smethod_0(exception_);
		}
	}

	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x06001A8F RID: 6799 RVA: 0x0006CC78 File Offset: 0x0006AE78
	// (set) Token: 0x06001A90 RID: 6800 RVA: 0x0006CC80 File Offset: 0x0006AE80
	public bool PopularButtonIsEnabled
	{
		get
		{
			return this.bool_5;
		}
		set
		{
			this.bool_5 = value;
			base.method_0("PopularButtonIsEnabled");
		}
	}

	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x06001A91 RID: 6801 RVA: 0x0006CC94 File Offset: 0x0006AE94
	public GClass134 PopularCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_2) == null)
			{
				result = (this.gclass134_2 = new GClass134(new Action<object>(this.method_11), null));
			}
			return result;
		}
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x0006CCC8 File Offset: 0x0006AEC8
	public Task method_3()
	{
		Class752.Struct260 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class752_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class752.Struct260>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001A93 RID: 6803 RVA: 0x0006CD0C File Offset: 0x0006AF0C
	public Task method_4()
	{
		Class752.Struct255 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class752_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class752.Struct255>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x17000410 RID: 1040
	// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0006CD50 File Offset: 0x0006AF50
	// (set) Token: 0x06001A95 RID: 6805 RVA: 0x0006CD58 File Offset: 0x0006AF58
	public double ProgressOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("ProgressOpacity");
		}
	}

	// Token: 0x17000411 RID: 1041
	// (get) Token: 0x06001A96 RID: 6806 RVA: 0x0006CD6C File Offset: 0x0006AF6C
	// (set) Token: 0x06001A97 RID: 6807 RVA: 0x0006CD74 File Offset: 0x0006AF74
	public Visibility ProgressVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("ProgressVisibility");
		}
	}

	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0006CD88 File Offset: 0x0006AF88
	// (set) Token: 0x06001A99 RID: 6809 RVA: 0x0006CD90 File Offset: 0x0006AF90
	public double ProgressValue
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
			base.method_0("ProgressValue");
		}
	}

	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x06001A9A RID: 6810 RVA: 0x0006CDA4 File Offset: 0x0006AFA4
	// (set) Token: 0x06001A9B RID: 6811 RVA: 0x0006CDAC File Offset: 0x0006AFAC
	public string ProgressText
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("ProgressText");
		}
	}

	// Token: 0x17000414 RID: 1044
	// (get) Token: 0x06001A9C RID: 6812 RVA: 0x0006CDC0 File Offset: 0x0006AFC0
	// (set) Token: 0x06001A9D RID: 6813 RVA: 0x0006CDC8 File Offset: 0x0006AFC8
	public string InstallStatusText
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
			base.method_0("InstallStatusText");
		}
	}

	// Token: 0x17000415 RID: 1045
	// (get) Token: 0x06001A9E RID: 6814 RVA: 0x0006CDDC File Offset: 0x0006AFDC
	// (set) Token: 0x06001A9F RID: 6815 RVA: 0x0006CDE4 File Offset: 0x0006AFE4
	public SolidColorBrush InstallStatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("InstallStatusColor");
		}
	}

	// Token: 0x17000416 RID: 1046
	// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0006CDF8 File Offset: 0x0006AFF8
	// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0006CE00 File Offset: 0x0006B000
	public double InstallStatusOpacity
	{
		get
		{
			return this.double_2;
		}
		set
		{
			this.double_2 = value;
			base.method_0("InstallStatusOpacity");
		}
	}

	// Token: 0x06001AA2 RID: 6818 RVA: 0x0006CE14 File Offset: 0x0006B014
	public void method_5(string string_5, SolidColorBrush solidColorBrush_2)
	{
		Class752.Struct263 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class752_0 = this;
		@struct.string_0 = string_5;
		@struct.solidColorBrush_0 = solidColorBrush_2;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class752.Struct263>(ref @struct);
	}

	// Token: 0x17000417 RID: 1047
	// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x0006CE5C File Offset: 0x0006B05C
	// (set) Token: 0x06001AA4 RID: 6820 RVA: 0x0006CE64 File Offset: 0x0006B064
	public string StatusText
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x17000418 RID: 1048
	// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x0006CE78 File Offset: 0x0006B078
	// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x0006CE80 File Offset: 0x0006B080
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_1;
		}
		set
		{
			this.solidColorBrush_1 = value;
			base.method_0("StatusColor");
		}
	}

	// Token: 0x17000419 RID: 1049
	// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x0006CE94 File Offset: 0x0006B094
	// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x0006CE9C File Offset: 0x0006B09C
	public double StatusOpacity
	{
		get
		{
			return this.double_3;
		}
		set
		{
			this.double_3 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x0006CEB0 File Offset: 0x0006B0B0
	private void method_6(string string_5, SolidColorBrush solidColorBrush_2)
	{
		Class752.Struct256 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class752_0 = this;
		@struct.string_0 = string_5;
		@struct.solidColorBrush_0 = solidColorBrush_2;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class752.Struct256>(ref @struct);
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x0006CEF8 File Offset: 0x0006B0F8
	private void method_7(object object_0)
	{
		if (!this.bool_3 && !(this.SearchText == Class364.smethod_0("SearchAllStore")) && !(this.SearchText == string.Empty))
		{
			Task.Run(new Func<Task>(this.method_8));
			return;
		}
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x0006CF4C File Offset: 0x0006B14C
	private Task method_8()
	{
		Class752.Struct261 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class752_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class752.Struct261>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x0006CF90 File Offset: 0x0006B190
	private void method_9(Class754 class754_0)
	{
		this.AppXVMs.Add(class754_0);
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x0006CFA0 File Offset: 0x0006B1A0
	private Task method_10()
	{
		Class752.Struct257 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class752_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class752.Struct257>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001AAE RID: 6830 RVA: 0x0006CFE4 File Offset: 0x0006B1E4
	private void method_11(object object_0)
	{
		if (this.bool_6)
		{
			return;
		}
		this.method_6(Class364.smethod_0("popular"), Brushes.White);
		Application.Current.Dispatcher.Invoke(new Action(this.method_12));
	}

	// Token: 0x06001AAF RID: 6831 RVA: 0x0006D020 File Offset: 0x0006B220
	private void method_12()
	{
		this.bool_6 = true;
		this.AppXVMs.Clear();
		Class754 item = new Class754(this)
		{
			AppXName = "NVIDIA Control Panel",
			AppXProductID = "9NF8H0H7WMLT",
			AppXIcon = Class397.smethod_1("https://store-images.s-microsoft.com/image/apps.20966.13599037783181022.b05b7adf-6b7a-44ae-9a70-9dc9370ea7e6.4cd88c60-6ff1-4b0f-aed6-8e2efa5629c1"),
			AppXAverageRating = "4.9"
		};
		this.AppXVMs.Add(item);
		Class754 item2 = new Class754(this)
		{
			AppXName = "Intel® Graphics Command Center",
			AppXProductID = "9PLFNLNT3G5G",
			AppXIcon = Class397.smethod_1("https://store-images.s-microsoft.com/image/apps.22002.14318846362781107.472babb5-aec4-4502-a619-ffbe2ee169d0.8218d196-46bc-4137-97c1-e1c26e8f8b98"),
			AppXAverageRating = "4.4"
		};
		this.AppXVMs.Add(item2);
		Class754 item3 = new Class754(this)
		{
			AppXName = "EarTrumpet",
			AppXProductID = "9NBLGGH516XP",
			AppXIcon = Class397.smethod_1("https://store-images.s-microsoft.com/image/apps.50137.13510798887629242.fde3f4b7-ddb2-475b-aabf-ff422a1a22df.9afc66c4-1c87-44f8-ba5e-6cde87df617d"),
			AppXAverageRating = "4.6"
		};
		this.AppXVMs.Add(item3);
		Class754 item4 = new Class754(this)
		{
			AppXName = "Yandex.Music",
			AppXProductID = "9NBLGGH0CB6D",
			AppXIcon = Class397.smethod_1("https://store-images.s-microsoft.com/image/apps.2465.13510798882805719.3f5d017d-a79f-4f62-ad22-aee707e0ebd0.0620b3ee-ff33-447a-b654-eaa47d20d4a6"),
			AppXAverageRating = "4.7"
		};
		this.AppXVMs.Add(item4);
		Class754 item5 = new Class754(this)
		{
			AppXName = "Telegram Desktop",
			AppXProductID = "9NZTWSQNTD0S",
			AppXIcon = Class397.smethod_1("https://store-images.s-microsoft.com/image/apps.55784.14473651905739879.7e8ace6f-b86f-4bec-9f23-d539d439d019.be0af39d-bd1f-4dc6-af9f-0791118700e8"),
			AppXAverageRating = "4.8"
		};
		this.AppXVMs.Add(item5);
		Class754 item6 = new Class754(this)
		{
			AppXName = "VK Messenger",
			AppXProductID = "9PMJG1606PSH",
			AppXIcon = Class397.smethod_1("https://store-images.s-microsoft.com/image/apps.16056.14297064179277156.9154fe5e-0f0e-4f47-8a3e-d62afa55cb1c.60edf27b-455c-498b-8552-6bb01d5c882a"),
			AppXAverageRating = "3.9"
		};
		this.AppXVMs.Add(item6);
		Class754 item7 = new Class754(this)
		{
			AppXName = "Instagram",
			AppXProductID = "9NBLGGH5L9XT",
			AppXIcon = Class397.smethod_1("https://store-images.s-microsoft.com/image/apps.31997.13510798887167234.6cd52261-a276-49cf-9b6b-9ef8491fb799.30e70ce4-33c5-43d6-9af1-491fe4679377"),
			AppXAverageRating = "4"
		};
		this.AppXVMs.Add(item7);
		Class754 item8 = new Class754(this)
		{
			AppXName = "TikTok",
			AppXProductID = "9NH2GPH4JZS4",
			AppXIcon = Class397.smethod_1("https://store-images.s-microsoft.com/image/apps.47495.13634052595610511.c45457c9-b4af-46b0-8e61-8d7c0aec3f56.a8b71481-8a43-465d-88d6-e63add92c112"),
			AppXAverageRating = "3.9"
		};
		this.AppXVMs.Add(item8);
		this.bool_6 = false;
	}

	// Token: 0x06001AB0 RID: 6832 RVA: 0x0006D270 File Offset: 0x0006B470
	private Task method_13()
	{
		Class752.Struct259 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class752_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class752.Struct259>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001AB1 RID: 6833 RVA: 0x0006D2B4 File Offset: 0x0006B4B4
	private Task method_14()
	{
		Class752.Struct264 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class752_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class752.Struct264>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04001294 RID: 4756
	private bool bool_0 = true;

	// Token: 0x04001295 RID: 4757
	private ObservableCollection<Class754> observableCollection_0 = new ObservableCollection<Class754>();

	// Token: 0x04001296 RID: 4758
	private ObservableCollection<Class754> observableCollection_1 = new ObservableCollection<Class754>();

	// Token: 0x04001297 RID: 4759
	public bool bool_1;

	// Token: 0x04001298 RID: 4760
	private bool bool_2;

	// Token: 0x04001299 RID: 4761
	private string string_0 = Class364.smethod_0("SearchAllStore");

	// Token: 0x0400129A RID: 4762
	private bool bool_3;

	// Token: 0x0400129B RID: 4763
	private GClass134 gclass134_0;

	// Token: 0x0400129C RID: 4764
	private GClass134 gclass134_1;

	// Token: 0x0400129D RID: 4765
	private string string_1;

	// Token: 0x0400129E RID: 4766
	private bool bool_4;

	// Token: 0x0400129F RID: 4767
	private static CancellationTokenSource cancellationTokenSource_0 = new CancellationTokenSource();

	// Token: 0x040012A0 RID: 4768
	private static CancellationToken cancellationToken_0 = Class752.cancellationTokenSource_0.Token;

	// Token: 0x040012A1 RID: 4769
	private bool bool_5;

	// Token: 0x040012A2 RID: 4770
	private bool bool_6;

	// Token: 0x040012A3 RID: 4771
	private GClass134 gclass134_2;

	// Token: 0x040012A4 RID: 4772
	private double double_0;

	// Token: 0x040012A5 RID: 4773
	private Visibility visibility_0 = Visibility.Collapsed;

	// Token: 0x040012A6 RID: 4774
	private double double_1;

	// Token: 0x040012A7 RID: 4775
	private string string_2;

	// Token: 0x040012A8 RID: 4776
	private string string_3 = string.Empty;

	// Token: 0x040012A9 RID: 4777
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x040012AA RID: 4778
	private double double_2;

	// Token: 0x040012AB RID: 4779
	private string string_4 = string.Empty;

	// Token: 0x040012AC RID: 4780
	private SolidColorBrush solidColorBrush_1 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x040012AD RID: 4781
	private double double_3;

	// Token: 0x020004B4 RID: 1204
	[StructLayout(LayoutKind.Auto)]
	private struct Struct255 : IAsyncStateMachine
	{
		// Token: 0x06001AB2 RID: 6834 RVA: 0x0006D2F8 File Offset: 0x0006B4F8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class752 @object = this.class752_0;
			try
			{
				TaskAwaiter<Task> awaiter;
				if (num != 0)
				{
					awaiter = Application.Current.Dispatcher.InvokeAsync<Task>(new Func<Task>(@object.method_14)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class752.Struct255>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Task>);
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

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0006D3C0 File Offset: 0x0006B5C0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012AE RID: 4782
		public int int_0;

		// Token: 0x040012AF RID: 4783
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040012B0 RID: 4784
		public Class752 class752_0;

		// Token: 0x040012B1 RID: 4785
		private TaskAwaiter<Task> taskAwaiter_0;
	}

	// Token: 0x020004B5 RID: 1205
	[StructLayout(LayoutKind.Auto)]
	private struct Struct256 : IAsyncStateMachine
	{
		// Token: 0x06001AB4 RID: 6836 RVA: 0x0006D3D0 File Offset: 0x0006B5D0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class752 @class = this.class752_0;
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
				if (@class.StatusOpacity == 0.0)
				{
					@class.StatusColor = this.solidColorBrush_0;
					@class.StatusText = this.string_0;
					goto IL_147;
				}
				@class.StatusOpacity -= 0.1;
				if (@class.StatusOpacity < 0.05)
				{
					@class.StatusOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class752.Struct256>(ref awaiter, ref this);
					return;
				}
				IL_E2:
				awaiter.GetResult();
				goto IL_1D;
				IL_140:
				awaiter.GetResult();
				IL_147:
				if (@class.StatusOpacity != 1.0)
				{
					@class.StatusOpacity += 0.13333333333333333;
					if (@class.StatusOpacity > 0.95)
					{
						@class.StatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_140;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class752.Struct256>(ref awaiter, ref this);
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

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0006D5CC File Offset: 0x0006B7CC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012B2 RID: 4786
		public int int_0;

		// Token: 0x040012B3 RID: 4787
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040012B4 RID: 4788
		public Class752 class752_0;

		// Token: 0x040012B5 RID: 4789
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040012B6 RID: 4790
		public string string_0;

		// Token: 0x040012B7 RID: 4791
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004B6 RID: 1206
	[StructLayout(LayoutKind.Auto)]
	private struct Struct257 : IAsyncStateMachine
	{
		// Token: 0x06001AB6 RID: 6838 RVA: 0x0006D5DC File Offset: 0x0006B7DC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class752 @class = this.class752_0;
			try
			{
				if (num > 1)
				{
					Class468.smethod_0().method_2();
					Class468.smethod_0().method_14();
					this.ienumerator_0 = @class.AppXsInstallVMs.GetEnumerator();
				}
				try
				{
					if (num == 0)
					{
						goto IL_129;
					}
					if (num != 1)
					{
						goto IL_101;
					}
					TaskAwaiter awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					IL_A8:
					awaiter.GetResult();
					this.class754_0.method_3(Class364.smethod_0("storexerror2"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
					@class.InstallButtonContent = Class364.smethod_0("install");
					@class.bool_2 = false;
					this.class754_0.bool_0 = false;
					@class.AppXListIsEnabled = true;
					IL_F3:
					this.object_0 = null;
					this.class754_0 = null;
					IL_101:
					if (!this.ienumerator_0.MoveNext())
					{
						goto IL_1F7;
					}
					this.class754_0 = this.ienumerator_0.Current;
					this.int_1 = 0;
					try
					{
						IL_129:
						if (num != 0)
						{
							awaiter = Class426.smethod_4(this.class754_0, @class, Class752.cancellationToken_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.int_0 = num3;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class752.Struct257>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.int_0 = num4;
						}
						awaiter.GetResult();
						goto IL_70;
					}
					catch (Exception ex)
					{
						this.object_0 = ex;
						this.int_1 = 1;
						goto IL_70;
					}
					goto IL_1B1;
					IL_70:
					int num5 = this.int_1;
					if (num5 != 1)
					{
						goto IL_F3;
					}
					GClass141.smethod_0((Exception)this.object_0);
					awaiter = @class.method_4().GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_A8;
					}
					IL_1B1:
					int num6 = 1;
					num = 1;
					this.int_0 = num6;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class752.Struct257>(ref awaiter, ref this);
					return;
				}
				finally
				{
					if (num < 0 && this.ienumerator_0 != null)
					{
						this.ienumerator_0.Dispose();
					}
				}
				IL_1F7:
				this.ienumerator_0 = null;
				@class.method_6(Class364.smethod_0("storexins6"), Brushes.White);
				Class468.smethod_0().method_16();
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

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0006D888 File Offset: 0x0006BA88
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012B8 RID: 4792
		public int int_0;

		// Token: 0x040012B9 RID: 4793
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040012BA RID: 4794
		public Class752 class752_0;

		// Token: 0x040012BB RID: 4795
		private IEnumerator<Class754> ienumerator_0;

		// Token: 0x040012BC RID: 4796
		private Class754 class754_0;

		// Token: 0x040012BD RID: 4797
		private object object_0;

		// Token: 0x040012BE RID: 4798
		private int int_1;

		// Token: 0x040012BF RID: 4799
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004B7 RID: 1207
	private sealed class Class565
	{
		// Token: 0x06001AB9 RID: 6841 RVA: 0x0006D8A0 File Offset: 0x0006BAA0
		internal Task method_0()
		{
			Class752.Class565.Struct258 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class565_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class752.Class565.Struct258>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040012C0 RID: 4800
		public Class752 class752_0;

		// Token: 0x040012C1 RID: 4801
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040012C2 RID: 4802
		public string string_0;

		// Token: 0x020004B8 RID: 1208
		[StructLayout(LayoutKind.Auto)]
		private struct Struct258 : IAsyncStateMachine
		{
			// Token: 0x06001ABA RID: 6842 RVA: 0x0006D8E4 File Offset: 0x0006BAE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class752.Class565 @class = this.class565_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_105;
					}
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_177;
					}
					IL_1D:
					if (@class.class752_0.InstallStatusOpacity == 0.0)
					{
						@class.class752_0.InstallStatusColor = @class.solidColorBrush_0;
						@class.class752_0.InstallStatusText = @class.string_0;
						goto IL_17E;
					}
					@class.class752_0.InstallStatusOpacity = @class.class752_0.InstallStatusOpacity - 0.1;
					if (@class.class752_0.InstallStatusOpacity < 0.05)
					{
						@class.class752_0.InstallStatusOpacity = 0.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class752.Class565.Struct258>(ref awaiter, ref this);
						return;
					}
					IL_105:
					awaiter.GetResult();
					goto IL_1D;
					IL_177:
					awaiter.GetResult();
					IL_17E:
					if (@class.class752_0.InstallStatusOpacity != 1.0)
					{
						@class.class752_0.InstallStatusOpacity = @class.class752_0.InstallStatusOpacity + 0.13333333333333333;
						if (@class.class752_0.InstallStatusOpacity > 0.95)
						{
							@class.class752_0.InstallStatusOpacity = 1.0;
						}
						awaiter = Task.Delay(10).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_177;
						}
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class752.Class565.Struct258>(ref awaiter, ref this);
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

			// Token: 0x06001ABB RID: 6843 RVA: 0x0006DB1C File Offset: 0x0006BD1C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040012C3 RID: 4803
			public int int_0;

			// Token: 0x040012C4 RID: 4804
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040012C5 RID: 4805
			public Class752.Class565 class565_0;

			// Token: 0x040012C6 RID: 4806
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x020004B9 RID: 1209
	[StructLayout(LayoutKind.Auto)]
	private struct Struct259 : IAsyncStateMachine
	{
		// Token: 0x06001ABC RID: 6844 RVA: 0x0006DB2C File Offset: 0x0006BD2C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class752 @class = this.class752_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_A7;
				}
				@class.ProgressVisibility = Visibility.Visible;
				IL_1B:
				if (@class.ProgressOpacity == 1.0)
				{
					goto IL_F0;
				}
				@class.ProgressOpacity += 0.13333333333333333;
				if (@class.ProgressOpacity > 0.95)
				{
					@class.ProgressOpacity = 1.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class752.Struct259>(ref awaiter, ref this);
					return;
				}
				IL_A7:
				awaiter.GetResult();
				goto IL_1B;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_F0:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0006DC4C File Offset: 0x0006BE4C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012C7 RID: 4807
		public int int_0;

		// Token: 0x040012C8 RID: 4808
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040012C9 RID: 4809
		public Class752 class752_0;

		// Token: 0x040012CA RID: 4810
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004BA RID: 1210
	private static class Class566
	{
		// Token: 0x040012CB RID: 4811
		public static Action<string> action_0;
	}

	// Token: 0x020004BB RID: 1211
	[StructLayout(LayoutKind.Auto)]
	private struct Struct260 : IAsyncStateMachine
	{
		// Token: 0x06001ABE RID: 6846 RVA: 0x0006DC5C File Offset: 0x0006BE5C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class752 @object = this.class752_0;
			try
			{
				TaskAwaiter<Task> awaiter;
				if (num != 0)
				{
					awaiter = Application.Current.Dispatcher.InvokeAsync<Task>(new Func<Task>(@object.method_13)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class752.Struct260>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Task>);
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

		// Token: 0x06001ABF RID: 6847 RVA: 0x0006DD24 File Offset: 0x0006BF24
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012CC RID: 4812
		public int int_0;

		// Token: 0x040012CD RID: 4813
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040012CE RID: 4814
		public Class752 class752_0;

		// Token: 0x040012CF RID: 4815
		private TaskAwaiter<Task> taskAwaiter_0;
	}

	// Token: 0x020004BC RID: 1212
	[Serializable]
	private sealed class Class567
	{
		// Token: 0x06001AC2 RID: 6850 RVA: 0x0006DD48 File Offset: 0x0006BF48
		internal void method_0(object object_0)
		{
			Class358.smethod_0().method_3(typeof(dje_zA6HRDGVQ449XDH4D5NPJHBXAQ5BZC26NDGXJQ5PLSURH2QZ_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x040012D0 RID: 4816
		public static readonly Class752.Class567 class567_0 = new Class752.Class567();

		// Token: 0x040012D1 RID: 4817
		public static Action<object> action_0;
	}

	// Token: 0x020004BD RID: 1213
	[StructLayout(LayoutKind.Auto)]
	private struct Struct261 : IAsyncStateMachine
	{
		// Token: 0x06001AC3 RID: 6851 RVA: 0x0006DD68 File Offset: 0x0006BF68
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class752 @class = this.class752_0;
			try
			{
				TaskAwaiter<List<Class754>> awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<List<Class754>>);
					this.int_0 = -1;
					goto IL_EF;
				}
				TaskAwaiter awaiter2;
				if (num != 1)
				{
					this.class568_0 = new Class752.Class568();
					this.class568_0.class752_0 = @class;
					@class.bool_3 = true;
					@class.PopularButtonIsEnabled = false;
					@class.method_6(Class364.smethod_0("Searching"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					awaiter = Class426.smethod_0(@class.SearchText, @class).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class754>>, Class752.Struct261>(ref awaiter, ref this);
						return;
					}
					goto IL_EF;
				}
				else
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_B4:
				awaiter2.GetResult();
				@class.PopularCommand.Execute(null);
				@class.bool_3 = false;
				goto IL_1D9;
				IL_EF:
				List<Class754> result = awaiter.GetResult();
				this.class568_0.list_0 = result;
				if (this.class568_0.list_0.Count == 0)
				{
					@class.method_6(Class364.smethod_0("notfoundapp"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					awaiter2 = Task.Delay(1500).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class752.Struct261>(ref awaiter2, ref this);
						return;
					}
					goto IL_B4;
				}
				else
				{
					Application.Current.Dispatcher.Invoke(new Action(this.class568_0.method_0));
					@class.method_6(Class364.smethod_0("FoundFromQuery"), Brushes.White);
					@class.PopularButtonIsEnabled = true;
					@class.bool_3 = false;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class568_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1D9:
			this.int_0 = -2;
			this.class568_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x0006DF84 File Offset: 0x0006C184
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012D2 RID: 4818
		public int int_0;

		// Token: 0x040012D3 RID: 4819
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040012D4 RID: 4820
		public Class752 class752_0;

		// Token: 0x040012D5 RID: 4821
		private Class752.Class568 class568_0;

		// Token: 0x040012D6 RID: 4822
		private TaskAwaiter<List<Class754>> taskAwaiter_0;

		// Token: 0x040012D7 RID: 4823
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020004BE RID: 1214
	private sealed class Class568
	{
		// Token: 0x06001AC6 RID: 6854 RVA: 0x0006DF9C File Offset: 0x0006C19C
		internal void method_0()
		{
			this.class752_0.AppXVMs.Clear();
			this.list_0.ForEach(new Action<Class754>(this.class752_0.method_9));
		}

		// Token: 0x040012D8 RID: 4824
		public List<Class754> list_0;

		// Token: 0x040012D9 RID: 4825
		public Class752 class752_0;
	}

	// Token: 0x020004BF RID: 1215
	[StructLayout(LayoutKind.Auto)]
	private struct Struct262 : IAsyncStateMachine
	{
		// Token: 0x06001AC7 RID: 6855 RVA: 0x0006DFCC File Offset: 0x0006C1CC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class752 @class = this.class752_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num != 1)
					{
						if (!this.bool_0)
						{
							if (!@class.bool_2)
							{
								goto IL_17F;
							}
							@class.bool_2 = false;
							Class752.cancellationTokenSource_0.Cancel();
							@class.method_5(Class364.smethod_0("cancelappxinstall"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
							awaiter = Task.Delay(1500).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class752.Struct262>(ref awaiter, ref this);
								return;
							}
							goto IL_178;
						}
						else
						{
							@class.InstallButtonContent = Class364.smethod_0("cancel");
							@class.method_5(Class364.smethod_0("storexins1"), Brushes.White);
							@class.bool_2 = true;
							@class.AppXListIsEnabled = false;
							awaiter = Task.Run(new Func<Task>(@class.method_10)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class752.Struct262>(ref awaiter, ref this);
								return;
							}
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					@class.method_6(Class364.smethod_0("finished"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					@class.bool_2 = false;
					@class.InstallButtonIsChecked = false;
					goto IL_1D2;
				}
				awaiter = this.taskAwaiter_0;
				this.taskAwaiter_0 = default(TaskAwaiter);
				this.int_0 = -1;
				IL_178:
				awaiter.GetResult();
				IL_17F:
				@class.AppXListIsEnabled = true;
				@class.InstallButtonContent = Class364.smethod_0("install");
				@class.method_5(string.Empty, Brushes.White);
				@class.AppXListIsEnabled = true;
				@class.method_2();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1D2:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0006E1DC File Offset: 0x0006C3DC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012DA RID: 4826
		public int int_0;

		// Token: 0x040012DB RID: 4827
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040012DC RID: 4828
		public bool bool_0;

		// Token: 0x040012DD RID: 4829
		public Class752 class752_0;

		// Token: 0x040012DE RID: 4830
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004C0 RID: 1216
	[StructLayout(LayoutKind.Auto)]
	private struct Struct263 : IAsyncStateMachine
	{
		// Token: 0x06001AC9 RID: 6857 RVA: 0x0006E1EC File Offset: 0x0006C3EC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<Task> awaiter;
				if (num != 0)
				{
					Class752.Class565 @class = new Class752.Class565();
					@class.class752_0 = this.class752_0;
					@class.solidColorBrush_0 = this.solidColorBrush_0;
					@class.string_0 = this.string_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync<Task>(new Func<Task>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class752.Struct263>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Task>);
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

		// Token: 0x06001ACA RID: 6858 RVA: 0x0006E2D8 File Offset: 0x0006C4D8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012DF RID: 4831
		public int int_0;

		// Token: 0x040012E0 RID: 4832
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040012E1 RID: 4833
		public Class752 class752_0;

		// Token: 0x040012E2 RID: 4834
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040012E3 RID: 4835
		public string string_0;

		// Token: 0x040012E4 RID: 4836
		private TaskAwaiter<Task> taskAwaiter_0;
	}

	// Token: 0x020004C1 RID: 1217
	[StructLayout(LayoutKind.Auto)]
	private struct Struct264 : IAsyncStateMachine
	{
		// Token: 0x06001ACB RID: 6859 RVA: 0x0006E2E8 File Offset: 0x0006C4E8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class752 @class = this.class752_0;
			try
			{
				if (num != 0)
				{
					goto IL_8E;
				}
				TaskAwaiter awaiter = this.taskAwaiter_0;
				this.taskAwaiter_0 = default(TaskAwaiter);
				this.int_0 = -1;
				IL_87:
				awaiter.GetResult();
				IL_8E:
				if (@class.ProgressOpacity == 0.0)
				{
					@class.ProgressVisibility = Visibility.Collapsed;
				}
				else
				{
					@class.ProgressOpacity -= 0.1;
					if (@class.ProgressOpacity < 0.05)
					{
						@class.ProgressOpacity = 0.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_87;
					}
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class752.Struct264>(ref awaiter, ref this);
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

		// Token: 0x06001ACC RID: 6860 RVA: 0x0006E404 File Offset: 0x0006C604
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012E5 RID: 4837
		public int int_0;

		// Token: 0x040012E6 RID: 4838
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040012E7 RID: 4839
		public Class752 class752_0;

		// Token: 0x040012E8 RID: 4840
		private TaskAwaiter taskAwaiter_0;
	}
}
