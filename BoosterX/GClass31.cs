using System;
using Newtonsoft.Json;

// Token: 0x02000592 RID: 1426
public sealed class GClass31 : GClass29
{
	// Token: 0x170004CE RID: 1230
	// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x0007FDF0 File Offset: 0x0007DFF0
	// (set) Token: 0x06001EC2 RID: 7874 RVA: 0x0007FDF8 File Offset: 0x0007DFF8
	[JsonProperty("completion_tokens")]
	public int Int32_2
	{
		get
		{
			return this.int_2;
		}
		set
		{
			this.int_2 = value;
		}
	}

	// Token: 0x04001596 RID: 5526
	private int int_2;
}
