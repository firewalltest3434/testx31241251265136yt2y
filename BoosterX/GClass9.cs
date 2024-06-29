using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NvidiaX.NVIDIA.Classes;
using NvidiaX.NVIDIA.Classes.Import;
using NvidiaX.NVIDIA.Enums;

// Token: 0x020002B5 RID: 693
public sealed class GClass9 : GClass7
{
	// Token: 0x0600100D RID: 4109 RVA: 0x000440C0 File Offset: 0x000422C0
	public GClass9(GClass42 gclass42_1, GClass11 gclass11_1, GClass10 gclass10_1, GClass8 gclass8_2) : base(gclass42_1, null)
	{
		this.gclass11_0 = gclass11_1;
		this.gclass10_0 = gclass10_1;
		this.gclass8_1 = gclass8_2;
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x000440E0 File Offset: 0x000422E0
	public void method_20(string string_0)
	{
		base.method_1(new Action<IntPtr>(new GClass9.Class348
		{
			gclass9_0 = this,
			string_0 = string_0
		}.method_0), false, false);
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x00044118 File Offset: 0x00042318
	public void method_21(string string_0)
	{
		base.method_1(new Action<IntPtr>(new GClass9.Class347
		{
			gclass9_0 = this,
			string_0 = string_0
		}.method_0), true, true);
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00044150 File Offset: 0x00042350
	public void method_22(IEnumerable<GClass136> ienumerable_0, string string_0, bool bool_0)
	{
		GClass9.Class350 @class = new GClass9.Class350();
		@class.ienumerable_0 = ienumerable_0;
		@class.gclass9_0 = this;
		@class.bool_0 = bool_0;
		@class.importExportProfiles_0 = new ImportExportProfiles();
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		foreach (ImportExportProfile importExportProfile in @class.importExportProfiles_0.Profiles)
		{
			binaryWriter.Write(importExportProfile.ProfileName);
			binaryWriter.Write(importExportProfile.Executeables.Count);
			foreach (string value in importExportProfile.Executeables)
			{
				binaryWriter.Write(value);
			}
			binaryWriter.Write(importExportProfile.Settings.Count);
			foreach (ImportExportProfileSetting importExportProfileSetting in importExportProfile.Settings)
			{
				binaryWriter.Write(importExportProfileSetting.SettingNameInfo);
				binaryWriter.Write(importExportProfileSetting.SettingId);
				binaryWriter.Write(importExportProfileSetting.SettingValue);
				binaryWriter.Write((byte)importExportProfileSetting.ValueType);
			}
		}
		byte[] bytes = GClass85.smethod_0(memoryStream.ToArray()).smethod_2(2);
		File.WriteAllBytes(string_0, bytes);
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x00044300 File Offset: 0x00042500
	public byte[] method_23(IEnumerable<GClass136> ienumerable_0, bool bool_0)
	{
		GClass9.Class344 @class = new GClass9.Class344();
		@class.ienumerable_0 = ienumerable_0;
		@class.gclass9_0 = this;
		@class.bool_0 = bool_0;
		@class.importExportProfiles_0 = new ImportExportProfiles();
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		foreach (ImportExportProfile importExportProfile in @class.importExportProfiles_0.Profiles)
		{
			binaryWriter.Write(importExportProfile.ProfileName);
			binaryWriter.Write(importExportProfile.Executeables.Count);
			foreach (string value in importExportProfile.Executeables)
			{
				binaryWriter.Write(value);
			}
			binaryWriter.Write(importExportProfile.Settings.Count);
			foreach (ImportExportProfileSetting importExportProfileSetting in importExportProfile.Settings)
			{
				binaryWriter.Write(importExportProfileSetting.SettingNameInfo);
				binaryWriter.Write(importExportProfileSetting.SettingId);
				binaryWriter.Write(importExportProfileSetting.SettingValue);
				binaryWriter.Write((byte)importExportProfileSetting.ValueType);
			}
		}
		return GClass85.smethod_0(memoryStream.ToArray()).smethod_2(2);
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x000444A8 File Offset: 0x000426A8
	private ImportExportProfile method_24(IntPtr intptr_0, string string_0, bool bool_0)
	{
		ImportExportProfile importExportProfile = new ImportExportProfile();
		IntPtr intPtr = base.method_3(intptr_0, string_0);
		if (intPtr != IntPtr.Zero)
		{
			importExportProfile.ProfileName = string_0;
			foreach (GStruct7 gstruct in base.method_16(intptr_0, intPtr))
			{
				importExportProfile.Executeables.Add(gstruct.string_0);
			}
			foreach (GStruct1 gstruct2 in base.method_15(intptr_0, intPtr))
			{
				bool flag = gstruct2.uint_2 == 1U;
				if (gstruct2.genum1_0 == (GEnum1)0 && (!flag || bool_0))
				{
					GStruct1 gstruct1_ = gstruct2;
					this.gclass8_1.method_23(string_0, ref gstruct1_);
					ImportExportProfileSetting item = GClass152.smethod_1(gstruct1_);
					importExportProfile.Settings.Add(item);
				}
			}
		}
		return importExportProfile;
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x000445B8 File Offset: 0x000427B8
	public ImportExportProfiles method_25(string string_0)
	{
		ImportExportProfiles importExportProfiles = new ImportExportProfiles();
		if (Path.GetExtension(string_0).Equals(".nip", StringComparison.OrdinalIgnoreCase))
		{
			importExportProfiles = GClass203.smethod_0(File.ReadAllText(string_0));
		}
		else
		{
			MemoryStream memoryStream = new MemoryStream(GClass85.smethod_1(File.ReadAllBytes(string_0).smethod_2(2)));
			BinaryReader binaryReader = new BinaryReader(memoryStream);
			while (memoryStream.Position < memoryStream.Length)
			{
				ImportExportProfile importExportProfile = new ImportExportProfile();
				importExportProfile.ProfileName = binaryReader.ReadString();
				int num = binaryReader.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					importExportProfile.Executeables.Add(binaryReader.ReadString());
				}
				int num2 = binaryReader.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					importExportProfile.Settings.Add(new ImportExportProfileSetting
					{
						SettingNameInfo = binaryReader.ReadString(),
						SettingId = binaryReader.ReadUInt32(),
						SettingValue = binaryReader.ReadString(),
						ValueType = (SettingValueType)binaryReader.ReadByte()
					});
				}
				importExportProfiles.Profiles.Add(importExportProfile);
			}
		}
		return importExportProfiles;
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x000446DC File Offset: 0x000428DC
	public string method_26(string string_0)
	{
		GClass9.Class342 @class = new GClass9.Class342();
		@class.gclass9_0 = this;
		@class.stringBuilder_0 = new StringBuilder();
		@class.bool_0 = false;
		@class.importExportProfiles_0 = this.method_25(string_0);
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		if (@class.bool_0)
		{
			@class.stringBuilder_0.AppendLine("Hint: If just the profile name has been changed by nvidia, consider to manually modify the profile name inside the import file using a text editor.");
		}
		return @class.stringBuilder_0.ToString();
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x00044750 File Offset: 0x00042950
	private bool method_27(string string_0, ImportExportProfile importExportProfile_0)
	{
		GClass9.Class343 @class = new GClass9.Class343();
		@class.string_0 = string_0;
		return importExportProfile_0.Executeables.Any(new Func<string, bool>(@class.method_0));
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x00044784 File Offset: 0x00042984
	private void method_28(IntPtr intptr_0, IntPtr intptr_1, ImportExportProfile importExportProfile_0)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (GStruct7 gstruct in base.method_16(intptr_0, intptr_1))
		{
			if (this.method_27(gstruct.string_0, importExportProfile_0) && !hashSet.Contains(gstruct.string_0))
			{
				hashSet.Add(gstruct.string_0);
			}
			else
			{
				GClass202.gdelegate11_0(intptr_0, intptr_1, new StringBuilder(gstruct.string_0));
			}
		}
		foreach (string text in importExportProfile_0.Executeables)
		{
			if (!hashSet.Contains(text))
			{
				try
				{
					base.method_12(intptr_0, intptr_1, text);
				}
				catch (GException7)
				{
					throw new GException8(text);
				}
			}
		}
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x00044884 File Offset: 0x00042A84
	private uint method_29(uint uint_0, ImportExportProfile importExportProfile_0)
	{
		GClass9.Class345 @class = new GClass9.Class345();
		@class.uint_0 = uint_0;
		ImportExportProfileSetting importExportProfileSetting = importExportProfile_0.Settings.FirstOrDefault(new Func<ImportExportProfileSetting, bool>(@class.method_0));
		if (importExportProfileSetting != null)
		{
			return uint.Parse(importExportProfileSetting.SettingValue);
		}
		return 0U;
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x000448C8 File Offset: 0x00042AC8
	private ImportExportProfileSetting method_30(uint uint_0, ImportExportProfile importExportProfile_0)
	{
		GClass9.Class346 @class = new GClass9.Class346();
		@class.uint_0 = uint_0;
		return importExportProfile_0.Settings.FirstOrDefault(new Func<ImportExportProfileSetting, bool>(@class.method_0));
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x000448FC File Offset: 0x00042AFC
	private bool method_31(uint uint_0, ImportExportProfile importExportProfile_0)
	{
		GClass9.Class349 @class = new GClass9.Class349();
		@class.uint_0 = uint_0;
		return importExportProfile_0.Settings.Any(new Func<ImportExportProfileSetting, bool>(@class.method_0));
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00044930 File Offset: 0x00042B30
	private void method_32(IntPtr intptr_0, IntPtr intptr_1, ImportExportProfile importExportProfile_0, string string_0)
	{
		HashSet<uint> hashSet = new HashSet<uint>();
		foreach (GStruct1 gstruct in base.method_15(intptr_0, intptr_1))
		{
			bool flag = gstruct.genum1_0 == (GEnum1)0;
			bool flag2 = gstruct.uint_2 == 1U;
			if (flag)
			{
				bool flag3 = this.method_31(gstruct.uint_1, importExportProfile_0);
				ImportExportProfileSetting importExportProfileSetting_ = this.method_30(gstruct.uint_1, importExportProfile_0);
				GStruct1 gstruct1_ = gstruct;
				this.gclass8_1.method_23(string_0, ref gstruct1_);
				if (flag2 && flag3 && GClass152.smethod_0(gstruct1_, importExportProfileSetting_))
				{
					hashSet.Add(gstruct.uint_1);
				}
				else if (flag3)
				{
					GStruct1 gstruct1_2 = GClass152.smethod_4(importExportProfileSetting_);
					base.method_6(intptr_0, intptr_1, gstruct1_2);
					hashSet.Add(gstruct.uint_1);
				}
				else if (!flag2)
				{
					GClass202.gdelegate6_0(intptr_0, intptr_1, gstruct.uint_1);
				}
			}
		}
		foreach (ImportExportProfileSetting importExportProfileSetting in importExportProfile_0.Settings)
		{
			if (!hashSet.Contains(importExportProfileSetting.SettingId))
			{
				GStruct1 gstruct1_3 = GClass152.smethod_4(importExportProfileSetting);
				try
				{
					base.method_6(intptr_0, intptr_1, gstruct1_3);
				}
				catch (GException7 gexception)
				{
					if (gexception.genum0_0 != GEnum0.NVAPI_SETTING_NOT_FOUND)
					{
						throw;
					}
				}
			}
		}
	}

	// Token: 0x040009A3 RID: 2467
	private readonly GClass11 gclass11_0;

	// Token: 0x040009A4 RID: 2468
	private readonly GClass10 gclass10_0;

	// Token: 0x040009A5 RID: 2469
	private readonly GClass8 gclass8_1;

	// Token: 0x020002B6 RID: 694
	private sealed class Class342
	{
		// Token: 0x0600101C RID: 4124 RVA: 0x00044AE0 File Offset: 0x00042CE0
		internal void method_0(IntPtr intptr_0)
		{
			foreach (ImportExportProfile importExportProfile in this.importExportProfiles_0.Profiles)
			{
				bool flag = false;
				IntPtr intPtr = this.gclass9_0.method_3(intptr_0, importExportProfile.ProfileName);
				if (intPtr == IntPtr.Zero)
				{
					intPtr = this.gclass9_0.method_4(intptr_0, importExportProfile.ProfileName);
					GClass202.gdelegate27_0(intptr_0);
					flag = true;
				}
				if (intPtr != IntPtr.Zero)
				{
					bool flag2 = false;
					this.gclass9_0.gclass11_0.method_29(importExportProfile.ProfileName, out flag2);
					try
					{
						this.gclass9_0.method_28(intptr_0, intPtr, importExportProfile);
						this.gclass9_0.method_32(intptr_0, intPtr, importExportProfile, importExportProfile.ProfileName);
					}
					catch (GException7 gexception)
					{
						if (flag)
						{
							GClass202.gdelegate18_0(intptr_0, intPtr);
						}
						this.stringBuilder_0.AppendLine(string.Format("Failed to import profile '{0}'", importExportProfile.ProfileName));
						GException8 gexception2 = gexception as GException8;
						if (gexception2 != null)
						{
							string arg = this.gclass9_0.gclass10_0.method_24(gexception2.string_0);
							this.stringBuilder_0.AppendLine(string.Format("- application '{0}' is already in use by profile '{1}'", gexception2.string_0, arg));
							this.bool_0 = true;
						}
						else
						{
							this.stringBuilder_0.AppendLine(string.Format("- {0}", gexception.Message));
						}
						this.stringBuilder_0.AppendLine();
					}
					GClass202.gdelegate27_0(intptr_0);
				}
			}
		}

		// Token: 0x040009A6 RID: 2470
		public ImportExportProfiles importExportProfiles_0;

		// Token: 0x040009A7 RID: 2471
		public GClass9 gclass9_0;

		// Token: 0x040009A8 RID: 2472
		public StringBuilder stringBuilder_0;

		// Token: 0x040009A9 RID: 2473
		public bool bool_0;
	}

	// Token: 0x020002B7 RID: 695
	private sealed class Class343
	{
		// Token: 0x0600101E RID: 4126 RVA: 0x00044CA8 File Offset: 0x00042EA8
		internal bool method_0(string string_1)
		{
			return string_1.Equals(this.string_0);
		}

		// Token: 0x040009AA RID: 2474
		public string string_0;
	}

	// Token: 0x020002B8 RID: 696
	private sealed class Class344
	{
		// Token: 0x06001020 RID: 4128 RVA: 0x00044CC0 File Offset: 0x00042EC0
		internal void method_0(IntPtr intptr_0)
		{
			foreach (GClass136 gclass in this.ienumerable_0)
			{
				ImportExportProfile item = this.gclass9_0.method_24(intptr_0, gclass.ProfileName, this.bool_0);
				this.importExportProfiles_0.Profiles.Add(item);
			}
		}

		// Token: 0x040009AB RID: 2475
		public IEnumerable<GClass136> ienumerable_0;

		// Token: 0x040009AC RID: 2476
		public GClass9 gclass9_0;

		// Token: 0x040009AD RID: 2477
		public bool bool_0;

		// Token: 0x040009AE RID: 2478
		public ImportExportProfiles importExportProfiles_0;
	}

	// Token: 0x020002B9 RID: 697
	private sealed class Class345
	{
		// Token: 0x06001022 RID: 4130 RVA: 0x00044D3C File Offset: 0x00042F3C
		internal bool method_0(ImportExportProfileSetting importExportProfileSetting_0)
		{
			return importExportProfileSetting_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x040009AF RID: 2479
		public uint uint_0;
	}

	// Token: 0x020002BA RID: 698
	private sealed class Class346
	{
		// Token: 0x06001024 RID: 4132 RVA: 0x00044D68 File Offset: 0x00042F68
		internal bool method_0(ImportExportProfileSetting importExportProfileSetting_0)
		{
			return importExportProfileSetting_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x040009B0 RID: 2480
		public uint uint_0;
	}

	// Token: 0x020002BB RID: 699
	private sealed class Class347
	{
		// Token: 0x06001026 RID: 4134 RVA: 0x00044D94 File Offset: 0x00042F94
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass9_0.method_18(intptr_0, this.string_0);
			this.gclass9_0.method_17(intptr_0);
		}

		// Token: 0x040009B1 RID: 2481
		public GClass9 gclass9_0;

		// Token: 0x040009B2 RID: 2482
		public string string_0;
	}

	// Token: 0x020002BC RID: 700
	private sealed class Class348
	{
		// Token: 0x06001028 RID: 4136 RVA: 0x00044DBC File Offset: 0x00042FBC
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass9_0.method_19(intptr_0, this.string_0);
		}

		// Token: 0x040009B3 RID: 2483
		public GClass9 gclass9_0;

		// Token: 0x040009B4 RID: 2484
		public string string_0;
	}

	// Token: 0x020002BD RID: 701
	private sealed class Class349
	{
		// Token: 0x0600102A RID: 4138 RVA: 0x00044DD8 File Offset: 0x00042FD8
		internal bool method_0(ImportExportProfileSetting importExportProfileSetting_0)
		{
			return importExportProfileSetting_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x040009B5 RID: 2485
		public uint uint_0;
	}

	// Token: 0x020002BE RID: 702
	private sealed class Class350
	{
		// Token: 0x0600102C RID: 4140 RVA: 0x00044E04 File Offset: 0x00043004
		internal void method_0(IntPtr intptr_0)
		{
			foreach (GClass136 gclass in this.ienumerable_0)
			{
				ImportExportProfile item = this.gclass9_0.method_24(intptr_0, gclass.ProfileName, this.bool_0);
				this.importExportProfiles_0.Profiles.Add(item);
			}
		}

		// Token: 0x040009B6 RID: 2486
		public IEnumerable<GClass136> ienumerable_0;

		// Token: 0x040009B7 RID: 2487
		public GClass9 gclass9_0;

		// Token: 0x040009B8 RID: 2488
		public bool bool_0;

		// Token: 0x040009B9 RID: 2489
		public ImportExportProfiles importExportProfiles_0;
	}
}
