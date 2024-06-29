using System;
using System.Security.Cryptography;

// Token: 0x020000AA RID: 170
internal sealed class Class113 : DeriveBytes
{
	// Token: 0x06000552 RID: 1362 RVA: 0x0001C708 File Offset: 0x0001A908
	public Class113(byte[] byte_3, byte[] byte_4, int int_1)
	{
		if (byte_3 == null)
		{
			throw new ArgumentNullException("#=zakh_yIU=");
		}
		if (byte_4 == null)
		{
			throw new ArgumentNullException("#=zt5lpyKI=");
		}
		if (int_1 < 1)
		{
			throw new ArgumentException("iterationCount");
		}
		this.byte_0 = (byte[])byte_3.Clone();
		this.byte_1 = (byte[])byte_4.Clone();
		this.int_0 = int_1;
		this.byte_2 = new byte[this.class96_0.method_1()];
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0001C790 File Offset: 0x0001A990
	private void method_0(byte[] byte_3, int int_1, byte[] byte_4, byte[] byte_5, int int_2)
	{
		if (byte_3 != null)
		{
			this.class96_0.method_2(byte_3, 0, byte_3.Length);
		}
		this.class96_0.method_2(byte_4, 0, byte_4.Length);
		this.class96_0.method_3(this.byte_2, 0);
		Buffer.BlockCopy(this.byte_2, 0, byte_5, int_2, this.byte_2.Length);
		for (int i = 1; i < int_1; i++)
		{
			this.class96_0.method_2(this.byte_2, 0, this.byte_2.Length);
			this.class96_0.method_3(this.byte_2, 0);
			for (int j = 0; j < this.byte_2.Length; j++)
			{
				int num = int_2 + j;
				byte_5[num] ^= this.byte_2[j];
			}
		}
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x0001C864 File Offset: 0x0001AA64
	public override byte[] GetBytes(int p0)
	{
		int num = this.class96_0.method_1();
		int num2 = (p0 + num - 1) / num;
		byte[] array = new byte[4];
		byte[] array2 = new byte[num2 * num];
		int num3 = 0;
		this.class96_0.method_0(this.byte_0);
		for (int i = 1; i <= num2; i++)
		{
			int num4 = 3;
			for (;;)
			{
				byte[] array3 = array;
				int num5 = num4;
				byte b = array3[num5] + 1;
				array3[num5] = b;
				if (b != 0)
				{
					break;
				}
				num4--;
			}
			this.method_0(this.byte_1, this.int_0, array, array2, num3);
			num3 += num;
		}
		if (p0 < array2.Length)
		{
			byte[] array4 = new byte[p0];
			Buffer.BlockCopy(array2, 0, array4, 0, p0);
			array2 = array4;
		}
		return array2;
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0001C914 File Offset: 0x0001AB14
	public override void Reset()
	{
		throw new NotSupportedException();
	}

	// Token: 0x04000233 RID: 563
	private byte[] byte_0;

	// Token: 0x04000234 RID: 564
	private byte[] byte_1;

	// Token: 0x04000235 RID: 565
	private int int_0;

	// Token: 0x04000236 RID: 566
	private readonly Class96 class96_0 = new Class96();

	// Token: 0x04000237 RID: 567
	private readonly byte[] byte_2;
}
