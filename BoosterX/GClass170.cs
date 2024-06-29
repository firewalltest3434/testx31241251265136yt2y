using System;

// Token: 0x02000598 RID: 1432
public sealed class GClass170 : IEquatable<GClass170>
{
	// Token: 0x06001ED0 RID: 7888 RVA: 0x000801EC File Offset: 0x0007E3EC
	private GClass170(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06001ED2 RID: 7890 RVA: 0x0008022C File Offset: 0x0007E42C
	public static GClass170 smethod_0(string string_1)
	{
		if (string_1 == "system")
		{
			return GClass170.smethod_1();
		}
		if (string_1 == "user")
		{
			return GClass170.smethod_2();
		}
		if (!(string_1 == "assistant"))
		{
			return null;
		}
		return GClass170.smethod_3();
	}

	// Token: 0x06001ED3 RID: 7891 RVA: 0x00080268 File Offset: 0x0007E468
	private string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06001ED4 RID: 7892 RVA: 0x00080270 File Offset: 0x0007E470
	public static GClass170 smethod_1()
	{
		return GClass170.gclass170_0;
	}

	// Token: 0x06001ED5 RID: 7893 RVA: 0x00080278 File Offset: 0x0007E478
	public static GClass170 smethod_2()
	{
		return GClass170.gclass170_1;
	}

	// Token: 0x06001ED6 RID: 7894 RVA: 0x00080280 File Offset: 0x0007E480
	public static GClass170 smethod_3()
	{
		return GClass170.gclass170_2;
	}

	// Token: 0x06001ED7 RID: 7895 RVA: 0x00080288 File Offset: 0x0007E488
	public override string ToString()
	{
		return this.method_0();
	}

	// Token: 0x06001ED8 RID: 7896 RVA: 0x00080290 File Offset: 0x0007E490
	public override bool Equals(object obj)
	{
		return this.method_0().Equals((obj as GClass170).method_0());
	}

	// Token: 0x06001ED9 RID: 7897 RVA: 0x000802A8 File Offset: 0x0007E4A8
	public override int GetHashCode()
	{
		return this.method_0().GetHashCode();
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x000802B8 File Offset: 0x0007E4B8
	public bool Equals(GClass170 other)
	{
		return this.method_0().Equals(other.method_0());
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x000802CC File Offset: 0x0007E4CC
	public static implicit operator string(GClass170 gclass170_3)
	{
		return gclass170_3.method_0();
	}

	// Token: 0x040015A8 RID: 5544
	private readonly string string_0;

	// Token: 0x040015A9 RID: 5545
	private static readonly GClass170 gclass170_0 = new GClass170("system");

	// Token: 0x040015AA RID: 5546
	private static readonly GClass170 gclass170_1 = new GClass170("user");

	// Token: 0x040015AB RID: 5547
	private static readonly GClass170 gclass170_2 = new GClass170("assistant");
}
