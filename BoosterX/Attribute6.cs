using System;

// Token: 0x02000160 RID: 352
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
[Attribute5]
internal sealed class Attribute6 : Attribute
{
	// Token: 0x06000934 RID: 2356 RVA: 0x0002AD0C File Offset: 0x00028F0C
	public Attribute6(byte byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x04000547 RID: 1351
	public readonly byte byte_0;
}
