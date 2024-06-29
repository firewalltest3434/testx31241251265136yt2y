using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ns0
{
	// Token: 0x02000751 RID: 1873
	public sealed class dje_zAM4HZ5MMAMYP465L5R68FCN5K9BMJ2L89Z_ejd : IValueConverter
	{
		// Token: 0x060026D7 RID: 9943 RVA: 0x000A23B4 File Offset: 0x000A05B4
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is double)
			{
				double num = (double)value;
				return Math.Max(0.0, num - 35.0);
			}
			return DependencyProperty.UnsetValue;
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x000A23F4 File Offset: 0x000A05F4
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}
