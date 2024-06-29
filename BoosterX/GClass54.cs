using System;

// Token: 0x0200022C RID: 556
public sealed class GClass54
{
	// Token: 0x06000D33 RID: 3379 RVA: 0x0003B7C8 File Offset: 0x000399C8
	public GClass54(bool bool_2 = true, bool bool_3 = false)
	{
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x0003B7E0 File Offset: 0x000399E0
	internal uint method_0()
	{
		uint num = 0U;
		if (this.bool_0)
		{
			num |= 1U;
		}
		if (this.bool_1)
		{
			num |= 2U;
		}
		return num;
	}

	// Token: 0x04000838 RID: 2104
	public readonly bool bool_0;

	// Token: 0x04000839 RID: 2105
	public readonly bool bool_1;
}
