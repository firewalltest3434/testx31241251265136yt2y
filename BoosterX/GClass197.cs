using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Token: 0x0200060E RID: 1550
public sealed class GClass197 : GClass189, GInterface2
{
	// Token: 0x060021A4 RID: 8612 RVA: 0x00087E88 File Offset: 0x00086088
	internal GClass197(GClass178 gclass178_1) : base(gclass178_1)
	{
	}

	// Token: 0x060021A5 RID: 8613 RVA: 0x00087E94 File Offset: 0x00086094
	protected override string vmethod_0()
	{
		return "models";
	}

	// Token: 0x060021A6 RID: 8614 RVA: 0x00087E9C File Offset: 0x0008609C
	public Task<GClass89> imethod_0(string string_0)
	{
		GClass197.Struct363 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass89>.Create();
		@struct.gclass197_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass197.Struct363>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021A7 RID: 8615 RVA: 0x00087EE8 File Offset: 0x000860E8
	public Task<List<GClass89>> imethod_2()
	{
		GClass197.Struct361 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<GClass89>>.Create();
		@struct.gclass197_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass197.Struct361>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021A8 RID: 8616 RVA: 0x00087F2C File Offset: 0x0008612C
	[Obsolete("Use the overload without the APIAuthentication parameter instead, as custom auth is no longer used.", false)]
	public Task<GClass89> imethod_1(string string_0, GClass186 gclass186_0 = null)
	{
		GClass197.Struct362 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass89>.Create();
		@struct.gclass197_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass197.Struct362>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0200060F RID: 1551
	[StructLayout(LayoutKind.Auto)]
	private struct Struct361 : IAsyncStateMachine
	{
		// Token: 0x060021A9 RID: 8617 RVA: 0x00087F78 File Offset: 0x00086178
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass197 gclass = this.gclass197_0;
			List<GClass89> list_;
			try
			{
				TaskAwaiter<GClass197.Class257> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_7<GClass197.Class257>(null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass197.Class257>, GClass197.Struct361>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass197.Class257>);
					this.int_0 = -1;
				}
				list_ = awaiter.GetResult().List_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00088034 File Offset: 0x00086234
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001714 RID: 5908
		public int int_0;

		// Token: 0x04001715 RID: 5909
		public AsyncTaskMethodBuilder<List<GClass89>> asyncTaskMethodBuilder_0;

		// Token: 0x04001716 RID: 5910
		public GClass197 gclass197_0;

		// Token: 0x04001717 RID: 5911
		private TaskAwaiter<GClass197.Class257> taskAwaiter_0;
	}

	// Token: 0x02000610 RID: 1552
	private sealed class Class257 : GClass32
	{
		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x0008804C File Offset: 0x0008624C
		// (set) Token: 0x060021AD RID: 8621 RVA: 0x00088054 File Offset: 0x00086254
		[JsonProperty("data")]
		public List<GClass89> List_0
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x00088060 File Offset: 0x00086260
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x00088068 File Offset: 0x00086268
		[JsonProperty("object")]
		public string String_4
		{
			get
			{
				return this.string_4;
			}
			set
			{
				this.string_4 = value;
			}
		}

		// Token: 0x04001718 RID: 5912
		private List<GClass89> list_0;

		// Token: 0x04001719 RID: 5913
		private string string_4;
	}

	// Token: 0x02000611 RID: 1553
	[StructLayout(LayoutKind.Auto)]
	private struct Struct362 : IAsyncStateMachine
	{
		// Token: 0x060021B0 RID: 8624 RVA: 0x00088074 File Offset: 0x00086274
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass197 gclass = this.gclass197_0;
			GClass89 result;
			try
			{
				TaskAwaiter<GClass89> awaiter;
				if (num != 0)
				{
					awaiter = gclass.imethod_0(this.string_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass89>, GClass197.Struct362>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass89>);
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

		// Token: 0x060021B1 RID: 8625 RVA: 0x00088130 File Offset: 0x00086330
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400171A RID: 5914
		public int int_0;

		// Token: 0x0400171B RID: 5915
		public AsyncTaskMethodBuilder<GClass89> asyncTaskMethodBuilder_0;

		// Token: 0x0400171C RID: 5916
		public GClass197 gclass197_0;

		// Token: 0x0400171D RID: 5917
		public string string_0;

		// Token: 0x0400171E RID: 5918
		private TaskAwaiter<GClass89> taskAwaiter_0;
	}

	// Token: 0x02000612 RID: 1554
	[StructLayout(LayoutKind.Auto)]
	private struct Struct363 : IAsyncStateMachine
	{
		// Token: 0x060021B2 RID: 8626 RVA: 0x00088140 File Offset: 0x00086340
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass197 gclass = this.gclass197_0;
			GClass89 result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_4(gclass.method_0() + "/" + this.string_0, null, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass197.Struct363>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				result = JsonConvert.DeserializeObject<GClass89>(awaiter.GetResult());
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

		// Token: 0x060021B3 RID: 8627 RVA: 0x00088214 File Offset: 0x00086414
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400171F RID: 5919
		public int int_0;

		// Token: 0x04001720 RID: 5920
		public AsyncTaskMethodBuilder<GClass89> asyncTaskMethodBuilder_0;

		// Token: 0x04001721 RID: 5921
		public GClass197 gclass197_0;

		// Token: 0x04001722 RID: 5922
		public string string_0;

		// Token: 0x04001723 RID: 5923
		private TaskAwaiter<string> taskAwaiter_0;
	}
}
