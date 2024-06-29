using System;
using System.Collections.Generic;

// Token: 0x0200043C RID: 1084
internal sealed class Class495<T, U, V, W, X, Y, Z, T7>
{
	// Token: 0x060017E8 RID: 6120 RVA: 0x000650C4 File Offset: 0x000632C4
	public Class495(T gparam_8, U gparam_9, V gparam_10, W gparam_11, X gparam_12, Y gparam_13, Z gparam_14, T7 gparam_15)
	{
		this.gparam_0 = gparam_8;
		this.gparam_1 = gparam_9;
		this.gparam_2 = gparam_10;
		this.gparam_3 = gparam_11;
		this.gparam_4 = gparam_12;
		this.gparam_5 = gparam_13;
		this.gparam_6 = gparam_14;
		this.gparam_7 = gparam_15;
	}

	// Token: 0x1700036B RID: 875
	// (get) Token: 0x060017E9 RID: 6121 RVA: 0x00065114 File Offset: 0x00063314
	public T PublicIp
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x1700036C RID: 876
	// (get) Token: 0x060017EA RID: 6122 RVA: 0x0006511C File Offset: 0x0006331C
	public U Hwid
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x1700036D RID: 877
	// (get) Token: 0x060017EB RID: 6123 RVA: 0x00065124 File Offset: 0x00063324
	public V WindowsGuid
	{
		get
		{
			return this.gparam_2;
		}
	}

	// Token: 0x1700036E RID: 878
	// (get) Token: 0x060017EC RID: 6124 RVA: 0x0006512C File Offset: 0x0006332C
	public W MonitorHwid
	{
		get
		{
			return this.gparam_3;
		}
	}

	// Token: 0x1700036F RID: 879
	// (get) Token: 0x060017ED RID: 6125 RVA: 0x00065134 File Offset: 0x00063334
	public X DiscsSerials
	{
		get
		{
			return this.gparam_4;
		}
	}

	// Token: 0x17000370 RID: 880
	// (get) Token: 0x060017EE RID: 6126 RVA: 0x0006513C File Offset: 0x0006333C
	public Y SecretHwid
	{
		get
		{
			return this.gparam_5;
		}
	}

	// Token: 0x17000371 RID: 881
	// (get) Token: 0x060017EF RID: 6127 RVA: 0x00065144 File Offset: 0x00063344
	public Z BoosterXGuid
	{
		get
		{
			return this.gparam_6;
		}
	}

	// Token: 0x17000372 RID: 882
	// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0006514C File Offset: 0x0006334C
	public T7 DiscordNick
	{
		get
		{
			return this.gparam_7;
		}
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x00065154 File Offset: 0x00063354
	public override bool Equals(object obj)
	{
		Class495<T, U, V, W, X, Y, Z, T7> @class = obj as Class495<T, U, V, W, X, Y, Z, T7>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1) && EqualityComparer<V>.Default.Equals(this.gparam_2, @class.gparam_2) && EqualityComparer<W>.Default.Equals(this.gparam_3, @class.gparam_3) && EqualityComparer<X>.Default.Equals(this.gparam_4, @class.gparam_4) && EqualityComparer<Y>.Default.Equals(this.gparam_5, @class.gparam_5) && EqualityComparer<Z>.Default.Equals(this.gparam_6, @class.gparam_6) && EqualityComparer<T7>.Default.Equals(this.gparam_7, @class.gparam_7));
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x00065250 File Offset: 0x00063450
	public override int GetHashCode()
	{
		return (((((((-415238271 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.gparam_2)) * -1521134295 + EqualityComparer<W>.Default.GetHashCode(this.gparam_3)) * -1521134295 + EqualityComparer<X>.Default.GetHashCode(this.gparam_4)) * -1521134295 + EqualityComparer<Y>.Default.GetHashCode(this.gparam_5)) * -1521134295 + EqualityComparer<Z>.Default.GetHashCode(this.gparam_6)) * -1521134295 + EqualityComparer<T7>.Default.GetHashCode(this.gparam_7);
	}

	// Token: 0x060017F3 RID: 6131 RVA: 0x00065314 File Offset: 0x00063514
	[return: Attribute8(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ PublicIp = {0}, Hwid = {1}, WindowsGuid = {2}, MonitorHwid = {3}, DiscsSerials = {4}, SecretHwid = {5}, BoosterXGuid = {6}, DiscordNick = {7} }}";
		object[] array = new object[8];
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
		int num6 = 5;
		Y y = this.gparam_5;
		array[num6] = ((y != null) ? y.ToString() : null);
		int num7 = 6;
		Z z = this.gparam_6;
		array[num7] = ((z != null) ? z.ToString() : null);
		int num8 = 7;
		T7 t2 = this.gparam_7;
		array[num8] = ((t2 != null) ? t2.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x040010EA RID: 4330
	private readonly T gparam_0;

	// Token: 0x040010EB RID: 4331
	private readonly U gparam_1;

	// Token: 0x040010EC RID: 4332
	private readonly V gparam_2;

	// Token: 0x040010ED RID: 4333
	private readonly W gparam_3;

	// Token: 0x040010EE RID: 4334
	private readonly X gparam_4;

	// Token: 0x040010EF RID: 4335
	private readonly Y gparam_5;

	// Token: 0x040010F0 RID: 4336
	private readonly Z gparam_6;

	// Token: 0x040010F1 RID: 4337
	private readonly T7 gparam_7;
}
