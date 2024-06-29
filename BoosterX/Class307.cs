using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// Token: 0x0200025A RID: 602
internal static class Class307
{
	// Token: 0x040008A4 RID: 2212
	public static readonly JsonSerializerSettings jsonSerializerSettings_0 = new JsonSerializerSettings
	{
		MetadataPropertyHandling = 2,
		DateParseHandling = 0,
		Converters = 
		{
			new IsoDateTimeConverter
			{
				DateTimeStyles = DateTimeStyles.AssumeUniversal
			}
		}
	};
}
