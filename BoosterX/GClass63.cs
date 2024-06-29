using System;
using System.Linq;
using System.Numerics;

// Token: 0x02000244 RID: 580
public sealed class GClass63
{
	// Token: 0x06000DB0 RID: 3504 RVA: 0x0003C4EC File Offset: 0x0003A6EC
	public static int[] smethod_0(string string_0)
	{
		BigInteger left = BigInteger.Zero;
		foreach (char value in string_0.smethod_0().ToCharArray())
		{
			left = left * 57 + "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefhijkmnopqrstuvwxyz23456789".IndexOf(value);
		}
		byte[] array2 = left.ToByteArray().Reverse<byte>().ToArray<byte>();
		int[] array3 = new int[array2.Length];
		for (int j = 0; j < array2.Length; j++)
		{
			array3[j] = (int)Convert.ToUInt16(array2[j]);
		}
		if (array3[0] != 0)
		{
			int[] array4 = array3;
			array3 = new int[array4.Length + 1];
			Array.Copy(array4, 0, array3, 1, array2.Length - 1);
			array3[0] = 0;
		}
		return array3;
	}
}
