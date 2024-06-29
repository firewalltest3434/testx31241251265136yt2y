using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Token: 0x020000B7 RID: 183
internal sealed class Class124 : IDisposable, Interface6
{
	// Token: 0x0600058E RID: 1422 RVA: 0x0001D77C File Offset: 0x0001B97C
	public Class124(Class121 class121_1)
	{
		if (class121_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (class121_1.method_0())
		{
			throw new NotSupportedException();
		}
		this.class121_0 = class121_1;
		this.byte_0 = new byte[class121_1.imethod_1()];
		this.int_0 = this.method_0();
		this.int_1 = this.method_1();
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
	private int method_0()
	{
		return this.class121_0.imethod_0();
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x0001D7E8 File Offset: 0x0001B9E8
	private int method_1()
	{
		return this.class121_0.imethod_1() - 10;
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x0001D7F8 File Offset: 0x0001B9F8
	[CompilerGenerated]
	public int imethod_0()
	{
		return this.int_0;
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x0001D800 File Offset: 0x0001BA00
	[CompilerGenerated]
	public int imethod_1()
	{
		return this.int_1;
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0001D808 File Offset: 0x0001BA08
	public int imethod_2(byte[] byte_1, int int_2, int int_3, byte[] byte_2, int int_4, RandomNumberGenerator randomNumberGenerator_0)
	{
		return this.method_2(byte_1, int_2, int_3, byte_2, int_4, randomNumberGenerator_0);
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0001D81C File Offset: 0x0001BA1C
	private int method_2(byte[] byte_1, int int_2, int int_3, byte[] byte_2, int int_4, RandomNumberGenerator randomNumberGenerator_0)
	{
		int num = this.class121_0.imethod_1();
		byte[] array = this.byte_0;
		this.class121_0.imethod_2(byte_1, int_2, int_3, array, 0, randomNumberGenerator_0);
		byte b = array[0];
		bool flag = b != 2;
		int num2 = Class124.smethod_0(b, array, 0, num);
		num2++;
		if (flag | num2 < 10)
		{
			throw new InvalidOperationException("Invalid block.");
		}
		int num3 = num - num2;
		Buffer.BlockCopy(array, num2, byte_2, int_4, num3);
		return num3;
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0001D890 File Offset: 0x0001BA90
	private static int smethod_0(byte byte_1, byte[] byte_2, int int_2, int int_3)
	{
		for (int num = int_2 + 1; num != int_2 + int_3; num++)
		{
			if (byte_2[num] == 0)
			{
				return num;
			}
		}
		return -1;
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x0001D8B8 File Offset: 0x0001BAB8
	public void Dispose()
	{
		if (this.class121_0 != null)
		{
			this.class121_0.Dispose();
			this.class121_0 = null;
		}
	}

	// Token: 0x04000253 RID: 595
	private Class121 class121_0;

	// Token: 0x04000254 RID: 596
	private byte[] byte_0;

	// Token: 0x04000255 RID: 597
	private readonly int int_0;

	// Token: 0x04000256 RID: 598
	private readonly int int_1;
}
