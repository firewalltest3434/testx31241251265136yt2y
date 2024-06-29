using System;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x0200030E RID: 782
public sealed class GClass193 : GClass189, GInterface9
{
	// Token: 0x06001219 RID: 4633 RVA: 0x0004A8C4 File Offset: 0x00048AC4
	internal GClass193(GClass178 gclass178_1, bool bool_1) : base(gclass178_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x0004A8E0 File Offset: 0x00048AE0
	protected override string vmethod_0()
	{
		if (this.method_12())
		{
			return "audio/translations";
		}
		return "audio/transcriptions";
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x0004A8F8 File Offset: 0x00048AF8
	[CompilerGenerated]
	public GClass83 imethod_0()
	{
		return this.gclass83_0;
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x0004A900 File Offset: 0x00048B00
	[CompilerGenerated]
	public void imethod_1(GClass83 gclass83_1)
	{
		this.gclass83_0 = gclass83_1;
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x0004A90C File Offset: 0x00048B0C
	private bool method_12()
	{
		return this.bool_0;
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x0004A914 File Offset: 0x00048B14
	public Task<string> imethod_6(Stream stream_0, string string_0, string string_1 = null, string string_2 = null, double? nullable_0 = null)
	{
		GClass193.Struct162 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass193_0 = this;
		@struct.stream_0 = stream_0;
		@struct.string_0 = string_0;
		@struct.string_1 = string_1;
		@struct.string_2 = string_2;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass193.Struct162>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x0004A984 File Offset: 0x00048B84
	public Task<string> imethod_7(string string_0, string string_1 = null, string string_2 = null, double? nullable_0 = null)
	{
		GClass193.Struct160 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass193_0 = this;
		@struct.string_0 = string_0;
		@struct.string_1 = string_1;
		@struct.string_2 = string_2;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass193.Struct160>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x0004A9E8 File Offset: 0x00048BE8
	public Task<GClass39> imethod_4(Stream stream_0, string string_0, string string_1 = null, string string_2 = null, double? nullable_0 = null)
	{
		GClass193.Struct159 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass39>.Create();
		@struct.gclass193_0 = this;
		@struct.stream_0 = stream_0;
		@struct.string_2 = string_0;
		@struct.string_0 = string_1;
		@struct.string_1 = string_2;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass193.Struct159>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x0004AA58 File Offset: 0x00048C58
	public Task<GClass39> imethod_5(string string_0, string string_1 = null, string string_2 = null, double? nullable_0 = null)
	{
		GClass193.Struct163 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass39>.Create();
		@struct.gclass193_0 = this;
		@struct.string_0 = string_0;
		@struct.string_1 = string_1;
		@struct.string_2 = string_2;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass193.Struct163>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x0004AABC File Offset: 0x00048CBC
	public Task<string> imethod_2(Stream stream_0, string string_0, string string_1, string string_2 = null, string string_3 = null, double? nullable_0 = null)
	{
		GClass193.Struct164 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass193_0 = this;
		@struct.stream_0 = stream_0;
		@struct.string_3 = string_0;
		@struct.string_2 = string_1;
		@struct.string_0 = string_2;
		@struct.string_1 = string_3;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass193.Struct164>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x0004AB34 File Offset: 0x00048D34
	public Task<string> imethod_3(string string_0, string string_1, string string_2 = null, string string_3 = null, double? nullable_0 = null)
	{
		GClass193.Struct161 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass193_0 = this;
		@struct.string_0 = string_0;
		@struct.string_1 = string_1;
		@struct.string_2 = string_2;
		@struct.string_3 = string_3;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass193.Struct161>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000AD9 RID: 2777
	private GClass83 gclass83_0 = new GClass83();

	// Token: 0x04000ADA RID: 2778
	private readonly bool bool_0;

	// Token: 0x0200030F RID: 783
	[StructLayout(LayoutKind.Auto)]
	private struct Struct159 : IAsyncStateMachine
	{
		// Token: 0x06001224 RID: 4644 RVA: 0x0004ABA4 File Offset: 0x00048DA4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass193 gclass = this.gclass193_0;
			GClass39 result;
			try
			{
				TaskAwaiter<GClass39> awaiter;
				if (num != 0)
				{
					GClass83 gclass2 = new GClass83
					{
						String_2 = (this.string_0 ?? gclass.imethod_0().String_2),
						String_0 = gclass.imethod_0().String_0,
						String_1 = (this.string_1 ?? gclass.imethod_0().String_1),
						Double_0 = (this.nullable_0 ?? gclass.imethod_0().Double_0)
					};
					gclass2.String_3 = "verbose_json";
					MemoryStream memoryStream = new MemoryStream();
					MultipartFormDataContent multipartFormDataContent;
					try
					{
						this.stream_0.CopyTo(memoryStream);
						multipartFormDataContent = new MultipartFormDataContent
						{
							{
								new StringContent(gclass2.String_0),
								"model"
							},
							{
								new StringContent(gclass2.String_3),
								"response_format"
							},
							{
								new ByteArrayContent(memoryStream.ToArray()),
								"file",
								this.string_2
							}
						};
						if (!string.IsNullOrEmpty(gclass2.String_2))
						{
							multipartFormDataContent.Add(new StringContent(gclass2.String_2), "language");
						}
						if (!string.IsNullOrEmpty(gclass2.String_1))
						{
							multipartFormDataContent.Add(new StringContent(gclass2.String_1), "prompt");
						}
						if (gclass2.Double_0 != 0.0)
						{
							multipartFormDataContent.Add(new StringContent(gclass2.Double_0.ToString()), "temperature");
						}
					}
					finally
					{
						if (num < 0 && memoryStream != null)
						{
							((IDisposable)memoryStream).Dispose();
						}
					}
					awaiter = gclass.method_8<GClass39>(gclass.method_0(), multipartFormDataContent).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass39>, GClass193.Struct159>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass39>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
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

		// Token: 0x06001225 RID: 4645 RVA: 0x0004AE28 File Offset: 0x00049028
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000ADB RID: 2779
		public int int_0;

		// Token: 0x04000ADC RID: 2780
		public AsyncTaskMethodBuilder<GClass39> asyncTaskMethodBuilder_0;

		// Token: 0x04000ADD RID: 2781
		public string string_0;

		// Token: 0x04000ADE RID: 2782
		public GClass193 gclass193_0;

		// Token: 0x04000ADF RID: 2783
		public string string_1;

		// Token: 0x04000AE0 RID: 2784
		public double? nullable_0;

		// Token: 0x04000AE1 RID: 2785
		public Stream stream_0;

		// Token: 0x04000AE2 RID: 2786
		public string string_2;

		// Token: 0x04000AE3 RID: 2787
		private TaskAwaiter<GClass39> taskAwaiter_0;
	}

	// Token: 0x02000310 RID: 784
	[StructLayout(LayoutKind.Auto)]
	private struct Struct160 : IAsyncStateMachine
	{
		// Token: 0x06001226 RID: 4646 RVA: 0x0004AE38 File Offset: 0x00049038
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass193 gclass = this.gclass193_0;
			string result;
			try
			{
				if (num != 0)
				{
					this.fileStream_0 = File.OpenRead(this.string_0);
				}
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = gclass.imethod_6(this.fileStream_0, Path.GetFileName(this.string_0), this.string_1, this.string_2, this.nullable_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass193.Struct160>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<string>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					result = awaiter.GetResult();
				}
				finally
				{
					if (num < 0 && this.fileStream_0 != null)
					{
						((IDisposable)this.fileStream_0).Dispose();
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

		// Token: 0x06001227 RID: 4647 RVA: 0x0004AF64 File Offset: 0x00049164
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000AE4 RID: 2788
		public int int_0;

		// Token: 0x04000AE5 RID: 2789
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000AE6 RID: 2790
		public string string_0;

		// Token: 0x04000AE7 RID: 2791
		public GClass193 gclass193_0;

		// Token: 0x04000AE8 RID: 2792
		public string string_1;

		// Token: 0x04000AE9 RID: 2793
		public string string_2;

		// Token: 0x04000AEA RID: 2794
		public double? nullable_0;

		// Token: 0x04000AEB RID: 2795
		private FileStream fileStream_0;

		// Token: 0x04000AEC RID: 2796
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x02000311 RID: 785
	[StructLayout(LayoutKind.Auto)]
	private struct Struct161 : IAsyncStateMachine
	{
		// Token: 0x06001228 RID: 4648 RVA: 0x0004AF74 File Offset: 0x00049174
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass193 gclass = this.gclass193_0;
			string result;
			try
			{
				if (num != 0)
				{
					this.fileStream_0 = File.OpenRead(this.string_0);
				}
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = gclass.imethod_2(this.fileStream_0, Path.GetFileName(this.string_0), this.string_1, this.string_2, this.string_3, this.nullable_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass193.Struct161>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<string>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					result = awaiter.GetResult();
				}
				finally
				{
					if (num < 0 && this.fileStream_0 != null)
					{
						((IDisposable)this.fileStream_0).Dispose();
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

		// Token: 0x06001229 RID: 4649 RVA: 0x0004B0A4 File Offset: 0x000492A4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000AED RID: 2797
		public int int_0;

		// Token: 0x04000AEE RID: 2798
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000AEF RID: 2799
		public string string_0;

		// Token: 0x04000AF0 RID: 2800
		public GClass193 gclass193_0;

		// Token: 0x04000AF1 RID: 2801
		public string string_1;

		// Token: 0x04000AF2 RID: 2802
		public string string_2;

		// Token: 0x04000AF3 RID: 2803
		public string string_3;

		// Token: 0x04000AF4 RID: 2804
		public double? nullable_0;

		// Token: 0x04000AF5 RID: 2805
		private FileStream fileStream_0;

		// Token: 0x04000AF6 RID: 2806
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x02000312 RID: 786
	[StructLayout(LayoutKind.Auto)]
	private struct Struct162 : IAsyncStateMachine
	{
		// Token: 0x0600122A RID: 4650 RVA: 0x0004B0B4 File Offset: 0x000492B4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass193 gclass = this.gclass193_0;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = gclass.imethod_2(this.stream_0, this.string_0, "text", this.string_1, this.string_2, this.nullable_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass193.Struct162>(ref awaiter, ref this);
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

		// Token: 0x0600122B RID: 4651 RVA: 0x0004B190 File Offset: 0x00049390
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000AF7 RID: 2807
		public int int_0;

		// Token: 0x04000AF8 RID: 2808
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000AF9 RID: 2809
		public GClass193 gclass193_0;

		// Token: 0x04000AFA RID: 2810
		public Stream stream_0;

		// Token: 0x04000AFB RID: 2811
		public string string_0;

		// Token: 0x04000AFC RID: 2812
		public string string_1;

		// Token: 0x04000AFD RID: 2813
		public string string_2;

		// Token: 0x04000AFE RID: 2814
		public double? nullable_0;

		// Token: 0x04000AFF RID: 2815
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x02000313 RID: 787
	[StructLayout(LayoutKind.Auto)]
	private struct Struct163 : IAsyncStateMachine
	{
		// Token: 0x0600122C RID: 4652 RVA: 0x0004B1A0 File Offset: 0x000493A0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass193 gclass = this.gclass193_0;
			GClass39 result;
			try
			{
				if (num != 0)
				{
					this.fileStream_0 = File.OpenRead(this.string_0);
				}
				try
				{
					TaskAwaiter<GClass39> awaiter;
					if (num != 0)
					{
						awaiter = gclass.imethod_4(this.fileStream_0, Path.GetFileName(this.string_0), this.string_1, this.string_2, this.nullable_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass39>, GClass193.Struct163>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass39>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					result = awaiter.GetResult();
				}
				finally
				{
					if (num < 0 && this.fileStream_0 != null)
					{
						((IDisposable)this.fileStream_0).Dispose();
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

		// Token: 0x0600122D RID: 4653 RVA: 0x0004B2CC File Offset: 0x000494CC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B00 RID: 2816
		public int int_0;

		// Token: 0x04000B01 RID: 2817
		public AsyncTaskMethodBuilder<GClass39> asyncTaskMethodBuilder_0;

		// Token: 0x04000B02 RID: 2818
		public string string_0;

		// Token: 0x04000B03 RID: 2819
		public GClass193 gclass193_0;

		// Token: 0x04000B04 RID: 2820
		public string string_1;

		// Token: 0x04000B05 RID: 2821
		public string string_2;

		// Token: 0x04000B06 RID: 2822
		public double? nullable_0;

		// Token: 0x04000B07 RID: 2823
		private FileStream fileStream_0;

		// Token: 0x04000B08 RID: 2824
		private TaskAwaiter<GClass39> taskAwaiter_0;
	}

	// Token: 0x02000314 RID: 788
	[StructLayout(LayoutKind.Auto)]
	private struct Struct164 : IAsyncStateMachine
	{
		// Token: 0x0600122E RID: 4654 RVA: 0x0004B2DC File Offset: 0x000494DC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass193 gclass = this.gclass193_0;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					GClass83 gclass2 = new GClass83
					{
						String_2 = (this.string_0 ?? gclass.imethod_0().String_2),
						String_0 = gclass.imethod_0().String_0,
						String_1 = (this.string_1 ?? gclass.imethod_0().String_1),
						Double_0 = (this.nullable_0 ?? gclass.imethod_0().Double_0),
						String_3 = (this.string_2 ?? gclass.imethod_0().String_3)
					};
					MemoryStream memoryStream = new MemoryStream();
					MultipartFormDataContent multipartFormDataContent;
					try
					{
						this.stream_0.CopyTo(memoryStream);
						multipartFormDataContent = new MultipartFormDataContent
						{
							{
								new StringContent(gclass2.String_0),
								"model"
							},
							{
								new StringContent(gclass2.String_3),
								"response_format"
							},
							{
								new ByteArrayContent(memoryStream.ToArray()),
								"file",
								this.string_3
							}
						};
						if (!string.IsNullOrEmpty(gclass2.String_2))
						{
							multipartFormDataContent.Add(new StringContent(gclass2.String_2), "language");
						}
						if (!string.IsNullOrEmpty(gclass2.String_1))
						{
							multipartFormDataContent.Add(new StringContent(gclass2.String_1), "prompt");
						}
						if (gclass2.Double_0 != 0.0)
						{
							multipartFormDataContent.Add(new StringContent(gclass2.Double_0.ToString()), "temperature");
						}
					}
					finally
					{
						if (num < 0 && memoryStream != null)
						{
							((IDisposable)memoryStream).Dispose();
						}
					}
					awaiter = gclass.method_4(gclass.method_0(), HttpMethod.Post, multipartFormDataContent).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass193.Struct164>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
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

		// Token: 0x0600122F RID: 4655 RVA: 0x0004B578 File Offset: 0x00049778
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B09 RID: 2825
		public int int_0;

		// Token: 0x04000B0A RID: 2826
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000B0B RID: 2827
		public string string_0;

		// Token: 0x04000B0C RID: 2828
		public GClass193 gclass193_0;

		// Token: 0x04000B0D RID: 2829
		public string string_1;

		// Token: 0x04000B0E RID: 2830
		public double? nullable_0;

		// Token: 0x04000B0F RID: 2831
		public string string_2;

		// Token: 0x04000B10 RID: 2832
		public Stream stream_0;

		// Token: 0x04000B11 RID: 2833
		public string string_3;

		// Token: 0x04000B12 RID: 2834
		private TaskAwaiter<string> taskAwaiter_0;
	}
}
