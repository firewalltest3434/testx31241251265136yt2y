using System;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

// Token: 0x0200033A RID: 826
internal sealed class Class735 : GClass211
{
	// Token: 0x0600129B RID: 4763 RVA: 0x0004D058 File Offset: 0x0004B258
	public Class735()
	{
		this.AddCommand = new GClass134(new Action<object>(this.method_5), null);
	}

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x0600129C RID: 4764 RVA: 0x0004D078 File Offset: 0x0004B278
	// (set) Token: 0x0600129D RID: 4765 RVA: 0x0004D080 File Offset: 0x0004B280
	public bool IsAdded
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			this.method_1();
			base.method_0("IsAdded");
		}
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x0004D09C File Offset: 0x0004B29C
	private void method_1()
	{
		if (this.IsAdded)
		{
			Class294.smethod_2();
			this.FoundIn = Class364.smethod_0("added");
		}
	}

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x0600129F RID: 4767 RVA: 0x0004D0BC File Offset: 0x0004B2BC
	// (set) Token: 0x060012A0 RID: 4768 RVA: 0x0004D0C4 File Offset: 0x0004B2C4
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x0004D0D8 File Offset: 0x0004B2D8
	public void method_2()
	{
		this.Icon = Class650.smethod_6(this.ExeDir);
	}

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x060012A2 RID: 4770 RVA: 0x0004D0EC File Offset: 0x0004B2EC
	// (set) Token: 0x060012A3 RID: 4771 RVA: 0x0004D0F4 File Offset: 0x0004B2F4
	public GClass134 AddCommand
	{
		[CompilerGenerated]
		get
		{
			return this.gclass134_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass134_0 = value;
		}
	}

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x060012A4 RID: 4772 RVA: 0x0004D100 File Offset: 0x0004B300
	// (set) Token: 0x060012A5 RID: 4773 RVA: 0x0004D108 File Offset: 0x0004B308
	public string ExeName
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("ExeName");
		}
	}

	// Token: 0x1700025B RID: 603
	// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0004D11C File Offset: 0x0004B31C
	// (set) Token: 0x060012A7 RID: 4775 RVA: 0x0004D124 File Offset: 0x0004B324
	public string ExeDir
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			this.method_2();
			base.method_0("ExeDir");
		}
	}

	// Token: 0x1700025C RID: 604
	// (get) Token: 0x060012A8 RID: 4776 RVA: 0x0004D140 File Offset: 0x0004B340
	// (set) Token: 0x060012A9 RID: 4777 RVA: 0x0004D148 File Offset: 0x0004B348
	public BitmapSource Icon
	{
		get
		{
			return this.bitmapSource_0;
		}
		set
		{
			this.bitmapSource_0 = value;
			base.method_0("Icon");
		}
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x0004D15C File Offset: 0x0004B35C
	private string method_3()
	{
		return this.string_3;
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x0004D164 File Offset: 0x0004B364
	private void method_4(string string_4)
	{
		this.string_3 = string_4;
	}

	// Token: 0x1700025D RID: 605
	// (get) Token: 0x060012AC RID: 4780 RVA: 0x0004D170 File Offset: 0x0004B370
	// (set) Token: 0x060012AD RID: 4781 RVA: 0x0004D178 File Offset: 0x0004B378
	public string FoundIn
	{
		get
		{
			return this.method_3();
		}
		set
		{
			this.method_4(value);
			base.method_0("FoundIn");
		}
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x0004D18C File Offset: 0x0004B38C
	private void method_5(object object_0)
	{
		Class294.smethod_5(this);
		this.IsAdded = true;
	}

	// Token: 0x04000B7C RID: 2940
	private bool bool_0;

	// Token: 0x04000B7D RID: 2941
	private string string_0;

	// Token: 0x04000B7E RID: 2942
	private GClass134 gclass134_0;

	// Token: 0x04000B7F RID: 2943
	private string string_1;

	// Token: 0x04000B80 RID: 2944
	private string string_2;

	// Token: 0x04000B81 RID: 2945
	private BitmapSource bitmapSource_0;

	// Token: 0x04000B82 RID: 2946
	private string string_3;
}
