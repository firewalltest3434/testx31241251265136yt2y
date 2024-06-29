using System;
using System.Collections.Generic;
using ns0;

// Token: 0x0200035F RID: 863
public sealed class GClass106 : GInterface1
{
	// Token: 0x0600136B RID: 4971 RVA: 0x00051790 File Offset: 0x0004F990
	public GClass106(List<string> list_1)
	{
		this.list_0 = list_1;
		this.method_3();
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x000517B0 File Offset: 0x0004F9B0
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x000517B8 File Offset: 0x0004F9B8
	private void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x000517C4 File Offset: 0x0004F9C4
	public void imethod_3()
	{
		if (this.list_0.Count != 0)
		{
			this.list_0.ForEach(new Action<string>(this.method_6));
		}
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x000517EC File Offset: 0x0004F9EC
	public void method_2()
	{
		dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_4.Clear();
		this.method_1(string.Empty);
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x00051804 File Offset: 0x0004FA04
	public bool imethod_0<GInterface15>() where GInterface15 : GInterface15, new()
	{
		Struct168 @struct;
		return this.dictionary_0.TryGetValue(typeof(GInterface15), out @struct) && @struct.string_0 != null && this.method_0().Contains(@struct.string_0);
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x00051848 File Offset: 0x0004FA48
	public bool imethod_1<GInterface15>() where GInterface15 : GInterface15, new()
	{
		Struct168 @struct;
		return this.dictionary_0.TryGetValue(typeof(GInterface15), out @struct) && @struct.string_1 != null && this.method_0().Contains(@struct.string_1);
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x0005188C File Offset: 0x0004FA8C
	public bool imethod_2<GInterface15>(string string_1) where GInterface15 : GInterface15, new()
	{
		GClass106.Class398<GInterface15> @class = new GClass106.Class398<GInterface15>();
		@class.string_0 = string_1;
		@class.gclass106_0 = this;
		Struct168 @struct;
		return this.dictionary_0.TryGetValue(typeof(GInterface15), out @struct) && new List<Struct176>(@struct.struct176_0).Exists(new Predicate<Struct176>(@class.method_0));
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x000518E4 File Offset: 0x0004FAE4
	private void method_3()
	{
		this.dictionary_0 = new Dictionary<Type, Struct168>();
		this.method_5<GClass133>(new Struct176[]
		{
			new Struct176
			{
				string_0 = GClass133.string_1,
				string_1 = GClass133.string_1
			},
			new Struct176
			{
				string_0 = GClass133.string_2,
				string_1 = GClass133.string_2
			}
		});
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x00051958 File Offset: 0x0004FB58
	private void method_4<GInterface15>(string string_1, string string_2) where GInterface15 : GInterface15, new()
	{
		this.dictionary_0.Add(typeof(GInterface15), new Struct168
		{
			string_0 = string_1,
			string_1 = string_2
		});
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x00051994 File Offset: 0x0004FB94
	private void method_5<GInterface15>(Struct176[] struct176_0) where GInterface15 : GInterface15, new()
	{
		this.dictionary_0.Add(typeof(GInterface15), new Struct168
		{
			struct176_0 = struct176_0
		});
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x000519C8 File Offset: 0x0004FBC8
	public GInterface15 imethod_4<GInterface15>() where GInterface15 : class, GInterface15, new()
	{
		return Activator.CreateInstance<GInterface15>();
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x000519D0 File Offset: 0x0004FBD0
	private void method_6(string string_1)
	{
		this.method_1(this.method_0() + string_1);
	}

	// Token: 0x04000BDF RID: 3039
	private readonly List<string> list_0;

	// Token: 0x04000BE0 RID: 3040
	private string string_0 = string.Empty;

	// Token: 0x04000BE1 RID: 3041
	private Dictionary<Type, Struct168> dictionary_0;

	// Token: 0x02000360 RID: 864
	private sealed class Class398<GInterface15> where GInterface15 : global::GInterface15, new()
	{
		// Token: 0x06001379 RID: 4985 RVA: 0x000519EC File Offset: 0x0004FBEC
		internal bool method_0(Struct176 struct176_0)
		{
			return (struct176_0.string_1 == null || struct176_0.string_1 == this.string_0) && this.gclass106_0.method_0().Contains(struct176_0.string_0);
		}

		// Token: 0x04000BE2 RID: 3042
		public string string_0;

		// Token: 0x04000BE3 RID: 3043
		public GClass106 gclass106_0;
	}
}
