using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000275 RID: 629
public sealed class GClass72
{
	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0003F798 File Offset: 0x0003D998
	// (set) Token: 0x06000EAD RID: 3757 RVA: 0x0003F7A0 File Offset: 0x0003D9A0
	[JsonProperty("ValueTypes")]
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

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0003F7AC File Offset: 0x0003D9AC
	// (set) Token: 0x06000EAF RID: 3759 RVA: 0x0003F7B4 File Offset: 0x0003D9B4
	[JsonProperty("Value")]
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

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0003F7C0 File Offset: 0x0003D9C0
	[JsonIgnore]
	public string ValueHandler
	{
		get
		{
			if (!(this.String_0 == "Null"))
			{
				return this.String_0;
			}
			return Class364.smethod_0("Remove");
		}
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x0003F7E8 File Offset: 0x0003D9E8
	public bool method_0()
	{
		return this.List_0.Contains("BEST") && this.List_0.Contains("ON");
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x0003F810 File Offset: 0x0003DA10
	public bool method_1()
	{
		return this.List_0.Contains("OPTIMAL");
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0003F824 File Offset: 0x0003DA24
	[JsonIgnore]
	public bool ContainsOpt
	{
		get
		{
			return this.List_0.Contains("OPTIMAL");
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x0003F838 File Offset: 0x0003DA38
	[JsonIgnore]
	public bool ContainsOn
	{
		get
		{
			return this.List_0.Contains("ON");
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0003F84C File Offset: 0x0003DA4C
	[JsonIgnore]
	public bool ContainsOff
	{
		get
		{
			return this.List_0.Contains("OFF");
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0003F860 File Offset: 0x0003DA60
	[JsonIgnore]
	public bool ContainsBest
	{
		get
		{
			return this.List_0.Contains("BEST");
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0003F874 File Offset: 0x0003DA74
	[JsonIgnore]
	public bool ContainsDefault
	{
		get
		{
			return this.List_0.Contains("DEFAULT");
		}
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x0003F888 File Offset: 0x0003DA88
	public bool method_2()
	{
		return this.List_0.Contains("DEFAULT") && this.List_0.Contains("ON");
	}

	// Token: 0x040008FE RID: 2302
	private List<string> list_0;

	// Token: 0x040008FF RID: 2303
	private string string_0;
}
