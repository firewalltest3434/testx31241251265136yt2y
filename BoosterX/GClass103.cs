using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

// Token: 0x02000346 RID: 838
public sealed class GClass103
{
	// Token: 0x1700026C RID: 620
	// (get) Token: 0x060012F8 RID: 4856 RVA: 0x0004DDC8 File Offset: 0x0004BFC8
	// (set) Token: 0x060012F9 RID: 4857 RVA: 0x0004DDD0 File Offset: 0x0004BFD0
	[JsonProperty("categories")]
	public IDictionary<string, bool> IDictionary_0
	{
		get
		{
			return this.idictionary_0;
		}
		set
		{
			this.idictionary_0 = value;
		}
	}

	// Token: 0x1700026D RID: 621
	// (get) Token: 0x060012FA RID: 4858 RVA: 0x0004DDDC File Offset: 0x0004BFDC
	// (set) Token: 0x060012FB RID: 4859 RVA: 0x0004DDE4 File Offset: 0x0004BFE4
	[JsonProperty("category_scores")]
	public IDictionary<string, double> IDictionary_1
	{
		get
		{
			return this.idictionary_1;
		}
		set
		{
			this.idictionary_1 = value;
		}
	}

	// Token: 0x1700026E RID: 622
	// (get) Token: 0x060012FC RID: 4860 RVA: 0x0004DDF0 File Offset: 0x0004BFF0
	// (set) Token: 0x060012FD RID: 4861 RVA: 0x0004DDF8 File Offset: 0x0004BFF8
	[JsonProperty("flagged")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x060012FE RID: 4862 RVA: 0x0004DE04 File Offset: 0x0004C004
	public IList<string> FlaggedCategories
	{
		get
		{
			return this.IDictionary_0.Where(new Func<KeyValuePair<string, bool>, bool>(GClass103.Class388.class388_0.method_0)).OrderByDescending(new Func<KeyValuePair<string, bool>, double?>(this.method_0)).Select(new Func<KeyValuePair<string, bool>, string>(GClass103.Class388.class388_0.method_1)).ToList<string>();
		}
	}

	// Token: 0x17000270 RID: 624
	// (get) Token: 0x060012FF RID: 4863 RVA: 0x0004DE78 File Offset: 0x0004C078
	public string MainContentFlag
	{
		get
		{
			return this.FlaggedCategories.FirstOrDefault<string>();
		}
	}

	// Token: 0x17000271 RID: 625
	// (get) Token: 0x06001300 RID: 4864 RVA: 0x0004DE88 File Offset: 0x0004C088
	public double HighestFlagScore
	{
		get
		{
			return this.IDictionary_1.OrderByDescending(new Func<KeyValuePair<string, double>, double>(GClass103.Class388.class388_0.method_2)).First<KeyValuePair<string, double>>().Value;
		}
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x0004DECC File Offset: 0x0004C0CC
	private double? method_0(KeyValuePair<string, bool> keyValuePair_0)
	{
		IDictionary<string, double> dictionary = this.IDictionary_1;
		if (dictionary == null)
		{
			return null;
		}
		return new double?(dictionary[keyValuePair_0.Key]);
	}

	// Token: 0x04000BA0 RID: 2976
	private IDictionary<string, bool> idictionary_0;

	// Token: 0x04000BA1 RID: 2977
	private IDictionary<string, double> idictionary_1;

	// Token: 0x04000BA2 RID: 2978
	private bool bool_0;

	// Token: 0x02000347 RID: 839
	[Serializable]
	private sealed class Class388
	{
		// Token: 0x06001304 RID: 4868 RVA: 0x0004DF14 File Offset: 0x0004C114
		internal bool method_0(KeyValuePair<string, bool> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0004DF20 File Offset: 0x0004C120
		internal string method_1(KeyValuePair<string, bool> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0004DF2C File Offset: 0x0004C12C
		internal double method_2(KeyValuePair<string, double> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		// Token: 0x04000BA3 RID: 2979
		public static readonly GClass103.Class388 class388_0 = new GClass103.Class388();

		// Token: 0x04000BA4 RID: 2980
		public static Func<KeyValuePair<string, bool>, bool> func_0;

		// Token: 0x04000BA5 RID: 2981
		public static Func<KeyValuePair<string, bool>, string> func_1;

		// Token: 0x04000BA6 RID: 2982
		public static Func<KeyValuePair<string, double>, double> func_2;
	}
}
