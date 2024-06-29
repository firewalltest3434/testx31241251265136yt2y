using System;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

// Token: 0x020000A5 RID: 165
internal static class Class110
{
	// Token: 0x06000539 RID: 1337 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
	public static void smethod_0(uint uint_0)
	{
		if (uint_0 != 0U)
		{
			uint num = uint_0;
			throw new InvalidOperationException(num.ToString());
		}
	}

	// Token: 0x0600053A RID: 1338
	[DllImport("ncrypt.dll")]
	public static extern uint NCryptFreeObject(IntPtr intptr_0);

	// Token: 0x0600053B RID: 1339
	[DllImport("ncrypt.dll")]
	public static extern uint NCryptEncrypt(Class110.Class112 class112_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_0, IntPtr intptr_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_1, int int_1, out int int_2, int int_3);

	// Token: 0x0600053C RID: 1340
	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
	public static extern uint NCryptImportKey(Class110.Class111 class111_0, IntPtr intptr_0, string string_0, IntPtr intptr_1, out Class110.Class112 class112_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_0, uint uint_0);

	// Token: 0x0600053D RID: 1341
	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
	public static extern uint NCryptOpenStorageProvider(out Class110.Class111 class111_0, string string_0, uint uint_0);

	// Token: 0x020000A6 RID: 166
	[SecurityCritical]
	public sealed class Class111 : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x0001C508 File Offset: 0x0001A708
		public Class111() : base(true)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0001C514 File Offset: 0x0001A714
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0001C528 File Offset: 0x0001A728
		protected override bool ReleaseHandle()
		{
			return Class110.NCryptFreeObject(this.handle) == 0U;
		}
	}

	// Token: 0x020000A7 RID: 167
	public struct Struct14
	{
		// Token: 0x0400022B RID: 555
		public uint uint_0;

		// Token: 0x0400022C RID: 556
		public int int_0;

		// Token: 0x0400022D RID: 557
		public int int_1;

		// Token: 0x0400022E RID: 558
		public int int_2;

		// Token: 0x0400022F RID: 559
		public int int_3;

		// Token: 0x04000230 RID: 560
		public int int_4;
	}

	// Token: 0x020000A8 RID: 168
	[SecurityCritical]
	public sealed class Class112 : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000541 RID: 1345 RVA: 0x0001C538 File Offset: 0x0001A738
		public Class112() : base(true)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0001C544 File Offset: 0x0001A744
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0001C558 File Offset: 0x0001A758
		protected override bool ReleaseHandle()
		{
			return Class110.NCryptFreeObject(this.handle) == 0U;
		}
	}
}
