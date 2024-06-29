using System;

// Token: 0x020002CA RID: 714
public sealed class GClass81
{
	// Token: 0x0600106A RID: 4202 RVA: 0x00045D34 File Offset: 0x00043F34
	public GClass81(string string_1, int[] int_0)
	{
		this.method_1(string_1);
		GClass122 gclass = new GClass122();
		gclass.method_3((byte)int_0[5]);
		gclass.method_5((byte)int_0[6]);
		gclass.method_7((byte)int_0[7]);
		gclass.method_1((byte)int_0[8]);
		this.method_33(gclass);
		this.method_9((float)(int_0[11] & 7));
		this.method_23((int_0[14] >> 4 & 4) != 0);
		this.method_13((float)int_0[4] / 2f);
		this.method_25((int_0[11] & 8) != 0);
		this.method_19((float)(int_0[11] >> 4) / 10f);
		this.method_17((float)(int_0[12] >> 4) / 10f);
		this.method_21((float)(int_0[12] & 15) / 10f);
		this.method_15((float)int_0[9]);
		this.method_3((float)int_0[15] / 10f);
		this.method_5((float)int_0[13] / 10f);
		this.method_29((int_0[14] >> 4 & 8) != 0);
		this.method_27((int_0[14] >> 4 & 1) != 0);
		this.method_35((GEnum55)((int_0[14] & 15) >> 1));
		this.method_7((float)(int_0[3] << 24 >> 24) / 10f);
		this.method_11((float)(int_0[10] << 24 >> 24) / 10f);
		this.method_31((int_0[14] >> 4 & 2) == 2);
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x00045E98 File Offset: 0x00044098
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x00045EA0 File Offset: 0x000440A0
	private void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x00045EAC File Offset: 0x000440AC
	public float method_2()
	{
		return this.float_0;
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x00045EB4 File Offset: 0x000440B4
	private void method_3(float float_10)
	{
		this.float_0 = float_10;
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x00045EC0 File Offset: 0x000440C0
	public float method_4()
	{
		return this.float_1;
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x00045EC8 File Offset: 0x000440C8
	private void method_5(float float_10)
	{
		this.float_1 = float_10;
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x00045ED4 File Offset: 0x000440D4
	public float method_6()
	{
		return this.float_2;
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x00045EDC File Offset: 0x000440DC
	private void method_7(float float_10)
	{
		this.float_2 = float_10;
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x00045EE8 File Offset: 0x000440E8
	public float method_8()
	{
		return this.float_3;
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x00045EF0 File Offset: 0x000440F0
	private void method_9(float float_10)
	{
		this.float_3 = float_10;
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x00045EFC File Offset: 0x000440FC
	public float method_10()
	{
		return this.float_4;
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x00045F04 File Offset: 0x00044104
	private void method_11(float float_10)
	{
		this.float_4 = float_10;
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x00045F10 File Offset: 0x00044110
	public float method_12()
	{
		return this.float_5;
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00045F18 File Offset: 0x00044118
	private void method_13(float float_10)
	{
		this.float_5 = float_10;
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x00045F24 File Offset: 0x00044124
	public float method_14()
	{
		return this.float_6;
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x00045F2C File Offset: 0x0004412C
	private void method_15(float float_10)
	{
		this.float_6 = float_10;
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00045F38 File Offset: 0x00044138
	public float method_16()
	{
		return this.float_7;
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00045F40 File Offset: 0x00044140
	private void method_17(float float_10)
	{
		this.float_7 = float_10;
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00045F4C File Offset: 0x0004414C
	public float method_18()
	{
		return this.float_8;
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x00045F54 File Offset: 0x00044154
	private void method_19(float float_10)
	{
		this.float_8 = float_10;
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00045F60 File Offset: 0x00044160
	public float method_20()
	{
		return this.float_9;
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00045F68 File Offset: 0x00044168
	private void method_21(float float_10)
	{
		this.float_9 = float_10;
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00045F74 File Offset: 0x00044174
	public bool method_22()
	{
		return this.bool_0;
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x00045F7C File Offset: 0x0004417C
	private void method_23(bool bool_5)
	{
		this.bool_0 = bool_5;
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x00045F88 File Offset: 0x00044188
	public bool method_24()
	{
		return this.bool_1;
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x00045F90 File Offset: 0x00044190
	private void method_25(bool bool_5)
	{
		this.bool_1 = bool_5;
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x00045F9C File Offset: 0x0004419C
	public bool method_26()
	{
		return this.bool_2;
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x00045FA4 File Offset: 0x000441A4
	private void method_27(bool bool_5)
	{
		this.bool_2 = bool_5;
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00045FB0 File Offset: 0x000441B0
	public bool method_28()
	{
		return this.bool_3;
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x00045FB8 File Offset: 0x000441B8
	private void method_29(bool bool_5)
	{
		this.bool_3 = bool_5;
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x00045FC4 File Offset: 0x000441C4
	public bool method_30()
	{
		return this.bool_4;
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x00045FCC File Offset: 0x000441CC
	private void method_31(bool bool_5)
	{
		this.bool_4 = bool_5;
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00045FD8 File Offset: 0x000441D8
	public GClass122 method_32()
	{
		return this.gclass122_0;
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00045FE0 File Offset: 0x000441E0
	private void method_33(GClass122 gclass122_1)
	{
		this.gclass122_0 = gclass122_1;
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x00045FEC File Offset: 0x000441EC
	public GEnum55 method_34()
	{
		return this.genum55_0;
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x00045FF4 File Offset: 0x000441F4
	private void method_35(GEnum55 genum55_1)
	{
		this.genum55_0 = genum55_1;
	}

	// Token: 0x040009D6 RID: 2518
	private string string_0;

	// Token: 0x040009D7 RID: 2519
	private float float_0;

	// Token: 0x040009D8 RID: 2520
	private float float_1;

	// Token: 0x040009D9 RID: 2521
	private float float_2;

	// Token: 0x040009DA RID: 2522
	private float float_3;

	// Token: 0x040009DB RID: 2523
	private float float_4;

	// Token: 0x040009DC RID: 2524
	private float float_5;

	// Token: 0x040009DD RID: 2525
	private float float_6;

	// Token: 0x040009DE RID: 2526
	private float float_7;

	// Token: 0x040009DF RID: 2527
	private float float_8;

	// Token: 0x040009E0 RID: 2528
	private float float_9;

	// Token: 0x040009E1 RID: 2529
	private bool bool_0;

	// Token: 0x040009E2 RID: 2530
	private bool bool_1;

	// Token: 0x040009E3 RID: 2531
	private bool bool_2;

	// Token: 0x040009E4 RID: 2532
	private bool bool_3;

	// Token: 0x040009E5 RID: 2533
	private bool bool_4;

	// Token: 0x040009E6 RID: 2534
	private GClass122 gclass122_0;

	// Token: 0x040009E7 RID: 2535
	private GEnum55 genum55_0;
}
