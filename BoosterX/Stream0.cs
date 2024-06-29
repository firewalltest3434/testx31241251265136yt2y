using System;
using System.IO;

// Token: 0x02000058 RID: 88
internal sealed class Stream0 : Stream
{
	// Token: 0x06000346 RID: 838 RVA: 0x00013514 File Offset: 0x00011714
	public Stream0(Stream stream_1, int int_1)
	{
		this.method_1(stream_1);
		this.int_0 = int_1;
	}

	// Token: 0x06000347 RID: 839 RVA: 0x0001352C File Offset: 0x0001172C
	public Stream method_0()
	{
		return this.stream_0;
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00013534 File Offset: 0x00011734
	private void method_1(Stream stream_1)
	{
		this.stream_0 = stream_1;
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000349 RID: 841 RVA: 0x00013540 File Offset: 0x00011740
	public override bool CanRead
	{
		get
		{
			return this.method_0().CanRead;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600034A RID: 842 RVA: 0x00013550 File Offset: 0x00011750
	public override bool CanSeek
	{
		get
		{
			return this.method_0().CanSeek;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600034B RID: 843 RVA: 0x00013560 File Offset: 0x00011760
	public override bool CanWrite
	{
		get
		{
			return this.method_0().CanWrite;
		}
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00013570 File Offset: 0x00011770
	public override void Flush()
	{
		this.method_0().Flush();
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600034D RID: 845 RVA: 0x00013580 File Offset: 0x00011780
	public override long Length
	{
		get
		{
			return this.method_0().Length;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600034E RID: 846 RVA: 0x00013590 File Offset: 0x00011790
	// (set) Token: 0x0600034F RID: 847 RVA: 0x000135A0 File Offset: 0x000117A0
	public override long Position
	{
		get
		{
			return this.method_0().Position;
		}
		set
		{
			this.method_0().Position = value;
		}
	}

	// Token: 0x06000350 RID: 848 RVA: 0x000135B0 File Offset: 0x000117B0
	private byte method_2(byte byte_0, long long_0)
	{
		byte b = (byte)((ulong)this.int_0 | (ulong)long_0);
		return byte_0 ^ b;
	}

	// Token: 0x06000351 RID: 849 RVA: 0x000135CC File Offset: 0x000117CC
	public override void Write(byte[] buffer, int offset, int count)
	{
		byte[] array = new byte[count];
		Buffer.BlockCopy(buffer, offset, array, 0, count);
		long position = this.Position;
		for (int i = 0; i < count; i++)
		{
			array[i] = this.method_2(array[i], position + (long)i);
		}
		this.method_0().Write(array, 0, count);
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00013624 File Offset: 0x00011824
	public override int Read(byte[] buffer, int offset, int count)
	{
		long position = this.Position;
		byte[] array = new byte[count];
		int num = this.method_0().Read(array, 0, count);
		for (int i = 0; i < num; i++)
		{
			buffer[i + offset] = this.method_2(array[i], position + (long)i);
		}
		return num;
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00013678 File Offset: 0x00011878
	public override long Seek(long offset, SeekOrigin origin)
	{
		return this.method_0().Seek(offset, origin);
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00013688 File Offset: 0x00011888
	public override void SetLength(long value)
	{
		this.method_0().SetLength(value);
	}

	// Token: 0x040000A2 RID: 162
	private readonly int int_0;

	// Token: 0x040000A3 RID: 163
	private Stream stream_0;
}
