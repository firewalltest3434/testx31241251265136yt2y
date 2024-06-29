using System;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using ns0;

// Token: 0x020001ED RID: 493
internal sealed class Class720 : GClass211
{
	// Token: 0x06000BA5 RID: 2981 RVA: 0x00036660 File Offset: 0x00034860
	public Class720()
	{
		this.method_2(new Class521(this));
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x00036674 File Offset: 0x00034874
	private Class521 method_1()
	{
		return this.class521_0;
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x0003667C File Offset: 0x0003487C
	private void method_2(Class521 class521_1)
	{
		this.class521_0 = class521_1;
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00036688 File Offset: 0x00034888
	// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x00036690 File Offset: 0x00034890
	public dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd Type
	{
		[CompilerGenerated]
		get
		{
			return this.dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd_0;
		}
		[CompilerGenerated]
		set
		{
			this.dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd_0 = value;
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0003669C File Offset: 0x0003489C
	public string NameClean
	{
		get
		{
			return this.Name.smethod_5();
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06000BAB RID: 2987 RVA: 0x000366AC File Offset: 0x000348AC
	// (set) Token: 0x06000BAC RID: 2988 RVA: 0x000366B4 File Offset: 0x000348B4
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

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06000BAD RID: 2989 RVA: 0x000366C0 File Offset: 0x000348C0
	// (set) Token: 0x06000BAE RID: 2990 RVA: 0x000366C8 File Offset: 0x000348C8
	public string Description
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

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000BAF RID: 2991 RVA: 0x000366D4 File Offset: 0x000348D4
	// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x000366DC File Offset: 0x000348DC
	public string Runs
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

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x000366E8 File Offset: 0x000348E8
	// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x000366F0 File Offset: 0x000348F0
	public BitmapSource Icon
	{
		[CompilerGenerated]
		get
		{
			return this.bitmapSource_0;
		}
		[CompilerGenerated]
		set
		{
			this.bitmapSource_0 = value;
		}
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x000366FC File Offset: 0x000348FC
	// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x00036704 File Offset: 0x00034904
	public string Path
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

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00036710 File Offset: 0x00034910
	// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x00036718 File Offset: 0x00034918
	public bool? Status
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

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00036724 File Offset: 0x00034924
	// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x0003672C File Offset: 0x0003492C
	public bool? NewStatus
	{
		get
		{
			return this.nullable_1;
		}
		set
		{
			if (this.Status == null)
			{
				this.Status = value;
			}
			this.nullable_1 = value;
			if (this.nullable_1 != null)
			{
				this.ToDelete = false;
			}
			base.method_0("NewStatus");
			base.method_0("HasChanges");
			this.method_3();
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00036788 File Offset: 0x00034988
	// (set) Token: 0x06000BBA RID: 3002 RVA: 0x00036790 File Offset: 0x00034990
	public bool ToDelete
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			if (value)
			{
				this.NewStatus = null;
			}
			if (this.nullable_1 == null && !value)
			{
				this.NewStatus = this.Status;
			}
			base.method_0("ToDelete");
		}
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x000367E0 File Offset: 0x000349E0
	private void method_3()
	{
		if (!this.HasChanges)
		{
			this.method_5();
			return;
		}
		this.method_4();
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000BBC RID: 3004 RVA: 0x000367F8 File Offset: 0x000349F8
	public bool HasChanges
	{
		get
		{
			bool? newStatus = this.NewStatus;
			bool? status = this.Status;
			return !(newStatus.GetValueOrDefault() == status.GetValueOrDefault() & newStatus != null == (status != null));
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00036838 File Offset: 0x00034A38
	public bool AddToConfig
	{
		get
		{
			return Class585.struct13_0.method_0();
		}
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x00036844 File Offset: 0x00034A44
	private void method_4()
	{
		if (this.NewStatus == null && !this.AddToConfig)
		{
			return;
		}
		GClass93.smethod_0().method_9<Class521>(this.Path + this.Name, new Func<Class521>(this.method_7), this.method_6());
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x00036898 File Offset: 0x00034A98
	private void method_5()
	{
		GClass93.smethod_0().method_14<Class521>(this.Path + this.Name);
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x000368B8 File Offset: 0x00034AB8
	public string method_6()
	{
		string result = string.Empty;
		if (this.NewStatus == null)
		{
			result = "Delete";
		}
		else
		{
			result = (this.NewStatus.Value ? "Disable" : "Enable");
		}
		return result;
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x00036910 File Offset: 0x00034B10
	private Class521 method_7()
	{
		return this.method_1();
	}

	// Token: 0x04000748 RID: 1864
	private Class521 class521_0;

	// Token: 0x04000749 RID: 1865
	private dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd_0;

	// Token: 0x0400074A RID: 1866
	private string string_0;

	// Token: 0x0400074B RID: 1867
	private string string_1;

	// Token: 0x0400074C RID: 1868
	private string string_2;

	// Token: 0x0400074D RID: 1869
	private BitmapSource bitmapSource_0;

	// Token: 0x0400074E RID: 1870
	private string string_3;

	// Token: 0x0400074F RID: 1871
	private bool? nullable_0;

	// Token: 0x04000750 RID: 1872
	private bool? nullable_1;

	// Token: 0x04000751 RID: 1873
	private bool bool_0;
}
