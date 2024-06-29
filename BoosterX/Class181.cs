using System;

// Token: 0x0200014F RID: 335
internal static class Class181
{
	// Token: 0x0600088D RID: 2189 RVA: 0x00028EF8 File Offset: 0x000270F8
	public static long smethod_0(this DateTime dateTime_0)
	{
		DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
		return (long)(dateTime_0.ToLocalTime() - d).TotalSeconds;
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00028F30 File Offset: 0x00027130
	public static DateTime smethod_1(this long long_0)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
		return dateTime.AddSeconds((double)long_0);
	}
}
