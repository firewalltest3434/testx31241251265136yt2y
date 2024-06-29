using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000815 RID: 2069
	public sealed class dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd : Page, IComponentConnector
	{
		// Token: 0x06002A40 RID: 10816 RVA: 0x000B64C8 File Offset: 0x000B46C8
		public dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x000B64DC File Offset: 0x000B46DC
		private void method_0()
		{
			base.DataContext = (this.gclass222_0 = Class451.smethod_0(false));
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x000B6500 File Offset: 0x000B4700
		private void textBox_0_GotFocus(object sender, RoutedEventArgs p1)
		{
			this.textBox_0.Text = string.Empty;
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x000B6514 File Offset: 0x000B4714
		private void textBox_0_LostFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = (Application.Current.FindResource("SearchGameForSetup") as string);
			}
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x000B654C File Offset: 0x000B474C
		private void textBox_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs p1)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				textBox.SelectAll();
			}
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x000B656C File Offset: 0x000B476C
		private void textBox_0_TextChanged(object sender, TextChangedEventArgs p1)
		{
			dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd.Class851 @class = new dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd.Class851();
			@class.dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd_0 = this;
			if (this.gclass222_0 == null)
			{
				return;
			}
			if (!(this.textBox_0.Text == Class364.smethod_0("SearchGameForSetup")) && !(this.textBox_0.Text == string.Empty) && this.textBox_0.Text.Length >= 3)
			{
				@class.string_0 = this.textBox_0.Text;
				if (!this.comboBox_0.IsDropDownOpen)
				{
					this.comboBox_0.IsDropDownOpen = true;
				}
				this.comboBox_0.ItemsSource = ((!string.IsNullOrEmpty(@class.string_0)) ? new ObservableCollection<GClass136>(this.gclass222_0.Profiles.Where(new Func<GClass136, bool>(@class.method_0))) : this.gclass222_0.Profiles);
				return;
			}
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x000B6660 File Offset: 0x000B4860
		private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs p1)
		{
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x000B6664 File Offset: 0x000B4864
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/nvidiapage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x000B6694 File Offset: 0x000B4894
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_1(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x000B66A0 File Offset: 0x000B48A0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.button_0 = (Button)target;
				return;
			case 2:
				this.button_1 = (Button)target;
				return;
			case 3:
				this.button_2 = (Button)target;
				return;
			case 4:
				this.button_3 = (Button)target;
				return;
			case 5:
				this.button_4 = (Button)target;
				return;
			case 6:
				this.comboBox_0 = (ComboBox)target;
				this.comboBox_0.SelectionChanged += this.comboBox_0_SelectionChanged;
				return;
			case 7:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				this.textBox_0.MouseLeftButtonUp += this.textBox_0_MouseLeftButtonUp;
				this.textBox_0.TextChanged += this.textBox_0_TextChanged;
				return;
			case 8:
				this.checkBox_0 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x0400204D RID: 8269
		public GClass222 gclass222_0;

		// Token: 0x0400204E RID: 8270
		internal Button button_0;

		// Token: 0x0400204F RID: 8271
		internal Button button_1;

		// Token: 0x04002050 RID: 8272
		internal Button button_2;

		// Token: 0x04002051 RID: 8273
		internal Button button_3;

		// Token: 0x04002052 RID: 8274
		internal Button button_4;

		// Token: 0x04002053 RID: 8275
		internal ComboBox comboBox_0;

		// Token: 0x04002054 RID: 8276
		internal TextBox textBox_0;

		// Token: 0x04002055 RID: 8277
		internal CheckBox checkBox_0;

		// Token: 0x04002056 RID: 8278
		private bool bool_0;

		// Token: 0x02000816 RID: 2070
		private sealed class Class851
		{
			// Token: 0x06002A4B RID: 10827 RVA: 0x000B67C0 File Offset: 0x000B49C0
			internal bool method_0(GClass136 gclass136_0)
			{
				return gclass136_0.ProfileName.smethod_2(this.string_0) || gclass136_0 == this.dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd_0.gclass222_0.BaseProfile;
			}

			// Token: 0x04002057 RID: 8279
			public string string_0;

			// Token: 0x04002058 RID: 8280
			public dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd_0;
		}
	}
}
