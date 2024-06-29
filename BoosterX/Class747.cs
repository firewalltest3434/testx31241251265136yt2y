using System;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

// Token: 0x0200043E RID: 1086
internal sealed class Class747 : GClass211
{
	// Token: 0x060017F9 RID: 6137 RVA: 0x000654A8 File Offset: 0x000636A8
	public Class747(string string_1)
	{
		this.class505_0 = new Class505(string_1);
		this.DeleteCommand = new GClass134(new Action<object>(this.method_3), null);
		this.method_2();
	}

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x060017FA RID: 6138 RVA: 0x000654DC File Offset: 0x000636DC
	// (set) Token: 0x060017FB RID: 6139 RVA: 0x000654E4 File Offset: 0x000636E4
	public GClass134 DeleteCommand
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

	// Token: 0x17000374 RID: 884
	// (get) Token: 0x060017FC RID: 6140 RVA: 0x000654F0 File Offset: 0x000636F0
	// (set) Token: 0x060017FD RID: 6141 RVA: 0x000654F8 File Offset: 0x000636F8
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

	// Token: 0x060017FE RID: 6142 RVA: 0x00065514 File Offset: 0x00063714
	private void method_1()
	{
		if (this.IsAdded)
		{
			Class294.smethod_2();
			this.FoundIn = Class364.smethod_0("added");
		}
	}

	// Token: 0x17000375 RID: 885
	// (get) Token: 0x060017FF RID: 6143 RVA: 0x00065534 File Offset: 0x00063734
	public string Name
	{
		get
		{
			return this.class505_0.method_1();
		}
	}

	// Token: 0x06001800 RID: 6144 RVA: 0x00065544 File Offset: 0x00063744
	public void method_2()
	{
		this.Icon = Class650.smethod_6(this.ExeDir);
	}

	// Token: 0x17000376 RID: 886
	// (get) Token: 0x06001801 RID: 6145 RVA: 0x00065558 File Offset: 0x00063758
	// (set) Token: 0x06001802 RID: 6146 RVA: 0x00065560 File Offset: 0x00063760
	public GClass134 AddCommand
	{
		[CompilerGenerated]
		get
		{
			return this.gclass134_1;
		}
		[CompilerGenerated]
		set
		{
			this.gclass134_1 = value;
		}
	}

	// Token: 0x17000377 RID: 887
	// (get) Token: 0x06001803 RID: 6147 RVA: 0x0006556C File Offset: 0x0006376C
	public string ExeName
	{
		get
		{
			return this.class505_0.method_3();
		}
	}

	// Token: 0x17000378 RID: 888
	// (get) Token: 0x06001804 RID: 6148 RVA: 0x0006557C File Offset: 0x0006377C
	public string ExeDir
	{
		get
		{
			return this.class505_0.ExeDir;
		}
	}

	// Token: 0x17000379 RID: 889
	// (get) Token: 0x06001805 RID: 6149 RVA: 0x0006558C File Offset: 0x0006378C
	// (set) Token: 0x06001806 RID: 6150 RVA: 0x00065594 File Offset: 0x00063794
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

	// Token: 0x1700037A RID: 890
	// (get) Token: 0x06001807 RID: 6151 RVA: 0x000655A8 File Offset: 0x000637A8
	// (set) Token: 0x06001808 RID: 6152 RVA: 0x000655B0 File Offset: 0x000637B0
	public string FoundIn
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("FoundIn");
		}
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x000655C4 File Offset: 0x000637C4
	private void method_3(object object_0)
	{
		Class294.smethod_6(this);
		Class294.smethod_2();
	}

	// Token: 0x040010F4 RID: 4340
	private Class505 class505_0;

	// Token: 0x040010F5 RID: 4341
	private GClass134 gclass134_0;

	// Token: 0x040010F6 RID: 4342
	private bool bool_0;

	// Token: 0x040010F7 RID: 4343
	private GClass134 gclass134_1;

	// Token: 0x040010F8 RID: 4344
	private BitmapSource bitmapSource_0;

	// Token: 0x040010F9 RID: 4345
	private string string_0;
}
