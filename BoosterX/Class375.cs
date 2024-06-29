using System;
using System.Diagnostics;

// Token: 0x020002FE RID: 766
internal sealed class Class375
{
	// Token: 0x0600114F RID: 4431 RVA: 0x000491D0 File Offset: 0x000473D0
	public static string smethod_0(string string_0)
	{
		string result;
		try
		{
			Process process = new Process();
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.FileName = "bcdedit.exe";
			process.StartInfo.Arguments = "/enum {current} /v";
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			foreach (string text2 in text.Split(new string[]
			{
				Environment.NewLine
			}, StringSplitOptions.None))
			{
				if (text2.Trim().StartsWith(string_0, StringComparison.OrdinalIgnoreCase))
				{
					string[] array2 = text2.Split(new char[]
					{
						' '
					}, StringSplitOptions.RemoveEmptyEntries);
					if (array2.Length > 1)
					{
						return array2[1].Trim();
					}
				}
			}
			result = "Null";
		}
		catch
		{
			result = "Null";
		}
		return result;
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x000492E8 File Offset: 0x000474E8
	public static void smethod_1(string string_0, string string_1)
	{
		try
		{
			string arguments = (string_1 == "Null") ? ("/delete {current} " + string_0) : ("/set {current} " + string_0 + " " + string_1);
			Process process = new Process();
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "bcdedit.exe";
			process.StartInfo.Arguments = arguments;
			process.Start();
			process.WaitForExit();
		}
		catch (object obj)
		{
		}
	}
}
