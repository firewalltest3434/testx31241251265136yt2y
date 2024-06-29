using System;

// Token: 0x0200005A RID: 90
internal abstract class Class44
{
	// Token: 0x06000355 RID: 853 RVA: 0x00013698 File Offset: 0x00011898
	protected Class44(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x06000356 RID: 854
	public abstract object vmethod_0();

	// Token: 0x06000357 RID: 855
	public abstract void vmethod_1(object object_0);

	// Token: 0x06000358 RID: 856 RVA: 0x000136A8 File Offset: 0x000118A8
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x06000359 RID: 857
	public abstract Class44 vmethod_2(Class44 class44_0);

	// Token: 0x0600035A RID: 858
	public abstract Class44 vmethod_3();

	// Token: 0x0600035B RID: 859 RVA: 0x000136B0 File Offset: 0x000118B0
	public Type method_1()
	{
		return this.type_0;
	}

	// Token: 0x0600035C RID: 860 RVA: 0x000136B8 File Offset: 0x000118B8
	public void method_2(Type type_1)
	{
		this.type_0 = type_1;
	}

	// Token: 0x0600035D RID: 861 RVA: 0x000136C4 File Offset: 0x000118C4
	public static Class44 smethod_0(object object_0, Type type_1)
	{
		Class44 @class = object_0 as Class44;
		if (@class != null)
		{
			return @class;
		}
		if (type_1 == null)
		{
			if (object_0 == null)
			{
				return new Class51();
			}
			type_1 = object_0.GetType();
		}
		type_1 = Class115.smethod_2(type_1);
		switch (Class115.smethod_6(type_1))
		{
		case 0:
			@class = new Class70();
			break;
		default:
			@class = new Class51();
			break;
		case 2:
		{
			Enum enum_;
			if (object_0 == null)
			{
				enum_ = (Enum)Activator.CreateInstance(type_1);
			}
			else
			{
				enum_ = (Enum)Enum.ToObject(type_1, object_0);
			}
			return new Class53(enum_);
		}
		case 3:
			@class = new Class45();
			break;
		case 5:
		{
			Class51 class2 = new Class51();
			class2.method_2(type_1);
			@class = class2;
			break;
		}
		case 6:
			@class = new Class50();
			break;
		case 7:
			@class = new Class54();
			break;
		case 8:
			@class = new Class58();
			break;
		case 9:
			@class = new Class71();
			break;
		case 10:
			if (object_0 == null)
			{
				if (type_1 != Class115.type_4)
				{
					object_0 = Activator.CreateInstance(type_1);
				}
			}
			else if (object_0.GetType() != type_1)
			{
				try
				{
					object_0 = Convert.ChangeType(object_0, type_1);
				}
				catch (object obj)
				{
				}
			}
			return new Class46(object_0);
		case 12:
			@class = new Class69();
			break;
		case 14:
			@class = new Class52();
			break;
		case 15:
			@class = new Class49();
			break;
		case 16:
			@class = new Class47();
			break;
		case 17:
			@class = new Class51();
			if (object_0 != null && object_0.GetType() != Class115.type_0)
			{
				@class.method_2(object_0.GetType());
			}
			break;
		case 19:
			@class = new Class59();
			break;
		case 20:
			@class = new Class60();
			break;
		case 22:
			@class = new Class56();
			break;
		case 24:
			@class = new Class57();
			break;
		case 25:
			@class = new Class68();
			break;
		case 26:
			@class = new Class48();
			break;
		}
		if (object_0 != null)
		{
			@class.vmethod_1(object_0);
		}
		return @class;
	}

	// Token: 0x040000A4 RID: 164
	private readonly int int_0;

	// Token: 0x040000A5 RID: 165
	private Type type_0;
}
