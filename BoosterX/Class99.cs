using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000094 RID: 148
internal sealed class Class99 : IDisposable, Interface2
{
	// Token: 0x060004AE RID: 1198 RVA: 0x00018C4C File Offset: 0x00016E4C
	public int imethod_0()
	{
		return this.secureString_0.Length;
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00018C5C File Offset: 0x00016E5C
	public Interface2 imethod_4()
	{
		return new Class99();
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00018C64 File Offset: 0x00016E64
	public void imethod_1(int int_0, out byte byte_0)
	{
		if (int_0 >= 0 && int_0 < this.imethod_0())
		{
			IntPtr intPtr = IntPtr.Zero;
			char char_ = '\0';
			try
			{
				intPtr = Marshal.SecureStringToGlobalAllocUnicode(this.secureString_0);
				char_ = (char)Marshal.ReadInt16(intPtr, int_0 * 2);
				byte_0 = Class99.smethod_1(char_, int_0);
				return;
			}
			finally
			{
				Class73.smethod_3(ref char_);
				if (intPtr != IntPtr.Zero)
				{
					Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
				}
			}
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00018CE8 File Offset: 0x00016EE8
	public void imethod_2(int int_0, ref byte byte_0)
	{
		for (int i = this.secureString_0.Length; i <= int_0; i++)
		{
			if (i == int_0)
			{
				this.secureString_0.AppendChar(Class99.smethod_0(byte_0, i));
				return;
			}
			this.secureString_0.AppendChar(Class99.smethod_0(0, i));
		}
		this.secureString_0.SetAt(int_0, Class99.smethod_0(byte_0, int_0));
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00018D54 File Offset: 0x00016F54
	private static char smethod_0(byte byte_0, int int_0)
	{
		return (char)(byte_0 + 1);
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00018D5C File Offset: 0x00016F5C
	private static byte smethod_1(char char_0, int int_0)
	{
		return (byte)(char_0 - '\u0001');
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00018D64 File Offset: 0x00016F64
	public void imethod_3()
	{
		this.secureString_0.Clear();
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x00018D74 File Offset: 0x00016F74
	public void Dispose()
	{
		this.secureString_0.Dispose();
		this.secureString_0 = null;
	}

	// Token: 0x04000124 RID: 292
	private SecureString secureString_0 = new SecureString();
}
