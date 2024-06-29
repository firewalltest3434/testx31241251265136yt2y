using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace NvidiaX.NVIDIA.Classes.Import
{
	// Token: 0x02000845 RID: 2117
	[JsonObject]
	[XmlRoot("Profile")]
	[Serializable]
	public class ImportExportProfile
	{
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x000BAA20 File Offset: 0x000B8C20
		// (set) Token: 0x06002B15 RID: 11029 RVA: 0x000BAA28 File Offset: 0x000B8C28
		[XmlElement("ProfileName")]
		[JsonProperty("P")]
		public string ProfileName
		{
			[CompilerGenerated]
			get
			{
				return this.dje_zEL57ZPWMY7S8RSK89WAQR_ejd;
			}
			[CompilerGenerated]
			set
			{
				this.dje_zEL57ZPWMY7S8RSK89WAQR_ejd = value;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x000BAA34 File Offset: 0x000B8C34
		// (set) Token: 0x06002B17 RID: 11031 RVA: 0x000BAA3C File Offset: 0x000B8C3C
		[JsonProperty("EX")]
		[XmlArrayItem("string")]
		[XmlArray("Executeables")]
		public List<string> Executeables
		{
			[CompilerGenerated]
			get
			{
				return this.dje_zHKPLJCXTX6SPXAJPCTCEJNYH5GKDQXAPCM6F4GUS_ejd;
			}
			[CompilerGenerated]
			set
			{
				this.dje_zHKPLJCXTX6SPXAJPCTCEJNYH5GKDQXAPCM6F4GUS_ejd = value;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x000BAA48 File Offset: 0x000B8C48
		// (set) Token: 0x06002B19 RID: 11033 RVA: 0x000BAA50 File Offset: 0x000B8C50
		[XmlArray("Settings")]
		[XmlArrayItem("ProfileSetting")]
		[JsonProperty("S")]
		public List<ImportExportProfileSetting> Settings
		{
			[CompilerGenerated]
			get
			{
				return this.dje_zJ2J5MKN7GREKAAUFT9ME4_ejd;
			}
			[CompilerGenerated]
			set
			{
				this.dje_zJ2J5MKN7GREKAAUFT9ME4_ejd = value;
			}
		}

		// Token: 0x04002115 RID: 8469
		private string dje_zEL57ZPWMY7S8RSK89WAQR_ejd = string.Empty;

		// Token: 0x04002116 RID: 8470
		private List<string> dje_zHKPLJCXTX6SPXAJPCTCEJNYH5GKDQXAPCM6F4GUS_ejd = new List<string>();

		// Token: 0x04002117 RID: 8471
		private List<ImportExportProfileSetting> dje_zJ2J5MKN7GREKAAUFT9ME4_ejd = new List<ImportExportProfileSetting>();
	}
}
