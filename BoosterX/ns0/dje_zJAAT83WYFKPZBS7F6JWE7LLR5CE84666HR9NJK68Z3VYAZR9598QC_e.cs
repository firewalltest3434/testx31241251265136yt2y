using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000796 RID: 1942
	public sealed class dje_zJAAT83WYFKPZBS7F6JWE7LLR5CE84666HR9NJK68Z3VYAZR9598QC_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002807 RID: 10247 RVA: 0x000AA2F0 File Offset: 0x000A84F0
		public dje_zJAAT83WYFKPZBS7F6JWE7LLR5CE84666HR9NJK68Z3VYAZR9598QC_ejd()
		{
			this.InitializeComponent();
			base.DataContextChanged += this.dje_zJAAT83WYFKPZBS7F6JWE7LLR5CE84666HR9NJK68Z3VYAZR9598QC_ejd_DataContextChanged;
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000AA310 File Offset: 0x000A8510
		private void dje_zJAAT83WYFKPZBS7F6JWE7LLR5CE84666HR9NJK68Z3VYAZR9598QC_ejd_DataContextChanged(object sender, DependencyPropertyChangedEventArgs p1)
		{
			GClass61 gclass = p1.NewValue as GClass61;
			if (gclass != null)
			{
				this.gclass61_0 = gclass;
			}
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000AA334 File Offset: 0x000A8534
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/servicesgroupcontroller/servicesgroupcontroller.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000AA364 File Offset: 0x000A8564
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x000AA370 File Offset: 0x000A8570
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 2:
				this.grid_0 = (Grid)target;
				return;
			case 3:
				this.checkBox_1 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001DBB RID: 7611
		private GClass61 gclass61_0;

		// Token: 0x04001DBC RID: 7612
		internal CheckBox checkBox_0;

		// Token: 0x04001DBD RID: 7613
		internal Grid grid_0;

		// Token: 0x04001DBE RID: 7614
		internal CheckBox checkBox_1;

		// Token: 0x04001DBF RID: 7615
		private bool bool_0;
	}
}
