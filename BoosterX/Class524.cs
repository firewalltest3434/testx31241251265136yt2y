using System;

// Token: 0x020004CA RID: 1226
internal sealed class Class524 : GClass131
{
	// Token: 0x06001AE7 RID: 6887 RVA: 0x0006ED9C File Offset: 0x0006CF9C
	public Class524(Class716 class716_1)
	{
		this.class716_0 = class716_1;
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x0006EDAC File Offset: 0x0006CFAC
	protected override void RunFunction(object argument)
	{
		base.imethod_1("ChangingAffinity", (GEnum93)1);
		if ((string)argument == "default")
		{
			base.imethod_1("DefaultAffinity", (GEnum93)1);
			Class185.smethod_22("reg delete \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\" + this.class716_0.Path + "\\Device Parameters\\Interrupt Management\\Affinity Policy\" /v \"DevicePolicy\" /f");
			Class185.smethod_22("reg delete \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\" + this.class716_0.Path + "\\Device Parameters\\Interrupt Management\\Affinity Policy\" /v \"AssignmentSetOverride\" /f");
			return;
		}
		base.imethod_1("ChangingAffinity", (GEnum93)1);
		string text = Class672.smethod_4(argument.ToString());
		Class185.smethod_22("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\" + this.class716_0.Path + "\\Device Parameters\\Interrupt Management\\Affinity Policy\" /v \"DevicePolicy\" /t REG_DWORD /d \"4\" /f");
		Class185.smethod_22(string.Concat(new string[]
		{
			"reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\",
			this.class716_0.Path,
			"\\Device Parameters\\Interrupt Management\\Affinity Policy\" /v \"AssignmentSetOverride\" /t REG_BINARY /d \"",
			text,
			"\" /f"
		}));
	}

	// Token: 0x040012F4 RID: 4852
	private Class716 class716_0;
}
