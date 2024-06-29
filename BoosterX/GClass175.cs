using System;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using StoreLib.Models;

// Token: 0x020005A3 RID: 1443
public static class GClass175
{
	// Token: 0x06001F00 RID: 7936 RVA: 0x0008099C File Offset: 0x0007EB9C
	public static Uri smethod_0(ImagePurpose imagePurpose_0, GClass18 gclass18_0)
	{
		foreach (GClass137 gclass in gclass18_0.GClass209_0.List_0[0].List_1)
		{
			if (gclass.String_4 == Enum.GetName(typeof(ImagePurpose), imagePurpose_0))
			{
				if (gclass.String_6.StartsWith("//"))
				{
					return new Uri("http:" + gclass.String_6);
				}
				return new Uri(gclass.String_6);
			}
		}
		return null;
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x00080A58 File Offset: 0x0007EC58
	public static Task<byte[]> smethod_1(Uri uri_0, string string_0, bool bool_0)
	{
		GClass175.Struct339 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<byte[]>.Create();
		@struct.uri_0 = uri_0;
		@struct.string_0 = string_0;
		@struct.bool_0 = bool_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass175.Struct339>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x020005A4 RID: 1444
	[StructLayout(LayoutKind.Auto)]
	private struct Struct339 : IAsyncStateMachine
	{
		// Token: 0x06001F02 RID: 7938 RVA: 0x00080AAC File Offset: 0x0007ECAC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			byte[] result;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				TaskAwaiter<int> awaiter4;
				switch (num)
				{
				case 0:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					break;
				}
				case 1:
				case 2:
					IL_14D:
					try
					{
						TaskAwaiter<byte[]> awaiter2;
						if (num == 1)
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<byte[]>);
							int num3 = -1;
							num = -1;
							this.int_0 = num3;
							goto IL_1FD;
						}
						TaskAwaiter awaiter3;
						if (num != 2)
						{
							this.httpResponseMessage_0.EnsureSuccessStatusCode();
							awaiter2 = this.httpResponseMessage_0.Content.ReadAsByteArrayAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								this.int_0 = num4;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, GClass175.Struct339>(ref awaiter2, ref this);
								return;
							}
							goto IL_1FD;
						}
						else
						{
							awaiter3 = this.taskAwaiter_2;
							this.taskAwaiter_2 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
						}
						IL_1CE:
						awaiter3.GetResult();
						result = this.byte_0;
						goto IL_2E7;
						IL_1FD:
						byte[] result2 = awaiter2.GetResult();
						this.byte_0 = result2;
						awaiter3 = new FileStream(this.string_0 + "\\" + this.string_1, FileMode.Create).WriteAsync(this.byte_0, 0, this.byte_0.Length).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num6 = 2;
							num = 2;
							this.int_0 = num6;
							this.taskAwaiter_2 = awaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass175.Struct339>(ref awaiter3, ref this);
							return;
						}
						goto IL_1CE;
					}
					finally
					{
						if (num < 0 && this.httpResponseMessage_0 != null)
						{
							((IDisposable)this.httpResponseMessage_0).Dispose();
						}
					}
					goto IL_293;
				case 3:
					goto IL_293;
				default:
					this.string_1 = Class467.smethod_1(this.uri_0.ToString());
					if (this.bool_0 | !File.Exists(this.string_0 + "\\" + this.string_1))
					{
						awaiter = new HttpClient().GetAsync(this.uri_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num7 = 0;
							num = 0;
							this.int_0 = num7;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass175.Struct339>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						FileStream fileStream = new FileStream(this.string_0 + "\\" + this.string_1, FileMode.Open);
						this.byte_0 = new byte[fileStream.Length];
						awaiter4 = fileStream.ReadAsync(this.byte_0, 0, this.byte_0.Length).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							int num8 = 3;
							num = 3;
							this.int_0 = num8;
							this.taskAwaiter_3 = awaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<int>, GClass175.Struct339>(ref awaiter4, ref this);
							return;
						}
						goto IL_2B0;
					}
					break;
				}
				HttpResponseMessage result3 = awaiter.GetResult();
				this.httpResponseMessage_0 = result3;
				goto IL_14D;
				IL_293:
				awaiter4 = this.taskAwaiter_3;
				this.taskAwaiter_3 = default(TaskAwaiter<int>);
				int num9 = -1;
				num = -1;
				this.int_0 = num9;
				IL_2B0:
				awaiter4.GetResult();
				result = this.byte_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.string_1 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_2E7:
			this.int_0 = -2;
			this.string_1 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00080DF0 File Offset: 0x0007EFF0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040015B8 RID: 5560
		public int int_0;

		// Token: 0x040015B9 RID: 5561
		public AsyncTaskMethodBuilder<byte[]> asyncTaskMethodBuilder_0;

		// Token: 0x040015BA RID: 5562
		public Uri uri_0;

		// Token: 0x040015BB RID: 5563
		public bool bool_0;

		// Token: 0x040015BC RID: 5564
		public string string_0;

		// Token: 0x040015BD RID: 5565
		private string string_1;

		// Token: 0x040015BE RID: 5566
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x040015BF RID: 5567
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040015C0 RID: 5568
		private byte[] byte_0;

		// Token: 0x040015C1 RID: 5569
		private TaskAwaiter<byte[]> taskAwaiter_1;

		// Token: 0x040015C2 RID: 5570
		private TaskAwaiter taskAwaiter_2;

		// Token: 0x040015C3 RID: 5571
		private TaskAwaiter<int> taskAwaiter_3;
	}
}
