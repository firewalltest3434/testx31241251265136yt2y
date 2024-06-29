using System;

// Token: 0x0200008C RID: 140
internal struct Struct11
{
	// Token: 0x06000485 RID: 1157 RVA: 0x000183D0 File Offset: 0x000165D0
	public Struct11(int int_1, byte byte_1)
	{
		this.method_1(int_1);
		this.byte_0 = byte_1;
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x000183E0 File Offset: 0x000165E0
	[Attribute1]
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x000183E8 File Offset: 0x000165E8
	public void method_1(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x000183F4 File Offset: 0x000165F4
	[Attribute1]
	public byte method_2()
	{
		return this.byte_0;
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x000183FC File Offset: 0x000165FC
	public override bool Equals(object obj)
	{
		if (obj is Struct11)
		{
			Struct11 struct11_ = (Struct11)obj;
			return this.method_3(struct11_);
		}
		return false;
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00018424 File Offset: 0x00016624
	public bool method_3(Struct11 struct11_0)
	{
		return struct11_0.method_0() == this.method_0();
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00018438 File Offset: 0x00016638
	public static bool operator ==(Struct11 struct11_0, Struct11 struct11_1)
	{
		return struct11_0.method_3(struct11_1);
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00018444 File Offset: 0x00016644
	public static bool operator !=(Struct11 struct11_0, Struct11 struct11_1)
	{
		return !(struct11_0 == struct11_1);
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00018450 File Offset: 0x00016650
	public override int GetHashCode()
	{
		return this.method_0().GetHashCode();
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x0001846C File Offset: 0x0001666C
	public override string ToString()
	{
		return this.method_0().ToString();
	}

	// Token: 0x04000117 RID: 279
	private int int_0;

	// Token: 0x04000118 RID: 280
	private readonly byte byte_0;
}
