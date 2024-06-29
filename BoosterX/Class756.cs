using System;

// Token: 0x02000577 RID: 1399
internal sealed class Class756 : GClass211
{
	// Token: 0x06001E5F RID: 7775 RVA: 0x0007F0C8 File Offset: 0x0007D2C8
	public Class756(Class716 class716_1 = null)
	{
		this.class716_0 = class716_1;
	}

	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0007F0D8 File Offset: 0x0007D2D8
	// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0007F0E0 File Offset: 0x0007D2E0
	public int Core
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
			base.method_0("Core");
		}
	}

	// Token: 0x170004C5 RID: 1221
	// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0007F0F4 File Offset: 0x0007D2F4
	// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0007F0FC File Offset: 0x0007D2FC
	public int Thread
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
			base.method_0("Thread");
		}
	}

	// Token: 0x170004C6 RID: 1222
	// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0007F110 File Offset: 0x0007D310
	// (set) Token: 0x06001E65 RID: 7781 RVA: 0x0007F118 File Offset: 0x0007D318
	public bool IsECore
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("IsECore");
		}
	}

	// Token: 0x170004C7 RID: 1223
	// (get) Token: 0x06001E66 RID: 7782 RVA: 0x0007F12C File Offset: 0x0007D32C
	// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0007F134 File Offset: 0x0007D334
	public bool ShowCoreType
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			base.method_0("ShowCoreType");
		}
	}

	// Token: 0x170004C8 RID: 1224
	// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0007F148 File Offset: 0x0007D348
	// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0007F150 File Offset: 0x0007D350
	public bool IsChosen
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
			Class716 @class = this.class716_0;
			if (@class != null)
			{
				@class.method_9();
			}
			base.method_0("IsChosen");
		}
	}

	// Token: 0x0400156E RID: 5486
	private Class716 class716_0;

	// Token: 0x0400156F RID: 5487
	public int int_0;

	// Token: 0x04001570 RID: 5488
	public int int_1;

	// Token: 0x04001571 RID: 5489
	public bool bool_0;

	// Token: 0x04001572 RID: 5490
	public bool bool_1;

	// Token: 0x04001573 RID: 5491
	public bool bool_2;
}
