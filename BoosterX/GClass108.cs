using System;
using System.Runtime.CompilerServices;

// Token: 0x02000374 RID: 884
public sealed class GClass108
{
	// Token: 0x060013AC RID: 5036 RVA: 0x000524E0 File Offset: 0x000506E0
	public GClass108(string string_2, object object_0)
	{
		this.Name = string_2;
		this.method_1((object_0 != null) ? object_0.ToString() : null);
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x00052504 File Offset: 0x00050704
	public GClass108(string string_2)
	{
		bool flag = string_2[0] == '/' && string_2[1] == '/';
		string[] array = string_2.Split(new string[]
		{
			" "
		}, flag ? 1 : 3, StringSplitOptions.RemoveEmptyEntries);
		int num = array.Length - 1;
		this.Name = ((array.Length == 3) ? (array[0] + " " + array[1]) : array[0]);
		this.method_1((array.Length > 1) ? array[num].Replace("\"", null) : null);
	}

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x060013AE RID: 5038 RVA: 0x000525B0 File Offset: 0x000507B0
	// (set) Token: 0x060013AF RID: 5039 RVA: 0x000525B8 File Offset: 0x000507B8
	public string Name
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

	// Token: 0x060013B0 RID: 5040 RVA: 0x000525C4 File Offset: 0x000507C4
	public string method_0()
	{
		return this.string_1;
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x000525CC File Offset: 0x000507CC
	public void method_1(string string_2)
	{
		this.string_1 = string_2;
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x000525D8 File Offset: 0x000507D8
	public static bool operator ==(GClass108 gclass108_0, GClass108 gclass108_1)
	{
		return gclass108_0.Name == gclass108_1.Name && gclass108_0.method_0() == gclass108_1.method_0();
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x00052600 File Offset: 0x00050800
	public static bool operator !=(GClass108 gclass108_0, GClass108 gclass108_1)
	{
		return gclass108_0 != gclass108_1;
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x0005260C File Offset: 0x0005080C
	public override bool Equals(object obj)
	{
		return base.Equals(obj);
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x00052618 File Offset: 0x00050818
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x00052620 File Offset: 0x00050820
	public override string ToString()
	{
		return this.Name + " " + ((!string.IsNullOrEmpty(this.method_0())) ? ("\"" + this.method_0() + "\"") : null);
	}

	// Token: 0x04000C07 RID: 3079
	private string string_0;

	// Token: 0x04000C08 RID: 3080
	private string string_1;
}
