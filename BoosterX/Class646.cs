using System;
using System.Collections.Generic;

// Token: 0x0200059B RID: 1435
internal sealed class Class646<T, U>
{
	// Token: 0x06001EE0 RID: 7904 RVA: 0x00080344 File Offset: 0x0007E544
	public Class646(T gparam_2, U gparam_3)
	{
		this.gparam_0 = gparam_2;
		this.gparam_1 = gparam_3;
	}

	// Token: 0x170004CF RID: 1231
	// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x0008035C File Offset: 0x0007E55C
	public T Key
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x170004D0 RID: 1232
	// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x00080364 File Offset: 0x0007E564
	public U ExistingIds
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x0008036C File Offset: 0x0007E56C
	public override bool Equals(object obj)
	{
		Class646<T, U> @class = obj as Class646<T, U>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1));
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x000803C4 File Offset: 0x0007E5C4
	public override int GetHashCode()
	{
		return (-1112793680 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x000803F4 File Offset: 0x0007E5F4
	[return: Attribute8(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Key = {0}, ExistingIds = {1} }}";
		object[] array = new object[2];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x040015AC RID: 5548
	private readonly T gparam_0;

	// Token: 0x040015AD RID: 5549
	private readonly U gparam_1;
}
