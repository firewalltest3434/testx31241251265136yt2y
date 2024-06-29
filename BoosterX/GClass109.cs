using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000378 RID: 888
public sealed class GClass109
{
	// Token: 0x1700028E RID: 654
	// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00052668 File Offset: 0x00050868
	// (set) Token: 0x060013B9 RID: 5049 RVA: 0x00052670 File Offset: 0x00050870
	[JsonProperty("LastModifiedDate")]
	public DateTime DateTime_0
	{
		get
		{
			return this.dateTime_0;
		}
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x060013BA RID: 5050 RVA: 0x0005267C File Offset: 0x0005087C
	// (set) Token: 0x060013BB RID: 5051 RVA: 0x00052684 File Offset: 0x00050884
	[JsonProperty("LocalizedProperties")]
	public List<GClass229> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x060013BC RID: 5052 RVA: 0x00052690 File Offset: 0x00050890
	// (set) Token: 0x060013BD RID: 5053 RVA: 0x00052698 File Offset: 0x00050898
	[JsonProperty("MarketProperties")]
	public List<GClass105> List_1
	{
		get
		{
			return this.list_1;
		}
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x060013BE RID: 5054 RVA: 0x000526A4 File Offset: 0x000508A4
	// (set) Token: 0x060013BF RID: 5055 RVA: 0x000526AC File Offset: 0x000508AC
	[JsonProperty("Properties")]
	public GClass183 GClass183_0
	{
		get
		{
			return this.gclass183_0;
		}
		set
		{
			this.gclass183_0 = value;
		}
	}

	// Token: 0x17000292 RID: 658
	// (get) Token: 0x060013C0 RID: 5056 RVA: 0x000526B8 File Offset: 0x000508B8
	// (set) Token: 0x060013C1 RID: 5057 RVA: 0x000526C0 File Offset: 0x000508C0
	[JsonProperty("SkuASchema")]
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

	// Token: 0x17000293 RID: 659
	// (get) Token: 0x060013C2 RID: 5058 RVA: 0x000526CC File Offset: 0x000508CC
	// (set) Token: 0x060013C3 RID: 5059 RVA: 0x000526D4 File Offset: 0x000508D4
	[JsonProperty("SkuBSchema")]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x060013C4 RID: 5060 RVA: 0x000526E0 File Offset: 0x000508E0
	// (set) Token: 0x060013C5 RID: 5061 RVA: 0x000526E8 File Offset: 0x000508E8
	[JsonProperty("SkuId")]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x060013C6 RID: 5062 RVA: 0x000526F4 File Offset: 0x000508F4
	// (set) Token: 0x060013C7 RID: 5063 RVA: 0x000526FC File Offset: 0x000508FC
	[JsonProperty("SkuType")]
	public string String_3
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00052708 File Offset: 0x00050908
	// (set) Token: 0x060013C9 RID: 5065 RVA: 0x00052710 File Offset: 0x00050910
	[JsonProperty("RecurrencePolicy")]
	public object Object_0
	{
		get
		{
			return this.object_0;
		}
		set
		{
			this.object_0 = value;
		}
	}

	// Token: 0x17000297 RID: 663
	// (get) Token: 0x060013CA RID: 5066 RVA: 0x0005271C File Offset: 0x0005091C
	// (set) Token: 0x060013CB RID: 5067 RVA: 0x00052724 File Offset: 0x00050924
	[JsonProperty("SubscriptionPolicyId")]
	public object Object_1
	{
		get
		{
			return this.object_1;
		}
		set
		{
			this.object_1 = value;
		}
	}

	// Token: 0x04000C0C RID: 3084
	private DateTime dateTime_0;

	// Token: 0x04000C0D RID: 3085
	private List<GClass229> list_0;

	// Token: 0x04000C0E RID: 3086
	private List<GClass105> list_1;

	// Token: 0x04000C0F RID: 3087
	private GClass183 gclass183_0;

	// Token: 0x04000C10 RID: 3088
	private string string_0;

	// Token: 0x04000C11 RID: 3089
	private string string_1;

	// Token: 0x04000C12 RID: 3090
	private string string_2;

	// Token: 0x04000C13 RID: 3091
	private string string_3;

	// Token: 0x04000C14 RID: 3092
	private object object_0;

	// Token: 0x04000C15 RID: 3093
	private object object_1;
}
