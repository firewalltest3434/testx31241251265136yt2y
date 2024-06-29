using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x0200052F RID: 1327
public sealed class GClass195 : GClass189, GInterface8
{
	// Token: 0x06001D03 RID: 7427 RVA: 0x00079330 File Offset: 0x00077530
	internal GClass195(GClass178 gclass178_1) : base(gclass178_1)
	{
	}

	// Token: 0x06001D04 RID: 7428 RVA: 0x00079354 File Offset: 0x00077554
	[CompilerGenerated]
	public GClass44 imethod_0()
	{
		return this.gclass44_0;
	}

	// Token: 0x06001D05 RID: 7429 RVA: 0x0007935C File Offset: 0x0007755C
	[CompilerGenerated]
	public void imethod_1(GClass44 gclass44_1)
	{
		this.gclass44_0 = gclass44_1;
	}

	// Token: 0x06001D06 RID: 7430 RVA: 0x00079368 File Offset: 0x00077568
	protected override string vmethod_0()
	{
		return "completions";
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x00079370 File Offset: 0x00077570
	public Task<GClass33> imethod_2(GClass44 gclass44_1)
	{
		GClass195.Struct299 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass33>.Create();
		@struct.gclass195_0 = this;
		@struct.gclass44_0 = gclass44_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass195.Struct299>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001D08 RID: 7432 RVA: 0x000793BC File Offset: 0x000775BC
	public Task<GClass33> imethod_5(GClass44 gclass44_1, int int_0 = 5)
	{
		gclass44_1.Nullable_5 = new int?(int_0);
		return this.imethod_2(gclass44_1);
	}

	// Token: 0x06001D09 RID: 7433 RVA: 0x000793D4 File Offset: 0x000775D4
	public Task<GClass33> imethod_3(string string_0, GClass89 gclass89_0 = null, int? nullable_0 = null, double? nullable_1 = null, double? nullable_2 = null, int? nullable_3 = null, double? nullable_4 = null, double? nullable_5 = null, int? nullable_6 = null, bool? nullable_7 = null, params string[] string_1)
	{
		GClass44 gclass = new GClass44(this.imethod_0());
		gclass.String_2 = string_0;
		gclass.String_0 = (gclass89_0 ?? this.imethod_0().String_0);
		int? num = nullable_0;
		gclass.Nullable_0 = ((num != null) ? num : this.imethod_0().Nullable_0);
		double? num2 = nullable_1;
		gclass.Nullable_1 = ((num2 != null) ? num2 : this.imethod_0().Nullable_1);
		num2 = nullable_2;
		gclass.Nullable_2 = ((num2 != null) ? num2 : this.imethod_0().Nullable_2);
		num = nullable_3;
		gclass.Nullable_5 = ((num != null) ? num : this.imethod_0().Nullable_5);
		num2 = nullable_4;
		gclass.Nullable_3 = ((num2 != null) ? num2 : this.imethod_0().Nullable_3);
		num2 = nullable_5;
		gclass.Nullable_4 = ((num2 != null) ? num2 : this.imethod_0().Nullable_4);
		num = nullable_6;
		gclass.Nullable_6 = ((num != null) ? num : this.imethod_0().Nullable_6);
		bool? flag = nullable_7;
		gclass.Nullable_7 = ((flag != null) ? flag : this.imethod_0().Nullable_7);
		gclass.String_4 = (string_1 ?? this.imethod_0().String_4);
		GClass44 gclass44_ = gclass;
		return this.imethod_2(gclass44_);
	}

	// Token: 0x06001D0A RID: 7434 RVA: 0x00079534 File Offset: 0x00077734
	public Task<GClass33> imethod_4(params string[] string_0)
	{
		GClass44 gclass44_ = new GClass44(this.imethod_0())
		{
			String_1 = string_0
		};
		return this.imethod_2(gclass44_);
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x0007955C File Offset: 0x0007775C
	public Task imethod_6(GClass44 gclass44_1, Action<int, GClass33> action_0)
	{
		GClass195.Struct300 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass195_0 = this;
		@struct.gclass44_0 = gclass44_1;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass195.Struct300>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001D0C RID: 7436 RVA: 0x000795B0 File Offset: 0x000777B0
	public Task imethod_7(GClass44 gclass44_1, Action<GClass33> action_0)
	{
		GClass195.Struct302 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass195_0 = this;
		@struct.gclass44_0 = gclass44_1;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass195.Struct302>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001D0D RID: 7437 RVA: 0x00079604 File Offset: 0x00077804
	public IAsyncEnumerable<GClass33> imethod_8(GClass44 gclass44_1)
	{
		gclass44_1 = new GClass44(gclass44_1)
		{
			Boolean_0 = true
		};
		return base.method_11<GClass33>(base.method_0(), HttpMethod.Post, gclass44_1);
	}

	// Token: 0x06001D0E RID: 7438 RVA: 0x0007962C File Offset: 0x0007782C
	public IAsyncEnumerable<GClass33> imethod_9(string string_0, GClass89 gclass89_0 = null, int? nullable_0 = null, double? nullable_1 = null, double? nullable_2 = null, int? nullable_3 = null, double? nullable_4 = null, double? nullable_5 = null, int? nullable_6 = null, bool? nullable_7 = null, params string[] string_1)
	{
		GClass44 gclass = new GClass44(this.imethod_0());
		gclass.String_2 = string_0;
		gclass.String_0 = (gclass89_0 ?? this.imethod_0().String_0);
		int? num = nullable_0;
		gclass.Nullable_0 = ((num != null) ? num : this.imethod_0().Nullable_0);
		double? num2 = nullable_1;
		gclass.Nullable_1 = ((num2 != null) ? num2 : this.imethod_0().Nullable_1);
		num2 = nullable_2;
		gclass.Nullable_2 = ((num2 != null) ? num2 : this.imethod_0().Nullable_2);
		num = nullable_3;
		gclass.Nullable_5 = ((num != null) ? num : this.imethod_0().Nullable_5);
		num2 = nullable_4;
		gclass.Nullable_3 = ((num2 != null) ? num2 : this.imethod_0().Nullable_3);
		num2 = nullable_5;
		gclass.Nullable_4 = ((num2 != null) ? num2 : this.imethod_0().Nullable_4);
		num = nullable_6;
		gclass.Nullable_6 = ((num != null) ? num : this.imethod_0().Nullable_6);
		bool? flag = nullable_7;
		gclass.Nullable_7 = ((flag != null) ? flag : this.imethod_0().Nullable_7);
		gclass.String_4 = (string_1 ?? this.imethod_0().String_4);
		gclass.Boolean_0 = true;
		GClass44 gclass44_ = gclass;
		return this.imethod_8(gclass44_);
	}

	// Token: 0x06001D0F RID: 7439 RVA: 0x00079790 File Offset: 0x00077990
	public Task<string> imethod_10(GClass44 gclass44_1)
	{
		GClass195.Struct301 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass195_0 = this;
		@struct.gclass44_0 = gclass44_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass195.Struct301>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001D10 RID: 7440 RVA: 0x000797DC File Offset: 0x000779DC
	public Task<string> imethod_11(string string_0)
	{
		GClass195.Struct303 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass195_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass195.Struct303>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0400145C RID: 5212
	private GClass44 gclass44_0 = new GClass44
	{
		String_0 = GClass89.smethod_0()
	};

	// Token: 0x02000530 RID: 1328
	[StructLayout(LayoutKind.Auto)]
	private struct Struct299 : IAsyncStateMachine
	{
		// Token: 0x06001D11 RID: 7441 RVA: 0x00079828 File Offset: 0x00077A28
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass195 gclass = this.gclass195_0;
			GClass33 result;
			try
			{
				TaskAwaiter<GClass33> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_8<GClass33>(null, this.gclass44_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass33>, GClass195.Struct299>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass33>);
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

		// Token: 0x06001D12 RID: 7442 RVA: 0x000798E8 File Offset: 0x00077AE8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400145D RID: 5213
		public int int_0;

		// Token: 0x0400145E RID: 5214
		public AsyncTaskMethodBuilder<GClass33> asyncTaskMethodBuilder_0;

		// Token: 0x0400145F RID: 5215
		public GClass195 gclass195_0;

		// Token: 0x04001460 RID: 5216
		public GClass44 gclass44_0;

		// Token: 0x04001461 RID: 5217
		private TaskAwaiter<GClass33> taskAwaiter_0;
	}

	// Token: 0x02000531 RID: 1329
	[StructLayout(LayoutKind.Auto)]
	private struct Struct300 : IAsyncStateMachine
	{
		// Token: 0x06001D13 RID: 7443 RVA: 0x000798F8 File Offset: 0x00077AF8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass195 gclass = this.gclass195_0;
			try
			{
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_7C;
					}
					this.int_1 = 0;
					this.iasyncEnumerator_0 = gclass.imethod_8(this.gclass44_0).GetAsyncEnumerator(default(CancellationToken));
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
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass195.Struct300>(ref awaiter, ref this);
							return;
						}
						IL_107:
						if (!awaiter.GetResult())
						{
							goto IL_148;
						}
						GClass33 arg = this.iasyncEnumerator_0.Current;
						Action<int, GClass33> action = this.action_0;
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
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass195.Struct300>(ref awaiter2, ref this);
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

		// Token: 0x06001D14 RID: 7444 RVA: 0x00079B20 File Offset: 0x00077D20
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001462 RID: 5218
		public int int_0;

		// Token: 0x04001463 RID: 5219
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001464 RID: 5220
		public GClass195 gclass195_0;

		// Token: 0x04001465 RID: 5221
		public GClass44 gclass44_0;

		// Token: 0x04001466 RID: 5222
		public Action<int, GClass33> action_0;

		// Token: 0x04001467 RID: 5223
		private int int_1;

		// Token: 0x04001468 RID: 5224
		private IAsyncEnumerator<GClass33> iasyncEnumerator_0;

		// Token: 0x04001469 RID: 5225
		private object object_0;

		// Token: 0x0400146A RID: 5226
		private int int_2;

		// Token: 0x0400146B RID: 5227
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x0400146C RID: 5228
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}

	// Token: 0x02000532 RID: 1330
	[StructLayout(LayoutKind.Auto)]
	private struct Struct301 : IAsyncStateMachine
	{
		// Token: 0x06001D15 RID: 7445 RVA: 0x00079B30 File Offset: 0x00077D30
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass195 gclass = this.gclass195_0;
			string result2;
			try
			{
				TaskAwaiter<GClass33> awaiter;
				if (num != 0)
				{
					this.string_0 = this.gclass44_0.String_2;
					awaiter = gclass.imethod_2(this.gclass44_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass33>, GClass195.Struct301>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass33>);
					this.int_0 = -1;
				}
				GClass33 result = awaiter.GetResult();
				result2 = this.string_0 + result.ToString();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.string_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.string_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00079C20 File Offset: 0x00077E20
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400146D RID: 5229
		public int int_0;

		// Token: 0x0400146E RID: 5230
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x0400146F RID: 5231
		public GClass44 gclass44_0;

		// Token: 0x04001470 RID: 5232
		public GClass195 gclass195_0;

		// Token: 0x04001471 RID: 5233
		private string string_0;

		// Token: 0x04001472 RID: 5234
		private TaskAwaiter<GClass33> taskAwaiter_0;
	}

	// Token: 0x02000533 RID: 1331
	[StructLayout(LayoutKind.Auto)]
	private struct Struct302 : IAsyncStateMachine
	{
		// Token: 0x06001D17 RID: 7447 RVA: 0x00079C30 File Offset: 0x00077E30
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass195 gclass = this.gclass195_0;
			try
			{
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_75;
					}
					this.iasyncEnumerator_0 = gclass.imethod_8(this.gclass44_0).GetAsyncEnumerator(default(CancellationToken));
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
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass195.Struct302>(ref awaiter, ref this);
							return;
						}
						IL_EE:
						if (!awaiter.GetResult())
						{
							goto IL_12F;
						}
						GClass33 obj = this.iasyncEnumerator_0.Current;
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
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass195.Struct302>(ref awaiter2, ref this);
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

		// Token: 0x06001D18 RID: 7448 RVA: 0x00079E3C File Offset: 0x0007803C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001473 RID: 5235
		public int int_0;

		// Token: 0x04001474 RID: 5236
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001475 RID: 5237
		public GClass195 gclass195_0;

		// Token: 0x04001476 RID: 5238
		public GClass44 gclass44_0;

		// Token: 0x04001477 RID: 5239
		public Action<GClass33> action_0;

		// Token: 0x04001478 RID: 5240
		private IAsyncEnumerator<GClass33> iasyncEnumerator_0;

		// Token: 0x04001479 RID: 5241
		private object object_0;

		// Token: 0x0400147A RID: 5242
		private int int_1;

		// Token: 0x0400147B RID: 5243
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x0400147C RID: 5244
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}

	// Token: 0x02000534 RID: 1332
	[StructLayout(LayoutKind.Auto)]
	private struct Struct303 : IAsyncStateMachine
	{
		// Token: 0x06001D19 RID: 7449 RVA: 0x00079E4C File Offset: 0x0007804C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass195 gclass = this.gclass195_0;
			string result;
			try
			{
				TaskAwaiter<GClass33> awaiter;
				if (num != 0)
				{
					GClass44 gclass44_ = new GClass44(gclass.imethod_0())
					{
						String_2 = this.string_0,
						Nullable_5 = new int?(1)
					};
					awaiter = gclass.imethod_2(gclass44_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass33>, GClass195.Struct303>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass33>);
					this.int_0 = -1;
				}
				result = awaiter.GetResult().ToString();
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

		// Token: 0x06001D1A RID: 7450 RVA: 0x00079F30 File Offset: 0x00078130
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400147D RID: 5245
		public int int_0;

		// Token: 0x0400147E RID: 5246
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x0400147F RID: 5247
		public GClass195 gclass195_0;

		// Token: 0x04001480 RID: 5248
		public string string_0;

		// Token: 0x04001481 RID: 5249
		private TaskAwaiter<GClass33> taskAwaiter_0;
	}
}
