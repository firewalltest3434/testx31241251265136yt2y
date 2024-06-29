using System;
using System.Collections.Generic;

// Token: 0x0200015E RID: 350
internal sealed class Class187<T, U>
{
	// Token: 0x06000927 RID: 2343 RVA: 0x0002ABA8 File Offset: 0x00028DA8
	public Class187(T gparam_2, U gparam_3)
	{
		this.gparam_0 = gparam_2;
		this.gparam_1 = gparam_3;
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000928 RID: 2344 RVA: 0x0002ABC0 File Offset: 0x00028DC0
	public T Email
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000929 RID: 2345 RVA: 0x0002ABC8 File Offset: 0x00028DC8
	public U Key
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x0002ABD0 File Offset: 0x00028DD0
	public override bool Equals(object obj)
	{
		Class187<T, U> @class = obj as Class187<T, U>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1));
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x0002AC28 File Offset: 0x00028E28
	public override int GetHashCode()
	{
		return (319815229 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x0002AC58 File Offset: 0x00028E58
	[return: Attribute8(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Email = {0}, Key = {1} }}";
		object[] array = new object[2];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000542 RID: 1346
	private readonly T gparam_0;

	// Token: 0x04000543 RID: 1347
	private readonly U gparam_1;
}
