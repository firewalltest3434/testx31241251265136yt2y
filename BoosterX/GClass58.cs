using System;
using System.Runtime.CompilerServices;

// Token: 0x02000230 RID: 560
public sealed class GClass58<T> : GInterface5
{
	// Token: 0x06000D3A RID: 3386 RVA: 0x0003B874 File Offset: 0x00039A74
	public GClass58(GEnum3 genum3_1)
	{
		this.genum3_0 = genum3_1;
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x0003B884 File Offset: 0x00039A84
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x0003B88C File Offset: 0x00039A8C
	public void method_1(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x06000D3D RID: 3389 RVA: 0x0003B898 File Offset: 0x00039A98
	[CompilerGenerated]
	public string imethod_1()
	{
		return this.string_0;
	}

	// Token: 0x06000D3E RID: 3390 RVA: 0x0003B8A0 File Offset: 0x00039AA0
	[CompilerGenerated]
	public void imethod_2(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0003B8AC File Offset: 0x00039AAC
	public string ValueNameLoc
	{
		get
		{
			return Class364.smethod_0(this.imethod_1());
		}
	}

	// Token: 0x06000D40 RID: 3392 RVA: 0x0003B8BC File Offset: 0x00039ABC
	public T method_2()
	{
		return this.gparam_0;
	}

	// Token: 0x06000D41 RID: 3393 RVA: 0x0003B8C4 File Offset: 0x00039AC4
	public void method_3(T gparam_1)
	{
		this.gparam_0 = gparam_1;
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x0003B8D0 File Offset: 0x00039AD0
	public object imethod_0()
	{
		return this.method_2();
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x0003B8E0 File Offset: 0x00039AE0
	public override string ToString()
	{
		if (typeof(T) == typeof(uint))
		{
			return string.Format("Value=0x{0:X8}; ValueName={1}; Source={2};", this.method_2(), this.imethod_1(), this.genum3_0);
		}
		return string.Format("Value={0}; ValueName={1};", this.method_2(), this.imethod_1());
	}

	// Token: 0x04000840 RID: 2112
	public GEnum3 genum3_0;

	// Token: 0x04000841 RID: 2113
	private int int_0;

	// Token: 0x04000842 RID: 2114
	private string string_0;

	// Token: 0x04000843 RID: 2115
	private T gparam_0;
}
