using System;
using System.Runtime.InteropServices;

// Token: 0x020002D0 RID: 720
internal struct Struct146 : IDisposable
{
	// Token: 0x060010A6 RID: 4262 RVA: 0x0004627C File Offset: 0x0004447C
	public Struct146(Struct174 struct174_0)
	{
		this.uint_0 = (uint)Marshal.SizeOf(typeof(Struct146));
		this.intptr_2 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Struct174)));
		Marshal.StructureToPtr<Struct174>(struct174_0, this.intptr_2, false);
		this.enum14_0 = (Enum14)1;
		this.intptr_0 = IntPtr.Zero;
		this.intptr_1 = IntPtr.Zero;
		this.enum7_0 = (Enum7)2;
		this.enum12_0 = (Enum12)0;
		this.enum20_0 = (Enum20)0;
		this.intptr_3 = IntPtr.Zero;
		this.intptr_4 = IntPtr.Zero;
		this.enum23_0 = (Enum23)256;
		this.enum6_0 = (Enum6)0;
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x00046320 File Offset: 0x00044520
	public void Dispose()
	{
		this.method_0(true);
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x0004632C File Offset: 0x0004452C
	private void method_0(bool bool_0)
	{
		if (this.enum14_0 == (Enum14)1)
		{
			Struct174 structure = default(Struct174);
			Marshal.PtrToStructure<Struct174>(this.intptr_2, structure);
			structure.Dispose();
			Marshal.DestroyStructure(this.intptr_2, typeof(Struct174));
		}
		Marshal.FreeHGlobal(this.intptr_2);
	}

	// Token: 0x040009F4 RID: 2548
	public uint uint_0;

	// Token: 0x040009F5 RID: 2549
	public IntPtr intptr_0;

	// Token: 0x040009F6 RID: 2550
	public IntPtr intptr_1;

	// Token: 0x040009F7 RID: 2551
	public Enum7 enum7_0;

	// Token: 0x040009F8 RID: 2552
	public Enum12 enum12_0;

	// Token: 0x040009F9 RID: 2553
	public Enum14 enum14_0;

	// Token: 0x040009FA RID: 2554
	public IntPtr intptr_2;

	// Token: 0x040009FB RID: 2555
	public Enum20 enum20_0;

	// Token: 0x040009FC RID: 2556
	public IntPtr intptr_3;

	// Token: 0x040009FD RID: 2557
	private IntPtr intptr_4;

	// Token: 0x040009FE RID: 2558
	public Enum23 enum23_0;

	// Token: 0x040009FF RID: 2559
	public Enum6 enum6_0;
}
