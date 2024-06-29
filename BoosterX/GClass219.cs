using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x0200034F RID: 847
public sealed class GClass219 : GClass211
{
	// Token: 0x0600131D RID: 4893 RVA: 0x0004E280 File Offset: 0x0004C480
	public GClass219(GStruct0 gstruct0_0, bool bool_1)
	{
		this.IsEdited = false;
		this.GroupName = gstruct0_0.method_2();
		this.SettingItem = gstruct0_0.SettingItem;
		this.SettingMeta = gstruct0_0.method_0();
		List<GInterface5> values;
		if (!bool_1)
		{
			values = gstruct0_0.Values.Where(new Func<GInterface5, bool>(GClass219.Class392.class392_0.method_0)).ToList<GInterface5>();
		}
		else
		{
			values = gstruct0_0.Values;
		}
		this.Values = values;
		this.DefaultValue = (this.CurrentValue = gstruct0_0.CurrentValue);
		if (!string.IsNullOrEmpty(this.SettingMeta.Description))
		{
			this.Description = this.SettingMeta.Description;
		}
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x0600131E RID: 4894 RVA: 0x0004E348 File Offset: 0x0004C548
	// (set) Token: 0x0600131F RID: 4895 RVA: 0x0004E350 File Offset: 0x0004C550
	public bool IsEdited
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("IsEdited");
		}
	}

	// Token: 0x17000277 RID: 631
	// (get) Token: 0x06001320 RID: 4896 RVA: 0x0004E364 File Offset: 0x0004C564
	// (set) Token: 0x06001321 RID: 4897 RVA: 0x0004E36C File Offset: 0x0004C56C
	public string GroupName
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

	// Token: 0x17000278 RID: 632
	// (get) Token: 0x06001322 RID: 4898 RVA: 0x0004E378 File Offset: 0x0004C578
	// (set) Token: 0x06001323 RID: 4899 RVA: 0x0004E380 File Offset: 0x0004C580
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

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x06001324 RID: 4900 RVA: 0x0004E38C File Offset: 0x0004C58C
	// (set) Token: 0x06001325 RID: 4901 RVA: 0x0004E394 File Offset: 0x0004C594
	public List<GInterface5> Values
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
		[CompilerGenerated]
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x06001326 RID: 4902 RVA: 0x0004E3A0 File Offset: 0x0004C5A0
	// (set) Token: 0x06001327 RID: 4903 RVA: 0x0004E3A8 File Offset: 0x0004C5A8
	public GInterface5 CurrentValue
	{
		get
		{
			return this.ginterface5_0;
		}
		set
		{
			if (this.ginterface5_1 == null)
			{
				this.ginterface5_1 = value;
			}
			this.ginterface5_0 = value;
			base.method_0("CurrentValue");
		}
	}

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x06001328 RID: 4904 RVA: 0x0004E3CC File Offset: 0x0004C5CC
	// (set) Token: 0x06001329 RID: 4905 RVA: 0x0004E3D4 File Offset: 0x0004C5D4
	public GInterface5 DefaultValue
	{
		[CompilerGenerated]
		get
		{
			return this.ginterface5_2;
		}
		[CompilerGenerated]
		set
		{
			this.ginterface5_2 = value;
		}
	}

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x0600132A RID: 4906 RVA: 0x0004E3E0 File Offset: 0x0004C5E0
	// (set) Token: 0x0600132B RID: 4907 RVA: 0x0004E3E8 File Offset: 0x0004C5E8
	public GClass79 SettingItem
	{
		[CompilerGenerated]
		get
		{
			return this.gclass79_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass79_0 = value;
		}
	}

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x0600132C RID: 4908 RVA: 0x0004E3F4 File Offset: 0x0004C5F4
	// (set) Token: 0x0600132D RID: 4909 RVA: 0x0004E3FC File Offset: 0x0004C5FC
	public GClass69 SettingMeta
	{
		[CompilerGenerated]
		get
		{
			return this.gclass69_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass69_0 = value;
		}
	}

	// Token: 0x04000BB5 RID: 2997
	private bool bool_0;

	// Token: 0x04000BB6 RID: 2998
	private string string_0;

	// Token: 0x04000BB7 RID: 2999
	private string string_1 = "No description..";

	// Token: 0x04000BB8 RID: 3000
	private List<GInterface5> list_0;

	// Token: 0x04000BB9 RID: 3001
	private GInterface5 ginterface5_0;

	// Token: 0x04000BBA RID: 3002
	public GInterface5 ginterface5_1;

	// Token: 0x04000BBB RID: 3003
	private GInterface5 ginterface5_2;

	// Token: 0x04000BBC RID: 3004
	private GClass79 gclass79_0;

	// Token: 0x04000BBD RID: 3005
	private GClass69 gclass69_0;

	// Token: 0x02000350 RID: 848
	[Serializable]
	private sealed class Class392
	{
		// Token: 0x06001330 RID: 4912 RVA: 0x0004E41C File Offset: 0x0004C61C
		internal bool method_0(GInterface5 ginterface5_0)
		{
			return !ginterface5_0.imethod_1().StartsWith("0x");
		}

		// Token: 0x04000BBE RID: 3006
		public static readonly GClass219.Class392 class392_0 = new GClass219.Class392();

		// Token: 0x04000BBF RID: 3007
		public static Func<GInterface5, bool> func_0;
	}
}
