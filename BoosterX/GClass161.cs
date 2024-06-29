using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;

// Token: 0x02000542 RID: 1346
public sealed class GClass161
{
	// Token: 0x06001D5D RID: 7517 RVA: 0x0007AF6C File Offset: 0x0007916C
	public static GClass161.GClass223 smethod_0(bool bool_2)
	{
		if (!GClass161.bool_0 || bool_2)
		{
			GClass93.smethod_0().method_17<Class520>();
			GClass161.bool_1 = false;
			GClass161.bool_0 = true;
			GClass161.smethod_1();
		}
		return GClass161.gclass223_0;
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x0007AF9C File Offset: 0x0007919C
	public static void smethod_1()
	{
		GClass161.Struct314 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass161.Struct314>(ref @struct);
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x0007AFCC File Offset: 0x000791CC
	public static void smethod_2()
	{
		GClass161.Struct311 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass161.Struct311>(ref @struct);
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x0007AFFC File Offset: 0x000791FC
	public static void smethod_3()
	{
		GClass161.Struct315 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass161.Struct315>(ref @struct);
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x0007B02C File Offset: 0x0007922C
	public static void smethod_4()
	{
		GClass161.Struct312 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass161.Struct312>(ref @struct);
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x0007B05C File Offset: 0x0007925C
	public static Task smethod_5()
	{
		GClass161.Struct313 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass161.Struct313>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x040014A0 RID: 5280
	private static GClass161.GClass223 gclass223_0 = new GClass161.GClass223();

	// Token: 0x040014A1 RID: 5281
	private static bool bool_0 = false;

	// Token: 0x040014A2 RID: 5282
	private static bool bool_1 = false;

	// Token: 0x02000543 RID: 1347
	[StructLayout(LayoutKind.Auto)]
	private struct Struct311 : IAsyncStateMachine
	{
		// Token: 0x06001D63 RID: 7523 RVA: 0x0007B098 File Offset: 0x00079298
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!GClass161.bool_0)
					{
						GClass161.smethod_0(false);
					}
					awaiter = GClass161.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass161.Struct311>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<GClass221> enumerator = GClass161.gclass223_0.MsiSupportedDevices.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass221 gclass = enumerator.Current;
						gclass.MsiStatus = false;
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				enumerator = GClass161.gclass223_0.CanBeDisabled.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass221 gclass2 = enumerator.Current;
						gclass2.IsEnabled = false;
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
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

		// Token: 0x06001D64 RID: 7524 RVA: 0x0007B1DC File Offset: 0x000793DC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014A3 RID: 5283
		public int int_0;

		// Token: 0x040014A4 RID: 5284
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040014A5 RID: 5285
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000544 RID: 1348
	private sealed class Class612
	{
		// Token: 0x06001D66 RID: 7526 RVA: 0x0007B1F4 File Offset: 0x000793F4
		internal void method_0()
		{
			this.class618_0.observableCollection_1.Add(new GClass221(this.gclass116_0, false, string.Empty));
		}

		// Token: 0x040014A6 RID: 5286
		public GClass116 gclass116_0;

		// Token: 0x040014A7 RID: 5287
		public GClass161.Class618 class618_0;
	}

	// Token: 0x02000545 RID: 1349
	public sealed class GClass223 : GClass211
	{
		// Token: 0x06001D67 RID: 7527 RVA: 0x0007B218 File Offset: 0x00079418
		public GClass223()
		{
			this.observableCollection_0.CollectionChanged += this.observableCollection_2_CollectionChanged;
			this.observableCollection_1.CollectionChanged += this.observableCollection_2_CollectionChanged;
			this.observableCollection_2.CollectionChanged += this.observableCollection_2_CollectionChanged;
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x0007B29C File Offset: 0x0007949C
		private void observableCollection_2_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
		{
			base.method_0("CollectionChanged");
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x0007B2AC File Offset: 0x000794AC
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x0007B2B4 File Offset: 0x000794B4
		public ObservableCollection<GClass221> MsiSupportedDevices
		{
			get
			{
				return this.observableCollection_0;
			}
			set
			{
				this.observableCollection_0 = value;
				base.method_0("MsiSupportedDevices");
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x0007B2C8 File Offset: 0x000794C8
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x0007B2D0 File Offset: 0x000794D0
		public ObservableCollection<GClass226> CustomDisableDevices
		{
			get
			{
				return this.observableCollection_1;
			}
			set
			{
				this.observableCollection_1 = value;
				base.method_0("CustomDisableDevices");
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0007B2E4 File Offset: 0x000794E4
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x0007B2EC File Offset: 0x000794EC
		public ObservableCollection<GClass221> CanBeDisabled
		{
			get
			{
				return this.observableCollection_2;
			}
			set
			{
				this.observableCollection_2 = value;
				base.method_0("CanBeDisabled");
			}
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0007B300 File Offset: 0x00079500
		public void method_1()
		{
			this.CanBeDisabled.Clear();
			this.CustomDisableDevices.Clear();
			this.MsiSupportedDevices.Clear();
			this.list_0.Clear();
		}

		// Token: 0x040014A8 RID: 5288
		public List<GClass116> list_0 = new List<GClass116>();

		// Token: 0x040014A9 RID: 5289
		private ObservableCollection<GClass221> observableCollection_0 = new ObservableCollection<GClass221>();

		// Token: 0x040014AA RID: 5290
		private ObservableCollection<GClass226> observableCollection_1 = new ObservableCollection<GClass226>();

		// Token: 0x040014AB RID: 5291
		private ObservableCollection<GClass221> observableCollection_2 = new ObservableCollection<GClass221>();
	}

	// Token: 0x02000546 RID: 1350
	private sealed class Class613
	{
		// Token: 0x06001D71 RID: 7537 RVA: 0x0007B338 File Offset: 0x00079538
		internal void method_0()
		{
			GClass161.gclass223_0.CanBeDisabled.Add(new GClass221(this.gclass116_0, false, string.Empty));
		}

		// Token: 0x040014AC RID: 5292
		public GClass116 gclass116_0;
	}

	// Token: 0x02000547 RID: 1351
	private sealed class Class614
	{
		// Token: 0x06001D73 RID: 7539 RVA: 0x0007B364 File Offset: 0x00079564
		internal void method_0()
		{
			this.class618_0.observableCollection_3.Add(new GClass221(this.gclass116_0, false, string.Empty));
		}

		// Token: 0x040014AD RID: 5293
		public GClass116 gclass116_0;

		// Token: 0x040014AE RID: 5294
		public GClass161.Class618 class618_0;
	}

	// Token: 0x02000548 RID: 1352
	private sealed class Class615
	{
		// Token: 0x06001D75 RID: 7541 RVA: 0x0007B390 File Offset: 0x00079590
		internal bool method_0(string string_0)
		{
			return this.gclass116_0.method_0().ToLower().StartsWith(string_0.ToLower());
		}

		// Token: 0x040014AF RID: 5295
		public GClass116 gclass116_0;
	}

	// Token: 0x02000549 RID: 1353
	private sealed class Class616
	{
		// Token: 0x06001D77 RID: 7543 RVA: 0x0007B3B8 File Offset: 0x000795B8
		internal void method_0()
		{
			this.class618_0.observableCollection_2.Add(new GClass221(this.gclass116_0, false, string.Empty));
		}

		// Token: 0x040014B0 RID: 5296
		public GClass116 gclass116_0;

		// Token: 0x040014B1 RID: 5297
		public GClass161.Class618 class618_0;
	}

	// Token: 0x0200054A RID: 1354
	[StructLayout(LayoutKind.Auto)]
	private struct Struct312 : IAsyncStateMachine
	{
		// Token: 0x06001D78 RID: 7544 RVA: 0x0007B3DC File Offset: 0x000795DC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!GClass161.bool_0)
					{
						GClass161.smethod_0(false);
					}
					awaiter = GClass161.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass161.Struct312>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<GClass221> enumerator = GClass161.gclass223_0.CanBeDisabled.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass221 gclass = enumerator.Current;
						gclass.IsEnabled = true;
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				IEnumerator<GClass226> enumerator2 = GClass161.gclass223_0.CustomDisableDevices.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass226 gclass2 = enumerator2.Current;
						gclass2.IsDisabled = new bool?(false);
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
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

		// Token: 0x06001D79 RID: 7545 RVA: 0x0007B524 File Offset: 0x00079724
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014B2 RID: 5298
		public int int_0;

		// Token: 0x040014B3 RID: 5299
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040014B4 RID: 5300
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200054B RID: 1355
	[Serializable]
	private sealed class Class617
	{
		// Token: 0x06001D7C RID: 7548 RVA: 0x0007B548 File Offset: 0x00079748
		internal void method_0()
		{
			GClass161.Class618 @class = new GClass161.Class618();
			Application.Current.Dispatcher.Invoke(new Action(GClass161.Class617.class617_0.method_1));
			GClass161.gclass223_0.list_0.AddRange(Class694.smethod_2());
			GClass161.gclass223_0.list_0.Where(new Func<GClass116, bool>(GClass161.Class617.class617_0.method_2)).ToList<GClass116>().ForEach(new Action<GClass116>(GClass161.Class617.class617_0.method_3));
			GClass161.gclass223_0.list_0.Where(new Func<GClass116, bool>(GClass161.Class617.class617_0.method_4)).ToList<GClass116>().ForEach(new Action<GClass116>(GClass161.Class617.class617_0.method_5));
			@class.observableCollection_0 = null;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			GClass161.gclass223_0.list_0.Where(new Func<GClass116, bool>(GClass161.Class617.class617_0.method_6)).ToList<GClass116>().ForEach(new Action<GClass116>(@class.method_1));
			if (@class.observableCollection_0.Count > 0)
			{
				Application.Current.Dispatcher.Invoke(new Action(@class.method_2));
			}
			@class.observableCollection_1 = null;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_3));
			GClass161.gclass223_0.list_0.Where(new Func<GClass116, bool>(GClass161.Class617.class617_0.method_7)).ToList<GClass116>().ForEach(new Action<GClass116>(@class.method_4));
			if (@class.observableCollection_1.Count > 0)
			{
				Application.Current.Dispatcher.Invoke(new Action(@class.method_5));
			}
			@class.observableCollection_2 = null;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_6));
			GClass161.gclass223_0.list_0.Where(new Func<GClass116, bool>(GClass161.Class617.class617_0.method_8)).ToList<GClass116>().ForEach(new Action<GClass116>(@class.method_7));
			if (@class.observableCollection_2.Count > 0)
			{
				Application.Current.Dispatcher.Invoke(new Action(@class.method_8));
			}
			@class.observableCollection_3 = null;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_9));
			GClass161.gclass223_0.list_0.Where(new Func<GClass116, bool>(GClass161.Class617.class617_0.method_9)).ToList<GClass116>().ForEach(new Action<GClass116>(@class.method_10));
			if (@class.observableCollection_3.Count > 0)
			{
				Application.Current.Dispatcher.Invoke(new Action(@class.method_11));
			}
			GClass161.bool_1 = true;
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0007B890 File Offset: 0x00079A90
		internal void method_1()
		{
			GClass161.gclass223_0.method_1();
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0007B89C File Offset: 0x00079A9C
		internal bool method_2(GClass116 gclass116_0)
		{
			return gclass116_0.method_14();
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0007B8A4 File Offset: 0x00079AA4
		internal void method_3(GClass116 gclass116_0)
		{
			GClass161.Class619 @class = new GClass161.Class619();
			@class.gclass116_0 = gclass116_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x0007B8DC File Offset: 0x00079ADC
		internal bool method_4(GClass116 gclass116_0)
		{
			GClass161.Class615 @class = new GClass161.Class615();
			@class.gclass116_0 = gclass116_0;
			return GClass127.list_0.Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x0007B90C File Offset: 0x00079B0C
		internal void method_5(GClass116 gclass116_0)
		{
			GClass161.Class613 @class = new GClass161.Class613();
			@class.gclass116_0 = gclass116_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0007B944 File Offset: 0x00079B44
		internal bool method_6(GClass116 gclass116_0)
		{
			return gclass116_0.method_2() == "Bluetooth";
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x0007B958 File Offset: 0x00079B58
		internal bool method_7(GClass116 gclass116_0)
		{
			return gclass116_0.method_2() == "PrintQueue";
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x0007B96C File Offset: 0x00079B6C
		internal bool method_8(GClass116 gclass116_0)
		{
			return gclass116_0.Name.StartsWith("WAN Miniport");
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0007B980 File Offset: 0x00079B80
		internal bool method_9(GClass116 gclass116_0)
		{
			return gclass116_0.method_10() == "28 (0x1C) [CM_PROB_FAILED_INSTALL]";
		}

		// Token: 0x040014B5 RID: 5301
		public static readonly GClass161.Class617 class617_0 = new GClass161.Class617();

		// Token: 0x040014B6 RID: 5302
		public static Action action_0;

		// Token: 0x040014B7 RID: 5303
		public static Func<GClass116, bool> func_0;

		// Token: 0x040014B8 RID: 5304
		public static Action<GClass116> action_1;

		// Token: 0x040014B9 RID: 5305
		public static Func<GClass116, bool> func_1;

		// Token: 0x040014BA RID: 5306
		public static Action<GClass116> action_2;

		// Token: 0x040014BB RID: 5307
		public static Func<GClass116, bool> func_2;

		// Token: 0x040014BC RID: 5308
		public static Func<GClass116, bool> func_3;

		// Token: 0x040014BD RID: 5309
		public static Func<GClass116, bool> func_4;

		// Token: 0x040014BE RID: 5310
		public static Func<GClass116, bool> func_5;

		// Token: 0x040014BF RID: 5311
		public static Action action_3;
	}

	// Token: 0x0200054C RID: 1356
	private sealed class Class618
	{
		// Token: 0x06001D87 RID: 7559 RVA: 0x0007B99C File Offset: 0x00079B9C
		internal void method_0()
		{
			this.observableCollection_0 = new ObservableCollection<GClass221>();
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0007B9AC File Offset: 0x00079BAC
		internal void method_1(GClass116 gclass116_0)
		{
			GClass161.Class620 @class = new GClass161.Class620();
			@class.class618_0 = this;
			@class.gclass116_0 = gclass116_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0007B9E8 File Offset: 0x00079BE8
		internal void method_2()
		{
			GClass161.gclass223_0.CustomDisableDevices.Add(new GClass226
			{
				Name = "Bluetooth",
				Description = Class364.smethod_0("BlutoothDevicesDesc"),
				Devices = this.observableCollection_0
			});
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x0007BA28 File Offset: 0x00079C28
		internal void method_3()
		{
			this.observableCollection_1 = new ObservableCollection<GClass221>();
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x0007BA38 File Offset: 0x00079C38
		internal void method_4(GClass116 gclass116_0)
		{
			GClass161.Class612 @class = new GClass161.Class612();
			@class.class618_0 = this;
			@class.gclass116_0 = gclass116_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0007BA74 File Offset: 0x00079C74
		internal void method_5()
		{
			GClass161.gclass223_0.CustomDisableDevices.Add(new GClass226
			{
				Name = Class364.smethod_0("Print"),
				Description = Class364.smethod_0("PrintDesc"),
				Devices = this.observableCollection_1
			});
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x0007BAC4 File Offset: 0x00079CC4
		internal void method_6()
		{
			this.observableCollection_2 = new ObservableCollection<GClass221>();
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x0007BAD4 File Offset: 0x00079CD4
		internal void method_7(GClass116 gclass116_0)
		{
			GClass161.Class616 @class = new GClass161.Class616();
			@class.class618_0 = this;
			@class.gclass116_0 = gclass116_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x0007BB10 File Offset: 0x00079D10
		internal void method_8()
		{
			GClass161.gclass223_0.CustomDisableDevices.Add(new GClass226
			{
				Name = "WAN Miniports",
				Description = Class364.smethod_0("WanMiniPortsDesc"),
				Devices = this.observableCollection_2
			});
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x0007BB50 File Offset: 0x00079D50
		internal void method_9()
		{
			this.observableCollection_3 = new ObservableCollection<GClass221>();
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0007BB60 File Offset: 0x00079D60
		internal void method_10(GClass116 gclass116_0)
		{
			GClass161.Class614 @class = new GClass161.Class614();
			@class.class618_0 = this;
			@class.gclass116_0 = gclass116_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0007BB9C File Offset: 0x00079D9C
		internal void method_11()
		{
			GClass161.gclass223_0.CustomDisableDevices.Add(new GClass226
			{
				Name = Class364.smethod_0("NoDriverDevices"),
				Description = Class364.smethod_0("NoDriverDevicesDesc"),
				Devices = this.observableCollection_3
			});
		}

		// Token: 0x040014C0 RID: 5312
		public ObservableCollection<GClass221> observableCollection_0;

		// Token: 0x040014C1 RID: 5313
		public ObservableCollection<GClass221> observableCollection_1;

		// Token: 0x040014C2 RID: 5314
		public ObservableCollection<GClass221> observableCollection_2;

		// Token: 0x040014C3 RID: 5315
		public ObservableCollection<GClass221> observableCollection_3;
	}

	// Token: 0x0200054D RID: 1357
	[StructLayout(LayoutKind.Auto)]
	private struct Struct313 : IAsyncStateMachine
	{
		// Token: 0x06001D93 RID: 7571 RVA: 0x0007BBEC File Offset: 0x00079DEC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_5E;
				}
				this.int_1 = 0;
				IL_41:
				if (GClass161.bool_1)
				{
					goto IL_AD;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass161.Struct313>(ref awaiter, ref this);
					return;
				}
				IL_5E:
				awaiter.GetResult();
				if (this.int_1 <= 500)
				{
					int num2 = this.int_1;
					this.int_1 = num2 + 1;
					goto IL_41;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_AD:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x0007BCCC File Offset: 0x00079ECC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014C4 RID: 5316
		public int int_0;

		// Token: 0x040014C5 RID: 5317
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040014C6 RID: 5318
		private int int_1;

		// Token: 0x040014C7 RID: 5319
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200054E RID: 1358
	[StructLayout(LayoutKind.Auto)]
	private struct Struct314 : IAsyncStateMachine
	{
		// Token: 0x06001D95 RID: 7573 RVA: 0x0007BCDC File Offset: 0x00079EDC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(GClass161.Class617.class617_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass161.Struct314>(ref awaiter, ref this);
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

		// Token: 0x06001D96 RID: 7574 RVA: 0x0007BDA8 File Offset: 0x00079FA8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014C8 RID: 5320
		public int int_0;

		// Token: 0x040014C9 RID: 5321
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040014CA RID: 5322
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200054F RID: 1359
	private sealed class Class619
	{
		// Token: 0x06001D98 RID: 7576 RVA: 0x0007BDC0 File Offset: 0x00079FC0
		internal void method_0()
		{
			if (!this.gclass116_0.Name.Contains("High Definition Audio"))
			{
				GClass161.gclass223_0.MsiSupportedDevices.Add(new GClass221(this.gclass116_0, true, string.Empty));
			}
		}

		// Token: 0x040014CB RID: 5323
		public GClass116 gclass116_0;
	}

	// Token: 0x02000550 RID: 1360
	private sealed class Class620
	{
		// Token: 0x06001D9A RID: 7578 RVA: 0x0007BE04 File Offset: 0x0007A004
		internal void method_0()
		{
			this.class618_0.observableCollection_0.Add(new GClass221(this.gclass116_0, false, string.Empty));
		}

		// Token: 0x040014CC RID: 5324
		public GClass116 gclass116_0;

		// Token: 0x040014CD RID: 5325
		public GClass161.Class618 class618_0;
	}

	// Token: 0x02000551 RID: 1361
	[StructLayout(LayoutKind.Auto)]
	private struct Struct315 : IAsyncStateMachine
	{
		// Token: 0x06001D9B RID: 7579 RVA: 0x0007BE28 File Offset: 0x0007A028
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!GClass161.bool_0)
					{
						GClass161.smethod_0(false);
					}
					awaiter = GClass161.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass161.Struct315>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<GClass221> enumerator = GClass161.gclass223_0.MsiSupportedDevices.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass221 gclass = enumerator.Current;
						gclass.MsiStatus = false;
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				enumerator = GClass161.gclass223_0.CanBeDisabled.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass221 gclass2 = enumerator.Current;
						gclass2.IsEnabled = false;
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				IEnumerator<GClass226> enumerator2 = GClass161.gclass223_0.CustomDisableDevices.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass226 gclass3 = enumerator2.Current;
						gclass3.IsDisabled = new bool?(true);
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
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

		// Token: 0x06001D9C RID: 7580 RVA: 0x0007BFE4 File Offset: 0x0007A1E4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014CE RID: 5326
		public int int_0;

		// Token: 0x040014CF RID: 5327
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040014D0 RID: 5328
		private TaskAwaiter taskAwaiter_0;
	}
}
