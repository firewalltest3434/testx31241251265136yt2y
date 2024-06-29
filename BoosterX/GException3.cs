using System;

// Token: 0x020002BF RID: 703
public class GException3 : GException2
{
	// Token: 0x0600102D RID: 4141 RVA: 0x00044E78 File Offset: 0x00043078
	public GException3()
	{
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x00044E80 File Offset: 0x00043080
	public GException3(string string_2) : base(string_2)
	{
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x00044E8C File Offset: 0x0004308C
	public GException3(string string_2, string string_3, int int_1, string string_4) : base(string_2)
	{
		this.method_1(string_3);
		this.method_3(int_1);
		this.method_5(string_4);
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00044EAC File Offset: 0x000430AC
	public GException3(string string_2, int int_1, string string_3) : base(string.Format("Endpoint: {0}. Status code: {1}. Response: {2}", string_2, int_1, string_3))
	{
		this.method_1(string_2);
		this.method_3(int_1);
		this.method_5(string_3);
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x00044EDC File Offset: 0x000430DC
	public GException3(string string_2, Exception exception_0) : base(string_2, exception_0)
	{
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00044EE8 File Offset: 0x000430E8
	private string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x00044EF0 File Offset: 0x000430F0
	private void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00044EFC File Offset: 0x000430FC
	private int method_2()
	{
		return this.int_0;
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00044F04 File Offset: 0x00043104
	private void method_3(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00044F10 File Offset: 0x00043110
	private string method_4()
	{
		return this.string_1;
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x00044F18 File Offset: 0x00043118
	private void method_5(string string_2)
	{
		this.string_1 = string_2;
	}

	// Token: 0x040009BA RID: 2490
	private string string_0;

	// Token: 0x040009BB RID: 2491
	private int int_0;

	// Token: 0x040009BC RID: 2492
	private string string_1;
}
