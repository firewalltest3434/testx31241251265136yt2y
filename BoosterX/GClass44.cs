using System;
using Newtonsoft.Json;

// Token: 0x020001F0 RID: 496
public sealed class GClass44
{
	// Token: 0x06000BD1 RID: 3025 RVA: 0x000369AC File Offset: 0x00034BAC
	public GClass44()
	{
		this.String_0 = GClass89.smethod_0();
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x000369D4 File Offset: 0x00034BD4
	public GClass44(GClass44 gclass44_0)
	{
		this.String_0 = gclass44_0.String_0;
		this.String_1 = gclass44_0.String_1;
		this.Nullable_0 = gclass44_0.Nullable_0;
		this.Nullable_1 = gclass44_0.Nullable_1;
		this.Nullable_2 = gclass44_0.Nullable_2;
		this.Nullable_5 = gclass44_0.Nullable_5;
		this.Nullable_3 = gclass44_0.Nullable_3;
		this.Nullable_4 = gclass44_0.Nullable_4;
		this.Nullable_6 = gclass44_0.Nullable_6;
		this.Nullable_7 = gclass44_0.Nullable_7;
		this.String_4 = gclass44_0.String_4;
		this.Nullable_8 = gclass44_0.Nullable_8;
		this.String_6 = gclass44_0.String_6;
		this.String_3 = gclass44_0.String_3;
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x00036AA0 File Offset: 0x00034CA0
	public GClass44(params string[] string_5)
	{
		this.String_1 = string_5;
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x00036AC0 File Offset: 0x00034CC0
	public GClass44(string string_5, GClass89 gclass89_0 = null, int? nullable_9 = null, double? nullable_10 = null, string string_6 = null, double? nullable_11 = null, int? nullable_12 = null, double? nullable_13 = null, double? nullable_14 = null, int? nullable_15 = null, bool? nullable_16 = null, params string[] string_7)
	{
		this.String_0 = gclass89_0;
		this.String_2 = string_5;
		this.Nullable_0 = nullable_9;
		this.Nullable_1 = nullable_10;
		this.String_3 = string_6;
		this.Nullable_2 = nullable_11;
		this.Nullable_5 = nullable_12;
		this.Nullable_3 = nullable_13;
		this.Nullable_4 = nullable_14;
		this.Nullable_6 = nullable_15;
		this.Nullable_7 = nullable_16;
		this.String_4 = string_7;
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x00036B48 File Offset: 0x00034D48
	// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x00036B50 File Offset: 0x00034D50
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

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00036B5C File Offset: 0x00034D5C
	[JsonProperty("prompt")]
	public object Object_0
	{
		get
		{
			string[] array = this.String_1;
			if (array != null && array.Length == 1)
			{
				return this.String_2;
			}
			return this.String_1;
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00036B80 File Offset: 0x00034D80
	// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x00036B88 File Offset: 0x00034D88
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

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00036B94 File Offset: 0x00034D94
	// (set) Token: 0x06000BDB RID: 3035 RVA: 0x00036BA4 File Offset: 0x00034DA4
	[JsonIgnore]
	public string String_2
	{
		get
		{
			return Class333.smethod_2<string>(this.String_1);
		}
		set
		{
			this.String_1 = new string[]
			{
				value
			};
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00036BB8 File Offset: 0x00034DB8
	// (set) Token: 0x06000BDD RID: 3037 RVA: 0x00036BC0 File Offset: 0x00034DC0
	[JsonProperty("suffix")]
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

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00036BCC File Offset: 0x00034DCC
	// (set) Token: 0x06000BDF RID: 3039 RVA: 0x00036BD4 File Offset: 0x00034DD4
	[JsonProperty("max_tokens")]
	public int? Nullable_0
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

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00036BE0 File Offset: 0x00034DE0
	// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x00036BE8 File Offset: 0x00034DE8
	[JsonProperty("temperature")]
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

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00036BF4 File Offset: 0x00034DF4
	// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x00036BFC File Offset: 0x00034DFC
	[JsonProperty("top_p")]
	public double? Nullable_2
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

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00036C08 File Offset: 0x00034E08
	// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00036C10 File Offset: 0x00034E10
	[JsonProperty("presence_penalty")]
	public double? Nullable_3
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

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x00036C1C File Offset: 0x00034E1C
	// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x00036C24 File Offset: 0x00034E24
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

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00036C30 File Offset: 0x00034E30
	// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x00036C38 File Offset: 0x00034E38
	[JsonProperty("n")]
	public int? Nullable_5
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

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00036C44 File Offset: 0x00034E44
	// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00036C4C File Offset: 0x00034E4C
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

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00036C58 File Offset: 0x00034E58
	// (set) Token: 0x06000BED RID: 3053 RVA: 0x00036C60 File Offset: 0x00034E60
	[JsonProperty("logprobs")]
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

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00036C6C File Offset: 0x00034E6C
	// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00036C74 File Offset: 0x00034E74
	[JsonProperty("echo")]
	public bool? Nullable_7
	{
		get
		{
			return this.nullable_7;
		}
		set
		{
			this.nullable_7 = value;
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00036C80 File Offset: 0x00034E80
	[JsonProperty("stop")]
	public object Object_1
	{
		get
		{
			string[] array = this.String_4;
			if (array != null && array.Length == 1)
			{
				return this.String_5;
			}
			string[] array2 = this.String_4;
			if (array2 != null && array2.Length != 0)
			{
				return this.String_4;
			}
			return null;
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00036CB8 File Offset: 0x00034EB8
	// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x00036CC0 File Offset: 0x00034EC0
	[JsonIgnore]
	public string[] String_4
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

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00036CCC File Offset: 0x00034ECC
	// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x00036CE8 File Offset: 0x00034EE8
	[JsonIgnore]
	public string String_5
	{
		get
		{
			string[] array = this.String_4;
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
				this.String_4 = new string[]
				{
					value
				};
			}
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00036D00 File Offset: 0x00034F00
	// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00036D08 File Offset: 0x00034F08
	[JsonProperty("best_of")]
	public int? Nullable_8
	{
		get
		{
			return this.nullable_8;
		}
		set
		{
			this.nullable_8 = value;
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00036D14 File Offset: 0x00034F14
	// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00036D1C File Offset: 0x00034F1C
	[JsonProperty("user")]
	public string String_6
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

	// Token: 0x0400075A RID: 1882
	private string string_0 = GClass89.smethod_0();

	// Token: 0x0400075B RID: 1883
	private string[] string_1;

	// Token: 0x0400075C RID: 1884
	private string string_2;

	// Token: 0x0400075D RID: 1885
	private int? nullable_0;

	// Token: 0x0400075E RID: 1886
	private double? nullable_1;

	// Token: 0x0400075F RID: 1887
	private double? nullable_2;

	// Token: 0x04000760 RID: 1888
	private double? nullable_3;

	// Token: 0x04000761 RID: 1889
	private double? nullable_4;

	// Token: 0x04000762 RID: 1890
	private int? nullable_5;

	// Token: 0x04000763 RID: 1891
	private bool bool_0;

	// Token: 0x04000764 RID: 1892
	private int? nullable_6;

	// Token: 0x04000765 RID: 1893
	private bool? nullable_7;

	// Token: 0x04000766 RID: 1894
	private string[] string_3;

	// Token: 0x04000767 RID: 1895
	private int? nullable_8;

	// Token: 0x04000768 RID: 1896
	private string string_4;
}
