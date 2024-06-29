using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000110 RID: 272
public static class GClass14
{
	// Token: 0x0600078F RID: 1935
	[DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern int WNetGetConnection([MarshalAs(UnmanagedType.LPTStr)] string string_0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, ref int int_0);

	// Token: 0x06000790 RID: 1936 RVA: 0x00024C70 File Offset: 0x00022E70
	public static string smethod_0(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		int capacity = stringBuilder.Capacity;
		if (string_0.Length > 2 && string_0[1] == ':')
		{
			char c = string_0[0];
			if (((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) && GClass14.WNetGetConnection(string_0.Substring(0, 2), stringBuilder, ref capacity) == 0)
			{
				new DirectoryInfo(string_0);
				string path = Path.GetFullPath(string_0).Substring(Path.GetPathRoot(string_0).Length);
				return Path.Combine(stringBuilder.ToString().TrimEnd(Array.Empty<char>()), path);
			}
		}
		return string_0;
	}
}
