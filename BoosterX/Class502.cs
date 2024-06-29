using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;

// Token: 0x02000449 RID: 1097
internal abstract class Class502
{
	// Token: 0x0600185F RID: 6239 RVA: 0x00065E30 File Offset: 0x00064030
	public static string smethod_0(string string_0, string string_1)
	{
		Class502.Class507 @class = new Class502.Class507();
		@class.string_0 = string_1;
		Class502.registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
		if (!Class502.registryKey_0.GetSubKeyNames().Any(new Func<string, bool>(@class.method_0)))
		{
			Class502.registryKey_0.CreateSubKey(@class.string_0);
		}
		Class502.registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + @class.string_0, true);
		string result;
		try
		{
			object value = Class502.registryKey_0.GetValue(string_0);
			if (value == null)
			{
				result = null;
			}
			else
			{
				result = value.ToString();
			}
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06001860 RID: 6240 RVA: 0x00065EE0 File Offset: 0x000640E0
	public static void smethod_1(string string_0, string string_1, string string_2)
	{
		Class502.Class508 @class = new Class502.Class508();
		@class.string_0 = string_2;
		Class502.registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
		if (!Class502.registryKey_0.GetSubKeyNames().Any(new Func<string, bool>(@class.method_0)))
		{
			Class502.registryKey_0.CreateSubKey(@class.string_0);
		}
		Class502.registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + @class.string_0, true);
		try
		{
			Class502.registryKey_0.SetValue(string_0, string_1, RegistryValueKind.String);
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06001861 RID: 6241 RVA: 0x00065F80 File Offset: 0x00064180
	public static List<string> smethod_2(string string_0, string string_1)
	{
		Class502.Class509 @class = new Class502.Class509();
		@class.string_0 = string_1;
		Class502.registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
		if (!Class502.registryKey_0.GetSubKeyNames().Any(new Func<string, bool>(@class.method_0)))
		{
			Class502.registryKey_0.CreateSubKey(@class.string_0);
		}
		Class502.registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + @class.string_0 + "\\" + string_0, true);
		List<string> result;
		try
		{
			result = Class502.registryKey_0.GetSubKeyNames().ToList<string>();
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0400111C RID: 4380
	private static RegistryKey registryKey_0;

	// Token: 0x0200044A RID: 1098
	private sealed class Class507
	{
		// Token: 0x06001863 RID: 6243 RVA: 0x00066034 File Offset: 0x00064234
		internal bool method_0(string string_1)
		{
			return string_1 == this.string_0;
		}

		// Token: 0x0400111D RID: 4381
		public string string_0;
	}

	// Token: 0x0200044B RID: 1099
	private sealed class Class508
	{
		// Token: 0x06001865 RID: 6245 RVA: 0x0006604C File Offset: 0x0006424C
		internal bool method_0(string string_1)
		{
			return string_1 == this.string_0;
		}

		// Token: 0x0400111E RID: 4382
		public string string_0;
	}

	// Token: 0x0200044C RID: 1100
	private sealed class Class509
	{
		// Token: 0x06001867 RID: 6247 RVA: 0x00066064 File Offset: 0x00064264
		internal bool method_0(string string_1)
		{
			return string_1 == this.string_0;
		}

		// Token: 0x0400111F RID: 4383
		public string string_0;
	}
}
