using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x02000161 RID: 353
internal sealed class Class716 : GClass211
{
	// Token: 0x06000935 RID: 2357 RVA: 0x0002AD1C File Offset: 0x00028F1C
	public Class716(Class744 class744_1)
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		this.class744_0 = class744_1;
		this.method_2(new Class524(this));
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x0002AD84 File Offset: 0x00028F84
	private Class524 method_1()
	{
		return this.class524_0;
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x0002AD8C File Offset: 0x00028F8C
	private void method_2(Class524 class524_1)
	{
		this.class524_0 = class524_1;
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x0002AD98 File Offset: 0x00028F98
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("ColChanged");
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x06000939 RID: 2361 RVA: 0x0002ADA8 File Offset: 0x00028FA8
	// (set) Token: 0x0600093A RID: 2362 RVA: 0x0002ADB0 File Offset: 0x00028FB0
	public ObservableCollection<Class756> AffinityModel
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("AffinityModel");
		}
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x0002ADC4 File Offset: 0x00028FC4
	private string method_3()
	{
		return this.string_0;
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x0002ADCC File Offset: 0x00028FCC
	private void method_4(string string_6)
	{
		this.string_0 = string_6;
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x0600093D RID: 2365 RVA: 0x0002ADD8 File Offset: 0x00028FD8
	// (set) Token: 0x0600093E RID: 2366 RVA: 0x0002ADE0 File Offset: 0x00028FE0
	public string Name
	{
		get
		{
			return this.method_3();
		}
		set
		{
			this.method_4(value);
			base.method_0("Name");
		}
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x0600093F RID: 2367 RVA: 0x0002ADF4 File Offset: 0x00028FF4
	// (set) Token: 0x06000940 RID: 2368 RVA: 0x0002ADFC File Offset: 0x00028FFC
	public string DeviceTypeName
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

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06000941 RID: 2369 RVA: 0x0002AE08 File Offset: 0x00029008
	// (set) Token: 0x06000942 RID: 2370 RVA: 0x0002AE10 File Offset: 0x00029010
	public DrawingImage Icon
	{
		[CompilerGenerated]
		get
		{
			return this.drawingImage_0;
		}
		[CompilerGenerated]
		set
		{
			this.drawingImage_0 = value;
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06000943 RID: 2371 RVA: 0x0002AE1C File Offset: 0x0002901C
	// (set) Token: 0x06000944 RID: 2372 RVA: 0x0002AE24 File Offset: 0x00029024
	public string Path
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x0002AE30 File Offset: 0x00029030
	private bool method_5()
	{
		return this.bool_0;
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x0002AE38 File Offset: 0x00029038
	private void method_6(bool bool_4)
	{
		this.bool_0 = bool_4;
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000947 RID: 2375 RVA: 0x0002AE44 File Offset: 0x00029044
	// (set) Token: 0x06000948 RID: 2376 RVA: 0x0002AE4C File Offset: 0x0002904C
	public bool IsChecked
	{
		get
		{
			return this.method_5();
		}
		set
		{
			this.method_6(value);
			if (this.method_5() && this.class744_0 != null)
			{
				this.class744_0.ChoosenDevThreads = this.AffinityModel;
			}
			base.method_0("IsChecked");
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000949 RID: 2377 RVA: 0x0002AE84 File Offset: 0x00029084
	// (set) Token: 0x0600094A RID: 2378 RVA: 0x0002AE8C File Offset: 0x0002908C
	public string Affinity
	{
		[CompilerGenerated]
		get
		{
			return this.string_3;
		}
		[CompilerGenerated]
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x0600094B RID: 2379 RVA: 0x0002AE98 File Offset: 0x00029098
	// (set) Token: 0x0600094C RID: 2380 RVA: 0x0002AEA0 File Offset: 0x000290A0
	public string _NewAffinity
	{
		[CompilerGenerated]
		get
		{
			return this.string_4;
		}
		[CompilerGenerated]
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x0600094D RID: 2381 RVA: 0x0002AEAC File Offset: 0x000290AC
	// (set) Token: 0x0600094E RID: 2382 RVA: 0x0002AEB4 File Offset: 0x000290B4
	public string NewAffinity
	{
		get
		{
			return this._NewAffinity;
		}
		set
		{
			if (this.Affinity == null)
			{
				this.Affinity = value;
			}
			this._NewAffinity = value;
			this.method_8();
			base.method_0("NewAffinity");
			base.method_0("HasChanges");
			this.method_7();
		}
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x0002AEF0 File Offset: 0x000290F0
	private void method_7()
	{
		if (this.bool_2)
		{
			return;
		}
		if (!this.HasChanges)
		{
			this.method_13((this.NewAffinity == "default") ? Class364.smethod_0("DefaultAffinity") : (Class364.smethod_0("BindedTo") + " " + this.NewAffinity), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			this.method_12();
			return;
		}
		this.method_13((this.NewAffinity == "default") ? Class364.smethod_0("WillBeDefault") : (Class364.smethod_0("WillBeBindedTo") + " " + this.NewAffinity), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
		this.method_11();
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x0002AFB4 File Offset: 0x000291B4
	public void method_8()
	{
		Class716.Class191 @class = new Class716.Class191();
		@class.class716_0 = this;
		if (this.bool_1)
		{
			return;
		}
		this.bool_1 = true;
		this.bool_2 = true;
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		@class.string_0 = this.NewAffinity.Replace(" ", string.Empty).Split(new char[]
		{
			','
		});
		@class.bool_0 = Class250.list_0.Any(new Func<Class163, bool>(Class716.Class190.class190_0.method_0));
		using (List<Class163>.Enumerator enumerator = Class250.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class716.Class189 class2 = new Class716.Class189();
				class2.class191_0 = @class;
				class2.class163_0 = enumerator.Current;
				Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
			}
		}
		this.bool_2 = false;
		base.method_0("AffinityModel");
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x0002B0D8 File Offset: 0x000292D8
	public void method_9()
	{
		string text = string.Empty;
		bool flag = true;
		foreach (Class756 @class in this.AffinityModel)
		{
			if (@class.IsChosen)
			{
				if (flag)
				{
					text = @class.Thread.ToString();
					flag = false;
				}
				else
				{
					text = text + ", " + @class.Thread.ToString();
				}
			}
		}
		if (text == string.Empty)
		{
			this.NewAffinity = "default";
			return;
		}
		this.NewAffinity = text;
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x0002B184 File Offset: 0x00029384
	public void method_10()
	{
		string text = string.Empty;
		foreach (Class756 @class in this.AffinityModel)
		{
			if (@class.IsChosen)
			{
				text = text + @class.Thread.ToString() + ", ";
			}
		}
		this.NewAffinity = text.Remove(text.Length, 2);
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x06000953 RID: 2387 RVA: 0x0002B208 File Offset: 0x00029408
	public bool HasChanges
	{
		get
		{
			return this._NewAffinity != this.Affinity;
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x06000954 RID: 2388 RVA: 0x0002B21C File Offset: 0x0002941C
	public bool AddToConfig
	{
		get
		{
			return Class585.struct13_0.method_0();
		}
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x0002B228 File Offset: 0x00029428
	private void method_11()
	{
		if (this.AddToConfig)
		{
			GClass93.smethod_0().method_9<Class524>(this.Name, new Func<Class524>(this.method_14), this._NewAffinity);
		}
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x0002B258 File Offset: 0x00029458
	private void method_12()
	{
		if (this.AddToConfig)
		{
			GClass93.smethod_0().method_14<Class524>(this.Name);
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06000957 RID: 2391 RVA: 0x0002B274 File Offset: 0x00029474
	// (set) Token: 0x06000958 RID: 2392 RVA: 0x0002B27C File Offset: 0x0002947C
	public string StatusText
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06000959 RID: 2393 RVA: 0x0002B290 File Offset: 0x00029490
	// (set) Token: 0x0600095A RID: 2394 RVA: 0x0002B298 File Offset: 0x00029498
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

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x0600095B RID: 2395 RVA: 0x0002B2AC File Offset: 0x000294AC
	// (set) Token: 0x0600095C RID: 2396 RVA: 0x0002B2B4 File Offset: 0x000294B4
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

	// Token: 0x0600095D RID: 2397 RVA: 0x0002B2C8 File Offset: 0x000294C8
	private void method_13(string string_6, SolidColorBrush solidColorBrush_1)
	{
		Class716.Struct67 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class716_0 = this;
		@struct.string_0 = string_6;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class716.Struct67>(ref @struct);
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x0002B310 File Offset: 0x00029510
	private Class524 method_14()
	{
		return this.method_1();
	}

	// Token: 0x04000548 RID: 1352
	private Class744 class744_0;

	// Token: 0x04000549 RID: 1353
	private Class524 class524_0;

	// Token: 0x0400054A RID: 1354
	private ObservableCollection<Class756> observableCollection_0 = new ObservableCollection<Class756>();

	// Token: 0x0400054B RID: 1355
	private string string_0;

	// Token: 0x0400054C RID: 1356
	private string string_1;

	// Token: 0x0400054D RID: 1357
	private DrawingImage drawingImage_0;

	// Token: 0x0400054E RID: 1358
	private string string_2;

	// Token: 0x0400054F RID: 1359
	private bool bool_0;

	// Token: 0x04000550 RID: 1360
	private string string_3;

	// Token: 0x04000551 RID: 1361
	private string string_4;

	// Token: 0x04000552 RID: 1362
	public bool bool_1;

	// Token: 0x04000553 RID: 1363
	private bool bool_2 = true;

	// Token: 0x04000554 RID: 1364
	public bool bool_3;

	// Token: 0x04000555 RID: 1365
	private string string_5 = string.Empty;

	// Token: 0x04000556 RID: 1366
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x04000557 RID: 1367
	private double double_0;

	// Token: 0x02000162 RID: 354
	private sealed class Class189
	{
		// Token: 0x06000960 RID: 2400 RVA: 0x0002B320 File Offset: 0x00029520
		internal void method_0()
		{
			Collection<Class756> affinityModel = this.class191_0.class716_0.AffinityModel;
			Class756 @class = new Class756(this.class191_0.class716_0);
			@class.Core = this.class163_0.Core;
			IEnumerable<string> string_ = this.class191_0.string_0;
			Func<string, bool> predicate;
			if ((predicate = this.func_0) == null)
			{
				predicate = (this.func_0 = new Func<string, bool>(this.method_1));
			}
			@class.IsChosen = string_.Any(predicate);
			@class.Thread = this.class163_0.Thread;
			@class.IsECore = this.class163_0.IsECore;
			@class.ShowCoreType = this.class191_0.bool_0;
			affinityModel.Add(@class);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0002B3CC File Offset: 0x000295CC
		internal bool method_1(string string_0)
		{
			return string_0 == this.class163_0.Thread.ToString();
		}

		// Token: 0x04000558 RID: 1368
		public Class163 class163_0;

		// Token: 0x04000559 RID: 1369
		public Class716.Class191 class191_0;

		// Token: 0x0400055A RID: 1370
		public Func<string, bool> func_0;
	}

	// Token: 0x02000163 RID: 355
	[Serializable]
	private sealed class Class190
	{
		// Token: 0x06000964 RID: 2404 RVA: 0x0002B408 File Offset: 0x00029608
		internal bool method_0(Class163 class163_0)
		{
			return class163_0.IsECore;
		}

		// Token: 0x0400055B RID: 1371
		public static readonly Class716.Class190 class190_0 = new Class716.Class190();

		// Token: 0x0400055C RID: 1372
		public static Func<Class163, bool> func_0;
	}

	// Token: 0x02000164 RID: 356
	[StructLayout(LayoutKind.Auto)]
	private struct Struct67 : IAsyncStateMachine
	{
		// Token: 0x06000965 RID: 2405 RVA: 0x0002B410 File Offset: 0x00029610
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class716 @class = this.class716_0;
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class716.Struct67>(ref awaiter, ref this);
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class716.Struct67>(ref awaiter, ref this);
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

		// Token: 0x06000966 RID: 2406 RVA: 0x0002B60C File Offset: 0x0002980C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400055D RID: 1373
		public int int_0;

		// Token: 0x0400055E RID: 1374
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400055F RID: 1375
		public Class716 class716_0;

		// Token: 0x04000560 RID: 1376
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000561 RID: 1377
		public string string_0;

		// Token: 0x04000562 RID: 1378
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000165 RID: 357
	private sealed class Class191
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x0002B624 File Offset: 0x00029824
		internal void method_0()
		{
			this.class716_0.AffinityModel.Clear();
		}

		// Token: 0x04000563 RID: 1379
		public Class716 class716_0;

		// Token: 0x04000564 RID: 1380
		public string[] string_0;

		// Token: 0x04000565 RID: 1381
		public bool bool_0;
	}
}
