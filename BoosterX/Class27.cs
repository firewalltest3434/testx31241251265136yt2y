using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Threading;

// Token: 0x0200002B RID: 43
internal sealed class Class27
{
	// Token: 0x06000105 RID: 261 RVA: 0x00005240 File Offset: 0x00003440
	public Class27(Class102 class102_1, Module module_1)
	{
		this.class102_0 = class102_1;
		this.module_0 = module_1;
		this.method_8();
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00005274 File Offset: 0x00003474
	public Class27(Class102 class102_1) : this(class102_1, typeof(Class27).Module)
	{
	}

	// Token: 0x06000107 RID: 263 RVA: 0x0000528C File Offset: 0x0000348C
	// Note: this type is marked as 'beforefieldinit'.
	static Class27()
	{
		Class27.dictionary_4 = new Dictionary<Class27.Struct2, Class27.Delegate0>(256);
		Class27.dictionary_0 = new Dictionary<MethodBase, int>(256);
		Class27.dictionary_1 = new Dictionary<MethodBase, object>();
		Class27.dictionary_3 = new Dictionary<int, object>();
		Class27.type_3 = typeof(void);
		Class27.type_5 = typeof(object[]);
		Class27.type_2 = typeof(IntPtr);
		Class27.type_0 = typeof(Assembly);
		Class27.type_6 = typeof(MethodBase);
		Class27.type_7 = typeof(RuntimeHelpers);
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00005330 File Offset: 0x00003530
	private void method_0(ref Class27.Struct5 struct5_0)
	{
		if (struct5_0.bool_0)
		{
			Monitor.Exit(Class27.object_2);
		}
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00005344 File Offset: 0x00003544
	private static void smethod_0(Class27 class27_0, Class44 class44_4)
	{
		object object_ = class27_0.method_37().vmethod_0();
		long num = class27_0.method_70();
		Array array = (Array)class27_0.method_37().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(short))
			{
				Class44 @class = Class44.smethod_0(object_, typeof(short));
				((short[])array)[(int)((IntPtr)num)] = (short)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(ushort))
			{
				Class44 class2 = Class44.smethod_0(object_, typeof(ushort));
				((ushort[])array)[(int)((IntPtr)num)] = (ushort)class2.vmethod_0();
				return;
			}
			if (elementType == typeof(char))
			{
				Class44 class3 = Class44.smethod_0(object_, typeof(char));
				((char[])array)[(int)((IntPtr)num)] = (char)class3.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				class27_0.method_34(elementType, object_, num, array);
				return;
			}
			class27_0.method_34(typeof(short), object_, num, array);
		}
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00005448 File Offset: 0x00003648
	public object method_1(Stream stream_1, string string_0, object[] object_3)
	{
		return this.method_85(stream_1, string_0, object_3, null, null, null);
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00005458 File Offset: 0x00003658
	private static void smethod_1(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		if (Class27.smethod_111(class27_0.method_37(), class44_5))
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00005490 File Offset: 0x00003690
	private static object smethod_2(MethodBase methodBase_0, object object_3, object[] object_4, bool bool_2)
	{
		if (!Class27.Class29.bool_0)
		{
			return Class27.smethod_31(methodBase_0, object_3, object_4);
		}
		return Class27.smethod_213(methodBase_0, object_3, object_4, bool_2);
	}

	// Token: 0x0600010D RID: 269 RVA: 0x000054AC File Offset: 0x000036AC
	private bool method_2(Class62 class62_0)
	{
		return !class62_0.method_5().IsInitOnly || (class62_0.method_5().IsStatic == this.class10_0.method_12() && (!this.class10_0.method_12() || !(this.class10_0.method_4() != ".cctor")) && this.method_80(this.class10_0.method_6(), true) == class62_0.method_5().DeclaringType);
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00005538 File Offset: 0x00003738
	private static Class125 smethod_3(Class79 class79_2)
	{
		Class125 @class = new Class125();
		@class.method_3((int)class79_2.method_6());
		@class.method_1(class79_2.method_19());
		@class.method_9(class79_2.method_20());
		@class.method_5(class79_2.method_20());
		@class.method_11(class79_2.method_20());
		@class.method_7(class79_2.method_20());
		return @class;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00005594 File Offset: 0x00003794
	private static Class44 smethod_4(Class44 class44_4, Class44 class44_5, bool bool_2, bool bool_3)
	{
		if (class44_4.method_0() == 7)
		{
			if (class44_5.method_0() == 7)
			{
				if (!bool_3)
				{
					int num = ((Class54)class44_4).method_3();
					int num2 = ((Class54)class44_5).method_3();
					int int_;
					if (bool_2)
					{
						int_ = checked(num - num2);
					}
					else
					{
						int_ = num - num2;
					}
					return new Class54(int_);
				}
				uint num3 = (uint)((Class54)class44_4).method_3();
				uint num4 = (uint)((Class54)class44_5).method_3();
				uint int_2;
				if (bool_2)
				{
					int_2 = checked(num3 - num4);
				}
				else
				{
					int_2 = num3 - num4;
				}
				return new Class54((int)int_2);
			}
			else
			{
				if (class44_5.method_0() == 22)
				{
					return Class27.smethod_150(new Class56((long)((Class54)class44_4).method_3()), class44_5, bool_2, bool_3);
				}
				if (class44_5.method_0() == 2)
				{
					Type underlyingType = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
					if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
					{
						return Class27.smethod_150(new Class56((long)((Class54)class44_4).method_3()), new Class56(Convert.ToInt64(class44_5.vmethod_0())), bool_2, bool_3);
					}
					return Class27.smethod_4(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2, bool_3);
				}
			}
		}
		if (class44_4.method_0() == 22)
		{
			if (class44_5.method_0() == 22)
			{
				return Class27.smethod_150(class44_4, class44_5, bool_2, bool_3);
			}
			if (class44_5.method_0() == 7)
			{
				return Class27.smethod_150(class44_4, new Class56((long)((Class54)class44_5).method_3()), bool_2, bool_3);
			}
			if (class44_5.method_0() == 2)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return Class27.smethod_150(class44_4, new Class56(Convert.ToInt64(class44_5.vmethod_0())), bool_2, bool_3);
				}
				return Class27.smethod_150(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class44_4.method_0() == 8 && class44_5.method_0() == 8)
		{
			Class58 @class = new Class58();
			@class.method_4(((Class58)class44_4).method_3() - ((Class58)class44_5).method_3());
			return @class;
		}
		if (class44_4.method_0() != 2)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType3 = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
		if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong))
		{
			return Class27.smethod_4(new Class56(Convert.ToInt64(class44_4.vmethod_0())), class44_5, bool_2, bool_3);
		}
		return Class27.smethod_4(new Class54(Convert.ToInt32(class44_4.vmethod_0())), class44_5, bool_2, bool_3);
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00005848 File Offset: 0x00003A48
	private static void smethod_5(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_16(typeof(double));
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0000585C File Offset: 0x00003A5C
	private static void smethod_6(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_74(typeof(int));
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00005870 File Offset: 0x00003A70
	private static void smethod_7(Class27 class27_0, Class44 class44_4)
	{
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00005874 File Offset: 0x00003A74
	private static void smethod_8(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Type t = class27_0.method_80(int_, true);
		class27_0.method_22(new Class54(Marshal.SizeOf(t)));
	}

	// Token: 0x06000114 RID: 276 RVA: 0x000058A8 File Offset: 0x00003AA8
	private static void smethod_9(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		FieldInfo fieldInfo = class27_0.method_27(int_);
		Class44 @class = class27_0.method_37();
		Class61 class2 = @class as Class61;
		if (class2 != null)
		{
			@class = class27_0.method_83(class2);
		}
		object obj = @class.vmethod_0();
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		class27_0.method_22(Class44.smethod_0(fieldInfo.GetValue(obj), fieldInfo.FieldType));
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0000590C File Offset: 0x00003B0C
	public static object smethod_10(Type type_9)
	{
		if (type_9.IsValueType)
		{
			return Activator.CreateInstance(type_9);
		}
		return null;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00005920 File Offset: 0x00003B20
	private Class44[] method_3()
	{
		Class37[] array = this.class10_0.method_0();
		int num = array.Length;
		Class44[] array2 = new Class44[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = Class44.smethod_0(null, this.method_80(array[i].method_0(), false));
		}
		return array2;
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0000597C File Offset: 0x00003B7C
	private static Exception smethod_11(string string_0, string string_1)
	{
		return new MethodAccessException(Class27.smethod_105("security transparent method '" + string_0 + "'", "security critical method '" + string_1 + "'"));
	}

	// Token: 0x06000118 RID: 280 RVA: 0x000059A8 File Offset: 0x00003BA8
	private static void smethod_12(Class27 class27_0, Class44 class44_4)
	{
		MethodBase methodBase_ = ((Class55)class27_0.method_37()).method_3();
		class27_0.method_81(methodBase_, false);
	}

	// Token: 0x06000119 RID: 281 RVA: 0x000059D0 File Offset: 0x00003BD0
	private static void smethod_13(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		class27_0.method_22(class27_0.method_36(class44_5));
	}

	// Token: 0x0600011A RID: 282 RVA: 0x000059F4 File Offset: 0x00003BF4
	private static void smethod_14(Class27 class27_0, Class44 class44_4)
	{
		throw new NotSupportedException("Arglist is not supported.");
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00005A00 File Offset: 0x00003C00
	private static void smethod_15(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_73(typeof(double));
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00005A14 File Offset: 0x00003C14
	private static void smethod_16(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_96(0);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00005A20 File Offset: 0x00003C20
	public void method_4(Stream stream_1, string string_0, object[] object_3)
	{
		this.method_1(stream_1, string_0, object_3);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00005A2C File Offset: 0x00003C2C
	private static void smethod_17(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_71(3);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00005A38 File Offset: 0x00003C38
	private static void smethod_18(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_74(typeof(short));
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00005A4C File Offset: 0x00003C4C
	private void method_5(Class61 class61_0, Class44 class44_4)
	{
		int num = class61_0.method_0();
		if (num <= 13)
		{
			if (num == 1)
			{
				goto IL_77;
			}
			if (num == 13)
			{
				this.class44_0[((Class63)class61_0).method_3()].vmethod_2(class44_4);
				return;
			}
		}
		else if (num != 18)
		{
			if (num == 21)
			{
				goto IL_77;
			}
			if (num == 23)
			{
				((Class64)class61_0).method_3().vmethod_2(class44_4);
				return;
			}
		}
		else
		{
			Class62 @class = (Class62)class61_0;
			FieldInfo fieldInfo = @class.method_5();
			Class44 class2 = Class44.smethod_0(class44_4.vmethod_0(), fieldInfo.FieldType);
			fieldInfo.SetValue(@class.method_3(), class2.vmethod_0());
			Class61 class3 = @class.method_7();
			if (class3 != null && fieldInfo.DeclaringType.IsValueType)
			{
				this.method_5(class3, Class44.smethod_0(@class.method_3(), null));
				return;
			}
			return;
		}
		throw new ArgumentOutOfRangeException();
		IL_77:
		Class65 class4 = (Class65)class61_0;
		Class44 class5 = Class44.smethod_0(class44_4.vmethod_0(), class4.method_3());
		class4.vmethod_5(class5.vmethod_0());
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00005B60 File Offset: 0x00003D60
	private static void smethod_19(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_10(false, false);
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00005B6C File Offset: 0x00003D6C
	private static void smethod_20(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_32(true);
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00005B78 File Offset: 0x00003D78
	private static void smethod_21(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_73(Class115.type_0);
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00005B88 File Offset: 0x00003D88
	private static void smethod_22(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_58(true, false);
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00005B94 File Offset: 0x00003D94
	private static void smethod_23(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_16(typeof(long));
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00005BA8 File Offset: 0x00003DA8
	private static void smethod_24(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_95(class44_4);
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00005BB4 File Offset: 0x00003DB4
	private static void smethod_25(Class27 class27_0, Class44 class44_4)
	{
		Debugger.Break();
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00005BBC File Offset: 0x00003DBC
	private static bool smethod_26(Class44 class44_4, Class44 class44_5)
	{
		bool result = false;
		int num = class44_4.method_0();
		if (num <= 7)
		{
			if (num == 2)
			{
				return Class27.smethod_26(new Class56(Convert.ToInt64(((Class53)class44_4).method_3())), class44_5);
			}
			if (num == 7)
			{
				if (class44_5.method_0() == 2)
				{
					return Class27.smethod_26(class44_4, new Class54(Convert.ToInt32(((Class53)class44_5).method_3())));
				}
				result = (((Class54)class44_4).method_3() < ((Class54)class44_5).method_3());
			}
		}
		else if (num != 8)
		{
			if (num == 22)
			{
				if (class44_5.method_0() == 2)
				{
					return Class27.smethod_26(class44_4, new Class56(Convert.ToInt64(((Class53)class44_5).method_3())));
				}
				if (class44_5.method_0() == 7)
				{
					return Class27.smethod_26(class44_4, new Class56((long)((Class54)class44_5).method_3()));
				}
				result = (((Class56)class44_4).method_3() < ((Class56)class44_5).method_3());
			}
		}
		else
		{
			result = (((Class58)class44_4).method_3() < ((Class58)class44_5).method_3());
		}
		return result;
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00005CF0 File Offset: 0x00003EF0
	private static void smethod_27(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Type type_ = class27_0.method_80(int_, true);
		Class44 class44_5 = class27_0.method_37();
		if (class27_0.method_23(class44_5, type_))
		{
			class27_0.method_22(class44_5);
			return;
		}
		class27_0.method_22(new Class51());
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00005D38 File Offset: 0x00003F38
	private static void smethod_28(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_86(false);
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00005D44 File Offset: 0x00003F44
	private void method_6(bool bool_2)
	{
		Class44 @class = this.method_37();
		bool flag = IntPtr.Size == 4;
		int num = @class.method_0();
		IntPtr intptr_;
		if (num <= 7)
		{
			if (num != 2)
			{
				if (num == 7)
				{
					int value = ((Class54)@class).method_3();
					if (bool_2)
					{
						intptr_ = new IntPtr(value);
						goto IL_166;
					}
					intptr_ = new IntPtr(value);
					goto IL_166;
				}
			}
			else
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(checked((long)Convert.ToUInt64(((Class53)@class).method_3())));
					goto IL_166;
				}
				intptr_ = new IntPtr((long)Convert.ToUInt64(((Class53)@class).method_3()));
				goto IL_166;
			}
		}
		else if (num != 8)
		{
			if (num == 22)
			{
				long num2 = ((Class56)@class).method_3();
				if (flag)
				{
					if (bool_2)
					{
						intptr_ = new IntPtr(checked((int)num2));
						goto IL_166;
					}
					intptr_ = new IntPtr((int)num2);
					goto IL_166;
				}
				else
				{
					if (bool_2)
					{
						intptr_ = new IntPtr(num2);
						goto IL_166;
					}
					intptr_ = new IntPtr(num2);
					goto IL_166;
				}
			}
		}
		else
		{
			double num3 = ((Class58)@class).method_3();
			if (flag)
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(checked((int)num3));
					goto IL_166;
				}
				intptr_ = new IntPtr((int)num3);
				goto IL_166;
			}
			else
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(checked((long)num3));
					goto IL_166;
				}
				intptr_ = new IntPtr((long)num3);
				goto IL_166;
			}
		}
		throw new InvalidOperationException();
		IL_166:
		Class49 class2 = new Class49();
		class2.method_4(intptr_);
		this.method_22(class2);
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00005ECC File Offset: 0x000040CC
	private static void smethod_29(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_105(true);
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00005ED8 File Offset: 0x000040D8
	private static void smethod_30(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		checked
		{
			long long_;
			if (num <= 7)
			{
				if (num == 2)
				{
					long_ = (long)Convert.ToUInt64(((Class53)@class).method_3());
					goto IL_D4;
				}
				if (num == 7)
				{
					long_ = (long)(unchecked((ulong)((Class54)@class).method_3()));
					goto IL_D4;
				}
			}
			else
			{
				if (num == 8)
				{
					long_ = (long)((Class58)@class).method_3();
					goto IL_D4;
				}
				if (num != 15)
				{
					if (num == 22)
					{
						long_ = (long)((ulong)((Class56)@class).method_3());
						goto IL_D4;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						long_ = (long)(unchecked((ulong)((int)((Class49)@class).method_3())));
						goto IL_D4;
					}
					long_ = (long)((ulong)((long)((Class49)@class).method_3()));
					goto IL_D4;
				}
			}
			throw new InvalidOperationException();
			IL_D4:
			class27_0.method_22(new Class56(long_));
		}
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00005FC8 File Offset: 0x000041C8
	private Class10 method_7(Class79 class79_2)
	{
		Class10 @class = new Class10();
		@class.method_9(class79_2.method_19());
		@class.method_11(class79_2.method_6());
		@class.method_3(this.method_66(class79_2));
		@class.method_1(this.method_52(class79_2));
		@class.method_5(class79_2.method_9());
		@class.method_7(class79_2.method_19());
		return @class;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00006024 File Offset: 0x00004224
	private static object smethod_31(MethodBase methodBase_0, object object_3, object[] object_4)
	{
		if (methodBase_0.IsConstructor)
		{
			object result;
			try
			{
				result = Activator.CreateInstance(methodBase_0.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, object_4, null);
			}
			catch (AmbiguousMatchException)
			{
				result = ((ConstructorInfo)methodBase_0).Invoke(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, object_4, null);
			}
			return result;
		}
		return methodBase_0.Invoke(object_3, object_4);
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0000607C File Offset: 0x0000427C
	private void method_8()
	{
		if (!this.class102_0.method_0())
		{
			Class102 obj = this.class102_0;
			lock (obj)
			{
				if (!this.class102_0.method_0())
				{
					Class27.dictionary_2 = Class27.smethod_189(this.class102_0);
					this.method_72();
					this.class102_0.method_1(true);
				}
			}
		}
		if (Class27.dictionary_2 == null)
		{
			Class27.dictionary_2 = Class27.smethod_189(this.class102_0);
		}
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00006104 File Offset: 0x00004304
	private void method_9(bool bool_2)
	{
		Class44 @class = this.method_37();
		int num = @class.method_0();
		byte int_;
		if (num <= 7)
		{
			if (num != 2)
			{
				if (num == 7)
				{
					if (bool_2)
					{
						int_ = checked((byte)((uint)((Class54)@class).method_3()));
						goto IL_176;
					}
					int_ = (byte)((Class54)@class).method_3();
					goto IL_176;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((byte)Convert.ToUInt64(((Class53)@class).method_3()));
					goto IL_176;
				}
				int_ = (byte)Convert.ToUInt64(((Class53)@class).method_3());
				goto IL_176;
			}
		}
		else if (num != 8)
		{
			if (num != 15)
			{
				if (num == 22)
				{
					if (bool_2)
					{
						int_ = checked((byte)((ulong)((Class56)@class).method_3()));
						goto IL_176;
					}
					int_ = (byte)((Class56)@class).method_3();
					goto IL_176;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = checked((byte)((int)((Class49)@class).method_3()));
					goto IL_176;
				}
				int_ = (byte)((int)((Class49)@class).method_3());
				goto IL_176;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((byte)((ulong)((long)((Class49)@class).method_3())));
					goto IL_176;
				}
				int_ = (byte)((long)((Class49)@class).method_3());
				goto IL_176;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((byte)((Class58)@class).method_3());
				goto IL_176;
			}
			int_ = (byte)((Class58)@class).method_3();
			goto IL_176;
		}
		throw new InvalidOperationException();
		IL_176:
		this.method_22(new Class54((int)int_));
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00006294 File Offset: 0x00004494
	public static void smethod_32<T>(T[] gparam_0, Comparison<T> comparison_0)
	{
		KeyValuePair<int, T>[] array = new KeyValuePair<int, T>[gparam_0.Length];
		for (int i = 0; i < gparam_0.Length; i++)
		{
			array[i] = new KeyValuePair<int, T>(i, gparam_0[i]);
		}
		Array.Sort<KeyValuePair<int, T>, T>(array, gparam_0, new Class27.Class30<T>(comparison_0));
	}

	// Token: 0x06000133 RID: 307 RVA: 0x000062E4 File Offset: 0x000044E4
	private static void smethod_33(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Type type_ = class27_0.method_80(int_, true);
		Class44 class44_5 = class27_0.method_37();
		if (!class27_0.method_23(class44_5, type_))
		{
			throw new InvalidCastException();
		}
		class27_0.method_22(class44_5);
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00006324 File Offset: 0x00004524
	private static void smethod_34(Class27 class27_0, Class44 class44_4)
	{
		Class48 @class = (Class48)class44_4;
		Class64 class2 = new Class64();
		class2.method_4(class27_0.class44_1[(int)@class.method_3()]);
		class27_0.method_22(class2);
	}

	// Token: 0x06000135 RID: 309 RVA: 0x0000635C File Offset: 0x0000455C
	private static bool smethod_35()
	{
		return false;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00006360 File Offset: 0x00004560
	private void method_10(bool bool_2, bool bool_3)
	{
		Class44 class44_ = this.method_37();
		Class44 class44_2 = this.method_37();
		this.method_22(Class27.smethod_92(class44_2, class44_, bool_2, bool_3));
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0000638C File Offset: 0x0000458C
	private MethodBase method_11(Class4 class4_0)
	{
		Type type = this.method_80(class4_0.method_4().method_2(), false);
		BindingFlags bindingAttr = Class27.smethod_188(class4_0.method_2());
		Type[] array = null;
		Class93[] array2 = class4_0.method_10();
		if (array2 != null)
		{
			array = new Type[array2.Length];
			for (int i = 0; i < array.Length; i++)
			{
				Class93 @class = array2[i];
				if (@class != null)
				{
					array[i] = this.method_80(@class.method_2(), true);
				}
			}
		}
		MemberInfo[] member = type.GetMember(class4_0.method_6(), MemberTypes.Method, bindingAttr);
		MethodInfo methodInfo = null;
		int num = -1;
		foreach (MethodInfo methodInfo2 in member)
		{
			int num2;
			if (this.method_31(methodInfo2, class4_0, array, out num2) && num2 > num)
			{
				methodInfo = methodInfo2;
				num = num2;
			}
		}
		if (methodInfo == null)
		{
			throw new Exception(string.Format("Cannot bind method: {0}.{1}", type.Name, class4_0.method_6()));
		}
		return methodInfo.MakeGenericMethod(array);
	}

	// Token: 0x06000138 RID: 312 RVA: 0x0000649C File Offset: 0x0000469C
	private static void smethod_36(Class27 class27_0, Class44 class44_4)
	{
		object object_ = class27_0.method_37().vmethod_0();
		long num = class27_0.method_70();
		Array array = (Array)class27_0.method_37().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(int))
			{
				Class44 @class = Class44.smethod_0(object_, typeof(int));
				((int[])array)[(int)((IntPtr)num)] = (int)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(uint))
			{
				Class44 class2 = Class44.smethod_0(object_, typeof(uint));
				((uint[])array)[(int)((IntPtr)num)] = (uint)class2.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				class27_0.method_34(elementType, object_, num, array);
				return;
			}
			class27_0.method_34(typeof(int), object_, num, array);
		}
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0000656C File Offset: 0x0000476C
	private static void smethod_37(ILGenerator ilgenerator_0, Type type_9)
	{
		if (type_9.IsValueType || Class115.smethod_1(type_9).IsGenericParameter)
		{
			ilgenerator_0.Emit(OpCodes.Box, type_9);
		}
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00006590 File Offset: 0x00004790
	private static Class27.Delegate0 smethod_38(MethodBase methodBase_0, bool bool_2)
	{
		DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, Class115.type_0, new Type[]
		{
			Class115.type_0,
			Class27.type_5
		}, typeof(Class27).Module, true);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Type[] array = new Type[parameters.Length];
		bool flag = false;
		for (int i = 0; i < parameters.Length; i++)
		{
			Type type = parameters[i].ParameterType;
			if (type.IsByRef)
			{
				flag = true;
				type = type.GetElementType();
			}
			array[i] = type;
		}
		LocalBuilder[] array2 = new LocalBuilder[array.Length];
		if (array2.Length != 0)
		{
			dynamicMethod.InitLocals = true;
		}
		for (int j = 0; j < array.Length; j++)
		{
			array2[j] = ilgenerator.DeclareLocal(array[j]);
		}
		for (int k = 0; k < array.Length; k++)
		{
			ilgenerator.Emit(OpCodes.Ldarg_1);
			Class27.smethod_250(ilgenerator, k);
			ilgenerator.Emit(OpCodes.Ldelem_Ref);
			Class27.smethod_226(ilgenerator, array[k]);
			ilgenerator.Emit(OpCodes.Stloc, array2[k]);
		}
		if (flag)
		{
			ilgenerator.BeginExceptionBlock();
		}
		if (!methodBase_0.IsStatic && !methodBase_0.IsConstructor)
		{
			ilgenerator.Emit(OpCodes.Ldarg_0);
			Type declaringType = methodBase_0.DeclaringType;
			if (declaringType.IsValueType)
			{
				ilgenerator.Emit(OpCodes.Unbox, declaringType);
				bool_2 = false;
			}
			else
			{
				Class27.smethod_127(ilgenerator, declaringType);
			}
		}
		for (int l = 0; l < array.Length; l++)
		{
			if (parameters[l].ParameterType.IsByRef)
			{
				ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
			}
			else
			{
				ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
			}
		}
		if (methodBase_0.IsConstructor)
		{
			ilgenerator.Emit(OpCodes.Newobj, (ConstructorInfo)methodBase_0);
			Class27.smethod_37(ilgenerator, methodBase_0.DeclaringType);
		}
		else
		{
			MethodInfo methodInfo = (MethodInfo)methodBase_0;
			if (bool_2 && !methodBase_0.IsStatic)
			{
				ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
			}
			else
			{
				ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
			}
			if (methodInfo.ReturnType == Class27.type_3)
			{
				ilgenerator.Emit(OpCodes.Ldnull);
			}
			else
			{
				Class27.smethod_37(ilgenerator, methodInfo.ReturnType);
			}
		}
		if (flag)
		{
			LocalBuilder local = ilgenerator.DeclareLocal(Class115.type_0);
			ilgenerator.Emit(OpCodes.Stloc, local);
			ilgenerator.BeginFinallyBlock();
			for (int m = 0; m < array.Length; m++)
			{
				if (parameters[m].ParameterType.IsByRef)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class27.smethod_250(ilgenerator, m);
					ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
					if (array2[m].LocalType.IsValueType || Class115.smethod_1(array2[m].LocalType).IsGenericParameter)
					{
						ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
					}
					ilgenerator.Emit(OpCodes.Stelem_Ref);
				}
			}
			ilgenerator.EndExceptionBlock();
			ilgenerator.Emit(OpCodes.Ldloc, local);
		}
		ilgenerator.Emit(OpCodes.Ret);
		return (Class27.Delegate0)dynamicMethod.CreateDelegate(typeof(Class27.Delegate0));
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00006938 File Offset: 0x00004B38
	private bool method_12()
	{
		return this.class44_2 != null || this.stack_2.Count != 0;
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00006954 File Offset: 0x00004B54
	private int method_13()
	{
		return -1948471376;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0000695C File Offset: 0x00004B5C
	private static void smethod_39(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_73(Class27.type_2);
	}

	// Token: 0x0600013E RID: 318 RVA: 0x0000696C File Offset: 0x00004B6C
	private static void smethod_40(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_53(true);
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00006978 File Offset: 0x00004B78
	private static void smethod_41(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_51();
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00006980 File Offset: 0x00004B80
	private void method_14(bool bool_2)
	{
		Class44 @class = this.method_37();
		int num = @class.method_0();
		long long_;
		if (num <= 7)
		{
			if (num != 2)
			{
				if (num == 7)
				{
					if (bool_2)
					{
						long_ = (long)((Class54)@class).method_3();
						goto IL_12D;
					}
					long_ = (long)((Class54)@class).method_3();
					goto IL_12D;
				}
			}
			else
			{
				if (bool_2)
				{
					long_ = checked((long)Convert.ToUInt64(((Class53)@class).method_3()));
					goto IL_12D;
				}
				long_ = (long)Convert.ToUInt64(((Class53)@class).method_3());
				goto IL_12D;
			}
		}
		else if (num != 8)
		{
			if (num != 15)
			{
				if (num == 22)
				{
					if (bool_2)
					{
						long_ = ((Class56)@class).method_3();
						goto IL_12D;
					}
					long_ = ((Class56)@class).method_3();
					goto IL_12D;
				}
			}
			else
			{
				if (bool_2)
				{
					long_ = (long)((Class49)@class).method_3();
					goto IL_12D;
				}
				long_ = (long)((Class49)@class).method_3();
				goto IL_12D;
			}
		}
		else
		{
			if (bool_2)
			{
				long_ = checked((long)((Class58)@class).method_3());
				goto IL_12D;
			}
			long_ = (long)((Class58)@class).method_3();
			goto IL_12D;
		}
		throw new InvalidOperationException();
		IL_12D:
		Class56 class2 = new Class56();
		class2.method_4(long_);
		this.method_22(class2);
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00006ACC File Offset: 0x00004CCC
	private static void smethod_42(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_74(typeof(uint));
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00006AE0 File Offset: 0x00004CE0
	private Class44 method_15()
	{
		return this.class44_2 ?? this.stack_2.Peek();
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00006AF8 File Offset: 0x00004CF8
	private static void smethod_43(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		class27_0.type_4 = class27_0.method_80(int_, true);
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00006B20 File Offset: 0x00004D20
	private void method_16(Type type_9)
	{
		long index = this.method_70();
		Array array = (Array)this.method_37().vmethod_0();
		this.method_22(Class44.smethod_0(array.GetValue(index), type_9));
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00006B58 File Offset: 0x00004D58
	private static void smethod_44(Class27 class27_0, Class44 class44_4)
	{
		Thread.MemoryBarrier();
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00006B60 File Offset: 0x00004D60
	private static void smethod_45(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		Class44 class44_6 = class27_0.method_37();
		class27_0.method_22(new Class54(Class27.smethod_149(class44_6, class44_5) ? 1 : 0));
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00006B94 File Offset: 0x00004D94
	private static bool smethod_46(uint uint_3, uint uint_4, uint uint_5)
	{
		return uint_3 >= uint_4 && uint_3 <= uint_4 + uint_5;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00006BAC File Offset: 0x00004DAC
	private void method_17(bool bool_2, bool bool_3)
	{
		Class44 class44_ = this.method_37();
		Class44 class44_2 = this.method_37();
		this.method_22(Class27.smethod_110(class44_2, class44_, bool_2, bool_3));
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00006BD8 File Offset: 0x00004DD8
	private void method_18(Class79 class79_2)
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00006BDC File Offset: 0x00004DDC
	private Class44 method_19(Class79 class79_2, byte byte_1)
	{
		switch (byte_1)
		{
		case 0:
		{
			this.uint_0 += 4U;
			Class59 @class = new Class59();
			@class.method_4(class79_2.method_20());
			return @class;
		}
		case 1:
		{
			this.uint_0 += 4U;
			Class57 class2 = new Class57();
			class2.method_4(class79_2.method_26());
			return class2;
		}
		case 2:
		case 4:
		{
			this.uint_0 += 2U;
			Class48 class3 = new Class48();
			class3.method_4(class79_2.method_24());
			return class3;
		}
		case 3:
		case 5:
			this.uint_0 += 4U;
			return new Class54(class79_2.method_19());
		case 6:
		case 9:
		{
			this.uint_0 += 1U;
			Class69 class4 = new Class69();
			class4.method_4(class79_2.method_6());
			return class4;
		}
		case 7:
		{
			int num = class79_2.method_19();
			Class54[] array = new Class54[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new Class54(class79_2.method_19());
			}
			this.uint_0 += (uint)((num + 1) * 4);
			Class70 class5 = new Class70();
			class5.method_4(array);
			return class5;
		}
		case 8:
			return null;
		case 10:
		{
			this.uint_0 += 8U;
			Class58 class6 = new Class58();
			class6.method_4(class79_2.method_27());
			return class6;
		}
		case 11:
			this.uint_0 += 8U;
			return new Class56(class79_2.method_21());
		case 12:
		{
			this.uint_0 += 1U;
			Class60 class7 = new Class60();
			class7.method_4(class79_2.method_7());
			return class7;
		}
		default:
			throw new Exception("Unknown operand type.");
		}
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00006D78 File Offset: 0x00004F78
	private void method_20(bool bool_2)
	{
		Class44 @class = this.method_37();
		int num = @class.method_0();
		short int_;
		if (num <= 7)
		{
			if (num != 2)
			{
				if (num == 7)
				{
					if (bool_2)
					{
						int_ = checked((short)((Class54)@class).method_3());
						goto IL_173;
					}
					int_ = (short)((Class54)@class).method_3();
					goto IL_173;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((short)Convert.ToUInt64(((Class53)@class).method_3()));
					goto IL_173;
				}
				int_ = (short)Convert.ToUInt64(((Class53)@class).method_3());
				goto IL_173;
			}
		}
		else if (num != 8)
		{
			if (num != 15)
			{
				if (num == 22)
				{
					if (bool_2)
					{
						int_ = checked((short)((Class56)@class).method_3());
						goto IL_173;
					}
					int_ = (short)((Class56)@class).method_3();
					goto IL_173;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = checked((short)((int)((Class49)@class).method_3()));
					goto IL_173;
				}
				int_ = (short)((int)((Class49)@class).method_3());
				goto IL_173;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((short)((long)((Class49)@class).method_3()));
					goto IL_173;
				}
				int_ = (short)((long)((Class49)@class).method_3());
				goto IL_173;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((short)((Class58)@class).method_3());
				goto IL_173;
			}
			int_ = (short)((Class58)@class).method_3();
			goto IL_173;
		}
		throw new InvalidOperationException();
		IL_173:
		Class54 class2 = new Class54();
		class2.method_4((int)int_);
		this.method_22(class2);
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00006F0C File Offset: 0x0000510C
	private void method_21(bool bool_2)
	{
		Class44 class44_ = this.method_37();
		Class44 class44_2 = this.method_37();
		this.method_22(Class27.smethod_240(class44_2, class44_, bool_2));
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00006F38 File Offset: 0x00005138
	private void method_22(Class44 class44_4)
	{
		if (class44_4 == null)
		{
			throw new ArgumentNullException("obj");
		}
		Class44 @class;
		if (class44_4.method_1() != null)
		{
			@class = class44_4;
		}
		else
		{
			int num = class44_4.method_0();
			if (num != 3)
			{
				switch (num)
				{
				case 12:
				{
					Class54 class2 = new Class54((int)((Class69)class44_4).method_3());
					class2.method_2(class44_4.method_1());
					@class = class2;
					break;
				}
				default:
					@class = class44_4;
					break;
				case 14:
				{
					Class54 class3 = new Class54(((Class52)class44_4).method_3() ? 1 : 0);
					class3.method_2(class44_4.method_1());
					@class = class3;
					break;
				}
				case 16:
				{
					Class54 class4 = new Class54((int)((Class47)class44_4).method_3());
					class4.method_2(class44_4.method_1());
					@class = class4;
					break;
				}
				case 17:
				{
					object obj = class44_4.vmethod_0();
					if (obj == null)
					{
						@class = class44_4;
					}
					else
					{
						Type type = obj.GetType();
						if (type.HasElementType && !type.IsArray)
						{
							type = type.GetElementType();
						}
						if (type != null && !type.IsValueType && !type.IsEnum)
						{
							@class = class44_4;
						}
						else
						{
							@class = Class44.smethod_0(obj, type);
						}
					}
					break;
				}
				case 19:
				{
					Class54 class5 = new Class54((int)((Class59)class44_4).method_3());
					class5.method_2(class44_4.method_1());
					@class = class5;
					break;
				}
				case 20:
				{
					Class54 class6 = new Class54((int)((Class60)class44_4).method_3());
					class6.method_2(class44_4.method_1());
					@class = class6;
					break;
				}
				case 24:
				{
					Class58 class7 = new Class58();
					class7.method_4((double)((Class57)class44_4).method_3());
					class7.method_2(class44_4.method_1());
					@class = class7;
					break;
				}
				case 25:
				{
					Class56 class8 = new Class56((long)((Class68)class44_4).method_3());
					class8.method_2(class44_4.method_1());
					@class = class8;
					break;
				}
				case 26:
				{
					Class54 class9 = new Class54((int)((Class48)class44_4).method_3());
					class9.method_2(class44_4.method_1());
					@class = class9;
					break;
				}
				}
			}
			else
			{
				Class54 class10 = new Class54((int)((Class45)class44_4).method_3());
				class10.method_2(class44_4.method_1());
				@class = class10;
			}
		}
		if (this.class44_2 != null)
		{
			if (this.class44_3 != null)
			{
				this.stack_2.Push(this.class44_3);
			}
			this.class44_3 = this.class44_2;
		}
		this.class44_2 = @class;
	}

	// Token: 0x0600014E RID: 334 RVA: 0x000071A8 File Offset: 0x000053A8
	private bool method_23(Class44 class44_4, Type type_9)
	{
		object obj = class44_4.vmethod_0();
		if (obj == null)
		{
			return true;
		}
		Type type = class44_4.method_1() ?? obj.GetType();
		if (type != type_9 && !type_9.IsAssignableFrom(type))
		{
			if (!type.IsValueType && !type_9.IsValueType)
			{
				if (Marshal.IsComObject(obj))
				{
					IntPtr intPtr = IntPtr.Zero;
					try
					{
						intPtr = Marshal.GetComInterfaceForObject(obj, type_9);
					}
					catch (ArgumentException ex)
					{
					}
					catch (InvalidCastException ex2)
					{
					}
					if (intPtr != IntPtr.Zero)
					{
						try
						{
							Marshal.Release(intPtr);
						}
						catch (object obj2)
						{
						}
						return true;
					}
				}
				else if (Class27.smethod_229(obj))
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x0000728C File Offset: 0x0000548C
	private long method_24()
	{
		return this.class79_1.method_0().vmethod_4() + this.long_0;
	}

	// Token: 0x06000150 RID: 336 RVA: 0x000072A8 File Offset: 0x000054A8
	private static void smethod_47(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		FieldInfo fieldInfo_ = class27_0.method_27(int_);
		class27_0.method_22(new Class62(fieldInfo_, null));
	}

	// Token: 0x06000151 RID: 337 RVA: 0x000072D8 File Offset: 0x000054D8
	private static Class44 smethod_48(Class44 class44_4, Class44 class44_5, bool bool_2)
	{
		if (!bool_2)
		{
			long num = ((Class56)class44_4).method_3();
			long num2 = ((Class56)class44_5).method_3();
			return new Class56(num / num2);
		}
		long num3 = ((Class56)class44_4).method_3();
		ulong num4 = (ulong)((Class56)class44_5).method_3();
		return new Class56(num3 / (long)num4);
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00007328 File Offset: 0x00005528
	private static void smethod_49(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		Class44 class44_6 = class27_0.method_37();
		class27_0.method_22(class27_0.method_42(class44_6, class44_5));
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00007354 File Offset: 0x00005554
	private bool method_25(MethodBase methodBase_0)
	{
		return methodBase_0.IsVirtual && this.method_80(this.class10_0.method_6(), true).IsSubclassOf(methodBase_0.DeclaringType);
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00007384 File Offset: 0x00005584
	private bool method_26(Type type_9, Class93 class93_0, out int int_0)
	{
		int_0 = 0;
		Class1 @class = (Class1)class93_0.method_4();
		if (Class115.smethod_1(type_9).IsGenericParameter)
		{
			return @class == null || @class.method_2();
		}
		Type type = this.method_80(class93_0.method_2(), false);
		return Class77.smethod_0(type_9, type, out int_0);
	}

	// Token: 0x06000155 RID: 341 RVA: 0x000073D8 File Offset: 0x000055D8
	private static Class27.Delegate0 smethod_50(Class27.Struct2 struct2_0)
	{
		Dictionary<Class27.Struct2, Class27.Delegate0> obj = Class27.dictionary_4;
		Class27.Delegate0 @delegate;
		lock (obj)
		{
			Class27.dictionary_4.TryGetValue(struct2_0, out @delegate);
		}
		if (@delegate != null)
		{
			return @delegate;
		}
		MethodBase methodBase = struct2_0.method_0();
		Dictionary<MethodBase, object> obj2 = Class27.dictionary_1;
		lock (obj2)
		{
			while (Class27.dictionary_1.ContainsKey(methodBase))
			{
				Monitor.Wait(Class27.dictionary_1);
			}
			Class27.dictionary_1[methodBase] = null;
		}
		Class27.Delegate0 result;
		try
		{
			obj = Class27.dictionary_4;
			lock (obj)
			{
				Class27.dictionary_4.TryGetValue(struct2_0, out @delegate);
			}
			if (@delegate == null)
			{
				@delegate = Class27.smethod_38(methodBase, struct2_0.method_1());
				obj = Class27.dictionary_4;
				lock (obj)
				{
					Class27.dictionary_4[struct2_0] = @delegate;
				}
			}
			result = @delegate;
		}
		finally
		{
			obj2 = Class27.dictionary_1;
			lock (obj2)
			{
				Class27.dictionary_1.Remove(methodBase);
				Monitor.PulseAll(Class27.dictionary_1);
			}
		}
		return result;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00007528 File Offset: 0x00005728
	private FieldInfo method_27(int int_0)
	{
		Dictionary<int, object> obj = Class27.dictionary_3;
		FieldInfo result;
		lock (obj)
		{
			bool flag = true;
			object obj2;
			FieldInfo fieldInfo;
			if (Class27.dictionary_3.TryGetValue(int_0, out obj2))
			{
				fieldInfo = (FieldInfo)obj2;
			}
			else
			{
				Class93 class93_ = this.method_50(int_0);
				fieldInfo = this.method_106(int_0, class93_, ref flag);
				if (flag)
				{
					Class27.dictionary_3.Add(int_0, fieldInfo);
				}
			}
			this.method_87(fieldInfo);
			result = fieldInfo;
		}
		return result;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x000075A4 File Offset: 0x000057A4
	private static void smethod_51(Class27 class27_0, Class44 class44_4)
	{
		Class54 @class = (Class54)class44_4;
		MethodBase methodBase_ = class27_0.method_40(@class.method_3());
		Class55 class2 = new Class55();
		class2.method_4(methodBase_);
		class27_0.method_22(class2);
	}

	// Token: 0x06000158 RID: 344 RVA: 0x000075D8 File Offset: 0x000057D8
	private static void smethod_52(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Type type = class27_0.method_80(int_, true);
		Class61 @class = (Class61)class27_0.method_37();
		if (!type.IsValueType)
		{
			class27_0.method_5(@class, new Class51());
			return;
		}
		object obj = class27_0.method_83(@class).vmethod_0();
		if (Class115.smethod_0(type))
		{
			Class61 class61_ = @class;
			Class51 class2 = new Class51();
			class2.method_2(type);
			class27_0.method_5(class61_, class2);
			return;
		}
		foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy))
		{
			fieldInfo.SetValue(obj, Class27.smethod_10(fieldInfo.FieldType));
		}
	}

	// Token: 0x06000159 RID: 345 RVA: 0x0000768C File Offset: 0x0000588C
	private static void smethod_53(Class27 class27_0, Class44 class44_4)
	{
		throw new NotSupportedException("Cpblk not supported.");
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00007698 File Offset: 0x00005898
	private static void smethod_54(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_91(false);
	}

	// Token: 0x0600015B RID: 347 RVA: 0x000076A4 File Offset: 0x000058A4
	private static void smethod_55(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_74(typeof(sbyte));
	}

	// Token: 0x0600015C RID: 348 RVA: 0x000076B8 File Offset: 0x000058B8
	private static void smethod_56(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_29(3);
	}

	// Token: 0x0600015D RID: 349 RVA: 0x000076C4 File Offset: 0x000058C4
	private void method_28(int int_0)
	{
		this.method_22(this.class44_0[int_0].vmethod_3());
	}

	// Token: 0x0600015E RID: 350 RVA: 0x000076E0 File Offset: 0x000058E0
	private void method_29(int int_0)
	{
		this.method_22(this.class44_1[int_0].vmethod_3());
	}

	// Token: 0x0600015F RID: 351 RVA: 0x000076FC File Offset: 0x000058FC
	private static void smethod_57(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		Class44 class44_6 = class27_0.method_37();
		class27_0.method_22(new Class54(Class27.smethod_111(class44_6, class44_5) ? 1 : 0));
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00007730 File Offset: 0x00005930
	private static void smethod_58(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_91(true);
	}

	// Token: 0x06000161 RID: 353 RVA: 0x0000773C File Offset: 0x0000593C
	private static void smethod_59(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_14(true);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00007748 File Offset: 0x00005948
	private static void smethod_60(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Type type_ = class27_0.method_80(int_, true);
		class27_0.method_74(type_);
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00007774 File Offset: 0x00005974
	[Conditional("DEBUG")]
	private void method_30(object object_3)
	{
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00007778 File Offset: 0x00005978
	private static void smethod_61(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_21(true);
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00007784 File Offset: 0x00005984
	private bool method_31(MethodInfo methodInfo_0, Class4 class4_0, Type[] type_9, out int int_0)
	{
		int_0 = 0;
		if (!methodInfo_0.IsGenericMethodDefinition)
		{
			return false;
		}
		ParameterInfo[] parameters = methodInfo_0.GetParameters();
		if (parameters.Length != class4_0.method_8().Length)
		{
			return false;
		}
		if (methodInfo_0.GetGenericArguments().Length != class4_0.method_10().Length)
		{
			return false;
		}
		for (int i = -1; i < parameters.Length; i++)
		{
			Type type = (i == -1) ? methodInfo_0.ReturnType : parameters[i].ParameterType;
			if (type_9 != null && type.IsGenericParameter && type.DeclaringMethod != null)
			{
				type = (type_9[type.GenericParameterPosition] ?? type);
			}
			Class93 @class = (i == -1) ? class4_0.method_12() : class4_0.method_8()[i];
			if (@class != null)
			{
				int num;
				if (!this.method_26(type, @class, out num))
				{
					return false;
				}
				if (i >= 0)
				{
					int_0 += num;
				}
			}
		}
		return true;
	}

	// Token: 0x06000166 RID: 358 RVA: 0x0000788C File Offset: 0x00005A8C
	private static void smethod_62(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_16(Class115.type_0);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0000789C File Offset: 0x00005A9C
	private static void smethod_63(Class27 class27_0, Class44 class44_4)
	{
		throw new NotSupportedException("Localloc not supported.");
	}

	// Token: 0x06000168 RID: 360 RVA: 0x000078A8 File Offset: 0x00005AA8
	private static void smethod_64(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		class27_0.method_22(class27_0.method_82(class44_5));
	}

	// Token: 0x06000169 RID: 361 RVA: 0x000078CC File Offset: 0x00005ACC
	private void method_32(bool bool_2)
	{
		Class44 @class = this.method_37();
		int num = @class.method_0();
		ulong long_;
		if (num <= 7)
		{
			if (num != 2)
			{
				if (num == 7)
				{
					if (bool_2)
					{
						long_ = (ulong)(checked((uint)((Class54)@class).method_3()));
						goto IL_171;
					}
					long_ = (ulong)((Class54)@class).method_3();
					goto IL_171;
				}
			}
			else
			{
				if (bool_2)
				{
					long_ = Convert.ToUInt64(((Class53)@class).method_3());
					goto IL_171;
				}
				long_ = Convert.ToUInt64(((Class53)@class).method_3());
				goto IL_171;
			}
		}
		else if (num != 8)
		{
			if (num != 15)
			{
				if (num == 22)
				{
					if (bool_2)
					{
						long_ = checked((ulong)((Class56)@class).method_3());
						goto IL_171;
					}
					long_ = (ulong)((Class56)@class).method_3();
					goto IL_171;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					long_ = (ulong)(checked((uint)((int)((Class49)@class).method_3())));
					goto IL_171;
				}
				long_ = (ulong)((int)((Class49)@class).method_3());
				goto IL_171;
			}
			else
			{
				if (bool_2)
				{
					long_ = checked((ulong)((long)((Class49)@class).method_3()));
					goto IL_171;
				}
				long_ = (ulong)((long)((Class49)@class).method_3());
				goto IL_171;
			}
		}
		else
		{
			if (bool_2)
			{
				long_ = checked((ulong)((Class58)@class).method_3());
				goto IL_171;
			}
			long_ = (ulong)((Class58)@class).method_3();
			goto IL_171;
		}
		throw new InvalidOperationException();
		IL_171:
		this.method_22(new Class56((long)long_));
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00007A58 File Offset: 0x00005C58
	private static void smethod_65(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		Class44 @class = class27_0.method_37();
		bool flag;
		if (@class.method_0() == 8)
		{
			flag = !Class27.smethod_149(@class, class44_5);
		}
		else
		{
			flag = !Class27.smethod_111(@class, class44_5);
		}
		if (flag)
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00007AAC File Offset: 0x00005CAC
	private static void smethod_66(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_73(typeof(float));
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00007AC0 File Offset: 0x00005CC0
	private static void smethod_67(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Type type_ = class27_0.method_80(int_, true);
		class27_0.method_16(type_);
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00007AEC File Offset: 0x00005CEC
	private static void smethod_68(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_22(class44_4);
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00007AF8 File Offset: 0x00005CF8
	private Class44 method_33(Class44 class44_4, Class44 class44_5)
	{
		if (class44_4.method_0() == 7)
		{
			if (class44_5.method_0() == 7)
			{
				int num = ((Class54)class44_4).method_3();
				int num2 = ((Class54)class44_5).method_3();
				return new Class54(num | num2);
			}
			if (class44_5.method_0() == 2)
			{
				int num3 = ((Class54)class44_4).method_3();
				Type underlyingType = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
				if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
				{
					long num4 = Convert.ToInt64(class44_5.vmethod_0());
					return new Class56((long)num3 | num4);
				}
				int num5 = Convert.ToInt32(class44_5.vmethod_0());
				return new Class54(num3 | num5);
			}
		}
		if (class44_4.method_0() == 22)
		{
			if (class44_5.method_0() == 22)
			{
				long num6 = ((Class56)class44_4).method_3();
				long num7 = ((Class56)class44_5).method_3();
				return new Class56(num6 | num7);
			}
			if (class44_5.method_0() == 2)
			{
				long num8 = (long)((Class54)class44_4).method_3();
				long num9 = Convert.ToInt64(class44_5.vmethod_0());
				return new Class56(num8 | num9);
			}
		}
		if (class44_4.method_0() == 2)
		{
			if (class44_5.method_0() == 7)
			{
				int num10 = ((Class54)class44_5).method_3();
				Type underlyingType2 = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return new Class56(Convert.ToInt64(class44_5.vmethod_0()) | (long)num10);
				}
				return new Class54(Convert.ToInt32(class44_4.vmethod_0()) | num10);
			}
			else
			{
				if (class44_5.method_0() == 22)
				{
					long num11 = Convert.ToInt64(class44_4.vmethod_0());
					long num12 = ((Class56)class44_5).method_3();
					return new Class56(num11 | num12);
				}
				if (class44_5.method_0() == 2)
				{
					Type underlyingType3 = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
					Type underlyingType4 = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
					if (underlyingType3 != typeof(long) && underlyingType3 != typeof(ulong) && underlyingType4 != typeof(long))
					{
						if (underlyingType4 != typeof(ulong))
						{
							int num13 = Convert.ToInt32(class44_4.vmethod_0());
							int num14 = Convert.ToInt32(class44_5.vmethod_0());
							return new Class54(num13 | num14);
						}
					}
					long num15 = Convert.ToInt64(class44_4.vmethod_0());
					long num16 = Convert.ToInt64(class44_5.vmethod_0());
					return new Class56(num15 | num16);
				}
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00007D94 File Offset: 0x00005F94
	private static void smethod_69(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		checked
		{
			byte int_;
			if (num <= 7)
			{
				if (num == 2)
				{
					int_ = (byte)Convert.ToUInt64(((Class53)@class).method_3());
					goto IL_D6;
				}
				if (num == 7)
				{
					int_ = (byte)((uint)((Class54)@class).method_3());
					goto IL_D6;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (byte)((Class58)@class).method_3();
					goto IL_D6;
				}
				if (num != 15)
				{
					if (num == 22)
					{
						int_ = (byte)((ulong)((Class56)@class).method_3());
						goto IL_D6;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (byte)((uint)((int)((Class49)@class).method_3()));
						goto IL_D6;
					}
					int_ = (byte)((ulong)((long)((Class49)@class).method_3()));
					goto IL_D6;
				}
			}
			throw new InvalidOperationException();
			IL_D6:
			class27_0.method_22(new Class54((int)int_));
		}
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00007E84 File Offset: 0x00006084
	private static void smethod_70(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_58(true, true);
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00007E90 File Offset: 0x00006090
	private static void smethod_71(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_74(typeof(long));
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00007EA4 File Offset: 0x000060A4
	private static void smethod_72(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		if (Class27.smethod_168(class27_0.method_37(), class44_5))
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00007EDC File Offset: 0x000060DC
	private static void smethod_73(Class27 class27_0, Class44 class44_4)
	{
		Class54 @class = (Class54)class44_4;
		MethodBase methodBase_ = class27_0.method_40(@class.method_3());
		foreach (Class44 class44_5 in class27_0.class44_1)
		{
			class27_0.method_22(class44_5);
		}
		class27_0.method_81(methodBase_, false);
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00007F34 File Offset: 0x00006134
	private static void smethod_74(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		UIntPtr uintptr_;
		if (num <= 7)
		{
			if (num == 2)
			{
				uintptr_ = new UIntPtr(Convert.ToUInt64(((Class53)@class).method_3()));
				goto IL_A4;
			}
			if (num == 7)
			{
				uintptr_ = new UIntPtr((uint)((Class54)@class).method_3());
				goto IL_A4;
			}
		}
		else
		{
			if (num == 8)
			{
				uintptr_ = new UIntPtr((ulong)((Class58)@class).method_3());
				goto IL_A4;
			}
			if (num == 22)
			{
				uintptr_ = new UIntPtr((ulong)((Class56)@class).method_3());
				goto IL_A4;
			}
		}
		throw new InvalidOperationException();
		IL_A4:
		Class50 class2 = new Class50();
		class2.method_4(uintptr_);
		class27_0.method_22(class2);
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00007FF8 File Offset: 0x000061F8
	private static void smethod_75(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_16(typeof(int));
	}

	// Token: 0x06000176 RID: 374 RVA: 0x0000800C File Offset: 0x0000620C
	private static void smethod_76(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_28(1);
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00008018 File Offset: 0x00006218
	private void method_34(Type type_9, object object_3, long long_1, Array array_0)
	{
		Class44 @class = Class44.smethod_0(object_3, type_9);
		array_0.SetValue(@class.vmethod_0(), long_1);
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0000803C File Offset: 0x0000623C
	private static void smethod_77(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_29((int)((Class48)class44_4).method_3());
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00008050 File Offset: 0x00006250
	private static void smethod_78(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_22(class44_4);
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0000805C File Offset: 0x0000625C
	private static void smethod_79(Class27 class27_0, Class44 class44_4)
	{
		Class48 @class = (Class48)class44_4;
		class27_0.method_96((int)@class.method_3());
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0000807C File Offset: 0x0000627C
	private static void smethod_80(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_98((int)((Class69)class44_4).method_3());
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00008090 File Offset: 0x00006290
	private long method_35(string string_0)
	{
		MemoryStream memoryStream = new MemoryStream(Class117.smethod_0(string_0));
		long result = new Class79(new Class42(memoryStream, this.method_79())).method_21();
		memoryStream.Dispose();
		return result;
	}

	// Token: 0x0600017D RID: 381 RVA: 0x000080C8 File Offset: 0x000062C8
	private static void smethod_81(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_15();
		class27_0.method_22(@class.vmethod_3());
	}

	// Token: 0x0600017E RID: 382 RVA: 0x000080E8 File Offset: 0x000062E8
	private static void smethod_82(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_74(typeof(ushort));
	}

	// Token: 0x0600017F RID: 383 RVA: 0x000080FC File Offset: 0x000062FC
	private static void smethod_83(Class27 class27_0, Class44 class44_4)
	{
		Array array = (Array)class27_0.method_37().vmethod_0();
		class27_0.method_22(new Class54(array.Length));
	}

	// Token: 0x06000180 RID: 384 RVA: 0x0000812C File Offset: 0x0000632C
	private static void smethod_84(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Type elementType = class27_0.method_80(int_, true);
		Class44 @class = class27_0.method_37();
		Class54 class2 = @class as Class54;
		int length;
		if (class2 != null)
		{
			length = class2.method_3();
		}
		else
		{
			Class49 class3 = @class as Class49;
			if (class3 != null)
			{
				length = class3.method_3().ToInt32();
			}
			else
			{
				Class50 class4 = @class as Class50;
				if (class4 == null)
				{
					throw new Exception();
				}
				length = (int)class4.method_3().ToUInt32();
			}
		}
		Array array_ = Array.CreateInstance(elementType, length);
		Class70 class5 = new Class70();
		class5.method_4(array_);
		class27_0.method_22(class5);
	}

	// Token: 0x06000181 RID: 385 RVA: 0x000081C8 File Offset: 0x000063C8
	private static void smethod_85(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_51();
	}

	// Token: 0x06000182 RID: 386 RVA: 0x000081D0 File Offset: 0x000063D0
	private Class44 method_36(Class44 class44_4)
	{
		if (class44_4.method_0() == 7)
		{
			int num = ((Class54)class44_4).method_3();
			Class54 @class = new Class54();
			@class.method_4(~num);
			return @class;
		}
		if (class44_4.method_0() == 22)
		{
			long num2 = ((Class56)class44_4).method_3();
			Class56 class2 = new Class56();
			class2.method_4(~num2);
			return class2;
		}
		if (class44_4.method_0() != 2)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
		if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
		{
			return new Class56(~Convert.ToInt64(class44_4.vmethod_0()));
		}
		return new Class54(~Convert.ToInt32(class44_4.vmethod_0()));
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00008294 File Offset: 0x00006494
	private static void smethod_86(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		if (Class27.smethod_130(class27_0.method_37(), class44_5))
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x06000184 RID: 388 RVA: 0x000082CC File Offset: 0x000064CC
	private static void smethod_87(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_29((int)((Class69)class44_4).method_3());
	}

	// Token: 0x06000185 RID: 389 RVA: 0x000082E0 File Offset: 0x000064E0
	private Class44 method_37()
	{
		Class44 @class = this.class44_2;
		if (@class != null)
		{
			this.class44_2 = this.class44_3;
			this.class44_3 = null;
			return @class;
		}
		return this.stack_2.Pop();
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00008318 File Offset: 0x00006518
	private static void smethod_88(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_71(2);
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00008324 File Offset: 0x00006524
	private static void smethod_89(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		if (@class.method_0() != 7)
		{
			throw new InvalidOperationException();
		}
		int num = ((Class54)@class).method_3();
		Stack<Class27.Class28> stack = class27_0.method_77();
		if (stack.Count < 2)
		{
			throw new InvalidOperationException();
		}
		using (Class27.Class28 class2 = stack.Pop())
		{
			if (class2 == null || class2.class105_0.imethod_0() != num)
			{
				throw new InvalidOperationException();
			}
			Class27.Class28 class28_ = stack.Peek();
			class27_0.method_67(class28_);
			class27_0.uint_0 += (uint)class2.class105_0.method_3();
			class27_0.method_101((long)((ulong)class27_0.uint_0));
		}
	}

	// Token: 0x06000188 RID: 392 RVA: 0x000083F4 File Offset: 0x000065F4
	private static Class44 smethod_90(Class44 class44_4, Class44 class44_5, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class56)class44_4).method_3();
			long num2 = ((Class56)class44_5).method_3();
			long long_;
			if (bool_2)
			{
				long_ = checked(num + num2);
			}
			else
			{
				long_ = num + num2;
			}
			return new Class56(long_);
		}
		ulong num3 = (ulong)((Class56)class44_4).method_3();
		ulong num4 = (ulong)((Class56)class44_5).method_3();
		ulong long_2;
		if (bool_2)
		{
			long_2 = checked(num3 + num4);
		}
		else
		{
			long_2 = num3 + num4;
		}
		return new Class56((long)long_2);
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00008464 File Offset: 0x00006664
	private static void smethod_91(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_71(0);
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00008470 File Offset: 0x00006670
	private static Class44 smethod_92(Class44 class44_4, Class44 class44_5, bool bool_2, bool bool_3)
	{
		if (class44_4.method_0() == 7)
		{
			if (class44_5.method_0() == 7)
			{
				if (!bool_3)
				{
					int num = ((Class54)class44_4).method_3();
					int num2 = ((Class54)class44_5).method_3();
					int int_;
					if (bool_2)
					{
						int_ = checked(num + num2);
					}
					else
					{
						int_ = num + num2;
					}
					return new Class54(int_);
				}
				uint num3 = (uint)((Class54)class44_4).method_3();
				uint num4 = (uint)((Class54)class44_5).method_3();
				uint int_2;
				if (bool_2)
				{
					int_2 = checked(num3 + num4);
				}
				else
				{
					int_2 = num3 + num4;
				}
				return new Class54((int)int_2);
			}
			else
			{
				if (class44_5.method_0() == 22)
				{
					return Class27.smethod_90(new Class56((long)((Class54)class44_4).method_3()), class44_5, bool_2, bool_3);
				}
				if (class44_5.method_0() == 2)
				{
					Type underlyingType = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
					if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
					{
						return Class27.smethod_90(new Class56((long)((Class54)class44_4).method_3()), new Class56(Convert.ToInt64(class44_5.vmethod_0())), bool_2, bool_3);
					}
					return Class27.smethod_92(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2, bool_3);
				}
			}
		}
		if (class44_4.method_0() == 22)
		{
			if (class44_5.method_0() == 22)
			{
				return Class27.smethod_90(class44_4, class44_5, bool_2, bool_3);
			}
			if (class44_5.method_0() == 7)
			{
				return Class27.smethod_90(class44_4, new Class56((long)((Class54)class44_5).method_3()), bool_2, bool_3);
			}
			if (class44_5.method_0() == 2)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return Class27.smethod_90(class44_4, new Class56(Convert.ToInt64(class44_5.vmethod_0())), bool_2, bool_3);
				}
				return Class27.smethod_90(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class44_4.method_0() == 8 && class44_5.method_0() == 8)
		{
			Class58 @class = new Class58();
			@class.method_4(((Class58)class44_4).method_3() + ((Class58)class44_5).method_3());
			return @class;
		}
		if (class44_4.method_0() != 2)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType3 = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
		if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong))
		{
			return Class27.smethod_92(new Class56(Convert.ToInt64(class44_4.vmethod_0())), class44_5, bool_2, bool_3);
		}
		return Class27.smethod_92(new Class54(Convert.ToInt32(class44_4.vmethod_0())), class44_5, bool_2, bool_3);
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00008724 File Offset: 0x00006924
	private static void smethod_93(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_20(false);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00008730 File Offset: 0x00006930
	private static void smethod_94(Class27 class27_0, Class44 class44_4)
	{
		throw new NotSupportedException("Mkrefany is not supported.");
	}

	// Token: 0x0600018D RID: 397 RVA: 0x0000873C File Offset: 0x0000693C
	private static void smethod_95(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_10(true, false);
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00008748 File Offset: 0x00006948
	private static void smethod_96(Class27 class27_0, Class44 class44_4)
	{
		throw new NotSupportedException("Refanytype is not supported.");
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00008754 File Offset: 0x00006954
	private static void smethod_97(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_97(class44_4);
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00008760 File Offset: 0x00006960
	private static void smethod_98(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_28(3);
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0000876C File Offset: 0x0000696C
	private Class37 method_38(Class79 class79_2)
	{
		Class37 @class = new Class37();
		@class.method_1(class79_2.method_19());
		return @class;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00008780 File Offset: 0x00006980
	private static void smethod_99(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_17(true, false);
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0000878C File Offset: 0x0000698C
	private void method_39(Stream stream_1, long long_1, string string_0)
	{
		int int_ = this.method_13();
		Class42 class41_ = new Class42(stream_1, int_);
		this.class79_0 = new Class79(class41_);
		if (string_0 != null)
		{
			long_1 = this.method_35(string_0);
		}
		Class41 @class = this.class79_0.method_0();
		Class41 obj = @class;
		lock (obj)
		{
			@class.vmethod_9(long_1, 0);
			this.method_18(this.class79_0);
			this.class10_0 = this.method_7(this.class79_0);
			this.class125_0 = Class27.smethod_176(this.class79_0);
			this.byte_0 = Class27.smethod_125(this.class79_0);
		}
		this.method_84();
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00008840 File Offset: 0x00006A40
	private static void smethod_100(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_74(typeof(float));
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00008854 File Offset: 0x00006A54
	private static void smethod_101(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_29(1);
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00008860 File Offset: 0x00006A60
	private MethodBase method_40(int int_0)
	{
		Class93 class93_ = this.method_50(int_0);
		MethodBase methodBase = this.method_63(int_0, class93_);
		this.method_87(methodBase);
		return methodBase;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00008888 File Offset: 0x00006A88
	private void method_41(int int_0)
	{
		Class63 @class = new Class63();
		@class.method_4(int_0);
		this.method_22(@class);
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0000889C File Offset: 0x00006A9C
	private static void smethod_102(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_74(typeof(double));
	}

	// Token: 0x06000199 RID: 409 RVA: 0x000088B0 File Offset: 0x00006AB0
	private Class44 method_42(Class44 class44_4, Class44 class44_5)
	{
		if (class44_4.method_0() == 7)
		{
			if (class44_5.method_0() == 7)
			{
				int num = ((Class54)class44_4).method_3();
				int num2 = ((Class54)class44_5).method_3();
				return new Class54(num ^ num2);
			}
			if (class44_5.method_0() == 2)
			{
				int num3 = ((Class54)class44_4).method_3();
				Type underlyingType = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
				if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
				{
					long num4 = Convert.ToInt64(class44_5.vmethod_0());
					return new Class56((long)num3 ^ num4);
				}
				int num5 = Convert.ToInt32(class44_5.vmethod_0());
				return new Class54(num3 ^ num5);
			}
		}
		if (class44_4.method_0() == 22)
		{
			if (class44_5.method_0() == 22)
			{
				long num6 = ((Class56)class44_4).method_3();
				long num7 = ((Class56)class44_5).method_3();
				return new Class56(num6 ^ num7);
			}
			if (class44_5.method_0() == 2)
			{
				long num8 = (long)((Class54)class44_4).method_3();
				long num9 = Convert.ToInt64(class44_5.vmethod_0());
				return new Class56(num8 ^ num9);
			}
		}
		if (class44_4.method_0() == 2)
		{
			if (class44_5.method_0() == 7)
			{
				int num10 = ((Class54)class44_5).method_3();
				Type underlyingType2 = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return new Class56(Convert.ToInt64(class44_5.vmethod_0()) ^ (long)num10);
				}
				return new Class54(Convert.ToInt32(class44_4.vmethod_0()) ^ num10);
			}
			else
			{
				if (class44_5.method_0() == 22)
				{
					long num11 = Convert.ToInt64(class44_4.vmethod_0());
					long num12 = ((Class56)class44_5).method_3();
					return new Class56(num11 ^ num12);
				}
				if (class44_5.method_0() == 2)
				{
					Type underlyingType3 = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
					Type underlyingType4 = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
					if (underlyingType3 != typeof(long) && underlyingType3 != typeof(ulong) && underlyingType4 != typeof(long))
					{
						if (underlyingType4 != typeof(ulong))
						{
							int num13 = Convert.ToInt32(class44_4.vmethod_0());
							int num14 = Convert.ToInt32(class44_5.vmethod_0());
							return new Class54(num13 ^ num14);
						}
					}
					long num15 = Convert.ToInt64(class44_4.vmethod_0());
					long num16 = Convert.ToInt64(class44_5.vmethod_0());
					return new Class56(num15 ^ num16);
				}
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00008B4C File Offset: 0x00006D4C
	private bool method_43(MethodBase methodBase_0, object object_3, ref object object_4, object[] object_5)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (Class115.smethod_0(declaringType))
		{
			if (string.Equals(methodBase_0.Name, "get_HasValue", StringComparison.Ordinal))
			{
				object_4 = (object_3 != null);
			}
			else if (string.Equals(methodBase_0.Name, "get_Value", StringComparison.Ordinal))
			{
				if (object_3 == null)
				{
					return ((bool?)null).Value;
				}
				object_4 = object_3;
			}
			else if (methodBase_0.Name.Equals("GetValueOrDefault", StringComparison.Ordinal))
			{
				if (object_3 == null)
				{
					object_4 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
				}
				object_4 = object_3;
			}
			else
			{
				if (object_3 != null || methodBase_0.IsStatic)
				{
					return false;
				}
				object_4 = null;
			}
			return true;
		}
		if (declaringType == Class27.type_0)
		{
			if (methodBase_0.Name.Equals("GetExecutingAssembly", StringComparison.Ordinal))
			{
				object_4 = Class115.assembly_0;
				return true;
			}
			if (this.object_1 != null && methodBase_0.Name == "GetCallingAssembly")
			{
				object[] array = this.object_1;
				for (int i = 0; i < array.Length; i++)
				{
					Assembly assembly = array[i] as Assembly;
					if (assembly != null)
					{
						object_4 = assembly;
						return true;
					}
				}
			}
		}
		else if (declaringType == Class27.type_6)
		{
			if (methodBase_0.Name == "GetCurrentMethod")
			{
				if (this.object_1 != null)
				{
					object[] array = this.object_1;
					for (int i = 0; i < array.Length; i++)
					{
						MethodBase methodBase = array[i] as MethodBase;
						if (methodBase != null)
						{
							object_4 = methodBase;
							return true;
						}
					}
				}
				object_4 = MethodBase.GetCurrentMethod();
				return true;
			}
		}
		else if (declaringType.IsArray && declaringType.GetArrayRank() >= 2)
		{
			return this.method_69(methodBase_0, object_3, ref object_4, object_5);
		}
		return false;
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00008D30 File Offset: 0x00006F30
	private object method_44(Stream stream_1, int int_0, object[] object_3, Type[] type_9, Type[] type_10, object[] object_4)
	{
		this.stream_0 = stream_1;
		this.method_39(stream_1, (long)int_0, null);
		return this.method_54(object_3, type_9, type_10, object_4);
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00008D50 File Offset: 0x00006F50
	private void method_45(Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		MethodBase methodBase = this.method_40(int_);
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		int num = parameters.Length;
		object[] array = new object[num];
		Dictionary<int, Class61> dictionary = new Dictionary<int, Class61>();
		for (int i = num - 1; i >= 0; i--)
		{
			Class44 @class = this.method_37();
			Class61 class2 = @class as Class61;
			if (class2 != null)
			{
				dictionary.Add(i, class2);
				@class = this.method_83(class2);
			}
			if (@class.method_1() != null)
			{
				@class = Class44.smethod_0(null, @class.method_1()).vmethod_2(@class);
			}
			Class44 class3 = Class44.smethod_0(null, parameters[i].ParameterType).vmethod_2(@class);
			array[i] = class3.vmethod_0();
		}
		object obj;
		try
		{
			obj = Class27.smethod_2(methodBase, null, array, false);
		}
		catch (TargetInvocationException ex)
		{
			Exception object_ = ex.InnerException ?? ex;
			this.method_104(object_);
			return;
		}
		foreach (KeyValuePair<int, Class61> keyValuePair in dictionary)
		{
			this.method_5(keyValuePair.Value, Class44.smethod_0(array[keyValuePair.Key], null));
		}
		this.method_22(Class44.smethod_0(obj, declaringType));
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00008EA8 File Offset: 0x000070A8
	private static void smethod_103(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_22(class44_4);
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00008EB4 File Offset: 0x000070B4
	private static void smethod_104(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_107();
	}

	// Token: 0x0600019F RID: 415 RVA: 0x00008EBC File Offset: 0x000070BC
	private void method_46()
	{
		if (this.class10_0.method_12())
		{
			Type type;
			try
			{
				type = this.method_80(this.class10_0.method_6(), false);
			}
			catch (InvalidOperationException)
			{
				type = null;
			}
			if (type != null)
			{
				RuntimeHelpers.RunClassConstructor(type.TypeHandle);
			}
		}
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00008F10 File Offset: 0x00007110
	private static string smethod_105(string string_0, string string_1)
	{
		string fullName = typeof(Class27).Assembly.FullName;
		return string.Concat(new string[]
		{
			"Attempt by ",
			string_0,
			" to access ",
			string_1,
			" failed.",
			Environment.NewLine,
			Environment.NewLine,
			"Assembly '",
			fullName,
			"' is marked with the AllowPartiallyTrustedCallersAttribute, and uses the level 2 security transparency model. Level 2 transparency causes all methods in AllowPartiallyTrustedCallers assemblies to become security transparent by default, which may be the cause of this exception."
		});
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00008F84 File Offset: 0x00007184
	private static void smethod_106(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		checked
		{
			uint int_;
			if (num <= 7)
			{
				if (num == 2)
				{
					int_ = (uint)Convert.ToUInt64(((Class53)@class).method_3());
					goto IL_D2;
				}
				if (num == 7)
				{
					int_ = (uint)((Class54)@class).method_3();
					goto IL_D2;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (uint)((Class58)@class).method_3();
					goto IL_D2;
				}
				if (num != 15)
				{
					if (num == 22)
					{
						int_ = (uint)((ulong)((Class56)@class).method_3());
						goto IL_D2;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (uint)((int)((Class49)@class).method_3());
						goto IL_D2;
					}
					int_ = (uint)((ulong)((long)((Class49)@class).method_3()));
					goto IL_D2;
				}
			}
			throw new InvalidOperationException();
			IL_D2:
			class27_0.method_22(new Class54((int)int_));
		}
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00009070 File Offset: 0x00007270
	private static void smethod_107(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_51();
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00009078 File Offset: 0x00007278
	private static void smethod_108(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_62(true);
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00009084 File Offset: 0x00007284
	private static void smethod_109(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		checked
		{
			ushort int_;
			if (num <= 7)
			{
				if (num == 2)
				{
					int_ = (ushort)Convert.ToUInt64(((Class53)@class).method_3());
					goto IL_D6;
				}
				if (num == 7)
				{
					int_ = (ushort)((uint)((Class54)@class).method_3());
					goto IL_D6;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (ushort)((Class58)@class).method_3();
					goto IL_D6;
				}
				if (num != 15)
				{
					if (num == 22)
					{
						int_ = (ushort)((ulong)((Class56)@class).method_3());
						goto IL_D6;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (ushort)((uint)((int)((Class49)@class).method_3()));
						goto IL_D6;
					}
					int_ = (ushort)((ulong)((long)((Class49)@class).method_3()));
					goto IL_D6;
				}
			}
			throw new InvalidOperationException();
			IL_D6:
			class27_0.method_22(new Class54((int)int_));
		}
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00009174 File Offset: 0x00007374
	private static Class44 smethod_110(Class44 class44_4, Class44 class44_5, bool bool_2, bool bool_3)
	{
		if (class44_4.method_0() == 7)
		{
			if (class44_5.method_0() == 7)
			{
				if (!bool_3)
				{
					int num = ((Class54)class44_4).method_3();
					int num2 = ((Class54)class44_5).method_3();
					int int_;
					if (bool_2)
					{
						int_ = checked(num * num2);
					}
					else
					{
						int_ = num * num2;
					}
					return new Class54(int_);
				}
				uint num3 = (uint)((Class54)class44_4).method_3();
				uint num4 = (uint)((Class54)class44_5).method_3();
				uint int_2;
				if (bool_2)
				{
					int_2 = checked(num3 * num4);
				}
				else
				{
					int_2 = num3 * num4;
				}
				return new Class54((int)int_2);
			}
			else
			{
				if (class44_5.method_0() == 22)
				{
					return Class27.smethod_228(new Class56((long)((Class54)class44_4).method_3()), class44_5, bool_2, bool_3);
				}
				if (class44_5.method_0() == 2)
				{
					Type underlyingType = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
					if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
					{
						return Class27.smethod_228(new Class56((long)((Class54)class44_4).method_3()), new Class56(Convert.ToInt64(class44_5.vmethod_0())), bool_2, bool_3);
					}
					return Class27.smethod_110(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2, bool_3);
				}
			}
		}
		if (class44_4.method_0() == 22)
		{
			if (class44_5.method_0() == 22)
			{
				return Class27.smethod_228(class44_4, class44_5, bool_2, bool_3);
			}
			if (class44_5.method_0() == 7)
			{
				return Class27.smethod_228(class44_4, new Class56((long)((Class54)class44_5).method_3()), bool_2, bool_3);
			}
			if (class44_5.method_0() == 2)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return Class27.smethod_228(class44_4, new Class56(Convert.ToInt64(class44_5.vmethod_0())), bool_2, bool_3);
				}
				return Class27.smethod_228(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class44_4.method_0() == 8 && class44_5.method_0() == 8)
		{
			Class58 @class = new Class58();
			@class.method_4(((Class58)class44_4).method_3() * ((Class58)class44_5).method_3());
			return @class;
		}
		if (class44_4.method_0() != 2)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType3 = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
		if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong))
		{
			return Class27.smethod_110(new Class56(Convert.ToInt64(class44_4.vmethod_0())), class44_5, bool_2, bool_3);
		}
		return Class27.smethod_110(new Class54(Convert.ToInt32(class44_4.vmethod_0())), class44_5, bool_2, bool_3);
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x00009428 File Offset: 0x00007628
	private static bool smethod_111(Class44 class44_4, Class44 class44_5)
	{
		int num = class44_4.method_0();
		if (num <= 15)
		{
			switch (num)
			{
			case 2:
			{
				long num2 = Convert.ToInt64(((Class53)class44_4).method_3());
				long num3;
				if (class44_5.method_0() == 7)
				{
					num3 = (long)((Class54)class44_5).method_3();
				}
				else
				{
					num3 = Convert.ToInt64(((Class53)class44_5).method_3());
				}
				return num2 > num3;
			}
			case 3:
			case 4:
			case 5:
			case 9:
				break;
			case 6:
				if (class44_5.method_0() == 17 && class44_5.vmethod_0() == null)
				{
					return ((Class50)class44_4).method_3() != UIntPtr.Zero;
				}
				return ((Class50)class44_4).method_3() != ((Class50)class44_5).method_3();
			case 7:
				return ((Class54)class44_4).method_3() > ((Class54)class44_5).method_3();
			case 8:
			{
				double num4 = ((Class58)class44_4).method_3();
				double num5 = ((Class58)class44_5).method_3();
				return num4 > num5 || double.IsNaN(num4) || double.IsNaN(num5);
			}
			case 10:
				return (class44_5.method_0() == 17 && class44_5.vmethod_0() == null) || ((Class46)class44_4).method_3() != ((Class46)class44_5).method_3();
			default:
				if (num == 15)
				{
					if (class44_5.method_0() == 17 && class44_5.vmethod_0() == null)
					{
						return ((Class49)class44_4).method_3() != IntPtr.Zero;
					}
					return ((Class49)class44_4).method_3() != ((Class49)class44_5).method_3();
				}
				break;
			}
		}
		else
		{
			if (num == 17)
			{
				return ((Class51)class44_4).method_3() != ((Class51)class44_5).method_3();
			}
			if (num == 22)
			{
				return ((Class56)class44_4).method_3() > ((Class56)class44_5).method_3();
			}
		}
		return class44_4.vmethod_0() != class44_5.vmethod_0();
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00009678 File Offset: 0x00007878
	private object method_47(int int_0)
	{
		int num = Class90.smethod_0(int_0);
		object result;
		if (num > 67108864)
		{
			if (num <= 167772160)
			{
				if (num != 100663296)
				{
					if (num != 167772160)
					{
						goto IL_A5;
					}
					try
					{
						return this.module_0.ModuleHandle.ResolveFieldHandle(int_0);
					}
					catch
					{
						try
						{
							result = this.module_0.ModuleHandle.ResolveMethodHandle(int_0);
						}
						catch
						{
							throw new InvalidOperationException();
						}
						return result;
					}
				}
			}
			else
			{
				if (num == 452984832)
				{
					goto IL_115;
				}
				if (num != 721420288)
				{
					goto IL_A5;
				}
			}
			return this.module_0.ModuleHandle.ResolveMethodHandle(int_0);
		}
		if (num == 16777216 || num == 33554432)
		{
			goto IL_115;
		}
		if (num == 67108864)
		{
			return this.module_0.ModuleHandle.ResolveFieldHandle(int_0);
		}
		IL_A5:
		throw new InvalidOperationException();
		IL_115:
		result = this.module_0.ModuleHandle.ResolveTypeHandle(int_0);
		return result;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x000097D4 File Offset: 0x000079D4
	private void method_48()
	{
		if (this.stack_1.Count == 0)
		{
			if (this.bool_1)
			{
				this.method_104(this.object_0);
			}
			return;
		}
		Class27.Struct3 @struct = this.stack_1.Pop();
		if (@struct.method_1() != null)
		{
			Class51 @class = new Class51();
			@class.vmethod_1(@struct.method_1());
			this.method_22(@class);
		}
		else
		{
			this.method_49();
		}
		this.method_60(@struct.method_0());
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00009848 File Offset: 0x00007A48
	private void method_49()
	{
		this.class44_2 = null;
		this.class44_3 = null;
		this.stack_2.Clear();
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00009864 File Offset: 0x00007A64
	private static void smethod_112(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		string string_ = class27_0.method_57(int_);
		Class71 @class = new Class71();
		@class.method_4(string_);
		class27_0.method_22(@class);
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00009898 File Offset: 0x00007A98
	private static void smethod_113(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_29(2);
	}

	// Token: 0x060001AC RID: 428 RVA: 0x000098A4 File Offset: 0x00007AA4
	private static void smethod_114(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_71(7);
	}

	// Token: 0x060001AD RID: 429 RVA: 0x000098B0 File Offset: 0x00007AB0
	private static void smethod_115(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_71(8);
	}

	// Token: 0x060001AE RID: 430 RVA: 0x000098BC File Offset: 0x00007ABC
	private static Class105 smethod_116(Class27 class27_0)
	{
		Class44 @class = class27_0.method_37();
		Class44 class2 = class27_0.method_37();
		Class44 class3 = class27_0.method_37();
		if (@class.method_0() != 22)
		{
			throw new InvalidOperationException();
		}
		long long_ = ((Class56)@class).method_3();
		int num = class2.method_0();
		if (num != 0 && num != 17)
		{
			throw new InvalidOperationException();
		}
		byte[] byte_ = Class16.smethod_3(class2.vmethod_0());
		if (class3.method_0() != 7)
		{
			throw new InvalidOperationException();
		}
		int int_ = ((Class54)class3).method_3();
		Class105 class4 = new Class105();
		class4.method_0(int_);
		class4.method_1(byte_);
		class4.method_2(long_);
		return class4;
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00009964 File Offset: 0x00007B64
	private static void smethod_117(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		Class44 class44_6 = class27_0.method_37();
		class27_0.method_22(class27_0.method_92(class44_6, class44_5));
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00009990 File Offset: 0x00007B90
	private static Exception smethod_118(string string_0, string string_1)
	{
		return new FieldAccessException(Class27.smethod_105("security transparent method '" + string_0 + "'", "security critical field '" + string_1 + "'"));
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x000099BC File Offset: 0x00007BBC
	private static void smethod_119(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_9(true);
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x000099C8 File Offset: 0x00007BC8
	private static void smethod_120(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_86(true);
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x000099D4 File Offset: 0x00007BD4
	private static void smethod_121(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_10(true, true);
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x000099E0 File Offset: 0x00007BE0
	private static void smethod_122(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		double double_;
		if (num <= 7)
		{
			if (num == 2)
			{
				double_ = Convert.ToUInt64(((Class53)@class).method_3());
				goto IL_8F;
			}
			if (num == 7)
			{
				double_ = (double)((Class54)@class).method_3();
				goto IL_8F;
			}
		}
		else
		{
			if (num == 8)
			{
				double_ = ((Class58)@class).method_3();
				goto IL_8F;
			}
			if (num == 22)
			{
				double_ = (double)((Class56)@class).method_3();
				goto IL_8F;
			}
		}
		throw new InvalidOperationException();
		IL_8F:
		Class58 class2 = new Class58();
		class2.method_4(double_);
		class27_0.method_22(class2);
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00009A90 File Offset: 0x00007C90
	private static void smethod_123(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		float num2;
		if (num <= 7)
		{
			if (num == 2)
			{
				num2 = Convert.ToUInt64(((Class53)@class).method_3());
				goto IL_90;
			}
			if (num == 7)
			{
				num2 = (float)((Class54)@class).method_3();
				goto IL_90;
			}
		}
		else
		{
			if (num == 8)
			{
				num2 = (float)((Class58)@class).method_3();
				goto IL_90;
			}
			if (num == 22)
			{
				num2 = (float)((Class56)@class).method_3();
				goto IL_90;
			}
		}
		throw new InvalidOperationException();
		IL_90:
		Class58 class2 = new Class58();
		class2.method_4((double)num2);
		class27_0.method_22(class2);
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00009B40 File Offset: 0x00007D40
	private static void smethod_124(Class27 class27_0, Class44 class44_4)
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00009B44 File Offset: 0x00007D44
	private static byte[] smethod_125(Class79 class79_2)
	{
		int num = class79_2.method_19();
		byte[] array = new byte[num];
		class79_2.method_14(array, 0, num);
		return array;
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00009B6C File Offset: 0x00007D6C
	private static void smethod_126(Class27 class27_0, Class44 class44_4)
	{
		Class54 @class = (Class54)class44_4;
		MethodBase methodBase_ = class27_0.method_40(@class.method_3());
		class27_0.method_81(methodBase_, false);
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00009B98 File Offset: 0x00007D98
	private static void smethod_127(ILGenerator ilgenerator_0, Type type_9)
	{
		if (type_9 == Class115.type_0)
		{
			return;
		}
		ilgenerator_0.Emit(OpCodes.Castclass, type_9);
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00009BB0 File Offset: 0x00007DB0
	private Class93 method_50(int int_0)
	{
		if (this.class79_0 == null)
		{
			throw new InvalidOperationException();
		}
		Class41 obj = this.class79_0.method_0();
		Class93 result;
		lock (obj)
		{
			this.class79_0.method_0().vmethod_9((long)int_0, 0);
			Class93 @class = new Class93();
			@class.method_1(this.class79_0.method_6());
			if (@class.method_0() == 0)
			{
				@class.method_3(this.class79_0.method_19());
			}
			else
			{
				@class.method_5(this.method_68(this.class79_0));
			}
			result = @class;
		}
		return result;
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00009C54 File Offset: 0x00007E54
	private void method_51()
	{
		Class44 class44_ = this.method_37();
		Class61 class61_ = (Class61)this.method_37();
		this.method_5(class61_, class44_);
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00009C7C File Offset: 0x00007E7C
	private static void smethod_128(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		if (!Class27.smethod_26(class27_0.method_37(), class44_5))
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00009CB4 File Offset: 0x00007EB4
	private static void smethod_129(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_58(false, false);
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00009CC0 File Offset: 0x00007EC0
	private Class37[] method_52(Class79 class79_2)
	{
		Class37[] array = new Class37[(int)class79_2.method_23()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = this.method_38(class79_2);
		}
		return array;
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00009D00 File Offset: 0x00007F00
	private void method_53(bool bool_2)
	{
		Class44 @class = this.method_37();
		int num = @class.method_0();
		uint int_;
		if (num <= 7)
		{
			if (num != 2)
			{
				if (num == 7)
				{
					if (bool_2)
					{
						int_ = checked((uint)((Class54)@class).method_3());
						goto IL_173;
					}
					int_ = (uint)((ushort)((Class54)@class).method_3());
					goto IL_173;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((uint)Convert.ToUInt64(((Class53)@class).method_3()));
					goto IL_173;
				}
				int_ = (uint)Convert.ToUInt64(((Class53)@class).method_3());
				goto IL_173;
			}
		}
		else if (num != 8)
		{
			if (num != 15)
			{
				if (num == 22)
				{
					if (bool_2)
					{
						int_ = checked((uint)((Class56)@class).method_3());
						goto IL_173;
					}
					int_ = (uint)((Class56)@class).method_3();
					goto IL_173;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = checked((uint)((int)((Class49)@class).method_3()));
					goto IL_173;
				}
				int_ = (uint)((int)((Class49)@class).method_3());
				goto IL_173;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((uint)((ulong)((long)((Class49)@class).method_3())));
					goto IL_173;
				}
				int_ = (uint)((long)((Class49)@class).method_3());
				goto IL_173;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((uint)((Class58)@class).method_3());
				goto IL_173;
			}
			int_ = (uint)((Class58)@class).method_3();
			goto IL_173;
		}
		throw new InvalidOperationException();
		IL_173:
		this.method_22(new Class54((int)int_));
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00009E8C File Offset: 0x0000808C
	private static bool smethod_130(Class44 class44_4, Class44 class44_5)
	{
		bool result = false;
		int num = class44_4.method_0();
		if (num <= 7)
		{
			if (num == 2)
			{
				return Class27.smethod_130(new Class56(Convert.ToInt64(((Class53)class44_4).method_3())), class44_5);
			}
			if (num == 7)
			{
				if (class44_5.method_0() == 2)
				{
					return Class27.smethod_130(class44_4, new Class54(Convert.ToInt32(((Class53)class44_5).method_3())));
				}
				result = (((Class54)class44_4).method_3() < ((Class54)class44_5).method_3());
			}
		}
		else if (num != 8)
		{
			if (num == 22)
			{
				if (class44_5.method_0() == 2)
				{
					return Class27.smethod_130(class44_4, new Class56(Convert.ToInt64(((Class53)class44_5).method_3())));
				}
				if (class44_5.method_0() == 7)
				{
					return Class27.smethod_130(class44_4, new Class56((long)((Class54)class44_5).method_3()));
				}
				result = (((Class56)class44_4).method_3() < ((Class56)class44_5).method_3());
			}
		}
		else
		{
			double num2 = ((Class58)class44_4).method_3();
			double num3 = ((Class58)class44_5).method_3();
			result = (num2 < num3 || double.IsNaN(num2) || double.IsNaN(num3));
		}
		return result;
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00009FE0 File Offset: 0x000081E0
	private static void smethod_131(Class27 class27_0, Class44 class44_4)
	{
		Class69 @class = (Class69)class44_4;
		Class64 class2 = new Class64();
		class2.method_4(class27_0.class44_1[(int)@class.method_3()]);
		class27_0.method_22(class2);
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0000A018 File Offset: 0x00008218
	private static void smethod_132(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		Class44 class44_6 = class27_0.method_37();
		Class54 @class = new Class54();
		@class.method_4(Class27.smethod_168(class44_6, class44_5) ? 1 : 0);
		class27_0.method_22(@class);
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x0000A054 File Offset: 0x00008254
	private static void smethod_133(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_51();
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0000A05C File Offset: 0x0000825C
	private static bool smethod_134(MethodBase methodBase_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			if (parameters[i].ParameterType.IsByRef)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x0000A0A0 File Offset: 0x000082A0
	private object method_54(object[] object_3, Type[] type_9, Type[] type_10, object[] object_4)
	{
		this.method_46();
		if (object_3 == null)
		{
			object_3 = Class119<object>.gparam_0;
		}
		this.object_1 = object_4;
		this.type_1 = type_9;
		this.type_8 = type_10;
		this.class44_1 = this.method_88(object_3);
		this.class44_0 = this.method_3();
		object result;
		try
		{
			Class43 @class = new Class43(this.byte_0);
			try
			{
				using (this.class79_1 = new Class79(@class))
				{
					this.uint_1 = (uint)@class.vmethod_3();
					this.bool_0 = false;
					this.nullable_0 = null;
					this.uint_2 = 0U;
					this.uint_0 = 0U;
					this.method_49();
					this.method_61();
				}
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			Type type = this.method_80(this.class10_0.method_8(), false);
			if (type != Class27.type_3 && this.method_12())
			{
				result = Class44.smethod_0(null, type).vmethod_2(this.method_37()).vmethod_0();
			}
			else
			{
				result = null;
			}
		}
		finally
		{
			for (int i = 0; i < this.class10_0.method_2().Length; i++)
			{
				Class126 class3 = this.class10_0.method_2()[i];
				if (class3.method_2())
				{
					Class64 class4 = (Class64)this.class44_1[i];
					Type type2 = this.method_80(class3.method_0(), false);
					object_3[i] = Class44.smethod_0(null, type2.GetElementType()).vmethod_2(class4.method_3()).vmethod_0();
				}
			}
			this.object_1 = null;
			this.class44_1 = null;
			this.class44_0 = null;
		}
		return result;
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x0000A278 File Offset: 0x00008478
	private static void smethod_135(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_71(-1);
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x0000A284 File Offset: 0x00008484
	private static void smethod_136(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Class93 @class = class27_0.method_50(int_);
		object obj;
		if (@class.method_0() == 0)
		{
			obj = class27_0.method_47(@class.method_2());
		}
		else
		{
			switch (@class.method_4().vmethod_0())
			{
			case 1:
				obj = class27_0.method_40(int_).MethodHandle;
				break;
			case 2:
				obj = class27_0.method_27(int_).FieldHandle;
				break;
			case 3:
				obj = class27_0.method_80(int_, true).TypeHandle;
				break;
			default:
				throw new InvalidOperationException();
			}
		}
		Class51 class2 = new Class51();
		class2.method_4(obj);
		class27_0.method_22(class2);
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x0000A330 File Offset: 0x00008530
	private static void smethod_137(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_16(typeof(float));
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0000A344 File Offset: 0x00008544
	private static void smethod_138(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		if (Class27.smethod_26(class27_0.method_37(), class44_5))
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x060001CA RID: 458 RVA: 0x0000A37C File Offset: 0x0000857C
	private static void smethod_139(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_28((int)((Class48)class44_4).method_3());
	}

	// Token: 0x060001CB RID: 459 RVA: 0x0000A390 File Offset: 0x00008590
	private static void smethod_140(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		checked
		{
			int int_;
			if (num <= 7)
			{
				if (num == 2)
				{
					int_ = (int)Convert.ToUInt64(((Class53)@class).method_3());
					goto IL_D6;
				}
				if (num == 7)
				{
					int_ = (int)((uint)((Class54)@class).method_3());
					goto IL_D6;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (int)((Class58)@class).method_3();
					goto IL_D6;
				}
				if (num != 15)
				{
					if (num == 22)
					{
						int_ = (int)((ulong)((Class56)@class).method_3());
						goto IL_D6;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (int)((uint)((int)((Class49)@class).method_3()));
						goto IL_D6;
					}
					int_ = (int)((ulong)((long)((Class49)@class).method_3()));
					goto IL_D6;
				}
			}
			throw new InvalidOperationException();
			IL_D6:
			class27_0.method_22(new Class54(int_));
		}
	}

	// Token: 0x060001CC RID: 460 RVA: 0x0000A480 File Offset: 0x00008680
	private void method_55(Stream stream_1, string string_0)
	{
		this.method_39(stream_1, 0L, string_0);
	}

	// Token: 0x060001CD RID: 461 RVA: 0x0000A494 File Offset: 0x00008694
	private static void smethod_141(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_96(1);
	}

	// Token: 0x060001CE RID: 462 RVA: 0x0000A4A0 File Offset: 0x000086A0
	private Type method_56(int int_0, Class93 class93_0, ref bool bool_2, bool bool_3)
	{
		/*
An exception occurred when decompiling this method (060001CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type Class27::method_56(System.Int32,Class93,System.Boolean&,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_163:; 	brtrue(IL_193, logicnot:bool(call:bool(string::IsNullOrEmpty, ldloc:string(var_12)))); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0000A78C File Offset: 0x0000898C
	private string method_57(int int_0)
	{
		Dictionary<int, object> obj = Class27.dictionary_3;
		string result;
		lock (obj)
		{
			bool flag = true;
			object obj2;
			if (Class27.dictionary_3.TryGetValue(int_0, out obj2))
			{
				result = (string)obj2;
			}
			else
			{
				Class93 @class = this.method_50(int_0);
				if (@class.method_0() == 0)
				{
					result = this.module_0.ResolveString(@class.method_2());
				}
				else
				{
					string text = ((Class2)@class.method_4()).method_0();
					if (flag)
					{
						Class27.dictionary_3.Add(int_0, text);
					}
					result = text;
				}
			}
		}
		return result;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0000A824 File Offset: 0x00008A24
	private void method_58(bool bool_2, bool bool_3)
	{
		Class44 class44_ = this.method_37();
		Class44 class44_2 = this.method_37();
		this.method_22(Class27.smethod_4(class44_2, class44_, bool_2, bool_3));
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x0000A850 File Offset: 0x00008A50
	private static void smethod_142(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_16(typeof(short));
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0000A864 File Offset: 0x00008A64
	private static Class44 smethod_143(Class44 class44_4, Class44 class44_5, bool bool_2)
	{
		if (class44_4.method_0() == 7)
		{
			if (class44_5.method_0() == 7)
			{
				if (!bool_2)
				{
					int num = ((Class54)class44_4).method_3();
					int num2 = ((Class54)class44_5).method_3();
					return new Class54(num >> (num2 & 31));
				}
				int num3 = ((Class54)class44_4).method_3();
				int num4 = ((Class54)class44_5).method_3();
				return new Class54(num3 >> (num4 & 31));
			}
			else if (class44_5.method_0() == 2)
			{
				return Class27.smethod_143(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2);
			}
		}
		if (class44_4.method_0() == 22)
		{
			if (class44_5.method_0() == 7)
			{
				if (!bool_2)
				{
					long num5 = ((Class56)class44_4).method_3();
					int num6 = ((Class54)class44_5).method_3();
					return new Class56(num5 >> (num6 & 63));
				}
				long num7 = ((Class56)class44_4).method_3();
				int num8 = ((Class54)class44_5).method_3();
				return new Class56(num7 >> (num8 & 63));
			}
			else if (class44_5.method_0() == 2)
			{
				return Class27.smethod_143(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2);
			}
		}
		if (class44_4.method_0() != 2)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
		if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
		{
			return Class27.smethod_143(new Class56(Convert.ToInt64(class44_4.vmethod_0())), class44_5, bool_2);
		}
		return Class27.smethod_143(new Class54(Convert.ToInt32(class44_4.vmethod_0())), class44_5, bool_2);
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0000A9F4 File Offset: 0x00008BF4
	private Class126 method_59(Class79 class79_2)
	{
		Class126 @class = new Class126();
		@class.method_1(class79_2.method_19());
		@class.method_3(class79_2.method_5());
		return @class;
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x0000AA14 File Offset: 0x00008C14
	private static void smethod_144(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_22(class44_4);
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x0000AA20 File Offset: 0x00008C20
	private static void smethod_145(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		if (!Class27.smethod_130(class27_0.method_37(), class44_5))
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x0000AA58 File Offset: 0x00008C58
	private static void smethod_146(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_74(typeof(byte));
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x0000AA6C File Offset: 0x00008C6C
	private static void smethod_147(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		FieldInfo fieldInfo = class27_0.method_27(int_);
		Class44 @class = class27_0.method_37();
		Class44 class2 = class27_0.method_37();
		Class61 class3 = class2 as Class61;
		object obj;
		if (class3 != null)
		{
			obj = class27_0.method_83(class3).vmethod_0();
		}
		else
		{
			obj = class2.vmethod_0();
		}
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		Class44 class4 = Class44.smethod_0(@class.vmethod_0(), fieldInfo.FieldType);
		fieldInfo.SetValue(obj, class4.vmethod_0());
		if (class3 != null && obj != null && obj.GetType().IsValueType)
		{
			class27_0.method_5(class3, Class44.smethod_0(obj, null));
		}
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x0000AB08 File Offset: 0x00008D08
	private void method_60(uint uint_3)
	{
		this.nullable_0 = new uint?(uint_3);
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x0000AB18 File Offset: 0x00008D18
	private static void smethod_148(Class27 class27_0, Class44 class44_4)
	{
		object object_ = class27_0.method_37().vmethod_0();
		long num = class27_0.method_70();
		Array array = (Array)class27_0.method_37().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(sbyte))
			{
				Class44 @class = Class44.smethod_0(object_, typeof(sbyte));
				((sbyte[])array)[(int)((IntPtr)num)] = (sbyte)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(byte))
			{
				Class44 class2 = Class44.smethod_0(object_, typeof(byte));
				((byte[])array)[(int)((IntPtr)num)] = (byte)class2.vmethod_0();
				return;
			}
			if (elementType == typeof(bool))
			{
				Class44 class3 = Class44.smethod_0(object_, typeof(bool));
				((bool[])array)[(int)((IntPtr)num)] = (bool)class3.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				class27_0.method_34(elementType, object_, num, array);
				return;
			}
			class27_0.method_34(typeof(sbyte), object_, num, array);
		}
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0000AC1C File Offset: 0x00008E1C
	private static bool smethod_149(Class44 class44_4, Class44 class44_5)
	{
		bool result = false;
		int num = class44_4.method_0();
		if (num <= 7)
		{
			if (num == 2)
			{
				return Class27.smethod_149(new Class56(Convert.ToInt64(((Class53)class44_4).method_3())), class44_5);
			}
			if (num == 7)
			{
				if (class44_5.method_0() == 2)
				{
					return Class27.smethod_149(class44_4, new Class54(Convert.ToInt32(((Class53)class44_5).method_3())));
				}
				result = (((Class54)class44_4).method_3() > ((Class54)class44_5).method_3());
			}
		}
		else if (num != 8)
		{
			if (num == 22)
			{
				if (class44_5.method_0() == 2)
				{
					return Class27.smethod_149(class44_4, new Class56(Convert.ToInt64(((Class53)class44_5).method_3())));
				}
				if (class44_5.method_0() == 7)
				{
					return Class27.smethod_149(class44_4, new Class56((long)((Class54)class44_5).method_3()));
				}
				result = (((Class56)class44_4).method_3() > ((Class56)class44_5).method_3());
			}
		}
		else
		{
			double num2 = ((Class58)class44_4).method_3();
			double num3 = ((Class58)class44_5).method_3();
			result = (!double.IsNaN(num2) && !double.IsNaN(num3) && num2 > num3);
		}
		return result;
	}

	// Token: 0x060001DB RID: 475 RVA: 0x0000AD74 File Offset: 0x00008F74
	private static Class44 smethod_150(Class44 class44_4, Class44 class44_5, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class56)class44_4).method_3();
			long num2 = ((Class56)class44_5).method_3();
			long long_;
			if (bool_2)
			{
				long_ = checked(num - num2);
			}
			else
			{
				long_ = num - num2;
			}
			return new Class56(long_);
		}
		ulong num3 = (ulong)((Class56)class44_4).method_3();
		ulong num4 = (ulong)((Class56)class44_5).method_3();
		ulong long_2;
		if (bool_2)
		{
			long_2 = checked(num3 - num4);
		}
		else
		{
			long_2 = num3 - num4;
		}
		return new Class56((long)long_2);
	}

	// Token: 0x060001DC RID: 476 RVA: 0x0000ADE4 File Offset: 0x00008FE4
	private static void smethod_151(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		checked
		{
			short int_;
			if (num <= 7)
			{
				if (num == 2)
				{
					int_ = (short)Convert.ToUInt64(((Class53)@class).method_3());
					goto IL_D6;
				}
				if (num == 7)
				{
					int_ = (short)((uint)((Class54)@class).method_3());
					goto IL_D6;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (short)((Class58)@class).method_3();
					goto IL_D6;
				}
				if (num != 15)
				{
					if (num == 22)
					{
						int_ = (short)((ulong)((Class56)@class).method_3());
						goto IL_D6;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (short)((uint)((int)((Class49)@class).method_3()));
						goto IL_D6;
					}
					int_ = (short)((ulong)((long)((Class49)@class).method_3()));
					goto IL_D6;
				}
			}
			throw new InvalidOperationException();
			IL_D6:
			class27_0.method_22(new Class54((int)int_));
		}
	}

	// Token: 0x060001DD RID: 477 RVA: 0x0000AED4 File Offset: 0x000090D4
	private static bool smethod_152()
	{
		return false;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x0000AED8 File Offset: 0x000090D8
	private void method_61()
	{
		this.method_93(false);
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0000AEE4 File Offset: 0x000090E4
	private void method_62(bool bool_2)
	{
		Class44 @class = this.method_37();
		int num = @class.method_0();
		int int_;
		if (num <= 7)
		{
			if (num != 2)
			{
				if (num == 7)
				{
					if (bool_2)
					{
						int_ = ((Class54)@class).method_3();
						goto IL_16F;
					}
					int_ = ((Class54)@class).method_3();
					goto IL_16F;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((int)Convert.ToUInt64(((Class53)@class).method_3()));
					goto IL_16F;
				}
				int_ = (int)Convert.ToUInt64(((Class53)@class).method_3());
				goto IL_16F;
			}
		}
		else if (num != 8)
		{
			if (num != 15)
			{
				if (num == 22)
				{
					if (bool_2)
					{
						int_ = checked((int)((Class56)@class).method_3());
						goto IL_16F;
					}
					int_ = (int)((Class56)@class).method_3();
					goto IL_16F;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = (int)((Class49)@class).method_3();
					goto IL_16F;
				}
				int_ = (int)((Class49)@class).method_3();
				goto IL_16F;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((int)((long)((Class49)@class).method_3()));
					goto IL_16F;
				}
				int_ = (int)((long)((Class49)@class).method_3());
				goto IL_16F;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((int)((Class58)@class).method_3());
				goto IL_16F;
			}
			int_ = (int)((Class58)@class).method_3();
			goto IL_16F;
		}
		throw new InvalidOperationException();
		IL_16F:
		Class54 class2 = new Class54();
		class2.method_4(int_);
		this.method_22(class2);
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0000B074 File Offset: 0x00009274
	private static void smethod_153(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_14(false);
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x0000B080 File Offset: 0x00009280
	private static void smethod_154(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_41((int)((Class48)class44_4).method_3());
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x0000B094 File Offset: 0x00009294
	private MethodBase method_63(int int_0, Class93 class93_0)
	{
		Dictionary<int, object> obj = Class27.dictionary_3;
		MethodBase result;
		lock (obj)
		{
			bool flag = true;
			object obj2;
			if (Class27.dictionary_3.TryGetValue(int_0, out obj2))
			{
				result = (MethodBase)obj2;
			}
			else if (class93_0.method_0() == 0)
			{
				MethodBase methodBase = this.module_0.ResolveMethod(class93_0.method_2());
				if (flag)
				{
					Class27.dictionary_3.Add(int_0, methodBase);
				}
				result = methodBase;
			}
			else
			{
				Class4 @class = (Class4)class93_0.method_4();
				if (@class.method_3())
				{
					result = this.method_11(@class);
				}
				else
				{
					Type type = this.method_80(@class.method_4().method_2(), false);
					Type type2 = this.method_80(@class.method_12().method_2(), true);
					Type[] array = new Type[@class.method_8().Length];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = this.method_80(@class.method_8()[i].method_2(), true);
					}
					if (type.IsGenericType)
					{
						flag = false;
					}
					if (@class.method_6() == ".ctor")
					{
						ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, array, null);
						if (constructor == null)
						{
							throw new Exception();
						}
						if (flag)
						{
							Class27.dictionary_3.Add(int_0, constructor);
						}
						result = constructor;
					}
					else
					{
						BindingFlags bindingAttr = Class27.smethod_188(@class.method_2());
						MethodBase methodBase2 = null;
						try
						{
							methodBase2 = type.GetMethod(@class.method_6(), bindingAttr, null, CallingConventions.Any, array, null);
						}
						catch (AmbiguousMatchException)
						{
							foreach (MethodInfo methodInfo in type.GetMethods(bindingAttr))
							{
								if (!(methodInfo.Name != @class.method_6()) && methodInfo.ReturnType == type2)
								{
									ParameterInfo[] parameters = methodInfo.GetParameters();
									if (parameters.Length == array.Length)
									{
										bool flag2 = false;
										for (int k = 0; k < array.Length; k++)
										{
											if (parameters[k].ParameterType != array[k])
											{
												goto IL_219;
											}
										}
										if (!flag2)
										{
											methodBase2 = methodInfo;
											break;
										}
									}
								}
								IL_219:;
							}
						}
						if (methodBase2 == null)
						{
							throw new Exception(string.Format("Cannot bind method: {0}.{1}", type.Name, @class.method_6()));
						}
						if (flag)
						{
							Class27.dictionary_3.Add(int_0, methodBase2);
						}
						result = methodBase2;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0000B358 File Offset: 0x00009558
	private static void smethod_155(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_21(false);
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x0000B364 File Offset: 0x00009564
	private void method_64(Class10 class10_1)
	{
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x0000B378 File Offset: 0x00009578
	private void method_65(ref Class27.Struct5 struct5_0, MethodBase methodBase_0, bool bool_2)
	{
		bool flag = false;
		if (methodBase_0.DeclaringType == typeof(Interlocked) && methodBase_0.IsStatic)
		{
			string name = methodBase_0.Name;
			if (name == "Add" || name == "CompareExchange" || name == "Decrement" || name == "Exchange" || name == "Increment")
			{
				goto IL_94;
			}
			if (name == "Read")
			{
				goto IL_94;
			}
		}
		if (!flag)
		{
			return;
		}
		try
		{
			IL_94:;
		}
		finally
		{
			Monitor.Enter(Class27.object_2);
			struct5_0.bool_0 = true;
		}
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x0000B440 File Offset: 0x00009640
	private Class126[] method_66(Class79 class79_2)
	{
		Class126[] array = new Class126[(int)class79_2.method_23()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = this.method_59(class79_2);
		}
		return array;
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x0000B480 File Offset: 0x00009680
	private static void smethod_156(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_29(0);
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x0000B48C File Offset: 0x0000968C
	private void method_67(Class27.Class28 class28_0)
	{
		this.class79_1 = class28_0.class79_0;
		this.long_0 = class28_0.long_0;
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x0000B4A8 File Offset: 0x000096A8
	private static void smethod_157(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_89(true);
	}

	// Token: 0x060001EA RID: 490 RVA: 0x0000B4B4 File Offset: 0x000096B4
	private Class0 method_68(Class79 class79_2)
	{
		switch (class79_2.method_6())
		{
		case 0:
		{
			Class5 @class = new Class5();
			@class.method_1(class79_2.method_19());
			@class.method_3(class79_2.method_19());
			return @class;
		}
		case 1:
		{
			Class4 class2 = new Class4();
			Class4 class3 = class2;
			Class93 class4 = new Class93();
			class4.method_1(1);
			class4.method_3(class79_2.method_19());
			class3.method_5(class4);
			class2.method_1(class79_2.method_6());
			class2.method_7(class79_2.method_9());
			Class4 class5 = class2;
			Class93 class6 = new Class93();
			class6.method_1(1);
			class6.method_3(class79_2.method_19());
			class5.method_13(class6);
			int num = class79_2.method_18();
			Class93[] array = new Class93[num];
			for (int i = 0; i < num; i++)
			{
				Class93[] array2 = array;
				int num2 = i;
				Class93 class7 = new Class93();
				class7.method_1(1);
				class7.method_3(class79_2.method_19());
				array2[num2] = class7;
			}
			class2.method_9(array);
			int num3 = class79_2.method_18();
			Class93[] array3 = new Class93[num3];
			for (int j = 0; j < num3; j++)
			{
				Class93[] array4 = array3;
				int num4 = j;
				Class93 class8 = new Class93();
				class8.method_1(1);
				class8.method_3(class79_2.method_19());
				array4[num4] = class8;
			}
			class2.method_11(array3);
			return class2;
		}
		case 2:
		{
			Class3 class9 = new Class3();
			Class93 class10 = new Class93();
			class10.method_1(1);
			class10.method_3(class79_2.method_19());
			class9.method_1(class10);
			class9.method_3(class79_2.method_9());
			class9.method_5(class79_2.method_5());
			return class9;
		}
		case 3:
		{
			Class1 class11 = new Class1();
			class11.method_1(class79_2.method_9());
			class11.method_5(class79_2.method_5());
			class11.method_3(class79_2.method_5());
			class11.method_11(class79_2.method_19());
			class11.method_9(class79_2.method_19());
			int num5 = class79_2.method_18();
			Class93[] array5 = new Class93[num5];
			for (int k = 0; k < num5; k++)
			{
				Class93[] array6 = array5;
				int num6 = k;
				Class93 class12 = new Class93();
				class12.method_1(1);
				class12.method_3(class79_2.method_19());
				array6[num6] = class12;
			}
			class11.method_7(array5);
			return class11;
		}
		case 4:
		{
			Class2 class13 = new Class2();
			class13.method_1(class79_2.method_9());
			return class13;
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	// Token: 0x060001EB RID: 491 RVA: 0x0000B6D8 File Offset: 0x000098D8
	private bool method_69(MethodBase methodBase_0, object object_3, ref object object_4, object[] object_5)
	{
		if (!methodBase_0.IsStatic && methodBase_0.Name == "Address")
		{
			MethodInfo methodInfo = methodBase_0 as MethodInfo;
			if (methodInfo != null)
			{
				Type type = methodInfo.ReturnType;
				if (type.IsByRef)
				{
					type = type.GetElementType();
					int num = object_5.Length;
					if (num >= 1 && object_5[0] is int)
					{
						int[] array = new int[num];
						for (int i = 0; i < num; i++)
						{
							array[i] = (int)object_5[i];
						}
						Class66 @class = new Class66();
						@class.method_6((Array)object_3);
						@class.method_8(array);
						@class.method_4(type);
						object_4 = @class;
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060001EC RID: 492 RVA: 0x0000B798 File Offset: 0x00009998
	private static void smethod_158(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_74(Class27.type_2);
	}

	// Token: 0x060001ED RID: 493 RVA: 0x0000B7A8 File Offset: 0x000099A8
	private static void smethod_159(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		Class44 class44_6 = class27_0.method_37();
		class27_0.method_22(new Class54(Class27.smethod_26(class44_6, class44_5) ? 1 : 0));
	}

	// Token: 0x060001EE RID: 494 RVA: 0x0000B7DC File Offset: 0x000099DC
	private static void smethod_160(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_71(4);
	}

	// Token: 0x060001EF RID: 495 RVA: 0x0000B7E8 File Offset: 0x000099E8
	private static void smethod_161(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		bool flag;
		if (num <= 7)
		{
			if (num == 2)
			{
				flag = Convert.ToBoolean(((Class53)@class).method_3());
				goto IL_F1;
			}
			if (num == 6)
			{
				flag = (((Class50)@class).method_3() != UIntPtr.Zero);
				goto IL_F1;
			}
			if (num == 7)
			{
				flag = (((Class54)@class).method_3() != 0);
				goto IL_F1;
			}
		}
		else
		{
			if (num == 15)
			{
				flag = (((Class49)@class).method_3() != IntPtr.Zero);
				goto IL_F1;
			}
			if (num == 17)
			{
				flag = (((Class51)@class).method_3() != null);
				goto IL_F1;
			}
			if (num == 22)
			{
				flag = (((Class56)@class).method_3() != 0L);
				goto IL_F1;
			}
		}
		flag = (@class.vmethod_0() != null);
		IL_F1:
		if (flag)
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x0000B900 File Offset: 0x00009B00
	private static void smethod_162(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_32(false);
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x0000B90C File Offset: 0x00009B0C
	private long method_70()
	{
		Class44 @class = this.method_37();
		int num = @class.method_0();
		if (num <= 6)
		{
			if (num == 2)
			{
				return Convert.ToInt64(((Class53)@class).method_3());
			}
			if (num == 6)
			{
				return (long)((Class50)@class).method_3().ToUInt64();
			}
		}
		else
		{
			if (num == 7)
			{
				return (long)((Class54)@class).method_3();
			}
			if (num == 15)
			{
				return ((Class49)@class).method_3().ToInt64();
			}
		}
		throw new Exception("Unexpected value on the stack.");
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x0000B9BC File Offset: 0x00009BBC
	private static void smethod_163(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_90(true);
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x0000B9C8 File Offset: 0x00009BC8
	private static void smethod_164(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_16(typeof(byte));
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x0000B9DC File Offset: 0x00009BDC
	private static void smethod_165(object object_3)
	{
		throw object_3;
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x0000B9E0 File Offset: 0x00009BE0
	private static void smethod_166(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_105(false);
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x0000B9EC File Offset: 0x00009BEC
	private void method_71(int int_0)
	{
		this.method_22(new Class54(int_0));
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x0000B9FC File Offset: 0x00009BFC
	private static void smethod_167(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_22(class44_4);
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x0000BA08 File Offset: 0x00009C08
	private static bool smethod_168(Class44 class44_4, Class44 class44_5)
	{
		bool result = false;
		switch (class44_4.method_0())
		{
		case 1:
		case 21:
		{
			Class65 @class = (Class65)class44_4;
			Class65 class65_ = (Class65)class44_5;
			result = @class.vmethod_6(class65_);
			break;
		}
		case 2:
		{
			Class53 class2 = (Class53)class44_4;
			if (class44_5.method_0() == 2)
			{
				result = (Convert.ToInt64(class2.method_3()) == Convert.ToInt64(((Class53)class44_5).method_3()));
			}
			else if (class2.method_3() == null)
			{
				result = (class44_5.vmethod_0() == null);
			}
			else if (class44_5.vmethod_0() != null)
			{
				result = (Convert.ToInt64(class2.method_3()) == Convert.ToInt64(class44_5.vmethod_0()));
			}
			break;
		}
		default:
			result = (class44_4.vmethod_0() == class44_5.vmethod_0());
			break;
		case 6:
			if (class44_5.method_0() == 17 && class44_5.vmethod_0() == null)
			{
				result = (((Class50)class44_4).method_3() == UIntPtr.Zero);
			}
			else if (class44_5.method_0() == 7)
			{
				result = (((Class50)class44_4).method_3() == new UIntPtr((uint)((Class54)class44_5).method_3()));
			}
			else if (class44_5.method_0() == 22)
			{
				result = (((Class50)class44_4).method_3() == new UIntPtr((ulong)((Class56)class44_5).method_3()));
			}
			else
			{
				result = (((Class50)class44_4).method_3() == ((Class50)class44_5).method_3());
			}
			break;
		case 7:
			if (class44_5.method_0() == 2)
			{
				result = ((long)((Class54)class44_4).method_3() == Convert.ToInt64(((Class53)class44_5).method_3()));
			}
			else if (class44_5.method_0() == 17 && class44_5.vmethod_0() == null)
			{
				result = (((Class54)class44_4).method_3() == 0);
			}
			else
			{
				result = (((Class54)class44_4).method_3() == ((Class54)class44_5).method_3());
			}
			break;
		case 8:
		{
			double d = ((Class58)class44_4).method_3();
			double num = ((Class58)class44_5).method_3();
			result = (!double.IsNaN(d) && !double.IsNaN(num) && d.Equals(num));
			break;
		}
		case 10:
			result = ((class44_5.method_0() != 17 || class44_5.vmethod_0() != null) && ((Class46)class44_4).method_3() == ((Class46)class44_5).method_3());
			break;
		case 13:
		{
			Class63 class3 = (Class63)class44_4;
			Class63 class4 = (Class63)class44_5;
			result = (class3.method_3() == class4.method_3());
			break;
		}
		case 15:
			if (class44_5.method_0() == 17 && class44_5.vmethod_0() == null)
			{
				result = (((Class49)class44_4).method_3() == IntPtr.Zero);
			}
			else if (class44_5.method_0() == 7)
			{
				result = (((Class49)class44_4).method_3() == new IntPtr(((Class54)class44_5).method_3()));
			}
			else if (class44_5.method_0() == 22)
			{
				result = (((Class49)class44_4).method_3() == new IntPtr(((Class56)class44_5).method_3()));
			}
			else
			{
				result = (((Class49)class44_4).method_3() == ((Class49)class44_5).method_3());
			}
			break;
		case 17:
			result = (class44_4.vmethod_0() == class44_5.vmethod_0());
			break;
		case 18:
		{
			Class62 class5 = (Class62)class44_4;
			Class62 class6 = (Class62)class44_5;
			result = (class5.method_3() == class6.method_3() && class5.method_5() == class6.method_5());
			break;
		}
		case 22:
			if (class44_5.method_0() == 2)
			{
				result = (((Class56)class44_4).method_3() == Convert.ToInt64(((Class53)class44_5).method_3()));
			}
			else if (class44_5.method_0() == 17 && class44_5.vmethod_0() == null)
			{
				result = (((Class56)class44_4).method_3() == 0L);
			}
			else
			{
				result = (((Class56)class44_4).method_3() == ((Class56)class44_5).method_3());
			}
			break;
		case 23:
		{
			Class64 class7 = (Class64)class44_4;
			Class64 class8 = (Class64)class44_5;
			result = Class27.smethod_168(class7.method_3(), class8.method_3());
			break;
		}
		}
		return result;
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
	private void method_72()
	{
	}

	// Token: 0x060001FA RID: 506 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
	private void method_73(Type type_9)
	{
		object object_ = this.method_37().vmethod_0();
		long long_ = this.method_70();
		Array array_ = (Array)this.method_37().vmethod_0();
		this.method_34(type_9, object_, long_, array_);
	}

	// Token: 0x060001FB RID: 507 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
	private void method_74(Type type_9)
	{
		Class61 class61_ = (Class61)this.method_37();
		this.method_22(Class44.smethod_0(this.method_83(class61_).vmethod_0(), type_9));
	}

	// Token: 0x060001FC RID: 508 RVA: 0x0000BF24 File Offset: 0x0000A124
	private static string smethod_169(MethodBase methodBase_0)
	{
		Type declaringType = methodBase_0.DeclaringType;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		string[] array = new string[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			ParameterInfo parameterInfo = parameters[i];
			array[i] = string.Format("{0} {1}", parameterInfo.ParameterType, parameterInfo.Name);
		}
		string text = string.Join(", ", array);
		return string.Concat(new string[]
		{
			declaringType.FullName,
			".",
			methodBase_0.Name,
			"(",
			text,
			")"
		});
	}

	// Token: 0x060001FD RID: 509 RVA: 0x0000BFCC File Offset: 0x0000A1CC
	private void method_75(Class5 class5_0)
	{
		Class93 @class = this.method_50(class5_0.method_2());
		Class4 class2 = (Class4)@class.method_4();
		MethodBase methodBase = this.method_63(class5_0.method_2(), @class);
		methodBase.GetParameters();
		int num = class5_0.method_0();
		bool bool_ = (num & 1073741824) != 0;
		num &= -1073741825;
		Type[] array = this.type_1;
		Type[] array2 = this.type_8;
		try
		{
			this.type_1 = ((methodBase is ConstructorInfo) ? null : methodBase.GetGenericArguments());
			this.type_8 = methodBase.DeclaringType.GetGenericArguments();
			this.method_103(num, this.type_1, this.type_8, bool_);
		}
		finally
		{
			this.type_1 = array;
			this.type_8 = array2;
		}
	}

	// Token: 0x060001FE RID: 510 RVA: 0x0000C090 File Offset: 0x0000A290
	private static void smethod_170(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		if (Class27.smethod_149(class27_0.method_37(), class44_5))
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x060001FF RID: 511 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
	private Class44 method_76(Class44 class44_4, Class44 class44_5, bool bool_2)
	{
		if (class44_4.method_0() == 7)
		{
			if (class44_5.method_0() == 7)
			{
				if (!bool_2)
				{
					int num = ((Class54)class44_4).method_3();
					int num2 = ((Class54)class44_5).method_3();
					return new Class54(num / num2);
				}
				int num3 = ((Class54)class44_4).method_3();
				uint num4 = (uint)((Class54)class44_5).method_3();
				return new Class54(num3 / (int)num4);
			}
			else
			{
				if (class44_5.method_0() == 22)
				{
					return Class27.smethod_48(new Class56((long)((Class54)class44_4).method_3()), class44_5, bool_2);
				}
				if (class44_5.method_0() == 2)
				{
					Type underlyingType = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
					if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
					{
						return Class27.smethod_48(new Class56((long)((Class54)class44_4).method_3()), new Class56(Convert.ToInt64(class44_5.vmethod_0())), bool_2);
					}
					return this.method_76(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2);
				}
			}
		}
		if (class44_4.method_0() == 22)
		{
			if (class44_5.method_0() == 22)
			{
				return Class27.smethod_48(class44_4, class44_5, bool_2);
			}
			if (class44_5.method_0() == 7)
			{
				return Class27.smethod_48(class44_4, new Class56((long)((Class54)class44_5).method_3()), bool_2);
			}
			if (class44_5.method_0() == 2)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return Class27.smethod_48(class44_4, new Class56(Convert.ToInt64(class44_5.vmethod_0())), bool_2);
				}
				return Class27.smethod_48(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2);
			}
		}
		if (class44_4.method_0() == 8 && class44_5.method_0() == 8)
		{
			Class58 @class = new Class58();
			@class.method_4(((Class58)class44_4).method_3() / ((Class58)class44_5).method_3());
			return @class;
		}
		if (class44_4.method_0() != 2)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType3 = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
		if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong))
		{
			return this.method_76(new Class56(Convert.ToInt64(class44_4.vmethod_0())), class44_5, bool_2);
		}
		return this.method_76(new Class54(Convert.ToInt32(class44_4.vmethod_0())), class44_5, bool_2);
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0000C344 File Offset: 0x0000A544
	private Stack<Class27.Class28> method_77()
	{
		Stack<Class27.Class28> stack = this.stack_0;
		if (stack == null)
		{
			stack = (this.stack_0 = new Stack<Class27.Class28>());
			stack.Push(new Class27.Class28
			{
				class79_0 = this.class79_1,
				class41_0 = this.class79_1.method_0(),
				long_0 = this.long_0
			});
		}
		return stack;
	}

	// Token: 0x06000201 RID: 513 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
	private static void smethod_171(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_16(typeof(ushort));
	}

	// Token: 0x06000202 RID: 514 RVA: 0x0000C3B4 File Offset: 0x0000A5B4
	private void method_78(object object_3, uint uint_3)
	{
		bool flag = object_3 != null;
		this.object_0 = object_3;
		if (flag)
		{
			this.stack_1.Clear();
		}
		this.bool_1 = flag;
		if (!flag)
		{
			this.stack_1.Push(new Class27.Struct3(uint_3));
		}
		foreach (Class125 @class in this.class125_0)
		{
			if (Class27.smethod_46(this.uint_2, @class.method_6(), @class.method_4()))
			{
				switch (@class.method_2())
				{
				case 0:
					if (flag)
					{
						Type type = object_3.GetType();
						Type type2 = this.method_80(@class.method_0(), true);
						if (type == type2 || type.IsSubclassOf(type2))
						{
							this.stack_1.Push(new Class27.Struct3(@class.method_8(), object_3));
							this.bool_1 = false;
						}
					}
					break;
				case 1:
					if (flag || !Class27.smethod_46(uint_3, @class.method_6(), @class.method_4()))
					{
						this.stack_1.Push(new Class27.Struct3(@class.method_8()));
					}
					break;
				case 2:
					if (flag)
					{
						this.stack_1.Push(new Class27.Struct3(@class.method_8()));
					}
					break;
				case 4:
					if (flag)
					{
						this.stack_1.Push(new Class27.Struct3(@class.method_10(), object_3));
					}
					break;
				}
			}
		}
		this.method_48();
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0000C53C File Offset: 0x0000A73C
	private static void smethod_172(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_74(Class115.type_0);
	}

	// Token: 0x06000204 RID: 516 RVA: 0x0000C54C File Offset: 0x0000A74C
	private static void smethod_173(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		uint num2;
		if (num != 2)
		{
			if (num != 7)
			{
				if (num != 22)
				{
					throw new InvalidOperationException();
				}
				num2 = (uint)((Class56)@class).method_3();
			}
			else
			{
				num2 = (uint)((Class54)@class).method_3();
			}
		}
		else
		{
			num2 = (uint)Convert.ToInt64(@class.vmethod_0());
		}
		Class54[] array = (Class54[])((Class70)class44_4).method_3();
		if ((ulong)num2 >= (ulong)((long)array.Length))
		{
			return;
		}
		uint uint_ = (uint)array[(int)num2].method_3();
		class27_0.method_60(uint_);
	}

	// Token: 0x06000205 RID: 517 RVA: 0x0000C5F0 File Offset: 0x0000A7F0
	private static void smethod_174(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		FieldInfo fieldInfo = class27_0.method_27(int_);
		class27_0.method_22(Class44.smethod_0(fieldInfo.GetValue(null), fieldInfo.FieldType));
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0000C62C File Offset: 0x0000A82C
	private int method_79()
	{
		return -1501602977;
	}

	// Token: 0x06000207 RID: 519 RVA: 0x0000C634 File Offset: 0x0000A834
	private Type method_80(int int_0, bool bool_2)
	{
		Dictionary<int, object> obj = Class27.dictionary_3;
		Type type;
		lock (obj)
		{
			bool flag = true;
			object obj2;
			if (Class27.dictionary_3.TryGetValue(int_0, out obj2))
			{
				type = (Type)obj2;
			}
			else
			{
				Class93 class93_ = this.method_50(int_0);
				type = this.method_56(int_0, class93_, ref flag, bool_2);
				if (flag)
				{
					Class27.dictionary_3.Add(int_0, type);
				}
			}
		}
		if (bool_2)
		{
			this.method_87(type);
		}
		return type;
	}

	// Token: 0x06000208 RID: 520 RVA: 0x0000C6B0 File Offset: 0x0000A8B0
	private static void smethod_175(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_28((int)((Class69)class44_4).method_3());
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000C6C4 File Offset: 0x0000A8C4
	private static Class125[] smethod_176(Class79 class79_2)
	{
		int num = (int)class79_2.method_23();
		Class125[] array = new Class125[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = Class27.smethod_3(class79_2);
		}
		return array;
	}

	// Token: 0x0600020A RID: 522 RVA: 0x0000C704 File Offset: 0x0000A904
	private void method_81(MethodBase methodBase_0, bool bool_2)
	{
		bool flag;
		if ((flag = (!bool_2 && this.method_25(methodBase_0))) && Class27.Class29.bool_0)
		{
			methodBase_0 = Class27.Class33.smethod_0(this, this.class10_0, methodBase_0, bool_2);
		}
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		Class44[] array = new Class44[num];
		object[] array2 = new object[num];
		Class27.Struct5 @struct = default(Class27.Struct5);
		try
		{
			this.method_65(ref @struct, methodBase_0, bool_2);
			for (int i = num - 1; i >= 0; i--)
			{
				Class44 @class = this.method_37();
				array[i] = @class;
				Class61 class2 = @class as Class61;
				if (class2 != null)
				{
					@class = this.method_83(class2);
				}
				if (@class.method_1() != null)
				{
					@class = Class44.smethod_0(null, @class.method_1()).vmethod_2(@class);
				}
				Class44 class3 = Class44.smethod_0(null, parameters[i].ParameterType).vmethod_2(@class);
				array2[i] = class3.vmethod_0();
			}
			Class44 class4 = null;
			if (!methodBase_0.IsStatic)
			{
				class4 = this.method_37();
				if (class4 != null && class4.method_1() != null)
				{
					class4 = Class44.smethod_0(null, class4.method_1()).vmethod_2(class4);
				}
			}
			object obj = null;
			object obj2 = null;
			try
			{
				if (methodBase_0.IsConstructor)
				{
					obj = Activator.CreateInstance(methodBase_0.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, array2, null);
					if (!(class4 is Class61))
					{
						throw new InvalidOperationException();
					}
				}
				else
				{
					if (class4 != null)
					{
						Class44 class5 = class4;
						Class61 class6 = class4 as Class61;
						if (class6 != null)
						{
							class5 = this.method_83(class6);
						}
						obj2 = class5.vmethod_0();
					}
					try
					{
						if (!this.method_43(methodBase_0, obj2, ref obj, array2))
						{
							if (bool_2 && !methodBase_0.IsStatic && obj2 == null)
							{
								throw new NullReferenceException();
							}
							if (!this.method_94(methodBase_0, obj2, array, array2, bool_2, ref obj))
							{
								MethodBase methodBase_ = methodBase_0;
								object object_ = obj2;
								if (flag && !Class27.Class29.bool_0)
								{
									MethodInfo methodInfo;
									object_ = Class27.Class34.smethod_0(obj2, methodBase_0, out methodInfo);
									methodBase_ = methodInfo;
								}
								obj = Class27.smethod_2(methodBase_, object_, array2, bool_2);
							}
						}
						goto IL_2BB;
					}
					catch (TargetInvocationException ex)
					{
						Exception object_2 = ex.InnerException ?? ex;
						this.method_104(object_2);
						goto IL_2BB;
					}
				}
				obj2 = obj;
			}
			finally
			{
				for (int j = 0; j < array.Length; j++)
				{
					Class61 class7 = array[j] as Class61;
					if (class7 != null)
					{
						object obj3 = array2[j];
						this.method_5(class7, Class44.smethod_0(obj3, null));
					}
				}
				if (obj2 != null)
				{
					Class61 class8 = class4 as Class61;
					if (class8 != null)
					{
						bool flag2 = true;
						Class62 class9 = class8 as Class62;
						if (class9 != null)
						{
							flag2 = this.method_2(class9);
						}
						if (flag2)
						{
							this.method_5(class8, Class44.smethod_0(obj2, methodBase_0.DeclaringType));
						}
					}
				}
			}
			IL_2BB:
			MethodInfo methodInfo2 = methodBase_0 as MethodInfo;
			if (methodInfo2 != null)
			{
				Type returnType = methodInfo2.ReturnType;
				if (returnType != Class27.type_3)
				{
					this.method_22(Class44.smethod_0(obj, returnType));
				}
			}
		}
		finally
		{
			this.method_0(ref @struct);
		}
	}

	// Token: 0x0600020B RID: 523 RVA: 0x0000CA5C File Offset: 0x0000AC5C
	private static void smethod_177(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_96(3);
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0000CA68 File Offset: 0x0000AC68
	private static void smethod_178(Class27 class27_0, Class44 class44_4)
	{
		Class69 @class = (Class69)class44_4;
		class27_0.method_96((int)@class.method_3());
	}

	// Token: 0x0600020D RID: 525 RVA: 0x0000CA88 File Offset: 0x0000AC88
	private static void smethod_179(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Type type = class27_0.method_80(int_, true);
		Class44 @class = Class44.smethod_0(class27_0.method_37().vmethod_0(), type);
		@class.method_2(type);
		class27_0.method_22(@class);
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0000CACC File Offset: 0x0000ACCC
	private static void smethod_180(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_90(false);
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
	private static Class44 smethod_181(Class44 class44_4, Class44 class44_5, bool bool_2)
	{
		if (!bool_2)
		{
			long num = ((Class56)class44_4).method_3();
			long num2 = ((Class56)class44_5).method_3();
			return new Class56(num % num2);
		}
		long num3 = ((Class56)class44_4).method_3();
		ulong num4 = (ulong)((Class56)class44_5).method_3();
		return new Class56(num3 % (long)num4);
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000CB28 File Offset: 0x0000AD28
	private static void smethod_182(Class27 class27_0, Class44 class44_4)
	{
		uint uint_ = ((Class59)class44_4).method_3();
		class27_0.method_78(null, uint_);
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000CB4C File Offset: 0x0000AD4C
	private static void smethod_183(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Type type = class27_0.method_80(int_, true);
		Class44 class44_5 = Class44.smethod_0(class27_0.method_37().vmethod_0(), type);
		class27_0.method_22(class44_5);
	}

	// Token: 0x06000212 RID: 530 RVA: 0x0000CB88 File Offset: 0x0000AD88
	private static void smethod_184(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_28(0);
	}

	// Token: 0x06000213 RID: 531 RVA: 0x0000CB94 File Offset: 0x0000AD94
	private Class44 method_82(Class44 class44_4)
	{
		if (class44_4.method_0() == 7)
		{
			return new Class54(-((Class54)class44_4).method_3());
		}
		if (class44_4.method_0() == 22)
		{
			return new Class56(-((Class56)class44_4).method_3());
		}
		if (class44_4.method_0() == 8)
		{
			Class58 @class = new Class58();
			@class.method_4(-((Class58)class44_4).method_3());
			return @class;
		}
		if (class44_4.method_0() != 2)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
		if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
		{
			return this.method_82(new Class56(Convert.ToInt64(class44_4.vmethod_0())));
		}
		return this.method_82(new Class54(Convert.ToInt32(class44_4.vmethod_0())));
	}

	// Token: 0x06000214 RID: 532 RVA: 0x0000CC74 File Offset: 0x0000AE74
	private static void smethod_185(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_16(Class27.type_2);
	}

	// Token: 0x06000215 RID: 533 RVA: 0x0000CC84 File Offset: 0x0000AE84
	private static void smethod_186(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_20(true);
	}

	// Token: 0x06000216 RID: 534 RVA: 0x0000CC90 File Offset: 0x0000AE90
	private static void smethod_187(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		ulong long_;
		if (num <= 7)
		{
			if (num == 2)
			{
				long_ = Convert.ToUInt64(((Class53)@class).method_3());
				goto IL_CF;
			}
			if (num == 7)
			{
				long_ = (ulong)((Class54)@class).method_3();
				goto IL_CF;
			}
		}
		else
		{
			if (num == 8)
			{
				long_ = checked((ulong)((Class58)@class).method_3());
				goto IL_CF;
			}
			if (num != 15)
			{
				if (num == 22)
				{
					long_ = (ulong)((Class56)@class).method_3();
					goto IL_CF;
				}
			}
			else
			{
				if (IntPtr.Size == 4)
				{
					long_ = (ulong)((int)((Class49)@class).method_3());
					goto IL_CF;
				}
				long_ = (ulong)((long)((Class49)@class).method_3());
				goto IL_CF;
			}
		}
		throw new InvalidOperationException();
		IL_CF:
		class27_0.method_22(new Class56((long)long_));
	}

	// Token: 0x06000217 RID: 535 RVA: 0x0000CD78 File Offset: 0x0000AF78
	private static BindingFlags smethod_188(bool bool_2)
	{
		BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
		if (bool_2)
		{
			bindingFlags |= BindingFlags.Static;
		}
		else
		{
			bindingFlags |= BindingFlags.Instance;
		}
		return bindingFlags;
	}

	// Token: 0x06000218 RID: 536 RVA: 0x0000CD98 File Offset: 0x0000AF98
	private static Dictionary<int, Class27.Struct4> smethod_189(Class102 class102_1)
	{
		return new Dictionary<int, Class27.Struct4>(256)
		{
			{
				class102_1.struct11_24.method_0(),
				new Class27.Struct4(class102_1.struct11_24, new Class27.Delegate21(Class27.smethod_166))
			},
			{
				class102_1.struct11_201.method_0(),
				new Class27.Struct4(class102_1.struct11_201, new Class27.Delegate21(Class27.smethod_145))
			},
			{
				class102_1.struct11_96.method_0(),
				new Class27.Struct4(class102_1.struct11_96, new Class27.Delegate21(Class27.smethod_144))
			},
			{
				class102_1.struct11_132.method_0(),
				new Class27.Struct4(class102_1.struct11_52, new Class27.Delegate21(Class27.smethod_44))
			},
			{
				class102_1.struct11_63.method_0(),
				new Class27.Struct4(class102_1.struct11_63, new Class27.Delegate21(Class27.smethod_108))
			},
			{
				class102_1.struct11_191.method_0(),
				new Class27.Struct4(class102_1.struct11_191, new Class27.Delegate21(Class27.smethod_120))
			},
			{
				class102_1.struct11_37.method_0(),
				new Class27.Struct4(class102_1.struct11_37, new Class27.Delegate21(Class27.smethod_194))
			},
			{
				class102_1.struct11_195.method_0(),
				new Class27.Struct4(class102_1.struct11_195, new Class27.Delegate21(Class27.smethod_87))
			},
			{
				class102_1.struct11_15.method_0(),
				new Class27.Struct4(class102_1.struct11_15, new Class27.Delegate21(Class27.smethod_59))
			},
			{
				class102_1.struct11_123.method_0(),
				new Class27.Struct4(class102_1.struct11_123, new Class27.Delegate21(Class27.smethod_227))
			},
			{
				class102_1.struct11_121.method_0(),
				new Class27.Struct4(class102_1.struct11_121, new Class27.Delegate21(Class27.smethod_96))
			},
			{
				class102_1.struct11_150.method_0(),
				new Class27.Struct4(class102_1.struct11_150, new Class27.Delegate21(Class27.smethod_178))
			},
			{
				class102_1.struct11_50.method_0(),
				new Class27.Struct4(class102_1.struct11_50, new Class27.Delegate21(Class27.smethod_174))
			},
			{
				class102_1.struct11_4.method_0(),
				new Class27.Struct4(class102_1.struct11_4, new Class27.Delegate21(Class27.smethod_71))
			},
			{
				class102_1.struct11_27.method_0(),
				new Class27.Struct4(class102_1.struct11_27, new Class27.Delegate21(Class27.smethod_17))
			},
			{
				class102_1.struct11_95.method_0(),
				new Class27.Struct4(class102_1.struct11_95, new Class27.Delegate21(Class27.smethod_223))
			},
			{
				class102_1.struct11_79.method_0(),
				new Class27.Struct4(class102_1.struct11_79, new Class27.Delegate21(Class27.smethod_216))
			},
			{
				class102_1.struct11_49.method_0(),
				new Class27.Struct4(class102_1.struct11_49, new Class27.Delegate21(Class27.smethod_86))
			},
			{
				class102_1.struct11_183.method_0(),
				new Class27.Struct4(class102_1.struct11_183, new Class27.Delegate21(Class27.smethod_233))
			},
			{
				class102_1.struct11_97.method_0(),
				new Class27.Struct4(class102_1.struct11_97, new Class27.Delegate21(Class27.smethod_75))
			},
			{
				class102_1.struct11_139.method_0(),
				new Class27.Struct4(class102_1.struct11_139, new Class27.Delegate21(Class27.smethod_161))
			},
			{
				class102_1.struct11_203.method_0(),
				new Class27.Struct4(class102_1.struct11_203, new Class27.Delegate21(Class27.smethod_115))
			},
			{
				class102_1.struct11_163.method_0(),
				new Class27.Struct4(class102_1.struct11_163, new Class27.Delegate21(Class27.smethod_164))
			},
			{
				class102_1.struct11_149.method_0(),
				new Class27.Struct4(class102_1.struct11_149, new Class27.Delegate21(Class27.smethod_52))
			},
			{
				class102_1.struct11_160.method_0(),
				new Class27.Struct4(class102_1.struct11_160, new Class27.Delegate21(Class27.smethod_21))
			},
			{
				class102_1.struct11_14.method_0(),
				new Class27.Struct4(class102_1.struct11_14, new Class27.Delegate21(Class27.smethod_136))
			},
			{
				class102_1.struct11_197.method_0(),
				new Class27.Struct4(class102_1.struct11_197, new Class27.Delegate21(Class27.smethod_98))
			},
			{
				class102_1.struct11_57.method_0(),
				new Class27.Struct4(class102_1.struct11_57, new Class27.Delegate21(Class27.smethod_219))
			},
			{
				class102_1.struct11_124.method_0(),
				new Class27.Struct4(class102_1.struct11_124, new Class27.Delegate21(Class27.smethod_159))
			},
			{
				class102_1.struct11_117.method_0(),
				new Class27.Struct4(class102_1.struct11_117, new Class27.Delegate21(Class27.smethod_39))
			},
			{
				class102_1.struct11_106.method_0(),
				new Class27.Struct4(class102_1.struct11_106, new Class27.Delegate21(Class27.smethod_8))
			},
			{
				class102_1.struct11_105.method_0(),
				new Class27.Struct4(class102_1.struct11_105, new Class27.Delegate21(Class27.smethod_74))
			},
			{
				class102_1.struct11_135.method_0(),
				new Class27.Struct4(class102_1.struct11_135, new Class27.Delegate21(Class27.smethod_34))
			},
			{
				class102_1.struct11_177.method_0(),
				new Class27.Struct4(class102_1.struct11_177, new Class27.Delegate21(Class27.smethod_60))
			},
			{
				class102_1.struct11_153.method_0(),
				new Class27.Struct4(class102_1.struct11_153, new Class27.Delegate21(Class27.smethod_200))
			},
			{
				class102_1.struct11_73.method_0(),
				new Class27.Struct4(class102_1.struct11_73, new Class27.Delegate21(Class27.smethod_211))
			},
			{
				class102_1.struct11_189.method_0(),
				new Class27.Struct4(class102_1.struct11_189, new Class27.Delegate21(Class27.smethod_140))
			},
			{
				class102_1.struct11_45.method_0(),
				new Class27.Struct4(class102_1.struct11_45, new Class27.Delegate21(Class27.smethod_217))
			},
			{
				class102_1.struct11_167.method_0(),
				new Class27.Struct4(class102_1.struct11_167, new Class27.Delegate21(Class27.smethod_132))
			},
			{
				class102_1.struct11_35.method_0(),
				new Class27.Struct4(class102_1.struct11_35, new Class27.Delegate21(Class27.smethod_40))
			},
			{
				class102_1.struct11_133.method_0(),
				new Class27.Struct4(class102_1.struct11_133, new Class27.Delegate21(Class27.smethod_182))
			},
			{
				class102_1.struct11_86.method_0(),
				new Class27.Struct4(class102_1.struct11_86, new Class27.Delegate21(Class27.smethod_163))
			},
			{
				class102_1.struct11_90.method_0(),
				new Class27.Struct4(class102_1.struct11_90, new Class27.Delegate21(Class27.smethod_198))
			},
			{
				class102_1.struct11_146.method_0(),
				new Class27.Struct4(class102_1.struct11_146, new Class27.Delegate21(Class27.smethod_186))
			},
			{
				class102_1.struct11_112.method_0(),
				new Class27.Struct4(class102_1.struct11_112, new Class27.Delegate21(Class27.smethod_91))
			},
			{
				class102_1.struct11_60.method_0(),
				new Class27.Struct4(class102_1.struct11_60, new Class27.Delegate21(Class27.smethod_81))
			},
			{
				class102_1.struct11_171.method_0(),
				new Class27.Struct4(class102_1.struct11_171, new Class27.Delegate21(Class27.smethod_78))
			},
			{
				class102_1.struct11_26.method_0(),
				new Class27.Struct4(class102_1.struct11_26, new Class27.Delegate21(Class27.smethod_243))
			},
			{
				class102_1.struct11_59.method_0(),
				new Class27.Struct4(class102_1.struct11_59, new Class27.Delegate21(Class27.smethod_28))
			},
			{
				class102_1.struct11_114.method_0(),
				new Class27.Struct4(class102_1.struct11_114, new Class27.Delegate21(Class27.smethod_85))
			},
			{
				class102_1.struct11_179.method_0(),
				new Class27.Struct4(class102_1.struct11_179, new Class27.Delegate21(Class27.smethod_93))
			},
			{
				class102_1.struct11_34.method_0(),
				new Class27.Struct4(class102_1.struct11_34, new Class27.Delegate21(Class27.smethod_133))
			},
			{
				class102_1.struct11_126.method_0(),
				new Class27.Struct4(class102_1.struct11_126, new Class27.Delegate21(Class27.smethod_160))
			},
			{
				class102_1.struct11_87.method_0(),
				new Class27.Struct4(class102_1.struct11_87, new Class27.Delegate21(Class27.smethod_141))
			},
			{
				class102_1.struct11_43.method_0(),
				new Class27.Struct4(class102_1.struct11_43, new Class27.Delegate21(Class27.smethod_45))
			},
			{
				class102_1.struct11_23.method_0(),
				new Class27.Struct4(class102_1.struct11_23, new Class27.Delegate21(Class27.smethod_53))
			},
			{
				class102_1.struct11_7.method_0(),
				new Class27.Struct4(class102_1.struct11_7, new Class27.Delegate21(Class27.smethod_142))
			},
			{
				class102_1.struct11_88.method_0(),
				new Class27.Struct4(class102_1.struct11_88, new Class27.Delegate21(Class27.smethod_97))
			},
			{
				class102_1.struct11_42.method_0(),
				new Class27.Struct4(class102_1.struct11_42, new Class27.Delegate21(Class27.smethod_33))
			},
			{
				class102_1.struct11_209.method_0(),
				new Class27.Struct4(class102_1.struct11_209, new Class27.Delegate21(Class27.smethod_131))
			},
			{
				class102_1.struct11_31.method_0(),
				new Class27.Struct4(class102_1.struct11_31, new Class27.Delegate21(Class27.smethod_67))
			},
			{
				class102_1.struct11_65.method_0(),
				new Class27.Struct4(class102_1.struct11_65, new Class27.Delegate21(Class27.smethod_36))
			},
			{
				class102_1.struct11_151.method_0(),
				new Class27.Struct4(class102_1.struct11_151, new Class27.Delegate21(Class27.smethod_72))
			},
			{
				class102_1.struct11_116.method_0(),
				new Class27.Struct4(class102_1.struct11_116, new Class27.Delegate21(Class27.smethod_203))
			},
			{
				class102_1.struct11_44.method_0(),
				new Class27.Struct4(class102_1.struct11_44, new Class27.Delegate21(Class27.smethod_123))
			},
			{
				class102_1.struct11_180.method_0(),
				new Class27.Struct4(class102_1.struct11_180, new Class27.Delegate21(Class27.smethod_241))
			},
			{
				class102_1.struct11_129.method_0(),
				new Class27.Struct4(class102_1.struct11_129, new Class27.Delegate21(Class27.smethod_119))
			},
			{
				class102_1.struct11_53.method_0(),
				new Class27.Struct4(class102_1.struct11_53, new Class27.Delegate21(Class27.smethod_79))
			},
			{
				class102_1.struct11_109.method_0(),
				new Class27.Struct4(class102_1.struct11_109, new Class27.Delegate21(Class27.smethod_191))
			},
			{
				class102_1.struct11_77.method_0(),
				new Class27.Struct4(class102_1.struct11_77, new Class27.Delegate21(Class27.smethod_235))
			},
			{
				class102_1.struct11_17.method_0(),
				new Class27.Struct4(class102_1.struct11_17, new Class27.Delegate21(Class27.smethod_170))
			},
			{
				class102_1.struct11_38.method_0(),
				new Class27.Struct4(class102_1.struct11_38, new Class27.Delegate21(Class27.smethod_106))
			},
			{
				class102_1.struct11_1.method_0(),
				new Class27.Struct4(class102_1.struct11_1, new Class27.Delegate21(Class27.smethod_234))
			},
			{
				class102_1.struct11_69.method_0(),
				new Class27.Struct4(class102_1.struct11_69, new Class27.Delegate21(Class27.smethod_212))
			},
			{
				class102_1.struct11_102.method_0(),
				new Class27.Struct4(class102_1.struct11_102, new Class27.Delegate21(Class27.smethod_193))
			},
			{
				class102_1.struct11_125.method_0(),
				new Class27.Struct4(class102_1.struct11_125, new Class27.Delegate21(Class27.smethod_27))
			},
			{
				class102_1.struct11_56.method_0(),
				new Class27.Struct4(class102_1.struct11_56, new Class27.Delegate21(Class27.smethod_70))
			},
			{
				class102_1.struct11_100.method_0(),
				new Class27.Struct4(class102_1.struct11_100, new Class27.Delegate21(Class27.smethod_158))
			},
			{
				class102_1.struct11_98.method_0(),
				new Class27.Struct4(class102_1.struct11_98, new Class27.Delegate21(Class27.smethod_102))
			},
			{
				class102_1.struct11_212.method_0(),
				new Class27.Struct4(class102_1.struct11_212, new Class27.Delegate21(Class27.smethod_244))
			},
			{
				class102_1.struct11_3.method_0(),
				new Class27.Struct4(class102_1.struct11_3, new Class27.Delegate21(Class27.smethod_139))
			},
			{
				class102_1.struct11_207.method_0(),
				new Class27.Struct4(class102_1.struct11_207, new Class27.Delegate21(Class27.smethod_14))
			},
			{
				class102_1.struct11_178.method_0(),
				new Class27.Struct4(class102_1.struct11_178, new Class27.Delegate21(Class27.smethod_220))
			},
			{
				class102_1.struct11_6.method_0(),
				new Class27.Struct4(class102_1.struct11_6, new Class27.Delegate21(Class27.smethod_20))
			},
			{
				class102_1.struct11_170.method_0(),
				new Class27.Struct4(class102_1.struct11_170, new Class27.Delegate21(Class27.smethod_61))
			},
			{
				class102_1.struct11_16.method_0(),
				new Class27.Struct4(class102_1.struct11_16, new Class27.Delegate21(Class27.smethod_210))
			},
			{
				class102_1.struct11_39.method_0(),
				new Class27.Struct4(class102_1.struct11_39, new Class27.Delegate21(Class27.smethod_196))
			},
			{
				class102_1.struct11_64.method_0(),
				new Class27.Struct4(class102_1.struct11_64, new Class27.Delegate21(Class27.smethod_13))
			},
			{
				class102_1.struct11_111.method_0(),
				new Class27.Struct4(class102_1.struct11_111, new Class27.Delegate21(Class27.smethod_69))
			},
			{
				class102_1.struct11_92.method_0(),
				new Class27.Struct4(class102_1.struct11_92, new Class27.Delegate21(Class27.smethod_22))
			},
			{
				class102_1.struct11_122.method_0(),
				new Class27.Struct4(class102_1.struct11_122, new Class27.Delegate21(Class27.smethod_65))
			},
			{
				class102_1.struct11_46.method_0(),
				new Class27.Struct4(class102_1.struct11_46, new Class27.Delegate21(Class27.smethod_202))
			},
			{
				class102_1.struct11_104.method_0(),
				new Class27.Struct4(class102_1.struct11_104, new Class27.Delegate21(Class27.smethod_247))
			},
			{
				class102_1.struct11_194.method_0(),
				new Class27.Struct4(class102_1.struct11_194, new Class27.Delegate21(Class27.smethod_84))
			},
			{
				class102_1.struct11_169.method_0(),
				new Class27.Struct4(class102_1.struct11_169, new Class27.Delegate21(Class27.smethod_242))
			},
			{
				class102_1.struct11_143.method_0(),
				new Class27.Struct4(class102_1.struct11_143, new Class27.Delegate21(Class27.smethod_146))
			},
			{
				class102_1.struct11_156.method_0(),
				new Class27.Struct4(class102_1.struct11_156, new Class27.Delegate21(Class27.smethod_104))
			},
			{
				class102_1.struct11_172.method_0(),
				new Class27.Struct4(class102_1.struct11_172, new Class27.Delegate21(Class27.smethod_12))
			},
			{
				class102_1.struct11_18.method_0(),
				new Class27.Struct4(class102_1.struct11_18, new Class27.Delegate21(Class27.smethod_137))
			},
			{
				class102_1.struct11_138.method_0(),
				new Class27.Struct4(class102_1.struct11_138, new Class27.Delegate21(Class27.smethod_117))
			},
			{
				class102_1.struct11_182.method_0(),
				new Class27.Struct4(class102_1.struct11_182, new Class27.Delegate21(Class27.smethod_151))
			},
			{
				class102_1.struct11_205.method_0(),
				new Class27.Struct4(class102_1.struct11_205, new Class27.Delegate21(Class27.smethod_183))
			},
			{
				class102_1.struct11_99.method_0(),
				new Class27.Struct4(class102_1.struct11_99, new Class27.Delegate21(Class27.smethod_147))
			},
			{
				class102_1.struct11_80.method_0(),
				new Class27.Struct4(class102_1.struct11_80, new Class27.Delegate21(Class27.smethod_184))
			},
			{
				class102_1.struct11_40.method_0(),
				new Class27.Struct4(class102_1.struct11_40, new Class27.Delegate21(Class27.smethod_135))
			},
			{
				class102_1.struct11_9.method_0(),
				new Class27.Struct4(class102_1.struct11_9, new Class27.Delegate21(Class27.smethod_101))
			},
			{
				class102_1.struct11_107.method_0(),
				new Class27.Struct4(class102_1.struct11_107, new Class27.Delegate21(Class27.smethod_239))
			},
			{
				class102_1.struct11_108.method_0(),
				new Class27.Struct4(class102_1.struct11_108, new Class27.Delegate21(Class27.smethod_205))
			},
			{
				class102_1.struct11_147.method_0(),
				new Class27.Struct4(class102_1.struct11_147, new Class27.Delegate21(Class27.smethod_88))
			},
			{
				class102_1.struct11_29.method_0(),
				new Class27.Struct4(class102_1.struct11_29, new Class27.Delegate21(Class27.smethod_63))
			},
			{
				class102_1.struct11_213.method_0(),
				new Class27.Struct4(class102_1.struct11_213, new Class27.Delegate21(Class27.smethod_187))
			},
			{
				class102_1.struct11_192.method_0(),
				new Class27.Struct4(class102_1.struct11_192, new Class27.Delegate21(Class27.smethod_54))
			},
			{
				class102_1.struct11_158.method_0(),
				new Class27.Struct4(class102_1.struct11_158, new Class27.Delegate21(Class27.smethod_236))
			},
			{
				class102_1.struct11_187.method_0(),
				new Class27.Struct4(class102_1.struct11_187, new Class27.Delegate21(Class27.smethod_249))
			},
			{
				class102_1.struct11_168.method_0(),
				new Class27.Struct4(class102_1.struct11_168, new Class27.Delegate21(Class27.smethod_171))
			},
			{
				class102_1.struct11_137.method_0(),
				new Class27.Struct4(class102_1.struct11_137, new Class27.Delegate21(Class27.smethod_129))
			},
			{
				class102_1.struct11_184.method_0(),
				new Class27.Struct4(class102_1.struct11_184, new Class27.Delegate21(Class27.smethod_224))
			},
			{
				class102_1.struct11_175.method_0(),
				new Class27.Struct4(class102_1.struct11_175, new Class27.Delegate21(Class27.smethod_167))
			},
			{
				class102_1.struct11_204.method_0(),
				new Class27.Struct4(class102_1.struct11_204, new Class27.Delegate21(Class27.smethod_94))
			},
			{
				class102_1.struct11_19.method_0(),
				new Class27.Struct4(class102_1.struct11_19, new Class27.Delegate21(Class27.smethod_95))
			},
			{
				class102_1.struct11_67.method_0(),
				new Class27.Struct4(class102_1.struct11_67, new Class27.Delegate21(Class27.smethod_214))
			},
			{
				class102_1.struct11_54.method_0(),
				new Class27.Struct4(class102_1.struct11_54, new Class27.Delegate21(Class27.smethod_121))
			},
			{
				class102_1.struct11_120.method_0(),
				new Class27.Struct4(class102_1.struct11_120, new Class27.Delegate21(Class27.smethod_9))
			},
			{
				class102_1.struct11_32.method_0(),
				new Class27.Struct4(class102_1.struct11_32, new Class27.Delegate21(Class27.smethod_43))
			},
			{
				class102_1.struct11_47.method_0(),
				new Class27.Struct4(class102_1.struct11_47, new Class27.Delegate21(Class27.smethod_231))
			},
			{
				class102_1.struct11_186.method_0(),
				new Class27.Struct4(class102_1.struct11_186, new Class27.Delegate21(Class27.smethod_222))
			},
			{
				class102_1.struct11_154.method_0(),
				new Class27.Struct4(class102_1.struct11_154, new Class27.Delegate21(Class27.smethod_29))
			},
			{
				class102_1.struct11_70.method_0(),
				new Class27.Struct4(class102_1.struct11_70, new Class27.Delegate21(Class27.smethod_230))
			},
			{
				class102_1.struct11_119.method_0(),
				new Class27.Struct4(class102_1.struct11_119, new Class27.Delegate21(Class27.smethod_122))
			},
			{
				class102_1.struct11_174.method_0(),
				new Class27.Struct4(class102_1.struct11_174, new Class27.Delegate21(Class27.smethod_62))
			},
			{
				class102_1.struct11_55.method_0(),
				new Class27.Struct4(class102_1.struct11_55, new Class27.Delegate21(Class27.smethod_128))
			},
			{
				class102_1.struct11_196.method_0(),
				new Class27.Struct4(class102_1.struct11_196, new Class27.Delegate21(Class27.smethod_51))
			},
			{
				class102_1.struct11_0.method_0(),
				new Class27.Struct4(class102_1.struct11_0, new Class27.Delegate21(Class27.smethod_41))
			},
			{
				class102_1.struct11_93.method_0(),
				new Class27.Struct4(class102_1.struct11_93, new Class27.Delegate21(Class27.smethod_25))
			},
			{
				class102_1.struct11_36.method_0(),
				new Class27.Struct4(class102_1.struct11_36, new Class27.Delegate21(Class27.smethod_107))
			},
			{
				class102_1.struct11_199.method_0(),
				new Class27.Struct4(class102_1.struct11_199, new Class27.Delegate21(Class27.smethod_82))
			},
			{
				class102_1.struct11_142.method_0(),
				new Class27.Struct4(class102_1.struct11_142, new Class27.Delegate21(Class27.smethod_58))
			},
			{
				class102_1.struct11_8.method_0(),
				new Class27.Struct4(class102_1.struct11_8, new Class27.Delegate21(Class27.smethod_80))
			},
			{
				class102_1.struct11_21.method_0(),
				new Class27.Struct4(class102_1.struct11_21, new Class27.Delegate21(Class27.smethod_162))
			},
			{
				class102_1.struct11_22.method_0(),
				new Class27.Struct4(class102_1.struct11_22, new Class27.Delegate21(Class27.smethod_30))
			},
			{
				class102_1.struct11_30.method_0(),
				new Class27.Struct4(class102_1.struct11_30, new Class27.Delegate21(Class27.smethod_0))
			},
			{
				class102_1.struct11_159.method_0(),
				new Class27.Struct4(class102_1.struct11_159, new Class27.Delegate21(Class27.smethod_76))
			},
			{
				class102_1.struct11_101.method_0(),
				new Class27.Struct4(class102_1.struct11_101, new Class27.Delegate21(Class27.smethod_56))
			},
			{
				class102_1.struct11_110.method_0(),
				new Class27.Struct4(class102_1.struct11_110, new Class27.Delegate21(Class27.smethod_185))
			},
			{
				class102_1.struct11_161.method_0(),
				new Class27.Struct4(class102_1.struct11_161, new Class27.Delegate21(Class27.smethod_195))
			},
			{
				class102_1.struct11_20.method_0(),
				new Class27.Struct4(class102_1.struct11_20, new Class27.Delegate21(Class27.smethod_5))
			},
			{
				class102_1.struct11_58.method_0(),
				new Class27.Struct4(class102_1.struct11_58, new Class27.Delegate21(Class27.smethod_175))
			},
			{
				class102_1.struct11_214.method_0(),
				new Class27.Struct4(class102_1.struct11_214, new Class27.Delegate21(Class27.smethod_16))
			},
			{
				class102_1.struct11_5.method_0(),
				new Class27.Struct4(class102_1.struct11_5, new Class27.Delegate21(Class27.smethod_177))
			},
			{
				class102_1.struct11_78.method_0(),
				new Class27.Struct4(class102_1.struct11_78, new Class27.Delegate21(Class27.smethod_192))
			},
			{
				class102_1.struct11_83.method_0(),
				new Class27.Struct4(class102_1.struct11_83, new Class27.Delegate21(Class27.smethod_232))
			},
			{
				class102_1.struct11_181.method_0(),
				new Class27.Struct4(class102_1.struct11_181, new Class27.Delegate21(Class27.smethod_153))
			},
			{
				class102_1.struct11_2.method_0(),
				new Class27.Struct4(class102_1.struct11_2, new Class27.Delegate21(Class27.smethod_42))
			},
			{
				class102_1.struct11_71.method_0(),
				new Class27.Struct4(class102_1.struct11_71, new Class27.Delegate21(Class27.smethod_68))
			},
			{
				class102_1.struct11_91.method_0(),
				new Class27.Struct4(class102_1.struct11_91, new Class27.Delegate21(Class27.smethod_109))
			},
			{
				class102_1.struct11_190.method_0(),
				new Class27.Struct4(class102_1.struct11_190, new Class27.Delegate21(Class27.smethod_237))
			},
			{
				class102_1.struct11_144.method_0(),
				new Class27.Struct4(class102_1.struct11_144, new Class27.Delegate21(Class27.smethod_207))
			},
			{
				class102_1.struct11_68.method_0(),
				new Class27.Struct4(class102_1.struct11_68, new Class27.Delegate21(Class27.smethod_157))
			},
			{
				class102_1.struct11_76.method_0(),
				new Class27.Struct4(class102_1.struct11_76, new Class27.Delegate21(Class27.smethod_221))
			},
			{
				class102_1.struct11_61.method_0(),
				new Class27.Struct4(class102_1.struct11_61, new Class27.Delegate21(Class27.smethod_148))
			},
			{
				class102_1.struct11_81.method_0(),
				new Class27.Struct4(class102_1.struct11_81, new Class27.Delegate21(Class27.smethod_179))
			},
			{
				class102_1.struct11_141.method_0(),
				new Class27.Struct4(class102_1.struct11_141, new Class27.Delegate21(Class27.smethod_24))
			},
			{
				class102_1.struct11_118.method_0(),
				new Class27.Struct4(class102_1.struct11_118, new Class27.Delegate21(Class27.smethod_100))
			},
			{
				class102_1.struct11_148.method_0(),
				new Class27.Struct4(class102_1.struct11_148, new Class27.Delegate21(Class27.smethod_173))
			},
			{
				class102_1.struct11_173.method_0(),
				new Class27.Struct4(class102_1.struct11_173, new Class27.Delegate21(Class27.smethod_77))
			},
			{
				class102_1.struct11_206.method_0(),
				new Class27.Struct4(class102_1.struct11_206, new Class27.Delegate21(Class27.smethod_112))
			},
			{
				class102_1.struct11_166.method_0(),
				new Class27.Struct4(class102_1.struct11_166, new Class27.Delegate21(Class27.smethod_180))
			},
			{
				class102_1.struct11_75.method_0(),
				new Class27.Struct4(class102_1.struct11_75, new Class27.Delegate21(Class27.smethod_64))
			},
			{
				class102_1.struct11_200.method_0(),
				new Class27.Struct4(class102_1.struct11_200, new Class27.Delegate21(Class27.smethod_126))
			},
			{
				class102_1.struct11_152.method_0(),
				new Class27.Struct4(class102_1.struct11_152, new Class27.Delegate21(Class27.smethod_6))
			},
			{
				class102_1.struct11_145.method_0(),
				new Class27.Struct4(class102_1.struct11_145, new Class27.Delegate21(Class27.smethod_23))
			},
			{
				class102_1.struct11_103.method_0(),
				new Class27.Struct4(class102_1.struct11_103, new Class27.Delegate21(Class27.smethod_103))
			},
			{
				class102_1.struct11_82.method_0(),
				new Class27.Struct4(class102_1.struct11_82, new Class27.Delegate21(Class27.smethod_206))
			},
			{
				class102_1.struct11_165.method_0(),
				new Class27.Struct4(class102_1.struct11_165, new Class27.Delegate21(Class27.smethod_218))
			},
			{
				class102_1.struct11_84.method_0(),
				new Class27.Struct4(class102_1.struct11_84, new Class27.Delegate21(Class27.smethod_238))
			},
			{
				class102_1.struct11_130.method_0(),
				new Class27.Struct4(class102_1.struct11_130, new Class27.Delegate21(Class27.smethod_89))
			},
			{
				class102_1.struct11_140.method_0(),
				new Class27.Struct4(class102_1.struct11_140, new Class27.Delegate21(Class27.smethod_114))
			},
			{
				class102_1.struct11_52.method_0(),
				new Class27.Struct4(class102_1.struct11_52, new Class27.Delegate21(Class27.smethod_124))
			},
			{
				class102_1.struct11_85.method_0(),
				new Class27.Struct4(class102_1.struct11_85, new Class27.Delegate21(Class27.smethod_156))
			},
			{
				class102_1.struct11_51.method_0(),
				new Class27.Struct4(class102_1.struct11_51, new Class27.Delegate21(Class27.smethod_73))
			},
			{
				class102_1.struct11_89.method_0(),
				new Class27.Struct4(class102_1.struct11_89, new Class27.Delegate21(Class27.smethod_172))
			},
			{
				class102_1.struct11_164.method_0(),
				new Class27.Struct4(class102_1.struct11_164, new Class27.Delegate21(Class27.smethod_7))
			},
			{
				class102_1.struct11_62.method_0(),
				new Class27.Struct4(class102_1.struct11_62, new Class27.Delegate21(Class27.smethod_47))
			},
			{
				class102_1.struct11_66.method_0(),
				new Class27.Struct4(class102_1.struct11_66, new Class27.Delegate21(Class27.smethod_15))
			},
			{
				class102_1.struct11_157.method_0(),
				new Class27.Struct4(class102_1.struct11_157, new Class27.Delegate21(Class27.smethod_154))
			},
			{
				class102_1.struct11_134.method_0(),
				new Class27.Struct4(class102_1.struct11_134, new Class27.Delegate21(Class27.smethod_155))
			},
			{
				class102_1.struct11_115.method_0(),
				new Class27.Struct4(class102_1.struct11_115, new Class27.Delegate21(Class27.smethod_208))
			},
			{
				class102_1.struct11_113.method_0(),
				new Class27.Struct4(class102_1.struct11_113, new Class27.Delegate21(Class27.smethod_55))
			},
			{
				class102_1.struct11_11.method_0(),
				new Class27.Struct4(class102_1.struct11_11, new Class27.Delegate21(Class27.smethod_190))
			},
			{
				class102_1.struct11_208.method_0(),
				new Class27.Struct4(class102_1.struct11_208, new Class27.Delegate21(Class27.smethod_99))
			},
			{
				class102_1.struct11_48.method_0(),
				new Class27.Struct4(class102_1.struct11_48, new Class27.Delegate21(Class27.smethod_83))
			},
			{
				class102_1.struct11_94.method_0(),
				new Class27.Struct4(class102_1.struct11_94, new Class27.Delegate21(Class27.smethod_204))
			},
			{
				class102_1.struct11_210.method_0(),
				new Class27.Struct4(class102_1.struct11_210, new Class27.Delegate21(Class27.smethod_66))
			},
			{
				class102_1.struct11_211.method_0(),
				new Class27.Struct4(class102_1.struct11_211, new Class27.Delegate21(Class27.smethod_49))
			},
			{
				class102_1.struct11_127.method_0(),
				new Class27.Struct4(class102_1.struct11_127, new Class27.Delegate21(Class27.smethod_209))
			},
			{
				class102_1.struct11_25.method_0(),
				new Class27.Struct4(class102_1.struct11_25, new Class27.Delegate21(Class27.smethod_248))
			},
			{
				class102_1.struct11_188.method_0(),
				new Class27.Struct4(class102_1.struct11_188, new Class27.Delegate21(Class27.smethod_201))
			},
			{
				class102_1.struct11_198.method_0(),
				new Class27.Struct4(class102_1.struct11_198, new Class27.Delegate21(Class27.smethod_19))
			},
			{
				class102_1.struct11_28.method_0(),
				new Class27.Struct4(class102_1.struct11_28, new Class27.Delegate21(Class27.smethod_225))
			},
			{
				class102_1.struct11_41.method_0(),
				new Class27.Struct4(class102_1.struct11_41, new Class27.Delegate21(Class27.smethod_138))
			},
			{
				class102_1.struct11_33.method_0(),
				new Class27.Struct4(class102_1.struct11_33, new Class27.Delegate21(Class27.smethod_18))
			},
			{
				class102_1.struct11_12.method_0(),
				new Class27.Struct4(class102_1.struct11_12, new Class27.Delegate21(Class27.smethod_113))
			},
			{
				class102_1.struct11_72.method_0(),
				new Class27.Struct4(class102_1.struct11_72, new Class27.Delegate21(Class27.smethod_246))
			},
			{
				class102_1.struct11_155.method_0(),
				new Class27.Struct4(class102_1.struct11_155, new Class27.Delegate21(Class27.smethod_57))
			},
			{
				class102_1.struct11_131.method_0(),
				new Class27.Struct4(class102_1.struct11_131, new Class27.Delegate21(Class27.smethod_1))
			}
		};
	}

	// Token: 0x06000219 RID: 537 RVA: 0x0000F020 File Offset: 0x0000D220
	private static void smethod_190(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_98((int)((Class48)class44_4).method_3());
	}

	// Token: 0x0600021A RID: 538 RVA: 0x0000F034 File Offset: 0x0000D234
	private static void smethod_191(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_53(false);
	}

	// Token: 0x0600021B RID: 539 RVA: 0x0000F040 File Offset: 0x0000D240
	private static void smethod_192(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_89(false);
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0000F04C File Offset: 0x0000D24C
	private Class44 method_83(Class61 class61_0)
	{
		int num = class61_0.method_0();
		if (num <= 13)
		{
			if (num == 1)
			{
				goto IL_69;
			}
			if (num == 13)
			{
				return this.class44_0[((Class63)class61_0).method_3()];
			}
		}
		else
		{
			if (num == 18)
			{
				Class62 @class = (Class62)class61_0;
				return Class44.smethod_0(@class.method_5().GetValue(@class.method_3()), null);
			}
			if (num == 21)
			{
				goto IL_69;
			}
			if (num == 23)
			{
				return ((Class64)class61_0).method_3();
			}
		}
		throw new ArgumentOutOfRangeException();
		IL_69:
		Class65 class2 = (Class65)class61_0;
		return Class44.smethod_0(class2.vmethod_4(), class2.method_3());
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000F0FC File Offset: 0x0000D2FC
	private static void smethod_193(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		FieldInfo fieldInfo = class27_0.method_27(int_);
		Class44 @class = Class44.smethod_0(class27_0.method_37().vmethod_0(), fieldInfo.FieldType);
		fieldInfo.SetValue(null, @class.vmethod_0());
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0000F144 File Offset: 0x0000D344
	private static void smethod_194(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_37();
	}

	// Token: 0x0600021F RID: 543 RVA: 0x0000F150 File Offset: 0x0000D350
	private static void smethod_195(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_28(2);
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0000F15C File Offset: 0x0000D35C
	private void method_84()
	{
		Class27.smethod_32<Class125>(this.class125_0, new Comparison<Class125>(Class27.Class32.class32_0.method_0));
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000F188 File Offset: 0x0000D388
	private static void smethod_196(Class27 class27_0, Class44 class44_4)
	{
		if (class27_0.object_0 == null)
		{
			throw new InvalidOperationException();
		}
		class27_0.method_104(class27_0.object_0);
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0000F1A4 File Offset: 0x0000D3A4
	public object method_85(Stream stream_1, string string_0, object[] object_3, Type[] type_9, Type[] type_10, object[] object_4)
	{
		this.stream_0 = stream_1;
		this.method_55(stream_1, string_0);
		return this.method_54(object_3, type_9, type_10, object_4);
	}

	// Token: 0x06000223 RID: 547 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
	private static void smethod_197(Exception exception_0)
	{
		ExceptionDispatchInfo.Capture(exception_0).Throw();
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0000F1D4 File Offset: 0x0000D3D4
	private static void smethod_198(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		checked
		{
			IntPtr intptr_;
			if (num <= 7)
			{
				if (num == 2)
				{
					intptr_ = new IntPtr((long)Convert.ToUInt64(((Class53)@class).method_3()));
					goto IL_A9;
				}
				if (num == 7)
				{
					intptr_ = new IntPtr((long)(unchecked((ulong)(checked((uint)((Class54)@class).method_3())))));
					goto IL_A9;
				}
			}
			else
			{
				if (num == 8)
				{
					intptr_ = new IntPtr((long)((Class58)@class).method_3());
					goto IL_A9;
				}
				if (num == 22)
				{
					intptr_ = new IntPtr((long)((ulong)((Class56)@class).method_3()));
					goto IL_A9;
				}
			}
			throw new InvalidOperationException();
			IL_A9:
			Class49 class2 = new Class49();
			class2.method_4(intptr_);
			class27_0.method_22(class2);
		}
	}

	// Token: 0x06000225 RID: 549 RVA: 0x0000F29C File Offset: 0x0000D49C
	private static Exception smethod_199(string string_0, string string_1)
	{
		return new TypeLoadException(Class27.smethod_105("security transparent method '" + string_0 + "'", "security critical type '" + string_1 + "'"));
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
	private static void smethod_200(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_51();
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
	private static void smethod_201(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		class27_0.method_104(@class.vmethod_0());
	}

	// Token: 0x06000228 RID: 552 RVA: 0x0000F2F0 File Offset: 0x0000D4F0
	private static void smethod_202(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_6(false);
	}

	// Token: 0x06000229 RID: 553 RVA: 0x0000F2FC File Offset: 0x0000D4FC
	private static void smethod_203(Class27 class27_0, Class44 class44_4)
	{
		throw new NotSupportedException("Initblk not supported.");
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0000F308 File Offset: 0x0000D508
	private static void smethod_204(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_51();
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0000F310 File Offset: 0x0000D510
	private static void smethod_205(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_48();
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000F318 File Offset: 0x0000D518
	private void method_86(bool bool_2)
	{
		Class44 @class = this.method_37();
		bool flag = IntPtr.Size == 4;
		int num = @class.method_0();
		IntPtr intptr_;
		if (num <= 7)
		{
			if (num != 2)
			{
				if (num == 7)
				{
					int num2 = ((Class54)@class).method_3();
					if (flag)
					{
						if (bool_2)
						{
							intptr_ = new IntPtr(checked((int)((uint)num2)));
							goto IL_199;
						}
						intptr_ = new IntPtr(num2);
						goto IL_199;
					}
					else
					{
						if (bool_2)
						{
							intptr_ = new IntPtr((long)((ulong)(checked((uint)num2))));
							goto IL_199;
						}
						intptr_ = new IntPtr((long)((ulong)num2));
						goto IL_199;
					}
				}
			}
			else
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(Convert.ToInt64(((Class53)@class).method_3()));
					goto IL_199;
				}
				intptr_ = new IntPtr(Convert.ToInt64(((Class53)@class).method_3()));
				goto IL_199;
			}
		}
		else if (num != 8)
		{
			if (num == 22)
			{
				long num3 = ((Class56)@class).method_3();
				if (flag)
				{
					if (bool_2)
					{
						intptr_ = new IntPtr(checked((int)((ulong)num3)));
						goto IL_199;
					}
					intptr_ = new IntPtr((int)num3);
					goto IL_199;
				}
				else
				{
					if (bool_2)
					{
						intptr_ = new IntPtr(checked((long)((ulong)num3)));
						goto IL_199;
					}
					intptr_ = new IntPtr(num3);
					goto IL_199;
				}
			}
		}
		else
		{
			double num4 = ((Class58)@class).method_3();
			if (flag)
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(checked((int)((ulong)num4)));
					goto IL_199;
				}
				intptr_ = new IntPtr((int)((ulong)num4));
				goto IL_199;
			}
			else
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(checked((long)((ulong)num4)));
					goto IL_199;
				}
				intptr_ = new IntPtr((long)num4);
				goto IL_199;
			}
		}
		throw new InvalidOperationException();
		IL_199:
		Class49 class2 = new Class49();
		class2.method_4(intptr_);
		this.method_22(class2);
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
	private static void smethod_206(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_51();
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0000F4DC File Offset: 0x0000D6DC
	private static void smethod_207(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		Class44 class44_6 = class27_0.method_37();
		class27_0.method_22(class27_0.method_33(class44_6, class44_5));
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0000F508 File Offset: 0x0000D708
	private void method_87(MemberInfo memberInfo_0)
	{
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0000F51C File Offset: 0x0000D71C
	private Class44[] method_88(object[] object_3)
	{
		Class126[] array = this.class10_0.method_2();
		int num = array.Length;
		Class44[] array2 = new Class44[num];
		for (int i = 0; i < num; i++)
		{
			object obj = object_3[i];
			Type type = this.method_80(array[i].method_0(), false);
			Type type2 = Class115.smethod_2(type);
			Type type3;
			if (type2 != Class115.type_0 && !Class115.smethod_0(type2))
			{
				type3 = ((obj != null) ? obj.GetType() : type);
			}
			else
			{
				type3 = type;
			}
			if (obj != null && !type.IsAssignableFrom(type3) && type.IsByRef && !type.GetElementType().IsAssignableFrom(type3))
			{
				throw new ArgumentException(string.Format("Object of type {0} cannot be converted to type {1}.", type3, type));
			}
			array2[i] = Class44.smethod_0(obj, type3);
		}
		if (!this.class10_0.method_12() && this.method_80(this.class10_0.method_6(), false).IsValueType)
		{
			Class44[] array3 = array2;
			int num2 = 0;
			Class64 @class = new Class64();
			@class.method_4(array2[0]);
			array3[num2] = @class;
		}
		for (int j = 0; j < num; j++)
		{
			if (array[j].method_2())
			{
				Class44[] array4 = array2;
				int num3 = j;
				Class64 class2 = new Class64();
				class2.method_4(array2[j]);
				array4[num3] = class2;
			}
		}
		return array2;
	}

	// Token: 0x06000231 RID: 561 RVA: 0x0000F688 File Offset: 0x0000D888
	private static void smethod_208(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_17(true, true);
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0000F694 File Offset: 0x0000D894
	private void method_89(bool bool_2)
	{
		Class44 @class = this.method_37();
		int num = @class.method_0();
		sbyte int_;
		if (num <= 7)
		{
			if (num != 2)
			{
				if (num == 7)
				{
					if (bool_2)
					{
						int_ = checked((sbyte)((Class54)@class).method_3());
						goto IL_173;
					}
					int_ = (sbyte)((Class54)@class).method_3();
					goto IL_173;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((sbyte)Convert.ToUInt64(((Class53)@class).method_3()));
					goto IL_173;
				}
				int_ = (sbyte)Convert.ToUInt64(((Class53)@class).method_3());
				goto IL_173;
			}
		}
		else if (num != 8)
		{
			if (num != 15)
			{
				if (num == 22)
				{
					if (bool_2)
					{
						int_ = checked((sbyte)((Class56)@class).method_3());
						goto IL_173;
					}
					int_ = (sbyte)((Class56)@class).method_3();
					goto IL_173;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = checked((sbyte)((int)((Class49)@class).method_3()));
					goto IL_173;
				}
				int_ = (sbyte)((int)((Class49)@class).method_3());
				goto IL_173;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((sbyte)((long)((Class49)@class).method_3()));
					goto IL_173;
				}
				int_ = (sbyte)((long)((Class49)@class).method_3());
				goto IL_173;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((sbyte)((Class58)@class).method_3());
				goto IL_173;
			}
			int_ = (sbyte)((Class58)@class).method_3();
			goto IL_173;
		}
		throw new InvalidOperationException();
		IL_173:
		Class54 class2 = new Class54();
		class2.method_4((int)int_);
		this.method_22(class2);
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000F828 File Offset: 0x0000DA28
	private static void smethod_209(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Type type = class27_0.method_80(int_, true);
		long long_ = class27_0.method_70();
		Array array_ = (Array)class27_0.method_37().vmethod_0();
		Class67 @class = new Class67();
		@class.method_6(array_);
		@class.method_4(type);
		@class.method_8(long_);
		class27_0.method_22(@class);
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000F884 File Offset: 0x0000DA84
	private static void smethod_210(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_9(false);
	}

	// Token: 0x06000235 RID: 565 RVA: 0x0000F890 File Offset: 0x0000DA90
	private static void smethod_211(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		checked
		{
			sbyte int_;
			if (num <= 7)
			{
				if (num == 2)
				{
					int_ = (sbyte)Convert.ToUInt64(((Class53)@class).method_3());
					goto IL_D6;
				}
				if (num == 7)
				{
					int_ = (sbyte)((uint)((Class54)@class).method_3());
					goto IL_D6;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (sbyte)((Class58)@class).method_3();
					goto IL_D6;
				}
				if (num != 15)
				{
					if (num == 22)
					{
						int_ = (sbyte)((ulong)((Class56)@class).method_3());
						goto IL_D6;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (sbyte)((uint)((int)((Class49)@class).method_3()));
						goto IL_D6;
					}
					int_ = (sbyte)((ulong)((long)((Class49)@class).method_3()));
					goto IL_D6;
				}
			}
			throw new InvalidOperationException();
			IL_D6:
			class27_0.method_22(new Class54((int)int_));
		}
	}

	// Token: 0x06000236 RID: 566 RVA: 0x0000F980 File Offset: 0x0000DB80
	private void method_90(bool bool_2)
	{
		Class44 class44_ = this.method_37();
		Class44 class44_2 = this.method_37();
		this.method_22(Class27.smethod_143(class44_2, class44_, bool_2));
	}

	// Token: 0x06000237 RID: 567 RVA: 0x0000F9AC File Offset: 0x0000DBAC
	private static void smethod_212(Class27 class27_0, Class44 class44_4)
	{
		object object_ = class27_0.method_37().vmethod_0();
		long num = class27_0.method_70();
		Array array = (Array)class27_0.method_37().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(long))
			{
				Class44 @class = Class44.smethod_0(object_, typeof(long));
				((long[])array)[(int)((IntPtr)num)] = (long)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(ulong))
			{
				Class44 class2 = Class44.smethod_0(object_, typeof(ulong));
				((ulong[])array)[(int)((IntPtr)num)] = (ulong)class2.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				class27_0.method_34(elementType, object_, num, array);
				return;
			}
			class27_0.method_34(typeof(long), object_, num, array);
		}
	}

	// Token: 0x06000238 RID: 568 RVA: 0x0000FA7C File Offset: 0x0000DC7C
	private static object smethod_213(MethodBase methodBase_0, object object_3, object[] object_4, bool bool_2)
	{
		Class27.Struct2 struct2_ = new Class27.Struct2(methodBase_0, bool_2);
		Class27.Delegate0 @delegate = Class27.smethod_245(struct2_);
		if (@delegate == null)
		{
			Dictionary<MethodBase, int> obj = Class27.dictionary_0;
			bool flag;
			lock (obj)
			{
				int num;
				Class27.dictionary_0.TryGetValue(methodBase_0, out num);
				if (!(flag = (num >= 50)))
				{
					Class27.dictionary_0[methodBase_0] = num + 1;
				}
			}
			if (!(flag = (flag || (!bool_2 && object_3 == null && !methodBase_0.IsStatic && !methodBase_0.IsConstructor) || Class27.smethod_134(methodBase_0) || (methodBase_0.CallingConvention & CallingConventions.Any) == CallingConventions.VarArgs)))
			{
				return Class27.smethod_31(methodBase_0, object_3, object_4);
			}
			@delegate = Class27.smethod_50(struct2_);
			obj = Class27.dictionary_0;
			lock (obj)
			{
				Class27.dictionary_0.Remove(methodBase_0);
			}
		}
		return @delegate(object_3, object_4);
	}

	// Token: 0x06000239 RID: 569 RVA: 0x0000FB68 File Offset: 0x0000DD68
	private static void smethod_214(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_71(1);
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0000FB74 File Offset: 0x0000DD74
	[Conditional("DEBUG")]
	public static void smethod_215(string string_0)
	{
	}

	// Token: 0x0600023B RID: 571 RVA: 0x0000FB78 File Offset: 0x0000DD78
	private void method_91(bool bool_2)
	{
		Class44 @class = this.method_37();
		int num = @class.method_0();
		ushort int_;
		if (num <= 7)
		{
			if (num != 2)
			{
				if (num == 7)
				{
					if (bool_2)
					{
						int_ = checked((ushort)((uint)((Class54)@class).method_3()));
						goto IL_176;
					}
					int_ = (ushort)((Class54)@class).method_3();
					goto IL_176;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((ushort)Convert.ToUInt64(((Class53)@class).method_3()));
					goto IL_176;
				}
				int_ = (ushort)Convert.ToUInt64(((Class53)@class).method_3());
				goto IL_176;
			}
		}
		else if (num != 8)
		{
			if (num != 15)
			{
				if (num == 22)
				{
					if (bool_2)
					{
						int_ = checked((ushort)((ulong)((Class56)@class).method_3()));
						goto IL_176;
					}
					int_ = (ushort)((Class56)@class).method_3();
					goto IL_176;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = checked((ushort)((int)((Class49)@class).method_3()));
					goto IL_176;
				}
				int_ = (ushort)((int)((Class49)@class).method_3());
				goto IL_176;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((ushort)((ulong)((long)((Class49)@class).method_3())));
					goto IL_176;
				}
				int_ = (ushort)((long)((Class49)@class).method_3());
				goto IL_176;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((ushort)((Class58)@class).method_3());
				goto IL_176;
			}
			int_ = (ushort)((Class58)@class).method_3();
			goto IL_176;
		}
		throw new InvalidOperationException();
		IL_176:
		this.method_22(new Class54((int)int_));
	}

	// Token: 0x0600023C RID: 572 RVA: 0x0000FD08 File Offset: 0x0000DF08
	private Class44 method_92(Class44 class44_4, Class44 class44_5)
	{
		if (class44_4.method_0() == 7)
		{
			if (class44_5.method_0() == 7)
			{
				int num = ((Class54)class44_4).method_3();
				int num2 = ((Class54)class44_5).method_3();
				return new Class54(num << num2);
			}
			if (class44_5.method_0() == 2)
			{
				return this.method_92(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())));
			}
		}
		if (class44_4.method_0() == 22)
		{
			if (class44_5.method_0() == 7)
			{
				long num3 = ((Class56)class44_4).method_3();
				int num4 = ((Class54)class44_5).method_3();
				return new Class56(num3 << num4);
			}
			if (class44_5.method_0() == 2)
			{
				return this.method_92(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())));
			}
		}
		if (class44_4.method_0() != 2)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
		if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
		{
			return this.method_92(new Class56(Convert.ToInt64(class44_4.vmethod_0())), class44_5);
		}
		return this.method_92(new Class54(Convert.ToInt32(class44_4.vmethod_0())), class44_5);
	}

	// Token: 0x0600023D RID: 573 RVA: 0x0000FE48 File Offset: 0x0000E048
	private static void smethod_216(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		FieldInfo fieldInfo_ = class27_0.method_27(int_);
		Class44 @class = class27_0.method_37();
		Class61 class2 = @class as Class61;
		object obj;
		if (class2 != null)
		{
			obj = class27_0.method_83(class2).vmethod_0();
		}
		else
		{
			obj = @class.vmethod_0();
		}
		class27_0.method_22(new Class62(fieldInfo_, obj, class2));
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
	private static void smethod_217(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_96(2);
	}

	// Token: 0x0600023F RID: 575 RVA: 0x0000FEAC File Offset: 0x0000E0AC
	private void method_93(bool bool_2)
	{
		uint num = this.uint_1;
		goto IL_63;
		for (;;)
		{
			try
			{
				do
				{
					if (this.nullable_0 != null)
					{
						this.uint_0 = this.nullable_0.Value;
						this.method_101((long)((ulong)this.uint_0));
						this.nullable_0 = null;
					}
					else if (this.uint_0 >= num)
					{
						break;
					}
					this.method_102();
					IL_63:;
				}
				while (!this.bool_0);
				break;
			}
			catch (object object_)
			{
				this.method_78(object_, 0U);
				if (!bool_2)
				{
					this.method_93(true);
					break;
				}
				goto IL_93;
			}
			IL_93:
			goto IL_63;
		}
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0000FF64 File Offset: 0x0000E164
	private bool method_94(MethodBase methodBase_0, object object_3, Class44[] class44_4, object[] object_4, bool bool_2, ref object object_5)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (declaringType == Class27.type_7 && methodBase_0.Name == "InitializeArray" && object_4.Length == 2 && methodBase_0.ToString() == "Void InitializeArray(System.Array, System.RuntimeFieldHandle)")
		{
			Class101.smethod_0((Array)object_4[0], (RuntimeFieldHandle)object_4[1]);
			return true;
		}
		return false;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x0000FFCC File Offset: 0x0000E1CC
	private void method_95(Class44 class44_4)
	{
		if (((Class54)this.method_37()).method_3() != 0)
		{
			this.stack_1.Push(new Class27.Struct3(this.uint_0, this.object_0));
			this.bool_1 = false;
		}
		this.method_48();
	}

	// Token: 0x06000242 RID: 578 RVA: 0x0001000C File Offset: 0x0000E20C
	private static void smethod_218(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		Class44 class44_6 = class27_0.method_37();
		class27_0.method_22(new Class54(Class27.smethod_130(class44_6, class44_5) ? 1 : 0));
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00010040 File Offset: 0x0000E240
	private static void smethod_219(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_16(typeof(uint));
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00010054 File Offset: 0x0000E254
	private static void smethod_220(Class27 class27_0, Class44 class44_4)
	{
		int num = ((Class54)class44_4).method_3();
		bool flag = (num & int.MinValue) != 0;
		bool bool_ = (num & 1073741824) != 0;
		num &= 1073741823;
		if (flag)
		{
			class27_0.method_103(num, null, null, bool_);
			return;
		}
		Class5 class5_ = (Class5)class27_0.method_50(num).method_4();
		class27_0.method_75(class5_);
	}

	// Token: 0x06000245 RID: 581 RVA: 0x000100B0 File Offset: 0x0000E2B0
	private static void smethod_221(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_51();
	}

	// Token: 0x06000246 RID: 582 RVA: 0x000100B8 File Offset: 0x0000E2B8
	private static void smethod_222(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_17(false, false);
	}

	// Token: 0x06000247 RID: 583 RVA: 0x000100C4 File Offset: 0x0000E2C4
	private static void smethod_223(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_6(true);
	}

	// Token: 0x06000248 RID: 584 RVA: 0x000100D0 File Offset: 0x0000E2D0
	private void method_96(int int_0)
	{
		Class44 @class = this.method_37();
		if (@class is Class61)
		{
			this.class44_0[int_0] = @class;
			return;
		}
		this.class44_0[int_0].vmethod_2(@class);
	}

	// Token: 0x06000249 RID: 585 RVA: 0x00010110 File Offset: 0x0000E310
	private void method_97(Class44 class44_4)
	{
		Class54 @class = (Class54)class44_4;
		MethodBase methodBase = this.method_40(@class.method_3());
		if (this.type_4 != null)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			foreach (ParameterInfo parameterInfo in parameters)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			MethodInfo method = this.type_4.GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
			this.type_4 = null;
		}
		this.method_81(methodBase, true);
	}

	// Token: 0x0600024A RID: 586 RVA: 0x000101B4 File Offset: 0x0000E3B4
	private static void smethod_224(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_71(6);
	}

	// Token: 0x0600024B RID: 587 RVA: 0x000101C0 File Offset: 0x0000E3C0
	private static void smethod_225(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_41((int)((Class69)class44_4).method_3());
	}

	// Token: 0x0600024C RID: 588 RVA: 0x000101D4 File Offset: 0x0000E3D4
	private void method_98(int int_0)
	{
		Class44 @class = this.method_37();
		this.class44_1[int_0].vmethod_2(@class);
	}

	// Token: 0x0600024D RID: 589 RVA: 0x000101FC File Offset: 0x0000E3FC
	private static void smethod_226(ILGenerator ilgenerator_0, Type type_9)
	{
		if (!type_9.IsValueType && !Class115.smethod_1(type_9).IsGenericParameter)
		{
			Class27.smethod_127(ilgenerator_0, type_9);
			return;
		}
		ilgenerator_0.Emit(OpCodes.Unbox_Any, type_9);
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00010228 File Offset: 0x0000E428
	private string method_99(Class10 class10_1)
	{
		Type type = this.method_80(class10_1.method_6(), false);
		Class126[] array = class10_1.method_2();
		string[] array2 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string[] array3 = array2;
			int num = i;
			Type type2 = this.method_80(array[i].method_0(), false);
			array3[num] = ((type2 != null) ? type2.FullName : null);
		}
		string text = string.Join(", ", array2);
		return string.Concat(new string[]
		{
			type.FullName,
			".",
			class10_1.method_4(),
			"(",
			text,
			")"
		});
	}

	// Token: 0x0600024F RID: 591 RVA: 0x000102D8 File Offset: 0x0000E4D8
	private static void smethod_227(Class27 class27_0, Class44 class44_4)
	{
		Class54 @class = (Class54)class44_4;
		MethodBase methodBase = class27_0.method_40(@class.method_3());
		Type declaringType = methodBase.DeclaringType;
		Type type = class27_0.method_37().vmethod_0().GetType();
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			array[i] = parameters[i].ParameterType;
		}
		MethodBase methodBase2 = null;
		for (Type type2 = type; type2 != null; type2 = type2.BaseType)
		{
			if (type2 == declaringType)
			{
				break;
			}
			MethodInfo method = type2.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if (method != null && method.GetBaseDefinition() == methodBase)
			{
				methodBase2 = method;
				break;
			}
		}
		if (methodBase2 == null)
		{
			methodBase2 = methodBase;
		}
		Class55 class2 = new Class55();
		class2.method_4(methodBase2);
		class27_0.method_22(class2);
	}

	// Token: 0x06000250 RID: 592 RVA: 0x000103C4 File Offset: 0x0000E5C4
	private static Class44 smethod_228(Class44 class44_4, Class44 class44_5, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class56)class44_4).method_3();
			long num2 = ((Class56)class44_5).method_3();
			long long_;
			if (bool_2)
			{
				long_ = checked(num * num2);
			}
			else
			{
				long_ = num * num2;
			}
			return new Class56(long_);
		}
		ulong num3 = (ulong)((Class56)class44_4).method_3();
		ulong num4 = (ulong)((Class56)class44_5).method_3();
		ulong long_2;
		if (bool_2)
		{
			long_2 = checked(num3 * num4);
		}
		else
		{
			long_2 = num3 * num4;
		}
		return new Class56((long)long_2);
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00010434 File Offset: 0x0000E634
	private Class44 method_100(Class44 class44_4, Class44 class44_5)
	{
		if (class44_4.method_0() == 7)
		{
			if (class44_5.method_0() == 7)
			{
				int num = ((Class54)class44_4).method_3();
				int num2 = ((Class54)class44_5).method_3();
				Class54 @class = new Class54();
				@class.method_4(num & num2);
				return @class;
			}
			if (class44_5.method_0() == 2)
			{
				int num3 = ((Class54)class44_4).method_3();
				Type underlyingType = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
				if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
				{
					long num4 = Convert.ToInt64(class44_5.vmethod_0());
					return new Class56((long)num3 & num4);
				}
				int num5 = Convert.ToInt32(class44_5.vmethod_0());
				Class54 class2 = new Class54();
				class2.method_4(num3 & num5);
				return class2;
			}
		}
		if (class44_4.method_0() == 22)
		{
			if (class44_5.method_0() == 22)
			{
				long num6 = ((Class56)class44_4).method_3();
				long num7 = ((Class56)class44_5).method_3();
				Class56 class3 = new Class56();
				class3.method_4(num6 & num7);
				return class3;
			}
			if (class44_5.method_0() == 2)
			{
				long num8 = (long)((Class54)class44_4).method_3();
				long num9 = Convert.ToInt64(class44_5.vmethod_0());
				return new Class56(num8 & num9);
			}
		}
		if (class44_4.method_0() == 2)
		{
			if (class44_5.method_0() == 7)
			{
				int num10 = ((Class54)class44_5).method_3();
				Type underlyingType2 = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return new Class56(Convert.ToInt64(class44_5.vmethod_0()) & (long)num10);
				}
				int num11 = Convert.ToInt32(class44_4.vmethod_0());
				Class54 class4 = new Class54();
				class4.method_4(num11 & num10);
				return class4;
			}
			else
			{
				if (class44_5.method_0() == 22)
				{
					long num12 = Convert.ToInt64(class44_4.vmethod_0());
					long num13 = ((Class56)class44_5).method_3();
					Class56 class5 = new Class56();
					class5.method_4(num12 & num13);
					return class5;
				}
				if (class44_5.method_0() == 2)
				{
					Type underlyingType3 = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
					Type underlyingType4 = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
					if (underlyingType3 != typeof(long) && underlyingType3 != typeof(ulong) && underlyingType4 != typeof(long))
					{
						if (underlyingType4 != typeof(ulong))
						{
							int num14 = Convert.ToInt32(class44_4.vmethod_0());
							int num15 = Convert.ToInt32(class44_5.vmethod_0());
							return new Class54(num14 & num15);
						}
					}
					long num16 = Convert.ToInt64(class44_4.vmethod_0());
					long num17 = Convert.ToInt64(class44_5.vmethod_0());
					return new Class56(num16 & num17);
				}
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00010700 File Offset: 0x0000E900
	private static bool smethod_229(object object_3)
	{
		return RemotingServices.IsTransparentProxy(object_3);
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00010708 File Offset: 0x0000E908
	private void method_101(long long_1)
	{
		this.class79_1.method_0().vmethod_5(long_1 - this.long_0);
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00010724 File Offset: 0x0000E924
	private static void smethod_230(Class27 class27_0, Class44 class44_4)
	{
		Class58 @class = (Class58)class27_0.method_37();
		if (double.IsNaN(@class.method_3()) || double.IsInfinity(@class.method_3()))
		{
			throw new OverflowException("The value is not finite real number.");
		}
		class27_0.method_22(@class);
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00010770 File Offset: 0x0000E970
	private void method_102()
	{
		this.uint_2 = this.uint_0;
		int key = this.class79_1.method_19();
		this.uint_0 += 4U;
		Class27.Struct4 @struct;
		Class27.dictionary_2.TryGetValue(key, out @struct);
		@struct.delegate21_0(this, this.method_19(this.class79_1, @struct.byte_0));
	}

	// Token: 0x06000256 RID: 598 RVA: 0x000107D0 File Offset: 0x0000E9D0
	private static void smethod_231(Class27 class27_0, Class44 class44_4)
	{
		throw new NotSupportedException("Refanyval is not supported.");
	}

	// Token: 0x06000257 RID: 599 RVA: 0x000107DC File Offset: 0x0000E9DC
	private static void smethod_232(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		bool flag;
		if (num <= 7)
		{
			if (num == 2)
			{
				flag = !Convert.ToBoolean(((Class53)@class).method_3());
				goto IL_F4;
			}
			if (num == 6)
			{
				flag = (((Class50)@class).method_3() == UIntPtr.Zero);
				goto IL_F4;
			}
			if (num == 7)
			{
				flag = (((Class54)@class).method_3() == 0);
				goto IL_F4;
			}
		}
		else
		{
			if (num == 15)
			{
				flag = (((Class49)@class).method_3() == IntPtr.Zero);
				goto IL_F4;
			}
			if (num == 17)
			{
				flag = (((Class51)@class).method_3() == null);
				goto IL_F4;
			}
			if (num == 22)
			{
				flag = (((Class56)@class).method_3() == 0L);
				goto IL_F4;
			}
		}
		flag = (@class.vmethod_0() == null);
		IL_F4:
		if (flag)
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x06000258 RID: 600 RVA: 0x000108F8 File Offset: 0x0000EAF8
	private void method_103(int int_0, Type[] type_9, Type[] type_10, bool bool_2)
	{
		this.class79_0.method_0().vmethod_9((long)int_0, 0);
		this.method_18(this.class79_0);
		Class10 @class = this.method_7(this.class79_0);
		this.method_64(@class);
		int num = @class.method_2().Length;
		object[] array = new object[num];
		Class44[] array2 = new Class44[num];
		if (this.type_4 != null && bool_2)
		{
			int num2 = @class.method_12() ? 0 : 1;
			Type[] array3 = new Type[num - num2];
			for (int i = num - 1; i >= num2; i--)
			{
				array3[i] = this.method_80(@class.method_2()[i].method_0(), true);
			}
			MethodInfo method = this.type_4.GetMethod(@class.method_4(), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array3, null);
			this.type_4 = null;
			if (method != null)
			{
				this.method_81(method, true);
				return;
			}
		}
		for (int j = num - 1; j >= 0; j--)
		{
			Class44 class2 = this.method_37();
			array2[j] = class2;
			Class61 class3 = class2 as Class61;
			if (class3 != null)
			{
				class2 = this.method_83(class3);
			}
			if (class2.method_1() != null)
			{
				class2 = Class44.smethod_0(null, class2.method_1()).vmethod_2(class2);
			}
			Class44 class4 = Class44.smethod_0(null, this.method_80(@class.method_2()[j].method_0(), true)).vmethod_2(class2);
			array[j] = class4.vmethod_0();
			if (j == 0 && bool_2 && !@class.method_12() && array[j] == null)
			{
				throw new NullReferenceException();
			}
		}
		Class27 class5 = new Class27(this.class102_0);
		object[] object_ = new object[]
		{
			this.module_0.Assembly
		};
		object obj;
		try
		{
			obj = class5.method_44(this.stream_0, int_0, array, type_9, type_10, object_);
		}
		finally
		{
			bool flag = !@class.method_12();
			for (int k = 0; k < num; k++)
			{
				int num3;
				if (flag)
				{
					num3 = k + 1;
					if (num3 == num)
					{
						num3 = 0;
					}
				}
				else
				{
					num3 = k;
				}
				Class61 class6 = array2[num3] as Class61;
				if (class6 != null)
				{
					this.method_5(class6, Class44.smethod_0(array[num3], null));
				}
			}
		}
		Type type = class5.method_80(class5.class10_0.method_8(), true);
		if (type != Class27.type_3)
		{
			this.method_22(Class44.smethod_0(obj, type));
		}
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00010B94 File Offset: 0x0000ED94
	private void method_104(object object_3)
	{
		Exception ex = object_3 as Exception;
		if (ex != null)
		{
			Class27.smethod_197(ex);
		}
		Class27.smethod_165(object_3);
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00010BB8 File Offset: 0x0000EDB8
	private static void smethod_233(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_71(5);
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00010BC4 File Offset: 0x0000EDC4
	private static void smethod_234(Class27 class27_0, Class44 class44_4)
	{
		Class44 @class = class27_0.method_37();
		int num = @class.method_0();
		double double_;
		if (num != 2)
		{
			if (num != 7)
			{
				if (num != 22)
				{
					throw new InvalidOperationException();
				}
				double_ = ((Class56)@class).method_3();
			}
			else
			{
				double_ = ((Class54)@class).method_3();
			}
		}
		else
		{
			double_ = Convert.ToUInt64(((Class53)@class).method_3());
		}
		Class58 class2 = new Class58();
		class2.method_4(double_);
		class27_0.method_22(class2);
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00010C4C File Offset: 0x0000EE4C
	private static void smethod_235(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_16(typeof(sbyte));
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00010C60 File Offset: 0x0000EE60
	private static void smethod_236(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_45(class44_4);
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00010C6C File Offset: 0x0000EE6C
	private static void smethod_237(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		Class44 @class = class27_0.method_37();
		bool flag;
		if (@class.method_0() == 8)
		{
			flag = !Class27.smethod_111(@class, class44_5);
		}
		else
		{
			flag = !Class27.smethod_149(@class, class44_5);
		}
		if (flag)
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00010CC0 File Offset: 0x0000EEC0
	private void method_105(bool bool_2)
	{
		Class44 class44_ = this.method_37();
		Class44 class44_2 = this.method_37();
		this.method_22(this.method_76(class44_2, class44_, bool_2));
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00010CEC File Offset: 0x0000EEEC
	private static void smethod_238(Class27 class27_0, Class44 class44_4)
	{
		throw new NotSupportedException("Cpobj is not supported.");
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00010CF8 File Offset: 0x0000EEF8
	private static void smethod_239(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_51();
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00010D00 File Offset: 0x0000EF00
	private static Class44 smethod_240(Class44 class44_4, Class44 class44_5, bool bool_2)
	{
		if (class44_4.method_0() == 7)
		{
			if (class44_5.method_0() == 7)
			{
				if (!bool_2)
				{
					int num = ((Class54)class44_4).method_3();
					int num2 = ((Class54)class44_5).method_3();
					return new Class54(num % num2);
				}
				int num3 = ((Class54)class44_4).method_3();
				uint num4 = (uint)((Class54)class44_5).method_3();
				return new Class54(num3 % (int)num4);
			}
			else
			{
				if (class44_5.method_0() == 22)
				{
					return Class27.smethod_181(new Class56((long)((Class54)class44_4).method_3()), class44_5, bool_2);
				}
				if (class44_5.method_0() == 2)
				{
					Type underlyingType = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
					if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
					{
						return Class27.smethod_181(new Class56((long)((Class54)class44_4).method_3()), new Class56(Convert.ToInt64(class44_5.vmethod_0())), bool_2);
					}
					return Class27.smethod_240(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2);
				}
			}
		}
		if (class44_4.method_0() == 22)
		{
			if (class44_5.method_0() == 22)
			{
				return Class27.smethod_181(class44_4, class44_5, bool_2);
			}
			if (class44_5.method_0() == 7)
			{
				return Class27.smethod_181(class44_4, new Class56((long)((Class54)class44_5).method_3()), bool_2);
			}
			if (class44_5.method_0() == 2)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class44_5.vmethod_0().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return Class27.smethod_181(class44_4, new Class56(Convert.ToInt64(class44_5.vmethod_0())), bool_2);
				}
				return Class27.smethod_181(class44_4, new Class54(Convert.ToInt32(class44_5.vmethod_0())), bool_2);
			}
		}
		if (class44_4.method_0() == 8 && class44_5.method_0() == 8)
		{
			Class58 @class = new Class58();
			@class.method_4(((Class58)class44_4).method_3() % ((Class58)class44_5).method_3());
			return @class;
		}
		if (class44_4.method_0() != 2)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType3 = Enum.GetUnderlyingType(class44_4.vmethod_0().GetType());
		if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong))
		{
			return Class27.smethod_240(new Class56(Convert.ToInt64(class44_4.vmethod_0())), class44_5, bool_2);
		}
		return Class27.smethod_240(new Class54(Convert.ToInt32(class44_4.vmethod_0())), class44_5, bool_2);
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00010F78 File Offset: 0x0000F178
	private static void smethod_241(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_22(new Class51());
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00010F88 File Offset: 0x0000F188
	private FieldInfo method_106(int int_0, Class93 class93_0, ref bool bool_2)
	{
		if (class93_0.method_0() == 0)
		{
			bool_2 = false;
			return this.module_0.ResolveField(class93_0.method_2());
		}
		Class3 @class = (Class3)class93_0.method_4();
		Type type = this.method_80(@class.method_0().method_2(), false);
		if (type.IsGenericType)
		{
			bool_2 = false;
		}
		BindingFlags bindingAttr = Class27.smethod_188(@class.method_4());
		return type.GetField(@class.method_2(), bindingAttr);
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00010FF4 File Offset: 0x0000F1F4
	private static void smethod_242(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		Class44 class44_6 = class27_0.method_37();
		class27_0.method_22(class27_0.method_100(class44_6, class44_5));
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00011020 File Offset: 0x0000F220
	private static void smethod_243(Class27 class27_0, Class44 class44_4)
	{
		Class44 class44_5 = class27_0.method_37();
		if (!Class27.smethod_168(class27_0.method_37(), class44_5))
		{
			uint uint_ = ((Class59)class44_4).method_3();
			class27_0.method_60(uint_);
		}
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00011058 File Offset: 0x0000F258
	private static void smethod_244(Class27 class27_0, Class44 class44_4)
	{
		class27_0.method_62(false);
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00011064 File Offset: 0x0000F264
	private static Class27.Delegate0 smethod_245(Class27.Struct2 struct2_0)
	{
		Dictionary<Class27.Struct2, Class27.Delegate0> obj = Class27.dictionary_4;
		Class27.Delegate0 result;
		lock (obj)
		{
			Class27.dictionary_4.TryGetValue(struct2_0, out result);
		}
		return result;
	}

	// Token: 0x06000269 RID: 617 RVA: 0x000110A8 File Offset: 0x0000F2A8
	private static void smethod_246(Class27 class27_0, Class44 class44_4)
	{
		int int_ = ((Class54)class44_4).method_3();
		Type type_ = class27_0.method_80(int_, true);
		class27_0.method_73(type_);
	}

	// Token: 0x0600026A RID: 618 RVA: 0x000110D4 File Offset: 0x0000F2D4
	private static void smethod_247(Class27 class27_0, Class44 class44_4)
	{
	}

	// Token: 0x0600026B RID: 619 RVA: 0x000110D8 File Offset: 0x0000F2D8
	private void method_107()
	{
		this.bool_0 = true;
	}

	// Token: 0x0600026C RID: 620 RVA: 0x000110E4 File Offset: 0x0000F2E4
	private static void smethod_248(Class27 class27_0, Class44 class44_4)
	{
		Class105 @class = Class27.smethod_116(class27_0);
		Class41 class41_ = class27_0.class79_1.method_0();
		long num = class27_0.method_24();
		byte[] array = new Class85(@class.imethod_1(), @class.imethod_2()).method_1(class41_, @class);
		Class27.Class28 class2 = new Class27.Class28
		{
			class105_0 = @class,
			long_0 = num
		};
		@class.method_4(Class84.smethod_1(array.Length) - array.Length);
		Class43 class3 = new Class43(array, 0, array.Length, false);
		class2.class41_0 = class3;
		class2.class79_0 = new Class79(class3);
		class27_0.method_77().Push(class2);
		class27_0.method_67(class2);
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00011180 File Offset: 0x0000F380
	private static void smethod_249(Class27 class27_0, Class44 class44_4)
	{
		uint uint_ = ((Class59)class44_4).method_3();
		class27_0.method_60(uint_);
	}

	// Token: 0x0600026E RID: 622 RVA: 0x000111A0 File Offset: 0x0000F3A0
	private static void smethod_250(ILGenerator ilgenerator_0, int int_0)
	{
		switch (int_0)
		{
		case -1:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
			return;
		case 0:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
			return;
		case 1:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
			return;
		case 2:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
			return;
		case 3:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
			return;
		case 4:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
			return;
		case 5:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
			return;
		case 6:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
			return;
		case 7:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
			return;
		case 8:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
			return;
		default:
			if (int_0 > -129 && int_0 < 128)
			{
				ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_0);
				return;
			}
			ilgenerator_0.Emit(OpCodes.Ldc_I4, int_0);
			return;
		}
	}

	// Token: 0x04000050 RID: 80
	private Class44[] class44_0;

	// Token: 0x04000051 RID: 81
	private static readonly Dictionary<MethodBase, int> dictionary_0;

	// Token: 0x04000052 RID: 82
	private static Type type_0;

	// Token: 0x04000053 RID: 83
	private object object_0;

	// Token: 0x04000054 RID: 84
	private uint uint_0;

	// Token: 0x04000055 RID: 85
	private static readonly Dictionary<MethodBase, object> dictionary_1;

	// Token: 0x04000056 RID: 86
	private uint uint_1;

	// Token: 0x04000057 RID: 87
	private Class44[] class44_1;

	// Token: 0x04000058 RID: 88
	private Type[] type_1;

	// Token: 0x04000059 RID: 89
	private bool bool_0;

	// Token: 0x0400005A RID: 90
	private static Type type_2;

	// Token: 0x0400005B RID: 91
	private Stack<Class27.Class28> stack_0;

	// Token: 0x0400005C RID: 92
	private Stream stream_0;

	// Token: 0x0400005D RID: 93
	private long long_0;

	// Token: 0x0400005E RID: 94
	private static Dictionary<int, Class27.Struct4> dictionary_2;

	// Token: 0x0400005F RID: 95
	private Class10 class10_0;

	// Token: 0x04000060 RID: 96
	private readonly Class102 class102_0;

	// Token: 0x04000061 RID: 97
	private static readonly Dictionary<int, object> dictionary_3;

	// Token: 0x04000062 RID: 98
	private static Type type_3;

	// Token: 0x04000063 RID: 99
	private Class44 class44_2;

	// Token: 0x04000064 RID: 100
	private Class44 class44_3;

	// Token: 0x04000065 RID: 101
	private Class79 class79_0;

	// Token: 0x04000066 RID: 102
	private Type type_4;

	// Token: 0x04000067 RID: 103
	private readonly Stack<Class27.Struct3> stack_1 = new Stack<Class27.Struct3>();

	// Token: 0x04000068 RID: 104
	private uint? nullable_0;

	// Token: 0x04000069 RID: 105
	private static Type type_5;

	// Token: 0x0400006A RID: 106
	private static Type type_6;

	// Token: 0x0400006B RID: 107
	private object[] object_1;

	// Token: 0x0400006C RID: 108
	private Class79 class79_1;

	// Token: 0x0400006D RID: 109
	private byte[] byte_0;

	// Token: 0x0400006E RID: 110
	private bool bool_1;

	// Token: 0x0400006F RID: 111
	private readonly Stack<Class44> stack_2 = new Stack<Class44>(16);

	// Token: 0x04000070 RID: 112
	private static Type type_7;

	// Token: 0x04000071 RID: 113
	private static readonly Dictionary<Class27.Struct2, Class27.Delegate0> dictionary_4;

	// Token: 0x04000072 RID: 114
	private static object object_2 = new object();

	// Token: 0x04000073 RID: 115
	private readonly Module module_0;

	// Token: 0x04000074 RID: 116
	private Type[] type_8;

	// Token: 0x04000075 RID: 117
	private Class125[] class125_0;

	// Token: 0x04000076 RID: 118
	private uint uint_2;

	// Token: 0x0200002C RID: 44
	private struct Struct2 : IEquatable<Class27.Struct2>
	{
		// Token: 0x0600026F RID: 623 RVA: 0x00011280 File Offset: 0x0000F480
		public Struct2(MethodBase methodBase_1, bool bool_1)
		{
			this.methodBase_0 = methodBase_1;
			this.bool_0 = bool_1;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00011290 File Offset: 0x0000F490
		[Attribute1]
		public MethodBase method_0()
		{
			return this.methodBase_0;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00011298 File Offset: 0x0000F498
		[Attribute1]
		public bool method_1()
		{
			return this.bool_0;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000112A0 File Offset: 0x0000F4A0
		public override int GetHashCode()
		{
			return this.method_0().GetHashCode() ^ this.method_1().GetHashCode();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000112C8 File Offset: 0x0000F4C8
		public override bool Equals(object obj)
		{
			if (obj is Class27.Struct2)
			{
				Class27.Struct2 other = (Class27.Struct2)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000112F0 File Offset: 0x0000F4F0
		public bool Equals(Class27.Struct2 other)
		{
			return this.method_0() == other.method_0() && this.method_1() == other.method_1();
		}

		// Token: 0x04000077 RID: 119
		private readonly MethodBase methodBase_0;

		// Token: 0x04000078 RID: 120
		private readonly bool bool_0;
	}

	// Token: 0x0200002D RID: 45
	private sealed class Class28 : IDisposable
	{
		// Token: 0x06000276 RID: 630 RVA: 0x0001131C File Offset: 0x0000F51C
		public void Dispose()
		{
			IDisposable disposable = this.class79_0;
			if (disposable != null)
			{
				disposable.Dispose();
			}
			if (this.class41_0 != null)
			{
				this.class41_0.Dispose();
				this.class41_0 = null;
			}
		}

		// Token: 0x04000079 RID: 121
		public Class105 class105_0;

		// Token: 0x0400007A RID: 122
		public Class79 class79_0;

		// Token: 0x0400007B RID: 123
		public Class41 class41_0;

		// Token: 0x0400007C RID: 124
		public long long_0;
	}

	// Token: 0x0200002E RID: 46
	private static class Class29
	{
		// Token: 0x06000277 RID: 631 RVA: 0x00011358 File Offset: 0x0000F558
		static Class29()
		{
			try
			{
				Class27.Class29.bool_0 = true;
			}
			catch
			{
				Class27.Class29.bool_0 = false;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00011388 File Offset: 0x0000F588
		private static bool smethod_0()
		{
			if (typeof(DynamicMethod).IsAbstract)
			{
				return false;
			}
			bool result;
			try
			{
				new DynamicMethod(string.Empty, typeof(void), Type.EmptyTypes);
				return true;
			}
			catch (PlatformNotSupportedException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0400007D RID: 125
		public static readonly bool bool_0;
	}

	// Token: 0x0200002F RID: 47
	// (Invoke) Token: 0x0600027A RID: 634
	private delegate object Delegate0(object object_0, object[] object_1);

	// Token: 0x02000030 RID: 48
	private sealed class Class30<T> : IComparer<KeyValuePair<int, T>>
	{
		// Token: 0x0600027D RID: 637 RVA: 0x000113E8 File Offset: 0x0000F5E8
		public Class30(Comparison<T> comparison_1)
		{
			this.comparison_0 = comparison_1;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000113F8 File Offset: 0x0000F5F8
		public int Compare(KeyValuePair<int, T> p0, KeyValuePair<int, T> p1)
		{
			int num = this.comparison_0(p0.Value, p1.Value);
			if (num == 0)
			{
				return p1.Key.CompareTo(p0.Key);
			}
			return num;
		}

		// Token: 0x0400007E RID: 126
		private readonly Comparison<T> comparison_0;
	}

	// Token: 0x02000031 RID: 49
	private sealed class Class31
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00011444 File Offset: 0x0000F644
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001144C File Offset: 0x0000F64C
		public void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00011458 File Offset: 0x0000F658
		public Type method_2()
		{
			return this.type_0;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00011460 File Offset: 0x0000F660
		public void method_3(Type type_1)
		{
			this.type_0 = type_1;
		}

		// Token: 0x0400007F RID: 127
		private string string_0;

		// Token: 0x04000080 RID: 128
		private Type type_0;
	}

	// Token: 0x02000032 RID: 50
	[Serializable]
	private sealed class Class32
	{
		// Token: 0x06000286 RID: 646 RVA: 0x00011480 File Offset: 0x0000F680
		internal int method_0(Class125 class125_0, Class125 class125_1)
		{
			if (class125_0.method_6() == class125_1.method_6())
			{
				return class125_1.method_4().CompareTo(class125_0.method_4());
			}
			return class125_0.method_6().CompareTo(class125_1.method_6());
		}

		// Token: 0x04000081 RID: 129
		public static readonly Class27.Class32 class32_0 = new Class27.Class32();

		// Token: 0x04000082 RID: 130
		public static Comparison<Class125> comparison_0;
	}

	// Token: 0x02000033 RID: 51
	private static class Class33
	{
		// Token: 0x06000288 RID: 648 RVA: 0x000114D0 File Offset: 0x0000F6D0
		public static MethodBase smethod_0(Class27 class27_0, Class10 class10_0, MethodBase methodBase_0, bool bool_0)
		{
			Dictionary<MethodBase, MethodInfo> obj = Class27.Class33.dictionary_0;
			MethodBase result;
			lock (obj)
			{
				MethodInfo methodInfo;
				if (Class27.Class33.dictionary_0.TryGetValue(methodBase_0, out methodInfo))
				{
					result = methodInfo;
				}
				else
				{
					MethodInfo methodInfo2 = methodBase_0 as MethodInfo;
					Type returnType;
					if (methodInfo2 != null)
					{
						returnType = methodInfo2.ReturnType;
					}
					else
					{
						returnType = Class27.type_3;
					}
					ParameterInfo[] parameters = methodBase_0.GetParameters();
					Type[] array;
					if (methodBase_0.IsStatic)
					{
						array = new Type[parameters.Length];
						for (int i = 0; i < parameters.Length; i++)
						{
							array[i] = parameters[i].ParameterType;
						}
					}
					else
					{
						array = new Type[parameters.Length + 1];
						Type type = methodBase_0.DeclaringType;
						if (type.IsValueType)
						{
							type = type.MakeByRefType();
							bool_0 = false;
						}
						array[0] = type;
						for (int j = 0; j < parameters.Length; j++)
						{
							array[j + 1] = parameters[j].ParameterType;
						}
					}
					string empty = string.Empty;
					if (methodInfo == null)
					{
						methodInfo = new DynamicMethod(empty, returnType, array, class27_0.method_80(class10_0.method_6(), true), true);
					}
					ILGenerator ilgenerator = ((DynamicMethod)methodInfo).GetILGenerator();
					for (int k = 0; k < array.Length; k++)
					{
						ilgenerator.Emit(OpCodes.Ldarg, k);
					}
					ConstructorInfo constructorInfo = methodBase_0 as ConstructorInfo;
					if (constructorInfo != null)
					{
						ilgenerator.Emit(bool_0 ? OpCodes.Callvirt : OpCodes.Call, constructorInfo);
					}
					else
					{
						ilgenerator.Emit(bool_0 ? OpCodes.Callvirt : OpCodes.Call, (MethodInfo)methodBase_0);
					}
					ilgenerator.Emit(OpCodes.Ret);
					Class27.Class33.dictionary_0.Add(methodBase_0, methodInfo);
					result = methodInfo;
				}
			}
			return result;
		}

		// Token: 0x04000083 RID: 131
		private static readonly Dictionary<MethodBase, MethodInfo> dictionary_0 = new Dictionary<MethodBase, MethodInfo>();
	}

	// Token: 0x02000034 RID: 52
	private struct Struct3
	{
		// Token: 0x06000289 RID: 649 RVA: 0x000116D0 File Offset: 0x0000F8D0
		public Struct3(uint uint_1)
		{
			this.uint_0 = uint_1;
			this.object_0 = null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000116E0 File Offset: 0x0000F8E0
		public Struct3(uint uint_1, object object_1)
		{
			this.uint_0 = uint_1;
			this.object_0 = object_1;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000116F0 File Offset: 0x0000F8F0
		[Attribute1]
		public uint method_0()
		{
			return this.uint_0;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000116F8 File Offset: 0x0000F8F8
		[Attribute1]
		public object method_1()
		{
			return this.object_0;
		}

		// Token: 0x04000084 RID: 132
		private readonly uint uint_0;

		// Token: 0x04000085 RID: 133
		private readonly object object_0;
	}

	// Token: 0x02000035 RID: 53
	private struct Struct4
	{
		// Token: 0x0600028D RID: 653 RVA: 0x00011700 File Offset: 0x0000F900
		public Struct4(Struct11 struct11_0, Class27.Delegate21 delegate21_1)
		{
			this.byte_0 = struct11_0.method_2();
			this.delegate21_0 = delegate21_1;
		}

		// Token: 0x04000086 RID: 134
		public readonly byte byte_0;

		// Token: 0x04000087 RID: 135
		public readonly Class27.Delegate21 delegate21_0;
	}

	// Token: 0x02000036 RID: 54
	private static class Class34
	{
		// Token: 0x0600028F RID: 655 RVA: 0x00011724 File Offset: 0x0000F924
		public static object smethod_0(object object_0, MethodBase methodBase_0, out MethodInfo methodInfo_0)
		{
			KeyValuePair<Type, MethodInfo> keyValuePair = Class27.Class34.smethod_1(methodBase_0);
			object result = (Delegate)Activator.CreateInstance(keyValuePair.Key, new object[]
			{
				object_0,
				methodBase_0.MethodHandle.GetFunctionPointer()
			});
			methodInfo_0 = keyValuePair.Value;
			return result;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00011774 File Offset: 0x0000F974
		private static KeyValuePair<Type, MethodInfo> smethod_1(MethodBase methodBase_0)
		{
			Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>> obj = Class27.Class34.dictionary_0;
			KeyValuePair<Type, MethodInfo> result;
			lock (obj)
			{
				KeyValuePair<Type, MethodInfo> keyValuePair;
				if (Class27.Class34.dictionary_0.TryGetValue(methodBase_0, out keyValuePair))
				{
					result = keyValuePair;
				}
				else
				{
					MethodInfo methodInfo = methodBase_0 as MethodInfo;
					Type type;
					if (methodInfo != null)
					{
						if ((type = methodInfo.ReturnType) != null)
						{
							goto IL_4D;
						}
					}
					type = Class27.type_3;
					IL_4D:
					Type type2 = type;
					bool flag = type2 != Class27.type_3;
					ParameterInfo[] parameters = methodBase_0.GetParameters();
					if (parameters.Length > 9)
					{
						throw new Exception(string.Format("Cannot create delegate for a method. Unsupported number of parameters: {0}.", parameters.Length));
					}
					Type[] array = new Type[parameters.Length + (flag ? 1 : 0)];
					for (int i = 0; i < parameters.Length; i++)
					{
						Type parameterType = parameters[i].ParameterType;
						if (parameterType.IsByRef || parameterType.IsPointer)
						{
							throw new Exception("Cannot create delegate for a method with parameters passed by reference.");
						}
						array[i] = parameterType;
					}
					if (flag)
					{
						array[array.Length - 1] = type2;
					}
					Type type3 = (!flag) ? Class27.Class34.smethod_3(array) : Class27.Class34.smethod_2(array);
					MethodInfo method = type3.GetMethod("Invoke");
					keyValuePair = new KeyValuePair<Type, MethodInfo>(type3, method);
					Class27.Class34.dictionary_0.Add(methodBase_0, keyValuePair);
					result = keyValuePair;
				}
			}
			return result;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000118F0 File Offset: 0x0000FAF0
		private static Type smethod_2(Type[] type_0)
		{
			switch (type_0.Length)
			{
			case 1:
				return typeof(Class27.Class34.Delegate1<>).MakeGenericType(type_0);
			case 2:
				return typeof(Class27.Class34.Delegate8<, >).MakeGenericType(type_0);
			case 3:
				return typeof(Class27.Class34.Delegate3<, , >).MakeGenericType(type_0);
			case 4:
				return typeof(Class27.Class34.Delegate9<, , , >).MakeGenericType(type_0);
			case 5:
				return typeof(Class27.Class34.Delegate7<, , , , >).MakeGenericType(type_0);
			case 6:
				return typeof(Class27.Class34.Delegate10<, , , , , >).MakeGenericType(type_0);
			case 7:
				return typeof(Class27.Class34.Delegate5<, , , , , , >).MakeGenericType(type_0);
			case 8:
				return typeof(Class27.Class34.Delegate14<, , , , , , , >).MakeGenericType(type_0);
			case 9:
				return typeof(Class27.Class34.Delegate20<, , , , , , , , >).MakeGenericType(type_0);
			case 10:
				return typeof(Class27.Class34.Delegate2<, , , , , , , , , >).MakeGenericType(type_0);
			default:
				return null;
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000119DC File Offset: 0x0000FBDC
		private static Type smethod_3(Type[] type_0)
		{
			switch (type_0.Length)
			{
			case 0:
				return typeof(Class27.Class34.Delegate12);
			case 1:
				return typeof(Class27.Class34.Delegate18<>).MakeGenericType(type_0);
			case 2:
				return typeof(Class27.Class34.Delegate4<, >).MakeGenericType(type_0);
			case 3:
				return typeof(Class27.Class34.Delegate15<, , >).MakeGenericType(type_0);
			case 4:
				return typeof(Class27.Class34.Delegate6<, , , >).MakeGenericType(type_0);
			case 5:
				return typeof(Class27.Class34.Delegate11<, , , , >).MakeGenericType(type_0);
			case 6:
				return typeof(Class27.Class34.Delegate19<, , , , , >).MakeGenericType(type_0);
			case 7:
				return typeof(Class27.Class34.Delegate16<, , , , , , >).MakeGenericType(type_0);
			case 8:
				return typeof(Class27.Class34.Delegate17<, , , , , , , >).MakeGenericType(type_0);
			case 9:
				return typeof(Class27.Class34.Delegate13<, , , , , , , , >).MakeGenericType(type_0);
			default:
				return null;
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>> dictionary_0 = new Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>>();

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000294 RID: 660
		private delegate T Delegate1<out T>();

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000298 RID: 664
		private delegate T9 Delegate2<in T, in U, in V, in W, in X, in Y, in Z, in T7, in T8, out T9>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7, T8 gparam_8);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x0600029C RID: 668
		private delegate V Delegate3<in T, in U, out V>(T gparam_0, U gparam_1);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x060002A0 RID: 672
		private delegate void Delegate4<in T, in U>(T gparam_0, U gparam_1);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x060002A4 RID: 676
		private delegate Z Delegate5<in T, in U, in V, in W, in X, in Y, out Z>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x060002A8 RID: 680
		private delegate void Delegate6<in T, in U, in V, in W>(T gparam_0, U gparam_1, V gparam_2, W gparam_3);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x060002AC RID: 684
		private delegate X Delegate7<in T, in U, in V, in W, out X>(T gparam_0, U gparam_1, V gparam_2, W gparam_3);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060002B0 RID: 688
		private delegate U Delegate8<in T, out U>(T gparam_0);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x060002B4 RID: 692
		private delegate W Delegate9<in T, in U, in V, out W>(T gparam_0, U gparam_1, V gparam_2);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060002B8 RID: 696
		private delegate Y Delegate10<in T, in U, in V, in W, in X, out Y>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060002BC RID: 700
		private delegate void Delegate11<in T, in U, in V, in W, in X>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060002C0 RID: 704
		private delegate void Delegate12();

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060002C4 RID: 708
		private delegate void Delegate13<in T, in U, in V, in W, in X, in Y, in Z, in T7, in T8>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7, T8 gparam_8);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060002C8 RID: 712
		private delegate T7 Delegate14<in T, in U, in V, in W, in X, in Y, in Z, out T7>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060002CC RID: 716
		private delegate void Delegate15<in T, in U, in V>(T gparam_0, U gparam_1, V gparam_2);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x060002D0 RID: 720
		private delegate void Delegate16<in T, in U, in V, in W, in X, in Y, in Z>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060002D4 RID: 724
		private delegate void Delegate17<in T, in U, in V, in W, in X, in Y, in Z, in T7>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060002D8 RID: 728
		private delegate void Delegate18<in T>(T gparam_0);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060002DC RID: 732
		private delegate void Delegate19<in T, in U, in V, in W, in X, in Y>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060002E0 RID: 736
		private delegate T8 Delegate20<in T, in U, in V, in W, in X, in Y, in Z, in T7, out T8>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7);
	}

	// Token: 0x0200004B RID: 75
	private struct Struct5
	{
		// Token: 0x04000089 RID: 137
		public bool bool_0;
	}

	// Token: 0x0200004C RID: 76
	// (Invoke) Token: 0x060002E4 RID: 740
	private delegate void Delegate21(Class27 class27_0, Class44 class44_0);
}
