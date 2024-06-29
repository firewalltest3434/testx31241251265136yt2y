using System;
using System.Windows;
using System.Windows.Controls;

namespace ns0
{
	// Token: 0x0200080D RID: 2061
	public class dje_zW8YUDP3S7HTY5MN9SNJXVW52MTUD3QFQ6D5EZFR25X369NQ_ejd : UserControl
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x000B5A7C File Offset: 0x000B3C7C
		// (set) Token: 0x06002A24 RID: 10788 RVA: 0x000B5A90 File Offset: 0x000B3C90
		public double ArcThick
		{
			get
			{
				return (double)base.GetValue(dje_zW8YUDP3S7HTY5MN9SNJXVW52MTUD3QFQ6D5EZFR25X369NQ_ejd.dependencyProperty_0);
			}
			set
			{
				base.SetValue(dje_zW8YUDP3S7HTY5MN9SNJXVW52MTUD3QFQ6D5EZFR25X369NQ_ejd.dependencyProperty_0, value);
			}
		}

		// Token: 0x04002029 RID: 8233
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.Register("ArcThick", typeof(double), typeof(dje_z8VKMYK6QT9TCTRB844SSXLMJE4LHZU74WX5QXWVP3MG573ZSME5AQ_ejd), new UIPropertyMetadata(double.NaN));
	}
}
