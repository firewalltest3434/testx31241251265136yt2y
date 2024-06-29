using System;
using System.Collections.Generic;

// Token: 0x02000552 RID: 1362
public sealed class GClass224 : GClass211
{
	// Token: 0x17000496 RID: 1174
	// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0007BFFC File Offset: 0x0007A1FC
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

	// Token: 0x06001D9F RID: 7583 RVA: 0x0007C07C File Offset: 0x0007A27C
	private GClass215 method_1()
	{
		return this.gclass215_0;
	}

	// Token: 0x06001DA0 RID: 7584 RVA: 0x0007C084 File Offset: 0x0007A284
	private void method_2(GClass215 gclass215_1)
	{
		this.gclass215_0 = gclass215_1;
	}

	// Token: 0x17000497 RID: 1175
	// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x0007C090 File Offset: 0x0007A290
	// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x0007C0C0 File Offset: 0x0007A2C0
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

	// Token: 0x040014D1 RID: 5329
	private List<GClass215> list_0;

	// Token: 0x040014D2 RID: 5330
	private GClass215 gclass215_0;
}
