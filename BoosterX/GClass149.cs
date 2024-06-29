using System;
using System.Runtime.CompilerServices;
using Material.Icons;

// Token: 0x020004E5 RID: 1253
public sealed class GClass149
{
	// Token: 0x06001B6A RID: 7018 RVA: 0x000711C4 File Offset: 0x0006F3C4
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06001B6B RID: 7019 RVA: 0x000711CC File Offset: 0x0006F3CC
	public void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x06001B6C RID: 7020 RVA: 0x000711D8 File Offset: 0x0006F3D8
	// (set) Token: 0x06001B6D RID: 7021 RVA: 0x000711E0 File Offset: 0x0006F3E0
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x06001B6E RID: 7022 RVA: 0x000711EC File Offset: 0x0006F3EC
	// (set) Token: 0x06001B6F RID: 7023 RVA: 0x000711F4 File Offset: 0x0006F3F4
	public MaterialIconKind Icon
	{
		[CompilerGenerated]
		get
		{
			return this.materialIconKind_0;
		}
		[CompilerGenerated]
		set
		{
			this.materialIconKind_0 = value;
		}
	}

	// Token: 0x0400134E RID: 4942
	private string string_0;

	// Token: 0x0400134F RID: 4943
	private string string_1;

	// Token: 0x04001350 RID: 4944
	private MaterialIconKind materialIconKind_0;
}
