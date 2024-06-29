using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Token: 0x02000627 RID: 1575
public sealed class GClass198 : GClass189, GInterface16
{
	// Token: 0x060021F9 RID: 8697 RVA: 0x0008A2B0 File Offset: 0x000884B0
	internal GClass198(GClass178 gclass178_1) : base(gclass178_1)
	{
	}

	// Token: 0x060021FA RID: 8698 RVA: 0x0008A2BC File Offset: 0x000884BC
	protected override string vmethod_0()
	{
		return "files";
	}

	// Token: 0x060021FB RID: 8699 RVA: 0x0008A2C4 File Offset: 0x000884C4
	public Task<List<GClass34>> imethod_0()
	{
		GClass198.Struct375 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<GClass34>>.Create();
		@struct.gclass198_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass198.Struct375>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x0008A308 File Offset: 0x00088508
	public Task<GClass34> imethod_1(string string_0)
	{
		GClass198.Struct376 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass34>.Create();
		@struct.gclass198_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass198.Struct376>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021FD RID: 8701 RVA: 0x0008A354 File Offset: 0x00088554
	public Task<string> imethod_2(string string_0)
	{
		GClass198.Struct374 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass198_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass198.Struct374>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x0008A3A0 File Offset: 0x000885A0
	public Task<GClass34> imethod_3(string string_0)
	{
		GClass198.Struct373 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass34>.Create();
		@struct.gclass198_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass198.Struct373>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x0008A3EC File Offset: 0x000885EC
	public Task<GClass34> imethod_4(string string_0, string string_1 = "fine-tune")
	{
		GClass198.Struct372 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass34>.Create();
		@struct.gclass198_0 = this;
		@struct.string_1 = string_0;
		@struct.string_0 = string_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass198.Struct372>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x02000628 RID: 1576
	[StructLayout(LayoutKind.Auto)]
	private struct Struct372 : IAsyncStateMachine
	{
		// Token: 0x06002200 RID: 8704 RVA: 0x0008A440 File Offset: 0x00088640
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass198 gclass = this.gclass198_0;
			GClass34 result;
			try
			{
				TaskAwaiter<GClass34> awaiter;
				if (num != 0)
				{
					MultipartFormDataContent object_ = new MultipartFormDataContent
					{
						{
							new StringContent(this.string_0),
							"purpose"
						},
						{
							new ByteArrayContent(File.ReadAllBytes(this.string_1)),
							"file",
							Path.GetFileName(this.string_1)
						}
					};
					awaiter = gclass.method_8<GClass34>(gclass.method_0(), object_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass34>, GClass198.Struct372>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass34>);
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

		// Token: 0x06002201 RID: 8705 RVA: 0x0008A544 File Offset: 0x00088744
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001786 RID: 6022
		public int int_0;

		// Token: 0x04001787 RID: 6023
		public AsyncTaskMethodBuilder<GClass34> asyncTaskMethodBuilder_0;

		// Token: 0x04001788 RID: 6024
		public string string_0;

		// Token: 0x04001789 RID: 6025
		public string string_1;

		// Token: 0x0400178A RID: 6026
		public GClass198 gclass198_0;

		// Token: 0x0400178B RID: 6027
		private TaskAwaiter<GClass34> taskAwaiter_0;
	}

	// Token: 0x02000629 RID: 1577
	private sealed class Class258 : GClass32
	{
		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x0008A55C File Offset: 0x0008875C
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x0008A564 File Offset: 0x00088764
		[JsonProperty("data")]
		public List<GClass34> List_0
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

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x0008A570 File Offset: 0x00088770
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x0008A578 File Offset: 0x00088778
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

		// Token: 0x0400178C RID: 6028
		private List<GClass34> list_0;

		// Token: 0x0400178D RID: 6029
		private string string_4;
	}

	// Token: 0x0200062A RID: 1578
	[StructLayout(LayoutKind.Auto)]
	private struct Struct373 : IAsyncStateMachine
	{
		// Token: 0x06002207 RID: 8711 RVA: 0x0008A584 File Offset: 0x00088784
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass198 gclass = this.gclass198_0;
			GClass34 result;
			try
			{
				TaskAwaiter<GClass34> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_9<GClass34>(gclass.method_0() + "/" + this.string_0, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass34>, GClass198.Struct373>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass34>);
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

		// Token: 0x06002208 RID: 8712 RVA: 0x0008A654 File Offset: 0x00088854
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400178E RID: 6030
		public int int_0;

		// Token: 0x0400178F RID: 6031
		public AsyncTaskMethodBuilder<GClass34> asyncTaskMethodBuilder_0;

		// Token: 0x04001790 RID: 6032
		public GClass198 gclass198_0;

		// Token: 0x04001791 RID: 6033
		public string string_0;

		// Token: 0x04001792 RID: 6034
		private TaskAwaiter<GClass34> taskAwaiter_0;
	}

	// Token: 0x0200062B RID: 1579
	[StructLayout(LayoutKind.Auto)]
	private struct Struct374 : IAsyncStateMachine
	{
		// Token: 0x06002209 RID: 8713 RVA: 0x0008A664 File Offset: 0x00088864
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass198 gclass = this.gclass198_0;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_4(gclass.method_0() + "/" + this.string_0 + "/content", null, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass198.Struct374>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
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

		// Token: 0x0600220A RID: 8714 RVA: 0x0008A738 File Offset: 0x00088938
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001793 RID: 6035
		public int int_0;

		// Token: 0x04001794 RID: 6036
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04001795 RID: 6037
		public GClass198 gclass198_0;

		// Token: 0x04001796 RID: 6038
		public string string_0;

		// Token: 0x04001797 RID: 6039
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x0200062C RID: 1580
	[StructLayout(LayoutKind.Auto)]
	private struct Struct375 : IAsyncStateMachine
	{
		// Token: 0x0600220B RID: 8715 RVA: 0x0008A748 File Offset: 0x00088948
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass198 gclass = this.gclass198_0;
			List<GClass34> list_;
			try
			{
				TaskAwaiter<GClass198.Class258> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_7<GClass198.Class258>(null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass198.Class258>, GClass198.Struct375>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass198.Class258>);
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

		// Token: 0x0600220C RID: 8716 RVA: 0x0008A804 File Offset: 0x00088A04
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001798 RID: 6040
		public int int_0;

		// Token: 0x04001799 RID: 6041
		public AsyncTaskMethodBuilder<List<GClass34>> asyncTaskMethodBuilder_0;

		// Token: 0x0400179A RID: 6042
		public GClass198 gclass198_0;

		// Token: 0x0400179B RID: 6043
		private TaskAwaiter<GClass198.Class258> taskAwaiter_0;
	}

	// Token: 0x0200062D RID: 1581
	[StructLayout(LayoutKind.Auto)]
	private struct Struct376 : IAsyncStateMachine
	{
		// Token: 0x0600220D RID: 8717 RVA: 0x0008A814 File Offset: 0x00088A14
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass198 gclass = this.gclass198_0;
			GClass34 result;
			try
			{
				TaskAwaiter<GClass34> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_7<GClass34>(gclass.method_0() + "/" + this.string_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass34>, GClass198.Struct376>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass34>);
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

		// Token: 0x0600220E RID: 8718 RVA: 0x0008A8E0 File Offset: 0x00088AE0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400179C RID: 6044
		public int int_0;

		// Token: 0x0400179D RID: 6045
		public AsyncTaskMethodBuilder<GClass34> asyncTaskMethodBuilder_0;

		// Token: 0x0400179E RID: 6046
		public GClass198 gclass198_0;

		// Token: 0x0400179F RID: 6047
		public string string_0;

		// Token: 0x040017A0 RID: 6048
		private TaskAwaiter<GClass34> taskAwaiter_0;
	}
}
