using System;
using Newtonsoft.Json;

// Token: 0x020001C0 RID: 448
public class GClass29
{
	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00031948 File Offset: 0x0002FB48
	// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00031950 File Offset: 0x0002FB50
	[JsonProperty("prompt_tokens")]
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0003195C File Offset: 0x0002FB5C
	// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00031964 File Offset: 0x0002FB64
	[JsonProperty("total_tokens")]
	public int Int32_1
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x0400067D RID: 1661
	private int int_0;

	// Token: 0x0400067E RID: 1662
	private int int_1;
}
