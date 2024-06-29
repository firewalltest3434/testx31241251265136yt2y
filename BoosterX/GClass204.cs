using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x0200066B RID: 1643
public sealed class GClass204 : GInterface17
{
	// Token: 0x06002326 RID: 8998 RVA: 0x0008CF58 File Offset: 0x0008B158
	public GClass204()
	{
		this.dictionary_0 = this.method_0();
		this.imethod_10();
	}

	// Token: 0x06002327 RID: 8999 RVA: 0x0008CFAC File Offset: 0x0008B1AC
	private Dictionary<ESetting, Type> method_0()
	{
		Dictionary<ESetting, Type> dictionary = new Dictionary<ESetting, Type>();
		List<Type> source = Assembly.GetExecutingAssembly().GetTypes().Where(new Func<Type, bool>(GClass204.Class707.class707_0.method_0)).ToList<Type>();
		using (List<string>.Enumerator enumerator = Enum.GetNames(typeof(ESetting)).Distinct<string>().ToList<string>().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass204.Class708 @class = new GClass204.Class708();
				@class.string_0 = enumerator.Current;
				if (!this.string_0.Contains(@class.string_0))
				{
					Type type = source.FirstOrDefault(new Func<Type, bool>(@class.method_0));
					if (type != null)
					{
						ESetting key = (ESetting)Enum.Parse(typeof(ESetting), @class.string_0);
						dictionary.Add(key, type);
					}
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06002328 RID: 9000 RVA: 0x0008D0A8 File Offset: 0x0008B2A8
	public Type method_1(uint uint_0)
	{
		if (this.dictionary_0.ContainsKey((ESetting)uint_0))
		{
			return this.dictionary_0[(ESetting)uint_0];
		}
		return null;
	}

	// Token: 0x06002329 RID: 9001 RVA: 0x0008D0C8 File Offset: 0x0008B2C8
	public NVDRS_SETTING_TYPE? imethod_1(uint uint_0)
	{
		return null;
	}

	// Token: 0x0600232A RID: 9002 RVA: 0x0008D0E0 File Offset: 0x0008B2E0
	public string imethod_2(uint uint_0)
	{
		if (this.hashSet_0.Contains(uint_0))
		{
			ESetting esetting = (ESetting)uint_0;
			return esetting.ToString();
		}
		return null;
	}

	// Token: 0x0600232B RID: 9003 RVA: 0x0008D10C File Offset: 0x0008B30C
	public uint? imethod_4(uint uint_0)
	{
		if (this.dictionary_0.ContainsKey((ESetting)uint_0))
		{
			Type enumType = this.dictionary_0[(ESetting)uint_0];
			string text = Enum.GetNames(enumType).FirstOrDefault(new Func<string, bool>(GClass204.Class707.class707_0.method_1));
			if (text != null)
			{
				return new uint?((uint)Enum.Parse(enumType, text));
			}
		}
		return null;
	}

	// Token: 0x0600232C RID: 9004 RVA: 0x0008D180 File Offset: 0x0008B380
	public string imethod_5(uint uint_0)
	{
		return null;
	}

	// Token: 0x0600232D RID: 9005 RVA: 0x0008D184 File Offset: 0x0008B384
	public List<GClass58<string>> imethod_7(uint uint_0)
	{
		return null;
	}

	// Token: 0x0600232E RID: 9006 RVA: 0x0008D188 File Offset: 0x0008B388
	private uint method_2(Type type_0, string string_1)
	{
		uint result;
		try
		{
			result = (uint)Enum.Parse(type_0, string_1);
		}
		catch (InvalidCastException)
		{
			result = BitConverter.ToUInt32(BitConverter.GetBytes((int)Enum.Parse(type_0, string_1)), 0);
		}
		return result;
	}

	// Token: 0x0600232F RID: 9007 RVA: 0x0008D1D0 File Offset: 0x0008B3D0
	public List<GClass58<uint>> imethod_8(uint uint_0)
	{
		GClass204.Class706 @class = new GClass204.Class706();
		@class.gclass204_0 = this;
		if (this.dictionary_0.ContainsKey((ESetting)uint_0))
		{
			@class.type_0 = this.dictionary_0[(ESetting)uint_0];
			return Enum.GetNames(@class.type_0).Where(new Func<string, bool>(GClass204.Class707.class707_0.method_2)).ToList<string>().Select(new Func<string, GClass58<uint>>(@class.method_0)).ToList<GClass58<uint>>();
		}
		return null;
	}

	// Token: 0x06002330 RID: 9008 RVA: 0x0008D258 File Offset: 0x0008B458
	public List<uint> imethod_10()
	{
		if (this.hashSet_0 == null)
		{
			this.hashSet_0 = new HashSet<uint>(Enum.GetValues(typeof(ESetting)).Cast<ESetting>().Where(new Func<ESetting, bool>(this.method_3)).Cast<uint>().Distinct<uint>().ToList<uint>());
		}
		return this.hashSet_0.ToList<uint>();
	}

	// Token: 0x06002331 RID: 9009 RVA: 0x0008D2B8 File Offset: 0x0008B4B8
	public string imethod_3(uint uint_0)
	{
		return null;
	}

	// Token: 0x06002332 RID: 9010 RVA: 0x0008D2BC File Offset: 0x0008B4BC
	public byte[] imethod_6(uint uint_0)
	{
		return null;
	}

	// Token: 0x06002333 RID: 9011 RVA: 0x0008D2C0 File Offset: 0x0008B4C0
	public List<GClass58<byte[]>> imethod_9(uint uint_0)
	{
		return null;
	}

	// Token: 0x06002334 RID: 9012 RVA: 0x0008D2C4 File Offset: 0x0008B4C4
	public GEnum3 imethod_0()
	{
		return GEnum3.ConstantSettings;
	}

	// Token: 0x06002335 RID: 9013 RVA: 0x0008D2C8 File Offset: 0x0008B4C8
	private bool method_3(ESetting esetting_0)
	{
		return !this.string_0.Contains(esetting_0.ToString());
	}

	// Token: 0x0400180C RID: 6156
	private readonly Dictionary<ESetting, Type> dictionary_0;

	// Token: 0x0400180D RID: 6157
	private string[] string_0 = new string[]
	{
		"TOTAL_DWORD_SETTING_NUM",
		"TOTAL_WSTRING_SETTING_NUM",
		"TOTAL_SETTING_NUM",
		"INVALID_SETTING_ID"
	};

	// Token: 0x0400180E RID: 6158
	private HashSet<uint> hashSet_0;

	// Token: 0x0200066C RID: 1644
	private sealed class Class706
	{
		// Token: 0x06002337 RID: 9015 RVA: 0x0008D2F0 File Offset: 0x0008B4F0
		internal GClass58<uint> method_0(string string_0)
		{
			GClass58<uint> gclass = new GClass58<uint>(this.gclass204_0.imethod_0());
			gclass.method_3(this.gclass204_0.method_2(this.type_0, string_0));
			gclass.imethod_2(GClass166.smethod_0(this.gclass204_0.method_2(this.type_0, string_0)) + " " + string_0);
			return gclass;
		}

		// Token: 0x0400180F RID: 6159
		public GClass204 gclass204_0;

		// Token: 0x04001810 RID: 6160
		public Type type_0;
	}

	// Token: 0x0200066D RID: 1645
	[Serializable]
	private sealed class Class707
	{
		// Token: 0x0600233A RID: 9018 RVA: 0x0008D364 File Offset: 0x0008B564
		internal bool method_0(Type type_0)
		{
			return type_0.Namespace == "nspector.Native.NvApi.DriverSettings" && type_0.IsEnum && type_0.Name.StartsWith("EValues_");
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x0008D394 File Offset: 0x0008B594
		internal bool method_1(string string_0)
		{
			return string_0.EndsWith("_DEFAULT");
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x0008D3A4 File Offset: 0x0008B5A4
		internal bool method_2(string string_0)
		{
			return !string_0.EndsWith("_DEFAULT") && !string_0.EndsWith("_NUM_VALUES");
		}

		// Token: 0x04001811 RID: 6161
		public static readonly GClass204.Class707 class707_0 = new GClass204.Class707();

		// Token: 0x04001812 RID: 6162
		public static Func<Type, bool> func_0;

		// Token: 0x04001813 RID: 6163
		public static Func<string, bool> func_1;

		// Token: 0x04001814 RID: 6164
		public static Func<string, bool> func_2;
	}

	// Token: 0x0200066E RID: 1646
	private sealed class Class708
	{
		// Token: 0x0600233E RID: 9022 RVA: 0x0008D3CC File Offset: 0x0008B5CC
		internal bool method_0(Type type_0)
		{
			return this.string_0.Substring(0, this.string_0.Length - 3).Equals(type_0.Name.Substring(8));
		}

		// Token: 0x04001815 RID: 6165
		public string string_0;
	}
}
