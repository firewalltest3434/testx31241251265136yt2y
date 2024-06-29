using System;
using System.Runtime.InteropServices;

// Token: 0x0200068A RID: 1674
internal sealed class Class765 : IDisposable
{
	// Token: 0x060023E8 RID: 9192 RVA: 0x0008E728 File Offset: 0x0008C928
	internal Class765(IntPtr intptr_1, Enum22 enum22_1)
	{
		this.enum22_0 = enum22_1;
		this.intptr_0 = intptr_1;
	}

	// Token: 0x060023E9 RID: 9193 RVA: 0x0008E740 File Offset: 0x0008C940
	~Class765()
	{
		this.method_0(false);
	}

	// Token: 0x060023EA RID: 9194 RVA: 0x0008E770 File Offset: 0x0008C970
	private void method_0(bool bool_0)
	{
		if (this.intptr_0 != IntPtr.Zero)
		{
			if (this.enum22_0 == (Enum22)0)
			{
				Marshal.FreeHGlobal(this.intptr_0);
			}
			else if (this.enum22_0 == (Enum22)1)
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

	// Token: 0x060023EB RID: 9195 RVA: 0x0008E7CC File Offset: 0x0008C9CC
	public void Dispose()
	{
		this.method_0(true);
	}

	// Token: 0x060023EC RID: 9196 RVA: 0x0008E7D8 File Offset: 0x0008C9D8
	public static implicit operator IntPtr(Class765 class765_0)
	{
		return class765_0.intptr_0;
	}

	// Token: 0x0400186F RID: 6255
	private IntPtr intptr_0;

	// Token: 0x04001870 RID: 6256
	private Enum22 enum22_0;
}
