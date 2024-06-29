using System;
using System.Reflection;

// Token: 0x02000011 RID: 17
internal sealed class Class46 : Class44
{
	// Token: 0x06000060 RID: 96 RVA: 0x00002F14 File Offset: 0x00001114
	public Class46(object object_1) : base(10)
	{
		if (object_1 != null && !(object_1 is ValueType))
		{
			throw new ArgumentException();
		}
		this.object_0 = object_1;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002F38 File Offset: 0x00001138
	public object method_3()
	{
		return this.object_0;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002F40 File Offset: 0x00001140
	public void method_4(object object_1)
	{
		if (object_1 != null && !(object_1 is ValueType))
		{
			throw new ArgumentException();
		}
		this.object_0 = object_1;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002F5C File Offset: 0x0000115C
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002F64 File Offset: 0x00001164
	public override void vmethod_1(object object_1)
	{
		this.method_4(object_1);
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002F70 File Offset: 0x00001170
	private static bool smethod_1(Type type_1)
	{
		if (type_1.IsGenericType && type_1.Namespace == "System")
		{
			string name = type_1.Name;
			if (name == "Span`1" || name == "ReadOnlySpan`1")
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002FBC File Offset: 0x000011BC
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		int num = class44_0.method_0();
		if (num != 10)
		{
			if (num != 17)
			{
				this.method_4(class44_0.vmethod_0());
			}
			else
			{
				this.method_4(((Class51)class44_0).method_3());
			}
		}
		else
		{
			object obj = ((Class46)class44_0).method_3();
			object obj2 = this.method_3();
			if (obj2 != null && obj != null)
			{
				Type type = obj2.GetType();
				if (!type.IsPrimitive && !type.IsEnum && type == obj.GetType() && Class46.smethod_1(type))
				{
					foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
					{
						fieldInfo.SetValue(obj2, fieldInfo.GetValue(obj));
					}
					return this;
				}
			}
			this.method_4(obj);
		}
		return this;
	}

	// Token: 0x06000067 RID: 103 RVA: 0x000030B8 File Offset: 0x000012B8
	public override Class44 vmethod_3()
	{
		Class46 @class = new Class46(this.object_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x04000021 RID: 33
	private object object_0;
}
