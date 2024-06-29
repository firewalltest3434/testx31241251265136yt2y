using System;
using System.Runtime.CompilerServices;
using ns0;

// Token: 0x020000DD RID: 221
internal sealed class Class714 : GClass211
{
	// Token: 0x0600067C RID: 1660 RVA: 0x0001FF04 File Offset: 0x0001E104
	public Class714()
	{
		this.method_1();
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x0600067D RID: 1661 RVA: 0x0001FF14 File Offset: 0x0001E114
	// (set) Token: 0x0600067E RID: 1662 RVA: 0x0001FF1C File Offset: 0x0001E11C
	public Class723 _OptBtn
	{
		[CompilerGenerated]
		get
		{
			return this.class723_0;
		}
		[CompilerGenerated]
		set
		{
			this.class723_0 = value;
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x0600067F RID: 1663 RVA: 0x0001FF28 File Offset: 0x0001E128
	// (set) Token: 0x06000680 RID: 1664 RVA: 0x0001FF30 File Offset: 0x0001E130
	public Class723 OptBtn
	{
		get
		{
			return this._OptBtn;
		}
		set
		{
			this._OptBtn = value;
			base.method_0("OptBtn");
		}
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x0001FF44 File Offset: 0x0001E144
	private void method_1()
	{
		Class723 @class = new Class723();
		@class.Name = Class364.smethod_0("beginopt");
		@class.Click = new GClass134(new Action<object>(Class714.Class136.class136_0.method_0), null);
		this.OptBtn = @class;
	}

	// Token: 0x04000340 RID: 832
	private Class723 class723_0;

	// Token: 0x020000DE RID: 222
	[Serializable]
	private sealed class Class136
	{
		// Token: 0x06000684 RID: 1668 RVA: 0x0001FFAC File Offset: 0x0001E1AC
		internal void method_0(object object_0)
		{
			Class358.smethod_0().method_3(typeof(dje_zQY9BNU6QWSXMEC3Y3Z9MX674M42YS2UN42DQDFQQZX68KU2_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x04000341 RID: 833
		public static readonly Class714.Class136 class136_0 = new Class714.Class136();

		// Token: 0x04000342 RID: 834
		public static Action<object> action_0;
	}
}
