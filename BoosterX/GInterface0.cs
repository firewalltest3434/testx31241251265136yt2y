using System;
using System.IO;
using System.Threading.Tasks;

// Token: 0x02000172 RID: 370
public interface GInterface0
{
	// Token: 0x06000991 RID: 2449
	GClass167 imethod_0();

	// Token: 0x06000992 RID: 2450
	void imethod_1(GClass167 gclass167_0);

	// Token: 0x06000993 RID: 2451
	Task<Stream> imethod_2(GClass167 gclass167_0);

	// Token: 0x06000994 RID: 2452
	Task<Stream> imethod_3(string string_0, string string_1, double? nullable_0, string string_2, GClass89 gclass89_0);

	// Token: 0x06000995 RID: 2453
	Task<FileInfo> imethod_4(GClass167 gclass167_0, string string_0);

	// Token: 0x06000996 RID: 2454
	Task<FileInfo> imethod_5(string string_0, string string_1, string string_2, double? nullable_0, string string_3, GClass89 gclass89_0);
}
