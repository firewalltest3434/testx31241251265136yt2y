using System;
using System.Reflection;
using System.Security.Cryptography;

// Token: 0x02000067 RID: 103
internal sealed class Class80 : IDisposable
{
	// Token: 0x060003A7 RID: 935 RVA: 0x00014F28 File Offset: 0x00013128
	public Class80()
	{
		this.method_1((Enum0)1);
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00014F38 File Offset: 0x00013138
	public void Dispose()
	{
		IDisposable disposable = this.symmetricAlgorithm_0;
		if (disposable != null)
		{
			disposable.Dispose();
		}
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00014F58 File Offset: 0x00013158
	public Enum0 method_0()
	{
		return this.enum0_0;
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00014F60 File Offset: 0x00013160
	public void method_1(Enum0 enum0_1)
	{
		if (this.enum0_0 == enum0_1)
		{
			return;
		}
		this.enum0_0 = enum0_1;
		this.bool_1 = true;
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00014F7C File Offset: 0x0001317C
	public Enum2 method_2()
	{
		return this.enum2_0;
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00014F84 File Offset: 0x00013184
	public void method_3(Enum2 enum2_1)
	{
		if (this.enum2_0 == enum2_1)
		{
			return;
		}
		this.enum2_0 = enum2_1;
		this.bool_1 = true;
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00014FA0 File Offset: 0x000131A0
	public byte[] method_4()
	{
		return this.byte_0;
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00014FA8 File Offset: 0x000131A8
	public void method_5(byte[] byte_2)
	{
		this.byte_0 = byte_2;
		this.bool_1 = true;
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00014FB8 File Offset: 0x000131B8
	public byte[] method_6()
	{
		return this.byte_1;
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00014FC0 File Offset: 0x000131C0
	public void method_7(byte[] byte_2)
	{
		this.byte_1 = byte_2;
		this.bool_1 = true;
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00014FD0 File Offset: 0x000131D0
	private static SymmetricAlgorithm smethod_0()
	{
		if (Class80.type_0 != null)
		{
			if (Class80.type_0 == typeof(Class80.Class81))
			{
				return null;
			}
			return Activator.CreateInstance(Class80.type_0) as SymmetricAlgorithm;
		}
		else
		{
			Class80.type_0 = typeof(Class80.Class81);
			Assembly assembly = null;
			try
			{
				assembly = Assembly.Load("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
			}
			catch (object obj)
			{
			}
			if (assembly == null)
			{
				return null;
			}
			try
			{
				Type type = assembly.GetType("System.Security.Cryptography.AesCryptoServiceProvider");
				if (type != null)
				{
					SymmetricAlgorithm result = Activator.CreateInstance(type) as SymmetricAlgorithm;
					Class80.type_0 = type;
					return result;
				}
			}
			catch (object obj2)
			{
			}
			try
			{
				Type type2 = assembly.GetType("System.Security.Cryptography.AesManaged");
				if (type2 != null)
				{
					SymmetricAlgorithm result2 = Activator.CreateInstance(type2) as SymmetricAlgorithm;
					Class80.type_0 = type2;
					return result2;
				}
			}
			catch (object obj3)
			{
			}
			return null;
		}
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x000150FC File Offset: 0x000132FC
	private static CipherMode smethod_1(Enum0 enum0_1)
	{
		if (enum0_1 == (Enum0)1)
		{
			return CipherMode.CBC;
		}
		throw new InvalidOperationException("Cipher mode is not supported");
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00015114 File Offset: 0x00013314
	private static PaddingMode smethod_2(Enum2 enum2_1)
	{
		if (enum2_1 == (Enum2)1)
		{
			return PaddingMode.None;
		}
		if (enum2_1 != (Enum2)2)
		{
			throw new InvalidOperationException("Padding mode is not supported");
		}
		return PaddingMode.PKCS7;
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00015138 File Offset: 0x00013338
	public Class18 method_8()
	{
		return this.method_10(true);
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00015144 File Offset: 0x00013344
	public Class18 method_9()
	{
		return this.method_10(false);
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00015150 File Offset: 0x00013350
	private Class18 method_10(bool bool_2)
	{
		if (!this.bool_0)
		{
			bool flag = this.bool_1 || this.symmetricAlgorithm_0 == null;
			if (this.symmetricAlgorithm_0 == null)
			{
				this.symmetricAlgorithm_0 = Class80.smethod_0();
				if (this.symmetricAlgorithm_0 == null)
				{
					this.bool_0 = true;
				}
			}
			if (this.symmetricAlgorithm_0 != null)
			{
				if (flag)
				{
					this.symmetricAlgorithm_0.Key = this.method_4();
					this.symmetricAlgorithm_0.IV = this.method_6();
					this.symmetricAlgorithm_0.Mode = Class80.smethod_1(this.method_0());
					this.symmetricAlgorithm_0.Padding = Class80.smethod_2(this.method_2());
				}
				return new Class20(bool_2 ? this.symmetricAlgorithm_0.CreateEncryptor() : this.symmetricAlgorithm_0.CreateDecryptor());
			}
		}
		Class92 interface5_ = new Class92(new Class109());
		Class129 @class;
		if (this.method_2() != (Enum2)1)
		{
			@class = new Class130(interface5_, Class80.smethod_3(this.method_2()));
		}
		else
		{
			@class = new Class129(interface5_);
		}
		Class104 interface1_ = new Class104(new Class120(this.method_4()), this.method_6());
		@class.imethod_1(bool_2, interface1_);
		return new Class19(@class);
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00015290 File Offset: 0x00013490
	private static Interface0 smethod_3(Enum2 enum2_1)
	{
		if (enum2_1 == (Enum2)1)
		{
			return null;
		}
		if (enum2_1 != (Enum2)2)
		{
			throw new InvalidOperationException("Padding mode is not supported");
		}
		return new Class15();
	}

	// Token: 0x040000C6 RID: 198
	private Enum0 enum0_0;

	// Token: 0x040000C7 RID: 199
	private Enum2 enum2_0;

	// Token: 0x040000C8 RID: 200
	private byte[] byte_0;

	// Token: 0x040000C9 RID: 201
	private byte[] byte_1;

	// Token: 0x040000CA RID: 202
	private static volatile Type type_0;

	// Token: 0x040000CB RID: 203
	private bool bool_0;

	// Token: 0x040000CC RID: 204
	private bool bool_1;

	// Token: 0x040000CD RID: 205
	private SymmetricAlgorithm symmetricAlgorithm_0;

	// Token: 0x02000068 RID: 104
	private sealed class Class81
	{
	}
}
