using System;

// Token: 0x02000682 RID: 1666
internal sealed class Class764
{
	// Token: 0x060023B2 RID: 9138 RVA: 0x0008E390 File Offset: 0x0008C590
	internal void method_0()
	{
		this.string_0 = this.method_7();
		this.int_0 = 1;
		this.bool_0 = true;
	}

	// Token: 0x060023B3 RID: 9139 RVA: 0x0008E3AC File Offset: 0x0008C5AC
	protected static int smethod_0(Class764.Enum26 enum26_0)
	{
		return (int)enum26_0;
	}

	// Token: 0x060023B4 RID: 9140 RVA: 0x0008E3B0 File Offset: 0x0008C5B0
	private bool method_1()
	{
		int num = (int)Math.Floor(Math.Log10((double)this.int_0) + 1.0);
		return this.string_0.Length + 1 + num + 1 + 1 <= Class764.smethod_0((Class764.Enum26)12);
	}

	// Token: 0x060023B5 RID: 9141 RVA: 0x0008E3FC File Offset: 0x0008C5FC
	private bool method_2(int int_2)
	{
		if (int_2 - 1 == 2147483647)
		{
			return false;
		}
		int num = (int)Math.Floor(Math.Log10((double)int_2) + 1.0);
		return this.string_0.Length + num + 1 <= Class764.smethod_0((Class764.Enum26)12);
	}

	// Token: 0x060023B6 RID: 9142 RVA: 0x0008E448 File Offset: 0x0008C648
	internal string method_3()
	{
		if (!this.bool_0)
		{
			this.method_0();
		}
		if (this.method_1())
		{
			this.string_0 = this.method_4();
			this.int_0 = 1;
		}
		return this.method_4();
	}

	// Token: 0x060023B7 RID: 9143 RVA: 0x0008E47C File Offset: 0x0008C67C
	internal string method_4()
	{
		if (!this.bool_0)
		{
			return null;
		}
		return this.string_0 + "." + this.int_0.ToString();
	}

	// Token: 0x060023B8 RID: 9144 RVA: 0x0008E4A4 File Offset: 0x0008C6A4
	internal string method_5()
	{
		if (!this.bool_0)
		{
			this.method_0();
		}
		int int_ = this.int_0 + 1;
		if (this.method_2(int_))
		{
			this.int_0 = int_;
		}
		return this.method_4();
	}

	// Token: 0x060023B9 RID: 9145 RVA: 0x0008E4E0 File Offset: 0x0008C6E0
	private bool method_6(string string_2)
	{
		if (string_2.Length > Class764.smethod_0((Class764.Enum26)12))
		{
			return false;
		}
		string b = "^[" + this.string_1 + "]{16}(.[0-9]+)+$";
		return !(string_2 != b);
	}

	// Token: 0x060023BA RID: 9146 RVA: 0x0008E528 File Offset: 0x0008C728
	private string method_7()
	{
		string text = string.Empty;
		Random random = new Random();
		for (int i = 0; i < this.int_1; i++)
		{
			text += this.string_1[random.Next(this.string_1.Length)].ToString();
		}
		return text;
	}

	// Token: 0x060023BB RID: 9147 RVA: 0x0008E588 File Offset: 0x0008C788
	internal void method_8(string string_2)
	{
		if (!this.method_6(string_2))
		{
			throw new Exception("Cannot set invalid correlation vector value");
		}
		int num = string_2.LastIndexOf(".");
		this.string_0 = string_2.Substring(0, num);
		this.int_0 = int.Parse(string_2.Substring(num + 1));
		this.bool_0 = true;
	}

	// Token: 0x04001855 RID: 6229
	private string string_0;

	// Token: 0x04001856 RID: 6230
	private int int_0;

	// Token: 0x04001857 RID: 6231
	private readonly string string_1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

	// Token: 0x04001858 RID: 6232
	private readonly int int_1 = 16;

	// Token: 0x04001859 RID: 6233
	private bool bool_0;

	// Token: 0x02000683 RID: 1667
	internal enum Enum26
	{

	}
}
