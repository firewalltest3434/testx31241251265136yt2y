using System;
using Newtonsoft.Json;

// Token: 0x020002E1 RID: 737
public sealed class GClass83
{
	// Token: 0x1700020B RID: 523
	// (get) Token: 0x060010ED RID: 4333 RVA: 0x00047780 File Offset: 0x00045980
	// (set) Token: 0x060010EE RID: 4334 RVA: 0x00047788 File Offset: 0x00045988
	[JsonProperty("model")]
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

	// Token: 0x1700020C RID: 524
	// (get) Token: 0x060010EF RID: 4335 RVA: 0x00047794 File Offset: 0x00045994
	// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0004779C File Offset: 0x0004599C
	[JsonProperty("prompt", DefaultValueHandling = 1)]
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

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x060010F1 RID: 4337 RVA: 0x000477A8 File Offset: 0x000459A8
	// (set) Token: 0x060010F2 RID: 4338 RVA: 0x000477B0 File Offset: 0x000459B0
	[JsonProperty("language", DefaultValueHandling = 1)]
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

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x060010F3 RID: 4339 RVA: 0x000477BC File Offset: 0x000459BC
	// (set) Token: 0x060010F4 RID: 4340 RVA: 0x000477C4 File Offset: 0x000459C4
	[JsonProperty("response_format", DefaultValueHandling = 1)]
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

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x060010F5 RID: 4341 RVA: 0x000477D0 File Offset: 0x000459D0
	// (set) Token: 0x060010F6 RID: 4342 RVA: 0x000477D8 File Offset: 0x000459D8
	[JsonProperty("temperature", DefaultValueHandling = 1)]
	public double Double_0
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
		}
	}

	// Token: 0x04000A42 RID: 2626
	private string string_0 = GClass89.smethod_6();

	// Token: 0x04000A43 RID: 2627
	private string string_1;

	// Token: 0x04000A44 RID: 2628
	private string string_2;

	// Token: 0x04000A45 RID: 2629
	private string string_3;

	// Token: 0x04000A46 RID: 2630
	private double double_0;

	// Token: 0x020002E2 RID: 738
	public static class GClass84
	{
	}
}
