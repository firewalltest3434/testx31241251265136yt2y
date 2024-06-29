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
using Microsoft.Dism;

// Token: 0x02000181 RID: 385
internal sealed class Class718 : GClass211
{
	// Token: 0x060009E0 RID: 2528 RVA: 0x0002D2C4 File Offset: 0x0002B4C4
	public Class718()
	{
		this.Tweaks.CollectionChanged += this.method_1;
		this.method_2();
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0002D348 File Offset: 0x0002B548
	// (set) Token: 0x060009E3 RID: 2531 RVA: 0x0002D350 File Offset: 0x0002B550
	public ObservableCollection<Class745> Tweaks
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.Tweaks = value;
			base.method_0("Tweaks");
		}
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x0002D364 File Offset: 0x0002B564
	private void method_1(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("ColChanged");
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x0002D374 File Offset: 0x0002B574
	public void method_2()
	{
		Class718.Struct76 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class718_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class718.Struct76>(ref @struct);
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x0002D3AC File Offset: 0x0002B5AC
	private bool method_3(Class647 class647_0, bool bool_1)
	{
		if (class647_0 == null)
		{
			return false;
		}
		GClass179 gclass179_ = new GClass179
		{
			String_0 = class647_0.method_0(),
			Name = Class364.smethod_0("Loading"),
			Description = Class364.smethod_0("Loading"),
			IsEditable = false,
			Int32_0 = 1,
			List_0 = new List<string>
			{
				"LEVEL",
				"PRO"
			},
			Type = "DOUBLE",
			List_4 = new List<GClass67>
			{
				new GClass67
				{
					String_0 = "DISM",
					Path = class647_0.method_0(),
					Values = Class491.smethod_7(class647_0.method_0())
				}
			}
		};
		if (!bool_1)
		{
			this.dictionary_1.Add(class647_0.method_0(), new Class745(gclass179_, new Class525(gclass179_), false, true));
		}
		else
		{
			this.dictionary_2.Add(class647_0.method_0(), new Class745(gclass179_, new Class525(gclass179_), false, true));
		}
		return true;
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x0002D4AC File Offset: 0x0002B6AC
	private void method_4()
	{
		this.Tweaks.Clear();
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x0002D4BC File Offset: 0x0002B6BC
	private void method_5()
	{
		this.list_0.Clear();
		this.dictionary_0.Clear();
		this.dictionary_1.Clear();
		this.dictionary_2.Clear();
		this.dictionary_3.Clear();
		foreach (Class647 class647_ in Class203.smethod_0())
		{
			this.method_3(class647_, false);
		}
		foreach (KeyValuePair<string, Class745> keyValuePair in this.dictionary_1)
		{
			DismFeatureCollection dismFeatureCollection = Class203.smethod_5(keyValuePair.Key);
			if (dismFeatureCollection != null && dismFeatureCollection.Count<DismFeature>() > 0)
			{
				using (IEnumerator<DismFeature> enumerator3 = dismFeatureCollection.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						Class718.Class206 @class = new Class718.Class206();
						@class.dismFeature_0 = enumerator3.Current;
						@class.dismFeature_0.FeatureName.smethod_7();
						if (!this.dictionary_1.Any(new Func<KeyValuePair<string, Class745>, bool>(@class.method_0)))
						{
							Class647 class2 = new Class647();
							class2.method_1(@class.dismFeature_0.FeatureName);
							class2.State = @class.dismFeature_0.State.ToString();
							Class647 class3 = class2;
							Class203.list_0.Add(class3);
							if (this.method_3(class3, true))
							{
								keyValuePair.Value.list_0.Add(this.dictionary_2.First(new Func<KeyValuePair<string, Class745>, bool>(@class.method_1)).Value);
								this.dictionary_2.First(new Func<KeyValuePair<string, Class745>, bool>(@class.method_2)).Value.Childs.Add(keyValuePair.Value);
							}
						}
						else
						{
							keyValuePair.Value.list_0.Add(this.dictionary_1.First(new Func<KeyValuePair<string, Class745>, bool>(@class.method_3)).Value);
							this.dictionary_1.First(new Func<KeyValuePair<string, Class745>, bool>(@class.method_4)).Value.Childs.Add(keyValuePair.Value);
						}
					}
				}
				this.dictionary_3.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}
		this.dictionary_0 = this.dictionary_1.Concat(this.dictionary_2).ToLookup(new Func<KeyValuePair<string, Class745>, string>(Class718.Class207.class207_0.method_0), new Func<KeyValuePair<string, Class745>, Class745>(Class718.Class207.class207_0.method_1)).ToDictionary(new Func<IGrouping<string, Class745>, string>(Class718.Class207.class207_0.method_2), new Func<IGrouping<string, Class745>, Class745>(Class718.Class207.class207_0.method_3));
		foreach (KeyValuePair<string, Class745> keyValuePair2 in this.dictionary_0)
		{
			this.list_0.Add(keyValuePair2.Value.Name);
		}
		foreach (KeyValuePair<string, Class745> keyValuePair3 in this.dictionary_3)
		{
			this.dictionary_0.Remove(keyValuePair3.Key);
		}
		this.dictionary_1.Clear();
		foreach (string key in Class491.list_1)
		{
			Class745 value;
			if (this.dictionary_0.TryGetValue(key, out value))
			{
				this.dictionary_1.Add(key, value);
			}
		}
		foreach (KeyValuePair<string, Class745> keyValuePair4 in this.dictionary_0)
		{
			if (!Class491.list_1.Contains(keyValuePair4.Key))
			{
				this.dictionary_1.Add(keyValuePair4.Key, keyValuePair4.Value);
			}
		}
		using (Dictionary<string, Class745>.Enumerator enumerator2 = this.dictionary_1.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				Class718.Class208 class4 = new Class718.Class208();
				class4.class718_0 = this;
				class4.keyValuePair_0 = enumerator2.Current;
				Application.Current.Dispatcher.Invoke(new Action(class4.method_0));
			}
		}
		base.method_0("Load");
		this.bool_0 = true;
		Class718.semaphoreSlim_0.Release();
	}

	// Token: 0x040005BF RID: 1471
	public bool bool_0;

	// Token: 0x040005C0 RID: 1472
	private ObservableCollection<Class745> observableCollection_0 = new ObservableCollection<Class745>();

	// Token: 0x040005C1 RID: 1473
	private List<string> list_0 = new List<string>();

	// Token: 0x040005C2 RID: 1474
	private Dictionary<string, Class745> dictionary_0 = new Dictionary<string, Class745>();

	// Token: 0x040005C3 RID: 1475
	private Dictionary<string, Class745> dictionary_1 = new Dictionary<string, Class745>();

	// Token: 0x040005C4 RID: 1476
	private Dictionary<string, Class745> dictionary_2 = new Dictionary<string, Class745>();

	// Token: 0x040005C5 RID: 1477
	private Dictionary<string, Class745> dictionary_3 = new Dictionary<string, Class745>();

	// Token: 0x040005C6 RID: 1478
	private static readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x02000182 RID: 386
	private sealed class Class206
	{
		// Token: 0x060009EA RID: 2538 RVA: 0x0002DA54 File Offset: 0x0002BC54
		internal bool method_0(KeyValuePair<string, Class745> keyValuePair_0)
		{
			return keyValuePair_0.Key == this.dismFeature_0.FeatureName;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0002DA70 File Offset: 0x0002BC70
		internal bool method_1(KeyValuePair<string, Class745> keyValuePair_0)
		{
			return keyValuePair_0.Key == this.dismFeature_0.FeatureName;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0002DA8C File Offset: 0x0002BC8C
		internal bool method_2(KeyValuePair<string, Class745> keyValuePair_0)
		{
			return keyValuePair_0.Key == this.dismFeature_0.FeatureName;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0002DAA8 File Offset: 0x0002BCA8
		internal bool method_3(KeyValuePair<string, Class745> keyValuePair_0)
		{
			return keyValuePair_0.Key == this.dismFeature_0.FeatureName;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0002DAC4 File Offset: 0x0002BCC4
		internal bool method_4(KeyValuePair<string, Class745> keyValuePair_0)
		{
			return keyValuePair_0.Key == this.dismFeature_0.FeatureName;
		}

		// Token: 0x040005C7 RID: 1479
		public DismFeature dismFeature_0;
	}

	// Token: 0x02000183 RID: 387
	[Serializable]
	private sealed class Class207
	{
		// Token: 0x060009F1 RID: 2545 RVA: 0x0002DAF4 File Offset: 0x0002BCF4
		internal string method_0(KeyValuePair<string, Class745> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0002DB00 File Offset: 0x0002BD00
		internal Class745 method_1(KeyValuePair<string, Class745> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002DB0C File Offset: 0x0002BD0C
		internal string method_2(IGrouping<string, Class745> igrouping_0)
		{
			return igrouping_0.Key;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002DB14 File Offset: 0x0002BD14
		internal Class745 method_3(IGrouping<string, Class745> igrouping_0)
		{
			return igrouping_0.First<Class745>();
		}

		// Token: 0x040005C8 RID: 1480
		public static readonly Class718.Class207 class207_0 = new Class718.Class207();

		// Token: 0x040005C9 RID: 1481
		public static Func<KeyValuePair<string, Class745>, string> func_0;

		// Token: 0x040005CA RID: 1482
		public static Func<KeyValuePair<string, Class745>, Class745> func_1;

		// Token: 0x040005CB RID: 1483
		public static Func<IGrouping<string, Class745>, string> func_2;

		// Token: 0x040005CC RID: 1484
		public static Func<IGrouping<string, Class745>, Class745> func_3;
	}

	// Token: 0x02000184 RID: 388
	private sealed class Class208
	{
		// Token: 0x060009F6 RID: 2550 RVA: 0x0002DB24 File Offset: 0x0002BD24
		internal void method_0()
		{
			this.class718_0.Tweaks.Add(this.keyValuePair_0.Value);
		}

		// Token: 0x040005CD RID: 1485
		public KeyValuePair<string, Class745> keyValuePair_0;

		// Token: 0x040005CE RID: 1486
		public Class718 class718_0;
	}

	// Token: 0x02000185 RID: 389
	[StructLayout(LayoutKind.Auto)]
	private struct Struct76 : IAsyncStateMachine
	{
		// Token: 0x060009F7 RID: 2551 RVA: 0x0002DB44 File Offset: 0x0002BD44
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class718 @class = this.class718_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_A0;
				}
				if (num != 1)
				{
					awaiter = Class718.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class718.Struct76>(ref awaiter, ref this);
						return;
					}
					goto IL_A0;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_78:
				awaiter.GetResult();
				goto IL_139;
				IL_A0:
				awaiter.GetResult();
				@class.bool_0 = false;
				GClass93.smethod_0().method_16(@class.list_0);
				Application.Current.Dispatcher.Invoke(new Action(@class.method_4));
				awaiter = Task.Run(new Action(@class.method_5)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class718.Struct76>(ref awaiter, ref this);
					return;
				}
				goto IL_78;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_139:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0002DCBC File Offset: 0x0002BEBC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040005CF RID: 1487
		public int int_0;

		// Token: 0x040005D0 RID: 1488
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040005D1 RID: 1489
		public Class718 class718_0;

		// Token: 0x040005D2 RID: 1490
		private TaskAwaiter taskAwaiter_0;
	}
}
