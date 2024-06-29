using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using BoosterX.Classes.Tweaks.Expert.ServicesTweak;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x020007E0 RID: 2016
	public sealed class dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd : Page, IComponentConnector
	{
		// Token: 0x0600295F RID: 10591 RVA: 0x000B2144 File Offset: 0x000B0344
		public dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd()
		{
			this.InitializeComponent();
			this.listView_0.Opacity = 0.0;
			this.method_2(false);
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x000B21BC File Offset: 0x000B03BC
		private bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x000B21C4 File Offset: 0x000B03C4
		private void method_1(bool bool_3)
		{
			this.bool_0 = bool_3;
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000B21D0 File Offset: 0x000B03D0
		public void method_2(bool bool_3)
		{
			dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Struct566 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd_0 = this;
			@struct.bool_0 = bool_3;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Struct566>(ref @struct);
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000B2210 File Offset: 0x000B0410
		public void method_3()
		{
			Task.Run(new Action(this.method_12));
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x000B2224 File Offset: 0x000B0424
		private void button_2_Click(object sender, RoutedEventArgs p1)
		{
			this.checkBox_0.IsChecked = new bool?(true);
			this.method_2(true);
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x000B2240 File Offset: 0x000B0440
		private void method_4(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28 enum28_1, bool bool_3)
		{
			Func<GClass151, string> keySelector = new Func<GClass151, string>(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class842.class842_0.method_0);
			if (enum28_1 == (dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28)1)
			{
				keySelector = new Func<GClass151, string>(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class842.class842_0.method_1);
			}
			else if (enum28_1 == (dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28)0)
			{
				keySelector = new Func<GClass151, string>(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class842.class842_0.method_2);
			}
			else if (enum28_1 == (dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28)2)
			{
				keySelector = new Func<GClass151, string>(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class842.class842_0.method_3);
			}
			else if (enum28_1 == (dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28)3)
			{
				keySelector = new Func<GClass151, string>(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class842.class842_0.method_4);
			}
			if (bool_3)
			{
				this.list_0 = this.list_0.OrderBy(keySelector).ToList<GClass151>();
			}
			else
			{
				this.list_0 = this.list_0.OrderByDescending(keySelector).ToList<GClass151>();
			}
			this.method_3();
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000B233C File Offset: 0x000B053C
		private void comboBox_1_SelectionChanged(object sender, SelectionChangedEventArgs p1)
		{
			string name = ((ComboBoxItem)((ComboBox)sender).SelectedItem).Name;
			if (name == "SortingComboItemName")
			{
				this.enum28_0 = (dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28)0;
			}
			if (name == "SortingComboItemDisplayName")
			{
				this.enum28_0 = (dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28)1;
			}
			if (name == "SortingComboItemStartUp")
			{
				this.enum28_0 = (dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28)2;
			}
			if (name == "SortingComboItemStatus")
			{
				this.enum28_0 = (dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28)3;
			}
			this.method_5();
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x000B23C0 File Offset: 0x000B05C0
		private void comboBox_2_SelectionChanged(object sender, SelectionChangedEventArgs p1)
		{
			string name = ((ComboBoxItem)((ComboBox)sender).SelectedItem).Name;
			this.bool_1 = (name == "SortingComboAscending");
			this.method_5();
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x000B23FC File Offset: 0x000B05FC
		private void method_5()
		{
			if (this.enum28_0 == (dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28)0 && this.class692_0.ShowDisplayName)
			{
				this.class692_0.ShowDisplayName = false;
			}
			if (this.enum28_0 == (dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28)1 && !this.class692_0.ShowDisplayName)
			{
				this.class692_0.ShowDisplayName = true;
			}
			this.method_4(this.enum28_0, this.bool_1);
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x000B2460 File Offset: 0x000B0660
		public void method_6(PropertyChangedEventHandler propertyChangedEventHandler_1)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, propertyChangedEventHandler_1);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x000B2498 File Offset: 0x000B0698
		public void method_7(PropertyChangedEventHandler propertyChangedEventHandler_1)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, propertyChangedEventHandler_1);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x000B24D0 File Offset: 0x000B06D0
		protected void vmethod_0([CallerMemberName] string string_1)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler == null)
			{
				return;
			}
			propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_1));
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x000B24EC File Offset: 0x000B06EC
		protected bool method_8<T>(ref T gparam_0, T gparam_1, [CallerMemberName] string string_1)
		{
			if (EqualityComparer<T>.Default.Equals(gparam_0, gparam_1))
			{
				return false;
			}
			gparam_0 = gparam_1;
			this.vmethod_0(string_1);
			return true;
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x000B2514 File Offset: 0x000B0714
		private void textBox_0_GotFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == Class364.smethod_0("Search"))
			{
				this.textBox_0.Text = string.Empty;
			}
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x000B2544 File Offset: 0x000B0744
		private void textBox_0_LostFocus(object sender, RoutedEventArgs p1)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = Class364.smethod_0("Search");
			}
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000B2574 File Offset: 0x000B0774
		private void textBox_0_KeyUp(object sender, KeyEventArgs p1)
		{
			this.string_0 = this.textBox_0.Text;
			this.method_3();
			if (p1.Key == Key.Escape)
			{
				this.textBox_0.Text = string.Empty;
			}
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x000B25A8 File Offset: 0x000B07A8
		private void method_9(object sender, RoutedEventArgs p1)
		{
			this.method_10();
			this.method_3();
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x000B25B8 File Offset: 0x000B07B8
		private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs p1)
		{
			dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum27 @enum;
			if (Enum.TryParse<dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum27>(((ComboBoxItem)((ComboBox)sender).SelectedItem).Name, out @enum))
			{
				this.enum27_0 = @enum;
				this.method_3();
			}
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x000B25F0 File Offset: 0x000B07F0
		private void method_10()
		{
			this.textBox_0.Text = Class364.smethod_0("Search");
			this.string_0 = string.Empty;
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000B2614 File Offset: 0x000B0814
		private void checkBox_0_Checked(object sender, RoutedEventArgs p1)
		{
			if (this.method_0())
			{
				this.method_1(false);
				this.method_10();
				this.method_3();
			}
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000B2634 File Offset: 0x000B0834
		private void checkBox_0_Unchecked(object sender, RoutedEventArgs p1)
		{
			if (!this.method_0())
			{
				this.method_1(true);
				this.method_10();
				this.method_3();
			}
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000B2654 File Offset: 0x000B0854
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			this.list_0.ForEach(new Action<GClass151>(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class842.class842_0.method_5));
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x000B2680 File Offset: 0x000B0880
		private void button_1_Click(object sender, RoutedEventArgs p1)
		{
			this.list_0.ForEach(new Action<GClass151>(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class842.class842_0.method_6));
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000B26AC File Offset: 0x000B08AC
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All files (*.*)|*.*";
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			openFileDialog.Title = Class364.smethod_0("ChooseFile");
			bool? flag = openFileDialog.ShowDialog();
			if (flag.GetValueOrDefault() & flag != null)
			{
				dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class840 @class = new dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class840();
				@class.list_0 = new List<GClass92>();
				if (openFileDialog.FileName.EndsWith(".reg"))
				{
					@class.list_0 = GClass188.smethod_18(openFileDialog.FileName);
				}
				else
				{
					openFileDialog.FileName.EndsWith(".bat");
				}
				if (@class.list_0.Count > 0)
				{
					this.list_0.ForEach(new Action<GClass151>(@class.method_0));
				}
			}
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000B2770 File Offset: 0x000B0970
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_2)
			{
				return;
			}
			this.bool_2 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/winservicesmanagerpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000B27A0 File Offset: 0x000B09A0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_11(Type type_0, string string_1)
		{
			return Delegate.CreateDelegate(type_0, this, string_1);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000B27AC File Offset: 0x000B09AC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd_0 = (dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd)target;
				return;
			case 2:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 3:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 4:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 5:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.KeyUp += this.textBox_0_KeyUp;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				return;
			case 6:
				((Button)target).Click += this.method_9;
				return;
			case 7:
				this.checkBox_0 = (CheckBox)target;
				this.checkBox_0.Checked += this.checkBox_0_Checked;
				this.checkBox_0.Unchecked += this.checkBox_0_Unchecked;
				return;
			case 8:
				this.comboBox_0 = (ComboBox)target;
				this.comboBox_0.SelectionChanged += this.comboBox_0_SelectionChanged;
				return;
			case 9:
				this.comboBoxItem_0 = (ComboBoxItem)target;
				return;
			case 10:
				this.comboBoxItem_1 = (ComboBoxItem)target;
				return;
			case 11:
				this.comboBoxItem_2 = (ComboBoxItem)target;
				return;
			case 12:
				this.comboBoxItem_3 = (ComboBoxItem)target;
				return;
			case 13:
				this.comboBoxItem_4 = (ComboBoxItem)target;
				return;
			case 14:
				this.comboBoxItem_5 = (ComboBoxItem)target;
				return;
			case 15:
				this.comboBoxItem_6 = (ComboBoxItem)target;
				return;
			case 16:
				this.dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0 = (dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd)target;
				return;
			case 17:
				this.comboBox_1 = (ComboBox)target;
				this.comboBox_1.SelectionChanged += this.comboBox_1_SelectionChanged;
				return;
			case 18:
				this.comboBoxItem_7 = (ComboBoxItem)target;
				return;
			case 19:
				this.comboBoxItem_8 = (ComboBoxItem)target;
				return;
			case 20:
				this.comboBoxItem_9 = (ComboBoxItem)target;
				return;
			case 21:
				this.comboBoxItem_10 = (ComboBoxItem)target;
				return;
			case 22:
				this.comboBox_2 = (ComboBox)target;
				this.comboBox_2.SelectionChanged += this.comboBox_2_SelectionChanged;
				return;
			case 23:
				this.comboBoxItem_11 = (ComboBoxItem)target;
				return;
			case 24:
				this.comboBoxItem_12 = (ComboBoxItem)target;
				return;
			case 25:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 26:
				this.listView_0 = (ListView)target;
				return;
			default:
				this.bool_2 = true;
				return;
			}
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000B2AA4 File Offset: 0x000B0CA4
		private void method_12()
		{
			dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class841 @class = new dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class841();
			@class.dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd_0 = this;
			@class.list_0 = new List<GClass151>();
			@class.list_0.AddRange(this.list_0);
			@class.list_0 = @class.list_0.Where(new Func<GClass151, bool>(this.method_13)).Where(new Func<GClass151, bool>(this.method_14)).Where(new Func<GClass151, bool>(this.method_15)).ToList<GClass151>();
			Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(@class.method_0));
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000B2B3C File Offset: 0x000B0D3C
		private bool method_13(GClass151 gclass151_0)
		{
			return gclass151_0.Service.ServiceName.ToLower().Contains(this.string_0.ToLower()) || gclass151_0.Service.method_6(this.string_0.ToLower()) || gclass151_0.DisplayName.ToLower().Contains(this.string_0.ToLower()) || gclass151_0.WillBrake.ToLower().Contains(this.string_0.ToLower()) || (gclass151_0.Description != null && gclass151_0.Description.ToLower().Contains(this.string_0.ToLower()));
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000B2BE4 File Offset: 0x000B0DE4
		private bool method_14(GClass151 gclass151_0)
		{
			return !this.method_0() || GClass93.smethod_0().method_12<ServicesTweak>(gclass151_0.Service.ServiceName) != null;
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000B2C08 File Offset: 0x000B0E08
		private bool method_15(GClass151 gclass151_0)
		{
			bool result;
			switch (this.enum27_0)
			{
			case dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum27.AllServices:
				result = gclass151_0.Service.method_4();
				break;
			case dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum27.WindowsServices:
				result = (gclass151_0.Service.method_4() && GClass172.smethod_0(gclass151_0.Service));
				break;
			case dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum27.OtherServices:
				result = (gclass151_0.Service.method_4() && !GClass172.smethod_0(gclass151_0.Service));
				break;
			case dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum27.AllDrivers:
				result = gclass151_0.Service.method_5();
				break;
			case dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum27.WindowsDrivers:
				result = (gclass151_0.Service.method_5() && GClass172.smethod_0(gclass151_0.Service));
				break;
			case dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum27.OtherDrivers:
				result = (gclass151_0.Service.method_5() && !GClass172.smethod_0(gclass151_0.Service));
				break;
			case dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum27.All:
				result = true;
				break;
			default:
				result = true;
				break;
			}
			return result;
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x000B2CE8 File Offset: 0x000B0EE8
		private void method_16(GClass151 gclass151_0)
		{
			gclass151_0.ShowDisplayName = this.class692_0.ShowDisplayName;
		}

		// Token: 0x04001F4F RID: 8015
		private string string_0 = string.Empty;

		// Token: 0x04001F50 RID: 8016
		private dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum27 enum27_0;

		// Token: 0x04001F51 RID: 8017
		private readonly Class683.Class692 class692_0 = new Class683.Class692
		{
			ShowDisplayName = true,
			SingleServiceInfoViews = new ObservableCollection<GClass151>()
		};

		// Token: 0x04001F52 RID: 8018
		private List<GClass151> list_0 = new List<GClass151>();

		// Token: 0x04001F53 RID: 8019
		private bool bool_0 = true;

		// Token: 0x04001F54 RID: 8020
		private bool bool_1 = true;

		// Token: 0x04001F55 RID: 8021
		private dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28 enum28_0;

		// Token: 0x04001F56 RID: 8022
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x04001F57 RID: 8023
		internal dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd_0;

		// Token: 0x04001F58 RID: 8024
		internal Button button_0;

		// Token: 0x04001F59 RID: 8025
		internal Button button_1;

		// Token: 0x04001F5A RID: 8026
		internal Button button_2;

		// Token: 0x04001F5B RID: 8027
		internal TextBox textBox_0;

		// Token: 0x04001F5C RID: 8028
		internal CheckBox checkBox_0;

		// Token: 0x04001F5D RID: 8029
		internal ComboBox comboBox_0;

		// Token: 0x04001F5E RID: 8030
		internal ComboBoxItem comboBoxItem_0;

		// Token: 0x04001F5F RID: 8031
		internal ComboBoxItem comboBoxItem_1;

		// Token: 0x04001F60 RID: 8032
		internal ComboBoxItem comboBoxItem_2;

		// Token: 0x04001F61 RID: 8033
		internal ComboBoxItem comboBoxItem_3;

		// Token: 0x04001F62 RID: 8034
		internal ComboBoxItem comboBoxItem_4;

		// Token: 0x04001F63 RID: 8035
		internal ComboBoxItem comboBoxItem_5;

		// Token: 0x04001F64 RID: 8036
		internal ComboBoxItem comboBoxItem_6;

		// Token: 0x04001F65 RID: 8037
		internal dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0;

		// Token: 0x04001F66 RID: 8038
		internal ComboBox comboBox_1;

		// Token: 0x04001F67 RID: 8039
		internal ComboBoxItem comboBoxItem_7;

		// Token: 0x04001F68 RID: 8040
		internal ComboBoxItem comboBoxItem_8;

		// Token: 0x04001F69 RID: 8041
		internal ComboBoxItem comboBoxItem_9;

		// Token: 0x04001F6A RID: 8042
		internal ComboBoxItem comboBoxItem_10;

		// Token: 0x04001F6B RID: 8043
		internal ComboBox comboBox_2;

		// Token: 0x04001F6C RID: 8044
		internal ComboBoxItem comboBoxItem_11;

		// Token: 0x04001F6D RID: 8045
		internal ComboBoxItem comboBoxItem_12;

		// Token: 0x04001F6E RID: 8046
		internal Button button_3;

		// Token: 0x04001F6F RID: 8047
		internal ListView listView_0;

		// Token: 0x04001F70 RID: 8048
		private bool bool_2;

		// Token: 0x020007E1 RID: 2017
		private sealed class Class840
		{
			// Token: 0x06002981 RID: 10625 RVA: 0x000B2D04 File Offset: 0x000B0F04
			internal void method_0(GClass151 gclass151_0)
			{
				dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class843 @class = new dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class843();
				@class.gclass151_0 = gclass151_0;
				this.list_0.ForEach(new Action<GClass92>(@class.method_0));
			}

			// Token: 0x04001F71 RID: 8049
			public List<GClass92> list_0;
		}

		// Token: 0x020007E2 RID: 2018
		private enum Enum27
		{
			// Token: 0x04001F73 RID: 8051
			AllServices,
			// Token: 0x04001F74 RID: 8052
			WindowsServices,
			// Token: 0x04001F75 RID: 8053
			OtherServices,
			// Token: 0x04001F76 RID: 8054
			AllDrivers,
			// Token: 0x04001F77 RID: 8055
			WindowsDrivers,
			// Token: 0x04001F78 RID: 8056
			OtherDrivers,
			// Token: 0x04001F79 RID: 8057
			All
		}

		// Token: 0x020007E3 RID: 2019
		[StructLayout(LayoutKind.Auto)]
		private struct Struct566 : IAsyncStateMachine
		{
			// Token: 0x06002982 RID: 10626 RVA: 0x000B2D38 File Offset: 0x000B0F38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd = this.dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_129;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_19F;
					default:
						dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.button_2.IsEnabled = false;
						dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.DataContext = null;
						dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.DataContext = dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.class692_0;
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.listView_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Struct566>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0);
					dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.class692_0.SingleServiceInfoViews.Clear();
					dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.list_0.Clear();
					this.class760_0 = Class683.smethod_1(this.bool_0);
					awaiter = Class683.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Struct566>(ref awaiter, ref this);
						return;
					}
					IL_129:
					awaiter.GetResult();
					dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.list_0 = this.class760_0.AllServices;
					dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.method_4((dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Enum28)1, true);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.dje_z4MP6Y7KFGZ3ZH48FYKQ34LWTUGJ54C6VS5ZR946QJCY2DFQ_ejd_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Struct566>(ref awaiter, ref this);
						return;
					}
					IL_19F:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.listView_0);
					dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.button_2.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class760_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class760_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002983 RID: 10627 RVA: 0x000B2F58 File Offset: 0x000B1158
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F7A RID: 8058
			public int int_0;

			// Token: 0x04001F7B RID: 8059
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F7C RID: 8060
			public dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd_0;

			// Token: 0x04001F7D RID: 8061
			public bool bool_0;

			// Token: 0x04001F7E RID: 8062
			private Class683.Class760 class760_0;

			// Token: 0x04001F7F RID: 8063
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007E4 RID: 2020
		private sealed class Class841
		{
			// Token: 0x06002985 RID: 10629 RVA: 0x000B2F70 File Offset: 0x000B1170
			internal void method_0()
			{
				this.dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd_0.class692_0.SingleServiceInfoViews.Clear();
				this.dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd_0.class692_0.SingleServiceInfoViews = new ObservableCollection<GClass151>(this.list_0);
				this.dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd_0.list_0.ForEach(new Action<GClass151>(this.dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd_0.method_16));
			}

			// Token: 0x04001F80 RID: 8064
			public List<GClass151> list_0;

			// Token: 0x04001F81 RID: 8065
			public dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd_0;
		}

		// Token: 0x020007E5 RID: 2021
		private enum Enum28
		{

		}

		// Token: 0x020007E6 RID: 2022
		[Serializable]
		private sealed class Class842
		{
			// Token: 0x06002988 RID: 10632 RVA: 0x000B2FE4 File Offset: 0x000B11E4
			internal string method_0(GClass151 gclass151_0)
			{
				return gclass151_0.DisplayName;
			}

			// Token: 0x06002989 RID: 10633 RVA: 0x000B2FEC File Offset: 0x000B11EC
			internal string method_1(GClass151 gclass151_0)
			{
				return gclass151_0.DisplayName;
			}

			// Token: 0x0600298A RID: 10634 RVA: 0x000B2FF4 File Offset: 0x000B11F4
			internal string method_2(GClass151 gclass151_0)
			{
				return gclass151_0.Service.ServiceName;
			}

			// Token: 0x0600298B RID: 10635 RVA: 0x000B3004 File Offset: 0x000B1204
			internal string method_3(GClass151 gclass151_0)
			{
				return gclass151_0.Service.method_0().ToString();
			}

			// Token: 0x0600298C RID: 10636 RVA: 0x000B302C File Offset: 0x000B122C
			internal string method_4(GClass151 gclass151_0)
			{
				return gclass151_0.Service.Status.ToString();
			}

			// Token: 0x0600298D RID: 10637 RVA: 0x000B3054 File Offset: 0x000B1254
			internal void method_5(GClass151 gclass151_0)
			{
				if (gclass151_0.WinServiceViewModel.IsService)
				{
					gclass151_0.WinServiceViewModel.method_2();
				}
			}

			// Token: 0x0600298E RID: 10638 RVA: 0x000B3070 File Offset: 0x000B1270
			internal void method_6(GClass151 gclass151_0)
			{
				if (!gclass151_0.WinServiceViewModel.IsService)
				{
					gclass151_0.WinServiceViewModel.method_2();
				}
			}

			// Token: 0x04001F83 RID: 8067
			public static readonly dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class842 class842_0 = new dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd.Class842();

			// Token: 0x04001F84 RID: 8068
			public static Func<GClass151, string> func_0;

			// Token: 0x04001F85 RID: 8069
			public static Func<GClass151, string> func_1;

			// Token: 0x04001F86 RID: 8070
			public static Func<GClass151, string> func_2;

			// Token: 0x04001F87 RID: 8071
			public static Func<GClass151, string> func_3;

			// Token: 0x04001F88 RID: 8072
			public static Func<GClass151, string> func_4;

			// Token: 0x04001F89 RID: 8073
			public static Action<GClass151> action_0;

			// Token: 0x04001F8A RID: 8074
			public static Action<GClass151> action_1;
		}

		// Token: 0x020007E7 RID: 2023
		private sealed class Class843
		{
			// Token: 0x06002990 RID: 10640 RVA: 0x000B3094 File Offset: 0x000B1294
			internal void method_0(GClass92 gclass92_0)
			{
				if (this.gclass151_0.ServiceName.ToLower() == gclass92_0.Name.ToLower())
				{
					this.gclass151_0.WinServiceViewModel.NewStartMode = gclass92_0.Status;
				}
			}

			// Token: 0x04001F8B RID: 8075
			public GClass151 gclass151_0;
		}
	}
}
