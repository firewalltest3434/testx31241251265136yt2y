using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02000273 RID: 627
public sealed class GClass70
{
	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06000E9D RID: 3741 RVA: 0x0003F6E4 File Offset: 0x0003D8E4
	// (set) Token: 0x06000E9E RID: 3742 RVA: 0x0003F6EC File Offset: 0x0003D8EC
	[JsonProperty("index")]
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06000E9F RID: 3743 RVA: 0x0003F6F8 File Offset: 0x0003D8F8
	// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x0003F700 File Offset: 0x0003D900
	[JsonProperty("message")]
	public GClass163 Message
	{
		[CompilerGenerated]
		get
		{
			return this.gclass163_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass163_0 = value;
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x0003F70C File Offset: 0x0003D90C
	// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x0003F714 File Offset: 0x0003D914
	[JsonProperty("finish_reason")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x0003F720 File Offset: 0x0003D920
	// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x0003F728 File Offset: 0x0003D928
	[JsonProperty("delta")]
	public GClass163 GClass163_0
	{
		get
		{
			return this.gclass163_1;
		}
		set
		{
			this.gclass163_1 = value;
		}
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x0003F734 File Offset: 0x0003D934
	public override string ToString()
	{
		if (this.Message == null && this.GClass163_0 != null)
		{
			return this.GClass163_0.String_1;
		}
		return this.Message.String_1;
	}

	// Token: 0x040008F8 RID: 2296
	private int int_0;

	// Token: 0x040008F9 RID: 2297
	private GClass163 gclass163_0;

	// Token: 0x040008FA RID: 2298
	private string string_0;

	// Token: 0x040008FB RID: 2299
	private GClass163 gclass163_1;
}
