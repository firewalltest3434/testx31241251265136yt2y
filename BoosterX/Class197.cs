using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using IGDB;
using IGDB.Models;

// Token: 0x0200016E RID: 366
internal sealed class Class197
{
	// Token: 0x06000989 RID: 2441 RVA: 0x0002BA18 File Offset: 0x00029C18
	public static Task<string> smethod_0(string string_0)
	{
		Class197.Struct70 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class197.Struct70>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x0002BA5C File Offset: 0x00029C5C
	public static Task<string> smethod_1(string string_0)
	{
		Class197.Class198 @class = new Class197.Class198();
		@class.string_0 = string_0;
		return Task.Factory.StartNew<Task<string>>(new Func<Task<string>>(@class.method_0), TaskCreationOptions.LongRunning).Unwrap<string>();
	}

	// Token: 0x04000587 RID: 1415
	private static IGDBClient igdbclient_0 = new IGDBClient("6pcw6lgoq8xu5keworn22b8ndrwfik", "q5iwgob781l9xo3z4szjy2zq02l66q");

	// Token: 0x0200016F RID: 367
	[StructLayout(LayoutKind.Auto)]
	private struct Struct70 : IAsyncStateMachine
	{
		// Token: 0x0600098B RID: 2443 RVA: 0x0002BA94 File Offset: 0x00029C94
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result2;
			try
			{
				if (num > 1)
				{
					if (this.string_0 == "cs2")
					{
						this.string_0 = "Counter-Strike 2";
					}
					this.string_1 = Class186.string_1 + "\\" + this.string_0 + ".png";
					if (!Directory.Exists(Class186.string_1))
					{
						Directory.CreateDirectory(Class186.string_1);
					}
					if (File.Exists(this.string_1))
					{
						goto IL_1FB;
					}
				}
				try
				{
					TaskAwaiter<Game[]> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_135;
						}
						awaiter = Class197.igdbclient_0.QueryAsync<Game>("games", "search \"" + this.string_0 + "\"; fields cover.*;").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Game[]>, Class197.Struct70>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Game[]>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					string imageId = awaiter.GetResult()[0].Cover.Value.ImageId;
					string requestUri = "https://images.igdb.com/igdb/image/upload/t_cover_big/" + imageId + ".png";
					this.httpClient_0 = new HttpClient();
					try
					{
						IL_135:
						TaskAwaiter<byte[]> awaiter2;
						if (num != 1)
						{
							awaiter2 = this.httpClient_0.GetByteArrayAsync(requestUri).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								this.int_0 = num4;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, Class197.Struct70>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<byte[]>);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
						}
						byte[] result = awaiter2.GetResult();
						File.WriteAllBytes(this.string_1, result);
					}
					catch (object obj)
					{
					}
					finally
					{
						if (num < 0 && this.httpClient_0 != null)
						{
							((IDisposable)this.httpClient_0).Dispose();
						}
					}
					this.httpClient_0 = null;
					result2 = this.string_1;
					goto IL_22A;
				}
				catch
				{
					result2 = null;
					goto IL_22A;
				}
				IL_1FB:
				result2 = this.string_1;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.string_1 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_22A:
			this.int_0 = -2;
			this.string_1 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0002BD4C File Offset: 0x00029F4C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000588 RID: 1416
		public int int_0;

		// Token: 0x04000589 RID: 1417
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x0400058A RID: 1418
		public string string_0;

		// Token: 0x0400058B RID: 1419
		private string string_1;

		// Token: 0x0400058C RID: 1420
		private TaskAwaiter<Game[]> taskAwaiter_0;

		// Token: 0x0400058D RID: 1421
		private HttpClient httpClient_0;

		// Token: 0x0400058E RID: 1422
		private TaskAwaiter<byte[]> taskAwaiter_1;
	}

	// Token: 0x02000170 RID: 368
	private sealed class Class198
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x0002BD64 File Offset: 0x00029F64
		internal Task<string> method_0()
		{
			Class197.Class198.Struct71 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
			@struct.class198_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class197.Class198.Struct71>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0400058F RID: 1423
		public string string_0;

		// Token: 0x02000171 RID: 369
		[StructLayout(LayoutKind.Auto)]
		private struct Struct71 : IAsyncStateMachine
		{
			// Token: 0x0600098F RID: 2447 RVA: 0x0002BDA8 File Offset: 0x00029FA8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class197.Class198 @class = this.class198_0;
				string result2;
				try
				{
					TaskAwaiter<Game[]> awaiter;
					if (num != 0)
					{
						awaiter = Class197.igdbclient_0.QueryAsync<Game>("games", "search \"" + @class.string_0 + "\"; fields cover.*;").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Game[]>, Class197.Class198.Struct71>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Game[]>);
						this.int_0 = -1;
					}
					Game[] result = awaiter.GetResult();
					if (result != null && result.Count<Game>() != 0)
					{
						string imageId = result[0].Cover.Value.ImageId;
						result2 = "https://images.igdb.com/igdb/image/upload/t_cover_big/" + imageId + ".png";
					}
					else
					{
						result2 = string.Empty;
					}
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

			// Token: 0x06000990 RID: 2448 RVA: 0x0002BEBC File Offset: 0x0002A0BC
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000590 RID: 1424
			public int int_0;

			// Token: 0x04000591 RID: 1425
			public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

			// Token: 0x04000592 RID: 1426
			public Class197.Class198 class198_0;

			// Token: 0x04000593 RID: 1427
			private TaskAwaiter<Game[]> taskAwaiter_0;
		}
	}
}
