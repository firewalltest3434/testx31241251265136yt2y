using System;

// Token: 0x0200001C RID: 28
internal sealed class Class85 : Class84
{
	// Token: 0x060000AC RID: 172 RVA: 0x00003A10 File Offset: 0x00001C10
	public Class85(byte[] byte_0, long long_0) : base(byte_0, long_0)
	{
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00003A1C File Offset: 0x00001C1C
	public byte[] method_1(Class41 class41_0, Interface3 interface3_0)
	{
		byte[] array = new byte[4];
		Class85.smethod_6(class41_0, array, 0, new int?(array.Length));
		int num = Class84.smethod_4(base.method_0(array, false), 0);
		int num2 = Class84.smethod_1(num);
		int value = num2 - 4;
		byte[] array2 = new byte[num2];
		Class85.smethod_6(class41_0, array2, 4, new int?(value));
		Buffer.BlockCopy(array, 0, array2, 0, 4);
		Array src = base.method_0(array2, false);
		byte[] array3 = new byte[num];
		Buffer.BlockCopy(src, 4, array3, 0, num);
		return array3;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00003A94 File Offset: 0x00001C94
	public byte[] method_2(byte[] byte_0)
	{
		byte[] array = base.method_0(byte_0, false);
		int num = Class84.smethod_4(array, 0);
		byte[] array2 = new byte[num];
		Buffer.BlockCopy(array, 4, array2, 0, num);
		return array2;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00003AC4 File Offset: 0x00001CC4
	private static void smethod_6(Class41 class41_0, byte[] byte_0, int int_0, int? nullable_0)
	{
		int num = nullable_0 ?? (byte_0.Length - int_0);
		int num2;
		while ((num2 = class41_0.vmethod_11(byte_0, int_0, num)) > 0)
		{
			int_0 += num2;
			num -= num2;
		}
	}
}
