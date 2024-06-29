using System;
using System.Collections.Generic;

// Token: 0x0200047D RID: 1149
internal sealed class Class536<T, U>
{
	// Token: 0x0600197E RID: 6526 RVA: 0x00068704 File Offset: 0x00066904
	public Class536(T gparam_2, U gparam_3)
	{
		this.gparam_0 = gparam_2;
		this.gparam_1 = gparam_3;
	}

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x0600197F RID: 6527 RVA: 0x0006871C File Offset: 0x0006691C
	public T Id
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x06001980 RID: 6528 RVA: 0x00068724 File Offset: 0x00066924
	public U Json
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x06001981 RID: 6529 RVA: 0x0006872C File Offset: 0x0006692C
	public override bool Equals(object obj)
	{
		Class536<T, U> @class = obj as Class536<T, U>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1));
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x00068784 File Offset: 0x00066984
	public override int GetHashCode()
	{
		return (1584378345 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
	}

	// Token: 0x06001983 RID: 6531 RVA: 0x000687B4 File Offset: 0x000669B4
	[return: Attribute8(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Id = {0}, Json = {1} }}";
		object[] array = new object[2];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x040011C0 RID: 4544
	private readonly T gparam_0;

	// Token: 0x040011C1 RID: 4545
	private readonly U gparam_1;
}
