using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

// Token: 0x0200015D RID: 349
internal sealed class Class186
{
	// Token: 0x06000926 RID: 2342 RVA: 0x0002AA74 File Offset: 0x00028C74
	internal static void smethod_0()
	{
		string path;
		try
		{
			path = Path.GetTempPath();
		}
		catch
		{
			path = "C:\\Windows\\Temp";
		}
		Class186.string_0 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		Class186.string_1 = Path.Combine(path, "BoosterX");
		Class186.string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		Class186.string_3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		Class186.string_4 = Path.Combine(Class186.string_2, "BoosterX");
		Class186.string_5 = Path.Combine(Class186.string_4, "Dlls");
		Class186.string_6 = Path.Combine(Class186.string_4, "BackUp", "Profiles");
		Class186.string_7 = Path.Combine(Class186.string_4, "Data");
		Class186.string_8 = Path.Combine(Class186.string_7, "InputLagProfiles");
		Class186.string_9 = Path.Combine(Class186.string_7, "MyTweaks");
		Class186.string_10 = Path.Combine(Class186.string_4, "StoreX");
		Class186.string_11 = Path.Combine(Class186.string_4, "pnp");
		Class186.string_12 = Path.Combine(Class186.string_11, "en-US");
		Class186.string_13 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\system32\\drivers\\etc\\hosts";
	}

	// Token: 0x0400052D RID: 1325
	public static string string_0 = string.Empty;

	// Token: 0x0400052E RID: 1326
	public static string string_1 = string.Empty;

	// Token: 0x0400052F RID: 1327
	public static string string_2 = string.Empty;

	// Token: 0x04000530 RID: 1328
	public static string string_3 = string.Empty;

	// Token: 0x04000531 RID: 1329
	public static string string_4 = string.Empty;

	// Token: 0x04000532 RID: 1330
	public static string string_5 = string.Empty;

	// Token: 0x04000533 RID: 1331
	public static string string_6 = string.Empty;

	// Token: 0x04000534 RID: 1332
	public static string string_7 = string.Empty;

	// Token: 0x04000535 RID: 1333
	public static string string_8 = string.Empty;

	// Token: 0x04000536 RID: 1334
	public static string string_9 = string.Empty;

	// Token: 0x04000537 RID: 1335
	public static string string_10 = string.Empty;

	// Token: 0x04000538 RID: 1336
	public static string string_11 = string.Empty;

	// Token: 0x04000539 RID: 1337
	public static string string_12 = string.Empty;

	// Token: 0x0400053A RID: 1338
	public static string string_13 = string.Empty;

	// Token: 0x0400053B RID: 1339
	public static List<RegistryKey> list_0 = new List<RegistryKey>
	{
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"),
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled"),
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"),
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled"),
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run"),
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled")
	};

	// Token: 0x0400053C RID: 1340
	public static List<string> list_1 = new List<string>
	{
		"C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup",
		"C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\AutorunsDisabled",
		Class186.string_2 + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup",
		Class186.string_2 + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\AutorunsDisabled"
	};

	// Token: 0x0400053D RID: 1341
	public static string[] string_14 = new string[]
	{
		"Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ComDlg32\\FirstFolder",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ComDlg32\\LastVisitedPidlMRU",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ComDlg32\\LastVisitedPidlMRULegacy",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ComDlg32\\OpenSavePidlMRU",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\UserAssist",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit\\Favorites",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Paint\\Recent File List",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Applets\\Wordpad\\Recent File List",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Map Network Drive MRU",
		"Software\\Microsoft\\Search Assistant\\ACMru",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RecentDocs",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ComDlg32\\OpenSaveMRU",
		"Software\\Microsoft\\MediaPlayer\\Player\\RecentFileList",
		"Software\\Microsoft\\MediaPlayer\\Player\\RecentURLList",
		"Software\\Microsoft\\Direct3D\\MostRecentApplication",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RunMRU",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\TypedPaths"
	};

	// Token: 0x0400053E RID: 1342
	public static string[] string_15 = new string[]
	{
		"SYSTEM\\CurrentControlSet\\Control\\Session Manager\\AppCompatCache",
		"SYSTEM\\ControlSet001\\Control\\Session Manager\\AppCompatCache",
		"SOFTWARE\\Microsoft\\RADAR\\HeapLeakDetection\\DiagnosedApplications",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit\\Favorites",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Applets\\Paint\\Recent File List",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Map Network Drive MRU",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RecentDocs",
		"SOFTWARE\\Microsoft\\MediaPlayer\\Player\\RecentFileList",
		"SOFTWARE\\Microsoft\\MediaPlayer\\Player\\RecentURLList",
		"SOFTWARE\\Microsoft\\Direct3D\\MostRecentApplication"
	};

	// Token: 0x0400053F RID: 1343
	public static string[] string_16 = new string[]
	{
		"C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Temp",
		"C:\\Users\\%username%\\AppData\\Local\\CrashDumps",
		"C:\\ProgramData\\Microsoft\\Windows Defender\\Definition Updates\\Backup",
		"C:\\Documents and Settings\\All Users\\Application Data\\Microsoft\\Windows Defender\\Scans",
		"C:\\Users\\%username%\\AppData\\Roaming\\Adobe\\Common\\Media Cache",
		"C:\\Users\\%username%\\AppData\\Roaming\\Adobe\\Common\\Media Cache Files",
		"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE",
		"C:\\Users\\%username%\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\MetaData",
		"C:\\Users\\%username%\\AppData\\Local\\Temp\\filmoralog",
		"C:\\Windows\\Logs",
		"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\CLR_v4.0\\UsageLogs",
		"C:\\ProgramData\\Microsoft\\Windows Defender\\Scans",
		"C:\\Windows\\Temp\\CreativeCloud\\ACC",
		"C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportQueue",
		"C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\Logs",
		"C:\\ProgramData\\Apple\\Installer Cache",
		"C:\\ProgramData\\Microsoft\\Windows\\WER\\Temp",
		"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\VisualStudio\\SettingsLogs",
		"C:\\Users\\%username%\\AppData\\Roaming\\Notepad++",
		"C:\\Users\\%username%\\Saved Games\\My Games\\Warface\\modelscache",
		"C:\\Windows\\LiveKernelReports"
	};

	// Token: 0x04000540 RID: 1344
	public static string[] string_17 = new string[]
	{
		"C:\\Windows\\Temp",
		"C:\\Windows\\SoftwareDistribution\\Download",
		Class186.string_3 + "\\Temp"
	};

	// Token: 0x04000541 RID: 1345
	public static string[] string_18 = new string[]
	{
		"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\CurrentVersion\\AppModel\\PackageRepository\\Packages"
	};
}
