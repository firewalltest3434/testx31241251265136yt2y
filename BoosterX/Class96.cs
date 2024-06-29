using System;

// Token: 0x0200008A RID: 138
internal sealed class Class96
{
	// Token: 0x06000476 RID: 1142 RVA: 0x000180A0 File Offset: 0x000162A0
	public Class96()
	{
		this.int_0 = this.class88_0.method_5();
		this.int_1 = this.class88_0.method_3();
		this.byte_0 = new byte[this.int_1];
		this.byte_1 = new byte[this.int_1 + this.int_0];
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x0001810C File Offset: 0x0001630C
	public void method_0(byte[] byte_2)
	{
		this.class88_0.method_9();
		int num = byte_2.Length;
		if (num > this.int_1)
		{
			this.class88_0.method_1(byte_2, 0, num);
			this.class88_0.method_8(this.byte_0, 0);
			num = this.int_0;
		}
		else
		{
			Array.Copy(byte_2, 0, this.byte_0, 0, num);
		}
		Array.Clear(this.byte_0, num, this.int_1 - num);
		Array.Copy(this.byte_0, 0, this.byte_1, 0, this.int_1);
		Class96.smethod_0(this.byte_0, this.int_1, 54);
		Class96.smethod_0(this.byte_1, this.int_1, 92);
		this.class88_2 = this.class88_0.method_11();
		this.class88_2.method_1(this.byte_1, 0, this.int_1);
		this.class88_0.method_1(this.byte_0, 0, this.byte_0.Length);
		this.class88_1 = this.class88_0.method_11();
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00018214 File Offset: 0x00016414
	public int method_1()
	{
		return this.int_0;
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x0001821C File Offset: 0x0001641C
	public void method_2(byte[] byte_2, int int_2, int int_3)
	{
		this.class88_0.method_1(byte_2, int_2, int_3);
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x0001822C File Offset: 0x0001642C
	public int method_3(byte[] byte_2, int int_2)
	{
		this.class88_0.method_8(this.byte_1, this.int_1);
		this.class88_0.method_12(this.class88_2);
		this.class88_0.method_1(this.byte_1, this.int_1, this.class88_0.method_5());
		int result = this.class88_0.method_8(byte_2, int_2);
		Array.Clear(this.byte_1, this.int_1, this.int_0);
		this.class88_0.method_12(this.class88_1);
		return result;
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x000182BC File Offset: 0x000164BC
	private static void smethod_0(byte[] byte_2, int int_2, byte byte_3)
	{
		for (int i = 0; i < int_2; i++)
		{
			int num = i;
			byte_2[num] ^= byte_3;
		}
	}

	// Token: 0x0400010F RID: 271
	private readonly Class88 class88_0 = new Class88();

	// Token: 0x04000110 RID: 272
	private readonly int int_0;

	// Token: 0x04000111 RID: 273
	private readonly int int_1;

	// Token: 0x04000112 RID: 274
	private Class88 class88_1;

	// Token: 0x04000113 RID: 275
	private Class88 class88_2;

	// Token: 0x04000114 RID: 276
	private readonly byte[] byte_0;

	// Token: 0x04000115 RID: 277
	private readonly byte[] byte_1;
}
