using System;
using System.Runtime.CompilerServices;

// Token: 0x02000229 RID: 553
internal sealed class Class289
{
	// Token: 0x06000D24 RID: 3364 RVA: 0x0003AF0C File Offset: 0x0003910C
	public Class289(bool bool_1, string string_2 = "", string string_3 = "")
	{
		this.method_0(bool_1, string_2, string_3);
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0003AF20 File Offset: 0x00039120
	// (set) Token: 0x06000D26 RID: 3366 RVA: 0x0003AF28 File Offset: 0x00039128
	public bool Success
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

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000D27 RID: 3367 RVA: 0x0003AF34 File Offset: 0x00039134
	// (set) Token: 0x06000D28 RID: 3368 RVA: 0x0003AF3C File Offset: 0x0003913C
	public string Message
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

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000D29 RID: 3369 RVA: 0x0003AF48 File Offset: 0x00039148
	// (set) Token: 0x06000D2A RID: 3370 RVA: 0x0003AF50 File Offset: 0x00039150
	public string Time
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

	// Token: 0x06000D2B RID: 3371 RVA: 0x0003AF5C File Offset: 0x0003915C
	private void method_0(bool bool_1, string string_2, string string_3)
	{
		object[] object_ = new object[]
		{
			this,
			bool_1,
			string_2,
			string_3
		};
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebg[()PF7", object_);
	}

	// Token: 0x04000832 RID: 2098
	private bool bool_0;

	// Token: 0x04000833 RID: 2099
	private string string_0;

	// Token: 0x04000834 RID: 2100
	private string string_1;
}
