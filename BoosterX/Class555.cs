using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000494 RID: 1172
internal static class Class555
{
	// Token: 0x060019CF RID: 6607 RVA: 0x0006A088 File Offset: 0x00068288
	[MethodImpl(MethodImplOptions.Synchronized)]
	public static Class27 smethod_0()
	{
		if (Class555.class102_0 == null)
		{
			Class555.class102_0 = new Class102();
		}
		return new Class27(Class555.class102_0);
	}

	// Token: 0x060019D0 RID: 6608 RVA: 0x0006A0A8 File Offset: 0x000682A8
	public static string smethod_1()
	{
		return "mLqw7Z2OiHMLfUhNh8DCD+Kht6uhbJ49cjXFIibmy8Wlkiuc8NeHAc9FpyIfLUiAxauyJFzBPI2m3yCmlwlDRyhdWPCbbNLmVETEr6H0SNgM5yT2I+21QZmRyKV6Pz1iZeOg49GnhNbIolCNzw2gW63cUalZcq11+SjLuxqEQ5U=";
	}

	// Token: 0x060019D1 RID: 6609 RVA: 0x0006A0B0 File Offset: 0x000682B0
	public static Stream smethod_2()
	{
		if (Class555.stream_0 == null)
		{
			Class555.stream_0 = Class74.smethod_0(typeof(Class555).Assembly.GetManifestResourceStream("be704aedade848900cb99aa210f9bfb8"), new byte[]
			{
				196,
				55,
				59,
				76,
				38,
				82,
				207,
				81,
				107,
				209,
				44,
				190,
				133,
				49,
				246,
				87,
				126,
				91,
				178,
				100,
				150,
				byte.MaxValue,
				154,
				50,
				88,
				33,
				17,
				221,
				80,
				23,
				104,
				56,
				163,
				byte.MaxValue,
				136,
				27,
				6,
				167,
				129,
				126,
				5,
				65,
				157,
				247,
				188,
				87,
				138,
				231,
				107,
				250,
				59,
				116,
				197,
				198,
				210,
				183,
				71,
				92,
				170,
				175,
				196,
				235,
				107,
				103,
				173,
				65,
				221,
				169,
				117,
				171,
				203,
				149,
				119,
				203,
				40,
				171,
				171,
				112,
				42,
				55,
				59,
				132,
				162,
				108,
				156,
				111,
				112,
				184,
				63,
				81,
				50,
				21,
				45,
				237,
				250,
				240,
				104,
				61,
				16,
				154,
				18,
				11,
				55,
				208,
				170,
				227,
				154,
				44,
				41,
				243,
				210,
				107,
				200,
				46,
				47,
				49,
				34,
				5,
				134,
				231,
				225,
				169,
				96,
				126,
				227,
				61,
				226,
				91
			}, "mLqw7Z2OiHMLfUhNh8DCD+Kht6uhbJ49cjXFIibmy8Wlkiuc8NeHAc9FpyIfLUiAxauyJFzBPI2m3yCmlwlDRyhdWPCbbNLmVETEr6H0SNgM5yT2I+21QZmRyKV6Pz1iZeOg49GnhNbIolCNzw2gW63cUalZcq11+SjLuxqEQ5U=");
		}
		return Class555.stream_0;
	}

	// Token: 0x04001202 RID: 4610
	private static Class102 class102_0;

	// Token: 0x04001203 RID: 4611
	[ThreadStatic]
	private static Stream stream_0;

	// Token: 0x04001204 RID: 4612 RVA: 0x01FE7078 File Offset: 0x01FE5278
	internal static Class555.struct0495 f000096;

	// Token: 0x02000495 RID: 1173
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 128)]
	private struct struct0495
	{
	}
}
