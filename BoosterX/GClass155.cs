using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using Newtonsoft.Json;

// Token: 0x0200051B RID: 1307
public sealed class GClass155
{
	// Token: 0x06001CB4 RID: 7348 RVA: 0x000748BC File Offset: 0x00072ABC
	public GClass155(string string_1, ServiceStartMode? nullable_1, bool bool_2 = false, bool bool_3 = false)
	{
		this.ServiceName = string_1;
		this.IsBlocked = bool_2;
		this.Boolean_0 = bool_3;
		this.DefaultStartMode = nullable_1;
	}

	// Token: 0x1700047F RID: 1151
	// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x000748EC File Offset: 0x00072AEC
	// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x000748F4 File Offset: 0x00072AF4
	[JsonProperty("ServiceName")]
	public string ServiceName
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

	// Token: 0x17000480 RID: 1152
	// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x00074900 File Offset: 0x00072B00
	// (set) Token: 0x06001CB8 RID: 7352 RVA: 0x00074908 File Offset: 0x00072B08
	[JsonProperty("IsBlocked")]
	public bool IsBlocked
	{
		[CompilerGenerated]
		get
		{
			return this.bool_0;
		}
		[CompilerGenerated]
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x17000481 RID: 1153
	// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x00074914 File Offset: 0x00072B14
	// (set) Token: 0x06001CBA RID: 7354 RVA: 0x0007491C File Offset: 0x00072B1C
	[JsonProperty("IsBlocked11")]
	public bool Boolean_0
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

	// Token: 0x17000482 RID: 1154
	// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00074928 File Offset: 0x00072B28
	// (set) Token: 0x06001CBC RID: 7356 RVA: 0x00074930 File Offset: 0x00072B30
	[JsonProperty("DefaultStartMode")]
	public ServiceStartMode? DefaultStartMode
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_0;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x17000483 RID: 1155
	// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0007493C File Offset: 0x00072B3C
	// (set) Token: 0x06001CBE RID: 7358 RVA: 0x00074944 File Offset: 0x00072B44
	[JsonProperty("WillBrakeLoc")]
	public List<string> List_0
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

	// Token: 0x04001408 RID: 5128
	private string string_0;

	// Token: 0x04001409 RID: 5129
	private bool bool_0;

	// Token: 0x0400140A RID: 5130
	private bool bool_1;

	// Token: 0x0400140B RID: 5131
	private ServiceStartMode? nullable_0;

	// Token: 0x0400140C RID: 5132
	private List<string> list_0 = new List<string>();
}
