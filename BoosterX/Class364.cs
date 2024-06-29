using System;
using System.Windows;
using System.Windows.Media;

// Token: 0x020002ED RID: 749
internal sealed class Class364
{
	// Token: 0x06001117 RID: 4375 RVA: 0x00048270 File Offset: 0x00046470
	public static string smethod_0(string string_0)
	{
		return (Application.Current.TryFindResource(string_0) as string) ?? string_0;
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00048288 File Offset: 0x00046488
	public static Style smethod_1(string string_0)
	{
		Class364.Class365 @class = new Class364.Class365();
		@class.string_0 = string_0;
		@class.style_0 = new Style();
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		return @class.style_0;
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x000482D0 File Offset: 0x000464D0
	public static DrawingImage smethod_2(string string_0)
	{
		Class364.Class366 @class = new Class364.Class366();
		@class.string_0 = string_0;
		@class.drawingImage_0 = new DrawingImage();
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		return @class.drawingImage_0;
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00048318 File Offset: 0x00046518
	public static object smethod_3(string string_0)
	{
		Class364.Class367 @class = new Class364.Class367();
		@class.string_0 = string_0;
		@class.object_0 = new object();
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		return @class.object_0;
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00048360 File Offset: 0x00046560
	internal static string smethod_4(object object_0)
	{
		throw new NotImplementedException();
	}

	// Token: 0x020002EE RID: 750
	private sealed class Class365
	{
		// Token: 0x0600111D RID: 4381 RVA: 0x00048370 File Offset: 0x00046570
		internal void method_0()
		{
			this.style_0 = (Application.Current.FindResource(this.string_0) as Style);
		}

		// Token: 0x04000A74 RID: 2676
		public Style style_0;

		// Token: 0x04000A75 RID: 2677
		public string string_0;
	}

	// Token: 0x020002EF RID: 751
	private sealed class Class366
	{
		// Token: 0x0600111F RID: 4383 RVA: 0x00048398 File Offset: 0x00046598
		internal void method_0()
		{
			this.drawingImage_0 = (Application.Current.FindResource(this.string_0) as DrawingImage);
		}

		// Token: 0x04000A76 RID: 2678
		public DrawingImage drawingImage_0;

		// Token: 0x04000A77 RID: 2679
		public string string_0;
	}

	// Token: 0x020002F0 RID: 752
	private sealed class Class367
	{
		// Token: 0x06001121 RID: 4385 RVA: 0x000483C0 File Offset: 0x000465C0
		internal void method_0()
		{
			this.object_0 = Application.Current.FindResource(this.string_0);
		}

		// Token: 0x04000A78 RID: 2680
		public object object_0;

		// Token: 0x04000A79 RID: 2681
		public string string_0;
	}
}
