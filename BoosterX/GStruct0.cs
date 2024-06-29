using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020000DB RID: 219
public struct GStruct0
{
	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06000672 RID: 1650 RVA: 0x0001FDFC File Offset: 0x0001DFFC
	// (set) Token: 0x06000673 RID: 1651 RVA: 0x0001FE04 File Offset: 0x0001E004
	public GClass79 SettingItem
	{
		[CompilerGenerated]
		readonly get
		{
			return this.gclass79_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass79_0 = value;
		}
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x0001FE10 File Offset: 0x0001E010
	public readonly GClass69 method_0()
	{
		return this.gclass69_0;
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x0001FE18 File Offset: 0x0001E018
	public void method_1(GClass69 gclass69_1)
	{
		this.gclass69_0 = gclass69_1;
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06000676 RID: 1654 RVA: 0x0001FE24 File Offset: 0x0001E024
	public List<GInterface5> Values
	{
		get
		{
			GStruct0.Class135 @class = new GStruct0.Class135();
			List<GInterface5> list = new List<GInterface5>(this.method_0().Values);
			@class.object_0 = this.SettingItem.method_8();
			GInterface5 ginterface = list.FirstOrDefault(new Func<GInterface5, bool>(@class.method_0));
			if (ginterface == null)
			{
				List<GInterface5> list2 = list;
				int index = 0;
				GClass58<string> gclass = new GClass58<string>(GEnum3.CustomSettings);
				gclass.imethod_2("[ NONE ]");
				list2.Insert(index, gclass);
				this.CurrentValue = list.First<GInterface5>();
			}
			else
			{
				this.CurrentValue = ginterface;
			}
			return list;
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000677 RID: 1655 RVA: 0x0001FEA0 File Offset: 0x0001E0A0
	// (set) Token: 0x06000678 RID: 1656 RVA: 0x0001FEA8 File Offset: 0x0001E0A8
	public GInterface5 CurrentValue
	{
		[CompilerGenerated]
		readonly get
		{
			return this.ginterface5_0;
		}
		[CompilerGenerated]
		private set
		{
			this.ginterface5_0 = value;
		}
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x0001FEB4 File Offset: 0x0001E0B4
	public string method_2()
	{
		if (string.IsNullOrEmpty(this.SettingItem.method_10()))
		{
			return "Unknown";
		}
		return this.SettingItem.method_10();
	}

	// Token: 0x0400033C RID: 828
	private GClass79 gclass79_0;

	// Token: 0x0400033D RID: 829
	private GClass69 gclass69_0;

	// Token: 0x0400033E RID: 830
	private GInterface5 ginterface5_0;

	// Token: 0x020000DC RID: 220
	private sealed class Class135
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x0001FEE4 File Offset: 0x0001E0E4
		internal bool method_0(GInterface5 ginterface5_0)
		{
			return ginterface5_0.imethod_0().ToString() == this.object_0.ToString();
		}

		// Token: 0x0400033F RID: 831
		public object object_0;
	}
}
