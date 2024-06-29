using System;
using System.Collections.Generic;
using System.Linq;
using Material.Icons;

// Token: 0x02000358 RID: 856
public sealed class GClass220 : GClass211
{
	// Token: 0x0600134B RID: 4939 RVA: 0x0004E670 File Offset: 0x0004C870
	public GClass220(GClass212 gclass212_1)
	{
		this.gclass212_0 = gclass212_1;
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x0600134C RID: 4940 RVA: 0x0004E688 File Offset: 0x0004C888
	// (set) Token: 0x0600134D RID: 4941 RVA: 0x0004E698 File Offset: 0x0004C898
	public string Name
	{
		get
		{
			return Class364.smethod_0(this.string_0);
		}
		set
		{
			this.string_0 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x0600134E RID: 4942 RVA: 0x0004E6AC File Offset: 0x0004C8AC
	public string Description
	{
		get
		{
			return Class364.smethod_0(this.string_0 + "Desc");
		}
	}

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x0600134F RID: 4943 RVA: 0x0004E6C4 File Offset: 0x0004C8C4
	// (set) Token: 0x06001350 RID: 4944 RVA: 0x0004E6CC File Offset: 0x0004C8CC
	public bool IsChecked
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
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

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x06001351 RID: 4945 RVA: 0x0004E700 File Offset: 0x0004C900
	// (set) Token: 0x06001352 RID: 4946 RVA: 0x0004E708 File Offset: 0x0004C908
	public List<GClass108> CVars
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
			this.method_3();
			base.method_0("CVars");
		}
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x0004E724 File Offset: 0x0004C924
	private void method_1()
	{
		this.CVars.ForEach(new Action<GClass108>(this.method_6));
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x0004E740 File Offset: 0x0004C940
	private void method_2()
	{
		this.CVars.ForEach(new Action<GClass108>(this.method_7));
	}

	// Token: 0x06001355 RID: 4949 RVA: 0x0004E75C File Offset: 0x0004C95C
	public void method_3()
	{
		GClass220.Class396 @class = new GClass220.Class396();
		@class.list_0 = this.gclass212_0.list_0;
		if (@class.list_0 != null && @class.list_0.Count != 0)
		{
			this.IsChecked = this.CVars.Any(new Func<GClass108, bool>(@class.method_0));
			return;
		}
		this.IsChecked = false;
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x0004E7BC File Offset: 0x0004C9BC
	private MaterialIconKind method_4()
	{
		return this.materialIconKind_0;
	}

	// Token: 0x06001357 RID: 4951 RVA: 0x0004E7C4 File Offset: 0x0004C9C4
	private void method_5(MaterialIconKind materialIconKind_1)
	{
		this.materialIconKind_0 = materialIconKind_1;
	}

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x06001358 RID: 4952 RVA: 0x0004E7D0 File Offset: 0x0004C9D0
	// (set) Token: 0x06001359 RID: 4953 RVA: 0x0004E7D8 File Offset: 0x0004C9D8
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

	// Token: 0x0600135A RID: 4954 RVA: 0x0004E7EC File Offset: 0x0004C9EC
	private void method_6(GClass108 gclass108_0)
	{
		this.gclass212_0.method_2(gclass108_0);
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x0004E7FC File Offset: 0x0004C9FC
	private void method_7(GClass108 gclass108_0)
	{
		this.gclass212_0.method_3(gclass108_0);
	}

	// Token: 0x04000BD2 RID: 3026
	private GClass212 gclass212_0;

	// Token: 0x04000BD3 RID: 3027
	private string string_0;

	// Token: 0x04000BD4 RID: 3028
	public bool bool_0 = true;

	// Token: 0x04000BD5 RID: 3029
	private bool bool_1;

	// Token: 0x04000BD6 RID: 3030
	private List<GClass108> list_0;

	// Token: 0x04000BD7 RID: 3031
	private MaterialIconKind materialIconKind_0;

	// Token: 0x02000359 RID: 857
	private sealed class Class395
	{
		// Token: 0x0600135D RID: 4957 RVA: 0x0004E814 File Offset: 0x0004CA14
		internal bool method_0(GClass108 gclass108_1)
		{
			return gclass108_1 == this.gclass108_0;
		}

		// Token: 0x04000BD8 RID: 3032
		public GClass108 gclass108_0;
	}

	// Token: 0x0200035A RID: 858
	private sealed class Class396
	{
		// Token: 0x0600135F RID: 4959 RVA: 0x0004E82C File Offset: 0x0004CA2C
		internal bool method_0(GClass108 gclass108_0)
		{
			GClass220.Class395 @class = new GClass220.Class395();
			@class.gclass108_0 = gclass108_0;
			return this.list_0.Any(new Func<GClass108, bool>(@class.method_0));
		}

		// Token: 0x04000BD9 RID: 3033
		public List<GClass108> list_0;
	}
}
