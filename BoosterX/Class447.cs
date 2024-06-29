using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020003D2 RID: 978
internal sealed class Class447
{
	// Token: 0x060015A0 RID: 5536 RVA: 0x00059F3C File Offset: 0x0005813C
	public static Task<List<double>> smethod_0(string string_0, int int_0)
	{
		Class447.Struct207 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<double>>.Create();
		@struct.string_0 = string_0;
		@struct.int_1 = int_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class447.Struct207>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x00059F88 File Offset: 0x00058188
	public static Task smethod_1(string string_0)
	{
		Class447.Struct208 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class447.Struct208>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x00059FCC File Offset: 0x000581CC
	public static Task<List<Class675>> smethod_2(string string_0, int int_0, int int_1, int int_2, bool bool_0, int int_3, int int_4)
	{
		Class447.Struct206 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class675>>.Create();
		@struct.string_0 = string_0;
		@struct.int_1 = int_0;
		@struct.int_2 = int_1;
		@struct.int_3 = int_2;
		@struct.bool_0 = bool_0;
		@struct.int_4 = int_3;
		@struct.int_5 = int_4;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class447.Struct206>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x0005A044 File Offset: 0x00058244
	private static Task smethod_3(int int_0, bool bool_0, int int_1, int int_2)
	{
		Class447.Struct210 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_1 = int_0;
		@struct.bool_0 = bool_0;
		@struct.int_2 = int_1;
		@struct.int_3 = int_2;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class447.Struct210>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x0005A0A0 File Offset: 0x000582A0
	public static Task<List<double>> smethod_4(string string_0, int int_0, int int_1, int int_2, bool bool_0, int int_3, int int_4)
	{
		Class447.Struct205 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<double>>.Create();
		@struct.string_0 = string_0;
		@struct.int_2 = int_0;
		@struct.int_1 = int_1;
		@struct.int_3 = int_2;
		@struct.bool_0 = bool_0;
		@struct.int_4 = int_3;
		@struct.int_5 = int_4;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class447.Struct205>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x0005A118 File Offset: 0x00058318
	private static Task smethod_5(string string_0, int int_0, int int_1, bool bool_0, int int_2, int int_3)
	{
		Class447.Struct209 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.string_0 = string_0;
		@struct.int_1 = int_0;
		@struct.int_2 = int_1;
		@struct.bool_0 = bool_0;
		@struct.int_3 = int_2;
		@struct.int_4 = int_3;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class447.Struct209>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000D81 RID: 3457
	private static List<double> list_0 = new List<double>();

	// Token: 0x04000D82 RID: 3458
	private static readonly object object_0 = new object();

	// Token: 0x04000D83 RID: 3459
	private static List<Class675> list_1 = new List<Class675>();

	// Token: 0x04000D84 RID: 3460
	private static readonly object object_1 = new object();

	// Token: 0x04000D85 RID: 3461
	private static TcpClient tcpClient_0;

	// Token: 0x04000D86 RID: 3462
	private static List<double> list_2 = new List<double>();

	// Token: 0x04000D87 RID: 3463
	private static readonly object object_2 = new object();

	// Token: 0x04000D88 RID: 3464
	private static UdpClient udpClient_0;

	// Token: 0x020003D3 RID: 979
	[StructLayout(LayoutKind.Auto)]
	private struct Struct205 : IAsyncStateMachine
	{
		// Token: 0x060015A6 RID: 5542 RVA: 0x0005A188 File Offset: 0x00058388
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<double> result;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_E5;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_11D;
				}
				if (Class447.udpClient_0 == null)
				{
					Class447.udpClient_0 = new UdpClient();
				}
				Class447.list_2.Clear();
				this.double_0 = 1000.0 / (double)this.int_1;
				this.list_0 = new List<Task>();
				this.int_6 = 0;
				IL_7E:
				if (this.int_6 < this.int_1)
				{
					this.list_0.Add(Class447.smethod_5(this.string_0, this.int_2, this.int_3, this.bool_0, this.int_4, this.int_5));
					awaiter = Task.Delay(TimeSpan.FromMilliseconds(this.double_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class447.Struct205>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = Task.WhenAll(this.list_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class447.Struct205>(ref awaiter, ref this);
						return;
					}
					goto IL_11D;
				}
				IL_E5:
				awaiter.GetResult();
				int num2 = this.int_6;
				this.int_6 = num2 + 1;
				goto IL_7E;
				IL_11D:
				awaiter.GetResult();
				result = new List<double>(Class447.list_2);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0005A388 File Offset: 0x00058588
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000D89 RID: 3465
		public int int_0;

		// Token: 0x04000D8A RID: 3466
		public AsyncTaskMethodBuilder<List<double>> asyncTaskMethodBuilder_0;

		// Token: 0x04000D8B RID: 3467
		public int int_1;

		// Token: 0x04000D8C RID: 3468
		public string string_0;

		// Token: 0x04000D8D RID: 3469
		public int int_2;

		// Token: 0x04000D8E RID: 3470
		public int int_3;

		// Token: 0x04000D8F RID: 3471
		public bool bool_0;

		// Token: 0x04000D90 RID: 3472
		public int int_4;

		// Token: 0x04000D91 RID: 3473
		public int int_5;

		// Token: 0x04000D92 RID: 3474
		private double double_0;

		// Token: 0x04000D93 RID: 3475
		private List<Task> list_0;

		// Token: 0x04000D94 RID: 3476
		private int int_6;

		// Token: 0x04000D95 RID: 3477
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003D4 RID: 980
	[StructLayout(LayoutKind.Auto)]
	private struct Struct206 : IAsyncStateMachine
	{
		// Token: 0x060015A8 RID: 5544 RVA: 0x0005A398 File Offset: 0x00058598
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class675> result;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_137;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_16F;
				}
				if (Class447.tcpClient_0 == null)
				{
					Class447.tcpClient_0 = new TcpClient();
				}
				if (!Class447.tcpClient_0.Connected && (!Class447.tcpClient_0.BeginConnect(this.string_0, this.int_1, null, null).AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(2.0)) || !Class447.tcpClient_0.Connected))
				{
					result = new List<Class675>();
					goto IL_20C;
				}
				Class447.list_1.Clear();
				this.double_0 = 1000.0 / (double)this.int_2;
				this.list_0 = new List<Task>();
				this.int_6 = 0;
				IL_DC:
				if (this.int_6 < this.int_2)
				{
					this.list_0.Add(Class447.smethod_3(this.int_3, this.bool_0, this.int_4, this.int_5));
					awaiter = Task.Delay(TimeSpan.FromMilliseconds(this.double_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class447.Struct206>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = Task.WhenAll(this.list_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class447.Struct206>(ref awaiter, ref this);
						return;
					}
					goto IL_16F;
				}
				IL_137:
				awaiter.GetResult();
				int num2 = this.int_6;
				this.int_6 = num2 + 1;
				goto IL_DC;
				IL_16F:
				awaiter.GetResult();
				result = new List<Class675>(Class447.list_1);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_20C:
			this.int_0 = -2;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0005A5E8 File Offset: 0x000587E8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000D96 RID: 3478
		public int int_0;

		// Token: 0x04000D97 RID: 3479
		public AsyncTaskMethodBuilder<List<Class675>> asyncTaskMethodBuilder_0;

		// Token: 0x04000D98 RID: 3480
		public string string_0;

		// Token: 0x04000D99 RID: 3481
		public int int_1;

		// Token: 0x04000D9A RID: 3482
		public int int_2;

		// Token: 0x04000D9B RID: 3483
		public int int_3;

		// Token: 0x04000D9C RID: 3484
		public bool bool_0;

		// Token: 0x04000D9D RID: 3485
		public int int_4;

		// Token: 0x04000D9E RID: 3486
		public int int_5;

		// Token: 0x04000D9F RID: 3487
		private double double_0;

		// Token: 0x04000DA0 RID: 3488
		private List<Task> list_0;

		// Token: 0x04000DA1 RID: 3489
		private int int_6;

		// Token: 0x04000DA2 RID: 3490
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003D5 RID: 981
	private sealed class Class448
	{
		// Token: 0x060015AB RID: 5547 RVA: 0x0005A600 File Offset: 0x00058800
		internal void method_0()
		{
			try
			{
				NetworkStream stream = Class447.tcpClient_0.GetStream();
				int num = this.int_0 * 1024;
				if (this.bool_0 && this.int_1 > 0 && this.int_2 > this.int_1)
				{
					num = new Random().Next(this.int_1, this.int_2) * 1024;
				}
				byte[] array = new byte[num];
				byte[] array2 = new byte[num];
				new Random().NextBytes(array);
				Stopwatch stopwatch = Stopwatch.StartNew();
				stream.Write(array, 0, array.Length);
				int num2;
				object object_;
				for (int i = 0; i < num; i += num2)
				{
					num2 = stream.Read(array2, i, num - i);
					if (num2 == 0)
					{
						IL_133:
						object_ = Class447.object_1;
						lock (object_)
						{
							List<Class675> list_ = Class447.list_1;
							Class675 @class = new Class675();
							@class.method_1(false);
							list_.Add(@class);
						}
						return;
					}
				}
				stopwatch.Stop();
				object_ = Class447.object_1;
				lock (object_)
				{
					if (Class333.smethod_1(array, array2))
					{
						List<Class675> list_2 = Class447.list_1;
						Class675 class2 = new Class675();
						class2.method_1(true);
						class2.method_3((double)stopwatch.ElapsedMilliseconds);
						list_2.Add(class2);
					}
					else
					{
						List<Class675> list_3 = Class447.list_1;
						Class675 class3 = new Class675();
						class3.method_1(false);
						list_3.Add(class3);
					}
					return;
				}
				goto IL_133;
			}
			catch
			{
				object object_ = Class447.object_1;
				lock (object_)
				{
					List<Class675> list_4 = Class447.list_1;
					Class675 class4 = new Class675();
					class4.method_1(false);
					list_4.Add(class4);
				}
			}
		}

		// Token: 0x04000DA3 RID: 3491
		public int int_0;

		// Token: 0x04000DA4 RID: 3492
		public bool bool_0;

		// Token: 0x04000DA5 RID: 3493
		public int int_1;

		// Token: 0x04000DA6 RID: 3494
		public int int_2;
	}

	// Token: 0x020003D6 RID: 982
	[StructLayout(LayoutKind.Auto)]
	private struct Struct207 : IAsyncStateMachine
	{
		// Token: 0x060015AC RID: 5548 RVA: 0x0005A820 File Offset: 0x00058A20
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<double> result;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_B3;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_EB;
				}
				Class447.list_0.Clear();
				this.double_0 = 1000.0 / (double)this.int_1;
				this.list_0 = new List<Task>();
				this.int_2 = 0;
				IL_6A:
				if (this.int_2 < this.int_1)
				{
					this.list_0.Add(Class447.smethod_1(this.string_0));
					awaiter = Task.Delay(TimeSpan.FromMilliseconds(this.double_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class447.Struct207>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = Task.WhenAll(this.list_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class447.Struct207>(ref awaiter, ref this);
						return;
					}
					goto IL_EB;
				}
				IL_B3:
				awaiter.GetResult();
				int num2 = this.int_2;
				this.int_2 = num2 + 1;
				goto IL_6A;
				IL_EB:
				awaiter.GetResult();
				result = new List<double>(Class447.list_0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0005A9EC File Offset: 0x00058BEC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000DA7 RID: 3495
		public int int_0;

		// Token: 0x04000DA8 RID: 3496
		public AsyncTaskMethodBuilder<List<double>> asyncTaskMethodBuilder_0;

		// Token: 0x04000DA9 RID: 3497
		public int int_1;

		// Token: 0x04000DAA RID: 3498
		public string string_0;

		// Token: 0x04000DAB RID: 3499
		private double double_0;

		// Token: 0x04000DAC RID: 3500
		private List<Task> list_0;

		// Token: 0x04000DAD RID: 3501
		private int int_2;

		// Token: 0x04000DAE RID: 3502
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003D7 RID: 983
	private sealed class Class449
	{
		// Token: 0x060015AF RID: 5551 RVA: 0x0005AA04 File Offset: 0x00058C04
		internal void method_0()
		{
			try
			{
				Class447.udpClient_0.Connect(this.string_0, this.int_0);
				int num = this.int_1;
				if (this.bool_0 && this.int_2 > 0 && this.int_3 > this.int_2)
				{
					num = new Random().Next(this.int_2, this.int_3) * 1024;
				}
				List<byte[]> list = new List<byte[]>();
				byte[] array = new byte[num];
				new Random().NextBytes(array);
				int num2 = 1301;
				if (array.Length > 1301)
				{
					for (int i = 0; i < array.Length; i += num2)
					{
						int num3 = Math.Min(num2, array.Length - i);
						byte[] array2 = new byte[num3];
						Array.Copy(array, i, array2, 0, num3);
						list.Add(array2);
					}
				}
				else
				{
					list.Add(array);
				}
				int j = 0;
				while (j < list.Count)
				{
					Stopwatch stopwatch = Stopwatch.StartNew();
					Class447.udpClient_0.Send(array, array.Length);
					IAsyncResult asyncResult = Class447.udpClient_0.BeginReceive(null, null);
					asyncResult.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1.0));
					object object_;
					if (asyncResult.IsCompleted)
					{
						IPEndPoint ipendPoint = null;
						Class447.udpClient_0.EndReceive(asyncResult, ref ipendPoint);
						stopwatch.Stop();
						double item = (double)stopwatch.ElapsedMilliseconds;
						object_ = Class447.object_2;
						lock (object_)
						{
							Class447.list_2.Add(item);
							goto IL_1C4;
						}
						goto IL_18F;
					}
					goto IL_18F;
					IL_1C4:
					j++;
					continue;
					IL_18F:
					object_ = Class447.object_2;
					lock (object_)
					{
						Class447.list_2.Add(-1.0);
					}
					goto IL_1C4;
				}
			}
			catch
			{
				object object_ = Class447.object_2;
				lock (object_)
				{
					Class447.list_2.Add(-1.0);
				}
			}
		}

		// Token: 0x04000DAF RID: 3503
		public string string_0;

		// Token: 0x04000DB0 RID: 3504
		public int int_0;

		// Token: 0x04000DB1 RID: 3505
		public int int_1;

		// Token: 0x04000DB2 RID: 3506
		public bool bool_0;

		// Token: 0x04000DB3 RID: 3507
		public int int_2;

		// Token: 0x04000DB4 RID: 3508
		public int int_3;
	}

	// Token: 0x020003D8 RID: 984
	[StructLayout(LayoutKind.Auto)]
	private struct Struct208 : IAsyncStateMachine
	{
		// Token: 0x060015B0 RID: 5552 RVA: 0x0005AC84 File Offset: 0x00058E84
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new Class447.Class450
					{
						string_0 = this.string_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class447.Struct208>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
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

		// Token: 0x060015B1 RID: 5553 RVA: 0x0005AD4C File Offset: 0x00058F4C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000DB5 RID: 3509
		public int int_0;

		// Token: 0x04000DB6 RID: 3510
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000DB7 RID: 3511
		public string string_0;

		// Token: 0x04000DB8 RID: 3512
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003D9 RID: 985
	[StructLayout(LayoutKind.Auto)]
	private struct Struct209 : IAsyncStateMachine
	{
		// Token: 0x060015B2 RID: 5554 RVA: 0x0005AD5C File Offset: 0x00058F5C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new Class447.Class449
					{
						string_0 = this.string_0,
						int_0 = this.int_1,
						int_1 = this.int_2,
						bool_0 = this.bool_0,
						int_2 = this.int_3,
						int_3 = this.int_4
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class447.Struct209>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
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

		// Token: 0x060015B3 RID: 5555 RVA: 0x0005AE64 File Offset: 0x00059064
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000DB9 RID: 3513
		public int int_0;

		// Token: 0x04000DBA RID: 3514
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000DBB RID: 3515
		public string string_0;

		// Token: 0x04000DBC RID: 3516
		public int int_1;

		// Token: 0x04000DBD RID: 3517
		public int int_2;

		// Token: 0x04000DBE RID: 3518
		public bool bool_0;

		// Token: 0x04000DBF RID: 3519
		public int int_3;

		// Token: 0x04000DC0 RID: 3520
		public int int_4;

		// Token: 0x04000DC1 RID: 3521
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003DA RID: 986
	[StructLayout(LayoutKind.Auto)]
	private struct Struct210 : IAsyncStateMachine
	{
		// Token: 0x060015B4 RID: 5556 RVA: 0x0005AE74 File Offset: 0x00059074
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new Class447.Class448
					{
						int_0 = this.int_1,
						bool_0 = this.bool_0,
						int_1 = this.int_2,
						int_2 = this.int_3
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class447.Struct210>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
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

		// Token: 0x060015B5 RID: 5557 RVA: 0x0005AF60 File Offset: 0x00059160
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000DC2 RID: 3522
		public int int_0;

		// Token: 0x04000DC3 RID: 3523
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000DC4 RID: 3524
		public int int_1;

		// Token: 0x04000DC5 RID: 3525
		public bool bool_0;

		// Token: 0x04000DC6 RID: 3526
		public int int_2;

		// Token: 0x04000DC7 RID: 3527
		public int int_3;

		// Token: 0x04000DC8 RID: 3528
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003DB RID: 987
	private sealed class Class450
	{
		// Token: 0x060015B7 RID: 5559 RVA: 0x0005AF78 File Offset: 0x00059178
		internal void method_0()
		{
			PingReply pingReply = new Ping().Send(this.string_0);
			object object_ = Class447.object_0;
			lock (object_)
			{
				Class447.list_0.Add((double)pingReply.RoundtripTime);
			}
		}

		// Token: 0x04000DC9 RID: 3529
		public string string_0;
	}
}
