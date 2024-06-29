using System;
using System.Collections.Generic;
using System.Text;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x020000E5 RID: 229
public sealed class GClass5 : GInterface17
{
	// Token: 0x060006A8 RID: 1704 RVA: 0x0002032C File Offset: 0x0001E52C
	public GClass5()
	{
		this.list_0 = this.method_0();
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x0002034C File Offset: 0x0001E54C
	private List<uint> method_0()
	{
		List<uint> result = new List<uint>();
		GEnum0 genum = GClass202.smethod_8(out result, 512U);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_EnumAvailableSettingIds", genum);
		}
		return result;
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x0002037C File Offset: 0x0001E57C
	private GClass69 method_1(uint uint_0)
	{
		NVDRS_SETTING_VALUES nvdrs_SETTING_VALUES = default(NVDRS_SETTING_VALUES);
		nvdrs_SETTING_VALUES.version = GClass202.uint_0;
		uint num = 255U;
		GEnum0 genum = GClass202.smethod_9(uint_0, ref num, ref nvdrs_SETTING_VALUES);
		if (genum == GEnum0.NVAPI_SETTING_NOT_FOUND)
		{
			return null;
		}
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_EnumAvailableSettingValues", genum);
		}
		StringBuilder stringBuilder = new StringBuilder(2048);
		genum = GClass202.gdelegate32_0(uint_0, stringBuilder);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_GetSettingNameFromId", genum);
		}
		string text = stringBuilder.ToString();
		if (string.IsNullOrWhiteSpace(text))
		{
			text = GClass166.smethod_0(uint_0);
		}
		GClass69 gclass = new GClass69();
		gclass.method_1(new NVDRS_SETTING_TYPE?(nvdrs_SETTING_VALUES.settingType));
		gclass.method_5(text);
		GClass69 gclass2 = gclass;
		if (nvdrs_SETTING_VALUES.settingType == NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE)
		{
			gclass2.method_9(nvdrs_SETTING_VALUES.defaultValue.dwordValue);
			gclass2.method_19(new List<GClass58<uint>>());
			int num2 = 0;
			while ((long)num2 < (long)((ulong)nvdrs_SETTING_VALUES.numSettingValues))
			{
				List<GClass58<uint>> list = gclass2.method_18();
				GClass58<uint> gclass3 = new GClass58<uint>(this.imethod_0());
				gclass3.method_3(nvdrs_SETTING_VALUES.settingValues[num2].dwordValue);
				gclass3.imethod_2(GClass166.smethod_0(nvdrs_SETTING_VALUES.settingValues[num2].dwordValue));
				list.Add(gclass3);
				num2++;
			}
		}
		if (nvdrs_SETTING_VALUES.settingType == NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE)
		{
			gclass2.method_7(nvdrs_SETTING_VALUES.defaultValue.stringValue);
			gclass2.method_17(new List<GClass58<string>>());
			int num3 = 0;
			while ((long)num3 < (long)((ulong)nvdrs_SETTING_VALUES.numSettingValues))
			{
				string stringValue = nvdrs_SETTING_VALUES.settingValues[num3].stringValue;
				if (stringValue != null)
				{
					List<GClass58<string>> list2 = gclass2.method_16();
					GClass58<string> gclass4 = new GClass58<string>(this.imethod_0());
					gclass4.method_3(stringValue);
					gclass4.imethod_2(stringValue);
					list2.Add(gclass4);
				}
				num3++;
			}
		}
		if (nvdrs_SETTING_VALUES.settingType == NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE)
		{
			gclass2.method_11(nvdrs_SETTING_VALUES.defaultValue.binaryValue);
			gclass2.method_21(new List<GClass58<byte[]>>());
			int num4 = 0;
			while ((long)num4 < (long)((ulong)nvdrs_SETTING_VALUES.numSettingValues))
			{
				byte[] binaryValue = nvdrs_SETTING_VALUES.settingValues[num4].binaryValue;
				if (binaryValue != null)
				{
					List<GClass58<byte[]>> list3 = gclass2.method_20();
					GClass58<byte[]> gclass5 = new GClass58<byte[]>(this.imethod_0());
					gclass5.method_3(binaryValue);
					gclass5.imethod_2("");
					list3.Add(gclass5);
				}
				num4++;
			}
		}
		return gclass2;
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x000205DC File Offset: 0x0001E7DC
	private GClass69 method_2(uint uint_0)
	{
		if (this.dictionary_0.ContainsKey(uint_0))
		{
			return this.dictionary_0[uint_0];
		}
		GClass69 gclass = this.method_1(uint_0);
		if (gclass != null)
		{
			this.dictionary_0.Add(uint_0, gclass);
			return gclass;
		}
		return null;
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00020620 File Offset: 0x0001E820
	public string imethod_2(uint uint_0)
	{
		GClass69 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_4();
		}
		return null;
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00020640 File Offset: 0x0001E840
	public uint? imethod_4(uint uint_0)
	{
		GClass69 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return new uint?(gclass.method_8());
		}
		return null;
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00020670 File Offset: 0x0001E870
	public string imethod_5(uint uint_0)
	{
		GClass69 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_6();
		}
		return null;
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00020690 File Offset: 0x0001E890
	public List<GClass58<string>> imethod_7(uint uint_0)
	{
		GClass69 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_16();
		}
		return null;
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x000206B0 File Offset: 0x0001E8B0
	public List<GClass58<uint>> imethod_8(uint uint_0)
	{
		GClass69 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_18();
		}
		return null;
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x000206D0 File Offset: 0x0001E8D0
	public List<uint> imethod_10()
	{
		return this.list_0;
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x000206D8 File Offset: 0x0001E8D8
	public NVDRS_SETTING_TYPE? imethod_1(uint uint_0)
	{
		GClass69 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_0();
		}
		return null;
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00020700 File Offset: 0x0001E900
	public string imethod_3(uint uint_0)
	{
		return null;
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00020704 File Offset: 0x0001E904
	public byte[] imethod_6(uint uint_0)
	{
		GClass69 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_10();
		}
		return null;
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00020724 File Offset: 0x0001E924
	public List<GClass58<byte[]>> imethod_9(uint uint_0)
	{
		GClass69 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_20();
		}
		return null;
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00020744 File Offset: 0x0001E944
	public GEnum3 imethod_0()
	{
		return GEnum3.DriverSettings;
	}

	// Token: 0x04000355 RID: 853
	private readonly Dictionary<uint, GClass69> dictionary_0 = new Dictionary<uint, GClass69>();

	// Token: 0x04000356 RID: 854
	private readonly List<uint> list_0;
}
