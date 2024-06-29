using System;
using Newtonsoft.Json;

// Token: 0x020005D5 RID: 1493
[JsonObject]
public sealed class GClass184
{
	// Token: 0x1700054A RID: 1354
	// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000840C8 File Offset: 0x000822C8
	public uint SettingValue
	{
		get
		{
			return Convert.ToUInt32(this.String_1.Trim(), 16);
		}
	}

	// Token: 0x1700054B RID: 1355
	// (get) Token: 0x060020A2 RID: 8354 RVA: 0x000840DC File Offset: 0x000822DC
	// (set) Token: 0x060020A3 RID: 8355 RVA: 0x000840E4 File Offset: 0x000822E4
	[JsonProperty("UserfriendlyName")]
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

	// Token: 0x1700054C RID: 1356
	// (get) Token: 0x060020A4 RID: 8356 RVA: 0x000840F0 File Offset: 0x000822F0
	// (set) Token: 0x060020A5 RID: 8357 RVA: 0x000840F8 File Offset: 0x000822F8
	[JsonProperty("HexValue")]
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

	// Token: 0x04001689 RID: 5769
	private string string_0;

	// Token: 0x0400168A RID: 5770
	private string string_1;
}
