using System;
using Newtonsoft.Json;

// Token: 0x0200045F RID: 1119
public sealed class GClass135
{
	// Token: 0x060018D6 RID: 6358 RVA: 0x00066A78 File Offset: 0x00064C78
	public GClass135()
	{
	}

	// Token: 0x060018D7 RID: 6359 RVA: 0x00066A80 File Offset: 0x00064C80
	public GClass135(string string_2, GClass89 gclass89_0)
	{
		this.String_0 = gclass89_0;
		this.String_1 = string_2;
	}

	// Token: 0x060018D8 RID: 6360 RVA: 0x00066A9C File Offset: 0x00064C9C
	public GClass135(string[] string_2, GClass89 gclass89_0)
	{
		this.String_0 = gclass89_0;
		this.String_2 = string_2;
	}

	// Token: 0x060018D9 RID: 6361 RVA: 0x00066AB8 File Offset: 0x00064CB8
	public GClass135(params string[] string_2)
	{
		this.String_0 = GClass89.smethod_27();
		this.String_2 = string_2;
	}

	// Token: 0x170003B1 RID: 945
	// (get) Token: 0x060018DA RID: 6362 RVA: 0x00066AD8 File Offset: 0x00064CD8
	// (set) Token: 0x060018DB RID: 6363 RVA: 0x00066AE0 File Offset: 0x00064CE0
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

	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x060018DC RID: 6364 RVA: 0x00066AEC File Offset: 0x00064CEC
	// (set) Token: 0x060018DD RID: 6365 RVA: 0x00066B04 File Offset: 0x00064D04
	[JsonIgnore]
	public string String_1
	{
		get
		{
			if (this.String_2 == null)
			{
				return null;
			}
			return Class333.smethod_2<string>(this.String_2);
		}
		set
		{
			this.String_2 = new string[]
			{
				value
			};
		}
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x060018DE RID: 6366 RVA: 0x00066B18 File Offset: 0x00064D18
	// (set) Token: 0x060018DF RID: 6367 RVA: 0x00066B20 File Offset: 0x00064D20
	[JsonProperty("input")]
	public string[] String_2
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

	// Token: 0x04001152 RID: 4434
	private string string_0;

	// Token: 0x04001153 RID: 4435
	private string[] string_1;
}
