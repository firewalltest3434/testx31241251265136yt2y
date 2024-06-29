using System;
using System.IO;
using System.Xml.Serialization;
using NvidiaX.NVIDIA.Classes.Import;

// Token: 0x0200066A RID: 1642
public sealed class GClass203
{
	// Token: 0x06002324 RID: 8996 RVA: 0x0008CEC0 File Offset: 0x0008B0C0
	public static ImportExportProfiles smethod_0(string string_0)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportExportProfiles));
		StringReader stringReader = new StringReader(string_0);
		ImportExportProfiles result;
		try
		{
			result = (ImportExportProfiles)xmlSerializer.Deserialize(stringReader);
		}
		finally
		{
			((IDisposable)stringReader).Dispose();
		}
		return result;
	}

	// Token: 0x06002325 RID: 8997 RVA: 0x0008CF0C File Offset: 0x0008B10C
	public static string smethod_1(ImportExportProfiles importExportProfiles_0)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportExportProfiles));
		StringWriter stringWriter = new StringWriter();
		string result;
		try
		{
			xmlSerializer.Serialize(stringWriter, importExportProfiles_0);
			result = stringWriter.ToString();
		}
		finally
		{
			((IDisposable)stringWriter).Dispose();
		}
		return result;
	}
}
