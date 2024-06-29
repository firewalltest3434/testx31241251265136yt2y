using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x020001FA RID: 506
public sealed class GClass8 : GClass7
{
	// Token: 0x06000C2F RID: 3119 RVA: 0x00037224 File Offset: 0x00035424
	public GClass8(GClass42 gclass42_1) : base(gclass42_1, null)
	{
		try
		{
			this.method_26();
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x0003727C File Offset: 0x0003547C
	private uint method_20(uint uint_0)
	{
		return BitConverter.ToUInt32(new byte[]
		{
			GClass8.byte_0[(int)(uint_0 & 255U)],
			GClass8.byte_0[(int)(uint_0 + 1U & 255U)],
			GClass8.byte_0[(int)(uint_0 + 2U & 255U)],
			GClass8.byte_0[(int)(uint_0 + 3U & 255U)]
		}, 0);
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x000372DC File Offset: 0x000354DC
	public uint method_21(uint uint_0, uint uint_1)
	{
		uint uint_2 = uint_1 << 1;
		uint num = this.method_20(uint_2);
		return uint_0 ^ num;
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x000372F8 File Offset: 0x000354F8
	public string method_22(byte[] byte_1, uint uint_0)
	{
		uint num = uint_0 << 1;
		for (uint num2 = 0U; num2 < (uint)byte_1.Length; num2 += 1U)
		{
			uint num3 = num2;
			byte_1[(int)num3] = (byte_1[(int)num3] ^ GClass8.byte_0[(int)(num + num2 & 255U)]);
		}
		return Encoding.Unicode.GetString(byte_1).Trim(new char[1]);
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x00037350 File Offset: 0x00035550
	public void method_23(string string_0, ref GStruct1 gstruct1_0)
	{
		if (gstruct1_0.uint_3 == 1U && this.method_25(string_0, gstruct1_0.uint_1))
		{
			if (gstruct1_0.nvdrs_SETTING_TYPE_0 == NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE)
			{
				gstruct1_0.nvdrs_SETTING_UNION_0.stringValue = this.method_22(gstruct1_0.nvdrs_SETTING_UNION_0.rawData, gstruct1_0.uint_1);
				if (gstruct1_0.uint_2 == 1U)
				{
					gstruct1_0.nvdrs_SETTING_UNION_1.stringValue = this.method_22(gstruct1_0.nvdrs_SETTING_UNION_1.rawData, gstruct1_0.uint_1);
					return;
				}
			}
			else if (gstruct1_0.nvdrs_SETTING_TYPE_0 == NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE)
			{
				gstruct1_0.nvdrs_SETTING_UNION_0.dwordValue = this.method_21(gstruct1_0.nvdrs_SETTING_UNION_0.dwordValue, gstruct1_0.uint_1);
				if (gstruct1_0.uint_2 == 1U)
				{
					gstruct1_0.nvdrs_SETTING_UNION_1.dwordValue = this.method_21(gstruct1_0.nvdrs_SETTING_UNION_1.dwordValue, gstruct1_0.uint_1);
				}
			}
		}
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x00037428 File Offset: 0x00035628
	private string method_24(string string_0, uint uint_0)
	{
		return string_0 + uint_0.ToString("X8").ToLowerInvariant();
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x00037444 File Offset: 0x00035644
	public bool method_25(string string_0, uint uint_0)
	{
		return this.hashSet_0.Contains(this.method_24(string_0, uint_0));
	}

	// Token: 0x06000C37 RID: 3127 RVA: 0x0003745C File Offset: 0x0003565C
	private void method_26()
	{
		GClass8.Class269 @class = new GClass8.Class269();
		@class.gclass8_0 = this;
		@class.string_0 = "C:\\Users\\Administrator\\AppData\\Local\\Temp\\4ac002ca4bf9495e91237d9e01b1500e";
		try
		{
			base.method_1(new Action<IntPtr>(@class.method_0), false, false);
			if (File.Exists(@class.string_0))
			{
				string[] array = File.ReadAllLines(@class.string_0);
				this.hashSet_0 = new HashSet<string>();
				Regex regex = new Regex("Profile\\s\\\"(?<profileName>.*?)\\\"", RegexOptions.Compiled);
				Regex regex2 = new Regex("ID_0x(?<sid>[0-9a-fA-F]+)\\s\\=.*?InternalSettingFlag\\=V0", RegexOptions.Compiled);
				string str = string.Empty;
				for (int i = 0; i < array.Length; i++)
				{
					foreach (object obj in regex.Matches(array[i]))
					{
						str = ((Match)obj).Result("${profileName}");
					}
					foreach (object obj2 in regex2.Matches(array[i]))
					{
						Match match = (Match)obj2;
						this.hashSet_0.Add(str + match.Result("${sid}"));
					}
				}
			}
		}
		catch
		{
			if (File.Exists(@class.string_0))
			{
				File.Delete(@class.string_0);
			}
		}
		finally
		{
			if (File.Exists(@class.string_0))
			{
				File.Delete(@class.string_0);
			}
		}
	}

	// Token: 0x0400077E RID: 1918
	private static readonly byte[] byte_0 = new byte[]
	{
		47,
		124,
		79,
		139,
		32,
		36,
		82,
		141,
		38,
		60,
		148,
		119,
		243,
		124,
		152,
		165,
		250,
		113,
		182,
		128,
		221,
		53,
		132,
		186,
		253,
		182,
		166,
		27,
		57,
		196,
		204,
		176,
		126,
		149,
		217,
		238,
		24,
		75,
		156,
		245,
		45,
		78,
		208,
		193,
		85,
		23,
		223,
		24,
		30,
		11,
		24,
		139,
		136,
		88,
		134,
		90,
		30,
		3,
		237,
		86,
		251,
		22,
		254,
		138,
		1,
		50,
		156,
		141,
		242,
		232,
		74,
		230,
		144,
		142,
		21,
		104,
		232,
		45,
		244,
		64,
		55,
		154,
		114,
		199,
		2,
		12,
		209,
		211,
		88,
		234,
		98,
		209,
		152,
		54,
		43,
		178,
		22,
		213,
		222,
		147,
		241,
		186,
		116,
		227,
		50,
		196,
		159,
		246,
		18,
		254,
		24,
		192,
		187,
		53,
		121,
		156,
		107,
		122,
		35,
		127,
		43,
		21,
		155,
		66,
		7,
		26,
		byte.MaxValue,
		105,
		251,
		156,
		189,
		35,
		151,
		168,
		34,
		99,
		143,
		50,
		200,
		233,
		155,
		99,
		28,
		238,
		44,
		217,
		237,
		141,
		58,
		53,
		156,
		177,
		96,
		174,
		94,
		245,
		151,
		107,
		159,
		32,
		140,
		247,
		152,
		44,
		67,
		121,
		149,
		29,
		205,
		70,
		54,
		108,
		217,
		103,
		32,
		171,
		65,
		34,
		33,
		229,
		85,
		130,
		245,
		39,
		32,
		245,
		8,
		7,
		63,
		109,
		105,
		217,
		28,
		75,
		248,
		38,
		3,
		110,
		178,
		63,
		30,
		230,
		202,
		61,
		97,
		68,
		176,
		146,
		175,
		240,
		136,
		202,
		224,
		95,
		93,
		244,
		223,
		198,
		76,
		164,
		224,
		202,
		176,
		32,
		93,
		192,
		250,
		221,
		154,
		52,
		143,
		80,
		121,
		90,
		95,
		124,
		25,
		158,
		64,
		112,
		113,
		181,
		69,
		25,
		184,
		83,
		252,
		223,
		36,
		190,
		34,
		28,
		121,
		191,
		66,
		137
	};

	// Token: 0x0400077F RID: 1919
	private HashSet<string> hashSet_0 = new HashSet<string>();

	// Token: 0x020001FB RID: 507
	private sealed class Class269
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x0003765C File Offset: 0x0003585C
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass8_0.method_19(intptr_0, this.string_0);
		}

		// Token: 0x04000780 RID: 1920
		public GClass8 gclass8_0;

		// Token: 0x04000781 RID: 1921
		public string string_0;
	}
}
