using System;
using System.Runtime.InteropServices;
using System.Text;

namespace NvidiaX.NVIDIA.Native.NVAPI
{
	// Token: 0x0200084B RID: 2123
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 8, Size = 4100)]
	public struct NVDRS_SETTING_UNION
	{
		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x000BAAF4 File Offset: 0x000B8CF4
		// (set) Token: 0x06002B27 RID: 11047 RVA: 0x000BAB28 File Offset: 0x000B8D28
		public byte[] binaryValue
		{
			get
			{
				uint num = BitConverter.ToUInt32(this.rawData, 0);
				byte[] array = new byte[num];
				Buffer.BlockCopy(this.rawData, 4, array, 0, (int)num);
				return array;
			}
			set
			{
				this.rawData = new byte[4100];
				if (value != null)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(value.Length), 0, this.rawData, 0, 4);
					Buffer.BlockCopy(value, 0, this.rawData, 4, value.Length);
				}
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x000BAB64 File Offset: 0x000B8D64
		// (set) Token: 0x06002B29 RID: 11049 RVA: 0x000BAB74 File Offset: 0x000B8D74
		public uint dwordValue
		{
			get
			{
				return BitConverter.ToUInt32(this.rawData, 0);
			}
			set
			{
				this.rawData = new byte[4100];
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.rawData, 0, 4);
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000BAB9C File Offset: 0x000B8D9C
		// (set) Token: 0x06002B2B RID: 11051 RVA: 0x000BABBC File Offset: 0x000B8DBC
		public string stringValue
		{
			get
			{
				return Encoding.Unicode.GetString(this.rawData).Split(new char[1], 2)[0];
			}
			set
			{
				this.rawData = new byte[4100];
				byte[] bytes = Encoding.Unicode.GetBytes(value);
				Buffer.BlockCopy(bytes, 0, this.rawData, 0, bytes.Length);
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x000BABF8 File Offset: 0x000B8DF8
		// (set) Token: 0x06002B2D RID: 11053 RVA: 0x000BAC18 File Offset: 0x000B8E18
		public string ansiStringValue
		{
			get
			{
				return Encoding.Default.GetString(this.rawData).Split(new char[1], 2)[0];
			}
			set
			{
				this.rawData = new byte[4100];
				byte[] bytes = Encoding.Default.GetBytes(value);
				Buffer.BlockCopy(bytes, 0, this.rawData, 0, bytes.Length);
			}
		}

		// Token: 0x0400218E RID: 8590
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4100)]
		public byte[] rawData;
	}
}
