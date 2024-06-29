using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Token: 0x02000282 RID: 642
internal sealed class Class324
{
	// Token: 0x06000ED7 RID: 3799 RVA: 0x0003FC2C File Offset: 0x0003DE2C
	public static List<Class323> smethod_0()
	{
		List<Class323> list = new List<Class323>();
		Class323 @class = new Class323();
		@class.Name = "WBBlueStacks";
		@class.method_1(new Task(new Action(Class324.Class325.class325_0.method_0)));
		@class.method_3(new Task<bool>(new Func<bool>(Class324.Class325.class325_0.method_1)));
		list.Add(@class);
		return list;
	}

	// Token: 0x02000283 RID: 643
	[Serializable]
	private sealed class Class325
	{
		// Token: 0x06000EDA RID: 3802 RVA: 0x0003FCBC File Offset: 0x0003DEBC
		internal void method_0()
		{
			Class185.smethod_22("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\Disabled\" /v \"electron.app.BlueStacks Services\" /f");
			Class185.smethod_22("reg add \"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\" /v \"electron.app.BlueStacks Services\" /t REG_SZ /d \"C:\\Users\\ios1ph\\AppData\\Local\\Programs\\bluestacks-services\\BlueStacksServices.exe --hidden\" /f");
			Class185.smethod_22("schtasks /change /TN \"BlueStacksHelper_nxt\" /Enable");
			Class185.smethod_22("schtasks /change /TN \"\\BlueStacksHelper_nxt\" /Enable");
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0003FCE8 File Offset: 0x0003DEE8
		internal bool method_1()
		{
			return Class168.smethod_2("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\Disabled", "electron.app.BlueStacks Services") || Class406.smethod_0("BlueStacksHelper_nxt");
		}

		// Token: 0x0400090F RID: 2319
		public static readonly Class324.Class325 class325_0 = new Class324.Class325();

		// Token: 0x04000910 RID: 2320
		public static Action action_0;

		// Token: 0x04000911 RID: 2321
		public static Func<bool> func_0;
	}
}
