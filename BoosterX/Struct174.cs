using System;
using System.Runtime.InteropServices;

// Token: 0x02000348 RID: 840
internal struct Struct174 : IDisposable
{
	// Token: 0x06001307 RID: 4871 RVA: 0x0004DF38 File Offset: 0x0004C138
	public Struct174(string string_1, Guid guid_0)
	{
		this.uint_0 = (uint)Marshal.SizeOf(typeof(Struct174));
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

	// Token: 0x06001308 RID: 4872 RVA: 0x0004DFB0 File Offset: 0x0004C1B0
	public void Dispose()
	{
		this.method_0(true);
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x0004DFBC File Offset: 0x0004C1BC
	private void method_0(bool bool_0)
	{
		if (this.intptr_1 != IntPtr.Zero)
		{
			Marshal.DestroyStructure(this.intptr_1, typeof(Guid));
			Marshal.FreeHGlobal(this.intptr_1);
		}
	}

	// Token: 0x04000BA7 RID: 2983
	public uint uint_0;

	// Token: 0x04000BA8 RID: 2984
	[MarshalAs(UnmanagedType.LPTStr)]
	public string string_0;

	// Token: 0x04000BA9 RID: 2985
	public IntPtr intptr_0;

	// Token: 0x04000BAA RID: 2986
	public IntPtr intptr_1;
}
