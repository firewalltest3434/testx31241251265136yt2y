using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using NvidiaX.NVIDIA.Classes.Import;

// Token: 0x02000394 RID: 916
public static class GClass113
{
	// Token: 0x060014A4 RID: 5284 RVA: 0x000545A0 File Offset: 0x000527A0
	public static bool smethod_0()
	{
		return GClass113.bool_0;
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x000545A8 File Offset: 0x000527A8
	private static void smethod_1(bool bool_1)
	{
		GClass113.bool_0 = bool_1;
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x000545B0 File Offset: 0x000527B0
	public static Task<GStruct9> smethod_2()
	{
		GClass113.Struct195 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GStruct9>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct195>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014A7 RID: 5287 RVA: 0x000545EC File Offset: 0x000527EC
	public static Task<GStruct9> smethod_3(CancellationToken cancellationToken_0)
	{
		GClass113.Struct189 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GStruct9>.Create();
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct189>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x00054630 File Offset: 0x00052830
	public static Task<GStruct9> smethod_4(CancellationToken cancellationToken_0, bool bool_1)
	{
		GClass113.Struct187 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GStruct9>.Create();
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.bool_0 = bool_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct187>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x0005467C File Offset: 0x0005287C
	public static Task<ValueTuple<List<GStruct0>, Dictionary<string, string>>> smethod_5(this GClass136 gclass136_0)
	{
		GClass113.Struct186 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>>.Create();
		@struct.gclass136_0 = gclass136_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct186>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014AA RID: 5290 RVA: 0x000546C0 File Offset: 0x000528C0
	public static Task<ValueTuple<List<GStruct0>, Dictionary<string, string>>> smethod_6(this GClass136 gclass136_0, GEnum78 genum78_0)
	{
		GClass113.Struct190 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>>.Create();
		@struct.gclass136_0 = gclass136_0;
		@struct.genum78_0 = genum78_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct190>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x0005470C File Offset: 0x0005290C
	public static Task<ValueTuple<List<GStruct0>, Dictionary<string, string>>> smethod_7(this GClass136 gclass136_0, GEnum78 genum78_0, bool bool_1)
	{
		GClass113.Struct191 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>>.Create();
		@struct.gclass136_0 = gclass136_0;
		@struct.genum78_0 = genum78_0;
		@struct.bool_0 = bool_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct191>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x00054760 File Offset: 0x00052960
	public static Task<ValueTuple<List<GStruct0>, Dictionary<string, string>>> smethod_8(this GClass136 gclass136_0, GEnum78 genum78_0, bool bool_1, CancellationToken cancellationToken_0)
	{
		GClass113.Struct185 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>>.Create();
		@struct.gclass136_0 = gclass136_0;
		@struct.genum78_0 = genum78_0;
		@struct.bool_0 = bool_1;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct185>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014AD RID: 5293 RVA: 0x000547BC File Offset: 0x000529BC
	public static Task smethod_9()
	{
		GClass113.Struct192 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct192>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x000547F8 File Offset: 0x000529F8
	public static Task smethod_10(CancellationToken cancellationToken_0)
	{
		GClass113.Struct194 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct194>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x0005483C File Offset: 0x00052A3C
	public static void smethod_11()
	{
		GClass113.smethod_12(false);
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x00054844 File Offset: 0x00052A44
	public static void smethod_12(bool bool_1)
	{
		GClass113.gclass42_0.method_0(bool_1);
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x00054854 File Offset: 0x00052A54
	public static Task smethod_13(this GClass136 gclass136_0, IEnumerable<GClass79> ienumerable_0, CancellationToken cancellationToken_0)
	{
		GClass113.Struct188 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass136_0 = gclass136_0;
		@struct.ienumerable_0 = ienumerable_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct188>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x000548A8 File Offset: 0x00052AA8
	public static void smethod_14()
	{
		GClass113.smethod_15(default(CancellationToken));
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x000548C4 File Offset: 0x00052AC4
	public static void smethod_15(CancellationToken cancellationToken_0)
	{
		GClass74.smethod_1();
		GClass113.smethod_1(false);
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x000548D4 File Offset: 0x00052AD4
	public static void smethod_16(this GClass136 gclass136_0, string string_0)
	{
		gclass136_0.smethod_17(string_0, true);
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x000548E0 File Offset: 0x00052AE0
	public static void smethod_17(this GClass136 gclass136_0, string string_0, bool bool_1)
	{
		GClass113.gclass9_0.method_22(new GClass136[]
		{
			gclass136_0
		}, string_0, bool_1);
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x000548F8 File Offset: 0x00052AF8
	public static void smethod_18(this IEnumerable<GClass136> ienumerable_0, string string_0)
	{
		ienumerable_0.smethod_19(string_0, true);
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x00054904 File Offset: 0x00052B04
	public static void smethod_19(this IEnumerable<GClass136> ienumerable_0, string string_0, bool bool_1)
	{
		GClass113.gclass9_0.method_22(ienumerable_0, string_0, bool_1);
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x00054914 File Offset: 0x00052B14
	public static byte[] smethod_20(this IEnumerable<GClass136> ienumerable_0, bool bool_1)
	{
		return GClass113.gclass9_0.method_23(ienumerable_0, bool_1);
	}

	// Token: 0x060014B9 RID: 5305 RVA: 0x00054924 File Offset: 0x00052B24
	public static void smethod_21(string string_0)
	{
		GClass113.gclass9_0.method_20(string_0);
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x00054934 File Offset: 0x00052B34
	public static void smethod_22(string string_0)
	{
		GClass113.gclass9_0.method_26(string_0);
	}

	// Token: 0x060014BB RID: 5307 RVA: 0x00054944 File Offset: 0x00052B44
	public static ImportExportProfiles smethod_23(string string_0)
	{
		return GClass113.gclass9_0.method_25(string_0);
	}

	// Token: 0x060014BC RID: 5308 RVA: 0x00054954 File Offset: 0x00052B54
	public static void smethod_24(string string_0)
	{
		GClass113.gclass9_0.method_21(string_0);
	}

	// Token: 0x060014BD RID: 5309 RVA: 0x00054964 File Offset: 0x00052B64
	public static Task<bool> smethod_25(this GClass136 gclass136_0)
	{
		GClass113.Struct193 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@struct.gclass136_0 = gclass136_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct193>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014BE RID: 5310 RVA: 0x000549A8 File Offset: 0x00052BA8
	public static Task<bool> smethod_26()
	{
		GClass113.Struct184 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass113.Struct184>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060014BF RID: 5311 RVA: 0x000549E4 File Offset: 0x00052BE4
	public static List<GClass136> smethod_27()
	{
		return GClass113.gclass10_0.list_1;
	}

	// Token: 0x060014C0 RID: 5312 RVA: 0x000549F0 File Offset: 0x00052BF0
	public static GEnum50 smethod_28(this GClass136 gclass136_0)
	{
		if (GClass113.gclass10_0.list_1.Contains(gclass136_0))
		{
			return (GEnum50)0;
		}
		if (GClass113.gclass10_0.hashSet_0.Contains(gclass136_0))
		{
			return (GEnum50)1;
		}
		return (GEnum50)2;
	}

	// Token: 0x04000C71 RID: 3185
	private static GClass11 gclass11_0 = GClass12.gclass11_0;

	// Token: 0x04000C72 RID: 3186
	private static GClass10 gclass10_0 = GClass12.gclass10_0;

	// Token: 0x04000C73 RID: 3187
	private static GClass42 gclass42_0 = GClass12.gclass42_0;

	// Token: 0x04000C74 RID: 3188
	private static GClass9 gclass9_0 = GClass12.gclass9_0;

	// Token: 0x04000C75 RID: 3189
	private static bool bool_0 = false;

	// Token: 0x02000395 RID: 917
	[StructLayout(LayoutKind.Auto)]
	private struct Struct184 : IAsyncStateMachine
	{
		// Token: 0x060014C1 RID: 5313 RVA: 0x00054A1C File Offset: 0x00052C1C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			bool result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.bool_0 = false;
					awaiter = Task.Run(new Action(GClass113.Class420.class420_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass113.Struct184>(ref awaiter, ref this);
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
				result = this.bool_0;
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

		// Token: 0x060014C2 RID: 5314 RVA: 0x00054AF4 File Offset: 0x00052CF4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C76 RID: 3190
		public int int_0;

		// Token: 0x04000C77 RID: 3191
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x04000C78 RID: 3192
		private bool bool_0;

		// Token: 0x04000C79 RID: 3193
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000396 RID: 918
	[StructLayout(LayoutKind.Auto)]
	private struct Struct185 : IAsyncStateMachine
	{
		// Token: 0x060014C3 RID: 5315 RVA: 0x00054B04 File Offset: 0x00052D04
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			ValueTuple<List<GStruct0>, Dictionary<string, string>> result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.class419_0 = new GClass113.Class419();
					this.class419_0.gclass136_0 = this.gclass136_0;
					this.class419_0.genum78_0 = this.genum78_0;
					this.class419_0.bool_0 = this.bool_0;
					if (this.class419_0.genum78_0 == (GEnum78)1 && !GClass113.smethod_0())
					{
						throw new InvalidOperationException("ProfilesScanned");
					}
					this.class419_0.list_0 = new List<GStruct0>();
					this.class419_0.dictionary_0 = new Dictionary<string, string>();
					awaiter = Task.Run(new Action(this.class419_0.method_0), this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass113.Struct185>(ref awaiter, ref this);
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
				result = new ValueTuple<List<GStruct0>, Dictionary<string, string>>(this.class419_0.list_0, this.class419_0.dictionary_0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class419_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class419_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00054C80 File Offset: 0x00052E80
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C7A RID: 3194
		public int int_0;

		// Token: 0x04000C7B RID: 3195
		public AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>> asyncTaskMethodBuilder_0;

		// Token: 0x04000C7C RID: 3196
		public GClass136 gclass136_0;

		// Token: 0x04000C7D RID: 3197
		public GEnum78 genum78_0;

		// Token: 0x04000C7E RID: 3198
		public bool bool_0;

		// Token: 0x04000C7F RID: 3199
		public CancellationToken cancellationToken_0;

		// Token: 0x04000C80 RID: 3200
		private GClass113.Class419 class419_0;

		// Token: 0x04000C81 RID: 3201
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000397 RID: 919
	private sealed class Class418
	{
		// Token: 0x060014C6 RID: 5318 RVA: 0x00054C98 File Offset: 0x00052E98
		internal void method_0()
		{
			this.list_0 = GClass113.gclass11_0.method_26(ref this.gclass136_0);
			if (this.bool_0)
			{
				this.list_0.Remove(this.gclass136_0);
				this.list_0.Sort();
				this.list_0.Insert(0, this.gclass136_0);
			}
		}

		// Token: 0x04000C82 RID: 3202
		public List<GClass136> list_0;

		// Token: 0x04000C83 RID: 3203
		public GClass136 gclass136_0;

		// Token: 0x04000C84 RID: 3204
		public bool bool_0;
	}

	// Token: 0x02000398 RID: 920
	[StructLayout(LayoutKind.Auto)]
	private struct Struct186 : IAsyncStateMachine
	{
		// Token: 0x060014C7 RID: 5319 RVA: 0x00054CF4 File Offset: 0x00052EF4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			ValueTuple<List<GStruct0>, Dictionary<string, string>> result;
			try
			{
				TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> awaiter;
				if (num != 0)
				{
					awaiter = this.gclass136_0.smethod_8((GEnum78)0, false, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>, GClass113.Struct186>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>);
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

		// Token: 0x060014C8 RID: 5320 RVA: 0x00054DB4 File Offset: 0x00052FB4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C85 RID: 3205
		public int int_0;

		// Token: 0x04000C86 RID: 3206
		public AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>> asyncTaskMethodBuilder_0;

		// Token: 0x04000C87 RID: 3207
		public GClass136 gclass136_0;

		// Token: 0x04000C88 RID: 3208
		private TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> taskAwaiter_0;
	}

	// Token: 0x02000399 RID: 921
	[StructLayout(LayoutKind.Auto)]
	private struct Struct187 : IAsyncStateMachine
	{
		// Token: 0x060014C9 RID: 5321 RVA: 0x00054DC4 File Offset: 0x00052FC4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GStruct9 result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.class418_0 = new GClass113.Class418();
					this.class418_0.bool_0 = this.bool_0;
					this.class418_0.list_0 = null;
					this.class418_0.gclass136_0 = null;
					awaiter = Task.Run(new Action(this.class418_0.method_0), this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass113.Struct187>(ref awaiter, ref this);
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
				result = new GStruct9(this.class418_0.list_0, this.class418_0.gclass136_0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class418_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class418_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00054EE4 File Offset: 0x000530E4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C89 RID: 3209
		public int int_0;

		// Token: 0x04000C8A RID: 3210
		public AsyncTaskMethodBuilder<GStruct9> asyncTaskMethodBuilder_0;

		// Token: 0x04000C8B RID: 3211
		public bool bool_0;

		// Token: 0x04000C8C RID: 3212
		public CancellationToken cancellationToken_0;

		// Token: 0x04000C8D RID: 3213
		private GClass113.Class418 class418_0;

		// Token: 0x04000C8E RID: 3214
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200039A RID: 922
	[StructLayout(LayoutKind.Auto)]
	private struct Struct188 : IAsyncStateMachine
	{
		// Token: 0x060014CB RID: 5323 RVA: 0x00054EF4 File Offset: 0x000530F4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new GClass113.Class422
					{
						ienumerable_0 = this.ienumerable_0,
						gclass136_0 = this.gclass136_0
					}.method_0), this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass113.Struct188>(ref awaiter, ref this);
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

		// Token: 0x060014CC RID: 5324 RVA: 0x00054FCC File Offset: 0x000531CC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C8F RID: 3215
		public int int_0;

		// Token: 0x04000C90 RID: 3216
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000C91 RID: 3217
		public IEnumerable<GClass79> ienumerable_0;

		// Token: 0x04000C92 RID: 3218
		public GClass136 gclass136_0;

		// Token: 0x04000C93 RID: 3219
		public CancellationToken cancellationToken_0;

		// Token: 0x04000C94 RID: 3220
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200039B RID: 923
	[StructLayout(LayoutKind.Auto)]
	private struct Struct189 : IAsyncStateMachine
	{
		// Token: 0x060014CD RID: 5325 RVA: 0x00054FDC File Offset: 0x000531DC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GStruct9 result;
			try
			{
				TaskAwaiter<GStruct9> awaiter;
				if (num != 0)
				{
					awaiter = GClass113.smethod_4(this.cancellationToken_0, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GStruct9>, GClass113.Struct189>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GStruct9>);
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

		// Token: 0x060014CE RID: 5326 RVA: 0x00055090 File Offset: 0x00053290
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C95 RID: 3221
		public int int_0;

		// Token: 0x04000C96 RID: 3222
		public AsyncTaskMethodBuilder<GStruct9> asyncTaskMethodBuilder_0;

		// Token: 0x04000C97 RID: 3223
		public CancellationToken cancellationToken_0;

		// Token: 0x04000C98 RID: 3224
		private TaskAwaiter<GStruct9> taskAwaiter_0;
	}

	// Token: 0x0200039C RID: 924
	[StructLayout(LayoutKind.Auto)]
	private struct Struct190 : IAsyncStateMachine
	{
		// Token: 0x060014CF RID: 5327 RVA: 0x000550A0 File Offset: 0x000532A0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			ValueTuple<List<GStruct0>, Dictionary<string, string>> result;
			try
			{
				TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> awaiter;
				if (num != 0)
				{
					awaiter = this.gclass136_0.smethod_8(this.genum78_0, false, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>, GClass113.Struct190>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>);
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

		// Token: 0x060014D0 RID: 5328 RVA: 0x00055164 File Offset: 0x00053364
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C99 RID: 3225
		public int int_0;

		// Token: 0x04000C9A RID: 3226
		public AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>> asyncTaskMethodBuilder_0;

		// Token: 0x04000C9B RID: 3227
		public GClass136 gclass136_0;

		// Token: 0x04000C9C RID: 3228
		public GEnum78 genum78_0;

		// Token: 0x04000C9D RID: 3229
		private TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> taskAwaiter_0;
	}

	// Token: 0x0200039D RID: 925
	private sealed class Class419
	{
		// Token: 0x060014D2 RID: 5330 RVA: 0x0005517C File Offset: 0x0005337C
		internal void method_0()
		{
			IEnumerable<GClass79> source = GClass113.gclass11_0.method_36(this.gclass136_0.ProfileName, this.genum78_0, ref this.dictionary_0);
			Func<GClass79, bool> predicate;
			if ((predicate = this.func_0) == null)
			{
				predicate = (this.func_0 = new Func<GClass79, bool>(this.method_1));
			}
			foreach (GClass79 gclass in source.Where(predicate))
			{
				GClass69 gclass2 = GClass113.gclass42_0.method_16(gclass.method_0(), this.genum78_0);
				if (gclass2 == null || gclass2.Values.Count<GInterface5>() >= 1)
				{
					List<GStruct0> list = this.list_0;
					GStruct0 item = default(GStruct0);
					item.SettingItem = gclass;
					item.method_1(gclass2);
					list.Add(item);
				}
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00055268 File Offset: 0x00053468
		internal bool method_1(GClass79 gclass79_0)
		{
			return gclass79_0.method_16() == this.bool_0;
		}

		// Token: 0x04000C9E RID: 3230
		public GClass136 gclass136_0;

		// Token: 0x04000C9F RID: 3231
		public GEnum78 genum78_0;

		// Token: 0x04000CA0 RID: 3232
		public Dictionary<string, string> dictionary_0;

		// Token: 0x04000CA1 RID: 3233
		public bool bool_0;

		// Token: 0x04000CA2 RID: 3234
		public List<GStruct0> list_0;

		// Token: 0x04000CA3 RID: 3235
		public Func<GClass79, bool> func_0;
	}

	// Token: 0x0200039E RID: 926
	[Serializable]
	private sealed class Class420
	{
		// Token: 0x060014D6 RID: 5334 RVA: 0x0005528C File Offset: 0x0005348C
		internal void method_0()
		{
			GClass113.gclass11_0.method_28();
		}

		// Token: 0x04000CA4 RID: 3236
		public static readonly GClass113.Class420 class420_0 = new GClass113.Class420();

		// Token: 0x04000CA5 RID: 3237
		public static Action action_0;
	}

	// Token: 0x0200039F RID: 927
	[StructLayout(LayoutKind.Auto)]
	private struct Struct191 : IAsyncStateMachine
	{
		// Token: 0x060014D7 RID: 5335 RVA: 0x00055298 File Offset: 0x00053498
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			ValueTuple<List<GStruct0>, Dictionary<string, string>> result;
			try
			{
				TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> awaiter;
				if (num != 0)
				{
					awaiter = this.gclass136_0.smethod_8(this.genum78_0, this.bool_0, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>, GClass113.Struct191>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>);
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

		// Token: 0x060014D8 RID: 5336 RVA: 0x00055360 File Offset: 0x00053560
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000CA6 RID: 3238
		public int int_0;

		// Token: 0x04000CA7 RID: 3239
		public AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>> asyncTaskMethodBuilder_0;

		// Token: 0x04000CA8 RID: 3240
		public GClass136 gclass136_0;

		// Token: 0x04000CA9 RID: 3241
		public GEnum78 genum78_0;

		// Token: 0x04000CAA RID: 3242
		public bool bool_0;

		// Token: 0x04000CAB RID: 3243
		private TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> taskAwaiter_0;
	}

	// Token: 0x020003A0 RID: 928
	[StructLayout(LayoutKind.Auto)]
	private struct Struct192 : IAsyncStateMachine
	{
		// Token: 0x060014D9 RID: 5337 RVA: 0x00055370 File Offset: 0x00053570
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = GClass113.smethod_10(default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass113.Struct192>(ref awaiter, ref this);
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

		// Token: 0x060014DA RID: 5338 RVA: 0x00055424 File Offset: 0x00053624
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000CAC RID: 3244
		public int int_0;

		// Token: 0x04000CAD RID: 3245
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000CAE RID: 3246
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003A1 RID: 929
	private sealed class Class421
	{
		// Token: 0x060014DC RID: 5340 RVA: 0x0005543C File Offset: 0x0005363C
		internal void method_0()
		{
			GClass113.gclass11_0.method_29(this.gclass136_0.ProfileName, out this.bool_0);
		}

		// Token: 0x04000CAF RID: 3247
		public GClass136 gclass136_0;

		// Token: 0x04000CB0 RID: 3248
		public bool bool_0;
	}

	// Token: 0x020003A2 RID: 930
	[StructLayout(LayoutKind.Auto)]
	private struct Struct193 : IAsyncStateMachine
	{
		// Token: 0x060014DD RID: 5341 RVA: 0x0005545C File Offset: 0x0005365C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			bool bool_;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.class421_0 = new GClass113.Class421();
					this.class421_0.gclass136_0 = this.gclass136_0;
					this.class421_0.bool_0 = false;
					awaiter = Task.Run(new Action(this.class421_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass113.Struct193>(ref awaiter, ref this);
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
				bool_ = this.class421_0.bool_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class421_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class421_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(bool_);
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0005555C File Offset: 0x0005375C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000CB1 RID: 3249
		public int int_0;

		// Token: 0x04000CB2 RID: 3250
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x04000CB3 RID: 3251
		public GClass136 gclass136_0;

		// Token: 0x04000CB4 RID: 3252
		private GClass113.Class421 class421_0;

		// Token: 0x04000CB5 RID: 3253
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003A3 RID: 931
	[StructLayout(LayoutKind.Auto)]
	private struct Struct194 : IAsyncStateMachine
	{
		// Token: 0x060014DF RID: 5343 RVA: 0x0005556C File Offset: 0x0005376C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num != 1)
					{
						if (!GClass113.smethod_0())
						{
							awaiter = GClass113.gclass10_0.method_22(false, null, this.cancellationToken_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass113.Struct194>(ref awaiter, ref this);
								return;
							}
							goto IL_F2;
						}
						else
						{
							awaiter = GClass113.gclass10_0.method_22(true, null, this.cancellationToken_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass113.Struct194>(ref awaiter, ref this);
								return;
							}
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					goto IL_104;
				}
				awaiter = this.taskAwaiter_0;
				this.taskAwaiter_0 = default(TaskAwaiter);
				this.int_0 = -1;
				IL_F2:
				awaiter.GetResult();
				GClass113.smethod_11();
				GClass113.smethod_1(true);
				IL_104:;
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

		// Token: 0x060014E0 RID: 5344 RVA: 0x000556CC File Offset: 0x000538CC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000CB6 RID: 3254
		public int int_0;

		// Token: 0x04000CB7 RID: 3255
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000CB8 RID: 3256
		public CancellationToken cancellationToken_0;

		// Token: 0x04000CB9 RID: 3257
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003A4 RID: 932
	private sealed class Class422
	{
		// Token: 0x060014E2 RID: 5346 RVA: 0x000556E4 File Offset: 0x000538E4
		internal void method_0()
		{
			if (this.ienumerable_0.Count<GClass79>() > 0)
			{
				GClass113.gclass11_0.method_34(this.gclass136_0, this.ienumerable_0);
			}
		}

		// Token: 0x04000CBA RID: 3258
		public IEnumerable<GClass79> ienumerable_0;

		// Token: 0x04000CBB RID: 3259
		public GClass136 gclass136_0;
	}

	// Token: 0x020003A5 RID: 933
	[StructLayout(LayoutKind.Auto)]
	private struct Struct195 : IAsyncStateMachine
	{
		// Token: 0x060014E3 RID: 5347 RVA: 0x0005570C File Offset: 0x0005390C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GStruct9 result;
			try
			{
				TaskAwaiter<GStruct9> awaiter;
				if (num != 0)
				{
					awaiter = GClass113.smethod_4(default(CancellationToken), false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GStruct9>, GClass113.Struct195>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GStruct9>);
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

		// Token: 0x060014E4 RID: 5348 RVA: 0x000557C4 File Offset: 0x000539C4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000CBC RID: 3260
		public int int_0;

		// Token: 0x04000CBD RID: 3261
		public AsyncTaskMethodBuilder<GStruct9> asyncTaskMethodBuilder_0;

		// Token: 0x04000CBE RID: 3262
		private TaskAwaiter<GStruct9> taskAwaiter_0;
	}
}
