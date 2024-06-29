using System;
using System.Collections.Generic;
using ns0;

// Token: 0x020004B0 RID: 1200
public sealed class GClass133 : GClass132
{
	// Token: 0x06001A5A RID: 6746 RVA: 0x0006C7C0 File Offset: 0x0006A9C0
	public GClass133()
	{
		base.method_3("GetType");
	}

	// Token: 0x06001A5C RID: 6748 RVA: 0x0006C7EC File Offset: 0x0006A9EC
	protected override void vmethod_0(string string_3)
	{
		if (string_3 == GClass133.string_2)
		{
			this.method_6(dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.string_1, dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_2);
		}
	}

	// Token: 0x06001A5D RID: 6749 RVA: 0x0006C80C File Offset: 0x0006AA0C
	private void method_6(string string_3, List<string> list_0)
	{
		if (string_3 != string.Empty)
		{
			base.imethod_1(Class364.smethod_0("SetActivePowerScheme"), (GEnum93)1);
			Class185.smethod_22("powercfg -setactive " + string_3);
		}
		if (list_0.Count > 0)
		{
			list_0.ForEach(new Action<string>(this.method_7));
		}
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x0006C864 File Offset: 0x0006AA64
	private void method_7(string string_3)
	{
		base.imethod_1(Class364.smethod_0("DeletingPowerScheme"), (GEnum93)1);
		Class185.smethod_22("powercfg -delete " + string_3);
	}

	// Token: 0x04001285 RID: 4741
	public static readonly string string_1 = "IMPORTPOWER";

	// Token: 0x04001286 RID: 4742
	public static readonly string string_2 = "ADDORDELETEPOWERSCHEME";
}
