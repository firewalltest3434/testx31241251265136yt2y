using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x02000593 RID: 1427
public sealed class GClass196 : GClass189, GInterface12
{
	// Token: 0x06001EC3 RID: 7875 RVA: 0x0007FE04 File Offset: 0x0007E004
	internal GClass196(GClass178 gclass178_1) : base(gclass178_1)
	{
	}

	// Token: 0x06001EC4 RID: 7876 RVA: 0x0007FE28 File Offset: 0x0007E028
	[CompilerGenerated]
	public GClass205 imethod_0()
	{
		return this.gclass205_0;
	}

	// Token: 0x06001EC5 RID: 7877 RVA: 0x0007FE30 File Offset: 0x0007E030
	[CompilerGenerated]
	public void imethod_1(GClass205 gclass205_1)
	{
		this.gclass205_0 = gclass205_1;
	}

	// Token: 0x06001EC6 RID: 7878 RVA: 0x0007FE3C File Offset: 0x0007E03C
	protected override string vmethod_0()
	{
		return "embeddings";
	}

	// Token: 0x06001EC7 RID: 7879 RVA: 0x0007FE44 File Offset: 0x0007E044
	public Task<GClass35> imethod_2(string string_0)
	{
		GClass196.Struct337 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass35>.Create();
		@struct.gclass196_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass196.Struct337>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001EC8 RID: 7880 RVA: 0x0007FE90 File Offset: 0x0007E090
	public Task<GClass35> imethod_3(GClass205 gclass205_1)
	{
		GClass196.Struct336 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass35>.Create();
		@struct.gclass196_0 = this;
		@struct.gclass205_0 = gclass205_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass196.Struct336>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001EC9 RID: 7881 RVA: 0x0007FEDC File Offset: 0x0007E0DC
	public Task<float[]> imethod_4(string string_0)
	{
		GClass196.Struct338 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<float[]>.Create();
		@struct.gclass196_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass196.Struct338>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04001597 RID: 5527
	private GClass205 gclass205_0 = new GClass205
	{
		String_0 = GClass89.smethod_25()
	};

	// Token: 0x02000594 RID: 1428
	[StructLayout(LayoutKind.Auto)]
	private struct Struct336 : IAsyncStateMachine
	{
		// Token: 0x06001ECA RID: 7882 RVA: 0x0007FF28 File Offset: 0x0007E128
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass196 gclass = this.gclass196_0;
			GClass35 result;
			try
			{
				TaskAwaiter<GClass35> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_8<GClass35>(null, this.gclass205_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass35>, GClass196.Struct336>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass35>);
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

		// Token: 0x06001ECB RID: 7883 RVA: 0x0007FFE8 File Offset: 0x0007E1E8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001598 RID: 5528
		public int int_0;

		// Token: 0x04001599 RID: 5529
		public AsyncTaskMethodBuilder<GClass35> asyncTaskMethodBuilder_0;

		// Token: 0x0400159A RID: 5530
		public GClass196 gclass196_0;

		// Token: 0x0400159B RID: 5531
		public GClass205 gclass205_0;

		// Token: 0x0400159C RID: 5532
		private TaskAwaiter<GClass35> taskAwaiter_0;
	}

	// Token: 0x02000595 RID: 1429
	[StructLayout(LayoutKind.Auto)]
	private struct Struct337 : IAsyncStateMachine
	{
		// Token: 0x06001ECC RID: 7884 RVA: 0x0007FFF8 File Offset: 0x0007E1F8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass196 gclass = this.gclass196_0;
			GClass35 result;
			try
			{
				TaskAwaiter<GClass35> awaiter;
				if (num != 0)
				{
					GClass205 gclass205_ = new GClass205(gclass.imethod_0().String_0, this.string_0);
					awaiter = gclass.imethod_3(gclass205_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass35>, GClass196.Struct337>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass35>);
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

		// Token: 0x06001ECD RID: 7885 RVA: 0x000800D0 File Offset: 0x0007E2D0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400159D RID: 5533
		public int int_0;

		// Token: 0x0400159E RID: 5534
		public AsyncTaskMethodBuilder<GClass35> asyncTaskMethodBuilder_0;

		// Token: 0x0400159F RID: 5535
		public GClass196 gclass196_0;

		// Token: 0x040015A0 RID: 5536
		public string string_0;

		// Token: 0x040015A1 RID: 5537
		private TaskAwaiter<GClass35> taskAwaiter_0;
	}

	// Token: 0x02000596 RID: 1430
	[StructLayout(LayoutKind.Auto)]
	private struct Struct338 : IAsyncStateMachine
	{
		// Token: 0x06001ECE RID: 7886 RVA: 0x000800E0 File Offset: 0x0007E2E0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass196 gclass = this.gclass196_0;
			float[] result2;
			try
			{
				TaskAwaiter<GClass35> awaiter;
				if (num != 0)
				{
					GClass205 gclass205_ = new GClass205(gclass.imethod_0().String_0, this.string_0);
					awaiter = gclass.imethod_3(gclass205_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass35>, GClass196.Struct338>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass35>);
					this.int_0 = -1;
				}
				GClass35 result = awaiter.GetResult();
				float[] array;
				if (result == null)
				{
					array = null;
				}
				else
				{
					List<GClass78> list_ = result.List_0;
					if (list_ == null)
					{
						array = null;
					}
					else
					{
						GClass78 gclass2 = list_[0];
						array = ((gclass2 != null) ? gclass2.Single_0 : null);
					}
				}
				result2 = array;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x000801DC File Offset: 0x0007E3DC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040015A2 RID: 5538
		public int int_0;

		// Token: 0x040015A3 RID: 5539
		public AsyncTaskMethodBuilder<float[]> asyncTaskMethodBuilder_0;

		// Token: 0x040015A4 RID: 5540
		public GClass196 gclass196_0;

		// Token: 0x040015A5 RID: 5541
		public string string_0;

		// Token: 0x040015A6 RID: 5542
		private TaskAwaiter<GClass35> taskAwaiter_0;
	}
}
