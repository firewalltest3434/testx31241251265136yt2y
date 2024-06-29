using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using ns0;

// Token: 0x020005CE RID: 1486
internal sealed class Class660
{
	// Token: 0x17000533 RID: 1331
	// (get) Token: 0x06002068 RID: 8296 RVA: 0x00083DE4 File Offset: 0x00081FE4
	// (set) Token: 0x06002069 RID: 8297 RVA: 0x00083DEC File Offset: 0x00081FEC
	[JsonProperty("D")]
	public DateTime DateTime_0
	{
		get
		{
			return this.dateTime_0;
		}
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x17000534 RID: 1332
	// (get) Token: 0x0600206A RID: 8298 RVA: 0x00083DF8 File Offset: 0x00081FF8
	// (set) Token: 0x0600206B RID: 8299 RVA: 0x00083E00 File Offset: 0x00082000
	[JsonProperty("P")]
	public List<Class188> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x0600206C RID: 8300 RVA: 0x00083E0C File Offset: 0x0008200C
	public Class188 method_0(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0, string string_0)
	{
		Class660.Class661 @class = new Class660.Class661();
		@class.dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0 = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0;
		@class.string_0 = string_0;
		return this.List_0.FirstOrDefault(new Func<Class188, bool>(@class.method_0)) ?? null;
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x00083E4C File Offset: 0x0008204C
	public List<Class188> method_1(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0)
	{
		Class660.Class663 @class = new Class660.Class663();
		@class.dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0 = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0;
		return this.List_0.FindAll(new Predicate<Class188>(@class.method_0)) ?? null;
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x00083E84 File Offset: 0x00082084
	public bool method_2(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0)
	{
		Class660.Class662 @class = new Class660.Class662();
		@class.dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0 = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0;
		return this.List_0.Any(new Func<Class188, bool>(@class.method_0));
	}

	// Token: 0x0400166C RID: 5740
	private DateTime dateTime_0;

	// Token: 0x0400166D RID: 5741
	private List<Class188> list_0 = new List<Class188>();

	// Token: 0x020005CF RID: 1487
	private sealed class Class661
	{
		// Token: 0x06002070 RID: 8304 RVA: 0x00083EC0 File Offset: 0x000820C0
		internal bool method_0(Class188 class188_0)
		{
			return class188_0.Type == this.dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0 && class188_0.Name == this.string_0;
		}

		// Token: 0x0400166E RID: 5742
		public dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0;

		// Token: 0x0400166F RID: 5743
		public string string_0;
	}

	// Token: 0x020005D0 RID: 1488
	private sealed class Class662
	{
		// Token: 0x06002072 RID: 8306 RVA: 0x00083EEC File Offset: 0x000820EC
		internal bool method_0(Class188 class188_0)
		{
			return class188_0.Type == this.dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0;
		}

		// Token: 0x04001670 RID: 5744
		public dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0;
	}

	// Token: 0x020005D1 RID: 1489
	private sealed class Class663
	{
		// Token: 0x06002074 RID: 8308 RVA: 0x00083F04 File Offset: 0x00082104
		internal bool method_0(Class188 class188_0)
		{
			return class188_0.Type == this.dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0;
		}

		// Token: 0x04001671 RID: 5745
		public dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd_0;
	}
}
