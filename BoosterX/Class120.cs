using System;

// Token: 0x020000B2 RID: 178
internal sealed class Class120 : Interface1
{
	// Token: 0x06000575 RID: 1397 RVA: 0x0001D300 File Offset: 0x0001B500
	public Class120(byte[] byte_1)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException("#=zakh_yIU=");
		}
		this.byte_0 = (byte[])byte_1.Clone();
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x0001D328 File Offset: 0x0001B528
	public Class120(byte[] byte_1, int int_0, int int_1)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException("#=zakh_yIU=");
		}
		if (int_0 < 0 || int_0 > byte_1.Length)
		{
			throw new ArgumentOutOfRangeException("#=zt5lpyKI=");
		}
		if (int_1 < 0 || int_0 + int_1 > byte_1.Length)
		{
			throw new ArgumentOutOfRangeException("#=zD4aStCw=");
		}
		this.byte_0 = new byte[int_1];
		Array.Copy(byte_1, int_0, this.byte_0, 0, int_1);
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x0001D3A8 File Offset: 0x0001B5A8
	public byte[] method_0()
	{
		return (byte[])this.byte_0.Clone();
	}

	// Token: 0x04000243 RID: 579
	private readonly byte[] byte_0;
}
