using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;

// Token: 0x0200040E RID: 1038
internal sealed class Class475
{
	// Token: 0x06001667 RID: 5735 RVA: 0x0005E230 File Offset: 0x0005C430
	public static void smethod_0()
	{
		Class185.smethod_22("reg add \"HKEY_CLASSES_ROOT\\BoosterX\" /v \"\" /t REG_SZ /d \"URL:BoosterX\" /f");
		Class185.smethod_22("reg add \"HKEY_CLASSES_ROOT\\BoosterX\" /v \"URL Protocol\" /t REG_SZ /d \"\" /f");
		string str = "\"" + Assembly.GetEntryAssembly().Location + "\" \"%%1\"";
		Class185.smethod_22("reg add \"HKEY_CLASSES_ROOT\\BoosterX\\shell\\open\\command\" /v \"URL Protocol\" /t REG_SZ /d \"" + str + "\" /f");
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x0005E280 File Offset: 0x0005C480
	public static void smethod_1()
	{
		Class185.smethod_22("reg delete \"HKEY_CLASSES_ROOT\\BoosterX\" /f");
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x0005E28C File Offset: 0x0005C48C
	public static string smethod_2()
	{
		if (Class475.string_1 != null)
		{
			return Class475.string_1;
		}
		string[] array = "2.0.10.0".Split(new char[]
		{
			'.'
		});
		Class475.string_1 = array[0] + "." + array[1];
		return Class475.string_1;
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x0005E2D8 File Offset: 0x0005C4D8
	public static string smethod_3()
	{
		string result;
		if ((result = Class475.string_0) == null)
		{
			result = (Class475.string_0 = Class475.fileVersionInfo_0.ProductVersion);
		}
		return result;
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x0005E2F4 File Offset: 0x0005C4F4
	public static bool smethod_4(string string_2)
	{
		bool result;
		try
		{
			result = (Version.Parse("2.0.10.0".Replace(',', '.')).CompareTo(Version.Parse(string_2)) < 0);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x0005E33C File Offset: 0x0005C53C
	public static void smethod_5()
	{
		Class475.Struct222 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class475.Struct222>(ref @struct);
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x0005E36C File Offset: 0x0005C56C
	public static string smethod_6()
	{
		string result;
		using (MD5 md = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(Process.GetCurrentProcess().MainModule.FileName))
			{
				result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", string.Empty).ToLowerInvariant();
			}
		}
		return result;
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x0005E3E8 File Offset: 0x0005C5E8
	public static string smethod_7()
	{
		return Path.GetDirectoryName(new Uri(Class475.assembly_0.EscapedCodeBase).LocalPath);
	}

	// Token: 0x0400101C RID: 4124
	private static Assembly assembly_0 = Assembly.GetExecutingAssembly();

	// Token: 0x0400101D RID: 4125
	private static FileVersionInfo fileVersionInfo_0 = FileVersionInfo.GetVersionInfo(Class475.assembly_0.Location);

	// Token: 0x0400101E RID: 4126
	private static string string_0;

	// Token: 0x0400101F RID: 4127
	private static string string_1;

	// Token: 0x04001020 RID: 4128
	public static IntPtr intptr_0 = Process.GetCurrentProcess().MainWindowHandle;

	// Token: 0x0200040F RID: 1039
	[StructLayout(LayoutKind.Auto)]
	private struct Struct222 : IAsyncStateMachine
	{
		// Token: 0x0600166F RID: 5743 RVA: 0x0005E404 File Offset: 0x0005C604
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class475.Class476.class476_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class475.Struct222>(ref awaiter, ref this);
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

		// Token: 0x06001670 RID: 5744 RVA: 0x0005E4D0 File Offset: 0x0005C6D0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001021 RID: 4129
		public int int_0;

		// Token: 0x04001022 RID: 4130
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001023 RID: 4131
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000410 RID: 1040
	[Serializable]
	private sealed class Class476
	{
		// Token: 0x06001673 RID: 5747 RVA: 0x0005E4F4 File Offset: 0x0005C6F4
		internal void method_0()
		{
		}

		// Token: 0x04001024 RID: 4132
		public static readonly Class475.Class476 class476_0 = new Class475.Class476();

		// Token: 0x04001025 RID: 4133
		public static Action action_0;
	}
}
