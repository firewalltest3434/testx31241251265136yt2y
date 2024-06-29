using System;
using Newtonsoft.Json;

// Token: 0x0200033E RID: 830
public sealed class GClass101
{
	// Token: 0x060012CB RID: 4811 RVA: 0x0004D354 File Offset: 0x0004B554
	internal GClass101(string string_1)
	{
		this.method_1(string_1);
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x0004D364 File Offset: 0x0004B564
	private string method_0()
	{
		return this.string_0;
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x0004D36C File Offset: 0x0004B56C
	private void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x0004D378 File Offset: 0x0004B578
	public static GClass101 smethod_0()
	{
		return new GClass101("256x256");
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x0004D384 File Offset: 0x0004B584
	public static GClass101 smethod_1()
	{
		return new GClass101("512x512");
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x0004D390 File Offset: 0x0004B590
	public static GClass101 smethod_2()
	{
		return new GClass101("1024x1024");
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x0004D39C File Offset: 0x0004B59C
	public static GClass101 smethod_3()
	{
		return new GClass101("1024x1792");
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x0004D3A8 File Offset: 0x0004B5A8
	public static GClass101 smethod_4()
	{
		return new GClass101("1792x1024");
	}

	// Token: 0x060012D3 RID: 4819 RVA: 0x0004D3B4 File Offset: 0x0004B5B4
	public override string ToString()
	{
		return this.method_0();
	}

	// Token: 0x060012D4 RID: 4820 RVA: 0x0004D3BC File Offset: 0x0004B5BC
	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj is GClass101)
		{
			return this.method_0().Equals(((GClass101)obj).method_0());
		}
		return obj is string && this.method_0().Equals((string)obj);
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x0004D408 File Offset: 0x0004B608
	public override int GetHashCode()
	{
		return this.method_0().GetHashCode();
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x0004D418 File Offset: 0x0004B618
	public static bool operator ==(GClass101 gclass101_0, GClass101 gclass101_1)
	{
		return gclass101_0.Equals(gclass101_1);
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x0004D424 File Offset: 0x0004B624
	public static bool operator !=(GClass101 gclass101_0, GClass101 gclass101_1)
	{
		return !gclass101_0.Equals(gclass101_1);
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x0004D430 File Offset: 0x0004B630
	public static implicit operator string(GClass101 gclass101_0)
	{
		return gclass101_0;
	}

	// Token: 0x04000B90 RID: 2960
	private string string_0;

	// Token: 0x0200033F RID: 831
	internal sealed class Class384 : JsonConverter<GClass101>
	{
		// Token: 0x060012DA RID: 4826 RVA: 0x0004D440 File Offset: 0x0004B640
		public override void WriteJson(JsonWriter jsonWriter_0, GClass101 gclass101_0, JsonSerializer jsonSerializer_0)
		{
			jsonWriter_0.WriteValue(gclass101_0.ToString());
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0004D450 File Offset: 0x0004B650
		public override GClass101 ReadJson(JsonReader jsonReader_0, Type type_0, GClass101 gclass101_0, bool bool_0, JsonSerializer jsonSerializer_0)
		{
			return new GClass101(jsonReader_0.ReadAsString());
		}
	}
}
