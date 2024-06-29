using System;
using System.Runtime.CompilerServices;
using System.Windows.Media;

// Token: 0x02000284 RID: 644
internal sealed class Class724 : GClass211
{
	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06000EDD RID: 3805 RVA: 0x0003FD1C File Offset: 0x0003DF1C
	// (set) Token: 0x06000EDE RID: 3806 RVA: 0x0003FD24 File Offset: 0x0003DF24
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

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0003FD30 File Offset: 0x0003DF30
	public string Question
	{
		get
		{
			return Class364.smethod_0(this.Name);
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0003FD40 File Offset: 0x0003DF40
	public string Description
	{
		get
		{
			return Class364.smethod_0(this.Name + "Desc");
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x0003FD58 File Offset: 0x0003DF58
	public string Nuance
	{
		get
		{
			return Class364.smethod_0(this.Name + "Nuances");
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0003FD70 File Offset: 0x0003DF70
	// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x0003FD78 File Offset: 0x0003DF78
	public string Image
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("Image");
		}
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0003FD8C File Offset: 0x0003DF8C
	// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x0003FD94 File Offset: 0x0003DF94
	public bool IsChecked
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("IsChecked");
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0003FDA8 File Offset: 0x0003DFA8
	// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x0003FDB8 File Offset: 0x0003DFB8
	public string MainButton
	{
		get
		{
			return Class364.smethod_0(this.string_2);
		}
		set
		{
			this.string_2 = value;
			base.method_0("MainButton");
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x0003FDCC File Offset: 0x0003DFCC
	// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x0003FDDC File Offset: 0x0003DFDC
	public string RedButton
	{
		get
		{
			return Class364.smethod_0(this.string_3);
		}
		set
		{
			this.string_3 = value;
			base.method_0("RedButton");
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0003FDF0 File Offset: 0x0003DFF0
	// (set) Token: 0x06000EEB RID: 3819 RVA: 0x0003FDF8 File Offset: 0x0003DFF8
	public Color Grad1
	{
		[CompilerGenerated]
		get
		{
			return this.color_0;
		}
		[CompilerGenerated]
		set
		{
			this.color_0 = value;
		}
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0003FE04 File Offset: 0x0003E004
	// (set) Token: 0x06000EED RID: 3821 RVA: 0x0003FE0C File Offset: 0x0003E00C
	public Color Grad2
	{
		[CompilerGenerated]
		get
		{
			return this.color_1;
		}
		[CompilerGenerated]
		set
		{
			this.color_1 = value;
		}
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0003FE18 File Offset: 0x0003E018
	// (set) Token: 0x06000EEF RID: 3823 RVA: 0x0003FE20 File Offset: 0x0003E020
	public Color Grad3
	{
		[CompilerGenerated]
		get
		{
			return this.color_2;
		}
		[CompilerGenerated]
		set
		{
			this.color_2 = value;
		}
	}

	// Token: 0x04000912 RID: 2322
	private string string_0;

	// Token: 0x04000913 RID: 2323
	private string string_1;

	// Token: 0x04000914 RID: 2324
	private bool bool_0;

	// Token: 0x04000915 RID: 2325
	private string string_2;

	// Token: 0x04000916 RID: 2326
	private string string_3;

	// Token: 0x04000917 RID: 2327
	private Color color_0;

	// Token: 0x04000918 RID: 2328
	private Color color_1;

	// Token: 0x04000919 RID: 2329
	private Color color_2;
}
