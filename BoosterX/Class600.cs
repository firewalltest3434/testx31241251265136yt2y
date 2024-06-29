using System;
using System.Collections.Generic;

// Token: 0x0200050F RID: 1295
internal sealed class Class600<T, U, V, W, X>
{
	// Token: 0x06001C60 RID: 7264 RVA: 0x000741EC File Offset: 0x000723EC
	public Class600(T gparam_5, U gparam_6, V gparam_7, W gparam_8, X gparam_9)
	{
		this.gparam_0 = gparam_5;
		this.gparam_1 = gparam_6;
		this.gparam_2 = gparam_7;
		this.gparam_3 = gparam_8;
		this.gparam_4 = gparam_9;
	}

	// Token: 0x17000465 RID: 1125
	// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0007421C File Offset: 0x0007241C
	public T Key
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x17000466 RID: 1126
	// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00074224 File Offset: 0x00072424
	public U Name
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x17000467 RID: 1127
	// (get) Token: 0x06001C63 RID: 7267 RVA: 0x0007422C File Offset: 0x0007242C
	public V CreationDate
	{
		get
		{
			return this.gparam_2;
		}
	}

	// Token: 0x17000468 RID: 1128
	// (get) Token: 0x06001C64 RID: 7268 RVA: 0x00074234 File Offset: 0x00072434
	public W Id
	{
		get
		{
			return this.gparam_3;
		}
	}

	// Token: 0x17000469 RID: 1129
	// (get) Token: 0x06001C65 RID: 7269 RVA: 0x0007423C File Offset: 0x0007243C
	public X Data
	{
		get
		{
			return this.gparam_4;
		}
	}

	// Token: 0x06001C66 RID: 7270 RVA: 0x00074244 File Offset: 0x00072444
	public override bool Equals(object obj)
	{
		Class600<T, U, V, W, X> @class = obj as Class600<T, U, V, W, X>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1) && EqualityComparer<V>.Default.Equals(this.gparam_2, @class.gparam_2) && EqualityComparer<W>.Default.Equals(this.gparam_3, @class.gparam_3) && EqualityComparer<X>.Default.Equals(this.gparam_4, @class.gparam_4));
	}

	// Token: 0x06001C67 RID: 7271 RVA: 0x000742F0 File Offset: 0x000724F0
	public override int GetHashCode()
	{
		return ((((-1554103958 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.gparam_2)) * -1521134295 + EqualityComparer<W>.Default.GetHashCode(this.gparam_3)) * -1521134295 + EqualityComparer<X>.Default.GetHashCode(this.gparam_4);
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x00074370 File Offset: 0x00072570
	[return: Attribute8(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Key = {0}, Name = {1}, CreationDate = {2}, Id = {3}, Data = {4} }}";
		object[] array = new object[5];
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
		int num5 = 4;
		X x = this.gparam_4;
		array[num5] = ((x != null) ? x.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x040013E5 RID: 5093
	private readonly T gparam_0;

	// Token: 0x040013E6 RID: 5094
	private readonly U gparam_1;

	// Token: 0x040013E7 RID: 5095
	private readonly V gparam_2;

	// Token: 0x040013E8 RID: 5096
	private readonly W gparam_3;

	// Token: 0x040013E9 RID: 5097
	private readonly X gparam_4;
}
