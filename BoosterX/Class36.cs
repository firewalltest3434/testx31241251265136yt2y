using System;
using System.IO;

// Token: 0x0200004E RID: 78
internal sealed class Class36
{
	// Token: 0x060002EA RID: 746 RVA: 0x00011B54 File Offset: 0x0000FD54
	private static Stream smethod_0()
	{
		return (Stream)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebh-()K%I", null);
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00011B70 File Offset: 0x0000FD70
	private static int smethod_1()
	{
		return (int)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebh9()Kpb", null);
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00011B94 File Offset: 0x0000FD94
	private static byte[] smethod_2()
	{
		return (byte[])Class555.smethod_0().method_1(Class555.smethod_2(), "&ebh+()L<m", null);
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00011BB0 File Offset: 0x0000FDB0
	private static byte[] smethod_3()
	{
		return (byte[])Class555.smethod_0().method_1(Class555.smethod_2(), "&ebg'()K^\\", null);
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00011BCC File Offset: 0x0000FDCC
	public static void smethod_4(string string_0, byte[] byte_0, int int_0, int int_1)
	{
		if (Class36.stream_0 == null)
		{
			Class36.stream_0 = Class36.smethod_0();
		}
		Class36.smethod_9(Class36.smethod_11(string_0), byte_0, int_0, int_1);
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00011BF0 File Offset: 0x0000FDF0
	public static byte[] smethod_5(string string_0)
	{
		if (Class36.stream_0 == null)
		{
			Class36.stream_0 = Class36.smethod_0();
		}
		long num = Class36.smethod_11(string_0);
		byte[] array = new byte[4];
		Class36.smethod_9(num, array, 0, 4);
		int num2 = Class23.smethod_4(array, 0);
		Array.Clear(array, 0, array.Length);
		byte[] array2 = new byte[num2];
		Class36.smethod_9(num + 4L, array2, 0, num2);
		return array2;
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00011C50 File Offset: 0x0000FE50
	private static Class18 smethod_6(out bool bool_0)
	{
		bool_0 = true;
		if (Class36.class18_0 != null)
		{
			return Class36.class18_0;
		}
		if (Class36.class80_0 != null)
		{
			bool_0 = false;
			return Class36.class80_0.method_8();
		}
		Class80 @class = Class36.smethod_8();
		Class18 class2 = @class.method_8();
		if (class2.vmethod_0())
		{
			Class36.class18_0 = class2;
			@class.Dispose();
		}
		else
		{
			Class36.class80_0 = @class;
			bool_0 = false;
		}
		return class2;
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00011CB0 File Offset: 0x0000FEB0
	private static int smethod_7()
	{
		if (Class36.nullable_0 != null)
		{
			return Class36.nullable_0.Value;
		}
		bool flag;
		Class18 @class = Class36.smethod_6(out flag);
		Class36.nullable_0 = new int?(@class.vmethod_1());
		if (!flag)
		{
			@class.Dispose();
		}
		return Class36.nullable_0.Value;
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00011D00 File Offset: 0x0000FF00
	private static Class80 smethod_8()
	{
		return (Class80)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebg!()M*.", null);
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00011D1C File Offset: 0x0000FF1C
	private static void smethod_9(long long_0, byte[] byte_0, int int_0, int int_1)
	{
		object[] object_ = new object[]
		{
			long_0,
			byte_0,
			int_0,
			int_1
		};
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebgH()M$,", object_);
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00011D64 File Offset: 0x0000FF64
	private static void smethod_10(long long_0, byte[] byte_0)
	{
		object[] object_ = new object[]
		{
			long_0,
			byte_0
		};
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebgC()IW!", object_);
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00011D9C File Offset: 0x0000FF9C
	private static long smethod_11(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (long)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebfb()IJr", object_);
	}

	// Token: 0x0400008C RID: 140
	[ThreadStatic]
	private static Stream stream_0;

	// Token: 0x0400008D RID: 141
	[ThreadStatic]
	private static Class80 class80_0;

	// Token: 0x0400008E RID: 142
	[ThreadStatic]
	private static Class18 class18_0;

	// Token: 0x0400008F RID: 143
	private static int? nullable_0;
}
