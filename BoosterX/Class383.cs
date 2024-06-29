using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200033C RID: 828
internal sealed class Class383
{
	// Token: 0x17000265 RID: 613
	// (get) Token: 0x060012C1 RID: 4801 RVA: 0x0004D2F0 File Offset: 0x0004B4F0
	// (set) Token: 0x060012C2 RID: 4802 RVA: 0x0004D2F8 File Offset: 0x0004B4F8
	public DateTime DateCreated
	{
		[CompilerGenerated]
		get
		{
			return this.dateTime_0;
		}
		[CompilerGenerated]
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x17000266 RID: 614
	// (get) Token: 0x060012C3 RID: 4803 RVA: 0x0004D304 File Offset: 0x0004B504
	// (set) Token: 0x060012C4 RID: 4804 RVA: 0x0004D30C File Offset: 0x0004B50C
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

	// Token: 0x17000267 RID: 615
	// (get) Token: 0x060012C5 RID: 4805 RVA: 0x0004D318 File Offset: 0x0004B518
	// (set) Token: 0x060012C6 RID: 4806 RVA: 0x0004D320 File Offset: 0x0004B520
	public string Creator
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

	// Token: 0x17000268 RID: 616
	// (get) Token: 0x060012C7 RID: 4807 RVA: 0x0004D32C File Offset: 0x0004B52C
	// (set) Token: 0x060012C8 RID: 4808 RVA: 0x0004D334 File Offset: 0x0004B534
	public List<Class529> Contents
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

	// Token: 0x17000269 RID: 617
	// (get) Token: 0x060012C9 RID: 4809 RVA: 0x0004D340 File Offset: 0x0004B540
	// (set) Token: 0x060012CA RID: 4810 RVA: 0x0004D348 File Offset: 0x0004B548
	public List<Class528> Buttons
	{
		[CompilerGenerated]
		get
		{
			return this.list_1;
		}
		[CompilerGenerated]
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x04000B8A RID: 2954
	private DateTime dateTime_0;

	// Token: 0x04000B8B RID: 2955
	private string string_0 = string.Empty;

	// Token: 0x04000B8C RID: 2956
	private string string_1 = string.Empty;

	// Token: 0x04000B8D RID: 2957
	private List<Class529> list_0;

	// Token: 0x04000B8E RID: 2958
	private List<Class528> list_1;
}
