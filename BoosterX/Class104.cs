using System;

// Token: 0x0200009E RID: 158
internal sealed class Class104 : Interface1
{
	// Token: 0x060004F7 RID: 1271 RVA: 0x0001A604 File Offset: 0x00018804
	public Class104(Interface1 interface1_1, byte[] byte_1) : this(interface1_1, byte_1, 0, byte_1.Length)
	{
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x0001A614 File Offset: 0x00018814
	public Class104(Interface1 interface1_1, byte[] byte_1, int int_0, int int_1)
	{
		if (interface1_1 == null)
		{
			throw new ArgumentNullException("parameters");
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException("iv");
		}
		this.interface1_0 = interface1_1;
		this.byte_0 = new byte[int_1];
		Array.Copy(byte_1, int_0, this.byte_0, 0, int_1);
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x0001A668 File Offset: 0x00018868
	public byte[] method_0()
	{
		return (byte[])this.byte_0.Clone();
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x0001A67C File Offset: 0x0001887C
	public Interface1 method_1()
	{
		return this.interface1_0;
	}

	// Token: 0x04000215 RID: 533
	private readonly Interface1 interface1_0;

	// Token: 0x04000216 RID: 534
	private readonly byte[] byte_0;
}
