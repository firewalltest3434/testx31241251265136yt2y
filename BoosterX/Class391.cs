using System;
using System.Collections.Generic;

// Token: 0x0200034E RID: 846
internal sealed class Class391<T>
{
	// Token: 0x06001318 RID: 4888 RVA: 0x0004E1C8 File Offset: 0x0004C3C8
	public Class391(T Data)
	{
		this.gparam_0 = Data;
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x06001319 RID: 4889 RVA: 0x0004E1D8 File Offset: 0x0004C3D8
	public T Data
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x0004E1E0 File Offset: 0x0004C3E0
	public override bool Equals(object obj)
	{
		Class391<T> @class = obj as Class391<T>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0));
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x0004E220 File Offset: 0x0004C420
	public override int GetHashCode()
	{
		return 1150210300 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0);
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x0004E238 File Offset: 0x0004C438
	[return: Attribute8(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Data = {0} }}";
		object[] array = new object[1];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000BB4 RID: 2996
	private readonly T gparam_0;
}
