using System;

// Token: 0x02000065 RID: 101
internal static class Class78
{
	// Token: 0x06000383 RID: 899 RVA: 0x00014398 File Offset: 0x00012598
	public static bool smethod_0(int[] int_0, int[] int_1)
	{
		if (int_0 == int_1)
		{
			return true;
		}
		if (int_0 == null || int_1 == null)
		{
			return false;
		}
		if (int_0.Length != int_1.Length)
		{
			return false;
		}
		for (int i = 0; i < int_0.Length; i++)
		{
			if (int_0[i] != int_1[i])
			{
				return false;
			}
		}
		return true;
	}
}
