using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading;

// Token: 0x02000245 RID: 581
internal static class Class296
{
	// Token: 0x06000DB2 RID: 3506 RVA: 0x0003C5C0 File Offset: 0x0003A7C0
	internal static long smethod_0()
	{
		if (Assembly.GetCallingAssembly() == typeof(Class296).Assembly)
		{
		}
		return 0L;
		long result;
		try
		{
			AssemblyName assemblyName;
			try
			{
			}
			catch
			{
				Assembly assembly;
				assemblyName = new AssemblyName(assembly.FullName);
			}
			byte[] array = assemblyName.GetPublicKeyToken();
			if (array != null && array.Length == 0)
			{
				array = null;
			}
			List<byte> list;
			if (array != null)
			{
				list.AddRange(array);
			}
			list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
			int num = Class296.smethod_4(typeof(Class296));
			int num2 = Class296.Class297.smethod_0();
			list.Add((byte)(num >> 24));
			list.Add((byte)(num2 >> 24));
			list.Add((byte)num);
			list.Add((byte)(num2 >> 16));
			list.Add((byte)(num >> 8));
			list.Add((byte)num2);
			list.Add((byte)(num >> 16));
			list.Add((byte)(num2 >> 8));
			int count = list.Count;
			ulong num3 = 0UL;
			for (int num4 = 0; num4 != count; num4++)
			{
				num3 += (ulong)list[num4];
				num3 += num3 << 20;
				num3 ^= num3 >> 12;
				list[num4] = 0;
			}
			num3 += num3 << 6;
			num3 ^= num3 >> 22;
			num3 += num3 << 30;
			long num5 = (long)num3;
			num5 ^= 3065565080337847689L;
			Class296.class301_0.method_1(num5);
			result = num5;
		}
		finally
		{
			Class296.Class301 obj;
			Monitor.Exit(obj);
		}
		return result;
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x0003C7A4 File Offset: 0x0003A9A4
	internal static void smethod_1(byte[] byte_0)
	{
		if (Assembly.GetCallingAssembly() == typeof(Class296).Assembly)
		{
		}
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x0003C7CC File Offset: 0x0003A9CC
	private static bool smethod_2()
	{
		return false;
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x0003C7D0 File Offset: 0x0003A9D0
	private static bool smethod_3()
	{
		StackTrace stackTrace = new StackTrace();
		StackFrame frame = stackTrace.GetFrame(3);
		MethodBase methodBase = (frame == null) ? null : frame.GetMethod();
		Type type = (methodBase == null) ? null : methodBase.DeclaringType;
		return type != typeof(RuntimeMethodHandle) && type != null && type.Assembly == typeof(Class296).Assembly;
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x0003C84C File Offset: 0x0003AA4C
	private static int smethod_4(Type type_0)
	{
		return type_0.MetadataToken;
	}

	// Token: 0x0400086F RID: 2159
	private static Class296.Class301 class301_0 = new Class296.Class301();

	// Token: 0x02000246 RID: 582
	private sealed class Class297
	{
		// Token: 0x06000DB8 RID: 3512 RVA: 0x0003C85C File Offset: 0x0003AA5C
		internal static int smethod_0()
		{
			return Class296.Class299.smethod_2(Class296.Class299.smethod_1(Class296.smethod_4(typeof(Class296.Class304)), Class296.Class299.smethod_2(Class296.smethod_4(typeof(Class296.Class297)), Class296.smethod_4(typeof(Class296.Class303)))), Class296.Class300.smethod_0());
		}
	}

	// Token: 0x02000247 RID: 583
	private sealed class Class298
	{
		// Token: 0x06000DBA RID: 3514 RVA: 0x0003C8B4 File Offset: 0x0003AAB4
		internal static int smethod_0()
		{
			return Class296.Class299.smethod_2(Class296.Class299.smethod_0(Class296.Class304.smethod_0() ^ 527758446, Class296.smethod_4(typeof(Class296.Class302))), Class296.Class299.smethod_1(Class296.smethod_4(typeof(Class296.Class297)) ^ Class296.smethod_4(typeof(Class296.Class300)), 1819178601));
		}
	}

	// Token: 0x02000248 RID: 584
	private static class Class299
	{
		// Token: 0x06000DBB RID: 3515 RVA: 0x0003C910 File Offset: 0x0003AB10
		internal static int smethod_0(int int_0, int int_1)
		{
			return int_0 ^ int_1 - -2143878771;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0003C91C File Offset: 0x0003AB1C
		internal static int smethod_1(int int_0, int int_1)
		{
			return int_0 - -308043955 ^ int_1 + 1995162201;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0003C930 File Offset: 0x0003AB30
		internal static int smethod_2(int int_0, int int_1)
		{
			return int_0 ^ (int_1 - 2142453777 ^ int_0 - int_1);
		}
	}

	// Token: 0x02000249 RID: 585
	private sealed class Class300
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x0003C948 File Offset: 0x0003AB48
		internal static int smethod_0()
		{
			return Class296.Class299.smethod_0(Class296.smethod_4(typeof(Class296.Class300)), Class296.Class299.smethod_2(Class296.Class299.smethod_1(Class296.smethod_4(typeof(Class296.Class303)), Class296.smethod_4(typeof(Class296.Class297))), Class296.Class299.smethod_2(Class296.smethod_4(typeof(Class296.Class298)) ^ -805164379, Class296.Class303.smethod_0())));
		}
	}

	// Token: 0x0200024A RID: 586
	private sealed class Class301
	{
		// Token: 0x06000DC0 RID: 3520 RVA: 0x0003C9B0 File Offset: 0x0003ABB0
		internal Class301()
		{
			this.method_1(0L);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0003C9C8 File Offset: 0x0003ABC8
		internal long method_0()
		{
			if (Assembly.GetCallingAssembly() != typeof(Class296.Class301).Assembly)
			{
				return 2918384L;
			}
			return 2918384L;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0003CA04 File Offset: 0x0003AC04
		internal void method_1(long long_0)
		{
			if (Assembly.GetCallingAssembly() != typeof(Class296.Class301).Assembly)
			{
				return;
			}
		}

		// Token: 0x04000870 RID: 2160
		private int int_0;

		// Token: 0x04000871 RID: 2161
		private int int_1;
	}

	// Token: 0x0200024B RID: 587
	private sealed class Class302
	{
		// Token: 0x06000DC4 RID: 3524 RVA: 0x0003CA38 File Offset: 0x0003AC38
		internal static int smethod_0()
		{
			return Class296.Class299.smethod_2(Class296.smethod_4(typeof(Class296.Class302)), Class296.Class299.smethod_0(Class296.smethod_4(typeof(Class296.Class297)), Class296.Class299.smethod_1(Class296.smethod_4(typeof(Class296.Class304)), Class296.Class299.smethod_2(Class296.smethod_4(typeof(Class296.Class298)), Class296.Class299.smethod_0(Class296.smethod_4(typeof(Class296.Class303)), Class296.smethod_4(typeof(Class296.Class300)))))));
		}
	}

	// Token: 0x0200024C RID: 588
	private sealed class Class303
	{
		// Token: 0x06000DC6 RID: 3526 RVA: 0x0003CAC0 File Offset: 0x0003ACC0
		internal static int smethod_0()
		{
			return Class296.Class299.smethod_1(Class296.Class299.smethod_1(Class296.Class298.smethod_0(), Class296.Class299.smethod_0(Class296.smethod_4(typeof(Class296.Class303)), Class296.Class304.smethod_0())), Class296.smethod_4(typeof(Class296.Class300)));
		}
	}

	// Token: 0x0200024D RID: 589
	private sealed class Class304
	{
		// Token: 0x06000DC8 RID: 3528 RVA: 0x0003CB04 File Offset: 0x0003AD04
		internal static int smethod_0()
		{
			return Class296.Class299.smethod_0(Class296.smethod_4(typeof(Class296.Class298)), Class296.smethod_4(typeof(Class296.Class302)) ^ Class296.Class299.smethod_1(Class296.smethod_4(typeof(Class296.Class304)), Class296.Class299.smethod_2(Class296.smethod_4(typeof(Class296.Class300)), Class296.Class302.smethod_0())));
		}
	}
}
