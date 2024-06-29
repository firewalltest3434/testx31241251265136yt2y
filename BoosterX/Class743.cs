using System;
using System.Collections.Generic;

// Token: 0x02000400 RID: 1024
internal sealed class Class743 : GClass211
{
	// Token: 0x170002F6 RID: 758
	// (get) Token: 0x06001629 RID: 5673 RVA: 0x0005D86C File Offset: 0x0005BA6C
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

	// Token: 0x0600162A RID: 5674 RVA: 0x0005D8EC File Offset: 0x0005BAEC
	private GClass215 method_1()
	{
		return this.gclass215_0;
	}

	// Token: 0x0600162B RID: 5675 RVA: 0x0005D8F4 File Offset: 0x0005BAF4
	private void method_2(GClass215 gclass215_1)
	{
		this.gclass215_0 = gclass215_1;
	}

	// Token: 0x170002F7 RID: 759
	// (get) Token: 0x0600162C RID: 5676 RVA: 0x0005D900 File Offset: 0x0005BB00
	// (set) Token: 0x0600162D RID: 5677 RVA: 0x0005D930 File Offset: 0x0005BB30
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

	// Token: 0x04000F0D RID: 3853
	private List<GClass215> list_0;

	// Token: 0x04000F0E RID: 3854
	private GClass215 gclass215_0;
}
