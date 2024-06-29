using System;
using Newtonsoft.Json;

// Token: 0x02000432 RID: 1074
public sealed class GClass120
{
	// Token: 0x1700035B RID: 859
	// (get) Token: 0x060017A6 RID: 6054 RVA: 0x000632B4 File Offset: 0x000614B4
	// (set) Token: 0x060017A7 RID: 6055 RVA: 0x000632BC File Offset: 0x000614BC
	[JsonProperty("MaxTested")]
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			this.long_0 = value;
		}
	}

	// Token: 0x1700035C RID: 860
	// (get) Token: 0x060017A8 RID: 6056 RVA: 0x000632C8 File Offset: 0x000614C8
	// (set) Token: 0x060017A9 RID: 6057 RVA: 0x000632D0 File Offset: 0x000614D0
	[JsonProperty("MinVersion")]
	public long Int64_1
	{
		get
		{
			return this.long_1;
		}
		set
		{
			this.long_1 = value;
		}
	}

	// Token: 0x1700035D RID: 861
	// (get) Token: 0x060017AA RID: 6058 RVA: 0x000632DC File Offset: 0x000614DC
	// (set) Token: 0x060017AB RID: 6059 RVA: 0x000632E4 File Offset: 0x000614E4
	[JsonProperty("PlatformName")]
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

	// Token: 0x040010C6 RID: 4294
	private long long_0;

	// Token: 0x040010C7 RID: 4295
	private long long_1;

	// Token: 0x040010C8 RID: 4296
	private string string_0;
}
