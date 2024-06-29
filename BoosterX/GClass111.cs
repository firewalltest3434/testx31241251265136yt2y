using System;
using System.Linq;

// Token: 0x02000386 RID: 902
public sealed class GClass111
{
	// Token: 0x06001442 RID: 5186 RVA: 0x00053700 File Offset: 0x00051900
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x00053708 File Offset: 0x00051908
	public void method_1(string string_6)
	{
		this.string_0 = string_6;
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x00053714 File Offset: 0x00051914
	public string method_2()
	{
		return this.string_1;
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x0005371C File Offset: 0x0005191C
	public void method_3(string string_6)
	{
		this.string_1 = string_6;
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x00053728 File Offset: 0x00051928
	public string method_4()
	{
		return this.string_2;
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x00053730 File Offset: 0x00051930
	public void method_5(string string_6)
	{
		this.string_2 = string_6;
	}

	// Token: 0x06001448 RID: 5192 RVA: 0x0005373C File Offset: 0x0005193C
	public string method_6()
	{
		return this.string_3;
	}

	// Token: 0x06001449 RID: 5193 RVA: 0x00053744 File Offset: 0x00051944
	public void method_7(string string_6)
	{
		this.string_3 = string_6;
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x00053750 File Offset: 0x00051950
	public string method_8()
	{
		return this.string_4;
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x00053758 File Offset: 0x00051958
	public void method_9(string string_6)
	{
		this.string_4 = string_6;
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x00053764 File Offset: 0x00051964
	public string method_10()
	{
		return this.string_5;
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x0005376C File Offset: 0x0005196C
	public void method_11(string string_6)
	{
		this.string_5 = string_6;
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x00053778 File Offset: 0x00051978
	public bool method_12()
	{
		return Class497.smethod_0().method_3(this.method_13(), this.method_15(), this.method_14());
	}

	// Token: 0x0600144F RID: 5199 RVA: 0x00053798 File Offset: 0x00051998
	public string method_13()
	{
		return this.method_0().Split(new char[]
		{
			'_'
		})[0];
	}

	// Token: 0x06001450 RID: 5200 RVA: 0x000537B4 File Offset: 0x000519B4
	public string method_14()
	{
		return this.method_0().Split(new char[]
		{
			'_'
		})[2];
	}

	// Token: 0x06001451 RID: 5201 RVA: 0x000537D0 File Offset: 0x000519D0
	public string method_15()
	{
		return this.method_0().Split(new char[]
		{
			'_'
		})[1];
	}

	// Token: 0x06001452 RID: 5202 RVA: 0x000537EC File Offset: 0x000519EC
	public string method_16()
	{
		return string.Concat(new string[]
		{
			this.method_13(),
			"_",
			this.method_15(),
			"_",
			this.method_14()
		});
	}

	// Token: 0x06001453 RID: 5203 RVA: 0x00053824 File Offset: 0x00051A24
	public int method_17()
	{
		return Convert.ToInt32(this.method_0().Split(new char[]
		{
			'_'
		})[1].Split(new char[]
		{
			'.'
		})[0]);
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x00053858 File Offset: 0x00051A58
	public bool method_18()
	{
		return this.method_15().Split(new char[]
		{
			'.'
		}).Last<string>() == "70";
	}

	// Token: 0x06001455 RID: 5205 RVA: 0x00053880 File Offset: 0x00051A80
	public bool method_19()
	{
		return this.method_14() == "x64";
	}

	// Token: 0x06001456 RID: 5206 RVA: 0x00053894 File Offset: 0x00051A94
	public bool method_20()
	{
		return this.method_14() == "x86";
	}

	// Token: 0x06001457 RID: 5207 RVA: 0x000538A8 File Offset: 0x00051AA8
	public bool method_21()
	{
		return this.method_14() == "neutral";
	}

	// Token: 0x06001458 RID: 5208 RVA: 0x000538BC File Offset: 0x00051ABC
	public int method_22(GClass111 gclass111_0)
	{
		if (!gclass111_0.method_0().StartsWith("Microsoft.Windows") && gclass111_0.method_17().ToString().ToCharArray().Length != 4)
		{
			return Version.Parse(this.method_15()).CompareTo(Version.Parse(gclass111_0.method_15()));
		}
		int num = Convert.ToInt32("22H2".Remove(2)) + 2000;
		if (gclass111_0.method_17() < num && (this.method_17() >= num || this.method_17() < gclass111_0.method_17()))
		{
			return -1;
		}
		if (gclass111_0.method_17() == this.method_17())
		{
			return Version.Parse(this.method_15()).CompareTo(Version.Parse(gclass111_0.method_15()));
		}
		return 1;
	}

	// Token: 0x06001459 RID: 5209 RVA: 0x00053988 File Offset: 0x00051B88
	public bool method_23()
	{
		return this.method_13().StartsWith("Microsoft.") && this.method_8().ToLower() == "developer tools";
	}

	// Token: 0x04000C43 RID: 3139
	private string string_0;

	// Token: 0x04000C44 RID: 3140
	private string string_1;

	// Token: 0x04000C45 RID: 3141
	private string string_2;

	// Token: 0x04000C46 RID: 3142
	private string string_3;

	// Token: 0x04000C47 RID: 3143
	private string string_4;

	// Token: 0x04000C48 RID: 3144
	private string string_5;
}
