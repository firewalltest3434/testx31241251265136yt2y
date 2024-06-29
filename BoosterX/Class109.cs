using System;

// Token: 0x020000A4 RID: 164
internal sealed class Class109 : Interface5
{
	// Token: 0x0600052A RID: 1322 RVA: 0x0001B300 File Offset: 0x00019500
	private uint method_0(uint uint_7, int int_1)
	{
		return uint_7 >> int_1 | uint_7 << 32 - int_1;
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x0001B314 File Offset: 0x00019514
	private uint method_1(uint uint_7)
	{
		return (uint_7 & 2139062143U) << 1 ^ ((uint_7 & 2155905152U) >> 7) * 27U;
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0001B32C File Offset: 0x0001952C
	private uint method_2(uint uint_7)
	{
		uint num = this.method_1(uint_7);
		uint num2 = this.method_1(num);
		uint num3 = this.method_1(num2);
		uint num4 = uint_7 ^ num3;
		return num ^ num2 ^ num3 ^ this.method_0(num ^ num4, 8) ^ this.method_0(num2 ^ num4, 16) ^ this.method_0(num4, 24);
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0001B37C File Offset: 0x0001957C
	private uint method_3(uint uint_7)
	{
		return (uint)((int)Class109.byte_0[(int)(uint_7 & 255U)] | (int)Class109.byte_0[(int)(uint_7 >> 8 & 255U)] << 8 | (int)Class109.byte_0[(int)(uint_7 >> 16 & 255U)] << 16 | (int)Class109.byte_0[(int)(uint_7 >> 24 & 255U)] << 24);
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x0001B3D0 File Offset: 0x000195D0
	private uint[,] method_4(byte[] byte_3, bool bool_1)
	{
		int num = byte_3.Length / 4;
		if (num != 4 && num != 6 && num != 8)
		{
			throw new ArgumentException("Key length not 128/192/256 bits.");
		}
		this.int_0 = num + 6;
		uint[,] array = new uint[this.int_0 + 1, 4];
		int num2 = 0;
		int i = 0;
		while (i < byte_3.Length)
		{
			array[num2 >> 2, num2 & 3] = Class118.smethod_1(byte_3, i);
			i += 4;
			num2++;
		}
		int num3 = this.int_0 + 1 << 2;
		for (int j = num; j < num3; j++)
		{
			uint num4 = array[j - 1 >> 2, j - 1 & 3];
			if (j % num == 0)
			{
				num4 = (this.method_3(this.method_0(num4, 8)) ^ (uint)Class109.byte_2[j / num - 1]);
			}
			else if (num > 6 && j % num == 4)
			{
				num4 = this.method_3(num4);
			}
			array[j >> 2, j & 3] = (array[j - num >> 2, j - num & 3] ^ num4);
		}
		if (!bool_1)
		{
			for (int k = 1; k < this.int_0; k++)
			{
				for (int l = 0; l < 4; l++)
				{
					array[k, l] = this.method_2(array[k, l]);
				}
			}
		}
		return array;
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0001B540 File Offset: 0x00019740
	public void imethod_1(bool bool_1, Interface1 interface1_0)
	{
		Class120 @class = interface1_0 as Class120;
		if (@class == null)
		{
			throw new ArgumentException("invalid parameter passed to AES init - " + interface1_0.GetType().Name);
		}
		this.uint_2 = this.method_4(@class.method_0(), bool_1);
		this.bool_0 = bool_1;
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x0001B58C File Offset: 0x0001978C
	public string imethod_0()
	{
		return "AES";
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0001B594 File Offset: 0x00019794
	public bool imethod_3()
	{
		return false;
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x0001B598 File Offset: 0x00019798
	public int imethod_2()
	{
		return 16;
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0001B59C File Offset: 0x0001979C
	public int imethod_4(byte[] byte_3, int int_1, byte[] byte_4, int int_2)
	{
		if (this.uint_2 == null)
		{
			throw new InvalidOperationException("AES engine not initialised");
		}
		if (int_1 + 16 > byte_3.Length)
		{
			throw new Exception2("input buffer too short");
		}
		if (int_2 + 16 > byte_4.Length)
		{
			throw new Exception2("output buffer too short");
		}
		this.method_5(byte_3, int_1);
		if (this.bool_0)
		{
			this.method_7(this.uint_2);
		}
		else
		{
			this.method_8(this.uint_2);
		}
		this.method_6(byte_4, int_2);
		return 16;
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0001B61C File Offset: 0x0001981C
	public void imethod_5()
	{
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0001B620 File Offset: 0x00019820
	private void method_5(byte[] byte_3, int int_1)
	{
		this.uint_3 = Class118.smethod_1(byte_3, int_1);
		this.uint_4 = Class118.smethod_1(byte_3, int_1 + 4);
		this.uint_5 = Class118.smethod_1(byte_3, int_1 + 8);
		this.uint_6 = Class118.smethod_1(byte_3, int_1 + 12);
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0001B660 File Offset: 0x00019860
	private void method_6(byte[] byte_3, int int_1)
	{
		Class118.smethod_0(this.uint_3, byte_3, int_1);
		Class118.smethod_0(this.uint_4, byte_3, int_1 + 4);
		Class118.smethod_0(this.uint_5, byte_3, int_1 + 8);
		Class118.smethod_0(this.uint_6, byte_3, int_1 + 12);
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0001B6A0 File Offset: 0x000198A0
	private void method_7(uint[,] uint_7)
	{
		this.uint_3 ^= uint_7[0, 0];
		this.uint_4 ^= uint_7[0, 1];
		this.uint_5 ^= uint_7[0, 2];
		this.uint_6 ^= uint_7[0, 3];
		uint num = 1U;
		uint num2;
		uint num3;
		uint num4;
		uint num5;
		while ((ulong)num < (ulong)((long)(this.int_0 - 1)))
		{
			num2 = (Class109.uint_0[(int)(this.uint_3 & 255U)] ^ this.method_0(Class109.uint_0[(int)(this.uint_4 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(this.uint_5 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(this.uint_6 >> 24 & 255U)], 8) ^ uint_7[(int)num, 0]);
			num3 = (Class109.uint_0[(int)(this.uint_4 & 255U)] ^ this.method_0(Class109.uint_0[(int)(this.uint_5 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(this.uint_6 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(this.uint_3 >> 24 & 255U)], 8) ^ uint_7[(int)num, 1]);
			num4 = (Class109.uint_0[(int)(this.uint_5 & 255U)] ^ this.method_0(Class109.uint_0[(int)(this.uint_6 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(this.uint_3 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(this.uint_4 >> 24 & 255U)], 8) ^ uint_7[(int)num, 2]);
			num5 = (Class109.uint_0[(int)(this.uint_6 & 255U)] ^ this.method_0(Class109.uint_0[(int)(this.uint_3 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(this.uint_4 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(this.uint_5 >> 24 & 255U)], 8) ^ uint_7[(int)num++, 3]);
			this.uint_3 = (Class109.uint_0[(int)(num2 & 255U)] ^ this.method_0(Class109.uint_0[(int)(num3 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(num4 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(num5 >> 24 & 255U)], 8) ^ uint_7[(int)num, 0]);
			this.uint_4 = (Class109.uint_0[(int)(num3 & 255U)] ^ this.method_0(Class109.uint_0[(int)(num4 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(num5 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(num2 >> 24 & 255U)], 8) ^ uint_7[(int)num, 1]);
			this.uint_5 = (Class109.uint_0[(int)(num4 & 255U)] ^ this.method_0(Class109.uint_0[(int)(num5 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(num2 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(num3 >> 24 & 255U)], 8) ^ uint_7[(int)num, 2]);
			this.uint_6 = (Class109.uint_0[(int)(num5 & 255U)] ^ this.method_0(Class109.uint_0[(int)(num2 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(num3 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(num4 >> 24 & 255U)], 8) ^ uint_7[(int)num++, 3]);
		}
		num2 = (Class109.uint_0[(int)(this.uint_3 & 255U)] ^ this.method_0(Class109.uint_0[(int)(this.uint_4 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(this.uint_5 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(this.uint_6 >> 24 & 255U)], 8) ^ uint_7[(int)num, 0]);
		num3 = (Class109.uint_0[(int)(this.uint_4 & 255U)] ^ this.method_0(Class109.uint_0[(int)(this.uint_5 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(this.uint_6 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(this.uint_3 >> 24 & 255U)], 8) ^ uint_7[(int)num, 1]);
		num4 = (Class109.uint_0[(int)(this.uint_5 & 255U)] ^ this.method_0(Class109.uint_0[(int)(this.uint_6 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(this.uint_3 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(this.uint_4 >> 24 & 255U)], 8) ^ uint_7[(int)num, 2]);
		num5 = (Class109.uint_0[(int)(this.uint_6 & 255U)] ^ this.method_0(Class109.uint_0[(int)(this.uint_3 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_0[(int)(this.uint_4 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_0[(int)(this.uint_5 >> 24 & 255U)], 8) ^ uint_7[(int)num++, 3]);
		this.uint_3 = (uint)((int)Class109.byte_0[(int)(num2 & 255U)] ^ (int)Class109.byte_0[(int)(num3 >> 8 & 255U)] << 8 ^ (int)Class109.byte_0[(int)(num4 >> 16 & 255U)] << 16 ^ (int)Class109.byte_0[(int)(num5 >> 24 & 255U)] << 24 ^ (int)uint_7[(int)num, 0]);
		this.uint_4 = (uint)((int)Class109.byte_0[(int)(num3 & 255U)] ^ (int)Class109.byte_0[(int)(num4 >> 8 & 255U)] << 8 ^ (int)Class109.byte_0[(int)(num5 >> 16 & 255U)] << 16 ^ (int)Class109.byte_0[(int)(num2 >> 24 & 255U)] << 24 ^ (int)uint_7[(int)num, 1]);
		this.uint_5 = (uint)((int)Class109.byte_0[(int)(num4 & 255U)] ^ (int)Class109.byte_0[(int)(num5 >> 8 & 255U)] << 8 ^ (int)Class109.byte_0[(int)(num2 >> 16 & 255U)] << 16 ^ (int)Class109.byte_0[(int)(num3 >> 24 & 255U)] << 24 ^ (int)uint_7[(int)num, 2]);
		this.uint_6 = (uint)((int)Class109.byte_0[(int)(num5 & 255U)] ^ (int)Class109.byte_0[(int)(num2 >> 8 & 255U)] << 8 ^ (int)Class109.byte_0[(int)(num3 >> 16 & 255U)] << 16 ^ (int)Class109.byte_0[(int)(num4 >> 24 & 255U)] << 24 ^ (int)uint_7[(int)num, 3]);
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x0001BDBC File Offset: 0x00019FBC
	private void method_8(uint[,] uint_7)
	{
		this.uint_3 ^= uint_7[this.int_0, 0];
		this.uint_4 ^= uint_7[this.int_0, 1];
		this.uint_5 ^= uint_7[this.int_0, 2];
		this.uint_6 ^= uint_7[this.int_0, 3];
		int i = this.int_0 - 1;
		uint num;
		uint num2;
		uint num3;
		uint num4;
		while (i > 1)
		{
			num = (Class109.uint_1[(int)(this.uint_3 & 255U)] ^ this.method_0(Class109.uint_1[(int)(this.uint_6 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(this.uint_5 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(this.uint_4 >> 24 & 255U)], 8) ^ uint_7[i, 0]);
			num2 = (Class109.uint_1[(int)(this.uint_4 & 255U)] ^ this.method_0(Class109.uint_1[(int)(this.uint_3 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(this.uint_6 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(this.uint_5 >> 24 & 255U)], 8) ^ uint_7[i, 1]);
			num3 = (Class109.uint_1[(int)(this.uint_5 & 255U)] ^ this.method_0(Class109.uint_1[(int)(this.uint_4 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(this.uint_3 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(this.uint_6 >> 24 & 255U)], 8) ^ uint_7[i, 2]);
			num4 = (Class109.uint_1[(int)(this.uint_6 & 255U)] ^ this.method_0(Class109.uint_1[(int)(this.uint_5 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(this.uint_4 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(this.uint_3 >> 24 & 255U)], 8) ^ uint_7[i--, 3]);
			this.uint_3 = (Class109.uint_1[(int)(num & 255U)] ^ this.method_0(Class109.uint_1[(int)(num4 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(num3 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(num2 >> 24 & 255U)], 8) ^ uint_7[i, 0]);
			this.uint_4 = (Class109.uint_1[(int)(num2 & 255U)] ^ this.method_0(Class109.uint_1[(int)(num >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(num4 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(num3 >> 24 & 255U)], 8) ^ uint_7[i, 1]);
			this.uint_5 = (Class109.uint_1[(int)(num3 & 255U)] ^ this.method_0(Class109.uint_1[(int)(num2 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(num >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(num4 >> 24 & 255U)], 8) ^ uint_7[i, 2]);
			this.uint_6 = (Class109.uint_1[(int)(num4 & 255U)] ^ this.method_0(Class109.uint_1[(int)(num3 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(num2 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(num >> 24 & 255U)], 8) ^ uint_7[i--, 3]);
		}
		num = (Class109.uint_1[(int)(this.uint_3 & 255U)] ^ this.method_0(Class109.uint_1[(int)(this.uint_6 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(this.uint_5 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(this.uint_4 >> 24 & 255U)], 8) ^ uint_7[i, 0]);
		num2 = (Class109.uint_1[(int)(this.uint_4 & 255U)] ^ this.method_0(Class109.uint_1[(int)(this.uint_3 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(this.uint_6 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(this.uint_5 >> 24 & 255U)], 8) ^ uint_7[i, 1]);
		num3 = (Class109.uint_1[(int)(this.uint_5 & 255U)] ^ this.method_0(Class109.uint_1[(int)(this.uint_4 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(this.uint_3 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(this.uint_6 >> 24 & 255U)], 8) ^ uint_7[i, 2]);
		num4 = (Class109.uint_1[(int)(this.uint_6 & 255U)] ^ this.method_0(Class109.uint_1[(int)(this.uint_5 >> 8 & 255U)], 24) ^ this.method_0(Class109.uint_1[(int)(this.uint_4 >> 16 & 255U)], 16) ^ this.method_0(Class109.uint_1[(int)(this.uint_3 >> 24 & 255U)], 8) ^ uint_7[i, 3]);
		this.uint_3 = (uint)((int)Class109.byte_1[(int)(num & 255U)] ^ (int)Class109.byte_1[(int)(num4 >> 8 & 255U)] << 8 ^ (int)Class109.byte_1[(int)(num3 >> 16 & 255U)] << 16 ^ (int)Class109.byte_1[(int)(num2 >> 24 & 255U)] << 24 ^ (int)uint_7[0, 0]);
		this.uint_4 = (uint)((int)Class109.byte_1[(int)(num2 & 255U)] ^ (int)Class109.byte_1[(int)(num >> 8 & 255U)] << 8 ^ (int)Class109.byte_1[(int)(num4 >> 16 & 255U)] << 16 ^ (int)Class109.byte_1[(int)(num3 >> 24 & 255U)] << 24 ^ (int)uint_7[0, 1]);
		this.uint_5 = (uint)((int)Class109.byte_1[(int)(num3 & 255U)] ^ (int)Class109.byte_1[(int)(num2 >> 8 & 255U)] << 8 ^ (int)Class109.byte_1[(int)(num >> 16 & 255U)] << 16 ^ (int)Class109.byte_1[(int)(num4 >> 24 & 255U)] << 24 ^ (int)uint_7[0, 2]);
		this.uint_6 = (uint)((int)Class109.byte_1[(int)(num4 & 255U)] ^ (int)Class109.byte_1[(int)(num3 >> 8 & 255U)] << 8 ^ (int)Class109.byte_1[(int)(num2 >> 16 & 255U)] << 16 ^ (int)Class109.byte_1[(int)(num >> 24 & 255U)] << 24 ^ (int)uint_7[0, 3]);
	}

	// Token: 0x0400021F RID: 543
	private static readonly byte[] byte_0 = new byte[]
	{
		99,
		124,
		119,
		123,
		242,
		107,
		111,
		197,
		48,
		1,
		103,
		43,
		254,
		215,
		171,
		118,
		202,
		130,
		201,
		125,
		250,
		89,
		71,
		240,
		173,
		212,
		162,
		175,
		156,
		164,
		114,
		192,
		183,
		253,
		147,
		38,
		54,
		63,
		247,
		204,
		52,
		165,
		229,
		241,
		113,
		216,
		49,
		21,
		4,
		199,
		35,
		195,
		24,
		150,
		5,
		154,
		7,
		18,
		128,
		226,
		235,
		39,
		178,
		117,
		9,
		131,
		44,
		26,
		27,
		110,
		90,
		160,
		82,
		59,
		214,
		179,
		41,
		227,
		47,
		132,
		83,
		209,
		0,
		237,
		32,
		252,
		177,
		91,
		106,
		203,
		190,
		57,
		74,
		76,
		88,
		207,
		208,
		239,
		170,
		251,
		67,
		77,
		51,
		133,
		69,
		249,
		2,
		127,
		80,
		60,
		159,
		168,
		81,
		163,
		64,
		143,
		146,
		157,
		56,
		245,
		188,
		182,
		218,
		33,
		16,
		byte.MaxValue,
		243,
		210,
		205,
		12,
		19,
		236,
		95,
		151,
		68,
		23,
		196,
		167,
		126,
		61,
		100,
		93,
		25,
		115,
		96,
		129,
		79,
		220,
		34,
		42,
		144,
		136,
		70,
		238,
		184,
		20,
		222,
		94,
		11,
		219,
		224,
		50,
		58,
		10,
		73,
		6,
		36,
		92,
		194,
		211,
		172,
		98,
		145,
		149,
		228,
		121,
		231,
		200,
		55,
		109,
		141,
		213,
		78,
		169,
		108,
		86,
		244,
		234,
		101,
		122,
		174,
		8,
		186,
		120,
		37,
		46,
		28,
		166,
		180,
		198,
		232,
		221,
		116,
		31,
		75,
		189,
		139,
		138,
		112,
		62,
		181,
		102,
		72,
		3,
		246,
		14,
		97,
		53,
		87,
		185,
		134,
		193,
		29,
		158,
		225,
		248,
		152,
		17,
		105,
		217,
		142,
		148,
		155,
		30,
		135,
		233,
		206,
		85,
		40,
		223,
		140,
		161,
		137,
		13,
		191,
		230,
		66,
		104,
		65,
		153,
		45,
		15,
		176,
		84,
		187,
		22
	};

	// Token: 0x04000220 RID: 544
	private static readonly byte[] byte_1 = new byte[]
	{
		82,
		9,
		106,
		213,
		48,
		54,
		165,
		56,
		191,
		64,
		163,
		158,
		129,
		243,
		215,
		251,
		124,
		227,
		57,
		130,
		155,
		47,
		byte.MaxValue,
		135,
		52,
		142,
		67,
		68,
		196,
		222,
		233,
		203,
		84,
		123,
		148,
		50,
		166,
		194,
		35,
		61,
		238,
		76,
		149,
		11,
		66,
		250,
		195,
		78,
		8,
		46,
		161,
		102,
		40,
		217,
		36,
		178,
		118,
		91,
		162,
		73,
		109,
		139,
		209,
		37,
		114,
		248,
		246,
		100,
		134,
		104,
		152,
		22,
		212,
		164,
		92,
		204,
		93,
		101,
		182,
		146,
		108,
		112,
		72,
		80,
		253,
		237,
		185,
		218,
		94,
		21,
		70,
		87,
		167,
		141,
		157,
		132,
		144,
		216,
		171,
		0,
		140,
		188,
		211,
		10,
		247,
		228,
		88,
		5,
		184,
		179,
		69,
		6,
		208,
		44,
		30,
		143,
		202,
		63,
		15,
		2,
		193,
		175,
		189,
		3,
		1,
		19,
		138,
		107,
		58,
		145,
		17,
		65,
		79,
		103,
		220,
		234,
		151,
		242,
		207,
		206,
		240,
		180,
		230,
		115,
		150,
		172,
		116,
		34,
		231,
		173,
		53,
		133,
		226,
		249,
		55,
		232,
		28,
		117,
		223,
		110,
		71,
		241,
		26,
		113,
		29,
		41,
		197,
		137,
		111,
		183,
		98,
		14,
		170,
		24,
		190,
		27,
		252,
		86,
		62,
		75,
		198,
		210,
		121,
		32,
		154,
		219,
		192,
		254,
		120,
		205,
		90,
		244,
		31,
		221,
		168,
		51,
		136,
		7,
		199,
		49,
		177,
		18,
		16,
		89,
		39,
		128,
		236,
		95,
		96,
		81,
		127,
		169,
		25,
		181,
		74,
		13,
		45,
		229,
		122,
		159,
		147,
		201,
		156,
		239,
		160,
		224,
		59,
		77,
		174,
		42,
		245,
		176,
		200,
		235,
		187,
		60,
		131,
		83,
		153,
		97,
		23,
		43,
		4,
		126,
		186,
		119,
		214,
		38,
		225,
		105,
		20,
		99,
		85,
		33,
		12,
		125
	};

	// Token: 0x04000221 RID: 545
	private static readonly byte[] byte_2 = new byte[]
	{
		1,
		2,
		4,
		8,
		16,
		32,
		64,
		128,
		27,
		54,
		108,
		216,
		171,
		77,
		154,
		47,
		94,
		188,
		99,
		198,
		151,
		53,
		106,
		212,
		179,
		125,
		250,
		239,
		197,
		145
	};

	// Token: 0x04000222 RID: 546
	private static readonly uint[] uint_0 = new uint[]
	{
		2774754246U,
		2222750968U,
		2574743534U,
		2373680118U,
		234025727U,
		3177933782U,
		2976870366U,
		1422247313U,
		1345335392U,
		50397442U,
		2842126286U,
		2099981142U,
		436141799U,
		1658312629U,
		3870010189U,
		2591454956U,
		1170918031U,
		2642575903U,
		1086966153U,
		2273148410U,
		368769775U,
		3948501426U,
		3376891790U,
		200339707U,
		3970805057U,
		1742001331U,
		4255294047U,
		3937382213U,
		3214711843U,
		4154762323U,
		2524082916U,
		1539358875U,
		3266819957U,
		486407649U,
		2928907069U,
		1780885068U,
		1513502316U,
		1094664062U,
		49805301U,
		1338821763U,
		1546925160U,
		4104496465U,
		887481809U,
		150073849U,
		2473685474U,
		1943591083U,
		1395732834U,
		1058346282U,
		201589768U,
		1388824469U,
		1696801606U,
		1589887901U,
		672667696U,
		2711000631U,
		251987210U,
		3046808111U,
		151455502U,
		907153956U,
		2608889883U,
		1038279391U,
		652995533U,
		1764173646U,
		3451040383U,
		2675275242U,
		453576978U,
		2659418909U,
		1949051992U,
		773462580U,
		756751158U,
		2993581788U,
		3998898868U,
		4221608027U,
		4132590244U,
		1295727478U,
		1641469623U,
		3467883389U,
		2066295122U,
		1055122397U,
		1898917726U,
		2542044179U,
		4115878822U,
		1758581177U,
		0U,
		753790401U,
		1612718144U,
		536673507U,
		3367088505U,
		3982187446U,
		3194645204U,
		1187761037U,
		3653156455U,
		1262041458U,
		3729410708U,
		3561770136U,
		3898103984U,
		1255133061U,
		1808847035U,
		720367557U,
		3853167183U,
		385612781U,
		3309519750U,
		3612167578U,
		1429418854U,
		2491778321U,
		3477423498U,
		284817897U,
		100794884U,
		2172616702U,
		4031795360U,
		1144798328U,
		3131023141U,
		3819481163U,
		4082192802U,
		4272137053U,
		3225436288U,
		2324664069U,
		2912064063U,
		3164445985U,
		1211644016U,
		83228145U,
		3753688163U,
		3249976951U,
		1977277103U,
		1663115586U,
		806359072U,
		452984805U,
		250868733U,
		1842533055U,
		1288555905U,
		336333848U,
		890442534U,
		804056259U,
		3781124030U,
		2727843637U,
		3427026056U,
		957814574U,
		1472513171U,
		4071073621U,
		2189328124U,
		1195195770U,
		2892260552U,
		3881655738U,
		723065138U,
		2507371494U,
		2690670784U,
		2558624025U,
		3511635870U,
		2145180835U,
		1713513028U,
		2116692564U,
		2878378043U,
		2206763019U,
		3393603212U,
		703524551U,
		3552098411U,
		1007948840U,
		2044649127U,
		3797835452U,
		487262998U,
		1994120109U,
		1004593371U,
		1446130276U,
		1312438900U,
		503974420U,
		3679013266U,
		168166924U,
		1814307912U,
		3831258296U,
		1573044895U,
		1859376061U,
		4021070915U,
		2791465668U,
		2828112185U,
		2761266481U,
		937747667U,
		2339994098U,
		854058965U,
		1137232011U,
		1496790894U,
		3077402074U,
		2358086913U,
		1691735473U,
		3528347292U,
		3769215305U,
		3027004632U,
		4199962284U,
		133494003U,
		636152527U,
		2942657994U,
		2390391540U,
		3920539207U,
		403179536U,
		3585784431U,
		2289596656U,
		1864705354U,
		1915629148U,
		605822008U,
		4054230615U,
		3350508659U,
		1371981463U,
		602466507U,
		2094914977U,
		2624877800U,
		555687742U,
		3712699286U,
		3703422305U,
		2257292045U,
		2240449039U,
		2423288032U,
		1111375484U,
		3300242801U,
		2858837708U,
		3628615824U,
		84083462U,
		32962295U,
		302911004U,
		2741068226U,
		1597322602U,
		4183250862U,
		3501832553U,
		2441512471U,
		1489093017U,
		656219450U,
		3114180135U,
		954327513U,
		335083755U,
		3013122091U,
		856756514U,
		3144247762U,
		1893325225U,
		2307821063U,
		2811532339U,
		3063651117U,
		572399164U,
		2458355477U,
		552200649U,
		1238290055U,
		4283782570U,
		2015897680U,
		2061492133U,
		2408352771U,
		4171342169U,
		2156497161U,
		386731290U,
		3669999461U,
		837215959U,
		3326231172U,
		3093850320U,
		3275833730U,
		2962856233U,
		1999449434U,
		286199582U,
		3417354363U,
		4233385128U,
		3602627437U,
		974525996U
	};

	// Token: 0x04000223 RID: 547
	private static readonly uint[] uint_1 = new uint[]
	{
		1353184337U,
		1399144830U,
		3282310938U,
		2522752826U,
		3412831035U,
		4047871263U,
		2874735276U,
		2466505547U,
		1442459680U,
		4134368941U,
		2440481928U,
		625738485U,
		4242007375U,
		3620416197U,
		2151953702U,
		2409849525U,
		1230680542U,
		1729870373U,
		2551114309U,
		3787521629U,
		41234371U,
		317738113U,
		2744600205U,
		3338261355U,
		3881799427U,
		2510066197U,
		3950669247U,
		3663286933U,
		763608788U,
		3542185048U,
		694804553U,
		1154009486U,
		1787413109U,
		2021232372U,
		1799248025U,
		3715217703U,
		3058688446U,
		397248752U,
		1722556617U,
		3023752829U,
		407560035U,
		2184256229U,
		1613975959U,
		1165972322U,
		3765920945U,
		2226023355U,
		480281086U,
		2485848313U,
		1483229296U,
		436028815U,
		2272059028U,
		3086515026U,
		601060267U,
		3791801202U,
		1468997603U,
		715871590U,
		120122290U,
		63092015U,
		2591802758U,
		2768779219U,
		4068943920U,
		2997206819U,
		3127509762U,
		1552029421U,
		723308426U,
		2461301159U,
		4042393587U,
		2715969870U,
		3455375973U,
		3586000134U,
		526529745U,
		2331944644U,
		2639474228U,
		2689987490U,
		853641733U,
		1978398372U,
		971801355U,
		2867814464U,
		111112542U,
		1360031421U,
		4186579262U,
		1023860118U,
		2919579357U,
		1186850381U,
		3045938321U,
		90031217U,
		1876166148U,
		4279586912U,
		620468249U,
		2548678102U,
		3426959497U,
		2006899047U,
		3175278768U,
		2290845959U,
		945494503U,
		3689859193U,
		1191869601U,
		3910091388U,
		3374220536U,
		0U,
		2206629897U,
		1223502642U,
		2893025566U,
		1316117100U,
		4227796733U,
		1446544655U,
		517320253U,
		658058550U,
		1691946762U,
		564550760U,
		3511966619U,
		976107044U,
		2976320012U,
		266819475U,
		3533106868U,
		2660342555U,
		1338359936U,
		2720062561U,
		1766553434U,
		370807324U,
		179999714U,
		3844776128U,
		1138762300U,
		488053522U,
		185403662U,
		2915535858U,
		3114841645U,
		3366526484U,
		2233069911U,
		1275557295U,
		3151862254U,
		4250959779U,
		2670068215U,
		3170202204U,
		3309004356U,
		880737115U,
		1982415755U,
		3703972811U,
		1761406390U,
		1676797112U,
		3403428311U,
		277177154U,
		1076008723U,
		538035844U,
		2099530373U,
		4164795346U,
		288553390U,
		1839278535U,
		1261411869U,
		4080055004U,
		3964831245U,
		3504587127U,
		1813426987U,
		2579067049U,
		4199060497U,
		577038663U,
		3297574056U,
		440397984U,
		3626794326U,
		4019204898U,
		3343796615U,
		3251714265U,
		4272081548U,
		906744984U,
		3481400742U,
		685669029U,
		646887386U,
		2764025151U,
		3835509292U,
		227702864U,
		2613862250U,
		1648787028U,
		3256061430U,
		3904428176U,
		1593260334U,
		4121936770U,
		3196083615U,
		2090061929U,
		2838353263U,
		3004310991U,
		999926984U,
		2809993232U,
		1852021992U,
		2075868123U,
		158869197U,
		4095236462U,
		28809964U,
		2828685187U,
		1701746150U,
		2129067946U,
		147831841U,
		3873969647U,
		3650873274U,
		3459673930U,
		3557400554U,
		3598495785U,
		2947720241U,
		824393514U,
		815048134U,
		3227951669U,
		935087732U,
		2798289660U,
		2966458592U,
		366520115U,
		1251476721U,
		4158319681U,
		240176511U,
		804688151U,
		2379631990U,
		1303441219U,
		1414376140U,
		3741619940U,
		3820343710U,
		461924940U,
		3089050817U,
		2136040774U,
		82468509U,
		1563790337U,
		1937016826U,
		776014843U,
		1511876531U,
		1389550482U,
		861278441U,
		323475053U,
		2355222426U,
		2047648055U,
		2383738969U,
		2302415851U,
		3995576782U,
		902390199U,
		3991215329U,
		1018251130U,
		1507840668U,
		1064563285U,
		2043548696U,
		3208103795U,
		3939366739U,
		1537932639U,
		342834655U,
		2262516856U,
		2180231114U,
		1053059257U,
		741614648U,
		1598071746U,
		1925389590U,
		203809468U,
		2336832552U,
		1100287487U,
		1895934009U,
		3736275976U,
		2632234200U,
		2428589668U,
		1636092795U,
		1890988757U,
		1952214088U,
		1113045200U
	};

	// Token: 0x04000224 RID: 548
	private int int_0;

	// Token: 0x04000225 RID: 549
	private uint[,] uint_2;

	// Token: 0x04000226 RID: 550
	private uint uint_3;

	// Token: 0x04000227 RID: 551
	private uint uint_4;

	// Token: 0x04000228 RID: 552
	private uint uint_5;

	// Token: 0x04000229 RID: 553
	private uint uint_6;

	// Token: 0x0400022A RID: 554
	private bool bool_0;
}
