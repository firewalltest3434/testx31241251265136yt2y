using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using NSpeedTest.Models;

// Token: 0x02000852 RID: 2130
[XmlRoot("client")]
public sealed class dje_z7S3R65DSBN3CVRKHCSDS3_ejd
{
	// Token: 0x06002B63 RID: 11107 RVA: 0x000BB430 File Offset: 0x000B9630
	public dje_z7S3R65DSBN3CVRKHCSDS3_ejd()
	{
		this.lazy_0 = new Lazy<Coordinate>(new Func<Coordinate>(this.method_0));
	}

	// Token: 0x17000600 RID: 1536
	// (get) Token: 0x06002B64 RID: 11108 RVA: 0x000BB450 File Offset: 0x000B9650
	// (set) Token: 0x06002B65 RID: 11109 RVA: 0x000BB458 File Offset: 0x000B9658
	[XmlAttribute("ip")]
	public string Ip
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

	// Token: 0x17000601 RID: 1537
	// (get) Token: 0x06002B66 RID: 11110 RVA: 0x000BB464 File Offset: 0x000B9664
	// (set) Token: 0x06002B67 RID: 11111 RVA: 0x000BB46C File Offset: 0x000B966C
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

	// Token: 0x17000602 RID: 1538
	// (get) Token: 0x06002B68 RID: 11112 RVA: 0x000BB478 File Offset: 0x000B9678
	// (set) Token: 0x06002B69 RID: 11113 RVA: 0x000BB480 File Offset: 0x000B9680
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

	// Token: 0x17000603 RID: 1539
	// (get) Token: 0x06002B6A RID: 11114 RVA: 0x000BB48C File Offset: 0x000B968C
	// (set) Token: 0x06002B6B RID: 11115 RVA: 0x000BB494 File Offset: 0x000B9694
	[XmlAttribute("isp")]
	public string Isp
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

	// Token: 0x17000604 RID: 1540
	// (get) Token: 0x06002B6C RID: 11116 RVA: 0x000BB4A0 File Offset: 0x000B96A0
	// (set) Token: 0x06002B6D RID: 11117 RVA: 0x000BB4A8 File Offset: 0x000B96A8
	[XmlAttribute("isprating")]
	public double IspRating
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

	// Token: 0x17000605 RID: 1541
	// (get) Token: 0x06002B6E RID: 11118 RVA: 0x000BB4B4 File Offset: 0x000B96B4
	// (set) Token: 0x06002B6F RID: 11119 RVA: 0x000BB4BC File Offset: 0x000B96BC
	[XmlAttribute("rating")]
	public double Rating
	{
		[CompilerGenerated]
		get
		{
			return this.double_3;
		}
		[CompilerGenerated]
		set
		{
			this.double_3 = value;
		}
	}

	// Token: 0x17000606 RID: 1542
	// (get) Token: 0x06002B70 RID: 11120 RVA: 0x000BB4C8 File Offset: 0x000B96C8
	// (set) Token: 0x06002B71 RID: 11121 RVA: 0x000BB4D0 File Offset: 0x000B96D0
	[XmlAttribute("ispdlavg")]
	public int IspAvarageDownloadSpeed
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

	// Token: 0x17000607 RID: 1543
	// (get) Token: 0x06002B72 RID: 11122 RVA: 0x000BB4DC File Offset: 0x000B96DC
	// (set) Token: 0x06002B73 RID: 11123 RVA: 0x000BB4E4 File Offset: 0x000B96E4
	[XmlAttribute("ispulavg")]
	public int IspAvarageUploadSpeed
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

	// Token: 0x17000608 RID: 1544
	// (get) Token: 0x06002B74 RID: 11124 RVA: 0x000BB4F0 File Offset: 0x000B96F0
	public Coordinate GeoCoordinate
	{
		get
		{
			return this.lazy_0.Value;
		}
	}

	// Token: 0x06002B75 RID: 11125 RVA: 0x000BB500 File Offset: 0x000B9700
	private Coordinate method_0()
	{
		return new Coordinate(this.Latitude, this.Longitude);
	}

	// Token: 0x040021A6 RID: 8614
	private string string_0;

	// Token: 0x040021A7 RID: 8615
	private double double_0;

	// Token: 0x040021A8 RID: 8616
	private double double_1;

	// Token: 0x040021A9 RID: 8617
	private string string_1;

	// Token: 0x040021AA RID: 8618
	private double double_2;

	// Token: 0x040021AB RID: 8619
	private double double_3;

	// Token: 0x040021AC RID: 8620
	private int int_0;

	// Token: 0x040021AD RID: 8621
	private int int_1;

	// Token: 0x040021AE RID: 8622
	private readonly Lazy<Coordinate> lazy_0;
}
