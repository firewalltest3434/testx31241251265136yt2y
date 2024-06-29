using System;

// Token: 0x02000062 RID: 98
internal static class Class77
{
	// Token: 0x0600037A RID: 890 RVA: 0x00013F20 File Offset: 0x00012120
	public static bool smethod_0(Type type_0, Type type_1, out int int_0)
	{
		int_0 = 0;
		if (type_0 == type_1)
		{
			int_0 = 1;
			return true;
		}
		if (type_0 == null || type_1 == null)
		{
			return false;
		}
		if (type_0.IsByRef)
		{
			return type_1.IsByRef && Class77.smethod_0(type_0.GetElementType(), type_1.GetElementType(), out int_0);
		}
		if (type_1.IsByRef)
		{
			return false;
		}
		if (type_0.IsPointer)
		{
			return type_1.IsPointer && Class77.smethod_0(type_0.GetElementType(), type_1.GetElementType(), out int_0);
		}
		if (type_1.IsPointer)
		{
			return false;
		}
		if (type_0.IsArray)
		{
			return type_1.IsArray && type_0.GetArrayRank() == type_1.GetArrayRank() && Class77.smethod_0(type_0.GetElementType(), type_1.GetElementType(), out int_0);
		}
		if (type_1.IsArray)
		{
			return false;
		}
		if (type_0.IsGenericType != type_1.IsGenericType)
		{
			return false;
		}
		if (type_0.IsGenericType)
		{
			Type type = type_0.IsGenericTypeDefinition ? type_0 : type_0.GetGenericTypeDefinition();
			Type type2 = type_1.IsGenericTypeDefinition ? type_1 : type_1.GetGenericTypeDefinition();
			if (type != type2)
			{
				return false;
			}
			Type[] genericArguments = type_0.GetGenericArguments();
			Type[] genericArguments2 = type_1.GetGenericArguments();
			if (genericArguments.Length != genericArguments2.Length)
			{
				return false;
			}
			for (int i = 0; i < genericArguments.Length; i++)
			{
				int num;
				if (Class77.smethod_0(genericArguments[i], genericArguments2[i], out num))
				{
					int_0 += num;
				}
			}
		}
		else if (type_0 != type_1)
		{
			return false;
		}
		int_0++;
		return true;
	}
}
