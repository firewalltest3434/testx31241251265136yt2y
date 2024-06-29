using System;
using System.Management;
using System.Management.Automation;

// Token: 0x0200058C RID: 1420
internal sealed class Class643
{
	// Token: 0x06001EAC RID: 7852 RVA: 0x0007FB90 File Offset: 0x0007DD90
	public static bool smethod_0()
	{
		using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMv2\\Security\\MicrosoftVolumeEncryption", "SELECT * FROM Win32_EncryptableVolume").Get().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((ManagementObject)enumerator.Current)["ConversionStatus"].ToString().smethod_2("1"))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001EAD RID: 7853 RVA: 0x0007FC0C File Offset: 0x0007DE0C
	public static void smethod_1()
	{
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript("Get-BitLockerVolume | Where-Object { $_.VolumeType -eq 'OperatingSystem' -and $_.ProtectionStatus -eq 'On' } | Disable-BitLocker -MountPoint $_.MountPoint -RebootCount 0");
			try
			{
				powerShell.Invoke();
			}
			catch (Exception exception_)
			{
				GClass141.smethod_0(exception_);
			}
			powerShell.Dispose();
		}
	}

	// Token: 0x06001EAE RID: 7854 RVA: 0x0007FC6C File Offset: 0x0007DE6C
	public static void smethod_2()
	{
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript("Get-BitLockerVolume | Where-Object { $_.VolumeType -eq 'OperatingSystem' -and $_.ProtectionStatus -eq 'Off' } | Enable-BitLocker -MountPoint $_.MountPoint -RebootCount 0");
			try
			{
				powerShell.Invoke();
			}
			catch (Exception exception_)
			{
				GClass141.smethod_0(exception_);
			}
			powerShell.Dispose();
		}
	}
}
