using System;
using System.Collections.Generic;

// Token: 0x0200043F RID: 1087
internal sealed class Class496<T, U>
{
	// Token: 0x0600180A RID: 6154 RVA: 0x000655D4 File Offset: 0x000637D4
	public Class496(T gparam_2, U gparam_3)
	{
		this.gparam_0 = gparam_2;
		this.gparam_1 = gparam_3;
	}

	// Token: 0x1700037B RID: 891
	// (get) Token: 0x0600180B RID: 6155 RVA: 0x000655EC File Offset: 0x000637EC
	public T DiscordUserName
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x1700037C RID: 892
	// (get) Token: 0x0600180C RID: 6156 RVA: 0x000655F4 File Offset: 0x000637F4
	public U Key
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x000655FC File Offset: 0x000637FC
	public override bool Equals(object obj)
	{
		Class496<T, U> @class = obj as Class496<T, U>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1));
	}

	// Token: 0x0600180E RID: 6158 RVA: 0x00065654 File Offset: 0x00063854
	public override int GetHashCode()
	{
		return (1886838585 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x00065684 File Offset: 0x00063884
	[return: Attribute8(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ DiscordUserName = {0}, Key = {1} }}";
		object[] array = new object[2];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x040010FA RID: 4346
	private readonly T gparam_0;

	// Token: 0x040010FB RID: 4347
	private readonly U gparam_1;
}
