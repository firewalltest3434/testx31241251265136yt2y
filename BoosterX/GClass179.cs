using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020005A8 RID: 1448
public sealed class GClass179
{
	// Token: 0x170004DE RID: 1246
	// (get) Token: 0x06001F2D RID: 7981 RVA: 0x000810B8 File Offset: 0x0007F2B8
	// (set) Token: 0x06001F2E RID: 7982 RVA: 0x000810C0 File Offset: 0x0007F2C0
	[JsonProperty("Id")]
	public Guid Guid_0
	{
		get
		{
			return this.guid_0;
		}
		set
		{
			this.guid_0 = value;
		}
	}

	// Token: 0x170004DF RID: 1247
	// (get) Token: 0x06001F2F RID: 7983 RVA: 0x000810CC File Offset: 0x0007F2CC
	// (set) Token: 0x06001F30 RID: 7984 RVA: 0x000810D4 File Offset: 0x0007F2D4
	[JsonProperty("IsEditable")]
	public bool IsEditable
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

	// Token: 0x170004E0 RID: 1248
	// (get) Token: 0x06001F31 RID: 7985 RVA: 0x000810E0 File Offset: 0x0007F2E0
	// (set) Token: 0x06001F32 RID: 7986 RVA: 0x000810E8 File Offset: 0x0007F2E8
	[JsonProperty("Name")]
	public string Name
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

	// Token: 0x170004E1 RID: 1249
	// (get) Token: 0x06001F33 RID: 7987 RVA: 0x000810F4 File Offset: 0x0007F2F4
	// (set) Token: 0x06001F34 RID: 7988 RVA: 0x000810FC File Offset: 0x0007F2FC
	[JsonIgnore]
	public string String_0
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x170004E2 RID: 1250
	// (get) Token: 0x06001F35 RID: 7989 RVA: 0x00081108 File Offset: 0x0007F308
	// (set) Token: 0x06001F36 RID: 7990 RVA: 0x00081110 File Offset: 0x0007F310
	[JsonProperty("Description")]
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x06001F37 RID: 7991 RVA: 0x0008111C File Offset: 0x0007F31C
	// (set) Token: 0x06001F38 RID: 7992 RVA: 0x00081124 File Offset: 0x0007F324
	[JsonProperty("WillBrake")]
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

	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06001F39 RID: 7993 RVA: 0x00081130 File Offset: 0x0007F330
	// (set) Token: 0x06001F3A RID: 7994 RVA: 0x00081138 File Offset: 0x0007F338
	[JsonProperty("Level")]
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06001F3B RID: 7995 RVA: 0x00081144 File Offset: 0x0007F344
	// (set) Token: 0x06001F3C RID: 7996 RVA: 0x0008114C File Offset: 0x0007F34C
	[JsonProperty("Group")]
	public string String_1
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x06001F3D RID: 7997 RVA: 0x00081158 File Offset: 0x0007F358
	// (set) Token: 0x06001F3E RID: 7998 RVA: 0x00081160 File Offset: 0x0007F360
	[JsonProperty("PowerSchemesForImport")]
	public int Int32_1
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x170004E7 RID: 1255
	// (get) Token: 0x06001F3F RID: 7999 RVA: 0x0008116C File Offset: 0x0007F36C
	// (set) Token: 0x06001F40 RID: 8000 RVA: 0x00081174 File Offset: 0x0007F374
	[JsonProperty("IconPath")]
	public string String_2
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x170004E8 RID: 1256
	// (get) Token: 0x06001F41 RID: 8001 RVA: 0x00081180 File Offset: 0x0007F380
	// (set) Token: 0x06001F42 RID: 8002 RVA: 0x00081188 File Offset: 0x0007F388
	[JsonProperty("Arguments")]
	public List<string> List_0
	{
		get
		{
			return this.list_1;
		}
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x170004E9 RID: 1257
	// (get) Token: 0x06001F43 RID: 8003 RVA: 0x00081194 File Offset: 0x0007F394
	// (set) Token: 0x06001F44 RID: 8004 RVA: 0x0008119C File Offset: 0x0007F39C
	[JsonProperty("NoSupport")]
	public List<string> List_1
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

	// Token: 0x170004EA RID: 1258
	// (get) Token: 0x06001F45 RID: 8005 RVA: 0x000811A8 File Offset: 0x0007F3A8
	// (set) Token: 0x06001F46 RID: 8006 RVA: 0x000811B0 File Offset: 0x0007F3B0
	[JsonProperty("OffWith")]
	public List<string> List_2
	{
		get
		{
			return this.list_3;
		}
		set
		{
			this.list_3 = value;
		}
	}

	// Token: 0x170004EB RID: 1259
	// (get) Token: 0x06001F47 RID: 8007 RVA: 0x000811BC File Offset: 0x0007F3BC
	// (set) Token: 0x06001F48 RID: 8008 RVA: 0x000811C4 File Offset: 0x0007F3C4
	[JsonProperty("OnWith")]
	public List<string> List_3
	{
		get
		{
			return this.list_4;
		}
		set
		{
			this.list_4 = value;
		}
	}

	// Token: 0x170004EC RID: 1260
	// (get) Token: 0x06001F49 RID: 8009 RVA: 0x000811D0 File Offset: 0x0007F3D0
	// (set) Token: 0x06001F4A RID: 8010 RVA: 0x000811D8 File Offset: 0x0007F3D8
	[JsonProperty("Type")]
	public string Type
	{
		[CompilerGenerated]
		get
		{
			return this.string_5;
		}
		[CompilerGenerated]
		set
		{
			this.string_5 = value;
		}
	}

	// Token: 0x170004ED RID: 1261
	// (get) Token: 0x06001F4B RID: 8011 RVA: 0x000811E4 File Offset: 0x0007F3E4
	// (set) Token: 0x06001F4C RID: 8012 RVA: 0x000811EC File Offset: 0x0007F3EC
	[JsonProperty("Tweaks")]
	public List<GClass67> List_4
	{
		get
		{
			return this.list_5;
		}
		set
		{
			this.list_5 = value;
		}
	}

	// Token: 0x06001F4D RID: 8013 RVA: 0x000811F8 File Offset: 0x0007F3F8
	public bool method_0()
	{
		return this.List_4.Any(new Func<GClass67, bool>(GClass179.Class649.class649_0.method_0));
	}

	// Token: 0x06001F4E RID: 8014 RVA: 0x00081224 File Offset: 0x0007F424
	public bool method_1()
	{
		if (this.Type != "DOUBLE")
		{
			return true;
		}
		return this.List_4.All(new Func<GClass67, bool>(GClass179.Class649.class649_0.method_1));
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x00081264 File Offset: 0x0007F464
	public bool method_2()
	{
		if (this.Type != "DOUBLE")
		{
			return true;
		}
		foreach (GClass67 gclass in this.List_4)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			foreach (GClass72 gclass2 in gclass.Values)
			{
				if (gclass2.ContainsOn)
				{
					flag = true;
				}
				if (gclass2.ContainsOff)
				{
					flag2 = true;
				}
				if (gclass2.ContainsBest)
				{
					flag3 = true;
				}
				if (gclass2.ContainsDefault)
				{
					flag4 = true;
				}
			}
			if (!flag || !flag2 || !flag3 || !flag4)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x00081344 File Offset: 0x0007F544
	public bool method_3()
	{
		if (this.Type != "DOUBLE")
		{
			return true;
		}
		foreach (GClass67 gclass in this.List_4)
		{
			foreach (GClass72 gclass2 in gclass.Values)
			{
				if (gclass2.ContainsOn && gclass2.ContainsOff)
				{
					return false;
				}
				if (gclass2.ContainsBest && gclass2.ContainsDefault)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x0008142C File Offset: 0x0007F62C
	public bool method_4()
	{
		return this.List_4.Any(new Func<GClass67, bool>(GClass179.Class649.class649_0.method_2));
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x00081458 File Offset: 0x0007F658
	public bool method_5()
	{
		return this.List_4.Any(new Func<GClass67, bool>(GClass179.Class649.class649_0.method_3));
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x00081484 File Offset: 0x0007F684
	public bool method_6()
	{
		return this.List_4.Any(new Func<GClass67, bool>(GClass179.Class649.class649_0.method_4));
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x000814B0 File Offset: 0x0007F6B0
	public string method_7(bool bool_1)
	{
		if (this.List_4.Any(new Func<GClass67, bool>(GClass179.Class649.class649_0.method_5)))
		{
			return Class453.smethod_4(this.List_4.First(new Func<GClass67, bool>(GClass179.Class649.class649_0.method_6)).Path);
		}
		return Class453.smethod_2(this, bool_1);
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x00081528 File Offset: 0x0007F728
	public string method_8()
	{
		return Class453.smethod_3(this);
	}

	// Token: 0x040015DC RID: 5596
	private Guid guid_0;

	// Token: 0x040015DD RID: 5597
	private bool bool_0;

	// Token: 0x040015DE RID: 5598
	private string string_0;

	// Token: 0x040015DF RID: 5599
	private string string_1;

	// Token: 0x040015E0 RID: 5600
	private string string_2;

	// Token: 0x040015E1 RID: 5601
	private List<string> list_0 = new List<string>();

	// Token: 0x040015E2 RID: 5602
	private int int_0;

	// Token: 0x040015E3 RID: 5603
	private string string_3 = string.Empty;

	// Token: 0x040015E4 RID: 5604
	private int int_1;

	// Token: 0x040015E5 RID: 5605
	private string string_4;

	// Token: 0x040015E6 RID: 5606
	private List<string> list_1;

	// Token: 0x040015E7 RID: 5607
	private List<string> list_2 = new List<string>();

	// Token: 0x040015E8 RID: 5608
	private List<string> list_3;

	// Token: 0x040015E9 RID: 5609
	private List<string> list_4;

	// Token: 0x040015EA RID: 5610
	private string string_5;

	// Token: 0x040015EB RID: 5611
	private List<GClass67> list_5;

	// Token: 0x020005A9 RID: 1449
	[Serializable]
	private sealed class Class649
	{
		// Token: 0x06001F58 RID: 8024 RVA: 0x00081544 File Offset: 0x0007F744
		internal bool method_0(GClass67 gclass67_0)
		{
			return gclass67_0.method_0();
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x0008154C File Offset: 0x0007F74C
		internal bool method_1(GClass67 gclass67_0)
		{
			return gclass67_0.Values.Count<GClass72>() == 2;
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x0008155C File Offset: 0x0007F75C
		internal bool method_2(GClass67 gclass67_0)
		{
			return gclass67_0.method_1();
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00081564 File Offset: 0x0007F764
		internal bool method_3(GClass67 gclass67_0)
		{
			return gclass67_0.method_2();
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0008156C File Offset: 0x0007F76C
		internal bool method_4(GClass67 gclass67_0)
		{
			return gclass67_0.method_3();
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00081574 File Offset: 0x0007F774
		internal bool method_5(GClass67 gclass67_0)
		{
			return gclass67_0.String_0 == "CHECK";
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00081588 File Offset: 0x0007F788
		internal bool method_6(GClass67 gclass67_0)
		{
			return gclass67_0.String_0 == "CHECK";
		}

		// Token: 0x040015EC RID: 5612
		public static readonly GClass179.Class649 class649_0 = new GClass179.Class649();

		// Token: 0x040015ED RID: 5613
		public static Func<GClass67, bool> func_0;

		// Token: 0x040015EE RID: 5614
		public static Func<GClass67, bool> func_1;

		// Token: 0x040015EF RID: 5615
		public static Func<GClass67, bool> func_2;

		// Token: 0x040015F0 RID: 5616
		public static Func<GClass67, bool> func_3;

		// Token: 0x040015F1 RID: 5617
		public static Func<GClass67, bool> func_4;

		// Token: 0x040015F2 RID: 5618
		public static Func<GClass67, bool> func_5;

		// Token: 0x040015F3 RID: 5619
		public static Func<GClass67, bool> func_6;
	}
}
