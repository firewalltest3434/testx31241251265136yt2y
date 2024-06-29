using System;
using System.IO;

// Token: 0x020000B9 RID: 185
internal sealed class Class43 : Class41, IDisposable
{
	// Token: 0x060005A4 RID: 1444 RVA: 0x0001D954 File Offset: 0x0001BB54
	public Class43() : this(0)
	{
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x0001D960 File Offset: 0x0001BB60
	public Class43(int int_4)
	{
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.byte_0 = new byte[int_4];
		this.int_3 = int_4;
		this.bool_0 = true;
		this.bool_1 = true;
		this.int_0 = 0;
		this.bool_2 = true;
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x0001D9AC File Offset: 0x0001BBAC
	public Class43(byte[] byte_1) : this(byte_1, true)
	{
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x0001D9B8 File Offset: 0x0001BBB8
	public Class43(byte[] byte_1, bool bool_4)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		this.byte_0 = byte_1;
		this.int_2 = (this.int_3 = byte_1.Length);
		this.bool_1 = bool_4;
		this.int_0 = 0;
		this.bool_2 = true;
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x0001DA04 File Offset: 0x0001BC04
	public Class43(byte[] byte_1, int int_4, int int_5) : this(byte_1, int_4, int_5, true)
	{
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x0001DA10 File Offset: 0x0001BC10
	public Class43(byte[] byte_1, int int_4, int int_5, bool bool_4)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		this.byte_0 = byte_1;
		this.int_1 = int_4;
		this.int_0 = int_4;
		this.int_2 = (this.int_3 = int_4 + int_5);
		this.bool_1 = bool_4;
		this.bool_0 = false;
		this.bool_2 = true;
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x0001DA90 File Offset: 0x0001BC90
	public override bool vmethod_0()
	{
		return this.bool_2;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x0001DA98 File Offset: 0x0001BC98
	public override bool vmethod_2()
	{
		return this.bool_2;
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x0001DAA0 File Offset: 0x0001BCA0
	public override bool vmethod_1()
	{
		return this.bool_1;
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x0001DAA8 File Offset: 0x0001BCA8
	protected override void vmethod_7(bool bool_4)
	{
		if (!this.bool_3)
		{
			if (bool_4)
			{
				this.bool_2 = false;
				this.bool_1 = false;
				this.bool_0 = false;
			}
			this.bool_3 = true;
		}
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x0001DAD4 File Offset: 0x0001BCD4
	private bool method_0(int int_4)
	{
		if (int_4 < 0)
		{
			throw new IOException();
		}
		if (int_4 > this.int_3)
		{
			int num = int_4;
			if (num < 256)
			{
				num = 256;
			}
			if (num < this.int_3 * 2)
			{
				num = this.int_3 * 2;
			}
			this.method_6(num);
			return true;
		}
		return false;
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x0001DB24 File Offset: 0x0001BD24
	public override void vmethod_8()
	{
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x0001DB28 File Offset: 0x0001BD28
	internal byte[] method_1()
	{
		return this.byte_0;
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x0001DB30 File Offset: 0x0001BD30
	internal void method_2(out int int_4, out int int_5)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		int_4 = this.int_0;
		int_5 = this.int_2;
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0001DB50 File Offset: 0x0001BD50
	internal int method_3()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return this.int_1;
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x0001DB68 File Offset: 0x0001BD68
	public int method_4(int int_4)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		int num = this.int_2 - this.int_1;
		if (num > int_4)
		{
			num = int_4;
		}
		if (num < 0)
		{
			num = 0;
		}
		this.int_1 += num;
		return num;
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x0001DBAC File Offset: 0x0001BDAC
	public int method_5()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return this.int_3 - this.int_0;
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0001DBCC File Offset: 0x0001BDCC
	public void method_6(int int_4)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (int_4 != this.int_3)
		{
			if (!this.bool_0)
			{
				throw new Exception();
			}
			if (int_4 < this.int_2)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (int_4 > 0)
			{
				byte[] dst = new byte[int_4];
				if (this.int_2 > 0)
				{
					Buffer.BlockCopy(this.byte_0, 0, dst, 0, this.int_2);
				}
				this.byte_0 = dst;
			}
			else
			{
				this.byte_0 = null;
			}
			this.int_3 = int_4;
		}
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x0001DC64 File Offset: 0x0001BE64
	public override long vmethod_3()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return (long)(this.int_2 - this.int_0);
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x0001DC84 File Offset: 0x0001BE84
	public override long vmethod_4()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return (long)(this.int_1 - this.int_0);
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x0001DCA4 File Offset: 0x0001BEA4
	public override void vmethod_5(long long_0)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (long_0 < 0L)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.int_1 = this.int_0 + (int)long_0;
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x0001DCF4 File Offset: 0x0001BEF4
	public override int vmethod_11(byte[] byte_1, int int_4, int int_5)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		int num = this.int_2 - this.int_1;
		if (num > int_5)
		{
			num = int_5;
		}
		if (num <= 0)
		{
			return 0;
		}
		if (num <= 8)
		{
			int num2 = num;
			while (--num2 >= 0)
			{
				byte_1[int_4 + num2] = this.byte_0[this.int_1 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(this.byte_0, this.int_1, byte_1, int_4, num);
		}
		this.int_1 += num;
		return num;
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0001DDC4 File Offset: 0x0001BFC4
	public override int vmethod_12()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (this.int_1 >= this.int_2)
		{
			return -1;
		}
		byte[] array = this.byte_0;
		int num = this.int_1;
		this.int_1 = num + 1;
		return array[num];
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x0001DE10 File Offset: 0x0001C010
	public override long vmethod_9(long long_0, int int_4)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		switch (int_4)
		{
		case 0:
			if (long_0 < 0L)
			{
				throw new IOException();
			}
			this.int_1 = this.int_0 + (int)long_0;
			break;
		case 1:
			if (long_0 + (long)this.int_1 < (long)this.int_0)
			{
				throw new IOException();
			}
			this.int_1 += (int)long_0;
			break;
		case 2:
			if ((long)this.int_2 + long_0 < (long)this.int_0)
			{
				throw new IOException();
			}
			this.int_1 = this.int_2 + (int)long_0;
			break;
		default:
			throw new ArgumentException();
		}
		return (long)this.int_1;
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0001DED0 File Offset: 0x0001C0D0
	public override void vmethod_10(long long_0)
	{
		if (!this.bool_1)
		{
			throw new Exception();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (long_0 >= 0L && long_0 <= (long)(2147483647 - this.int_0))
		{
			int num = this.int_0 + (int)long_0;
			if (!this.method_0(num) && num > this.int_2)
			{
				Array.Clear(this.byte_0, this.int_2, num - this.int_2);
			}
			this.int_2 = num;
			if (this.int_1 > num)
			{
				this.int_1 = num;
			}
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x0001DF84 File Offset: 0x0001C184
	public byte[] method_7()
	{
		byte[] array = new byte[this.int_2 - this.int_0];
		Buffer.BlockCopy(this.byte_0, this.int_0, array, 0, this.int_2 - this.int_0);
		return array;
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0001DFC8 File Offset: 0x0001C1C8
	public override void vmethod_13(byte[] byte_1, int int_4, int int_5)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (!this.bool_1)
		{
			throw new Exception();
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		int num = this.int_1 + int_5;
		if (num < 0)
		{
			throw new IOException();
		}
		if (num > this.int_2)
		{
			bool flag = this.int_1 > this.int_2;
			if (num <= this.int_3 || !this.method_0(num))
			{
				if (flag)
				{
					Array.Clear(this.byte_0, this.int_2, num - this.int_2);
				}
			}
			this.int_2 = num;
		}
		if (int_5 <= 8)
		{
			int num2 = int_5;
			while (--num2 >= 0)
			{
				this.byte_0[this.int_1 + num2] = byte_1[int_4 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(byte_1, int_4, this.byte_0, this.int_1, int_5);
		}
		this.int_1 = num;
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x0001E0F4 File Offset: 0x0001C2F4
	public override void vmethod_14(byte byte_1)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (!this.bool_1)
		{
			throw new Exception();
		}
		if (this.int_1 >= this.int_2)
		{
			int num = this.int_1 + 1;
			bool flag = this.int_1 > this.int_2;
			if (num < this.int_3 || !this.method_0(num))
			{
				if (flag)
				{
					Array.Clear(this.byte_0, this.int_2, this.int_1 - this.int_2);
				}
			}
			this.int_2 = num;
		}
		byte[] array = this.byte_0;
		int num2 = this.int_1;
		this.int_1 = num2 + 1;
		array[num2] = byte_1;
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0001E1B4 File Offset: 0x0001C3B4
	public void method_8(Stream stream_0)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (stream_0 == null)
		{
			throw new ArgumentNullException();
		}
		stream_0.Write(this.byte_0, this.int_0, this.int_2 - this.int_0);
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x0001E1EC File Offset: 0x0001C3EC
	internal int method_9()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		int num = this.int_1 += 4;
		if (num > this.int_2)
		{
			this.int_1 = this.int_2;
			throw new Exception();
		}
		return (int)this.byte_0[num - 3] | (int)this.byte_0[num - 2] << 8 | (int)this.byte_0[num - 4] << 24 | (int)this.byte_0[num - 1] << 16;
	}

	// Token: 0x0400025D RID: 605
	private byte[] byte_0;

	// Token: 0x0400025E RID: 606
	private int int_0;

	// Token: 0x0400025F RID: 607
	private int int_1;

	// Token: 0x04000260 RID: 608
	private int int_2;

	// Token: 0x04000261 RID: 609
	private int int_3;

	// Token: 0x04000262 RID: 610
	private bool bool_0;

	// Token: 0x04000263 RID: 611
	private bool bool_1;

	// Token: 0x04000264 RID: 612
	private bool bool_2;

	// Token: 0x04000265 RID: 613
	private bool bool_3;
}
