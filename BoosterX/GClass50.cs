using System;
using System.Text;
using NvidiaX.NVIDIA.Classes.Import;

// Token: 0x02000200 RID: 512
public sealed class GClass50
{
	// Token: 0x06000C58 RID: 3160 RVA: 0x00037AF0 File Offset: 0x00035CF0
	public static byte[] smethod_0(string string_0, Encoding encoding_0)
	{
		return GClass210.smethod_0<ImportExportProfiles>(GClass203.smethod_0(string_0), encoding_0);
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x00037B00 File Offset: 0x00035D00
	public static string smethod_1(byte[] byte_0, Encoding encoding_0)
	{
		return GClass203.smethod_1(GClass210.smethod_1<ImportExportProfiles>(byte_0, encoding_0));
	}
}
