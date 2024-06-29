using System;
using System.Runtime.CompilerServices;

// Token: 0x02000280 RID: 640
internal sealed class Class723 : GClass211
{
	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0003FB80 File Offset: 0x0003DD80
	// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x0003FB88 File Offset: 0x0003DD88
	public string _Name
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

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0003FB94 File Offset: 0x0003DD94
	// (set) Token: 0x06000ECA RID: 3786 RVA: 0x0003FB9C File Offset: 0x0003DD9C
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			this._Name = value;
			base.method_0("Name");
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x06000ECB RID: 3787 RVA: 0x0003FBB0 File Offset: 0x0003DDB0
	// (set) Token: 0x06000ECC RID: 3788 RVA: 0x0003FBB8 File Offset: 0x0003DDB8
	public GClass134 _Click
	{
		[CompilerGenerated]
		get
		{
			return this.gclass134_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass134_0 = value;
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x06000ECD RID: 3789 RVA: 0x0003FBC4 File Offset: 0x0003DDC4
	// (set) Token: 0x06000ECE RID: 3790 RVA: 0x0003FBCC File Offset: 0x0003DDCC
	public GClass134 Click
	{
		get
		{
			return this._Click;
		}
		set
		{
			this._Click = value;
			base.method_0("Click");
		}
	}

	// Token: 0x0400090A RID: 2314
	private string string_0;

	// Token: 0x0400090B RID: 2315
	private GClass134 gclass134_0;
}
