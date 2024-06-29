using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace BoosterX.Classes.Tweaks.CleanerModel
{
	// Token: 0x02000837 RID: 2103
	public class JsonCleanDto
	{
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x000B9B60 File Offset: 0x000B7D60
		// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x000B9B68 File Offset: 0x000B7D68
		[JsonProperty("Name")]
		public string Name
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

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x000B9B74 File Offset: 0x000B7D74
		// (set) Token: 0x06002AC9 RID: 10953 RVA: 0x000B9B7C File Offset: 0x000B7D7C
		[JsonProperty("Description")]
		public string Description
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x000B9B88 File Offset: 0x000B7D88
		// (set) Token: 0x06002ACB RID: 10955 RVA: 0x000B9B90 File Offset: 0x000B7D90
		[JsonProperty("IconPath")]
		public string IconPath
		{
			[CompilerGenerated]
			get
			{
				return this.string_2;
			}
			[CompilerGenerated]
			set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06002ACC RID: 10956 RVA: 0x000B9B9C File Offset: 0x000B7D9C
		// (set) Token: 0x06002ACD RID: 10957 RVA: 0x000B9BA4 File Offset: 0x000B7DA4
		[JsonProperty("IsPRO")]
		public bool IsPRO
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x000B9BB0 File Offset: 0x000B7DB0
		// (set) Token: 0x06002ACF RID: 10959 RVA: 0x000B9BB8 File Offset: 0x000B7DB8
		[JsonProperty("Paths")]
		public List<string> Paths
		{
			[CompilerGenerated]
			get
			{
				return this.list_0;
			}
			[CompilerGenerated]
			set
			{
				this.list_0 = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x000B9BC4 File Offset: 0x000B7DC4
		// (set) Token: 0x06002AD1 RID: 10961 RVA: 0x000B9BCC File Offset: 0x000B7DCC
		[JsonProperty("IncludeInsideFolders")]
		public bool IncludeInsideFolders
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				this.bool_1 = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x000B9BD8 File Offset: 0x000B7DD8
		// (set) Token: 0x06002AD3 RID: 10963 RVA: 0x000B9BE0 File Offset: 0x000B7DE0
		[JsonProperty("SearchPattern")]
		public string SearchPattern
		{
			[CompilerGenerated]
			get
			{
				return this.string_3;
			}
			[CompilerGenerated]
			set
			{
				this.string_3 = value;
			}
		}

		// Token: 0x040020F4 RID: 8436
		private string string_0;

		// Token: 0x040020F5 RID: 8437
		private string string_1;

		// Token: 0x040020F6 RID: 8438
		private string string_2;

		// Token: 0x040020F7 RID: 8439
		private bool bool_0;

		// Token: 0x040020F8 RID: 8440
		private List<string> list_0;

		// Token: 0x040020F9 RID: 8441
		private bool bool_1;

		// Token: 0x040020FA RID: 8442
		private string string_3;
	}
}
