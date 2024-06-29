using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using TsudaKageyu;

// Token: 0x020005AD RID: 1453
internal sealed class Class650
{
	// Token: 0x06001F69 RID: 8041 RVA: 0x000815E4 File Offset: 0x0007F7E4
	public static bool smethod_0(string string_0)
	{
		return !new Regex("[" + Regex.Escape(new string(Path.GetInvalidPathChars())) + "]").IsMatch(string_0) && !Regex.IsMatch(string_0, "([\\*\\?\\|\\\\/<>:]+)|([\\. ]+$)|^(CON|PRN|AUX|NUL|COM[1-9]|LPT[1-9])(\\.|$)", RegexOptions.IgnoreCase);
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x00081624 File Offset: 0x0007F824
	public static void smethod_1(string string_0, string string_1)
	{
		FileInfo fileInfo = new FileInfo(string_0);
		fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + string_1);
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x00081648 File Offset: 0x0007F848
	public static string smethod_2(string string_0, string string_1)
	{
		foreach (string text in Directory.GetFiles(string_0))
		{
			if (text.Split(new char[]
			{
				'\\'
			}).Last<string>().Contains(string_1))
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x0008169C File Offset: 0x0007F89C
	public static string smethod_3(string string_0, string string_1)
	{
		foreach (string text in Directory.GetDirectories(string_0))
		{
			if (text.Split(new char[]
			{
				'\\'
			}).Last<string>().Contains(string_1))
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x000816F0 File Offset: 0x0007F8F0
	public static void smethod_4(string string_0, string string_1, string string_2, string string_3, bool bool_0)
	{
		using (Stream manifestResourceStream = Assembly.GetCallingAssembly().GetManifestResourceStream(string_0 + "." + ((string_2 == string.Empty) ? string.Empty : (string_2 + ".")) + string_3))
		{
			BinaryReader binaryReader = new BinaryReader(manifestResourceStream);
			try
			{
				FileStream fileStream = new FileStream(string_1 + "\\" + string_3, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
				try
				{
					BinaryWriter binaryWriter = new BinaryWriter(fileStream);
					try
					{
						binaryWriter.Write(binaryReader.ReadBytes((int)manifestResourceStream.Length));
					}
					finally
					{
						((IDisposable)binaryWriter).Dispose();
					}
				}
				finally
				{
					((IDisposable)fileStream).Dispose();
				}
			}
			finally
			{
				((IDisposable)binaryReader).Dispose();
			}
		}
		if (bool_0)
		{
			string path = Path.Combine(string_1, string_3);
			File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
		}
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x000817D8 File Offset: 0x0007F9D8
	public static BitmapImage smethod_5(string string_0)
	{
		BitmapImage result;
		try
		{
			result = new BitmapImage(new Uri(string_0));
		}
		catch (Exception exception_)
		{
			GClass141.smethod_0(exception_);
			result = new BitmapImage();
		}
		return result;
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x00081814 File Offset: 0x0007FA14
	public static BitmapSource smethod_6(string string_0)
	{
		BitmapSource result;
		try
		{
			IconExtractor iconExtractor = new IconExtractor(string_0.smethod_2());
			string fileName = iconExtractor.FileName;
			Icon[] array = IconUtil.Split(iconExtractor.GetAllIcons()[0]);
			Icon icon = array[0];
			int num = array[0].Width * array[0].Height;
			foreach (Icon icon2 in array)
			{
				int num2 = icon2.Width * icon2.Height;
				if (num2 > num)
				{
					num = num2;
					icon = icon2;
				}
			}
			result = Imaging.CreateBitmapSourceFromHBitmap(IconUtil.ToBitmap(icon).GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
		}
		catch
		{
			result = Imaging.CreateBitmapSourceFromHIcon(Icon.ExtractAssociatedIcon(Process.GetCurrentProcess().MainModule.FileName).Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
		}
		return result;
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x000818FC File Offset: 0x0007FAFC
	public static BitmapSource smethod_7()
	{
		return Imaging.CreateBitmapSourceFromHIcon(Icon.ExtractAssociatedIcon(Process.GetCurrentProcess().MainModule.FileName).Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
	}

	// Token: 0x06001F71 RID: 8049
	[DllImport("shfolder.dll", CharSet = CharSet.Auto)]
	internal static extern int SHGetFolderPath(IntPtr intptr_0, int int_0, IntPtr intptr_1, int int_1, StringBuilder stringBuilder_0);

	// Token: 0x06001F72 RID: 8050 RVA: 0x00081928 File Offset: 0x0007FB28
	public static string smethod_8(string string_0)
	{
		Class650.Class651 @class = new Class650.Class651();
		((Class650.Interface17)@class).imethod_3(string_0, 0U);
		StringBuilder stringBuilder = new StringBuilder(260);
		Class650.Struct340 @struct = default(Class650.Struct340);
		((Class650.Interface19)@class).imethod_0(stringBuilder, stringBuilder.Capacity, out @struct, (Class650.Enum24)0);
		return stringBuilder.ToString();
	}

	// Token: 0x06001F73 RID: 8051 RVA: 0x00081974 File Offset: 0x0007FB74
	public static void smethod_9(bool bool_0, string string_0, string string_1, string string_2)
	{
		try
		{
			string[] array = File.ReadAllLines(string_2);
			int num = 0;
			if (bool_0)
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] == string_0)
					{
						break;
					}
					num++;
				}
			}
			else
			{
				string[] array2 = array;
				int i = 0;
				while (i < array2.Length && !array2[i].Contains(string_0))
				{
					num++;
					i++;
				}
			}
			array[num] = string_1;
			File.Delete(string_2);
			FileStream fileStream = new FileStream(string_2, FileMode.Create);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream);
				try
				{
					foreach (string value in array)
					{
						streamWriter.WriteLine(value);
					}
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06001F74 RID: 8052 RVA: 0x00081A78 File Offset: 0x0007FC78
	public static void smethod_10(int int_0, string string_0, string string_1)
	{
		try
		{
			string[] array = File.ReadAllLines(string_1);
			array[int_0] = string_0;
			File.Delete(string_1);
			FileStream fileStream = new FileStream(string_1, FileMode.Create);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream);
				try
				{
					foreach (string value in array)
					{
						streamWriter.WriteLine(value);
					}
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06001F75 RID: 8053 RVA: 0x00081B18 File Offset: 0x0007FD18
	public static void smethod_11(bool bool_0, string string_0, string string_1)
	{
		try
		{
			string[] array = File.ReadAllLines(string_1);
			int num = 0;
			if (bool_0)
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] == string_0)
					{
						break;
					}
					num++;
				}
			}
			else
			{
				string[] array2 = array;
				int i = 0;
				while (i < array2.Length && !array2[i].Contains(string_0))
				{
					num++;
					i++;
				}
			}
			File.Delete(string_1);
			FileStream fileStream = new FileStream(string_1, FileMode.Create);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream);
				try
				{
					for (int j = 0; j < array.Length; j++)
					{
						if (j != num)
						{
							streamWriter.WriteLine(array[j]);
						}
					}
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x00081C20 File Offset: 0x0007FE20
	public static long smethod_12(List<string> list_0, string string_0, bool bool_0)
	{
		long num = 0L;
		foreach (string text in list_0)
		{
			if (text.StartsWith("?:\\"))
			{
				foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
				{
					num += Class650.smethod_13(text.Replace("?:\\", driveInfo.Name), string_0, bool_0);
				}
			}
			else
			{
				num += Class650.smethod_13(text, string_0, bool_0);
			}
		}
		return num;
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x00081CDC File Offset: 0x0007FEDC
	public static long smethod_13(string string_0, string string_1, bool bool_0)
	{
		long num = 0L;
		string[] array = string_1.Split(new char[]
		{
			'|'
		});
		try
		{
			string text = string_0.Replace("%username%", Environment.UserName);
			if (Directory.Exists(text))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (bool_0)
					{
						num += Class185.smethod_9(text);
					}
					else
					{
						foreach (string fileName in Class650.smethod_14(text, string_1))
						{
							try
							{
								num += new FileInfo(fileName).Length;
							}
							catch (object obj)
							{
							}
						}
					}
				}
			}
		}
		catch (object obj2)
		{
		}
		return num;
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x00081DD4 File Offset: 0x0007FFD4
	private static List<string> smethod_14(string string_0, string string_1)
	{
		Class650.Class652 @class = new Class650.Class652();
		@class.list_0 = new List<string>();
		try
		{
			Directory.GetFiles(string_0, string_1).ToList<string>().ForEach(new Action<string>(@class.method_0));
		}
		catch (object obj)
		{
		}
		return @class.list_0;
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x00081E2C File Offset: 0x0008002C
	public static string smethod_15(string string_0)
	{
		string text = string.Empty;
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache");
			foreach (string text2 in registryKey.GetValueNames())
			{
				if (text2.Contains(string_0.Split(new char[]
				{
					'\\'
				}).Last<string>()) && text2.Contains("FriendlyAppName"))
				{
					text = registryKey.GetValue(text2).ToString();
				}
			}
		}
		catch (object obj)
		{
		}
		if (!(text == string.Empty))
		{
			if (text != null)
			{
				goto IL_B0;
			}
		}
		try
		{
			text = FileVersionInfo.GetVersionInfo(string_0).ProductName;
		}
		catch (object obj2)
		{
		}
		IL_B0:
		if (!(text == string.Empty))
		{
			if (text != null)
			{
				goto IL_150;
			}
		}
		try
		{
			foreach (string str in Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall").GetSubKeyNames())
			{
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + str);
				if (string_0.Contains(registryKey2.GetValue("InstallLocation").ToString().Replace('/', '\\')))
				{
					text = registryKey2.GetValue("DisplayName").ToString();
				}
			}
		}
		catch (object obj3)
		{
		}
		IL_150:
		if (text == string.Empty || text == null)
		{
			text = string_0.Split(new char[]
			{
				'\\'
			}).Last<string>();
		}
		return text;
	}

	// Token: 0x06001F7A RID: 8058 RVA: 0x00081FE0 File Offset: 0x000801E0
	public static void smethod_16(string string_0, string string_1, Encoding encoding_0)
	{
		Encoding encoding = encoding_0 ?? Encoding.Default;
		try
		{
			if (!File.Exists(string_0))
			{
				FileSecurity fileSecurity = new FileSecurity();
				fileSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, AccessControlType.Allow));
				using (File.Create(string_0, 1024, FileOptions.None, fileSecurity))
				{
				}
			}
			FileStream fileStream2 = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream2, encoding);
				try
				{
					streamWriter.WriteLine(string_1);
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream2).Dispose();
			}
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x000820A0 File Offset: 0x000802A0
	public static void smethod_17(string string_0, string string_1, Encoding encoding_0)
	{
		Encoding encoding = encoding_0 ?? Encoding.Default;
		try
		{
			if (!File.Exists(string_0))
			{
				FileSecurity fileSecurity = new FileSecurity();
				fileSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, AccessControlType.Allow));
				using (File.Create(string_0, 1024, FileOptions.None, fileSecurity))
				{
				}
			}
			FileStream fileStream2 = new FileStream(string_0, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream2, encoding);
				try
				{
					streamWriter.WriteLine(string_1);
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream2).Dispose();
			}
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x00082160 File Offset: 0x00080360
	public static void smethod_18(string string_0)
	{
		Class185.smethod_22("takeown /f \"" + string_0 + "\"");
		Class185.smethod_22("icacls \"" + string_0 + "\" /grant *S-1-5-32-544:F");
	}

	// Token: 0x020005AE RID: 1454
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("000214F9-0000-0000-C000-000000000046")]
	[ComImport]
	internal interface Interface16
	{
		// Token: 0x06001F7D RID: 8061
		void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out IntPtr intptr_0, int int_1);

		// Token: 0x06001F7E RID: 8062
		void imethod_1(out IntPtr intptr_0);

		// Token: 0x06001F7F RID: 8063
		void imethod_2(IntPtr intptr_0);

		// Token: 0x06001F80 RID: 8064
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06001F81 RID: 8065
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06001F82 RID: 8066
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06001F83 RID: 8067
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06001F84 RID: 8068
		void imethod_7([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06001F85 RID: 8069
		void imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06001F86 RID: 8070
		void imethod_9(out short short_0);

		// Token: 0x06001F87 RID: 8071
		void imethod_10(short short_0);

		// Token: 0x06001F88 RID: 8072
		void imethod_11(out int int_0);

		// Token: 0x06001F89 RID: 8073
		void imethod_12(int int_0);

		// Token: 0x06001F8A RID: 8074
		void imethod_13([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out int int_1);

		// Token: 0x06001F8B RID: 8075
		void imethod_14([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x06001F8C RID: 8076
		void imethod_15([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x06001F8D RID: 8077
		void imethod_16(IntPtr intptr_0, int int_0);

		// Token: 0x06001F8E RID: 8078
		void imethod_17([MarshalAs(UnmanagedType.LPWStr)] string string_0);
	}

	// Token: 0x020005AF RID: 1455
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000010b-0000-0000-C000-000000000046")]
	[ComImport]
	public interface Interface17 : Class650.Interface18
	{
		// Token: 0x06001F8F RID: 8079
		void imethod_1(out Guid guid_0);

		// Token: 0x06001F90 RID: 8080
		[PreserveSig]
		int imethod_2();

		// Token: 0x06001F91 RID: 8081
		[PreserveSig]
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, uint uint_0);

		// Token: 0x06001F92 RID: 8082
		[PreserveSig]
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

		// Token: 0x06001F93 RID: 8083
		[PreserveSig]
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

		// Token: 0x06001F94 RID: 8084
		[PreserveSig]
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);
	}

	// Token: 0x020005B0 RID: 1456
	private enum Enum24
	{

	}

	// Token: 0x020005B1 RID: 1457
	[Guid("00021401-0000-0000-C000-000000000046")]
	[ComImport]
	internal sealed class Class651
	{
		// Token: 0x06001F95 RID: 8085
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Class651();
	}

	// Token: 0x020005B2 RID: 1458
	private sealed class Class652
	{
		// Token: 0x06001F97 RID: 8087 RVA: 0x00082194 File Offset: 0x00080394
		internal void method_0(string string_0)
		{
			this.list_0.Add(string_0);
		}

		// Token: 0x040015F8 RID: 5624
		public List<string> list_0;
	}

	// Token: 0x020005B3 RID: 1459
	[Guid("0000010c-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface Interface18
	{
		// Token: 0x06001F98 RID: 8088
		[PreserveSig]
		void imethod_0(out Guid guid_0);
	}

	// Token: 0x020005B4 RID: 1460
	[Guid("000214F9-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	private interface Interface19
	{
		// Token: 0x06001F99 RID: 8089
		void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out Class650.Struct340 struct340_0, Class650.Enum24 enum24_0);

		// Token: 0x06001F9A RID: 8090
		void imethod_1(out IntPtr intptr_0);

		// Token: 0x06001F9B RID: 8091
		void imethod_2(IntPtr intptr_0);

		// Token: 0x06001F9C RID: 8092
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06001F9D RID: 8093
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06001F9E RID: 8094
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06001F9F RID: 8095
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06001FA0 RID: 8096
		void imethod_7([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06001FA1 RID: 8097
		void imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06001FA2 RID: 8098
		void imethod_9(out short short_0);

		// Token: 0x06001FA3 RID: 8099
		void imethod_10(short short_0);

		// Token: 0x06001FA4 RID: 8100
		void imethod_11(out int int_0);

		// Token: 0x06001FA5 RID: 8101
		void imethod_12(int int_0);

		// Token: 0x06001FA6 RID: 8102
		void imethod_13([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out int int_1);

		// Token: 0x06001FA7 RID: 8103
		void imethod_14([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x06001FA8 RID: 8104
		void imethod_15([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x06001FA9 RID: 8105
		void imethod_16(IntPtr intptr_0, Class650.Enum25 enum25_0);

		// Token: 0x06001FAA RID: 8106
		void imethod_17([MarshalAs(UnmanagedType.LPWStr)] string string_0);
	}

	// Token: 0x020005B5 RID: 1461
	private enum Enum25
	{

	}

	// Token: 0x020005B6 RID: 1462
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct Struct340
	{
		// Token: 0x040015FA RID: 5626
		public uint uint_0;

		// Token: 0x040015FB RID: 5627
		public long long_0;

		// Token: 0x040015FC RID: 5628
		public long long_1;

		// Token: 0x040015FD RID: 5629
		public long long_2;

		// Token: 0x040015FE RID: 5630
		public uint uint_1;

		// Token: 0x040015FF RID: 5631
		public uint uint_2;

		// Token: 0x04001600 RID: 5632
		public uint uint_3;

		// Token: 0x04001601 RID: 5633
		public uint uint_4;

		// Token: 0x04001602 RID: 5634
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		// Token: 0x04001603 RID: 5635
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string string_1;
	}
}
