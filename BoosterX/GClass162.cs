using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x02000559 RID: 1369
public sealed class GClass162
{
	// Token: 0x06001DC8 RID: 7624 RVA: 0x0007C934 File Offset: 0x0007AB34
	public GClass162(GEnum97 genum97_1, GClass4 gclass4_1)
	{
		this.gclass15_0 = new GClass15();
		this.genum97_0 = genum97_1;
		this.gclass4_0 = gclass4_1;
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x0007C958 File Offset: 0x0007AB58
	public static GClass162 smethod_0()
	{
		return new GClass162((GEnum97)0, new GClass4(GEnum70.US, GEnum68.f00001c, true));
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x0007C96C File Offset: 0x0007AB6C
	public Task<IList<GClass56>> method_0(GClass209 gclass209_0, string string_0)
	{
		GClass162.Struct320 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IList<GClass56>>.Create();
		@struct.gclass209_0 = gclass209_0;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass162.Struct320>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x0007C9B8 File Offset: 0x0007ABB8
	public Task<GClass18> method_1(string string_0, GEnum26 genum26_0, string string_1)
	{
		GClass162.Struct323 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass18>.Create();
		@struct.gclass162_0 = this;
		@struct.string_0 = string_0;
		@struct.genum26_0 = genum26_0;
		@struct.string_1 = string_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass162.Struct323>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001DCC RID: 7628 RVA: 0x0007CA14 File Offset: 0x0007AC14
	public Task<GClass180> method_2(string string_0, GEnum49 genum49_0)
	{
		GClass162.Struct322 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass180>.Create();
		@struct.gclass162_0 = this;
		@struct.string_0 = string_0;
		@struct.genum49_0 = genum49_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass162.Struct322>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x0007CA68 File Offset: 0x0007AC68
	public Task<GClass59> method_3(string string_0)
	{
		GClass162.Struct321 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass59>.Create();
		@struct.gclass162_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass162.Struct321>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001DCE RID: 7630 RVA: 0x0007CAB4 File Offset: 0x0007ACB4
	private Task<HttpResponseMessage> method_4(Uri uri_0, HttpMethod httpMethod_0, string string_0)
	{
		GClass162.Struct324 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		@struct.gclass162_0 = this;
		@struct.uri_0 = uri_0;
		@struct.httpMethod_0 = httpMethod_0;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass162.Struct324>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x040014F4 RID: 5364
	private readonly GClass15 gclass15_0;

	// Token: 0x040014F5 RID: 5365
	private readonly GEnum97 genum97_0;

	// Token: 0x040014F6 RID: 5366
	private readonly GClass4 gclass4_0;

	// Token: 0x0200055A RID: 1370
	[StructLayout(LayoutKind.Auto)]
	private struct Struct320 : IAsyncStateMachine
	{
		// Token: 0x06001DCF RID: 7631 RVA: 0x0007CB10 File Offset: 0x0007AD10
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			IList<GClass56> result4;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<IList<GClass56>> awaiter2;
				TaskAwaiter<IList<Uri>> awaiter3;
				switch (num)
				{
				case 0:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					break;
				}
				case 1:
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<IList<GClass56>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					goto IL_108;
				}
				case 2:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter<IList<Uri>>);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
					goto IL_181;
				}
				default:
					awaiter = GClass82.smethod_0(this.gclass209_0.List_4[0].GClass109_0.GClass183_0.GClass3_0.String_1, this.string_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num5 = 0;
						num = 0;
						this.int_0 = num5;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass162.Struct320>(ref awaiter, ref this);
						return;
					}
					break;
				}
				string result = awaiter.GetResult();
				IList<string> list;
				GClass82.smethod_4(result, out this.ilist_0, out list, out this.ilist_1);
				awaiter2 = GClass82.smethod_2(result).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					int num6 = 1;
					num = 1;
					this.int_0 = num6;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IList<GClass56>>, GClass162.Struct320>(ref awaiter2, ref this);
					return;
				}
				IL_108:
				IList<GClass56> result2 = awaiter2.GetResult();
				this.ilist_2 = result2;
				awaiter3 = GClass82.smethod_5(this.ilist_1, this.ilist_0, this.string_0).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num7 = 2;
					num = 2;
					this.int_0 = num7;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IList<Uri>>, GClass162.Struct320>(ref awaiter3, ref this);
					return;
				}
				IL_181:
				IList<Uri> result3 = awaiter3.GetResult();
				IEnumerator<GClass56> enumerator = this.ilist_2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass56 gclass = enumerator.Current;
						int index = this.ilist_2.IndexOf(gclass);
						gclass.uri_0 = result3[index];
						gclass.string_1 = this.ilist_1[index];
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				result4 = this.ilist_2;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.ilist_0 = null;
				this.ilist_1 = null;
				this.ilist_2 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.ilist_0 = null;
			this.ilist_1 = null;
			this.ilist_2 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result4);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0007CD9C File Offset: 0x0007AF9C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014F7 RID: 5367
		public int int_0;

		// Token: 0x040014F8 RID: 5368
		public AsyncTaskMethodBuilder<IList<GClass56>> asyncTaskMethodBuilder_0;

		// Token: 0x040014F9 RID: 5369
		public GClass209 gclass209_0;

		// Token: 0x040014FA RID: 5370
		public string string_0;

		// Token: 0x040014FB RID: 5371
		private IList<string> ilist_0;

		// Token: 0x040014FC RID: 5372
		private IList<string> ilist_1;

		// Token: 0x040014FD RID: 5373
		private IList<GClass56> ilist_2;

		// Token: 0x040014FE RID: 5374
		private TaskAwaiter<string> taskAwaiter_0;

		// Token: 0x040014FF RID: 5375
		private TaskAwaiter<IList<GClass56>> taskAwaiter_1;

		// Token: 0x04001500 RID: 5376
		private TaskAwaiter<IList<Uri>> taskAwaiter_2;
	}

	// Token: 0x0200055B RID: 1371
	[StructLayout(LayoutKind.Auto)]
	private struct Struct321 : IAsyncStateMachine
	{
		// Token: 0x06001DD1 RID: 7633 RVA: 0x0007CDAC File Offset: 0x0007AFAC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass162 gclass = this.gclass162_0;
			GClass59 result;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					goto IL_BE;
				}
				TaskAwaiter<string> awaiter2;
				if (num != 1)
				{
					Uri uri_ = GClass80.smethod_2(gclass.gclass4_0, this.string_0);
					awaiter = gclass.method_4(uri_, HttpMethod.Get, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass162.Struct321>(ref awaiter, ref this);
						return;
					}
					goto IL_BE;
				}
				else
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				IL_8F:
				result = GClass59.smethod_0(awaiter2.GetResult());
				goto IL_120;
				IL_BE:
				awaiter2 = awaiter.GetResult().Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass162.Struct321>(ref awaiter2, ref this);
					return;
				}
				goto IL_8F;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_120:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x0007CF00 File Offset: 0x0007B100
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001501 RID: 5377
		public int int_0;

		// Token: 0x04001502 RID: 5378
		public AsyncTaskMethodBuilder<GClass59> asyncTaskMethodBuilder_0;

		// Token: 0x04001503 RID: 5379
		public GClass162 gclass162_0;

		// Token: 0x04001504 RID: 5380
		public string string_0;

		// Token: 0x04001505 RID: 5381
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001506 RID: 5382
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x0200055C RID: 1372
	[StructLayout(LayoutKind.Auto)]
	private struct Struct322 : IAsyncStateMachine
	{
		// Token: 0x06001DD3 RID: 7635 RVA: 0x0007CF10 File Offset: 0x0007B110
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass162 gclass = this.gclass162_0;
			GClass180 result;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					goto IL_CA;
				}
				TaskAwaiter<string> awaiter2;
				if (num != 1)
				{
					Uri uri_ = GClass80.smethod_1(gclass.genum97_0, this.genum49_0, gclass.gclass4_0, this.string_0);
					awaiter = gclass.method_4(uri_, HttpMethod.Get, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass162.Struct322>(ref awaiter, ref this);
						return;
					}
					goto IL_CA;
				}
				else
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				IL_9B:
				result = GClass180.smethod_0(awaiter2.GetResult());
				goto IL_12C;
				IL_CA:
				awaiter2 = awaiter.GetResult().Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass162.Struct322>(ref awaiter2, ref this);
					return;
				}
				goto IL_9B;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_12C:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0007D07C File Offset: 0x0007B27C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001507 RID: 5383
		public int int_0;

		// Token: 0x04001508 RID: 5384
		public AsyncTaskMethodBuilder<GClass180> asyncTaskMethodBuilder_0;

		// Token: 0x04001509 RID: 5385
		public GClass162 gclass162_0;

		// Token: 0x0400150A RID: 5386
		public GEnum49 genum49_0;

		// Token: 0x0400150B RID: 5387
		public string string_0;

		// Token: 0x0400150C RID: 5388
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400150D RID: 5389
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x0200055D RID: 1373
	[StructLayout(LayoutKind.Auto)]
	private struct Struct323 : IAsyncStateMachine
	{
		// Token: 0x06001DD5 RID: 7637 RVA: 0x0007D08C File Offset: 0x0007B28C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass162 gclass = this.gclass162_0;
			GClass18 result;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					goto IL_CF;
				}
				TaskAwaiter<string> awaiter2;
				if (num != 1)
				{
					Uri uri_ = GClass80.smethod_0(gclass.genum97_0, this.string_0, this.genum26_0, gclass.gclass4_0);
					awaiter = gclass.method_4(uri_, HttpMethod.Get, this.string_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass162.Struct323>(ref awaiter, ref this);
						return;
					}
					goto IL_CF;
				}
				else
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				IL_A0:
				result = GClass18.smethod_0(awaiter2.GetResult());
				goto IL_131;
				IL_CF:
				awaiter2 = awaiter.GetResult().Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass162.Struct323>(ref awaiter2, ref this);
					return;
				}
				goto IL_A0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_131:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x0007D1FC File Offset: 0x0007B3FC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400150E RID: 5390
		public int int_0;

		// Token: 0x0400150F RID: 5391
		public AsyncTaskMethodBuilder<GClass18> asyncTaskMethodBuilder_0;

		// Token: 0x04001510 RID: 5392
		public GClass162 gclass162_0;

		// Token: 0x04001511 RID: 5393
		public string string_0;

		// Token: 0x04001512 RID: 5394
		public GEnum26 genum26_0;

		// Token: 0x04001513 RID: 5395
		public string string_1;

		// Token: 0x04001514 RID: 5396
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001515 RID: 5397
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x0200055E RID: 1374
	[StructLayout(LayoutKind.Auto)]
	private struct Struct324 : IAsyncStateMachine
	{
		// Token: 0x06001DD7 RID: 7639 RVA: 0x0007D20C File Offset: 0x0007B40C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass162 gclass = this.gclass162_0;
			HttpResponseMessage result2;
			try
			{
				TaskAwaiter<string> awaiter;
				HttpRequestMessage httpRequestMessage;
				switch (num)
				{
				case 0:
					break;
				case 1:
					awaiter = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_1E1;
				case 2:
					awaiter = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_218;
				default:
					httpRequestMessage = new HttpRequestMessage(this.httpMethod_0, this.uri_0);
					if (!string.IsNullOrEmpty(this.string_0))
					{
						httpRequestMessage.Headers.TryAddWithoutValidation("Authentication", this.string_0);
					}
					break;
				}
				HttpResponseMessage result;
				try
				{
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						awaiter2 = gclass.gclass15_0.SendAsync(httpRequestMessage, default(CancellationToken)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass162.Struct324>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						this.int_0 = -1;
					}
					result = awaiter2.GetResult();
				}
				catch
				{
					throw new GException5(this.uri_0.ToString(), 0, null);
				}
				if (result.StatusCode == HttpStatusCode.NotFound)
				{
					this.string_1 = this.uri_0.ToString();
					this.int_1 = (int)result.StatusCode;
					awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass162.Struct324>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					if (result.IsSuccessStatusCode)
					{
						result2 = result;
						goto IL_257;
					}
					this.string_1 = this.uri_0.ToString();
					this.int_1 = (int)result.StatusCode;
					awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_1 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass162.Struct324>(ref awaiter, ref this);
						return;
					}
					goto IL_218;
				}
				IL_1E1:
				string result3 = awaiter.GetResult();
				throw new GException4(this.string_1, this.int_1, result3);
				IL_218:
				result3 = awaiter.GetResult();
				throw new GException4(this.string_1, this.int_1, result3);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_257:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0007D4BC File Offset: 0x0007B6BC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001516 RID: 5398
		public int int_0;

		// Token: 0x04001517 RID: 5399
		public AsyncTaskMethodBuilder<HttpResponseMessage> asyncTaskMethodBuilder_0;

		// Token: 0x04001518 RID: 5400
		public HttpMethod httpMethod_0;

		// Token: 0x04001519 RID: 5401
		public Uri uri_0;

		// Token: 0x0400151A RID: 5402
		public string string_0;

		// Token: 0x0400151B RID: 5403
		public GClass162 gclass162_0;

		// Token: 0x0400151C RID: 5404
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400151D RID: 5405
		private string string_1;

		// Token: 0x0400151E RID: 5406
		private int int_1;

		// Token: 0x0400151F RID: 5407
		private TaskAwaiter<string> taskAwaiter_1;
	}
}
