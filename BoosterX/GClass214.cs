using System;
using System.Runtime.CompilerServices;
using Material.Icons;

// Token: 0x02000259 RID: 601
public sealed class GClass214 : GClass211
{
	// Token: 0x06000E01 RID: 3585 RVA: 0x0003D928 File Offset: 0x0003BB28
	public GClass214(GClass215 gclass215_1)
	{
		this.gclass215_0 = gclass215_1;
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0003D940 File Offset: 0x0003BB40
	// (set) Token: 0x06000E03 RID: 3587 RVA: 0x0003D948 File Offset: 0x0003BB48
	public string _Name
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

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06000E04 RID: 3588 RVA: 0x0003D954 File Offset: 0x0003BB54
	// (set) Token: 0x06000E05 RID: 3589 RVA: 0x0003D964 File Offset: 0x0003BB64
	public string Name
	{
		get
		{
			return Class364.smethod_0(this._Name);
		}
		set
		{
			this._Name = value;
			base.method_0("Name");
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x06000E06 RID: 3590 RVA: 0x0003D978 File Offset: 0x0003BB78
	public string Description
	{
		get
		{
			return Class364.smethod_0(this._Name + "Desc");
		}
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x06000E07 RID: 3591 RVA: 0x0003D990 File Offset: 0x0003BB90
	// (set) Token: 0x06000E08 RID: 3592 RVA: 0x0003D998 File Offset: 0x0003BB98
	public string _Param
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

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0003D9A4 File Offset: 0x0003BBA4
	// (set) Token: 0x06000E0A RID: 3594 RVA: 0x0003D9AC File Offset: 0x0003BBAC
	public string Param
	{
		get
		{
			return this._Param;
		}
		set
		{
			this._Param = value;
			this.method_3();
			base.method_0("Param");
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000E0B RID: 3595 RVA: 0x0003D9C8 File Offset: 0x0003BBC8
	// (set) Token: 0x06000E0C RID: 3596 RVA: 0x0003D9D0 File Offset: 0x0003BBD0
	public bool _IsChecked
	{
		[CompilerGenerated]
		get
		{
			return this.bool_1;
		}
		[CompilerGenerated]
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0003D9DC File Offset: 0x0003BBDC
	// (set) Token: 0x06000E0E RID: 3598 RVA: 0x0003D9E4 File Offset: 0x0003BBE4
	public bool IsChecked
	{
		get
		{
			return this._IsChecked;
		}
		set
		{
			this._IsChecked = value;
			base.method_0("IsChecked");
			if (this.bool_0)
			{
				this.bool_0 = false;
				return;
			}
			if (value)
			{
				this.method_1();
				return;
			}
			this.method_2();
		}
	}

	// Token: 0x06000E0F RID: 3599 RVA: 0x0003DA18 File Offset: 0x0003BC18
	public void method_1()
	{
		if (this.gclass215_0.CSGOLaunchOptions == string.Empty)
		{
			GClass215 gclass = this.gclass215_0;
			gclass.CSGOLaunchOptions += this.Param;
			return;
		}
		GClass215 gclass2 = this.gclass215_0;
		gclass2.CSGOLaunchOptions = gclass2.CSGOLaunchOptions + " " + this.Param;
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x0003DA7C File Offset: 0x0003BC7C
	public void method_2()
	{
		this.gclass215_0.CSGOLaunchOptions = this.gclass215_0.CSGOLaunchOptions.Replace(this.Param, string.Empty);
		if (this.gclass215_0.CSGOLaunchOptions.StartsWith(" "))
		{
			this.gclass215_0.CSGOLaunchOptions.Substring(1);
		}
	}

	// Token: 0x06000E11 RID: 3601 RVA: 0x0003DAD8 File Offset: 0x0003BCD8
	public void method_3()
	{
		this.IsChecked = this.gclass215_0.CSGOLaunchOptions.Contains(this.Param);
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x0003DAF8 File Offset: 0x0003BCF8
	private MaterialIconKind method_4()
	{
		return this.materialIconKind_0;
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x0003DB00 File Offset: 0x0003BD00
	private void method_5(MaterialIconKind materialIconKind_1)
	{
		this.materialIconKind_0 = materialIconKind_1;
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0003DB0C File Offset: 0x0003BD0C
	// (set) Token: 0x06000E15 RID: 3605 RVA: 0x0003DB14 File Offset: 0x0003BD14
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_4();
		}
		set
		{
			this.method_5(value);
			base.method_0("Icon");
		}
	}

	// Token: 0x0400089E RID: 2206
	private GClass215 gclass215_0;

	// Token: 0x0400089F RID: 2207
	private string string_0;

	// Token: 0x040008A0 RID: 2208
	private string string_1;

	// Token: 0x040008A1 RID: 2209
	public bool bool_0 = true;

	// Token: 0x040008A2 RID: 2210
	private bool bool_1;

	// Token: 0x040008A3 RID: 2211
	private MaterialIconKind materialIconKind_0;
}
