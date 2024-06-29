using System;
using System.IO;

// Token: 0x02000096 RID: 150
internal sealed class Stream2 : Stream
{
	// Token: 0x060004BD RID: 1213 RVA: 0x00018E94 File Offset: 0x00017094
	public Stream2(Stream stream_1, Interface6 interface6_1)
	{
		if (stream_1 == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (interface6_1 == null)
		{
			throw new ArgumentNullException("transform");
		}
		this.stream_0 = stream_1;
		this.interface6_0 = interface6_1;
		if (this.stream_0.Length < 4L)
		{
			throw new InvalidOperationException();
		}
		this.method_0();
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00018EF4 File Offset: 0x000170F4
	private void method_0()
	{
		this.int_4 = this.interface6_0.imethod_0();
		this.byte_0 = new byte[this.int_4];
		this.int_7 = this.interface6_0.imethod_1();
		this.byte_1 = new byte[this.int_7];
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x060004BF RID: 1215 RVA: 0x00018F48 File Offset: 0x00017148
	public override bool CanRead
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00018F4C File Offset: 0x0001714C
	public override bool CanSeek
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00018F50 File Offset: 0x00017150
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00018F54 File Offset: 0x00017154
	public override long Length
	{
		get
		{
			this.method_4();
			return (long)this.int_0;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00018F64 File Offset: 0x00017164
	// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00018F7C File Offset: 0x0001717C
	public override long Position
	{
		get
		{
			return (long)(this.int_3 * this.int_7 + this.int_6);
		}
		set
		{
			int num = (int)value / this.int_7;
			this.int_6 = (int)value % this.int_7;
			if (this.int_3 != num)
			{
				this.int_3 = num;
				this.bool_2 = true;
				this.bool_0 = false;
			}
		}
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00018FC8 File Offset: 0x000171C8
	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			this.Position = offset;
			break;
		case SeekOrigin.Current:
			this.Position += offset;
			break;
		case SeekOrigin.End:
			this.Position = this.Length + offset;
			break;
		}
		return this.Position;
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00019018 File Offset: 0x00017218
	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00019020 File Offset: 0x00017220
	public override int Read(byte[] buffer, int offset, int count)
	{
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
		if (count == 0)
		{
			return 0;
		}
		int i = count;
		int num = offset;
		if (this.int_6 < this.int_7)
		{
			this.method_1();
			int num2 = this.int_5 - this.int_6;
			if (num2 > count)
			{
				Buffer.BlockCopy(this.byte_1, this.int_6, buffer, offset, count);
				this.int_6 += count;
				return count;
			}
			Buffer.BlockCopy(this.byte_1, this.int_6, buffer, offset, num2);
			this.int_6 = this.int_5;
			if (this.bool_1)
			{
				return num2;
			}
			i -= num2;
			num += num2;
		}
		if (this.bool_1)
		{
			return count - i;
		}
		while (i > 0)
		{
			this.method_2();
			if (this.bool_1)
			{
				return count - i;
			}
			int num3 = this.int_5;
			if (i < num3)
			{
				Buffer.BlockCopy(this.byte_1, 0, buffer, num, i);
				this.int_6 = i;
				return count;
			}
			Buffer.BlockCopy(this.byte_1, 0, buffer, num, num3);
			num += num3;
			i -= num3;
			this.int_6 = num3;
		}
		return count;
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x0001916C File Offset: 0x0001736C
	private void method_1()
	{
		this.method_4();
		if (!this.bool_0)
		{
			this.bool_0 = true;
			this.bool_1 = false;
			int num = this.int_3;
			if (this.bool_2)
			{
				this.stream_0.Position = (long)(4 + num * this.int_4);
				this.bool_2 = false;
			}
			this.method_3(num);
		}
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x000191CC File Offset: 0x000173CC
	private void method_2()
	{
		int int_ = this.int_3 + 1;
		if (this.method_3(int_))
		{
			this.int_3 = int_;
			this.int_6 = 0;
		}
		this.bool_0 = true;
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00019200 File Offset: 0x00017400
	private bool method_3(int int_8)
	{
		int i = 0;
		while (i < this.int_4)
		{
			int num = this.stream_0.Read(this.byte_0, i, this.int_4 - i);
			if (num != 0)
			{
				i += num;
			}
			else
			{
				if (i != 0)
				{
					throw new InvalidOperationException();
				}
				this.bool_1 = true;
				return false;
			}
		}
		this.int_5 = this.interface6_0.imethod_2(this.byte_0, 0, this.int_4, this.byte_1, 0, null);
		if (int_8 == this.int_1)
		{
			this.int_5 = this.int_2;
		}
		return true;
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x0001929C File Offset: 0x0001749C
	private void method_4()
	{
		if (!this.bool_3)
		{
			if (this.stream_0.Position != 0L)
			{
				this.stream_0.Position = 0L;
				this.bool_2 = true;
			}
			Struct0 @struct = Stream2.smethod_0(this.stream_0);
			this.int_0 = @struct.int_0;
			this.int_1 = this.int_0 / this.int_7;
			this.int_2 = this.int_0 % this.int_7;
			this.bool_3 = true;
		}
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00019320 File Offset: 0x00017520
	private static Struct0 smethod_0(Stream stream_1)
	{
		Class42 @class = new Class42(stream_1, 0);
		Struct0 result;
		try
		{
			Class79 class2 = new Class79(@class);
			try
			{
				result = new Struct0(class2.method_19());
			}
			finally
			{
				((IDisposable)class2).Dispose();
			}
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		return result;
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00019378 File Offset: 0x00017578
	public override void Flush()
	{
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x0001937C File Offset: 0x0001757C
	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	// Token: 0x04000126 RID: 294
	private int int_0;

	// Token: 0x04000127 RID: 295
	private int int_1;

	// Token: 0x04000128 RID: 296
	private int int_2;

	// Token: 0x04000129 RID: 297
	private Stream stream_0;

	// Token: 0x0400012A RID: 298
	private Interface6 interface6_0;

	// Token: 0x0400012B RID: 299
	private int int_3;

	// Token: 0x0400012C RID: 300
	private bool bool_0;

	// Token: 0x0400012D RID: 301
	private bool bool_1;

	// Token: 0x0400012E RID: 302
	private bool bool_2;

	// Token: 0x0400012F RID: 303
	private byte[] byte_0;

	// Token: 0x04000130 RID: 304
	private int int_4;

	// Token: 0x04000131 RID: 305
	private byte[] byte_1;

	// Token: 0x04000132 RID: 306
	private int int_5;

	// Token: 0x04000133 RID: 307
	private int int_6;

	// Token: 0x04000134 RID: 308
	private int int_7;

	// Token: 0x04000135 RID: 309
	private bool bool_3;
}
