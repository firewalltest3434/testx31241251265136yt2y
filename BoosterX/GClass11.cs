using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using ns0;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x02000483 RID: 1155
public sealed class GClass11 : GClass7
{
	// Token: 0x06001992 RID: 6546 RVA: 0x00068BC4 File Offset: 0x00066DC4
	public GClass11(GClass42 gclass42_1, GClass8 gclass8_1) : base(gclass42_1, gclass8_1)
	{
		this.list_0 = this.method_20();
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x00068BDC File Offset: 0x00066DDC
	private List<uint> method_20()
	{
		return base.method_2<List<uint>>(new Func<IntPtr, List<uint>>(this.method_40), false);
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x00068BF4 File Offset: 0x00066DF4
	private string method_21()
	{
		foreach (string path in Directory.EnumerateDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "NVIDIA Corporation\\Installer2"), "Display.Driver.*"))
		{
			FileInfo fileInfo = new FileInfo(Path.Combine(path, "dbInstaller.exe"));
			if (fileInfo.Exists)
			{
				string text = FileVersionInfo.GetVersionInfo(fileInfo.FullName).FileVersion.Replace(".", string.Empty);
				string value = this.float_0.ToString().Replace(",", string.Empty).Replace(".", string.Empty);
				if (text.EndsWith(value))
				{
					return fileInfo.DirectoryName;
				}
			}
		}
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "NVIDIA Corporation\\Drs");
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x00068CE0 File Offset: 0x00066EE0
	private void method_22()
	{
		string text = this.method_21();
		Process.Start(new ProcessStartInfo
		{
			UseShellExecute = true,
			WorkingDirectory = text,
			Arguments = "-init",
			FileName = Path.Combine(text, "dbInstaller.exe")
		}).WaitForExit();
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x00068D30 File Offset: 0x00066F30
	public void method_23()
	{
		GClass11.Class550 @class = new GClass11.Class550();
		@class.gclass11_0 = this;
		@class.string_0 = "C:\\Users\\Administrator\\AppData\\Local\\Temp\\9ac2b8af59e048a1955a13cc00e7a0cb";
		try
		{
			File.WriteAllText(@class.string_0, "BaseProfile \"Base Profile\"\r\nSelectedGlobalProfile \"Base Profile\"\r\nProfile \"Base Profile\"\r\nShowOn All\r\nProfileType Global\r\nEndProfile\r\n");
			base.method_1(new Action<IntPtr>(@class.method_0), true, true);
		}
		finally
		{
			if (File.Exists(@class.string_0))
			{
				File.Delete(@class.string_0);
			}
		}
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x00068DA4 File Offset: 0x00066FA4
	public void method_24(string string_0)
	{
		GClass11.Class554 @class = new GClass11.Class554();
		@class.gclass11_0 = this;
		@class.string_1 = string_0;
		@class.string_0 = "C:\\Users\\Administrator\\AppData\\Local\\Temp\\48952a85f24746b48af9c844fc7daa5b";
		try
		{
			GClass11.Class546 class2 = new GClass11.Class546();
			class2.class554_0 = @class;
			class2.string_0 = string.Empty;
			base.method_1(new Action<IntPtr>(class2.method_0), false, false);
			if (class2.string_0 != string.Empty)
			{
				base.method_1(new Action<IntPtr>(class2.class554_0.method_0), false, false);
			}
		}
		finally
		{
			if (File.Exists(@class.string_0))
			{
				File.Delete(@class.string_0);
			}
		}
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x00068E54 File Offset: 0x00067054
	public void method_25(string string_0)
	{
		base.method_1(new Action<IntPtr>(new GClass11.Class545
		{
			gclass11_0 = this,
			string_0 = string_0
		}.method_0), false, false);
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x00068E8C File Offset: 0x0006708C
	public List<GClass136> method_26(ref GClass136 gclass136_0)
	{
		GClass11.Class539 @class = new GClass11.Class539();
		@class.gclass11_0 = this;
		@class.list_0 = new List<GClass136>();
		@class.gclass136_0 = null;
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		gclass136_0 = @class.gclass136_0;
		return @class.list_0;
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x00068EDC File Offset: 0x000670DC
	public void method_27(string string_0, string string_1)
	{
		base.method_1(new Action<IntPtr>(new GClass11.Class542
		{
			gclass11_0 = this,
			string_0 = string_0,
			string_1 = string_1
		}.method_0), false, false);
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x00068F18 File Offset: 0x00067118
	public void method_28()
	{
		base.method_1(new Action<IntPtr>(this.method_41), false, false);
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x00068F30 File Offset: 0x00067130
	public void method_29(string string_0, out bool bool_0)
	{
		GClass11.Class541 @class = new GClass11.Class541();
		@class.gclass11_0 = this;
		@class.string_0 = string_0;
		@class.bool_0 = false;
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		bool_0 = @class.bool_0;
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x00068F74 File Offset: 0x00067174
	public void method_30(string string_0, uint uint_0, out bool bool_0)
	{
		GClass11.Class543 @class = new GClass11.Class543();
		@class.gclass11_0 = this;
		@class.string_0 = string_0;
		@class.uint_0 = uint_0;
		@class.bool_0 = false;
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		bool_0 = @class.bool_0;
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x00068FC0 File Offset: 0x000671C0
	public void method_31(string string_0, uint uint_0, out bool bool_0)
	{
		GClass11.Class547 @class = new GClass11.Class547();
		@class.gclass11_0 = this;
		@class.string_0 = string_0;
		@class.uint_0 = uint_0;
		@class.bool_0 = false;
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		bool_0 = @class.bool_0;
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x0006900C File Offset: 0x0006720C
	public uint method_32(string string_0, uint uint_0, bool bool_0, bool bool_1)
	{
		return base.method_2<uint>(new Func<IntPtr, uint>(new GClass11.Class548
		{
			gclass11_0 = this,
			string_0 = string_0,
			uint_0 = uint_0,
			bool_0 = bool_0
		}.method_0), false);
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x00069050 File Offset: 0x00067250
	public void method_33(string string_0, uint uint_0, uint uint_1)
	{
		base.method_1(new Action<IntPtr>(new GClass11.Class553
		{
			gclass11_0 = this,
			string_0 = string_0,
			uint_0 = uint_0,
			uint_1 = uint_1
		}.method_0), false, false);
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x00069094 File Offset: 0x00067294
	public int method_34(GClass136 gclass136_0, IEnumerable<GClass79> ienumerable_0)
	{
		base.method_1(new Action<IntPtr>(new GClass11.Class540
		{
			gclass11_0 = this,
			gclass136_0 = gclass136_0,
			ienumerable_0 = ienumerable_0
		}.method_0), false, false);
		return 0;
	}

	// Token: 0x060019A2 RID: 6562 RVA: 0x000690D4 File Offset: 0x000672D4
	private GClass79 method_35(GStruct1 gstruct1_0, bool bool_0)
	{
		GClass69 gclass = this.gclass42_0.method_16(gstruct1_0.uint_1, (GEnum78)0);
		gclass.method_1(new NVDRS_SETTING_TYPE?(gstruct1_0.nvdrs_SETTING_TYPE_0));
		if (gclass.method_18() == null)
		{
			gclass.method_19(new List<GClass58<uint>>());
		}
		if (gclass.method_16() == null)
		{
			gclass.method_17(new List<GClass58<string>>());
		}
		if (gclass.method_20() == null)
		{
			gclass.method_21(new List<GClass58<byte[]>>());
		}
		dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd state = dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd.NotAssiged;
		string string_ = string.Empty;
		string string_2 = string.Empty;
		object object_ = null;
		NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = gclass.method_0();
		if (nvdrs_SETTING_TYPE.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE & nvdrs_SETTING_TYPE != null)
		{
			if (bool_0)
			{
				string_ = GClass166.smethod_0(gclass.method_8());
				string_2 = GClass166.smethod_3(gclass, gclass.method_8());
				object_ = gclass.method_8();
			}
			else if (gstruct1_0.uint_2 == 1U && gstruct1_0.uint_3 == 1U)
			{
				string_ = GClass166.smethod_0(gstruct1_0.nvdrs_SETTING_UNION_0.dwordValue);
				string_2 = GClass166.smethod_3(gclass, gstruct1_0.nvdrs_SETTING_UNION_0.dwordValue);
				object_ = gstruct1_0.nvdrs_SETTING_UNION_0.dwordValue;
				if (gstruct1_0.genum1_0 == (GEnum1)0)
				{
					state = dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd.NvidiaSetting;
				}
				else
				{
					state = dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd.GlobalSetting;
				}
			}
			else
			{
				string_ = GClass166.smethod_0(gstruct1_0.nvdrs_SETTING_UNION_1.dwordValue);
				string_2 = GClass166.smethod_3(gclass, gstruct1_0.nvdrs_SETTING_UNION_1.dwordValue);
				object_ = gstruct1_0.nvdrs_SETTING_UNION_1.dwordValue;
				if (gstruct1_0.genum1_0 == (GEnum1)0)
				{
					state = dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd.UserdefinedSetting;
				}
				else
				{
					state = dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd.GlobalSetting;
				}
			}
		}
		nvdrs_SETTING_TYPE = gclass.method_0();
		if (nvdrs_SETTING_TYPE.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE & nvdrs_SETTING_TYPE != null)
		{
			if (bool_0)
			{
				string_ = gclass.method_6();
				string_2 = GClass166.smethod_5(gclass, gclass.method_6());
				object_ = gclass.method_6();
			}
			else if (gstruct1_0.uint_2 == 1U && gstruct1_0.uint_3 == 1U)
			{
				string_ = gstruct1_0.nvdrs_SETTING_UNION_0.stringValue;
				string_2 = GClass166.smethod_5(gclass, gstruct1_0.nvdrs_SETTING_UNION_0.stringValue);
				object_ = gstruct1_0.nvdrs_SETTING_UNION_0.stringValue;
				state = dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd.NvidiaSetting;
			}
			else
			{
				string_ = gstruct1_0.nvdrs_SETTING_UNION_1.stringValue;
				string_2 = GClass166.smethod_5(gclass, gstruct1_0.nvdrs_SETTING_UNION_1.stringValue);
				object_ = gstruct1_0.nvdrs_SETTING_UNION_1.stringValue;
				if (gstruct1_0.genum1_0 == (GEnum1)0)
				{
					state = dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd.UserdefinedSetting;
				}
				else
				{
					state = dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd.GlobalSetting;
				}
			}
		}
		nvdrs_SETTING_TYPE = gclass.method_0();
		if (nvdrs_SETTING_TYPE.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE & nvdrs_SETTING_TYPE != null)
		{
			if (bool_0)
			{
				string_ = GClass166.smethod_6(gclass.method_10());
				string_2 = GClass166.smethod_7(gclass, gclass.method_10());
				object_ = gclass.method_10();
			}
			else if (gstruct1_0.uint_2 == 1U && gstruct1_0.uint_3 == 1U)
			{
				string_ = GClass166.smethod_6(gstruct1_0.nvdrs_SETTING_UNION_0.binaryValue);
				string_2 = GClass166.smethod_7(gclass, gstruct1_0.nvdrs_SETTING_UNION_0.binaryValue);
				object_ = gstruct1_0.nvdrs_SETTING_UNION_0.binaryValue;
				state = dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd.NvidiaSetting;
			}
			else
			{
				string_ = GClass166.smethod_6(gstruct1_0.nvdrs_SETTING_UNION_1.binaryValue);
				string_2 = GClass166.smethod_7(gclass, gstruct1_0.nvdrs_SETTING_UNION_1.binaryValue);
				object_ = gstruct1_0.nvdrs_SETTING_UNION_1.binaryValue;
				if (gstruct1_0.genum1_0 == (GEnum1)0)
				{
					state = dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd.UserdefinedSetting;
				}
				else
				{
					state = dje_zTE684NXDJN58YBDZT86VHE9HCBGE8LPNBYXD94Y7_ejd.GlobalSetting;
				}
			}
		}
		GClass79 gclass2 = new GClass79();
		gclass2.method_1(gstruct1_0.uint_1);
		gclass2.method_3(gclass.method_4());
		gclass2.method_11(gclass.method_2());
		gclass2.method_9(object_);
		gclass2.method_7(string_);
		gclass2.method_5(string_2);
		gclass2.State = state;
		nvdrs_SETTING_TYPE = gclass.method_0();
		gclass2.method_13(nvdrs_SETTING_TYPE.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE & nvdrs_SETTING_TYPE != null);
		gclass2.method_15(gclass.method_12());
		gclass2.method_17(gclass.method_14());
		return gclass2;
	}

	// Token: 0x060019A3 RID: 6563 RVA: 0x00069450 File Offset: 0x00067650
	public List<GClass79> method_36(string string_0, GEnum78 genum78_0, ref Dictionary<string, string> dictionary_0)
	{
		GClass11.Class551 @class = new GClass11.Class551();
		@class.gclass11_0 = this;
		@class.string_0 = string_0;
		@class.list_0 = new List<GClass79>();
		@class.list_1 = this.gclass42_0.method_11(genum78_0);
		@class.list_1.AddRange(this.list_0);
		@class.list_1 = @class.list_1.Distinct<uint>().ToList<uint>();
		dictionary_0 = base.method_2<Dictionary<string, string>>(new Func<IntPtr, Dictionary<string, string>>(@class.method_0), false);
		return @class.list_0.OrderBy(new Func<GClass79, string>(GClass11.Class549.class549_0.method_3)).ThenBy(new Func<GClass79, string>(GClass11.Class549.class549_0.method_4)).ToList<GClass79>();
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x00069520 File Offset: 0x00067720
	public void method_37(string string_0, string string_1)
	{
		base.method_1(new Action<IntPtr>(new GClass11.Class552
		{
			gclass11_0 = this,
			string_0 = string_0,
			string_1 = string_1
		}.method_0), false, false);
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x0006955C File Offset: 0x0006775C
	public void method_38(string string_0, string string_1)
	{
		base.method_1(new Action<IntPtr>(new GClass11.Class544
		{
			gclass11_0 = this,
			string_0 = string_0,
			string_1 = string_1
		}.method_0), false, false);
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x00069598 File Offset: 0x00067798
	private string method_39(GStruct7 gstruct7_0)
	{
		return string.Concat(new string[]
		{
			gstruct7_0.string_0,
			"|",
			gstruct7_0.string_3,
			"|",
			gstruct7_0.string_1,
			"|",
			gstruct7_0.string_2
		});
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x000695EC File Offset: 0x000677EC
	private List<uint> method_40(IntPtr intptr_0)
	{
		IntPtr intptr_ = base.method_3(intptr_0, string.Empty);
		return base.method_15(intptr_0, intptr_).Select(new Func<GStruct1, uint>(GClass11.Class549.class549_0.method_0)).ToList<uint>();
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x00069638 File Offset: 0x00067838
	private void method_41(IntPtr intptr_0)
	{
		GEnum0 genum = GClass202.gdelegate8_0(intptr_0);
		if (genum != GEnum0.NVAPI_OK)
		{
			throw new GException7("DRS_RestoreAllDefaults", genum);
		}
		base.method_17(intptr_0);
	}

	// Token: 0x040011CB RID: 4555
	private readonly List<uint> list_0;

	// Token: 0x02000484 RID: 1156
	private sealed class Class539
	{
		// Token: 0x060019AA RID: 6570 RVA: 0x00069670 File Offset: 0x00067870
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass11_0.method_3(intptr_0, null);
			GStruct3 gstruct3_ = this.gclass11_0.method_5(intptr_0, intptr_);
			this.gclass136_0 = new GClass136(gstruct3_);
			this.list_0.Add(this.gclass136_0);
			foreach (IntPtr intptr_2 in this.gclass11_0.method_14(intptr_0))
			{
				GStruct3 gstruct = this.gclass11_0.method_5(intptr_0, intptr_2);
				if (gstruct.uint_1 == 0U || gstruct.uint_2 > 0U)
				{
					this.list_0.Add(new GClass136(gstruct));
				}
			}
		}

		// Token: 0x040011CC RID: 4556
		public GClass11 gclass11_0;

		// Token: 0x040011CD RID: 4557
		public GClass136 gclass136_0;

		// Token: 0x040011CE RID: 4558
		public List<GClass136> list_0;
	}

	// Token: 0x02000485 RID: 1157
	private sealed class Class540
	{
		// Token: 0x060019AC RID: 6572 RVA: 0x00069738 File Offset: 0x00067938
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass11_0.method_3(intptr_0, this.gclass136_0.ProfileName);
			foreach (GClass79 gclass in this.ienumerable_0)
			{
				GClass69 gclass2 = this.gclass11_0.gclass42_0.method_16(gclass.method_0(), (GEnum78)0);
				NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = gclass2.method_0();
				NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
				if (nvdrs_SETTING_TYPE2.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE & nvdrs_SETTING_TYPE2 != null)
				{
					uint uint_ = GClass166.smethod_2(gclass2, gclass.method_4());
					this.gclass11_0.method_7(intptr_0, intptr_, gclass.method_0(), uint_);
				}
				else
				{
					nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
					if (nvdrs_SETTING_TYPE2.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE & nvdrs_SETTING_TYPE2 != null)
					{
						string string_ = GClass166.smethod_4(gclass2, gclass.method_4());
						this.gclass11_0.method_8(intptr_0, intptr_, gclass.method_0(), string_);
					}
					else
					{
						nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
						if (nvdrs_SETTING_TYPE2.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE & nvdrs_SETTING_TYPE2 != null)
						{
							byte[] byte_ = GClass166.smethod_8(gclass2, gclass.method_4());
							this.gclass11_0.method_9(intptr_0, intptr_, gclass.method_0(), byte_);
						}
					}
				}
			}
			this.gclass11_0.method_17(intptr_0);
		}

		// Token: 0x040011CF RID: 4559
		public GClass11 gclass11_0;

		// Token: 0x040011D0 RID: 4560
		public GClass136 gclass136_0;

		// Token: 0x040011D1 RID: 4561
		public IEnumerable<GClass79> ienumerable_0;
	}

	// Token: 0x02000486 RID: 1158
	private sealed class Class541
	{
		// Token: 0x060019AE RID: 6574 RVA: 0x0006988C File Offset: 0x00067A8C
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass11_0.method_3(intptr_0, this.string_0);
			GStruct3 gstruct = this.gclass11_0.method_5(intptr_0, intptr_);
			if (gstruct.uint_1 != 1U)
			{
				if (gstruct.uint_3 > 0U)
				{
					int num = 0;
					foreach (GStruct1 gstruct2 in this.gclass11_0.method_15(intptr_0, intptr_))
					{
						if (gstruct2.genum1_0 == (GEnum1)0 && GClass202.gdelegate6_0(intptr_0, intptr_, gstruct2.uint_1) == GEnum0.NVAPI_OK)
						{
							num++;
						}
					}
					if (num > 0)
					{
						this.gclass11_0.method_17(intptr_0);
					}
				}
				return;
			}
			GEnum0 genum = GClass202.gdelegate26_0(intptr_0, intptr_);
			if (genum != GEnum0.NVAPI_OK)
			{
				throw new GException7("DRS_RestoreProfileDefault", genum);
			}
			this.gclass11_0.method_17(intptr_0);
			this.bool_0 = true;
		}

		// Token: 0x040011D2 RID: 4562
		public GClass11 gclass11_0;

		// Token: 0x040011D3 RID: 4563
		public string string_0;

		// Token: 0x040011D4 RID: 4564
		public bool bool_0;
	}

	// Token: 0x02000487 RID: 1159
	private sealed class Class542
	{
		// Token: 0x060019B0 RID: 6576 RVA: 0x00069984 File Offset: 0x00067B84
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass11_0.method_4(intptr_0, this.string_0);
			if (this.string_1 != null)
			{
				this.gclass11_0.method_12(intptr_0, intptr_, this.string_1);
			}
			this.gclass11_0.method_17(intptr_0);
		}

		// Token: 0x040011D5 RID: 4565
		public GClass11 gclass11_0;

		// Token: 0x040011D6 RID: 4566
		public string string_0;

		// Token: 0x040011D7 RID: 4567
		public string string_1;
	}

	// Token: 0x02000488 RID: 1160
	private sealed class Class543
	{
		// Token: 0x060019B2 RID: 6578 RVA: 0x000699D4 File Offset: 0x00067BD4
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intPtr = this.gclass11_0.method_3(intptr_0, this.string_0);
			if (intPtr != IntPtr.Zero)
			{
				GEnum0 genum = GClass202.gdelegate35_0(intptr_0, intPtr, this.uint_0);
				if (genum != GEnum0.NVAPI_OK)
				{
					throw new GException7("DRS_RestoreProfileDefaultSetting", genum);
				}
				this.gclass11_0.method_17(intptr_0);
				int num = 0;
				foreach (GStruct1 gstruct in this.gclass11_0.method_15(intptr_0, intPtr))
				{
					if (gstruct.uint_2 == 0U && gstruct.genum1_0 == (GEnum1)0)
					{
						num++;
					}
				}
				this.bool_0 = (num == 0);
			}
		}

		// Token: 0x040011D8 RID: 4568
		public GClass11 gclass11_0;

		// Token: 0x040011D9 RID: 4569
		public string string_0;

		// Token: 0x040011DA RID: 4570
		public uint uint_0;

		// Token: 0x040011DB RID: 4571
		public bool bool_0;
	}

	// Token: 0x02000489 RID: 1161
	private sealed class Class544
	{
		// Token: 0x060019B4 RID: 6580 RVA: 0x00069AA4 File Offset: 0x00067CA4
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass11_0.method_3(intptr_0, this.string_0);
			foreach (GStruct7 gstruct7_ in this.gclass11_0.method_16(intptr_0, intptr_))
			{
				if (!(this.gclass11_0.method_39(gstruct7_) != this.string_1))
				{
					this.gclass11_0.method_13(intptr_0, intptr_, gstruct7_);
					break;
				}
			}
			this.gclass11_0.method_17(intptr_0);
		}

		// Token: 0x040011DC RID: 4572
		public GClass11 gclass11_0;

		// Token: 0x040011DD RID: 4573
		public string string_0;

		// Token: 0x040011DE RID: 4574
		public string string_1;
	}

	// Token: 0x0200048A RID: 1162
	private sealed class Class545
	{
		// Token: 0x060019B6 RID: 6582 RVA: 0x00069B48 File Offset: 0x00067D48
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intPtr = this.gclass11_0.method_3(intptr_0, this.string_0);
			if (intPtr != IntPtr.Zero)
			{
				GEnum0 genum = GClass202.gdelegate18_0(intptr_0, intPtr);
				if (genum != GEnum0.NVAPI_OK)
				{
					throw new GException7("DRS_DeleteProfile", genum);
				}
				this.gclass11_0.method_17(intptr_0);
			}
		}

		// Token: 0x040011DF RID: 4575
		public GClass11 gclass11_0;

		// Token: 0x040011E0 RID: 4576
		public string string_0;
	}

	// Token: 0x0200048B RID: 1163
	private sealed class Class546
	{
		// Token: 0x060019B8 RID: 6584 RVA: 0x00069BA8 File Offset: 0x00067DA8
		internal void method_0(IntPtr intptr_0)
		{
			this.class554_0.gclass11_0.method_19(intptr_0, this.class554_0.string_0);
			this.string_0 = File.ReadAllText(this.class554_0.string_0);
			string pattern = "(?<rpl>\nProfile\\s\"" + Regex.Escape(this.class554_0.string_1) + "\".*?EndProfile.*?\n)";
			this.string_0 = Regex.Replace(this.string_0, pattern, string.Empty, RegexOptions.Singleline);
			File.WriteAllText(this.class554_0.string_0, this.string_0);
		}

		// Token: 0x040011E1 RID: 4577
		public string string_0;

		// Token: 0x040011E2 RID: 4578
		public GClass11.Class554 class554_0;
	}

	// Token: 0x0200048C RID: 1164
	private sealed class Class547
	{
		// Token: 0x060019BA RID: 6586 RVA: 0x00069C40 File Offset: 0x00067E40
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intPtr = this.gclass11_0.method_3(intptr_0, this.string_0);
			if (intPtr != IntPtr.Zero)
			{
				int num = 0;
				foreach (GStruct1 gstruct in this.gclass11_0.method_15(intptr_0, intPtr))
				{
					if (gstruct.uint_1 == this.uint_0 && gstruct.genum1_0 == (GEnum1)0 && GClass202.gdelegate6_0(intptr_0, intPtr, gstruct.uint_1) == GEnum0.NVAPI_OK)
					{
						num++;
						break;
					}
				}
				this.bool_0 = (num == 0);
				this.gclass11_0.method_17(intptr_0);
			}
		}

		// Token: 0x040011E3 RID: 4579
		public GClass11 gclass11_0;

		// Token: 0x040011E4 RID: 4580
		public string string_0;

		// Token: 0x040011E5 RID: 4581
		public uint uint_0;

		// Token: 0x040011E6 RID: 4582
		public bool bool_0;
	}

	// Token: 0x0200048D RID: 1165
	private sealed class Class548
	{
		// Token: 0x060019BC RID: 6588 RVA: 0x00069D04 File Offset: 0x00067F04
		internal uint method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass11_0.method_3(intptr_0, this.string_0);
			uint? num = this.gclass11_0.method_11(intptr_0, intptr_, this.uint_0);
			if (num != null)
			{
				return num.Value;
			}
			if (!this.bool_0)
			{
				throw new GException7("DRS_GetSetting", GEnum0.NVAPI_SETTING_NOT_FOUND);
			}
			return this.gclass11_0.gclass42_0.method_16(this.uint_0, (GEnum78)0).method_8();
		}

		// Token: 0x040011E7 RID: 4583
		public GClass11 gclass11_0;

		// Token: 0x040011E8 RID: 4584
		public string string_0;

		// Token: 0x040011E9 RID: 4585
		public uint uint_0;

		// Token: 0x040011EA RID: 4586
		public bool bool_0;
	}

	// Token: 0x0200048E RID: 1166
	[Serializable]
	private sealed class Class549
	{
		// Token: 0x060019BF RID: 6591 RVA: 0x00069D94 File Offset: 0x00067F94
		internal uint method_0(GStruct1 gstruct1_0)
		{
			return gstruct1_0.uint_1;
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00069D9C File Offset: 0x00067F9C
		internal string method_1(Tuple<string, string> tuple_0)
		{
			return tuple_0.Item2;
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00069DA4 File Offset: 0x00067FA4
		internal string method_2(Tuple<string, string> tuple_0)
		{
			return tuple_0.Item1;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00069DAC File Offset: 0x00067FAC
		internal string method_3(GClass79 gclass79_0)
		{
			return gclass79_0.method_2();
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00069DB4 File Offset: 0x00067FB4
		internal string method_4(GClass79 gclass79_0)
		{
			return gclass79_0.method_10();
		}

		// Token: 0x040011EB RID: 4587
		public static readonly GClass11.Class549 class549_0 = new GClass11.Class549();

		// Token: 0x040011EC RID: 4588
		public static Func<GStruct1, uint> func_0;

		// Token: 0x040011ED RID: 4589
		public static Func<Tuple<string, string>, string> func_1;

		// Token: 0x040011EE RID: 4590
		public static Func<Tuple<string, string>, string> func_2;

		// Token: 0x040011EF RID: 4591
		public static Func<GClass79, string> func_3;

		// Token: 0x040011F0 RID: 4592
		public static Func<GClass79, string> func_4;
	}

	// Token: 0x0200048F RID: 1167
	private sealed class Class550
	{
		// Token: 0x060019C5 RID: 6597 RVA: 0x00069DC4 File Offset: 0x00067FC4
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass11_0.method_18(intptr_0, this.string_0);
			this.gclass11_0.method_17(intptr_0);
		}

		// Token: 0x040011F1 RID: 4593
		public GClass11 gclass11_0;

		// Token: 0x040011F2 RID: 4594
		public string string_0;
	}

	// Token: 0x02000490 RID: 1168
	private sealed class Class551
	{
		// Token: 0x060019C7 RID: 6599 RVA: 0x00069DEC File Offset: 0x00067FEC
		internal Dictionary<string, string> method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass11_0.method_3(intptr_0, this.string_0);
			foreach (GStruct1 gstruct in this.gclass11_0.method_15(intptr_0, intptr_))
			{
				this.list_0.Add(this.gclass11_0.method_35(gstruct, false));
				if (this.list_1.Contains(gstruct.uint_1))
				{
					this.list_1.Remove(gstruct.uint_1);
				}
			}
			foreach (uint num in this.list_1)
			{
				if (num != 0U)
				{
					GStruct1? gstruct2 = this.gclass11_0.method_10(intptr_0, intptr_, num);
					if (gstruct2 != null)
					{
						this.list_0.Add(this.gclass11_0.method_35(gstruct2.Value, false));
					}
					else
					{
						GStruct1 gstruct1_ = new GStruct1
						{
							uint_1 = num
						};
						this.list_0.Add(this.gclass11_0.method_35(gstruct1_, true));
					}
				}
			}
			IEnumerable<GStruct7> source = this.gclass11_0.method_16(intptr_0, intptr_);
			Func<GStruct7, Tuple<string, string>> selector;
			if ((selector = this.func_0) == null)
			{
				selector = (this.func_0 = new Func<GStruct7, Tuple<string, string>>(this.method_1));
			}
			return source.Select(selector).ToDictionary(new Func<Tuple<string, string>, string>(GClass11.Class549.class549_0.method_1), new Func<Tuple<string, string>, string>(GClass11.Class549.class549_0.method_2));
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00069FAC File Offset: 0x000681AC
		internal Tuple<string, string> method_1(GStruct7 gstruct7_0)
		{
			return Tuple.Create<string, string>(gstruct7_0.string_0, this.gclass11_0.method_39(gstruct7_0));
		}

		// Token: 0x040011F3 RID: 4595
		public GClass11 gclass11_0;

		// Token: 0x040011F4 RID: 4596
		public string string_0;

		// Token: 0x040011F5 RID: 4597
		public List<GClass79> list_0;

		// Token: 0x040011F6 RID: 4598
		public List<uint> list_1;

		// Token: 0x040011F7 RID: 4599
		public Func<GStruct7, Tuple<string, string>> func_0;
	}

	// Token: 0x02000491 RID: 1169
	private sealed class Class552
	{
		// Token: 0x060019CA RID: 6602 RVA: 0x00069FD0 File Offset: 0x000681D0
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass11_0.method_3(intptr_0, this.string_0);
			this.gclass11_0.method_12(intptr_0, intptr_, this.string_1);
			this.gclass11_0.method_17(intptr_0);
		}

		// Token: 0x040011F8 RID: 4600
		public GClass11 gclass11_0;

		// Token: 0x040011F9 RID: 4601
		public string string_0;

		// Token: 0x040011FA RID: 4602
		public string string_1;
	}

	// Token: 0x02000492 RID: 1170
	private sealed class Class553
	{
		// Token: 0x060019CC RID: 6604 RVA: 0x0006A018 File Offset: 0x00068218
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass11_0.method_3(intptr_0, this.string_0);
			this.gclass11_0.method_7(intptr_0, intptr_, this.uint_0, this.uint_1);
			this.gclass11_0.method_17(intptr_0);
		}

		// Token: 0x040011FB RID: 4603
		public GClass11 gclass11_0;

		// Token: 0x040011FC RID: 4604
		public string string_0;

		// Token: 0x040011FD RID: 4605
		public uint uint_0;

		// Token: 0x040011FE RID: 4606
		public uint uint_1;
	}

	// Token: 0x02000493 RID: 1171
	private sealed class Class554
	{
		// Token: 0x060019CE RID: 6606 RVA: 0x0006A068 File Offset: 0x00068268
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass11_0.method_18(intptr_0, this.string_0);
			this.gclass11_0.method_17(intptr_0);
		}

		// Token: 0x040011FF RID: 4607
		public GClass11 gclass11_0;

		// Token: 0x04001200 RID: 4608
		public string string_0;

		// Token: 0x04001201 RID: 4609
		public string string_1;
	}
}
