using System;
using System.Runtime.CompilerServices;

// Token: 0x020001DB RID: 475
internal sealed class Class256
{
	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00034144 File Offset: 0x00032344
	// (set) Token: 0x06000B25 RID: 2853 RVA: 0x0003414C File Offset: 0x0003234C
	public Guid Id
	{
		[CompilerGenerated]
		get
		{
			return this.guid_0;
		}
		[CompilerGenerated]
		set
		{
			this.guid_0 = value;
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00034158 File Offset: 0x00032358
	// (set) Token: 0x06000B27 RID: 2855 RVA: 0x00034160 File Offset: 0x00032360
	public string Json
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x040006E4 RID: 1764
	private Guid guid_0;

	// Token: 0x040006E5 RID: 1765
	private string string_0 = string.Empty;
}
