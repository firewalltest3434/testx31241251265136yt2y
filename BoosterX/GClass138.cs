using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200046F RID: 1135
public static class GClass138
{
	// Token: 0x0600193C RID: 6460 RVA: 0x00067C78 File Offset: 0x00065E78
	public static string smethod_0(this string string_0)
	{
		IEnumerable<char> values = string_0.ToCharArray().Reverse<char>();
		return string.Join<char>(string.Empty, values);
	}
}
