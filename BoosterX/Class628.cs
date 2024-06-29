using System;
using System.Collections.Generic;

// Token: 0x02000574 RID: 1396
internal sealed class Class628<T, U, V>
{
	// Token: 0x06001E50 RID: 7760 RVA: 0x0007ED24 File Offset: 0x0007CF24
	public Class628(T gparam_3, U gparam_4, V gparam_5)
	{
		this.gparam_0 = gparam_3;
		this.gparam_1 = gparam_4;
		this.gparam_2 = gparam_5;
	}

	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x06001E51 RID: 7761 RVA: 0x0007ED44 File Offset: 0x0007CF44
	public T Key
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x170004C2 RID: 1218
	// (get) Token: 0x06001E52 RID: 7762 RVA: 0x0007ED4C File Offset: 0x0007CF4C
	public U Id
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x170004C3 RID: 1219
	// (get) Token: 0x06001E53 RID: 7763 RVA: 0x0007ED54 File Offset: 0x0007CF54
	public V Json
	{
		get
		{
			return this.gparam_2;
		}
	}

	// Token: 0x06001E54 RID: 7764 RVA: 0x0007ED5C File Offset: 0x0007CF5C
	public override bool Equals(object obj)
	{
		Class628<T, U, V> @class = obj as Class628<T, U, V>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1) && EqualityComparer<V>.Default.Equals(this.gparam_2, @class.gparam_2));
	}

	// Token: 0x06001E55 RID: 7765 RVA: 0x0007EDD0 File Offset: 0x0007CFD0
	public override int GetHashCode()
	{
		return ((-1690658872 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.gparam_2);
	}

	// Token: 0x06001E56 RID: 7766 RVA: 0x0007EE24 File Offset: 0x0007D024
	[return: Attribute8(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Key = {0}, Id = {1}, Json = {2} }}";
		object[] array = new object[3];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		int num3 = 2;
		V v = this.gparam_2;
		array[num3] = ((v != null) ? v.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04001566 RID: 5478
	private readonly T gparam_0;

	// Token: 0x04001567 RID: 5479
	private readonly U gparam_1;

	// Token: 0x04001568 RID: 5480
	private readonly V gparam_2;
}
