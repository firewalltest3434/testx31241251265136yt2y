using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Microsoft.Xaml.Behaviors;
using ScrollViewer;

// Token: 0x0200059A RID: 1434
public sealed class GClass171 : Behavior<ScrollViewer>
{
	// Token: 0x06001EDE RID: 7902 RVA: 0x000802DC File Offset: 0x0007E4DC
	protected override void OnAttached()
	{
		base.OnAttached();
		base.AssociatedObject.Loaded += this.method_0;
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x000802FC File Offset: 0x0007E4FC
	private void method_0(object sender, RoutedEventArgs p1)
	{
		PropertyInfo property = base.AssociatedObject.GetType().GetProperty("ScrollInfo", BindingFlags.Instance | BindingFlags.NonPublic);
		property.SetValue(base.AssociatedObject, new ScrollInfoAdapter((IScrollInfo)property.GetValue(base.AssociatedObject)));
	}
}
