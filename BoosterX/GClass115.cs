using System;
using System.Collections.Generic;

// Token: 0x020003CA RID: 970
public sealed class GClass115
{
	// Token: 0x06001577 RID: 5495 RVA: 0x00058D08 File Offset: 0x00056F08
	// Note: this type is marked as 'beforefieldinit'.
	static GClass115()
	{
		GClass172.GClass173 gclass = new GClass172.GClass173();
		gclass.Icon = 421;
		gclass.method_1("storeXRequiredServices");
		gclass.Services = new List<string>
		{
			"ClipSVC",
			"SecurityHealthService",
			"wscsvc",
			"mpssvc",
			"BFE",
			"AppReadiness",
			"LicenseManager",
			"AppXSvc",
			"StorSvc",
			"TokenBroker",
			"wlidsvc",
			"camsvc",
			"UserDataSvc",
			"UnistoreSvc"
		};
		GClass115.gclass173_0 = gclass;
		GClass172.GClass173 gclass2 = new GClass172.GClass173();
		gclass2.Icon = 5387;
		gclass2.IsRed = false;
		gclass2.method_1("printAndScannerServices");
		gclass2.Services = new List<string>
		{
			"PrintNotify",
			"Spooler",
			"PrintWorkflowUserSvc",
			"McpManagementService",
			"stisvc",
			"WiaRpc",
			"Fax",
			"TapiSrv"
		};
		GClass115.gclass173_1 = gclass2;
		GClass172.GClass173 gclass3 = new GClass172.GClass173();
		gclass3.Icon = 2389;
		gclass3.IsRed = false;
		gclass3.method_1("hypervServices");
		gclass3.Services = new List<string>
		{
			"HvHost",
			"vmicguestinterface",
			"vmicheartbeat",
			"vmickvpexchange",
			"vmicrdv",
			"vmicshutdown",
			"vmictimesync",
			"vmicvmsession",
			"vmicvss"
		};
		GClass115.gclass173_2 = gclass3;
		GClass172.GClass173 gclass4 = new GClass172.GClass173();
		gclass4.Icon = 7307;
		gclass4.IsRed = true;
		gclass4.method_1("wifiServices");
		gclass4.Services = new List<string>
		{
			"WlanSvc",
			"vwifibus",
			"wdiwifi"
		};
		GClass115.gclass173_3 = gclass4;
		GClass172.GClass173 gclass5 = new GClass172.GClass173();
		gclass5.Icon = 972;
		gclass5.IsRed = false;
		gclass5.method_1("bluetoothServices");
		gclass5.Services = new List<string>
		{
			"BluetoothUserService",
			"BthAvctpSvc",
			"bthserv",
			"BTAGService",
			"NcbService",
			"DeviceAssociationService",
			"DsmSvc"
		};
		GClass115.gclass173_4 = gclass5;
		GClass172.GClass173 gclass6 = new GClass172.GClass173();
		gclass6.Icon = 4329;
		gclass6.IsRed = false;
		gclass6.method_1("encryptServices");
		gclass6.Services = new List<string>
		{
			"BDESVC",
			"EFS"
		};
		GClass115.gclass173_5 = gclass6;
		GClass172.GClass173 gclass7 = new GClass172.GClass173();
		gclass7.Icon = 421;
		gclass7.IsRed = false;
		gclass7.method_1("storeServices");
		gclass7.Services = new List<string>
		{
			"ClipSVC",
			"AppReadiness",
			"LicenseManager",
			"InstallService",
			"PushToInstall",
			"VaultSvc",
			"StorSvc",
			"TokenBroker",
			"wlidsvc",
			"UserDataSvc",
			"UnistoreSvc"
		};
		GClass115.gclass173_6 = gclass7;
		GClass172.GClass173 gclass8 = new GClass172.GClass173();
		gclass8.Icon = 4566;
		gclass8.IsRed = false;
		gclass8.method_1("microsoftAccountServices");
		gclass8.Services = new List<string>
		{
			"VaultSvc",
			"wlidsvc"
		};
		GClass115.gclass173_7 = gclass8;
		GClass172.GClass173 gclass9 = new GClass172.GClass173();
		gclass9.Icon = 2378;
		gclass9.IsRed = false;
		gclass9.method_1("uselessServices");
		gclass9.Services = new List<string>
		{
			"AssignedAccessManagerSvc",
			"ScDeviceEnum",
			"RetailDemo",
			"TrkWks",
			"ALG",
			"AxInstSV",
			"CertPropSvc",
			"DevQueryBroker",
			"FontCache",
			"FontCache3.0.0.0",
			"IpxlatCfgSvc",
			"MapsBroker",
			"perceptionsimulation",
			"spectrum",
			"PhoneSvc",
			"PNRPAutoReg",
			"PNRPsvc",
			"RpcLocator",
			"SCPolicySvc",
			"SmsRouter",
			"SNMPTRAP",
			"TieringEngineService",
			"wcncsvc",
			"WEPHOSTSVC",
			"wercplsupport",
			"WpcMonSvc",
			"WpnService",
			"CDPUserSvc",
			"PimIndexMaintenanceSvc",
			"SEMgrSvc",
			"autotimesvc",
			"KtmRm",
			"SensorDataService",
			"SensorService",
			"SensrSvc",
			"WalletService",
			"Beep",
			"tcpipreg"
		};
		GClass115.gclass173_8 = gclass9;
		GClass172.GClass173 gclass10 = new GClass172.GClass173();
		gclass10.Icon = 7151;
		gclass10.IsRed = false;
		gclass10.method_1("vpnOrProxyServices");
		gclass10.Services = new List<string>
		{
			"SstpSvc",
			"IKEEXT",
			"RasMan",
			"PolicyAgent",
			"WinHttpAutoProxySvc"
		};
		GClass115.gclass173_9 = gclass10;
		GClass172.GClass173 gclass11 = new GClass172.GClass173();
		gclass11.Icon = 7128;
		gclass11.IsRed = false;
		gclass11.method_1("virtualRealityServices");
		gclass11.Services = new List<string>
		{
			"MixedRealityOpenXRSvc",
			"SharedRealitySvc",
			"VacSvc"
		};
		GClass115.gclass173_10 = gclass11;
		GClass172.GClass173 gclass12 = new GClass172.GClass173();
		gclass12.Icon = 4135;
		gclass12.IsRed = false;
		gclass12.method_1("localNetworkServices");
		gclass12.Services = new List<string>
		{
			"LanmanServer",
			"lmhosts",
			"workfolderssvc",
			"fdPHost",
			"AppMgmt",
			"CscService",
			"dot3svc",
			"DsSvc",
			"lltdsvc",
			"MSDTC",
			"p2pimsvc",
			"p2psvc",
			"PeerDistSvc",
			"QWAVE",
			"SEMgrSvc",
			"SharedAccess",
			"SSDPSRV",
			"Browser",
			"upnphost",
			"Wecsvc",
			"WinRM",
			"WMPNetworkSvc",
			"AJRouter",
			"NetBT"
		};
		GClass115.gclass173_11 = gclass12;
		GClass172.GClass173 gclass13 = new GClass172.GClass173();
		gclass13.Icon = 4137;
		gclass13.IsRed = false;
		gclass13.method_1("remoteControlServices");
		gclass13.Services = new List<string>
		{
			"UmRdpService",
			"RasAuto",
			"TermService",
			"EntAppSvc",
			"SessionEnv",
			"DispBrokerDesktopSvc",
			"Eaphost",
			"WebClient"
		};
		GClass115.gclass173_12 = gclass13;
		GClass172.GClass173 gclass14 = new GClass172.GClass173();
		gclass14.Icon = 2005;
		gclass14.IsRed = false;
		gclass14.method_1("diagnosisServices");
		gclass14.Services = new List<string>
		{
			"pla",
			"TroubleshootingSvc",
			"WerSvc",
			"DPS",
			"diagnosticshub.standardcollector.service",
			"CDPSvc",
			"WdiServiceHost",
			"WdiSystemHost",
			"wmiApSrv",
			"SgrmBroker",
			"bam",
			"dam",
			"GpuEnergyDrv"
		};
		GClass115.gclass173_13 = gclass14;
		GClass172.GClass173 gclass15 = new GClass172.GClass173();
		gclass15.Icon = 428;
		gclass15.IsRed = false;
		gclass15.method_1("archiveAndRestoreWindowsServices");
		gclass15.Services = new List<string>
		{
			"SDRSVC",
			"swprv",
			"VSS",
			"wbengine",
			"fhsvc"
		};
		GClass115.gclass173_14 = gclass15;
		GClass172.GClass173 gclass16 = new GClass172.GClass173();
		gclass16.Icon = 2997;
		gclass16.IsRed = true;
		gclass16.method_1("passwordBiometryServices");
		gclass16.Services = new List<string>
		{
			"NgcSvc",
			"NgcCtnrSvc",
			"NaturalAuthentication",
			"WbioSrvc"
		};
		GClass115.gclass173_15 = gclass16;
		GClass172.GClass173 gclass17 = new GClass172.GClass173();
		gclass17.Icon = 4569;
		gclass17.IsRed = false;
		gclass17.method_1("xboxServices");
		gclass17.Services = new List<string>
		{
			"IKEEXT",
			"iphlpsvc",
			"DeviceAssociationBrokerSvc",
			"XblAuthManager",
			"XblGameSave",
			"XboxNetApiSvc",
			"xbgm",
			"XboxGipSvc"
		};
		GClass115.gclass173_16 = gclass17;
		GClass172.GClass173 gclass18 = new GClass172.GClass173();
		gclass18.Icon = 3167;
		gclass18.IsRed = false;
		gclass18.method_1("windowsMediaPlayerServices");
		gclass18.Services = new List<string>
		{
			"WMPNetworkSvc",
			"WPDBusEnum"
		};
		GClass115.gclass173_17 = gclass18;
		GClass172.GClass173 gclass19 = new GClass172.GClass173();
		gclass19.Icon = 2067;
		gclass19.IsRed = false;
		gclass19.method_1("themesService");
		gclass19.Services = new List<string>
		{
			"Themes"
		};
		GClass115.gclass173_18 = gclass19;
		GClass172.GClass173 gclass20 = new GClass172.GClass173();
		gclass20.Icon = 3647;
		gclass20.IsRed = false;
		gclass20.method_1("sysmainServices");
		gclass20.Services = new List<string>
		{
			"SysMain",
			"svsvc"
		};
		GClass115.gclass173_19 = gclass20;
		GClass172.GClass173 gclass21 = new GClass172.GClass173();
		gclass21.Icon = 2818;
		gclass21.IsRed = false;
		gclass21.method_1("indexServices");
		gclass21.Services = new List<string>
		{
			"WSearch"
		};
		GClass115.gclass173_20 = gclass21;
		GClass172.GClass173 gclass22 = new GClass172.GClass173();
		gclass22.Icon = 6753;
		gclass22.IsRed = false;
		gclass22.method_1("wisvcService");
		gclass22.Services = new List<string>
		{
			"wisvc"
		};
		GClass115.gclass173_21 = gclass22;
		GClass172.GClass173 gclass23 = new GClass172.GClass173();
		gclass23.Icon = 6994;
		gclass23.IsRed = false;
		gclass23.method_1("shellHWDetectionService");
		gclass23.Services = new List<string>
		{
			"ShellHWDetection"
		};
		GClass115.gclass173_22 = gclass23;
		GClass172.GClass173 gclass24 = new GClass172.GClass173();
		gclass24.Icon = 6993;
		gclass24.IsRed = false;
		gclass24.method_1("WwanSvcService");
		gclass24.Services = new List<string>
		{
			"WwanSvc"
		};
		GClass115.gclass173_23 = gclass24;
		GClass172.GClass173 gclass25 = new GClass172.GClass173();
		gclass25.Icon = 2834;
		gclass25.IsRed = false;
		gclass25.method_1("PcaSvcService");
		gclass25.Services = new List<string>
		{
			"PcaSvc"
		};
		GClass115.gclass173_24 = gclass25;
		GClass172.GClass173 gclass26 = new GClass172.GClass173();
		gclass26.Icon = 7314;
		gclass26.IsRed = false;
		gclass26.method_1("DusmSvcService");
		gclass26.Services = new List<string>
		{
			"DusmSvc"
		};
		GClass115.gclass173_25 = gclass26;
		GClass172.GClass173 gclass27 = new GClass172.GClass173();
		gclass27.Icon = 3648;
		gclass27.IsRed = false;
		gclass27.method_1("defragsvcService");
		gclass27.Services = new List<string>
		{
			"defragsvc"
		};
		GClass115.gclass173_26 = gclass27;
		GClass172.GClass173 gclass28 = new GClass172.GClass173();
		gclass28.Icon = 7239;
		gclass28.IsRed = false;
		gclass28.method_1("W32TimeService");
		gclass28.Services = new List<string>
		{
			"W32Time"
		};
		GClass115.gclass173_27 = gclass28;
		GClass172.GClass173 gclass29 = new GClass172.GClass173();
		gclass29.Icon = 1575;
		gclass29.IsRed = false;
		gclass29.method_1("DeviceAssociationService");
		gclass29.Services = new List<string>
		{
			"DeviceAssociationService"
		};
		GClass115.gclass173_28 = gclass29;
		GClass172.GClass173 gclass30 = new GClass172.GClass173();
		gclass30.Icon = 7269;
		gclass30.IsRed = false;
		gclass30.method_1("DisplayEnhancementService");
		gclass30.Services = new List<string>
		{
			"DisplayEnhancementService"
		};
		GClass115.gclass173_29 = gclass30;
		GClass172.GClass173 gclass31 = new GClass172.GClass173();
		gclass31.Icon = 1924;
		gclass31.IsRed = false;
		gclass31.method_1("DsmSvcService");
		gclass31.Services = new List<string>
		{
			"DsmSvc"
		};
		GClass115.gclass173_30 = gclass31;
		GClass172.GClass173 gclass32 = new GClass172.GClass173();
		gclass32.Icon = 7275;
		gclass32.IsRed = false;
		gclass32.method_1("FrameServerService");
		gclass32.Services = new List<string>
		{
			"FrameServer"
		};
		GClass115.gclass173_31 = gclass32;
		GClass172.GClass173 gclass33 = new GClass172.GClass173();
		gclass33.Icon = 4090;
		gclass33.IsRed = true;
		gclass33.method_1("hidservService");
		gclass33.Services = new List<string>
		{
			"hidserv"
		};
		GClass115.gclass173_32 = gclass33;
		GClass172.GClass173 gclass34 = new GClass172.GClass173();
		gclass34.Icon = 6870;
		gclass34.IsRed = false;
		gclass34.method_1("LxpSvcService");
		gclass34.Services = new List<string>
		{
			"LxpSvc"
		};
		GClass115.gclass173_33 = gclass34;
		GClass172.GClass173 gclass35 = new GClass172.GClass173();
		gclass35.Icon = 2100;
		gclass35.IsRed = false;
		gclass35.method_1("smphostService");
		gclass35.Services = new List<string>
		{
			"smphost"
		};
		GClass115.gclass173_34 = gclass35;
	}

	// Token: 0x04000D4A RID: 3402
	public static readonly GClass172.GClass173 gclass173_0;

	// Token: 0x04000D4B RID: 3403
	public static readonly GClass172.GClass173 gclass173_1;

	// Token: 0x04000D4C RID: 3404
	public static readonly GClass172.GClass173 gclass173_2;

	// Token: 0x04000D4D RID: 3405
	public static readonly GClass172.GClass173 gclass173_3;

	// Token: 0x04000D4E RID: 3406
	public static readonly GClass172.GClass173 gclass173_4;

	// Token: 0x04000D4F RID: 3407
	public static readonly GClass172.GClass173 gclass173_5;

	// Token: 0x04000D50 RID: 3408
	public static readonly GClass172.GClass173 gclass173_6;

	// Token: 0x04000D51 RID: 3409
	public static readonly GClass172.GClass173 gclass173_7;

	// Token: 0x04000D52 RID: 3410
	public static readonly GClass172.GClass173 gclass173_8;

	// Token: 0x04000D53 RID: 3411
	public static readonly GClass172.GClass173 gclass173_9;

	// Token: 0x04000D54 RID: 3412
	public static readonly GClass172.GClass173 gclass173_10;

	// Token: 0x04000D55 RID: 3413
	public static readonly GClass172.GClass173 gclass173_11;

	// Token: 0x04000D56 RID: 3414
	public static readonly GClass172.GClass173 gclass173_12;

	// Token: 0x04000D57 RID: 3415
	public static readonly GClass172.GClass173 gclass173_13;

	// Token: 0x04000D58 RID: 3416
	public static readonly GClass172.GClass173 gclass173_14;

	// Token: 0x04000D59 RID: 3417
	public static readonly GClass172.GClass173 gclass173_15;

	// Token: 0x04000D5A RID: 3418
	public static readonly GClass172.GClass173 gclass173_16;

	// Token: 0x04000D5B RID: 3419
	public static readonly GClass172.GClass173 gclass173_17;

	// Token: 0x04000D5C RID: 3420
	public static readonly GClass172.GClass173 gclass173_18;

	// Token: 0x04000D5D RID: 3421
	public static readonly GClass172.GClass173 gclass173_19;

	// Token: 0x04000D5E RID: 3422
	public static readonly GClass172.GClass173 gclass173_20;

	// Token: 0x04000D5F RID: 3423
	public static readonly GClass172.GClass173 gclass173_21;

	// Token: 0x04000D60 RID: 3424
	public static readonly GClass172.GClass173 gclass173_22;

	// Token: 0x04000D61 RID: 3425
	public static readonly GClass172.GClass173 gclass173_23;

	// Token: 0x04000D62 RID: 3426
	public static readonly GClass172.GClass173 gclass173_24;

	// Token: 0x04000D63 RID: 3427
	public static readonly GClass172.GClass173 gclass173_25;

	// Token: 0x04000D64 RID: 3428
	public static readonly GClass172.GClass173 gclass173_26;

	// Token: 0x04000D65 RID: 3429
	public static readonly GClass172.GClass173 gclass173_27;

	// Token: 0x04000D66 RID: 3430
	public static readonly GClass172.GClass173 gclass173_28;

	// Token: 0x04000D67 RID: 3431
	public static readonly GClass172.GClass173 gclass173_29;

	// Token: 0x04000D68 RID: 3432
	public static readonly GClass172.GClass173 gclass173_30;

	// Token: 0x04000D69 RID: 3433
	public static readonly GClass172.GClass173 gclass173_31;

	// Token: 0x04000D6A RID: 3434
	public static readonly GClass172.GClass173 gclass173_32;

	// Token: 0x04000D6B RID: 3435
	public static readonly GClass172.GClass173 gclass173_33;

	// Token: 0x04000D6C RID: 3436
	public static readonly GClass172.GClass173 gclass173_34;
}
