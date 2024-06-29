using System;

// Token: 0x02000076 RID: 118
internal sealed class Class89
{
	// Token: 0x06000401 RID: 1025 RVA: 0x0001654C File Offset: 0x0001474C
	public Class89(bool bool_1, Class39 class39_2, Class39 class39_3)
	{
		if (class39_2 == null)
		{
			throw new ArgumentNullException("modulus");
		}
		if (class39_3 == null)
		{
			throw new ArgumentNullException("exponent");
		}
		this.bool_0 = bool_1;
		this.class39_0 = class39_2;
		this.class39_1 = class39_3;
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00016588 File Offset: 0x00014788
	public bool method_0()
	{
		return this.bool_0;
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00016590 File Offset: 0x00014790
	public Class39 method_1()
	{
		return this.class39_0;
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00016598 File Offset: 0x00014798
	public Class39 method_2()
	{
		return this.class39_1;
	}

	// Token: 0x040000E3 RID: 227
	private readonly bool bool_0;

	// Token: 0x040000E4 RID: 228
	private readonly Class39 class39_0;

	// Token: 0x040000E5 RID: 229
	private readonly Class39 class39_1;
}
