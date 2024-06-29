using System;
using NvidiaX.NVIDIA.Classes;
using NvidiaX.NVIDIA.Enums;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x0200050E RID: 1294
public sealed class GClass152
{
	// Token: 0x06001C59 RID: 7257 RVA: 0x00074004 File Offset: 0x00072204
	public static bool smethod_0(GStruct1 gstruct1_0, ImportExportProfileSetting importExportProfileSetting_0)
	{
		ImportExportProfileSetting importExportProfileSetting = GClass152.smethod_1(gstruct1_0);
		return importExportProfileSetting_0.SettingValue.Equals(importExportProfileSetting.SettingValue);
	}

	// Token: 0x06001C5A RID: 7258 RVA: 0x0007402C File Offset: 0x0007222C
	public static ImportExportProfileSetting smethod_1(GStruct1 gstruct1_0)
	{
		return new ImportExportProfileSetting
		{
			SettingId = gstruct1_0.uint_1,
			SettingNameInfo = gstruct1_0.string_0,
			SettingValue = GClass152.smethod_2(gstruct1_0),
			ValueType = GClass152.smethod_3(gstruct1_0.nvdrs_SETTING_TYPE_0)
		};
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x00074068 File Offset: 0x00072268
	private static string smethod_2(GStruct1 gstruct1_0)
	{
		NVDRS_SETTING_UNION nvdrs_SETTING_UNION = gstruct1_0.nvdrs_SETTING_UNION_1;
		if (gstruct1_0.uint_2 == 1U)
		{
			nvdrs_SETTING_UNION = gstruct1_0.nvdrs_SETTING_UNION_0;
		}
		switch (gstruct1_0.nvdrs_SETTING_TYPE_0)
		{
		case NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE:
			return nvdrs_SETTING_UNION.dwordValue.ToString();
		case NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE:
			return Convert.ToBase64String(nvdrs_SETTING_UNION.binaryValue);
		case NVDRS_SETTING_TYPE.NVDRS_STRING_TYPE:
			return nvdrs_SETTING_UNION.ansiStringValue;
		case NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE:
			return nvdrs_SETTING_UNION.stringValue;
		default:
			throw new Exception("invalid setting type");
		}
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x000740E0 File Offset: 0x000722E0
	private static SettingValueType smethod_3(NVDRS_SETTING_TYPE nvdrs_SETTING_TYPE_0)
	{
		switch (nvdrs_SETTING_TYPE_0)
		{
		case NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE:
			return SettingValueType.Binary;
		case NVDRS_SETTING_TYPE.NVDRS_STRING_TYPE:
			return SettingValueType.AnsiString;
		case NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE:
			return SettingValueType.f000097;
		default:
			return SettingValueType.Dword;
		}
	}

	// Token: 0x06001C5D RID: 7261 RVA: 0x00074100 File Offset: 0x00072300
	public static GStruct1 smethod_4(ImportExportProfileSetting importExportProfileSetting_0)
	{
		return new GStruct1
		{
			uint_0 = GClass202.uint_1,
			uint_1 = importExportProfileSetting_0.SettingId,
			nvdrs_SETTING_TYPE_0 = GClass152.smethod_6(importExportProfileSetting_0.ValueType),
			genum1_0 = (GEnum1)0,
			nvdrs_SETTING_UNION_1 = GClass152.smethod_5(importExportProfileSetting_0.ValueType, importExportProfileSetting_0.SettingValue)
		};
	}

	// Token: 0x06001C5E RID: 7262 RVA: 0x00074164 File Offset: 0x00072364
	private static NVDRS_SETTING_UNION smethod_5(SettingValueType settingValueType_0, string string_0)
	{
		NVDRS_SETTING_UNION result = default(NVDRS_SETTING_UNION);
		switch (settingValueType_0)
		{
		case SettingValueType.Dword:
			result.dwordValue = uint.Parse(string_0);
			break;
		case SettingValueType.AnsiString:
			result.ansiStringValue = string_0;
			break;
		case SettingValueType.f000097:
			result.stringValue = string_0;
			break;
		case SettingValueType.Binary:
			result.binaryValue = Convert.FromBase64String(string_0);
			break;
		default:
			throw new Exception("invalid value type");
		}
		return result;
	}

	// Token: 0x06001C5F RID: 7263 RVA: 0x000741CC File Offset: 0x000723CC
	private static NVDRS_SETTING_TYPE smethod_6(SettingValueType settingValueType_0)
	{
		switch (settingValueType_0)
		{
		case SettingValueType.AnsiString:
			return NVDRS_SETTING_TYPE.NVDRS_STRING_TYPE;
		case SettingValueType.f000097:
			return NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE;
		case SettingValueType.Binary:
			return NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE;
		default:
			return NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE;
		}
	}
}
