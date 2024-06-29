using System;
using System.IO;

// Token: 0x020000A9 RID: 169
internal sealed class Class42 : Class41
{
	// Token: 0x06000544 RID: 1348 RVA: 0x0001C568 File Offset: 0x0001A768
	public Class42(Stream stream_1, int int_1)
	{
		this.stream_0 = stream_1;
		this.int_0 = (int_1 ^ -559030707);
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0001C584 File Offset: 0x0001A784
	public Stream method_0()
	{
		return this.stream_0;
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x0001C58C File Offset: 0x0001A78C
	public override bool vmethod_0()
	{
		return this.method_0().CanRead;
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x0001C59C File Offset: 0x0001A79C
	public override bool vmethod_2()
	{
		return this.method_0().CanSeek;
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0001C5AC File Offset: 0x0001A7AC
	public override bool vmethod_1()
	{
		return this.method_0().CanWrite;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x0001C5BC File Offset: 0x0001A7BC
	public override void vmethod_8()
	{
		this.method_0().Flush();
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x0001C5CC File Offset: 0x0001A7CC
	public override long vmethod_3()
	{
		return this.method_0().Length;
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x0001C5DC File Offset: 0x0001A7DC
	public override long vmethod_4()
	{
		return this.method_0().Position;
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x0001C5EC File Offset: 0x0001A7EC
	public override void vmethod_5(long long_0)
	{
		this.method_0().Position = long_0;
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0001C5FC File Offset: 0x0001A7FC
	private byte method_1(byte byte_0, uint uint_0)
	{
		byte b = (byte)(this.int_0 ^ (int)uint_0);
		return byte_0 ^ b;
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x0001C618 File Offset: 0x0001A818
	public override void vmethod_13(byte[] byte_0, int int_1, int int_2)
	{
		uint num = (uint)this.vmethod_4();
		byte[] array = new byte[int_2];
		uint num2 = 0U;
		while ((ulong)num2 < (ulong)((long)int_2))
		{
			array[(int)num2] = this.method_1(byte_0[(int)(checked((IntPtr)(unchecked((ulong)num2 + (ulong)((long)int_1)))))], num + num2);
			num2 += 1U;
		}
		this.method_0().Write(array, 0, int_2);
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x0001C66C File Offset: 0x0001A86C
	public override int vmethod_11(byte[] byte_0, int int_1, int int_2)
	{
		uint num = (uint)this.vmethod_4();
		int num2 = this.method_0().Read(byte_0, int_1, int_2);
		int num3 = int_1 + num2;
		for (int i = int_1; i < num3; i++)
		{
			byte_0[i] = this.method_1(byte_0[i], num++);
		}
		return num2;
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x0001C6BC File Offset: 0x0001A8BC
	public override long vmethod_9(long long_0, int int_1)
	{
		SeekOrigin origin;
		switch (int_1)
		{
		case 0:
			origin = SeekOrigin.Begin;
			break;
		case 1:
			origin = SeekOrigin.Current;
			break;
		case 2:
			origin = SeekOrigin.End;
			break;
		default:
			throw new ArgumentException();
		}
		return this.method_0().Seek(long_0, origin);
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x0001C6F8 File Offset: 0x0001A8F8
	public override void vmethod_10(long long_0)
	{
		this.method_0().SetLength(long_0);
	}

	// Token: 0x04000231 RID: 561
	private readonly int int_0;

	// Token: 0x04000232 RID: 562
	private readonly Stream stream_0;
}
