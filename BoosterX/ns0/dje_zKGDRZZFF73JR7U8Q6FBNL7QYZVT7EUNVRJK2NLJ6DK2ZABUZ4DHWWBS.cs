using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007AF RID: 1967
	public sealed class dje_zKGDRZZFF73JR7U8Q6FBNL7QYZVT7EUNVRJK2NLJ6DK2ZABUZ4DHWWBSF6GHYP2ECLS_ejd : RadioButton, IComponentConnector
	{
		// Token: 0x0600285D RID: 10333 RVA: 0x000AD3F0 File Offset: 0x000AB5F0
		public dje_zKGDRZZFF73JR7U8Q6FBNL7QYZVT7EUNVRJK2NLJ6DK2ZABUZ4DHWWBSF6GHYP2ECLS_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x000AD400 File Offset: 0x000AB600
		private void method_0(object sender, RoutedEventArgs p1)
		{
			if (this.bool_0)
			{
				this.bool_0 = false;
				p1.Handled = true;
				return;
			}
			bool? isChecked = base.IsChecked;
			if (isChecked.GetValueOrDefault() & isChecked != null)
			{
				base.IsChecked = new bool?(false);
			}
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x000AD44C File Offset: 0x000AB64C
		private void method_1(object sender, RoutedEventArgs p1)
		{
			this.bool_0 = true;
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000AD458 File Offset: 0x000AB658
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/gamemodexucs/gmxgamesuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000AD488 File Offset: 0x000AB688
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((dje_zKGDRZZFF73JR7U8Q6FBNL7QYZVT7EUNVRJK2NLJ6DK2ZABUZ4DHWWBSF6GHYP2ECLS_ejd)target).Checked += this.method_1;
				((dje_zKGDRZZFF73JR7U8Q6FBNL7QYZVT7EUNVRJK2NLJ6DK2ZABUZ4DHWWBSF6GHYP2ECLS_ejd)target).Click += this.method_0;
				return;
			}
			this.bool_1 = true;
		}

		// Token: 0x04001E57 RID: 7767
		private bool bool_0;

		// Token: 0x04001E58 RID: 7768
		private bool bool_1;
	}
}
