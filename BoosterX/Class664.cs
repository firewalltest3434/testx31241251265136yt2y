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
using BoosterX.Classes.Tweaks.CleanerModel;
using ns0;

// Token: 0x020005D6 RID: 1494
internal sealed class Class664
{
	// Token: 0x060020A8 RID: 8360 RVA: 0x00084124 File Offset: 0x00082324
	public static void smethod_0(Class664.Delegate33 delegate33_1)
	{
		Class664.Delegate33 @delegate = Class664.delegate33_0;
		Class664.Delegate33 delegate2;
		do
		{
			delegate2 = @delegate;
			Class664.Delegate33 value = (Class664.Delegate33)Delegate.Combine(delegate2, delegate33_1);
			@delegate = Interlocked.CompareExchange<Class664.Delegate33>(ref Class664.delegate33_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x060020A9 RID: 8361 RVA: 0x00084158 File Offset: 0x00082358
	public static void smethod_1(Class664.Delegate33 delegate33_1)
	{
		Class664.Delegate33 @delegate = Class664.delegate33_0;
		Class664.Delegate33 delegate2;
		do
		{
			delegate2 = @delegate;
			Class664.Delegate33 value = (Class664.Delegate33)Delegate.Remove(delegate2, delegate33_1);
			@delegate = Interlocked.CompareExchange<Class664.Delegate33>(ref Class664.delegate33_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x060020AA RID: 8362 RVA: 0x0008418C File Offset: 0x0008238C
	public static Class664.Class759 smethod_2(bool bool_2)
	{
		if (!Class664.bool_0 || bool_2)
		{
			Class664.bool_0 = true;
			Class664.bool_1 = false;
			GClass93.smethod_0().method_17<Class526>();
			Application.Current.Dispatcher.Invoke(new Action(Class664.Class670.class670_0.method_0));
			Class664.smethod_3();
		}
		return Class664.class759_0;
	}

	// Token: 0x060020AB RID: 8363 RVA: 0x000841F4 File Offset: 0x000823F4
	private static void smethod_3()
	{
		Class664.Struct350 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class664.Struct350>(ref @struct);
	}

	// Token: 0x060020AC RID: 8364 RVA: 0x00084224 File Offset: 0x00082424
	public static ObservableCollection<Class739> smethod_4(bool bool_2)
	{
		Class664.Class667 @class = new Class664.Class667();
		@class.bool_0 = bool_2;
		GClass207 gclass = new GClass207();
		@class.list_0 = null;
		@class.list_1 = gclass.method_2<List<JsonCleanDto>>(Class588.list_0.First(new Func<Class588.Class753, bool>(Class664.Class670.class670_0.method_4)).JsonPath);
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		using (List<JsonCleanDto>.Enumerator enumerator = @class.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class664.Class665 class2 = new Class664.Class665();
				class2.class667_0 = @class;
				class2.jsonCleanDto_0 = enumerator.Current;
				Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
			}
		}
		return Class664.class759_0.CleanUpModels;
	}

	// Token: 0x060020AD RID: 8365 RVA: 0x00084318 File Offset: 0x00082518
	public static void smethod_5()
	{
		Class664.Struct349 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class664.Struct349>(ref @struct);
	}

	// Token: 0x060020AE RID: 8366 RVA: 0x00084348 File Offset: 0x00082548
	public static Task smethod_6()
	{
		Class664.Struct352 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class664.Struct352>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060020AF RID: 8367 RVA: 0x00084384 File Offset: 0x00082584
	internal static void smethod_7()
	{
		Class664.Struct353 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class664.Struct353>(ref @struct);
	}

	// Token: 0x060020B0 RID: 8368 RVA: 0x000843B4 File Offset: 0x000825B4
	internal static void smethod_8()
	{
		Class664.Struct354 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class664.Struct354>(ref @struct);
	}

	// Token: 0x060020B1 RID: 8369 RVA: 0x000843E4 File Offset: 0x000825E4
	internal static void smethod_9()
	{
		Class664.Struct351 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class664.Struct351>(ref @struct);
	}

	// Token: 0x0400168B RID: 5771
	private static Class664.Delegate33 delegate33_0;

	// Token: 0x0400168C RID: 5772
	private static bool bool_0 = false;

	// Token: 0x0400168D RID: 5773
	private static bool bool_1 = false;

	// Token: 0x0400168E RID: 5774
	public static Class664.Class759 class759_0 = new Class664.Class759();

	// Token: 0x020005D7 RID: 1495
	[StructLayout(LayoutKind.Auto)]
	private struct Struct349 : IAsyncStateMachine
	{
		// Token: 0x060020B2 RID: 8370 RVA: 0x00084414 File Offset: 0x00082614
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class664.bool_1)
					{
						goto IL_75;
					}
					Class664.smethod_2(false);
					awaiter = Class664.smethod_6().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class664.Struct349>(ref awaiter, ref this);
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
				IL_75:
				IEnumerator<Class739> enumerator = Class664.class759_0.CleanUpModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class739 @class = enumerator.Current;
						@class.ToDelete = true;
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				IEnumerator<Class750> enumerator2 = Class664.class759_0.DeletedUwpCleanModels.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Class750 class2 = enumerator2.Current;
						class2.ToDelete = true;
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				IEnumerator<Class722> enumerator3 = Class664.class759_0.DisconnectedDevicesModels.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						Class722 class3 = enumerator3.Current;
						class3.ToDelete = true;
					}
				}
				finally
				{
					if (num < 0 && enumerator3 != null)
					{
						enumerator3.Dispose();
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

		// Token: 0x060020B3 RID: 8371 RVA: 0x000845D0 File Offset: 0x000827D0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400168F RID: 5775
		public int int_0;

		// Token: 0x04001690 RID: 5776
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001691 RID: 5777
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005D8 RID: 1496
	[StructLayout(LayoutKind.Auto)]
	private struct Struct350 : IAsyncStateMachine
	{
		// Token: 0x060020B4 RID: 8372 RVA: 0x000845E0 File Offset: 0x000827E0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class664.Class670.class670_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class664.Struct350>(ref awaiter, ref this);
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

		// Token: 0x060020B5 RID: 8373 RVA: 0x000846AC File Offset: 0x000828AC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001692 RID: 5778
		public int int_0;

		// Token: 0x04001693 RID: 5779
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001694 RID: 5780
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005D9 RID: 1497
	private sealed class Class665
	{
		// Token: 0x060020B7 RID: 8375 RVA: 0x000846C4 File Offset: 0x000828C4
		internal void method_0()
		{
			Class664.class759_0.CleanUpModels.Add(new Class739(this.jsonCleanDto_0, this.class667_0.bool_0));
		}

		// Token: 0x04001695 RID: 5781
		public JsonCleanDto jsonCleanDto_0;

		// Token: 0x04001696 RID: 5782
		public Class664.Class667 class667_0;
	}

	// Token: 0x020005DA RID: 1498
	[StructLayout(LayoutKind.Auto)]
	private struct Struct351 : IAsyncStateMachine
	{
		// Token: 0x060020B8 RID: 8376 RVA: 0x000846EC File Offset: 0x000828EC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class664.bool_1)
					{
						goto IL_72;
					}
					Class664.smethod_2(false);
					awaiter = Class664.smethod_6().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class664.Struct351>(ref awaiter, ref this);
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
				IL_72:
				IEnumerator<Class739> enumerator = Class664.class759_0.CleanUpModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class739 @class = enumerator.Current;
						@class.ToDelete = true;
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

		// Token: 0x060020B9 RID: 8377 RVA: 0x000847EC File Offset: 0x000829EC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001697 RID: 5783
		public int int_0;

		// Token: 0x04001698 RID: 5784
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001699 RID: 5785
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005DB RID: 1499
	private sealed class Class666
	{
		// Token: 0x060020BB RID: 8379 RVA: 0x00084804 File Offset: 0x00082A04
		internal void method_0(string string_0)
		{
			Class664.Class671 @class = new Class664.Class671();
			@class.string_0 = string_0.Split(new char[]
			{
				'\\'
			}).Last<string>();
			@class.bool_0 = false;
			Class605.list_9.ForEach(new Action<string>(@class.method_0));
			if (!@class.bool_0)
			{
				this.list_0.Add(@class.string_0);
			}
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x0008486C File Offset: 0x00082A6C
		internal void method_1(string string_0)
		{
			string item = string_0.Split(new char[]
			{
				'_'
			})[0] + "_" + string_0.Split(new char[]
			{
				'_'
			})[1];
			if (!this.list_1.Contains(item))
			{
				this.list_1.Add(item);
			}
		}

		// Token: 0x0400169A RID: 5786
		public List<string> list_0;

		// Token: 0x0400169B RID: 5787
		public List<string> list_1;
	}

	// Token: 0x020005DC RID: 1500
	private sealed class Class667
	{
		// Token: 0x060020BE RID: 8382 RVA: 0x000848CC File Offset: 0x00082ACC
		internal void method_0()
		{
			this.list_0 = new List<JsonCleanDto>();
			this.list_0.AddRange(this.list_1);
		}

		// Token: 0x0400169C RID: 5788
		public List<JsonCleanDto> list_0;

		// Token: 0x0400169D RID: 5789
		public List<JsonCleanDto> list_1;

		// Token: 0x0400169E RID: 5790
		public bool bool_0;
	}

	// Token: 0x020005DD RID: 1501
	private sealed class Class668
	{
		// Token: 0x060020C0 RID: 8384 RVA: 0x000848F4 File Offset: 0x00082AF4
		internal void method_0()
		{
			Class664.class759_0.DisconnectedDevicesModels.Add(new Class722(this.gclass116_0));
		}

		// Token: 0x0400169F RID: 5791
		public GClass116 gclass116_0;
	}

	// Token: 0x020005DE RID: 1502
	private sealed class Class669
	{
		// Token: 0x060020C2 RID: 8386 RVA: 0x00084918 File Offset: 0x00082B18
		internal void method_0()
		{
			Class664.class759_0.DeletedUwpCleanModels.Add(new Class750
			{
				Name = this.string_0
			});
		}

		// Token: 0x040016A0 RID: 5792
		public string string_0;
	}

	// Token: 0x020005DF RID: 1503
	[StructLayout(LayoutKind.Auto)]
	private struct Struct352 : IAsyncStateMachine
	{
		// Token: 0x060020C3 RID: 8387 RVA: 0x0008493C File Offset: 0x00082B3C
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
				if (Class664.bool_1)
				{
					goto IL_AD;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class664.Struct352>(ref awaiter, ref this);
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

		// Token: 0x060020C4 RID: 8388 RVA: 0x00084A1C File Offset: 0x00082C1C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040016A1 RID: 5793
		public int int_0;

		// Token: 0x040016A2 RID: 5794
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040016A3 RID: 5795
		private int int_1;

		// Token: 0x040016A4 RID: 5796
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005E0 RID: 1504
	public sealed class Class759 : GClass211
	{
		// Token: 0x060020C5 RID: 8389 RVA: 0x00084A2C File Offset: 0x00082C2C
		public Class759()
		{
			this.observableCollection_1.CollectionChanged += this.observableCollection_0_CollectionChanged;
			this.observableCollection_2.CollectionChanged += this.observableCollection_0_CollectionChanged;
			this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00084AA8 File Offset: 0x00082CA8
		public void method_1()
		{
			this.DeletedUwpCleanModels.Clear();
			this.CleanUpModels.Clear();
			this.DisconnectedDevicesModels.Clear();
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x00084ACC File Offset: 0x00082CCC
		private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
		{
			base.method_0("DisDevColChanged");
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x00084ADC File Offset: 0x00082CDC
		// (set) Token: 0x060020C9 RID: 8393 RVA: 0x00084AE4 File Offset: 0x00082CE4
		public ObservableCollection<Class739> CleanUpModels
		{
			get
			{
				return this.observableCollection_0;
			}
			set
			{
				this.observableCollection_0 = value;
				base.method_0("CleanUpModels");
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x00084AF8 File Offset: 0x00082CF8
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x00084B00 File Offset: 0x00082D00
		public ObservableCollection<Class750> DeletedUwpCleanModels
		{
			get
			{
				return this.observableCollection_1;
			}
			set
			{
				this.observableCollection_1 = value;
				base.method_0("DeletedUwpCleanModels");
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x00084B14 File Offset: 0x00082D14
		// (set) Token: 0x060020CD RID: 8397 RVA: 0x00084B1C File Offset: 0x00082D1C
		public ObservableCollection<Class722> DisconnectedDevicesModels
		{
			get
			{
				return this.observableCollection_2;
			}
			set
			{
				this.observableCollection_2 = value;
				base.method_0("DisconnectedDevicesModels");
			}
		}

		// Token: 0x040016A5 RID: 5797
		private ObservableCollection<Class739> observableCollection_0 = new ObservableCollection<Class739>();

		// Token: 0x040016A6 RID: 5798
		private ObservableCollection<Class750> observableCollection_1 = new ObservableCollection<Class750>();

		// Token: 0x040016A7 RID: 5799
		private ObservableCollection<Class722> observableCollection_2 = new ObservableCollection<Class722>();
	}

	// Token: 0x020005E1 RID: 1505
	[Serializable]
	private sealed class Class670
	{
		// Token: 0x060020D0 RID: 8400 RVA: 0x00084B44 File Offset: 0x00082D44
		internal void method_0()
		{
			Class664.class759_0.method_1();
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00084B50 File Offset: 0x00082D50
		internal void method_1()
		{
			Class664.smethod_4(true);
			try
			{
				Class694.smethod_1().ForEach(new Action<GClass116>(Class664.Class670.class670_0.method_2));
			}
			catch (object obj)
			{
			}
			try
			{
				Class664.Class666 @class = new Class664.Class666();
				Class497.smethod_0().method_0();
				List<string> list = Directory.GetDirectories("C:\\Program Files\\WindowsApps").ToList<string>();
				@class.list_0 = new List<string>();
				list.ForEach(new Action<string>(@class.method_0));
				@class.list_1 = new List<string>();
				@class.list_0.ForEach(new Action<string>(@class.method_1));
				@class.list_1.ForEach(new Action<string>(Class664.Class670.class670_0.method_3));
			}
			catch (object obj2)
			{
			}
			Class664.Delegate33 delegate33_ = Class664.delegate33_0;
			if (delegate33_ != null)
			{
				delegate33_();
			}
			Class664.bool_1 = true;
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00084C54 File Offset: 0x00082E54
		internal void method_2(GClass116 gclass116_0)
		{
			Class664.Class668 @class = new Class664.Class668();
			@class.gclass116_0 = gclass116_0;
			try
			{
				if (!@class.gclass116_0.Name.StartsWith("WAN Miniport"))
				{
					Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
				}
			}
			catch (object obj)
			{
			}
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00084CB8 File Offset: 0x00082EB8
		internal void method_3(string string_0)
		{
			Class664.Class669 @class = new Class664.Class669();
			@class.string_0 = string_0;
			if (!Class497.smethod_0().method_2(@class.string_0))
			{
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			}
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00084D00 File Offset: 0x00082F00
		internal bool method_4(Class588.Class753 class753_0)
		{
			return class753_0.Type == typeof(dje_z627PU6QDPF5L5L22PZKAYL8VEPS25LWV7TFR5U5JH6MNTERGA6VSXSKBF49Q_ejd);
		}

		// Token: 0x040016A8 RID: 5800
		public static readonly Class664.Class670 class670_0 = new Class664.Class670();

		// Token: 0x040016A9 RID: 5801
		public static Action action_0;

		// Token: 0x040016AA RID: 5802
		public static Action<GClass116> action_1;

		// Token: 0x040016AB RID: 5803
		public static Action<string> action_2;

		// Token: 0x040016AC RID: 5804
		public static Action action_3;

		// Token: 0x040016AD RID: 5805
		public static Func<Class588.Class753, bool> func_0;
	}

	// Token: 0x020005E2 RID: 1506
	// (Invoke) Token: 0x060020D6 RID: 8406
	public delegate void Delegate33();

	// Token: 0x020005E3 RID: 1507
	private sealed class Class671
	{
		// Token: 0x060020DA RID: 8410 RVA: 0x00084D20 File Offset: 0x00082F20
		internal void method_0(string string_1)
		{
			if (this.string_0 == string_1)
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x040016AE RID: 5806
		public string string_0;

		// Token: 0x040016AF RID: 5807
		public bool bool_0;
	}

	// Token: 0x020005E4 RID: 1508
	[StructLayout(LayoutKind.Auto)]
	private struct Struct353 : IAsyncStateMachine
	{
		// Token: 0x060020DB RID: 8411 RVA: 0x00084D38 File Offset: 0x00082F38
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class664.bool_1)
					{
						goto IL_72;
					}
					Class664.smethod_2(false);
					awaiter = Class664.smethod_6().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class664.Struct353>(ref awaiter, ref this);
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
				IL_72:
				IEnumerator<Class722> enumerator = Class664.class759_0.DisconnectedDevicesModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class722 @class = enumerator.Current;
						@class.ToDelete = true;
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

		// Token: 0x060020DC RID: 8412 RVA: 0x00084E38 File Offset: 0x00083038
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040016B0 RID: 5808
		public int int_0;

		// Token: 0x040016B1 RID: 5809
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040016B2 RID: 5810
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005E5 RID: 1509
	[StructLayout(LayoutKind.Auto)]
	private struct Struct354 : IAsyncStateMachine
	{
		// Token: 0x060020DD RID: 8413 RVA: 0x00084E48 File Offset: 0x00083048
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class664.bool_1)
					{
						goto IL_72;
					}
					Class664.smethod_2(false);
					awaiter = Class664.smethod_6().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class664.Struct354>(ref awaiter, ref this);
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
				IL_72:
				IEnumerator<Class750> enumerator = Class664.class759_0.DeletedUwpCleanModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class750 @class = enumerator.Current;
						@class.ToDelete = true;
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

		// Token: 0x060020DE RID: 8414 RVA: 0x00084F48 File Offset: 0x00083148
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040016B3 RID: 5811
		public int int_0;

		// Token: 0x040016B4 RID: 5812
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040016B5 RID: 5813
		private TaskAwaiter taskAwaiter_0;
	}
}
