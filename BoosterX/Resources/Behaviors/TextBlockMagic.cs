using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace BoosterX.Resources.Behaviors
{
	// Token: 0x0200083F RID: 2111
	public static class TextBlockMagic
	{
		// Token: 0x06002AFD RID: 11005 RVA: 0x000BA3E0 File Offset: 0x000B85E0
		[Obsolete]
		static TextBlockMagic()
		{
			EventManager.RegisterClassHandler(typeof(TextBlock), FrameworkElement.SizeChangedEvent, new SizeChangedEventHandler(TextBlockMagic.smethod_0), true);
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x000BA47C File Offset: 0x000B867C
		[AttachedPropertyBrowsableForType(typeof(TextBlock))]
		public static bool GetIsTextTrimmed(TextBlock target)
		{
			return (bool)target.GetValue(TextBlockMagic.IsTextTrimmedProperty);
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000BA490 File Offset: 0x000B8690
		[AttachedPropertyBrowsableForType(typeof(DependencyObject))]
		public static bool GetAutomaticToolTipEnabled(DependencyObject element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return (bool)element.GetValue(TextBlockMagic.AutomaticToolTipEnabledProperty);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x000BA4B0 File Offset: 0x000B86B0
		public static void SetAutomaticToolTipEnabled(DependencyObject element, bool value)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			element.SetValue(TextBlockMagic.AutomaticToolTipEnabledProperty, value);
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000BA4D4 File Offset: 0x000B86D4
		private static void smethod_0(object sender, SizeChangedEventArgs p1)
		{
			TextBlockMagic.smethod_1(sender);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000BA4DC File Offset: 0x000B86DC
		private static void smethod_1(object object_0)
		{
			TextBlockMagic.Class864 @class = new TextBlockMagic.Class864();
			@class.textBlock_0 = (object_0 as TextBlock);
			if (@class.textBlock_0 == null)
			{
				return;
			}
			if (@class.textBlock_0.TextTrimming == TextTrimming.None)
			{
				@class.textBlock_0.SetValue(TextBlockMagic.dependencyPropertyKey_0, false);
				return;
			}
			bool flag = @class.textBlock_0.Dispatcher.Invoke<bool>(new Func<bool>(@class.method_0), DispatcherPriority.DataBind);
			@class.textBlock_0.SetValue(TextBlockMagic.dependencyPropertyKey_0, flag);
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x000BA55C File Offset: 0x000B875C
		private static bool smethod_2(TextBlock textBlock_0)
		{
			if (!textBlock_0.IsArrangeValid)
			{
				return TextBlockMagic.GetIsTextTrimmed(textBlock_0);
			}
			Typeface typeface = new Typeface(textBlock_0.FontFamily, textBlock_0.FontStyle, textBlock_0.FontWeight, textBlock_0.FontStretch);
			FormattedText formattedText = new FormattedText(textBlock_0.Text, Thread.CurrentThread.CurrentCulture, textBlock_0.FlowDirection, typeface, textBlock_0.FontSize, textBlock_0.Foreground);
			formattedText.MaxTextWidth = textBlock_0.ActualWidth;
			return formattedText.Height > textBlock_0.ActualHeight || formattedText.MinWidth > formattedText.MaxTextWidth;
		}

		// Token: 0x04002106 RID: 8454
		private static readonly DependencyPropertyKey dependencyPropertyKey_0 = DependencyProperty.RegisterAttachedReadOnly("IsTextTrimmed", typeof(bool), typeof(TextBlockMagic), new PropertyMetadata(false));

		// Token: 0x04002107 RID: 8455
		public static readonly DependencyProperty IsTextTrimmedProperty = TextBlockMagic.dependencyPropertyKey_0.DependencyProperty;

		// Token: 0x04002108 RID: 8456
		public static readonly DependencyProperty AutomaticToolTipEnabledProperty = DependencyProperty.RegisterAttached("AutomaticToolTipEnabled", typeof(bool), typeof(TextBlockMagic), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x02000840 RID: 2112
		private sealed class Class864
		{
			// Token: 0x06002B05 RID: 11013 RVA: 0x000BA5FC File Offset: 0x000B87FC
			internal bool method_0()
			{
				return TextBlockMagic.smethod_2(this.textBlock_0);
			}

			// Token: 0x04002109 RID: 8457
			public TextBlock textBlock_0;
		}
	}
}
