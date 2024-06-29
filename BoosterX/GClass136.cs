using System;
using System.Runtime.CompilerServices;

// Token: 0x02000460 RID: 1120
public sealed class GClass136 : IComparable<GClass136>
{
	// Token: 0x060018E0 RID: 6368 RVA: 0x00066B2C File Offset: 0x00064D2C
	public GClass136()
	{
	}

	// Token: 0x060018E1 RID: 6369 RVA: 0x00066B34 File Offset: 0x00064D34
	public GClass136(GStruct3 gstruct3_0)
	{
		this.method_1((int)gstruct3_0.uint_0);
		this.ProfileName = gstruct3_0.string_0;
		this.method_3(gstruct3_0.genum79_0);
		this.method_5(gstruct3_0.uint_1 == 1U);
		this.method_7((int)gstruct3_0.uint_2);
		this.method_9((int)gstruct3_0.uint_3);
	}

	// Token: 0x060018E2 RID: 6370 RVA: 0x00066B94 File Offset: 0x00064D94
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x060018E3 RID: 6371 RVA: 0x00066B9C File Offset: 0x00064D9C
	public void method_1(int int_3)
	{
		this.int_0 = int_3;
	}

	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x060018E4 RID: 6372 RVA: 0x00066BA8 File Offset: 0x00064DA8
	// (set) Token: 0x060018E5 RID: 6373 RVA: 0x00066BB0 File Offset: 0x00064DB0
	public string ProfileName
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x060018E6 RID: 6374 RVA: 0x00066BBC File Offset: 0x00064DBC
	public GEnum79 method_2()
	{
		return this.genum79_0;
	}

	// Token: 0x060018E7 RID: 6375 RVA: 0x00066BC4 File Offset: 0x00064DC4
	public void method_3(GEnum79 genum79_1)
	{
		this.genum79_0 = genum79_1;
	}

	// Token: 0x060018E8 RID: 6376 RVA: 0x00066BD0 File Offset: 0x00064DD0
	public bool method_4()
	{
		return this.bool_0;
	}

	// Token: 0x060018E9 RID: 6377 RVA: 0x00066BD8 File Offset: 0x00064DD8
	public void method_5(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x060018EA RID: 6378 RVA: 0x00066BE4 File Offset: 0x00064DE4
	public int method_6()
	{
		return this.int_1;
	}

	// Token: 0x060018EB RID: 6379 RVA: 0x00066BEC File Offset: 0x00064DEC
	public void method_7(int int_3)
	{
		this.int_1 = int_3;
	}

	// Token: 0x060018EC RID: 6380 RVA: 0x00066BF8 File Offset: 0x00064DF8
	public int method_8()
	{
		return this.int_2;
	}

	// Token: 0x060018ED RID: 6381 RVA: 0x00066C00 File Offset: 0x00064E00
	public void method_9(int int_3)
	{
		this.int_2 = int_3;
	}

	// Token: 0x060018EE RID: 6382 RVA: 0x00066C0C File Offset: 0x00064E0C
	public override string ToString()
	{
		if (!this.ProfileName.Equals("base profile", StringComparison.OrdinalIgnoreCase))
		{
			return this.ProfileName;
		}
		return Class364.smethod_0("GlobalProfile");
	}

	// Token: 0x060018EF RID: 6383 RVA: 0x00066C38 File Offset: 0x00064E38
	public int CompareTo(GClass136 other)
	{
		if (!this.ProfileName.Equals("base profile", StringComparison.OrdinalIgnoreCase))
		{
			return this.ProfileName.CompareTo(other.ProfileName);
		}
		return 0;
	}

	// Token: 0x04001154 RID: 4436
	private int int_0;

	// Token: 0x04001155 RID: 4437
	private string string_0;

	// Token: 0x04001156 RID: 4438
	private GEnum79 genum79_0;

	// Token: 0x04001157 RID: 4439
	private bool bool_0;

	// Token: 0x04001158 RID: 4440
	private int int_1;

	// Token: 0x04001159 RID: 4441
	private int int_2;
}
