using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x02000479 RID: 1145
[DefaultMember("#=zFR_km9Q=")]
public sealed class GClass139
{
	// Token: 0x06001959 RID: 6489 RVA: 0x00068328 File Offset: 0x00066528
	private GClass139()
	{
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x0006833C File Offset: 0x0006653C
	public static GClass139 smethod_0()
	{
		if (GClass139.gclass139_0 == null)
		{
			GClass139.gclass139_0 = new GClass139();
		}
		return GClass139.gclass139_0;
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x00068354 File Offset: 0x00066554
	public Dictionary<string, GClass155> method_0()
	{
		if (this.dictionary_0 == null)
		{
			this.dictionary_0 = new Dictionary<string, GClass155>();
			this.gclass207_0.method_2<List<GClass155>>("BoosterX.Resources.Json.allServices.json").ForEach(new Action<GClass155>(this.method_1));
		}
		return this.dictionary_0;
	}

	// Token: 0x170003C9 RID: 969
	// (get) Token: 0x0600195C RID: 6492 RVA: 0x00068390 File Offset: 0x00066590
	// (set) Token: 0x0600195D RID: 6493 RVA: 0x000683B8 File Offset: 0x000665B8
	public GClass155 Item
	{
		get
		{
			GClass155 result;
			if (!this.method_0().TryGetValue(string_0.ToLower(), out result))
			{
				return null;
			}
			return result;
		}
		set
		{
			this.method_0()[string_0.ToLower()] = value;
		}
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x000683CC File Offset: 0x000665CC
	private void method_1(GClass155 gclass155_0)
	{
		this.set_Item(gclass155_0.ServiceName, gclass155_0);
	}

	// Token: 0x040011B4 RID: 4532
	private static GClass139 gclass139_0;

	// Token: 0x040011B5 RID: 4533
	private GClass207 gclass207_0 = new GClass207();

	// Token: 0x040011B6 RID: 4534
	private Dictionary<string, GClass155> dictionary_0;
}
