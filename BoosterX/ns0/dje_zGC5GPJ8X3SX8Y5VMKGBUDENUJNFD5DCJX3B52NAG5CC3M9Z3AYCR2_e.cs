using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000783 RID: 1923
	public sealed class dje_zGC5GPJ8X3SX8Y5VMKGBUDENUJNFD5DCJX3B52NAG5CC3M9Z3AYCR2_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060027B0 RID: 10160 RVA: 0x000A805C File Offset: 0x000A625C
		public dje_zGC5GPJ8X3SX8Y5VMKGBUDENUJNFD5DCJX3B52NAG5CC3M9Z3AYCR2_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x000A806C File Offset: 0x000A626C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/devicepageucs/devicesgroupuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000A809C File Offset: 0x000A629C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000A80A8 File Offset: 0x000A62A8
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
				this.dje_z5QYU3UGZZK8P6HBXCSHD2BMW75JBJUSKUZRNPAVJABKCJXRZFRF6Z_ejd_0 = (dje_z5QYU3UGZZK8P6HBXCSHD2BMW75JBJUSKUZRNPAVJABKCJXRZFRF6Z_ejd)target;
				return;
			case 3:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 4:
				this.checkBox_1 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001D55 RID: 7509
		internal CheckBox checkBox_0;

		// Token: 0x04001D56 RID: 7510
		internal dje_z5QYU3UGZZK8P6HBXCSHD2BMW75JBJUSKUZRNPAVJABKCJXRZFRF6Z_ejd dje_z5QYU3UGZZK8P6HBXCSHD2BMW75JBJUSKUZRNPAVJABKCJXRZFRF6Z_ejd_0;

		// Token: 0x04001D57 RID: 7511
		internal TextBlock textBlock_0;

		// Token: 0x04001D58 RID: 7512
		internal CheckBox checkBox_1;

		// Token: 0x04001D59 RID: 7513
		private bool bool_0;
	}
}
