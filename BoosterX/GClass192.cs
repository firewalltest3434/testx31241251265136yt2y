using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020002D3 RID: 723
public sealed class GClass192 : GClass189, GInterface13
{
	// Token: 0x060010B0 RID: 4272 RVA: 0x00046430 File Offset: 0x00044630
	internal GClass192(GClass178 gclass178_1) : base(gclass178_1)
	{
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x00046454 File Offset: 0x00044654
	[CompilerGenerated]
	public GClass135 imethod_0()
	{
		return this.gclass135_0;
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x0004645C File Offset: 0x0004465C
	[CompilerGenerated]
	public void imethod_1(GClass135 gclass135_1)
	{
		this.gclass135_0 = gclass135_1;
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x00046468 File Offset: 0x00044668
	protected override string vmethod_0()
	{
		return "moderations";
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x00046470 File Offset: 0x00044670
	public Task<GClass37> imethod_3(string string_0)
	{
		GClass192.Struct147 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass37>.Create();
		@struct.gclass192_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass192.Struct147>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x000464BC File Offset: 0x000446BC
	public Task<GClass37> imethod_2(GClass135 gclass135_1)
	{
		GClass192.Struct148 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass37>.Create();
		@struct.gclass192_0 = this;
		@struct.gclass135_0 = gclass135_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass192.Struct148>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000A03 RID: 2563
	private GClass135 gclass135_0 = new GClass135
	{
		String_0 = GClass89.smethod_27()
	};

	// Token: 0x020002D4 RID: 724
	[StructLayout(LayoutKind.Auto)]
	private struct Struct147 : IAsyncStateMachine
	{
		// Token: 0x060010B6 RID: 4278 RVA: 0x00046508 File Offset: 0x00044708
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass192 gclass = this.gclass192_0;
			GClass37 result;
			try
			{
				TaskAwaiter<GClass37> awaiter;
				if (num != 0)
				{
					GClass135 gclass135_ = new GClass135(new string[]
					{
						this.string_0,
						gclass.imethod_0().String_0
					});
					awaiter = gclass.imethod_2(gclass135_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass37>, GClass192.Struct147>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass37>);
					this.int_0 = -1;
				}
				result = awaiter.GetResult();
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

		// Token: 0x060010B7 RID: 4279 RVA: 0x000465E4 File Offset: 0x000447E4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A04 RID: 2564
		public int int_0;

		// Token: 0x04000A05 RID: 2565
		public AsyncTaskMethodBuilder<GClass37> asyncTaskMethodBuilder_0;

		// Token: 0x04000A06 RID: 2566
		public string string_0;

		// Token: 0x04000A07 RID: 2567
		public GClass192 gclass192_0;

		// Token: 0x04000A08 RID: 2568
		private TaskAwaiter<GClass37> taskAwaiter_0;
	}

	// Token: 0x020002D5 RID: 725
	[StructLayout(LayoutKind.Auto)]
	private struct Struct148 : IAsyncStateMachine
	{
		// Token: 0x060010B8 RID: 4280 RVA: 0x000465F4 File Offset: 0x000447F4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass192 gclass = this.gclass192_0;
			GClass37 result;
			try
			{
				TaskAwaiter<GClass37> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_8<GClass37>(null, this.gclass135_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass37>, GClass192.Struct148>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass37>);
					this.int_0 = -1;
				}
				result = awaiter.GetResult();
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

		// Token: 0x060010B9 RID: 4281 RVA: 0x000466B4 File Offset: 0x000448B4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A09 RID: 2569
		public int int_0;

		// Token: 0x04000A0A RID: 2570
		public AsyncTaskMethodBuilder<GClass37> asyncTaskMethodBuilder_0;

		// Token: 0x04000A0B RID: 2571
		public GClass192 gclass192_0;

		// Token: 0x04000A0C RID: 2572
		public GClass135 gclass135_0;

		// Token: 0x04000A0D RID: 2573
		private TaskAwaiter<GClass37> taskAwaiter_0;
	}
}
