using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Microsoft.Win32;
using Newtonsoft.Json;
using ns0;

// Token: 0x02000564 RID: 1380
internal sealed class Class755 : GClass211
{
	// Token: 0x06001E00 RID: 7680 RVA: 0x0007D8CC File Offset: 0x0007BACC
	public Class755()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_1_CollectionChanged;
		this.observableCollection_1.CollectionChanged += this.observableCollection_1_CollectionChanged;
		this.method_1();
		this.method_2();
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x0007D948 File Offset: 0x0007BB48
	private void observableCollection_1_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("CloudCount");
		base.method_0("ColChanged");
	}

	// Token: 0x170004AE RID: 1198
	// (get) Token: 0x06001E02 RID: 7682 RVA: 0x0007D960 File Offset: 0x0007BB60
	public string CloudCount
	{
		get
		{
			return this.CloudProfiles.Count.ToString() + "/10";
		}
	}

	// Token: 0x170004AF RID: 1199
	// (get) Token: 0x06001E03 RID: 7683 RVA: 0x0007D98C File Offset: 0x0007BB8C
	// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0007D994 File Offset: 0x0007BB94
	public Class734 ChoosenForImport
	{
		get
		{
			return this.class734_0;
		}
		set
		{
			this.class734_0 = value;
			base.method_0("ChoosenForImport");
		}
	}

	// Token: 0x170004B0 RID: 1200
	// (get) Token: 0x06001E05 RID: 7685 RVA: 0x0007D9A8 File Offset: 0x0007BBA8
	// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0007D9B0 File Offset: 0x0007BBB0
	public ObservableCollection<Class734> LocalProfiles
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("LocalProfiles");
		}
	}

	// Token: 0x170004B1 RID: 1201
	// (get) Token: 0x06001E07 RID: 7687 RVA: 0x0007D9C4 File Offset: 0x0007BBC4
	// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0007D9CC File Offset: 0x0007BBCC
	public ObservableCollection<Class725> CloudProfiles
	{
		get
		{
			return this.observableCollection_1;
		}
		set
		{
			this.observableCollection_1 = value;
			base.method_0("CloudCount");
			base.method_0("CloudProfiles");
		}
	}

	// Token: 0x170004B2 RID: 1202
	// (get) Token: 0x06001E09 RID: 7689 RVA: 0x0007D9EC File Offset: 0x0007BBEC
	public GClass134 TakeSnapshotCmd
	{
		get
		{
			return new GClass134(new Action<object>(this.method_4), null);
		}
	}

	// Token: 0x170004B3 RID: 1203
	// (get) Token: 0x06001E0A RID: 7690 RVA: 0x0007DA00 File Offset: 0x0007BC00
	public GClass134 ImportFileCmd
	{
		get
		{
			return new GClass134(new Action<object>(this.method_6), null);
		}
	}

	// Token: 0x170004B4 RID: 1204
	// (get) Token: 0x06001E0B RID: 7691 RVA: 0x0007DA14 File Offset: 0x0007BC14
	public GClass134 Update
	{
		get
		{
			return new GClass134(new Action<object>(this.method_8), null);
		}
	}

	// Token: 0x170004B5 RID: 1205
	// (get) Token: 0x06001E0C RID: 7692 RVA: 0x0007DA28 File Offset: 0x0007BC28
	public GClass134 ImportFromKey
	{
		get
		{
			return new GClass134(new Action<object>(this.method_10), null);
		}
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x0007DA3C File Offset: 0x0007BC3C
	public void method_1()
	{
		Class755.Struct331 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class755_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class755.Struct331>(ref @struct);
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x0007DA74 File Offset: 0x0007BC74
	public void method_2()
	{
		Class755.Struct332 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class755_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class755.Struct332>(ref @struct);
	}

	// Token: 0x170004B6 RID: 1206
	// (get) Token: 0x06001E0F RID: 7695 RVA: 0x0007DAAC File Offset: 0x0007BCAC
	// (set) Token: 0x06001E10 RID: 7696 RVA: 0x0007DAB4 File Offset: 0x0007BCB4
	public string StatusText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x170004B7 RID: 1207
	// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0007DAC8 File Offset: 0x0007BCC8
	// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0007DAD0 File Offset: 0x0007BCD0
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

	// Token: 0x170004B8 RID: 1208
	// (get) Token: 0x06001E13 RID: 7699 RVA: 0x0007DAE4 File Offset: 0x0007BCE4
	// (set) Token: 0x06001E14 RID: 7700 RVA: 0x0007DAEC File Offset: 0x0007BCEC
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

	// Token: 0x06001E15 RID: 7701 RVA: 0x0007DB00 File Offset: 0x0007BD00
	private void method_3(string string_1, SolidColorBrush solidColorBrush_1)
	{
		Class755.Struct326 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class755_0 = this;
		@struct.string_0 = string_1;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class755.Struct326>(ref @struct);
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x0007DB48 File Offset: 0x0007BD48
	private void method_4(object object_0)
	{
		Class755.Struct329 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class755_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class755.Struct329>(ref @struct);
	}

	// Token: 0x06001E17 RID: 7703 RVA: 0x0007DB80 File Offset: 0x0007BD80
	private Task method_5()
	{
		Class755.Struct327 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class755_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class755.Struct327>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x0007DBC4 File Offset: 0x0007BDC4
	private void method_6(object object_0)
	{
		Task.Run(new Func<Task>(this.method_7));
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x0007DBD8 File Offset: 0x0007BDD8
	private Task method_7()
	{
		Class755.Struct330 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class755_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class755.Struct330>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001E1A RID: 7706 RVA: 0x0007DC1C File Offset: 0x0007BE1C
	private void method_8(object object_0)
	{
		Task.Run(new Action(this.method_9));
	}

	// Token: 0x06001E1B RID: 7707 RVA: 0x0007DC30 File Offset: 0x0007BE30
	private void method_9()
	{
		this.method_1();
		this.method_2();
	}

	// Token: 0x06001E1C RID: 7708 RVA: 0x0007DC40 File Offset: 0x0007BE40
	private void method_10(object object_0)
	{
		Class755.Struct325 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class755_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class755.Struct325>(ref @struct);
	}

	// Token: 0x06001E1D RID: 7709 RVA: 0x0007DC78 File Offset: 0x0007BE78
	private void method_11()
	{
		Application.Current.Dispatcher.Invoke(new Action(this.method_12));
		if (!Directory.Exists(Class186.string_6))
		{
			return;
		}
		string[] files = Directory.GetFiles(Class186.string_6);
		if (files.Count<string>() == 0)
		{
			return;
		}
		List<Class734> list = new List<Class734>();
		string[] array = files;
		for (int i = 0; i < array.Length; i++)
		{
			Class734 item = new Class734(array[i], this);
			list.Add(item);
		}
		list = list.OrderByDescending(new Func<Class734, DateTime>(Class755.Class625.class625_0.method_1)).ToList<Class734>();
		using (List<Class734>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class755.Class626 @class = new Class755.Class626();
				@class.class755_0 = this;
				@class.class734_0 = enumerator.Current;
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			}
		}
	}

	// Token: 0x06001E1E RID: 7710 RVA: 0x0007DD9C File Offset: 0x0007BF9C
	private void method_12()
	{
		this.LocalProfiles.Clear();
		base.method_0("GetLocalProfiles");
	}

	// Token: 0x06001E1F RID: 7711 RVA: 0x0007DDB4 File Offset: 0x0007BFB4
	private Task method_13()
	{
		Class755.Struct328 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class755_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class755.Struct328>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001E20 RID: 7712 RVA: 0x0007DDF8 File Offset: 0x0007BFF8
	private void method_14()
	{
		this.CloudProfiles.Clear();
		base.method_0("GetCloudProfiles");
	}

	// Token: 0x06001E21 RID: 7713 RVA: 0x0007DE10 File Offset: 0x0007C010
	private void method_15(GClass112 gclass112_0)
	{
		Class755.Class624 @class = new Class755.Class624();
		@class.class755_0 = this;
		@class.gclass112_0 = gclass112_0;
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
	}

	// Token: 0x0400152A RID: 5418
	private Class734 class734_0;

	// Token: 0x0400152B RID: 5419
	private ObservableCollection<Class734> observableCollection_0 = new ObservableCollection<Class734>();

	// Token: 0x0400152C RID: 5420
	private ObservableCollection<Class725> observableCollection_1 = new ObservableCollection<Class725>();

	// Token: 0x0400152D RID: 5421
	private bool bool_0;

	// Token: 0x0400152E RID: 5422
	private string string_0 = string.Empty;

	// Token: 0x0400152F RID: 5423
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x04001530 RID: 5424
	private double double_0;

	// Token: 0x02000565 RID: 1381
	[StructLayout(LayoutKind.Auto)]
	private struct Struct325 : IAsyncStateMachine
	{
		// Token: 0x06001E22 RID: 7714 RVA: 0x0007DE4C File Offset: 0x0007C04C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class755 @class = this.class755_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class585.struct13_0.method_0())
					{
						Application.Current.Dispatcher.Invoke(new Action(Class755.Class625.class625_0.method_0));
						goto IL_ED;
					}
					@class.method_3(Class364.smethod_0("prorequired"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
					awaiter = Task.Delay(1500).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class755.Struct325>(ref awaiter, ref this);
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
				@class.method_3(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_ED:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0007DF6C File Offset: 0x0007C16C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001531 RID: 5425
		public int int_0;

		// Token: 0x04001532 RID: 5426
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001533 RID: 5427
		public Class755 class755_0;

		// Token: 0x04001534 RID: 5428
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000566 RID: 1382
	[StructLayout(LayoutKind.Auto)]
	private struct Struct326 : IAsyncStateMachine
	{
		// Token: 0x06001E24 RID: 7716 RVA: 0x0007DF7C File Offset: 0x0007C17C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class755 @class = this.class755_0;
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class755.Struct326>(ref awaiter, ref this);
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class755.Struct326>(ref awaiter, ref this);
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

		// Token: 0x06001E25 RID: 7717 RVA: 0x0007E178 File Offset: 0x0007C378
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001535 RID: 5429
		public int int_0;

		// Token: 0x04001536 RID: 5430
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001537 RID: 5431
		public Class755 class755_0;

		// Token: 0x04001538 RID: 5432
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001539 RID: 5433
		public string string_0;

		// Token: 0x0400153A RID: 5434
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000567 RID: 1383
	[StructLayout(LayoutKind.Auto)]
	private struct Struct327 : IAsyncStateMachine
	{
		// Token: 0x06001E26 RID: 7718 RVA: 0x0007E188 File Offset: 0x0007C388
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class755 @class = this.class755_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_C5;
				}
				if (num != 1)
				{
					@class.method_3(Class364.smethod_0("CreatingProfile"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					awaiter = Class762.smethod_0("BackUp").GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class755.Struct327>(ref awaiter, ref this);
						return;
					}
					goto IL_C5;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_8D:
				awaiter.GetResult();
				@class.method_3(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				goto IL_140;
				IL_C5:
				awaiter.GetResult();
				@class.method_1();
				@class.method_3(Class364.smethod_0("storexins7"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				awaiter = Task.Delay(1500).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class755.Struct327>(ref awaiter, ref this);
					return;
				}
				goto IL_8D;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_140:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0007E304 File Offset: 0x0007C504
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400153B RID: 5435
		public int int_0;

		// Token: 0x0400153C RID: 5436
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400153D RID: 5437
		public Class755 class755_0;

		// Token: 0x0400153E RID: 5438
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000568 RID: 1384
	private sealed class Class624
	{
		// Token: 0x06001E29 RID: 7721 RVA: 0x0007E31C File Offset: 0x0007C51C
		internal void method_0()
		{
			this.class755_0.CloudProfiles.Add(new Class725(this.gclass112_0, this.class755_0));
		}

		// Token: 0x0400153F RID: 5439
		public GClass112 gclass112_0;

		// Token: 0x04001540 RID: 5440
		public Class755 class755_0;
	}

	// Token: 0x02000569 RID: 1385
	[StructLayout(LayoutKind.Auto)]
	private struct Struct328 : IAsyncStateMachine
	{
		// Token: 0x06001E2A RID: 7722 RVA: 0x0007E340 File Offset: 0x0007C540
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class755 @object = this.class755_0;
			try
			{
				TaskAwaiter<Class289> awaiter;
				if (num != 0)
				{
					if (!Class585.struct13_0.method_0())
					{
						goto IL_E8;
					}
					awaiter = Class166.smethod_1(Class193.uri_10, Class389.class504_0.Key).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class755.Struct328>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class289>);
					this.int_0 = -1;
				}
				Class289 result = awaiter.GetResult();
				if (result.Success)
				{
					List<GClass112> list = JsonConvert.DeserializeObject<List<GClass112>>(result.Message);
					Application.Current.Dispatcher.Invoke(new Action(@object.method_14));
					list.ForEach(new Action<GClass112>(@object.method_15));
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_E8:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0007E458 File Offset: 0x0007C658
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001541 RID: 5441
		public int int_0;

		// Token: 0x04001542 RID: 5442
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001543 RID: 5443
		public Class755 class755_0;

		// Token: 0x04001544 RID: 5444
		private TaskAwaiter<Class289> taskAwaiter_0;
	}

	// Token: 0x0200056A RID: 1386
	[Serializable]
	private sealed class Class625
	{
		// Token: 0x06001E2E RID: 7726 RVA: 0x0007E47C File Offset: 0x0007C67C
		internal void method_0()
		{
			Class358.smethod_0().method_3(typeof(dje_zNFRKV9TBJU7K5R2T3JBPSNE2MH4MQ7PYQLV248SGMNYXV4NGSHASC_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0007E49C File Offset: 0x0007C69C
		internal DateTime method_1(Class734 class734_0)
		{
			return DateTime.ParseExact(class734_0.DateCreated, "dd.MM.yyyy HH:mm", null);
		}

		// Token: 0x04001545 RID: 5445
		public static readonly Class755.Class625 class625_0 = new Class755.Class625();

		// Token: 0x04001546 RID: 5446
		public static Action action_0;

		// Token: 0x04001547 RID: 5447
		public static Func<Class734, DateTime> func_0;
	}

	// Token: 0x0200056B RID: 1387
	[StructLayout(LayoutKind.Auto)]
	private struct Struct329 : IAsyncStateMachine
	{
		// Token: 0x06001E30 RID: 7728 RVA: 0x0007E4B0 File Offset: 0x0007C6B0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class755 @class = this.class755_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (@class.bool_0)
					{
						goto IL_A8;
					}
					@class.bool_0 = true;
					awaiter = Task.Run(new Func<Task>(@class.method_5)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class755.Struct329>(ref awaiter, ref this);
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
				@class.bool_0 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_A8:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0007E588 File Offset: 0x0007C788
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001548 RID: 5448
		public int int_0;

		// Token: 0x04001549 RID: 5449
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400154A RID: 5450
		public Class755 class755_0;

		// Token: 0x0400154B RID: 5451
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200056C RID: 1388
	private sealed class Class626
	{
		// Token: 0x06001E33 RID: 7731 RVA: 0x0007E5A0 File Offset: 0x0007C7A0
		internal void method_0()
		{
			this.class755_0.LocalProfiles.Add(this.class734_0);
		}

		// Token: 0x0400154C RID: 5452
		public Class734 class734_0;

		// Token: 0x0400154D RID: 5453
		public Class755 class755_0;
	}

	// Token: 0x0200056D RID: 1389
	[StructLayout(LayoutKind.Auto)]
	private struct Struct330 : IAsyncStateMachine
	{
		// Token: 0x06001E34 RID: 7732 RVA: 0x0007E5B8 File Offset: 0x0007C7B8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class755 @class = this.class755_0;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					break;
				case 1:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_214;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_249;
				default:
				{
					OpenFileDialog openFileDialog = new OpenFileDialog
					{
						Filter = "BoosterX Profiles (*.buxz) | *.buxz",
						CheckFileExists = true,
						CheckPathExists = true
					};
					if (!openFileDialog.ShowDialog().Value)
					{
						goto IL_260;
					}
					if (!openFileDialog.FileName.EndsWith(".buxz"))
					{
						goto IL_27B;
					}
					string path = Path.Combine(Class186.string_6, Path.GetFileName(openFileDialog.FileName));
					if (File.Exists(path))
					{
						@class.method_3(Class364.smethod_0("FileExists"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
						awaiter = Task.Delay(1500).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class755.Struct330>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						int num2 = 0;
						try
						{
							File.WriteAllBytes(path, File.ReadAllBytes(openFileDialog.FileName));
						}
						catch (Exception obj)
						{
							num2 = 1;
						}
						if (num2 == 1)
						{
							object obj;
							GClass141.smethod_1(((Exception)obj).Message);
							@class.method_3(Class364.smethod_0("unknownerror"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
							awaiter = Task.Delay(1500).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class755.Struct330>(ref awaiter, ref this);
								return;
							}
							goto IL_214;
						}
						else
						{
							@class.method_1();
							@class.method_3(Class364.smethod_0("storexins7"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
							awaiter = Task.Delay(1500).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 2;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class755.Struct330>(ref awaiter, ref this);
								return;
							}
							goto IL_249;
						}
					}
					break;
				}
				}
				awaiter.GetResult();
				@class.method_3(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				goto IL_27B;
				IL_214:
				awaiter.GetResult();
				@class.method_3(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				goto IL_27B;
				IL_249:
				awaiter.GetResult();
				@class.method_3(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				IL_260:;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_27B:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0007E888 File Offset: 0x0007CA88
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400154E RID: 5454
		public int int_0;

		// Token: 0x0400154F RID: 5455
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001550 RID: 5456
		public Class755 class755_0;

		// Token: 0x04001551 RID: 5457
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200056E RID: 1390
	[StructLayout(LayoutKind.Auto)]
	private struct Struct331 : IAsyncStateMachine
	{
		// Token: 0x06001E36 RID: 7734 RVA: 0x0007E898 File Offset: 0x0007CA98
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class755 @object = this.class755_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_11)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class755.Struct331>(ref awaiter, ref this);
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

		// Token: 0x06001E37 RID: 7735 RVA: 0x0007E958 File Offset: 0x0007CB58
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001552 RID: 5458
		public int int_0;

		// Token: 0x04001553 RID: 5459
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001554 RID: 5460
		public Class755 class755_0;

		// Token: 0x04001555 RID: 5461
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200056F RID: 1391
	[StructLayout(LayoutKind.Auto)]
	private struct Struct332 : IAsyncStateMachine
	{
		// Token: 0x06001E38 RID: 7736 RVA: 0x0007E968 File Offset: 0x0007CB68
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class755 @object = this.class755_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_13)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class755.Struct332>(ref awaiter, ref this);
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

		// Token: 0x06001E39 RID: 7737 RVA: 0x0007EA28 File Offset: 0x0007CC28
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001556 RID: 5462
		public int int_0;

		// Token: 0x04001557 RID: 5463
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001558 RID: 5464
		public Class755 class755_0;

		// Token: 0x04001559 RID: 5465
		private TaskAwaiter taskAwaiter_0;
	}
}
