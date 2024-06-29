using System;

// Token: 0x0200035D RID: 861
[Attribute5]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
internal sealed class Attribute8 : Attribute
{
	// Token: 0x06001369 RID: 4969 RVA: 0x00051768 File Offset: 0x0004F968
	public Attribute8(byte byte_1)
	{
		this.byte_0 = new byte[]
		{
			byte_1
		};
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x00051780 File Offset: 0x0004F980
	public Attribute8(byte[] byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x04000BDD RID: 3037
	public readonly byte[] byte_0;
}
