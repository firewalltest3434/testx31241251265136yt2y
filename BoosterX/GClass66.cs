using System;
using Newtonsoft.Json;

// Token: 0x0200025B RID: 603
public sealed class GClass66
{
	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0003DB64 File Offset: 0x0003BD64
	// (set) Token: 0x06000E19 RID: 3609 RVA: 0x0003DB6C File Offset: 0x0003BD6C
	[JsonProperty("IdType")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0003DB78 File Offset: 0x0003BD78
	// (set) Token: 0x06000E1B RID: 3611 RVA: 0x0003DB80 File Offset: 0x0003BD80
	[JsonProperty("Value")]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x040008A5 RID: 2213
	private string string_0;

	// Token: 0x040008A6 RID: 2214
	private string string_1;
}
