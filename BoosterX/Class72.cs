using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Token: 0x0200005B RID: 91
internal sealed class Class72 : IDisposable, Interface6
{
	// Token: 0x0600035E RID: 862 RVA: 0x00013910 File Offset: 0x00011B10
	protected Class72(bool bool_2, Class89 class89_0)
	{
		if (class89_0 == null)
		{
			throw new ArgumentNullException("parameters");
		}
		int int_ = class89_0.method_1().method_1();
		this.int_0 = Class72.smethod_3(int_);
		this.method_0(Class72.smethod_1(int_, bool_2));
		this.method_1(Class72.smethod_2(int_, bool_2));
		Class110.smethod_0(Class110.NCryptOpenStorageProvider(out this.class111_0, "Microsoft Software Key Storage Provider", 0U));
		string string_;
		byte[] array = this.vmethod_0(class89_0, out string_);
		Class110.smethod_0(Class110.NCryptImportKey(this.class111_0, IntPtr.Zero, string_, IntPtr.Zero, out this.class112_0, array, array.Length, 64U));
	}

	// Token: 0x06000360 RID: 864 RVA: 0x000139B4 File Offset: 0x00011BB4
	public static Class72 smethod_0(bool bool_2, Class89 class89_0)
	{
		if (!Class72.bool_0)
		{
			return null;
		}
		Class72 @class = null;
		Class72 result;
		try
		{
			return new Class72(bool_2, class89_0);
		}
		catch
		{
			if (@class != null)
			{
				@class.Dispose();
			}
			Class72.bool_0 = false;
			result = null;
		}
		return result;
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00013A0C File Offset: 0x00011C0C
	[CompilerGenerated]
	public int imethod_0()
	{
		return this.int_1;
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00013A14 File Offset: 0x00011C14
	private void method_0(int int_3)
	{
		this.int_1 = int_3;
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00013A20 File Offset: 0x00011C20
	[CompilerGenerated]
	public int imethod_1()
	{
		return this.int_2;
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00013A28 File Offset: 0x00011C28
	private void method_1(int int_3)
	{
		this.int_2 = int_3;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00013A34 File Offset: 0x00011C34
	private static int smethod_1(int int_3, bool bool_2)
	{
		if (!bool_2)
		{
			return (int_3 + 7) / 8;
		}
		return (int_3 - 1) / 8;
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00013A44 File Offset: 0x00011C44
	private static int smethod_2(int int_3, bool bool_2)
	{
		if (!bool_2)
		{
			return (int_3 - 1) / 8;
		}
		return (int_3 + 7) / 8;
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00013A54 File Offset: 0x00011C54
	private static int smethod_3(int int_3)
	{
		return (int_3 + 7) / 8;
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00013A5C File Offset: 0x00011C5C
	private void method_2()
	{
		if (!this.bool_1)
		{
			this.byte_0 = new byte[this.int_0];
			this.byte_1 = new byte[this.int_0];
			this.bool_1 = true;
		}
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00013A90 File Offset: 0x00011C90
	public int imethod_2(byte[] byte_2, int int_3, int int_4, byte[] byte_3, int int_5, RandomNumberGenerator randomNumberGenerator_0)
	{
		this.method_2();
		byte[] array = this.byte_0;
		int num = array.Length - int_4;
		if (num > 0)
		{
			Array.Clear(array, 0, num);
		}
		Buffer.BlockCopy(byte_2, int_3, array, num, int_4);
		int num2;
		Class110.smethod_0(Class110.NCryptEncrypt(this.class112_0, array, array.Length, IntPtr.Zero, this.byte_1, this.int_0, out num2, 1));
		int num3 = this.imethod_1();
		int srcOffset = num2 - num3;
		Buffer.BlockCopy(this.byte_1, srcOffset, byte_3, int_5, num3);
		return num3;
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00013B0C File Offset: 0x00011D0C
	protected byte[] vmethod_0(Class89 class89_0, out string string_0)
	{
		string_0 = "RSAPUBLICBLOB";
		return Class72.smethod_4(class89_0);
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00013B1C File Offset: 0x00011D1C
	protected static byte[] smethod_4(Class89 class89_0)
	{
		int num = Marshal.SizeOf(typeof(Class110.Struct14));
		byte[] array = new byte[num + class89_0.method_2().method_10() + class89_0.method_1().method_10()];
		Class72.smethod_5(new Class110.Struct14
		{
			uint_0 = 826364754U,
			int_0 = class89_0.method_1().method_1(),
			int_1 = class89_0.method_2().method_10(),
			int_2 = class89_0.method_1().method_10()
		}, array, 0);
		int num2 = num;
		num2 += class89_0.method_2().method_11(array, num2);
		num2 += class89_0.method_1().method_11(array, num2);
		return array;
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00013BCC File Offset: 0x00011DCC
	protected static void smethod_5(Class110.Struct14 struct14_0, byte[] byte_2, int int_3)
	{
		int num = Marshal.SizeOf(struct14_0);
		if (int_3 + num > byte_2.Length)
		{
			throw new ArgumentException("blob");
		}
		try
		{
		}
		finally
		{
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(struct14_0, intPtr, false);
			Marshal.Copy(intPtr, byte_2, int_3, num);
			Marshal.DestroyStructure(intPtr, typeof(Class110.Struct14));
			Marshal.FreeHGlobal(intPtr);
		}
	}

	// Token: 0x0600036D RID: 877 RVA: 0x00013C44 File Offset: 0x00011E44
	public void Dispose()
	{
		if (this.class111_0 != null)
		{
			this.class111_0.Dispose();
			this.class111_0 = null;
		}
		if (this.class112_0 != null)
		{
			this.class112_0.Dispose();
			this.class112_0 = null;
		}
	}

	// Token: 0x040000A6 RID: 166
	private static bool bool_0 = true;

	// Token: 0x040000A7 RID: 167
	protected Class110.Class111 class111_0;

	// Token: 0x040000A8 RID: 168
	protected Class110.Class112 class112_0;

	// Token: 0x040000A9 RID: 169
	protected int int_0;

	// Token: 0x040000AA RID: 170
	private int int_1;

	// Token: 0x040000AB RID: 171
	private int int_2;

	// Token: 0x040000AC RID: 172
	private byte[] byte_0;

	// Token: 0x040000AD RID: 173
	private byte[] byte_1;

	// Token: 0x040000AE RID: 174
	private bool bool_1;
}
