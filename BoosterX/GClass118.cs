using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000408 RID: 1032
public static class GClass118
{
	// Token: 0x0600165A RID: 5722 RVA: 0x0005E0D8 File Offset: 0x0005C2D8
	public static void smethod_0<T>(this IEnumerable<T> ienumerable_0, Action<T> action_0)
	{
		ienumerable_0.smethod_1(action_0, new Func<T, bool>(GClass118.Class474<T>.class474_0.method_0));
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x0005E100 File Offset: 0x0005C300
	public static void smethod_1<T>(this IEnumerable<T> ienumerable_0, Action<T> action_0, Func<T, bool> func_0)
	{
		ienumerable_0 = ienumerable_0.Where(func_0);
		for (int i = 0; i < ienumerable_0.Count<T>(); i++)
		{
			action_0(ienumerable_0.ElementAt(i));
		}
	}

	// Token: 0x02000409 RID: 1033
	[Serializable]
	private sealed class Class474<T>
	{
		// Token: 0x0600165E RID: 5726 RVA: 0x0005E154 File Offset: 0x0005C354
		internal bool method_0(T gparam_0)
		{
			return true;
		}

		// Token: 0x04000F23 RID: 3875
		public static readonly GClass118.Class474<T> class474_0 = new GClass118.Class474<T>();

		// Token: 0x04000F24 RID: 3876
		public static Func<T, bool> func_0;
	}
}
