using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200030B RID: 779
public sealed class GClass94
{
	// Token: 0x1700021A RID: 538
	// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0004A57C File Offset: 0x0004877C
	// (set) Token: 0x060011D8 RID: 4568 RVA: 0x0004A584 File Offset: 0x00048784
	[JsonProperty("Applications")]
	public List<GClass47> List_0
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

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x060011D9 RID: 4569 RVA: 0x0004A590 File Offset: 0x00048790
	// (set) Token: 0x060011DA RID: 4570 RVA: 0x0004A598 File Offset: 0x00048798
	[JsonProperty("Architectures")]
	public List<string> List_1
	{
		get
		{
			return this.list_1;
		}
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x060011DB RID: 4571 RVA: 0x0004A5A4 File Offset: 0x000487A4
	// (set) Token: 0x060011DC RID: 4572 RVA: 0x0004A5AC File Offset: 0x000487AC
	[JsonProperty("Capabilities")]
	public List<string> List_2
	{
		get
		{
			return this.list_2;
		}
		set
		{
			this.list_2 = value;
		}
	}

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x060011DD RID: 4573 RVA: 0x0004A5B8 File Offset: 0x000487B8
	// (set) Token: 0x060011DE RID: 4574 RVA: 0x0004A5C0 File Offset: 0x000487C0
	[JsonProperty("DeviceCapabilities")]
	public List<object> List_3
	{
		get
		{
			return this.list_3;
		}
		set
		{
			this.list_3 = value;
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x060011DF RID: 4575 RVA: 0x0004A5CC File Offset: 0x000487CC
	// (set) Token: 0x060011E0 RID: 4576 RVA: 0x0004A5D4 File Offset: 0x000487D4
	[JsonProperty("ExperienceIds")]
	public List<object> List_4
	{
		get
		{
			return this.list_4;
		}
		set
		{
			this.list_4 = value;
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0004A5E0 File Offset: 0x000487E0
	// (set) Token: 0x060011E2 RID: 4578 RVA: 0x0004A5E8 File Offset: 0x000487E8
	[JsonProperty("FrameworkDependencies")]
	public List<object> List_5
	{
		get
		{
			return this.list_5;
		}
		set
		{
			this.list_5 = value;
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0004A5F4 File Offset: 0x000487F4
	// (set) Token: 0x060011E4 RID: 4580 RVA: 0x0004A5FC File Offset: 0x000487FC
	[JsonProperty("HardwareDependencies")]
	public List<object> List_6
	{
		get
		{
			return this.list_6;
		}
		set
		{
			this.list_6 = value;
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0004A608 File Offset: 0x00048808
	// (set) Token: 0x060011E6 RID: 4582 RVA: 0x0004A610 File Offset: 0x00048810
	[JsonProperty("HardwareRequirements")]
	public List<object> List_7
	{
		get
		{
			return this.list_7;
		}
		set
		{
			this.list_7 = value;
		}
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0004A61C File Offset: 0x0004881C
	// (set) Token: 0x060011E8 RID: 4584 RVA: 0x0004A624 File Offset: 0x00048824
	[JsonProperty("Hash")]
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

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0004A630 File Offset: 0x00048830
	// (set) Token: 0x060011EA RID: 4586 RVA: 0x0004A638 File Offset: 0x00048838
	[JsonProperty("HashAlgorithm")]
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

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x060011EB RID: 4587 RVA: 0x0004A644 File Offset: 0x00048844
	// (set) Token: 0x060011EC RID: 4588 RVA: 0x0004A64C File Offset: 0x0004884C
	[JsonProperty("IsStreamingApp")]
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

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x060011ED RID: 4589 RVA: 0x0004A658 File Offset: 0x00048858
	// (set) Token: 0x060011EE RID: 4590 RVA: 0x0004A660 File Offset: 0x00048860
	[JsonProperty("Languages")]
	public List<string> List_8
	{
		get
		{
			return this.list_8;
		}
		set
		{
			this.list_8 = value;
		}
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x060011EF RID: 4591 RVA: 0x0004A66C File Offset: 0x0004886C
	// (set) Token: 0x060011F0 RID: 4592 RVA: 0x0004A674 File Offset: 0x00048874
	[JsonProperty("MaxDownloadSizeInBytes")]
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

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0004A680 File Offset: 0x00048880
	// (set) Token: 0x060011F2 RID: 4594 RVA: 0x0004A688 File Offset: 0x00048888
	[JsonProperty("MaxInstallSizeInBytes")]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0004A694 File Offset: 0x00048894
	// (set) Token: 0x060011F4 RID: 4596 RVA: 0x0004A69C File Offset: 0x0004889C
	[JsonProperty("PackageFormat")]
	public string String_3
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x060011F5 RID: 4597 RVA: 0x0004A6A8 File Offset: 0x000488A8
	// (set) Token: 0x060011F6 RID: 4598 RVA: 0x0004A6B0 File Offset: 0x000488B0
	[JsonProperty("PackageFamilyName")]
	public string String_4
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x060011F7 RID: 4599 RVA: 0x0004A6BC File Offset: 0x000488BC
	// (set) Token: 0x060011F8 RID: 4600 RVA: 0x0004A6C4 File Offset: 0x000488C4
	[JsonProperty("MainPackageFamilyNameForDlc")]
	public object Object_0
	{
		get
		{
			return this.object_0;
		}
		set
		{
			this.object_0 = value;
		}
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x060011F9 RID: 4601 RVA: 0x0004A6D0 File Offset: 0x000488D0
	// (set) Token: 0x060011FA RID: 4602 RVA: 0x0004A6D8 File Offset: 0x000488D8
	[JsonProperty("PackageFullName")]
	public string String_5
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x060011FB RID: 4603 RVA: 0x0004A6E4 File Offset: 0x000488E4
	// (set) Token: 0x060011FC RID: 4604 RVA: 0x0004A6EC File Offset: 0x000488EC
	[JsonProperty("PackageId")]
	public string String_6
	{
		get
		{
			return this.string_6;
		}
		set
		{
			this.string_6 = value;
		}
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x060011FD RID: 4605 RVA: 0x0004A6F8 File Offset: 0x000488F8
	// (set) Token: 0x060011FE RID: 4606 RVA: 0x0004A700 File Offset: 0x00048900
	[JsonProperty("ContentId")]
	public string String_7
	{
		get
		{
			return this.string_7;
		}
		set
		{
			this.string_7 = value;
		}
	}

	// Token: 0x1700022E RID: 558
	// (get) Token: 0x060011FF RID: 4607 RVA: 0x0004A70C File Offset: 0x0004890C
	// (set) Token: 0x06001200 RID: 4608 RVA: 0x0004A714 File Offset: 0x00048914
	[JsonProperty("KeyId")]
	public string String_8
	{
		get
		{
			return this.string_8;
		}
		set
		{
			this.string_8 = value;
		}
	}

	// Token: 0x1700022F RID: 559
	// (get) Token: 0x06001201 RID: 4609 RVA: 0x0004A720 File Offset: 0x00048920
	// (set) Token: 0x06001202 RID: 4610 RVA: 0x0004A728 File Offset: 0x00048928
	[JsonProperty("PackageRank")]
	public long Int64_1
	{
		get
		{
			return this.long_1;
		}
		set
		{
			this.long_1 = value;
		}
	}

	// Token: 0x17000230 RID: 560
	// (get) Token: 0x06001203 RID: 4611 RVA: 0x0004A734 File Offset: 0x00048934
	// (set) Token: 0x06001204 RID: 4612 RVA: 0x0004A73C File Offset: 0x0004893C
	[JsonProperty("PackageUri")]
	public string String_9
	{
		get
		{
			return this.string_9;
		}
		set
		{
			this.string_9 = value;
		}
	}

	// Token: 0x17000231 RID: 561
	// (get) Token: 0x06001205 RID: 4613 RVA: 0x0004A748 File Offset: 0x00048948
	// (set) Token: 0x06001206 RID: 4614 RVA: 0x0004A750 File Offset: 0x00048950
	[JsonProperty("PlatformDependencies")]
	public List<GClass120> List_9
	{
		get
		{
			return this.list_9;
		}
		set
		{
			this.list_9 = value;
		}
	}

	// Token: 0x17000232 RID: 562
	// (get) Token: 0x06001207 RID: 4615 RVA: 0x0004A75C File Offset: 0x0004895C
	// (set) Token: 0x06001208 RID: 4616 RVA: 0x0004A764 File Offset: 0x00048964
	[JsonProperty("PlatformDependencyXmlBlob")]
	public string String_10
	{
		get
		{
			return this.string_10;
		}
		set
		{
			this.string_10 = value;
		}
	}

	// Token: 0x17000233 RID: 563
	// (get) Token: 0x06001209 RID: 4617 RVA: 0x0004A770 File Offset: 0x00048970
	// (set) Token: 0x0600120A RID: 4618 RVA: 0x0004A778 File Offset: 0x00048978
	[JsonProperty("ResourceId")]
	public string String_11
	{
		get
		{
			return this.string_11;
		}
		set
		{
			this.string_11 = value;
		}
	}

	// Token: 0x17000234 RID: 564
	// (get) Token: 0x0600120B RID: 4619 RVA: 0x0004A784 File Offset: 0x00048984
	// (set) Token: 0x0600120C RID: 4620 RVA: 0x0004A78C File Offset: 0x0004898C
	[JsonProperty("Version")]
	public string String_12
	{
		get
		{
			return this.string_12;
		}
		set
		{
			this.string_12 = value;
		}
	}

	// Token: 0x17000235 RID: 565
	// (get) Token: 0x0600120D RID: 4621 RVA: 0x0004A798 File Offset: 0x00048998
	// (set) Token: 0x0600120E RID: 4622 RVA: 0x0004A7A0 File Offset: 0x000489A0
	[JsonProperty("PackageDownloadUris")]
	public List<GClass114> List_10
	{
		get
		{
			return this.list_10;
		}
		set
		{
			this.list_10 = value;
		}
	}

	// Token: 0x17000236 RID: 566
	// (get) Token: 0x0600120F RID: 4623 RVA: 0x0004A7AC File Offset: 0x000489AC
	// (set) Token: 0x06001210 RID: 4624 RVA: 0x0004A7B4 File Offset: 0x000489B4
	[JsonProperty("DriverDependencies")]
	public List<object> List_11
	{
		get
		{
			return this.list_11;
		}
		set
		{
			this.list_11 = value;
		}
	}

	// Token: 0x17000237 RID: 567
	// (get) Token: 0x06001211 RID: 4625 RVA: 0x0004A7C0 File Offset: 0x000489C0
	// (set) Token: 0x06001212 RID: 4626 RVA: 0x0004A7C8 File Offset: 0x000489C8
	[JsonProperty("FulfillmentData")]
	public GClass3 GClass3_0
	{
		get
		{
			return this.gclass3_0;
		}
		set
		{
			this.gclass3_0 = value;
		}
	}

	// Token: 0x04000AB9 RID: 2745
	private List<GClass47> list_0;

	// Token: 0x04000ABA RID: 2746
	private List<string> list_1;

	// Token: 0x04000ABB RID: 2747
	private List<string> list_2;

	// Token: 0x04000ABC RID: 2748
	private List<object> list_3;

	// Token: 0x04000ABD RID: 2749
	private List<object> list_4;

	// Token: 0x04000ABE RID: 2750
	private List<object> list_5;

	// Token: 0x04000ABF RID: 2751
	private List<object> list_6;

	// Token: 0x04000AC0 RID: 2752
	private List<object> list_7;

	// Token: 0x04000AC1 RID: 2753
	private string string_0;

	// Token: 0x04000AC2 RID: 2754
	private string string_1;

	// Token: 0x04000AC3 RID: 2755
	private bool bool_0;

	// Token: 0x04000AC4 RID: 2756
	private List<string> list_8;

	// Token: 0x04000AC5 RID: 2757
	private long long_0;

	// Token: 0x04000AC6 RID: 2758
	private string string_2;

	// Token: 0x04000AC7 RID: 2759
	private string string_3;

	// Token: 0x04000AC8 RID: 2760
	private string string_4;

	// Token: 0x04000AC9 RID: 2761
	private object object_0;

	// Token: 0x04000ACA RID: 2762
	private string string_5;

	// Token: 0x04000ACB RID: 2763
	private string string_6;

	// Token: 0x04000ACC RID: 2764
	private string string_7;

	// Token: 0x04000ACD RID: 2765
	private string string_8;

	// Token: 0x04000ACE RID: 2766
	private long long_1;

	// Token: 0x04000ACF RID: 2767
	private string string_9;

	// Token: 0x04000AD0 RID: 2768
	private List<GClass120> list_9;

	// Token: 0x04000AD1 RID: 2769
	private string string_10;

	// Token: 0x04000AD2 RID: 2770
	private string string_11;

	// Token: 0x04000AD3 RID: 2771
	private string string_12;

	// Token: 0x04000AD4 RID: 2772
	private List<GClass114> list_10;

	// Token: 0x04000AD5 RID: 2773
	private List<object> list_11;

	// Token: 0x04000AD6 RID: 2774
	private GClass3 gclass3_0;
}
