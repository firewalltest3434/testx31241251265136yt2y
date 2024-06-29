using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

// Token: 0x02000584 RID: 1412
public sealed class GClass166
{
	// Token: 0x06001E92 RID: 7826 RVA: 0x0007F748 File Offset: 0x0007D948
	public static string smethod_0(uint uint_0)
	{
		return string.Format("0x{0:X8}", uint_0);
	}

	// Token: 0x06001E93 RID: 7827 RVA: 0x0007F75C File Offset: 0x0007D95C
	public static uint smethod_1(string string_1)
	{
		uint result = 0U;
		if (string_1.ToLowerInvariant().StartsWith("0x"))
		{
			try
			{
				int num = string_1.IndexOf(' ');
				int length = (num > 2) ? (num - 2) : (string_1.Length - 2);
				return uint.Parse(string_1.Substring(2, length), NumberStyles.AllowHexSpecifier);
			}
			catch (object obj)
			{
				return result;
			}
		}
		try
		{
			result = uint.Parse(string_1);
		}
		catch (object obj2)
		{
		}
		return result;
	}

	// Token: 0x06001E94 RID: 7828 RVA: 0x0007F7F4 File Offset: 0x0007D9F4
	internal static uint smethod_2(GClass69 gclass69_0, string string_1)
	{
		GClass166.Class641 @class = new GClass166.Class641();
		@class.string_0 = string_1;
		GClass58<uint> gclass = gclass69_0.method_18().FirstOrDefault(new Func<GClass58<uint>, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.method_2();
		}
		return GClass166.smethod_1(@class.string_0);
	}

	// Token: 0x06001E95 RID: 7829 RVA: 0x0007F83C File Offset: 0x0007DA3C
	internal static string smethod_3(GClass69 gclass69_0, uint uint_0)
	{
		GClass166.Class640 @class = new GClass166.Class640();
		@class.uint_0 = uint_0;
		GClass58<uint> gclass = gclass69_0.method_18().FirstOrDefault(new Func<GClass58<uint>, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.imethod_1();
		}
		return GClass166.smethod_0(@class.uint_0);
	}

	// Token: 0x06001E96 RID: 7830 RVA: 0x0007F884 File Offset: 0x0007DA84
	internal static string smethod_4(GClass69 gclass69_0, string string_1)
	{
		GClass166.Class639 @class = new GClass166.Class639();
		@class.string_0 = string_1;
		List<GClass58<string>> list = gclass69_0.method_16();
		GClass58<string> gclass = (list != null) ? list.FirstOrDefault(new Func<GClass58<string>, bool>(@class.method_0)) : null;
		if (gclass != null)
		{
			return gclass.method_2();
		}
		return @class.string_0;
	}

	// Token: 0x06001E97 RID: 7831 RVA: 0x0007F8D0 File Offset: 0x0007DAD0
	internal static string smethod_5(GClass69 gclass69_0, string string_1)
	{
		GClass166.Class642 @class = new GClass166.Class642();
		@class.string_0 = string_1;
		GClass58<string> gclass = gclass69_0.method_16().FirstOrDefault(new Func<GClass58<string>, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.imethod_1();
		}
		return @class.string_0;
	}

	// Token: 0x06001E98 RID: 7832 RVA: 0x0007F914 File Offset: 0x0007DB14
	public static string smethod_6(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return string.Empty;
		}
		if (byte_0.Length == 8)
		{
			return string.Format("0x{0:X16}", BitConverter.ToUInt64(byte_0, 0));
		}
		return BitConverter.ToString(byte_0);
	}

	// Token: 0x06001E99 RID: 7833 RVA: 0x0007F944 File Offset: 0x0007DB44
	internal static string smethod_7(GClass69 gclass69_0, byte[] byte_0)
	{
		GClass166.Class636 @class = new GClass166.Class636();
		@class.byte_0 = byte_0;
		List<GClass58<byte[]>> list = gclass69_0.method_20();
		GClass58<byte[]> gclass = (list != null) ? list.FirstOrDefault(new Func<GClass58<byte[]>, bool>(@class.method_0)) : null;
		if (gclass != null)
		{
			return gclass.imethod_1();
		}
		return GClass166.smethod_6(@class.byte_0);
	}

	// Token: 0x06001E9A RID: 7834 RVA: 0x0007F994 File Offset: 0x0007DB94
	internal static byte[] smethod_8(GClass69 gclass69_0, string string_1)
	{
		GClass166.Class637 @class = new GClass166.Class637();
		@class.string_0 = string_1;
		GClass58<byte[]> gclass = gclass69_0.method_20().FirstOrDefault(new Func<GClass58<byte[]>, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.method_2();
		}
		return GClass166.smethod_9(@class.string_0);
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x0007F9DC File Offset: 0x0007DBDC
	public static byte[] smethod_9(string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			return null;
		}
		if (string_1.StartsWith("0x"))
		{
			int num = string_1.IndexOf(' ');
			int length = (num > 2) ? (num - 2) : (string_1.Length - 2);
			return BitConverter.GetBytes(ulong.Parse(string_1.Substring(2, length), NumberStyles.AllowHexSpecifier));
		}
		if (string_1.Contains("-"))
		{
			return Array.ConvertAll<string, byte>(string_1.Split(new char[]
			{
				'-'
			}), new Converter<string, byte>(GClass166.Class638.class638_0.method_0));
		}
		return null;
	}

	// Token: 0x04001586 RID: 5510
	public static string string_0 = "Text";

	// Token: 0x02000585 RID: 1413
	private sealed class Class636
	{
		// Token: 0x06001E9D RID: 7837 RVA: 0x0007FA94 File Offset: 0x0007DC94
		internal bool method_0(GClass58<byte[]> gclass58_0)
		{
			return gclass58_0.method_2().Equals(this.byte_0);
		}

		// Token: 0x04001587 RID: 5511
		public byte[] byte_0;
	}

	// Token: 0x02000586 RID: 1414
	private sealed class Class637
	{
		// Token: 0x06001E9F RID: 7839 RVA: 0x0007FAB0 File Offset: 0x0007DCB0
		internal bool method_0(GClass58<byte[]> gclass58_0)
		{
			return gclass58_0.imethod_1() != null && gclass58_0.imethod_1().Equals(this.string_0);
		}

		// Token: 0x04001588 RID: 5512
		public string string_0;
	}

	// Token: 0x02000587 RID: 1415
	[Serializable]
	private sealed class Class638
	{
		// Token: 0x06001EA2 RID: 7842 RVA: 0x0007FAE4 File Offset: 0x0007DCE4
		internal byte method_0(string string_0)
		{
			return Convert.ToByte(string_0, 16);
		}

		// Token: 0x04001589 RID: 5513
		public static readonly GClass166.Class638 class638_0 = new GClass166.Class638();

		// Token: 0x0400158A RID: 5514
		public static Converter<string, byte> converter_0;
	}

	// Token: 0x02000588 RID: 1416
	private sealed class Class639
	{
		// Token: 0x06001EA4 RID: 7844 RVA: 0x0007FAF8 File Offset: 0x0007DCF8
		internal bool method_0(GClass58<string> gclass58_0)
		{
			return gclass58_0.imethod_1() != null && gclass58_0.imethod_1().Equals(this.string_0);
		}

		// Token: 0x0400158B RID: 5515
		public string string_0;
	}

	// Token: 0x02000589 RID: 1417
	private sealed class Class640
	{
		// Token: 0x06001EA6 RID: 7846 RVA: 0x0007FB20 File Offset: 0x0007DD20
		internal bool method_0(GClass58<uint> gclass58_0)
		{
			return gclass58_0.method_2().Equals(this.uint_0);
		}

		// Token: 0x0400158C RID: 5516
		public uint uint_0;
	}

	// Token: 0x0200058A RID: 1418
	private sealed class Class641
	{
		// Token: 0x06001EA8 RID: 7848 RVA: 0x0007FB4C File Offset: 0x0007DD4C
		internal bool method_0(GClass58<uint> gclass58_0)
		{
			return gclass58_0.imethod_1() != null && gclass58_0.imethod_1().Equals(this.string_0);
		}

		// Token: 0x0400158D RID: 5517
		public string string_0;
	}

	// Token: 0x0200058B RID: 1419
	private sealed class Class642
	{
		// Token: 0x06001EAA RID: 7850 RVA: 0x0007FB74 File Offset: 0x0007DD74
		internal bool method_0(GClass58<string> gclass58_0)
		{
			return gclass58_0.method_2().Equals(this.string_0);
		}

		// Token: 0x0400158E RID: 5518
		public string string_0;
	}
}
