using System;

// Token: 0x020002A8 RID: 680
internal sealed class Class504 : Class502
{
	// Token: 0x06000F87 RID: 3975 RVA: 0x00043300 File Offset: 0x00041500
	public string method_0()
	{
		return Class502.smethod_0("GMXInstallLocation", "BoosterX");
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00043314 File Offset: 0x00041514
	public void method_1(string string_0)
	{
		Class502.smethod_1("GMXInstallLocation", string_0.ToString(), "BoosterX");
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x0004332C File Offset: 0x0004152C
	public string method_2()
	{
		return Class502.smethod_0("LastLaunchLocation", "BoosterX");
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00043340 File Offset: 0x00041540
	public void method_3(string string_0)
	{
		Class502.smethod_1("LastLaunchLocation", string_0.ToString(), "BoosterX");
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00043358 File Offset: 0x00041558
	public int? method_4()
	{
		return new int?(Convert.ToInt32("10"));
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x0004336C File Offset: 0x0004156C
	public void method_5(int? nullable_0)
	{
		Class502.smethod_1("ILTCount", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x0004338C File Offset: 0x0004158C
	public int? method_6()
	{
		return new int?(Convert.ToInt32(Class502.smethod_0("PxPos", "BoosterX")));
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x000433A8 File Offset: 0x000415A8
	public void method_7(int? nullable_0)
	{
		Class502.smethod_1("PxPos", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x000433C8 File Offset: 0x000415C8
	public int? method_8()
	{
		return new int?(Convert.ToInt32(Class502.smethod_0("PyPos", "BoosterX")));
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x000433E4 File Offset: 0x000415E4
	public void method_9(int? nullable_0)
	{
		Class502.smethod_1("PyPos", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x00043404 File Offset: 0x00041604
	public int? method_10()
	{
		return new int?(Convert.ToInt32("0"));
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x00043418 File Offset: 0x00041618
	public void method_11(int? nullable_0)
	{
		Class502.smethod_1("ILTChoosenArea", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x00043438 File Offset: 0x00041638
	public double? method_12()
	{
		return new double?(Convert.ToDouble("69"));
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x0004344C File Offset: 0x0004164C
	public void method_13(double? nullable_0)
	{
		Class502.smethod_1("Top", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x0004346C File Offset: 0x0004166C
	public double? method_14()
	{
		return new double?(Convert.ToDouble("48"));
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00043480 File Offset: 0x00041680
	public void method_15(double? nullable_0)
	{
		Class502.smethod_1("Left", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x06000F97 RID: 3991 RVA: 0x000434A0 File Offset: 0x000416A0
	// (set) Token: 0x06000F98 RID: 3992 RVA: 0x000434B4 File Offset: 0x000416B4
	public double? Height
	{
		get
		{
			return new double?(Convert.ToDouble("754"));
		}
		set
		{
			Class502.smethod_1("Height", value.ToString(), "BoosterX");
		}
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06000F99 RID: 3993 RVA: 0x000434D4 File Offset: 0x000416D4
	// (set) Token: 0x06000F9A RID: 3994 RVA: 0x000434E8 File Offset: 0x000416E8
	public double? Width
	{
		get
		{
			return new double?(Convert.ToDouble("1072"));
		}
		set
		{
			Class502.smethod_1("Width", value.ToString(), "BoosterX");
		}
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x00043508 File Offset: 0x00041708
	public bool? method_16()
	{
		return Class502.smethod_0("IsMaximized", "BoosterX").smethod_0();
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x00043520 File Offset: 0x00041720
	public void method_17(bool? nullable_0)
	{
		Class502.smethod_1("IsMaximized", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x00043540 File Offset: 0x00041740
	public bool? method_18()
	{
		return Class502.smethod_0("DisableAV1", "BoosterX").smethod_0();
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x00043558 File Offset: 0x00041758
	public void method_19(bool? nullable_0)
	{
		Class502.smethod_1("DisableAV1", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x00043578 File Offset: 0x00041778
	public bool? method_20()
	{
		return Class502.smethod_0("DisableAV2", "BoosterX").smethod_0();
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x00043590 File Offset: 0x00041790
	public void method_21(bool? nullable_0)
	{
		Class502.smethod_1("DisableAV2", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x000435B0 File Offset: 0x000417B0
	public bool? method_22()
	{
		return "False".smethod_0();
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x000435C0 File Offset: 0x000417C0
	public void method_23(bool? nullable_0)
	{
		Class502.smethod_1("IsAIonGEN", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x000435E0 File Offset: 0x000417E0
	public bool? method_24()
	{
		return Class502.smethod_0("SlowPCMode", "BoosterX").smethod_0();
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x000435F8 File Offset: 0x000417F8
	public void method_25(bool? nullable_0)
	{
		Class502.smethod_1("SlowPCMode", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x00043618 File Offset: 0x00041818
	public bool? method_26()
	{
		return "False".smethod_0();
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x00043628 File Offset: 0x00041828
	public void method_27(bool? nullable_0)
	{
		Class502.smethod_1("ShowAffinityPage", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x00043648 File Offset: 0x00041848
	public bool? method_28()
	{
		return "False".smethod_0();
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x00043658 File Offset: 0x00041858
	public void method_29(bool? nullable_0)
	{
		Class502.smethod_1("ShowMetrics", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x00043678 File Offset: 0x00041878
	public bool? method_30()
	{
		return Class502.smethod_0("AutoUpdate", "BoosterX").smethod_0();
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x00043690 File Offset: 0x00041890
	public void method_31(bool? nullable_0)
	{
		Class502.smethod_1("AutoUpdate", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x000436B0 File Offset: 0x000418B0
	public bool? method_32()
	{
		return Class502.smethod_0("DoNotShowILTFirstPage", "BoosterX").smethod_0();
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x000436C8 File Offset: 0x000418C8
	public void method_33(bool? nullable_0)
	{
		Class502.smethod_1("DoNotShowILTFirstPage", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x000436E8 File Offset: 0x000418E8
	public bool? method_34()
	{
		return Class502.smethod_0("DoNotShowStoreXFirstPage", "BoosterX").smethod_0();
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x00043700 File Offset: 0x00041900
	public void method_35(bool? nullable_0)
	{
		Class502.smethod_1("DoNotShowStoreXFirstPage", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x00043720 File Offset: 0x00041920
	public bool? method_36()
	{
		return Class502.smethod_0("ShowRAMMetrics", "BoosterX").smethod_0();
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x00043738 File Offset: 0x00041938
	public void method_37(bool? nullable_0)
	{
		Class502.smethod_1("ShowRAMMetrics", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x00043758 File Offset: 0x00041958
	public bool? method_38()
	{
		return Class502.smethod_0("ShowDISKMetrics", "BoosterX").smethod_0();
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x00043770 File Offset: 0x00041970
	public void method_39(bool? nullable_0)
	{
		Class502.smethod_1("ShowDISKMetrics", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x00043790 File Offset: 0x00041990
	public bool? method_40()
	{
		return Class502.smethod_0("ShowServicesPage", "BoosterX").smethod_0();
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x000437A8 File Offset: 0x000419A8
	public void method_41(bool? nullable_0)
	{
		Class502.smethod_1("ShowServicesPage", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x000437C8 File Offset: 0x000419C8
	public bool? method_42()
	{
		return "True".smethod_0();
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x000437D8 File Offset: 0x000419D8
	public void method_43(bool? nullable_0)
	{
		Class502.smethod_1("ShowDiscordRPC", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x000437F8 File Offset: 0x000419F8
	public bool? method_44()
	{
		return Class502.smethod_0("ShowServicesManagerPage", "BoosterX").smethod_0();
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x00043810 File Offset: 0x00041A10
	public void method_45(bool? nullable_0)
	{
		Class502.smethod_1("ShowServicesManagerPage", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x00043830 File Offset: 0x00041A30
	public bool? method_46()
	{
		return "True".smethod_0();
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x00043840 File Offset: 0x00041A40
	public void method_47(bool? nullable_0)
	{
		Class502.smethod_1("RestoreCreated", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x00043860 File Offset: 0x00041A60
	public bool? method_48()
	{
		return Class502.smethod_0("ShowErrors", "BoosterX").smethod_0();
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x00043878 File Offset: 0x00041A78
	public void method_49(bool? nullable_0)
	{
		Class502.smethod_1("ShowErrors", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x00043898 File Offset: 0x00041A98
	public bool? method_50()
	{
		return Class502.smethod_0("IsNvidiaHardMode", "BoosterX").smethod_0();
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x000438B0 File Offset: 0x00041AB0
	public void method_51(bool? nullable_0)
	{
		Class502.smethod_1("IsNvidiaHardMode", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x000438D0 File Offset: 0x00041AD0
	public bool? method_52()
	{
		return Class502.smethod_0("ShowExperimentalTweaks", "BoosterX").smethod_0();
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x000438E8 File Offset: 0x00041AE8
	public void method_53(bool? nullable_0)
	{
		Class502.smethod_1("ShowExperimentalTweaks", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x00043908 File Offset: 0x00041B08
	public bool? method_54()
	{
		return Class502.smethod_0("ShowHiddenTweaks", "BoosterX").smethod_0();
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x00043920 File Offset: 0x00041B20
	public void method_55(bool? nullable_0)
	{
		Class502.smethod_1("ShowHiddenTweaks", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x00043940 File Offset: 0x00041B40
	public bool? method_56()
	{
		return "True".smethod_0();
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x00043950 File Offset: 0x00041B50
	public void method_57(bool? nullable_0)
	{
		Class502.smethod_1("EULAAccepted", nullable_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FC5 RID: 4037 RVA: 0x00043970 File Offset: 0x00041B70
	public string method_58()
	{
		return Class502.smethod_0("PCoresThreads", "BoosterX");
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x00043984 File Offset: 0x00041B84
	public void method_59(string string_0)
	{
		Class502.smethod_1("PCoresThreads", string_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x0004399C File Offset: 0x00041B9C
	public string method_60()
	{
		return "12";
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x000439A8 File Offset: 0x00041BA8
	public void method_61(string string_0)
	{
		Class502.smethod_1("TotalThreads", string_0.ToString(), "BoosterX");
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x000439C0 File Offset: 0x00041BC0
	// (set) Token: 0x06000FCA RID: 4042 RVA: 0x000439CC File Offset: 0x00041BCC
	public string Key
	{
		get
		{
			return "6NPMPT-YW4IB6-GJMWQK-RXDB5F-7FEQ3P-D8LCB3";
		}
		set
		{
			Class502.smethod_1("Key", value.ToString(), "BoosterX");
		}
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x000439E4 File Offset: 0x00041BE4
	public string method_62()
	{
		return "en-US";
	}

	// Token: 0x06000FCC RID: 4044 RVA: 0x000439F0 File Offset: 0x00041BF0
	public void method_63(string string_0)
	{
		Class502.smethod_1("Language", string_0.ToString(), "BoosterX");
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00043A08 File Offset: 0x00041C08
	// (set) Token: 0x06000FCE RID: 4046 RVA: 0x00043A14 File Offset: 0x00041C14
	public string Guid
	{
		get
		{
			return "35619726-0d91-42d1-8d8c-981c0387b961";
		}
		set
		{
			Class502.smethod_1("Guid", value.ToString(), "BoosterX");
		}
	}

	// Token: 0x06000FCF RID: 4047 RVA: 0x00043A2C File Offset: 0x00041C2C
	public string method_64()
	{
		return "3 009 640";
	}

	// Token: 0x06000FD0 RID: 4048 RVA: 0x00043A38 File Offset: 0x00041C38
	public void method_65(string string_0)
	{
		Class502.smethod_1("LastUsersCount", string_0.ToString(), "BoosterX");
	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x00043A50 File Offset: 0x00041C50
	public string method_66()
	{
		return Class502.smethod_0("NewVersionLink", "BoosterX");
	}

	// Token: 0x06000FD2 RID: 4050 RVA: 0x00043A64 File Offset: 0x00041C64
	public void method_67(string string_0)
	{
		Class502.smethod_1("NewVersionLink", string_0.ToString(), "BoosterX");
	}
}
