using System;
using System.Collections.Generic;
using System.Linq;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x020001E4 RID: 484
public sealed class GClass42
{
	// Token: 0x06000B6A RID: 2922 RVA: 0x00035524 File Offset: 0x00033724
	public GClass42(GClass143 gclass143_2, GClass143 gclass143_3 = null)
	{
		this.gclass143_0 = gclass143_2;
		this.gclass143_1 = gclass143_3;
		this.method_0(true);
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x00035558 File Offset: 0x00033758
	public void method_0(bool bool_0)
	{
		this.dictionary_0 = new Dictionary<uint, GClass69>();
		this.list_0 = new List<GClass123>();
		this.ginterface17_1 = new GClass125(this.gclass143_0, GEnum3.CustomSettings);
		List<GClass123> list = this.list_0;
		GClass123 gclass = new GClass123();
		gclass.method_3(1U);
		gclass.method_1(this.ginterface17_1);
		list.Add(gclass);
		if (!bool_0)
		{
			this.ginterface17_4 = new GClass5();
			List<GClass123> list2 = this.list_0;
			GClass123 gclass2 = new GClass123();
			gclass2.method_3(5U);
			gclass2.method_1(this.ginterface17_4);
			list2.Add(gclass2);
			this.ginterface17_0 = new GClass204();
			List<GClass123> list3 = this.list_0;
			GClass123 gclass3 = new GClass123();
			gclass3.method_3(2U);
			gclass3.method_1(this.ginterface17_0);
			list3.Add(gclass3);
			if (GClass12.gclass10_0 != null)
			{
				this.ginterface17_2 = new GClass87(GClass12.gclass10_0.list_0);
				List<GClass123> list4 = this.list_0;
				GClass123 gclass4 = new GClass123();
				gclass4.method_3(3U);
				gclass4.method_1(this.ginterface17_2);
				list4.Add(gclass4);
			}
			if (this.gclass143_1 != null)
			{
				this.ginterface17_3 = new GClass125(this.gclass143_1, GEnum3.ReferenceSettings);
				List<GClass123> list5 = this.list_0;
				GClass123 gclass5 = new GClass123();
				gclass5.method_3(4U);
				gclass5.method_1(this.ginterface17_3);
				list5.Add(gclass5);
			}
		}
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x00035690 File Offset: 0x00033890
	private NVDRS_SETTING_TYPE? method_1(uint uint_0)
	{
		foreach (GClass123 gclass in this.list_0.OrderBy(new Func<GClass123, GEnum3>(GClass42.Class263.class263_0.method_0)))
		{
			NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = gclass.method_0().imethod_1(uint_0);
			if (nvdrs_SETTING_TYPE != null)
			{
				return new NVDRS_SETTING_TYPE?(nvdrs_SETTING_TYPE.Value);
			}
		}
		return new NVDRS_SETTING_TYPE?(NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE);
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00035728 File Offset: 0x00033928
	private string method_2(uint uint_0)
	{
		string result = null;
		foreach (GClass123 gclass in this.list_0.OrderBy(new Func<GClass123, GEnum3>(GClass42.Class263.class263_0.method_1)))
		{
			string text = gclass.method_0().imethod_2(uint_0);
			if (!string.IsNullOrEmpty(text))
			{
				if (!text.StartsWith("0x"))
				{
					return text;
				}
				result = text;
			}
		}
		return result;
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x000357C0 File Offset: 0x000339C0
	private string method_3(uint uint_0)
	{
		foreach (GClass123 gclass in this.list_0.OrderBy(new Func<GClass123, GEnum3>(GClass42.Class263.class263_0.method_2)))
		{
			string text = gclass.method_0().imethod_3(uint_0);
			if (text != null)
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x00035840 File Offset: 0x00033A40
	private uint method_4(uint uint_0)
	{
		foreach (GClass123 gclass in this.list_0.OrderBy(new Func<GClass123, GEnum3>(GClass42.Class263.class263_0.method_3)))
		{
			uint? num = gclass.method_0().imethod_4(uint_0);
			if (num != null)
			{
				return num.Value;
			}
		}
		return 0U;
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x000358CC File Offset: 0x00033ACC
	private string method_5(uint uint_0)
	{
		foreach (GClass123 gclass in this.list_0.OrderBy(new Func<GClass123, GEnum3>(GClass42.Class263.class263_0.method_4)))
		{
			string text = gclass.method_0().imethod_5(uint_0);
			if (text != null)
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x0003594C File Offset: 0x00033B4C
	private byte[] method_6(uint uint_0)
	{
		foreach (GClass123 gclass in this.list_0.OrderBy(new Func<GClass123, GEnum3>(GClass42.Class263.class263_0.method_5)))
		{
			byte[] array = gclass.method_0().imethod_6(uint_0);
			if (array != null)
			{
				return array;
			}
		}
		return null;
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x000359CC File Offset: 0x00033BCC
	private List<GClass58<T>> method_7<T>(List<GClass58<T>> list_1, List<GClass58<T>> list_2)
	{
		/*
An exception occurred when decompiling this method (06000B72)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<GClass58`1<T>> GClass42::method_7<T>(System.Collections.Generic.List`1<GClass58`1<T>>,System.Collections.Generic.List`1<GClass58`1<T>>)

 ---> System.Exception: Inconsistent stack size at IL_21
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x00035B70 File Offset: 0x00033D70
	private List<GClass58<byte[]>> method_8(uint uint_0)
	{
		List<GClass58<byte[]>> list = new List<GClass58<byte[]>>();
		foreach (GClass123 gclass in this.list_0.OrderByDescending(new Func<GClass123, uint>(GClass42.Class263.class263_0.method_6)))
		{
			list = this.method_7<byte[]>(list, gclass.method_0().imethod_9(uint_0));
		}
		return list;
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x00035BF8 File Offset: 0x00033DF8
	private List<GClass58<string>> method_9(uint uint_0)
	{
		List<GClass58<string>> list = new List<GClass58<string>>();
		foreach (GClass123 gclass in this.list_0.OrderByDescending(new Func<GClass123, uint>(GClass42.Class263.class263_0.method_7)))
		{
			list = this.method_7<string>(list, gclass.method_0().imethod_7(uint_0));
		}
		return list;
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x00035C80 File Offset: 0x00033E80
	private List<GClass58<uint>> method_10(uint uint_0)
	{
		List<GClass58<uint>> list = new List<GClass58<uint>>();
		foreach (GClass123 gclass in this.list_0.OrderByDescending(new Func<GClass123, uint>(GClass42.Class263.class263_0.method_8)))
		{
			list = this.method_7<uint>(list, gclass.method_0().imethod_8(uint_0));
		}
		if (list != null)
		{
			list = list.Where(new Func<GClass58<uint>, bool>(GClass42.Class263.class263_0.method_9)).GroupBy(new Func<GClass58<uint>, string>(GClass42.Class263.class263_0.method_10)).Select(new Func<IGrouping<string, GClass58<uint>>, GClass58<uint>>(GClass42.Class263.class263_0.method_11)).OrderBy(new Func<GClass58<uint>, GEnum3>(GClass42.Class263.class263_0.method_12)).ThenBy(new Func<GClass58<uint>, int>(GClass42.Class263.class263_0.method_13)).ThenBy(new Func<GClass58<uint>, string>(GClass42.Class263.class263_0.method_14)).ToList<GClass58<uint>>();
		}
		return list;
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00035DEC File Offset: 0x00033FEC
	public List<uint> method_11(GEnum78 genum78_0)
	{
		List<uint> list = new List<uint>();
		GEnum3[] source = this.method_12(genum78_0);
		foreach (GClass123 gclass in this.list_0.OrderBy(new Func<GClass123, GEnum3>(GClass42.Class263.class263_0.method_15)))
		{
			if (source.Contains(gclass.method_0().imethod_0()))
			{
				list.AddRange(gclass.method_0().imethod_10());
			}
		}
		return list.Distinct<uint>().ToList<uint>();
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x00035E94 File Offset: 0x00034094
	private GEnum3[] method_12(GEnum78 genum78_0)
	{
		if (genum78_0 == (GEnum78)1)
		{
			return new GEnum3[]
			{
				GEnum3.ConstantSettings,
				GEnum3.ScannedSettings,
				GEnum3.CustomSettings,
				GEnum3.DriverSettings,
				GEnum3.ReferenceSettings
			};
		}
		if (genum78_0 == (GEnum78)2)
		{
			return new GEnum3[]
			{
				GEnum3.CustomSettings
			};
		}
		return new GEnum3[]
		{
			GEnum3.CustomSettings,
			GEnum3.DriverSettings
		};
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00035ED4 File Offset: 0x000340D4
	private GEnum3[] method_13(GEnum78 genum78_0)
	{
		if (genum78_0 == (GEnum78)2)
		{
			return new GEnum3[]
			{
				GEnum3.CustomSettings,
				GEnum3.ScannedSettings
			};
		}
		return new GEnum3[]
		{
			GEnum3.ConstantSettings,
			GEnum3.ScannedSettings,
			GEnum3.CustomSettings,
			GEnum3.DriverSettings,
			GEnum3.ReferenceSettings
		};
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x00035EFC File Offset: 0x000340FC
	private GClass69 method_14(uint uint_0)
	{
		NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = this.method_1(uint_0);
		string text = this.method_2(uint_0);
		string text2 = this.method_3(uint_0);
		if (text2 == null)
		{
			text2 = this.method_17(uint_0, text);
		}
		GClass69 gclass = new GClass69();
		gclass.method_1(nvdrs_SETTING_TYPE);
		gclass.method_5(text);
		gclass.method_3(text2);
		gclass.method_13(this.method_18(uint_0));
		gclass.method_15(this.method_19(uint_0));
		gclass.Description = this.method_20(uint_0);
		NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
		gclass.method_9((nvdrs_SETTING_TYPE2.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE & nvdrs_SETTING_TYPE2 != null) ? this.method_4(uint_0) : 0U);
		nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
		gclass.method_7((nvdrs_SETTING_TYPE2.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE & nvdrs_SETTING_TYPE2 != null) ? this.method_5(uint_0) : null);
		nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
		gclass.method_11((nvdrs_SETTING_TYPE2.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE & nvdrs_SETTING_TYPE2 != null) ? this.method_6(uint_0) : null);
		nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
		gclass.method_19((nvdrs_SETTING_TYPE2.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE & nvdrs_SETTING_TYPE2 != null) ? this.method_10(uint_0) : null);
		nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
		gclass.method_17((nvdrs_SETTING_TYPE2.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE & nvdrs_SETTING_TYPE2 != null) ? this.method_9(uint_0) : null);
		nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
		gclass.method_21((nvdrs_SETTING_TYPE2.GetValueOrDefault() == NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE & nvdrs_SETTING_TYPE2 != null) ? this.method_8(uint_0) : null);
		return gclass;
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x00036058 File Offset: 0x00034258
	private GClass69 method_15(uint uint_0, GClass69 gclass69_0, GEnum78 genum78_0)
	{
		GClass42.Class264 @class = new GClass42.Class264();
		GClass69 gclass = new GClass69();
		gclass.method_9(gclass69_0.method_8());
		gclass.method_7(gclass69_0.method_6());
		gclass.method_11(gclass69_0.method_10());
		gclass.method_5(gclass69_0.method_4());
		gclass.method_1(gclass69_0.method_0());
		gclass.method_3(gclass69_0.method_2());
		gclass.method_13(gclass69_0.method_12());
		gclass.method_15(gclass69_0.method_14());
		gclass.Description = gclass69_0.Description;
		GClass69 gclass2 = gclass;
		if (string.IsNullOrEmpty(gclass2.method_4()))
		{
			gclass2.method_5(string.Format("0x{0:X8}", uint_0));
		}
		@class.genum3_0 = this.method_13(genum78_0);
		if (gclass69_0.method_18() != null)
		{
			gclass2.method_19(gclass69_0.method_18().Where(new Func<GClass58<uint>, bool>(@class.method_0)).ToList<GClass58<uint>>());
		}
		if (gclass69_0.method_16() != null)
		{
			gclass2.method_17(gclass69_0.method_16().Where(new Func<GClass58<string>, bool>(@class.method_1)).ToList<GClass58<string>>());
		}
		if (gclass69_0.method_20() != null)
		{
			gclass2.method_21(gclass69_0.method_20().Where(new Func<GClass58<byte[]>, bool>(@class.method_2)).ToList<GClass58<byte[]>>());
		}
		return gclass2;
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x0003618C File Offset: 0x0003438C
	public GClass69 method_16(uint uint_0, GEnum78 genum78_0)
	{
		if (this.dictionary_0.ContainsKey(uint_0))
		{
			return this.method_15(uint_0, this.dictionary_0[uint_0], genum78_0);
		}
		GClass69 gclass = this.method_14(uint_0);
		this.dictionary_0.Add(uint_0, gclass);
		return this.method_15(uint_0, gclass, genum78_0);
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x000361DC File Offset: 0x000343DC
	private string method_17(uint uint_0, string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (string_0.ToUpper().Contains("SLI"))
		{
			return "SLI";
		}
		if (string_0.ToUpper().Contains("STEREO"))
		{
			return "Stereo";
		}
		if (string_0.StartsWith("0x"))
		{
			return "Unknown";
		}
		return "Other";
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x00036244 File Offset: 0x00034444
	private bool method_18(uint uint_0)
	{
		GClass123 gclass = this.list_0.FirstOrDefault(new Func<GClass123, bool>(GClass42.Class263.class263_0.method_16));
		return gclass != null && gclass.method_0().imethod_10().Contains(uint_0);
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x00036294 File Offset: 0x00034494
	private bool method_19(uint uint_0)
	{
		GClass123 gclass = this.list_0.FirstOrDefault(new Func<GClass123, bool>(GClass42.Class263.class263_0.method_17));
		return gclass != null && ((GClass125)gclass.method_0()).method_1(uint_0);
	}

	// Token: 0x06000B7F RID: 2943 RVA: 0x000362E4 File Offset: 0x000344E4
	private string method_20(uint uint_0)
	{
		GClass123 gclass = this.list_0.FirstOrDefault(new Func<GClass123, bool>(GClass42.Class263.class263_0.method_18));
		string text = (gclass != null) ? (((GClass125)gclass.method_0()).method_2(uint_0) ?? string.Empty) : string.Empty;
		GClass123 gclass2 = this.list_0.FirstOrDefault(new Func<GClass123, bool>(GClass42.Class263.class263_0.method_19));
		string result = (gclass2 != null) ? (((GClass125)gclass2.method_0()).method_2(uint_0) ?? string.Empty) : string.Empty;
		if (string.IsNullOrEmpty(text))
		{
			return result;
		}
		return text;
	}

	// Token: 0x04000720 RID: 1824
	private GInterface17 ginterface17_0;

	// Token: 0x04000721 RID: 1825
	private GInterface17 ginterface17_1;

	// Token: 0x04000722 RID: 1826
	private GInterface17 ginterface17_2;

	// Token: 0x04000723 RID: 1827
	private GInterface17 ginterface17_3;

	// Token: 0x04000724 RID: 1828
	public GInterface17 ginterface17_4;

	// Token: 0x04000725 RID: 1829
	private readonly GClass143 gclass143_0;

	// Token: 0x04000726 RID: 1830
	private readonly GClass143 gclass143_1;

	// Token: 0x04000727 RID: 1831
	private List<GClass123> list_0 = new List<GClass123>();

	// Token: 0x04000728 RID: 1832
	private Dictionary<uint, GClass69> dictionary_0 = new Dictionary<uint, GClass69>();

	// Token: 0x020001E5 RID: 485
	private sealed class Class261<T>
	{
		// Token: 0x06000B81 RID: 2945 RVA: 0x000363A4 File Offset: 0x000345A4
		internal bool method_0(GClass58<T> gclass58_0)
		{
			return !this.list_0.Contains(gclass58_0.method_2());
		}

		// Token: 0x04000729 RID: 1833
		public List<T> list_0;
	}

	// Token: 0x020001E6 RID: 486
	private sealed class Class262
	{
		// Token: 0x06000B83 RID: 2947 RVA: 0x000363C4 File Offset: 0x000345C4
		internal bool method_0(GClass58<uint> gclass58_0)
		{
			return gclass58_0.imethod_1() == this.igrouping_0.Key;
		}

		// Token: 0x0400072A RID: 1834
		public IGrouping<string, GClass58<uint>> igrouping_0;
	}

	// Token: 0x020001E7 RID: 487
	[Serializable]
	private sealed class Class263
	{
		// Token: 0x06000B86 RID: 2950 RVA: 0x000363F0 File Offset: 0x000345F0
		internal GEnum3 method_0(GClass123 gclass123_0)
		{
			return gclass123_0.method_0().imethod_0();
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00036400 File Offset: 0x00034600
		internal GEnum3 method_1(GClass123 gclass123_0)
		{
			return gclass123_0.method_0().imethod_0();
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00036410 File Offset: 0x00034610
		internal GEnum3 method_2(GClass123 gclass123_0)
		{
			return gclass123_0.method_0().imethod_0();
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00036420 File Offset: 0x00034620
		internal GEnum3 method_3(GClass123 gclass123_0)
		{
			return gclass123_0.method_0().imethod_0();
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00036430 File Offset: 0x00034630
		internal GEnum3 method_4(GClass123 gclass123_0)
		{
			return gclass123_0.method_0().imethod_0();
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00036440 File Offset: 0x00034640
		internal GEnum3 method_5(GClass123 gclass123_0)
		{
			return gclass123_0.method_0().imethod_0();
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00036450 File Offset: 0x00034650
		internal uint method_6(GClass123 gclass123_0)
		{
			return gclass123_0.method_2();
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00036458 File Offset: 0x00034658
		internal uint method_7(GClass123 gclass123_0)
		{
			return gclass123_0.method_2();
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00036460 File Offset: 0x00034660
		internal uint method_8(GClass123 gclass123_0)
		{
			return gclass123_0.method_2();
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00036468 File Offset: 0x00034668
		internal bool method_9(GClass58<uint> gclass58_0)
		{
			return !gclass58_0.imethod_1().EndsWith("_NUM") && !gclass58_0.imethod_1().EndsWith("_MASK") && (!gclass58_0.imethod_1().EndsWith("_MIN") || gclass58_0.imethod_1().Equals("PREFERRED_PSTATE_PREFER_MIN")) && (!gclass58_0.imethod_1().EndsWith("_MAX") || gclass58_0.imethod_1().Equals("PREFERRED_PSTATE_PREFER_MAX"));
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000364E4 File Offset: 0x000346E4
		internal string method_10(GClass58<uint> gclass58_0)
		{
			return gclass58_0.imethod_1();
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000364EC File Offset: 0x000346EC
		internal GClass58<uint> method_11(IGrouping<string, GClass58<uint>> igrouping_0)
		{
			GClass42.Class262 @class = new GClass42.Class262();
			@class.igrouping_0 = igrouping_0;
			return @class.igrouping_0.First(new Func<GClass58<uint>, bool>(@class.method_0));
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00036520 File Offset: 0x00034720
		internal GEnum3 method_12(GClass58<uint> gclass58_0)
		{
			return gclass58_0.genum3_0;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00036528 File Offset: 0x00034728
		internal int method_13(GClass58<uint> gclass58_0)
		{
			return gclass58_0.method_0();
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00036530 File Offset: 0x00034730
		internal string method_14(GClass58<uint> gclass58_0)
		{
			return gclass58_0.imethod_1();
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00036538 File Offset: 0x00034738
		internal GEnum3 method_15(GClass123 gclass123_0)
		{
			return gclass123_0.method_0().imethod_0();
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00036548 File Offset: 0x00034748
		internal bool method_16(GClass123 gclass123_0)
		{
			return gclass123_0.method_0().imethod_0() == GEnum3.DriverSettings;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0003655C File Offset: 0x0003475C
		internal bool method_17(GClass123 gclass123_0)
		{
			return gclass123_0.method_0().imethod_0() == GEnum3.CustomSettings;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00036570 File Offset: 0x00034770
		internal bool method_18(GClass123 gclass123_0)
		{
			return gclass123_0.method_0().imethod_0() == GEnum3.CustomSettings;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00036584 File Offset: 0x00034784
		internal bool method_19(GClass123 gclass123_0)
		{
			return gclass123_0.method_0().imethod_0() == GEnum3.ReferenceSettings;
		}

		// Token: 0x0400072B RID: 1835
		public static readonly GClass42.Class263 class263_0 = new GClass42.Class263();

		// Token: 0x0400072C RID: 1836
		public static Func<GClass123, GEnum3> func_0;

		// Token: 0x0400072D RID: 1837
		public static Func<GClass123, GEnum3> func_1;

		// Token: 0x0400072E RID: 1838
		public static Func<GClass123, GEnum3> func_2;

		// Token: 0x0400072F RID: 1839
		public static Func<GClass123, GEnum3> func_3;

		// Token: 0x04000730 RID: 1840
		public static Func<GClass123, GEnum3> func_4;

		// Token: 0x04000731 RID: 1841
		public static Func<GClass123, GEnum3> func_5;

		// Token: 0x04000732 RID: 1842
		public static Func<GClass123, uint> func_6;

		// Token: 0x04000733 RID: 1843
		public static Func<GClass123, uint> func_7;

		// Token: 0x04000734 RID: 1844
		public static Func<GClass123, uint> func_8;

		// Token: 0x04000735 RID: 1845
		public static Func<GClass58<uint>, bool> func_9;

		// Token: 0x04000736 RID: 1846
		public static Func<GClass58<uint>, string> func_10;

		// Token: 0x04000737 RID: 1847
		public static Func<IGrouping<string, GClass58<uint>>, GClass58<uint>> func_11;

		// Token: 0x04000738 RID: 1848
		public static Func<GClass58<uint>, GEnum3> func_12;

		// Token: 0x04000739 RID: 1849
		public static Func<GClass58<uint>, int> func_13;

		// Token: 0x0400073A RID: 1850
		public static Func<GClass58<uint>, string> func_14;

		// Token: 0x0400073B RID: 1851
		public static Func<GClass123, GEnum3> func_15;

		// Token: 0x0400073C RID: 1852
		public static Func<GClass123, bool> func_16;

		// Token: 0x0400073D RID: 1853
		public static Func<GClass123, bool> func_17;

		// Token: 0x0400073E RID: 1854
		public static Func<GClass123, bool> func_18;

		// Token: 0x0400073F RID: 1855
		public static Func<GClass123, bool> func_19;
	}

	// Token: 0x020001E8 RID: 488
	private sealed class Class264
	{
		// Token: 0x06000B9B RID: 2971 RVA: 0x000365A0 File Offset: 0x000347A0
		internal bool method_0(GClass58<uint> gclass58_0)
		{
			return this.genum3_0.Contains(gclass58_0.genum3_0);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000365B4 File Offset: 0x000347B4
		internal bool method_1(GClass58<string> gclass58_0)
		{
			return this.genum3_0.Contains(gclass58_0.genum3_0);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x000365C8 File Offset: 0x000347C8
		internal bool method_2(GClass58<byte[]> gclass58_0)
		{
			return this.genum3_0.Contains(gclass58_0.genum3_0);
		}

		// Token: 0x04000740 RID: 1856
		public GEnum3[] genum3_0;
	}

	// Token: 0x020001E9 RID: 489
	[Serializable]
	private sealed class Class265<T>
	{
		// Token: 0x06000BA0 RID: 2976 RVA: 0x000365F0 File Offset: 0x000347F0
		internal bool method_0(GClass58<T> gclass58_0)
		{
			return gclass58_0.genum3_0 != GEnum3.ScannedSettings;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00036600 File Offset: 0x00034800
		internal T method_1(GClass58<T> gclass58_0)
		{
			return gclass58_0.method_2();
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00036608 File Offset: 0x00034808
		internal T method_2(GClass58<T> gclass58_0)
		{
			return gclass58_0.method_2();
		}

		// Token: 0x04000741 RID: 1857
		public static readonly GClass42.Class265<T> class265_0 = new GClass42.Class265<T>();

		// Token: 0x04000742 RID: 1858
		public static Func<GClass58<T>, bool> func_0;

		// Token: 0x04000743 RID: 1859
		public static Func<GClass58<T>, T> func_1;

		// Token: 0x04000744 RID: 1860
		public static Func<GClass58<T>, T> func_2;
	}

	// Token: 0x020001EA RID: 490
	private sealed class Class266<T>
	{
		// Token: 0x06000BA4 RID: 2980 RVA: 0x00036618 File Offset: 0x00034818
		internal bool method_0(GClass58<T> gclass58_1)
		{
			T t = gclass58_1.method_2();
			return t.Equals(this.gclass58_0.method_2()) && this.gclass58_0.genum3_0 != GEnum3.ScannedSettings;
		}

		// Token: 0x04000745 RID: 1861
		public GClass58<T> gclass58_0;
	}
}
