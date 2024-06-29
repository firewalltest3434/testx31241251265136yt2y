using System;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

// Token: 0x02000412 RID: 1042
public sealed class GClass221 : GClass211
{
	// Token: 0x0600167C RID: 5756 RVA: 0x0005E4F8 File Offset: 0x0005C6F8
	public GClass221(GClass116 gclass116_1, bool bool_3 = false, string string_1 = "")
	{
		this.class520_0 = new Class520(this);
		this.gclass116_0 = gclass116_1;
		this.IsEnabled = (this.gclass116_0.Status == "Started");
		this.MsiStatus = this.gclass116_0.method_16();
		this.bool_0 = bool_3;
		this.string_0 = string_1;
	}

	// Token: 0x170002FB RID: 763
	// (get) Token: 0x0600167D RID: 5757 RVA: 0x0005E564 File Offset: 0x0005C764
	public string Name
	{
		get
		{
			return this.gclass116_0.Name;
		}
	}

	// Token: 0x170002FC RID: 764
	// (get) Token: 0x0600167E RID: 5758 RVA: 0x0005E574 File Offset: 0x0005C774
	public string ClassName
	{
		get
		{
			return this.gclass116_0.method_2();
		}
	}

	// Token: 0x170002FD RID: 765
	// (get) Token: 0x0600167F RID: 5759 RVA: 0x0005E584 File Offset: 0x0005C784
	public string ClassGuid
	{
		get
		{
			return this.gclass116_0.method_4();
		}
	}

	// Token: 0x170002FE RID: 766
	// (get) Token: 0x06001680 RID: 5760 RVA: 0x0005E594 File Offset: 0x0005C794
	public BitmapSource Icon
	{
		get
		{
			return GClass160.smethod_1(this.gclass116_0.method_4());
		}
	}

	// Token: 0x170002FF RID: 767
	// (get) Token: 0x06001681 RID: 5761 RVA: 0x0005E5A8 File Offset: 0x0005C7A8
	public string Id
	{
		get
		{
			return this.gclass116_0.method_0();
		}
	}

	// Token: 0x17000300 RID: 768
	// (get) Token: 0x06001682 RID: 5762 RVA: 0x0005E5B8 File Offset: 0x0005C7B8
	public string Description
	{
		get
		{
			string text = string.Empty;
			if (this.string_0 == string.Empty)
			{
				text += (this.bool_0 ? Class364.smethod_0("MsiDeviceDesc") : Class364.smethod_0("DisableDeviceDesc"));
			}
			else
			{
				text += this.string_0;
			}
			text += "\n\n";
			return string.Concat(new string[]
			{
				text,
				"ID: ",
				this.gclass116_0.method_0(),
				"\r\n",
				Class364.smethod_0("Name"),
				": ",
				this.gclass116_0.Name,
				"\r\n",
				Class364.smethod_0("Driver"),
				": ",
				this.gclass116_0.method_8(),
				"\r\n",
				Class364.smethod_0("Manufacturer"),
				": ",
				this.gclass116_0.method_6(),
				"\r\n",
				Class364.smethod_0("storexerror2"),
				": ",
				this.gclass116_0.method_12(),
				"\r\n",
				Class364.smethod_0("Status"),
				": ",
				this.gclass116_0.Status
			});
		}
	}

	// Token: 0x17000301 RID: 769
	// (get) Token: 0x06001683 RID: 5763 RVA: 0x0005E738 File Offset: 0x0005C938
	// (set) Token: 0x06001684 RID: 5764 RVA: 0x0005E740 File Offset: 0x0005C940
	public bool? CurrentStatus
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_0;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x17000302 RID: 770
	// (get) Token: 0x06001685 RID: 5765 RVA: 0x0005E74C File Offset: 0x0005C94C
	// (set) Token: 0x06001686 RID: 5766 RVA: 0x0005E754 File Offset: 0x0005C954
	public bool IsEnabled
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			if (this.CurrentStatus == null)
			{
				this.CurrentStatus = new bool?(value);
			}
			this.bool_1 = value;
			base.method_0("HasChangesEnabled");
			base.method_0("IsEnabled");
			this.method_1();
		}
	}

	// Token: 0x17000303 RID: 771
	// (get) Token: 0x06001687 RID: 5767 RVA: 0x0005E7A0 File Offset: 0x0005C9A0
	// (set) Token: 0x06001688 RID: 5768 RVA: 0x0005E7A8 File Offset: 0x0005C9A8
	public bool? MsiCurrentStatus
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_1;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_1 = value;
		}
	}

	// Token: 0x17000304 RID: 772
	// (get) Token: 0x06001689 RID: 5769 RVA: 0x0005E7B4 File Offset: 0x0005C9B4
	// (set) Token: 0x0600168A RID: 5770 RVA: 0x0005E7BC File Offset: 0x0005C9BC
	public bool MsiStatus
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			bool? msiCurrentStatus = this.MsiCurrentStatus;
			bool valueOrDefault = msiCurrentStatus.GetValueOrDefault();
			if (msiCurrentStatus == null)
			{
				bool? msiCurrentStatus2 = new bool?(value);
				this.MsiCurrentStatus = msiCurrentStatus2;
			}
			this.bool_2 = value;
			base.method_0("HasChangesMSI");
			base.method_0("MsiStatus");
			this.method_2();
		}
	}

	// Token: 0x17000305 RID: 773
	// (get) Token: 0x0600168B RID: 5771 RVA: 0x0005E818 File Offset: 0x0005CA18
	public bool HasChangesMSI
	{
		get
		{
			bool msiStatus = this.MsiStatus;
			bool? msiCurrentStatus = this.MsiCurrentStatus;
			return !(msiStatus == msiCurrentStatus.GetValueOrDefault() & msiCurrentStatus != null);
		}
	}

	// Token: 0x17000306 RID: 774
	// (get) Token: 0x0600168C RID: 5772 RVA: 0x0005E848 File Offset: 0x0005CA48
	public bool HasChangesEnabled
	{
		get
		{
			bool isEnabled = this.IsEnabled;
			bool? currentStatus = this.CurrentStatus;
			return !(isEnabled == currentStatus.GetValueOrDefault() & currentStatus != null);
		}
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x0005E878 File Offset: 0x0005CA78
	private void method_1()
	{
		if (!this.HasChangesEnabled)
		{
			this.method_4();
			return;
		}
		this.method_3();
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x0005E890 File Offset: 0x0005CA90
	private void method_2()
	{
		if (!this.HasChangesMSI)
		{
			this.method_4();
			return;
		}
		this.method_3();
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x0005E8A8 File Offset: 0x0005CAA8
	private void method_3()
	{
		GClass93.smethod_0().method_9<Class520>(this.gclass116_0.method_0(), new Func<Class520>(this.method_5), this);
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x0005E8D0 File Offset: 0x0005CAD0
	private void method_4()
	{
		GClass93.smethod_0().method_15(typeof(Class520), this.gclass116_0.method_0());
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x0005E8F4 File Offset: 0x0005CAF4
	private Class520 method_5()
	{
		return this.class520_0;
	}

	// Token: 0x04001026 RID: 4134
	private GClass116 gclass116_0;

	// Token: 0x04001027 RID: 4135
	private Class520 class520_0;

	// Token: 0x04001028 RID: 4136
	private bool bool_0;

	// Token: 0x04001029 RID: 4137
	private string string_0 = string.Empty;

	// Token: 0x0400102A RID: 4138
	private bool? nullable_0;

	// Token: 0x0400102B RID: 4139
	private bool bool_1;

	// Token: 0x0400102C RID: 4140
	private bool? nullable_1;

	// Token: 0x0400102D RID: 4141
	private bool bool_2;
}
