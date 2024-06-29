using System;
using System.IO;

// Token: 0x02000078 RID: 120
internal sealed class Stream1 : Stream
{
	// Token: 0x06000408 RID: 1032 RVA: 0x000165C0 File Offset: 0x000147C0
	public Stream1(Stream stream_1, Class12 class12_1 = null, Class35 class35_1 = null, bool bool_2 = false)
	{
		this.stream_0 = stream_1;
		this.bool_0 = bool_2;
		this.class35_0 = class35_1;
		this.class12_0 = class12_1;
		if (this.class12_0 == null)
		{
			this.class12_0 = Class12.smethod_0();
		}
		if (this.class12_0.method_2() == 0)
		{
			throw new ArgumentException("parameters");
		}
		if (this.class12_0.method_4() == 0)
		{
			throw new ArgumentException("parameters");
		}
		if (!this.stream_0.CanRead)
		{
			throw new ArgumentException("stream");
		}
		if (!this.stream_0.CanSeek)
		{
			throw new ArgumentException("stream");
		}
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00016664 File Offset: 0x00014864
	private void method_0()
	{
		if (!this.bool_1)
		{
			this.class21_0 = new Class21[this.class12_0.method_2()];
			for (int i = 0; i < this.class12_0.method_2(); i++)
			{
				this.class21_0[i] = new Class21();
			}
			if (this.class35_0 != null)
			{
				this.class24_0 = this.class35_0.method_0(this.class12_0);
			}
			this.bool_1 = true;
		}
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x000166EC File Offset: 0x000148EC
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && !this.bool_0)
			{
				this.stream_0.Close();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600040B RID: 1035 RVA: 0x0001672C File Offset: 0x0001492C
	public override bool CanRead
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600040C RID: 1036 RVA: 0x00016730 File Offset: 0x00014930
	public override bool CanSeek
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600040D RID: 1037 RVA: 0x00016734 File Offset: 0x00014934
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600040E RID: 1038 RVA: 0x00016738 File Offset: 0x00014938
	public override long Length
	{
		get
		{
			return this.stream_0.Length;
		}
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00016748 File Offset: 0x00014948
	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00016750 File Offset: 0x00014950
	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00016758 File Offset: 0x00014958
	public override void Flush()
	{
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001675C File Offset: 0x0001495C
	// (set) Token: 0x06000413 RID: 1043 RVA: 0x00016778 File Offset: 0x00014978
	public override long Position
	{
		get
		{
			return this.stream_0.Position + (long)(this.int_0 - this.int_1);
		}
		set
		{
			this.Seek(value, SeekOrigin.Begin);
		}
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00016784 File Offset: 0x00014984
	private int method_1(byte[] byte_1, int int_2, int int_3)
	{
		int num = this.int_1 - this.int_0;
		if (num <= 0)
		{
			return 0;
		}
		if (num > int_3)
		{
			num = int_3;
		}
		Buffer.BlockCopy(this.byte_0, this.int_0, byte_1, int_2, num);
		this.int_0 += num;
		return num;
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x000167D8 File Offset: 0x000149D8
	private void method_2(int int_2)
	{
		int num = (int)this.stream_0.Position;
		if ((long)num >= this.stream_0.Length)
		{
			return;
		}
		int num2 = num + int_2;
		foreach (Class21 @class in this.class21_0)
		{
			if (@class.int_0 <= num && @class.int_1 >= num2)
			{
				this.byte_0 = @class.byte_0;
				this.int_1 = @class.int_1 - @class.int_0;
				this.int_0 = num - @class.int_0;
				this.stream_0.Position = (long)@class.int_1;
				@class.dateTime_0 = DateTime.UtcNow;
				return;
			}
		}
		int num3 = 0;
		DateTime dateTime_ = this.class21_0[0].dateTime_0;
		for (int j = 1; j < this.class21_0.Length; j++)
		{
			if (this.class21_0[j].dateTime_0 < dateTime_)
			{
				num3 = j;
			}
		}
		Class21 class2 = this.class21_0[num3];
		if (class2.byte_0 == null)
		{
			class2.byte_0 = new byte[this.class12_0.method_0()];
		}
		int num4 = num;
		num = this.method_3(num);
		if (num < 0)
		{
			num = 0;
		}
		num2 = num + this.class12_0.method_0();
		if (this.class24_0 != null && this.class24_0.method_3(num, ref class2))
		{
			this.byte_0 = class2.byte_0;
			this.int_1 = class2.int_1 - num;
			this.stream_0.Position = (long)class2.int_1;
			this.int_0 = num4 - num;
		}
		else
		{
			class2.int_0 = num;
			class2.dateTime_0 = DateTime.UtcNow;
			this.byte_0 = class2.byte_0;
			this.stream_0.Position = (long)num;
			this.int_1 = this.stream_0.Read(this.byte_0, 0, num2 - num);
			this.int_0 = num4 - num;
			class2.int_1 = num + this.int_1;
			if (this.class24_0 != null)
			{
				this.class24_0.method_1(class2);
				return;
			}
		}
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00016A10 File Offset: 0x00014C10
	private int method_3(int int_2)
	{
		return int_2 - int_2 % this.class12_0.method_0();
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00016A24 File Offset: 0x00014C24
	public override int Read(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("#=zakh_yIU=");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("#=zt5lpyKI=");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("#=zD4aStCw=");
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException();
		}
		int int_ = offset;
		int num = this.method_1(buffer, offset, count);
		if (num == count)
		{
			return num;
		}
		int num2 = num;
		if (num > 0)
		{
			count -= num;
			offset += num;
		}
		this.int_1 = 0;
		this.int_0 = 0;
		this.method_0();
		if (count < this.class12_0.method_0())
		{
			this.method_2(count);
			num = this.method_1(buffer, offset, count);
			return num + num2;
		}
		if (this.class24_0 == null)
		{
			return this.stream_0.Read(buffer, offset, count) + num2;
		}
		int int_2 = (int)this.stream_0.Position - num2;
		int num3;
		if (this.class24_0.method_8(int_2, buffer, int_, count + num2, out num3))
		{
			this.stream_0.Seek((long)(num3 - num2), SeekOrigin.Current);
			return num3;
		}
		num3 = this.stream_0.Read(buffer, offset, count);
		if (num3 != 0)
		{
			this.class24_0.method_7(int_2, buffer, int_, num3 + num2, num3 < count);
		}
		return num3 + num2;
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00016B68 File Offset: 0x00014D68
	public override long Seek(long offset, SeekOrigin origin)
	{
		if (this.int_1 - this.int_0 > 0 && origin == SeekOrigin.Current)
		{
			offset -= (long)(this.int_1 - this.int_0);
		}
		long position = this.Position;
		long num = this.stream_0.Seek(offset, origin);
		this.int_0 = (int)(num - (position - (long)this.int_0));
		if (0 <= this.int_0 && this.int_0 < this.int_1)
		{
			this.stream_0.Seek((long)(this.int_1 - this.int_0), SeekOrigin.Current);
		}
		else
		{
			this.int_1 = 0;
			this.int_0 = 0;
		}
		return num;
	}

	// Token: 0x040000E6 RID: 230
	private bool bool_0;

	// Token: 0x040000E7 RID: 231
	private Stream stream_0;

	// Token: 0x040000E8 RID: 232
	private Class21[] class21_0;

	// Token: 0x040000E9 RID: 233
	private Class12 class12_0;

	// Token: 0x040000EA RID: 234
	private Class35 class35_0;

	// Token: 0x040000EB RID: 235
	private Class24 class24_0;

	// Token: 0x040000EC RID: 236
	private bool bool_1;

	// Token: 0x040000ED RID: 237
	private byte[] byte_0;

	// Token: 0x040000EE RID: 238
	private int int_0;

	// Token: 0x040000EF RID: 239
	private int int_1;
}
