using System;
using System.Collections.Generic;
using System.Linq;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x020002F4 RID: 756
public sealed class GClass87 : GInterface17
{
	// Token: 0x06001125 RID: 4389 RVA: 0x00048508 File Offset: 0x00046708
	public GClass87(List<GClass75> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00048518 File Offset: 0x00046718
	public GEnum3 imethod_0()
	{
		return GEnum3.ScannedSettings;
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x0004851C File Offset: 0x0004671C
	public NVDRS_SETTING_TYPE? imethod_1(uint uint_0)
	{
		GClass87.Class373 @class = new GClass87.Class373();
		@class.uint_0 = uint_0;
		GClass75 gclass = this.list_0.FirstOrDefault(new Func<GClass75, bool>(@class.method_0));
		if (gclass != null)
		{
			return new NVDRS_SETTING_TYPE?(gclass.nvdrs_SETTING_TYPE_0);
		}
		return null;
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00048568 File Offset: 0x00046768
	public string imethod_2(uint uint_0)
	{
		GClass87.Class372 @class = new GClass87.Class372();
		@class.uint_0 = uint_0;
		GClass75 gclass = this.list_0.FirstOrDefault(new Func<GClass75, bool>(@class.method_0));
		if (gclass != null)
		{
			return string.Format("0x{0:X8} ({1} Profiles)", @class.uint_0, gclass.uint_1);
		}
		return null;
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x000485C0 File Offset: 0x000467C0
	public string imethod_3(uint uint_0)
	{
		return null;
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x000485C4 File Offset: 0x000467C4
	public uint? imethod_4(uint uint_0)
	{
		return null;
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x000485DC File Offset: 0x000467DC
	public string imethod_5(uint uint_0)
	{
		return null;
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x000485E0 File Offset: 0x000467E0
	public List<GClass58<string>> imethod_7(uint uint_0)
	{
		GClass87.Class369 @class = new GClass87.Class369();
		@class.uint_0 = uint_0;
		@class.gclass87_0 = this;
		GClass75 gclass = this.list_0.FirstOrDefault(new Func<GClass75, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.list_0.Select(new Func<GClass90, GClass58<string>>(@class.method_1)).ToList<GClass58<string>>();
		}
		return null;
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x0004863C File Offset: 0x0004683C
	public List<GClass58<uint>> imethod_8(uint uint_0)
	{
		GClass87.Class368 @class = new GClass87.Class368();
		@class.uint_0 = uint_0;
		@class.gclass87_0 = this;
		GClass75 gclass = this.list_0.FirstOrDefault(new Func<GClass75, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.list_0.Select(new Func<GClass90, GClass58<uint>>(@class.method_1)).ToList<GClass58<uint>>();
		}
		return null;
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00048698 File Offset: 0x00046898
	public List<uint> imethod_10()
	{
		return this.list_0.Select(new Func<GClass75, uint>(GClass87.Class371.class371_0.method_0)).ToList<uint>();
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x000486CC File Offset: 0x000468CC
	public byte[] imethod_6(uint uint_0)
	{
		return null;
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x000486D0 File Offset: 0x000468D0
	public List<GClass58<byte[]>> imethod_9(uint uint_0)
	{
		GClass87.Class370 @class = new GClass87.Class370();
		@class.uint_0 = uint_0;
		@class.gclass87_0 = this;
		GClass75 gclass = this.list_0.FirstOrDefault(new Func<GClass75, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.list_0.Select(new Func<GClass90, GClass58<byte[]>>(@class.method_1)).ToList<GClass58<byte[]>>();
		}
		return null;
	}

	// Token: 0x04000A7E RID: 2686
	private readonly List<GClass75> list_0;

	// Token: 0x020002F5 RID: 757
	private sealed class Class368
	{
		// Token: 0x06001132 RID: 4402 RVA: 0x00048734 File Offset: 0x00046934
		internal bool method_0(GClass75 gclass75_0)
		{
			return gclass75_0.uint_0.Equals(this.uint_0);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00048748 File Offset: 0x00046948
		internal GClass58<uint> method_1(GClass90 gclass90_0)
		{
			GClass58<uint> gclass = new GClass58<uint>(this.gclass87_0.imethod_0());
			gclass.method_3(gclass90_0.uint_0);
			gclass.imethod_2(string.Format("0x{0:X8} ({1})", gclass90_0.uint_0, gclass90_0.stringBuilder_0));
			return gclass;
		}

		// Token: 0x04000A7F RID: 2687
		public uint uint_0;

		// Token: 0x04000A80 RID: 2688
		public GClass87 gclass87_0;
	}

	// Token: 0x020002F6 RID: 758
	private sealed class Class369
	{
		// Token: 0x06001135 RID: 4405 RVA: 0x00048790 File Offset: 0x00046990
		internal bool method_0(GClass75 gclass75_0)
		{
			return gclass75_0.uint_0.Equals(this.uint_0);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x000487A4 File Offset: 0x000469A4
		internal GClass58<string> method_1(GClass90 gclass90_0)
		{
			GClass58<string> gclass = new GClass58<string>(this.gclass87_0.imethod_0());
			gclass.method_3(gclass90_0.string_0);
			gclass.imethod_2(string.Format("'{0}' ({1})", gclass90_0.string_0.Trim(), gclass90_0.stringBuilder_0));
			return gclass;
		}

		// Token: 0x04000A81 RID: 2689
		public uint uint_0;

		// Token: 0x04000A82 RID: 2690
		public GClass87 gclass87_0;
	}

	// Token: 0x020002F7 RID: 759
	private sealed class Class370
	{
		// Token: 0x06001138 RID: 4408 RVA: 0x000487EC File Offset: 0x000469EC
		internal bool method_0(GClass75 gclass75_0)
		{
			return gclass75_0.uint_0.Equals(this.uint_0);
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00048800 File Offset: 0x00046A00
		internal GClass58<byte[]> method_1(GClass90 gclass90_0)
		{
			GClass58<byte[]> gclass = new GClass58<byte[]>(this.gclass87_0.imethod_0());
			gclass.method_3(gclass90_0.byte_0);
			gclass.imethod_2(string.Format("{0} ({1})", GClass166.smethod_6(gclass90_0.byte_0), gclass90_0.stringBuilder_0));
			return gclass;
		}

		// Token: 0x04000A83 RID: 2691
		public uint uint_0;

		// Token: 0x04000A84 RID: 2692
		public GClass87 gclass87_0;
	}

	// Token: 0x020002F8 RID: 760
	[Serializable]
	private sealed class Class371
	{
		// Token: 0x0600113C RID: 4412 RVA: 0x00048854 File Offset: 0x00046A54
		internal uint method_0(GClass75 gclass75_0)
		{
			return gclass75_0.uint_0;
		}

		// Token: 0x04000A85 RID: 2693
		public static readonly GClass87.Class371 class371_0 = new GClass87.Class371();

		// Token: 0x04000A86 RID: 2694
		public static Func<GClass75, uint> func_0;
	}

	// Token: 0x020002F9 RID: 761
	private sealed class Class372
	{
		// Token: 0x0600113E RID: 4414 RVA: 0x00048864 File Offset: 0x00046A64
		internal bool method_0(GClass75 gclass75_0)
		{
			return gclass75_0.uint_0.Equals(this.uint_0);
		}

		// Token: 0x04000A87 RID: 2695
		public uint uint_0;
	}

	// Token: 0x020002FA RID: 762
	private sealed class Class373
	{
		// Token: 0x06001140 RID: 4416 RVA: 0x00048880 File Offset: 0x00046A80
		internal bool method_0(GClass75 gclass75_0)
		{
			return gclass75_0.uint_0.Equals(this.uint_0);
		}

		// Token: 0x04000A88 RID: 2696
		public uint uint_0;
	}
}
