using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ns0;

// Token: 0x02000660 RID: 1632
internal sealed class Class704
{
	// Token: 0x060022FB RID: 8955 RVA: 0x0008B5E4 File Offset: 0x000897E4
	public static Task smethod_0()
	{
		Class704.Struct380 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class704.Struct380>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060022FC RID: 8956 RVA: 0x0008B620 File Offset: 0x00089820
	public static Task smethod_1()
	{
		Class704.Struct379 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class704.Struct379>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060022FD RID: 8957 RVA: 0x0008B65C File Offset: 0x0008985C
	public static Task smethod_2()
	{
		Class704.Struct383 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class704.Struct383>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060022FE RID: 8958 RVA: 0x0008B698 File Offset: 0x00089898
	public static Task smethod_3()
	{
		Class704.Struct378 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class704.Struct378>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x0008B6D4 File Offset: 0x000898D4
	public static Task smethod_4()
	{
		Class704.Struct377 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class704.Struct377>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002300 RID: 8960 RVA: 0x0008B710 File Offset: 0x00089910
	public static Task smethod_5()
	{
		Class704.Struct382 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class704.Struct382>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x040017DC RID: 6108
	public static bool bool_0;

	// Token: 0x040017DD RID: 6109
	public static bool bool_1;

	// Token: 0x040017DE RID: 6110
	public static Class580 class580_0;

	// Token: 0x02000661 RID: 1633
	[StructLayout(LayoutKind.Auto)]
	private struct Struct377 : IAsyncStateMachine
	{
		// Token: 0x06002301 RID: 8961 RVA: 0x0008B74C File Offset: 0x0008994C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_94;
				}
				if (num != 1)
				{
					awaiter = Class704.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Struct377>(ref awaiter, ref this);
						return;
					}
					goto IL_94;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_6C:
				awaiter.GetResult();
				goto IL_111;
				IL_94:
				awaiter.GetResult();
				awaiter = Task.Run(new Action(Class704.Class705.class705_0.method_3)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Struct377>(ref awaiter, ref this);
					return;
				}
				goto IL_6C;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_111:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0008B890 File Offset: 0x00089A90
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040017DF RID: 6111
		public int int_0;

		// Token: 0x040017E0 RID: 6112
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040017E1 RID: 6113
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000662 RID: 1634
	[StructLayout(LayoutKind.Auto)]
	private struct Struct378 : IAsyncStateMachine
	{
		// Token: 0x06002303 RID: 8963 RVA: 0x0008B8A0 File Offset: 0x00089AA0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_94;
				}
				if (num != 1)
				{
					awaiter = Class704.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Struct378>(ref awaiter, ref this);
						return;
					}
					goto IL_94;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_6C:
				awaiter.GetResult();
				goto IL_111;
				IL_94:
				awaiter.GetResult();
				awaiter = Task.Run(new Action(Class704.Class705.class705_0.method_2)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Struct378>(ref awaiter, ref this);
					return;
				}
				goto IL_6C;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_111:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0008B9E4 File Offset: 0x00089BE4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040017E2 RID: 6114
		public int int_0;

		// Token: 0x040017E3 RID: 6115
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040017E4 RID: 6116
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000663 RID: 1635
	[StructLayout(LayoutKind.Auto)]
	private struct Struct379 : IAsyncStateMachine
	{
		// Token: 0x06002305 RID: 8965 RVA: 0x0008B9F4 File Offset: 0x00089BF4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_94;
				}
				if (num != 1)
				{
					awaiter = Class704.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Struct379>(ref awaiter, ref this);
						return;
					}
					goto IL_94;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_6C:
				awaiter.GetResult();
				goto IL_111;
				IL_94:
				awaiter.GetResult();
				awaiter = Task.Run(new Action(Class704.Class705.class705_0.method_0)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Struct379>(ref awaiter, ref this);
					return;
				}
				goto IL_6C;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_111:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x0008BB38 File Offset: 0x00089D38
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040017E5 RID: 6117
		public int int_0;

		// Token: 0x040017E6 RID: 6118
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040017E7 RID: 6119
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000664 RID: 1636
	[StructLayout(LayoutKind.Auto)]
	private struct Struct380 : IAsyncStateMachine
	{
		// Token: 0x06002307 RID: 8967 RVA: 0x0008BB48 File Offset: 0x00089D48
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				if (num > 3)
				{
					if (Class704.bool_1)
					{
						goto IL_256;
					}
					Class704.bool_1 = true;
				}
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<bool> awaiter2;
					TaskAwaiter<Class718> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<bool>);
						this.int_0 = -1;
						goto IL_E1;
					case 2:
						awaiter3 = this.taskAwaiter_2;
						this.taskAwaiter_2 = default(TaskAwaiter<Class718>);
						this.int_0 = -1;
						goto IL_167;
					case 3:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_211;
					default:
						awaiter = Class588.smethod_7().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Struct380>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter2 = Class588.smethod_10().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class704.Struct380>(ref awaiter2, ref this);
						return;
					}
					IL_E1:
					awaiter2.GetResult();
					GClass161.smethod_0(true);
					Class664.smethod_2(true);
					Class462.smethod_0(true);
					Class683.smethod_1(true);
					Class310.smethod_0(true);
					Class150.smethod_0(true);
					awaiter3 = Class271.smethod_0(true).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_2 = awaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class718>, Class704.Struct380>(ref awaiter3, ref this);
						return;
					}
					IL_167:
					awaiter3.GetResult();
					awaiter = Task.WhenAll(new List<Task>
					{
						GClass161.smethod_5(),
						Class664.smethod_6(),
						Class462.smethod_4(),
						Class683.smethod_7(),
						Class310.smethod_4(),
						Class150.smethod_5(),
						Class271.smethod_4()
					}).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Struct380>(ref awaiter, ref this);
						return;
					}
					IL_211:
					awaiter.GetResult();
					if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_3)
					{
						Class451.smethod_0(false).RefreshCommand.Execute(null);
					}
				}
				catch (object obj)
				{
				}
				Class704.bool_1 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_256:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x0008BDF4 File Offset: 0x00089FF4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040017E8 RID: 6120
		public int int_0;

		// Token: 0x040017E9 RID: 6121
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040017EA RID: 6122
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x040017EB RID: 6123
		private TaskAwaiter<bool> taskAwaiter_1;

		// Token: 0x040017EC RID: 6124
		private TaskAwaiter<Class718> taskAwaiter_2;
	}

	// Token: 0x02000665 RID: 1637
	[Serializable]
	private sealed class Class705
	{
		// Token: 0x0600230B RID: 8971 RVA: 0x0008BE18 File Offset: 0x0008A018
		internal void method_0()
		{
			Class588.smethod_12(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd));
			Class588.smethod_12(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd));
			Class588.smethod_12(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd));
			Class588.smethod_12(typeof(dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd));
			Class271.smethod_3();
			GClass161.smethod_2();
			Class664.smethod_5();
			Class462.smethod_2();
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_3)
			{
				GClass222 gclass = Class451.smethod_0(false);
				int num = 0;
				while (gclass.bool_0 && num++ <= 500)
				{
					Task.Delay(20).Wait();
				}
				gclass.OptimalClickCommand.Execute(null);
			}
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x0008BEC4 File Offset: 0x0008A0C4
		internal void method_1()
		{
			Class588.smethod_12(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd));
			Class588.smethod_12(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd));
			Class588.smethod_12(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd));
			Class588.smethod_12(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd));
			Class588.smethod_12(typeof(dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd));
			Class271.smethod_3();
			GClass161.smethod_2();
			Class664.smethod_5();
			Class462.smethod_2();
			bool? flag = Class389.class504_0.method_40();
			if (flag.GetValueOrDefault() & flag != null)
			{
				Class683.smethod_4();
			}
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_3)
			{
				GClass222 gclass = Class451.smethod_0(false);
				int num = 0;
				while (gclass.bool_0 && num++ <= 500)
				{
					Task.Delay(20).Wait();
				}
				gclass.OptimalClickCommand.Execute(null);
			}
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x0008BFA4 File Offset: 0x0008A1A4
		internal void method_2()
		{
			Class588.smethod_11(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd));
			Class588.smethod_12(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd));
			Class588.smethod_12(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd));
			Class588.smethod_11(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd));
			Class588.smethod_11(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd));
			Class588.smethod_11(typeof(dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd));
			Class271.smethod_2();
			GClass161.smethod_2();
			Class664.smethod_5();
			Class462.smethod_2();
			bool? flag = Class389.class504_0.method_40();
			if (flag.GetValueOrDefault() & flag != null)
			{
				Class683.smethod_4();
			}
			Class310.smethod_2();
			Class150.smethod_3();
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_3)
			{
				GClass222 gclass = Class451.smethod_0(false);
				int num = 0;
				while (gclass.bool_0 && num++ <= 500)
				{
					Task.Delay(20).Wait();
				}
				gclass.OptimalClickCommand.Execute(null);
			}
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x0008C09C File Offset: 0x0008A29C
		internal void method_3()
		{
			Class588.smethod_11(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd));
			Class588.smethod_11(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd));
			Class588.smethod_11(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd));
			Class588.smethod_11(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd));
			Class588.smethod_11(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd));
			GClass161.smethod_3();
			Class664.smethod_5();
			Class462.smethod_2();
			bool? flag = Class389.class504_0.method_40();
			if (flag.GetValueOrDefault() & flag != null)
			{
				Class683.smethod_5(null);
			}
			Class310.smethod_2();
			Class150.smethod_3();
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_3)
			{
				GClass222 gclass = Class451.smethod_0(false);
				int num = 0;
				while (gclass.bool_0 && num++ <= 500)
				{
					Task.Delay(20).Wait();
				}
				gclass.OptimalClickCommand.Execute(null);
			}
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x0008C184 File Offset: 0x0008A384
		internal Task method_4()
		{
			Class704.Class705.Struct381 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class704.Class705.Struct381>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x0008C1C0 File Offset: 0x0008A3C0
		internal bool method_5(Class745 class745_0)
		{
			return class745_0.NameRaw == "DefenderAndSmartScreen";
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x0008C1D4 File Offset: 0x0008A3D4
		internal bool method_6(Class745 class745_0)
		{
			return class745_0.NameRaw == "FSO";
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x0008C1E8 File Offset: 0x0008A3E8
		internal bool method_7(Class745 class745_0)
		{
			return class745_0.NameRaw == "GameBar";
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x0008C1FC File Offset: 0x0008A3FC
		internal bool method_8(Class745 class745_0)
		{
			return class745_0.NameRaw == "setsfirewall";
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x0008C210 File Offset: 0x0008A410
		internal bool method_9(Class745 class745_0)
		{
			return class745_0.NameRaw == "TaskXBOX";
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x0008C224 File Offset: 0x0008A424
		internal bool method_10(Class745 class745_0)
		{
			return class745_0.NameRaw == "TaskXBOX";
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x0008C238 File Offset: 0x0008A438
		internal bool method_11(Class745 class745_0)
		{
			return class745_0.NameRaw == "setsvisuals";
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x0008C24C File Offset: 0x0008A44C
		internal void method_12()
		{
			Class185.smethod_22("reg add \"HKLM\\Software\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU\" /v \"NoAutoUpdate\"  /t REG_DWORD /d \"1\" /f");
			Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings\" /v \"FlightSettingsMaxPauseDays\"  /t REG_DWORD /d \"5269\" /f");
			Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings\" /v \"PauseFeatureUpdatesStartTime\"  /t REG_SZ /d \"2023-10-20T01:00:00Z\" /f");
			Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings\" /v \"PauseFeatureUpdatesStartTime\"  /t REG_SZ /d \"2038-01-20T01:00:00Z\" /f");
			Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings\" /v \"PauseQualityUpdatesStartTime\"  /t REG_SZ /d \"2023-10-20T01:00:00Z\" /f");
			Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings\" /v \"PauseQualityUpdatesEndTime\"  /t REG_SZ /d \"2038-01-20T01:00:00Z\" /f");
			Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings\" /v \"PauseUpdatesStartTime\"  /t REG_SZ /d \"2023-10-20T01:00:00Z\" /f");
			Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings\" /v \"PauseUpdatesExpiryTime\"  /t REG_SZ /d \"2038-01-20T01:00:00Z\" /f");
			Class185.smethod_22("reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DeliveryOptimization\\Settings\" /v \"DownloadMode\"  /t REG_SZ /d \"0\" /f");
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0008C2B4 File Offset: 0x0008A4B4
		internal bool method_13(GClass226 gclass226_0)
		{
			return gclass226_0.Name == "Bluetooth";
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0008C2C8 File Offset: 0x0008A4C8
		internal bool method_14(GClass226 gclass226_0)
		{
			return gclass226_0.Name == "Print";
		}

		// Token: 0x040017ED RID: 6125
		public static readonly Class704.Class705 class705_0 = new Class704.Class705();

		// Token: 0x040017EE RID: 6126
		public static Action action_0;

		// Token: 0x040017EF RID: 6127
		public static Action action_1;

		// Token: 0x040017F0 RID: 6128
		public static Action action_2;

		// Token: 0x040017F1 RID: 6129
		public static Action action_3;

		// Token: 0x040017F2 RID: 6130
		public static Func<Class745, bool> func_0;

		// Token: 0x040017F3 RID: 6131
		public static Func<Class745, bool> func_1;

		// Token: 0x040017F4 RID: 6132
		public static Func<Class745, bool> func_2;

		// Token: 0x040017F5 RID: 6133
		public static Func<Class745, bool> func_3;

		// Token: 0x040017F6 RID: 6134
		public static Func<Class745, bool> func_4;

		// Token: 0x040017F7 RID: 6135
		public static Func<Class745, bool> func_5;

		// Token: 0x040017F8 RID: 6136
		public static Func<Class745, bool> func_6;

		// Token: 0x040017F9 RID: 6137
		public static Action action_4;

		// Token: 0x040017FA RID: 6138
		public static Func<GClass226, bool> func_7;

		// Token: 0x040017FB RID: 6139
		public static Func<GClass226, bool> func_8;

		// Token: 0x040017FC RID: 6140
		public static Func<Task> func_9;

		// Token: 0x02000666 RID: 1638
		[StructLayout(LayoutKind.Auto)]
		private struct Struct381 : IAsyncStateMachine
		{
			// Token: 0x0600231A RID: 8986 RVA: 0x0008C2DC File Offset: 0x0008A4DC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					try
					{
						TaskAwaiter awaiter;
						TaskAwaiter<ObservableCollection<Class745>> awaiter2;
						switch (num)
						{
						case 0:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							break;
						case 1:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_1C7;
						case 2:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class745>>);
							this.int_0 = -1;
							goto IL_290;
						case 3:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class745>>);
							this.int_0 = -1;
							goto IL_362;
						case 4:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class745>>);
							this.int_0 = -1;
							goto IL_402;
						case 5:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class745>>);
							this.int_0 = -1;
							goto IL_500;
						case 6:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class745>>);
							this.int_0 = -1;
							goto IL_5A0;
						case 7:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class745>>);
							this.int_0 = -1;
							goto IL_600;
						case 8:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class745>>);
							this.int_0 = -1;
							goto IL_6B9;
						case 9:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_7C4;
						case 10:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_897;
						default:
							awaiter = Class704.smethod_0().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Class705.Struct381>(ref awaiter, ref this);
								return;
							}
							break;
						}
						awaiter.GetResult();
						Class588.smethod_12(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd));
						Class588.smethod_12(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd));
						Class588.smethod_12(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd));
						Class588.smethod_12(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd));
						Class588.smethod_11(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd));
						Class588.smethod_12(typeof(dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd));
						Class271.smethod_3();
						GClass161.smethod_2();
						Class664.smethod_5();
						Class462.smethod_2();
						Class310.smethod_2();
						Class150.smethod_3();
						bool? nullable_ = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.nullable_2;
						if (nullable_.GetValueOrDefault() & nullable_ != null)
						{
							GClass93.smethod_0().method_15(typeof(Class525), Class364.smethod_0("PowerXv2"));
						}
						if (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_3 || !Class704.class580_0.method_14("QNvidia").IsChecked)
						{
							goto IL_22F;
						}
						this.gclass222_0 = Class451.smethod_0(false);
						this.int_1 = 0;
						IL_181:
						if (this.gclass222_0.bool_0)
						{
							int num2 = this.int_1;
							this.int_1 = num2 + 1;
							if (num2 <= 500)
							{
								awaiter = Task.Delay(20).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									goto IL_1C7;
								}
								this.int_0 = 1;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Class705.Struct381>(ref awaiter, ref this);
								return;
							}
						}
						this.gclass222_0.OptimalClickCommand.Execute(null);
						this.gclass222_0 = null;
						goto IL_22F;
						IL_1C7:
						awaiter.GetResult();
						goto IL_181;
						IL_22F:
						awaiter2 = Class588.smethod_2(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 2;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class704.Class705.Struct381>(ref awaiter2, ref this);
							return;
						}
						IL_290:
						Class745 @class = awaiter2.GetResult().FirstOrDefault(new Func<Class745, bool>(Class704.Class705.class705_0.method_5));
						if (@class != null)
						{
							@class.method_17();
						}
						if (!Class704.class580_0.method_14("QAlttab").IsChecked && Class704.class580_0.method_14("QGameBar").IsChecked)
						{
							goto IL_441;
						}
						awaiter2 = Class588.smethod_2(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 3;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class704.Class705.Struct381>(ref awaiter2, ref this);
							return;
						}
						IL_362:
						Class745 class2 = awaiter2.GetResult().FirstOrDefault(new Func<Class745, bool>(Class704.Class705.class705_0.method_6));
						if (class2 != null)
						{
							class2.method_14();
						}
						awaiter2 = Class588.smethod_2(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 4;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class704.Class705.Struct381>(ref awaiter2, ref this);
							return;
						}
						IL_402:
						Class745 class3 = awaiter2.GetResult().FirstOrDefault(new Func<Class745, bool>(Class704.Class705.class705_0.method_7));
						if (class3 != null)
						{
							class3.method_14();
						}
						IL_441:
						if (Class704.class580_0.method_14("QXBOX").IsChecked)
						{
							awaiter2 = Class588.smethod_2(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 5;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class704.Class705.Struct381>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = Class588.smethod_2(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd), false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 7;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class704.Class705.Struct381>(ref awaiter2, ref this);
								return;
							}
							goto IL_600;
						}
						IL_500:
						Class745 class4 = awaiter2.GetResult().FirstOrDefault(new Func<Class745, bool>(Class704.Class705.class705_0.method_8));
						if (class4 != null)
						{
							class4.method_14();
						}
						awaiter2 = Class588.smethod_2(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd), false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 6;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class704.Class705.Struct381>(ref awaiter2, ref this);
							return;
						}
						IL_5A0:
						Class745 class5 = awaiter2.GetResult().FirstOrDefault(new Func<Class745, bool>(Class704.Class705.class705_0.method_9));
						if (class5 == null)
						{
							goto IL_63F;
						}
						class5.method_14();
						goto IL_63F;
						IL_600:
						Class745 class6 = awaiter2.GetResult().FirstOrDefault(new Func<Class745, bool>(Class704.Class705.class705_0.method_10));
						if (class6 != null)
						{
							class6.method_16();
						}
						IL_63F:
						if (!Class704.class580_0.method_14("QVisuals").IsChecked)
						{
							goto IL_6F8;
						}
						awaiter2 = Class588.smethod_2(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 8;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class704.Class705.Struct381>(ref awaiter2, ref this);
							return;
						}
						IL_6B9:
						Class745 class7 = awaiter2.GetResult().FirstOrDefault(new Func<Class745, bool>(Class704.Class705.class705_0.method_11));
						if (class7 != null)
						{
							class7.method_14();
						}
						IL_6F8:
						if (Class704.class580_0.method_14("QUpdates").IsChecked)
						{
							Class178.dictionary_0.Add(Class364.smethod_0("DisableUpdates"), new Action(Class704.Class705.class705_0.method_12));
						}
						if (!Class704.class580_0.method_14("QBluetooth").IsChecked)
						{
							goto IL_81A;
						}
						this.gclass223_0 = GClass161.smethod_0(false);
						awaiter = GClass161.smethod_5().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 9;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Class705.Struct381>(ref awaiter, ref this);
							return;
						}
						IL_7C4:
						awaiter.GetResult();
						GClass226 gclass = this.gclass223_0.CustomDisableDevices.FirstOrDefault(new Func<GClass226, bool>(Class704.Class705.class705_0.method_13));
						if (gclass != null)
						{
							gclass.IsDisabled = new bool?(true);
						}
						this.gclass223_0 = null;
						IL_81A:
						if (!Class704.class580_0.method_14("QPrinter").IsChecked)
						{
							goto IL_8ED;
						}
						this.gclass223_0 = GClass161.smethod_0(false);
						awaiter = GClass161.smethod_5().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 10;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Class705.Struct381>(ref awaiter, ref this);
							return;
						}
						IL_897:
						awaiter.GetResult();
						GClass226 gclass2 = this.gclass223_0.CustomDisableDevices.FirstOrDefault(new Func<GClass226, bool>(Class704.Class705.class705_0.method_14));
						if (gclass2 != null)
						{
							gclass2.IsDisabled = new bool?(true);
						}
						this.gclass223_0 = null;
						IL_8ED:;
					}
					catch (object obj)
					{
					}
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

			// Token: 0x0600231B RID: 8987 RVA: 0x0008CC4C File Offset: 0x0008AE4C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040017FD RID: 6141
			public int int_0;

			// Token: 0x040017FE RID: 6142
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040017FF RID: 6143
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x04001800 RID: 6144
			private GClass222 gclass222_0;

			// Token: 0x04001801 RID: 6145
			private int int_1;

			// Token: 0x04001802 RID: 6146
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_1;

			// Token: 0x04001803 RID: 6147
			private GClass161.GClass223 gclass223_0;
		}
	}

	// Token: 0x02000667 RID: 1639
	[StructLayout(LayoutKind.Auto)]
	private struct Struct382 : IAsyncStateMachine
	{
		// Token: 0x0600231C RID: 8988 RVA: 0x0008CC5C File Offset: 0x0008AE5C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class704.class580_0 == null)
					{
						goto IL_A5;
					}
					awaiter = Task.Run(new Func<Task>(Class704.Class705.class705_0.method_4)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Struct382>(ref awaiter, ref this);
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
			IL_A5:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x0008CD34 File Offset: 0x0008AF34
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001804 RID: 6148
		public int int_0;

		// Token: 0x04001805 RID: 6149
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001806 RID: 6150
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000668 RID: 1640
	[StructLayout(LayoutKind.Auto)]
	private struct Struct383 : IAsyncStateMachine
	{
		// Token: 0x0600231E RID: 8990 RVA: 0x0008CD44 File Offset: 0x0008AF44
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_94;
				}
				if (num != 1)
				{
					awaiter = Class704.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Struct383>(ref awaiter, ref this);
						return;
					}
					goto IL_94;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_6C:
				awaiter.GetResult();
				goto IL_111;
				IL_94:
				awaiter.GetResult();
				awaiter = Task.Run(new Action(Class704.Class705.class705_0.method_1)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class704.Struct383>(ref awaiter, ref this);
					return;
				}
				goto IL_6C;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_111:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x0008CE88 File Offset: 0x0008B088
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001807 RID: 6151
		public int int_0;

		// Token: 0x04001808 RID: 6152
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001809 RID: 6153
		private TaskAwaiter taskAwaiter_0;
	}
}
