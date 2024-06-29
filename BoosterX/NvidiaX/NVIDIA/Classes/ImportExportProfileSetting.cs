using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Newtonsoft.Json;
using NvidiaX.NVIDIA.Enums;

namespace NvidiaX.NVIDIA.Classes
{
	// Token: 0x02000847 RID: 2119
	[JsonObject]
	[Serializable]
	public class ImportExportProfileSetting
	{
		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x000BAAA4 File Offset: 0x000B8CA4
		// (set) Token: 0x06002B1F RID: 11039 RVA: 0x000BAAAC File Offset: 0x000B8CAC
		[JsonProperty("SNI")]
		[XmlElement("SettingNameInfo")]
		public string SettingNameInfo
		{
			[CompilerGenerated]
			get
			{
				return this.dje_zMCZ675UUSWQ4H2X4P2ZSKCHCQQPA_ejd;
			}
			[CompilerGenerated]
			set
			{
				this.dje_zMCZ675UUSWQ4H2X4P2ZSKCHCQQPA_ejd = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x000BAAB8 File Offset: 0x000B8CB8
		// (set) Token: 0x06002B21 RID: 11041 RVA: 0x000BAAC0 File Offset: 0x000B8CC0
		[JsonProperty("SID")]
		[XmlElement("SettingID")]
		public uint SettingId
		{
			[CompilerGenerated]
			get
			{
				return this.dje_zAFGT8UKF6SMMYERMSUQLF_ejd;
			}
			[CompilerGenerated]
			set
			{
				this.dje_zAFGT8UKF6SMMYERMSUQLF_ejd = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06002B22 RID: 11042 RVA: 0x000BAACC File Offset: 0x000B8CCC
		// (set) Token: 0x06002B23 RID: 11043 RVA: 0x000BAAD4 File Offset: 0x000B8CD4
		[JsonProperty("SV")]
		[XmlElement("SettingValue")]
		public string SettingValue
		{
			[CompilerGenerated]
			get
			{
				return this.dje_zV4UY8LMTHHXJPGC4RHC6R_ejd;
			}
			[CompilerGenerated]
			set
			{
				this.dje_zV4UY8LMTHHXJPGC4RHC6R_ejd = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x000BAAE0 File Offset: 0x000B8CE0
		// (set) Token: 0x06002B25 RID: 11045 RVA: 0x000BAAE8 File Offset: 0x000B8CE8
		[JsonProperty("T")]
		[XmlElement("ValueType")]
		public SettingValueType ValueType
		{
			[CompilerGenerated]
			get
			{
				return this.dje_z9932CHTPSNEMW6DX62CSZ_ejd;
			}
			[CompilerGenerated]
			set
			{
				this.dje_z9932CHTPSNEMW6DX62CSZ_ejd = value;
			}
		}

		// Token: 0x04002119 RID: 8473
		private string dje_zMCZ675UUSWQ4H2X4P2ZSKCHCQQPA_ejd = string.Empty;

		// Token: 0x0400211A RID: 8474
		private uint dje_zAFGT8UKF6SMMYERMSUQLF_ejd;

		// Token: 0x0400211B RID: 8475
		private string dje_zV4UY8LMTHHXJPGC4RHC6R_ejd = "0";

		// Token: 0x0400211C RID: 8476
		private SettingValueType dje_z9932CHTPSNEMW6DX62CSZ_ejd;
	}
}
