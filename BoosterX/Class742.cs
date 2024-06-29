using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

// Token: 0x020003C2 RID: 962
internal sealed class Class742 : GClass211
{
	// Token: 0x06001539 RID: 5433 RVA: 0x000582B0 File Offset: 0x000564B0
	public Class742(string string_0)
	{
		this.class503_0 = new Class503(string_0);
		this.method_4();
		this.method_1();
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x000582DC File Offset: 0x000564DC
	private void method_1()
	{
		this.list_0.Clear();
		bool flag = false;
		List<string> source = new List<string>();
		if (this.Affinity != null && this.Affinity != string.Empty)
		{
			source = this.Affinity.Split(new char[]
			{
				','
			}).ToList<string>();
		}
		else
		{
			flag = true;
		}
		bool showCoreType = Class250.list_0.Any(new Func<Class163, bool>(Class742.Class443.class443_0.method_0));
		using (List<Class163>.Enumerator enumerator = Class250.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class742.Class445 @class = new Class742.Class445();
				@class.class163_0 = enumerator.Current;
				this.list_0.Add(new Class756(null)
				{
					Core = @class.class163_0.Core,
					IsChosen = (flag || source.Any(new Func<string, bool>(@class.method_0))),
					Thread = @class.class163_0.Thread,
					IsECore = @class.class163_0.IsECore,
					ShowCoreType = showCoreType
				});
			}
		}
		this.method_2();
		this.list_0.ForEach(new Action<Class756>(this.method_5));
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x00058434 File Offset: 0x00056634
	private void method_2()
	{
		bool disableHyperThreading;
		if (Class250.bool_0)
		{
			disableHyperThreading = this.list_0.FindAll(new Predicate<Class756>(Class742.Class443.class443_0.method_1)).All(new Func<Class756, bool>(Class742.Class443.class443_0.method_2));
		}
		else
		{
			disableHyperThreading = false;
		}
		this.DisableHyperThreading = disableHyperThreading;
		this.DisableCore0 = this.list_0.FindAll(new Predicate<Class756>(Class742.Class443.class443_0.method_3)).All(new Func<Class756, bool>(Class742.Class443.class443_0.method_4));
		bool onlyPCores;
		if (Class250.int_3 != 0)
		{
			onlyPCores = this.list_0.FindAll(new Predicate<Class756>(Class742.Class443.class443_0.method_5)).All(new Func<Class756, bool>(Class742.Class443.class443_0.method_6));
		}
		else
		{
			onlyPCores = false;
		}
		this.OnlyPCores = onlyPCores;
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00058554 File Offset: 0x00056754
	private void method_3(object sender, PropertyChangedEventArgs p1)
	{
		Class742.Class444 @class = new Class742.Class444();
		@class.list_0 = new List<string>();
		this.list_0.FindAll(new Predicate<Class756>(Class742.Class443.class443_0.method_7)).ForEach(new Action<Class756>(@class.method_0));
		this.Affinity = string.Join(",", @class.list_0);
	}

	// Token: 0x170002E2 RID: 738
	// (get) Token: 0x0600153D RID: 5437 RVA: 0x000585C4 File Offset: 0x000567C4
	// (set) Token: 0x0600153E RID: 5438 RVA: 0x000585CC File Offset: 0x000567CC
	public bool DisableCore0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			Class742.Class441 @class = new Class742.Class441();
			@class.bool_0 = value;
			this.bool_0 = @class.bool_0;
			this.list_0.FindAll(new Predicate<Class756>(Class742.Class443.class443_0.method_8)).ForEach(new Action<Class756>(@class.method_0));
			base.method_0("DisableCore0");
		}
	}

	// Token: 0x170002E3 RID: 739
	// (get) Token: 0x0600153F RID: 5439 RVA: 0x00058638 File Offset: 0x00056838
	// (set) Token: 0x06001540 RID: 5440 RVA: 0x00058640 File Offset: 0x00056840
	public bool DisableHyperThreading
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			Class742.Class442 @class = new Class742.Class442();
			@class.bool_0 = value;
			this.bool_1 = @class.bool_0;
			this.list_0.FindAll(new Predicate<Class756>(Class742.Class443.class443_0.method_9)).ForEach(new Action<Class756>(@class.method_0));
			base.method_0("DisableHyperThreading");
		}
	}

	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x06001541 RID: 5441 RVA: 0x000586AC File Offset: 0x000568AC
	// (set) Token: 0x06001542 RID: 5442 RVA: 0x000586B4 File Offset: 0x000568B4
	public bool OnlyPCores
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			Class742.Class440 @class = new Class742.Class440();
			@class.bool_0 = value;
			this.bool_2 = @class.bool_0;
			this.list_0.FindAll(new Predicate<Class756>(Class742.Class443.class443_0.method_10)).ForEach(new Action<Class756>(@class.method_0));
			base.method_0("OnlyPCores");
		}
	}

	// Token: 0x170002E5 RID: 741
	// (get) Token: 0x06001543 RID: 5443 RVA: 0x00058720 File Offset: 0x00056920
	// (set) Token: 0x06001544 RID: 5444 RVA: 0x00058728 File Offset: 0x00056928
	public bool IsChecked
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.bool_3 = value;
			base.method_0("IsChecked");
		}
	}

	// Token: 0x170002E6 RID: 742
	// (get) Token: 0x06001545 RID: 5445 RVA: 0x0005873C File Offset: 0x0005693C
	public string Name
	{
		get
		{
			return this.class503_0.method_1();
		}
	}

	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x06001546 RID: 5446 RVA: 0x0005874C File Offset: 0x0005694C
	// (set) Token: 0x06001547 RID: 5447 RVA: 0x0005875C File Offset: 0x0005695C
	public string FoundIn
	{
		get
		{
			return this.class503_0.FoundIn;
		}
		set
		{
			this.class503_0.FoundIn = value;
			base.method_0("FoundIn");
		}
	}

	// Token: 0x170002E8 RID: 744
	// (get) Token: 0x06001548 RID: 5448 RVA: 0x00058778 File Offset: 0x00056978
	// (set) Token: 0x06001549 RID: 5449 RVA: 0x00058788 File Offset: 0x00056988
	public string ExeName
	{
		get
		{
			return this.class503_0.method_3();
		}
		set
		{
			this.class503_0.method_4(value);
			base.method_0("ExeName");
		}
	}

	// Token: 0x170002E9 RID: 745
	// (get) Token: 0x0600154A RID: 5450 RVA: 0x000587A4 File Offset: 0x000569A4
	// (set) Token: 0x0600154B RID: 5451 RVA: 0x000587B4 File Offset: 0x000569B4
	public string GamePath
	{
		get
		{
			return this.class503_0.method_5();
		}
		set
		{
			this.class503_0.method_6(value);
			base.method_0("GamePath");
		}
	}

	// Token: 0x170002EA RID: 746
	// (get) Token: 0x0600154C RID: 5452 RVA: 0x000587D0 File Offset: 0x000569D0
	// (set) Token: 0x0600154D RID: 5453 RVA: 0x000587E0 File Offset: 0x000569E0
	public string LaunchDelay
	{
		get
		{
			return this.class503_0.LaunchDelay;
		}
		set
		{
			this.class503_0.LaunchDelay = value;
			base.method_0("LaunchDelay");
		}
	}

	// Token: 0x170002EB RID: 747
	// (get) Token: 0x0600154E RID: 5454 RVA: 0x000587FC File Offset: 0x000569FC
	// (set) Token: 0x0600154F RID: 5455 RVA: 0x00058804 File Offset: 0x00056A04
	public BitmapSource Icon
	{
		get
		{
			return this.bitmapSource_0;
		}
		set
		{
			this.bitmapSource_0 = value;
			base.method_0("Icon");
		}
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x00058818 File Offset: 0x00056A18
	public void method_4()
	{
		Class742.Struct204 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class742_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class742.Struct204>(ref @struct);
	}

	// Token: 0x170002EC RID: 748
	// (get) Token: 0x06001551 RID: 5457 RVA: 0x00058850 File Offset: 0x00056A50
	// (set) Token: 0x06001552 RID: 5458 RVA: 0x00058860 File Offset: 0x00056A60
	public string Affinity
	{
		get
		{
			return this.class503_0.Affinity;
		}
		set
		{
			this.class503_0.Affinity = value;
			base.method_0("Affinity");
		}
	}

	// Token: 0x170002ED RID: 749
	// (get) Token: 0x06001553 RID: 5459 RVA: 0x0005887C File Offset: 0x00056A7C
	// (set) Token: 0x06001554 RID: 5460 RVA: 0x0005888C File Offset: 0x00056A8C
	public bool? DisableDWM
	{
		get
		{
			return this.class503_0.DisableDWM;
		}
		set
		{
			bool? useGlobalProfile = this.UseGlobalProfile;
			if (useGlobalProfile.GetValueOrDefault() & useGlobalProfile != null)
			{
				return;
			}
			this.class503_0.DisableDWM = value;
			base.method_0("DisableDWM");
		}
	}

	// Token: 0x170002EE RID: 750
	// (get) Token: 0x06001555 RID: 5461 RVA: 0x000588CC File Offset: 0x00056ACC
	// (set) Token: 0x06001556 RID: 5462 RVA: 0x000588DC File Offset: 0x00056ADC
	public bool? ThreadCompatibility
	{
		get
		{
			return this.class503_0.ThreadCompatibility;
		}
		set
		{
			if (value.Value)
			{
				this.DisableHyperThreading = false;
				this.DisableCore0 = false;
				this.list_0.ForEach(new Action<Class756>(Class742.Class443.class443_0.method_11));
				this.OnlyPCores = true;
			}
			this.class503_0.ThreadCompatibility = value;
			base.method_0("ThreadCompatibility");
		}
	}

	// Token: 0x170002EF RID: 751
	// (get) Token: 0x06001557 RID: 5463 RVA: 0x00058948 File Offset: 0x00056B48
	// (set) Token: 0x06001558 RID: 5464 RVA: 0x00058958 File Offset: 0x00056B58
	public bool? DisableExplorer
	{
		get
		{
			return this.class503_0.DisableExplorer;
		}
		set
		{
			bool? useGlobalProfile = this.UseGlobalProfile;
			if (useGlobalProfile.GetValueOrDefault() & useGlobalProfile != null)
			{
				return;
			}
			this.class503_0.DisableExplorer = value;
			base.method_0("DisableExplorer");
		}
	}

	// Token: 0x170002F0 RID: 752
	// (get) Token: 0x06001559 RID: 5465 RVA: 0x00058998 File Offset: 0x00056B98
	// (set) Token: 0x0600155A RID: 5466 RVA: 0x000589A8 File Offset: 0x00056BA8
	public bool? UseGlobalProfile
	{
		get
		{
			return this.class503_0.UseGlobalProfile;
		}
		set
		{
			bool? flag = value;
			if (flag.GetValueOrDefault() & flag != null)
			{
				this.DisableExplorer = null;
				this.DisableDWM = null;
			}
			this.class503_0.UseGlobalProfile = value;
			flag = value;
			if ((!flag.GetValueOrDefault() & flag != null) && (this.DisableExplorer == null || this.DisableDWM == null))
			{
				this.DisableExplorer = new bool?(true);
				this.DisableDWM = new bool?(false);
			}
			base.method_0("DisableExplorer");
			base.method_0("DisableDWM");
			base.method_0("UseGlobalProfile");
		}
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x00058A64 File Offset: 0x00056C64
	private void method_5(Class756 class756_0)
	{
		class756_0.PropertyChanged += this.method_3;
	}

	// Token: 0x04000D2D RID: 3373
	private Class503 class503_0;

	// Token: 0x04000D2E RID: 3374
	public List<Class756> list_0 = new List<Class756>();

	// Token: 0x04000D2F RID: 3375
	private bool bool_0;

	// Token: 0x04000D30 RID: 3376
	private bool bool_1;

	// Token: 0x04000D31 RID: 3377
	private bool bool_2;

	// Token: 0x04000D32 RID: 3378
	private bool bool_3;

	// Token: 0x04000D33 RID: 3379
	private BitmapSource bitmapSource_0;

	// Token: 0x020003C3 RID: 963
	[StructLayout(LayoutKind.Auto)]
	private struct Struct204 : IAsyncStateMachine
	{
		// Token: 0x0600155C RID: 5468 RVA: 0x00058A78 File Offset: 0x00056C78
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class742 @class = this.class742_0;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = Class197.smethod_0(@class.Name.EndsWith(".exe") ? @class.Name.Replace(".exe", string.Empty) : @class.Name).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class742.Struct204>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				string result = awaiter.GetResult();
				if (result != null && !(result == string.Empty))
				{
					@class.Icon = Class650.smethod_5(result);
				}
				else
				{
					@class.Icon = Class650.smethod_6(@class.GamePath);
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

		// Token: 0x0600155D RID: 5469 RVA: 0x00058B90 File Offset: 0x00056D90
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000D34 RID: 3380
		public int int_0;

		// Token: 0x04000D35 RID: 3381
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000D36 RID: 3382
		public Class742 class742_0;

		// Token: 0x04000D37 RID: 3383
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x020003C4 RID: 964
	private sealed class Class440
	{
		// Token: 0x0600155F RID: 5471 RVA: 0x00058BA8 File Offset: 0x00056DA8
		internal void method_0(Class756 class756_0)
		{
			class756_0.IsChosen = !this.bool_0;
		}

		// Token: 0x04000D38 RID: 3384
		public bool bool_0;
	}

	// Token: 0x020003C5 RID: 965
	private sealed class Class441
	{
		// Token: 0x06001561 RID: 5473 RVA: 0x00058BC4 File Offset: 0x00056DC4
		internal void method_0(Class756 class756_0)
		{
			class756_0.IsChosen = !this.bool_0;
		}

		// Token: 0x04000D39 RID: 3385
		public bool bool_0;
	}

	// Token: 0x020003C6 RID: 966
	private sealed class Class442
	{
		// Token: 0x06001563 RID: 5475 RVA: 0x00058BE0 File Offset: 0x00056DE0
		internal void method_0(Class756 class756_0)
		{
			class756_0.IsChosen = !this.bool_0;
		}

		// Token: 0x04000D3A RID: 3386
		public bool bool_0;
	}

	// Token: 0x020003C7 RID: 967
	[Serializable]
	private sealed class Class443
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x00058C08 File Offset: 0x00056E08
		internal bool method_0(Class163 class163_0)
		{
			return class163_0.IsECore;
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00058C10 File Offset: 0x00056E10
		internal bool method_1(Class756 class756_0)
		{
			return !class756_0.IsECore && class756_0.Thread % 2 == 1;
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00058C28 File Offset: 0x00056E28
		internal bool method_2(Class756 class756_0)
		{
			return !class756_0.IsChosen;
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00058C34 File Offset: 0x00056E34
		internal bool method_3(Class756 class756_0)
		{
			return class756_0.Core == 0;
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00058C40 File Offset: 0x00056E40
		internal bool method_4(Class756 class756_0)
		{
			return !class756_0.IsChosen;
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00058C4C File Offset: 0x00056E4C
		internal bool method_5(Class756 class756_0)
		{
			return class756_0.IsECore;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00058C54 File Offset: 0x00056E54
		internal bool method_6(Class756 class756_0)
		{
			return !class756_0.IsChosen;
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00058C60 File Offset: 0x00056E60
		internal bool method_7(Class756 class756_0)
		{
			return class756_0.IsChosen;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00058C68 File Offset: 0x00056E68
		internal bool method_8(Class756 class756_0)
		{
			return class756_0.Core == 0;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00058C74 File Offset: 0x00056E74
		internal bool method_9(Class756 class756_0)
		{
			return !class756_0.IsECore && class756_0.Thread % 2 == 1;
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00058C8C File Offset: 0x00056E8C
		internal bool method_10(Class756 class756_0)
		{
			return class756_0.IsECore;
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00058C94 File Offset: 0x00056E94
		internal void method_11(Class756 class756_0)
		{
			class756_0.IsChosen = true;
		}

		// Token: 0x04000D3B RID: 3387
		public static readonly Class742.Class443 class443_0 = new Class742.Class443();

		// Token: 0x04000D3C RID: 3388
		public static Func<Class163, bool> func_0;

		// Token: 0x04000D3D RID: 3389
		public static Predicate<Class756> predicate_0;

		// Token: 0x04000D3E RID: 3390
		public static Func<Class756, bool> func_1;

		// Token: 0x04000D3F RID: 3391
		public static Predicate<Class756> predicate_1;

		// Token: 0x04000D40 RID: 3392
		public static Func<Class756, bool> func_2;

		// Token: 0x04000D41 RID: 3393
		public static Predicate<Class756> predicate_2;

		// Token: 0x04000D42 RID: 3394
		public static Func<Class756, bool> func_3;

		// Token: 0x04000D43 RID: 3395
		public static Predicate<Class756> predicate_3;

		// Token: 0x04000D44 RID: 3396
		public static Predicate<Class756> predicate_4;

		// Token: 0x04000D45 RID: 3397
		public static Predicate<Class756> predicate_5;

		// Token: 0x04000D46 RID: 3398
		public static Predicate<Class756> predicate_6;

		// Token: 0x04000D47 RID: 3399
		public static Action<Class756> action_0;
	}

	// Token: 0x020003C8 RID: 968
	private sealed class Class444
	{
		// Token: 0x06001573 RID: 5491 RVA: 0x00058CA8 File Offset: 0x00056EA8
		internal void method_0(Class756 class756_0)
		{
			this.list_0.Add(class756_0.Thread.ToString());
		}

		// Token: 0x04000D48 RID: 3400
		public List<string> list_0;
	}

	// Token: 0x020003C9 RID: 969
	private sealed class Class445
	{
		// Token: 0x06001575 RID: 5493 RVA: 0x00058CD8 File Offset: 0x00056ED8
		internal bool method_0(string string_0)
		{
			return string_0 == this.class163_0.Thread.ToString();
		}

		// Token: 0x04000D49 RID: 3401
		public Class163 class163_0;
	}
}
