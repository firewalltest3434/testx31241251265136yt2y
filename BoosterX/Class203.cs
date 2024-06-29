using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Dism;

// Token: 0x0200017C RID: 380
internal sealed class Class203
{
	// Token: 0x060009CE RID: 2510 RVA: 0x0002CD78 File Offset: 0x0002AF78
	public static List<Class647> smethod_0()
	{
		if (!Class203.bool_0)
		{
			Class203.bool_0 = true;
			DismApi.Initialize(0);
			Class203.dismSession_0 = DismApi.OpenOnlineSessionEx(new DismSessionOptions
			{
				ThrowExceptionOnRebootRequired = false
			});
		}
		ReadOnlyCollection<DismFeature> features = DismApi.GetFeatures(Class203.dismSession_0);
		Class203.list_0.Clear();
		foreach (DismFeature dismFeature in features)
		{
			List<Class647> list = Class203.list_0;
			Class647 @class = new Class647();
			@class.method_1(dismFeature.FeatureName);
			@class.State = dismFeature.State.ToString();
			list.Add(@class);
		}
		return Class203.list_0;
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x0002CE30 File Offset: 0x0002B030
	public static void smethod_1(string string_0)
	{
		Task.Run(new Func<Task>(new Class203.Class204
		{
			string_0 = string_0
		}.method_0)).Wait();
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x0002CE54 File Offset: 0x0002B054
	public static void smethod_2(string string_0)
	{
		Task.Run(new Func<Task>(new Class203.Class205
		{
			string_0 = string_0
		}.method_0)).Wait();
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x0002CE78 File Offset: 0x0002B078
	public static void smethod_3(string string_0)
	{
		if (Class203.bool_1)
		{
			return;
		}
		DismApi.DisableFeature(Class203.dismSession_0, string_0, null, false);
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x0002CE90 File Offset: 0x0002B090
	public static void smethod_4(string string_0)
	{
		if (Class203.bool_1)
		{
			return;
		}
		bool flag = "DEFAULT" == "BEST";
		try
		{
			DismApi.EnableFeature(Class203.dismSession_0, string_0, false, true);
		}
		catch (object obj)
		{
		}
		bool flag2 = "DEFAULT" == "BEST";
		if (flag && flag2 != flag)
		{
			try
			{
				Class650.smethod_4("BoosterX", Class186.string_4, "Resources.EmbedRes.Tweaks.Updates", "disable.bat", false);
				string text = Class186.string_4 + "\\disable.bat";
				GClass104.smethod_0("cmd.exe /c \"" + text + "\"", false);
				File.Delete(text);
			}
			catch (object obj2)
			{
			}
		}
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x0002CF64 File Offset: 0x0002B164
	public static DismFeatureCollection smethod_5(string string_0)
	{
		return DismApi.GetFeatureParentByName(Class203.dismSession_0, string_0, null);
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x0002CF74 File Offset: 0x0002B174
	public static bool smethod_6(string string_0)
	{
		return DismApi.GetFeatureInfo(Class203.dismSession_0, string_0).FeatureState == 4;
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x0002CF8C File Offset: 0x0002B18C
	public static DismFeatureInfo smethod_7(string string_0)
	{
		return DismApi.GetFeatureInfo(Class203.dismSession_0, string_0);
	}

	// Token: 0x040005AD RID: 1453
	private static bool bool_0 = false;

	// Token: 0x040005AE RID: 1454
	private static DismSession dismSession_0;

	// Token: 0x040005AF RID: 1455
	public static List<Class647> list_0 = new List<Class647>();

	// Token: 0x040005B0 RID: 1456
	public static bool bool_1 = false;

	// Token: 0x0200017D RID: 381
	private sealed class Class204
	{
		// Token: 0x060009D7 RID: 2519 RVA: 0x0002CFA4 File Offset: 0x0002B1A4
		internal Task method_0()
		{
			Class203.Class204.Struct74 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class204_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class203.Class204.Struct74>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0002CFE8 File Offset: 0x0002B1E8
		internal void method_1()
		{
			Class203.smethod_4(this.string_0);
		}

		// Token: 0x040005B1 RID: 1457
		public string string_0;

		// Token: 0x040005B2 RID: 1458
		public Action action_0;

		// Token: 0x0200017E RID: 382
		[StructLayout(LayoutKind.Auto)]
		private struct Struct74 : IAsyncStateMachine
		{
			// Token: 0x060009D9 RID: 2521 RVA: 0x0002CFF8 File Offset: 0x0002B1F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class203.Class204 @class = this.class204_0;
				try
				{
					TaskAwaiter<Task> awaiter;
					if (num != 0)
					{
						this.task_0 = Task.Delay(TimeSpan.FromSeconds(60.0));
						Action action;
						if ((action = @class.action_0) == null)
						{
							action = (@class.action_0 = new Action(@class.method_1));
						}
						Task task = Task.Run(action);
						awaiter = Task.WhenAny(new Task[]
						{
							task,
							this.task_0
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class203.Class204.Struct74>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Task>);
						this.int_0 = -1;
					}
					if (awaiter.GetResult() == this.task_0)
					{
						Class203.bool_1 = true;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.task_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.task_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060009DA RID: 2522 RVA: 0x0002D120 File Offset: 0x0002B320
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005B3 RID: 1459
			public int int_0;

			// Token: 0x040005B4 RID: 1460
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005B5 RID: 1461
			public Class203.Class204 class204_0;

			// Token: 0x040005B6 RID: 1462
			private Task task_0;

			// Token: 0x040005B7 RID: 1463
			private TaskAwaiter<Task> taskAwaiter_0;
		}
	}

	// Token: 0x0200017F RID: 383
	private sealed class Class205
	{
		// Token: 0x060009DC RID: 2524 RVA: 0x0002D138 File Offset: 0x0002B338
		internal Task method_0()
		{
			Class203.Class205.Struct75 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class205_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class203.Class205.Struct75>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0002D17C File Offset: 0x0002B37C
		internal void method_1()
		{
			Class203.smethod_3(this.string_0);
		}

		// Token: 0x040005B8 RID: 1464
		public string string_0;

		// Token: 0x040005B9 RID: 1465
		public Action action_0;

		// Token: 0x02000180 RID: 384
		[StructLayout(LayoutKind.Auto)]
		private struct Struct75 : IAsyncStateMachine
		{
			// Token: 0x060009DE RID: 2526 RVA: 0x0002D18C File Offset: 0x0002B38C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class203.Class205 @class = this.class205_0;
				try
				{
					TaskAwaiter<Task> awaiter;
					if (num != 0)
					{
						this.task_0 = Task.Delay(TimeSpan.FromSeconds(60.0));
						Action action;
						if ((action = @class.action_0) == null)
						{
							action = (@class.action_0 = new Action(@class.method_1));
						}
						Task task = Task.Run(action);
						awaiter = Task.WhenAny(new Task[]
						{
							task,
							this.task_0
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class203.Class205.Struct75>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Task>);
						this.int_0 = -1;
					}
					if (awaiter.GetResult() == this.task_0)
					{
						Class203.bool_1 = true;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.task_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.task_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060009DF RID: 2527 RVA: 0x0002D2B4 File Offset: 0x0002B4B4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005BA RID: 1466
			public int int_0;

			// Token: 0x040005BB RID: 1467
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005BC RID: 1468
			public Class203.Class205 class205_0;

			// Token: 0x040005BD RID: 1469
			private Task task_0;

			// Token: 0x040005BE RID: 1470
			private TaskAwaiter<Task> taskAwaiter_0;
		}
	}
}
