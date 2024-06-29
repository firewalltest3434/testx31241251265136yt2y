using System;

// Token: 0x020002CF RID: 719
public sealed class GClass216 : GClass211
{
	// Token: 0x170001FB RID: 507
	// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00046244 File Offset: 0x00044444
	// (set) Token: 0x060010A3 RID: 4259 RVA: 0x0004624C File Offset: 0x0004444C
	public string OptCurrent
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("OptCurrent");
		}
	}

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00046260 File Offset: 0x00044460
	// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00046268 File Offset: 0x00044468
	public bool IsFinished
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("IsFinished");
		}
	}

	// Token: 0x040009F2 RID: 2546
	private string string_0;

	// Token: 0x040009F3 RID: 2547
	private bool bool_0;
}
