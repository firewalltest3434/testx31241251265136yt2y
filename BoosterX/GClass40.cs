using System;
using System.IO;
using System.Reflection;

// Token: 0x020001DD RID: 477
public sealed class GClass40
{
	// Token: 0x06000B39 RID: 2873 RVA: 0x00034250 File Offset: 0x00032450
	public static string smethod_0(string string_0)
	{
		string result;
		using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string_0))
		{
			if (manifestResourceStream != null)
			{
				StreamReader streamReader = new StreamReader(manifestResourceStream);
				try
				{
					return streamReader.ReadToEnd();
				}
				finally
				{
					((IDisposable)streamReader).Dispose();
				}
			}
			result = null;
		}
		return result;
	}
}
