using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020001C8 RID: 456
internal sealed class Class250
{
	// Token: 0x06000AD2 RID: 2770 RVA: 0x00032648 File Offset: 0x00030848
	public static void smethod_0()
	{
		Class250.Struct94 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class250.Struct94>(ref @struct);
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x00032678 File Offset: 0x00030878
	private static void smethod_1(Class174.Class175 class175_0)
	{
		Class250.int_2 = class175_0.method_2();
		Class250.int_3 = class175_0.method_4();
		int num = 0;
		for (int i = 0; i < Class250.int_2; i++)
		{
			Class250.list_0.Add(new Class163
			{
				Core = i,
				Thread = num++,
				IsECore = false
			});
			if (Class250.bool_0)
			{
				Class250.list_0.Add(new Class163
				{
					Core = i,
					Thread = num++,
					IsECore = false
				});
			}
		}
		Class389.class504_0.method_59(num.ToString());
		for (int j = Class250.int_2; j < Class250.int_3 + Class250.int_2; j++)
		{
			Class250.list_0.Add(new Class163
			{
				Core = j,
				Thread = num++,
				IsECore = true
			});
		}
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x0003276C File Offset: 0x0003096C
	private static void smethod_2()
	{
		int num = 0;
		for (int i = 0; i < Class250.int_0; i++)
		{
			Class250.list_0.Add(new Class163
			{
				Core = i,
				Thread = num++,
				IsECore = false
			});
			if (Class250.bool_0)
			{
				Class250.list_0.Add(new Class163
				{
					Core = i,
					Thread = num++,
					IsECore = false
				});
			}
		}
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x000327F0 File Offset: 0x000309F0
	private static bool smethod_3(Class174.Class175 class175_0)
	{
		return (Class250.int_1 == class175_0.method_2() + class175_0.method_4() && !Class250.bool_0) || (Class250.int_1 == class175_0.method_2() * 2 + class175_0.method_4() && Class250.bool_0);
	}

	// Token: 0x0400068F RID: 1679
	public static int int_0 = 0;

	// Token: 0x04000690 RID: 1680
	public static int int_1 = 0;

	// Token: 0x04000691 RID: 1681
	public static int int_2 = 0;

	// Token: 0x04000692 RID: 1682
	public static int int_3 = 0;

	// Token: 0x04000693 RID: 1683
	public static bool bool_0 = false;

	// Token: 0x04000694 RID: 1684
	public static string string_0 = "UNKNOWN";

	// Token: 0x04000695 RID: 1685
	public static bool bool_1 = false;

	// Token: 0x04000696 RID: 1686
	public static List<Class163> list_0 = new List<Class163>();

	// Token: 0x020001C9 RID: 457
	[StructLayout(LayoutKind.Auto)]
	private struct Struct94 : IAsyncStateMachine
	{
		// Token: 0x06000AD6 RID: 2774 RVA: 0x00032830 File Offset: 0x00030A30
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(Class250.Class251.class251_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class250.Struct94>(ref awaiter, ref this);
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
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000328FC File Offset: 0x00030AFC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000697 RID: 1687
		public int int_0;

		// Token: 0x04000698 RID: 1688
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000699 RID: 1689
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001CA RID: 458
	[Serializable]
	private sealed class Class251
	{
		// Token: 0x06000ADA RID: 2778 RVA: 0x00032920 File Offset: 0x00030B20
		internal Task method_0()
		{
			Class250.Class251.Struct95 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class250.Class251.Struct95>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0003295C File Offset: 0x00030B5C
		internal bool method_1(Class174.Class175 class175_0)
		{
			return class175_0.method_0().ToLower() == Class250.string_0.Split(new char[]
			{
				'-'
			}).Last<string>().ToLower();
		}

		// Token: 0x0400069A RID: 1690
		public static readonly Class250.Class251 class251_0 = new Class250.Class251();

		// Token: 0x0400069B RID: 1691
		public static Func<Class174.Class175, bool> func_0;

		// Token: 0x0400069C RID: 1692
		public static Func<Task> func_1;

		// Token: 0x020001CB RID: 459
		[StructLayout(LayoutKind.Auto)]
		private struct Struct95 : IAsyncStateMachine
		{
			// Token: 0x06000ADC RID: 2780 RVA: 0x00032990 File Offset: 0x00030B90
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						Class250.int_0 = Class537.smethod_3();
						Class250.int_1 = Class537.smethod_2();
						Class389.class504_0.method_61(Class250.int_1.ToString());
						Class250.bool_0 = (Class250.int_0 != Class250.int_1);
						try
						{
							ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor").Get().GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									ManagementBaseObject managementBaseObject = enumerator.Current;
									Class250.string_0 = ((ManagementObject)managementBaseObject)["Name"].ToString();
								}
							}
							finally
							{
								if (num < 0 && enumerator != null)
								{
									((IDisposable)enumerator).Dispose();
								}
							}
						}
						catch (object obj)
						{
						}
						this.class175_0 = Class174.list_0.FirstOrDefault(new Func<Class174.Class175, bool>(Class250.Class251.class251_0.method_1));
						if (this.class175_0 == null)
						{
							Class250.smethod_2();
							Class250.bool_1 = true;
							goto IL_194;
						}
						awaiter = Class253.smethod_7().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class250.Class251.Struct95>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<bool>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					Class250.bool_0 = awaiter.GetResult();
					if (!Class250.smethod_3(this.class175_0))
					{
						Class250.smethod_2();
						Class250.bool_1 = true;
					}
					else
					{
						Class250.smethod_1(this.class175_0);
						Class250.bool_1 = true;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class175_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_194:
				this.int_0 = -2;
				this.class175_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06000ADD RID: 2781 RVA: 0x00032B98 File Offset: 0x00030D98
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400069D RID: 1693
			public int int_0;

			// Token: 0x0400069E RID: 1694
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400069F RID: 1695
			private Class174.Class175 class175_0;

			// Token: 0x040006A0 RID: 1696
			private TaskAwaiter<bool> taskAwaiter_0;
		}
	}
}
