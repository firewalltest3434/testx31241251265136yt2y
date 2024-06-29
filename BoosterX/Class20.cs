using System;
using System.Security.Cryptography;

// Token: 0x0200001A RID: 26
internal sealed class Class20 : Class18
{
	// Token: 0x060000A0 RID: 160 RVA: 0x000039A0 File Offset: 0x00001BA0
	public Class20(ICryptoTransform icryptoTransform_1)
	{
		this.icryptoTransform_0 = icryptoTransform_1;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x000039B0 File Offset: 0x00001BB0
	public override void Dispose()
	{
		this.icryptoTransform_0.Dispose();
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x000039C0 File Offset: 0x00001BC0
	public override bool vmethod_0()
	{
		return this.icryptoTransform_0.CanReuseTransform;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x000039D0 File Offset: 0x00001BD0
	public override int vmethod_1()
	{
		return this.icryptoTransform_0.InputBlockSize;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x000039E0 File Offset: 0x00001BE0
	public override int vmethod_2(byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
	{
		return this.icryptoTransform_0.TransformBlock(byte_0, int_0, int_1, byte_1, int_2);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x000039F4 File Offset: 0x00001BF4
	public override byte[] vmethod_3(byte[] byte_0, int int_0, int int_1)
	{
		return this.icryptoTransform_0.TransformFinalBlock(byte_0, int_0, int_1);
	}

	// Token: 0x0400002F RID: 47
	private ICryptoTransform icryptoTransform_0;
}
