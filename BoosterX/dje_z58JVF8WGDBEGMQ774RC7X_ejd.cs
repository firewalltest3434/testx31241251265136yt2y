using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using NSpeedTest.Models;

// Token: 0x02000850 RID: 2128
[XmlRoot("settings")]
public sealed class dje_z58JVF8WGDBEGMQ774RC7X_ejd
{
	// Token: 0x06002B5C RID: 11100 RVA: 0x000BB38C File Offset: 0x000B958C
	public dje_z58JVF8WGDBEGMQ774RC7X_ejd()
	{
		this.dje_zCTJSS8TJ_ejd = new List<dje_z8KW56LJY9U4NE627Q7PL4_ejd>();
	}

	// Token: 0x170005FE RID: 1534
	// (get) Token: 0x06002B5D RID: 11101 RVA: 0x000BB3A0 File Offset: 0x000B95A0
	// (set) Token: 0x06002B5E RID: 11102 RVA: 0x000BB3A8 File Offset: 0x000B95A8
	[XmlArrayItem("server")]
	[XmlArray("servers")]
	public List<dje_z8KW56LJY9U4NE627Q7PL4_ejd> dje_zCTJSS8TJ_ejd
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

	// Token: 0x06002B5F RID: 11103 RVA: 0x000BB3B4 File Offset: 0x000B95B4
	public void method_0(Coordinate coordinate_0)
	{
		foreach (dje_z8KW56LJY9U4NE627Q7PL4_ejd dje_z8KW56LJY9U4NE627Q7PL4_ejd in this.dje_zCTJSS8TJ_ejd)
		{
			dje_z8KW56LJY9U4NE627Q7PL4_ejd.Distance = coordinate_0.method_0(dje_z8KW56LJY9U4NE627Q7PL4_ejd.GeoCoordinate);
		}
	}

	// Token: 0x040021A4 RID: 8612
	private List<dje_z8KW56LJY9U4NE627Q7PL4_ejd> list_0;
}
