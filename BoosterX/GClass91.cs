using System;

// Token: 0x02000303 RID: 771
public static class GClass91
{
	// Token: 0x0600119D RID: 4509 RVA: 0x00049C94 File Offset: 0x00047E94
	public static void smethod_0(string string_0)
	{
		GClass146.smethod_5("Get-AppxPackage -Name \"*" + string_0 + "*\" | Remove-AppxPackage");
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00049CAC File Offset: 0x00047EAC
	public static void smethod_1(string string_0)
	{
		GClass146.smethod_3("Get-AppxPackage -Name \"*" + string_0 + "*\" | Foreach {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}");
	}
}
