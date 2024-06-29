using System;
using System.Windows;
using System.Windows.Controls;
using ScrollViewer;

// Token: 0x02000440 RID: 1088
public sealed class GClass124 : ScrollViewer
{
	// Token: 0x06001810 RID: 6160 RVA: 0x000656F4 File Offset: 0x000638F4
	public GClass124()
	{
		base.Loaded += this.GClass124_Loaded;
	}

	// Token: 0x06001811 RID: 6161 RVA: 0x00065710 File Offset: 0x00063910
	private void GClass124_Loaded(object sender, RoutedEventArgs p1)
	{
		base.ScrollInfo = new ScrollInfoAdapter(base.ScrollInfo);
	}
}
