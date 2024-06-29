using System;
using System.Collections.Generic;

// Token: 0x02000392 RID: 914
internal sealed class Class740 : GClass211
{
	// Token: 0x170002D4 RID: 724
	// (get) Token: 0x0600149E RID: 5278 RVA: 0x00054498 File Offset: 0x00052698
	public List<GClass215> Profiles
	{
		get
		{
			if (this.list_0 != null)
			{
				return this.list_0;
			}
			List<GClass215> list = new List<GClass215>();
			foreach (KeyValuePair<string, string> keyValuePair_ in GClass88.smethod_0().method_0())
			{
				list.Add(new GClass215(keyValuePair_));
			}
			this.list_0 = list;
			return this.list_0;
		}
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x00054518 File Offset: 0x00052718
	private GClass215 method_1()
	{
		return this.gclass215_0;
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x00054520 File Offset: 0x00052720
	private void method_2(GClass215 gclass215_1)
	{
		this.gclass215_0 = gclass215_1;
	}

	// Token: 0x170002D5 RID: 725
	// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0005452C File Offset: 0x0005272C
	// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0005455C File Offset: 0x0005275C
	public GClass215 SelectedProfile
	{
		get
		{
			if (this.method_1() == null)
			{
				this.method_2(this.Profiles[0]);
				base.method_0("SelectedProfile");
			}
			return this.method_1();
		}
		set
		{
			this.method_2(value);
			base.method_0("SelectedProfile");
		}
	}

	// Token: 0x04000C6E RID: 3182
	private List<GClass215> list_0;

	// Token: 0x04000C6F RID: 3183
	private GClass215 gclass215_0;
}
