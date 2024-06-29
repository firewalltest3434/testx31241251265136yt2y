using System;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020003F0 RID: 1008
public sealed class GClass194 : GClass189, GInterface0
{
	// Token: 0x060015FB RID: 5627 RVA: 0x0005C5E8 File Offset: 0x0005A7E8
	internal GClass194(GClass178 gclass178_1) : base(gclass178_1)
	{
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x0005C5FC File Offset: 0x0005A7FC
	protected override string vmethod_0()
	{
		return "audio/speech";
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x0005C604 File Offset: 0x0005A804
	[CompilerGenerated]
	public GClass167 imethod_0()
	{
		return this.gclass167_0;
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x0005C60C File Offset: 0x0005A80C
	[CompilerGenerated]
	public void imethod_1(GClass167 gclass167_1)
	{
		this.gclass167_0 = gclass167_1;
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x0005C618 File Offset: 0x0005A818
	public Task<Stream> imethod_2(GClass167 gclass167_1)
	{
		GClass194.Struct213 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Stream>.Create();
		@struct.gclass194_0 = this;
		@struct.gclass167_0 = gclass167_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass194.Struct213>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x0005C664 File Offset: 0x0005A864
	public Task<Stream> imethod_3(string string_0, string string_1 = null, double? nullable_0 = null, string string_2 = null, GClass89 gclass89_0 = null)
	{
		GClass194.Struct215 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Stream>.Create();
		@struct.gclass194_0 = this;
		@struct.string_0 = string_0;
		@struct.string_1 = string_1;
		@struct.nullable_0 = nullable_0;
		@struct.string_2 = string_2;
		@struct.gclass89_0 = gclass89_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass194.Struct215>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001601 RID: 5633 RVA: 0x0005C6D4 File Offset: 0x0005A8D4
	public Task<FileInfo> imethod_4(GClass167 gclass167_1, string string_0)
	{
		GClass194.Struct212 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<FileInfo>.Create();
		@struct.gclass194_0 = this;
		@struct.gclass167_0 = gclass167_1;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass194.Struct212>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x0005C728 File Offset: 0x0005A928
	public Task<FileInfo> imethod_5(string string_0, string string_1, string string_2 = null, double? nullable_0 = null, string string_3 = null, GClass89 gclass89_0 = null)
	{
		GClass194.Struct214 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<FileInfo>.Create();
		@struct.gclass194_0 = this;
		@struct.string_0 = string_0;
		@struct.string_3 = string_1;
		@struct.string_1 = string_2;
		@struct.nullable_0 = nullable_0;
		@struct.string_2 = string_3;
		@struct.gclass89_0 = gclass89_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass194.Struct214>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000ECD RID: 3789
	private GClass167 gclass167_0 = new GClass167();

	// Token: 0x020003F1 RID: 1009
	[StructLayout(LayoutKind.Auto)]
	private struct Struct212 : IAsyncStateMachine
	{
		// Token: 0x06001603 RID: 5635 RVA: 0x0005C7A0 File Offset: 0x0005A9A0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass194 gclass = this.gclass194_0;
			FileInfo result2;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_8B;
					}
					awaiter = gclass.imethod_2(this.gclass167_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass194.Struct212>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Stream>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				Stream result = awaiter.GetResult();
				this.stream_0 = result;
				try
				{
					IL_8B:
					if (num != 1)
					{
						this.fileStream_0 = new FileStream(this.string_0, FileMode.Create);
					}
					try
					{
						TaskAwaiter awaiter2;
						if (num != 1)
						{
							awaiter2 = this.stream_0.CopyToAsync(this.fileStream_0).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								this.int_0 = num4;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass194.Struct212>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
						}
						awaiter2.GetResult();
					}
					finally
					{
						if (num < 0 && this.fileStream_0 != null)
						{
							((IDisposable)this.fileStream_0).Dispose();
						}
					}
					this.fileStream_0 = null;
				}
				finally
				{
					if (num < 0 && this.stream_0 != null)
					{
						((IDisposable)this.stream_0).Dispose();
					}
				}
				this.stream_0 = null;
				result2 = new FileInfo(this.string_0);
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

		// Token: 0x06001604 RID: 5636 RVA: 0x0005C9A8 File Offset: 0x0005ABA8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000ECE RID: 3790
		public int int_0;

		// Token: 0x04000ECF RID: 3791
		public AsyncTaskMethodBuilder<FileInfo> asyncTaskMethodBuilder_0;

		// Token: 0x04000ED0 RID: 3792
		public GClass194 gclass194_0;

		// Token: 0x04000ED1 RID: 3793
		public GClass167 gclass167_0;

		// Token: 0x04000ED2 RID: 3794
		public string string_0;

		// Token: 0x04000ED3 RID: 3795
		private Stream stream_0;

		// Token: 0x04000ED4 RID: 3796
		private TaskAwaiter<Stream> taskAwaiter_0;

		// Token: 0x04000ED5 RID: 3797
		private FileStream fileStream_0;

		// Token: 0x04000ED6 RID: 3798
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020003F2 RID: 1010
	[StructLayout(LayoutKind.Auto)]
	private struct Struct213 : IAsyncStateMachine
	{
		// Token: 0x06001605 RID: 5637 RVA: 0x0005C9B8 File Offset: 0x0005ABB8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass194 gclass = this.gclass194_0;
			Stream result;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_5(null, HttpMethod.Post, this.gclass167_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass194.Struct213>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Stream>);
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

		// Token: 0x06001606 RID: 5638 RVA: 0x0005CA7C File Offset: 0x0005AC7C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000ED7 RID: 3799
		public int int_0;

		// Token: 0x04000ED8 RID: 3800
		public AsyncTaskMethodBuilder<Stream> asyncTaskMethodBuilder_0;

		// Token: 0x04000ED9 RID: 3801
		public GClass194 gclass194_0;

		// Token: 0x04000EDA RID: 3802
		public GClass167 gclass167_0;

		// Token: 0x04000EDB RID: 3803
		private TaskAwaiter<Stream> taskAwaiter_0;
	}

	// Token: 0x020003F3 RID: 1011
	[StructLayout(LayoutKind.Auto)]
	private struct Struct214 : IAsyncStateMachine
	{
		// Token: 0x06001607 RID: 5639 RVA: 0x0005CA8C File Offset: 0x0005AC8C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass194 gclass = this.gclass194_0;
			FileInfo result;
			try
			{
				TaskAwaiter<FileInfo> awaiter;
				if (num != 0)
				{
					GClass167 gclass2 = new GClass167();
					gclass2.String_1 = this.string_0;
					gclass2.String_2 = (this.string_1 ?? gclass.imethod_0().String_2);
					double? num2 = this.nullable_0;
					gclass2.Nullable_0 = ((num2 != null) ? num2 : gclass.imethod_0().Nullable_0);
					gclass2.String_0 = (this.gclass89_0 ?? gclass.imethod_0().String_0);
					gclass2.String_3 = (this.string_2 ?? gclass.imethod_0().String_3);
					GClass167 gclass167_ = gclass2;
					awaiter = gclass.imethod_4(gclass167_, this.string_3).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<FileInfo>, GClass194.Struct214>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<FileInfo>);
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

		// Token: 0x06001608 RID: 5640 RVA: 0x0005CBE4 File Offset: 0x0005ADE4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000EDC RID: 3804
		public int int_0;

		// Token: 0x04000EDD RID: 3805
		public AsyncTaskMethodBuilder<FileInfo> asyncTaskMethodBuilder_0;

		// Token: 0x04000EDE RID: 3806
		public string string_0;

		// Token: 0x04000EDF RID: 3807
		public string string_1;

		// Token: 0x04000EE0 RID: 3808
		public GClass194 gclass194_0;

		// Token: 0x04000EE1 RID: 3809
		public double? nullable_0;

		// Token: 0x04000EE2 RID: 3810
		public GClass89 gclass89_0;

		// Token: 0x04000EE3 RID: 3811
		public string string_2;

		// Token: 0x04000EE4 RID: 3812
		public string string_3;

		// Token: 0x04000EE5 RID: 3813
		private TaskAwaiter<FileInfo> taskAwaiter_0;
	}

	// Token: 0x020003F4 RID: 1012
	[StructLayout(LayoutKind.Auto)]
	private struct Struct215 : IAsyncStateMachine
	{
		// Token: 0x06001609 RID: 5641 RVA: 0x0005CBF4 File Offset: 0x0005ADF4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass194 gclass = this.gclass194_0;
			Stream result;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num != 0)
				{
					GClass167 gclass2 = new GClass167();
					gclass2.String_1 = this.string_0;
					gclass2.String_2 = (this.string_1 ?? gclass.imethod_0().String_2);
					double? num2 = this.nullable_0;
					gclass2.Nullable_0 = ((num2 != null) ? num2 : gclass.imethod_0().Nullable_0);
					gclass2.String_0 = (this.gclass89_0 ?? gclass.imethod_0().String_0);
					gclass2.String_3 = (this.string_2 ?? gclass.imethod_0().String_3);
					GClass167 object_ = gclass2;
					awaiter = gclass.method_5(null, HttpMethod.Post, object_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass194.Struct215>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Stream>);
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

		// Token: 0x0600160A RID: 5642 RVA: 0x0005CD4C File Offset: 0x0005AF4C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000EE6 RID: 3814
		public int int_0;

		// Token: 0x04000EE7 RID: 3815
		public AsyncTaskMethodBuilder<Stream> asyncTaskMethodBuilder_0;

		// Token: 0x04000EE8 RID: 3816
		public string string_0;

		// Token: 0x04000EE9 RID: 3817
		public string string_1;

		// Token: 0x04000EEA RID: 3818
		public GClass194 gclass194_0;

		// Token: 0x04000EEB RID: 3819
		public double? nullable_0;

		// Token: 0x04000EEC RID: 3820
		public GClass89 gclass89_0;

		// Token: 0x04000EED RID: 3821
		public string string_2;

		// Token: 0x04000EEE RID: 3822
		private TaskAwaiter<Stream> taskAwaiter_0;
	}
}
