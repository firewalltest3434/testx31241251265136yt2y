using System;

// Token: 0x02000157 RID: 343
internal sealed class Class520 : GClass131
{
	// Token: 0x060008FB RID: 2299 RVA: 0x00029598 File Offset: 0x00027798
	public Class520(GClass221 gclass221_1)
	{
		this.gclass221_0 = gclass221_1;
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x000295A8 File Offset: 0x000277A8
	public GClass221 method_6()
	{
		return this.gclass221_0;
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x000295B0 File Offset: 0x000277B0
	protected override void RunFunction(object argument)
	{
		GClass221 gclass = argument as GClass221;
		string a = string.Empty;
		try
		{
			if (gclass.HasChangesMSI)
			{
				base.imethod_1("ChangingMsi", (GEnum93)1);
				a = (gclass.MsiStatus ? "DisableMsi" : "EnableMsi");
			}
		}
		catch (object obj)
		{
		}
		try
		{
			if (gclass.HasChangesEnabled)
			{
				base.imethod_1("ChangingDeviceStatus", (GEnum93)1);
				a = (gclass.IsEnabled ? "EnableDevice" : "DisableDevice");
			}
		}
		catch (object obj2)
		{
		}
		if (a == "DisableMsi")
		{
			Class185.smethod_22("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\" + gclass.Id + "\\Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties\" /v \"MSISupported\" /t REG_DWORD /d \"0\" /f");
		}
		if (a == "EnableMsi")
		{
			Class185.smethod_22("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\" + gclass.Id + "\\Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties\" /v \"MSISupported\" /t REG_DWORD /d \"1\" /f");
		}
		if (a == "DisableDevice")
		{
			Class694.smethod_5(gclass.Id);
		}
		if (a == "EnableDevice")
		{
			Class694.smethod_6(gclass.Id);
		}
	}

	// Token: 0x04000527 RID: 1319
	private GClass221 gclass221_0;
}
