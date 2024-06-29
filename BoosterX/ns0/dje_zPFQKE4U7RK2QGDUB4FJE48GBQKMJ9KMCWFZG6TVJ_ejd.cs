using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007D7 RID: 2007
	public sealed class dje_zPFQKE4U7RK2QGDUB4FJE48GBQKMJ9KMCWFZG6TVJ_ejd : Page, IComponentConnector
	{
		// Token: 0x0600292E RID: 10542 RVA: 0x000B1204 File Offset: 0x000AF404
		public dje_zPFQKE4U7RK2QGDUB4FJE48GBQKMJ9KMCWFZG6TVJ_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new GClass222();
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000B1220 File Offset: 0x000AF420
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/services/nvidiax/mvvm/views/nvidiapage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000B1250 File Offset: 0x000AF450
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x000B125C File Offset: 0x000AF45C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04001F1E RID: 7966
		private bool bool_0;
	}
}
