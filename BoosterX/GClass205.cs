using System;
using Newtonsoft.Json;

// Token: 0x0200066F RID: 1647
public sealed class GClass205
{
	// Token: 0x0600233F RID: 9023 RVA: 0x0008D3F8 File Offset: 0x0008B5F8
	public GClass205()
	{
	}

	// Token: 0x06002340 RID: 9024 RVA: 0x0008D400 File Offset: 0x0008B600
	public GClass205(GClass89 gclass89_0, string string_2)
	{
		this.String_0 = gclass89_0;
		this.String_1 = string_2;
	}

	// Token: 0x06002341 RID: 9025 RVA: 0x0008D41C File Offset: 0x0008B61C
	public GClass205(string string_2)
	{
		this.String_0 = GClass89.smethod_25();
		this.String_1 = string_2;
	}

	// Token: 0x17000589 RID: 1417
	// (get) Token: 0x06002342 RID: 9026 RVA: 0x0008D43C File Offset: 0x0008B63C
	// (set) Token: 0x06002343 RID: 9027 RVA: 0x0008D444 File Offset: 0x0008B644
	[JsonProperty("model")]
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

	// Token: 0x1700058A RID: 1418
	// (get) Token: 0x06002344 RID: 9028 RVA: 0x0008D450 File Offset: 0x0008B650
	// (set) Token: 0x06002345 RID: 9029 RVA: 0x0008D458 File Offset: 0x0008B658
	[JsonProperty("input")]
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

	// Token: 0x04001816 RID: 6166
	private string string_0;

	// Token: 0x04001817 RID: 6167
	private string string_1;
}
