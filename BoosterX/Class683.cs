using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using BoosterX.Classes.Tweaks.Expert.ServicesTweak;
using ns0;

// Token: 0x020005FB RID: 1531
internal sealed class Class683
{
	// Token: 0x06002153 RID: 8531 RVA: 0x0008709C File Offset: 0x0008529C
	public static void smethod_0()
	{
		Class683.class760_0.method_1();
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x000870A8 File Offset: 0x000852A8
	public static Class683.Class760 smethod_1(bool bool_2)
	{
		if (!Class683.bool_0 || bool_2)
		{
			Class683.bool_1 = false;
			Class683.bool_0 = true;
			GClass93.smethod_0().method_17<ServicesTweak>();
			Class683.smethod_2();
		}
		return Class683.class760_0;
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x000870D8 File Offset: 0x000852D8
	private static void smethod_2()
	{
		Class683.Struct357 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class683.Struct357>(ref @struct);
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x00087108 File Offset: 0x00085308
	private static List<GClass61> smethod_3(List<GClass151> list_0, GClass172.GClass174 gclass174_0)
	{
		Class683.Class686 @class = new Class683.Class686();
		@class.list_0 = list_0;
		return gclass174_0.method_0().Select(new Func<GClass172.GClass173, GClass61>(@class.method_0)).ToList<GClass61>();
	}

	// Token: 0x06002157 RID: 8535 RVA: 0x00087140 File Offset: 0x00085340
	public static void smethod_4()
	{
		Class683.Struct356 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class683.Struct356>(ref @struct);
	}

	// Token: 0x06002158 RID: 8536 RVA: 0x00087170 File Offset: 0x00085370
	public static void smethod_5(RoutedEventArgs routedEventArgs_0)
	{
		Class683.Struct359 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class683.Struct359>(ref @struct);
	}

	// Token: 0x06002159 RID: 8537 RVA: 0x000871A0 File Offset: 0x000853A0
	public static void smethod_6()
	{
		Class683.Struct358 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class683.Struct358>(ref @struct);
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x000871D0 File Offset: 0x000853D0
	public static Task smethod_7()
	{
		Class683.Struct360 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class683.Struct360>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x040016E2 RID: 5858
	public static Class683.Class760 class760_0 = new Class683.Class760();

	// Token: 0x040016E3 RID: 5859
	private static bool bool_0 = false;

	// Token: 0x040016E4 RID: 5860
	private static bool bool_1 = false;

	// Token: 0x020005FC RID: 1532
	[StructLayout(LayoutKind.Auto)]
	private struct Struct356 : IAsyncStateMachine
	{
		// Token: 0x0600215B RID: 8539 RVA: 0x0008720C File Offset: 0x0008540C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class683.bool_1)
					{
						goto IL_6B;
					}
					awaiter = Class683.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class683.Struct356>(ref awaiter, ref this);
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
				IL_6B:
				IEnumerator<Class683.Class761> enumerator = Class683.class760_0.GroupServices.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class683.Class761 @class = enumerator.Current;
						@class.ServicesViewGroupModels.ForEach(new Action<GClass61>(Class683.Class690.class690_0.method_2));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				bool? nullable_ = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_4;
				if (!nullable_.GetValueOrDefault() & nullable_ != null)
				{
					enumerator = Class683.class760_0.GroupServices.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class683.Class761 class2 = enumerator.Current;
							class2.ServicesViewGroupModels.ForEach(new Action<GClass61>(Class683.Class690.class690_0.method_3));
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

		// Token: 0x0600215C RID: 8540 RVA: 0x000873CC File Offset: 0x000855CC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040016E5 RID: 5861
		public int int_0;

		// Token: 0x040016E6 RID: 5862
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040016E7 RID: 5863
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005FD RID: 1533
	private sealed class Class684
	{
		// Token: 0x0600215E RID: 8542 RVA: 0x000873E4 File Offset: 0x000855E4
		internal bool method_0(GClass151 gclass151_0)
		{
			return this.gclass173_0.Services.Contains(gclass151_0.Service.ServiceName);
		}

		// Token: 0x040016E8 RID: 5864
		public GClass172.GClass173 gclass173_0;
	}

	// Token: 0x020005FE RID: 1534
	[StructLayout(LayoutKind.Auto)]
	private struct Struct357 : IAsyncStateMachine
	{
		// Token: 0x0600215F RID: 8543 RVA: 0x00087404 File Offset: 0x00085604
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class683.Class690.class690_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class683.Struct357>(ref awaiter, ref this);
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

		// Token: 0x06002160 RID: 8544 RVA: 0x000874D0 File Offset: 0x000856D0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040016E9 RID: 5865
		public int int_0;

		// Token: 0x040016EA RID: 5866
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040016EB RID: 5867
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005FF RID: 1535
	[StructLayout(LayoutKind.Auto)]
	private struct Struct358 : IAsyncStateMachine
	{
		// Token: 0x06002161 RID: 8545 RVA: 0x000874E0 File Offset: 0x000856E0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class683.bool_1)
					{
						goto IL_6B;
					}
					awaiter = Class683.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class683.Struct358>(ref awaiter, ref this);
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
				IL_6B:
				IEnumerator<Class683.Class761> enumerator = Class683.class760_0.GroupServices.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class683.Class761 @class = enumerator.Current;
						@class.ServicesViewGroupModels.ForEach(new Action<GClass61>(Class683.Class690.class690_0.method_5));
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

		// Token: 0x06002162 RID: 8546 RVA: 0x000875FC File Offset: 0x000857FC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040016EC RID: 5868
		public int int_0;

		// Token: 0x040016ED RID: 5869
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040016EE RID: 5870
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000600 RID: 1536
	private sealed class Class685
	{
		// Token: 0x06002164 RID: 8548 RVA: 0x00087614 File Offset: 0x00085814
		internal void method_0()
		{
			Class683.class760_0.GroupServices.Add(new Class683.Class761
			{
				HeaderText = this.class691_0.method_0(),
				DescText = this.class691_0.Desc,
				ServicesViewGroupModels = this.class691_0.method_2()
			});
		}

		// Token: 0x040016EF RID: 5871
		public Class683.Class691 class691_0;
	}

	// Token: 0x02000601 RID: 1537
	private sealed class Class686
	{
		// Token: 0x06002166 RID: 8550 RVA: 0x00087670 File Offset: 0x00085870
		internal GClass61 method_0(GClass172.GClass173 gclass173_0)
		{
			Class683.Class684 @class = new Class683.Class684();
			@class.gclass173_0 = gclass173_0;
			List<GClass151> list_ = this.list_0.Where(new Func<GClass151, bool>(@class.method_0)).ToList<GClass151>();
			return new GClass61(@class.gclass173_0, list_);
		}

		// Token: 0x040016F0 RID: 5872
		public List<GClass151> list_0;
	}

	// Token: 0x02000602 RID: 1538
	private sealed class Class687
	{
		// Token: 0x06002168 RID: 8552 RVA: 0x000876BC File Offset: 0x000858BC
		internal void method_0(GClass172.GClass173 gclass173_0)
		{
			if (gclass173_0 == this.gclass61_0.ServicesViewGroupName)
			{
				this.gclass61_0.IsDisabled = new bool?(true);
			}
		}

		// Token: 0x040016F1 RID: 5873
		public GClass61 gclass61_0;
	}

	// Token: 0x02000603 RID: 1539
	private sealed class Class688
	{
		// Token: 0x0600216A RID: 8554 RVA: 0x000876E8 File Offset: 0x000858E8
		internal void method_0()
		{
			Class683.class760_0.AllServices.Add(this.gclass151_0);
		}

		// Token: 0x040016F2 RID: 5874
		public GClass151 gclass151_0;
	}

	// Token: 0x02000604 RID: 1540
	private sealed class Class689
	{
		// Token: 0x0600216C RID: 8556 RVA: 0x00087708 File Offset: 0x00085908
		internal void method_0(GClass172.GClass173 gclass173_0)
		{
			if (gclass173_0 == this.gclass61_0.ServicesViewGroupName)
			{
				this.gclass61_0.IsDisabled = new bool?(true);
			}
		}

		// Token: 0x040016F3 RID: 5875
		public GClass61 gclass61_0;
	}

	// Token: 0x02000605 RID: 1541
	[StructLayout(LayoutKind.Auto)]
	private struct Struct359 : IAsyncStateMachine
	{
		// Token: 0x0600216D RID: 8557 RVA: 0x0008772C File Offset: 0x0008592C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class683.bool_1)
					{
						goto IL_6B;
					}
					awaiter = Class683.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class683.Struct359>(ref awaiter, ref this);
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
				IL_6B:
				IEnumerator<Class683.Class761> enumerator = Class683.class760_0.GroupServices.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class683.Class761 @class = enumerator.Current;
						@class.ServicesViewGroupModels.ForEach(new Action<GClass61>(Class683.Class690.class690_0.method_4));
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

		// Token: 0x0600216E RID: 8558 RVA: 0x00087848 File Offset: 0x00085A48
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040016F4 RID: 5876
		public int int_0;

		// Token: 0x040016F5 RID: 5877
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040016F6 RID: 5878
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000606 RID: 1542
	public sealed class Class760 : GClass211
	{
		// Token: 0x0600216F RID: 8559 RVA: 0x00087858 File Offset: 0x00085A58
		public Class760()
		{
			this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00087890 File Offset: 0x00085A90
		private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
		{
			base.method_0("ColChanged");
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x000878A0 File Offset: 0x00085AA0
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x000878A8 File Offset: 0x00085AA8
		public ObservableCollection<Class683.Class761> GroupServices
		{
			get
			{
				return this.observableCollection_0;
			}
			set
			{
				this.observableCollection_0 = value;
				base.method_0("GroupServices");
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x000878BC File Offset: 0x00085ABC
		// (set) Token: 0x06002174 RID: 8564 RVA: 0x000878C4 File Offset: 0x00085AC4
		public List<GClass151> AllServices
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
				base.method_0("AllServices");
			}
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x000878D8 File Offset: 0x00085AD8
		public void method_1()
		{
			this.AllServices.Clear();
			this.GroupServices.Clear();
		}

		// Token: 0x040016F7 RID: 5879
		public ObservableCollection<Class683.Class761> observableCollection_0 = new ObservableCollection<Class683.Class761>();

		// Token: 0x040016F8 RID: 5880
		public List<GClass151> list_0 = new List<GClass151>();
	}

	// Token: 0x02000607 RID: 1543
	[StructLayout(LayoutKind.Auto)]
	private struct Struct360 : IAsyncStateMachine
	{
		// Token: 0x06002176 RID: 8566 RVA: 0x000878F0 File Offset: 0x00085AF0
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
				if (Class683.bool_1)
				{
					goto IL_AD;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class683.Struct360>(ref awaiter, ref this);
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

		// Token: 0x06002177 RID: 8567 RVA: 0x000879D0 File Offset: 0x00085BD0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040016F9 RID: 5881
		public int int_0;

		// Token: 0x040016FA RID: 5882
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040016FB RID: 5883
		private int int_1;

		// Token: 0x040016FC RID: 5884
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000608 RID: 1544
	[Serializable]
	private sealed class Class690
	{
		// Token: 0x0600217A RID: 8570 RVA: 0x000879F4 File Offset: 0x00085BF4
		internal void method_0()
		{
			Application.Current.Dispatcher.Invoke(new Action(Class683.Class690.class690_0.method_1));
			List<GClass151> list = Class468.smethod_0().method_9();
			using (List<GClass151>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class683.Class688 @class = new Class683.Class688();
					@class.gclass151_0 = enumerator.Current;
					Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
				}
			}
			List<Class683.Class691> list2 = new List<Class683.Class691>();
			Class683.Class691 class2 = new Class683.Class691();
			class2.method_1("WinSerGroup1");
			class2.Desc = "WinSerGroup1Desc";
			class2.method_3(Class683.smethod_3(list, GClass158.gclass174_0));
			list2.Add(class2);
			Class683.Class691 class3 = new Class683.Class691();
			class3.method_1("WinSerGroup2");
			class3.Desc = "WinSerGroup2Desc";
			class3.method_3(Class683.smethod_3(list, GClass158.gclass174_1));
			list2.Add(class3);
			using (List<Class683.Class691>.Enumerator enumerator2 = list2.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					Class683.Class685 class4 = new Class683.Class685();
					class4.class691_0 = enumerator2.Current;
					Application.Current.Dispatcher.Invoke(new Action(class4.method_0));
				}
			}
			GClass93.smethod_0().method_10();
			Class683.bool_1 = true;
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00087B74 File Offset: 0x00085D74
		internal void method_1()
		{
			Class683.class760_0.method_1();
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00087B80 File Offset: 0x00085D80
		internal void method_2(GClass61 gclass61_0)
		{
			Class683.Class687 @class = new Class683.Class687();
			@class.gclass61_0 = gclass61_0;
			GClass158.gclass174_2.method_0().ForEach(new Action<GClass172.GClass173>(@class.method_0));
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00087BB8 File Offset: 0x00085DB8
		internal void method_3(GClass61 gclass61_0)
		{
			if (gclass61_0.ServicesViewGroupName == GClass115.gclass173_19)
			{
				gclass61_0.IsDisabled = new bool?(true);
			}
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00087BD4 File Offset: 0x00085DD4
		internal void method_4(GClass61 gclass61_0)
		{
			Class683.Class689 @class = new Class683.Class689();
			@class.gclass61_0 = gclass61_0;
			GClass158.gclass174_3.method_0().ForEach(new Action<GClass172.GClass173>(@class.method_0));
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x00087C0C File Offset: 0x00085E0C
		internal void method_5(GClass61 gclass61_0)
		{
			gclass61_0.IsDisabled = new bool?(false);
		}

		// Token: 0x040016FD RID: 5885
		public static readonly Class683.Class690 class690_0 = new Class683.Class690();

		// Token: 0x040016FE RID: 5886
		public static Action action_0;

		// Token: 0x040016FF RID: 5887
		public static Action action_1;

		// Token: 0x04001700 RID: 5888
		public static Action<GClass61> action_2;

		// Token: 0x04001701 RID: 5889
		public static Action<GClass61> action_3;

		// Token: 0x04001702 RID: 5890
		public static Action<GClass61> action_4;

		// Token: 0x04001703 RID: 5891
		public static Action<GClass61> action_5;
	}

	// Token: 0x02000609 RID: 1545
	public sealed class Class691
	{
		// Token: 0x06002181 RID: 8577 RVA: 0x00087C24 File Offset: 0x00085E24
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00087C2C File Offset: 0x00085E2C
		public void method_1(string string_2)
		{
			this.string_0 = string_2;
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x00087C38 File Offset: 0x00085E38
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x00087C40 File Offset: 0x00085E40
		public string Desc
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

		// Token: 0x06002185 RID: 8581 RVA: 0x00087C4C File Offset: 0x00085E4C
		public List<GClass61> method_2()
		{
			return this.list_0;
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00087C54 File Offset: 0x00085E54
		public void method_3(List<GClass61> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x04001704 RID: 5892
		private string string_0;

		// Token: 0x04001705 RID: 5893
		private string string_1;

		// Token: 0x04001706 RID: 5894
		private List<GClass61> list_0;
	}

	// Token: 0x0200060A RID: 1546
	public sealed class Class692 : INotifyPropertyChanged
	{
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x00087C68 File Offset: 0x00085E68
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x00087C70 File Offset: 0x00085E70
		public bool ShowDisplayName
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
				this.vmethod_0("ShowDisplayName");
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x00087C90 File Offset: 0x00085E90
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x00087C98 File Offset: 0x00085E98
		public ObservableCollection<GClass151> SingleServiceInfoViews
		{
			get
			{
				return this.observableCollection_0;
			}
			set
			{
				if (object.Equals(value, this.observableCollection_0))
				{
					return;
				}
				this.observableCollection_0 = value;
				this.vmethod_0("SingleServiceInfoViews");
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600218C RID: 8588 RVA: 0x00087CBC File Offset: 0x00085EBC
		// (remove) Token: 0x0600218D RID: 8589 RVA: 0x00087CF4 File Offset: 0x00085EF4
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

		// Token: 0x0600218E RID: 8590 RVA: 0x00087D2C File Offset: 0x00085F2C
		protected void vmethod_0([CallerMemberName] string string_0)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler == null)
			{
				return;
			}
			propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_0));
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00087D48 File Offset: 0x00085F48
		protected bool method_0<T>(ref T gparam_0, T gparam_1, [CallerMemberName] string string_0)
		{
			if (EqualityComparer<T>.Default.Equals(gparam_0, gparam_1))
			{
				return false;
			}
			gparam_0 = gparam_1;
			this.vmethod_0(string_0);
			return true;
		}

		// Token: 0x04001707 RID: 5895
		private bool bool_0;

		// Token: 0x04001708 RID: 5896
		private ObservableCollection<GClass151> observableCollection_0;

		// Token: 0x04001709 RID: 5897
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}

	// Token: 0x0200060B RID: 1547
	public sealed class Class761 : GClass211
	{
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06002191 RID: 8593 RVA: 0x00087D78 File Offset: 0x00085F78
		// (set) Token: 0x06002192 RID: 8594 RVA: 0x00087D80 File Offset: 0x00085F80
		public List<GClass61> ServicesViewGroupModels
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
				this.list_0 = value;
				base.method_0("ServicesViewGroupModels");
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x00087DA4 File Offset: 0x00085FA4
		// (set) Token: 0x06002194 RID: 8596 RVA: 0x00087DAC File Offset: 0x00085FAC
		public string HeaderText
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
				base.method_0("HeaderText");
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x00087DD0 File Offset: 0x00085FD0
		// (set) Token: 0x06002196 RID: 8598 RVA: 0x00087DD8 File Offset: 0x00085FD8
		public string DescText
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
				base.method_0("DescText");
			}
		}

		// Token: 0x0400170A RID: 5898
		private string string_0;

		// Token: 0x0400170B RID: 5899
		private string string_1;

		// Token: 0x0400170C RID: 5900
		private List<GClass61> list_0;
	}
}
