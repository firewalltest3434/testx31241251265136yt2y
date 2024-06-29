using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x020001CC RID: 460
public sealed class GClass191 : GClass189, GInterface7
{
	// Token: 0x06000ADE RID: 2782 RVA: 0x00032BA8 File Offset: 0x00030DA8
	internal GClass191(GClass178 gclass178_1) : base(gclass178_1)
	{
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x00032BCC File Offset: 0x00030DCC
	[CompilerGenerated]
	public GClass45 imethod_0()
	{
		return this.gclass45_0;
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x00032BD4 File Offset: 0x00030DD4
	[CompilerGenerated]
	public void imethod_1(GClass45 gclass45_1)
	{
		this.gclass45_0 = gclass45_1;
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00032BE0 File Offset: 0x00030DE0
	protected override string vmethod_0()
	{
		return "chat/completions";
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x00032BE8 File Offset: 0x00030DE8
	public GClass41 imethod_2(GClass45 gclass45_1 = null)
	{
		return new GClass41(this, null, gclass45_1 ?? this.imethod_0());
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x00032BFC File Offset: 0x00030DFC
	public Task<GClass38> imethod_3(GClass45 gclass45_1)
	{
		GClass191.Struct98 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass38>.Create();
		@struct.gclass191_0 = this;
		@struct.gclass45_0 = gclass45_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass191.Struct98>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x00032C48 File Offset: 0x00030E48
	public Task<GClass38> imethod_4(GClass45 gclass45_1, int int_0 = 5)
	{
		gclass45_1.Nullable_2 = new int?(int_0);
		return this.imethod_3(gclass45_1);
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00032C60 File Offset: 0x00030E60
	public Task<GClass38> imethod_5(IList<GClass163> ilist_0, GClass89 gclass89_0 = null, double? nullable_0 = null, double? nullable_1 = null, int? nullable_2 = null, int? nullable_3 = null, double? nullable_4 = null, double? nullable_5 = null, IReadOnlyDictionary<string, float> ireadOnlyDictionary_0 = null, params string[] string_0)
	{
		GClass45 gclass = new GClass45(this.imethod_0());
		gclass.IList_0 = ilist_0;
		gclass.String_0 = (gclass89_0 ?? this.imethod_0().String_0);
		double? num = nullable_0;
		gclass.Nullable_0 = ((num != null) ? num : this.imethod_0().Nullable_0);
		num = nullable_1;
		gclass.Nullable_1 = ((num != null) ? num : this.imethod_0().Nullable_1);
		int? num2 = nullable_2;
		gclass.Nullable_2 = ((num2 != null) ? num2 : this.imethod_0().Nullable_2);
		gclass.String_1 = (string_0 ?? this.imethod_0().String_1);
		num2 = nullable_3;
		gclass.Nullable_3 = ((num2 != null) ? num2 : this.imethod_0().Nullable_3);
		num = nullable_4;
		gclass.Nullable_4 = ((num != null) ? num : this.imethod_0().Nullable_4);
		num = nullable_5;
		gclass.Nullable_5 = ((num != null) ? num : this.imethod_0().Nullable_5);
		gclass.IReadOnlyDictionary_0 = (ireadOnlyDictionary_0 ?? this.imethod_0().IReadOnlyDictionary_0);
		GClass45 gclass45_ = gclass;
		return this.imethod_3(gclass45_);
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x00032D94 File Offset: 0x00030F94
	public Task<GClass38> imethod_6(params GClass163[] gclass163_0)
	{
		GClass45 gclass45_ = new GClass45(this.imethod_0())
		{
			IList_0 = gclass163_0
		};
		return this.imethod_3(gclass45_);
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00032DBC File Offset: 0x00030FBC
	public Task<GClass38> imethod_7(params string[] string_0)
	{
		return this.imethod_6(string_0.Select(new Func<string, GClass163>(GClass191.Class252.class252_0.method_0)).ToArray<GClass163>());
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00032DF0 File Offset: 0x00030FF0
	public Task<GClass38> imethod_8(string string_0, params GClass163.GClass164[] gclass164_0)
	{
		GClass45 gclass45_ = new GClass45(this.imethod_0())
		{
			String_0 = GClass89.smethod_10(),
			IList_0 = new GClass163[]
			{
				new GClass163(GClass170.smethod_2(), string_0, gclass164_0)
			}
		};
		return this.imethod_3(gclass45_);
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x00032E40 File Offset: 0x00031040
	public Task imethod_12(GClass45 gclass45_1, Action<int, GClass38> action_0)
	{
		GClass191.Struct97 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass191_0 = this;
		@struct.gclass45_0 = gclass45_1;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass191.Struct97>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x00032E94 File Offset: 0x00031094
	public Task imethod_9(GClass45 gclass45_1, Action<GClass38> action_0)
	{
		GClass191.Struct96 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass191_0 = this;
		@struct.gclass45_0 = gclass45_1;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass191.Struct96>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x00032EE8 File Offset: 0x000310E8
	public IAsyncEnumerable<GClass38> imethod_10(GClass45 gclass45_1)
	{
		gclass45_1 = new GClass45(gclass45_1)
		{
			Boolean_0 = true
		};
		return base.method_11<GClass38>(base.method_0(), HttpMethod.Post, gclass45_1);
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x00032F10 File Offset: 0x00031110
	public IAsyncEnumerable<GClass38> imethod_11(IList<GClass163> ilist_0, GClass89 gclass89_0 = null, double? nullable_0 = null, double? nullable_1 = null, int? nullable_2 = null, int? nullable_3 = null, double? nullable_4 = null, double? nullable_5 = null, IReadOnlyDictionary<string, float> ireadOnlyDictionary_0 = null, params string[] string_0)
	{
		GClass45 gclass = new GClass45(this.imethod_0());
		gclass.IList_0 = ilist_0;
		gclass.String_0 = (gclass89_0 ?? this.imethod_0().String_0);
		double? num = nullable_0;
		gclass.Nullable_0 = ((num != null) ? num : this.imethod_0().Nullable_0);
		num = nullable_1;
		gclass.Nullable_1 = ((num != null) ? num : this.imethod_0().Nullable_1);
		int? num2 = nullable_2;
		gclass.Nullable_2 = ((num2 != null) ? num2 : this.imethod_0().Nullable_2);
		gclass.String_1 = (string_0 ?? this.imethod_0().String_1);
		num2 = nullable_3;
		gclass.Nullable_3 = ((num2 != null) ? num2 : this.imethod_0().Nullable_3);
		num = nullable_4;
		gclass.Nullable_4 = ((num != null) ? num : this.imethod_0().Nullable_4);
		num = nullable_5;
		gclass.Nullable_5 = ((num != null) ? num : this.imethod_0().Nullable_5);
		gclass.IReadOnlyDictionary_0 = (ireadOnlyDictionary_0 ?? this.imethod_0().IReadOnlyDictionary_0);
		GClass45 gclass45_ = gclass;
		return this.imethod_10(gclass45_);
	}

	// Token: 0x040006A1 RID: 1697
	private GClass45 gclass45_0 = new GClass45
	{
		String_0 = GClass89.smethod_2()
	};

	// Token: 0x020001CD RID: 461
	[StructLayout(LayoutKind.Auto)]
	private struct Struct96 : IAsyncStateMachine
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x00033044 File Offset: 0x00031244
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass191 gclass = this.gclass191_0;
			try
			{
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_75;
					}
					this.iasyncEnumerator_0 = gclass.imethod_10(this.gclass45_0).GetAsyncEnumerator(default(CancellationToken));
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
							goto IL_EE;
						}
						IL_CD:
						awaiter = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.valueTaskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass191.Struct96>(ref awaiter, ref this);
							return;
						}
						IL_EE:
						if (!awaiter.GetResult())
						{
							goto IL_12F;
						}
						GClass38 obj = this.iasyncEnumerator_0.Current;
						this.action_0(obj);
						goto IL_CD;
						IL_75:
						awaiter2 = this.valueTaskAwaiter_1;
						this.valueTaskAwaiter_1 = default(ValueTaskAwaiter);
						this.int_0 = -1;
						IL_91:
						awaiter2.GetResult();
						IL_98:
						object obj2 = this.object_0;
						if (obj2 == null)
						{
							goto IL_188;
						}
						ex = (obj2 as Exception);
						if (ex != null)
						{
							goto IL_17E;
						}
						throw obj2;
					}
					catch (object obj2)
					{
						object obj2;
						this.object_0 = obj2;
					}
					IL_12F:
					if (this.iasyncEnumerator_0 == null)
					{
						goto IL_98;
					}
					awaiter2 = this.iasyncEnumerator_0.DisposeAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						break;
					}
					goto IL_91;
				}
				this.int_0 = 1;
				this.valueTaskAwaiter_1 = awaiter2;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass191.Struct96>(ref awaiter2, ref this);
				return;
				IL_17E:
				ExceptionDispatchInfo.Capture(ex).Throw();
				IL_188:
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

		// Token: 0x06000AEE RID: 2798 RVA: 0x00033250 File Offset: 0x00031450
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006A2 RID: 1698
		public int int_0;

		// Token: 0x040006A3 RID: 1699
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040006A4 RID: 1700
		public GClass191 gclass191_0;

		// Token: 0x040006A5 RID: 1701
		public GClass45 gclass45_0;

		// Token: 0x040006A6 RID: 1702
		public Action<GClass38> action_0;

		// Token: 0x040006A7 RID: 1703
		private IAsyncEnumerator<GClass38> iasyncEnumerator_0;

		// Token: 0x040006A8 RID: 1704
		private object object_0;

		// Token: 0x040006A9 RID: 1705
		private int int_1;

		// Token: 0x040006AA RID: 1706
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x040006AB RID: 1707
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}

	// Token: 0x020001CE RID: 462
	[StructLayout(LayoutKind.Auto)]
	private struct Struct97 : IAsyncStateMachine
	{
		// Token: 0x06000AEF RID: 2799 RVA: 0x00033260 File Offset: 0x00031460
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass191 gclass = this.gclass191_0;
			try
			{
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_7C;
					}
					this.int_1 = 0;
					this.iasyncEnumerator_0 = gclass.imethod_10(this.gclass45_0).GetAsyncEnumerator(default(CancellationToken));
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
							goto IL_107;
						}
						IL_E6:
						awaiter = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.valueTaskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass191.Struct97>(ref awaiter, ref this);
							return;
						}
						IL_107:
						if (!awaiter.GetResult())
						{
							goto IL_148;
						}
						GClass38 arg = this.iasyncEnumerator_0.Current;
						Action<int, GClass38> action = this.action_0;
						int num2 = this.int_1;
						this.int_1 = num2 + 1;
						action(num2, arg);
						goto IL_E6;
						IL_7C:
						awaiter2 = this.valueTaskAwaiter_1;
						this.valueTaskAwaiter_1 = default(ValueTaskAwaiter);
						this.int_0 = -1;
						IL_99:
						awaiter2.GetResult();
						IL_A0:
						object obj = this.object_0;
						if (obj == null)
						{
							goto IL_1A3;
						}
						ex = (obj as Exception);
						if (ex != null)
						{
							goto IL_199;
						}
						throw obj;
					}
					catch (object obj)
					{
						object obj;
						this.object_0 = obj;
					}
					IL_148:
					if (this.iasyncEnumerator_0 == null)
					{
						goto IL_A0;
					}
					awaiter2 = this.iasyncEnumerator_0.DisposeAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						break;
					}
					goto IL_99;
				}
				this.int_0 = 1;
				this.valueTaskAwaiter_1 = awaiter2;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass191.Struct97>(ref awaiter2, ref this);
				return;
				IL_199:
				ExceptionDispatchInfo.Capture(ex).Throw();
				IL_1A3:
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

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00033488 File Offset: 0x00031688
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006AC RID: 1708
		public int int_0;

		// Token: 0x040006AD RID: 1709
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040006AE RID: 1710
		public GClass191 gclass191_0;

		// Token: 0x040006AF RID: 1711
		public GClass45 gclass45_0;

		// Token: 0x040006B0 RID: 1712
		public Action<int, GClass38> action_0;

		// Token: 0x040006B1 RID: 1713
		private int int_1;

		// Token: 0x040006B2 RID: 1714
		private IAsyncEnumerator<GClass38> iasyncEnumerator_0;

		// Token: 0x040006B3 RID: 1715
		private object object_0;

		// Token: 0x040006B4 RID: 1716
		private int int_2;

		// Token: 0x040006B5 RID: 1717
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x040006B6 RID: 1718
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}

	// Token: 0x020001CF RID: 463
	[Serializable]
	private sealed class Class252
	{
		// Token: 0x06000AF3 RID: 2803 RVA: 0x000334AC File Offset: 0x000316AC
		internal GClass163 method_0(string string_0)
		{
			return new GClass163(GClass170.smethod_2(), string_0);
		}

		// Token: 0x040006B7 RID: 1719
		public static readonly GClass191.Class252 class252_0 = new GClass191.Class252();

		// Token: 0x040006B8 RID: 1720
		public static Func<string, GClass163> func_0;
	}

	// Token: 0x020001D0 RID: 464
	[StructLayout(LayoutKind.Auto)]
	private struct Struct98 : IAsyncStateMachine
	{
		// Token: 0x06000AF4 RID: 2804 RVA: 0x000334BC File Offset: 0x000316BC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass191 gclass = this.gclass191_0;
			GClass38 result;
			try
			{
				TaskAwaiter<GClass38> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_8<GClass38>(null, this.gclass45_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass38>, GClass191.Struct98>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass38>);
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

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0003357C File Offset: 0x0003177C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006B9 RID: 1721
		public int int_0;

		// Token: 0x040006BA RID: 1722
		public AsyncTaskMethodBuilder<GClass38> asyncTaskMethodBuilder_0;

		// Token: 0x040006BB RID: 1723
		public GClass191 gclass191_0;

		// Token: 0x040006BC RID: 1724
		public GClass45 gclass45_0;

		// Token: 0x040006BD RID: 1725
		private TaskAwaiter<GClass38> taskAwaiter_0;
	}
}
