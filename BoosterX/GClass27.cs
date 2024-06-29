using System;

// Token: 0x0200018E RID: 398
public sealed class GClass27 : GInterface14
{
	// Token: 0x06000A19 RID: 2585 RVA: 0x0002E1AC File Offset: 0x0002C3AC
	public GClass27(GInterface1 ginterface1_1, Action<string, GEnum93> action_1)
	{
		this.ginterface1_0 = ginterface1_1;
		this.action_0 = action_1;
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x0002E1C4 File Offset: 0x0002C3C4
	public void imethod_0<GClass129>(Action<string, GEnum93> action_1) where GClass129 : GClass129, new()
	{
		GClass129 gclass = this.ginterface1_0.imethod_4<GClass129>();
		if (action_1 != null)
		{
			gclass.imethod_2(action_1);
		}
		if (this.ginterface1_0.imethod_0<GClass129>())
		{
			gclass.method_4();
		}
		if (this.ginterface1_0.imethod_1<GClass129>())
		{
			gclass.method_5();
		}
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x0002E21C File Offset: 0x0002C41C
	public void imethod_1<GClass129>() where GClass129 : GClass129, new()
	{
		this.imethod_0<GClass129>(this.action_0);
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x0002E22C File Offset: 0x0002C42C
	public void imethod_2<GClass132>(string string_0, Action<string, GEnum93> action_1) where GClass132 : GClass132, new()
	{
		GClass132 gclass = this.ginterface1_0.imethod_4<GClass132>();
		gclass.imethod_2(action_1);
		if (this.ginterface1_0.imethod_2<GClass132>(string_0))
		{
			gclass.imethod_3(string_0);
		}
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x0002E26C File Offset: 0x0002C46C
	public void imethod_3<GClass132>(string string_0) where GClass132 : GClass132, new()
	{
		this.imethod_2<GClass132>(string_0, this.action_0);
	}

	// Token: 0x040005E3 RID: 1507
	private readonly GInterface1 ginterface1_0;

	// Token: 0x040005E4 RID: 1508
	private readonly Action<string, GEnum93> action_0;
}
