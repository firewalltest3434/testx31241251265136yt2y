using System;
using System.Reflection;
using System.Security;

// Token: 0x02000053 RID: 83
internal static class Class40
{
	// Token: 0x06000327 RID: 807 RVA: 0x000130E8 File Offset: 0x000112E8
	private static bool smethod_0()
	{
		bool result;
		try
		{
			if (Environment.Version.Major < 4)
			{
				result = false;
			}
			else
			{
				Assembly assembly = typeof(Class27).Assembly;
				Assembly assembly2 = typeof(SecurityCriticalAttribute).Assembly;
				bool flag = false;
				foreach (object obj in assembly.GetCustomAttributes(false))
				{
					if (obj is AllowPartiallyTrustedCallersAttribute)
					{
						flag = true;
					}
					else
					{
						Type type = obj.GetType();
						if (type.Assembly == assembly2 && "System.Security.SecurityRulesAttribute".Equals(type.FullName, StringComparison.Ordinal) && (byte)type.GetProperty("RuleSet").GetValue(obj, null) != 2)
						{
							return false;
						}
					}
				}
				result = flag;
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x000131D8 File Offset: 0x000113D8
	public static bool smethod_1()
	{
		return Class40.bool_0;
	}

	// Token: 0x0400009B RID: 155
	private static readonly bool bool_0 = false;
}
