using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020004E6 RID: 1254
[JsonObject]
public sealed class GClass150
{
	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x06001B71 RID: 7025 RVA: 0x00071208 File Offset: 0x0006F408
	// (set) Token: 0x06001B72 RID: 7026 RVA: 0x00071210 File Offset: 0x0006F410
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

	// Token: 0x1700042B RID: 1067
	// (get) Token: 0x06001B73 RID: 7027 RVA: 0x0007121C File Offset: 0x0006F41C
	// (set) Token: 0x06001B74 RID: 7028 RVA: 0x00071224 File Offset: 0x0006F424
	[JsonProperty("HexSettingID")]
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

	// Token: 0x1700042C RID: 1068
	// (get) Token: 0x06001B75 RID: 7029 RVA: 0x00071230 File Offset: 0x0006F430
	// (set) Token: 0x06001B76 RID: 7030 RVA: 0x00071238 File Offset: 0x0006F438
	[JsonProperty("Description")]
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x1700042D RID: 1069
	// (get) Token: 0x06001B77 RID: 7031 RVA: 0x00071244 File Offset: 0x0006F444
	// (set) Token: 0x06001B78 RID: 7032 RVA: 0x0007124C File Offset: 0x0006F44C
	[JsonProperty("GroupName")]
	public string String_2
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

	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x06001B79 RID: 7033 RVA: 0x00071258 File Offset: 0x0006F458
	// (set) Token: 0x06001B7A RID: 7034 RVA: 0x00071260 File Offset: 0x0006F460
	[JsonProperty("OverrideDefault")]
	public string String_3
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x06001B7B RID: 7035 RVA: 0x0007126C File Offset: 0x0006F46C
	// (set) Token: 0x06001B7C RID: 7036 RVA: 0x00071274 File Offset: 0x0006F474
	[JsonProperty("MinRequiredDriverVersion")]
	public float Single_0
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

	// Token: 0x17000430 RID: 1072
	// (get) Token: 0x06001B7D RID: 7037 RVA: 0x00071280 File Offset: 0x0006F480
	// (set) Token: 0x06001B7E RID: 7038 RVA: 0x00071288 File Offset: 0x0006F488
	[JsonProperty("Hidden")]
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

	// Token: 0x17000431 RID: 1073
	// (get) Token: 0x06001B7F RID: 7039 RVA: 0x00071294 File Offset: 0x0006F494
	// (set) Token: 0x06001B80 RID: 7040 RVA: 0x0007129C File Offset: 0x0006F49C
	[JsonProperty("HasConstraints")]
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

	// Token: 0x17000432 RID: 1074
	// (get) Token: 0x06001B81 RID: 7041 RVA: 0x000712A8 File Offset: 0x0006F4A8
	// (set) Token: 0x06001B82 RID: 7042 RVA: 0x000712B0 File Offset: 0x0006F4B0
	[JsonProperty("DataType")]
	public string String_4
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
		}
	}

	// Token: 0x17000433 RID: 1075
	// (get) Token: 0x06001B83 RID: 7043 RVA: 0x000712BC File Offset: 0x0006F4BC
	// (set) Token: 0x06001B84 RID: 7044 RVA: 0x000712C4 File Offset: 0x0006F4C4
	[JsonProperty("SettingValues")]
	public List<GClass184> List_0
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

	// Token: 0x17000434 RID: 1076
	// (get) Token: 0x06001B85 RID: 7045 RVA: 0x000712D0 File Offset: 0x0006F4D0
	public uint SettingId
	{
		get
		{
			return Convert.ToUInt32(this.String_1.Trim(), 16);
		}
	}

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x06001B86 RID: 7046 RVA: 0x000712E4 File Offset: 0x0006F4E4
	public uint? DefaultValue
	{
		get
		{
			if (!string.IsNullOrEmpty(this.String_3))
			{
				return new uint?(Convert.ToUInt32(this.String_3.Trim(), 16));
			}
			return null;
		}
	}

	// Token: 0x04001351 RID: 4945
	private string string_0;

	// Token: 0x04001352 RID: 4946
	private string string_1;

	// Token: 0x04001353 RID: 4947
	private string string_2;

	// Token: 0x04001354 RID: 4948
	private string string_3;

	// Token: 0x04001355 RID: 4949
	private string string_4;

	// Token: 0x04001356 RID: 4950
	private float float_0;

	// Token: 0x04001357 RID: 4951
	private bool bool_0;

	// Token: 0x04001358 RID: 4952
	private bool bool_1;

	// Token: 0x04001359 RID: 4953
	private string string_5;

	// Token: 0x0400135A RID: 4954
	private List<GClass184> list_0;
}
