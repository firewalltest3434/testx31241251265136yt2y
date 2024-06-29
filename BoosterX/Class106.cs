using System;
using System.Security.Cryptography;

// Token: 0x020000A0 RID: 160
internal sealed class Class106 : SymmetricAlgorithm
{
	// Token: 0x06000504 RID: 1284 RVA: 0x0001A6DC File Offset: 0x000188DC
	public Class106()
	{
		this.LegalBlockSizesValue = new KeySizes[]
		{
			new KeySizes(32, 32, 0)
		};
		this.LegalKeySizesValue = new KeySizes[]
		{
			new KeySizes(80, 80, 0)
		};
		this.BlockSizeValue = 32;
		this.KeySizeValue = 80;
		this.ModeValue = CipherMode.ECB;
		this.PaddingValue = PaddingMode.None;
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x0001A740 File Offset: 0x00018940
	public Class106(byte[] byte_1) : this()
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		this.Key = byte_1;
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x0001A778 File Offset: 0x00018978
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return new Class106.Class107(rgbKey, false);
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x0001A784 File Offset: 0x00018984
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return new Class106.Class107(rgbKey, true);
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x0001A790 File Offset: 0x00018990
	public override void GenerateIV()
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x0001A798 File Offset: 0x00018998
	public override void GenerateKey()
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x0001A7A0 File Offset: 0x000189A0
	private static ushort smethod_0(byte[] byte_1, int int_0, ushort ushort_0)
	{
		byte b = (byte)(ushort_0 >> 8);
		byte b2 = (byte)ushort_0;
		byte b3 = Class106.byte_0[(int)(b2 ^ byte_1[4 * int_0 % 10])] ^ b;
		byte b4 = Class106.byte_0[(int)(b3 ^ byte_1[(4 * int_0 + 1) % 10])] ^ b2;
		byte b5 = Class106.byte_0[(int)(b4 ^ byte_1[(4 * int_0 + 2) % 10])] ^ b3;
		byte b6 = Class106.byte_0[(int)(b5 ^ byte_1[(4 * int_0 + 3) % 10])] ^ b4;
		return (ushort)(((int)b5 << 8) + (int)b6);
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x0001A818 File Offset: 0x00018A18
	private static void smethod_1(byte[] byte_1, byte[] byte_2, int int_0, byte[] byte_3, int int_1, bool bool_0)
	{
		int num;
		int num2;
		if (bool_0)
		{
			num = 1;
			num2 = 0;
		}
		else
		{
			num = -1;
			num2 = 23;
		}
		ushort num3 = (ushort)(((int)byte_2[int_0] << 8) + (int)byte_2[int_0 + 1]);
		ushort num4 = (ushort)(((int)byte_2[int_0 + 2] << 8) + (int)byte_2[int_0 + 3]);
		for (int i = 0; i < 12; i++)
		{
			num4 ^= (ushort)((int)Class106.smethod_0(byte_1, num2, num3) ^ num2);
			num2 += num;
			num3 ^= (ushort)((int)Class106.smethod_0(byte_1, num2, num4) ^ num2);
			num2 += num;
		}
		byte_3[int_1] = (byte)(num4 >> 8);
		byte_3[int_1 + 1] = (byte)num4;
		byte_3[int_1 + 2] = (byte)(num3 >> 8);
		byte_3[int_1 + 3] = (byte)num3;
	}

	// Token: 0x0400021B RID: 539
	private static byte[] byte_0 = new byte[]
	{
		163,
		215,
		9,
		131,
		248,
		72,
		246,
		244,
		179,
		33,
		21,
		120,
		153,
		177,
		175,
		249,
		231,
		45,
		77,
		138,
		206,
		76,
		202,
		46,
		82,
		149,
		217,
		30,
		78,
		56,
		68,
		40,
		10,
		223,
		2,
		160,
		23,
		241,
		96,
		104,
		18,
		183,
		122,
		195,
		233,
		250,
		61,
		83,
		150,
		132,
		107,
		186,
		242,
		99,
		154,
		25,
		124,
		174,
		229,
		245,
		247,
		22,
		106,
		162,
		57,
		182,
		123,
		15,
		193,
		147,
		129,
		27,
		238,
		180,
		26,
		234,
		208,
		145,
		47,
		184,
		85,
		185,
		218,
		133,
		63,
		65,
		191,
		224,
		90,
		88,
		128,
		95,
		102,
		11,
		216,
		144,
		53,
		213,
		192,
		167,
		51,
		6,
		101,
		105,
		69,
		0,
		148,
		86,
		109,
		152,
		155,
		118,
		151,
		252,
		178,
		194,
		176,
		254,
		219,
		32,
		225,
		235,
		214,
		228,
		221,
		71,
		74,
		29,
		66,
		237,
		158,
		110,
		73,
		60,
		205,
		67,
		39,
		210,
		7,
		212,
		222,
		199,
		103,
		24,
		137,
		203,
		48,
		31,
		141,
		198,
		143,
		170,
		200,
		116,
		220,
		201,
		93,
		92,
		49,
		164,
		112,
		136,
		97,
		44,
		159,
		13,
		43,
		135,
		80,
		130,
		84,
		100,
		38,
		125,
		3,
		64,
		52,
		75,
		28,
		115,
		209,
		196,
		253,
		59,
		204,
		251,
		127,
		171,
		230,
		62,
		91,
		165,
		173,
		4,
		35,
		156,
		20,
		81,
		34,
		240,
		41,
		121,
		113,
		126,
		byte.MaxValue,
		140,
		14,
		226,
		12,
		239,
		188,
		114,
		117,
		111,
		55,
		161,
		236,
		211,
		142,
		98,
		139,
		134,
		16,
		232,
		8,
		119,
		17,
		190,
		146,
		79,
		36,
		197,
		50,
		54,
		157,
		207,
		243,
		166,
		187,
		172,
		94,
		108,
		169,
		19,
		87,
		37,
		181,
		227,
		189,
		168,
		58,
		1,
		5,
		89,
		42,
		70
	};

	// Token: 0x020000A1 RID: 161
	private sealed class Class107 : ICryptoTransform, IDisposable
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x0001A8B8 File Offset: 0x00018AB8
		public Class107(byte[] byte_1, bool bool_1)
		{
			this.byte_0 = byte_1;
			this.bool_0 = bool_1;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0001A8D0 File Offset: 0x00018AD0
		public int InputBlockSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0001A8D4 File Offset: 0x00018AD4
		public int OutputBlockSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0001A8DC File Offset: 0x00018ADC
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001A8E0 File Offset: 0x00018AE0
		public void Dispose()
		{
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0001A8E4 File Offset: 0x00018AE4
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputCount % 4 != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			for (int i = 0; i < inputCount; i += 4)
			{
				Class106.smethod_1(this.byte_0, inputBuffer, inputOffset + i, outputBuffer, outputOffset + i, this.bool_0);
			}
			return inputCount;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001A930 File Offset: 0x00018B30
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			this.TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		// Token: 0x0400021C RID: 540
		private byte[] byte_0;

		// Token: 0x0400021D RID: 541
		private bool bool_0;
	}
}
