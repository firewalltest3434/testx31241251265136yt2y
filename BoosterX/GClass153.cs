using System;
using Newtonsoft.Json;

// Token: 0x02000510 RID: 1296
public sealed class GClass153
{
	// Token: 0x1700046A RID: 1130
	// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00074460 File Offset: 0x00072660
	// (set) Token: 0x06001C6B RID: 7275 RVA: 0x00074468 File Offset: 0x00072668
	[JsonProperty("category.first")]
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

	// Token: 0x1700046B RID: 1131
	// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00074474 File Offset: 0x00072674
	// (set) Token: 0x06001C6D RID: 7277 RVA: 0x0007447C File Offset: 0x0007267C
	[JsonProperty("category.second")]
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

	// Token: 0x1700046C RID: 1132
	// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00074488 File Offset: 0x00072688
	// (set) Token: 0x06001C6F RID: 7279 RVA: 0x00074490 File Offset: 0x00072690
	[JsonProperty("category.third")]
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

	// Token: 0x1700046D RID: 1133
	// (get) Token: 0x06001C70 RID: 7280 RVA: 0x0007449C File Offset: 0x0007269C
	// (set) Token: 0x06001C71 RID: 7281 RVA: 0x000744A4 File Offset: 0x000726A4
	[JsonProperty("optOut.backupRestore")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x1700046E RID: 1134
	// (get) Token: 0x06001C72 RID: 7282 RVA: 0x000744B0 File Offset: 0x000726B0
	// (set) Token: 0x06001C73 RID: 7283 RVA: 0x000744B8 File Offset: 0x000726B8
	[JsonProperty("optOut.removeableMedia")]
	public bool Boolean_1
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x040013EA RID: 5098
	private string string_0;

	// Token: 0x040013EB RID: 5099
	private string string_1;

	// Token: 0x040013EC RID: 5100
	private string string_2;

	// Token: 0x040013ED RID: 5101
	private bool bool_0;

	// Token: 0x040013EE RID: 5102
	private bool bool_1;
}
