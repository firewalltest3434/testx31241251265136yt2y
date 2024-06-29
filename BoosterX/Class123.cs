using System;
using System.Security.Cryptography;

// Token: 0x020000B5 RID: 181
internal sealed class Class123 : DeriveBytes
{
	// Token: 0x06000585 RID: 1413 RVA: 0x0001D690 File Offset: 0x0001B890
	public Class123(byte[] byte_2, byte[] byte_3, int int_1)
	{
		this.byte_0 = byte_2;
		this.byte_1 = byte_3;
		this.int_0 = int_1;
		if (!Class123.bool_0)
		{
			try
			{
				this.deriveBytes_0 = new Rfc2898DeriveBytes(byte_2, byte_3, int_1);
			}
			catch
			{
				Class123.bool_0 = true;
			}
		}
		if (this.deriveBytes_0 == null)
		{
			this.deriveBytes_0 = new Class113(byte_2, byte_3, int_1);
		}
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x0001D704 File Offset: 0x0001B904
	public override byte[] GetBytes(int p0)
	{
		byte[] array = null;
		if (!Class123.bool_0)
		{
			try
			{
				array = this.deriveBytes_0.GetBytes(p0);
			}
			catch
			{
				Class123.bool_0 = true;
			}
		}
		if (array == null)
		{
			this.deriveBytes_0 = new Class113(this.byte_0, this.byte_1, this.int_0);
			array = this.deriveBytes_0.GetBytes(p0);
		}
		return array;
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x0001D774 File Offset: 0x0001B974
	public override void Reset()
	{
		throw new NotSupportedException();
	}

	// Token: 0x0400024E RID: 590
	private static volatile bool bool_0;

	// Token: 0x0400024F RID: 591
	private DeriveBytes deriveBytes_0;

	// Token: 0x04000250 RID: 592
	private readonly byte[] byte_0;

	// Token: 0x04000251 RID: 593
	private readonly byte[] byte_1;

	// Token: 0x04000252 RID: 594
	private readonly int int_0;
}
