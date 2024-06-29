using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ns0;

// Token: 0x02000135 RID: 309
public sealed class GClass16 : Interface8
{
	// Token: 0x06000809 RID: 2057 RVA: 0x00026DF8 File Offset: 0x00024FF8
	public dje_zCAP6BWWS6CCL7H9NW6P82_ejd imethod_0()
	{
		Class351 @class = new Class351();
		dje_zCAP6BWWS6CCL7H9NW6P82_ejd result;
		try
		{
			dje_zCAP6BWWS6CCL7H9NW6P82_ejd dje_zCAP6BWWS6CCL7H9NW6P82_ejd = @class.method_2<dje_zCAP6BWWS6CCL7H9NW6P82_ejd>("http://www.speedtest.net/speedtest-config.php");
			dje_z58JVF8WGDBEGMQ774RC7X_ejd dje_z58JVF8WGDBEGMQ774RC7X_ejd = @class.method_2<dje_z58JVF8WGDBEGMQ774RC7X_ejd>("http://www.speedtest.net/speedtest-servers.php");
			dje_z58JVF8WGDBEGMQ774RC7X_ejd.method_0(dje_zCAP6BWWS6CCL7H9NW6P82_ejd.dje_z47ACRX7V_ejd.GeoCoordinate);
			dje_zCAP6BWWS6CCL7H9NW6P82_ejd.Servers = dje_z58JVF8WGDBEGMQ774RC7X_ejd.dje_zCTJSS8TJ_ejd.OrderBy(new Func<dje_z8KW56LJY9U4NE627Q7PL4_ejd, double>(GClass16.Class171.class171_0.method_0)).ToList<dje_z8KW56LJY9U4NE627Q7PL4_ejd>();
			result = dje_zCAP6BWWS6CCL7H9NW6P82_ejd;
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		return result;
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00026E88 File Offset: 0x00025088
	public int imethod_1(dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0, int int_1 = 3)
	{
		string address = GClass16.smethod_3(dje_z8KW56LJY9U4NE627Q7PL4_ejd_0, "latency.txt");
		Stopwatch stopwatch = new Stopwatch();
		Class351 @class = new Class351();
		try
		{
			int i = 0;
			while (i < int_1)
			{
				string text;
				try
				{
					stopwatch.Start();
					text = @class.DownloadString(address);
				}
				catch (WebException ex)
				{
					goto IL_51;
				}
				finally
				{
					stopwatch.Stop();
				}
				goto IL_40;
				IL_51:
				i++;
				continue;
				IL_40:
				if (text.StartsWith("test=test"))
				{
					goto IL_51;
				}
				throw new InvalidOperationException("Server returned incorrect test string for latency.txt");
			}
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		return (int)stopwatch.ElapsedMilliseconds / int_1;
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00026F3C File Offset: 0x0002513C
	public double imethod_2(dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0, int int_1 = 2, int int_2 = 2)
	{
		return GClass16.smethod_0<string>(this.method_0(dje_z8KW56LJY9U4NE627Q7PL4_ejd_0, int_2), new Func<WebClient, string, Task<int>>(GClass16.Class171.class171_0.method_1), int_1);
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00026F6C File Offset: 0x0002516C
	public double imethod_3(dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0, int int_1 = 2, int int_2 = 2)
	{
		GClass16.Class169 @class = new GClass16.Class169();
		@class.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0 = dje_z8KW56LJY9U4NE627Q7PL4_ejd_0;
		return GClass16.smethod_0<NameValueCollection>(GClass16.smethod_2(int_2), new Func<WebClient, NameValueCollection, Task<int>>(@class.method_0), int_1);
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00026FA0 File Offset: 0x000251A0
	private static double smethod_0<T>(IEnumerable<T> ienumerable_0, Func<WebClient, T, Task<int>> func_0, int int_1)
	{
		GClass16.Class170<T> @class = new GClass16.Class170<T>();
		@class.func_0 = func_0;
		@class.semaphoreSlim_0 = new SemaphoreSlim(int_1);
		GClass16.stopwatch_0.Reset();
		GClass16.stopwatch_0.Start();
		Task[] tasks;
		IEnumerable<Task<int>> source = tasks = ienumerable_0.Select(new Func<T, Task<int>>(@class.method_0)).ToArray<Task<int>>();
		Task.WaitAll(tasks);
		GClass16.stopwatch_0.Stop();
		double num = (double)source.Sum(new Func<Task<int>, int>(GClass16.Class173<T>.class173_0.method_0));
		GClass16.list_0.Clear();
		return num * 8.0 / 1024.0 / ((double)GClass16.stopwatch_0.ElapsedMilliseconds / 1000.0);
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x0002705C File Offset: 0x0002525C
	private static void smethod_1(int int_1)
	{
		GClass16.list_0.Add(int_1);
		dje_zC7GGM5J9JMCAHA4MLTJEGB3TDHU55L6ZPVEBX7W7ERSRJHHAHEHCR_ejd.double_2 = (double)(GClass16.list_0.Sum() * 8 / 1024) / ((double)GClass16.stopwatch_0.ElapsedMilliseconds / 1000.0);
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x00027098 File Offset: 0x00025298
	private static IEnumerable<NameValueCollection> smethod_2(int int_1)
	{
		Random random = new Random();
		List<NameValueCollection> list = new List<NameValueCollection>();
		for (int i = 1; i < 21; i++)
		{
			int num = i * 200 * 1024;
			StringBuilder stringBuilder = new StringBuilder(num);
			for (int j = 0; j < num; j++)
			{
				stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ"[random.Next(26)]);
			}
			for (int k = 0; k < int_1; k++)
			{
				list.Add(new NameValueCollection
				{
					{
						string.Format("content{0}", i),
						stringBuilder.ToString()
					}
				});
			}
		}
		return list;
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x0002714C File Offset: 0x0002534C
	private static string smethod_3(dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0, string string_0)
	{
		return new Uri(new Uri(dje_z8KW56LJY9U4NE627Q7PL4_ejd_0.Url), ".").OriginalString + string_0;
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00027170 File Offset: 0x00025370
	private IEnumerable<string> method_0(dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0, int int_1)
	{
		return new GClass16.Class172(-2)
		{
			gclass16_0 = this,
			dje_z8KW56LJY9U4NE627Q7PL4_ejd_1 = dje_z8KW56LJY9U4NE627Q7PL4_ejd_0,
			int_3 = int_1
		};
	}

	// Token: 0x04000467 RID: 1127
	private readonly int[] int_0 = new int[]
	{
		350,
		750,
		1500,
		3500,
		4000
	};

	// Token: 0x04000468 RID: 1128
	private static Stopwatch stopwatch_0 = new Stopwatch();

	// Token: 0x04000469 RID: 1129
	private static List<int> list_0 = new List<int>();

	// Token: 0x02000136 RID: 310
	private sealed class Class169
	{
		// Token: 0x06000813 RID: 2067 RVA: 0x00027198 File Offset: 0x00025398
		internal Task<int> method_0(WebClient webClient_0, NameValueCollection nameValueCollection_0)
		{
			GClass16.Class169.Struct60 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<int>.Create();
			@struct.class169_0 = this;
			@struct.webClient_0 = webClient_0;
			@struct.nameValueCollection_0 = nameValueCollection_0;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass16.Class169.Struct60>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0400046A RID: 1130
		public dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0;

		// Token: 0x02000137 RID: 311
		[StructLayout(LayoutKind.Auto)]
		private struct Struct60 : IAsyncStateMachine
		{
			// Token: 0x06000814 RID: 2068 RVA: 0x000271EC File Offset: 0x000253EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				GClass16.Class169 @class = this.class169_0;
				int length;
				try
				{
					ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = this.webClient_0.UploadValuesTaskAsync(@class.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0.Url, this.nameValueCollection_0).ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.configuredTaskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter, GClass16.Class169.Struct60>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.configuredTaskAwaiter_0;
						this.configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					length = this.nameValueCollection_0[0].Length;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult(length);
			}

			// Token: 0x06000815 RID: 2069 RVA: 0x000272D4 File Offset: 0x000254D4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400046B RID: 1131
			public int int_0;

			// Token: 0x0400046C RID: 1132
			public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

			// Token: 0x0400046D RID: 1133
			public WebClient webClient_0;

			// Token: 0x0400046E RID: 1134
			public GClass16.Class169 class169_0;

			// Token: 0x0400046F RID: 1135
			public NameValueCollection nameValueCollection_0;

			// Token: 0x04000470 RID: 1136
			private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;
		}
	}

	// Token: 0x02000138 RID: 312
	private sealed class Class170<T>
	{
		// Token: 0x06000817 RID: 2071 RVA: 0x000272EC File Offset: 0x000254EC
		internal Task<int> method_0(T gparam_0)
		{
			GClass16.Class170<T>.Struct61 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<int>.Create();
			@struct.class170_0 = this;
			@struct.gparam_0 = gparam_0;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass16.Class170<T>.Struct61>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000471 RID: 1137
		public SemaphoreSlim semaphoreSlim_0;

		// Token: 0x04000472 RID: 1138
		public Func<WebClient, T, Task<int>> func_0;

		// Token: 0x02000139 RID: 313
		[StructLayout(LayoutKind.Auto)]
		private struct Struct61 : IAsyncStateMachine
		{
			// Token: 0x06000818 RID: 2072 RVA: 0x00027338 File Offset: 0x00025538
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				GClass16.Class170<T> @class = this.class170_0;
				int result2;
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_95;
						}
						awaiter = @class.semaphoreSlim_0.WaitAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.configuredTaskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, GClass16.Class170<T>.Struct61>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.configuredTaskAwaiter_0;
						this.configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
					this.class351_0 = new Class351();
					try
					{
						IL_95:
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter2;
						if (num != 1)
						{
							awaiter2 = @class.func_0(this.class351_0, this.gparam_0).ConfigureAwait(false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								this.int_0 = num4;
								this.configuredTaskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, GClass16.Class170<T>.Struct61>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.configuredTaskAwaiter_1;
							this.configuredTaskAwaiter_1 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
						}
						int result = awaiter2.GetResult();
						GClass16.smethod_1(result);
						result2 = result;
					}
					finally
					{
						if (num < 0)
						{
							this.class351_0.Dispose();
							@class.semaphoreSlim_0.Release();
						}
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class351_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class351_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult(result2);
			}

			// Token: 0x06000819 RID: 2073 RVA: 0x000274FC File Offset: 0x000256FC
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000473 RID: 1139
			public int int_0;

			// Token: 0x04000474 RID: 1140
			public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

			// Token: 0x04000475 RID: 1141
			public GClass16.Class170<T> class170_0;

			// Token: 0x04000476 RID: 1142
			public T gparam_0;

			// Token: 0x04000477 RID: 1143
			private Class351 class351_0;

			// Token: 0x04000478 RID: 1144
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

			// Token: 0x04000479 RID: 1145
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter configuredTaskAwaiter_1;
		}
	}

	// Token: 0x0200013A RID: 314
	[Serializable]
	private sealed class Class171
	{
		// Token: 0x0600081C RID: 2076 RVA: 0x00027520 File Offset: 0x00025720
		internal double method_0(dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0)
		{
			return dje_z8KW56LJY9U4NE627Q7PL4_ejd_0.Distance;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00027528 File Offset: 0x00025728
		internal Task<int> method_1(WebClient webClient_0, string string_0)
		{
			GClass16.Class171.Struct62 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<int>.Create();
			@struct.webClient_0 = webClient_0;
			@struct.string_0 = string_0;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass16.Class171.Struct62>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0400047A RID: 1146
		public static readonly GClass16.Class171 class171_0 = new GClass16.Class171();

		// Token: 0x0400047B RID: 1147
		public static Func<dje_z8KW56LJY9U4NE627Q7PL4_ejd, double> func_0;

		// Token: 0x0400047C RID: 1148
		public static Func<WebClient, string, Task<int>> func_1;

		// Token: 0x0200013B RID: 315
		[StructLayout(LayoutKind.Auto)]
		private struct Struct62 : IAsyncStateMachine
		{
			// Token: 0x0600081E RID: 2078 RVA: 0x00027574 File Offset: 0x00025774
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				int result;
				try
				{
					ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = this.webClient_0.DownloadDataTaskAsync(this.string_0).ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.configuredTaskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter, GClass16.Class171.Struct62>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.configuredTaskAwaiter_0;
						this.configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter);
						this.int_0 = -1;
					}
					result = awaiter.GetResult().Length;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult(result);
			}

			// Token: 0x0600081F RID: 2079 RVA: 0x00027638 File Offset: 0x00025838
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400047D RID: 1149
			public int int_0;

			// Token: 0x0400047E RID: 1150
			public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

			// Token: 0x0400047F RID: 1151
			public WebClient webClient_0;

			// Token: 0x04000480 RID: 1152
			public string string_0;

			// Token: 0x04000481 RID: 1153
			private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;
		}
	}

	// Token: 0x0200013C RID: 316
	private sealed class Class172 : IEnumerator<string>, IEnumerable<string>, IDisposable, IEnumerable, IEnumerator
	{
		// Token: 0x06000820 RID: 2080 RVA: 0x00027648 File Offset: 0x00025848
		public Class172(int int_8)
		{
			this.int_0 = int_8;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00027664 File Offset: 0x00025864
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00027668 File Offset: 0x00025868
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			GClass16 gclass = this.gclass16_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.string_1 = GClass16.smethod_3(this.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0, "random{0}x{0}.jpg?r={1}");
				this.int_4 = gclass.int_0;
				this.int_5 = 0;
				goto IL_AB;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			int num2 = this.int_7;
			this.int_7 = num2 + 1;
			IL_8A:
			if (this.int_7 < this.int_2)
			{
				this.string_0 = string.Format(this.string_1, this.int_6, this.int_7);
				this.int_0 = 1;
				return true;
			}
			this.int_5++;
			IL_AB:
			if (this.int_5 >= this.int_4.Length)
			{
				this.int_4 = null;
				return false;
			}
			this.int_6 = this.int_4[this.int_5];
			this.int_7 = 0;
			goto IL_8A;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00027770 File Offset: 0x00025970
		string IEnumerator<string>.p000001
		{
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00027778 File Offset: 0x00025978
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00027780 File Offset: 0x00025980
		object IEnumerator.Current
		{
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00027788 File Offset: 0x00025988
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			GClass16.Class172 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new GClass16.Class172(0);
				@class.gclass16_0 = this.gclass16_0;
			}
			@class.dje_z8KW56LJY9U4NE627Q7PL4_ejd_0 = this.dje_z8KW56LJY9U4NE627Q7PL4_ejd_1;
			@class.int_2 = this.int_3;
			return @class;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000277E4 File Offset: 0x000259E4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000482 RID: 1154
		private int int_0;

		// Token: 0x04000483 RID: 1155
		private string string_0;

		// Token: 0x04000484 RID: 1156
		private int int_1;

		// Token: 0x04000485 RID: 1157
		private dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_0;

		// Token: 0x04000486 RID: 1158
		public dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd_1;

		// Token: 0x04000487 RID: 1159
		public GClass16 gclass16_0;

		// Token: 0x04000488 RID: 1160
		private int int_2;

		// Token: 0x04000489 RID: 1161
		public int int_3;

		// Token: 0x0400048A RID: 1162
		private string string_1;

		// Token: 0x0400048B RID: 1163
		private int[] int_4;

		// Token: 0x0400048C RID: 1164
		private int int_5;

		// Token: 0x0400048D RID: 1165
		private int int_6;

		// Token: 0x0400048E RID: 1166
		private int int_7;
	}

	// Token: 0x0200013D RID: 317
	[Serializable]
	private sealed class Class173<T>
	{
		// Token: 0x0600082A RID: 2090 RVA: 0x00027800 File Offset: 0x00025A00
		internal int method_0(Task<int> task_0)
		{
			return task_0.Result;
		}

		// Token: 0x0400048F RID: 1167
		public static readonly GClass16.Class173<T> class173_0 = new GClass16.Class173<T>();

		// Token: 0x04000490 RID: 1168
		public static Func<Task<int>, int> func_0;
	}
}
