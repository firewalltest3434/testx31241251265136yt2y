using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace NvidiaX.NVIDIA.Classes.Import
{
	// Token: 0x02000846 RID: 2118
	[XmlRoot("ArrayOfProfile")]
	[Serializable]
	public class ImportExportProfiles
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06002B1B RID: 11035 RVA: 0x000BAA70 File Offset: 0x000B8C70
		// (set) Token: 0x06002B1C RID: 11036 RVA: 0x000BAA78 File Offset: 0x000B8C78
		[XmlElement("Profile")]
		public List<ImportExportProfile> Profiles
		{
			[CompilerGenerated]
			get
			{
				return this.dje_z9PTKJWVC6J2Z35BYAVQCS_ejd;
			}
			[CompilerGenerated]
			set
			{
				this.dje_z9PTKJWVC6J2Z35BYAVQCS_ejd = value;
			}
		}

		// Token: 0x04002118 RID: 8472
		private List<ImportExportProfile> dje_z9PTKJWVC6J2Z35BYAVQCS_ejd = new List<ImportExportProfile>();
	}
}
