using System;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

// Token: 0x020002D6 RID: 726
public sealed class GClass217 : GClass211
{
	// Token: 0x060010BA RID: 4282 RVA: 0x000466C4 File Offset: 0x000448C4
	public GClass217()
	{
		this.AppXStatus = Class364.smethod_0("OnQueue");
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x060010BB RID: 4283 RVA: 0x000466DC File Offset: 0x000448DC
	// (set) Token: 0x060010BC RID: 4284 RVA: 0x000466E4 File Offset: 0x000448E4
	public int AppXID
	{
		[CompilerGenerated]
		get
		{
			return this.int_0;
		}
		[CompilerGenerated]
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x060010BD RID: 4285 RVA: 0x000466F0 File Offset: 0x000448F0
	// (set) Token: 0x060010BE RID: 4286 RVA: 0x000466F8 File Offset: 0x000448F8
	public string AppXName
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

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x060010BF RID: 4287 RVA: 0x00046704 File Offset: 0x00044904
	// (set) Token: 0x060010C0 RID: 4288 RVA: 0x0004670C File Offset: 0x0004490C
	public string AppXUri
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

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00046718 File Offset: 0x00044918
	// (set) Token: 0x060010C2 RID: 4290 RVA: 0x00046720 File Offset: 0x00044920
	public string AppXAverageRating
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

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0004672C File Offset: 0x0004492C
	// (set) Token: 0x060010C4 RID: 4292 RVA: 0x00046734 File Offset: 0x00044934
	public string AppXProductID
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
			base.method_0("AppXProductID");
		}
	}

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00046748 File Offset: 0x00044948
	// (set) Token: 0x060010C6 RID: 4294 RVA: 0x00046750 File Offset: 0x00044950
	public bool AppXIsChecked
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("AppXIsChecked");
		}
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x060010C7 RID: 4295 RVA: 0x00046764 File Offset: 0x00044964
	// (set) Token: 0x060010C8 RID: 4296 RVA: 0x0004676C File Offset: 0x0004496C
	public string AppXStatus
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
			base.method_0("AppXStatus");
		}
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00046780 File Offset: 0x00044980
	// (set) Token: 0x060010CA RID: 4298 RVA: 0x00046788 File Offset: 0x00044988
	public BitmapSource AppXIcon
	{
		[CompilerGenerated]
		get
		{
			return this.bitmapSource_0;
		}
		[CompilerGenerated]
		set
		{
			this.bitmapSource_0 = value;
		}
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x00046794 File Offset: 0x00044994
	private string method_1()
	{
		return this.string_5;
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x0004679C File Offset: 0x0004499C
	private void method_2(string string_6)
	{
		this.string_5 = string_6;
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x060010CD RID: 4301 RVA: 0x000467A8 File Offset: 0x000449A8
	// (set) Token: 0x060010CE RID: 4302 RVA: 0x000467B0 File Offset: 0x000449B0
	public string AppXSize
	{
		get
		{
			return this.method_1();
		}
		set
		{
			this.method_2(value);
			base.method_0("AppXSize");
		}
	}

	// Token: 0x04000A0E RID: 2574
	private int int_0;

	// Token: 0x04000A0F RID: 2575
	private string string_0;

	// Token: 0x04000A10 RID: 2576
	private string string_1;

	// Token: 0x04000A11 RID: 2577
	private string string_2;

	// Token: 0x04000A12 RID: 2578
	private string string_3;

	// Token: 0x04000A13 RID: 2579
	private bool bool_0;

	// Token: 0x04000A14 RID: 2580
	private string string_4;

	// Token: 0x04000A15 RID: 2581
	private BitmapSource bitmapSource_0;

	// Token: 0x04000A16 RID: 2582
	private string string_5;
}
