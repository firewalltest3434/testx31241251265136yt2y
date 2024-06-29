using System;
using System.Windows;
using System.Windows.Controls;

namespace ns0
{
	// Token: 0x020007DF RID: 2015
	public class dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd : Page
	{
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x000B20A4 File Offset: 0x000B02A4
		// (set) Token: 0x06002958 RID: 10584 RVA: 0x000B20B8 File Offset: 0x000B02B8
		public bool OnlyPCores
		{
			get
			{
				return (bool)base.GetValue(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd.dependencyProperty_0);
			}
			set
			{
				base.SetValue(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd.dependencyProperty_0, value);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x000B20CC File Offset: 0x000B02CC
		// (set) Token: 0x0600295A RID: 10586 RVA: 0x000B20E0 File Offset: 0x000B02E0
		public bool DisableCore0
		{
			get
			{
				return (bool)base.GetValue(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd.dependencyProperty_1);
			}
			set
			{
				base.SetValue(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd.dependencyProperty_1, value);
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x000B20F4 File Offset: 0x000B02F4
		// (set) Token: 0x0600295C RID: 10588 RVA: 0x000B2108 File Offset: 0x000B0308
		public bool DisableHyperThreading
		{
			get
			{
				return (bool)base.GetValue(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd.dependencyProperty_2);
			}
			set
			{
				base.SetValue(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd.dependencyProperty_2, value);
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x000B211C File Offset: 0x000B031C
		// (set) Token: 0x0600295E RID: 10590 RVA: 0x000B2130 File Offset: 0x000B0330
		public bool CustomChoose
		{
			get
			{
				return (bool)base.GetValue(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd.dependencyProperty_3);
			}
			set
			{
				base.SetValue(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd.dependencyProperty_3, value);
			}
		}

		// Token: 0x04001F4B RID: 8011
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.Register("OnlyPCores", typeof(bool), typeof(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd), new UIPropertyMetadata(false));

		// Token: 0x04001F4C RID: 8012
		public static readonly DependencyProperty dependencyProperty_1 = DependencyProperty.Register("DisableCore0", typeof(bool), typeof(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd), new UIPropertyMetadata(false));

		// Token: 0x04001F4D RID: 8013
		public static readonly DependencyProperty dependencyProperty_2 = DependencyProperty.Register("DisableHyperThreading", typeof(bool), typeof(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd), new UIPropertyMetadata(false));

		// Token: 0x04001F4E RID: 8014
		public static readonly DependencyProperty dependencyProperty_3 = DependencyProperty.Register("CustomChoose", typeof(bool), typeof(dje_zR79DDJ2MRE3Q4YX7ZQZELTY2RMZST9EMYG4C9JAC73TTUJQ_ejd), new UIPropertyMetadata(false));
	}
}
