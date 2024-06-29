using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ns0;

// Token: 0x02000202 RID: 514
internal sealed class Class271
{
	// Token: 0x06000C75 RID: 3189 RVA: 0x00037C20 File Offset: 0x00035E20
	public static Task<Class718> smethod_0(bool bool_0)
	{
		Class271.Struct110 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Class718>.Create();
		@struct.bool_0 = bool_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class271.Struct110>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x00037C64 File Offset: 0x00035E64
	public static void smethod_1()
	{
		Class271.Struct107 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class271.Struct107>(ref @struct);
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x00037C94 File Offset: 0x00035E94
	public static void smethod_2()
	{
		Class271.Struct109 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class271.Struct109>(ref @struct);
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x00037CC4 File Offset: 0x00035EC4
	public static void smethod_3()
	{
		Class271.Struct108 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class271.Struct108>(ref @struct);
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x00037CF4 File Offset: 0x00035EF4
	public static Task smethod_4()
	{
		Class271.Struct111 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class271.Struct111>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00037D30 File Offset: 0x00035F30
	internal static List<string> smethod_5()
	{
		List<string> list = new List<string>();
		if (Class271.class718_0 != null)
		{
			foreach (Class745 @class in Class271.class718_0.Tweaks)
			{
				list.Add(@class.Name);
			}
		}
		return list;
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x00037D98 File Offset: 0x00035F98
	public static Task<List<Class188>> smethod_6()
	{
		Class271.Struct112 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class188>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class271.Struct112>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0400079B RID: 1947
	private static readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x0400079C RID: 1948
	public static Class718 class718_0;

	// Token: 0x02000203 RID: 515
	[StructLayout(LayoutKind.Auto)]
	private struct Struct107 : IAsyncStateMachine
	{
		// Token: 0x06000C7C RID: 3196 RVA: 0x00037DD4 File Offset: 0x00035FD4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Class271.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class271.Struct107>(ref awaiter, ref this);
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
				IEnumerator<Class745> enumerator = Class271.class718_0.Tweaks.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 @class = enumerator.Current;
						string empty = string.Empty;
						if (Class491.dictionary_0.TryGetValue(@class.NameRawIcon, out empty))
						{
							if (empty == "BEST")
							{
								@class.method_14();
							}
							else
							{
								@class.method_16();
							}
						}
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

		// Token: 0x06000C7D RID: 3197 RVA: 0x00037EF8 File Offset: 0x000360F8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400079D RID: 1949
		public int int_0;

		// Token: 0x0400079E RID: 1950
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400079F RID: 1951
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000204 RID: 516
	[StructLayout(LayoutKind.Auto)]
	private struct Struct108 : IAsyncStateMachine
	{
		// Token: 0x06000C7E RID: 3198 RVA: 0x00037F08 File Offset: 0x00036108
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Class271.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class271.Struct108>(ref awaiter, ref this);
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
				IEnumerator<Class745> enumerator = Class271.class718_0.Tweaks.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 @class = enumerator.Current;
						string empty = string.Empty;
						if (Class491.dictionary_1.TryGetValue(@class.NameRawIcon, out empty))
						{
							if (empty == "BEST")
							{
								@class.method_14();
							}
							else
							{
								@class.method_16();
							}
						}
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

		// Token: 0x06000C7F RID: 3199 RVA: 0x0003802C File Offset: 0x0003622C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007A0 RID: 1952
		public int int_0;

		// Token: 0x040007A1 RID: 1953
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007A2 RID: 1954
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000205 RID: 517
	[StructLayout(LayoutKind.Auto)]
	private struct Struct109 : IAsyncStateMachine
	{
		// Token: 0x06000C80 RID: 3200 RVA: 0x0003803C File Offset: 0x0003623C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Class271.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class271.Struct109>(ref awaiter, ref this);
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
				IEnumerator<Class745> enumerator = Class271.class718_0.Tweaks.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 @class = enumerator.Current;
						@class.method_14();
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

		// Token: 0x06000C81 RID: 3201 RVA: 0x0003812C File Offset: 0x0003632C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007A3 RID: 1955
		public int int_0;

		// Token: 0x040007A4 RID: 1956
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007A5 RID: 1957
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000206 RID: 518
	[StructLayout(LayoutKind.Auto)]
	private struct Struct110 : IAsyncStateMachine
	{
		// Token: 0x06000C82 RID: 3202 RVA: 0x0003813C File Offset: 0x0003633C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class718 result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Class271.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class271.Struct110>(ref awaiter, ref this);
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
				try
				{
					if (Class271.class718_0 == null)
					{
						Class271.class718_0 = new Class718();
						result = Class271.class718_0;
					}
					else
					{
						if (this.bool_0)
						{
							Class271.class718_0.method_2();
						}
						result = Class271.class718_0;
					}
				}
				catch
				{
					result = null;
				}
				finally
				{
					if (num < 0)
					{
						Class271.semaphoreSlim_0.Release();
					}
				}
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

		// Token: 0x06000C83 RID: 3203 RVA: 0x00038268 File Offset: 0x00036468
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007A6 RID: 1958
		public int int_0;

		// Token: 0x040007A7 RID: 1959
		public AsyncTaskMethodBuilder<Class718> asyncTaskMethodBuilder_0;

		// Token: 0x040007A8 RID: 1960
		public bool bool_0;

		// Token: 0x040007A9 RID: 1961
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000207 RID: 519
	[StructLayout(LayoutKind.Auto)]
	private struct Struct111 : IAsyncStateMachine
	{
		// Token: 0x06000C84 RID: 3204 RVA: 0x00038278 File Offset: 0x00036478
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
					goto IL_97;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_E7;
				}
				this.int_1 = 0;
				IL_74:
				if (Class271.class718_0 == null)
				{
					awaiter = Task.Delay(20).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class271.Struct111>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					if (Class271.class718_0 == null)
					{
						goto IL_189;
					}
					this.int_1 = 0;
					goto IL_110;
				}
				IL_97:
				awaiter.GetResult();
				if (this.int_1 > 500)
				{
					goto IL_189;
				}
				int num2 = this.int_1;
				this.int_1 = num2 + 1;
				goto IL_74;
				IL_E7:
				awaiter.GetResult();
				if (this.int_1 > 500)
				{
					goto IL_189;
				}
				num2 = this.int_1;
				this.int_1 = num2 + 1;
				IL_110:
				if (!Class271.class718_0.bool_0)
				{
					awaiter = Task.Delay(20).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_E7;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class271.Struct111>(ref awaiter, ref this);
					return;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_189:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00038440 File Offset: 0x00036640
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007AA RID: 1962
		public int int_0;

		// Token: 0x040007AB RID: 1963
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040007AC RID: 1964
		private int int_1;

		// Token: 0x040007AD RID: 1965
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000208 RID: 520
	[StructLayout(LayoutKind.Auto)]
	private struct Struct112 : IAsyncStateMachine
	{
		// Token: 0x06000C86 RID: 3206 RVA: 0x00038450 File Offset: 0x00036650
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class188> result;
			try
			{
				if (num == 0)
				{
					goto IL_A0;
				}
				TaskAwaiter awaiter2;
				if (num != 1)
				{
					this.list_0 = new List<Class188>();
					if (Class271.class718_0 != null)
					{
						goto IL_C4;
					}
					TaskAwaiter<Class718> awaiter = Class271.smethod_0(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class718>, Class271.Struct112>(ref awaiter, ref this);
						return;
					}
					goto IL_BC;
				}
				else
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				IL_83:
				awaiter2.GetResult();
				IEnumerator<Class745> enumerator = Class271.class718_0.Tweaks.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 @class = enumerator.Current;
						this.list_0.Add(new Class188
						{
							Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Json,
							Name = @class.NameRaw,
							State = ((@class.CurrentValueType != "CUSTOM") ? @class.CurrentValueType : @class.CurrentCustomValue)
						});
					}
					goto IL_17A;
					IL_A0:
					TaskAwaiter<Class718> awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class718>);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
					IL_BC:
					awaiter.GetResult();
					IL_C4:
					awaiter2 = Class271.smethod_4().GetAwaiter();
					if (awaiter2.IsCompleted)
					{
						goto IL_83;
					}
					int num5 = 1;
					num = 1;
					this.int_0 = num5;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class271.Struct112>(ref awaiter2, ref this);
					return;
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				IL_17A:
				result = this.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00038658 File Offset: 0x00036858
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007AE RID: 1966
		public int int_0;

		// Token: 0x040007AF RID: 1967
		public AsyncTaskMethodBuilder<List<Class188>> asyncTaskMethodBuilder_0;

		// Token: 0x040007B0 RID: 1968
		private List<Class188> list_0;

		// Token: 0x040007B1 RID: 1969
		private TaskAwaiter<Class718> taskAwaiter_0;

		// Token: 0x040007B2 RID: 1970
		private TaskAwaiter taskAwaiter_1;
	}
}
