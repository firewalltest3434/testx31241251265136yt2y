using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using Windows.Devices.Enumeration;

// Token: 0x02000535 RID: 1333
public sealed class GClass160
{
	// Token: 0x06001D1C RID: 7452
	[DllImport("setupapi", CharSet = CharSet.Unicode)]
	private static extern int SetupDiGetClassDescription([MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, StringBuilder stringBuilder_0, int int_0, ref int int_1);

	// Token: 0x06001D1D RID: 7453
	[DllImport("setupapi")]
	private static extern bool SetupDiLoadClassIcon([MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, out IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x06001D1E RID: 7454
	[DllImport("user32")]
	internal static extern bool DestroyIcon(IntPtr intptr_0);

	// Token: 0x06001D1F RID: 7455
	[DllImport("shlwapi", CharSet = CharSet.Unicode)]
	private static extern int PathParseIconLocation(string string_0);

	// Token: 0x06001D20 RID: 7456
	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern IntPtr LoadImage(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1, int int_2, int int_3);

	// Token: 0x06001D21 RID: 7457
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr LoadLibraryEx(string string_0, IntPtr intptr_0, int int_0);

	// Token: 0x06001D22 RID: 7458
	[DllImport("kernel32", SetLastError = true)]
	private static extern bool FreeLibrary(IntPtr intptr_0);

	// Token: 0x06001D23 RID: 7459 RVA: 0x00079F48 File Offset: 0x00078148
	public static DeviceInformation smethod_0()
	{
		return GClass160.deviceInformation_0;
	}

	// Token: 0x06001D24 RID: 7460 RVA: 0x00079F50 File Offset: 0x00078150
	public static BitmapSource smethod_1(string string_0)
	{
		GClass160.Class607 @class = new GClass160.Class607();
		Guid.TryParse(string_0, out @class.guid_0);
		GClass160.lazy_0 = new Lazy<BitmapSource>(new Func<BitmapSource>(@class.method_0), false);
		return GClass160.lazy_0.Value;
	}

	// Token: 0x06001D25 RID: 7461 RVA: 0x00079F94 File Offset: 0x00078194
	internal static int smethod_2(string string_0, out string string_1)
	{
		string_1 = new string(string_0.ToCharArray());
		int result = GClass160.PathParseIconLocation(string_1);
		int num = string_1.LastIndexOf('\0');
		if (num >= 0)
		{
			string_1 = string_1.Substring(0, num);
		}
		return result;
	}

	// Token: 0x06001D26 RID: 7462 RVA: 0x00079FD4 File Offset: 0x000781D4
	internal static BitmapSource smethod_3(string string_0, int int_0, int int_1)
	{
		if (Path.GetExtension(string_0).ToLower() == ".ico")
		{
			try
			{
				using (Icon icon = Icon.ExtractAssociatedIcon(string_0))
				{
					return Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
				}
			}
			catch
			{
				return null;
			}
		}
		IntPtr intPtr = GClass160.LoadLibraryEx(GClass160.smethod_4(string_0), IntPtr.Zero, 34);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		IntPtr intPtr2 = IntPtr.Zero;
		try
		{
			intPtr2 = GClass160.LoadImage(intPtr, (IntPtr)(-int_0), 1, int_1, int_1, 0);
			if (intPtr2 == IntPtr.Zero)
			{
				return null;
			}
			return Imaging.CreateBitmapSourceFromHIcon(intPtr2, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
		}
		catch (object obj)
		{
		}
		if (intPtr2 != IntPtr.Zero)
		{
			GClass160.DestroyIcon(intPtr2);
		}
		GClass160.FreeLibrary(intPtr);
		return null;
	}

	// Token: 0x06001D27 RID: 7463 RVA: 0x0007A0D0 File Offset: 0x000782D0
	internal static string smethod_4(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return string_0;
		}
		if (string_0.Contains("%"))
		{
			return Environment.ExpandEnvironmentVariables(string_0);
		}
		return string_0;
	}

	// Token: 0x04001482 RID: 5250
	private static Lazy<BitmapSource> lazy_0;

	// Token: 0x04001483 RID: 5251
	private static readonly DeviceInformation deviceInformation_0;

	// Token: 0x02000536 RID: 1334
	private sealed class Class607
	{
		// Token: 0x06001D29 RID: 7465 RVA: 0x0007A0FC File Offset: 0x000782FC
		internal BitmapSource method_0()
		{
			IntPtr intPtr;
			if (!GClass160.SetupDiLoadClassIcon(this.guid_0, out intPtr, IntPtr.Zero))
			{
				return null;
			}
			BitmapSource result;
			using (Icon icon = Icon.FromHandle(intPtr))
			{
				BitmapSource bitmapSource = Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
				GClass160.DestroyIcon(intPtr);
				result = bitmapSource;
			}
			return result;
		}

		// Token: 0x04001484 RID: 5252
		public Guid guid_0;
	}
}
