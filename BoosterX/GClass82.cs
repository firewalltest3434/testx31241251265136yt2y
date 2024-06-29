using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using Newtonsoft.Json;

// Token: 0x020002D7 RID: 727
public static class GClass82
{
	// Token: 0x060010D0 RID: 4304 RVA: 0x000467DC File Offset: 0x000449DC
	public static Task<string> smethod_0(string string_1, string string_2)
	{
		GClass82.Struct152 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.string_0 = string_1;
		@struct.string_1 = string_2;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass82.Struct152>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x00046828 File Offset: 0x00044A28
	public static Task<IList<GClass56>> smethod_1(string string_1, string string_2)
	{
		GClass82.Struct151 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IList<GClass56>>.Create();
		@struct.string_0 = string_1;
		@struct.string_1 = string_2;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass82.Struct151>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x00046874 File Offset: 0x00044A74
	public static Task<IList<GClass56>> smethod_2(string string_1)
	{
		GClass82.Struct150 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IList<GClass56>>.Create();
		@struct.string_0 = string_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass82.Struct150>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x000468B8 File Offset: 0x00044AB8
	public static Task<string> smethod_3()
	{
		GClass82.Struct149 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass82.Struct149>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x000468F4 File Offset: 0x00044AF4
	public static void smethod_4(string string_1, out IList<string> ilist_0, out IList<string> ilist_1, out IList<string> ilist_2)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(string_1);
		ilist_2 = new List<string>();
		ilist_1 = new List<string>();
		ilist_0 = new List<string>();
		foreach (object obj in xmlDocument.GetElementsByTagName("SecuredFragment"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			string value = xmlNode.ParentNode.ParentNode.FirstChild.Attributes[0].Value;
			string value2 = xmlNode.ParentNode.ParentNode.FirstChild.Attributes[1].Value;
			ilist_2.Add(value);
			ilist_0.Add(value2);
		}
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x000469BC File Offset: 0x00044BBC
	public static Task<IList<Uri>> smethod_5(IList<string> ilist_0, IList<string> ilist_1, string string_1)
	{
		GClass82.Struct153 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IList<Uri>>.Create();
		@struct.ilist_0 = ilist_0;
		@struct.ilist_1 = ilist_1;
		@struct.string_0 = string_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass82.Struct153>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x00046A10 File Offset: 0x00044C10
	private static string smethod_6(string string_1)
	{
		string result = string.Empty;
		using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BoosterX.Services.StoreLib.Xml." + string_1))
		{
			StreamReader streamReader = new StreamReader(manifestResourceStream);
			try
			{
				result = streamReader.ReadToEnd();
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
		}
		return result;
	}

	// Token: 0x04000A17 RID: 2583
	private static readonly GClass15 gclass15_0 = new GClass15();

	// Token: 0x04000A18 RID: 2584
	private static readonly string string_0 = "<Device>dAA9AEUAdwBBAHcAQQBzAE4AMwBCAEEAQQBVADEAYgB5AHMAZQBtAGIAZQBEAFYAQwArADMAZgBtADcAbwBXAHkASAA3AGIAbgBnAEcAWQBtAEEAQQBMAGoAbQBqAFYAVQB2AFEAYwA0AEsAVwBFAC8AYwBDAEwANQBYAGUANABnAHYAWABkAGkAegBHAGwAZABjADEAZAAvAFcAeQAvAHgASgBQAG4AVwBRAGUAYwBtAHYAbwBjAGkAZwA5AGoAZABwAE4AawBIAG0AYQBzAHAAVABKAEwARAArAFAAYwBBAFgAbQAvAFQAcAA3AEgAagBzAEYANAA0AEgAdABsAC8AMQBtAHUAcgAwAFMAdQBtAG8AMABZAGEAdgBqAFIANwArADQAcABoAC8AcwA4ADEANgBFAFkANQBNAFIAbQBnAFIAQwA2ADMAQwBSAEoAQQBVAHYAZgBzADQAaQB2AHgAYwB5AEwAbAA2AHoAOABlAHgAMABrAFgAOQBPAHcAYQB0ADEAdQBwAFMAOAAxAEgANgA4AEEASABzAEoAegBnAFQAQQBMAG8AbgBBADIAWQBBAEEAQQBpAGcANQBJADMAUQAvAFYASABLAHcANABBAEIAcQA5AFMAcQBhADEAQgA4AGsAVQAxAGEAbwBLAEEAdQA0AHYAbABWAG4AdwBWADMAUQB6AHMATgBtAEQAaQBqAGgANQBkAEcAcgBpADgAQQBlAEUARQBWAEcAbQBXAGgASQBCAE0AUAAyAEQAVwA0ADMAZABWAGkARABUAHoAVQB0AHQARQBMAEgAaABSAGYAcgBhAGIAWgBsAHQAQQBUAEUATABmAHMARQBGAFUAYQBRAFMASgB4ADUAeQBRADgAagBaAEUAZQAyAHgANABCADMAMQB2AEIAMgBqAC8AUgBLAGEAWQAvAHEAeQB0AHoANwBUAHYAdAB3AHQAagBzADYAUQBYAEIAZQA4AHMAZwBJAG8AOQBiADUAQQBCADcAOAAxAHMANgAvAGQAUwBFAHgATgBEAEQAYQBRAHoAQQBYAFAAWABCAFkAdQBYAFEARQBzAE8AegA4AHQAcgBpAGUATQBiAEIAZQBUAFkAOQBiAG8AQgBOAE8AaQBVADcATgBSAEYAOQAzAG8AVgArAFYAQQBiAGgAcAAwAHAAUgBQAFMAZQBmAEcARwBPAHEAdwBTAGcANwA3AHMAaAA5AEoASABNAHAARABNAFMAbgBrAHEAcgAyAGYARgBpAEMAUABrAHcAVgBvAHgANgBuAG4AeABGAEQAbwBXAC8AYQAxAHQAYQBaAHcAegB5AGwATABMADEAMgB3AHUAYgBtADUAdQBtAHAAcQB5AFcAYwBLAFIAagB5AGgAMgBKAFQARgBKAFcANQBnAFgARQBJADUAcAA4ADAARwB1ADIAbgB4AEwAUgBOAHcAaQB3AHIANwBXAE0AUgBBAFYASwBGAFcATQBlAFIAegBsADkAVQBxAGcALwBwAFgALwB2AGUATAB3AFMAawAyAFMAUwBIAGYAYQBLADYAagBhAG8AWQB1AG4AUgBHAHIAOABtAGIARQBvAEgAbABGADYASgBDAGEAYQBUAEIAWABCAGMAdgB1AGUAQwBKAG8AOQA4AGgAUgBBAHIARwB3ADQAKwBQAEgAZQBUAGIATgBTAEUAWABYAHoAdgBaADYAdQBXADUARQBBAGYAZABaAG0AUwA4ADgAVgBKAGMAWgBhAEYASwA3AHgAeABnADAAdwBvAG4ANwBoADAAeABDADYAWgBCADAAYwBZAGoATAByAC8ARwBlAE8AegA5AEcANABRAFUASAA5AEUAawB5ADAAZAB5AEYALwByAGUAVQAxAEkAeQBpAGEAcABwAGgATwBQADgAUwAyAHQANABCAHIAUABaAFgAVAB2AEMAMABQADcAegBPACsAZgBHAGsAeABWAG0AKwBVAGYAWgBiAFEANQA1AHMAdwBFAD0AJgBwAD0A</Device>";

	// Token: 0x020002D8 RID: 728
	[StructLayout(LayoutKind.Auto)]
	private struct Struct149 : IAsyncStateMachine
	{
		// Token: 0x060010D7 RID: 4311 RVA: 0x00046A78 File Offset: 0x00044C78
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string innerText;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					goto IL_121;
				}
				TaskAwaiter<string> awaiter2;
				if (num != 1)
				{
					this.xmlDocument_0 = new XmlDocument();
					HttpContent content = new StringContent(GClass82.smethod_6("GetCookie.xml"), Encoding.UTF8, "application/soap+xml");
					HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
					httpRequestMessage.RequestUri = GClass20.uri_0;
					httpRequestMessage.Content = content;
					httpRequestMessage.Method = HttpMethod.Post;
					awaiter = GClass82.gclass15_0.SendAsync(httpRequestMessage, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass82.Struct149>(ref awaiter, ref this);
						return;
					}
					goto IL_121;
				}
				else
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				IL_C6:
				string result = awaiter2.GetResult();
				this.xmlDocument_1.LoadXml(result);
				this.xmlDocument_1 = null;
				innerText = this.xmlDocument_0.GetElementsByTagName("EncryptedData")[0].InnerText;
				goto IL_196;
				IL_121:
				HttpResponseMessage result2 = awaiter.GetResult();
				this.xmlDocument_1 = this.xmlDocument_0;
				awaiter2 = result2.Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass82.Struct149>(ref awaiter2, ref this);
					return;
				}
				goto IL_C6;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.xmlDocument_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_196:
			this.int_0 = -2;
			this.xmlDocument_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(innerText);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00046C54 File Offset: 0x00044E54
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A19 RID: 2585
		public int int_0;

		// Token: 0x04000A1A RID: 2586
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000A1B RID: 2587
		private XmlDocument xmlDocument_0;

		// Token: 0x04000A1C RID: 2588
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000A1D RID: 2589
		private XmlDocument xmlDocument_1;

		// Token: 0x04000A1E RID: 2590
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x020002D9 RID: 729
	[StructLayout(LayoutKind.Auto)]
	private struct Struct150 : IAsyncStateMachine
	{
		// Token: 0x060010D9 RID: 4313 RVA: 0x00046C64 File Offset: 0x00044E64
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			IList<GClass56> result;
			try
			{
				TaskAwaiter<IList<GClass56>> awaiter;
				if (num != 0)
				{
					awaiter = Task.Run<IList<GClass56>>(new Func<IList<GClass56>>(new GClass82.Class356
					{
						string_0 = this.string_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IList<GClass56>>, GClass82.Struct150>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<IList<GClass56>>);
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

		// Token: 0x060010DA RID: 4314 RVA: 0x00046D2C File Offset: 0x00044F2C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A1F RID: 2591
		public int int_0;

		// Token: 0x04000A20 RID: 2592
		public AsyncTaskMethodBuilder<IList<GClass56>> asyncTaskMethodBuilder_0;

		// Token: 0x04000A21 RID: 2593
		public string string_0;

		// Token: 0x04000A22 RID: 2594
		private TaskAwaiter<IList<GClass56>> taskAwaiter_0;
	}

	// Token: 0x020002DA RID: 730
	[StructLayout(LayoutKind.Auto)]
	private struct Struct151 : IAsyncStateMachine
	{
		// Token: 0x060010DB RID: 4315 RVA: 0x00046D3C File Offset: 0x00044F3C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			IList<GClass56> result2;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<HttpResponseMessage> awaiter2;
				TaskAwaiter<IList<GClass56>> awaiter3;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					goto IL_14A;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_1A9;
				case 3:
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter<IList<GClass56>>);
					this.int_0 = -1;
					goto IL_208;
				default:
					this.string_2 = GClass82.smethod_6("WUIDRequest.xml");
					awaiter = GClass82.smethod_3().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass82.Struct151>(ref awaiter, ref this);
						return;
					}
					break;
				}
				string result = awaiter.GetResult();
				HttpContent content = new StringContent(string.Format(this.string_2, result, this.string_0, this.string_1 ?? GClass82.string_0), Encoding.UTF8, "application/soap+xml");
				this.string_2 = null;
				HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
				httpRequestMessage.RequestUri = GClass20.uri_0;
				httpRequestMessage.Content = content;
				httpRequestMessage.Method = HttpMethod.Post;
				awaiter2 = GClass82.gclass15_0.SendAsync(httpRequestMessage, default(CancellationToken)).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass82.Struct151>(ref awaiter2, ref this);
					return;
				}
				IL_14A:
				awaiter = awaiter2.GetResult().Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass82.Struct151>(ref awaiter, ref this);
					return;
				}
				IL_1A9:
				awaiter3 = GClass82.smethod_2(HttpUtility.HtmlDecode(awaiter.GetResult())).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IList<GClass56>>, GClass82.Struct151>(ref awaiter3, ref this);
					return;
				}
				IL_208:
				result2 = awaiter3.GetResult();
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

		// Token: 0x060010DC RID: 4316 RVA: 0x00046FA8 File Offset: 0x000451A8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A23 RID: 2595
		public int int_0;

		// Token: 0x04000A24 RID: 2596
		public AsyncTaskMethodBuilder<IList<GClass56>> asyncTaskMethodBuilder_0;

		// Token: 0x04000A25 RID: 2597
		public string string_0;

		// Token: 0x04000A26 RID: 2598
		public string string_1;

		// Token: 0x04000A27 RID: 2599
		private string string_2;

		// Token: 0x04000A28 RID: 2600
		private TaskAwaiter<string> taskAwaiter_0;

		// Token: 0x04000A29 RID: 2601
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;

		// Token: 0x04000A2A RID: 2602
		private TaskAwaiter<IList<GClass56>> taskAwaiter_2;
	}

	// Token: 0x020002DB RID: 731
	[StructLayout(LayoutKind.Auto)]
	private struct Struct152 : IAsyncStateMachine
	{
		// Token: 0x060010DD RID: 4317 RVA: 0x00046FB8 File Offset: 0x000451B8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result2;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<HttpResponseMessage> awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					goto IL_146;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_1A2;
				default:
					this.string_2 = GClass82.smethod_6("WUIDRequest.xml");
					awaiter = GClass82.smethod_3().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass82.Struct152>(ref awaiter, ref this);
						return;
					}
					break;
				}
				string result = awaiter.GetResult();
				HttpContent content = new StringContent(string.Format(this.string_2, result, this.string_0, this.string_1 ?? GClass82.string_0), Encoding.UTF8, "application/soap+xml");
				this.string_2 = null;
				HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
				httpRequestMessage.RequestUri = GClass20.uri_0;
				httpRequestMessage.Content = content;
				httpRequestMessage.Method = HttpMethod.Post;
				awaiter2 = GClass82.gclass15_0.SendAsync(httpRequestMessage, default(CancellationToken)).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass82.Struct152>(ref awaiter2, ref this);
					return;
				}
				IL_146:
				awaiter = awaiter2.GetResult().Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass82.Struct152>(ref awaiter, ref this);
					return;
				}
				IL_1A2:
				result2 = HttpUtility.HtmlDecode(awaiter.GetResult());
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

		// Token: 0x060010DE RID: 4318 RVA: 0x000471C4 File Offset: 0x000453C4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A2B RID: 2603
		public int int_0;

		// Token: 0x04000A2C RID: 2604
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000A2D RID: 2605
		public string string_0;

		// Token: 0x04000A2E RID: 2606
		public string string_1;

		// Token: 0x04000A2F RID: 2607
		private string string_2;

		// Token: 0x04000A30 RID: 2608
		private TaskAwaiter<string> taskAwaiter_0;

		// Token: 0x04000A31 RID: 2609
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;
	}

	// Token: 0x020002DC RID: 732
	[StructLayout(LayoutKind.Auto)]
	private struct Struct153 : IAsyncStateMachine
	{
		// Token: 0x060010DF RID: 4319 RVA: 0x000471D4 File Offset: 0x000453D4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			IList<Uri> result3;
			try
			{
				if (num > 1)
				{
					this.xmlDocument_0 = new XmlDocument();
					this.ilist_2 = new List<Uri>();
					this.ienumerator_0 = this.ilist_0.GetEnumerator();
				}
				try
				{
					TaskAwaiter<HttpResponseMessage> awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_162;
					}
					TaskAwaiter<string> awaiter2;
					if (num == 1)
					{
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<string>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
						goto IL_192;
					}
					IL_45:
					if (!this.ienumerator_0.MoveNext())
					{
						goto IL_2CD;
					}
					string text = this.ienumerator_0.Current;
					HttpContent content = new StringContent(string.Format(GClass82.smethod_6("FE3FileUrl.xml"), text, this.ilist_1[this.ilist_0.IndexOf(text)], this.string_0 ?? GClass82.string_0), Encoding.UTF8, "application/soap+xml");
					HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
					httpRequestMessage.RequestUri = GClass20.uri_1;
					httpRequestMessage.Content = content;
					httpRequestMessage.Method = HttpMethod.Post;
					awaiter = GClass82.gclass15_0.SendAsync(httpRequestMessage, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num4 = 0;
						num = 0;
						this.int_0 = num4;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass82.Struct153>(ref awaiter, ref this);
						return;
					}
					IL_162:
					HttpResponseMessage result = awaiter.GetResult();
					this.xmlDocument_1 = this.xmlDocument_0;
					awaiter2 = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						goto IL_28B;
					}
					IL_192:
					string result2 = awaiter2.GetResult();
					this.xmlDocument_1.LoadXml(result2);
					this.xmlDocument_1 = null;
					IEnumerator enumerator = this.xmlDocument_0.GetElementsByTagName("FileLocation").GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							IEnumerator enumerator2 = ((XmlNode)obj).ChildNodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									object obj2 = enumerator2.Current;
									XmlNode xmlNode = (XmlNode)obj2;
									if (xmlNode.Name == "Url" && xmlNode.InnerText.Length != 99)
									{
										this.ilist_2.Add(new Uri(xmlNode.InnerText));
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									IDisposable disposable = enumerator2 as IDisposable;
									if (disposable != null)
									{
										disposable.Dispose();
									}
								}
							}
						}
						goto IL_45;
					}
					finally
					{
						if (num < 0)
						{
							IDisposable disposable = enumerator as IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
					IL_28B:
					int num5 = 1;
					num = 1;
					this.int_0 = num5;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass82.Struct153>(ref awaiter2, ref this);
					return;
				}
				finally
				{
					if (num < 0 && this.ienumerator_0 != null)
					{
						this.ienumerator_0.Dispose();
					}
				}
				IL_2CD:
				this.ienumerator_0 = null;
				result3 = this.ilist_2;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.xmlDocument_0 = null;
				this.ilist_2 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.xmlDocument_0 = null;
			this.ilist_2 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result3);
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00047574 File Offset: 0x00045774
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A32 RID: 2610
		public int int_0;

		// Token: 0x04000A33 RID: 2611
		public AsyncTaskMethodBuilder<IList<Uri>> asyncTaskMethodBuilder_0;

		// Token: 0x04000A34 RID: 2612
		public IList<string> ilist_0;

		// Token: 0x04000A35 RID: 2613
		public IList<string> ilist_1;

		// Token: 0x04000A36 RID: 2614
		public string string_0;

		// Token: 0x04000A37 RID: 2615
		private XmlDocument xmlDocument_0;

		// Token: 0x04000A38 RID: 2616
		private IList<Uri> ilist_2;

		// Token: 0x04000A39 RID: 2617
		private IEnumerator<string> ienumerator_0;

		// Token: 0x04000A3A RID: 2618
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000A3B RID: 2619
		private XmlDocument xmlDocument_1;

		// Token: 0x04000A3C RID: 2620
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x020002DD RID: 733
	private sealed class Class356
	{
		// Token: 0x060010E2 RID: 4322 RVA: 0x0004758C File Offset: 0x0004578C
		internal IList<GClass56> method_0()
		{
			IList<GClass56> list = new List<GClass56>();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(this.string_0);
			foreach (object obj in xmlDocument.GetElementsByTagName("AppxMetadata"))
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes.Count >= 3)
				{
					GClass56 item = new GClass56(xmlNode.Attributes.GetNamedItem("PackageMoniker").Value, new Uri("http://test.com"), GClass73.smethod_3(xmlNode.Attributes.GetNamedItem("PackageType").Value), JsonConvert.DeserializeObject<GClass2>(xmlNode.FirstChild.InnerText), string.Empty);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x04000A3D RID: 2621
		public string string_0;
	}
}
