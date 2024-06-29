using System;

// Token: 0x02000056 RID: 86
internal abstract class Class41 : IDisposable
{
	// Token: 0x0600032F RID: 815
	public abstract bool vmethod_0();

	// Token: 0x06000330 RID: 816
	public abstract bool vmethod_1();

	// Token: 0x06000331 RID: 817
	public abstract bool vmethod_2();

	// Token: 0x06000332 RID: 818
	public abstract long vmethod_3();

	// Token: 0x06000333 RID: 819
	public abstract long vmethod_4();

	// Token: 0x06000334 RID: 820
	public abstract void vmethod_5(long long_0);

	// Token: 0x06000335 RID: 821 RVA: 0x0001325C File Offset: 0x0001145C
	public virtual void vmethod_6()
	{
		this.vmethod_7(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0001326C File Offset: 0x0001146C
	public void Dispose()
	{
		this.vmethod_6();
	}

	// Token: 0x06000337 RID: 823 RVA: 0x00013274 File Offset: 0x00011474
	protected virtual void vmethod_7(bool bool_0)
	{
	}

	// Token: 0x06000338 RID: 824
	public abstract void vmethod_8();

	// Token: 0x06000339 RID: 825
	public abstract long vmethod_9(long long_0, int int_0);

	// Token: 0x0600033A RID: 826
	public abstract void vmethod_10(long long_0);

	// Token: 0x0600033B RID: 827
	public abstract int vmethod_11(byte[] byte_0, int int_0, int int_1);

	// Token: 0x0600033C RID: 828 RVA: 0x00013278 File Offset: 0x00011478
	public virtual int vmethod_12()
	{
		byte[] array = new byte[1];
		if (this.vmethod_11(array, 0, 1) == 0)
		{
			return -1;
		}
		return (int)array[0];
	}

	// Token: 0x0600033D RID: 829
	public abstract void vmethod_13(byte[] byte_0, int int_0, int int_1);

	// Token: 0x0600033E RID: 830 RVA: 0x0001329C File Offset: 0x0001149C
	public virtual void vmethod_14(byte byte_0)
	{
		this.vmethod_13(new byte[]
		{
			byte_0
		}, 0, 1);
	}
}
