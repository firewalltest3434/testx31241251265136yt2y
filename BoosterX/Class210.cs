using System;
using Microsoft.Win32.TaskScheduler;

// Token: 0x0200018C RID: 396
internal sealed class Class210
{
	// Token: 0x06000A10 RID: 2576 RVA: 0x0002DFE4 File Offset: 0x0002C1E4
	private Class210()
	{
		if (this.taskService_0 == null)
		{
			this.taskService_0 = new TaskService();
		}
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x0002E000 File Offset: 0x0002C200
	public static Class210 smethod_0()
	{
		if (Class210.class210_0 == null)
		{
			Class210.class210_0 = new Class210();
		}
		return Class210.class210_0;
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x0002E018 File Offset: 0x0002C218
	public bool method_0(string string_0)
	{
		bool result;
		try
		{
			result = this.taskService_0.GetTask(string_0).Enabled;
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x0002E050 File Offset: 0x0002C250
	internal static void smethod_1(string string_0)
	{
		if (string_0.StartsWith("\\"))
		{
			Class185.smethod_22("schtasks /Change /TN \"" + string_0 + "\" /Enable");
			return;
		}
		Class185.smethod_22("schtasks /Change /TN \"\\" + string_0 + "\" /Enable");
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x0002E090 File Offset: 0x0002C290
	internal static void smethod_2(string string_0)
	{
		if (string_0.StartsWith("\\"))
		{
			Class185.smethod_22("schtasks /Change /TN \"" + string_0 + "\" /Disable");
			return;
		}
		Class185.smethod_22("schtasks /Change /TN \"\\" + string_0 + "\" /Disable");
	}

	// Token: 0x040005E0 RID: 1504
	private static Class210 class210_0;

	// Token: 0x040005E1 RID: 1505
	private TaskService taskService_0;
}
