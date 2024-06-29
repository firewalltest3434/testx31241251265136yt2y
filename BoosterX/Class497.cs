using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000442 RID: 1090
internal sealed class Class497
{
	// Token: 0x06001836 RID: 6198 RVA: 0x000659C4 File Offset: 0x00063BC4
	private Class497()
	{
	}

	// Token: 0x06001837 RID: 6199 RVA: 0x000659E4 File Offset: 0x00063BE4
	public static Class497 smethod_0()
	{
		if (Class497.class497_0 == null)
		{
			Class497.class497_0 = new Class497();
		}
		return Class497.class497_0;
	}

	// Token: 0x06001838 RID: 6200 RVA: 0x000659FC File Offset: 0x00063BFC
	public void method_0()
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.list_0 = GClass146.smethod_0();
		}
	}

	// Token: 0x06001839 RID: 6201 RVA: 0x00065A44 File Offset: 0x00063C44
	public bool method_1(string string_0)
	{
		Class497.Class500 @class = new Class497.Class500();
		@class.string_0 = string_0;
		return this.list_0.Any(new Func<GClass146.GClass148, bool>(@class.method_0));
	}

	// Token: 0x0600183A RID: 6202 RVA: 0x00065A78 File Offset: 0x00063C78
	public bool method_2(string string_0)
	{
		Class497.Class498 @class = new Class497.Class498();
		@class.string_0 = string_0;
		return this.list_0.Any(new Func<GClass146.GClass148, bool>(@class.method_0));
	}

	// Token: 0x0600183B RID: 6203 RVA: 0x00065AAC File Offset: 0x00063CAC
	public bool method_3(string string_0, string string_1, string string_2)
	{
		Class497.Class499 @class = new Class497.Class499();
		@class.string_0 = string_0;
		@class.string_1 = string_1;
		@class.string_2 = string_2;
		return this.list_0.Any(new Func<GClass146.GClass148, bool>(@class.method_0));
	}

	// Token: 0x0600183C RID: 6204 RVA: 0x00065AEC File Offset: 0x00063CEC
	public List<GClass146.GClass148> method_4()
	{
		return this.list_0;
	}

	// Token: 0x0400110D RID: 4365
	private static Class497 class497_0;

	// Token: 0x0400110E RID: 4366
	private List<GClass146.GClass148> list_0 = new List<GClass146.GClass148>();

	// Token: 0x0400110F RID: 4367
	private object object_0 = new object();

	// Token: 0x02000443 RID: 1091
	private sealed class Class498
	{
		// Token: 0x0600183E RID: 6206 RVA: 0x00065AFC File Offset: 0x00063CFC
		internal bool method_0(GClass146.GClass148 gclass148_0)
		{
			return gclass148_0.method_8().Split(new char[]
			{
				'_'
			})[0] + "_" + gclass148_0.method_8().Split(new char[]
			{
				'_'
			})[1] == this.string_0;
		}

		// Token: 0x04001110 RID: 4368
		public string string_0;
	}

	// Token: 0x02000444 RID: 1092
	private sealed class Class499
	{
		// Token: 0x06001840 RID: 6208 RVA: 0x00065B58 File Offset: 0x00063D58
		internal bool method_0(GClass146.GClass148 gclass148_0)
		{
			return gclass148_0.Name == this.string_0 && gclass148_0.method_6() == this.string_1 && gclass148_0.method_2().ToLower() == this.string_2.ToLower();
		}

		// Token: 0x04001111 RID: 4369
		public string string_0;

		// Token: 0x04001112 RID: 4370
		public string string_1;

		// Token: 0x04001113 RID: 4371
		public string string_2;
	}

	// Token: 0x02000445 RID: 1093
	private sealed class Class500
	{
		// Token: 0x06001842 RID: 6210 RVA: 0x00065BB0 File Offset: 0x00063DB0
		internal bool method_0(GClass146.GClass148 gclass148_0)
		{
			return gclass148_0.method_8() == this.string_0;
		}

		// Token: 0x04001114 RID: 4372
		public string string_0;
	}
}
