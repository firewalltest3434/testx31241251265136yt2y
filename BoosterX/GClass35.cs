using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000145 RID: 325
public sealed class GClass35 : GClass32
{
	// Token: 0x17000086 RID: 134
	// (get) Token: 0x0600084E RID: 2126 RVA: 0x000289B8 File Offset: 0x00026BB8
	// (set) Token: 0x0600084F RID: 2127 RVA: 0x000289C0 File Offset: 0x00026BC0
	[JsonProperty("data")]
	public List<GClass78> List_0
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

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x06000850 RID: 2128 RVA: 0x000289CC File Offset: 0x00026BCC
	// (set) Token: 0x06000851 RID: 2129 RVA: 0x000289D4 File Offset: 0x00026BD4
	[JsonProperty("usage")]
	public GClass29 GClass29_0
	{
		get
		{
			return this.gclass29_0;
		}
		set
		{
			this.gclass29_0 = value;
		}
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x000289E0 File Offset: 0x00026BE0
	public static implicit operator float[](GClass35 gclass35_0)
	{
		GClass78 gclass = Class333.smethod_0<GClass78>(gclass35_0.List_0);
		if (gclass == null)
		{
			return null;
		}
		return gclass.Single_0;
	}

	// Token: 0x040004A4 RID: 1188
	private List<GClass78> list_0;

	// Token: 0x040004A5 RID: 1189
	private GClass29 gclass29_0;
}
