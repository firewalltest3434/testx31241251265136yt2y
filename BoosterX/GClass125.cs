using System;
using System.Collections.Generic;
using System.Linq;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x0200044E RID: 1102
public sealed class GClass125 : GInterface17
{
	// Token: 0x06001868 RID: 6248 RVA: 0x00066074 File Offset: 0x00064274
	public GClass125(GClass143 gclass143_1, GEnum3 genum3_1 = GEnum3.CustomSettings)
	{
		this.gclass143_0 = gclass143_1;
		this.genum3_0 = genum3_1;
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x0006608C File Offset: 0x0006428C
	public NVDRS_SETTING_TYPE? imethod_1(uint uint_0)
	{
		GClass125.Class517 @class = new GClass125.Class517();
		@class.uint_0 = uint_0;
		GClass150 gclass = this.gclass143_0.list_0.FirstOrDefault(new Func<GClass150, bool>(@class.method_0));
		return this.method_0((gclass != null) ? gclass.String_4 : null);
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x000660D8 File Offset: 0x000642D8
	private NVDRS_SETTING_TYPE? method_0(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		string a = string_0.ToLowerInvariant();
		if (a == "dword")
		{
			return new NVDRS_SETTING_TYPE?(NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE);
		}
		if (a == "string")
		{
			return new NVDRS_SETTING_TYPE?(NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE);
		}
		if (!(a == "binary"))
		{
			throw new ArgumentOutOfRangeException(string_0);
		}
		return new NVDRS_SETTING_TYPE?(NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE);
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x00066140 File Offset: 0x00064340
	public string imethod_2(uint uint_0)
	{
		GClass125.Class516 @class = new GClass125.Class516();
		@class.uint_0 = uint_0;
		GClass150 gclass = this.gclass143_0.list_0.FirstOrDefault(new Func<GClass150, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.String_0;
		}
		return null;
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x00066184 File Offset: 0x00064384
	public uint? imethod_4(uint uint_0)
	{
		GClass125.Class519 @class = new GClass125.Class519();
		@class.uint_0 = uint_0;
		GClass150 gclass = this.gclass143_0.list_0.FirstOrDefault(new Func<GClass150, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.DefaultValue;
		}
		return null;
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x000661D0 File Offset: 0x000643D0
	public string imethod_5(uint uint_0)
	{
		return null;
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x000661D4 File Offset: 0x000643D4
	public List<GClass58<string>> imethod_7(uint uint_0)
	{
		return null;
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x000661D8 File Offset: 0x000643D8
	public List<GClass58<uint>> imethod_8(uint uint_0)
	{
		GClass125.Class513 @class = new GClass125.Class513();
		@class.uint_0 = uint_0;
		@class.gclass125_0 = this;
		GClass150 gclass = this.gclass143_0.list_0.FirstOrDefault(new Func<GClass150, bool>(@class.method_0));
		if (gclass != null)
		{
			GClass125.Class511 class2 = new GClass125.Class511();
			class2.class513_0 = @class;
			class2.int_0 = 0;
			return gclass.List_0.Select(new Func<GClass184, GClass58<uint>>(class2.method_0)).ToList<GClass58<uint>>();
		}
		return null;
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x0006624C File Offset: 0x0006444C
	public List<uint> imethod_10()
	{
		return this.gclass143_0.list_0.Select(new Func<GClass150, uint>(GClass125.Class515.class515_0.method_0)).ToList<uint>();
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x00066284 File Offset: 0x00064484
	public string imethod_3(uint uint_0)
	{
		GClass125.Class512 @class = new GClass125.Class512();
		@class.uint_0 = uint_0;
		GClass150 gclass = this.gclass143_0.list_0.FirstOrDefault(new Func<GClass150, bool>(@class.method_0));
		if (gclass != null && !string.IsNullOrWhiteSpace(gclass.String_2))
		{
			return gclass.String_2;
		}
		return null;
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x000662D4 File Offset: 0x000644D4
	public byte[] imethod_6(uint uint_0)
	{
		return null;
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x000662D8 File Offset: 0x000644D8
	public List<GClass58<byte[]>> imethod_9(uint uint_0)
	{
		return null;
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x000662DC File Offset: 0x000644DC
	public bool method_1(uint uint_0)
	{
		GClass125.Class514 @class = new GClass125.Class514();
		@class.uint_0 = uint_0;
		GClass150 gclass = this.gclass143_0.list_0.FirstOrDefault(new Func<GClass150, bool>(@class.method_0));
		return gclass != null && gclass.Boolean_0;
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x00066320 File Offset: 0x00064520
	public string method_2(uint uint_0)
	{
		GClass125.Class518 @class = new GClass125.Class518();
		@class.uint_0 = uint_0;
		GClass150 gclass = this.gclass143_0.list_0.FirstOrDefault(new Func<GClass150, bool>(@class.method_0));
		if (gclass == null)
		{
			return null;
		}
		return gclass.Description;
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x00066364 File Offset: 0x00064564
	public GEnum3 imethod_0()
	{
		return this.genum3_0;
	}

	// Token: 0x04001120 RID: 4384
	private readonly GClass143 gclass143_0;

	// Token: 0x04001121 RID: 4385
	private readonly GEnum3 genum3_0;

	// Token: 0x0200044F RID: 1103
	private sealed class Class511
	{
		// Token: 0x06001878 RID: 6264 RVA: 0x00066374 File Offset: 0x00064574
		internal GClass58<uint> method_0(GClass184 gclass184_0)
		{
			GClass58<uint> gclass = new GClass58<uint>(this.class513_0.gclass125_0.imethod_0());
			int num = this.int_0;
			this.int_0 = num + 1;
			gclass.method_1(num);
			gclass.method_3(gclass184_0.SettingValue);
			gclass.imethod_2((this.class513_0.gclass125_0.genum3_0 == GEnum3.CustomSettings) ? gclass184_0.String_0 : (GClass166.smethod_0(gclass184_0.SettingValue) + " " + gclass184_0.String_0));
			return gclass;
		}

		// Token: 0x04001122 RID: 4386
		public int int_0;

		// Token: 0x04001123 RID: 4387
		public GClass125.Class513 class513_0;
	}

	// Token: 0x02000450 RID: 1104
	private sealed class Class512
	{
		// Token: 0x0600187A RID: 6266 RVA: 0x00066408 File Offset: 0x00064608
		internal bool method_0(GClass150 gclass150_0)
		{
			return gclass150_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x04001124 RID: 4388
		public uint uint_0;
	}

	// Token: 0x02000451 RID: 1105
	private sealed class Class513
	{
		// Token: 0x0600187C RID: 6268 RVA: 0x00066434 File Offset: 0x00064634
		internal bool method_0(GClass150 gclass150_0)
		{
			return gclass150_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x04001125 RID: 4389
		public uint uint_0;

		// Token: 0x04001126 RID: 4390
		public GClass125 gclass125_0;
	}

	// Token: 0x02000452 RID: 1106
	private sealed class Class514
	{
		// Token: 0x0600187E RID: 6270 RVA: 0x00066460 File Offset: 0x00064660
		internal bool method_0(GClass150 gclass150_0)
		{
			return gclass150_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x04001127 RID: 4391
		public uint uint_0;
	}

	// Token: 0x02000453 RID: 1107
	[Serializable]
	private sealed class Class515
	{
		// Token: 0x06001881 RID: 6273 RVA: 0x00066498 File Offset: 0x00064698
		internal uint method_0(GClass150 gclass150_0)
		{
			return gclass150_0.SettingId;
		}

		// Token: 0x04001128 RID: 4392
		public static readonly GClass125.Class515 class515_0 = new GClass125.Class515();

		// Token: 0x04001129 RID: 4393
		public static Func<GClass150, uint> func_0;
	}

	// Token: 0x02000454 RID: 1108
	private sealed class Class516
	{
		// Token: 0x06001883 RID: 6275 RVA: 0x000664A8 File Offset: 0x000646A8
		internal bool method_0(GClass150 gclass150_0)
		{
			return gclass150_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x0400112A RID: 4394
		public uint uint_0;
	}

	// Token: 0x02000455 RID: 1109
	private sealed class Class517
	{
		// Token: 0x06001885 RID: 6277 RVA: 0x000664D4 File Offset: 0x000646D4
		internal bool method_0(GClass150 gclass150_0)
		{
			return gclass150_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x0400112B RID: 4395
		public uint uint_0;
	}

	// Token: 0x02000456 RID: 1110
	private sealed class Class518
	{
		// Token: 0x06001887 RID: 6279 RVA: 0x00066500 File Offset: 0x00064700
		internal bool method_0(GClass150 gclass150_0)
		{
			return gclass150_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x0400112C RID: 4396
		public uint uint_0;
	}

	// Token: 0x02000457 RID: 1111
	private sealed class Class519
	{
		// Token: 0x06001889 RID: 6281 RVA: 0x0006652C File Offset: 0x0006472C
		internal bool method_0(GClass150 gclass150_0)
		{
			return gclass150_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x0400112D RID: 4397
		public uint uint_0;
	}
}
