using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

// Token: 0x02000851 RID: 2129
[XmlRoot("server-config")]
public sealed class dje_z5MY8KLGK7V764MMKJHNMS_ejd
{
	// Token: 0x170005FF RID: 1535
	// (get) Token: 0x06002B61 RID: 11105 RVA: 0x000BB41C File Offset: 0x000B961C
	// (set) Token: 0x06002B62 RID: 11106 RVA: 0x000BB424 File Offset: 0x000B9624
	[XmlAttribute("ignoreids")]
	public string IgnoreIds
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x040021A5 RID: 8613
	private string string_0;
}
