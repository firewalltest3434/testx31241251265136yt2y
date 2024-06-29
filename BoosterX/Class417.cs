using System;
using System.Diagnostics;

// Token: 0x02000390 RID: 912
internal sealed class Class417
{
	// Token: 0x06001498 RID: 5272 RVA: 0x000543BC File Offset: 0x000525BC
	public static void smethod_0(string string_0)
	{
		Class185.smethod_22("wevtutil sl " + string_0 + " /e:false /q");
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x000543D4 File Offset: 0x000525D4
	public static void smethod_1(string string_0)
	{
		Class185.smethod_22("wevtutil sl " + string_0 + " /e:true /q");
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x000543EC File Offset: 0x000525EC
	public static bool smethod_2(string string_0)
	{
		string text = string.Empty;
		Process process = new Process();
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.FileName = "wevtutil.exe";
		process.StartInfo.Arguments = "gl " + string_0;
		process.Start();
		text = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return text.ToLower().Contains("enabled: true");
	}
}
