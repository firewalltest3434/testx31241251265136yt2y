using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Newtonsoft.Json;

// Token: 0x02000619 RID: 1561
public abstract class GClass189
{
	// Token: 0x060021C1 RID: 8641 RVA: 0x000889EC File Offset: 0x00086BEC
	internal GClass189(GClass178 gclass178_1)
	{
		this.gclass178_0 = gclass178_1;
	}

	// Token: 0x060021C2 RID: 8642
	protected abstract string vmethod_0();

	// Token: 0x060021C3 RID: 8643 RVA: 0x000889FC File Offset: 0x00086BFC
	protected string method_0()
	{
		if (Class245.bool_0)
		{
			return string.Format(this.gclass178_0.method_2(), this.gclass178_0.imethod_2(), this.vmethod_0());
		}
		return string.Format(this.gclass178_0.imethod_0(), this.gclass178_0.imethod_2(), this.vmethod_0());
	}

	// Token: 0x060021C4 RID: 8644 RVA: 0x00088A54 File Offset: 0x00086C54
	protected HttpClient method_1()
	{
		GClass186 gclass = this.gclass178_0.imethod_4();
		if (((gclass != null) ? gclass.method_0() : null) == null)
		{
			throw new AuthenticationException("You must provide API authentication.  Please refer to https://github.com/OkGoDoIt/OpenAI-API-dotnet#authentication for details.");
		}
		IHttpClientFactory httpClientFactory = this.gclass178_0.method_4();
		HttpClient httpClient;
		if (httpClientFactory != null)
		{
			httpClient = HttpClientFactoryExtensions.CreateClient(httpClientFactory);
		}
		else
		{
			httpClient = new HttpClient();
		}
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.gclass178_0.imethod_4().method_0());
		httpClient.DefaultRequestHeaders.Add("api-key", this.gclass178_0.imethod_4().method_0());
		httpClient.DefaultRequestHeaders.Add("User-Agent", "okgodoit/dotnet_openai_api");
		if (!string.IsNullOrEmpty(this.gclass178_0.imethod_4().method_2()))
		{
			httpClient.DefaultRequestHeaders.Add("OpenAI-Organization", this.gclass178_0.imethod_4().method_2());
		}
		return httpClient;
	}

	// Token: 0x060021C5 RID: 8645 RVA: 0x00088B38 File Offset: 0x00086D38
	protected string method_2(string string_0, HttpResponseMessage httpResponseMessage_0, string string_1, string string_2)
	{
		return string.Format("Error at {0} ({1}) with HTTP status code: {2}. Content: {3}", new object[]
		{
			string_1,
			string_2,
			httpResponseMessage_0.StatusCode,
			string_0 ?? "<no content>"
		});
	}

	// Token: 0x060021C6 RID: 8646 RVA: 0x00088B70 File Offset: 0x00086D70
	private Task<HttpResponseMessage> method_3(string string_0, HttpMethod httpMethod_0, object object_0, bool bool_0)
	{
		GClass189.Struct369 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		@struct.gclass189_0 = this;
		@struct.string_0 = string_0;
		@struct.httpMethod_0 = httpMethod_0;
		@struct.object_0 = object_0;
		@struct.bool_0 = bool_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass189.Struct369>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021C7 RID: 8647 RVA: 0x00088BD4 File Offset: 0x00086DD4
	internal Task<string> method_4(string string_0, HttpMethod httpMethod_0, object object_0)
	{
		GClass189.Struct371 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass189_0 = this;
		@struct.string_0 = string_0;
		@struct.httpMethod_0 = httpMethod_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass189.Struct371>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021C8 RID: 8648 RVA: 0x00088C30 File Offset: 0x00086E30
	internal Task<Stream> method_5(string string_0, HttpMethod httpMethod_0, object object_0)
	{
		GClass189.Struct364 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Stream>.Create();
		@struct.gclass189_0 = this;
		@struct.string_0 = string_0;
		@struct.httpMethod_0 = httpMethod_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass189.Struct364>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021C9 RID: 8649 RVA: 0x00088C8C File Offset: 0x00086E8C
	private Task<GClass32> method_6<GClass32>(string string_0, HttpMethod httpMethod_0, object object_0) where GClass32 : GClass32
	{
		GClass189.Struct365<GClass32> @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass32>.Create();
		@struct.gclass189_0 = this;
		@struct.string_0 = string_0;
		@struct.httpMethod_0 = httpMethod_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass189.Struct365<GClass32>>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021CA RID: 8650 RVA: 0x00088CE8 File Offset: 0x00086EE8
	internal Task<GClass32> method_7<GClass32>(string string_0) where GClass32 : GClass32
	{
		GClass189.Struct367<GClass32> @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass32>.Create();
		@struct.gclass189_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass189.Struct367<GClass32>>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021CB RID: 8651 RVA: 0x00088D34 File Offset: 0x00086F34
	internal Task<GClass32> method_8<GClass32>(string string_0, object object_0) where GClass32 : GClass32
	{
		GClass189.Struct370<GClass32> @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass32>.Create();
		@struct.gclass189_0 = this;
		@struct.string_0 = string_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass189.Struct370<GClass32>>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021CC RID: 8652 RVA: 0x00088D88 File Offset: 0x00086F88
	internal Task<GClass32> method_9<GClass32>(string string_0, object object_0) where GClass32 : GClass32
	{
		GClass189.Struct368<GClass32> @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass32>.Create();
		@struct.gclass189_0 = this;
		@struct.string_0 = string_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass189.Struct368<GClass32>>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021CD RID: 8653 RVA: 0x00088DDC File Offset: 0x00086FDC
	internal Task<GClass32> method_10<GClass32>(string string_0, object object_0) where GClass32 : GClass32
	{
		GClass189.Struct366<GClass32> @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass32>.Create();
		@struct.gclass189_0 = this;
		@struct.string_0 = string_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass189.Struct366<GClass32>>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021CE RID: 8654 RVA: 0x00088E30 File Offset: 0x00087030
	[AsyncIteratorStateMachine]
	protected IAsyncEnumerable<GClass32> method_11<GClass32>(string string_0, HttpMethod httpMethod_0, object object_0) where GClass32 : GClass32
	{
		return new GClass189.Class697<GClass32>(-2)
		{
			gclass189_0 = this,
			string_1 = string_0,
			httpMethod_1 = httpMethod_0,
			object_1 = object_0
		};
	}

	// Token: 0x0400172C RID: 5932
	protected readonly GClass178 gclass178_0;

	// Token: 0x0200061A RID: 1562
	private sealed class Class697<GClass32> : IValueTaskSource<bool>, IAsyncEnumerable<GClass32>, IAsyncEnumerator<GClass32>, IAsyncStateMachine, IAsyncDisposable, IValueTaskSource where GClass32 : global::GClass32
	{
		// Token: 0x060021CF RID: 8655 RVA: 0x00088E58 File Offset: 0x00087058
		public Class697(int int_2)
		{
			this.asyncIteratorMethodBuilder_0 = AsyncIteratorMethodBuilder.Create();
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00088E80 File Offset: 0x00087080
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass189 gclass = this.gclass189_0;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter2;
				TaskAwaiter<Stream> awaiter3;
				switch (num)
				{
				case -4:
				case 2:
					IL_20A:
					try
					{
						if (num != -4 && num != 2)
						{
							this.streamReader_0 = new StreamReader(this.stream_0);
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num == -4)
							{
								int num2 = -1;
								num = -1;
								this.int_0 = num2;
								if (!this.bool_0)
								{
									goto IL_2F1;
								}
								goto IL_3D5;
							}
							else
							{
								if (num != 2)
								{
									goto IL_2F1;
								}
								awaiter = this.taskAwaiter_2;
								this.taskAwaiter_2 = default(TaskAwaiter<string>);
								int num3 = -1;
								num = -1;
								this.int_0 = num3;
							}
							IL_27D:
							string text;
							if ((text = awaiter.GetResult()) == null)
							{
								goto IL_3D5;
							}
							this.string_6 = this.string_6 + text + Environment.NewLine;
							if (text.StartsWith("data:"))
							{
								text = text.Substring(5);
							}
							text = text.TrimStart(Array.Empty<char>());
							if (text == "[DONE]")
							{
								this.bool_0 = true;
								goto IL_3D5;
							}
							if (!text.StartsWith(":") && !string.IsNullOrWhiteSpace(text))
							{
								GClass32 gclass2 = JsonConvert.DeserializeObject<GClass32>(text);
								gclass2.String_1 = this.string_2;
								gclass2.String_2 = this.string_3;
								gclass2.TimeSpan_0 = this.timeSpan_0;
								gclass2.String_3 = this.string_4;
								if (string.IsNullOrEmpty(gclass2.GClass89_0))
								{
									gclass2.GClass89_0 = this.string_5;
								}
								this.gparam_0 = gclass2;
								int num4 = -4;
								num = -4;
								this.int_0 = num4;
								goto IL_47C;
							}
							IL_2F1:
							awaiter = this.streamReader_0.ReadLineAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 2;
								num = 2;
								this.int_0 = num5;
								this.taskAwaiter_2 = awaiter;
								GClass189.Class697<GClass32> @class = this;
								this.asyncIteratorMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass189.Class697<GClass32>>(ref awaiter, ref @class);
								return;
							}
							goto IL_27D;
							IL_3D5:;
						}
						finally
						{
							if (num == -1 && this.streamReader_0 != null)
							{
								((IDisposable)this.streamReader_0).Dispose();
							}
						}
						if (!this.bool_0)
						{
							this.streamReader_0 = null;
						}
					}
					finally
					{
						if (num == -1 && this.stream_0 != null)
						{
							((IDisposable)this.stream_0).Dispose();
						}
					}
					if (this.bool_0)
					{
						goto IL_489;
					}
					this.stream_0 = null;
					goto IL_489;
				default:
				{
					if (this.bool_0)
					{
						goto IL_489;
					}
					int num6 = -1;
					num = -1;
					this.int_0 = num6;
					awaiter2 = gclass.method_3(this.string_0, this.httpMethod_0, this.object_0, true).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						int num7 = 0;
						num = 0;
						this.int_0 = num7;
						this.taskAwaiter_0 = awaiter2;
						GClass189.Class697<GClass32> @class = this;
						this.asyncIteratorMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass189.Class697<GClass32>>(ref awaiter2, ref @class);
						return;
					}
					break;
				}
				case 0:
				{
					awaiter2 = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					int num8 = -1;
					num = -1;
					this.int_0 = num8;
					break;
				}
				case 1:
				{
					awaiter3 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<Stream>);
					int num9 = -1;
					num = -1;
					this.int_0 = num9;
					goto IL_1F9;
				}
				}
				HttpResponseMessage result = awaiter2.GetResult();
				this.string_2 = null;
				this.string_3 = null;
				this.timeSpan_0 = TimeSpan.Zero;
				this.string_4 = null;
				this.string_5 = null;
				try
				{
					this.string_2 = result.Headers.GetValues("Openai-Organization").FirstOrDefault<string>();
					this.string_3 = result.Headers.GetValues("X-Request-ID").FirstOrDefault<string>();
					this.timeSpan_0 = TimeSpan.FromMilliseconds((double)int.Parse(result.Headers.GetValues("Openai-Processing-Ms").First<string>()));
					this.string_4 = result.Headers.GetValues("Openai-Version").FirstOrDefault<string>();
					this.string_5 = result.Headers.GetValues("Openai-Model").FirstOrDefault<string>();
				}
				catch (Exception ex)
				{
				}
				this.string_6 = string.Empty;
				awaiter3 = result.Content.ReadAsStreamAsync().GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num10 = 1;
					num = 1;
					this.int_0 = num10;
					this.taskAwaiter_1 = awaiter3;
					GClass189.Class697<GClass32> @class = this;
					this.asyncIteratorMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass189.Class697<GClass32>>(ref awaiter3, ref @class);
					return;
				}
				IL_1F9:
				Stream result2 = awaiter3.GetResult();
				this.stream_0 = result2;
				goto IL_20A;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.gparam_0 = default(GClass32);
				this.asyncIteratorMethodBuilder_0.Complete();
				this.manualResetValueTaskSourceCore_0.SetException(exception);
				return;
			}
			IL_47C:
			this.manualResetValueTaskSourceCore_0.SetResult(true);
			return;
			IL_489:
			this.int_0 = -2;
			this.gparam_0 = default(GClass32);
			this.asyncIteratorMethodBuilder_0.Complete();
			this.manualResetValueTaskSourceCore_0.SetResult(false);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x000893A8 File Offset: 0x000875A8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000893AC File Offset: 0x000875AC
		[return: Attribute8(new byte[]
		{
			1,
			0
		})]
		IAsyncEnumerator<GClass32> IAsyncEnumerable<!0>.GetAsyncEnumerator(CancellationToken cancellationToken_0)
		{
			GClass189.Class697<GClass32> @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = -3;
				this.asyncIteratorMethodBuilder_0 = AsyncIteratorMethodBuilder.Create();
				this.bool_0 = false;
				@class = this;
			}
			else
			{
				@class = new GClass189.Class697<GClass32>(-3);
				@class.gclass189_0 = this.gclass189_0;
			}
			@class.string_0 = this.string_1;
			@class.httpMethod_0 = this.httpMethod_1;
			@class.object_0 = this.object_1;
			return @class;
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00089428 File Offset: 0x00087628
		ValueTask<bool> IAsyncEnumerator<!0>.MoveNextAsync()
		{
			if (this.int_0 == -2)
			{
				return default(ValueTask<bool>);
			}
			this.manualResetValueTaskSourceCore_0.Reset();
			GClass189.Class697<GClass32> @class = this;
			this.asyncIteratorMethodBuilder_0.MoveNext<GClass189.Class697<GClass32>>(ref @class);
			short version = this.manualResetValueTaskSourceCore_0.Version;
			if (this.manualResetValueTaskSourceCore_0.GetStatus(version) == 1)
			{
				return new ValueTask<bool>(this.manualResetValueTaskSourceCore_0.GetResult(version));
			}
			return new ValueTask<bool>(this, version);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00089498 File Offset: 0x00087698
		GClass32 IAsyncEnumerator<!0>.get_Current()
		{
			return this.gparam_0;
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x000894A0 File Offset: 0x000876A0
		bool IValueTaskSource<bool>.GetResult(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetResult(short_0);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x000894B0 File Offset: 0x000876B0
		ValueTaskSourceStatus IValueTaskSource<bool>.GetStatus(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetStatus(short_0);
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x000894C0 File Offset: 0x000876C0
		void IValueTaskSource<bool>.OnCompleted(Action<object> action_0, object object_2, short short_0, ValueTaskSourceOnCompletedFlags valueTaskSourceOnCompletedFlags_0)
		{
			this.manualResetValueTaskSourceCore_0.OnCompleted(action_0, object_2, short_0, valueTaskSourceOnCompletedFlags_0);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x000894D4 File Offset: 0x000876D4
		void IValueTaskSource.GetResult(short short_0)
		{
			this.manualResetValueTaskSourceCore_0.GetResult(short_0);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000894E4 File Offset: 0x000876E4
		ValueTaskSourceStatus IValueTaskSource.GetStatus(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetStatus(short_0);
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x000894F4 File Offset: 0x000876F4
		void IValueTaskSource.OnCompleted(Action<object> action_0, object object_2, short short_0, ValueTaskSourceOnCompletedFlags valueTaskSourceOnCompletedFlags_0)
		{
			this.manualResetValueTaskSourceCore_0.OnCompleted(action_0, object_2, short_0, valueTaskSourceOnCompletedFlags_0);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x00089508 File Offset: 0x00087708
		ValueTask IAsyncDisposable.DisposeAsync()
		{
			if (this.int_0 >= -1)
			{
				throw new NotSupportedException();
			}
			if (this.int_0 == -2)
			{
				return default(ValueTask);
			}
			this.bool_0 = true;
			this.manualResetValueTaskSourceCore_0.Reset();
			GClass189.Class697<GClass32> @class = this;
			this.asyncIteratorMethodBuilder_0.MoveNext<GClass189.Class697<GClass32>>(ref @class);
			return new ValueTask(this, this.manualResetValueTaskSourceCore_0.Version);
		}

		// Token: 0x0400172D RID: 5933
		public int int_0;

		// Token: 0x0400172E RID: 5934
		public AsyncIteratorMethodBuilder asyncIteratorMethodBuilder_0;

		// Token: 0x0400172F RID: 5935
		public ManualResetValueTaskSourceCore<bool> manualResetValueTaskSourceCore_0;

		// Token: 0x04001730 RID: 5936
		private GClass32 gparam_0;

		// Token: 0x04001731 RID: 5937
		private bool bool_0;

		// Token: 0x04001732 RID: 5938
		private int int_1;

		// Token: 0x04001733 RID: 5939
		public GClass189 gclass189_0;

		// Token: 0x04001734 RID: 5940
		private string string_0;

		// Token: 0x04001735 RID: 5941
		public string string_1;

		// Token: 0x04001736 RID: 5942
		private HttpMethod httpMethod_0;

		// Token: 0x04001737 RID: 5943
		public HttpMethod httpMethod_1;

		// Token: 0x04001738 RID: 5944
		private object object_0;

		// Token: 0x04001739 RID: 5945
		public object object_1;

		// Token: 0x0400173A RID: 5946
		private string string_2;

		// Token: 0x0400173B RID: 5947
		private string string_3;

		// Token: 0x0400173C RID: 5948
		private TimeSpan timeSpan_0;

		// Token: 0x0400173D RID: 5949
		private string string_4;

		// Token: 0x0400173E RID: 5950
		private string string_5;

		// Token: 0x0400173F RID: 5951
		private string string_6;

		// Token: 0x04001740 RID: 5952
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001741 RID: 5953
		private Stream stream_0;

		// Token: 0x04001742 RID: 5954
		private TaskAwaiter<Stream> taskAwaiter_1;

		// Token: 0x04001743 RID: 5955
		private StreamReader streamReader_0;

		// Token: 0x04001744 RID: 5956
		private TaskAwaiter<string> taskAwaiter_2;
	}

	// Token: 0x0200061B RID: 1563
	internal sealed class Class698
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x0008957C File Offset: 0x0008777C
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x00089584 File Offset: 0x00087784
		[JsonProperty("message")]
		public string Message
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x00089590 File Offset: 0x00087790
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x00089598 File Offset: 0x00087798
		[JsonProperty("type")]
		public string String_0
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x000895A4 File Offset: 0x000877A4
		// (set) Token: 0x060021E2 RID: 8674 RVA: 0x000895AC File Offset: 0x000877AC
		[JsonProperty("param")]
		public string String_1
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x000895B8 File Offset: 0x000877B8
		// (set) Token: 0x060021E4 RID: 8676 RVA: 0x000895C0 File Offset: 0x000877C0
		[JsonProperty("code")]
		public string String_2
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		// Token: 0x04001745 RID: 5957
		private string string_0;

		// Token: 0x04001746 RID: 5958
		private string string_1;

		// Token: 0x04001747 RID: 5959
		private string string_2;

		// Token: 0x04001748 RID: 5960
		private string string_3;
	}

	// Token: 0x0200061C RID: 1564
	[StructLayout(LayoutKind.Auto)]
	private struct Struct364 : IAsyncStateMachine
	{
		// Token: 0x060021E5 RID: 8677 RVA: 0x000895CC File Offset: 0x000877CC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass189 gclass = this.gclass189_0;
			Stream result;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					goto IL_B1;
				}
				TaskAwaiter<Stream> awaiter2;
				if (num != 1)
				{
					awaiter = gclass.method_3(this.string_0, this.httpMethod_0, this.object_0, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass189.Struct364>(ref awaiter, ref this);
						return;
					}
					goto IL_B1;
				}
				else
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<Stream>);
					this.int_0 = -1;
				}
				IL_87:
				result = awaiter2.GetResult();
				goto IL_113;
				IL_B1:
				awaiter2 = awaiter.GetResult().Content.ReadAsStreamAsync().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass189.Struct364>(ref awaiter2, ref this);
					return;
				}
				goto IL_87;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_113:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00089714 File Offset: 0x00087914
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001749 RID: 5961
		public int int_0;

		// Token: 0x0400174A RID: 5962
		public AsyncTaskMethodBuilder<Stream> asyncTaskMethodBuilder_0;

		// Token: 0x0400174B RID: 5963
		public GClass189 gclass189_0;

		// Token: 0x0400174C RID: 5964
		public string string_0;

		// Token: 0x0400174D RID: 5965
		public HttpMethod httpMethod_0;

		// Token: 0x0400174E RID: 5966
		public object object_0;

		// Token: 0x0400174F RID: 5967
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001750 RID: 5968
		private TaskAwaiter<Stream> taskAwaiter_1;
	}

	// Token: 0x0200061D RID: 1565
	[StructLayout(LayoutKind.Auto)]
	private struct Struct365<GClass32> : IAsyncStateMachine where GClass32 : global::GClass32
	{
		// Token: 0x060021E7 RID: 8679 RVA: 0x00089724 File Offset: 0x00087924
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass189 gclass = this.gclass189_0;
			GClass32 result2;
			try
			{
				if (num == 0)
				{
					goto IL_17E;
				}
				TaskAwaiter<string> awaiter2;
				if (num != 1)
				{
					TaskAwaiter<HttpResponseMessage> awaiter = gclass.method_3(this.string_0, this.httpMethod_0, this.object_0, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass189.Struct365<GClass32>>(ref awaiter, ref this);
						return;
					}
					goto IL_19A;
				}
				else
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				IL_89:
				GClass32 gclass2 = JsonConvert.DeserializeObject<GClass32>(awaiter2.GetResult());
				try
				{
					gclass2.String_1 = this.httpResponseMessage_0.Headers.GetValues("Openai-Organization").FirstOrDefault<string>();
					gclass2.String_2 = this.httpResponseMessage_0.Headers.GetValues("X-Request-ID").FirstOrDefault<string>();
					gclass2.TimeSpan_0 = TimeSpan.FromMilliseconds((double)int.Parse(this.httpResponseMessage_0.Headers.GetValues("Openai-Processing-Ms").First<string>()));
					gclass2.String_3 = this.httpResponseMessage_0.Headers.GetValues("Openai-Version").FirstOrDefault<string>();
					if (string.IsNullOrEmpty(gclass2.GClass89_0))
					{
						gclass2.GClass89_0 = this.httpResponseMessage_0.Headers.GetValues("Openai-Model").FirstOrDefault<string>();
					}
					goto IL_1F6;
					IL_17E:
					TaskAwaiter<HttpResponseMessage> awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					IL_19A:
					HttpResponseMessage result = awaiter.GetResult();
					this.httpResponseMessage_0 = result;
					awaiter2 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
					if (awaiter2.IsCompleted)
					{
						goto IL_89;
					}
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass189.Struct365<GClass32>>(ref awaiter2, ref this);
					return;
				}
				catch (Exception ex)
				{
				}
				IL_1F6:
				result2 = gclass2;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.httpResponseMessage_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.httpResponseMessage_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000899A4 File Offset: 0x00087BA4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001751 RID: 5969
		public int int_0;

		// Token: 0x04001752 RID: 5970
		public AsyncTaskMethodBuilder<GClass32> asyncTaskMethodBuilder_0;

		// Token: 0x04001753 RID: 5971
		public GClass189 gclass189_0;

		// Token: 0x04001754 RID: 5972
		public string string_0;

		// Token: 0x04001755 RID: 5973
		public HttpMethod httpMethod_0;

		// Token: 0x04001756 RID: 5974
		public object object_0;

		// Token: 0x04001757 RID: 5975
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04001758 RID: 5976
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001759 RID: 5977
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x0200061E RID: 1566
	[StructLayout(LayoutKind.Auto)]
	private struct Struct366<GClass32> : IAsyncStateMachine where GClass32 : global::GClass32
	{
		// Token: 0x060021E9 RID: 8681 RVA: 0x000899B4 File Offset: 0x00087BB4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass189 gclass = this.gclass189_0;
			GClass32 result;
			try
			{
				TaskAwaiter<GClass32> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_6<GClass32>(this.string_0, HttpMethod.Put, this.object_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass32>, GClass189.Struct366<GClass32>>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass32>);
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

		// Token: 0x060021EA RID: 8682 RVA: 0x00089A7C File Offset: 0x00087C7C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400175A RID: 5978
		public int int_0;

		// Token: 0x0400175B RID: 5979
		public AsyncTaskMethodBuilder<GClass32> asyncTaskMethodBuilder_0;

		// Token: 0x0400175C RID: 5980
		public GClass189 gclass189_0;

		// Token: 0x0400175D RID: 5981
		public string string_0;

		// Token: 0x0400175E RID: 5982
		public object object_0;

		// Token: 0x0400175F RID: 5983
		private TaskAwaiter<GClass32> taskAwaiter_0;
	}

	// Token: 0x0200061F RID: 1567
	[StructLayout(LayoutKind.Auto)]
	private struct Struct367<GClass32> : IAsyncStateMachine where GClass32 : global::GClass32
	{
		// Token: 0x060021EB RID: 8683 RVA: 0x00089A8C File Offset: 0x00087C8C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass189 gclass = this.gclass189_0;
			GClass32 result;
			try
			{
				TaskAwaiter<GClass32> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_6<GClass32>(this.string_0, HttpMethod.Get, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass32>, GClass189.Struct367<GClass32>>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass32>);
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

		// Token: 0x060021EC RID: 8684 RVA: 0x00089B50 File Offset: 0x00087D50
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001760 RID: 5984
		public int int_0;

		// Token: 0x04001761 RID: 5985
		public AsyncTaskMethodBuilder<GClass32> asyncTaskMethodBuilder_0;

		// Token: 0x04001762 RID: 5986
		public GClass189 gclass189_0;

		// Token: 0x04001763 RID: 5987
		public string string_0;

		// Token: 0x04001764 RID: 5988
		private TaskAwaiter<GClass32> taskAwaiter_0;
	}

	// Token: 0x02000620 RID: 1568
	[StructLayout(LayoutKind.Auto)]
	private struct Struct368<GClass32> : IAsyncStateMachine where GClass32 : global::GClass32
	{
		// Token: 0x060021ED RID: 8685 RVA: 0x00089B60 File Offset: 0x00087D60
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass189 gclass = this.gclass189_0;
			GClass32 result;
			try
			{
				TaskAwaiter<GClass32> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_6<GClass32>(this.string_0, HttpMethod.Delete, this.object_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass32>, GClass189.Struct368<GClass32>>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass32>);
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

		// Token: 0x060021EE RID: 8686 RVA: 0x00089C28 File Offset: 0x00087E28
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001765 RID: 5989
		public int int_0;

		// Token: 0x04001766 RID: 5990
		public AsyncTaskMethodBuilder<GClass32> asyncTaskMethodBuilder_0;

		// Token: 0x04001767 RID: 5991
		public GClass189 gclass189_0;

		// Token: 0x04001768 RID: 5992
		public string string_0;

		// Token: 0x04001769 RID: 5993
		public object object_0;

		// Token: 0x0400176A RID: 5994
		private TaskAwaiter<GClass32> taskAwaiter_0;
	}

	// Token: 0x02000621 RID: 1569
	[StructLayout(LayoutKind.Auto)]
	private struct Struct369 : IAsyncStateMachine
	{
		// Token: 0x060021EF RID: 8687 RVA: 0x00089C38 File Offset: 0x00087E38
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass189 gclass = this.gclass189_0;
			HttpResponseMessage result2;
			try
			{
				if (num > 1)
				{
					if (string.IsNullOrEmpty(this.string_0))
					{
						this.string_0 = gclass.method_0();
					}
					if (this.httpMethod_0 == null)
					{
						this.httpMethod_0 = HttpMethod.Get;
					}
					this.httpClient_0 = gclass.method_1();
				}
				try
				{
					string text;
					TaskAwaiter<HttpResponseMessage> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_17C;
						}
						this.httpResponseMessage_0 = null;
						text = null;
						HttpRequestMessage httpRequestMessage = new HttpRequestMessage(this.httpMethod_0, this.string_0);
						if (this.object_0 != null)
						{
							if (this.object_0 is HttpContent)
							{
								httpRequestMessage.Content = (this.object_0 as HttpContent);
							}
							else
							{
								StringContent content = new StringContent(JsonConvert.SerializeObject(this.object_0, new JsonSerializerSettings
								{
									NullValueHandling = 1
								}), Encoding.UTF8, "application/json");
								httpRequestMessage.Content = content;
							}
						}
						awaiter = this.httpClient_0.SendAsync(httpRequestMessage, this.bool_0 ? HttpCompletionOption.ResponseHeadersRead : HttpCompletionOption.ResponseContentRead).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass189.Struct369>(ref awaiter, ref this);
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
					if (this.httpResponseMessage_0.IsSuccessStatusCode)
					{
						result2 = this.httpResponseMessage_0;
						goto IL_376;
					}
					try
					{
						IL_17C:
						TaskAwaiter<string> awaiter2;
						if (num != 1)
						{
							awaiter2 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								this.int_0 = num4;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass189.Struct369>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<string>);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
						}
						text = awaiter2.GetResult();
					}
					catch (Exception ex)
					{
						text = "Additionally, the following error was thrown when attemping to read the response content: " + ex.ToString();
					}
					if (this.httpResponseMessage_0.StatusCode == HttpStatusCode.Unauthorized)
					{
						throw new AuthenticationException("OpenAI rejected your authorization, most likely due to an invalid API Key.  Try checking your API Key and see https://github.com/OkGoDoIt/OpenAI-API-dotnet#authentication for guidance.  Full API response follows: " + text);
					}
					if (this.httpResponseMessage_0.StatusCode == HttpStatusCode.InternalServerError)
					{
						throw new HttpRequestException("OpenAI had an internal server error, which can happen occasionally.  Please retry your request.  " + gclass.method_2(text, this.httpResponseMessage_0, gclass.vmethod_0(), this.string_0));
					}
					HttpRequestException ex2 = new HttpRequestException(gclass.method_2(text, this.httpResponseMessage_0, gclass.vmethod_0(), this.string_0));
					GClass189.Class699 @class = JsonConvert.DeserializeObject<GClass189.Class699>(text);
					try
					{
						ex2.Data.Add("message", @class.Error.Message);
						ex2.Data.Add("type", @class.Error.String_0);
						ex2.Data.Add("param", @class.Error.String_1);
						ex2.Data.Add("code", @class.Error.String_2);
					}
					catch (Exception inner)
					{
						throw new HttpRequestException(ex2.Message, inner);
					}
					throw ex2;
				}
				finally
				{
					if (num < 0 && this.httpClient_0 != null)
					{
						((IDisposable)this.httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.httpClient_0 = null;
				this.httpResponseMessage_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_376:
			this.int_0 = -2;
			this.httpClient_0 = null;
			this.httpResponseMessage_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0008A044 File Offset: 0x00088244
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400176B RID: 5995
		public int int_0;

		// Token: 0x0400176C RID: 5996
		public AsyncTaskMethodBuilder<HttpResponseMessage> asyncTaskMethodBuilder_0;

		// Token: 0x0400176D RID: 5997
		public string string_0;

		// Token: 0x0400176E RID: 5998
		public GClass189 gclass189_0;

		// Token: 0x0400176F RID: 5999
		public HttpMethod httpMethod_0;

		// Token: 0x04001770 RID: 6000
		public object object_0;

		// Token: 0x04001771 RID: 6001
		public bool bool_0;

		// Token: 0x04001772 RID: 6002
		private HttpClient httpClient_0;

		// Token: 0x04001773 RID: 6003
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04001774 RID: 6004
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001775 RID: 6005
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x02000622 RID: 1570
	[StructLayout(LayoutKind.Auto)]
	private struct Struct370<GClass32> : IAsyncStateMachine where GClass32 : global::GClass32
	{
		// Token: 0x060021F1 RID: 8689 RVA: 0x0008A054 File Offset: 0x00088254
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass189 gclass = this.gclass189_0;
			GClass32 result;
			try
			{
				TaskAwaiter<GClass32> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_6<GClass32>(this.string_0, HttpMethod.Post, this.object_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass32>, GClass189.Struct370<GClass32>>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass32>);
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

		// Token: 0x060021F2 RID: 8690 RVA: 0x0008A11C File Offset: 0x0008831C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001776 RID: 6006
		public int int_0;

		// Token: 0x04001777 RID: 6007
		public AsyncTaskMethodBuilder<GClass32> asyncTaskMethodBuilder_0;

		// Token: 0x04001778 RID: 6008
		public GClass189 gclass189_0;

		// Token: 0x04001779 RID: 6009
		public string string_0;

		// Token: 0x0400177A RID: 6010
		public object object_0;

		// Token: 0x0400177B RID: 6011
		private TaskAwaiter<GClass32> taskAwaiter_0;
	}

	// Token: 0x02000623 RID: 1571
	[StructLayout(LayoutKind.Auto)]
	private struct Struct371 : IAsyncStateMachine
	{
		// Token: 0x060021F3 RID: 8691 RVA: 0x0008A12C File Offset: 0x0008832C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass189 gclass = this.gclass189_0;
			string result;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					goto IL_B1;
				}
				TaskAwaiter<string> awaiter2;
				if (num != 1)
				{
					awaiter = gclass.method_3(this.string_0, this.httpMethod_0, this.object_0, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass189.Struct371>(ref awaiter, ref this);
						return;
					}
					goto IL_B1;
				}
				else
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				IL_87:
				result = awaiter2.GetResult();
				goto IL_113;
				IL_B1:
				awaiter2 = awaiter.GetResult().Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass189.Struct371>(ref awaiter2, ref this);
					return;
				}
				goto IL_87;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_113:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0008A274 File Offset: 0x00088474
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400177C RID: 6012
		public int int_0;

		// Token: 0x0400177D RID: 6013
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x0400177E RID: 6014
		public GClass189 gclass189_0;

		// Token: 0x0400177F RID: 6015
		public string string_0;

		// Token: 0x04001780 RID: 6016
		public HttpMethod httpMethod_0;

		// Token: 0x04001781 RID: 6017
		public object object_0;

		// Token: 0x04001782 RID: 6018
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001783 RID: 6019
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x02000624 RID: 1572
	internal sealed class Class699
	{
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x0008A28C File Offset: 0x0008848C
		// (set) Token: 0x060021F7 RID: 8695 RVA: 0x0008A294 File Offset: 0x00088494
		[JsonProperty("error")]
		public GClass189.Class698 Error
		{
			[CompilerGenerated]
			get
			{
				return this.class698_0;
			}
			[CompilerGenerated]
			set
			{
				this.class698_0 = value;
			}
		}

		// Token: 0x04001784 RID: 6020
		private GClass189.Class698 class698_0;
	}
}
