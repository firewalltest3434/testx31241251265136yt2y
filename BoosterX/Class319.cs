using System;

// Token: 0x02000278 RID: 632
internal static class Class319
{
	// Token: 0x06000EBC RID: 3772 RVA: 0x0003F920 File Offset: 0x0003DB20
	public static string smethod_0(this ushort[] ushort_0)
	{
		Converter<ushort, char> converter;
		if ((converter = Class319.Class320.converter_0) == null)
		{
			converter = (Class319.Class320.converter_0 = new Converter<ushort, char>(Convert.ToChar));
		}
		return new string(Array.ConvertAll<ushort, char>(ushort_0, converter));
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x0003F948 File Offset: 0x0003DB48
	public static string smethod_1(this byte[] byte_0)
	{
		char[] array = new char[byte_0.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)byte_0[i];
		}
		return new string(array);
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x0003F980 File Offset: 0x0003DB80
	public static byte[] smethod_2(this byte[] byte_0, int int_0)
	{
		byte[] array = new byte[byte_0.Length];
		for (int i = 0; i < byte_0.Length; i++)
		{
			array[i] = (byte)((int)byte_0[i] ^ int_0);
		}
		return array;
	}

	// Token: 0x02000279 RID: 633
	private static class Class320
	{
		// Token: 0x04000901 RID: 2305
		public static Converter<ushort, char> converter_0;
	}
}
