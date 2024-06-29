using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x0200038F RID: 911
internal sealed class Class416
{
	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x06001493 RID: 5267 RVA: 0x0005438C File Offset: 0x0005258C
	// (set) Token: 0x06001494 RID: 5268 RVA: 0x00054394 File Offset: 0x00052594
	[JsonProperty("Command")]
	public string Command
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

	// Token: 0x170002D3 RID: 723
	// (get) Token: 0x06001495 RID: 5269 RVA: 0x000543A0 File Offset: 0x000525A0
	// (set) Token: 0x06001496 RID: 5270 RVA: 0x000543A8 File Offset: 0x000525A8
	[JsonProperty("Description")]
	public Dictionary<string, string> Description
	{
		[CompilerGenerated]
		get
		{
			return this.dictionary_0;
		}
		[CompilerGenerated]
		set
		{
			this.dictionary_0 = value;
		}
	}

	// Token: 0x04000C6C RID: 3180
	private string string_0;

	// Token: 0x04000C6D RID: 3181
	private Dictionary<string, string> dictionary_0;
}
