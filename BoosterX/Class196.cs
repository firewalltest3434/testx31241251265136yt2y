using System;
using System.Collections.Generic;

// Token: 0x0200016D RID: 365
internal sealed class Class196<T>
{
	// Token: 0x06000982 RID: 2434 RVA: 0x0002B940 File Offset: 0x00029B40
	public Class196(T gparam_1)
	{
		this.gparam_0 = gparam_1;
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06000983 RID: 2435 RVA: 0x0002B950 File Offset: 0x00029B50
	public T Id
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x0002B958 File Offset: 0x00029B58
	public override bool Equals(object obj)
	{
		Class196<T> @class = obj as Class196<T>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0));
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x0002B998 File Offset: 0x00029B98
	public override int GetHashCode()
	{
		return -1271893453 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0);
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x0002B9B0 File Offset: 0x00029BB0
	[return: Attribute8(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Id = {0} }}";
		object[] array = new object[1];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000586 RID: 1414
	private readonly T gparam_0;
}
