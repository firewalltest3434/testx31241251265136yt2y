using System;
using System.Runtime.InteropServices;

// Token: 0x02000188 RID: 392
internal struct Struct77 : IDisposable
{
	// Token: 0x06000A05 RID: 2565 RVA: 0x0002DD88 File Offset: 0x0002BF88
	public Struct77(string string_1, Guid guid_0)
	{
		this.uint_0 = (uint)Marshal.SizeOf(typeof(Struct77));
		this.string_0 = string_1;
		if (guid_0 != Guid.Empty)
		{
			this.intptr_1 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Guid)));
			Marshal.StructureToPtr<Guid>(guid_0, this.intptr_1, true);
		}
		else
		{
			this.intptr_1 = IntPtr.Zero;
		}
		this.intptr_0 = IntPtr.Zero;
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x0002DE00 File Offset: 0x0002C000
	public void Dispose()
	{
		this.method_0(true);
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x0002DE0C File Offset: 0x0002C00C
	private void method_0(bool bool_0)
	{
		if (this.intptr_1 != IntPtr.Zero)
		{
			Marshal.DestroyStructure(this.intptr_1, typeof(Guid));
			Marshal.FreeHGlobal(this.intptr_1);
		}
	}

	// Token: 0x040005D7 RID: 1495
	public uint uint_0;

	// Token: 0x040005D8 RID: 1496
	[MarshalAs(UnmanagedType.LPTStr)]
	public string string_0;

	// Token: 0x040005D9 RID: 1497
	public IntPtr intptr_0;

	// Token: 0x040005DA RID: 1498
	public IntPtr intptr_1;
}
