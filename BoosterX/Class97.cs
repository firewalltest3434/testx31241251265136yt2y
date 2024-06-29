using System;
using System.Collections.Generic;

// Token: 0x0200008B RID: 139
internal sealed class Class97 : IDisposable, Interface2
{
	// Token: 0x0600047D RID: 1149 RVA: 0x00018300 File Offset: 0x00016500
	public int imethod_0()
	{
		return this.list_0.Count;
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00018310 File Offset: 0x00016510
	public void imethod_3()
	{
		this.list_0.Clear();
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00018320 File Offset: 0x00016520
	public Interface2 imethod_4()
	{
		return new Class97();
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x00018328 File Offset: 0x00016528
	public void Dispose()
	{
		this.imethod_3();
		this.list_0 = null;
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00018338 File Offset: 0x00016538
	public void imethod_1(int int_0, out byte byte_0)
	{
		byte_0 = this.method_0(this.list_0[int_0], int_0);
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00018350 File Offset: 0x00016550
	public void imethod_2(int int_0, ref byte byte_0)
	{
		for (int i = this.list_0.Count; i <= int_0; i++)
		{
			if (i == int_0)
			{
				this.list_0.Add(this.method_1(byte_0, i));
				return;
			}
			this.list_0.Add(this.method_1(0, i));
		}
		this.list_0[int_0] = this.method_1(byte_0, int_0);
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x000183C0 File Offset: 0x000165C0
	private byte method_0(byte byte_0, int int_0)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x000183C8 File Offset: 0x000165C8
	private byte method_1(byte byte_0, int int_0)
	{
		throw new NotImplementedException();
	}

	// Token: 0x04000116 RID: 278
	private List<byte> list_0 = new List<byte>();
}
