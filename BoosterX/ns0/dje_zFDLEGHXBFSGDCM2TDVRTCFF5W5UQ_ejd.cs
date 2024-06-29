using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000780 RID: 1920
	internal sealed class dje_zFDLEGHXBFSGDCM2TDVRTCFF5W5UQ_ejd : MarkupExtension
	{
		// Token: 0x0600278B RID: 10123 RVA: 0x000A7C9C File Offset: 0x000A5E9C
		public dje_zFDLEGHXBFSGDCM2TDVRTCFF5W5UQ_ejd()
		{
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x000A7CA4 File Offset: 0x000A5EA4
		public dje_zFDLEGHXBFSGDCM2TDVRTCFF5W5UQ_ejd(string string_2)
		{
			this.Path = new PropertyPath(string_2, Array.Empty<object>());
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x000A7CF8 File Offset: 0x000A5EF8
		public static object GetResourceBindingKeyHelper(DependencyObject dependencyObject_0)
		{
			return dependencyObject_0.GetValue(dje_zFDLEGHXBFSGDCM2TDVRTCFF5W5UQ_ejd.dependencyProperty_0);
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x000A7D08 File Offset: 0x000A5F08
		public static void SetResourceBindingKeyHelper(DependencyObject dependencyObject_0, object object_3)
		{
			dependencyObject_0.SetValue(dje_zFDLEGHXBFSGDCM2TDVRTCFF5W5UQ_ejd.dependencyProperty_0, object_3);
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x000A7D18 File Offset: 0x000A5F18
		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			FrameworkElement frameworkElement = dependencyObject_0 as FrameworkElement;
			Tuple<object, DependencyProperty> tuple = dependencyPropertyChangedEventArgs_0.NewValue as Tuple<object, DependencyProperty>;
			if (frameworkElement == null || tuple == null)
			{
				return;
			}
			DependencyProperty item = tuple.Item2;
			if (tuple.Item1 == null)
			{
				frameworkElement.SetValue(item, item.GetMetadata(frameworkElement).DefaultValue);
				return;
			}
			frameworkElement.SetResourceReference(item, tuple.Item1);
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x000A7D70 File Offset: 0x000A5F70
		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			IProvideValueTarget provideValueTarget = (IProvideValueTarget)serviceProvider.GetService(typeof(IProvideValueTarget));
			if (provideValueTarget == null)
			{
				return null;
			}
			if (provideValueTarget.TargetObject != null && provideValueTarget.TargetObject.GetType().FullName == "System.Windows.SharedDp")
			{
				return this;
			}
			FrameworkElement frameworkElement = provideValueTarget.TargetObject as FrameworkElement;
			DependencyProperty dependencyProperty = provideValueTarget.TargetProperty as DependencyProperty;
			if (frameworkElement != null && dependencyProperty != null)
			{
				Binding binding = new Binding();
				binding.Path = this.Path;
				binding.XPath = this.String_0;
				binding.Mode = this.BindingMode_0;
				binding.UpdateSourceTrigger = this.UpdateSourceTrigger_0;
				binding.Converter = this.IValueConverter_0;
				binding.ConverterParameter = this.Object_0;
				binding.ConverterCulture = this.CultureInfo_0;
				if (this.RelativeSource_0 != null)
				{
					binding.RelativeSource = this.RelativeSource_0;
				}
				if (this.String_1 != null)
				{
					binding.ElementName = this.String_1;
				}
				if (this.method_0() != null)
				{
					binding.Source = this.method_0();
				}
				binding.FallbackValue = this.method_2();
				MultiBinding multiBinding = new MultiBinding();
				multiBinding.Converter = dje_zFDLEGHXBFSGDCM2TDVRTCFF5W5UQ_ejd.Class827.class827_0;
				multiBinding.ConverterParameter = dependencyProperty;
				multiBinding.Bindings.Add(binding);
				multiBinding.NotifyOnSourceUpdated = true;
				frameworkElement.SetBinding(dje_zFDLEGHXBFSGDCM2TDVRTCFF5W5UQ_ejd.dependencyProperty_0, multiBinding);
				return null;
			}
			return null;
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x000A7EC4 File Offset: 0x000A60C4
		public object method_0()
		{
			return this.object_0;
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x000A7ECC File Offset: 0x000A60CC
		public void method_1(object object_3)
		{
			this.object_0 = object_3;
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x000A7ED8 File Offset: 0x000A60D8
		// (set) Token: 0x06002795 RID: 10133 RVA: 0x000A7EE0 File Offset: 0x000A60E0
		public PropertyPath Path
		{
			[CompilerGenerated]
			get
			{
				return this.propertyPath_0;
			}
			[CompilerGenerated]
			set
			{
				this.propertyPath_0 = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x000A7EEC File Offset: 0x000A60EC
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x000A7EF4 File Offset: 0x000A60F4
		[DefaultValue(null)]
		public string String_0
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x000A7F00 File Offset: 0x000A6100
		// (set) Token: 0x06002799 RID: 10137 RVA: 0x000A7F08 File Offset: 0x000A6108
		[DefaultValue(BindingMode.Default)]
		public BindingMode BindingMode_0
		{
			get
			{
				return this.bindingMode_0;
			}
			set
			{
				this.bindingMode_0 = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x000A7F14 File Offset: 0x000A6114
		// (set) Token: 0x0600279B RID: 10139 RVA: 0x000A7F1C File Offset: 0x000A611C
		[DefaultValue(UpdateSourceTrigger.Default)]
		public UpdateSourceTrigger UpdateSourceTrigger_0
		{
			get
			{
				return this.updateSourceTrigger_0;
			}
			set
			{
				this.updateSourceTrigger_0 = value;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x000A7F28 File Offset: 0x000A6128
		// (set) Token: 0x0600279D RID: 10141 RVA: 0x000A7F30 File Offset: 0x000A6130
		[DefaultValue(null)]
		public IValueConverter IValueConverter_0
		{
			get
			{
				return this.ivalueConverter_0;
			}
			set
			{
				this.ivalueConverter_0 = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x000A7F3C File Offset: 0x000A613C
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x000A7F44 File Offset: 0x000A6144
		[DefaultValue(null)]
		public object Object_0
		{
			get
			{
				return this.object_1;
			}
			set
			{
				this.object_1 = value;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x000A7F50 File Offset: 0x000A6150
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x000A7F58 File Offset: 0x000A6158
		[DefaultValue(null)]
		[TypeConverter(typeof(CultureInfoIetfLanguageTagConverter))]
		public CultureInfo CultureInfo_0
		{
			get
			{
				return this.cultureInfo_0;
			}
			set
			{
				this.cultureInfo_0 = value;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x000A7F64 File Offset: 0x000A6164
		// (set) Token: 0x060027A3 RID: 10147 RVA: 0x000A7F6C File Offset: 0x000A616C
		[DefaultValue(null)]
		public RelativeSource RelativeSource_0
		{
			get
			{
				return this.relativeSource_0;
			}
			set
			{
				this.relativeSource_0 = value;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x000A7F78 File Offset: 0x000A6178
		// (set) Token: 0x060027A5 RID: 10149 RVA: 0x000A7F80 File Offset: 0x000A6180
		[DefaultValue(null)]
		public string String_1
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000A7F8C File Offset: 0x000A618C
		public object method_2()
		{
			return this.object_2;
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000A7F94 File Offset: 0x000A6194
		public void method_3(object object_3)
		{
			this.object_2 = object_3;
		}

		// Token: 0x04001D47 RID: 7495
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.RegisterAttached("ResourceBindingKeyHelper", typeof(object), typeof(dje_zFDLEGHXBFSGDCM2TDVRTCFF5W5UQ_ejd), new PropertyMetadata(null, new PropertyChangedCallback(dje_zFDLEGHXBFSGDCM2TDVRTCFF5W5UQ_ejd.smethod_0)));

		// Token: 0x04001D48 RID: 7496
		private object object_0;

		// Token: 0x04001D49 RID: 7497
		private PropertyPath propertyPath_0;

		// Token: 0x04001D4A RID: 7498
		private string string_0;

		// Token: 0x04001D4B RID: 7499
		private BindingMode bindingMode_0;

		// Token: 0x04001D4C RID: 7500
		private UpdateSourceTrigger updateSourceTrigger_0;

		// Token: 0x04001D4D RID: 7501
		private IValueConverter ivalueConverter_0;

		// Token: 0x04001D4E RID: 7502
		private object object_1;

		// Token: 0x04001D4F RID: 7503
		private CultureInfo cultureInfo_0;

		// Token: 0x04001D50 RID: 7504
		private RelativeSource relativeSource_0;

		// Token: 0x04001D51 RID: 7505
		private string string_1;

		// Token: 0x04001D52 RID: 7506
		private object object_2;

		// Token: 0x02000781 RID: 1921
		private sealed class Class827 : IMultiValueConverter
		{
			// Token: 0x060027AA RID: 10154 RVA: 0x000A7FB4 File Offset: 0x000A61B4
			public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
			{
				return Tuple.Create<object, DependencyProperty>(values[0], (DependencyProperty)parameter);
			}

			// Token: 0x060027AB RID: 10155 RVA: 0x000A7FC4 File Offset: 0x000A61C4
			public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
			{
				throw new NotImplementedException();
			}

			// Token: 0x04001D53 RID: 7507
			public static readonly dje_zFDLEGHXBFSGDCM2TDVRTCFF5W5UQ_ejd.Class827 class827_0 = new dje_zFDLEGHXBFSGDCM2TDVRTCFF5W5UQ_ejd.Class827();
		}
	}
}
