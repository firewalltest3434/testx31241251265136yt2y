using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x02000168 RID: 360
internal sealed class Class193
{
	// Token: 0x06000970 RID: 2416 RVA: 0x0002B6DC File Offset: 0x000298DC
	// Note: this type is marked as 'beforefieldinit'.
	static Class193()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebh9()LEp", null);
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x0002B6F4 File Offset: 0x000298F4
	public static Task smethod_0()
	{
		return (Task)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebfk()PR;", null);
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x0002B710 File Offset: 0x00029910
	public static void smethod_1()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebi@()L^#", null);
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x0002B728 File Offset: 0x00029928
	private static void smethod_2(ref Class193.Struct68 struct68_0)
	{
		struct68_0.asyncTaskMethodBuilder_0.Start<Class193.Struct68>(ref struct68_0);
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x0002B738 File Offset: 0x00029938
	private static void smethod_3(ref Class193.Struct69 struct69_0)
	{
		struct69_0.asyncVoidMethodBuilder_0.Start<Class193.Struct69>(ref struct69_0);
	}

	// Token: 0x04000567 RID: 1383
	private static Uri uri_0;

	// Token: 0x04000568 RID: 1384
	public static Uri uri_1;

	// Token: 0x04000569 RID: 1385
	public static Uri uri_2;

	// Token: 0x0400056A RID: 1386
	public static Uri uri_3;

	// Token: 0x0400056B RID: 1387
	public static Uri uri_4;

	// Token: 0x0400056C RID: 1388
	public static Uri uri_5;

	// Token: 0x0400056D RID: 1389
	public static Uri uri_6;

	// Token: 0x0400056E RID: 1390
	public static Uri uri_7;

	// Token: 0x0400056F RID: 1391
	public static Uri uri_8;

	// Token: 0x04000570 RID: 1392
	public static Uri uri_9;

	// Token: 0x04000571 RID: 1393
	public static Uri uri_10;

	// Token: 0x04000572 RID: 1394
	public static Uri uri_11;

	// Token: 0x04000573 RID: 1395
	public static Uri uri_12;

	// Token: 0x04000574 RID: 1396
	public static Uri uri_13;

	// Token: 0x04000575 RID: 1397
	public static Uri uri_14;

	// Token: 0x04000576 RID: 1398
	public static Uri uri_15;

	// Token: 0x04000577 RID: 1399
	public static Uri uri_16;

	// Token: 0x04000578 RID: 1400
	public static Uri uri_17;

	// Token: 0x04000579 RID: 1401
	public static Uri uri_18;

	// Token: 0x0400057A RID: 1402
	public static bool bool_0;

	// Token: 0x0400057B RID: 1403
	private static string string_0;

	// Token: 0x02000169 RID: 361
	[StructLayout(LayoutKind.Auto)]
	private struct Struct68 : IAsyncStateMachine
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x0002B748 File Offset: 0x00029948
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
				@class.method_4(stream_, "&ebg2()P=4", array);
			}
			finally
			{
				this = (Class193.Struct68)array[0];
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0002B7B0 File Offset: 0x000299B0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0002B7C0 File Offset: 0x000299C0
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class193.Struct68 struct68_0)
		{
			struct68_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class193.Struct68>(ref taskAwaiter_1, ref struct68_0);
		}

		// Token: 0x0400057C RID: 1404
		public int int_0;

		// Token: 0x0400057D RID: 1405
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400057E RID: 1406
		private int int_1;

		// Token: 0x0400057F RID: 1407
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200016A RID: 362
	[Serializable]
	private sealed class Class194
	{
		// Token: 0x0600097A RID: 2426 RVA: 0x0002B7E4 File Offset: 0x000299E4
		internal void method_0()
		{
			try
			{
				using (new WebClient
				{
					Proxy = null
				}.OpenRead("https://api.boosterx.org/_health"))
				{
					Class193.string_0 = "Good";
				}
			}
			catch (object obj)
			{
			}
		}

		// Token: 0x04000580 RID: 1408
		public static readonly Class193.Class194 class194_0 = new Class193.Class194();

		// Token: 0x04000581 RID: 1409
		public static Action action_0;
	}

	// Token: 0x0200016B RID: 363
	[StructLayout(LayoutKind.Auto)]
	private struct Struct69 : IAsyncStateMachine
	{
		// Token: 0x0600097B RID: 2427 RVA: 0x0002B840 File Offset: 0x00029A40
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
				@class.method_4(stream_, "&ebfb()O\"d", array);
			}
			finally
			{
				this = (Class193.Struct69)array[0];
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0002B8A8 File Offset: 0x00029AA8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0002B8B8 File Offset: 0x00029AB8
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class193.Struct69 struct69_0)
		{
			struct69_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class193.Struct69>(ref taskAwaiter_1, ref struct69_0);
		}

		// Token: 0x04000582 RID: 1410
		public int int_0;

		// Token: 0x04000583 RID: 1411
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000584 RID: 1412
		private TaskAwaiter taskAwaiter_0;
	}
}
