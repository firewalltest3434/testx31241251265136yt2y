using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using NSpeedTest.Models;

// Token: 0x02000853 RID: 2131
[XmlRoot("server")]
public sealed class dje_z8KW56LJY9U4NE627Q7PL4_ejd
{
	// Token: 0x06002B76 RID: 11126 RVA: 0x000BB514 File Offset: 0x000B9714
	public dje_z8KW56LJY9U4NE627Q7PL4_ejd()
	{
		this.lazy_0 = new Lazy<Coordinate>(new Func<Coordinate>(this.method_0));
	}

	// Token: 0x17000609 RID: 1545
	// (get) Token: 0x06002B77 RID: 11127 RVA: 0x000BB534 File Offset: 0x000B9734
	// (set) Token: 0x06002B78 RID: 11128 RVA: 0x000BB53C File Offset: 0x000B973C
	[XmlAttribute("id")]
	public int Id
	{
		[CompilerGenerated]
		get
		{
			return this.int_0;
		}
		[CompilerGenerated]
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x1700060A RID: 1546
	// (get) Token: 0x06002B79 RID: 11129 RVA: 0x000BB548 File Offset: 0x000B9748
	// (set) Token: 0x06002B7A RID: 11130 RVA: 0x000BB550 File Offset: 0x000B9750
	[XmlAttribute("name")]
	public string Name
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

	// Token: 0x1700060B RID: 1547
	// (get) Token: 0x06002B7B RID: 11131 RVA: 0x000BB55C File Offset: 0x000B975C
	// (set) Token: 0x06002B7C RID: 11132 RVA: 0x000BB564 File Offset: 0x000B9764
	[XmlAttribute("country")]
	public string Country
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

	// Token: 0x1700060C RID: 1548
	// (get) Token: 0x06002B7D RID: 11133 RVA: 0x000BB570 File Offset: 0x000B9770
	// (set) Token: 0x06002B7E RID: 11134 RVA: 0x000BB578 File Offset: 0x000B9778
	[XmlAttribute("sponsor")]
	public string Sponsor
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x1700060D RID: 1549
	// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000BB584 File Offset: 0x000B9784
	// (set) Token: 0x06002B80 RID: 11136 RVA: 0x000BB58C File Offset: 0x000B978C
	[XmlAttribute("host")]
	public string Host
	{
		[CompilerGenerated]
		get
		{
			return this.string_3;
		}
		[CompilerGenerated]
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x1700060E RID: 1550
	// (get) Token: 0x06002B81 RID: 11137 RVA: 0x000BB598 File Offset: 0x000B9798
	// (set) Token: 0x06002B82 RID: 11138 RVA: 0x000BB5A0 File Offset: 0x000B97A0
	[XmlAttribute("url")]
	public string Url
	{
		[CompilerGenerated]
		get
		{
			return this.string_4;
		}
		[CompilerGenerated]
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x1700060F RID: 1551
	// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000BB5AC File Offset: 0x000B97AC
	// (set) Token: 0x06002B84 RID: 11140 RVA: 0x000BB5B4 File Offset: 0x000B97B4
	[XmlAttribute("lat")]
	public double Latitude
	{
		[CompilerGenerated]
		get
		{
			return this.double_0;
		}
		[CompilerGenerated]
		set
		{
			this.double_0 = value;
		}
	}

	// Token: 0x17000610 RID: 1552
	// (get) Token: 0x06002B85 RID: 11141 RVA: 0x000BB5C0 File Offset: 0x000B97C0
	// (set) Token: 0x06002B86 RID: 11142 RVA: 0x000BB5C8 File Offset: 0x000B97C8
	[XmlAttribute("lon")]
	public double Longitude
	{
		[CompilerGenerated]
		get
		{
			return this.double_1;
		}
		[CompilerGenerated]
		set
		{
			this.double_1 = value;
		}
	}

	// Token: 0x17000611 RID: 1553
	// (get) Token: 0x06002B87 RID: 11143 RVA: 0x000BB5D4 File Offset: 0x000B97D4
	// (set) Token: 0x06002B88 RID: 11144 RVA: 0x000BB5DC File Offset: 0x000B97DC
	public double Distance
	{
		[CompilerGenerated]
		get
		{
			return this.double_2;
		}
		[CompilerGenerated]
		set
		{
			this.double_2 = value;
		}
	}

	// Token: 0x17000612 RID: 1554
	// (get) Token: 0x06002B89 RID: 11145 RVA: 0x000BB5E8 File Offset: 0x000B97E8
	// (set) Token: 0x06002B8A RID: 11146 RVA: 0x000BB5F0 File Offset: 0x000B97F0
	public int Latency
	{
		[CompilerGenerated]
		get
		{
			return this.int_1;
		}
		[CompilerGenerated]
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x17000613 RID: 1555
	// (get) Token: 0x06002B8B RID: 11147 RVA: 0x000BB5FC File Offset: 0x000B97FC
	public Coordinate GeoCoordinate
	{
		get
		{
			return this.lazy_0.Value;
		}
	}

	// Token: 0x06002B8C RID: 11148 RVA: 0x000BB60C File Offset: 0x000B980C
	private Coordinate method_0()
	{
		return new Coordinate(this.Latitude, this.Longitude);
	}

	// Token: 0x040021AF RID: 8623
	private int int_0;

	// Token: 0x040021B0 RID: 8624
	private string string_0;

	// Token: 0x040021B1 RID: 8625
	private string string_1;

	// Token: 0x040021B2 RID: 8626
	private string string_2;

	// Token: 0x040021B3 RID: 8627
	private string string_3;

	// Token: 0x040021B4 RID: 8628
	private string string_4;

	// Token: 0x040021B5 RID: 8629
	private double double_0;

	// Token: 0x040021B6 RID: 8630
	private double double_1;

	// Token: 0x040021B7 RID: 8631
	private double double_2;

	// Token: 0x040021B8 RID: 8632
	private int int_1;

	// Token: 0x040021B9 RID: 8633
	private Lazy<Coordinate> lazy_0;
}
