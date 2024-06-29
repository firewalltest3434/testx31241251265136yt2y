using System;
using System.Collections.Generic;

// Token: 0x020000E8 RID: 232
internal sealed class Class139<T>
{
	// Token: 0x060006BE RID: 1726 RVA: 0x00020834 File Offset: 0x0001EA34
	public Class139(T gparam_1)
	{
		this.gparam_0 = gparam_1;
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060006BF RID: 1727 RVA: 0x00020844 File Offset: 0x0001EA44
	public T Email
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x0002084C File Offset: 0x0001EA4C
	public override bool Equals(object obj)
	{
		Class139<T> @class = obj as Class139<T>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0));
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x0002088C File Offset: 0x0001EA8C
	public override int GetHashCode()
	{
		return -1271714786 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0);
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x000208A4 File Offset: 0x0001EAA4
	[return: Attribute8(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Email = {0} }}";
		object[] array = new object[1];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000357 RID: 855
	private readonly T gparam_0;
}
