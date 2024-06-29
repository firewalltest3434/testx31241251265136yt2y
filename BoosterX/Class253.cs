using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using LibreHardwareMonitor.Hardware;
using LibreHardwareMonitor.Hardware.Cpu;

// Token: 0x020001D2 RID: 466
internal sealed class Class253
{
	// Token: 0x06000AFF RID: 2815 RVA: 0x00033694 File Offset: 0x00031894
	public static void smethod_0(Class253.Delegate24 delegate24_1)
	{
		Class253.Delegate24 @delegate = Class253.delegate24_0;
		Class253.Delegate24 delegate2;
		do
		{
			delegate2 = @delegate;
			Class253.Delegate24 value = (Class253.Delegate24)Delegate.Combine(delegate2, delegate24_1);
			@delegate = Interlocked.CompareExchange<Class253.Delegate24>(ref Class253.delegate24_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x000336C8 File Offset: 0x000318C8
	public static void smethod_1(Class253.Delegate24 delegate24_1)
	{
		Class253.Delegate24 @delegate = Class253.delegate24_0;
		Class253.Delegate24 delegate2;
		do
		{
			delegate2 = @delegate;
			Class253.Delegate24 value = (Class253.Delegate24)Delegate.Remove(delegate2, delegate24_1);
			@delegate = Interlocked.CompareExchange<Class253.Delegate24>(ref Class253.delegate24_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x000336FC File Offset: 0x000318FC
	public static void smethod_2()
	{
		if (Class253.bool_3)
		{
			return;
		}
		Class253.bool_3 = true;
		try
		{
			Class253.computer_0.Open();
			Class253.computer_0.Accept(new Class253.Class255());
		}
		catch
		{
			Class253.bool_2 = true;
		}
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x0003374C File Offset: 0x0003194C
	public static void smethod_3()
	{
		Class253.bool_3 = false;
		Class253.computer_0.Close();
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x00033760 File Offset: 0x00031960
	public static void smethod_4()
	{
		Class253.float_0 = 0f;
		Class253.float_1 = 0f;
		Class253.float_2 = 0f;
		Class253.float_3 = 0f;
		Class253.float_4 = 0f;
		Class253.float_5 = 0f;
		Class253.float_6 = 0f;
		Class253.float_7 = 0f;
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x000337C0 File Offset: 0x000319C0
	public static void smethod_5()
	{
		Class253.Struct100 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class253.Struct100>(ref @struct);
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x000337F0 File Offset: 0x000319F0
	public static void smethod_6()
	{
		Class253.Struct103 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class253.Struct103>(ref @struct);
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x00033820 File Offset: 0x00031A20
	public static Task<bool> smethod_7()
	{
		Class253.Struct102 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class253.Struct102>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x0003385C File Offset: 0x00031A5C
	public static void smethod_8()
	{
		Class253.Struct99 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class253.Struct99>(ref @struct);
	}

	// Token: 0x040006C0 RID: 1728
	private static Class253.Delegate24 delegate24_0;

	// Token: 0x040006C1 RID: 1729
	public static bool bool_0 = false;

	// Token: 0x040006C2 RID: 1730
	private static bool bool_1 = false;

	// Token: 0x040006C3 RID: 1731
	private static bool bool_2 = false;

	// Token: 0x040006C4 RID: 1732
	public static float float_0 = 0f;

	// Token: 0x040006C5 RID: 1733
	public static float float_1 = 0f;

	// Token: 0x040006C6 RID: 1734
	public static float float_2 = 0f;

	// Token: 0x040006C7 RID: 1735
	public static float float_3 = 0f;

	// Token: 0x040006C8 RID: 1736
	public static float float_4 = 0f;

	// Token: 0x040006C9 RID: 1737
	public static float float_5 = 0f;

	// Token: 0x040006CA RID: 1738
	public static float float_6 = 0f;

	// Token: 0x040006CB RID: 1739
	public static float float_7 = 0f;

	// Token: 0x040006CC RID: 1740
	private static Computer computer_0 = new Computer
	{
		IsCpuEnabled = true,
		IsGpuEnabled = true
	};

	// Token: 0x040006CD RID: 1741
	private static bool bool_3 = false;

	// Token: 0x020001D3 RID: 467
	// (Invoke) Token: 0x06000B09 RID: 2825
	public delegate void Delegate24();

	// Token: 0x020001D4 RID: 468
	[StructLayout(LayoutKind.Auto)]
	private struct Struct99 : IAsyncStateMachine
	{
		// Token: 0x06000B0C RID: 2828 RVA: 0x0003388C File Offset: 0x00031A8C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(Class253.Class254.class254_0.method_5)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class253.Struct99>(ref awaiter, ref this);
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

		// Token: 0x06000B0D RID: 2829 RVA: 0x00033958 File Offset: 0x00031B58
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006CE RID: 1742
		public int int_0;

		// Token: 0x040006CF RID: 1743
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040006D0 RID: 1744
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001D5 RID: 469
	[StructLayout(LayoutKind.Auto)]
	private struct Struct100 : IAsyncStateMachine
	{
		// Token: 0x06000B0E RID: 2830 RVA: 0x00033968 File Offset: 0x00031B68
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class253.Class254.class254_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class253.Struct100>(ref awaiter, ref this);
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

		// Token: 0x06000B0F RID: 2831 RVA: 0x00033A34 File Offset: 0x00031C34
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006D1 RID: 1745
		public int int_0;

		// Token: 0x040006D2 RID: 1746
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040006D3 RID: 1747
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001D6 RID: 470
	[Serializable]
	private sealed class Class254
	{
		// Token: 0x06000B12 RID: 2834 RVA: 0x00033A58 File Offset: 0x00031C58
		internal void method_0()
		{
			Class253.bool_1 = true;
			Class253.smethod_8();
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00033A68 File Offset: 0x00031C68
		internal void method_1()
		{
			Class253.bool_1 = false;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00033A70 File Offset: 0x00031C70
		internal bool method_2()
		{
			bool result;
			try
			{
				if (!Class253.bool_3)
				{
					Class253.smethod_2();
				}
				result = (Class253.computer_0.Hardware[0] as GenericCpu).CpuId.Any(new Func<CpuId[], bool>(Class253.Class254.class254_0.method_3));
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00033AE0 File Offset: 0x00031CE0
		internal bool method_3(CpuId[] cpuId_0)
		{
			return cpuId_0.Any(new Func<CpuId, bool>(Class253.Class254.class254_0.method_4));
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00033B08 File Offset: 0x00031D08
		internal bool method_4(CpuId cpuId_0)
		{
			return cpuId_0.ThreadId == 1U;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00033B14 File Offset: 0x00031D14
		internal Task method_5()
		{
			Class253.Class254.Struct101 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class253.Class254.Struct101>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040006D4 RID: 1748
		public static readonly Class253.Class254 class254_0 = new Class253.Class254();

		// Token: 0x040006D5 RID: 1749
		public static Action action_0;

		// Token: 0x040006D6 RID: 1750
		public static Action action_1;

		// Token: 0x040006D7 RID: 1751
		public static Func<CpuId, bool> func_0;

		// Token: 0x040006D8 RID: 1752
		public static Func<CpuId[], bool> func_1;

		// Token: 0x040006D9 RID: 1753
		public static Func<bool> func_2;

		// Token: 0x040006DA RID: 1754
		public static Func<Task> func_3;

		// Token: 0x020001D7 RID: 471
		[StructLayout(LayoutKind.Auto)]
		private struct Struct101 : IAsyncStateMachine
		{
			// Token: 0x06000B18 RID: 2840 RVA: 0x00033B50 File Offset: 0x00031D50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (Class253.bool_2)
						{
							goto IL_36B;
						}
						if (!Class253.bool_3)
						{
							Class253.smethod_2();
							goto IL_340;
						}
						goto IL_340;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
					}
					IL_50:
					awaiter.GetResult();
					IL_340:
					if (Class253.bool_1)
					{
						Class253.smethod_4();
						IEnumerator<IHardware> enumerator = Class253.computer_0.Hardware.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								IHardware hardware = enumerator.Current;
								if (hardware.HardwareType == 2)
								{
									hardware.Update();
									foreach (ISensor sensor in hardware.Sensors)
									{
										if (sensor.SensorType == 4 && sensor.Name.Contains("CPU Package"))
										{
											Class253.float_0 = sensor.Value.GetValueOrDefault();
										}
										else if (sensor.SensorType == 5 && sensor.Name.Contains("CPU Total"))
										{
											Class253.float_1 = sensor.Value.GetValueOrDefault();
										}
										else if (sensor.SensorType == 2 && sensor.Name.Contains("CPU Package"))
										{
											Class253.float_2 = sensor.Value.GetValueOrDefault();
										}
										else if (sensor.SensorType == 3 && sensor.Name.Contains("CPU Core #1"))
										{
											Class253.float_3 = sensor.Value.GetValueOrDefault();
										}
									}
								}
								if (hardware.HardwareType == 5 || hardware.HardwareType == 4)
								{
									hardware.Update();
									foreach (ISensor sensor2 in hardware.Sensors)
									{
										if (sensor2.SensorType == 4 && sensor2.Name.Contains("GPU Core"))
										{
											Class253.float_4 = sensor2.Value.GetValueOrDefault();
										}
										else if (sensor2.SensorType == 5 && sensor2.Name.Contains("GPU Core"))
										{
											Class253.float_5 = sensor2.Value.GetValueOrDefault();
										}
										else if (sensor2.SensorType == 3 && sensor2.Name.Contains("GPU Core"))
										{
											Class253.float_6 = sensor2.Value.GetValueOrDefault();
										}
										else if (sensor2.SensorType == 3 && sensor2.Name.Contains("GPU Memory"))
										{
											Class253.float_7 = sensor2.Value.GetValueOrDefault();
										}
									}
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						Class253.Delegate24 delegate24_ = Class253.delegate24_0;
						if (delegate24_ != null)
						{
							delegate24_();
						}
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.int_0 = num3;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class253.Class254.Struct101>(ref awaiter, ref this);
							return;
						}
						goto IL_50;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_36B:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06000B19 RID: 2841 RVA: 0x00033F10 File Offset: 0x00032110
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040006DB RID: 1755
			public int int_0;

			// Token: 0x040006DC RID: 1756
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040006DD RID: 1757
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x020001D8 RID: 472
	[StructLayout(LayoutKind.Auto)]
	private struct Struct102 : IAsyncStateMachine
	{
		// Token: 0x06000B1A RID: 2842 RVA: 0x00033F20 File Offset: 0x00032120
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			bool result;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					awaiter = Task.Run<bool>(new Func<bool>(Class253.Class254.class254_0.method_2)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class253.Struct102>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<bool>);
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

		// Token: 0x06000B1B RID: 2843 RVA: 0x00033FEC File Offset: 0x000321EC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006DE RID: 1758
		public int int_0;

		// Token: 0x040006DF RID: 1759
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x040006E0 RID: 1760
		private TaskAwaiter<bool> taskAwaiter_0;
	}

	// Token: 0x020001D9 RID: 473
	[StructLayout(LayoutKind.Auto)]
	private struct Struct103 : IAsyncStateMachine
	{
		// Token: 0x06000B1C RID: 2844 RVA: 0x00033FFC File Offset: 0x000321FC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class253.Class254.class254_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class253.Struct103>(ref awaiter, ref this);
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

		// Token: 0x06000B1D RID: 2845 RVA: 0x000340C8 File Offset: 0x000322C8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006E1 RID: 1761
		public int int_0;

		// Token: 0x040006E2 RID: 1762
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040006E3 RID: 1763
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001DA RID: 474
	public sealed class Class255 : IVisitor
	{
		// Token: 0x06000B1F RID: 2847 RVA: 0x000340E0 File Offset: 0x000322E0
		public void VisitComputer(IComputer icomputer_0)
		{
			icomputer_0.Traverse(this);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x000340EC File Offset: 0x000322EC
		public void VisitHardware(IHardware ihardware_0)
		{
			ihardware_0.Update();
			IHardware[] subHardware = ihardware_0.SubHardware;
			for (int i = 0; i < subHardware.Length; i++)
			{
				subHardware[i].Accept(this);
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00034128 File Offset: 0x00032328
		public void VisitSensor(ISensor isensor_0)
		{
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0003412C File Offset: 0x0003232C
		public void VisitParameter(IParameter iparameter_0)
		{
		}
	}
}
