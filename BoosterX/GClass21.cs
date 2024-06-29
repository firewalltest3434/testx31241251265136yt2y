using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02000155 RID: 341
public sealed class GClass21
{
	// Token: 0x06000891 RID: 2193 RVA: 0x00029140 File Offset: 0x00027340
	public GClass187 method_0()
	{
		List<GClass187> list = this.List_1;
		if (list == null)
		{
			return null;
		}
		return list.Find(new Predicate<GClass187>(GClass21.Class182.class182_0.method_0));
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000892 RID: 2194 RVA: 0x00029174 File Offset: 0x00027374
	// (set) Token: 0x06000893 RID: 2195 RVA: 0x0002917C File Offset: 0x0002737C
	[JsonProperty("categories")]
	public List<string> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000894 RID: 2196 RVA: 0x00029188 File Offset: 0x00027388
	// (set) Token: 0x06000895 RID: 2197 RVA: 0x00029190 File Offset: 0x00027390
	[JsonProperty("images")]
	public List<GClass187> List_1
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

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000896 RID: 2198 RVA: 0x0002919C File Offset: 0x0002739C
	// (set) Token: 0x06000897 RID: 2199 RVA: 0x000291A4 File Offset: 0x000273A4
	[JsonProperty("productId")]
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

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000898 RID: 2200 RVA: 0x000291B0 File Offset: 0x000273B0
	// (set) Token: 0x06000899 RID: 2201 RVA: 0x000291B8 File Offset: 0x000273B8
	[JsonProperty("title")]
	public string String_1
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

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x0600089A RID: 2202 RVA: 0x000291C4 File Offset: 0x000273C4
	// (set) Token: 0x0600089B RID: 2203 RVA: 0x000291CC File Offset: 0x000273CC
	[JsonProperty("shortTitle")]
	public string String_2
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

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x0600089C RID: 2204 RVA: 0x000291D8 File Offset: 0x000273D8
	// (set) Token: 0x0600089D RID: 2205 RVA: 0x000291E0 File Offset: 0x000273E0
	[JsonProperty("titleLayout")]
	public string String_3
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

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x0600089E RID: 2206 RVA: 0x000291EC File Offset: 0x000273EC
	// (set) Token: 0x0600089F RID: 2207 RVA: 0x000291F4 File Offset: 0x000273F4
	[JsonProperty("description")]
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return this.string_4;
		}
		[CompilerGenerated]
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00029200 File Offset: 0x00027400
	// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00029208 File Offset: 0x00027408
	[JsonProperty("publisherName")]
	public string String_4
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00029214 File Offset: 0x00027414
	// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0002921C File Offset: 0x0002741C
	[JsonProperty("publisherId")]
	public string String_5
	{
		get
		{
			return this.string_6;
		}
		set
		{
			this.string_6 = value;
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00029228 File Offset: 0x00027428
	// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00029230 File Offset: 0x00027430
	[JsonProperty("isUniversal")]
	public string String_6
	{
		get
		{
			return this.string_7;
		}
		set
		{
			this.string_7 = value;
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0002923C File Offset: 0x0002743C
	// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00029244 File Offset: 0x00027444
	[JsonProperty("language")]
	public string String_7
	{
		get
		{
			return this.string_8;
		}
		set
		{
			this.string_8 = value;
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00029250 File Offset: 0x00027450
	// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00029258 File Offset: 0x00027458
	[JsonProperty("bgColor")]
	public string String_8
	{
		get
		{
			return this.string_9;
		}
		set
		{
			this.string_9 = value;
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x060008AA RID: 2218 RVA: 0x00029264 File Offset: 0x00027464
	// (set) Token: 0x060008AB RID: 2219 RVA: 0x0002926C File Offset: 0x0002746C
	[JsonProperty("fgColor")]
	public string String_9
	{
		get
		{
			return this.string_10;
		}
		set
		{
			this.string_10 = value;
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x060008AC RID: 2220 RVA: 0x00029278 File Offset: 0x00027478
	// (set) Token: 0x060008AD RID: 2221 RVA: 0x00029280 File Offset: 0x00027480
	[JsonProperty("averageRating")]
	public string String_10
	{
		get
		{
			return this.string_11;
		}
		set
		{
			this.string_11 = value;
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x060008AE RID: 2222 RVA: 0x0002928C File Offset: 0x0002748C
	// (set) Token: 0x060008AF RID: 2223 RVA: 0x00029294 File Offset: 0x00027494
	[JsonProperty("ratingCount")]
	public string String_11
	{
		get
		{
			return this.string_12;
		}
		set
		{
			this.string_12 = value;
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x060008B0 RID: 2224 RVA: 0x000292A0 File Offset: 0x000274A0
	// (set) Token: 0x060008B1 RID: 2225 RVA: 0x000292A8 File Offset: 0x000274A8
	[JsonProperty("hasFreeTrial")]
	public string String_12
	{
		get
		{
			return this.string_13;
		}
		set
		{
			this.string_13 = value;
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060008B2 RID: 2226 RVA: 0x000292B4 File Offset: 0x000274B4
	// (set) Token: 0x060008B3 RID: 2227 RVA: 0x000292BC File Offset: 0x000274BC
	[JsonProperty("productType")]
	public string String_13
	{
		get
		{
			return this.string_14;
		}
		set
		{
			this.string_14 = value;
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000292C8 File Offset: 0x000274C8
	// (set) Token: 0x060008B5 RID: 2229 RVA: 0x000292D0 File Offset: 0x000274D0
	[JsonProperty("price")]
	public string String_14
	{
		get
		{
			return this.string_15;
		}
		set
		{
			this.string_15 = value;
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000292DC File Offset: 0x000274DC
	// (set) Token: 0x060008B7 RID: 2231 RVA: 0x000292E4 File Offset: 0x000274E4
	[JsonProperty("currencySymbol")]
	public string String_15
	{
		get
		{
			return this.string_16;
		}
		set
		{
			this.string_16 = value;
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x060008B8 RID: 2232 RVA: 0x000292F0 File Offset: 0x000274F0
	// (set) Token: 0x060008B9 RID: 2233 RVA: 0x000292F8 File Offset: 0x000274F8
	[JsonProperty("currencyCode")]
	public string String_16
	{
		get
		{
			return this.string_17;
		}
		set
		{
			this.string_17 = value;
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x060008BA RID: 2234 RVA: 0x00029304 File Offset: 0x00027504
	// (set) Token: 0x060008BB RID: 2235 RVA: 0x0002930C File Offset: 0x0002750C
	[JsonProperty("displayPrice")]
	public string String_17
	{
		get
		{
			return this.string_18;
		}
		set
		{
			this.string_18 = value;
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x060008BC RID: 2236 RVA: 0x00029318 File Offset: 0x00027518
	// (set) Token: 0x060008BD RID: 2237 RVA: 0x00029320 File Offset: 0x00027520
	[JsonProperty("strikethroughPrice")]
	public string String_18
	{
		get
		{
			return this.string_19;
		}
		set
		{
			this.string_19 = value;
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x060008BE RID: 2238 RVA: 0x0002932C File Offset: 0x0002752C
	// (set) Token: 0x060008BF RID: 2239 RVA: 0x00029334 File Offset: 0x00027534
	[JsonProperty("developerName")]
	public string String_19
	{
		get
		{
			return this.string_20;
		}
		set
		{
			this.string_20 = value;
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00029340 File Offset: 0x00027540
	// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00029348 File Offset: 0x00027548
	[JsonProperty("productFamilyName")]
	public string String_20
	{
		get
		{
			return this.string_21;
		}
		set
		{
			this.string_21 = value;
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00029354 File Offset: 0x00027554
	// (set) Token: 0x060008C3 RID: 2243 RVA: 0x0002935C File Offset: 0x0002755C
	[JsonProperty("mediaType")]
	public string String_21
	{
		get
		{
			return this.string_22;
		}
		set
		{
			this.string_22 = value;
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00029368 File Offset: 0x00027568
	// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00029370 File Offset: 0x00027570
	[JsonProperty("contentIds")]
	public List<string> List_2
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

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0002937C File Offset: 0x0002757C
	// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00029384 File Offset: 0x00027584
	[JsonProperty("packageFamilyNames")]
	public List<string> List_3
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

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00029390 File Offset: 0x00027590
	// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00029398 File Offset: 0x00027598
	[JsonProperty("subcategoryName")]
	public string String_22
	{
		get
		{
			return this.string_23;
		}
		set
		{
			this.string_23 = value;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060008CA RID: 2250 RVA: 0x000293A4 File Offset: 0x000275A4
	// (set) Token: 0x060008CB RID: 2251 RVA: 0x000293AC File Offset: 0x000275AC
	[JsonProperty("alternateIds")]
	public List<GClass140> List_4
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

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060008CC RID: 2252 RVA: 0x000293B8 File Offset: 0x000275B8
	// (set) Token: 0x060008CD RID: 2253 RVA: 0x000293C0 File Offset: 0x000275C0
	[JsonProperty("collectionItemType")]
	public string String_23
	{
		get
		{
			return this.string_24;
		}
		set
		{
			this.string_24 = value;
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x060008CE RID: 2254 RVA: 0x000293CC File Offset: 0x000275CC
	// (set) Token: 0x060008CF RID: 2255 RVA: 0x000293D4 File Offset: 0x000275D4
	[JsonProperty("numberOfSeasons")]
	public string String_24
	{
		get
		{
			return this.string_25;
		}
		set
		{
			this.string_25 = value;
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x060008D0 RID: 2256 RVA: 0x000293E0 File Offset: 0x000275E0
	// (set) Token: 0x060008D1 RID: 2257 RVA: 0x000293E8 File Offset: 0x000275E8
	[JsonProperty("releaseDateUtc")]
	public string String_25
	{
		get
		{
			return this.string_26;
		}
		set
		{
			this.string_26 = value;
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060008D2 RID: 2258 RVA: 0x000293F4 File Offset: 0x000275F4
	// (set) Token: 0x060008D3 RID: 2259 RVA: 0x000293FC File Offset: 0x000275FC
	[JsonProperty("durationInSeconds")]
	public string String_26
	{
		get
		{
			return this.string_27;
		}
		set
		{
			this.string_27 = value;
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00029408 File Offset: 0x00027608
	// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00029410 File Offset: 0x00027610
	[JsonProperty("isCompatible")]
	public string String_27
	{
		get
		{
			return this.string_28;
		}
		set
		{
			this.string_28 = value;
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0002941C File Offset: 0x0002761C
	// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00029424 File Offset: 0x00027624
	[JsonProperty("isPurchaseEnabled")]
	public string String_28
	{
		get
		{
			return this.string_29;
		}
		set
		{
			this.string_29 = value;
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060008D8 RID: 2264 RVA: 0x00029430 File Offset: 0x00027630
	// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00029438 File Offset: 0x00027638
	[JsonProperty("developerOptOutOfSDCardInstall")]
	public string String_29
	{
		get
		{
			return this.string_30;
		}
		set
		{
			this.string_30 = value;
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x060008DA RID: 2266 RVA: 0x00029444 File Offset: 0x00027644
	// (set) Token: 0x060008DB RID: 2267 RVA: 0x0002944C File Offset: 0x0002764C
	[JsonProperty("hasAddOns")]
	public string String_30
	{
		get
		{
			return this.string_31;
		}
		set
		{
			this.string_31 = value;
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x060008DC RID: 2268 RVA: 0x00029458 File Offset: 0x00027658
	// (set) Token: 0x060008DD RID: 2269 RVA: 0x00029460 File Offset: 0x00027660
	[JsonProperty("hasThirdPartyIAPs")]
	public string String_31
	{
		get
		{
			return this.string_32;
		}
		set
		{
			this.string_32 = value;
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060008DE RID: 2270 RVA: 0x0002946C File Offset: 0x0002766C
	// (set) Token: 0x060008DF RID: 2271 RVA: 0x00029474 File Offset: 0x00027674
	[JsonProperty("voiceTitle")]
	public string String_32
	{
		get
		{
			return this.string_33;
		}
		set
		{
			this.string_33 = value;
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00029480 File Offset: 0x00027680
	// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00029488 File Offset: 0x00027688
	[JsonProperty("hideFromCollections")]
	public string String_33
	{
		get
		{
			return this.string_34;
		}
		set
		{
			this.string_34 = value;
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00029494 File Offset: 0x00027694
	// (set) Token: 0x060008E3 RID: 2275 RVA: 0x0002949C File Offset: 0x0002769C
	[JsonProperty("hideFromDownloadsAndUpdates")]
	public string String_34
	{
		get
		{
			return this.string_35;
		}
		set
		{
			this.string_35 = value;
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x060008E4 RID: 2276 RVA: 0x000294A8 File Offset: 0x000276A8
	// (set) Token: 0x060008E5 RID: 2277 RVA: 0x000294B0 File Offset: 0x000276B0
	[JsonProperty("gamingOptionsXboxLive")]
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

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060008E6 RID: 2278 RVA: 0x000294BC File Offset: 0x000276BC
	// (set) Token: 0x060008E7 RID: 2279 RVA: 0x000294C4 File Offset: 0x000276C4
	[JsonProperty("availableDevicesDisplayText")]
	public string String_35
	{
		get
		{
			return this.string_36;
		}
		set
		{
			this.string_36 = value;
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060008E8 RID: 2280 RVA: 0x000294D0 File Offset: 0x000276D0
	// (set) Token: 0x060008E9 RID: 2281 RVA: 0x000294D8 File Offset: 0x000276D8
	[JsonProperty("availableDevicesNarratorText")]
	public string String_36
	{
		get
		{
			return this.string_37;
		}
		set
		{
			this.string_37 = value;
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060008EA RID: 2282 RVA: 0x000294E4 File Offset: 0x000276E4
	// (set) Token: 0x060008EB RID: 2283 RVA: 0x000294EC File Offset: 0x000276EC
	[JsonProperty("isGamingAppOnly")]
	public bool Boolean_1
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060008EC RID: 2284 RVA: 0x000294F8 File Offset: 0x000276F8
	// (set) Token: 0x060008ED RID: 2285 RVA: 0x00029500 File Offset: 0x00027700
	[JsonProperty("isSoftBlocked")]
	public string String_37
	{
		get
		{
			return this.string_38;
		}
		set
		{
			this.string_38 = value;
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060008EE RID: 2286 RVA: 0x0002950C File Offset: 0x0002770C
	// (set) Token: 0x060008EF RID: 2287 RVA: 0x00029514 File Offset: 0x00027714
	[JsonProperty("tileLayout")]
	public string String_38
	{
		get
		{
			return this.string_39;
		}
		set
		{
			this.string_39 = value;
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00029520 File Offset: 0x00027720
	// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00029528 File Offset: 0x00027728
	[JsonProperty("typeTag")]
	public string String_39
	{
		get
		{
			return this.string_40;
		}
		set
		{
			this.string_40 = value;
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00029534 File Offset: 0x00027734
	// (set) Token: 0x060008F3 RID: 2291 RVA: 0x0002953C File Offset: 0x0002773C
	[JsonProperty("longDescription")]
	public string String_40
	{
		get
		{
			return this.string_41;
		}
		set
		{
			this.string_41 = value;
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00029548 File Offset: 0x00027748
	// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00029550 File Offset: 0x00027750
	[JsonProperty("schema")]
	public string String_41
	{
		get
		{
			return this.string_42;
		}
		set
		{
			this.string_42 = value;
		}
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0002955C File Offset: 0x0002775C
	// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00029564 File Offset: 0x00027764
	[JsonProperty("iconUrl")]
	public string String_42
	{
		get
		{
			return this.string_43;
		}
		set
		{
			this.string_43 = value;
		}
	}

	// Token: 0x040004F2 RID: 1266
	private List<string> list_0;

	// Token: 0x040004F3 RID: 1267
	private List<GClass187> list_1;

	// Token: 0x040004F4 RID: 1268
	private string string_0;

	// Token: 0x040004F5 RID: 1269
	private string string_1;

	// Token: 0x040004F6 RID: 1270
	private string string_2;

	// Token: 0x040004F7 RID: 1271
	private string string_3;

	// Token: 0x040004F8 RID: 1272
	private string string_4;

	// Token: 0x040004F9 RID: 1273
	private string string_5;

	// Token: 0x040004FA RID: 1274
	private string string_6;

	// Token: 0x040004FB RID: 1275
	private string string_7;

	// Token: 0x040004FC RID: 1276
	private string string_8;

	// Token: 0x040004FD RID: 1277
	private string string_9;

	// Token: 0x040004FE RID: 1278
	private string string_10;

	// Token: 0x040004FF RID: 1279
	private string string_11;

	// Token: 0x04000500 RID: 1280
	private string string_12;

	// Token: 0x04000501 RID: 1281
	private string string_13;

	// Token: 0x04000502 RID: 1282
	private string string_14;

	// Token: 0x04000503 RID: 1283
	private string string_15;

	// Token: 0x04000504 RID: 1284
	private string string_16;

	// Token: 0x04000505 RID: 1285
	private string string_17;

	// Token: 0x04000506 RID: 1286
	private string string_18;

	// Token: 0x04000507 RID: 1287
	private string string_19;

	// Token: 0x04000508 RID: 1288
	private string string_20;

	// Token: 0x04000509 RID: 1289
	private string string_21;

	// Token: 0x0400050A RID: 1290
	private string string_22;

	// Token: 0x0400050B RID: 1291
	private List<string> list_2;

	// Token: 0x0400050C RID: 1292
	private List<string> list_3;

	// Token: 0x0400050D RID: 1293
	private string string_23;

	// Token: 0x0400050E RID: 1294
	private List<GClass140> list_4;

	// Token: 0x0400050F RID: 1295
	private string string_24;

	// Token: 0x04000510 RID: 1296
	private string string_25;

	// Token: 0x04000511 RID: 1297
	private string string_26;

	// Token: 0x04000512 RID: 1298
	private string string_27;

	// Token: 0x04000513 RID: 1299
	private string string_28;

	// Token: 0x04000514 RID: 1300
	private string string_29;

	// Token: 0x04000515 RID: 1301
	private string string_30;

	// Token: 0x04000516 RID: 1302
	private string string_31;

	// Token: 0x04000517 RID: 1303
	private string string_32;

	// Token: 0x04000518 RID: 1304
	private string string_33;

	// Token: 0x04000519 RID: 1305
	private string string_34;

	// Token: 0x0400051A RID: 1306
	private string string_35;

	// Token: 0x0400051B RID: 1307
	private bool bool_0;

	// Token: 0x0400051C RID: 1308
	private string string_36;

	// Token: 0x0400051D RID: 1309
	private string string_37;

	// Token: 0x0400051E RID: 1310
	private bool bool_1;

	// Token: 0x0400051F RID: 1311
	private string string_38;

	// Token: 0x04000520 RID: 1312
	private string string_39;

	// Token: 0x04000521 RID: 1313
	private string string_40;

	// Token: 0x04000522 RID: 1314
	private string string_41;

	// Token: 0x04000523 RID: 1315
	private string string_42;

	// Token: 0x04000524 RID: 1316
	private string string_43;

	// Token: 0x02000156 RID: 342
	[Serializable]
	private sealed class Class182
	{
		// Token: 0x060008FA RID: 2298 RVA: 0x00029584 File Offset: 0x00027784
		internal bool method_0(GClass187 gclass187_0)
		{
			return gclass187_0.String_0 == "logo";
		}

		// Token: 0x04000525 RID: 1317
		public static readonly GClass21.Class182 class182_0 = new GClass21.Class182();

		// Token: 0x04000526 RID: 1318
		public static Predicate<GClass187> predicate_0;
	}
}
