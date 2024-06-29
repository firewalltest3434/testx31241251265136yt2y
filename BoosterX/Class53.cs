using System;

// Token: 0x02000063 RID: 99
internal sealed class Class53 : Class44
{
	// Token: 0x0600037B RID: 891 RVA: 0x000140C8 File Offset: 0x000122C8
	public Class53() : base(2)
	{
	}

	// Token: 0x0600037C RID: 892 RVA: 0x000140D4 File Offset: 0x000122D4
	public Class53(Enum enum_1) : this()
	{
		this.enum_0 = (enum_1 ?? Class53.Enum1.Value);
	}

	// Token: 0x0600037D RID: 893 RVA: 0x000140F0 File Offset: 0x000122F0
	public Enum method_3()
	{
		return this.enum_0;
	}

	// Token: 0x0600037E RID: 894 RVA: 0x000140F8 File Offset: 0x000122F8
	public void method_4(Enum enum_1)
	{
		if (enum_1 == null)
		{
			throw new ArgumentException();
		}
		this.enum_0 = enum_1;
	}

	// Token: 0x0600037F RID: 895 RVA: 0x0001410C File Offset: 0x0001230C
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000380 RID: 896 RVA: 0x00014114 File Offset: 0x00012314
	public override void vmethod_1(object object_0)
	{
		this.method_4((Enum)Enum.Parse(this.method_3().GetType(), object_0.ToString()));
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00014138 File Offset: 0x00012338
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		int num = class44_0.method_0();
		if (num != 2)
		{
			if (num != 7)
			{
				switch (num)
				{
				case 12:
					this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class69)class44_0).method_3()));
					break;
				default:
					throw new ArgumentOutOfRangeException();
				case 16:
					this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class47)class44_0).method_3()));
					break;
				case 17:
					this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class51)class44_0).method_3()));
					break;
				case 19:
					this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class59)class44_0).method_3()));
					break;
				case 20:
					this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class60)class44_0).method_3()));
					break;
				case 22:
					this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class56)class44_0).method_3()));
					break;
				case 25:
					this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class68)class44_0).method_3()));
					break;
				case 26:
					this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class48)class44_0).method_3()));
					break;
				}
			}
			else
			{
				this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class54)class44_0).method_3()));
			}
		}
		else
		{
			Type type = this.enum_0.GetType();
			Enum @enum = ((Class53)class44_0).method_3();
			if (@enum.GetType() == type)
			{
				this.method_4(@enum);
			}
			else
			{
				this.method_4((Enum)Enum.ToObject(type, @enum));
			}
		}
		return this;
	}

	// Token: 0x06000382 RID: 898 RVA: 0x0001437C File Offset: 0x0001257C
	public override Class44 vmethod_3()
	{
		Class53 @class = new Class53(this.enum_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x040000B7 RID: 183
	private Enum enum_0;

	// Token: 0x02000064 RID: 100
	private enum Enum1
	{
		// Token: 0x040000B9 RID: 185
		Value
	}
}
