using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;
using Newtonsoft.Json;

// Token: 0x020004EA RID: 1258
internal sealed class Class585
{
	// Token: 0x06001BD8 RID: 7128 RVA: 0x00071C0C File Offset: 0x0006FE0C
	// Note: this type is marked as 'beforefieldinit'.
	static Class585()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebg*()M`@", null);
	}

	// Token: 0x06001BD9 RID: 7129 RVA: 0x00071C24 File Offset: 0x0006FE24
	public static void smethod_0(Class585.Delegate28 delegate28_1)
	{
		Class585.Delegate28 @delegate = Class585.delegate28_0;
		Class585.Delegate28 delegate2;
		do
		{
			delegate2 = @delegate;
			Class585.Delegate28 value = (Class585.Delegate28)Delegate.Combine(delegate2, delegate28_1);
			@delegate = Interlocked.CompareExchange<Class585.Delegate28>(ref Class585.delegate28_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001BDA RID: 7130 RVA: 0x00071C58 File Offset: 0x0006FE58
	public static void smethod_1(Class585.Delegate28 delegate28_1)
	{
		Class585.Delegate28 @delegate = Class585.delegate28_0;
		Class585.Delegate28 delegate2;
		do
		{
			delegate2 = @delegate;
			Class585.Delegate28 value = (Class585.Delegate28)Delegate.Remove(delegate2, delegate28_1);
			@delegate = Interlocked.CompareExchange<Class585.Delegate28>(ref Class585.delegate28_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001BDB RID: 7131 RVA: 0x00071C8C File Offset: 0x0006FE8C
	public static void smethod_2(Class585.Delegate29 delegate29_1)
	{
		Class585.Delegate29 @delegate = Class585.delegate29_0;
		Class585.Delegate29 delegate2;
		do
		{
			delegate2 = @delegate;
			Class585.Delegate29 value = (Class585.Delegate29)Delegate.Combine(delegate2, delegate29_1);
			@delegate = Interlocked.CompareExchange<Class585.Delegate29>(ref Class585.delegate29_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001BDC RID: 7132 RVA: 0x00071CC0 File Offset: 0x0006FEC0
	public static void smethod_3(Class585.Delegate29 delegate29_1)
	{
		Class585.Delegate29 @delegate = Class585.delegate29_0;
		Class585.Delegate29 delegate2;
		do
		{
			delegate2 = @delegate;
			Class585.Delegate29 value = (Class585.Delegate29)Delegate.Remove(delegate2, delegate29_1);
			@delegate = Interlocked.CompareExchange<Class585.Delegate29>(ref Class585.delegate29_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x00071CF4 File Offset: 0x0006FEF4
	public static void smethod_4()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebg`()MN:", null);
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x00071D0C File Offset: 0x0006FF0C
	public static void smethod_5()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebi1()McA", null);
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x00071D24 File Offset: 0x0006FF24
	public static Task<Class289> smethod_6(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (Task<Class289>)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebhE()J//", object_);
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x00071D58 File Offset: 0x0006FF58
	public static void smethod_7()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebi>()J>4", null);
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x00071D70 File Offset: 0x0006FF70
	private static void smethod_8(ref Class585.Struct275 struct275_0)
	{
		struct275_0.asyncVoidMethodBuilder_0.Start<Class585.Struct275>(ref struct275_0);
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x00071D80 File Offset: 0x0006FF80
	private static void smethod_9(ref Class585.Struct276 struct276_0)
	{
		struct276_0.asyncVoidMethodBuilder_0.Start<Class585.Struct276>(ref struct276_0);
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x00071D90 File Offset: 0x0006FF90
	private static void smethod_10(ref Class585.Struct277 struct277_0)
	{
		struct277_0.asyncTaskMethodBuilder_0.Start<Class585.Struct277>(ref struct277_0);
	}

	// Token: 0x0400136C RID: 4972
	public static Struct13 struct13_0;

	// Token: 0x0400136D RID: 4973
	public static Struct1 struct1_0;

	// Token: 0x0400136E RID: 4974
	public static Struct1 struct1_1;

	// Token: 0x0400136F RID: 4975
	public static TimeSpan timeSpan_0;

	// Token: 0x04001370 RID: 4976
	private static Class585.Delegate28 delegate28_0;

	// Token: 0x04001371 RID: 4977
	private static Class585.Delegate29 delegate29_0;

	// Token: 0x04001372 RID: 4978
	public static bool bool_0;

	// Token: 0x020004EB RID: 1259
	// (Invoke) Token: 0x06001BE5 RID: 7141
	public delegate void Delegate28();

	// Token: 0x020004EC RID: 1260
	[StructLayout(LayoutKind.Auto)]
	private struct Struct275 : IAsyncStateMachine
	{
		// Token: 0x06001BE8 RID: 7144 RVA: 0x00071DA0 File Offset: 0x0006FFA0
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
				@class.method_4(stream_, "&ebh-()MrF", array);
			}
			finally
			{
				this = (Class585.Struct275)array[0];
			}
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00071E08 File Offset: 0x00070008
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00071E18 File Offset: 0x00070018
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class585.Struct275 struct275_0)
		{
			struct275_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class585.Struct275>(ref taskAwaiter_1, ref struct275_0);
		}

		// Token: 0x04001373 RID: 4979
		public int int_0;

		// Token: 0x04001374 RID: 4980
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001375 RID: 4981
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004ED RID: 1261
	[StructLayout(LayoutKind.Auto)]
	private struct Struct276 : IAsyncStateMachine
	{
		// Token: 0x06001BEB RID: 7147 RVA: 0x00071E28 File Offset: 0x00070028
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
				@class.method_4(stream_, "&ebfW()J;3", array);
			}
			finally
			{
				this = (Class585.Struct276)array[0];
			}
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00071E90 File Offset: 0x00070090
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00071EA0 File Offset: 0x000700A0
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class585.Struct276 struct276_0)
		{
			struct276_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class585.Struct276>(ref taskAwaiter_1, ref struct276_0);
		}

		// Token: 0x04001376 RID: 4982
		public int int_0;

		// Token: 0x04001377 RID: 4983
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001378 RID: 4984
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004EE RID: 1262
	[StructLayout(LayoutKind.Auto)]
	private struct Struct277 : IAsyncStateMachine
	{
		// Token: 0x06001BEE RID: 7150 RVA: 0x00071EB0 File Offset: 0x000700B0
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
				@class.method_4(stream_, "&ebft()JP:", array);
			}
			finally
			{
				this = (Class585.Struct277)array[0];
			}
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00071F18 File Offset: 0x00070118
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00071F28 File Offset: 0x00070128
		private static void MoveNext(ref TaskAwaiter<Class289> taskAwaiter_1, ref Class585.Struct277 struct277_0)
		{
			struct277_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class585.Struct277>(ref taskAwaiter_1, ref struct277_0);
		}

		// Token: 0x04001379 RID: 4985
		public int int_0;

		// Token: 0x0400137A RID: 4986
		public AsyncTaskMethodBuilder<Class289> asyncTaskMethodBuilder_0;

		// Token: 0x0400137B RID: 4987
		public string string_0;

		// Token: 0x0400137C RID: 4988
		private TaskAwaiter<Class289> taskAwaiter_0;
	}

	// Token: 0x020004EF RID: 1263
	// (Invoke) Token: 0x06001BF2 RID: 7154
	public delegate void Delegate29();

	// Token: 0x020004F0 RID: 1264
	[Serializable]
	private sealed class Class586
	{
		// Token: 0x06001BF7 RID: 7159 RVA: 0x00071F4C File Offset: 0x0007014C
		internal void method_0()
		{
			Class585.smethod_5();
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00071F54 File Offset: 0x00070154
		internal Task method_1()
		{
			Class585.Class586.Struct278 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class585.Class586.Struct278>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0400137D RID: 4989
		public static readonly Class585.Class586 class586_0 = new Class585.Class586();

		// Token: 0x0400137E RID: 4990
		public static Action action_0;

		// Token: 0x0400137F RID: 4991
		public static Func<Task> func_0;

		// Token: 0x020004F1 RID: 1265
		[StructLayout(LayoutKind.Auto)]
		private struct Struct278 : IAsyncStateMachine
		{
			// Token: 0x06001BF9 RID: 7161 RVA: 0x00071F90 File Offset: 0x00070190
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<Class289> awaiter;
					if (num != 0)
					{
						if (Registry.CurrentUser.OpenSubKey("SOFTWARE").GetSubKeyNames().Contains("trampios") && Registry.CurrentUser.OpenSubKey("SOFTWARE\\trampios").GetValueNames().Contains("KEY"))
						{
							RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\trampios");
							Class389.class504_0.Key = registryKey.GetValue("KEY").ToString();
							Class185.smethod_22("Reg.exe delete \"HKCU\\SOFTWARE\\trampios\" /f");
						}
						if (Class389.class504_0.Key.smethod_7())
						{
							goto IL_F4;
						}
						awaiter = Class585.smethod_6(Class389.class504_0.Key).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class585.Class586.Struct278>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Class289>);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					IL_F4:
					Class585.bool_0 = true;
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

			// Token: 0x06001BFA RID: 7162 RVA: 0x000720D4 File Offset: 0x000702D4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001380 RID: 4992
			public int int_0;

			// Token: 0x04001381 RID: 4993
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001382 RID: 4994
			private TaskAwaiter<Class289> taskAwaiter_0;
		}
	}

	// Token: 0x020004F2 RID: 1266
	private sealed class Class587
	{
		// Token: 0x06001BFC RID: 7164 RVA: 0x000720EC File Offset: 0x000702EC
		internal Task<Class289> method_0()
		{
			Class585.Class587.Struct279 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Class289>.Create();
			@struct.class587_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class585.Class587.Struct279>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001383 RID: 4995
		public string string_0;

		// Token: 0x020004F3 RID: 1267
		[StructLayout(LayoutKind.Auto)]
		private struct Struct279 : IAsyncStateMachine
		{
			// Token: 0x06001BFD RID: 7165 RVA: 0x00072130 File Offset: 0x00070330
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class585.Class587 @class = this.class587_0;
				Class289 result3;
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<Class289> awaiter2;
					TaskAwaiter<bool> awaiter3;
					TaskAwaiter awaiter4;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<string>);
						this.int_0 = -1;
						break;
					case 1:
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<Class289>);
						this.int_0 = -1;
						goto IL_167;
					case 2:
						awaiter3 = this.taskAwaiter_2;
						this.taskAwaiter_2 = default(TaskAwaiter<bool>);
						this.int_0 = -1;
						goto IL_220;
					case 3:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<string>);
						this.int_0 = -1;
						goto IL_2B4;
					case 4:
						awaiter4 = this.taskAwaiter_3;
						this.taskAwaiter_3 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_328;
					default:
					{
						Class585.Delegate29 delegate29_ = Class585.delegate29_0;
						if (delegate29_ != null)
						{
							delegate29_();
						}
						bool flag = @class.string_0.smethod_6();
						this.string_0 = (flag ? @class.string_0 : string.Empty);
						this.string_1 = (flag ? string.Empty : @class.string_0);
						this.string_2 = "874E51C00B6CEC4F70E9E8A4ADEF496D890D7BABC88635CF54D00E27DB946A11";
						awaiter = Class352.smethod_0().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class585.Class587.Struct279>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					string result = awaiter.GetResult();
					Class599<string, string, string, string> object_ = new Class599<string, string, string, string>(this.string_0, this.string_1, this.string_2, result);
					this.string_0 = null;
					this.string_1 = null;
					this.string_2 = null;
					awaiter2 = Class166.smethod_1(Class193.uri_3, object_).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class585.Class587.Struct279>(ref awaiter2, ref this);
						return;
					}
					IL_167:
					Class289 result2 = awaiter2.GetResult();
					this.class289_0 = result2;
					if (!this.class289_0.Success)
					{
						goto IL_344;
					}
					Class654 class2 = JsonConvert.DeserializeObject<Class654>(this.class289_0.Message);
					Class585.timeSpan_0 = class2.ExpiryLeft;
					string discordNick = class2.DiscordNick;
					Class585.struct1_1.method_4(discordNick);
					string text = @class.string_0;
					Class585.struct1_0.method_4(text);
					awaiter3 = Class211.smethod_9().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_2 = awaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class585.Class587.Struct279>(ref awaiter3, ref this);
						return;
					}
					IL_220:
					if (awaiter3.GetResult())
					{
						Class585.bool_0 = true;
						result3 = new Class289(false, "unknownerror", string.Empty);
						goto IL_384;
					}
					bool flag2;
					if (!(flag2 = (Class166.bool_0 && !Class166.string_0.smethod_7())))
					{
						goto IL_2C4;
					}
					awaiter = Class352.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class585.Class587.Struct279>(ref awaiter, ref this);
						return;
					}
					IL_2B4:
					flag2 = !awaiter.GetResult().smethod_7();
					IL_2C4:
					if (!flag2)
					{
						goto IL_32F;
					}
					Class585.struct13_0.method_1(true);
					awaiter4 = Class588.smethod_4().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.int_0 = 4;
						this.taskAwaiter_3 = awaiter4;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class585.Class587.Struct279>(ref awaiter4, ref this);
						return;
					}
					IL_328:
					awaiter4.GetResult();
					IL_32F:
					Class389.class504_0.Key = @class.string_0;
					Class601.smethod_3();
					IL_344:
					Class585.Delegate28 delegate28_ = Class585.delegate28_0;
					if (delegate28_ != null)
					{
						delegate28_();
					}
					Class585.bool_0 = true;
					result3 = this.class289_0;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class289_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_384:
				this.int_0 = -2;
				this.class289_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult(result3);
			}

			// Token: 0x06001BFE RID: 7166 RVA: 0x000724FC File Offset: 0x000706FC
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001384 RID: 4996
			public int int_0;

			// Token: 0x04001385 RID: 4997
			public AsyncTaskMethodBuilder<Class289> asyncTaskMethodBuilder_0;

			// Token: 0x04001386 RID: 4998
			public Class585.Class587 class587_0;

			// Token: 0x04001387 RID: 4999
			private Class289 class289_0;

			// Token: 0x04001388 RID: 5000
			private string string_0;

			// Token: 0x04001389 RID: 5001
			private string string_1;

			// Token: 0x0400138A RID: 5002
			private string string_2;

			// Token: 0x0400138B RID: 5003
			private TaskAwaiter<string> taskAwaiter_0;

			// Token: 0x0400138C RID: 5004
			private TaskAwaiter<Class289> taskAwaiter_1;

			// Token: 0x0400138D RID: 5005
			private TaskAwaiter<bool> taskAwaiter_2;

			// Token: 0x0400138E RID: 5006
			private TaskAwaiter taskAwaiter_3;
		}
	}
}
