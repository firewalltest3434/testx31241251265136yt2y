using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Token: 0x020000B3 RID: 179
internal sealed class Class121 : IDisposable, Interface6
{
	// Token: 0x06000578 RID: 1400 RVA: 0x0001D3BC File Offset: 0x0001B5BC
	public Class121(bool bool_3, Class89 class89_1, bool bool_4 = false)
	{
		this.bool_0 = bool_3;
		this.class89_0 = class89_1;
		this.bool_1 = bool_4;
		this.bool_1 = true;
		int int_ = class89_1.method_1().method_1();
		this.int_0 = Class121.smethod_0(int_, bool_3);
		this.int_1 = Class121.smethod_1(int_, bool_3);
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x0001D41C File Offset: 0x0001B61C
	public bool method_0()
	{
		return this.bool_0;
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x0001D424 File Offset: 0x0001B624
	[CompilerGenerated]
	public int imethod_0()
	{
		return this.int_0;
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x0001D42C File Offset: 0x0001B62C
	[CompilerGenerated]
	public int imethod_1()
	{
		return this.int_1;
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x0001D434 File Offset: 0x0001B634
	private static int smethod_0(int int_2, bool bool_3)
	{
		if (!bool_3)
		{
			return (int_2 + 7) / 8;
		}
		return (int_2 - 1) / 8;
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x0001D444 File Offset: 0x0001B644
	private static int smethod_1(int int_2, bool bool_3)
	{
		if (!bool_3)
		{
			return (int_2 - 1) / 8;
		}
		return (int_2 + 7) / 8;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x0001D454 File Offset: 0x0001B654
	public int imethod_2(byte[] byte_0, int int_2, int int_3, byte[] byte_1, int int_4, RandomNumberGenerator randomNumberGenerator_0)
	{
		this.method_2();
		Class121.Class122 @class = this.class122_0;
		int result;
		try
		{
			result = @class.interface6_0.imethod_2(byte_0, int_2, int_3, byte_1, int_4, randomNumberGenerator_0);
		}
		catch when (endfilter(@class.bool_0 > false))
		{
			this.method_1();
			@class = this.class122_0;
			result = @class.interface6_0.imethod_2(byte_0, int_2, int_3, byte_1, int_4, randomNumberGenerator_0);
		}
		return result;
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x0001D4C8 File Offset: 0x0001B6C8
	private void method_1()
	{
		object obj = this.object_0;
		lock (obj)
		{
			Class121.Class122 @class = this.class122_0;
			if (@class.bool_0)
			{
				try
				{
					IDisposable disposable = @class.interface6_0 as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				catch (object obj2)
				{
				}
				Interface6 @interface = this.vmethod_0(this.bool_0, this.class89_0);
				if (@interface == null)
				{
					throw new InvalidOperationException();
				}
				this.class122_0 = new Class121.Class122
				{
					bool_0 = false,
					interface6_0 = @interface
				};
			}
		}
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x0001D57C File Offset: 0x0001B77C
	private void method_2()
	{
		if (this.bool_2)
		{
			return;
		}
		object obj = this.object_0;
		lock (obj)
		{
			if (!this.bool_2)
			{
				Interface6 @interface;
				if (!this.bool_1 && (@interface = this.vmethod_1(this.bool_0, this.class89_0)) != null)
				{
					this.class122_0 = new Class121.Class122
					{
						bool_0 = true,
						interface6_0 = @interface
					};
				}
				else
				{
					@interface = this.vmethod_0(this.bool_0, this.class89_0);
					if (@interface == null)
					{
						throw new InvalidOperationException();
					}
					this.class122_0 = new Class121.Class122
					{
						bool_0 = false,
						interface6_0 = @interface
					};
				}
				this.bool_2 = true;
			}
		}
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0001D638 File Offset: 0x0001B838
	protected Interface6 vmethod_0(bool bool_3, Class89 class89_1)
	{
		return new Class98(bool_3, class89_1);
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x0001D644 File Offset: 0x0001B844
	protected Interface6 vmethod_1(bool bool_3, Class89 class89_1)
	{
		return Class72.smethod_0(bool_3, class89_1);
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0001D650 File Offset: 0x0001B850
	public void Dispose()
	{
		Class121.Class122 @class = this.class122_0;
		IDisposable disposable = ((@class != null) ? @class.interface6_0 : null) as IDisposable;
		if (disposable != null)
		{
			disposable.Dispose();
			this.class122_0 = null;
		}
	}

	// Token: 0x04000244 RID: 580
	private readonly Class89 class89_0;

	// Token: 0x04000245 RID: 581
	private readonly bool bool_0;

	// Token: 0x04000246 RID: 582
	private readonly bool bool_1;

	// Token: 0x04000247 RID: 583
	private readonly int int_0;

	// Token: 0x04000248 RID: 584
	private readonly int int_1;

	// Token: 0x04000249 RID: 585
	private Class121.Class122 class122_0;

	// Token: 0x0400024A RID: 586
	private bool bool_2;

	// Token: 0x0400024B RID: 587
	private readonly object object_0 = new object();

	// Token: 0x020000B4 RID: 180
	private sealed class Class122
	{
		// Token: 0x0400024C RID: 588
		public bool bool_0;

		// Token: 0x0400024D RID: 589
		public Interface6 interface6_0;
	}
}
