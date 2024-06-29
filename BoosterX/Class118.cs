using System;

// Token: 0x020000AF RID: 175
internal sealed class Class118
{
	// Token: 0x06000567 RID: 1383 RVA: 0x0001D164 File Offset: 0x0001B364
	private Class118()
	{
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x0001D16C File Offset: 0x0001B36C
	internal static void smethod_0(uint uint_0, byte[] byte_0, int int_0)
	{
		byte_0[int_0] = (byte)uint_0;
		byte_0[++int_0] = (byte)(uint_0 >> 8);
		byte_0[++int_0] = (byte)(uint_0 >> 16);
		byte_0[++int_0] = (byte)(uint_0 >> 24);
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x0001D1A0 File Offset: 0x0001B3A0
	internal static uint smethod_1(byte[] byte_0, int int_0)
	{
		return (uint)((int)byte_0[int_0] | (int)byte_0[++int_0] << 8 | (int)byte_0[++int_0] << 16 | (int)byte_0[++int_0] << 24);
	}
}
