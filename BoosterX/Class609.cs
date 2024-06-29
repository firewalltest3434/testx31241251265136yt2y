using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media;
using ns0;

// Token: 0x02000538 RID: 1336
internal sealed class Class609
{
	// Token: 0x06001D31 RID: 7473 RVA: 0x0007A78C File Offset: 0x0007898C
	public static List<Class609.Class610> smethod_0()
	{
		return Class609.list_0;
	}

	// Token: 0x06001D32 RID: 7474 RVA: 0x0007A794 File Offset: 0x00078994
	public static void smethod_1(List<Class609.Class610> list_1)
	{
		Class609.list_0 = list_1;
	}

	// Token: 0x04001485 RID: 5253
	private static List<Class609.Class610> list_0 = new List<Class609.Class610>
	{
		new Class609.Class610(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), Class364.smethod_2("BasicSettingsSvg"), Class364.smethod_0("settingsexp"), new Action(Class609.Class611.class611_0.method_0)),
		new Class609.Class610(typeof(dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd), Class364.smethod_2("NvidiaSvg"), Class364.smethod_0("NvidiaPage"), new Action(Class609.Class611.class611_0.method_1)),
		new Class609.Class610(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd), Class364.smethod_2("PowerSvg"), Class364.smethod_0("powermgmtexp"), new Action(Class609.Class611.class611_0.method_2)),
		new Class609.Class610(typeof(dje_z4EFBE23NRXT78H3EAL45CK9M5K537HLZVTED9PC5FL6WLE8YYJD3VFKL5QNA_ejd), Class364.smethod_2("WindowsSvg"), Class364.smethod_0("uwpappsexp"), new Action(Class609.Class611.class611_0.method_3)),
		new Class609.Class610(typeof(dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd), Class364.smethod_2("CogsSvg"), Class364.smethod_0("servicesexp"), new Action(Class609.Class611.class611_0.method_4)),
		new Class609.Class610(typeof(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd), Class364.smethod_2("ServicesSvg"), Class364.smethod_0("servicesexp"), new Action(Class609.Class611.class611_0.method_5)),
		new Class609.Class610(typeof(dje_z627PU6QDPF5L5L22PZKAYL8VEPS25LWV7TFR5U5JH6MNTERGA6VSXSKBF49Q_ejd), Class364.smethod_2("CleanUpSvg"), Class364.smethod_0("cleanupexp"), new Action(Class609.Class611.class611_0.method_6)),
		new Class609.Class610(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd), Class364.smethod_2("PrivacySvg"), Class364.smethod_0("Privacy"), new Action(Class609.Class611.class611_0.method_7)),
		new Class609.Class610(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd), Class364.smethod_2("RegistrySvg"), Class364.smethod_0("registrytweaksexp"), new Action(Class609.Class611.class611_0.method_8)),
		new Class609.Class610(typeof(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd), Class364.smethod_2("InterruptsSvg"), Class364.smethod_0("affinityexp"), new Action(Class609.Class611.class611_0.method_9)),
		new Class609.Class610(typeof(dje_z8NYEPSSJS77QLDRYJP4YDHXMCCZX642R76WUWAX6XD7EC3JPH2Y7TCVK5HRQ_ejd), Class364.smethod_2("AutorunsSvg"), Class364.smethod_0("autorunsexp"), new Action(Class609.Class611.class611_0.method_10)),
		new Class609.Class610(typeof(dje_zEAHJHJCF7YEVQXCTVJ6ZYLNYMV3GV7DXZT4HM29Y3NNNKUR5WQZEF_ejd), Class397.smethod_5("Chip"), Class364.smethod_0("Devices"), new Action(Class609.Class611.class611_0.method_11)),
		new Class609.Class610(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd), Class397.smethod_5("TaskAdd"), Class364.smethod_0("Tasks"), new Action(Class609.Class611.class611_0.method_12)),
		new Class609.Class610(typeof(dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd), Class397.smethod_5("CogSync"), Class364.smethod_0("Features"), new Action(Class609.Class611.class611_0.method_13)),
		new Class609.Class610(typeof(dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd), Class397.smethod_5("Brush"), Class364.smethod_0("Customization"), new Action(Class609.Class611.class611_0.method_14))
	};

	// Token: 0x02000539 RID: 1337
	public sealed class Class610
	{
		// Token: 0x06001D33 RID: 7475 RVA: 0x0007A79C File Offset: 0x0007899C
		public Class610(Type type_1, DrawingImage drawingImage_1, string string_1, Action action_1)
		{
			this.method_1(type_1);
			this.Name = string_1;
			this.Icon = drawingImage_1;
			this.method_3(action_1);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0007A7C4 File Offset: 0x000789C4
		public Type method_0()
		{
			return this.type_0;
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x0007A7CC File Offset: 0x000789CC
		public void method_1(Type type_1)
		{
			this.type_0 = type_1;
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x0007A7D8 File Offset: 0x000789D8
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x0007A7E0 File Offset: 0x000789E0
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x0007A7EC File Offset: 0x000789EC
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x0007A7F4 File Offset: 0x000789F4
		public DrawingImage Icon
		{
			[CompilerGenerated]
			get
			{
				return this.drawingImage_0;
			}
			[CompilerGenerated]
			set
			{
				this.drawingImage_0 = value;
			}
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0007A800 File Offset: 0x00078A00
		public Action method_2()
		{
			return this.action_0;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0007A808 File Offset: 0x00078A08
		public void method_3(Action action_1)
		{
			this.action_0 = action_1;
		}

		// Token: 0x04001486 RID: 5254
		private Type type_0;

		// Token: 0x04001487 RID: 5255
		private string string_0;

		// Token: 0x04001488 RID: 5256
		private DrawingImage drawingImage_0;

		// Token: 0x04001489 RID: 5257
		private Action action_0;
	}

	// Token: 0x0200053A RID: 1338
	[Serializable]
	private sealed class Class611
	{
		// Token: 0x06001D3E RID: 7486 RVA: 0x0007A828 File Offset: 0x00078A28
		internal void method_0()
		{
			Class609.Class611.Struct306 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class609.Class611.Struct306>(ref @struct);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x0007A858 File Offset: 0x00078A58
		internal void method_1()
		{
			Class451.smethod_0(false).RefreshCommand.Execute(null);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0007A86C File Offset: 0x00078A6C
		internal void method_2()
		{
			Class609.Class611.Struct309 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class609.Class611.Struct309>(ref @struct);
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0007A89C File Offset: 0x00078A9C
		internal void method_3()
		{
			Class462.smethod_0(true);
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x0007A8A8 File Offset: 0x00078AA8
		internal void method_4()
		{
			Class683.smethod_1(true);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x0007A8B4 File Offset: 0x00078AB4
		internal void method_5()
		{
			Class683.smethod_1(true);
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x0007A8C0 File Offset: 0x00078AC0
		internal void method_6()
		{
			Class664.smethod_2(true);
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x0007A8CC File Offset: 0x00078ACC
		internal void method_7()
		{
			Class609.Class611.Struct310 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class609.Class611.Struct310>(ref @struct);
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0007A8FC File Offset: 0x00078AFC
		internal void method_8()
		{
			Class609.Class611.Struct305 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class609.Class611.Struct305>(ref @struct);
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0007A92C File Offset: 0x00078B2C
		internal void method_9()
		{
			Class310.smethod_0(true);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0007A938 File Offset: 0x00078B38
		internal void method_10()
		{
			Class150.smethod_0(true);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x0007A944 File Offset: 0x00078B44
		internal void method_11()
		{
			GClass161.smethod_0(true);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0007A950 File Offset: 0x00078B50
		internal void method_12()
		{
			Class609.Class611.Struct308 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class609.Class611.Struct308>(ref @struct);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0007A980 File Offset: 0x00078B80
		internal void method_13()
		{
			Class609.Class611.Struct304 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class609.Class611.Struct304>(ref @struct);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x0007A9B0 File Offset: 0x00078BB0
		internal void method_14()
		{
			Class609.Class611.Struct307 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class609.Class611.Struct307>(ref @struct);
		}

		// Token: 0x0400148A RID: 5258
		public static readonly Class609.Class611 class611_0 = new Class609.Class611();

		// Token: 0x0200053B RID: 1339
		[StructLayout(LayoutKind.Auto)]
		private struct Struct304 : IAsyncStateMachine
		{
			// Token: 0x06001D4D RID: 7501 RVA: 0x0007A9E0 File Offset: 0x00078BE0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<Class718> awaiter;
					if (num != 0)
					{
						awaiter = Class271.smethod_0(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class718>, Class609.Class611.Struct304>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Class718>);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06001D4E RID: 7502 RVA: 0x0007AA8C File Offset: 0x00078C8C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400148B RID: 5259
			public int int_0;

			// Token: 0x0400148C RID: 5260
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400148D RID: 5261
			private TaskAwaiter<Class718> taskAwaiter_0;
		}

		// Token: 0x0200053C RID: 1340
		[StructLayout(LayoutKind.Auto)]
		private struct Struct305 : IAsyncStateMachine
		{
			// Token: 0x06001D4F RID: 7503 RVA: 0x0007AA9C File Offset: 0x00078C9C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num != 0)
					{
						awaiter = Class588.smethod_2(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class609.Class611.Struct305>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06001D50 RID: 7504 RVA: 0x0007AB54 File Offset: 0x00078D54
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400148E RID: 5262
			public int int_0;

			// Token: 0x0400148F RID: 5263
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001490 RID: 5264
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
		}

		// Token: 0x0200053D RID: 1341
		[StructLayout(LayoutKind.Auto)]
		private struct Struct306 : IAsyncStateMachine
		{
			// Token: 0x06001D51 RID: 7505 RVA: 0x0007AB64 File Offset: 0x00078D64
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num != 0)
					{
						awaiter = Class588.smethod_2(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class609.Class611.Struct306>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06001D52 RID: 7506 RVA: 0x0007AC1C File Offset: 0x00078E1C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001491 RID: 5265
			public int int_0;

			// Token: 0x04001492 RID: 5266
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001493 RID: 5267
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
		}

		// Token: 0x0200053E RID: 1342
		[StructLayout(LayoutKind.Auto)]
		private struct Struct307 : IAsyncStateMachine
		{
			// Token: 0x06001D53 RID: 7507 RVA: 0x0007AC2C File Offset: 0x00078E2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num != 0)
					{
						awaiter = Class588.smethod_2(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class609.Class611.Struct307>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06001D54 RID: 7508 RVA: 0x0007ACE4 File Offset: 0x00078EE4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001494 RID: 5268
			public int int_0;

			// Token: 0x04001495 RID: 5269
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001496 RID: 5270
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
		}

		// Token: 0x0200053F RID: 1343
		[StructLayout(LayoutKind.Auto)]
		private struct Struct308 : IAsyncStateMachine
		{
			// Token: 0x06001D55 RID: 7509 RVA: 0x0007ACF4 File Offset: 0x00078EF4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num != 0)
					{
						awaiter = Class588.smethod_2(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class609.Class611.Struct308>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06001D56 RID: 7510 RVA: 0x0007ADAC File Offset: 0x00078FAC
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001497 RID: 5271
			public int int_0;

			// Token: 0x04001498 RID: 5272
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001499 RID: 5273
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
		}

		// Token: 0x02000540 RID: 1344
		[StructLayout(LayoutKind.Auto)]
		private struct Struct309 : IAsyncStateMachine
		{
			// Token: 0x06001D57 RID: 7511 RVA: 0x0007ADBC File Offset: 0x00078FBC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num != 0)
					{
						awaiter = Class588.smethod_2(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class609.Class611.Struct309>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06001D58 RID: 7512 RVA: 0x0007AE74 File Offset: 0x00079074
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400149A RID: 5274
			public int int_0;

			// Token: 0x0400149B RID: 5275
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400149C RID: 5276
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
		}

		// Token: 0x02000541 RID: 1345
		[StructLayout(LayoutKind.Auto)]
		private struct Struct310 : IAsyncStateMachine
		{
			// Token: 0x06001D59 RID: 7513 RVA: 0x0007AE84 File Offset: 0x00079084
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num != 0)
					{
						awaiter = Class588.smethod_2(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class609.Class611.Struct310>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06001D5A RID: 7514 RVA: 0x0007AF3C File Offset: 0x0007913C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400149D RID: 5277
			public int int_0;

			// Token: 0x0400149E RID: 5278
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400149F RID: 5279
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
		}
	}
}
