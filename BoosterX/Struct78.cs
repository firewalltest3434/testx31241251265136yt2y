using System;
using System.Runtime.InteropServices;

// Token: 0x0200018F RID: 399
internal struct Struct78 : IDisposable
{
	// Token: 0x06000A1E RID: 2590 RVA: 0x0002E27C File Offset: 0x0002C47C
	public Struct78(Struct77 struct77_0)
	{
		this.uint_0 = (uint)Marshal.SizeOf(typeof(Struct78));
		this.intptr_2 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Struct77)));
		Marshal.StructureToPtr<Struct77>(struct77_0, this.intptr_2, false);
		this.enum11_0 = (Enum11)1;
		this.intptr_0 = IntPtr.Zero;
		this.intptr_1 = IntPtr.Zero;
		this.enum13_0 = (Enum13)2;
		this.enum5_0 = (Enum5)0;
		this.enum3_0 = (Enum3)0;
		this.intptr_3 = IntPtr.Zero;
		this.intptr_4 = IntPtr.Zero;
		this.enum18_0 = (Enum18)256;
		this.enum9_0 = (Enum9)0;
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x0002E320 File Offset: 0x0002C520
	public void Dispose()
	{
		this.method_0(true);
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x0002E32C File Offset: 0x0002C52C
	private void method_0(bool bool_0)
	{
		if (this.enum11_0 == (Enum11)1)
		{
			Struct77 structure = default(Struct77);
			Marshal.PtrToStructure<Struct77>(this.intptr_2, structure);
			structure.Dispose();
			Marshal.DestroyStructure(this.intptr_2, typeof(Struct77));
		}
		Marshal.FreeHGlobal(this.intptr_2);
	}

	// Token: 0x040005E5 RID: 1509
	public uint uint_0;

	// Token: 0x040005E6 RID: 1510
	public IntPtr intptr_0;

	// Token: 0x040005E7 RID: 1511
	public IntPtr intptr_1;

	// Token: 0x040005E8 RID: 1512
	public Enum13 enum13_0;

	// Token: 0x040005E9 RID: 1513
	public Enum5 enum5_0;

	// Token: 0x040005EA RID: 1514
	public Enum11 enum11_0;

	// Token: 0x040005EB RID: 1515
	public IntPtr intptr_2;

	// Token: 0x040005EC RID: 1516
	public Enum3 enum3_0;

	// Token: 0x040005ED RID: 1517
	public IntPtr intptr_3;

	// Token: 0x040005EE RID: 1518
	private IntPtr intptr_4;

	// Token: 0x040005EF RID: 1519
	public Enum18 enum18_0;

	// Token: 0x040005F0 RID: 1520
	public Enum9 enum9_0;
}
