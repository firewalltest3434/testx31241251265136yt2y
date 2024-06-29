using System;
using System.Security.Cryptography;

// Token: 0x02000005 RID: 5
internal sealed class Class6 : SymmetricAlgorithm
{
	// Token: 0x06000011 RID: 17 RVA: 0x00002178 File Offset: 0x00000378
	public Class6(params SymmetricAlgorithm[] symmetricAlgorithm_1)
	{
		symmetricAlgorithm_1 = (SymmetricAlgorithm[])symmetricAlgorithm_1.Clone();
		Array.Sort<SymmetricAlgorithm>(symmetricAlgorithm_1, new Comparison<SymmetricAlgorithm>(Class6.Class7.class7_0.method_0));
		this.symmetricAlgorithm_0 = symmetricAlgorithm_1;
		int num = 0;
		foreach (SymmetricAlgorithm symmetricAlgorithm in symmetricAlgorithm_1)
		{
			num += symmetricAlgorithm.KeySize;
			symmetricAlgorithm.Mode = CipherMode.ECB;
			symmetricAlgorithm.Padding = PaddingMode.None;
		}
		this.BlockSizeValue = symmetricAlgorithm_1[symmetricAlgorithm_1.Length - 1].BlockSize;
		this.LegalBlockSizesValue = new KeySizes[]
		{
			new KeySizes(this.BlockSizeValue, this.BlockSizeValue, 0)
		};
		this.KeySizeValue = num;
		this.LegalKeySizesValue = new KeySizes[]
		{
			new KeySizes(num, num, 0)
		};
		this.int_0 = symmetricAlgorithm_1[0].BlockSize;
		this.Mode = CipherMode.ECB;
		this.Padding = PaddingMode.None;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002278 File Offset: 0x00000478
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000013 RID: 19 RVA: 0x00002280 File Offset: 0x00000480
	// (set) Token: 0x06000014 RID: 20 RVA: 0x00002288 File Offset: 0x00000488
	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			this.IVValue = (byte[])value.Clone();
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000229C File Offset: 0x0000049C
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return this.method_1(rgbKey, rgbIV, false);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000022A8 File Offset: 0x000004A8
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return this.method_1(rgbKey, rgbIV, true);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000022B4 File Offset: 0x000004B4
	private ICryptoTransform method_1(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		if (byte_0.Length * 8 != this.KeySize)
		{
			throw new ArgumentException("Invalid key size.", "#=zakh_yIU=");
		}
		if (byte_1.Length * 8 != this.method_0())
		{
			throw new ArgumentException("Invalid IV size.", "#=zt5lpyKI=");
		}
		return new Class6.Class8(this.symmetricAlgorithm_0, byte_0, byte_1, bool_0);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002314 File Offset: 0x00000514
	public override void GenerateIV()
	{
		throw new NotSupportedException();
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000231C File Offset: 0x0000051C
	public override void GenerateKey()
	{
		throw new NotSupportedException();
	}

	// Token: 0x04000005 RID: 5
	private readonly SymmetricAlgorithm[] symmetricAlgorithm_0;

	// Token: 0x04000006 RID: 6
	private readonly int int_0;

	// Token: 0x02000006 RID: 6
	[Serializable]
	private sealed class Class7
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002338 File Offset: 0x00000538
		internal int method_0(SymmetricAlgorithm symmetricAlgorithm_0, SymmetricAlgorithm symmetricAlgorithm_1)
		{
			return symmetricAlgorithm_1.BlockSize.CompareTo(symmetricAlgorithm_0.BlockSize);
		}

		// Token: 0x04000007 RID: 7
		public static readonly Class6.Class7 class7_0 = new Class6.Class7();

		// Token: 0x04000008 RID: 8
		public static Comparison<SymmetricAlgorithm> comparison_0;
	}

	// Token: 0x02000007 RID: 7
	private sealed class Class8 : ICryptoTransform, IDisposable
	{
		// Token: 0x0600001D RID: 29 RVA: 0x0000235C File Offset: 0x0000055C
		public Class8(SymmetricAlgorithm[] symmetricAlgorithm_1, byte[] byte_2, byte[] byte_3, bool bool_1)
		{
			this.byte_0 = byte_2;
			this.byte_1 = byte_3;
			this.symmetricAlgorithm_0 = symmetricAlgorithm_1;
			this.bool_0 = bool_1;
			this.int_0 = symmetricAlgorithm_1[symmetricAlgorithm_1.Length - 1].BlockSize / 8;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000239C File Offset: 0x0000059C
		public int InputBlockSize
		{
			get
			{
				return this.int_0;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000023A4 File Offset: 0x000005A4
		public int OutputBlockSize
		{
			get
			{
				return this.int_0;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000023AC File Offset: 0x000005AC
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000023B0 File Offset: 0x000005B0
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000023B4 File Offset: 0x000005B4
		public void Dispose()
		{
			if (this.icryptoTransform_0 != null)
			{
				foreach (ICryptoTransform cryptoTransform in this.icryptoTransform_0)
				{
					if (cryptoTransform != null)
					{
						cryptoTransform.Dispose();
					}
				}
				this.icryptoTransform_0 = null;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002404 File Offset: 0x00000604
		private void method_0()
		{
			SymmetricAlgorithm[] array = this.symmetricAlgorithm_0;
			int num = array.Length;
			if (this.icryptoTransform_0 == null)
			{
				ICryptoTransform[] array2 = new ICryptoTransform[num];
				int num2 = 0;
				for (int i = 0; i < num; i++)
				{
					SymmetricAlgorithm symmetricAlgorithm = array[i];
					int num3 = symmetricAlgorithm.KeySize / 8;
					byte[] array3 = new byte[num3];
					Buffer.BlockCopy(this.byte_0, num2, array3, 0, num3);
					num2 += num3;
					byte[] rgbIV = new byte[symmetricAlgorithm.BlockSize / 8];
					ICryptoTransform cryptoTransform = this.bool_0 ? symmetricAlgorithm.CreateEncryptor(array3, rgbIV) : symmetricAlgorithm.CreateDecryptor(array3, rgbIV);
					array2[i] = cryptoTransform;
				}
				this.icryptoTransform_0 = array2;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000024C0 File Offset: 0x000006C0
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			this.TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000024E4 File Offset: 0x000006E4
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			Buffer.BlockCopy(inputBuffer, inputOffset, outputBuffer, outputOffset, inputCount);
			this.method_0();
			if (this.bool_0)
			{
				this.method_1(outputBuffer, outputOffset, inputCount);
			}
			else
			{
				this.method_2(outputBuffer, outputOffset, inputCount);
			}
			return inputCount;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000251C File Offset: 0x0000071C
		private void method_1(byte[] byte_2, int int_1, int int_2)
		{
			byte[] array = new byte[this.byte_1.Length];
			Buffer.BlockCopy(this.byte_1, 0, array, 0, array.Length);
			int num = 0;
			foreach (ICryptoTransform cryptoTransform in this.icryptoTransform_0)
			{
				int inputBlockSize = cryptoTransform.InputBlockSize;
				int num2 = int_2 - num & ~(inputBlockSize - 1);
				int num3 = num + num2;
				for (int j = num; j < num3; j += inputBlockSize)
				{
					int num4 = j + int_1;
					Class6.Class8.smethod_0(byte_2, num4, array, 0, inputBlockSize);
					cryptoTransform.TransformBlock(byte_2, num4, inputBlockSize, byte_2, num4);
					Buffer.BlockCopy(byte_2, num4, array, 0, inputBlockSize);
				}
				num = num3;
				if (num3 == int_2)
				{
					break;
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000025DC File Offset: 0x000007DC
		private void method_2(byte[] byte_2, int int_1, int int_2)
		{
			byte[] array = new byte[this.byte_1.Length];
			Buffer.BlockCopy(this.byte_1, 0, array, 0, array.Length);
			byte[] array2 = new byte[array.Length];
			int num = 0;
			foreach (ICryptoTransform cryptoTransform in this.icryptoTransform_0)
			{
				int inputBlockSize = cryptoTransform.InputBlockSize;
				int num2 = int_2 - num & ~(inputBlockSize - 1);
				int num3 = num + num2;
				for (int j = num; j < num3; j += inputBlockSize)
				{
					int num4 = j + int_1;
					Buffer.BlockCopy(byte_2, num4, array2, 0, inputBlockSize);
					cryptoTransform.TransformBlock(byte_2, num4, inputBlockSize, byte_2, num4);
					Class6.Class8.smethod_0(byte_2, num4, array, 0, inputBlockSize);
					Buffer.BlockCopy(array2, 0, array, 0, inputBlockSize);
				}
				num = num3;
				if (num3 == int_2)
				{
					break;
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000026B4 File Offset: 0x000008B4
		private static void smethod_0(byte[] byte_2, int int_1, byte[] byte_3, int int_2, int int_3)
		{
			for (int i = 0; i < int_3; i++)
			{
				int num = int_1 + i;
				byte_2[num] ^= byte_3[int_2 + i];
			}
		}

		// Token: 0x04000009 RID: 9
		private readonly byte[] byte_0;

		// Token: 0x0400000A RID: 10
		private readonly byte[] byte_1;

		// Token: 0x0400000B RID: 11
		private readonly SymmetricAlgorithm[] symmetricAlgorithm_0;

		// Token: 0x0400000C RID: 12
		private ICryptoTransform[] icryptoTransform_0;

		// Token: 0x0400000D RID: 13
		private readonly bool bool_0;

		// Token: 0x0400000E RID: 14
		private readonly int int_0;
	}
}
