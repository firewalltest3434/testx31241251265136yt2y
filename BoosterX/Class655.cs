using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading.Tasks;

// Token: 0x020005C0 RID: 1472
internal sealed class Class655
{
	// Token: 0x06002013 RID: 8211 RVA: 0x00083098 File Offset: 0x00081298
	public static Task smethod_0()
	{
		Class655.Struct344 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class655.Struct344>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002014 RID: 8212 RVA: 0x000830D4 File Offset: 0x000812D4
	public static void smethod_1()
	{
		try
		{
			using (WindowsIdentity current = WindowsIdentity.GetCurrent(TokenAccessLevels.Query | TokenAccessLevels.AdjustPrivileges))
			{
				Class655.Struct345 @struct;
				@struct.int_0 = 1;
				@struct.long_0 = 0L;
				@struct.int_1 = 2;
				Class655.LookupPrivilegeValue(null, "SeProfileSingleProcessPrivilege", ref @struct.long_0);
				Class655.AdjustTokenPrivileges(current.Token, false, ref @struct, 0, IntPtr.Zero, IntPtr.Zero);
				int int_ = 80;
				int structure = 4;
				Class655.NtSetSystemInformation(int_, ref structure, Marshal.SizeOf<int>(structure));
			}
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06002015 RID: 8213
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool LookupPrivilegeValue(string string_0, string string_1, ref long long_0);

	// Token: 0x06002016 RID: 8214
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool AdjustTokenPrivileges(IntPtr intptr_0, bool bool_0, ref Class655.Struct345 struct345_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

	// Token: 0x06002017 RID: 8215
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern uint NtSetSystemInformation(int int_0, ref int int_1, int int_2);

	// Token: 0x020005C1 RID: 1473
	[StructLayout(LayoutKind.Auto)]
	private struct Struct344 : IAsyncStateMachine
	{
		// Token: 0x06002018 RID: 8216 RVA: 0x00083178 File Offset: 0x00081378
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class655.Class656.class656_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class655.Struct344>(ref awaiter, ref this);
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

		// Token: 0x06002019 RID: 8217 RVA: 0x00083244 File Offset: 0x00081444
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001639 RID: 5689
		public int int_0;

		// Token: 0x0400163A RID: 5690
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400163B RID: 5691
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005C2 RID: 1474
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct345
	{
		// Token: 0x0400163C RID: 5692
		public int int_0;

		// Token: 0x0400163D RID: 5693
		public long long_0;

		// Token: 0x0400163E RID: 5694
		public int int_1;
	}

	// Token: 0x020005C3 RID: 1475
	[Serializable]
	private sealed class Class656
	{
		// Token: 0x0600201C RID: 8220 RVA: 0x00083268 File Offset: 0x00081468
		internal void method_0()
		{
			Class185.smethod_22("del /s /f /q %SYSTEMDRIVE%\\Windows\\Temp\\*.*");
			Class185.smethod_22("rd /s /q %SYSTEMDRIVE%\\Windows\\Temp");
			Class185.smethod_22("md C:\\Windows\\Temp");
			Class185.smethod_22("del /s /f /q %temp%\\*.*");
			Class185.smethod_22("rd /s /q %temp%");
			Class185.smethod_22("md %temp%");
			Class185.smethod_22("del /q /f /s %SYSTEMDRIVE%\\Temp\\*.*");
			Class185.smethod_22("del /q /f /s %SYSTEMDRIVE%\\Windows\\SoftwareDistribution\\Download\\*.*");
		}

		// Token: 0x0400163F RID: 5695
		public static readonly Class655.Class656 class656_0 = new Class655.Class656();

		// Token: 0x04001640 RID: 5696
		public static Action action_0;
	}
}
