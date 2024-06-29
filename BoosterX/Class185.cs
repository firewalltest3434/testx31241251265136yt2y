using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Runtime.InteropServices;
using ElevRightsX;

// Token: 0x0200015A RID: 346
internal sealed class Class185
{
	// Token: 0x06000901 RID: 2305 RVA: 0x00029BB8 File Offset: 0x00027DB8
	private Class185()
	{
	}

	// Token: 0x06000902 RID: 2306
	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenThread(Class185.Enum8 enum8_0, bool bool_0, uint uint_0);

	// Token: 0x06000903 RID: 2307
	[DllImport("kernel32.dll")]
	private static extern uint SuspendThread(IntPtr intptr_0);

	// Token: 0x06000904 RID: 2308
	[DllImport("kernel32.dll")]
	private static extern int ResumeThread(IntPtr intptr_0);

	// Token: 0x06000905 RID: 2309
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x06000906 RID: 2310
	[DllImport("user32.dll")]
	private static extern bool GetWindowRect(IntPtr intptr_0, out Class185.Struct66 struct66_0);

	// Token: 0x06000907 RID: 2311 RVA: 0x00029BC0 File Offset: 0x00027DC0
	public static Point smethod_0(IntPtr intptr_0)
	{
		Class185.Struct66 @struct;
		Class185.GetWindowRect(intptr_0, out @struct);
		int x = @struct.int_2 - @struct.int_0;
		int y = @struct.int_3 - @struct.int_1;
		return new Point(x, y);
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00029BF8 File Offset: 0x00027DF8
	public static bool smethod_1(Process process_0)
	{
		return Class185.smethod_16(process_0.ProcessName).StartsWith("C:\\Program Files\\WindowsApps\\");
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x00029C10 File Offset: 0x00027E10
	public static void smethod_2(Process process_0)
	{
		Class185.smethod_4(process_0.ProcessName);
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00029C20 File Offset: 0x00027E20
	public static void smethod_3(string string_0, string string_1)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = string_0,
				Arguments = string_1,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			}).WaitForExit();
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00029C74 File Offset: 0x00027E74
	public static void smethod_4(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = string_0,
				UseShellExecute = true,
				Arguments = "-silent",
				WindowStyle = ProcessWindowStyle.Minimized
			});
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00029CC4 File Offset: 0x00027EC4
	public static bool smethod_5(string string_0)
	{
		string text = string_0.Split(new char[]
		{
			'\\'
		})[3].Split(new char[]
		{
			'_'
		})[0];
		string text2 = Class185.smethod_13(text);
		if (text2 == null)
		{
			return false;
		}
		Class185.smethod_22(string.Concat(new string[]
		{
			"explorer.exe shell:appsFolder\\",
			text,
			"_",
			string_0.Split(new char[]
			{
				'\\'
			})[3].Split(new char[]
			{
				'_'
			})[4],
			"!",
			text2
		}));
		return true;
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00029D5C File Offset: 0x00027F5C
	public static double smethod_6(DirectoryInfo directoryInfo_0)
	{
		double result;
		try
		{
			result = Math.Round(Convert.ToDouble(Class185.smethod_10(directoryInfo_0)) / 1024.0 / 1024.0, 2);
		}
		catch
		{
			result = 0.0;
		}
		return result;
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x00029DB0 File Offset: 0x00027FB0
	public static double smethod_7(string string_0)
	{
		double result;
		try
		{
			result = Math.Round(Convert.ToDouble(Class185.smethod_9(string_0)) / 1024.0 / 1024.0, 2);
		}
		catch
		{
			result = 0.0;
		}
		return result;
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x00029E04 File Offset: 0x00028004
	public static double smethod_8(string string_0)
	{
		double result;
		try
		{
			result = Math.Round(Convert.ToDouble(Class185.smethod_9(string_0)) / 1024.0 / 1024.0 / 1024.0, 2);
		}
		catch
		{
			result = 0.0;
		}
		return result;
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x00029E64 File Offset: 0x00028064
	public static long smethod_9(string string_0)
	{
		long result;
		try
		{
			result = Class185.smethod_10(new DirectoryInfo(string_0));
		}
		catch
		{
			result = 0L;
		}
		return result;
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x00029EA0 File Offset: 0x000280A0
	public static long smethod_10(DirectoryInfo directoryInfo_0)
	{
		long result;
		try
		{
			long num = 0L;
			foreach (FileInfo fileInfo in directoryInfo_0.GetFiles())
			{
				num += fileInfo.Length;
			}
			foreach (DirectoryInfo directoryInfo in directoryInfo_0.GetDirectories())
			{
				num += Class185.smethod_9(directoryInfo.FullName);
			}
			result = num;
		}
		catch
		{
			result = 0L;
		}
		return result;
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00029F40 File Offset: 0x00028140
	public static string smethod_11(string string_0)
	{
		string result;
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript("(Get-AppxPackage -Name \"*" + string_0.Split(new char[]
			{
				'\\'
			}).Last<string>().Split(new char[]
			{
				'_'
			}).First<string>() + "*\" | Get-AppxPackageManifest).package.properties.logo");
			Collection<PSObject> collection = powerShell.Invoke();
			if (collection.Count == 0)
			{
				result = null;
			}
			else
			{
				result = string_0 + "\\" + collection[0].ToString();
			}
		}
		return result;
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00029FDC File Offset: 0x000281DC
	public static string smethod_12(string string_0)
	{
		string result;
		try
		{
			string text = Class185.smethod_11(string_0);
			if (!File.Exists(text))
			{
				string str = text.Split(new char[]
				{
					'\\'
				}).Last<string>().Split(new char[]
				{
					'.'
				}).First<string>();
				text = Directory.GetFiles(string_0, str + "*.png", SearchOption.AllDirectories).First<string>();
			}
			string text2 = Path.GetTempPath() + string_0.Split(new char[]
			{
				'\\'
			}).Last<string>().Split(new char[]
			{
				'_'
			}).First<string>() + text.Split(new char[]
			{
				'\\'
			}).Last<string>();
			if (!File.Exists(text2))
			{
				File.Copy(text, text2, true);
			}
			result = text2;
		}
		catch
		{
			result = string.Empty;
		}
		return result;
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x0002A0B8 File Offset: 0x000282B8
	public static string smethod_13(string string_0)
	{
		string result;
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript("(Get-AppxPackage -Name \"*" + string_0 + "*\" | Get-AppxPackageManifest).package.applications.application.id");
			Collection<PSObject> collection = powerShell.Invoke();
			if (collection.Count == 0)
			{
				result = "App";
			}
			else
			{
				result = collection[0].ToString();
			}
		}
		return result;
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x0002A124 File Offset: 0x00028324
	public static void smethod_14()
	{
		try
		{
			string path = "explorer.exe";
			Process.Start(new ProcessStartInfo
			{
				FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), path),
				UseShellExecute = true
			});
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x0002A174 File Offset: 0x00028374
	public static string smethod_15(Process process_0)
	{
		return Class185.smethod_16(process_0.ProcessName);
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x0002A184 File Offset: 0x00028384
	public static string smethod_16(string string_0)
	{
		string result;
		try
		{
			result = Process.GetProcessesByName(string_0)[0].MainModule.FileName;
		}
		catch
		{
			result = string.Empty;
		}
		return result;
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x0002A1C0 File Offset: 0x000283C0
	public static void smethod_17(Process process_0)
	{
		Class185.smethod_18(process_0.ProcessName);
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x0002A1D0 File Offset: 0x000283D0
	public static void smethod_18(string string_0)
	{
		try
		{
			if (!string_0.EndsWith(".exe"))
			{
				string_0 += ".exe";
			}
			Class185.smethod_22("taskkill /F /IM " + string_0);
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x0002A228 File Offset: 0x00028428
	public static bool smethod_19(string string_0)
	{
		bool result;
		try
		{
			result = (Process.GetProcessesByName(string_0).Length != 0);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x0002A258 File Offset: 0x00028458
	public static void smethod_20(string string_0)
	{
		try
		{
			foreach (object obj in Process.GetProcessesByName(string_0)[0].Threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				IntPtr intPtr = Class185.OpenThread((Class185.Enum8)2, false, (uint)processThread.Id);
				if (!(intPtr == IntPtr.Zero))
				{
					Class185.SuspendThread(intPtr);
					Class185.CloseHandle(intPtr);
				}
			}
		}
		catch (object obj2)
		{
		}
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x0002A2EC File Offset: 0x000284EC
	public static void smethod_21(string string_0)
	{
		try
		{
			foreach (object obj in Process.GetProcessesByName(string_0)[0].Threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				IntPtr intPtr = Class185.OpenThread((Class185.Enum8)2, false, (uint)processThread.Id);
				if (!(intPtr == IntPtr.Zero))
				{
					int num;
					do
					{
						num = Class185.ResumeThread(intPtr);
					}
					while (num > 0);
					Class185.CloseHandle(intPtr);
				}
			}
		}
		catch (object obj2)
		{
		}
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x0002A3A4 File Offset: 0x000285A4
	public static void smethod_22(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/c " + string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			}).WaitForExit();
		}
		catch
		{
			TrustedBypass.TrustedCrack("cmd.exe /c " + string_0, false);
		}
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x0002A418 File Offset: 0x00028618
	public static void smethod_23(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			}).WaitForExit();
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x0002A470 File Offset: 0x00028670
	public static void smethod_24(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/c " + string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			});
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x0002A4CC File Offset: 0x000286CC
	public static void smethod_25(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/c " + string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Normal
			});
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x0002A528 File Offset: 0x00028728
	public static void smethod_26(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "C:\\Windows\\system32\\cmd.exe",
				Arguments = "/c " + string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			}).WaitForExit();
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x0002A588 File Offset: 0x00028788
	public static string smethod_27(string string_0)
	{
		string result = string.Empty;
		try
		{
			Process process = new Process();
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + string_0;
			process.StartInfo.Verb = "runas";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			result = process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			process.WaitForExit();
		}
		catch (object obj)
		{
		}
		return result;
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x0002A634 File Offset: 0x00028834
	public static string smethod_28(string string_0)
	{
		string result = string.Empty;
		try
		{
			Process process = new Process();
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
			process.StartInfo.Arguments = "/c " + string_0;
			process.StartInfo.Verb = "runas";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			result = process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			process.WaitForExit();
		}
		catch (object obj)
		{
		}
		return result;
	}

	// Token: 0x0200015B RID: 347
	private struct Struct66
	{
		// Token: 0x04000528 RID: 1320
		public int int_0;

		// Token: 0x04000529 RID: 1321
		public int int_1;

		// Token: 0x0400052A RID: 1322
		public int int_2;

		// Token: 0x0400052B RID: 1323
		public int int_3;
	}

	// Token: 0x0200015C RID: 348
	public enum Enum8
	{

	}
}
