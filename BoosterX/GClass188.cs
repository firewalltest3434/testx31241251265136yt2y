using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using Microsoft.Win32;

// Token: 0x020005F7 RID: 1527
public static class GClass188
{
	// Token: 0x06002134 RID: 8500 RVA: 0x000867EC File Offset: 0x000849EC
	public static string smethod_0(string string_0)
	{
		GClass188.Class680 @class = new GClass188.Class680();
		@class.string_0 = string_0;
		string result = @class.string_0;
		try
		{
			result = ServiceController.GetServices().First(new Func<ServiceController, bool>(@class.method_0)).DisplayName;
		}
		catch (object obj)
		{
		}
		return result;
	}

	// Token: 0x06002135 RID: 8501 RVA: 0x00086840 File Offset: 0x00084A40
	public static ServiceStartMode smethod_1(string string_0)
	{
		ServiceStartMode result;
		try
		{
			result = GClass188.smethod_2(Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + string_0).GetValue("Start").ToString());
		}
		catch
		{
			result = ServiceStartMode.Disabled;
		}
		return result;
	}

	// Token: 0x06002136 RID: 8502 RVA: 0x00086890 File Offset: 0x00084A90
	public static ServiceStartMode smethod_2(string string_0)
	{
		ServiceStartMode result;
		if (!(string_0 == "0"))
		{
			if (!(string_0 == "1"))
			{
				if (!(string_0 == "2"))
				{
					if (!(string_0 == "3"))
					{
						if (!(string_0 == "4"))
						{
							result = ServiceStartMode.Disabled;
						}
						else
						{
							result = ServiceStartMode.Disabled;
						}
					}
					else
					{
						result = ServiceStartMode.Manual;
					}
				}
				else
				{
					result = ServiceStartMode.Automatic;
				}
			}
			else
			{
				result = ServiceStartMode.System;
			}
		}
		else
		{
			result = ServiceStartMode.Boot;
		}
		return result;
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x000868F8 File Offset: 0x00084AF8
	public static string smethod_3(ServiceStartMode? nullable_0)
	{
		if (nullable_0 != null)
		{
			switch (nullable_0.GetValueOrDefault())
			{
			case ServiceStartMode.Boot:
				return "0";
			case ServiceStartMode.System:
				return "1";
			case ServiceStartMode.Automatic:
				return "2";
			case ServiceStartMode.Manual:
				return "3";
			case ServiceStartMode.Disabled:
				return "4";
			}
		}
		return "4";
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x0008697C File Offset: 0x00084B7C
	public static string smethod_4(ServiceStartMode? nullable_0)
	{
		if (nullable_0 != null)
		{
			switch (nullable_0.GetValueOrDefault())
			{
			case ServiceStartMode.Boot:
				return Class364.smethod_0("Boot");
			case ServiceStartMode.System:
				return Class364.smethod_0("System");
			case ServiceStartMode.Automatic:
				return Class364.smethod_0("Automatic");
			case ServiceStartMode.Manual:
				return Class364.smethod_0("Manual");
			case ServiceStartMode.Disabled:
				return Class364.smethod_0("Disabled");
			}
		}
		return Class364.smethod_0("Unknown");
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x00086A20 File Offset: 0x00084C20
	public static string smethod_5(ServiceStartMode? nullable_0)
	{
		if (nullable_0 != null)
		{
			switch (nullable_0.GetValueOrDefault())
			{
			case ServiceStartMode.Boot:
				return "boot";
			case ServiceStartMode.System:
				return "system";
			case ServiceStartMode.Automatic:
				return "auto";
			case ServiceStartMode.Manual:
				return "demand";
			case ServiceStartMode.Disabled:
				return "disabled";
			}
		}
		return "unknown";
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x00086AA4 File Offset: 0x00084CA4
	public static string smethod_6(ServiceControllerStatus? nullable_0)
	{
		if (nullable_0 != null)
		{
			switch (nullable_0.GetValueOrDefault())
			{
			case ServiceControllerStatus.Stopped:
				return "stop";
			case ServiceControllerStatus.Running:
				return "start";
			case ServiceControllerStatus.ContinuePending:
				return "continue";
			case ServiceControllerStatus.Paused:
				return "pause";
			}
		}
		return "unknown";
	}

	// Token: 0x0600213B RID: 8507 RVA: 0x00086B0C File Offset: 0x00084D0C
	public static string smethod_7(ServiceControllerStatus serviceControllerStatus_0)
	{
		switch (serviceControllerStatus_0)
		{
		case ServiceControllerStatus.Stopped:
			return Class364.smethod_0("Stopped");
		case ServiceControllerStatus.StartPending:
			return Class364.smethod_0("StartPending");
		case ServiceControllerStatus.StopPending:
			return Class364.smethod_0("StopPending");
		case ServiceControllerStatus.Running:
			return Class364.smethod_0("Running");
		case ServiceControllerStatus.ContinuePending:
			return Class364.smethod_0("ContinuePending");
		case ServiceControllerStatus.PausePending:
			return Class364.smethod_0("PausePending");
		case ServiceControllerStatus.Paused:
			return Class364.smethod_0("Paused");
		default:
			return Class364.smethod_0("Unknown");
		}
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x00086B9C File Offset: 0x00084D9C
	public static List<string> smethod_8(string string_0)
	{
		string_0 = GClass188.smethod_16(string_0);
		GClass155 gclass = GClass139.smethod_0().get_Item(string_0);
		if (gclass == null)
		{
			return null;
		}
		return gclass.List_0;
	}

	// Token: 0x0600213D RID: 8509 RVA: 0x00086BC0 File Offset: 0x00084DC0
	public static bool smethod_9(string string_0)
	{
		string_0 = GClass188.smethod_16(string_0);
		GClass155 gclass = GClass139.smethod_0().get_Item(string_0);
		return gclass != null && gclass.IsBlocked;
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x00086BE4 File Offset: 0x00084DE4
	public static ServiceStartMode? smethod_10(string string_0)
	{
		string_0 = GClass188.smethod_16(string_0);
		GClass155 gclass = GClass139.smethod_0().get_Item(string_0);
		if (gclass == null)
		{
			return null;
		}
		return gclass.DefaultStartMode;
	}

	// Token: 0x0600213F RID: 8511 RVA: 0x00086C1C File Offset: 0x00084E1C
	public static bool smethod_11(ServiceController serviceController_0)
	{
		bool result;
		try
		{
			result = (serviceController_0.ServiceName != null);
		}
		catch (Exception exception_)
		{
			GClass141.smethod_0(exception_);
			result = false;
		}
		return result;
	}

	// Token: 0x06002140 RID: 8512 RVA: 0x00086C50 File Offset: 0x00084E50
	public static string smethod_12(ServiceController[] serviceController_0)
	{
		return GClass188.smethod_13(serviceController_0.ToList<ServiceController>());
	}

	// Token: 0x06002141 RID: 8513 RVA: 0x00086C60 File Offset: 0x00084E60
	public static string smethod_13(List<ServiceController> list_1)
	{
		return GClass188.smethod_15(list_1.First(new Func<ServiceController, bool>(GClass188.Class681.class681_0.method_0)));
	}

	// Token: 0x06002142 RID: 8514 RVA: 0x00086C8C File Offset: 0x00084E8C
	public static string smethod_14(ServiceController serviceController_0)
	{
		return serviceController_0.ServiceName.Split(new char[]
		{
			'_'
		}).First<string>();
	}

	// Token: 0x06002143 RID: 8515 RVA: 0x00086CAC File Offset: 0x00084EAC
	public static string smethod_15(ServiceController serviceController_0)
	{
		if (!serviceController_0.ServiceName.Contains('_'))
		{
			return null;
		}
		return serviceController_0.ServiceName.Split(new char[]
		{
			'_'
		}).Last<string>();
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x00086CDC File Offset: 0x00084EDC
	public static string smethod_16(string string_0)
	{
		if (string_0.Contains("_") && string_0.Contains(Class468.smethod_0().method_0()))
		{
			return string_0.Split(new char[]
			{
				'_'
			}).First<string>();
		}
		return string_0;
	}

	// Token: 0x06002145 RID: 8517 RVA: 0x00086D18 File Offset: 0x00084F18
	public static Dictionary<string, string> smethod_17()
	{
		string[] array = new string[]
		{
			"Win32_Service",
			"Win32_SystemDriver"
		};
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		try
		{
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(new SelectQuery(array2[i])).Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					object value = managementObject.Properties["Description"].Value;
					string text = (value != null) ? value.ToString() : null;
					object value2 = managementObject.Properties["Name"].Value;
					string text2 = (value2 != null) ? value2.ToString() : null;
					if (text2 != null && text != null)
					{
						dictionary.Add(text2, text);
					}
				}
			}
		}
		catch (object obj)
		{
		}
		return dictionary;
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x00086E34 File Offset: 0x00085034
	public static List<GClass92> smethod_18(string string_0)
	{
		string[] array = File.ReadAllLines(string_0);
		List<GClass92> list = new List<GClass92>();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].StartsWith("[HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services"))
			{
				GClass188.Class682 @class = new GClass188.Class682();
				@class.string_0 = array[i].Split(new char[]
				{
					'\\'
				}).Last<string>().Replace("]", string.Empty).ToLower();
				GClass188.list_0.ForEach(new Action<string>(@class.method_0));
				try
				{
					list.Add(new GClass92
					{
						Name = @class.string_0,
						Status = GClass188.smethod_2(array[i + 1].ToCharArray().Last<char>().ToString())
					});
				}
				catch (object obj)
				{
				}
			}
		}
		return new List<GClass92>();
	}

	// Token: 0x06002147 RID: 8519 RVA: 0x00086F18 File Offset: 0x00085118
	public static void smethod_19(GClass110 gclass110_0)
	{
		gclass110_0.DependOn.ForEach(new Action<GClass110>(GClass188.Class681.class681_0.method_1));
		GClass188.smethod_20(gclass110_0.Service.ServiceName, GClass188.smethod_3(gclass110_0.Service.DefaultStartMode));
	}

	// Token: 0x06002148 RID: 8520 RVA: 0x00086F70 File Offset: 0x00085170
	public static void smethod_20(string string_0, string string_1)
	{
		GClass104.smethod_1(string.Concat(new string[]
		{
			"Reg.exe add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\",
			string_0,
			"\" /v \"Start\" /t REG_DWORD /d \"",
			string_1,
			"\" /f"
		}), false);
		if (string_1 == "2")
		{
			GClass104.smethod_1("sc start " + string_0, false);
		}
	}

	// Token: 0x040016DC RID: 5852
	private static List<string> list_0 = new List<string>
	{
		"aarsvc",
		"bcastdvruserservice",
		"bluetoothuserservice",
		"captureservice",
		"cbdhsvc",
		"cdpusersvc",
		"consentuxusersvc",
		"credentialenrollmentmanagerusersvc",
		"deviceassociationbrokersvc",
		"devicepickerusersvc",
		"devicesflowusersvc",
		"messagingservice",
		"onesyncsvc",
		"pimindexmaintenancesvc",
		"printworkflowusersvc",
		"udkusersvc",
		"unistoresvc",
		"userdatasvc",
		"wpnuserservice"
	};

	// Token: 0x020005F8 RID: 1528
	private sealed class Class680
	{
		// Token: 0x0600214A RID: 8522 RVA: 0x00086FD4 File Offset: 0x000851D4
		internal bool method_0(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName.ToLower() == this.string_0.ToLower();
		}

		// Token: 0x040016DD RID: 5853
		public string string_0;
	}

	// Token: 0x020005F9 RID: 1529
	[Serializable]
	private sealed class Class681
	{
		// Token: 0x0600214D RID: 8525 RVA: 0x00087008 File Offset: 0x00085208
		internal bool method_0(ServiceController serviceController_0)
		{
			return GClass188.list_0.Contains(GClass188.smethod_14(serviceController_0).ToLower()) && GClass188.smethod_15(serviceController_0) != null;
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0008702C File Offset: 0x0008522C
		internal void method_1(GClass110 gclass110_0)
		{
			if (gclass110_0.Service.method_0() == ServiceStartMode.Disabled)
			{
				GClass188.smethod_20(gclass110_0.Service.ServiceName, GClass188.smethod_3(gclass110_0.Service.DefaultStartMode));
			}
		}

		// Token: 0x040016DE RID: 5854
		public static readonly GClass188.Class681 class681_0 = new GClass188.Class681();

		// Token: 0x040016DF RID: 5855
		public static Func<ServiceController, bool> func_0;

		// Token: 0x040016E0 RID: 5856
		public static Action<GClass110> action_0;
	}

	// Token: 0x020005FA RID: 1530
	private sealed class Class682
	{
		// Token: 0x06002150 RID: 8528 RVA: 0x00087064 File Offset: 0x00085264
		internal void method_0(string string_1)
		{
			if (this.string_0.StartsWith(string_1))
			{
				this.string_0 = string_1;
			}
		}

		// Token: 0x040016E1 RID: 5857
		public string string_0;
	}
}
