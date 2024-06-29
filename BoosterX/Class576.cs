using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using ns0;

// Token: 0x020004D3 RID: 1235
internal sealed class Class576
{
	// Token: 0x06001B26 RID: 6950 RVA: 0x0006F864 File Offset: 0x0006DA64
	public static List<Class188> smethod_0()
	{
		List<Class188> list = new List<Class188>();
		ServiceController[] services = ServiceController.GetServices();
		ServiceController[] devices = ServiceController.GetDevices();
		foreach (ServiceController serviceController in services)
		{
			list.Add(new Class188
			{
				Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Service,
				Name = serviceController.ServiceName,
				State = Class576.smethod_1(serviceController)
			});
		}
		foreach (ServiceController serviceController2 in devices)
		{
			list.Add(new Class188
			{
				Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Service,
				Name = serviceController2.ServiceName,
				State = Class576.smethod_1(serviceController2)
			});
		}
		return list;
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x0006F914 File Offset: 0x0006DB14
	private static string smethod_1(ServiceController serviceController_0)
	{
		string result;
		try
		{
			switch (serviceController_0.StartType)
			{
			case ServiceStartMode.Boot:
				result = "0";
				break;
			case ServiceStartMode.System:
				result = "1";
				break;
			case ServiceStartMode.Automatic:
				result = "2";
				break;
			case ServiceStartMode.Manual:
				result = "3";
				break;
			case ServiceStartMode.Disabled:
				result = "4";
				break;
			default:
				result = "0";
				break;
			}
		}
		catch
		{
			result = "Unknown";
		}
		return result;
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x0006F994 File Offset: 0x0006DB94
	public static void smethod_2(string string_0)
	{
		Class576.Class579 @class = new Class576.Class579();
		@class.string_0 = string_0;
		if (Class576.list_0 == null)
		{
			Class576.list_0 = ServiceController.GetServices().ToList<ServiceController>();
			Class576.list_0.AddRange(ServiceController.GetDevices().ToList<ServiceController>());
		}
		GClass104.smethod_1("cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + @class.string_0 + "\" /v \"Start\" /t REG_DWORD /d \"4\" /f", false);
		GClass104.smethod_1("cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + @class.string_0 + "\" /v \"LaunchProtected\" /t REG_DWORD /d \"4\" /f", false);
		GClass104.smethod_1("cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + @class.string_0 + "\" /v \"ErrorControl\" /t REG_DWORD /d \"0\" /f", false);
		GClass104.smethod_1("cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + @class.string_0 + "\" /v \"DelayedAutoStart\" /t REG_DWORD /d \"0\" /f", false);
		@class.string_1 = GClass188.smethod_13(Class576.list_0);
		if (Class576.list_0.Any(new Func<ServiceController, bool>(@class.method_0)))
		{
			GClass104.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"Start\" /t REG_DWORD /d \"3\" /f"
			}), false);
			GClass104.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"LaunchProtected\" /f"
			}), false);
			GClass104.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"ErrorControl\" /t REG_DWORD /d \"1\" /f"
			}), false);
			GClass104.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"DelayedAutoStart\" /f"
			}), false);
		}
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x0006FB60 File Offset: 0x0006DD60
	public static bool smethod_3(string string_0)
	{
		Class576.Class578 @class = new Class576.Class578();
		@class.string_0 = string_0;
		return Class576.smethod_0().Any(new Func<Class188, bool>(@class.method_0));
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x0006FB90 File Offset: 0x0006DD90
	public static bool smethod_4(string string_0)
	{
		Class576.Class577 @class = new Class576.Class577();
		@class.string_0 = string_0;
		return Class576.smethod_0().First(new Func<Class188, bool>(@class.method_0)).State == "4";
	}

	// Token: 0x0400130F RID: 4879
	private static List<ServiceController> list_0;

	// Token: 0x020004D4 RID: 1236
	private sealed class Class577
	{
		// Token: 0x06001B2C RID: 6956 RVA: 0x0006FBD8 File Offset: 0x0006DDD8
		internal bool method_0(Class188 class188_0)
		{
			return class188_0.Name == this.string_0;
		}

		// Token: 0x04001310 RID: 4880
		public string string_0;
	}

	// Token: 0x020004D5 RID: 1237
	private sealed class Class578
	{
		// Token: 0x06001B2E RID: 6958 RVA: 0x0006FBF4 File Offset: 0x0006DDF4
		internal bool method_0(Class188 class188_0)
		{
			return class188_0.Name == this.string_0;
		}

		// Token: 0x04001311 RID: 4881
		public string string_0;
	}

	// Token: 0x020004D6 RID: 1238
	private sealed class Class579
	{
		// Token: 0x06001B30 RID: 6960 RVA: 0x0006FC10 File Offset: 0x0006DE10
		internal bool method_0(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName == this.string_0 + "_" + this.string_1;
		}

		// Token: 0x04001312 RID: 4882
		public string string_0;

		// Token: 0x04001313 RID: 4883
		public string string_1;
	}
}
