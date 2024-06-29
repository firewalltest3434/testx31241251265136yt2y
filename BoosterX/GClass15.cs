using System;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x02000131 RID: 305
public sealed class GClass15 : HttpClient
{
	// Token: 0x060007FC RID: 2044 RVA: 0x00026A48 File Offset: 0x00024C48
	public GClass15() : base(GClass15.smethod_0())
	{
		this.class764_0.method_0();
		base.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "StoreLib");
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00026A98 File Offset: 0x00024C98
	private static HttpClientHandler smethod_0()
	{
		HttpClientHandler httpClientHandler = new HttpClientHandler();
		if (!GClass15.bool_0)
		{
			HttpClientHandler httpClientHandler2 = httpClientHandler;
			Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> serverCertificateCustomValidationCallback;
			if ((serverCertificateCustomValidationCallback = GClass15.Class167.func_0) == null)
			{
				serverCertificateCustomValidationCallback = (GClass15.Class167.func_0 = new Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool>(GClass15.smethod_1));
			}
			httpClientHandler2.ServerCertificateCustomValidationCallback = serverCertificateCustomValidationCallback;
		}
		return httpClientHandler;
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00026AD4 File Offset: 0x00024CD4
	private static bool smethod_1(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return true;
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00026AD8 File Offset: 0x00024CD8
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		GClass15.Struct59 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		@struct.gclass15_0 = this;
		@struct.httpRequestMessage_0 = request;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass15.Struct59>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0400045F RID: 1119
	private readonly Class764 class764_0 = new Class764();

	// Token: 0x04000460 RID: 1120
	private static readonly bool bool_0 = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

	// Token: 0x02000132 RID: 306
	[StructLayout(LayoutKind.Auto)]
	private struct Struct59 : IAsyncStateMachine
	{
		// Token: 0x06000801 RID: 2049 RVA: 0x00026B24 File Offset: 0x00024D24
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass15 gclass = this.gclass15_0;
			HttpResponseMessage result;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num != 0)
				{
					this.httpRequestMessage_0.Headers.Add("MS-CV", gclass.class764_0.method_4());
					gclass.class764_0.method_5();
					awaiter = gclass.SendAsync(this.httpRequestMessage_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass15.Struct59>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
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

		// Token: 0x06000802 RID: 2050 RVA: 0x00026C0C File Offset: 0x00024E0C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000461 RID: 1121
		public int int_0;

		// Token: 0x04000462 RID: 1122
		public AsyncTaskMethodBuilder<HttpResponseMessage> asyncTaskMethodBuilder_0;

		// Token: 0x04000463 RID: 1123
		public HttpRequestMessage httpRequestMessage_0;

		// Token: 0x04000464 RID: 1124
		public GClass15 gclass15_0;

		// Token: 0x04000465 RID: 1125
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
	}

	// Token: 0x02000133 RID: 307
	private static class Class167
	{
		// Token: 0x04000466 RID: 1126
		public static Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> func_0;
	}
}
