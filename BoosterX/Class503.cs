using System;

// Token: 0x02000253 RID: 595
internal sealed class Class503 : Class502
{
	// Token: 0x06000DDC RID: 3548 RVA: 0x0003D364 File Offset: 0x0003B564
	public Class503(string string_1)
	{
		this.method_2(string_1);
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x0003D374 File Offset: 0x0003B574
	public string method_0()
	{
		return "GameModeX\\Games\\" + this.method_1();
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x0003D388 File Offset: 0x0003B588
	public string method_1()
	{
		return this.string_0;
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x0003D390 File Offset: 0x0003B590
	public void method_2(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x0003D39C File Offset: 0x0003B59C
	public string method_3()
	{
		return Class502.smethod_0("ExeName", this.method_0());
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x0003D3B0 File Offset: 0x0003B5B0
	public void method_4(string string_1)
	{
		Class502.smethod_1("ExeName", string_1.ToString(), this.method_0());
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0003D3C8 File Offset: 0x0003B5C8
	// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x0003D3DC File Offset: 0x0003B5DC
	public string FoundIn
	{
		get
		{
			return Class502.smethod_0("FoundIn", this.method_0());
		}
		set
		{
			Class502.smethod_1("FoundIn", value.ToString(), this.method_0());
		}
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x0003D3F4 File Offset: 0x0003B5F4
	public string method_5()
	{
		return Class502.smethod_0("GamePath", this.method_0());
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x0003D408 File Offset: 0x0003B608
	public void method_6(string string_1)
	{
		Class502.smethod_1("GamePath", string_1.ToString(), this.method_0());
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0003D420 File Offset: 0x0003B620
	// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x0003D434 File Offset: 0x0003B634
	public string Affinity
	{
		get
		{
			return Class502.smethod_0("Affinity", this.method_0());
		}
		set
		{
			Class502.smethod_1("Affinity", value.ToString(), this.method_0());
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0003D44C File Offset: 0x0003B64C
	// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x0003D460 File Offset: 0x0003B660
	public string LaunchDelay
	{
		get
		{
			return Class502.smethod_0("LaunchDelay", this.method_0());
		}
		set
		{
			Class502.smethod_1("LaunchDelay", value.ToString(), this.method_0());
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0003D478 File Offset: 0x0003B678
	// (set) Token: 0x06000DEB RID: 3563 RVA: 0x0003D4C8 File Offset: 0x0003B6C8
	public bool? DisableDWM
	{
		get
		{
			if (Class502.smethod_0("DisableDWM", this.method_0()) == string.Empty)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(Class502.smethod_0("DisableDWM", this.method_0())));
		}
		set
		{
			Class502.smethod_1("DisableDWM", value.ToString(), this.method_0());
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0003D4E8 File Offset: 0x0003B6E8
	// (set) Token: 0x06000DED RID: 3565 RVA: 0x0003D538 File Offset: 0x0003B738
	public bool? DisableExplorer
	{
		get
		{
			if (Class502.smethod_0("DisableExplorer", this.method_0()) == string.Empty)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(Class502.smethod_0("DisableExplorer", this.method_0())));
		}
		set
		{
			Class502.smethod_1("DisableExplorer", value.ToString(), this.method_0());
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x06000DEE RID: 3566 RVA: 0x0003D558 File Offset: 0x0003B758
	// (set) Token: 0x06000DEF RID: 3567 RVA: 0x0003D5A8 File Offset: 0x0003B7A8
	public bool? UseGlobalProfile
	{
		get
		{
			if (Class502.smethod_0("UseGlobalProfile", this.method_0()) == string.Empty)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(Class502.smethod_0("UseGlobalProfile", this.method_0())));
		}
		set
		{
			Class502.smethod_1("UseGlobalProfile", value.ToString(), this.method_0());
		}
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x0003D5C8 File Offset: 0x0003B7C8
	// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x0003D618 File Offset: 0x0003B818
	public bool? ThreadCompatibility
	{
		get
		{
			if (Class502.smethod_0("UseGlobalProfile", this.method_0()) == string.Empty)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(Class502.smethod_0("ThreadCompatibility", this.method_0())));
		}
		set
		{
			Class502.smethod_1("ThreadCompatibility", value.ToString(), this.method_0());
		}
	}

	// Token: 0x04000892 RID: 2194
	private string string_0;
}
