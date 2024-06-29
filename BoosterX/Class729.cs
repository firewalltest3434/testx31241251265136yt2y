using System;
using System.Collections.Generic;

// Token: 0x020002C1 RID: 705
internal sealed class Class729 : GClass211
{
	// Token: 0x06001039 RID: 4153 RVA: 0x00044F24 File Offset: 0x00043124
	public Class729(GClass72 gclass72_1, Class751 class751_1)
	{
		this.class751_0 = class751_1;
		this.gclass72_0 = gclass72_1;
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x0600103A RID: 4154 RVA: 0x00044F3C File Offset: 0x0004313C
	public bool OnEdit
	{
		get
		{
			return this.class751_0.OnEdit && this.class751_0.OnEdit;
		}
	}

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x0600103B RID: 4155 RVA: 0x00044F58 File Offset: 0x00043158
	public bool IsReadOnly
	{
		get
		{
			return this.class751_0.TypeD == "DEVICE" || this.class751_0.TypeD == "TASK";
		}
	}

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x0600103C RID: 4156 RVA: 0x00044F88 File Offset: 0x00043188
	public List<string> ValueTypesD
	{
		get
		{
			return this.gclass72_0.List_0;
		}
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x0600103D RID: 4157 RVA: 0x00044F98 File Offset: 0x00043198
	// (set) Token: 0x0600103E RID: 4158 RVA: 0x00044FA8 File Offset: 0x000431A8
	public string ValueD
	{
		get
		{
			return this.gclass72_0.String_0;
		}
		set
		{
			if (!this.class751_0.OnEdit)
			{
				return;
			}
			this.gclass72_0.String_0 = value;
			base.method_0("ValueD");
		}
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x0600103F RID: 4159 RVA: 0x00044FD0 File Offset: 0x000431D0
	public string ValueHandlerD
	{
		get
		{
			return this.gclass72_0.ValueHandler;
		}
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x00044FE0 File Offset: 0x000431E0
	public bool method_1()
	{
		return this.gclass72_0.method_0();
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x00044FF0 File Offset: 0x000431F0
	public bool method_2()
	{
		return this.gclass72_0.method_1();
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x06001042 RID: 4162 RVA: 0x00045000 File Offset: 0x00043200
	public bool ContainsOpt
	{
		get
		{
			return this.gclass72_0.ContainsOpt;
		}
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06001043 RID: 4163 RVA: 0x00045010 File Offset: 0x00043210
	public bool ContainsOn
	{
		get
		{
			return this.gclass72_0.ContainsOn;
		}
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06001044 RID: 4164 RVA: 0x00045020 File Offset: 0x00043220
	public bool ContainsOff
	{
		get
		{
			return this.gclass72_0.ContainsOff;
		}
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x06001045 RID: 4165 RVA: 0x00045030 File Offset: 0x00043230
	public bool ContainsBest
	{
		get
		{
			return this.gclass72_0.ContainsBest;
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x06001046 RID: 4166 RVA: 0x00045040 File Offset: 0x00043240
	public bool ContainsDefault
	{
		get
		{
			return this.gclass72_0.ContainsDefault;
		}
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x00045050 File Offset: 0x00043250
	public bool method_3()
	{
		return this.gclass72_0.method_2();
	}

	// Token: 0x040009BD RID: 2493
	public GClass72 gclass72_0;

	// Token: 0x040009BE RID: 2494
	public Class751 class751_0;
}
