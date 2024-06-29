using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x02000631 RID: 1585
public sealed class GClass202
{
	// Token: 0x06002222 RID: 8738 RVA: 0x0008AA20 File Offset: 0x00088C20
	private GClass202()
	{
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x0008AA28 File Offset: 0x00088C28
	static GClass202()
	{
		IntPtr intPtr = GClass202.LoadLibrary("nvapi64.dll");
		if (intPtr != IntPtr.Zero)
		{
			GClass202.delegate37_0 = GClass202.smethod_3<GClass202.Delegate37>(intPtr, "nvapi_QueryInterface");
			if (GClass202.delegate37_0 != null)
			{
				GClass202.smethod_2<GClass202.GDelegate36>(22079528U, out GClass202.gdelegate36_0, null);
				if (GClass202.gdelegate36_0() == GEnum0.NVAPI_OK)
				{
					GClass202.smethod_2<GClass202.GDelegate34>(22079528U, out GClass202.gdelegate34_0, null);
					GClass202.smethod_2<GClass202.GDelegate19>(3526090110U, out GClass202.gdelegate19_0, null);
					GClass202.smethod_2<GClass202.GDelegate25>(1814889612U, out GClass202.gdelegate25_0, null);
					GClass202.smethod_2<GClass202.GDelegate16>(17121189U, out GClass202.gdelegate16_0, null);
					GClass202.smethod_2<GClass202.GDelegate5>(690399917U, out GClass202.gdelegate5_0, null);
					GClass202.smethod_2<GClass202.GDelegate21>(110417198U, out GClass202.gdelegate21_0, null);
					GClass202.smethod_2<GClass202.GDelegate39>(3671707640U, out GClass202.gdelegate39_0, null);
					GClass202.smethod_2<GClass202.GDelegate30>(928890219U, out GClass202.gdelegate30_0, null);
					GClass202.smethod_2<GClass202.GDelegate27>(4240211476U, out GClass202.gdelegate27_0, null);
					GClass202.smethod_2<GClass202.GDelegate29>(3555584137U, out GClass202.gdelegate29_0, null);
					GClass202.smethod_2<GClass202.GDelegate31>(736255480U, out GClass202.gdelegate31_0, null);
					GClass202.smethod_2<GClass202.GDelegate41>(3325822043U, out GClass202.gdelegate41_0, null);
					GClass202.smethod_2<GClass202.GDelegate20>(308773262U, out GClass202.gdelegate20_0, null);
					GClass202.smethod_2<GClass202.GDelegate13>(3424084072U, out GClass202.gdelegate13_0, null);
					GClass202.smethod_2<GClass202.GDelegate18>(386478598U, out GClass202.gdelegate18_0, null);
					GClass202.smethod_2<GClass202.GDelegate40>(478791135U, out GClass202.gdelegate40_0, null);
					GClass202.smethod_2<GClass202.GDelegate15>(1635516319U, out GClass202.gdelegate15_0, null);
					GClass202.smethod_2<GClass202.GDelegate17>(1640853462U, out GClass202.gdelegate17_0, null);
					GClass202.smethod_2<GClass202.GDelegate22>(380359593U, out GClass202.gdelegate22_0, null);
					GClass202.smethod_2<GClass202.GDelegate24>(2118818315U, out GClass202.gdelegate24_0, null);
					GClass202.smethod_2<GClass202.GDelegate38>(3157728992U, out GClass202.gdelegate38_0, null);
					GClass202.smethod_2<GClass202.GDelegate37>(497962940U, out GClass202.gdelegate37_0, null);
					GClass202.smethod_2<GClass202.GDelegate33>(1128770014U, out GClass202.gdelegate33_0, null);
					GClass202.smethod_2<GClass202.GDelegate4>(3320481185U, out GClass202.gdelegate4_0, null);
					GClass202.smethod_2<GClass202.GDelegate11>(745098182U, out GClass202.gdelegate11_0, null);
					GClass202.smethod_2<GClass202.GDelegate28>(3978267753U, out GClass202.gdelegate28_0, null);
					GClass202.smethod_2<GClass202.Delegate36>(2141329210U, out GClass202.delegate36_0, null);
					GClass202.smethod_2<GClass202.GDelegate12>(4008011442U, out GClass202.gdelegate12_0, null);
					GClass202.smethod_2<GClass202.GDelegate9>(2318202357U, out GClass202.gdelegate9_0, new uint?(1467863554U));
					GClass202.smethod_2<GClass202.GDelegate23>(3935914381U, out GClass202.gdelegate23_0, new uint?(1941930808U));
					GClass202.smethod_2<GClass202.Delegate35>(3486947390U, out GClass202.delegate35_0, new uint?(2922396122U));
					GClass202.smethod_2<GClass202.GDelegate7>(3856550117U, out GClass202.gdelegate7_0, new uint?(4028653898U));
					GClass202.smethod_2<GClass202.Delegate34>(784572304U, out GClass202.delegate34_0, null);
					GClass202.smethod_2<GClass202.GDelegate14>(3413313997U, out GClass202.gdelegate14_0, null);
					GClass202.smethod_2<GClass202.GDelegate32>(514930577U, out GClass202.gdelegate32_0, new uint?(3592207982U));
					GClass202.smethod_2<GClass202.GDelegate6>(3524078047U, out GClass202.gdelegate6_0, new uint?(3835847522U));
					GClass202.smethod_2<GClass202.GDelegate8>(1495773332U, out GClass202.gdelegate8_0, null);
					GClass202.smethod_2<GClass202.GDelegate26>(4200554804U, out GClass202.gdelegate26_0, null);
					GClass202.smethod_2<GClass202.GDelegate35>(2111156833U, out GClass202.gdelegate35_0, new uint?(1408251934U));
					GClass202.smethod_2<GClass202.GDelegate10>(3666110112U, out GClass202.gdelegate10_0, null);
				}
			}
		}
	}

	// Token: 0x06002224 RID: 8740
	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string string_0);

	// Token: 0x06002225 RID: 8741
	[DllImport("kernel32.dll")]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	// Token: 0x06002226 RID: 8742 RVA: 0x0008AEA4 File Offset: 0x000890A4
	private static uint smethod_0<T>(int int_0)
	{
		return (uint)(Marshal.SizeOf(typeof(T)) | int_0 << 16);
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x0008AEBC File Offset: 0x000890BC
	private static string smethod_1()
	{
		if (IntPtr.Size == 4)
		{
			return "nvapi.dll";
		}
		return "nvapi64.dll";
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x0008AED4 File Offset: 0x000890D4
	private static void smethod_2<T>(uint uint_7, out T gparam_0, uint? nullable_0) where T : class
	{
		IntPtr intPtr = GClass202.delegate37_0(uint_7);
		if (intPtr != IntPtr.Zero)
		{
			gparam_0 = (Marshal.GetDelegateForFunctionPointer(intPtr, typeof(T)) as T);
			return;
		}
		if (nullable_0 != null)
		{
			GClass202.smethod_2<T>(nullable_0.Value, out gparam_0, null);
			return;
		}
		gparam_0 = default(T);
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x0008AF44 File Offset: 0x00089144
	private static T smethod_3<T>(IntPtr intptr_0, string string_0)
	{
		T result = default(T);
		IntPtr procAddress = GClass202.GetProcAddress(intptr_0, string_0);
		if (procAddress != IntPtr.Zero)
		{
			result = (T)((object)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(T)));
		}
		return result;
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x0008AF88 File Offset: 0x00089188
	public static GEnum0 smethod_4<TDrsAppVersion>(IntPtr intptr_0, IntPtr intptr_1, uint uint_7, ref uint uint_8, ref TDrsAppVersion[] gparam_0)
	{
		IntPtr intPtr;
		GClass13.smethod_2<TDrsAppVersion>(gparam_0, out intPtr);
		GEnum0 result;
		try
		{
			result = GClass202.delegate36_0(intptr_0, intptr_1, uint_7, ref uint_8, intPtr);
			gparam_0 = GClass13.smethod_1<TDrsAppVersion>(intPtr, (int)uint_8);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return result;
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x0008AFD4 File Offset: 0x000891D4
	public static GEnum0 smethod_5(IntPtr intptr_0, IntPtr intptr_1, ref GStruct1 gstruct1_0)
	{
		return GClass202.gdelegate9_0(intptr_0, intptr_1, ref gstruct1_0, 0U, 0U);
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x0008AFE8 File Offset: 0x000891E8
	public static GEnum0 smethod_6(IntPtr intptr_0, IntPtr intptr_1, uint uint_7, ref GStruct1 gstruct1_0)
	{
		uint num = 0U;
		return GClass202.gdelegate23_0(intptr_0, intptr_1, uint_7, ref gstruct1_0, ref num);
	}

	// Token: 0x0600222D RID: 8749 RVA: 0x0008B008 File Offset: 0x00089208
	public static GEnum0 smethod_7(IntPtr intptr_0, IntPtr intptr_1, uint uint_7, ref uint uint_8, ref GStruct1[] gstruct1_0)
	{
		IntPtr intPtr;
		GClass13.smethod_2<GStruct1>(gstruct1_0, out intPtr);
		GEnum0 result;
		try
		{
			result = GClass202.delegate35_0(intptr_0, intptr_1, uint_7, ref uint_8, intPtr);
			gstruct1_0 = GClass13.smethod_1<GStruct1>(intPtr, (int)uint_8);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return result;
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x0008B054 File Offset: 0x00089254
	public static GEnum0 smethod_8(out List<uint> list_0, uint uint_7)
	{
		uint[] array = new uint[uint_7];
		IntPtr zero = IntPtr.Zero;
		GClass13.smethod_2<uint>(array, out zero);
		GEnum0 result;
		try
		{
			result = GClass202.gdelegate7_0(zero, ref uint_7);
			array = GClass13.smethod_1<uint>(zero, (int)uint_7);
			list_0 = array.ToList<uint>();
		}
		finally
		{
			Marshal.FreeHGlobal(zero);
		}
		return result;
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x0008B0B0 File Offset: 0x000892B0
	public static GEnum0 smethod_9(uint uint_7, ref uint uint_8, ref NVDRS_SETTING_VALUES nvdrs_SETTING_VALUES_0)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(NVDRS_SETTING_VALUES)));
		GEnum0 result;
		try
		{
			nvdrs_SETTING_VALUES_0.settingValues = new NVDRS_SETTING_UNION[100];
			Marshal.StructureToPtr<NVDRS_SETTING_VALUES>(nvdrs_SETTING_VALUES_0, intPtr, true);
			result = GClass202.delegate34_0(uint_7, ref uint_8, intPtr);
			nvdrs_SETTING_VALUES_0 = (NVDRS_SETTING_VALUES)Marshal.PtrToStructure(intPtr, typeof(NVDRS_SETTING_VALUES));
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return result;
	}

	// Token: 0x040017A5 RID: 6053
	public static uint uint_0 = GClass202.smethod_0<NVDRS_SETTING_VALUES>(1);

	// Token: 0x040017A6 RID: 6054
	public static uint uint_1 = GClass202.smethod_0<GStruct1>(1);

	// Token: 0x040017A7 RID: 6055
	public static uint uint_2 = GClass202.smethod_0<GStruct8>(1);

	// Token: 0x040017A8 RID: 6056
	public static uint uint_3 = GClass202.smethod_0<GStruct6>(2);

	// Token: 0x040017A9 RID: 6057
	public static uint uint_4 = GClass202.smethod_0<GStruct7>(3);

	// Token: 0x040017AA RID: 6058
	public static uint uint_5 = GClass202.uint_4;

	// Token: 0x040017AB RID: 6059
	public static uint uint_6 = GClass202.smethod_0<GStruct3>(1);

	// Token: 0x040017AC RID: 6060
	private static readonly GClass202.Delegate37 delegate37_0;

	// Token: 0x040017AD RID: 6061
	public static readonly GClass202.GDelegate36 gdelegate36_0;

	// Token: 0x040017AE RID: 6062
	public static readonly GClass202.GDelegate34 gdelegate34_0;

	// Token: 0x040017AF RID: 6063
	public static readonly GClass202.GDelegate19 gdelegate19_0;

	// Token: 0x040017B0 RID: 6064
	public static readonly GClass202.GDelegate25 gdelegate25_0;

	// Token: 0x040017B1 RID: 6065
	public static readonly GClass202.GDelegate16 gdelegate16_0;

	// Token: 0x040017B2 RID: 6066
	public static readonly GClass202.GDelegate5 gdelegate5_0;

	// Token: 0x040017B3 RID: 6067
	public static readonly GClass202.GDelegate21 gdelegate21_0;

	// Token: 0x040017B4 RID: 6068
	public static readonly GClass202.GDelegate39 gdelegate39_0;

	// Token: 0x040017B5 RID: 6069
	public static readonly GClass202.GDelegate30 gdelegate30_0;

	// Token: 0x040017B6 RID: 6070
	public static readonly GClass202.GDelegate27 gdelegate27_0;

	// Token: 0x040017B7 RID: 6071
	public static readonly GClass202.GDelegate29 gdelegate29_0;

	// Token: 0x040017B8 RID: 6072
	public static readonly GClass202.GDelegate31 gdelegate31_0;

	// Token: 0x040017B9 RID: 6073
	public static readonly GClass202.GDelegate41 gdelegate41_0;

	// Token: 0x040017BA RID: 6074
	public static readonly GClass202.GDelegate20 gdelegate20_0;

	// Token: 0x040017BB RID: 6075
	public static readonly GClass202.GDelegate13 gdelegate13_0;

	// Token: 0x040017BC RID: 6076
	public static readonly GClass202.GDelegate18 gdelegate18_0;

	// Token: 0x040017BD RID: 6077
	public static readonly GClass202.GDelegate40 gdelegate40_0;

	// Token: 0x040017BE RID: 6078
	public static readonly GClass202.GDelegate15 gdelegate15_0;

	// Token: 0x040017BF RID: 6079
	public static readonly GClass202.GDelegate17 gdelegate17_0;

	// Token: 0x040017C0 RID: 6080
	public static readonly GClass202.GDelegate22 gdelegate22_0;

	// Token: 0x040017C1 RID: 6081
	public static readonly GClass202.GDelegate24 gdelegate24_0;

	// Token: 0x040017C2 RID: 6082
	public static readonly GClass202.GDelegate38 gdelegate38_0;

	// Token: 0x040017C3 RID: 6083
	public static readonly GClass202.GDelegate37 gdelegate37_0;

	// Token: 0x040017C4 RID: 6084
	public static readonly GClass202.GDelegate33 gdelegate33_0;

	// Token: 0x040017C5 RID: 6085
	public static readonly GClass202.GDelegate4 gdelegate4_0;

	// Token: 0x040017C6 RID: 6086
	public static readonly GClass202.GDelegate11 gdelegate11_0;

	// Token: 0x040017C7 RID: 6087
	public static readonly GClass202.GDelegate28 gdelegate28_0;

	// Token: 0x040017C8 RID: 6088
	private static readonly GClass202.Delegate36 delegate36_0;

	// Token: 0x040017C9 RID: 6089
	public static readonly GClass202.GDelegate12 gdelegate12_0;

	// Token: 0x040017CA RID: 6090
	private static readonly GClass202.GDelegate9 gdelegate9_0;

	// Token: 0x040017CB RID: 6091
	private static readonly GClass202.GDelegate23 gdelegate23_0;

	// Token: 0x040017CC RID: 6092
	private static readonly GClass202.Delegate35 delegate35_0;

	// Token: 0x040017CD RID: 6093
	public static readonly GClass202.GDelegate7 gdelegate7_0;

	// Token: 0x040017CE RID: 6094
	private static readonly GClass202.Delegate34 delegate34_0;

	// Token: 0x040017CF RID: 6095
	public static readonly GClass202.GDelegate14 gdelegate14_0;

	// Token: 0x040017D0 RID: 6096
	public static readonly GClass202.GDelegate32 gdelegate32_0;

	// Token: 0x040017D1 RID: 6097
	public static readonly GClass202.GDelegate6 gdelegate6_0;

	// Token: 0x040017D2 RID: 6098
	public static readonly GClass202.GDelegate8 gdelegate8_0;

	// Token: 0x040017D3 RID: 6099
	public static readonly GClass202.GDelegate26 gdelegate26_0;

	// Token: 0x040017D4 RID: 6100
	public static readonly GClass202.GDelegate35 gdelegate35_0;

	// Token: 0x040017D5 RID: 6101
	public static readonly GClass202.GDelegate10 gdelegate10_0;

	// Token: 0x02000632 RID: 1586
	// (Invoke) Token: 0x06002231 RID: 8753
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate4(IntPtr intptr_0, IntPtr intptr_1, ref GStruct7 gstruct7_0);

	// Token: 0x02000633 RID: 1587
	// (Invoke) Token: 0x06002235 RID: 8757
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate5(ref uint uint_0, [MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0);

	// Token: 0x02000634 RID: 1588
	// (Invoke) Token: 0x06002239 RID: 8761
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate6(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

	// Token: 0x02000635 RID: 1589
	// (Invoke) Token: 0x0600223D RID: 8765
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate7(IntPtr intptr_0, ref uint uint_0);

	// Token: 0x02000636 RID: 1590
	// (Invoke) Token: 0x06002241 RID: 8769
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate8(IntPtr intptr_0);

	// Token: 0x02000637 RID: 1591
	// (Invoke) Token: 0x06002245 RID: 8773
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate9(IntPtr intptr_0, IntPtr intptr_1, ref GStruct1 gstruct1_0, uint uint_0, uint uint_1);

	// Token: 0x02000638 RID: 1592
	// (Invoke) Token: 0x06002249 RID: 8777
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate10(IntPtr intptr_0, ref IntPtr intptr_1);

	// Token: 0x02000639 RID: 1593
	// (Invoke) Token: 0x0600224D RID: 8781
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate GEnum0 Delegate34(uint uint_0, ref uint uint_1, IntPtr intptr_0);

	// Token: 0x0200063A RID: 1594
	// (Invoke) Token: 0x06002251 RID: 8785
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate11(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0);

	// Token: 0x0200063B RID: 1595
	// (Invoke) Token: 0x06002255 RID: 8789
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate12(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref IntPtr intptr_1, ref GStruct7 gstruct7_0);

	// Token: 0x0200063C RID: 1596
	// (Invoke) Token: 0x06002259 RID: 8793
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate13(IntPtr intptr_0, ref GStruct3 gstruct3_0, ref IntPtr intptr_1);

	// Token: 0x0200063D RID: 1597
	// (Invoke) Token: 0x0600225D RID: 8797
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate14([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref uint uint_0);

	// Token: 0x0200063E RID: 1598
	// (Invoke) Token: 0x06002261 RID: 8801
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate GEnum0 Delegate35(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, ref uint uint_1, IntPtr intptr_2);

	// Token: 0x0200063F RID: 1599
	// (Invoke) Token: 0x06002265 RID: 8805
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate15(IntPtr intptr_0, ref IntPtr intptr_1);

	// Token: 0x02000640 RID: 1600
	// (Invoke) Token: 0x06002269 RID: 8809
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate16([MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0);

	// Token: 0x02000641 RID: 1601
	// (Invoke) Token: 0x0600226D RID: 8813
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate17(IntPtr intptr_0, IntPtr intptr_1, ref GStruct3 gstruct3_0);

	// Token: 0x02000642 RID: 1602
	// (Invoke) Token: 0x06002271 RID: 8817
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate18(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x02000643 RID: 1603
	// (Invoke) Token: 0x06002275 RID: 8821
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate19();

	// Token: 0x02000644 RID: 1604
	// (Invoke) Token: 0x06002279 RID: 8825
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate20(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0);

	// Token: 0x02000645 RID: 1605
	// (Invoke) Token: 0x0600227D RID: 8829
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate21(ref IntPtr intptr_0);

	// Token: 0x02000646 RID: 1606
	// (Invoke) Token: 0x06002281 RID: 8833
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate22(IntPtr intptr_0, IntPtr intptr_1, ref GStruct3 gstruct3_0);

	// Token: 0x02000647 RID: 1607
	// (Invoke) Token: 0x06002285 RID: 8837
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate23(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, ref GStruct1 gstruct1_0, ref uint uint_1);

	// Token: 0x02000648 RID: 1608
	// (Invoke) Token: 0x06002289 RID: 8841
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate GEnum0 Delegate36(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, ref uint uint_1, IntPtr intptr_2);

	// Token: 0x02000649 RID: 1609
	// (Invoke) Token: 0x0600228D RID: 8845
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate24(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref IntPtr intptr_1);

	// Token: 0x0200064A RID: 1610
	// (Invoke) Token: 0x06002291 RID: 8849
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate25(GEnum0 genum0_0, [MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0);

	// Token: 0x0200064B RID: 1611
	// (Invoke) Token: 0x06002295 RID: 8853
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate26(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x0200064C RID: 1612
	// (Invoke) Token: 0x06002299 RID: 8857
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate27(IntPtr intptr_0);

	// Token: 0x0200064D RID: 1613
	// (Invoke) Token: 0x0600229D RID: 8861
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate28(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref GStruct7 gstruct7_0);

	// Token: 0x0200064E RID: 1614
	// (Invoke) Token: 0x060022A1 RID: 8865
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate29(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0);

	// Token: 0x0200064F RID: 1615
	// (Invoke) Token: 0x060022A5 RID: 8869
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate30(IntPtr intptr_0);

	// Token: 0x02000650 RID: 1616
	// (Invoke) Token: 0x060022A9 RID: 8873
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate37(uint uint_0);

	// Token: 0x02000651 RID: 1617
	// (Invoke) Token: 0x060022AD RID: 8877
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate31(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0);

	// Token: 0x02000652 RID: 1618
	// (Invoke) Token: 0x060022B1 RID: 8881
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate32(uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0);

	// Token: 0x02000653 RID: 1619
	// (Invoke) Token: 0x060022B5 RID: 8885
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate33(IntPtr intptr_0, IntPtr intptr_1, ref GStruct7 gstruct7_0);

	// Token: 0x02000654 RID: 1620
	// (Invoke) Token: 0x060022B9 RID: 8889
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate34();

	// Token: 0x02000655 RID: 1621
	// (Invoke) Token: 0x060022BD RID: 8893
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate35(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

	// Token: 0x02000656 RID: 1622
	// (Invoke) Token: 0x060022C1 RID: 8897
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate36();

	// Token: 0x02000657 RID: 1623
	// (Invoke) Token: 0x060022C5 RID: 8901
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate37(IntPtr intptr_0, ref uint uint_0);

	// Token: 0x02000658 RID: 1624
	// (Invoke) Token: 0x060022C9 RID: 8905
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate38(IntPtr intptr_0, uint uint_0, ref IntPtr intptr_1);

	// Token: 0x02000659 RID: 1625
	// (Invoke) Token: 0x060022CD RID: 8909
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate39(IntPtr intptr_0);

	// Token: 0x0200065A RID: 1626
	// (Invoke) Token: 0x060022D1 RID: 8913
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate40(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0);

	// Token: 0x0200065B RID: 1627
	// (Invoke) Token: 0x060022D5 RID: 8917
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GEnum0 GDelegate41(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0);
}
