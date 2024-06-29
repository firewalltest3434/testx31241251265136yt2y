using System;
using System.Runtime.CompilerServices;

// Token: 0x020005E9 RID: 1513
internal sealed class Class674
{
	// Token: 0x17000553 RID: 1363
	// (get) Token: 0x060020F3 RID: 8435 RVA: 0x00085C0C File Offset: 0x00083E0C
	// (set) Token: 0x060020F4 RID: 8436 RVA: 0x00085C14 File Offset: 0x00083E14
	public TimeSpan KeyExpiry
	{
		[CompilerGenerated]
		get
		{
			return this.timeSpan_0;
		}
		[CompilerGenerated]
		set
		{
			this.timeSpan_0 = value;
		}
	}

	// Token: 0x17000554 RID: 1364
	// (get) Token: 0x060020F5 RID: 8437 RVA: 0x00085C20 File Offset: 0x00083E20
	// (set) Token: 0x060020F6 RID: 8438 RVA: 0x00085C28 File Offset: 0x00083E28
	public int NextUnhwidDaysCount
	{
		[CompilerGenerated]
		get
		{
			return this.int_0;
		}
		[CompilerGenerated]
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x17000555 RID: 1365
	// (get) Token: 0x060020F7 RID: 8439 RVA: 0x00085C34 File Offset: 0x00083E34
	// (set) Token: 0x060020F8 RID: 8440 RVA: 0x00085C3C File Offset: 0x00083E3C
	public bool IsAvailable
	{
		[CompilerGenerated]
		get
		{
			return this.bool_0;
		}
		[CompilerGenerated]
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x040016BD RID: 5821
	private TimeSpan timeSpan_0;

	// Token: 0x040016BE RID: 5822
	private int int_0;

	// Token: 0x040016BF RID: 5823
	private bool bool_0;
}
