using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x02000470 RID: 1136
internal sealed class Class533
{
	// Token: 0x0600193E RID: 6462 RVA: 0x00067CA4 File Offset: 0x00065EA4
	public static void smethod_0(Class533.Delegate27 delegate27_1)
	{
		Class533.Delegate27 @delegate = Class533.delegate27_0;
		Class533.Delegate27 delegate2;
		do
		{
			delegate2 = @delegate;
			Class533.Delegate27 value = (Class533.Delegate27)Delegate.Combine(delegate2, delegate27_1);
			@delegate = Interlocked.CompareExchange<Class533.Delegate27>(ref Class533.delegate27_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x0600193F RID: 6463 RVA: 0x00067CD8 File Offset: 0x00065ED8
	public static void smethod_1(Class533.Delegate27 delegate27_1)
	{
		Class533.Delegate27 @delegate = Class533.delegate27_0;
		Class533.Delegate27 delegate2;
		do
		{
			delegate2 = @delegate;
			Class533.Delegate27 value = (Class533.Delegate27)Delegate.Remove(delegate2, delegate27_1);
			@delegate = Interlocked.CompareExchange<Class533.Delegate27>(ref Class533.delegate27_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x00067D0C File Offset: 0x00065F0C
	public static void smethod_2()
	{
		Class533.float_0 = 0f;
		Class533.float_1 = 0f;
		Class533.float_2 = 0f;
		Class533.float_3 = 0f;
		Class533.float_4 = 0f;
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x00067D40 File Offset: 0x00065F40
	public static void smethod_3()
	{
		Class533.Struct242 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class533.Struct242>(ref @struct);
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x00067D70 File Offset: 0x00065F70
	public static void smethod_4()
	{
		Class533.Struct239 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class533.Struct239>(ref @struct);
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x00067DA0 File Offset: 0x00065FA0
	public static void smethod_5()
	{
		Class533.Struct241 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class533.Struct241>(ref @struct);
	}

	// Token: 0x06001944 RID: 6468
	[DllImport("psapi.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetPerformanceInfo(out Class533.Struct238 struct238_0, [In] int int_0);

	// Token: 0x06001945 RID: 6469 RVA: 0x00067DD0 File Offset: 0x00065FD0
	public static long smethod_6()
	{
		Class533.Struct238 structure = default(Class533.Struct238);
		if (Class533.GetPerformanceInfo(out structure, Marshal.SizeOf<Class533.Struct238>(structure)))
		{
			return Convert.ToInt64(structure.intptr_4.ToInt64() * structure.intptr_9.ToInt64() / 1048576L);
		}
		return -1L;
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x00067E28 File Offset: 0x00066028
	public static long smethod_7()
	{
		Class533.Struct238 structure = default(Class533.Struct238);
		if (Class533.GetPerformanceInfo(out structure, Marshal.SizeOf<Class533.Struct238>(structure)))
		{
			return Convert.ToInt64(structure.intptr_3.ToInt64() * structure.intptr_9.ToInt64() / 1048576L);
		}
		return -1L;
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x00067E80 File Offset: 0x00066080
	public static long smethod_8()
	{
		Class533.Struct238 structure = default(Class533.Struct238);
		if (Class533.GetPerformanceInfo(out structure, Marshal.SizeOf<Class533.Struct238>(structure)))
		{
			return Convert.ToInt64(structure.intptr_5.ToInt64() * structure.intptr_9.ToInt64() / 1048576L);
		}
		return -1L;
	}

	// Token: 0x0400118E RID: 4494
	public static float float_0;

	// Token: 0x0400118F RID: 4495
	public static float float_1;

	// Token: 0x04001190 RID: 4496
	public static float float_2;

	// Token: 0x04001191 RID: 4497
	public static float float_3;

	// Token: 0x04001192 RID: 4498
	public static float float_4;

	// Token: 0x04001193 RID: 4499
	private static Class533.Delegate27 delegate27_0;

	// Token: 0x04001194 RID: 4500
	private static bool bool_0;

	// Token: 0x02000471 RID: 1137
	// (Invoke) Token: 0x06001949 RID: 6473
	public delegate void Delegate27();

	// Token: 0x02000472 RID: 1138
	public struct Struct238
	{
		// Token: 0x04001195 RID: 4501
		public int int_0;

		// Token: 0x04001196 RID: 4502
		public IntPtr intptr_0;

		// Token: 0x04001197 RID: 4503
		public IntPtr intptr_1;

		// Token: 0x04001198 RID: 4504
		public IntPtr intptr_2;

		// Token: 0x04001199 RID: 4505
		public IntPtr intptr_3;

		// Token: 0x0400119A RID: 4506
		public IntPtr intptr_4;

		// Token: 0x0400119B RID: 4507
		public IntPtr intptr_5;

		// Token: 0x0400119C RID: 4508
		public IntPtr intptr_6;

		// Token: 0x0400119D RID: 4509
		public IntPtr intptr_7;

		// Token: 0x0400119E RID: 4510
		public IntPtr intptr_8;

		// Token: 0x0400119F RID: 4511
		public IntPtr intptr_9;

		// Token: 0x040011A0 RID: 4512
		public int int_1;

		// Token: 0x040011A1 RID: 4513
		public int int_2;

		// Token: 0x040011A2 RID: 4514
		public int int_3;
	}

	// Token: 0x02000473 RID: 1139
	[StructLayout(LayoutKind.Auto)]
	private struct Struct239 : IAsyncStateMachine
	{
		// Token: 0x0600194C RID: 6476 RVA: 0x00067ED8 File Offset: 0x000660D8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class533.Class534.class534_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class533.Struct239>(ref awaiter, ref this);
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

		// Token: 0x0600194D RID: 6477 RVA: 0x00067FA4 File Offset: 0x000661A4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040011A3 RID: 4515
		public int int_0;

		// Token: 0x040011A4 RID: 4516
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040011A5 RID: 4517
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000474 RID: 1140
	[Serializable]
	private sealed class Class534
	{
		// Token: 0x06001950 RID: 6480 RVA: 0x00067FC8 File Offset: 0x000661C8
		internal void method_0()
		{
			Class533.bool_0 = true;
			Class533.smethod_5();
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00067FD8 File Offset: 0x000661D8
		internal void method_1()
		{
			Class533.bool_0 = false;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00067FE0 File Offset: 0x000661E0
		internal Task method_2()
		{
			Class533.Class534.Struct240 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class533.Class534.Struct240>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040011A6 RID: 4518
		public static readonly Class533.Class534 class534_0 = new Class533.Class534();

		// Token: 0x040011A7 RID: 4519
		public static Action action_0;

		// Token: 0x040011A8 RID: 4520
		public static Action action_1;

		// Token: 0x040011A9 RID: 4521
		public static Func<Task> func_0;

		// Token: 0x02000475 RID: 1141
		[StructLayout(LayoutKind.Auto)]
		private struct Struct240 : IAsyncStateMachine
		{
			// Token: 0x06001953 RID: 6483 RVA: 0x0006801C File Offset: 0x0006621C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					if (num != 0)
					{
						goto IL_56;
					}
					TaskAwaiter awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					IL_4F:
					awaiter.GetResult();
					IL_56:
					if (Class533.bool_0)
					{
						Class533.float_4 = (float)Class533.smethod_7();
						Class533.float_2 = (float)Class533.smethod_6();
						Class533.float_0 = Class533.float_4 - Class533.float_2;
						Class533.float_1 = (float)Class533.smethod_8();
						float num2 = Class533.float_4 - Class533.float_0 - Class533.float_1;
						Class533.float_3 = ((num2 < 0f) ? 0f : num2);
						Class533.Delegate27 delegate27_ = Class533.delegate27_0;
						if (delegate27_ != null)
						{
							delegate27_();
						}
						awaiter = Task.Delay(1000).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_4F;
						}
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class533.Class534.Struct240>(ref awaiter, ref this);
						return;
					}
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

			// Token: 0x06001954 RID: 6484 RVA: 0x00068160 File Offset: 0x00066360
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040011AA RID: 4522
			public int int_0;

			// Token: 0x040011AB RID: 4523
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040011AC RID: 4524
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x02000476 RID: 1142
	[StructLayout(LayoutKind.Auto)]
	private struct Struct241 : IAsyncStateMachine
	{
		// Token: 0x06001955 RID: 6485 RVA: 0x00068170 File Offset: 0x00066370
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(Class533.Class534.class534_0.method_2)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class533.Struct241>(ref awaiter, ref this);
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

		// Token: 0x06001956 RID: 6486 RVA: 0x0006823C File Offset: 0x0006643C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040011AD RID: 4525
		public int int_0;

		// Token: 0x040011AE RID: 4526
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040011AF RID: 4527
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000477 RID: 1143
	[StructLayout(LayoutKind.Auto)]
	private struct Struct242 : IAsyncStateMachine
	{
		// Token: 0x06001957 RID: 6487 RVA: 0x0006824C File Offset: 0x0006644C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class533.Class534.class534_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class533.Struct242>(ref awaiter, ref this);
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

		// Token: 0x06001958 RID: 6488 RVA: 0x00068318 File Offset: 0x00066518
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040011B0 RID: 4528
		public int int_0;

		// Token: 0x040011B1 RID: 4529
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040011B2 RID: 4530
		private TaskAwaiter taskAwaiter_0;
	}
}
