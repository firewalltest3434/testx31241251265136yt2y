using System;
using System.Collections.Generic;
using System.Linq;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x020002A2 RID: 674
public sealed class GClass75
{
	// Token: 0x06000F7B RID: 3963 RVA: 0x000430E4 File Offset: 0x000412E4
	public GClass75()
	{
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x000430F8 File Offset: 0x000412F8
	public GClass75(uint uint_2, NVDRS_SETTING_TYPE nvdrs_SETTING_TYPE_1)
	{
		this.uint_0 = uint_2;
		this.nvdrs_SETTING_TYPE_0 = nvdrs_SETTING_TYPE_1;
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x0004311C File Offset: 0x0004131C
	public void method_0(uint uint_2, string string_0)
	{
		GClass75.Class339 @class = new GClass75.Class339();
		@class.uint_0 = uint_2;
		GClass90 gclass = this.list_0.FirstOrDefault(new Func<GClass90, bool>(@class.method_0));
		if (gclass == null)
		{
			this.list_0.Add(new GClass90(@class.uint_0, string_0));
		}
		else
		{
			gclass.stringBuilder_0.Append(", " + string_0);
			gclass.uint_1 += 1U;
		}
		this.uint_1 += 1U;
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x000431A0 File Offset: 0x000413A0
	public void method_1(string string_0, string string_1)
	{
		GClass75.Class338 @class = new GClass75.Class338();
		@class.string_0 = string_0;
		GClass90 gclass = this.list_0.FirstOrDefault(new Func<GClass90, bool>(@class.method_0));
		if (gclass == null)
		{
			this.list_0.Add(new GClass90(@class.string_0, string_1));
		}
		else
		{
			gclass.stringBuilder_0.Append(", " + string_1);
			gclass.uint_1 += 1U;
		}
		this.uint_1 += 1U;
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00043224 File Offset: 0x00041424
	public void method_2(byte[] byte_0, string string_0)
	{
		GClass75.Class337 @class = new GClass75.Class337();
		@class.byte_0 = byte_0;
		GClass90 gclass = this.list_0.FirstOrDefault(new Func<GClass90, bool>(@class.method_0));
		if (gclass == null)
		{
			this.list_0.Add(new GClass90(@class.byte_0, string_0));
		}
		else
		{
			gclass.stringBuilder_0.Append(", " + string_0);
			gclass.uint_1 += 1U;
		}
		this.uint_1 += 1U;
	}

	// Token: 0x0400097D RID: 2429
	public uint uint_0;

	// Token: 0x0400097E RID: 2430
	public List<GClass90> list_0 = new List<GClass90>();

	// Token: 0x0400097F RID: 2431
	public uint uint_1;

	// Token: 0x04000980 RID: 2432
	public NVDRS_SETTING_TYPE nvdrs_SETTING_TYPE_0;

	// Token: 0x020002A3 RID: 675
	private sealed class Class337
	{
		// Token: 0x06000F81 RID: 3969 RVA: 0x000432B0 File Offset: 0x000414B0
		internal bool method_0(GClass90 gclass90_0)
		{
			return Class333.smethod_1(gclass90_0.byte_0, this.byte_0);
		}

		// Token: 0x04000981 RID: 2433
		public byte[] byte_0;
	}

	// Token: 0x020002A4 RID: 676
	private sealed class Class338
	{
		// Token: 0x06000F83 RID: 3971 RVA: 0x000432CC File Offset: 0x000414CC
		internal bool method_0(GClass90 gclass90_0)
		{
			return gclass90_0.string_0 == this.string_0;
		}

		// Token: 0x04000982 RID: 2434
		public string string_0;
	}

	// Token: 0x020002A5 RID: 677
	private sealed class Class339
	{
		// Token: 0x06000F85 RID: 3973 RVA: 0x000432E8 File Offset: 0x000414E8
		internal bool method_0(GClass90 gclass90_0)
		{
			return gclass90_0.uint_0 == this.uint_0;
		}

		// Token: 0x04000983 RID: 2435
		public uint uint_0;
	}
}
