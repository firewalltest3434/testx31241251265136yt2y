using System;
using System.IO;
using System.Text.RegularExpressions;

// Token: 0x02000166 RID: 358
internal sealed class Class192
{
	// Token: 0x0600096A RID: 2410 RVA: 0x0002B640 File Offset: 0x00029840
	public static void smethod_0(string string_0)
	{
		string contents = Regex.Replace(File.ReadAllText(string_0), "\"([^\"]+)\"\\s+\\{\\s+\\}", "\"$1\"\n{\n\t\"\"\n", RegexOptions.Multiline);
		File.WriteAllText(string_0, contents);
	}
}
