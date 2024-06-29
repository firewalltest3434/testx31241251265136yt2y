using System;
using System.Diagnostics;
using System.Windows;

// Token: 0x020002DF RID: 735
internal sealed class Class731 : GClass211
{
	// Token: 0x060010E3 RID: 4323 RVA: 0x00047678 File Offset: 0x00045878
	public Class731(Class528 class528_1)
	{
		this.class528_0 = class528_1;
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00047688 File Offset: 0x00045888
	public Style Style
	{
		get
		{
			return Class364.smethod_1(this.class528_0.Style);
		}
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0004769C File Offset: 0x0004589C
	public string Content
	{
		get
		{
			return Class364.smethod_0(this.class528_0.Name);
		}
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x060010E6 RID: 4326 RVA: 0x000476B0 File Offset: 0x000458B0
	public GClass134 Command
	{
		get
		{
			if (this.class528_0.Type == 0)
			{
				return new GClass134(new Action<object>(this.method_1), null);
			}
			if (this.class528_0.Type == 1)
			{
				return new GClass134(new Action<object>(Class731.Class357.class357_0.method_0), null);
			}
			return new GClass134(new Action<object>(Class731.Class357.class357_0.method_1), null);
		}
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x00047738 File Offset: 0x00045938
	private void method_1(object object_0)
	{
		Process.Start(this.class528_0.Content);
	}

	// Token: 0x04000A3E RID: 2622
	private readonly Class528 class528_0;

	// Token: 0x020002E0 RID: 736
	[Serializable]
	private sealed class Class357
	{
		// Token: 0x060010EA RID: 4330 RVA: 0x00047760 File Offset: 0x00045960
		internal void method_0(object object_0)
		{
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00047764 File Offset: 0x00045964
		internal void method_1(object object_0)
		{
		}

		// Token: 0x04000A3F RID: 2623
		public static readonly Class731.Class357 class357_0 = new Class731.Class357();

		// Token: 0x04000A40 RID: 2624
		public static Action<object> action_0;

		// Token: 0x04000A41 RID: 2625
		public static Action<object> action_1;
	}
}
