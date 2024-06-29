using System;

// Token: 0x0200005C RID: 92
internal static class Class73
{
	// Token: 0x0600036E RID: 878 RVA: 0x00013C7C File Offset: 0x00011E7C
	public static void smethod_0(ref byte byte_0)
	{
		byte_0 = (byte)Class73.int_0;
		Class73.int_1 = (int)byte_0;
	}

	// Token: 0x0600036F RID: 879 RVA: 0x00013C94 File Offset: 0x00011E94
	public static void smethod_1(ref int int_2)
	{
		int_2 = Class73.int_0;
		Class73.int_1 = int_2;
	}

	// Token: 0x06000370 RID: 880 RVA: 0x00013CA8 File Offset: 0x00011EA8
	public static void smethod_2(ref long long_0)
	{
		long_0 = (long)Class73.int_0;
		Class73.int_1 = (int)long_0;
	}

	// Token: 0x06000371 RID: 881 RVA: 0x00013CC0 File Offset: 0x00011EC0
	public static void smethod_3(ref char char_0)
	{
		char_0 = (char)Class73.int_0;
		Class73.int_1 = (int)char_0;
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00013CD8 File Offset: 0x00011ED8
	public static void smethod_4(Array array_0, int int_2, int int_3)
	{
		Array.Clear(array_0, int_2, int_3);
	}

	// Token: 0x06000373 RID: 883 RVA: 0x00013CE4 File Offset: 0x00011EE4
	public static void smethod_5(Array array_0)
	{
		Class73.smethod_4(array_0, 0, array_0.GetLength(0));
	}

	// Token: 0x040000AF RID: 175
	private static volatile int int_0;

	// Token: 0x040000B0 RID: 176
	private static volatile int int_1;
}
