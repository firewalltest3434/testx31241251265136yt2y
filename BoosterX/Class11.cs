using System;

// Token: 0x0200000B RID: 11
internal sealed class Class11
{
	// Token: 0x06000045 RID: 69 RVA: 0x00002C40 File Offset: 0x00000E40
	public Class11(string string_1, Class94 class94_1, Class103 class103_1)
	{
		this.string_0 = string_1;
		this.class94_0 = class94_1;
		this.class103_0 = class103_1;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002C60 File Offset: 0x00000E60
	protected override void Finalize()
	{
		try
		{
			object object_ = this.class103_0.object_0;
			lock (object_)
			{
				if (!this.class103_0.bool_1)
				{
					this.class103_0.byte_0 = Class114.smethod_1(this.string_0);
					this.class103_0.bool_1 = true;
					Class114.smethod_3(this.string_0);
				}
			}
		}
		finally
		{
			base.Finalize();
		}
	}

	// Token: 0x04000016 RID: 22
	public readonly string string_0;

	// Token: 0x04000017 RID: 23
	public readonly Class94 class94_0;

	// Token: 0x04000018 RID: 24
	public readonly Class103 class103_0;
}
