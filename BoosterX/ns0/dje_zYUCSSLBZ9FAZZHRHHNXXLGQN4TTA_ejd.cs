using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ns0
{
	// Token: 0x02000820 RID: 2080
	public static class dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd
	{
		// Token: 0x06002A6C RID: 10860 RVA: 0x000B75F0 File Offset: 0x000B57F0
		public static bool smethod_0()
		{
			return false;
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000B75F4 File Offset: 0x000B57F4
		public static void smethod_1(bool bool_8)
		{
			if (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_2)
			{
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_3();
			}
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_2 = bool_8;
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x000B7608 File Offset: 0x000B5808
		private static bool smethod_2()
		{
			return dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_2 || GClass93.smethod_0().method_21();
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x000B7620 File Offset: 0x000B5820
		private static void smethod_3()
		{
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x000B7624 File Offset: 0x000B5824
		public static void smethod_4()
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct585 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct585>(ref @struct);
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x000B7654 File Offset: 0x000B5854
		private static void smethod_5()
		{
			if (File.Exists("C:\\jsonModel.json"))
			{
				File.Delete("C:\\jsonModel.json");
			}
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x000B766C File Offset: 0x000B586C
		private static void smethod_6()
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct591 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct591>(ref @struct);
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x000B769C File Offset: 0x000B589C
		public static void smethod_7()
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct583 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct583>(ref @struct);
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x000B76CC File Offset: 0x000B58CC
		public static void smethod_8()
		{
			Class555.smethod_0().method_4(Class555.smethod_2(), "&ebgT()Huc", null);
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x000B76E4 File Offset: 0x000B58E4
		public static void smethod_9(string string_4)
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct590 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.string_0 = string_4;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct590>(ref @struct);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x000B771C File Offset: 0x000B591C
		public static void smethod_10(string string_4)
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct589 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.string_0 = string_4;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct589>(ref @struct);
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x000B7754 File Offset: 0x000B5954
		public static void smethod_11(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44 gdelegate44_1)
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44 gdelegate = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate44_0;
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44 value = (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44)Delegate.Combine(gdelegate2, gdelegate44_1);
				gdelegate = Interlocked.CompareExchange<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44>(ref dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate44_0, value, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x000B7788 File Offset: 0x000B5988
		public static void smethod_12(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44 gdelegate44_1)
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44 gdelegate = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate44_0;
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44 value = (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44)Delegate.Remove(gdelegate2, gdelegate44_1);
				gdelegate = Interlocked.CompareExchange<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44>(ref dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate44_0, value, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x000B77BC File Offset: 0x000B59BC
		private static void smethod_13(string string_4, GEnum93 genum93_0)
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class854 @class = new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class854();
			@class.genum93_0 = genum93_0;
			@class.string_0 = string_4;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x000B77F8 File Offset: 0x000B59F8
		public static void smethod_14(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43 gdelegate43_1)
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43 gdelegate = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate43_0;
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43 value = (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43)Delegate.Combine(gdelegate2, gdelegate43_1);
				gdelegate = Interlocked.CompareExchange<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43>(ref dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate43_0, value, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x000B782C File Offset: 0x000B5A2C
		public static void smethod_15(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43 gdelegate43_1)
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43 gdelegate = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate43_0;
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43 value = (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43)Delegate.Remove(gdelegate2, gdelegate43_1);
				gdelegate = Interlocked.CompareExchange<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43>(ref dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate43_0, value, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x000B7860 File Offset: 0x000B5A60
		public static void smethod_16(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42 gdelegate42_1)
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42 gdelegate = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate42_0;
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42 value = (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42)Delegate.Combine(gdelegate2, gdelegate42_1);
				gdelegate = Interlocked.CompareExchange<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42>(ref dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate42_0, value, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x000B7894 File Offset: 0x000B5A94
		public static void smethod_17(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42 gdelegate42_1)
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42 gdelegate = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate42_0;
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42 value = (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42)Delegate.Remove(gdelegate2, gdelegate42_1);
				gdelegate = Interlocked.CompareExchange<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42>(ref dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate42_0, value, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x000B78C8 File Offset: 0x000B5AC8
		public static void smethod_18()
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct584 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct584>(ref @struct);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x000B78F8 File Offset: 0x000B5AF8
		public static void smethod_19()
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct592 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct592>(ref @struct);
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x000B7928 File Offset: 0x000B5B28
		private static void smethod_20(object sender, NotifyCollectionChangedEventArgs p1)
		{
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class859 @class = new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class859();
			@class.int_0 = 0;
			while (@class.int_0 < dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.observableCollection_0.Count - 1)
			{
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
				int num = @class.int_0;
				@class.int_0 = num + 1;
			}
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x000B798C File Offset: 0x000B5B8C
		private static void smethod_21(ref dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct593 struct593_0)
		{
			struct593_0.asyncVoidMethodBuilder_0.Start<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct593>(ref struct593_0);
		}

		// Token: 0x04002088 RID: 8328
		public static string string_0 = string.Empty;

		// Token: 0x04002089 RID: 8329
		public static bool bool_0 = false;

		// Token: 0x0400208A RID: 8330
		public static bool bool_1 = false;

		// Token: 0x0400208B RID: 8331
		public static List<string> list_0 = new List<string>();

		// Token: 0x0400208C RID: 8332
		public static List<string> list_1 = new List<string>();

		// Token: 0x0400208D RID: 8333
		public static string string_1 = string.Empty;

		// Token: 0x0400208E RID: 8334
		public static List<string> list_2 = new List<string>();

		// Token: 0x0400208F RID: 8335
		private static bool bool_2 = false;

		// Token: 0x04002090 RID: 8336
		public static string string_2 = string.Empty;

		// Token: 0x04002091 RID: 8337
		public static bool? nullable_0 = new bool?(false);

		// Token: 0x04002092 RID: 8338
		public static bool? nullable_1 = new bool?(false);

		// Token: 0x04002093 RID: 8339
		public static bool? nullable_2 = new bool?(false);

		// Token: 0x04002094 RID: 8340
		public static bool? nullable_3 = new bool?(true);

		// Token: 0x04002095 RID: 8341
		public static bool? nullable_4 = new bool?(false);

		// Token: 0x04002096 RID: 8342
		public static string dje_zKWDWM2LA_ejd = string.Empty;

		// Token: 0x04002097 RID: 8343
		public static string string_3 = string.Empty;

		// Token: 0x04002098 RID: 8344
		public static bool bool_3 = false;

		// Token: 0x04002099 RID: 8345
		public static bool bool_4 = false;

		// Token: 0x0400209A RID: 8346
		public static bool? nullable_5;

		// Token: 0x0400209B RID: 8347
		public static int int_0 = 0;

		// Token: 0x0400209C RID: 8348
		private static dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44 gdelegate44_0;

		// Token: 0x0400209D RID: 8349
		public static int int_1 = 0;

		// Token: 0x0400209E RID: 8350
		public static int int_2 = 0;

		// Token: 0x0400209F RID: 8351
		public static double double_0 = 0.0;

		// Token: 0x040020A0 RID: 8352
		public static bool bool_5 = false;

		// Token: 0x040020A1 RID: 8353
		private static dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43 gdelegate43_0;

		// Token: 0x040020A2 RID: 8354
		private static dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42 gdelegate42_0;

		// Token: 0x040020A3 RID: 8355
		private static bool bool_6 = false;

		// Token: 0x040020A4 RID: 8356
		public static bool bool_7 = false;

		// Token: 0x040020A5 RID: 8357
		public static ObservableCollection<GClass216> observableCollection_0 = new ObservableCollection<GClass216>();

		// Token: 0x040020A6 RID: 8358
		public static List<string> list_3 = new List<string>();

		// Token: 0x040020A7 RID: 8359
		public static List<string> list_4 = new List<string>();

		// Token: 0x040020A8 RID: 8360
		private static readonly GClass106 gclass106_0 = new GClass106(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_4);

		// Token: 0x040020A9 RID: 8361
		private static readonly GClass27 gclass27_0 = new GClass27(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gclass106_0, new Action<string, GEnum93>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_13));

		// Token: 0x02000821 RID: 2081
		private sealed class Class854
		{
			// Token: 0x06002A83 RID: 10883 RVA: 0x000B79A4 File Offset: 0x000B5BA4
			internal void method_0()
			{
				if (this.genum93_0 == (GEnum93)1)
				{
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.observableCollection_0.Add(new GClass216
					{
						OptCurrent = Class364.smethod_0(this.string_0),
						IsFinished = false
					});
				}
				else
				{
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.observableCollection_0.Add(new GClass216
					{
						OptCurrent = this.string_0,
						IsFinished = false
					});
				}
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate44 gdelegate44_ = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate44_0;
				if (gdelegate44_ == null)
				{
					return;
				}
				gdelegate44_();
			}

			// Token: 0x040020AA RID: 8362
			public GEnum93 genum93_0;

			// Token: 0x040020AB RID: 8363
			public string string_0;
		}

		// Token: 0x02000822 RID: 2082
		// (Invoke) Token: 0x06002A85 RID: 10885
		public delegate void GDelegate42();

		// Token: 0x02000823 RID: 2083
		[StructLayout(LayoutKind.Auto)]
		private struct Struct583 : IAsyncStateMachine
		{
			// Token: 0x06002A88 RID: 10888 RVA: 0x000B7A14 File Offset: 0x000B5C14
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct583>(ref awaiter, ref this);
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

			// Token: 0x06002A89 RID: 10889 RVA: 0x000B7AE0 File Offset: 0x000B5CE0
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020AC RID: 8364
			public int int_0;

			// Token: 0x040020AD RID: 8365
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020AE RID: 8366
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000824 RID: 2084
		private sealed class Class855
		{
			// Token: 0x06002A8B RID: 10891 RVA: 0x000B7AF8 File Offset: 0x000B5CF8
			internal void method_0()
			{
				((GClass222)this.page_0.DataContext).method_3();
				((GClass222)this.page_0.DataContext).EditCount = 0;
				GClass93.smethod_0().method_17<Class522>();
			}

			// Token: 0x040020AF RID: 8367
			public SemaphoreSlim semaphoreSlim_0;

			// Token: 0x040020B0 RID: 8368
			public Page page_0;
		}

		// Token: 0x02000825 RID: 2085
		[StructLayout(LayoutKind.Auto)]
		private struct Struct584 : IAsyncStateMachine
		{
			// Token: 0x06002A8C RID: 10892 RVA: 0x000B7B30 File Offset: 0x000B5D30
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_5)
						{
							goto IL_10D;
						}
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_5 = true;
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate42 gdelegate42_ = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate42_0;
						if (gdelegate42_ != null)
						{
							gdelegate42_();
						}
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.double_0 = 0.0;
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_1 = 0;
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 = 0;
						awaiter = Task.Run(new Func<Task>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_5)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct584>(ref awaiter, ref this);
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
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.double_0 = (double)dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 / (double)dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_1 * 100.0;
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_5 = false;
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.GDelegate43 gdelegate43_ = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gdelegate43_0;
					if (gdelegate43_ != null)
					{
						gdelegate43_();
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_10D:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002A8D RID: 10893 RVA: 0x000B7C70 File Offset: 0x000B5E70
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020B1 RID: 8369
			public int int_0;

			// Token: 0x040020B2 RID: 8370
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020B3 RID: 8371
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000826 RID: 2086
		// (Invoke) Token: 0x06002A8F RID: 10895
		public delegate void GDelegate43();

		// Token: 0x02000827 RID: 2087
		[StructLayout(LayoutKind.Auto)]
		private struct Struct585 : IAsyncStateMachine
		{
			// Token: 0x06002A92 RID: 10898 RVA: 0x000B7C80 File Offset: 0x000B5E80
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct585>(ref awaiter, ref this);
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

			// Token: 0x06002A93 RID: 10899 RVA: 0x000B7D4C File Offset: 0x000B5F4C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020B4 RID: 8372
			public int int_0;

			// Token: 0x040020B5 RID: 8373
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020B6 RID: 8374
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000828 RID: 2088
		private static class Class856
		{
			// Token: 0x040020B7 RID: 8375
			public static NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler_0;

			// Token: 0x040020B8 RID: 8376
			public static Action<string, GEnum93> action_0;
		}

		// Token: 0x02000829 RID: 2089
		[Serializable]
		private sealed class Class857
		{
			// Token: 0x06002A96 RID: 10902 RVA: 0x000B7D70 File Offset: 0x000B5F70
			internal void method_0()
			{
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_7();
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_5();
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_8();
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_6();
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_0 = new bool?(false);
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_1 = new bool?(true);
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_2 = new bool?(false);
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_3 = new bool?(false);
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_4 = new bool?(GClass159.smethod_1("C", (GEnum40)0, true).method_16() == (GEnum53)2);
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_3 = true;
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_5 = new bool?(true);
				Class250.smethod_0();
				Class585.smethod_4();
				bool? flag = Class389.class504_0.method_42();
				if (flag.GetValueOrDefault() & flag != null)
				{
					Class380.smethod_0();
				}
			}

			// Token: 0x06002A97 RID: 10903 RVA: 0x000B7E1C File Offset: 0x000B601C
			internal void method_1()
			{
				Class389.class504_0.method_3(Assembly.GetEntryAssembly().Location);
				bool? flag = Class389.class504_0.method_28();
				if (!(flag.GetValueOrDefault() & flag != null))
				{
					Class389.class504_0.method_29(new bool?(false));
				}
				flag = Class389.class504_0.method_26();
				if (!(!flag.GetValueOrDefault() & flag != null))
				{
					flag = Class389.class504_0.method_26();
					if (!(flag.GetValueOrDefault() & flag != null))
					{
						Class389.class504_0.method_27(new bool?(false));
					}
				}
				if (Class389.class504_0.method_4() != null)
				{
					int? num = Class389.class504_0.method_4();
					if (!(num.GetValueOrDefault() <= 10 & num != null))
					{
						goto IL_E8;
					}
				}
				Class389.class504_0.method_5(new int?(10));
				IL_E8:
				if (Class389.class504_0.method_10() != null)
				{
					int? num = Class389.class504_0.method_10();
					if (!(num.GetValueOrDefault() == 0 & num != null))
					{
						num = Class389.class504_0.method_10();
						if (!(num.GetValueOrDefault() > 2 & num != null))
						{
							goto IL_153;
						}
					}
				}
				Class389.class504_0.method_11(new int?(0));
				IL_153:
				flag = Class389.class504_0.method_42();
				if (!(!flag.GetValueOrDefault() & flag != null))
				{
					Class389.class504_0.method_43(new bool?(true));
				}
				if (Class389.class504_0.method_24() == null && Environment.ProcessorCount <= 2)
				{
					Class389.class504_0.method_25(new bool?(true));
				}
			}

			// Token: 0x06002A98 RID: 10904 RVA: 0x000B7FE4 File Offset: 0x000B61E4
			internal void method_2()
			{
				Class186.smethod_0();
				if (!Directory.Exists(Class186.string_4))
				{
					Directory.CreateDirectory(Class186.string_4);
				}
				if (!Directory.Exists(Class186.string_4 + "\\BackUp"))
				{
					Directory.CreateDirectory(Class186.string_4 + "\\BackUp");
				}
				if (!Directory.Exists(Class186.string_4 + "\\BackUp\\Profiles"))
				{
					Directory.CreateDirectory(Class186.string_4 + "\\BackUp\\Profiles");
				}
				if (!Directory.Exists(Class186.string_4 + "\\BackUp\\Services"))
				{
					Directory.CreateDirectory(Class186.string_4 + "\\BackUp\\Services");
				}
				if (!Directory.Exists(Class186.string_10))
				{
					Directory.CreateDirectory(Class186.string_10);
				}
			}

			// Token: 0x06002A99 RID: 10905 RVA: 0x000B80A8 File Offset: 0x000B62A8
			internal void method_3()
			{
				try
				{
					if (Process.GetProcesses().ToList<Process>().Any(new Func<Process, bool>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_4)))
					{
						Environment.Exit(0);
					}
				}
				catch (object obj)
				{
				}
			}

			// Token: 0x06002A9A RID: 10906 RVA: 0x000B8100 File Offset: 0x000B6300
			internal bool method_4(Process process_0)
			{
				return process_0.ProcessName.ToLower().StartsWith("dnspy") || process_0.ProcessName.ToLower().StartsWith("ilspy") || process_0.ProcessName.ToLower().StartsWith("dotpeek") || process_0.ProcessName.ToLower().StartsWith("ida");
			}

			// Token: 0x06002A9B RID: 10907 RVA: 0x000B816C File Offset: 0x000B636C
			internal Task method_5()
			{
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.Struct587 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.Struct587>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x06002A9C RID: 10908 RVA: 0x000B81A8 File Offset: 0x000B63A8
			internal bool method_6(Class720 class720_0)
			{
				return class720_0.Name.ToLower().Contains("update");
			}

			// Token: 0x06002A9D RID: 10909 RVA: 0x000B81C0 File Offset: 0x000B63C0
			internal bool method_7(Class720 class720_0)
			{
				bool? status = class720_0.Status;
				return status.GetValueOrDefault() & status != null;
			}

			// Token: 0x06002A9E RID: 10910 RVA: 0x000B81E8 File Offset: 0x000B63E8
			internal bool method_8(Class720 class720_0)
			{
				return class720_0.Name.ToLower().Contains("update");
			}

			// Token: 0x06002A9F RID: 10911 RVA: 0x000B8200 File Offset: 0x000B6400
			internal bool method_9(Class720 class720_0)
			{
				bool? status = class720_0.Status;
				return status.GetValueOrDefault() & status != null;
			}

			// Token: 0x06002AA0 RID: 10912 RVA: 0x000B8228 File Offset: 0x000B6428
			internal bool method_10(Class720 class720_0)
			{
				return class720_0.Name.ToLower().Contains("update");
			}

			// Token: 0x06002AA1 RID: 10913 RVA: 0x000B8240 File Offset: 0x000B6440
			internal bool method_11(Class720 class720_0)
			{
				bool? status = class720_0.Status;
				return status.GetValueOrDefault() & status != null;
			}

			// Token: 0x06002AA2 RID: 10914 RVA: 0x000B8268 File Offset: 0x000B6468
			internal bool method_12(Class720 class720_0)
			{
				return class720_0.Name.ToLower().Contains("update");
			}

			// Token: 0x06002AA3 RID: 10915 RVA: 0x000B8280 File Offset: 0x000B6480
			internal bool method_13(Class720 class720_0)
			{
				bool? status = class720_0.Status;
				return status.GetValueOrDefault() & status != null;
			}

			// Token: 0x06002AA4 RID: 10916 RVA: 0x000B82A8 File Offset: 0x000B64A8
			internal Task method_14()
			{
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.Struct586 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.Struct586>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x06002AA5 RID: 10917 RVA: 0x000B82E4 File Offset: 0x000B64E4
			internal void method_15()
			{
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_6 = true;
				ObservableCollection<GClass216> observableCollection_ = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.observableCollection_0;
				NotifyCollectionChangedEventHandler value;
				if ((value = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class856.notifyCollectionChangedEventHandler_0) == null)
				{
					value = (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class856.notifyCollectionChangedEventHandler_0 = new NotifyCollectionChangedEventHandler(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_20));
				}
				observableCollection_.CollectionChanged += value;
			}

			// Token: 0x06002AA6 RID: 10918 RVA: 0x000B8314 File Offset: 0x000B6514
			internal bool method_16(Page page_0)
			{
				return page_0.GetType() == typeof(dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd);
			}

			// Token: 0x06002AA7 RID: 10919 RVA: 0x000B832C File Offset: 0x000B652C
			internal bool method_17(KeyValuePair<string, Action> keyValuePair_0)
			{
				return keyValuePair_0.Key.StartsWith(Class364.smethod_0("storexins5") + " ");
			}

			// Token: 0x040020B9 RID: 8377
			public static readonly dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857 class857_0 = new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857();

			// Token: 0x040020BA RID: 8378
			public static Action action_0;

			// Token: 0x040020BB RID: 8379
			public static Action action_1;

			// Token: 0x040020BC RID: 8380
			public static Action action_2;

			// Token: 0x040020BD RID: 8381
			public static Func<Process, bool> func_0;

			// Token: 0x040020BE RID: 8382
			public static Action action_3;

			// Token: 0x040020BF RID: 8383
			public static Func<Class720, bool> func_1;

			// Token: 0x040020C0 RID: 8384
			public static Func<Class720, bool> func_2;

			// Token: 0x040020C1 RID: 8385
			public static Func<Class720, bool> func_3;

			// Token: 0x040020C2 RID: 8386
			public static Func<Class720, bool> func_4;

			// Token: 0x040020C3 RID: 8387
			public static Func<Class720, bool> func_5;

			// Token: 0x040020C4 RID: 8388
			public static Func<Class720, bool> func_6;

			// Token: 0x040020C5 RID: 8389
			public static Func<Class720, bool> func_7;

			// Token: 0x040020C6 RID: 8390
			public static Func<Class720, bool> func_8;

			// Token: 0x040020C7 RID: 8391
			public static Func<Task> func_9;

			// Token: 0x040020C8 RID: 8392
			public static Action action_4;

			// Token: 0x040020C9 RID: 8393
			public static Func<Page, bool> func_10;

			// Token: 0x040020CA RID: 8394
			public static Func<KeyValuePair<string, Action>, bool> func_11;

			// Token: 0x040020CB RID: 8395
			public static Func<Task> func_12;

			// Token: 0x0200082A RID: 2090
			[StructLayout(LayoutKind.Auto)]
			private struct Struct586 : IAsyncStateMachine
			{
				// Token: 0x06002AA8 RID: 10920 RVA: 0x000B8350 File Offset: 0x000B6550
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					try
					{
						TaskAwaiter awaiter;
						switch (num)
						{
						case 0:
							break;
						case 1:
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num2 = -1;
							num = -1;
							this.int_0 = num2;
							goto IL_337;
						}
						case 2:
							goto Block_34;
						default:
						{
							this.class855_0 = new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class855();
							if (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_6)
							{
								Application.Current.Dispatcher.Invoke(new Action(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_15));
							}
							Class185.smethod_22("taskkill /F /FI \"IMAGENAME eq SystemSettings.exe\"");
							bool? flag = Class389.class504_0.method_46();
							if (flag.GetValueOrDefault() & flag != null)
							{
								goto IL_120;
							}
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_13("CreatingBackUp", (GEnum93)1);
							break;
						}
						}
						try
						{
							if (num != 0)
							{
								awaiter = Class762.smethod_0(Class364.smethod_0("BeforeOptimization")).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.int_0 = num3;
									this.taskAwaiter_0 = awaiter;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.Struct586>(ref awaiter, ref this);
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
						}
						catch (object obj)
						{
						}
						Class389.class504_0.method_47(new bool?(true));
						IL_120:
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_13("StartOptim", (GEnum93)1);
						Dictionary<Type, Dictionary<string, GClass93.GStruct4>> dictionary = GClass93.smethod_0().method_19();
						Dictionary<string, GClass93.GStruct4> dictionary2 = new Dictionary<string, GClass93.GStruct4>();
						this.bool_0 = (dictionary.TryGetValue(typeof(Class525), out dictionary2) && (dictionary2.ContainsKey(Class364.smethod_0("setsvisuals")) || dictionary2.ContainsKey(Class364.smethod_0("ShowAllIconsInTaskBar")) || dictionary2.ContainsKey(Class364.smethod_0("OldBatteryFlyout")) || dictionary2.ContainsKey(Class364.smethod_0("OldContextMenu")) || dictionary2.ContainsKey(Class364.smethod_0("ContextMenuDelay")) || dictionary2.ContainsKey(Class364.smethod_0("ContextMenuDelay")) || dictionary2.ContainsKey(Class364.smethod_0("W11Widgets"))));
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gclass106_0.imethod_3();
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gclass106_0.method_0();
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gclass27_0.imethod_3<GClass133>(GClass133.string_2);
						this.class855_0.semaphoreSlim_0 = new SemaphoreSlim(1);
						List<Task> list = new List<Task>();
						Dictionary<Type, Dictionary<string, GClass93.GStruct4>>.Enumerator enumerator = dictionary.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair = enumerator.Current;
								Dictionary<string, GClass93.GStruct4>.Enumerator enumerator2 = keyValuePair.Value.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										KeyValuePair<string, GClass93.GStruct4> keyValuePair_ = enumerator2.Current;
										list.Add(Task.Run(new Func<Task>(new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class858
										{
											class855_0 = this.class855_0,
											keyValuePair_0 = keyValuePair_
										}.method_0)));
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						awaiter = Task.WhenAll(list).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.int_0 = num5;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.Struct586>(ref awaiter, ref this);
							return;
						}
						IL_337:
						awaiter.GetResult();
						this.class855_0.page_0 = Class358.smethod_0().list_2.FirstOrDefault(new Func<Page, bool>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_16));
						if (this.class855_0.page_0 != null && this.class855_0.page_0 != null)
						{
							Application.Current.Dispatcher.Invoke(new Action(this.class855_0.method_0));
						}
						GClass93.smethod_0().method_20();
						string text = Class186.string_4 + "\\UninstallBat.bat";
						if (File.Exists(text))
						{
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_13("CleaningTrash", (GEnum93)1);
							try
							{
								GClass104.smethod_0("cmd.exe /c " + text, false);
							}
							catch (object obj2)
							{
							}
							try
							{
								File.Delete(text);
							}
							catch (object obj3)
							{
							}
						}
						string text2 = Class186.string_4 + "\\UninstallBat2.bat";
						if (File.Exists(text2))
						{
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_13("CleaningTrash", (GEnum93)1);
							try
							{
								GClass104.smethod_0("cmd.exe /c " + text2, false);
							}
							catch (object obj4)
							{
							}
							try
							{
								File.Delete(text2);
							}
							catch (object obj5)
							{
							}
						}
						if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_3.Count > 0)
						{
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_3.Sort();
							if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
							{
								Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
							}
							if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BoosterX"))
							{
								Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BoosterX");
							}
							List<string>.Enumerator enumerator3 = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_3.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									string string_ = enumerator3.Current;
									Class650.smethod_16(Class186.string_4 + "\\services.bat", string_, null);
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator3).Dispose();
								}
							}
							try
							{
								GClass104.smethod_0("cmd.exe /c \"" + Class186.string_4 + "\\services.bat\"", false);
							}
							catch
							{
								Class185.smethod_22("\"" + Class186.string_4 + "\\services.bat\"");
							}
							try
							{
								Class185.smethod_22("del /f \"" + Class186.string_4 + "\\services.bat\"");
							}
							catch (object obj6)
							{
							}
						}
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_3.Clear();
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.gclass106_0.method_2();
						if (Class178.dictionary_0 != null && Class178.dictionary_0.Count > 0)
						{
							try
							{
								bool flag2 = false;
								if (Class178.dictionary_0.Any(new Func<KeyValuePair<string, Action>, bool>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_17)))
								{
									flag2 = true;
									Class468.smethod_0().method_2();
									Class468.smethod_0().method_14();
								}
								Dictionary<string, Action>.Enumerator enumerator4 = Class178.dictionary_0.GetEnumerator();
								try
								{
									while (enumerator4.MoveNext())
									{
										KeyValuePair<string, Action> keyValuePair2 = enumerator4.Current;
										dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_13(keyValuePair2.Key, (GEnum93)1);
										keyValuePair2.Value();
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator4).Dispose();
									}
								}
								if (flag2)
								{
									Class468.smethod_0().method_16();
								}
								Class178.dictionary_0.Clear();
							}
							catch (object obj7)
							{
							}
						}
						Block_34:
						try
						{
							if (num != 2)
							{
								if (!this.bool_0)
								{
									goto IL_72C;
								}
								dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_13("ExplorerReset", (GEnum93)1);
								Class185.smethod_22("taskkill /f /im explorer.exe");
								awaiter = Task.Delay(1000).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num6 = 2;
									num = 2;
									this.int_0 = num6;
									this.taskAwaiter_0 = awaiter;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.Struct586>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.taskAwaiter_0;
								this.taskAwaiter_0 = default(TaskAwaiter);
								int num7 = -1;
								num = -1;
								this.int_0 = num7;
							}
							awaiter.GetResult();
							Class185.smethod_22("start explorer.exe");
							IL_72C:;
						}
						catch (object obj8)
						{
						}
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.string_0 = "FINISHED";
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.class855_0 = null;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.class855_0 = null;
					this.asyncTaskMethodBuilder_0.SetResult();
				}

				// Token: 0x06002AA9 RID: 10921 RVA: 0x000B8C38 File Offset: 0x000B6E38
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x040020CC RID: 8396
				public int int_0;

				// Token: 0x040020CD RID: 8397
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x040020CE RID: 8398
				private dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class855 class855_0;

				// Token: 0x040020CF RID: 8399
				private bool bool_0;

				// Token: 0x040020D0 RID: 8400
				private TaskAwaiter taskAwaiter_0;
			}

			// Token: 0x0200082B RID: 2091
			[StructLayout(LayoutKind.Auto)]
			private struct Struct587 : IAsyncStateMachine
			{
				// Token: 0x06002AAA RID: 10922 RVA: 0x000B8C48 File Offset: 0x000B6E48
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					try
					{
						TaskAwaiter<List<Class745>> awaiter;
						TaskAwaiter awaiter2;
						switch (num)
						{
						case 0:
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<List<Class745>>);
							int num2 = -1;
							num = -1;
							this.int_0 = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.int_0 = num3;
							goto IL_16C;
						}
						case 2:
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.int_0 = num4;
							goto IL_34C;
						}
						case 3:
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
							goto IL_4F3;
						}
						default:
							awaiter = Class588.smethod_9().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num6 = 0;
								num = 0;
								this.int_0 = num6;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class745>>, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.Struct587>(ref awaiter, ref this);
								return;
							}
							break;
						}
						List<Class745>.Enumerator enumerator = awaiter.GetResult().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Class745 @class = enumerator.Current;
								if (@class.LevelCount && !@class.IsExp && @class.IsSupported)
								{
									dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_1 += @class.Level;
									if (@class.CurrentValueType == "BEST")
									{
										dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += @class.Level;
									}
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_1 += 5;
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += 5;
						this.class730_0 = Class462.smethod_0(false);
						awaiter2 = Class462.smethod_4().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num7 = 1;
							num = 1;
							this.int_0 = num7;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.Struct587>(ref awaiter2, ref this);
							return;
						}
						IL_16C:
						awaiter2.GetResult();
						List<string>.Enumerator enumerator2 = Class605.list_10.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class860 class2 = new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class860();
								class2.string_0 = enumerator2.Current;
								dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_1 += 2;
								if (!this.class730_0.WinUwpAppsModels.Any(new Func<Class713, bool>(class2.method_0)))
								{
									dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += 2;
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator2).Dispose();
							}
						}
						IEnumerator<Class745> enumerator3 = this.class730_0.CustomDebloatList.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								Class745 class3 = enumerator3.Current;
								if (class3.LevelCount)
								{
									dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_1 += class3.Level;
									if (class3.CurrentValueType == "BEST")
									{
										dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += class3.Level;
									}
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator3 != null)
							{
								enumerator3.Dispose();
							}
						}
						List<Class188>.Enumerator enumerator4 = Class576.smethod_0().GetEnumerator();
						try
						{
							while (enumerator4.MoveNext())
							{
								Class188 class4 = enumerator4.Current;
								if (Class268.dictionary_0.ContainsKey(class4.Name))
								{
									int num8;
									Class268.dictionary_0.TryGetValue(class4.Name, out num8);
									dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_1 += num8;
									if (class4.State == "4")
									{
										dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += num8;
									}
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator4).Dispose();
							}
						}
						this.gclass223_0 = GClass161.smethod_0(false);
						awaiter2 = GClass161.smethod_5().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num9 = 2;
							num = 2;
							this.int_0 = num9;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.Struct587>(ref awaiter2, ref this);
							return;
						}
						IL_34C:
						awaiter2.GetResult();
						IEnumerator<GClass221> enumerator5 = this.gclass223_0.MsiSupportedDevices.GetEnumerator();
						try
						{
							while (enumerator5.MoveNext())
							{
								GClass221 gclass = enumerator5.Current;
								dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_1++;
								bool? flag = gclass.MsiCurrentStatus;
								if (!flag.GetValueOrDefault() & flag != null)
								{
									dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2++;
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator5 != null)
							{
								enumerator5.Dispose();
							}
						}
						enumerator5 = this.gclass223_0.CanBeDisabled.GetEnumerator();
						try
						{
							while (enumerator5.MoveNext())
							{
								GClass221 gclass2 = enumerator5.Current;
								dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_1++;
								bool? flag = gclass2.CurrentStatus;
								if (!flag.GetValueOrDefault() & flag != null)
								{
									dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2++;
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator5 != null)
							{
								enumerator5.Dispose();
							}
						}
						IEnumerator<GClass226> enumerator6 = this.gclass223_0.CustomDisableDevices.GetEnumerator();
						try
						{
							while (enumerator6.MoveNext())
							{
								GClass226 gclass3 = enumerator6.Current;
								dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_1++;
								bool? flag = gclass3.CurrentIsDisabled;
								if (flag.GetValueOrDefault() & flag != null)
								{
									dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2++;
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator6 != null)
							{
								enumerator6.Dispose();
							}
						}
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_1 += 20;
						this.class161_0 = Class150.smethod_0(false);
						awaiter2 = Class150.smethod_5().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num10 = 3;
							num = 3;
							this.int_0 = num10;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.Struct587>(ref awaiter2, ref this);
							return;
						}
						IL_4F3:
						awaiter2.GetResult();
						if (this.class161_0.FileARModels.Count > 0)
						{
							if (this.class161_0.FileARModels.Where(new Func<Class720, bool>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_6)).All(new Func<Class720, bool>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_7)))
							{
								dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += 5;
							}
						}
						else
						{
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += 5;
						}
						if (this.class161_0.RegARModels.Count > 0)
						{
							if (this.class161_0.RegARModels.Where(new Func<Class720, bool>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_8)).All(new Func<Class720, bool>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_9)))
							{
								dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += 5;
							}
						}
						else
						{
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += 5;
						}
						if (this.class161_0.TaskARModels.Count > 0)
						{
							if (this.class161_0.TaskARModels.Where(new Func<Class720, bool>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_10)).All(new Func<Class720, bool>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_11)))
							{
								dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += 5;
							}
						}
						else
						{
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += 5;
						}
						if (this.class161_0.ServiceARModels.Count > 0)
						{
							if (this.class161_0.ServiceARModels.Where(new Func<Class720, bool>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_12)).All(new Func<Class720, bool>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_13)))
							{
								dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += 5;
							}
						}
						else
						{
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_2 += 5;
						}
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.class730_0 = null;
						this.gclass223_0 = null;
						this.class161_0 = null;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.class730_0 = null;
					this.gclass223_0 = null;
					this.class161_0 = null;
					this.asyncTaskMethodBuilder_0.SetResult();
				}

				// Token: 0x06002AAB RID: 10923 RVA: 0x000B9474 File Offset: 0x000B7674
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x040020D1 RID: 8401
				public int int_0;

				// Token: 0x040020D2 RID: 8402
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x040020D3 RID: 8403
				private Class730 class730_0;

				// Token: 0x040020D4 RID: 8404
				private GClass161.GClass223 gclass223_0;

				// Token: 0x040020D5 RID: 8405
				private Class150.Class161 class161_0;

				// Token: 0x040020D6 RID: 8406
				private TaskAwaiter<List<Class745>> taskAwaiter_0;

				// Token: 0x040020D7 RID: 8407
				private TaskAwaiter taskAwaiter_1;
			}
		}

		// Token: 0x0200082C RID: 2092
		private sealed class Class858
		{
			// Token: 0x06002AAD RID: 10925 RVA: 0x000B948C File Offset: 0x000B768C
			internal Task method_0()
			{
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class858.Struct588 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class858_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class858.Struct588>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x040020D8 RID: 8408
			public KeyValuePair<string, GClass93.GStruct4> keyValuePair_0;

			// Token: 0x040020D9 RID: 8409
			public dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class855 class855_0;

			// Token: 0x0200082D RID: 2093
			[StructLayout(LayoutKind.Auto)]
			private struct Struct588 : IAsyncStateMachine
			{
				// Token: 0x06002AAE RID: 10926 RVA: 0x000B94D0 File Offset: 0x000B76D0
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class858 @class = this.class858_0;
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_85;
							}
							awaiter = @class.class855_0.semaphoreSlim_0.WaitAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class858.Struct588>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num2 = -1;
							num = -1;
							this.int_0 = num2;
						}
						awaiter.GetResult();
						try
						{
							IL_85:
							if (num != 1)
							{
								this.class861_0 = new dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class861();
								this.class861_0.object_0 = @class.keyValuePair_0.Value.method_2();
								this.class861_0.ginterface15_0 = @class.keyValuePair_0.Value.method_0();
								GInterface15 ginterface15_ = this.class861_0.ginterface15_0;
								Action<string, GEnum93> action_;
								if ((action_ = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class856.action_0) == null)
								{
									action_ = (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class856.action_0 = new Action<string, GEnum93>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_13));
								}
								ginterface15_.imethod_2(action_);
								awaiter = Task.Run(new Action(this.class861_0.method_0)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 1;
									this.taskAwaiter_0 = awaiter;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class858.Struct588>(ref awaiter, ref this);
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
							this.class861_0.ginterface15_0.imethod_2(null);
							this.class861_0 = null;
						}
						catch (object obj)
						{
						}
						@class.class855_0.semaphoreSlim_0.Release();
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

				// Token: 0x06002AAF RID: 10927 RVA: 0x000B96EC File Offset: 0x000B78EC
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x040020DA RID: 8410
				public int int_0;

				// Token: 0x040020DB RID: 8411
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x040020DC RID: 8412
				public dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class858 class858_0;

				// Token: 0x040020DD RID: 8413
				private dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class861 class861_0;

				// Token: 0x040020DE RID: 8414
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x0200082E RID: 2094
		private sealed class Class859
		{
			// Token: 0x06002AB1 RID: 10929 RVA: 0x000B9704 File Offset: 0x000B7904
			internal void method_0()
			{
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.observableCollection_0[this.int_0].IsFinished = true;
			}

			// Token: 0x040020DF RID: 8415
			public int int_0;
		}

		// Token: 0x0200082F RID: 2095
		[StructLayout(LayoutKind.Auto)]
		private struct Struct589 : IAsyncStateMachine
		{
			// Token: 0x06002AB2 RID: 10930 RVA: 0x000B971C File Offset: 0x000B791C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_4.Remove(this.string_0);
						awaiter = Task.Delay(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct589>(ref awaiter, ref this);
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

			// Token: 0x06002AB3 RID: 10931 RVA: 0x000B97D8 File Offset: 0x000B79D8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020E0 RID: 8416
			public int int_0;

			// Token: 0x040020E1 RID: 8417
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020E2 RID: 8418
			public string string_0;

			// Token: 0x040020E3 RID: 8419
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000830 RID: 2096
		[StructLayout(LayoutKind.Auto)]
		private struct Struct590 : IAsyncStateMachine
		{
			// Token: 0x06002AB4 RID: 10932 RVA: 0x000B97E8 File Offset: 0x000B79E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_4.Contains(this.string_0))
						{
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_4.Add(this.string_0);
						}
						awaiter = Task.Delay(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct590>(ref awaiter, ref this);
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

			// Token: 0x06002AB5 RID: 10933 RVA: 0x000B98B8 File Offset: 0x000B7AB8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020E4 RID: 8420
			public int int_0;

			// Token: 0x040020E5 RID: 8421
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020E6 RID: 8422
			public string string_0;

			// Token: 0x040020E7 RID: 8423
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000831 RID: 2097
		private sealed class Class860
		{
			// Token: 0x06002AB7 RID: 10935 RVA: 0x000B98D0 File Offset: 0x000B7AD0
			internal bool method_0(Class713 class713_0)
			{
				return class713_0.AppxFullName.ToLower().StartsWith(this.string_0.ToLower());
			}

			// Token: 0x040020E8 RID: 8424
			public string string_0;
		}

		// Token: 0x02000832 RID: 2098
		private sealed class Class861
		{
			// Token: 0x06002AB9 RID: 10937 RVA: 0x000B98F8 File Offset: 0x000B7AF8
			internal void method_0()
			{
				GClass128<object> gclass = this.ginterface15_0 as GClass128<object>;
				if (gclass == null)
				{
					return;
				}
				gclass.imethod_3(this.object_0);
			}

			// Token: 0x040020E9 RID: 8425
			public GInterface15 ginterface15_0;

			// Token: 0x040020EA RID: 8426
			public object object_0;
		}

		// Token: 0x02000833 RID: 2099
		[StructLayout(LayoutKind.Auto)]
		private struct Struct591 : IAsyncStateMachine
		{
			// Token: 0x06002ABA RID: 10938 RVA: 0x000B9918 File Offset: 0x000B7B18
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct591>(ref awaiter, ref this);
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

			// Token: 0x06002ABB RID: 10939 RVA: 0x000B99E4 File Offset: 0x000B7BE4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020EB RID: 8427
			public int int_0;

			// Token: 0x040020EC RID: 8428
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020ED RID: 8429
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000834 RID: 2100
		// (Invoke) Token: 0x06002ABD RID: 10941
		public delegate void GDelegate44();

		// Token: 0x02000835 RID: 2101
		[StructLayout(LayoutKind.Auto)]
		private struct Struct592 : IAsyncStateMachine
		{
			// Token: 0x06002AC0 RID: 10944 RVA: 0x000B99F4 File Offset: 0x000B7BF4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Func<Task>(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Class857.class857_0.method_14)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct592>(ref awaiter, ref this);
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

			// Token: 0x06002AC1 RID: 10945 RVA: 0x000B9AC0 File Offset: 0x000B7CC0
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020EE RID: 8430
			public int int_0;

			// Token: 0x040020EF RID: 8431
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020F0 RID: 8432
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000836 RID: 2102
		[StructLayout(LayoutKind.Auto)]
		private struct Struct593 : IAsyncStateMachine
		{
			// Token: 0x06002AC2 RID: 10946 RVA: 0x000B9AD0 File Offset: 0x000B7CD0
			void IAsyncStateMachine.MoveNext()
			{
				object[] array = new object[]
				{
					this
				};
				Class27 @class = Class555.smethod_0();
				Stream stream_ = Class555.smethod_2();
				try
				{
					@class.method_4(stream_, "&ebiH()I#d", array);
				}
				finally
				{
					this = (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct593)array[0];
				}
			}

			// Token: 0x06002AC3 RID: 10947 RVA: 0x000B9B38 File Offset: 0x000B7D38
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x06002AC4 RID: 10948 RVA: 0x000B9B48 File Offset: 0x000B7D48
			private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct593 struct593_0)
			{
				struct593_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.Struct593>(ref taskAwaiter_1, ref struct593_0);
			}

			// Token: 0x040020F1 RID: 8433
			public int int_0;

			// Token: 0x040020F2 RID: 8434
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020F3 RID: 8435
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
