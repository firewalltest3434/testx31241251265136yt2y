using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000669 RID: 1641
public struct GStruct9
{
	// Token: 0x06002320 RID: 8992 RVA: 0x0008CE98 File Offset: 0x0008B098
	public GStruct9(List<GClass136> list_1, GClass136 gclass136_1)
	{
		this.list_0 = list_1;
		this.gclass136_0 = gclass136_1;
	}

	// Token: 0x17000588 RID: 1416
	// (get) Token: 0x06002321 RID: 8993 RVA: 0x0008CEA8 File Offset: 0x0008B0A8
	public readonly List<GClass136> Profiles
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
	}

	// Token: 0x06002322 RID: 8994 RVA: 0x0008CEB0 File Offset: 0x0008B0B0
	public readonly GClass136 method_0()
	{
		return this.gclass136_0;
	}

	// Token: 0x0400180A RID: 6154
	private readonly List<GClass136> list_0;

	// Token: 0x0400180B RID: 6155
	private readonly GClass136 gclass136_0;
}
