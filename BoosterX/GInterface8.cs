using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Token: 0x020003E0 RID: 992
public interface GInterface8
{
	// Token: 0x060015D2 RID: 5586
	GClass44 imethod_0();

	// Token: 0x060015D3 RID: 5587
	void imethod_1(GClass44 gclass44_0);

	// Token: 0x060015D4 RID: 5588
	Task<GClass33> imethod_2(GClass44 gclass44_0);

	// Token: 0x060015D5 RID: 5589
	Task<GClass33> imethod_3(string string_0, GClass89 gclass89_0, int? nullable_0, double? nullable_1, double? nullable_2, int? nullable_3, double? nullable_4, double? nullable_5, int? nullable_6, bool? nullable_7, string[] string_1);

	// Token: 0x060015D6 RID: 5590
	Task<GClass33> imethod_4(string[] string_0);

	// Token: 0x060015D7 RID: 5591
	Task<GClass33> imethod_5(GClass44 gclass44_0, int int_0);

	// Token: 0x060015D8 RID: 5592
	Task imethod_6(GClass44 gclass44_0, Action<int, GClass33> action_0);

	// Token: 0x060015D9 RID: 5593
	Task imethod_7(GClass44 gclass44_0, Action<GClass33> action_0);

	// Token: 0x060015DA RID: 5594
	IAsyncEnumerable<GClass33> imethod_8(GClass44 gclass44_0);

	// Token: 0x060015DB RID: 5595
	IAsyncEnumerable<GClass33> imethod_9(string string_0, GClass89 gclass89_0, int? nullable_0, double? nullable_1, double? nullable_2, int? nullable_3, double? nullable_4, double? nullable_5, int? nullable_6, bool? nullable_7, string[] string_1);

	// Token: 0x060015DC RID: 5596
	Task<string> imethod_10(GClass44 gclass44_0);

	// Token: 0x060015DD RID: 5597
	Task<string> imethod_11(string string_0);
}
