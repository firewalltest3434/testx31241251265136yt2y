using System;
using System.Collections.Generic;

// Token: 0x0200050D RID: 1293
internal sealed class Class599<T, U, V, W>
{
	// Token: 0x06001C50 RID: 7248 RVA: 0x00073DFC File Offset: 0x00071FFC
	public Class599(T gparam_4, U gparam_5, V gparam_6, W gparam_7)
	{
		this.gparam_0 = gparam_4;
		this.gparam_1 = gparam_5;
		this.gparam_2 = gparam_6;
		this.gparam_3 = gparam_7;
	}

	// Token: 0x17000461 RID: 1121
	// (get) Token: 0x06001C51 RID: 7249 RVA: 0x00073E24 File Offset: 0x00072024
	public T Email
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x17000462 RID: 1122
	// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00073E2C File Offset: 0x0007202C
	public U Key
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x17000463 RID: 1123
	// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00073E34 File Offset: 0x00072034
	public V HWID
	{
		get
		{
			return this.gparam_2;
		}
	}

	// Token: 0x17000464 RID: 1124
	// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00073E3C File Offset: 0x0007203C
	public W IP
	{
		get
		{
			return this.gparam_3;
		}
	}

	// Token: 0x06001C55 RID: 7253 RVA: 0x00073E44 File Offset: 0x00072044
	public override bool Equals(object obj)
	{
		Class599<T, U, V, W> @class = obj as Class599<T, U, V, W>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1) && EqualityComparer<V>.Default.Equals(this.gparam_2, @class.gparam_2) && EqualityComparer<W>.Default.Equals(this.gparam_3, @class.gparam_3));
	}

	// Token: 0x06001C56 RID: 7254 RVA: 0x00073ED4 File Offset: 0x000720D4
	public override int GetHashCode()
	{
		return (((568615452 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.gparam_2)) * -1521134295 + EqualityComparer<W>.Default.GetHashCode(this.gparam_3);
	}

	// Token: 0x06001C57 RID: 7255 RVA: 0x00073F3C File Offset: 0x0007213C
	[return: Attribute8(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Email = {0}, Key = {1}, HWID = {2}, IP = {3} }}";
		object[] array = new object[4];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		int num3 = 2;
		V v = this.gparam_2;
		array[num3] = ((v != null) ? v.ToString() : null);
		int num4 = 3;
		W w = this.gparam_3;
		array[num4] = ((w != null) ? w.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x040013E1 RID: 5089
	private readonly T gparam_0;

	// Token: 0x040013E2 RID: 5090
	private readonly U gparam_1;

	// Token: 0x040013E3 RID: 5091
	private readonly V gparam_2;

	// Token: 0x040013E4 RID: 5092
	private readonly W gparam_3;
}
