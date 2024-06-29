using System;
using System.Runtime.InteropServices;

// Token: 0x02000338 RID: 824
internal sealed class Class381 : IDisposable
{
	// Token: 0x06001293 RID: 4755 RVA: 0x0004CF84 File Offset: 0x0004B184
	internal Class381(IntPtr intptr_1, Enum21 enum21_1)
	{
		this.enum21_0 = enum21_1;
		this.intptr_0 = intptr_1;
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x0004CF9C File Offset: 0x0004B19C
	~Class381()
	{
		this.method_0(false);
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x0004CFCC File Offset: 0x0004B1CC
	private void method_0(bool bool_0)
	{
		if (this.intptr_0 != IntPtr.Zero)
		{
			if (this.enum21_0 == (Enum21)0)
			{
				Marshal.FreeHGlobal(this.intptr_0);
			}
			else if (this.enum21_0 == (Enum21)1)
			{
				Marshal.FreeCoTaskMem(this.intptr_0);
			}
			this.intptr_0 = IntPtr.Zero;
		}
		if (bool_0)
		{
			GC.SuppressFinalize(this);
		}
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x0004D028 File Offset: 0x0004B228
	public void Dispose()
	{
		this.method_0(true);
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x0004D034 File Offset: 0x0004B234
	public static implicit operator IntPtr(Class381 class381_0)
	{
		return class381_0.intptr_0;
	}

	// Token: 0x04000B79 RID: 2937
	private IntPtr intptr_0;

	// Token: 0x04000B7A RID: 2938
	private Enum21 enum21_0;
}
