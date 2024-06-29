using System;
using System.ServiceProcess;

// Token: 0x020004AF RID: 1199
internal sealed class Class564
{
	// Token: 0x06001A59 RID: 6745 RVA: 0x0006C754 File Offset: 0x0006A954
	public static GClass151 smethod_0()
	{
		GClass97 gclass = new GClass97(new ServiceController(string.Empty));
		gclass.ServiceName = "Test Service Name";
		gclass.DisplayName = "Display Name";
		gclass.DefaultStartMode = new ServiceStartMode?(ServiceStartMode.Manual);
		gclass.IsBlocked = false;
		gclass.method_1(ServiceStartMode.Disabled);
		gclass.Status = ServiceControllerStatus.Running;
		gclass.method_3(new ServiceType?(ServiceType.Win32ShareProcess));
		return new GClass151(new GClass110(gclass));
	}
}
