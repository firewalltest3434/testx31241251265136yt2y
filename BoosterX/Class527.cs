using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200045C RID: 1116
internal sealed class Class527
{
	// Token: 0x170003AB RID: 939
	// (get) Token: 0x060018BF RID: 6335 RVA: 0x00066978 File Offset: 0x00064B78
	// (set) Token: 0x060018C0 RID: 6336 RVA: 0x00066980 File Offset: 0x00064B80
	public string Name
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

	// Token: 0x060018C1 RID: 6337 RVA: 0x0006698C File Offset: 0x00064B8C
	public string method_0()
	{
		return this.string_1;
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x00066994 File Offset: 0x00064B94
	public void method_1(string string_2)
	{
		this.string_1 = string_2;
	}

	// Token: 0x170003AC RID: 940
	// (get) Token: 0x060018C3 RID: 6339 RVA: 0x000669A0 File Offset: 0x00064BA0
	// (set) Token: 0x060018C4 RID: 6340 RVA: 0x000669A8 File Offset: 0x00064BA8
	public List<string> Services
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
		[CompilerGenerated]
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x000669B4 File Offset: 0x00064BB4
	public List<GClass151> method_2()
	{
		return this.list_1;
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x000669BC File Offset: 0x00064BBC
	public void method_3(List<GClass151> list_2)
	{
		this.list_1 = list_2;
	}

	// Token: 0x04001148 RID: 4424
	private string string_0;

	// Token: 0x04001149 RID: 4425
	private string string_1;

	// Token: 0x0400114A RID: 4426
	private List<string> list_0;

	// Token: 0x0400114B RID: 4427
	private List<GClass151> list_1;
}
