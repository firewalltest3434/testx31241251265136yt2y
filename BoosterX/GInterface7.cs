using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Token: 0x020003D1 RID: 977
public interface GInterface7
{
	// Token: 0x06001591 RID: 5521
	GClass45 imethod_0();

	// Token: 0x06001592 RID: 5522
	void imethod_1(GClass45 gclass45_0);

	// Token: 0x06001593 RID: 5523
	GClass41 imethod_2(GClass45 gclass45_0);

	// Token: 0x06001594 RID: 5524
	Task<GClass38> imethod_3(GClass45 gclass45_0);

	// Token: 0x06001595 RID: 5525
	Task<GClass38> imethod_4(GClass45 gclass45_0, int int_0);

	// Token: 0x06001596 RID: 5526
	Task<GClass38> imethod_5(IList<GClass163> ilist_0, GClass89 gclass89_0, double? nullable_0, double? nullable_1, int? nullable_2, int? nullable_3, double? nullable_4, double? nullable_5, IReadOnlyDictionary<string, float> ireadOnlyDictionary_0, string[] string_0);

	// Token: 0x06001597 RID: 5527
	Task<GClass38> imethod_6(GClass163[] gclass163_0);

	// Token: 0x06001598 RID: 5528
	Task<GClass38> imethod_7(string[] string_0);

	// Token: 0x06001599 RID: 5529
	Task<GClass38> imethod_8(string string_0, GClass163.GClass164[] gclass164_0);

	// Token: 0x0600159A RID: 5530
	Task imethod_9(GClass45 gclass45_0, Action<GClass38> action_0);

	// Token: 0x0600159B RID: 5531
	IAsyncEnumerable<GClass38> imethod_10(GClass45 gclass45_0);

	// Token: 0x0600159C RID: 5532
	IAsyncEnumerable<GClass38> imethod_11(IList<GClass163> ilist_0, GClass89 gclass89_0, double? nullable_0, double? nullable_1, int? nullable_2, int? nullable_3, double? nullable_4, double? nullable_5, IReadOnlyDictionary<string, float> ireadOnlyDictionary_0, string[] string_0);

	// Token: 0x0600159D RID: 5533
	Task imethod_12(GClass45 gclass45_0, Action<int, GClass38> action_0);
}
