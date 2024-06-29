using System;

// Token: 0x02000337 RID: 823
public sealed class GException8 : GException7
{
	// Token: 0x06001292 RID: 4754 RVA: 0x0004CF68 File Offset: 0x0004B168
	public GException8(string string_1) : base("DRS_CreateApplication", GEnum0.NVAPI_EXECUTABLE_ALREADY_IN_USE)
	{
		this.string_0 = string_1;
	}

	// Token: 0x04000B78 RID: 2936
	public readonly string string_0;
}
