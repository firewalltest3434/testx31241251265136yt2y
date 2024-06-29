using System;

// Token: 0x0200014D RID: 333
internal static class Class180
{
	// Token: 0x06000872 RID: 2162 RVA: 0x00028D2C File Offset: 0x00026F2C
	public static int smethod_0(int int_0, int int_1)
	{
		Random obj = Class180.random_0;
		int result;
		lock (obj)
		{
			result = Class180.random_0.Next(int_0, int_1);
		}
		return result;
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00028D74 File Offset: 0x00026F74
	public static bool smethod_1(this double? nullable_0)
	{
		if (nullable_0 != null)
		{
			double? num = nullable_0;
			if (!(num.GetValueOrDefault() == 0.0 & num != null))
			{
				double num2 = Convert.ToDouble(nullable_0);
				if (num2 != double.NaN && !double.IsInfinity(num2) && num2 != double.NegativeInfinity)
				{
					if (num2 != double.PositiveInfinity)
					{
						return false;
					}
				}
				return true;
			}
		}
		return true;
	}

	// Token: 0x040004BA RID: 1210
	private static readonly Random random_0 = new Random();
}
