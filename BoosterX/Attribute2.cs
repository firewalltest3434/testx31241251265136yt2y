using System;

// Token: 0x0200005D RID: 93
[Attribute4]
[AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
internal sealed class Attribute2 : Attribute
{
	// Token: 0x06000374 RID: 884 RVA: 0x00013CF4 File Offset: 0x00011EF4
	public Attribute2(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x040000B1 RID: 177
	public readonly int int_0;
}
