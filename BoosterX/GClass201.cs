using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200062F RID: 1583
public sealed class GClass201
{
	// Token: 0x17000575 RID: 1397
	// (get) Token: 0x06002216 RID: 8726 RVA: 0x0008A948 File Offset: 0x00088B48
	// (set) Token: 0x06002217 RID: 8727 RVA: 0x0008A950 File Offset: 0x00088B50
	[JsonProperty("ProductFamilyName")]
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

	// Token: 0x17000576 RID: 1398
	// (get) Token: 0x06002218 RID: 8728 RVA: 0x0008A95C File Offset: 0x00088B5C
	// (set) Token: 0x06002219 RID: 8729 RVA: 0x0008A964 File Offset: 0x00088B64
	[JsonProperty("Products")]
	public List<GClass209> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x040017A1 RID: 6049
	private string string_0;

	// Token: 0x040017A2 RID: 6050
	private List<GClass209> list_0;
}
