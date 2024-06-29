using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020001F4 RID: 500
public sealed class GClass45
{
	// Token: 0x06000BFC RID: 3068 RVA: 0x00036E10 File Offset: 0x00035010
	public GClass45()
	{
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00036E34 File Offset: 0x00035034
	public GClass45(GClass45 gclass45_0)
	{
		if (gclass45_0 == null)
		{
			return;
		}
		this.String_0 = gclass45_0.String_0;
		this.IList_0 = gclass45_0.IList_0;
		this.Nullable_0 = gclass45_0.Nullable_0;
		this.Nullable_1 = gclass45_0.Nullable_1;
		this.Nullable_2 = gclass45_0.Nullable_2;
		this.String_1 = gclass45_0.String_1;
		this.Nullable_3 = gclass45_0.Nullable_3;
		this.Nullable_4 = gclass45_0.Nullable_4;
		this.Nullable_5 = gclass45_0.Nullable_5;
		this.IReadOnlyDictionary_0 = gclass45_0.IReadOnlyDictionary_0;
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06000BFE RID: 3070 RVA: 0x00036EE0 File Offset: 0x000350E0
	// (set) Token: 0x06000BFF RID: 3071 RVA: 0x00036EE8 File Offset: 0x000350E8
	[JsonProperty("model")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00036EF4 File Offset: 0x000350F4
	// (set) Token: 0x06000C01 RID: 3073 RVA: 0x00036EFC File Offset: 0x000350FC
	[JsonProperty("messages")]
	public IList<GClass163> IList_0
	{
		get
		{
			return this.ilist_0;
		}
		set
		{
			this.ilist_0 = value;
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00036F08 File Offset: 0x00035108
	// (set) Token: 0x06000C03 RID: 3075 RVA: 0x00036F10 File Offset: 0x00035110
	[JsonProperty("temperature")]
	public double? Nullable_0
	{
		get
		{
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00036F1C File Offset: 0x0003511C
	// (set) Token: 0x06000C05 RID: 3077 RVA: 0x00036F24 File Offset: 0x00035124
	[JsonProperty("top_p")]
	public double? Nullable_1
	{
		get
		{
			return this.nullable_1;
		}
		set
		{
			this.nullable_1 = value;
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00036F30 File Offset: 0x00035130
	// (set) Token: 0x06000C07 RID: 3079 RVA: 0x00036F38 File Offset: 0x00035138
	[JsonProperty("n")]
	public int? Nullable_2
	{
		get
		{
			return this.nullable_2;
		}
		set
		{
			this.nullable_2 = value;
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00036F44 File Offset: 0x00035144
	// (set) Token: 0x06000C09 RID: 3081 RVA: 0x00036F4C File Offset: 0x0003514C
	[JsonProperty("stream")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		internal set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00036F58 File Offset: 0x00035158
	[JsonProperty("stop")]
	internal object Object_0
	{
		get
		{
			string[] array = this.String_1;
			if (array != null && array.Length == 1)
			{
				return this.String_2;
			}
			string[] array2 = this.String_1;
			if (array2 != null && array2.Length != 0)
			{
				return this.String_1;
			}
			return null;
		}
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00036F90 File Offset: 0x00035190
	// (set) Token: 0x06000C0C RID: 3084 RVA: 0x00036F98 File Offset: 0x00035198
	[JsonIgnore]
	public string[] String_1
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

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00036FA4 File Offset: 0x000351A4
	// (set) Token: 0x06000C0E RID: 3086 RVA: 0x00036FC0 File Offset: 0x000351C0
	[JsonIgnore]
	public string String_2
	{
		get
		{
			string[] array = this.String_1;
			string result;
			if (array != null)
			{
				if ((result = Class333.smethod_2<string>(array)) != null)
				{
					return result;
				}
			}
			result = null;
			return result;
		}
		set
		{
			if (value != null)
			{
				this.String_1 = new string[]
				{
					value
				};
			}
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00036FD8 File Offset: 0x000351D8
	// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00036FE0 File Offset: 0x000351E0
	[JsonProperty("max_tokens")]
	public int? Nullable_3
	{
		get
		{
			return this.nullable_3;
		}
		set
		{
			this.nullable_3 = value;
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00036FEC File Offset: 0x000351EC
	// (set) Token: 0x06000C12 RID: 3090 RVA: 0x00036FF4 File Offset: 0x000351F4
	[JsonProperty("frequency_penalty")]
	public double? Nullable_4
	{
		get
		{
			return this.nullable_4;
		}
		set
		{
			this.nullable_4 = value;
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00037000 File Offset: 0x00035200
	// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00037008 File Offset: 0x00035208
	[JsonProperty("presence_penalty")]
	public double? Nullable_5
	{
		get
		{
			return this.nullable_5;
		}
		set
		{
			this.nullable_5 = value;
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00037014 File Offset: 0x00035214
	// (set) Token: 0x06000C16 RID: 3094 RVA: 0x0003701C File Offset: 0x0003521C
	[JsonProperty("logit_bias")]
	public IReadOnlyDictionary<string, float> IReadOnlyDictionary_0
	{
		get
		{
			return this.ireadOnlyDictionary_0;
		}
		set
		{
			this.ireadOnlyDictionary_0 = value;
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00037028 File Offset: 0x00035228
	// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00037030 File Offset: 0x00035230
	[JsonProperty("user")]
	public string String_3
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0003703C File Offset: 0x0003523C
	// (set) Token: 0x06000C1A RID: 3098 RVA: 0x00037044 File Offset: 0x00035244
	[JsonIgnore]
	public string String_4
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

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00037050 File Offset: 0x00035250
	[JsonProperty("response_format", DefaultValueHandling = 1)]
	internal Dictionary<string, string> Dictionary_0
	{
		get
		{
			if (this.String_4 != null && !(this.String_4 == "text"))
			{
				return new Dictionary<string, string>
				{
					{
						"type",
						this.String_4
					}
				};
			}
			return null;
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00037084 File Offset: 0x00035284
	// (set) Token: 0x06000C1D RID: 3101 RVA: 0x0003708C File Offset: 0x0003528C
	[JsonProperty("seed", DefaultValueHandling = 1)]
	public int? Nullable_6
	{
		get
		{
			return this.nullable_6;
		}
		set
		{
			this.nullable_6 = value;
		}
	}

	// Token: 0x0400076B RID: 1899
	private string string_0 = GClass89.smethod_2();

	// Token: 0x0400076C RID: 1900
	private IList<GClass163> ilist_0;

	// Token: 0x0400076D RID: 1901
	private double? nullable_0;

	// Token: 0x0400076E RID: 1902
	private double? nullable_1;

	// Token: 0x0400076F RID: 1903
	private int? nullable_2;

	// Token: 0x04000770 RID: 1904
	private bool bool_0;

	// Token: 0x04000771 RID: 1905
	private string[] string_1;

	// Token: 0x04000772 RID: 1906
	private int? nullable_3;

	// Token: 0x04000773 RID: 1907
	private double? nullable_4;

	// Token: 0x04000774 RID: 1908
	private double? nullable_5;

	// Token: 0x04000775 RID: 1909
	private IReadOnlyDictionary<string, float> ireadOnlyDictionary_0;

	// Token: 0x04000776 RID: 1910
	private string string_2;

	// Token: 0x04000777 RID: 1911
	private string string_3 = "text";

	// Token: 0x04000778 RID: 1912
	private int? nullable_6;

	// Token: 0x020001F5 RID: 501
	public static class GClass46
	{
	}
}
