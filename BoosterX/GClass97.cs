using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ServiceProcess;

// Token: 0x0200032D RID: 813
public sealed class GClass97
{
	// Token: 0x06001273 RID: 4723 RVA: 0x0004C72C File Offset: 0x0004A92C
	public GClass97(ServiceController serviceController_0)
	{
		this.ServiceName = serviceController_0.ServiceName;
		this.DisplayName = serviceController_0.DisplayName;
		this.DefaultStartMode = GClass188.smethod_10(serviceController_0.ServiceName);
		ServiceStartMode? defaultStartMode = this.DefaultStartMode;
		if (defaultStartMode.GetValueOrDefault() == ServiceStartMode.Disabled & defaultStartMode != null)
		{
			this.DefaultStartMode = null;
		}
		this.IsBlocked = GClass188.smethod_9(serviceController_0.ServiceName);
		this.WillBrake = GClass188.smethod_8(serviceController_0.ServiceName);
		try
		{
			this.method_1(serviceController_0.StartType);
		}
		catch
		{
			this.method_1(GClass188.smethod_1(serviceController_0.ServiceName));
		}
		this.Status = serviceController_0.Status;
		this.method_3(new ServiceType?(serviceController_0.ServiceType));
	}

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x06001274 RID: 4724 RVA: 0x0004C804 File Offset: 0x0004AA04
	// (set) Token: 0x06001275 RID: 4725 RVA: 0x0004C80C File Offset: 0x0004AA0C
	public string ServiceName
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x1700024F RID: 591
	// (get) Token: 0x06001276 RID: 4726 RVA: 0x0004C818 File Offset: 0x0004AA18
	// (set) Token: 0x06001277 RID: 4727 RVA: 0x0004C820 File Offset: 0x0004AA20
	public string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x06001278 RID: 4728 RVA: 0x0004C82C File Offset: 0x0004AA2C
	// (set) Token: 0x06001279 RID: 4729 RVA: 0x0004C834 File Offset: 0x0004AA34
	public List<string> WillBrake
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
		[CompilerGenerated]
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x0600127A RID: 4730 RVA: 0x0004C840 File Offset: 0x0004AA40
	// (set) Token: 0x0600127B RID: 4731 RVA: 0x0004C848 File Offset: 0x0004AA48
	public bool IsBlocked
	{
		[CompilerGenerated]
		get
		{
			return this.bool_0;
		}
		[CompilerGenerated]
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x17000252 RID: 594
	// (get) Token: 0x0600127C RID: 4732 RVA: 0x0004C854 File Offset: 0x0004AA54
	// (set) Token: 0x0600127D RID: 4733 RVA: 0x0004C85C File Offset: 0x0004AA5C
	public ServiceStartMode? DefaultStartMode
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_0;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x0004C868 File Offset: 0x0004AA68
	public ServiceStartMode method_0()
	{
		return this.serviceStartMode_0;
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x0004C870 File Offset: 0x0004AA70
	public void method_1(ServiceStartMode serviceStartMode_1)
	{
		this.serviceStartMode_0 = serviceStartMode_1;
	}

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x06001280 RID: 4736 RVA: 0x0004C87C File Offset: 0x0004AA7C
	// (set) Token: 0x06001281 RID: 4737 RVA: 0x0004C884 File Offset: 0x0004AA84
	public ServiceControllerStatus Status
	{
		[CompilerGenerated]
		get
		{
			return this.serviceControllerStatus_0;
		}
		[CompilerGenerated]
		set
		{
			this.serviceControllerStatus_0 = value;
		}
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x0004C890 File Offset: 0x0004AA90
	public ServiceType? method_2()
	{
		return this.nullable_1;
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x0004C898 File Offset: 0x0004AA98
	public void method_3(ServiceType? nullable_2)
	{
		this.nullable_1 = nullable_2;
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x0004C8A4 File Offset: 0x0004AAA4
	public bool method_4()
	{
		return !this.method_5();
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x0004C8B0 File Offset: 0x0004AAB0
	public bool method_5()
	{
		ServiceType? serviceType = this.method_2();
		if (serviceType != null)
		{
			ServiceType valueOrDefault = serviceType.GetValueOrDefault();
			if (valueOrDefault - ServiceType.KernelDriver <= 1 || valueOrDefault == ServiceType.RecognizerDriver)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x0004C8E8 File Offset: 0x0004AAE8
	internal bool method_6(string string_2)
	{
		return false;
	}

	// Token: 0x04000B58 RID: 2904
	private string string_0;

	// Token: 0x04000B59 RID: 2905
	private string string_1;

	// Token: 0x04000B5A RID: 2906
	private List<string> list_0;

	// Token: 0x04000B5B RID: 2907
	private bool bool_0;

	// Token: 0x04000B5C RID: 2908
	private ServiceStartMode? nullable_0;

	// Token: 0x04000B5D RID: 2909
	private ServiceStartMode serviceStartMode_0;

	// Token: 0x04000B5E RID: 2910
	private ServiceControllerStatus serviceControllerStatus_0;

	// Token: 0x04000B5F RID: 2911
	private ServiceType? nullable_1;
}
