using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;

// Token: 0x02000402 RID: 1026
internal sealed class Class468
{
	// Token: 0x06001630 RID: 5680 RVA: 0x0005D9AC File Offset: 0x0005BBAC
	private Class468()
	{
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x0005D9E0 File Offset: 0x0005BBE0
	public static Class468 smethod_0()
	{
		if (Class468.class468_0 == null)
		{
			Class468.class468_0 = new Class468();
		}
		return Class468.class468_0;
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x0005D9F8 File Offset: 0x0005BBF8
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x0005DA00 File Offset: 0x0005BC00
	private void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x0005DA0C File Offset: 0x0005BC0C
	public void method_2()
	{
		this.list_1.Clear();
		this.list_0.Clear();
		foreach (ServiceController serviceController_ in ServiceController.GetServices())
		{
			this.list_0.Add(new GClass97(serviceController_));
		}
	}

	// Token: 0x170002F8 RID: 760
	// (get) Token: 0x06001635 RID: 5685 RVA: 0x0005DA60 File Offset: 0x0005BC60
	// (set) Token: 0x06001636 RID: 5686 RVA: 0x0005DA68 File Offset: 0x0005BC68
	public List<ServiceController> Services
	{
		get
		{
			return this.list_2;
		}
		set
		{
			this.list_2 = value;
		}
	}

	// Token: 0x06001637 RID: 5687 RVA: 0x0005DA74 File Offset: 0x0005BC74
	public List<ServiceController> method_3()
	{
		return this.list_3;
	}

	// Token: 0x06001638 RID: 5688 RVA: 0x0005DA7C File Offset: 0x0005BC7C
	public void method_4(List<ServiceController> list_5)
	{
		this.list_3 = list_5;
	}

	// Token: 0x06001639 RID: 5689 RVA: 0x0005DA88 File Offset: 0x0005BC88
	public List<ServiceController> method_5()
	{
		List<ServiceController> list = new List<ServiceController>();
		list.AddRange(this.Services);
		list.AddRange(this.method_3());
		return list;
	}

	// Token: 0x0600163A RID: 5690 RVA: 0x0005DAA8 File Offset: 0x0005BCA8
	private void method_6()
	{
		this.Services = ServiceController.GetServices().ToList<ServiceController>();
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x0005DABC File Offset: 0x0005BCBC
	private void method_7()
	{
		this.method_4(ServiceController.GetDevices().ToList<ServiceController>());
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x0005DAD0 File Offset: 0x0005BCD0
	private void method_8()
	{
		this.method_6();
		this.method_7();
		this.method_11();
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x0005DAE4 File Offset: 0x0005BCE4
	public List<GClass151> method_9()
	{
		Class468.Class472 @class = new Class468.Class472();
		this.method_8();
		@class.func_0 = this.method_13();
		return this.method_10().Select(new Func<GClass110, GClass151>(@class.method_1)).ToList<GClass151>();
	}

	// Token: 0x0600163E RID: 5694 RVA: 0x0005DB28 File Offset: 0x0005BD28
	private List<GClass110> method_10()
	{
		return this.list_4;
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x0005DB30 File Offset: 0x0005BD30
	private void method_11()
	{
		Class468.Class470 @class = new Class468.Class470();
		@class.list_0 = new List<GClass110>();
		List<ServiceController> source = this.method_5();
		this.method_1(GClass188.smethod_13(source));
		@class.dictionary_0 = source.ToDictionary(new Func<ServiceController, string>(Class468.Class471.class471_0.method_0));
		@class.dictionary_1 = source.Select(new Func<ServiceController, GClass110>(Class468.Class471.class471_0.method_1)).ToList<GClass110>().FindAll(new Predicate<GClass110>(Class468.Class471.class471_0.method_2)).ToDictionary(new Func<GClass110, string>(Class468.Class471.class471_0.method_3));
		@class.dictionary_0.Keys.ToList<string>().ForEach(new Action<string>(@class.method_0));
		this.list_4 = @class.list_0;
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x0005DC34 File Offset: 0x0005BE34
	private Dictionary<string, string> method_12()
	{
		Dictionary<string, string> result;
		if ((result = this.dictionary_0) == null)
		{
			result = (this.dictionary_0 = GClass188.smethod_17());
		}
		return result;
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x0005DC5C File Offset: 0x0005BE5C
	private Func<string, string> method_13()
	{
		return new Func<string, string>(this.method_19);
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x0005DC6C File Offset: 0x0005BE6C
	public void method_14()
	{
		this.list_1.Clear();
		this.method_15();
		this.method_15();
		this.method_15();
	}

	// Token: 0x06001643 RID: 5699 RVA: 0x0005DC8C File Offset: 0x0005BE8C
	public void method_15()
	{
		GClass115.gclass173_0.Services.ForEach(new Action<string>(this.method_20));
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x0005DCAC File Offset: 0x0005BEAC
	public void method_16()
	{
		try
		{
			this.list_1.ForEach(new Action<GClass97>(this.method_21));
			this.list_1.Clear();
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x0005DCF0 File Offset: 0x0005BEF0
	public void method_17(string string_1, ServiceStartMode? nullable_0)
	{
		ServiceStartMode? serviceStartMode = nullable_0;
		if (serviceStartMode.GetValueOrDefault() == ServiceStartMode.Manual & serviceStartMode != null)
		{
			GClass104.smethod_0("cmd.exe /c sc config " + string_1 + " start= demand", false);
			GClass104.smethod_0("cmd.exe /c net start " + string_1, false);
			return;
		}
		serviceStartMode = nullable_0;
		if (serviceStartMode.GetValueOrDefault() == ServiceStartMode.Automatic & serviceStartMode != null)
		{
			GClass104.smethod_0("cmd.exe /c sc config " + string_1 + " start= auto", false);
			GClass104.smethod_0("cmd.exe /c net start " + string_1, false);
			return;
		}
		GClass104.smethod_0("cmd.exe /c sc config " + string_1 + " start= disabled", false);
		GClass104.smethod_0("cmd.exe /c net stop " + string_1, false);
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x0005DDAC File Offset: 0x0005BFAC
	public void method_18(string string_1)
	{
		GClass104.smethod_0("cmd.exe /c net start " + string_1, false);
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x0005DDC0 File Offset: 0x0005BFC0
	private string method_19(string string_1)
	{
		if (!this.method_12().ContainsKey(string_1))
		{
			return null;
		}
		return this.method_12()[string_1];
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x0005DDE0 File Offset: 0x0005BFE0
	private void method_20(string string_1)
	{
		Class468.Class469 @class = new Class468.Class469();
		@class.string_0 = string_1;
		try
		{
			GClass97 gclass = this.list_0.First(new Func<GClass97, bool>(@class.method_0));
			ServiceStartMode? defaultStartMode = gclass.DefaultStartMode;
			ServiceStartMode serviceStartMode = gclass.method_0();
			if (defaultStartMode.GetValueOrDefault() == serviceStartMode & defaultStartMode != null)
			{
				this.method_18(gclass.ServiceName);
			}
			else
			{
				if (!this.list_1.Contains(gclass))
				{
					this.list_1.Add(gclass);
				}
				this.method_17(gclass.ServiceName, gclass.DefaultStartMode);
			}
		}
		catch (Exception exception_)
		{
			GClass141.smethod_0(exception_);
		}
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x0005DE88 File Offset: 0x0005C088
	private void method_21(GClass97 gclass97_0)
	{
		this.method_17(gclass97_0.ServiceName, new ServiceStartMode?(gclass97_0.method_0()));
	}

	// Token: 0x04000F0F RID: 3855
	private static Class468 class468_0;

	// Token: 0x04000F10 RID: 3856
	private readonly List<GClass97> list_0 = new List<GClass97>();

	// Token: 0x04000F11 RID: 3857
	private readonly List<GClass97> list_1 = new List<GClass97>();

	// Token: 0x04000F12 RID: 3858
	private string string_0 = string.Empty;

	// Token: 0x04000F13 RID: 3859
	private List<ServiceController> list_2;

	// Token: 0x04000F14 RID: 3860
	private List<ServiceController> list_3;

	// Token: 0x04000F15 RID: 3861
	private List<GClass110> list_4 = new List<GClass110>();

	// Token: 0x04000F16 RID: 3862
	private Dictionary<string, string> dictionary_0;

	// Token: 0x02000403 RID: 1027
	private sealed class Class469
	{
		// Token: 0x0600164B RID: 5707 RVA: 0x0005DEAC File Offset: 0x0005C0AC
		internal bool method_0(GClass97 gclass97_0)
		{
			return gclass97_0.ServiceName.ToLower() == this.string_0.ToLower();
		}

		// Token: 0x04000F17 RID: 3863
		public string string_0;
	}

	// Token: 0x02000404 RID: 1028
	private sealed class Class470
	{
		// Token: 0x0600164D RID: 5709 RVA: 0x0005DED4 File Offset: 0x0005C0D4
		internal void method_0(string string_0)
		{
			try
			{
				Class468.Class473 @class = new Class468.Class473();
				@class.class470_0 = this;
				ServiceController serviceController = this.dictionary_0[string_0];
				@class.gclass110_0 = this.dictionary_1[string_0];
				this.list_0.Add(@class.gclass110_0);
				serviceController.ServicesDependedOn.ToList<ServiceController>().ForEach(new Action<ServiceController>(@class.method_0));
				serviceController.DependentServices.ToList<ServiceController>().ForEach(new Action<ServiceController>(@class.method_1));
			}
			catch (Exception exception_)
			{
				GClass141.smethod_0(exception_);
			}
		}

		// Token: 0x04000F18 RID: 3864
		public Dictionary<string, ServiceController> dictionary_0;

		// Token: 0x04000F19 RID: 3865
		public Dictionary<string, GClass110> dictionary_1;

		// Token: 0x04000F1A RID: 3866
		public List<GClass110> list_0;
	}

	// Token: 0x02000405 RID: 1029
	[Serializable]
	private sealed class Class471
	{
		// Token: 0x06001650 RID: 5712 RVA: 0x0005DF84 File Offset: 0x0005C184
		internal string method_0(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0005DF8C File Offset: 0x0005C18C
		internal GClass110 method_1(ServiceController serviceController_0)
		{
			GClass110 result;
			try
			{
				result = new GClass110(new GClass97(serviceController_0));
			}
			catch (Exception exception_)
			{
				GClass141.smethod_0(exception_);
				result = null;
			}
			return result;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0005DFC4 File Offset: 0x0005C1C4
		internal bool method_2(GClass110 gclass110_0)
		{
			return gclass110_0 != null;
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0005DFCC File Offset: 0x0005C1CC
		internal string method_3(GClass110 gclass110_0)
		{
			return gclass110_0.Service.ServiceName;
		}

		// Token: 0x04000F1B RID: 3867
		public static readonly Class468.Class471 class471_0 = new Class468.Class471();

		// Token: 0x04000F1C RID: 3868
		public static Func<ServiceController, string> func_0;

		// Token: 0x04000F1D RID: 3869
		public static Func<ServiceController, GClass110> func_1;

		// Token: 0x04000F1E RID: 3870
		public static Predicate<GClass110> predicate_0;

		// Token: 0x04000F1F RID: 3871
		public static Func<GClass110, string> func_2;
	}

	// Token: 0x02000406 RID: 1030
	private sealed class Class472
	{
		// Token: 0x06001655 RID: 5717 RVA: 0x0005DFE4 File Offset: 0x0005C1E4
		internal void method_0(GClass151 gclass151_0)
		{
			gclass151_0.Description = this.func_0(gclass151_0.ServiceName);
			gclass151_0.DependenciesTree.ForEach(new Action<GClass151>(this.method_0));
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0005E014 File Offset: 0x0005C214
		internal GClass151 method_1(GClass110 gclass110_0)
		{
			GClass151 gclass = new GClass151(gclass110_0)
			{
				EnableParents = false
			};
			this.method_0(gclass);
			return gclass;
		}

		// Token: 0x04000F20 RID: 3872
		public Func<string, string> func_0;
	}

	// Token: 0x02000407 RID: 1031
	private sealed class Class473
	{
		// Token: 0x06001658 RID: 5720 RVA: 0x0005E040 File Offset: 0x0005C240
		internal void method_0(ServiceController serviceController_0)
		{
			if (!GClass188.smethod_11(serviceController_0))
			{
				return;
			}
			GClass110 gclass;
			if (!this.class470_0.dictionary_1.TryGetValue(serviceController_0.ServiceName, out gclass))
			{
				return;
			}
			this.gclass110_0.DependOn.Add(gclass);
			gclass.DependenciesTree.Add(this.gclass110_0);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0005E094 File Offset: 0x0005C294
		internal void method_1(ServiceController serviceController_0)
		{
			if (!GClass188.smethod_11(serviceController_0))
			{
				return;
			}
			GClass110 item;
			if (!this.class470_0.dictionary_1.TryGetValue(serviceController_0.ServiceName, out item))
			{
				return;
			}
			this.gclass110_0.DependenciesLinear.Add(item);
		}

		// Token: 0x04000F21 RID: 3873
		public GClass110 gclass110_0;

		// Token: 0x04000F22 RID: 3874
		public Class468.Class470 class470_0;
	}
}
