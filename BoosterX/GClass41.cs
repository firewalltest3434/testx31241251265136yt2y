using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

// Token: 0x020001DE RID: 478
public sealed class GClass41
{
	// Token: 0x06000B3A RID: 2874 RVA: 0x000342B0 File Offset: 0x000324B0
	public GClass41(GClass191 gclass191_1, GClass89 gclass89_0 = null, GClass45 gclass45_1 = null)
	{
		this.method_1(new GClass45(gclass45_1));
		if (gclass89_0 != null)
		{
			this.method_0().String_0 = gclass89_0;
		}
		if (this.method_0().String_0 == null)
		{
			this.method_0().String_0 = GClass89.smethod_2();
		}
		this.list_0 = new List<GClass163>();
		this.gclass191_0 = gclass191_1;
		this.method_0().Nullable_2 = new int?(1);
		this.method_0().Boolean_0 = false;
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x0003433C File Offset: 0x0003253C
	public GClass45 method_0()
	{
		return this.gclass45_0;
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x00034344 File Offset: 0x00032544
	private void method_1(GClass45 gclass45_1)
	{
		this.gclass45_0 = gclass45_1;
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x00034350 File Offset: 0x00032550
	public GClass89 method_2()
	{
		return this.method_0().String_0;
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x00034364 File Offset: 0x00032564
	public void method_3(GClass89 gclass89_0)
	{
		this.method_0().String_0 = gclass89_0;
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x00034378 File Offset: 0x00032578
	public GClass38 method_4()
	{
		return this.gclass38_0;
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x00034380 File Offset: 0x00032580
	private void method_5(GClass38 gclass38_1)
	{
		this.gclass38_0 = gclass38_1;
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x0003438C File Offset: 0x0003258C
	public IList<GClass163> method_6()
	{
		return this.list_0;
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x00034394 File Offset: 0x00032594
	public void method_7(GClass163 gclass163_0)
	{
		this.list_0.Add(gclass163_0);
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x000343A4 File Offset: 0x000325A4
	public void method_8(GClass170 gclass170_0, string string_0, GClass163.GClass164[] gclass164_0)
	{
		this.method_7(new GClass163(gclass170_0, string_0, gclass164_0));
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x000343B4 File Offset: 0x000325B4
	public void method_9(string string_0, GClass163.GClass164[] gclass164_0)
	{
		this.method_7(new GClass163(GClass170.smethod_2(), string_0, gclass164_0));
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x000343C8 File Offset: 0x000325C8
	public void method_10(string string_0, string string_1, GClass163.GClass164[] gclass164_0)
	{
		this.method_7(new GClass163(GClass170.smethod_2(), string_1, gclass164_0)
		{
			Name = string_0
		});
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x000343E4 File Offset: 0x000325E4
	public void method_11(string string_0)
	{
		this.method_7(new GClass163(GClass170.smethod_1(), string_0));
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x000343F8 File Offset: 0x000325F8
	public void method_12(string string_0)
	{
		this.method_7(new GClass163(GClass170.smethod_3(), string_0));
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x0003440C File Offset: 0x0003260C
	public void method_13(EventHandler<List<GClass163>> eventHandler_1)
	{
		EventHandler<List<GClass163>> eventHandler = this.eventHandler_0;
		EventHandler<List<GClass163>> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<List<GClass163>> value = (EventHandler<List<GClass163>>)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler<List<GClass163>>>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x00034444 File Offset: 0x00032644
	public void method_14(EventHandler<List<GClass163>> eventHandler_1)
	{
		EventHandler<List<GClass163>> eventHandler = this.eventHandler_0;
		EventHandler<List<GClass163>> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<List<GClass163>> value = (EventHandler<List<GClass163>>)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler<List<GClass163>>>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x0003447C File Offset: 0x0003267C
	public bool method_15()
	{
		return this.bool_0;
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x00034484 File Offset: 0x00032684
	public void method_16(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x00034490 File Offset: 0x00032690
	public Task<string> method_17()
	{
		GClass41.Struct106 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass41_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass41.Struct106>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x000344D4 File Offset: 0x000326D4
	public Task<string> method_18()
	{
		return this.method_17();
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x000344DC File Offset: 0x000326DC
	public Task method_19(Action<string> action_0)
	{
		GClass41.Struct105 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass41_0 = this;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass41.Struct105>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x00034528 File Offset: 0x00032728
	public Task method_20(Action<int, string> action_0)
	{
		GClass41.Struct104 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass41_0 = this;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass41.Struct104>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x00034574 File Offset: 0x00032774
	[AsyncIteratorStateMachine]
	public IAsyncEnumerable<string> method_21()
	{
		return new GClass41.Class260(-2)
		{
			gclass41_0 = this
		};
	}

	// Token: 0x040006ED RID: 1773
	private GClass191 gclass191_0;

	// Token: 0x040006EE RID: 1774
	private GClass45 gclass45_0;

	// Token: 0x040006EF RID: 1775
	private GClass38 gclass38_0;

	// Token: 0x040006F0 RID: 1776
	private List<GClass163> list_0;

	// Token: 0x040006F1 RID: 1777
	private EventHandler<List<GClass163>> eventHandler_0;

	// Token: 0x040006F2 RID: 1778
	private bool bool_0 = true;

	// Token: 0x020001DF RID: 479
	[StructLayout(LayoutKind.Auto)]
	private struct Struct104 : IAsyncStateMachine
	{
		// Token: 0x06000B51 RID: 2897 RVA: 0x00034584 File Offset: 0x00032784
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass41 gclass = this.gclass41_0;
			try
			{
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_76;
					}
					this.int_1 = 0;
					this.iasyncEnumerator_0 = gclass.method_21().GetAsyncEnumerator(default(CancellationToken));
					this.object_0 = null;
					this.int_2 = 0;
				}
				ValueTaskAwaiter awaiter2;
				Exception ex;
				for (;;)
				{
					try
					{
						ValueTaskAwaiter<bool> awaiter;
						if (num == 0)
						{
							awaiter = this.valueTaskAwaiter_0;
							this.valueTaskAwaiter_0 = default(ValueTaskAwaiter<bool>);
							this.int_0 = -1;
							goto IL_101;
						}
						IL_E0:
						awaiter = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.valueTaskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass41.Struct104>(ref awaiter, ref this);
							return;
						}
						IL_101:
						if (!awaiter.GetResult())
						{
							goto IL_142;
						}
						string arg = this.iasyncEnumerator_0.Current;
						Action<int, string> action = this.action_0;
						int num2 = this.int_1;
						this.int_1 = num2 + 1;
						action(num2, arg);
						goto IL_E0;
						IL_76:
						awaiter2 = this.valueTaskAwaiter_1;
						this.valueTaskAwaiter_1 = default(ValueTaskAwaiter);
						this.int_0 = -1;
						IL_93:
						awaiter2.GetResult();
						IL_9A:
						object obj = this.object_0;
						if (obj == null)
						{
							goto IL_19D;
						}
						ex = (obj as Exception);
						if (ex != null)
						{
							goto IL_193;
						}
						throw obj;
					}
					catch (object obj)
					{
						object obj;
						this.object_0 = obj;
					}
					IL_142:
					if (this.iasyncEnumerator_0 == null)
					{
						goto IL_9A;
					}
					awaiter2 = this.iasyncEnumerator_0.DisposeAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						break;
					}
					goto IL_93;
				}
				this.int_0 = 1;
				this.valueTaskAwaiter_1 = awaiter2;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass41.Struct104>(ref awaiter2, ref this);
				return;
				IL_193:
				ExceptionDispatchInfo.Capture(ex).Throw();
				IL_19D:
				this.object_0 = null;
				this.iasyncEnumerator_0 = null;
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

		// Token: 0x06000B52 RID: 2898 RVA: 0x000347A4 File Offset: 0x000329A4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006F3 RID: 1779
		public int int_0;

		// Token: 0x040006F4 RID: 1780
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040006F5 RID: 1781
		public GClass41 gclass41_0;

		// Token: 0x040006F6 RID: 1782
		public Action<int, string> action_0;

		// Token: 0x040006F7 RID: 1783
		private int int_1;

		// Token: 0x040006F8 RID: 1784
		private IAsyncEnumerator<string> iasyncEnumerator_0;

		// Token: 0x040006F9 RID: 1785
		private object object_0;

		// Token: 0x040006FA RID: 1786
		private int int_2;

		// Token: 0x040006FB RID: 1787
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x040006FC RID: 1788
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}

	// Token: 0x020001E0 RID: 480
	[StructLayout(LayoutKind.Auto)]
	private struct Struct105 : IAsyncStateMachine
	{
		// Token: 0x06000B53 RID: 2899 RVA: 0x000347B4 File Offset: 0x000329B4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass41 gclass = this.gclass41_0;
			try
			{
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_6F;
					}
					this.iasyncEnumerator_0 = gclass.method_21().GetAsyncEnumerator(default(CancellationToken));
					this.object_0 = null;
					this.int_1 = 0;
				}
				ValueTaskAwaiter awaiter2;
				Exception ex;
				for (;;)
				{
					try
					{
						ValueTaskAwaiter<bool> awaiter;
						if (num == 0)
						{
							awaiter = this.valueTaskAwaiter_0;
							this.valueTaskAwaiter_0 = default(ValueTaskAwaiter<bool>);
							this.int_0 = -1;
							goto IL_E8;
						}
						IL_C7:
						awaiter = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.valueTaskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass41.Struct105>(ref awaiter, ref this);
							return;
						}
						IL_E8:
						if (!awaiter.GetResult())
						{
							goto IL_129;
						}
						string obj = this.iasyncEnumerator_0.Current;
						this.action_0(obj);
						goto IL_C7;
						IL_6F:
						awaiter2 = this.valueTaskAwaiter_1;
						this.valueTaskAwaiter_1 = default(ValueTaskAwaiter);
						this.int_0 = -1;
						IL_8B:
						awaiter2.GetResult();
						IL_92:
						object obj2 = this.object_0;
						if (obj2 == null)
						{
							goto IL_182;
						}
						ex = (obj2 as Exception);
						if (ex != null)
						{
							goto IL_178;
						}
						throw obj2;
					}
					catch (object obj2)
					{
						object obj2;
						this.object_0 = obj2;
					}
					IL_129:
					if (this.iasyncEnumerator_0 == null)
					{
						goto IL_92;
					}
					awaiter2 = this.iasyncEnumerator_0.DisposeAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						break;
					}
					goto IL_8B;
				}
				this.int_0 = 1;
				this.valueTaskAwaiter_1 = awaiter2;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass41.Struct105>(ref awaiter2, ref this);
				return;
				IL_178:
				ExceptionDispatchInfo.Capture(ex).Throw();
				IL_182:
				this.object_0 = null;
				this.iasyncEnumerator_0 = null;
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

		// Token: 0x06000B54 RID: 2900 RVA: 0x000349BC File Offset: 0x00032BBC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006FD RID: 1789
		public int int_0;

		// Token: 0x040006FE RID: 1790
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040006FF RID: 1791
		public GClass41 gclass41_0;

		// Token: 0x04000700 RID: 1792
		public Action<string> action_0;

		// Token: 0x04000701 RID: 1793
		private IAsyncEnumerator<string> iasyncEnumerator_0;

		// Token: 0x04000702 RID: 1794
		private object object_0;

		// Token: 0x04000703 RID: 1795
		private int int_1;

		// Token: 0x04000704 RID: 1796
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x04000705 RID: 1797
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}

	// Token: 0x020001E1 RID: 481
	[StructLayout(LayoutKind.Auto)]
	private struct Struct106 : IAsyncStateMachine
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x000349CC File Offset: 0x00032BCC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass41 gclass = this.gclass41_0;
			string result2;
			try
			{
				TaskAwaiter<string> awaiter;
				switch (num)
				{
				case 0:
					break;
				case 1:
					awaiter = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_357;
				case 2:
					awaiter = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_381;
				default:
					this.int_1 = 0;
					break;
				}
				try
				{
					TaskAwaiter<GClass38> awaiter2;
					if (num != 0)
					{
						GClass45 gclass2 = new GClass45(gclass.method_0());
						gclass2.IList_0 = gclass.list_0.ToList<GClass163>();
						awaiter2 = gclass.gclass191_0.imethod_3(gclass2).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass38>, GClass41.Struct106>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass38>);
						this.int_0 = -1;
					}
					GClass38 result = awaiter2.GetResult();
					gclass.method_5(result);
					if (result.IReadOnlyList_0.Count > 0)
					{
						GClass163 message = result.IReadOnlyList_0[0].Message;
						gclass.method_7(message);
						result2 = message.String_1;
						goto IL_3AB;
					}
				}
				catch (HttpRequestException ex)
				{
					this.object_0 = ex;
					this.int_1 = 1;
				}
				int num2 = this.int_1;
				if (num2 == 1)
				{
					HttpRequestException ex2 = (HttpRequestException)this.object_0;
					if (!ex2.Data.Contains("code") || string.IsNullOrEmpty(ex2.Data["code"] as string) || !ex2.Data["code"].Equals("context_length_exceeded"))
					{
						throw ex2;
					}
					string text = "The context length of this conversation is too long for the OpenAI API to handle.  Consider shortening the message history by handling the OnTruncationNeeded event and removing some of the messages in the argument.";
					if (ex2.Data.Contains("message"))
					{
						text = text + "  " + ex2.Data["message"].ToString();
					}
					if (gclass.eventHandler_0 != null)
					{
						int num3 = gclass.method_6().Sum(new Func<GClass163, int>(GClass41.Class259.class259_0.method_0));
						gclass.eventHandler_0(gclass, gclass.list_0);
						if (num3 <= gclass.method_6().Sum(new Func<GClass163, int>(GClass41.Class259.class259_0.method_1)))
						{
							throw new ArgumentOutOfRangeException("OnTruncationNeeded was called but it did not reduce the message history length.  " + text, ex2);
						}
						awaiter = gclass.method_17().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_1 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass41.Struct106>(ref awaiter, ref this);
							return;
						}
						goto IL_357;
					}
					else
					{
						if (!gclass.method_15())
						{
							throw new ArgumentOutOfRangeException(text, ex2);
						}
						int i = 0;
						while (i < gclass.list_0.Count)
						{
							if (gclass.list_0[i].GClass170_0 != GClass170.smethod_1())
							{
								gclass.list_0.RemoveAt(i);
								awaiter = gclass.method_17().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 2;
									this.taskAwaiter_1 = awaiter;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass41.Struct106>(ref awaiter, ref this);
									return;
								}
								goto IL_381;
							}
							else
							{
								i++;
							}
						}
					}
				}
				this.object_0 = null;
				result2 = null;
				goto IL_3AB;
				IL_357:
				result2 = awaiter.GetResult();
				goto IL_3AB;
				IL_381:
				result2 = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_3AB:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00034DD0 File Offset: 0x00032FD0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000706 RID: 1798
		public int int_0;

		// Token: 0x04000707 RID: 1799
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000708 RID: 1800
		public GClass41 gclass41_0;

		// Token: 0x04000709 RID: 1801
		private object object_0;

		// Token: 0x0400070A RID: 1802
		private int int_1;

		// Token: 0x0400070B RID: 1803
		private TaskAwaiter<GClass38> taskAwaiter_0;

		// Token: 0x0400070C RID: 1804
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x020001E2 RID: 482
	[Serializable]
	private sealed class Class259
	{
		// Token: 0x06000B59 RID: 2905 RVA: 0x00034DF4 File Offset: 0x00032FF4
		internal int method_0(GClass163 gclass163_0)
		{
			return gclass163_0.String_1.Length;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00034E04 File Offset: 0x00033004
		internal int method_1(GClass163 gclass163_0)
		{
			return gclass163_0.String_1.Length;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00034E14 File Offset: 0x00033014
		internal int method_2(GClass163 gclass163_0)
		{
			return gclass163_0.String_1.Length;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00034E24 File Offset: 0x00033024
		internal int method_3(GClass163 gclass163_0)
		{
			return gclass163_0.String_1.Length;
		}

		// Token: 0x0400070D RID: 1805
		public static readonly GClass41.Class259 class259_0 = new GClass41.Class259();

		// Token: 0x0400070E RID: 1806
		public static Func<GClass163, int> func_0;

		// Token: 0x0400070F RID: 1807
		public static Func<GClass163, int> func_1;

		// Token: 0x04000710 RID: 1808
		public static Func<GClass163, int> func_2;

		// Token: 0x04000711 RID: 1809
		public static Func<GClass163, int> func_3;
	}

	// Token: 0x020001E3 RID: 483
	private sealed class Class260 : IAsyncEnumerable<string>, IAsyncEnumerator<string>, IValueTaskSource<bool>, IAsyncStateMachine, IAsyncDisposable, IValueTaskSource
	{
		// Token: 0x06000B5D RID: 2909 RVA: 0x00034E34 File Offset: 0x00033034
		public Class260(int int_2)
		{
			this.asyncIteratorMethodBuilder_0 = AsyncIteratorMethodBuilder.Create();
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00034E5C File Offset: 0x0003305C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass41 gclass = this.gclass41_0;
			try
			{
				ValueTaskAwaiter<bool> awaiter;
				switch (num)
				{
				case -4:
				{
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					if (this.bool_0)
					{
						goto IL_4B6;
					}
					goto IL_3C2;
				}
				default:
				{
					if (this.bool_0)
					{
						goto IL_4B6;
					}
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					GClass45 gclass2 = null;
					this.stringBuilder_0 = new StringBuilder();
					this.gclass170_0 = null;
					this.iasyncEnumerable_0 = null;
					this.bool_1 = true;
					this.iasyncEnumerator_0 = null;
					break;
				}
				case 0:
					IL_B6:
					try
					{
						if (num != 0)
						{
							GClass45 gclass2;
							this.iasyncEnumerable_0 = gclass.gclass191_0.imethod_10(gclass2);
							this.iasyncEnumerator_0 = this.iasyncEnumerable_0.GetAsyncEnumerator(default(CancellationToken));
							awaiter = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num4 = 0;
								num = 0;
								this.int_0 = num4;
								this.valueTaskAwaiter_0 = awaiter;
								GClass41.Class260 @class = this;
								this.asyncIteratorMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass41.Class260>(ref awaiter, ref @class);
								return;
							}
						}
						else
						{
							awaiter = this.valueTaskAwaiter_0;
							this.valueTaskAwaiter_0 = default(ValueTaskAwaiter<bool>);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
						}
						awaiter.GetResult();
						GClass38 gclass3 = this.iasyncEnumerator_0.Current;
					}
					catch (HttpRequestException ex)
					{
						if (!ex.Data.Contains("code") || string.IsNullOrEmpty(ex.Data["code"] as string) || !ex.Data["code"].Equals("context_length_exceeded"))
						{
							throw ex;
						}
						string text = "The context length of this conversation is too long for the OpenAI API to handle.  Consider shortening the message history by handling the OnTruncationNeeded event and removing some of the messages in the argument.";
						if (ex.Data.Contains("message"))
						{
							text = text + "  " + ex.Data["message"].ToString();
						}
						if (gclass.eventHandler_0 != null)
						{
							int num6 = gclass.method_6().Sum(new Func<GClass163, int>(GClass41.Class259.class259_0.method_2));
							gclass.eventHandler_0(gclass, gclass.list_0);
							if (num6 <= gclass.method_6().Sum(new Func<GClass163, int>(GClass41.Class259.class259_0.method_3)))
							{
								this.bool_1 = false;
								throw new ArgumentOutOfRangeException("OnTruncationNeeded was called but it did not reduce the message history length.  " + text, ex);
							}
							this.bool_1 = true;
						}
						else
						{
							if (!gclass.method_15())
							{
								this.bool_1 = false;
								throw new ArgumentOutOfRangeException(text, ex);
							}
							for (int i = 0; i < gclass.list_0.Count; i++)
							{
								if (gclass.list_0[i].GClass170_0 != GClass170.smethod_1())
								{
									gclass.list_0.RemoveAt(i);
									this.bool_1 = true;
									break;
								}
							}
						}
					}
					break;
				case 1:
				{
					awaiter = this.valueTaskAwaiter_0;
					this.valueTaskAwaiter_0 = default(ValueTaskAwaiter<bool>);
					int num7 = -1;
					num = -1;
					this.int_0 = num7;
					goto IL_3F6;
				}
				}
				if (this.bool_1)
				{
					this.bool_1 = false;
					GClass45 gclass2 = new GClass45(gclass.method_0());
					gclass2.IList_0 = gclass.list_0.ToList<GClass163>();
					goto IL_B6;
				}
				if (this.iasyncEnumerable_0 == null)
				{
					throw new Exception("The chat result stream is null, but it shouldn't be");
				}
				IL_358:
				this.gclass38_0 = this.iasyncEnumerator_0.Current;
				GClass70 gclass4 = this.gclass38_0.IReadOnlyList_0.FirstOrDefault<GClass70>();
				GClass163 gclass5 = (gclass4 != null) ? gclass4.GClass163_0 : null;
				if (gclass5 != null)
				{
					if (gclass5.GClass170_0 != null)
					{
						this.gclass170_0 = gclass5.GClass170_0;
					}
					string string_ = gclass5.String_1;
					if (!string.IsNullOrEmpty(string_))
					{
						this.stringBuilder_0.Append(string_);
						this.string_0 = string_;
						int num8 = -4;
						num = -4;
						this.int_0 = num8;
						goto IL_4A9;
					}
				}
				IL_3C2:
				gclass.method_5(this.gclass38_0);
				this.gclass38_0 = null;
				awaiter = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num9 = 1;
					num = 1;
					this.int_0 = num9;
					this.valueTaskAwaiter_0 = awaiter;
					GClass41.Class260 @class = this;
					this.asyncIteratorMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass41.Class260>(ref awaiter, ref @class);
					return;
				}
				IL_3F6:
				if (!awaiter.GetResult())
				{
					if (this.gclass170_0 != null)
					{
						gclass.method_8(this.gclass170_0, this.stringBuilder_0.ToString(), Array.Empty<GClass163.GClass164>());
					}
					goto IL_4B6;
				}
				goto IL_358;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.string_0 = null;
				this.asyncIteratorMethodBuilder_0.Complete();
				this.manualResetValueTaskSourceCore_0.SetException(exception);
				return;
			}
			IL_4A9:
			this.manualResetValueTaskSourceCore_0.SetResult(true);
			return;
			IL_4B6:
			this.int_0 = -2;
			this.string_0 = null;
			this.asyncIteratorMethodBuilder_0.Complete();
			this.manualResetValueTaskSourceCore_0.SetResult(false);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0003537C File Offset: 0x0003357C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00035380 File Offset: 0x00033580
		[return: Attribute8(new byte[]
		{
			1,
			0
		})]
		IAsyncEnumerator<string> IAsyncEnumerable<string>.GetAsyncEnumerator(CancellationToken cancellationToken_0)
		{
			GClass41.Class260 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = -3;
				this.asyncIteratorMethodBuilder_0 = AsyncIteratorMethodBuilder.Create();
				this.bool_0 = false;
				@class = this;
			}
			else
			{
				@class = new GClass41.Class260(-3);
				@class.gclass41_0 = this.gclass41_0;
			}
			return @class;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x000353D8 File Offset: 0x000335D8
		ValueTask<bool> IAsyncEnumerator<string>.MoveNextAsync()
		{
			if (this.int_0 == -2)
			{
				return default(ValueTask<bool>);
			}
			this.manualResetValueTaskSourceCore_0.Reset();
			GClass41.Class260 @class = this;
			this.asyncIteratorMethodBuilder_0.MoveNext<GClass41.Class260>(ref @class);
			short version = this.manualResetValueTaskSourceCore_0.Version;
			if (this.manualResetValueTaskSourceCore_0.GetStatus(version) == 1)
			{
				return new ValueTask<bool>(this.manualResetValueTaskSourceCore_0.GetResult(version));
			}
			return new ValueTask<bool>(this, version);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00035448 File Offset: 0x00033648
		string IAsyncEnumerator<string>.get_Current()
		{
			return this.string_0;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00035450 File Offset: 0x00033650
		bool IValueTaskSource<bool>.GetResult(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetResult(short_0);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00035460 File Offset: 0x00033660
		ValueTaskSourceStatus IValueTaskSource<bool>.GetStatus(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetStatus(short_0);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00035470 File Offset: 0x00033670
		void IValueTaskSource<bool>.OnCompleted(Action<object> action_0, object object_0, short short_0, ValueTaskSourceOnCompletedFlags valueTaskSourceOnCompletedFlags_0)
		{
			this.manualResetValueTaskSourceCore_0.OnCompleted(action_0, object_0, short_0, valueTaskSourceOnCompletedFlags_0);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00035484 File Offset: 0x00033684
		void IValueTaskSource.GetResult(short short_0)
		{
			this.manualResetValueTaskSourceCore_0.GetResult(short_0);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00035494 File Offset: 0x00033694
		ValueTaskSourceStatus IValueTaskSource.GetStatus(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetStatus(short_0);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x000354A4 File Offset: 0x000336A4
		void IValueTaskSource.OnCompleted(Action<object> action_0, object object_0, short short_0, ValueTaskSourceOnCompletedFlags valueTaskSourceOnCompletedFlags_0)
		{
			this.manualResetValueTaskSourceCore_0.OnCompleted(action_0, object_0, short_0, valueTaskSourceOnCompletedFlags_0);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x000354B8 File Offset: 0x000336B8
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
			GClass41.Class260 @class = this;
			this.asyncIteratorMethodBuilder_0.MoveNext<GClass41.Class260>(ref @class);
			return new ValueTask(this, this.manualResetValueTaskSourceCore_0.Version);
		}

		// Token: 0x04000712 RID: 1810
		public int int_0;

		// Token: 0x04000713 RID: 1811
		public AsyncIteratorMethodBuilder asyncIteratorMethodBuilder_0;

		// Token: 0x04000714 RID: 1812
		public ManualResetValueTaskSourceCore<bool> manualResetValueTaskSourceCore_0;

		// Token: 0x04000715 RID: 1813
		private string string_0;

		// Token: 0x04000716 RID: 1814
		private bool bool_0;

		// Token: 0x04000717 RID: 1815
		private int int_1;

		// Token: 0x04000718 RID: 1816
		public GClass41 gclass41_0;

		// Token: 0x04000719 RID: 1817
		private StringBuilder stringBuilder_0;

		// Token: 0x0400071A RID: 1818
		private GClass170 gclass170_0;

		// Token: 0x0400071B RID: 1819
		private IAsyncEnumerable<GClass38> iasyncEnumerable_0;

		// Token: 0x0400071C RID: 1820
		private bool bool_1;

		// Token: 0x0400071D RID: 1821
		private IAsyncEnumerator<GClass38> iasyncEnumerator_0;

		// Token: 0x0400071E RID: 1822
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x0400071F RID: 1823
		private GClass38 gclass38_0;
	}
}
