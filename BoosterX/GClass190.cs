using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x0200014A RID: 330
public sealed class GClass190 : GClass189, GInterface6
{
	// Token: 0x06000869 RID: 2153 RVA: 0x00028AB8 File Offset: 0x00026CB8
	internal GClass190(GClass178 gclass178_1) : base(gclass178_1)
	{
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00028AC4 File Offset: 0x00026CC4
	protected override string vmethod_0()
	{
		return "images/generations";
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00028ACC File Offset: 0x00026CCC
	public Task<GClass36> imethod_1(string string_0, GClass89 gclass89_0 = null)
	{
		GClass190.Struct65 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass36>.Create();
		@struct.gclass190_0 = this;
		@struct.string_0 = string_0;
		@struct.gclass89_0 = gclass89_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass190.Struct65>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00028B20 File Offset: 0x00026D20
	public Task<GClass36> imethod_0(GClass1 gclass1_0)
	{
		GClass190.Struct64 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass36>.Create();
		@struct.gclass190_0 = this;
		@struct.gclass1_0 = gclass1_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass190.Struct64>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0200014B RID: 331
	[StructLayout(LayoutKind.Auto)]
	private struct Struct64 : IAsyncStateMachine
	{
		// Token: 0x0600086D RID: 2157 RVA: 0x00028B6C File Offset: 0x00026D6C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass190 gclass = this.gclass190_0;
			GClass36 result;
			try
			{
				TaskAwaiter<GClass36> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_8<GClass36>(null, this.gclass1_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass36>, GClass190.Struct64>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass36>);
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

		// Token: 0x0600086E RID: 2158 RVA: 0x00028C2C File Offset: 0x00026E2C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040004AF RID: 1199
		public int int_0;

		// Token: 0x040004B0 RID: 1200
		public AsyncTaskMethodBuilder<GClass36> asyncTaskMethodBuilder_0;

		// Token: 0x040004B1 RID: 1201
		public GClass190 gclass190_0;

		// Token: 0x040004B2 RID: 1202
		public GClass1 gclass1_0;

		// Token: 0x040004B3 RID: 1203
		private TaskAwaiter<GClass36> taskAwaiter_0;
	}

	// Token: 0x0200014C RID: 332
	[StructLayout(LayoutKind.Auto)]
	private struct Struct65 : IAsyncStateMachine
	{
		// Token: 0x0600086F RID: 2159 RVA: 0x00028C3C File Offset: 0x00026E3C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass190 gclass = this.gclass190_0;
			GClass36 result;
			try
			{
				TaskAwaiter<GClass36> awaiter;
				if (num != 0)
				{
					GClass1 gclass1_ = new GClass1(this.string_0, this.gclass89_0, null, "standard", null, null);
					awaiter = gclass.imethod_0(gclass1_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass36>, GClass190.Struct65>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass36>);
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

		// Token: 0x06000870 RID: 2160 RVA: 0x00028D10 File Offset: 0x00026F10
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040004B4 RID: 1204
		public int int_0;

		// Token: 0x040004B5 RID: 1205
		public AsyncTaskMethodBuilder<GClass36> asyncTaskMethodBuilder_0;

		// Token: 0x040004B6 RID: 1206
		public string string_0;

		// Token: 0x040004B7 RID: 1207
		public GClass89 gclass89_0;

		// Token: 0x040004B8 RID: 1208
		public GClass190 gclass190_0;

		// Token: 0x040004B9 RID: 1209
		private TaskAwaiter<GClass36> taskAwaiter_0;
	}
}
