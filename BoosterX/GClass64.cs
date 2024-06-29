using System;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x0200024E RID: 590
public sealed class GClass64 : IDisposable
{
	// Token: 0x06000DC9 RID: 3529 RVA: 0x0003CB64 File Offset: 0x0003AD64
	public GClass64(string string_2, string string_3)
	{
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x0003CB7C File Offset: 0x0003AD7C
	private bool method_0()
	{
		return this.bool_0;
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x0003CB84 File Offset: 0x0003AD84
	private void method_1(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x0003CB90 File Offset: 0x0003AD90
	public void method_2(GClass64.GDelegate0 gdelegate0_1)
	{
		GClass64.GDelegate0 gdelegate = this.gdelegate0_0;
		GClass64.GDelegate0 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass64.GDelegate0 value = (GClass64.GDelegate0)Delegate.Combine(gdelegate2, gdelegate0_1);
			gdelegate = Interlocked.CompareExchange<GClass64.GDelegate0>(ref this.gdelegate0_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x0003CBC8 File Offset: 0x0003ADC8
	public void method_3(GClass64.GDelegate0 gdelegate0_1)
	{
		GClass64.GDelegate0 gdelegate = this.gdelegate0_0;
		GClass64.GDelegate0 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass64.GDelegate0 value = (GClass64.GDelegate0)Delegate.Remove(gdelegate2, gdelegate0_1);
			gdelegate = Interlocked.CompareExchange<GClass64.GDelegate0>(ref this.gdelegate0_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x0003CC00 File Offset: 0x0003AE00
	public Task method_4()
	{
		GClass64.Struct123 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass64_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass64.Struct123>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x0003CC44 File Offset: 0x0003AE44
	private Task method_5(HttpResponseMessage httpResponseMessage_0)
	{
		GClass64.Struct124 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass64_0 = this;
		@struct.httpResponseMessage_0 = httpResponseMessage_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass64.Struct124>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x0003CC90 File Offset: 0x0003AE90
	private Task method_6(long? nullable_0, Stream stream_0)
	{
		GClass64.Struct125 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass64_0 = this;
		@struct.nullable_0 = nullable_0;
		@struct.stream_0 = stream_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass64.Struct125>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x0003CCE4 File Offset: 0x0003AEE4
	public void Dispose()
	{
		HttpClient httpClient = this.httpClient_0;
		if (httpClient == null)
		{
			return;
		}
		httpClient.Dispose();
	}

	// Token: 0x04000872 RID: 2162
	private readonly string string_0;

	// Token: 0x04000873 RID: 2163
	private readonly string string_1;

	// Token: 0x04000874 RID: 2164
	private bool bool_0;

	// Token: 0x04000875 RID: 2165
	private HttpClient httpClient_0;

	// Token: 0x04000876 RID: 2166
	private GClass64.GDelegate0 gdelegate0_0;

	// Token: 0x0200024F RID: 591
	[StructLayout(LayoutKind.Auto)]
	private struct Struct123 : IAsyncStateMachine
	{
		// Token: 0x06000DD2 RID: 3538 RVA: 0x0003CCF8 File Offset: 0x0003AEF8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass64 gclass = this.gclass64_0;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_B0;
					}
					gclass.httpClient_0 = new HttpClient
					{
						Timeout = TimeSpan.FromDays(1.0)
					};
					awaiter = gclass.httpClient_0.GetAsync(gclass.string_0, HttpCompletionOption.ResponseHeadersRead).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass64.Struct123>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				HttpResponseMessage result = awaiter.GetResult();
				this.httpResponseMessage_0 = result;
				try
				{
					IL_B0:
					TaskAwaiter awaiter2;
					if (num != 1)
					{
						awaiter2 = gclass.method_5(this.httpResponseMessage_0).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num4 = 1;
							num = 1;
							this.int_0 = num4;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass64.Struct123>(ref awaiter2, ref this);
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
					if (num < 0 && this.httpResponseMessage_0 != null)
					{
						((IDisposable)this.httpResponseMessage_0).Dispose();
					}
				}
				this.httpResponseMessage_0 = null;
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

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0003CEB4 File Offset: 0x0003B0B4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000877 RID: 2167
		public int int_0;

		// Token: 0x04000878 RID: 2168
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000879 RID: 2169
		public GClass64 gclass64_0;

		// Token: 0x0400087A RID: 2170
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x0400087B RID: 2171
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400087C RID: 2172
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x02000250 RID: 592
	[StructLayout(LayoutKind.Auto)]
	private struct Struct124 : IAsyncStateMachine
	{
		// Token: 0x06000DD4 RID: 3540 RVA: 0x0003CEC4 File Offset: 0x0003B0C4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass64 gclass = this.gclass64_0;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_B6;
					}
					this.httpResponseMessage_0.EnsureSuccessStatusCode();
					this.nullable_0 = this.httpResponseMessage_0.Content.Headers.ContentLength;
					awaiter = this.httpResponseMessage_0.Content.ReadAsStreamAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass64.Struct124>(ref awaiter, ref this);
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
					IL_B6:
					TaskAwaiter awaiter2;
					if (num != 1)
					{
						awaiter2 = gclass.method_6(this.nullable_0, this.stream_0).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num4 = 1;
							num = 1;
							this.int_0 = num4;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass64.Struct124>(ref awaiter2, ref this);
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
					if (num < 0 && this.stream_0 != null)
					{
						((IDisposable)this.stream_0).Dispose();
					}
				}
				this.stream_0 = null;
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

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0003D08C File Offset: 0x0003B28C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400087D RID: 2173
		public int int_0;

		// Token: 0x0400087E RID: 2174
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400087F RID: 2175
		public HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04000880 RID: 2176
		public GClass64 gclass64_0;

		// Token: 0x04000881 RID: 2177
		private long? nullable_0;

		// Token: 0x04000882 RID: 2178
		private Stream stream_0;

		// Token: 0x04000883 RID: 2179
		private TaskAwaiter<Stream> taskAwaiter_0;

		// Token: 0x04000884 RID: 2180
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x02000251 RID: 593
	// (Invoke) Token: 0x06000DD7 RID: 3543
	public delegate bool GDelegate0(long? nullable_0, long long_0);

	// Token: 0x02000252 RID: 594
	[StructLayout(LayoutKind.Auto)]
	private struct Struct125 : IAsyncStateMachine
	{
		// Token: 0x06000DDA RID: 3546 RVA: 0x0003D09C File Offset: 0x0003B29C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass64 gclass = this.gclass64_0;
			try
			{
				if (num > 1)
				{
					this.long_0 = 0L;
					this.long_1 = 0L;
					this.byte_0 = new byte[8192];
					this.bool_0 = true;
					this.fileStream_0 = new FileStream(gclass.string_1, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true);
				}
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<int> awaiter2;
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_192;
						}
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_125;
					}
					else
					{
						awaiter2 = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<int>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					IL_B6:
					int result = awaiter2.GetResult();
					this.int_1 = result;
					if (this.int_1 == 0)
					{
						this.bool_0 = false;
						if (gclass.gdelegate0_0(this.nullable_0, this.long_0))
						{
							throw new OperationCanceledException();
						}
						goto IL_187;
					}
					else
					{
						awaiter = this.fileStream_0.WriteAsync(this.byte_0, 0, this.int_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num4 = 1;
							num = 1;
							this.int_0 = num4;
							this.taskAwaiter_1 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass64.Struct125>(ref awaiter, ref this);
							return;
						}
					}
					IL_125:
					awaiter.GetResult();
					this.long_0 += (long)this.int_1;
					this.long_1 += 1L;
					if (this.long_1 % 100L == 0L && gclass.gdelegate0_0(this.nullable_0, this.long_0))
					{
						throw new OperationCanceledException();
					}
					IL_187:
					if (!this.bool_0)
					{
						goto IL_22D;
					}
					IL_192:
					awaiter2 = this.stream_0.ReadAsync(this.byte_0, 0, this.byte_0.Length).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						int num5 = 0;
						num = 0;
						this.int_0 = num5;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<int>, GClass64.Struct125>(ref awaiter2, ref this);
						return;
					}
					goto IL_B6;
				}
				finally
				{
					if (num < 0 && this.fileStream_0 != null)
					{
						((IDisposable)this.fileStream_0).Dispose();
					}
				}
				IL_22D:
				this.fileStream_0 = null;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.byte_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.byte_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0003D354 File Offset: 0x0003B554
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000885 RID: 2181
		public int int_0;

		// Token: 0x04000886 RID: 2182
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000887 RID: 2183
		public GClass64 gclass64_0;

		// Token: 0x04000888 RID: 2184
		public Stream stream_0;

		// Token: 0x04000889 RID: 2185
		public long? nullable_0;

		// Token: 0x0400088A RID: 2186
		private long long_0;

		// Token: 0x0400088B RID: 2187
		private long long_1;

		// Token: 0x0400088C RID: 2188
		private byte[] byte_0;

		// Token: 0x0400088D RID: 2189
		private bool bool_0;

		// Token: 0x0400088E RID: 2190
		private FileStream fileStream_0;

		// Token: 0x0400088F RID: 2191
		private int int_1;

		// Token: 0x04000890 RID: 2192
		private TaskAwaiter<int> taskAwaiter_0;

		// Token: 0x04000891 RID: 2193
		private TaskAwaiter taskAwaiter_1;
	}
}
