using System;
using System.IO;

// Token: 0x0200005E RID: 94
internal static class Class74
{
	// Token: 0x06000376 RID: 886 RVA: 0x00013D24 File Offset: 0x00011F24
	public static Stream smethod_0(Stream stream_0, byte[] byte_0, string string_0)
	{
		byte[] array = Convert.FromBase64String(string_0);
		byte[] array2 = new byte[byte_0.Length + array.Length];
		Buffer.BlockCopy(byte_0, 0, array2, 0, byte_0.Length);
		Buffer.BlockCopy(array, 0, array2, byte_0.Length, array.Length);
		Class39 class39_ = new Class39(1, array2);
		Class89 class89_ = new Class89(false, class39_, Class74.class39_0);
		Class124 @class = new Class124(new Class121(false, class89_, false));
		Class12 class2 = new Class12();
		class2.method_1(@class.imethod_1());
		Class12 class12_ = class2;
		return new Stream1(new Stream2(stream_0, @class), class12_, Class74.class35_0, false);
	}

	// Token: 0x040000B2 RID: 178
	private static readonly Class39 class39_0 = Class39.smethod_18(65537UL);

	// Token: 0x040000B3 RID: 179
	private static readonly Class35 class35_0 = new Class35();
}
