using System;
using System.Text;

// Token: 0x02000302 RID: 770
public sealed class GClass90
{
	// Token: 0x06001199 RID: 4505 RVA: 0x00049BC0 File Offset: 0x00047DC0
	public GClass90()
	{
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00049BE0 File Offset: 0x00047DE0
	public GClass90(uint uint_2, string string_1)
	{
		this.uint_0 = uint_2;
		this.stringBuilder_0 = new StringBuilder(string_1);
		this.uint_1 = 1U;
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00049C1C File Offset: 0x00047E1C
	public GClass90(string string_1, string string_2)
	{
		this.string_0 = string_1;
		this.stringBuilder_0 = new StringBuilder(string_2);
		this.uint_1 = 1U;
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00049C58 File Offset: 0x00047E58
	public GClass90(byte[] byte_1, string string_1)
	{
		this.byte_0 = byte_1;
		this.stringBuilder_0 = new StringBuilder(string_1);
		this.uint_1 = 1U;
	}

	// Token: 0x04000AA6 RID: 2726
	public string string_0 = string.Empty;

	// Token: 0x04000AA7 RID: 2727
	public uint uint_0;

	// Token: 0x04000AA8 RID: 2728
	public byte[] byte_0 = new byte[0];

	// Token: 0x04000AA9 RID: 2729
	public StringBuilder stringBuilder_0;

	// Token: 0x04000AAA RID: 2730
	public uint uint_1;
}
