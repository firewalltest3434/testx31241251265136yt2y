using System;

// Token: 0x02000680 RID: 1664
public class GException7 : Exception
{
	// Token: 0x060023A7 RID: 9127 RVA: 0x0008E2F4 File Offset: 0x0008C4F4
	public GException7(string string_0, GEnum0 genum0_1) : base(string_0 + " failed: " + genum0_1.ToString())
	{
		this.genum0_0 = genum0_1;
	}

	// Token: 0x04001850 RID: 6224
	public readonly GEnum0 genum0_0;
}
