using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x02000270 RID: 624
public sealed class GClass69
{
	// Token: 0x06000E80 RID: 3712 RVA: 0x0003F4E0 File Offset: 0x0003D6E0
	public NVDRS_SETTING_TYPE? method_0()
	{
		return this.nullable_0;
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x0003F4E8 File Offset: 0x0003D6E8
	public void method_1(NVDRS_SETTING_TYPE? nullable_1)
	{
		this.nullable_0 = nullable_1;
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x0003F4F4 File Offset: 0x0003D6F4
	public string method_2()
	{
		return this.string_0;
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x0003F4FC File Offset: 0x0003D6FC
	public void method_3(string string_4)
	{
		this.string_0 = string_4;
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x0003F508 File Offset: 0x0003D708
	public string method_4()
	{
		return this.string_1;
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x0003F510 File Offset: 0x0003D710
	public void method_5(string string_4)
	{
		this.string_1 = string_4;
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x0003F51C File Offset: 0x0003D71C
	public string method_6()
	{
		return this.string_2;
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x0003F524 File Offset: 0x0003D724
	public void method_7(string string_4)
	{
		this.string_2 = string_4;
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x0003F530 File Offset: 0x0003D730
	public uint method_8()
	{
		return this.uint_0;
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x0003F538 File Offset: 0x0003D738
	public void method_9(uint uint_1)
	{
		this.uint_0 = uint_1;
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x0003F544 File Offset: 0x0003D744
	public byte[] method_10()
	{
		return this.byte_0;
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x0003F54C File Offset: 0x0003D74C
	public void method_11(byte[] byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x0003F558 File Offset: 0x0003D758
	public bool method_12()
	{
		return this.bool_0;
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x0003F560 File Offset: 0x0003D760
	public void method_13(bool bool_2)
	{
		this.bool_0 = bool_2;
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x0003F56C File Offset: 0x0003D76C
	public bool method_14()
	{
		return this.bool_1;
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x0003F574 File Offset: 0x0003D774
	public void method_15(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0003F580 File Offset: 0x0003D780
	// (set) Token: 0x06000E91 RID: 3729 RVA: 0x0003F588 File Offset: 0x0003D788
	public string Description
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

	// Token: 0x06000E92 RID: 3730 RVA: 0x0003F594 File Offset: 0x0003D794
	public List<GClass58<string>> method_16()
	{
		return this.list_0;
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x0003F59C File Offset: 0x0003D79C
	public void method_17(List<GClass58<string>> list_3)
	{
		this.list_0 = list_3;
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x0003F5A8 File Offset: 0x0003D7A8
	public List<GClass58<uint>> method_18()
	{
		return this.list_1;
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x0003F5B0 File Offset: 0x0003D7B0
	public void method_19(List<GClass58<uint>> list_3)
	{
		this.list_1 = list_3;
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x0003F5BC File Offset: 0x0003D7BC
	public List<GClass58<byte[]>> method_20()
	{
		return this.list_2;
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x0003F5C4 File Offset: 0x0003D7C4
	public void method_21(List<GClass58<byte[]>> list_3)
	{
		this.list_2 = list_3;
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0003F5D0 File Offset: 0x0003D7D0
	public IEnumerable<GInterface5> Values
	{
		get
		{
			NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = this.method_0();
			if (nvdrs_SETTING_TYPE != null)
			{
				switch (nvdrs_SETTING_TYPE.GetValueOrDefault())
				{
				case NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE:
					return this.method_18();
				case NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE:
					return this.method_20();
				case NVDRS_SETTING_TYPE.NVDRS_STRING_TYPE:
					return this.method_16();
				case NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE:
					return this.method_16();
				}
			}
			return null;
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06000E99 RID: 3737 RVA: 0x0003F634 File Offset: 0x0003D834
	public GInterface5 DefaultValue
	{
		get
		{
			GClass69.Class317 @class = new GClass69.Class317();
			NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = this.method_0();
			object object_;
			if (nvdrs_SETTING_TYPE != null)
			{
				switch (nvdrs_SETTING_TYPE.GetValueOrDefault())
				{
				case NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE:
					object_ = this.method_8();
					goto IL_61;
				case NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE:
					object_ = this.method_10();
					goto IL_61;
				case NVDRS_SETTING_TYPE.NVDRS_STRING_TYPE:
					object_ = this.method_6();
					goto IL_61;
				case NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE:
					object_ = this.method_6();
					goto IL_61;
				}
			}
			object_ = null;
			IL_61:
			@class.object_0 = object_;
			return this.Values.FirstOrDefault(new Func<GInterface5, bool>(@class.method_0));
		}
	}

	// Token: 0x040008EA RID: 2282
	private NVDRS_SETTING_TYPE? nullable_0;

	// Token: 0x040008EB RID: 2283
	private string string_0;

	// Token: 0x040008EC RID: 2284
	private string string_1;

	// Token: 0x040008ED RID: 2285
	private string string_2;

	// Token: 0x040008EE RID: 2286
	private uint uint_0;

	// Token: 0x040008EF RID: 2287
	private byte[] byte_0;

	// Token: 0x040008F0 RID: 2288
	private bool bool_0;

	// Token: 0x040008F1 RID: 2289
	private bool bool_1;

	// Token: 0x040008F2 RID: 2290
	private string string_3;

	// Token: 0x040008F3 RID: 2291
	private List<GClass58<string>> list_0;

	// Token: 0x040008F4 RID: 2292
	private List<GClass58<uint>> list_1;

	// Token: 0x040008F5 RID: 2293
	private List<GClass58<byte[]>> list_2;

	// Token: 0x02000271 RID: 625
	private sealed class Class317
	{
		// Token: 0x06000E9B RID: 3739 RVA: 0x0003F6C8 File Offset: 0x0003D8C8
		internal bool method_0(GInterface5 ginterface5_0)
		{
			return ginterface5_0.imethod_0().Equals(this.object_0);
		}

		// Token: 0x040008F6 RID: 2294
		public object object_0;
	}
}
