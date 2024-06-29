using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x020000AC RID: 172
internal static class Class115
{
	// Token: 0x0600055C RID: 1372 RVA: 0x0001CB60 File Offset: 0x0001AD60
	public static bool smethod_0(Type type_5)
	{
		return type_5.IsGenericType && !type_5.IsGenericTypeDefinition && type_5.GetGenericTypeDefinition() == Class115.type_3;
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0001CB84 File Offset: 0x0001AD84
	public static Type smethod_1(Type type_5)
	{
		while (type_5.HasElementType)
		{
			type_5 = type_5.GetElementType();
		}
		return type_5;
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x0001CB9C File Offset: 0x0001AD9C
	public static Type smethod_2(Type type_5)
	{
		if (type_5.HasElementType && !type_5.IsArray)
		{
			type_5 = type_5.GetElementType();
		}
		return type_5;
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x0001CBBC File Offset: 0x0001ADBC
	public static Stack<Struct8> smethod_3(Type type_5)
	{
		Stack<Struct8> stack = new Stack<Struct8>();
		Type type = type_5;
		for (;;)
		{
			if (type.IsArray)
			{
				stack.Push(new Struct8
				{
					int_0 = 1,
					int_1 = type.GetArrayRank()
				});
			}
			else if (type.IsByRef)
			{
				stack.Push(new Struct8
				{
					int_0 = 2
				});
			}
			else
			{
				if (!type.IsPointer)
				{
					break;
				}
				stack.Push(new Struct8
				{
					int_0 = 0
				});
			}
			type = type.GetElementType();
		}
		return stack;
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x0001CC5C File Offset: 0x0001AE5C
	public static Stack<Struct8> smethod_4(string string_0)
	{
		string text = string_0;
		Stack<Struct8> stack = new Stack<Struct8>();
		for (;;)
		{
			if (text.EndsWith("&", StringComparison.Ordinal))
			{
				stack.Push(new Struct8
				{
					int_0 = 2
				});
				text = text.Substring(0, text.Length - 1);
			}
			else if (text.EndsWith("*", StringComparison.Ordinal))
			{
				stack.Push(new Struct8
				{
					int_0 = 0
				});
				text = text.Substring(0, text.Length - 1);
			}
			else if (text.EndsWith("[]", StringComparison.Ordinal))
			{
				stack.Push(new Struct8
				{
					int_0 = 1,
					int_1 = 1
				});
				text = text.Substring(0, text.Length - 2);
			}
			else
			{
				if (!text.EndsWith(",]", StringComparison.Ordinal))
				{
					return stack;
				}
				int num = 1;
				int num2 = -1;
				for (int i = text.Length - 2; i >= 0; i--)
				{
					char c = text[i];
					if (c != ',')
					{
						if (c != '[')
						{
							goto Block_5;
						}
						num2 = i;
						i = -1;
					}
					else
					{
						num++;
					}
				}
				if (num2 < 0)
				{
					goto IL_16F;
				}
				text = text.Substring(0, num2);
				stack.Push(new Struct8
				{
					int_0 = 1,
					int_1 = num
				});
			}
		}
		Block_5:
		throw new InvalidOperationException("VM-3012");
		IL_16F:
		throw new InvalidOperationException("VM-3014");
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x0001CDE4 File Offset: 0x0001AFE4
	public static Type smethod_5(Type type_5, Stack<Struct8> stack_0)
	{
		Type type = type_5;
		while (stack_0.Count > 0)
		{
			Struct8 @struct = stack_0.Pop();
			switch (@struct.int_0)
			{
			case 0:
				type = type.MakePointerType();
				break;
			case 1:
				if (@struct.int_1 == 1)
				{
					type = type.MakeArrayType();
				}
				else
				{
					type = type.MakeArrayType(@struct.int_1);
				}
				break;
			case 2:
				type = type.MakeByRefType();
				break;
			}
		}
		return type;
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x0001CE6C File Offset: 0x0001B06C
	public static int smethod_6(Type type_5)
	{
		int result;
		if (Class115.Class116.dictionary_0.TryGetValue(type_5, out result))
		{
			return result;
		}
		if (type_5.IsArray)
		{
			return 0;
		}
		if (!type_5.IsValueType)
		{
			return 11;
		}
		if (type_5.IsSubclassOf(Class115.type_2))
		{
			return 2;
		}
		if (Class115.smethod_0(type_5))
		{
			return 5;
		}
		return 10;
	}

	// Token: 0x04000238 RID: 568
	public static readonly Type type_0 = typeof(object);

	// Token: 0x04000239 RID: 569
	public static readonly Type type_1 = typeof(ValueType);

	// Token: 0x0400023A RID: 570
	public static readonly Type type_2 = typeof(Enum);

	// Token: 0x0400023B RID: 571
	public static readonly Type type_3 = typeof(Nullable<>);

	// Token: 0x0400023C RID: 572
	public static readonly Type type_4 = typeof(void);

	// Token: 0x0400023D RID: 573
	public static readonly Assembly assembly_0 = typeof(Class115).Assembly;

	// Token: 0x020000AD RID: 173
	private static class Class116
	{
		// Token: 0x0400023E RID: 574
		public static readonly Dictionary<Type, int> dictionary_0 = new Dictionary<Type, int>
		{
			{
				typeof(object),
				17
			},
			{
				typeof(byte),
				12
			},
			{
				typeof(sbyte),
				20
			},
			{
				typeof(short),
				16
			},
			{
				typeof(int),
				7
			},
			{
				typeof(long),
				22
			},
			{
				typeof(ushort),
				26
			},
			{
				typeof(uint),
				19
			},
			{
				typeof(ulong),
				25
			},
			{
				typeof(IntPtr),
				15
			},
			{
				typeof(UIntPtr),
				6
			},
			{
				typeof(float),
				24
			},
			{
				typeof(double),
				8
			},
			{
				typeof(bool),
				14
			},
			{
				typeof(char),
				3
			},
			{
				typeof(string),
				9
			}
		};
	}
}
