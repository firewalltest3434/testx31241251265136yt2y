using System;
using System.Windows.Controls;
using ns0;

// Token: 0x0200034C RID: 844
internal sealed class Class736 : GClass211
{
	// Token: 0x0600130E RID: 4878 RVA: 0x0004E064 File Offset: 0x0004C264
	public Class736(Frame frame_1)
	{
		this.frame_0 = frame_1;
		this.AutoexecCommand.Execute(null);
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x0004E080 File Offset: 0x0004C280
	private void method_1()
	{
		Class358.smethod_0().method_3(typeof(dje_zLVLJLPE5FDZPHPW9CAMA5S69R3FGP7B99X4PE9F9ABTNDNSXLS978SVDJSHA_ejd), this.frame_0);
	}

	// Token: 0x17000272 RID: 626
	// (get) Token: 0x06001310 RID: 4880 RVA: 0x0004E09C File Offset: 0x0004C29C
	public GClass134 AutoexecCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_2), null));
			}
			return result;
		}
	}

	// Token: 0x17000273 RID: 627
	// (get) Token: 0x06001311 RID: 4881 RVA: 0x0004E0D0 File Offset: 0x0004C2D0
	public GClass134 LauchOptionsCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_1) == null)
			{
				result = (this.gclass134_1 = new GClass134(new Action<object>(this.method_3), null));
			}
			return result;
		}
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x06001312 RID: 4882 RVA: 0x0004E104 File Offset: 0x0004C304
	public GClass134 BackCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_2) == null)
			{
				result = (this.gclass134_2 = new GClass134(new Action<object>(Class736.Class390.class390_0.method_0), null));
			}
			return result;
		}
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x0004E14C File Offset: 0x0004C34C
	private void method_2(object object_0)
	{
		this.method_1();
		Class358.smethod_0().method_3(typeof(dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd), this.frame_0);
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x0004E170 File Offset: 0x0004C370
	private void method_3(object object_0)
	{
		this.method_1();
		Class358.smethod_0().method_3(typeof(dje_zBVAER69W7RVHSLHQKBDJZ43ZTMLQE26VNQFPD78BXTD2JBFRSD5PKMSQS49MXGDAS2_ejd), this.frame_0);
	}

	// Token: 0x04000BAE RID: 2990
	private Frame frame_0;

	// Token: 0x04000BAF RID: 2991
	private GClass134 gclass134_0;

	// Token: 0x04000BB0 RID: 2992
	private GClass134 gclass134_1;

	// Token: 0x04000BB1 RID: 2993
	private GClass134 gclass134_2;

	// Token: 0x0200034D RID: 845
	[Serializable]
	private sealed class Class390
	{
		// Token: 0x06001317 RID: 4887 RVA: 0x0004E1A8 File Offset: 0x0004C3A8
		internal void method_0(object object_0)
		{
			Class358.smethod_0().method_3(typeof(dje_zA6HRDGVQ449XDH4D5NPJHBXAQ5BZC26NDGXJQ5PLSURH2QZ_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x04000BB2 RID: 2994
		public static readonly Class736.Class390 class390_0 = new Class736.Class390();

		// Token: 0x04000BB3 RID: 2995
		public static Action<object> action_0;
	}
}
