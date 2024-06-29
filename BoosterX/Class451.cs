using System;
using System.Windows;

// Token: 0x020003DC RID: 988
internal sealed class Class451
{
	// Token: 0x060015B9 RID: 5561 RVA: 0x0005AFDC File Offset: 0x000591DC
	public static GClass222 smethod_0(bool bool_1)
	{
		if (!Class451.bool_0 || bool_1)
		{
			Class451.bool_0 = true;
			Application.Current.Dispatcher.Invoke(new Action(Class451.Class452.class452_0.method_0));
		}
		return Class451.gclass222_0;
	}

	// Token: 0x04000DCA RID: 3530
	private static GClass222 gclass222_0;

	// Token: 0x04000DCB RID: 3531
	private static bool bool_0;

	// Token: 0x020003DD RID: 989
	[Serializable]
	private sealed class Class452
	{
		// Token: 0x060015BC RID: 5564 RVA: 0x0005B044 File Offset: 0x00059244
		internal void method_0()
		{
			Class451.gclass222_0 = new GClass222();
		}

		// Token: 0x04000DCC RID: 3532
		public static readonly Class451.Class452 class452_0 = new Class451.Class452();

		// Token: 0x04000DCD RID: 3533
		public static Action action_0;
	}
}
