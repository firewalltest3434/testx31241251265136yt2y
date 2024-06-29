using System;
using System.Threading.Tasks;
using Material.Icons;

// Token: 0x02000447 RID: 1095
internal sealed class Class749 : GClass211
{
	// Token: 0x1700038E RID: 910
	// (get) Token: 0x0600184A RID: 6218 RVA: 0x00065C14 File Offset: 0x00063E14
	// (set) Token: 0x0600184B RID: 6219 RVA: 0x00065C1C File Offset: 0x00063E1C
	public string NameRaw
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("NameRaw");
		}
	}

	// Token: 0x1700038F RID: 911
	// (get) Token: 0x0600184C RID: 6220 RVA: 0x00065C30 File Offset: 0x00063E30
	public string Name
	{
		get
		{
			return Class364.smethod_0(this.NameRaw);
		}
	}

	// Token: 0x17000390 RID: 912
	// (get) Token: 0x0600184D RID: 6221 RVA: 0x00065C40 File Offset: 0x00063E40
	public string Description
	{
		get
		{
			return Class364.smethod_0(this.NameRaw + "Desc");
		}
	}

	// Token: 0x17000391 RID: 913
	// (get) Token: 0x0600184E RID: 6222 RVA: 0x00065C58 File Offset: 0x00063E58
	// (set) Token: 0x0600184F RID: 6223 RVA: 0x00065C60 File Offset: 0x00063E60
	public string Group
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = Class364.smethod_0(value);
			base.method_0("Group");
		}
	}

	// Token: 0x17000392 RID: 914
	// (get) Token: 0x06001850 RID: 6224 RVA: 0x00065C7C File Offset: 0x00063E7C
	// (set) Token: 0x06001851 RID: 6225 RVA: 0x00065C84 File Offset: 0x00063E84
	public string RegistryValue
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("IsEnabled");
		}
	}

	// Token: 0x17000393 RID: 915
	// (get) Token: 0x06001852 RID: 6226 RVA: 0x00065C98 File Offset: 0x00063E98
	// (set) Token: 0x06001853 RID: 6227 RVA: 0x00065CEC File Offset: 0x00063EEC
	public bool? IsEnabled
	{
		get
		{
			if (this.bool_0 && !Class585.struct13_0.method_0())
			{
				return null;
			}
			return new bool?(new bool?(Convert.ToBoolean(Class502.smethod_0(this.string_2, "BoosterX"))).GetValueOrDefault(true));
		}
		set
		{
			if (this.bool_0 && !Class585.struct13_0.method_0())
			{
				return;
			}
			Class502.smethod_1(this.string_2, value.ToString(), "BoosterX");
			if (this.RegistryValue == "ShowExperimentalTweaks" || this.RegistryValue == "ShowHiddenTweaks")
			{
				Task.Run(new Func<Task>(Class749.Class501.class501_0.method_0));
			}
			base.method_0("IsEnabled");
		}
	}

	// Token: 0x17000394 RID: 916
	// (get) Token: 0x06001854 RID: 6228 RVA: 0x00065D80 File Offset: 0x00063F80
	// (set) Token: 0x06001855 RID: 6229 RVA: 0x00065D88 File Offset: 0x00063F88
	public bool IsPRO
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("IsPRO");
		}
	}

	// Token: 0x17000395 RID: 917
	// (set) Token: 0x06001856 RID: 6230 RVA: 0x00065D9C File Offset: 0x00063F9C
	public string IconString
	{
		set
		{
			try
			{
				MaterialIconKind icon;
				if (Enum.TryParse<MaterialIconKind>(value, out icon))
				{
					this.Icon = icon;
				}
			}
			catch
			{
				this.Icon = 1996;
			}
		}
	}

	// Token: 0x06001857 RID: 6231 RVA: 0x00065DDC File Offset: 0x00063FDC
	private MaterialIconKind method_1()
	{
		return this.materialIconKind_0;
	}

	// Token: 0x06001858 RID: 6232 RVA: 0x00065DE4 File Offset: 0x00063FE4
	private void method_2(MaterialIconKind materialIconKind_1)
	{
		this.materialIconKind_0 = materialIconKind_1;
	}

	// Token: 0x17000396 RID: 918
	// (get) Token: 0x06001859 RID: 6233 RVA: 0x00065DF0 File Offset: 0x00063FF0
	// (set) Token: 0x0600185A RID: 6234 RVA: 0x00065DF8 File Offset: 0x00063FF8
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_1();
		}
		set
		{
			this.method_2(value);
			base.method_0("Icon");
		}
	}

	// Token: 0x04001115 RID: 4373
	private string string_0;

	// Token: 0x04001116 RID: 4374
	private string string_1;

	// Token: 0x04001117 RID: 4375
	private string string_2;

	// Token: 0x04001118 RID: 4376
	private bool bool_0;

	// Token: 0x04001119 RID: 4377
	private MaterialIconKind materialIconKind_0;

	// Token: 0x02000448 RID: 1096
	[Serializable]
	private sealed class Class501
	{
		// Token: 0x0600185D RID: 6237 RVA: 0x00065E20 File Offset: 0x00064020
		internal Task method_0()
		{
			return Class588.smethod_4();
		}

		// Token: 0x0400111A RID: 4378
		public static readonly Class749.Class501 class501_0 = new Class749.Class501();

		// Token: 0x0400111B RID: 4379
		public static Func<Task> func_0;
	}
}
