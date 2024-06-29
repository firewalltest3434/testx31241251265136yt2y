using System;
using System.Runtime.CompilerServices;

// Token: 0x020005A1 RID: 1441
internal sealed class Class647
{
	// Token: 0x06001EFB RID: 7931 RVA: 0x00080940 File Offset: 0x0007EB40
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x00080948 File Offset: 0x0007EB48
	public void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x170004D6 RID: 1238
	// (get) Token: 0x06001EFD RID: 7933 RVA: 0x00080954 File Offset: 0x0007EB54
	// (set) Token: 0x06001EFE RID: 7934 RVA: 0x0008095C File Offset: 0x0007EB5C
	public string State
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x040015B6 RID: 5558
	private string string_0;

	// Token: 0x040015B7 RID: 5559
	private string string_1;
}
