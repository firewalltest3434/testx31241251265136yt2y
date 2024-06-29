using System;
using Newtonsoft.Json;

// Token: 0x020004C7 RID: 1223
public sealed class GClass145
{
	// Token: 0x1700041D RID: 1053
	// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0006ED60 File Offset: 0x0006CF60
	// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x0006ED68 File Offset: 0x0006CF68
	[JsonProperty("PassedValidation")]
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

	// Token: 0x1700041E RID: 1054
	// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x0006ED74 File Offset: 0x0006CF74
	// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x0006ED7C File Offset: 0x0006CF7C
	[JsonProperty("RevisionId")]
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

	// Token: 0x1700041F RID: 1055
	// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0006ED88 File Offset: 0x0006CF88
	// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x0006ED90 File Offset: 0x0006CF90
	[JsonProperty("ValidationResultUri")]
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

	// Token: 0x040012EF RID: 4847
	private bool bool_0;

	// Token: 0x040012F0 RID: 4848
	private string string_0;

	// Token: 0x040012F1 RID: 4849
	private string string_1;
}
