using System;
using Newtonsoft.Json;

// Token: 0x020004C2 RID: 1218
public sealed class GClass144
{
	// Token: 0x06001ACD RID: 6861 RVA: 0x0006E414 File Offset: 0x0006C614
	private GClass144(string string_1)
	{
		this.method_1(string_1);
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x0006E424 File Offset: 0x0006C624
	private string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x0006E42C File Offset: 0x0006C62C
	private void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x0006E438 File Offset: 0x0006C638
	public static GClass144 smethod_0()
	{
		return new GClass144("url");
	}

	// Token: 0x06001AD1 RID: 6865 RVA: 0x0006E444 File Offset: 0x0006C644
	public static GClass144 smethod_1()
	{
		return new GClass144("b64_json");
	}

	// Token: 0x06001AD2 RID: 6866 RVA: 0x0006E450 File Offset: 0x0006C650
	public override string ToString()
	{
		return this.method_0();
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x0006E458 File Offset: 0x0006C658
	public static implicit operator string(GClass144 gclass144_0)
	{
		return gclass144_0;
	}

	// Token: 0x040012E9 RID: 4841
	private string string_0;

	// Token: 0x020004C3 RID: 1219
	internal sealed class Class569 : JsonConverter<GClass144>
	{
		// Token: 0x06001AD5 RID: 6869 RVA: 0x0006E468 File Offset: 0x0006C668
		public override GClass144 ReadJson(JsonReader jsonReader_0, Type type_0, GClass144 gclass144_0, bool bool_0, JsonSerializer jsonSerializer_0)
		{
			return new GClass144(jsonReader_0.ReadAsString());
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0006E478 File Offset: 0x0006C678
		public override void WriteJson(JsonWriter jsonWriter_0, GClass144 gclass144_0, JsonSerializer jsonSerializer_0)
		{
			jsonWriter_0.WriteValue(gclass144_0.ToString());
		}
	}
}
