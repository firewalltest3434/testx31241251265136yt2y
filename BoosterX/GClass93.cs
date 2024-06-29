using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ns0;

// Token: 0x02000305 RID: 773
public sealed class GClass93 : GInterface1
{
	// Token: 0x060011A4 RID: 4516 RVA: 0x00049CF4 File Offset: 0x00047EF4
	private GClass93()
	{
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00049D38 File Offset: 0x00047F38
	public static GClass93 smethod_0()
	{
		object obj = GClass93.object_0;
		GClass93 result;
		lock (obj)
		{
			GClass93 gclass;
			if ((gclass = GClass93.gclass93_0) == null)
			{
				gclass = (GClass93.gclass93_0 = new GClass93());
			}
			result = gclass;
		}
		return result;
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x00049D88 File Offset: 0x00047F88
	public void method_0(GClass93.GDelegate1 gdelegate1_1)
	{
		GClass93.GDelegate1 gdelegate = this.gdelegate1_0;
		GClass93.GDelegate1 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass93.GDelegate1 value = (GClass93.GDelegate1)Delegate.Combine(gdelegate2, gdelegate1_1);
			gdelegate = Interlocked.CompareExchange<GClass93.GDelegate1>(ref this.gdelegate1_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x00049DC0 File Offset: 0x00047FC0
	public void method_1(GClass93.GDelegate1 gdelegate1_1)
	{
		GClass93.GDelegate1 gdelegate = this.gdelegate1_0;
		GClass93.GDelegate1 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass93.GDelegate1 value = (GClass93.GDelegate1)Delegate.Remove(gdelegate2, gdelegate1_1);
			gdelegate = Interlocked.CompareExchange<GClass93.GDelegate1>(ref this.gdelegate1_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x00049DF8 File Offset: 0x00047FF8
	public void method_2(GClass93.GDelegate3 gdelegate3_1)
	{
		GClass93.GDelegate3 gdelegate = this.gdelegate3_0;
		GClass93.GDelegate3 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass93.GDelegate3 value = (GClass93.GDelegate3)Delegate.Combine(gdelegate2, gdelegate3_1);
			gdelegate = Interlocked.CompareExchange<GClass93.GDelegate3>(ref this.gdelegate3_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00049E30 File Offset: 0x00048030
	public void method_3(GClass93.GDelegate3 gdelegate3_1)
	{
		GClass93.GDelegate3 gdelegate = this.gdelegate3_0;
		GClass93.GDelegate3 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass93.GDelegate3 value = (GClass93.GDelegate3)Delegate.Remove(gdelegate2, gdelegate3_1);
			gdelegate = Interlocked.CompareExchange<GClass93.GDelegate3>(ref this.gdelegate3_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00049E68 File Offset: 0x00048068
	public void method_4(GClass93.GDelegate2 gdelegate2_1)
	{
		GClass93.GDelegate2 gdelegate = this.gdelegate2_0;
		GClass93.GDelegate2 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass93.GDelegate2 value = (GClass93.GDelegate2)Delegate.Combine(gdelegate2, gdelegate2_1);
			gdelegate = Interlocked.CompareExchange<GClass93.GDelegate2>(ref this.gdelegate2_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00049EA0 File Offset: 0x000480A0
	public void method_5(GClass93.GDelegate2 gdelegate2_1)
	{
		GClass93.GDelegate2 gdelegate = this.gdelegate2_0;
		GClass93.GDelegate2 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass93.GDelegate2 value = (GClass93.GDelegate2)Delegate.Remove(gdelegate2, gdelegate2_1);
			gdelegate = Interlocked.CompareExchange<GClass93.GDelegate2>(ref this.gdelegate2_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00049ED8 File Offset: 0x000480D8
	public bool imethod_0<GInterface15>() where GInterface15 : GInterface15, new()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x00049EE0 File Offset: 0x000480E0
	public bool imethod_1<GInterface15>() where GInterface15 : GInterface15, new()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00049EE8 File Offset: 0x000480E8
	public bool imethod_2<GInterface15>(string string_1) where GInterface15 : GInterface15, new()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00049EF0 File Offset: 0x000480F0
	public void imethod_3()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00049EF8 File Offset: 0x000480F8
	public GInterface15 imethod_4<GInterface15>() where GInterface15 : class, GInterface15, new()
	{
		return this.method_6<GInterface15>();
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00049F00 File Offset: 0x00048100
	public GInterface15 method_6<GInterface15>() where GInterface15 : class, GInterface15, new()
	{
		return this.method_12<GInterface15>(GClass93.string_0);
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00049F10 File Offset: 0x00048110
	public GInterface15 method_7<GInterface15>(Func<GInterface15> func_0, string string_1) where GInterface15 : class, GInterface15
	{
		return this.method_9<GInterface15>(GClass93.string_0, func_0, string_1);
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00049F20 File Offset: 0x00048120
	public bool method_8<GInterface15>() where GInterface15 : class, GInterface15
	{
		return this.method_14<GInterface15>(GClass93.string_0);
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x00049F30 File Offset: 0x00048130
	public GInterface15 method_9<GInterface15>(string string_1, Func<GInterface15> func_0, object object_3) where GInterface15 : class, GInterface15
	{
		Type typeFromHandle = typeof(GInterface15);
		object obj = this.object_1;
		GInterface15 result;
		lock (obj)
		{
			if (!this.dictionary_0.ContainsKey(typeFromHandle))
			{
				this.dictionary_0.Add(typeFromHandle, new Dictionary<string, GClass93.GStruct4>());
			}
			Dictionary<string, GClass93.GStruct4> dictionary = this.dictionary_0[typeFromHandle];
			GClass93.GStruct4 value = default(GClass93.GStruct4);
			value.method_1(func_0());
			value.method_3(object_3);
			dictionary[string_1] = value;
			result = (this.dictionary_0[typeFromHandle][string_1].method_0() as GInterface15);
		}
		this.method_10();
		this.method_18(typeFromHandle, string_1, true);
		return result;
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x0004A000 File Offset: 0x00048200
	public void method_10()
	{
		object obj = this.object_2;
		lock (obj)
		{
			GClass93.GDelegate3 gdelegate = this.gdelegate3_0;
			if (gdelegate != null)
			{
				gdelegate();
			}
		}
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x0004A04C File Offset: 0x0004824C
	public GClass93.GStruct4? method_11<GInterface15>(string string_1) where GInterface15 : class, GInterface15
	{
		object obj = this.object_1;
		GClass93.GStruct4 value;
		lock (obj)
		{
			Type typeFromHandle = typeof(GInterface15);
			if (!this.dictionary_0.ContainsKey(typeFromHandle))
			{
				return null;
			}
			if (!this.dictionary_0[typeFromHandle].ContainsKey(string_1))
			{
				return null;
			}
			value = this.dictionary_0[typeFromHandle][string_1];
		}
		return new GClass93.GStruct4?(value);
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x0004A0EC File Offset: 0x000482EC
	public GInterface15 method_12<GInterface15>(string string_1) where GInterface15 : class, GInterface15
	{
		object obj = this.object_1;
		GInterface15 result;
		lock (obj)
		{
			GClass93.GStruct4? gstruct = this.method_11<GInterface15>(string_1);
			result = (((gstruct != null) ? gstruct.GetValueOrDefault().method_0() : null) as GInterface15);
		}
		return result;
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x0004A158 File Offset: 0x00048358
	public object method_13<GInterface15>(string string_1) where GInterface15 : class, GInterface15
	{
		object obj = this.object_1;
		object result;
		lock (obj)
		{
			GClass93.GStruct4? gstruct = this.method_11<GInterface15>(string_1);
			result = ((gstruct != null) ? gstruct.GetValueOrDefault().method_2() : null);
		}
		return result;
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x0004A1B8 File Offset: 0x000483B8
	public bool method_14<GInterface15>(string string_1) where GInterface15 : class, GInterface15
	{
		return this.method_15(typeof(GInterface15), string_1);
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x0004A1CC File Offset: 0x000483CC
	public bool method_15(Type type_0, string string_1)
	{
		object obj = this.object_1;
		bool result;
		lock (obj)
		{
			if (!this.dictionary_0.ContainsKey(type_0))
			{
				return false;
			}
			Dictionary<string, GClass93.GStruct4> dictionary = this.dictionary_0[type_0];
			if (!dictionary.ContainsKey(string_1))
			{
				return false;
			}
			result = dictionary.Remove(string_1);
			if (dictionary.Count == 0)
			{
				this.dictionary_0.Remove(type_0);
			}
		}
		this.method_10();
		this.method_18(type_0, string_1, true);
		return result;
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x0004A264 File Offset: 0x00048464
	public void method_16(List<string> list_0)
	{
		if (list_0 != null && list_0.Count<string>() == 0)
		{
			return;
		}
		Type typeFromHandle = typeof(Class525);
		foreach (string text in list_0)
		{
			object obj = this.object_1;
			lock (obj)
			{
				if (!this.dictionary_0.ContainsKey(typeFromHandle))
				{
					continue;
				}
				Dictionary<string, GClass93.GStruct4> dictionary = this.dictionary_0[typeFromHandle];
				if (!dictionary.ContainsKey(text))
				{
					continue;
				}
				dictionary.Remove(text);
				if (dictionary.Count == 0)
				{
					this.dictionary_0.Remove(typeFromHandle);
				}
			}
			this.method_18(typeFromHandle, text, true);
		}
		this.method_10();
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x0004A344 File Offset: 0x00048544
	public void method_17<T>()
	{
		Type typeFromHandle = typeof(T);
		object obj = this.object_1;
		lock (obj)
		{
			this.dictionary_0.Remove(typeFromHandle);
		}
		this.method_10();
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x0004A39C File Offset: 0x0004859C
	private void method_18(Type type_0, string string_1, bool bool_0)
	{
		GClass93.GDelegate1 gdelegate = this.gdelegate1_0;
		if (gdelegate == null)
		{
			return;
		}
		gdelegate(type_0, string_1, bool_0);
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x0004A3B4 File Offset: 0x000485B4
	public Dictionary<Type, Dictionary<string, GClass93.GStruct4>> method_19()
	{
		object obj = this.object_1;
		Dictionary<Type, Dictionary<string, GClass93.GStruct4>> result;
		lock (obj)
		{
			result = new Dictionary<Type, Dictionary<string, GClass93.GStruct4>>(this.dictionary_0);
		}
		return result;
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x0004A3FC File Offset: 0x000485FC
	public void method_20()
	{
		dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_4.Clear();
		dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_2.Clear();
		dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.string_1 = string.Empty;
		object obj = this.object_1;
		lock (obj)
		{
			this.dictionary_0.Clear();
		}
		GClass93.GDelegate2 gdelegate = this.gdelegate2_0;
		if (gdelegate != null)
		{
			gdelegate();
		}
		this.method_10();
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x0004A478 File Offset: 0x00048678
	public bool method_21()
	{
		object obj = this.object_1;
		bool result;
		lock (obj)
		{
			result = (this.dictionary_0.Count > 0);
		}
		return result;
	}

	// Token: 0x04000AAD RID: 2733
	private static readonly object object_0 = new object();

	// Token: 0x04000AAE RID: 2734
	private static GClass93 gclass93_0;

	// Token: 0x04000AAF RID: 2735
	private readonly Dictionary<Type, Dictionary<string, GClass93.GStruct4>> dictionary_0 = new Dictionary<Type, Dictionary<string, GClass93.GStruct4>>();

	// Token: 0x04000AB0 RID: 2736
	public readonly object object_1 = new object();

	// Token: 0x04000AB1 RID: 2737
	private static readonly string string_0 = "default";

	// Token: 0x04000AB2 RID: 2738
	private GClass93.GDelegate1 gdelegate1_0;

	// Token: 0x04000AB3 RID: 2739
	private GClass93.GDelegate3 gdelegate3_0;

	// Token: 0x04000AB4 RID: 2740
	private GClass93.GDelegate2 gdelegate2_0;

	// Token: 0x04000AB5 RID: 2741
	private object object_2 = new object();

	// Token: 0x02000306 RID: 774
	// (Invoke) Token: 0x060011C3 RID: 4547
	public delegate void GDelegate1(Type type_0, string string_0, bool bool_0);

	// Token: 0x02000307 RID: 775
	// (Invoke) Token: 0x060011C7 RID: 4551
	public delegate void GDelegate2();

	// Token: 0x02000308 RID: 776
	public struct GStruct4
	{
		// Token: 0x060011CA RID: 4554 RVA: 0x0004A4C4 File Offset: 0x000486C4
		public readonly GInterface15 method_0()
		{
			return this.ginterface15_0;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0004A4CC File Offset: 0x000486CC
		public void method_1(GInterface15 ginterface15_1)
		{
			this.ginterface15_0 = ginterface15_1;
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0004A4D8 File Offset: 0x000486D8
		public readonly object method_2()
		{
			return this.object_0;
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0004A4E0 File Offset: 0x000486E0
		public void method_3(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x04000AB6 RID: 2742
		private GInterface15 ginterface15_0;

		// Token: 0x04000AB7 RID: 2743
		private object object_0;
	}

	// Token: 0x02000309 RID: 777
	// (Invoke) Token: 0x060011CF RID: 4559
	public delegate void GDelegate3();
}
