using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020000D8 RID: 216
public sealed class GClass2
{
	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000662 RID: 1634 RVA: 0x0001FD5C File Offset: 0x0001DF5C
	// (set) Token: 0x06000663 RID: 1635 RVA: 0x0001FD64 File Offset: 0x0001DF64
	[JsonProperty("blob.version")]
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			this.long_0 = value;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000664 RID: 1636 RVA: 0x0001FD70 File Offset: 0x0001DF70
	// (set) Token: 0x06000665 RID: 1637 RVA: 0x0001FD78 File Offset: 0x0001DF78
	[JsonProperty("content.isMain")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000666 RID: 1638 RVA: 0x0001FD84 File Offset: 0x0001DF84
	// (set) Token: 0x06000667 RID: 1639 RVA: 0x0001FD8C File Offset: 0x0001DF8C
	[JsonProperty("content.packageId")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000668 RID: 1640 RVA: 0x0001FD98 File Offset: 0x0001DF98
	// (set) Token: 0x06000669 RID: 1641 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
	[JsonProperty("content.productId")]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x0600066A RID: 1642 RVA: 0x0001FDAC File Offset: 0x0001DFAC
	// (set) Token: 0x0600066B RID: 1643 RVA: 0x0001FDB4 File Offset: 0x0001DFB4
	[JsonProperty("content.targetPlatforms")]
	public List<GClass185> List_0
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

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x0600066C RID: 1644 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
	// (set) Token: 0x0600066D RID: 1645 RVA: 0x0001FDC8 File Offset: 0x0001DFC8
	[JsonProperty("content.type")]
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600066E RID: 1646 RVA: 0x0001FDD4 File Offset: 0x0001DFD4
	// (set) Token: 0x0600066F RID: 1647 RVA: 0x0001FDDC File Offset: 0x0001DFDC
	[JsonProperty("policy")]
	public GClass153 GClass153_0
	{
		get
		{
			return this.gclass153_0;
		}
		set
		{
			this.gclass153_0 = value;
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000670 RID: 1648 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
	// (set) Token: 0x06000671 RID: 1649 RVA: 0x0001FDF0 File Offset: 0x0001DFF0
	[JsonProperty("policy2")]
	public GClass121 GClass121_0
	{
		get
		{
			return this.gclass121_0;
		}
		set
		{
			this.gclass121_0 = value;
		}
	}

	// Token: 0x04000332 RID: 818
	private long long_0;

	// Token: 0x04000333 RID: 819
	private bool bool_0;

	// Token: 0x04000334 RID: 820
	private string string_0;

	// Token: 0x04000335 RID: 821
	private string string_1;

	// Token: 0x04000336 RID: 822
	private List<GClass185> list_0;

	// Token: 0x04000337 RID: 823
	private int int_0;

	// Token: 0x04000338 RID: 824
	private GClass153 gclass153_0;

	// Token: 0x04000339 RID: 825
	private GClass121 gclass121_0;
}
