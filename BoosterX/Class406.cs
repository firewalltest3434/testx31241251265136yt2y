using System;
using Microsoft.Win32.TaskScheduler;

// Token: 0x02000373 RID: 883
internal sealed class Class406
{
	// Token: 0x060013AB RID: 5035 RVA: 0x0005244C File Offset: 0x0005064C
	public static bool smethod_0(string string_0)
	{
		TaskService taskService = new TaskService();
		bool result;
		try
		{
			foreach (Task task in taskService.RootFolder.Tasks)
			{
				try
				{
					if (!(task.Name != string_0))
					{
						bool isActive = task.IsActive;
					}
				}
				catch (object obj)
				{
				}
			}
			result = true;
		}
		finally
		{
			taskService.Dispose();
		}
		return result;
	}
}
