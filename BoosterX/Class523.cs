using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using Microsoft.Win32;
using ns0;

// Token: 0x020003EB RID: 1003
internal sealed class Class523 : GClass131
{
	// Token: 0x060015EE RID: 5614 RVA: 0x0005C2A8 File Offset: 0x0005A4A8
	public Class523(Class713 class713_1)
	{
		this.class713_0 = class713_1;
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x0005C2B8 File Offset: 0x0005A4B8
	protected override void RunFunction(object argument)
	{
		using (PowerShell powerShell = PowerShell.Create())
		{
			Class523.Class460 @class = new Class523.Class460();
			@class.string_0 = this.class713_0.AppxFullName.Split(new char[]
			{
				'_'
			}).First<string>();
			base.imethod_1(Class364.smethod_0("Deleting") + " " + @class.string_0, (GEnum93)0);
			powerShell.AddScript("Get-AppxPackage -Name \"*" + @class.string_0 + "*\" | Remove-AppxPackage");
			powerShell.Invoke();
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_1)
			{
				Class523.Class459 class2 = new Class523.Class459();
				class2.registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\CurrentVersion\\AppModel\\PackageRepository\\Packages", true);
				class2.registryKey_0.GetSubKeyNames().ToList<string>().Where(new Func<string, bool>(@class.method_0)).ToList<string>().ForEach(new Action<string>(class2.method_0));
				class2.registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\UserData\\UninstallTimes", true);
				class2.registryKey_0.GetValueNames().ToList<string>().Where(new Func<string, bool>(@class.method_1)).ToList<string>().ForEach(new Action<string>(class2.method_1));
			}
		}
		if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_1)
		{
			Class523.Class458 class3 = new Class523.Class458();
			class3.string_1 = Class186.string_4 + "\\UninstallBat2.bat";
			class3.string_0 = this.class713_0.AppxLocation.Split(new char[]
			{
				'\\'
			}).Last<string>();
			Directory.GetDirectories(this.class713_0.AppxLocation.Replace(class3.string_0, string.Empty)).Where(new Func<string, bool>(class3.method_0)).ToList<string>().ForEach(new Action<string>(class3.method_1));
		}
	}

	// Token: 0x04000EC8 RID: 3784
	private Class713 class713_0;

	// Token: 0x020003EC RID: 1004
	private sealed class Class458
	{
		// Token: 0x060015F1 RID: 5617 RVA: 0x0005C4A8 File Offset: 0x0005A6A8
		internal bool method_0(string string_2)
		{
			return string_2.Contains(this.string_0.Split(new char[]
			{
				'_'
			}).First<string>());
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x0005C4CC File Offset: 0x0005A6CC
		internal void method_1(string string_2)
		{
			Class650.smethod_16(this.string_1, "rmdir /s /q \"" + string_2 + "\"", null);
		}

		// Token: 0x04000EC9 RID: 3785
		public string string_0;

		// Token: 0x04000ECA RID: 3786
		public string string_1;
	}

	// Token: 0x020003ED RID: 1005
	private sealed class Class459
	{
		// Token: 0x060015F4 RID: 5620 RVA: 0x0005C4F4 File Offset: 0x0005A6F4
		internal void method_0(string string_0)
		{
			this.registryKey_0.DeleteSubKeyTree(string_0);
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x0005C504 File Offset: 0x0005A704
		internal void method_1(string string_0)
		{
			this.registryKey_0.DeleteValue(string_0);
		}

		// Token: 0x04000ECB RID: 3787
		public RegistryKey registryKey_0;
	}

	// Token: 0x020003EE RID: 1006
	private sealed class Class460
	{
		// Token: 0x060015F7 RID: 5623 RVA: 0x0005C51C File Offset: 0x0005A71C
		internal bool method_0(string string_1)
		{
			return string_1.StartsWith(this.string_0);
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x0005C52C File Offset: 0x0005A72C
		internal bool method_1(string string_1)
		{
			return string_1.StartsWith(this.string_0);
		}

		// Token: 0x04000ECC RID: 3788
		public string string_0;
	}
}
