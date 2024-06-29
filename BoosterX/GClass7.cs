using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x02000100 RID: 256
public abstract class GClass7
{
	// Token: 0x0600075D RID: 1885 RVA: 0x00023CF0 File Offset: 0x00021EF0
	public GClass7(GClass42 gclass42_1, GClass8 gclass8_1 = null)
	{
		this.gclass42_0 = gclass42_1;
		this.gclass8_0 = gclass8_1;
		this.float_0 = this.method_0();
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00023D14 File Offset: 0x00021F14
	private float method_0()
	{
		float result = 0f;
		uint num = 0U;
		StringBuilder stringBuilder_ = new StringBuilder(64);
		if (GClass202.gdelegate5_0(ref num, stringBuilder_) == GEnum0.NVAPI_OK)
		{
			try
			{
				result = num / 100f;
			}
			catch (object obj)
			{
			}
		}
		return result;
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00023D64 File Offset: 0x00021F64
	protected void method_1(Action<IntPtr> action_0, bool bool_0, bool bool_1)
	{
		GClass74.smethod_0<bool>(new Func<IntPtr, bool>(new GClass7.Class145
		{
			action_0 = action_0
		}.method_0), bool_0, bool_1);
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00023D88 File Offset: 0x00021F88
	protected T method_2<T>(Func<IntPtr, T> func_0, bool bool_0)
	{
		return GClass74.smethod_0<T>(func_0, bool_0, false);
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00023D94 File Offset: 0x00021F94
	protected IntPtr method_3(IntPtr intptr_0, string string_0)
	{
		IntPtr zero = IntPtr.Zero;
		if (string.IsNullOrEmpty(string_0))
		{
			GEnum0 genum = GClass202.gdelegate15_0(intptr_0, ref zero);
			if (zero == IntPtr.Zero)
			{
				throw new GException7("DRS_GetCurrentGlobalProfile", GEnum0.NVAPI_PROFILE_NOT_FOUND);
			}
			if (genum != GEnum0.NVAPI_OK)
			{
				throw new GException7("DRS_GetCurrentGlobalProfile", genum);
			}
		}
		else
		{
			GEnum0 genum2 = GClass202.gdelegate24_0(intptr_0, new StringBuilder(string_0), ref zero);
			if (genum2 == GEnum0.NVAPI_PROFILE_NOT_FOUND)
			{
				return IntPtr.Zero;
			}
			if (genum2 != GEnum0.NVAPI_OK)
			{
				throw new GException7("DRS_FindProfileByName", genum2);
			}
		}
		return zero;
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00023E1C File Offset: 0x0002201C
	protected IntPtr method_4(IntPtr intptr_0, string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException("#=zzr_9nXI=");
		}
		IntPtr zero = IntPtr.Zero;
		GStruct3 gstruct = new GStruct3
		{
			uint_0 = GClass202.uint_6,
			string_0 = string_0
		};
		GEnum0 genum = GClass202.gdelegate13_0(intptr_0, ref gstruct, ref zero);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_CreateProfile", genum);
		}
		return zero;
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00023E80 File Offset: 0x00022080
	protected GStruct3 method_5(IntPtr intptr_0, IntPtr intptr_1)
	{
		GStruct3 result = default(GStruct3);
		result.uint_0 = GClass202.uint_6;
		GEnum0 genum = GClass202.gdelegate17_0(intptr_0, intptr_1, ref result);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_GetProfileInfo", genum);
		}
		return result;
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00023EC0 File Offset: 0x000220C0
	protected void method_6(IntPtr intptr_0, IntPtr intptr_1, GStruct1 gstruct1_0)
	{
		GEnum0 genum = GClass202.smethod_5(intptr_0, intptr_1, ref gstruct1_0);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_SetSetting", genum);
		}
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00023EE8 File Offset: 0x000220E8
	protected void method_7(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, uint uint_1)
	{
		GStruct1 gstruct = new GStruct1
		{
			uint_0 = GClass202.uint_1,
			uint_1 = uint_0,
			nvdrs_SETTING_TYPE_0 = NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE,
			genum1_0 = (GEnum1)0,
			nvdrs_SETTING_UNION_1 = new NVDRS_SETTING_UNION
			{
				dwordValue = uint_1
			}
		};
		GEnum0 genum = GClass202.smethod_5(intptr_0, intptr_1, ref gstruct);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_SetSetting", genum);
		}
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00023F58 File Offset: 0x00022158
	protected void method_8(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, string string_0)
	{
		GStruct1 gstruct = new GStruct1
		{
			uint_0 = GClass202.uint_1,
			uint_1 = uint_0,
			nvdrs_SETTING_TYPE_0 = NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE,
			genum1_0 = (GEnum1)0,
			nvdrs_SETTING_UNION_1 = new NVDRS_SETTING_UNION
			{
				stringValue = string_0
			}
		};
		GEnum0 genum = GClass202.smethod_5(intptr_0, intptr_1, ref gstruct);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_SetSetting", genum);
		}
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x00023FC8 File Offset: 0x000221C8
	protected void method_9(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, byte[] byte_0)
	{
		GStruct1 gstruct = new GStruct1
		{
			uint_0 = GClass202.uint_1,
			uint_1 = uint_0,
			nvdrs_SETTING_TYPE_0 = NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE,
			genum1_0 = (GEnum1)0,
			nvdrs_SETTING_UNION_1 = new NVDRS_SETTING_UNION
			{
				binaryValue = byte_0
			}
		};
		GEnum0 genum = GClass202.smethod_5(intptr_0, intptr_1, ref gstruct);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_SetSetting", genum);
		}
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00024038 File Offset: 0x00022238
	protected GStruct1? method_10(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		GStruct1 value = new GStruct1
		{
			uint_0 = GClass202.uint_1
		};
		GEnum0 genum = GClass202.smethod_6(intptr_0, intptr_1, uint_0, ref value);
		if (genum == GEnum0.NVAPI_SETTING_NOT_FOUND)
		{
			return null;
		}
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_GetSetting", genum);
		}
		if (this.gclass8_0 != null)
		{
			GStruct3 gstruct = this.method_5(intptr_0, intptr_1);
			this.gclass8_0.method_23(gstruct.string_0, ref value);
		}
		return new GStruct1?(value);
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x000240B4 File Offset: 0x000222B4
	protected uint? method_11(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		GStruct1? gstruct = this.method_10(intptr_0, intptr_1, uint_0);
		if (gstruct == null)
		{
			return null;
		}
		return new uint?(gstruct.Value.nvdrs_SETTING_UNION_1.dwordValue);
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x000240F8 File Offset: 0x000222F8
	protected void method_12(IntPtr intptr_0, IntPtr intptr_1, string string_0)
	{
		GStruct7 gstruct = new GStruct7
		{
			uint_0 = GClass202.uint_4,
			string_0 = string_0
		};
		GEnum0 genum = GClass202.gdelegate33_0(intptr_0, intptr_1, ref gstruct);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_CreateApplication", genum);
		}
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00024144 File Offset: 0x00022344
	protected void method_13(IntPtr intptr_0, IntPtr intptr_1, GStruct7 gstruct7_0)
	{
		GEnum0 genum = GClass202.gdelegate4_0(intptr_0, intptr_1, ref gstruct7_0);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_DeleteApplication", genum);
		}
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00024170 File Offset: 0x00022370
	protected List<IntPtr> method_14(IntPtr intptr_0)
	{
		List<IntPtr> list = new List<IntPtr>();
		IntPtr zero = IntPtr.Zero;
		uint num = 0U;
		GEnum0 genum;
		do
		{
			genum = GClass202.gdelegate38_0(intptr_0, num, ref zero);
			if (genum == GEnum0.NVAPI_OK)
			{
				list.Add(zero);
			}
			num += 1U;
		}
		while (genum == GEnum0.NVAPI_OK);
		if (genum != GEnum0.NVAPI_END_ENUMERATION)
		{
			throw new GException7("DRS_EnumProfiles", genum);
		}
		return list;
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x000241C8 File Offset: 0x000223C8
	protected List<GStruct1> method_15(IntPtr intptr_0, IntPtr intptr_1)
	{
		uint num = 512U;
		GStruct1[] array = new GStruct1[512];
		array[0].uint_0 = GClass202.uint_1;
		GEnum0 genum = GClass202.smethod_7(intptr_0, intptr_1, 0U, ref num, ref array);
		if (genum == GEnum0.NVAPI_END_ENUMERATION)
		{
			return new List<GStruct1>();
		}
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_EnumSettings", genum);
		}
		if (this.gclass8_0 != null)
		{
			GStruct3 gstruct = this.method_5(intptr_0, intptr_1);
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				this.gclass8_0.method_23(gstruct.string_0, ref array[num2]);
				num2++;
			}
		}
		return array.ToList<GStruct1>();
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00024270 File Offset: 0x00022470
	protected List<GStruct7> method_16(IntPtr intptr_0, IntPtr intptr_1)
	{
		uint num = 512U;
		GStruct7[] array = new GStruct7[512];
		array[0].uint_0 = GClass202.uint_4;
		GEnum0 genum = GClass202.smethod_4<GStruct7>(intptr_0, intptr_1, 0U, ref num, ref array);
		if (genum == GEnum0.NVAPI_END_ENUMERATION)
		{
			return new List<GStruct7>();
		}
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_EnumApplications", genum);
		}
		return array.ToList<GStruct7>();
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x000242CC File Offset: 0x000224CC
	protected void method_17(IntPtr intptr_0)
	{
		GEnum0 genum = GClass202.gdelegate27_0(intptr_0);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_SaveSettings", genum);
		}
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x000242F4 File Offset: 0x000224F4
	protected void method_18(IntPtr intptr_0, string string_0)
	{
		GEnum0 genum = GClass202.gdelegate41_0(intptr_0, new StringBuilder(string_0));
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_LoadSettingsFromFileEx", genum);
		}
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00024324 File Offset: 0x00022524
	protected void method_19(IntPtr intptr_0, string string_0)
	{
		GEnum0 genum = GClass202.gdelegate20_0(intptr_0, new StringBuilder(string_0));
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_SaveSettingsToFileEx", genum);
		}
	}

	// Token: 0x040003D7 RID: 983
	protected GClass42 gclass42_0;

	// Token: 0x040003D8 RID: 984
	protected GClass8 gclass8_0;

	// Token: 0x040003D9 RID: 985
	public readonly float float_0;

	// Token: 0x02000101 RID: 257
	private sealed class Class145
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x0002435C File Offset: 0x0002255C
		internal bool method_0(IntPtr intptr_0)
		{
			this.action_0(intptr_0);
			return true;
		}

		// Token: 0x040003DA RID: 986
		public Action<IntPtr> action_0;
	}
}
