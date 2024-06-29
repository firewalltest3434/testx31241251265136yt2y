using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Material.Icons;

// Token: 0x0200059D RID: 1437
public sealed class GClass172
{
	// Token: 0x06001EED RID: 7917 RVA: 0x000808A8 File Offset: 0x0007EAA8
	public static bool smethod_0(GClass97 gclass97_0)
	{
		return GClass139.smethod_0().get_Item(GClass188.smethod_16(gclass97_0.ServiceName)) != null;
	}

	// Token: 0x0200059E RID: 1438
	public enum GEnum95
	{

	}

	// Token: 0x0200059F RID: 1439
	public sealed class GClass173
	{
		// Token: 0x06001EEF RID: 7919 RVA: 0x000808CC File Offset: 0x0007EACC
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x000808D4 File Offset: 0x0007EAD4
		public void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x000808E0 File Offset: 0x0007EAE0
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x000808E8 File Offset: 0x0007EAE8
		public bool IsRed
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x000808F4 File Offset: 0x0007EAF4
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x000808FC File Offset: 0x0007EAFC
		public List<string> Services
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

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00080908 File Offset: 0x0007EB08
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x00080910 File Offset: 0x0007EB10
		public MaterialIconKind Icon
		{
			[CompilerGenerated]
			get
			{
				return this.materialIconKind_0;
			}
			[CompilerGenerated]
			set
			{
				this.materialIconKind_0 = value;
			}
		}

		// Token: 0x040015B1 RID: 5553
		private string string_0;

		// Token: 0x040015B2 RID: 5554
		private bool bool_0;

		// Token: 0x040015B3 RID: 5555
		private List<string> list_0;

		// Token: 0x040015B4 RID: 5556
		private MaterialIconKind materialIconKind_0;
	}

	// Token: 0x020005A0 RID: 1440
	public sealed class GClass174
	{
		// Token: 0x06001EF8 RID: 7928 RVA: 0x00080924 File Offset: 0x0007EB24
		public List<GClass172.GClass173> method_0()
		{
			return this.list_0;
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0008092C File Offset: 0x0007EB2C
		public void method_1(List<GClass172.GClass173> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x040015B5 RID: 5557
		private List<GClass172.GClass173> list_0;
	}
}
