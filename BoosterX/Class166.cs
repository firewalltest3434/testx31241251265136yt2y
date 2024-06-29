using System;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x0200012E RID: 302
internal sealed class Class166
{
	// Token: 0x060007EA RID: 2026 RVA: 0x00026844 File Offset: 0x00024A44
	static Class166()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebhL()PgB", null);
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x00026864 File Offset: 0x00024A64
	public static Task<bool> smethod_0()
	{
		return (Task<bool>)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebfW()JG7", null);
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x00026880 File Offset: 0x00024A80
	public static Task<Class289> smethod_1(Uri uri_0, object object_0)
	{
		object[] object_ = new object[]
		{
			uri_0,
			object_0
		};
		return (Task<Class289>)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebg$()KIT", object_);
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x000268B8 File Offset: 0x00024AB8
	private static void smethod_2(ref Class166.Struct57 struct57_0)
	{
		struct57_0.asyncTaskMethodBuilder_0.Start<Class166.Struct57>(ref struct57_0);
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x000268C8 File Offset: 0x00024AC8
	private static void smethod_3(ref Class166.Struct58 struct58_0)
	{
		struct58_0.asyncTaskMethodBuilder_0.Start<Class166.Struct58>(ref struct58_0);
	}

	// Token: 0x0400044B RID: 1099
	public static string string_0;

	// Token: 0x0400044C RID: 1100
	public static string string_1;

	// Token: 0x0400044D RID: 1101
	public static bool bool_0;

	// Token: 0x0400044E RID: 1102
	private static bool bool_1;

	// Token: 0x0400044F RID: 1103
	public static string string_2;

	// Token: 0x04000450 RID: 1104
	private static readonly SemaphoreSlim semaphoreSlim_0;

	// Token: 0x04000451 RID: 1105
	private static readonly HttpClient httpClient_0;

	// Token: 0x0200012F RID: 303
	[StructLayout(LayoutKind.Auto)]
	private struct Struct57 : IAsyncStateMachine
	{
		// Token: 0x060007F0 RID: 2032 RVA: 0x000268D8 File Offset: 0x00024AD8
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
				@class.method_4(stream_, "&ebhO()L9k", array);
			}
			finally
			{
				this = (Class166.Struct57)array[0];
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00026940 File Offset: 0x00024B40
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00026950 File Offset: 0x00024B50
		private static void MoveNext(ref TaskAwaiter taskAwaiter_2, ref Class166.Struct57 struct57_0)
		{
			struct57_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class166.Struct57>(ref taskAwaiter_2, ref struct57_0);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00026960 File Offset: 0x00024B60
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_2, ref Class166.Struct57 struct57_0)
		{
			struct57_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class166.Struct57>(ref taskAwaiter_2, ref struct57_0);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00026970 File Offset: 0x00024B70
		private static void MoveNext_2(ref TaskAwaiter<string> taskAwaiter_2, ref Class166.Struct57 struct57_0)
		{
			struct57_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class166.Struct57>(ref taskAwaiter_2, ref struct57_0);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00026980 File Offset: 0x00024B80
		private static void MoveNext_3(ref ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter configuredTaskAwaiter_2, ref Class166.Struct57 struct57_0)
		{
			struct57_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, Class166.Struct57>(ref configuredTaskAwaiter_2, ref struct57_0);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00026990 File Offset: 0x00024B90
		private static void MoveNext_4(ref ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter configuredTaskAwaiter_2, ref Class166.Struct57 struct57_0)
		{
			struct57_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, Class166.Struct57>(ref configuredTaskAwaiter_2, ref struct57_0);
		}

		// Token: 0x04000452 RID: 1106
		public int int_0;

		// Token: 0x04000453 RID: 1107
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x04000454 RID: 1108
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04000455 RID: 1109
		private TaskAwaiter<string> taskAwaiter_1;

		// Token: 0x04000456 RID: 1110
		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		// Token: 0x04000457 RID: 1111
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter configuredTaskAwaiter_1;
	}

	// Token: 0x02000130 RID: 304
	[StructLayout(LayoutKind.Auto)]
	private struct Struct58 : IAsyncStateMachine
	{
		// Token: 0x060007F7 RID: 2039 RVA: 0x000269A0 File Offset: 0x00024BA0
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
				@class.method_4(stream_, "&ebh<()K4M", array);
			}
			finally
			{
				this = (Class166.Struct58)array[0];
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00026A08 File Offset: 0x00024C08
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00026A18 File Offset: 0x00024C18
		private static void MoveNext(ref TaskAwaiter<bool> taskAwaiter_1, ref Class166.Struct58 struct58_0)
		{
			struct58_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class166.Struct58>(ref taskAwaiter_1, ref struct58_0);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00026A28 File Offset: 0x00024C28
		private static void MoveNext_1(ref ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter configuredTaskAwaiter_2, ref Class166.Struct58 struct58_0)
		{
			struct58_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, Class166.Struct58>(ref configuredTaskAwaiter_2, ref struct58_0);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00026A38 File Offset: 0x00024C38
		private static void MoveNext_2(ref ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter configuredTaskAwaiter_2, ref Class166.Struct58 struct58_0)
		{
			struct58_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, Class166.Struct58>(ref configuredTaskAwaiter_2, ref struct58_0);
		}

		// Token: 0x04000458 RID: 1112
		public int int_0;

		// Token: 0x04000459 RID: 1113
		public AsyncTaskMethodBuilder<Class289> asyncTaskMethodBuilder_0;

		// Token: 0x0400045A RID: 1114
		public object object_0;

		// Token: 0x0400045B RID: 1115
		public Uri uri_0;

		// Token: 0x0400045C RID: 1116
		private TaskAwaiter<bool> taskAwaiter_0;

		// Token: 0x0400045D RID: 1117
		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		// Token: 0x0400045E RID: 1118
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter configuredTaskAwaiter_1;
	}
}
