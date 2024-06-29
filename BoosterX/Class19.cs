using System;

// Token: 0x02000014 RID: 20
internal sealed class Class19 : Class18
{
	// Token: 0x06000074 RID: 116 RVA: 0x000031EC File Offset: 0x000013EC
	public Class19(Interface4 interface4_1)
	{
		this.interface4_0 = interface4_1;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x000031FC File Offset: 0x000013FC
	public override void Dispose()
	{
		this.interface4_0.imethod_15();
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0000320C File Offset: 0x0000140C
	public override bool vmethod_0()
	{
		return true;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00003210 File Offset: 0x00001410
	public override int vmethod_1()
	{
		return this.interface4_0.imethod_2();
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00003220 File Offset: 0x00001420
	public override int vmethod_2(byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
	{
		return this.interface4_0.imethod_8(byte_0, int_0, int_1, byte_1, int_2);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00003234 File Offset: 0x00001434
	public override byte[] vmethod_3(byte[] byte_0, int int_0, int int_1)
	{
		return this.interface4_0.imethod_11(byte_0, int_0, int_1);
	}

	// Token: 0x04000027 RID: 39
	private readonly Interface4 interface4_0;
}
