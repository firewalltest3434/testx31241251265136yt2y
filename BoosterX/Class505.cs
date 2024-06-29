using System;

// Token: 0x02000517 RID: 1303
internal sealed class Class505 : Class502
{
	// Token: 0x06001C87 RID: 7303 RVA: 0x000746F0 File Offset: 0x000728F0
	public Class505(string string_1)
	{
		this.method_2(string_1);
	}

	// Token: 0x06001C88 RID: 7304 RVA: 0x00074700 File Offset: 0x00072900
	public string method_0()
	{
		return "GameModeX\\Apps\\" + this.method_1();
	}

	// Token: 0x06001C89 RID: 7305 RVA: 0x00074714 File Offset: 0x00072914
	public string method_1()
	{
		return this.string_0;
	}

	// Token: 0x06001C8A RID: 7306 RVA: 0x0007471C File Offset: 0x0007291C
	public void method_2(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06001C8B RID: 7307 RVA: 0x00074728 File Offset: 0x00072928
	public string method_3()
	{
		return Class502.smethod_0("ExeName", this.method_0());
	}

	// Token: 0x06001C8C RID: 7308 RVA: 0x0007473C File Offset: 0x0007293C
	public void method_4(string string_1)
	{
		Class502.smethod_1("ExeName", string_1.ToString(), this.method_0());
	}

	// Token: 0x1700046F RID: 1135
	// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00074754 File Offset: 0x00072954
	// (set) Token: 0x06001C8E RID: 7310 RVA: 0x00074768 File Offset: 0x00072968
	public string ExeDir
	{
		get
		{
			return Class502.smethod_0("ExeDir", this.method_0());
		}
		set
		{
			Class502.smethod_1("ExeDir", value.ToString(), this.method_0());
		}
	}

	// Token: 0x040013F8 RID: 5112
	private string string_0;
}
