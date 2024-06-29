using System;
using System.IO;
using System.Threading.Tasks;

// Token: 0x02000411 RID: 1041
public interface GInterface9
{
	// Token: 0x06001674 RID: 5748
	GClass83 imethod_0();

	// Token: 0x06001675 RID: 5749
	void imethod_1(GClass83 gclass83_0);

	// Token: 0x06001676 RID: 5750
	Task<string> imethod_2(Stream stream_0, string string_0, string string_1, string string_2, string string_3, double? nullable_0);

	// Token: 0x06001677 RID: 5751
	Task<string> imethod_3(string string_0, string string_1, string string_2, string string_3, double? nullable_0);

	// Token: 0x06001678 RID: 5752
	Task<GClass39> imethod_4(Stream stream_0, string string_0, string string_1, string string_2, double? nullable_0);

	// Token: 0x06001679 RID: 5753
	Task<GClass39> imethod_5(string string_0, string string_1, string string_2, double? nullable_0);

	// Token: 0x0600167A RID: 5754
	Task<string> imethod_6(Stream stream_0, string string_0, string string_1, string string_2, double? nullable_0);

	// Token: 0x0600167B RID: 5755
	Task<string> imethod_7(string string_0, string string_1, string string_2, double? nullable_0);
}
