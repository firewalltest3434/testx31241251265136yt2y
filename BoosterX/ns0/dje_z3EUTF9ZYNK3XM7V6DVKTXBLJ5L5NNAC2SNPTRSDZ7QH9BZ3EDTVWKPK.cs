using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200069B RID: 1691
	public sealed class dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd : Page, IComponentConnector
	{
		// Token: 0x06002448 RID: 9288 RVA: 0x0009084C File Offset: 0x0008EA4C
		public dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_Loaded;
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x0009086C File Offset: 0x0008EA6C
		private void dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			base.DataContext = new Class580(this);
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x0009087C File Offset: 0x0008EA7C
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Application.Current.Dispatcher.Invoke(new Action(dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd.Class766.class766_0.method_0));
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x000908AC File Offset: 0x0008EAAC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/questionare/questionpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x000908DC File Offset: 0x0008EADC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 2:
				this.image_0 = (Image)target;
				return;
			case 3:
				this.image_1 = (Image)target;
				return;
			case 4:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 5:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 6:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 7:
				this.button_1 = (Button)target;
				return;
			case 8:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 9:
				this.textBlock_4 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040018D9 RID: 6361
		internal Button button_0;

		// Token: 0x040018DA RID: 6362
		internal Image image_0;

		// Token: 0x040018DB RID: 6363
		internal Image image_1;

		// Token: 0x040018DC RID: 6364
		internal TextBlock textBlock_0;

		// Token: 0x040018DD RID: 6365
		internal TextBlock textBlock_1;

		// Token: 0x040018DE RID: 6366
		internal TextBlock textBlock_2;

		// Token: 0x040018DF RID: 6367
		internal Button button_1;

		// Token: 0x040018E0 RID: 6368
		internal TextBlock textBlock_3;

		// Token: 0x040018E1 RID: 6369
		internal TextBlock textBlock_4;

		// Token: 0x040018E2 RID: 6370
		private bool bool_0;

		// Token: 0x0200069C RID: 1692
		[Serializable]
		private sealed class Class766
		{
			// Token: 0x0600244F RID: 9295 RVA: 0x000909BC File Offset: 0x0008EBBC
			internal void method_0()
			{
				Class704.bool_0 = false;
				Class358.smethod_0().method_3(typeof(dje_zQY9BNU6QWSXMEC3Y3Z9MX674M42YS2UN42DQDFQQZX68KU2_ejd), Class358.smethod_0().frame_0);
			}

			// Token: 0x040018E3 RID: 6371
			public static readonly dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd.Class766 class766_0 = new dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd.Class766();

			// Token: 0x040018E4 RID: 6372
			public static Action action_0;
		}
	}
}
