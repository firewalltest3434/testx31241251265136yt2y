using System;
using Newtonsoft.Json;

// Token: 0x020002B3 RID: 691
public sealed class GClass78
{
	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00043F14 File Offset: 0x00042114
	// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00043F1C File Offset: 0x0004211C
	[JsonProperty("object")]
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

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x00043F28 File Offset: 0x00042128
	// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x00043F30 File Offset: 0x00042130
	[JsonProperty("embedding")]
	public float[] Single_0
	{
		get
		{
			return this.float_0;
		}
		set
		{
			this.float_0 = value;
		}
	}

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00043F3C File Offset: 0x0004213C
	// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00043F44 File Offset: 0x00042144
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

	// Token: 0x04000996 RID: 2454
	private string string_0;

	// Token: 0x04000997 RID: 2455
	private float[] float_0;

	// Token: 0x04000998 RID: 2456
	private int int_0;
}
