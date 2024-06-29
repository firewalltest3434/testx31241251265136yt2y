using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace ns0
{
	// Token: 0x020007F3 RID: 2035
	public sealed class dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd : Page, IComponentConnector, IStyleConnector
	{
		// Token: 0x060029B8 RID: 10680 RVA: 0x000B3CB8 File Offset: 0x000B1EB8
		public dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
			this.method_8();
			Class588.smethod_0(new Class588.Delegate30(this.method_8));
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x000B3CEC File Offset: 0x000B1EEC
		// (set) Token: 0x060029BA RID: 10682 RVA: 0x000B3CF4 File Offset: 0x000B1EF4
		public ICollectionView SettingItemsCollectionView
		{
			[CompilerGenerated]
			get
			{
				return this.icollectionView_0;
			}
			[CompilerGenerated]
			private set
			{
				this.icollectionView_0 = value;
			}
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x000B3D00 File Offset: 0x000B1F00
		private void method_0(bool bool_3)
		{
			dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct572 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0 = this;
			@struct.bool_0 = bool_3;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct572>(ref @struct);
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x000B3D40 File Offset: 0x000B1F40
		private void button_3_Click(object sender, RoutedEventArgs p1)
		{
			this.method_0(true);
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x000B3D4C File Offset: 0x000B1F4C
		private void method_1(bool bool_3, TextBlock textBlock_0)
		{
			if (bool_3)
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("enabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
				return;
			}
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("disabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000B3D7C File Offset: 0x000B1F7C
		private void method_2(bool bool_3, TextBlock textBlock_0)
		{
			if (bool_3)
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("enabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				return;
			}
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("disabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000B3DAC File Offset: 0x000B1FAC
		private void method_3(TextBlock textBlock_0, bool bool_3)
		{
			if (bool_3)
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("enableds"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
				return;
			}
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("disableds"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000B3DDC File Offset: 0x000B1FDC
		private void method_4(TextBlock textBlock_0, bool bool_3)
		{
			if (bool_3)
			{
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("enableds"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				return;
			}
			dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("disableds"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000B3E0C File Offset: 0x000B200C
		private void method_5(bool bool_3, TextBlock textBlock_0)
		{
			if (this.bool_0)
			{
				if (bool_3)
				{
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("willbeenabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
					return;
				}
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("willbedisabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000B3E44 File Offset: 0x000B2044
		private void method_6(bool bool_3, TextBlock textBlock_0)
		{
			if (this.bool_0)
			{
				if (bool_3)
				{
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("willbeenabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					return;
				}
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_6(textBlock_0, Class364.smethod_0("willbedisabled"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
			}
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000B3E7C File Offset: 0x000B207C
		private void method_7(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GClass230 gclass230_1, string string_0, SolidColorBrush solidColorBrush_0)
		{
			dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct569 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0 = this;
			@struct.gclass230_0 = gclass230_1;
			@struct.string_0 = string_0;
			@struct.solidColorBrush_0 = solidColorBrush_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct569>(ref @struct);
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x000B3ECC File Offset: 0x000B20CC
		public void button_2_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_11(base.GetType());
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000B3EDC File Offset: 0x000B20DC
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_13(base.GetType());
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000B3EEC File Offset: 0x000B20EC
		public void button_1_Click(object sender, RoutedEventArgs p1)
		{
			Class588.smethod_12(base.GetType());
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x000B3EFC File Offset: 0x000B20FC
		public void method_8()
		{
			dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class846 @class = new dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class846();
			@class.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0 = this;
			this.bool_0 = false;
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.string_1 = string.Empty;
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_2.Clear();
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_10("ADDORDELETEPOWERSCHEME");
			base.Dispatcher.Invoke(new Action(@class.method_0));
			@class.string_0 = "66666666-6666-6666-6666-666666666666".ToLower();
			@class.int_0 = 0;
			GClass76.smethod_4().ToList<Guid>().ForEach(new Action<Guid>(@class.method_1));
			this.bool_0 = true;
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_1(false);
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.string_1 = string.Empty;
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_2.Clear();
			dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_10("ADDORDELETEPOWERSCHEME");
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000B3FB0 File Offset: 0x000B21B0
		private void method_9(object sender, RoutedEventArgs p1)
		{
			dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct571 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0 = this;
			@struct.object_0 = sender;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct571>(ref @struct);
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000B3FF0 File Offset: 0x000B21F0
		private void method_10(object sender, RoutedEventArgs p1)
		{
			dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct573 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0 = this;
			@struct.object_0 = sender;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct573>(ref @struct);
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000B4030 File Offset: 0x000B2230
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_2)
			{
				return;
			}
			this.bool_2 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/powersettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000B4060 File Offset: 0x000B2260
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 2:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 3:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 4:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 5:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 6:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_2 = true;
				return;
			case 9:
				this.checkBox_1 = (CheckBox)target;
				return;
			case 10:
				this.itemsControl_1 = (ItemsControl)target;
				return;
			}
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000B4168 File Offset: 0x000B2368
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 7)
			{
				((Button)target).Click += this.method_9;
				return;
			}
			if (connectionId != 8)
			{
				return;
			}
			((Button)target).Click += this.method_10;
		}

		// Token: 0x04001FBA RID: 8122
		private ICollectionView icollectionView_0;

		// Token: 0x04001FBB RID: 8123
		private bool bool_0 = true;

		// Token: 0x04001FBC RID: 8124
		private bool bool_1;

		// Token: 0x04001FBD RID: 8125
		private dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GClass230 gclass230_0;

		// Token: 0x04001FBE RID: 8126
		internal Button button_0;

		// Token: 0x04001FBF RID: 8127
		internal Button button_1;

		// Token: 0x04001FC0 RID: 8128
		internal Button button_2;

		// Token: 0x04001FC1 RID: 8129
		internal Button button_3;

		// Token: 0x04001FC2 RID: 8130
		internal CheckBox checkBox_0;

		// Token: 0x04001FC3 RID: 8131
		internal ItemsControl itemsControl_0;

		// Token: 0x04001FC4 RID: 8132
		internal CheckBox checkBox_1;

		// Token: 0x04001FC5 RID: 8133
		internal ItemsControl itemsControl_1;

		// Token: 0x04001FC6 RID: 8134
		private bool bool_2;

		// Token: 0x020007F4 RID: 2036
		[StructLayout(LayoutKind.Auto)]
		private struct Struct569 : IAsyncStateMachine
		{
			// Token: 0x060029CD RID: 10701 RVA: 0x000B41B8 File Offset: 0x000B23B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd = this.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class845 @class = new dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class845();
						@class.gclass230_0 = this.gclass230_0;
						@class.string_0 = this.string_0;
						@class.solidColorBrush_0 = this.solidColorBrush_0;
						awaiter = dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Dispatcher.Invoke<Task>(new Func<Task>(@class.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct569>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060029CE RID: 10702 RVA: 0x000B42A8 File Offset: 0x000B24A8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FC7 RID: 8135
			public int int_0;

			// Token: 0x04001FC8 RID: 8136
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001FC9 RID: 8137
			public dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GClass230 gclass230_0;

			// Token: 0x04001FCA RID: 8138
			public string string_0;

			// Token: 0x04001FCB RID: 8139
			public SolidColorBrush solidColorBrush_0;

			// Token: 0x04001FCC RID: 8140
			public dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0;

			// Token: 0x04001FCD RID: 8141
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007F5 RID: 2037
		public sealed class GClass230 : INotifyPropertyChanged
		{
			// Token: 0x170005CF RID: 1487
			// (get) Token: 0x060029D0 RID: 10704 RVA: 0x000B42C0 File Offset: 0x000B24C0
			// (set) Token: 0x060029D1 RID: 10705 RVA: 0x000B42C8 File Offset: 0x000B24C8
			public int ID
			{
				[CompilerGenerated]
				get
				{
					return this.int_0;
				}
				[CompilerGenerated]
				set
				{
					this.int_0 = value;
				}
			}

			// Token: 0x170005D0 RID: 1488
			// (get) Token: 0x060029D2 RID: 10706 RVA: 0x000B42D4 File Offset: 0x000B24D4
			// (set) Token: 0x060029D3 RID: 10707 RVA: 0x000B42DC File Offset: 0x000B24DC
			public string Name
			{
				[CompilerGenerated]
				get
				{
					return this.string_0;
				}
				[CompilerGenerated]
				set
				{
					this.string_0 = value;
				}
			}

			// Token: 0x170005D1 RID: 1489
			// (get) Token: 0x060029D4 RID: 10708 RVA: 0x000B42E8 File Offset: 0x000B24E8
			// (set) Token: 0x060029D5 RID: 10709 RVA: 0x000B42F0 File Offset: 0x000B24F0
			public string Guid
			{
				[CompilerGenerated]
				get
				{
					return this.string_1;
				}
				[CompilerGenerated]
				set
				{
					this.string_1 = value;
				}
			}

			// Token: 0x170005D2 RID: 1490
			// (get) Token: 0x060029D6 RID: 10710 RVA: 0x000B42FC File Offset: 0x000B24FC
			// (set) Token: 0x060029D7 RID: 10711 RVA: 0x000B4304 File Offset: 0x000B2504
			public bool IsActive
			{
				[CompilerGenerated]
				get
				{
					return this.bool_0;
				}
				[CompilerGenerated]
				set
				{
					this.bool_0 = value;
				}
			}

			// Token: 0x170005D3 RID: 1491
			// (get) Token: 0x060029D8 RID: 10712 RVA: 0x000B4310 File Offset: 0x000B2510
			// (set) Token: 0x060029D9 RID: 10713 RVA: 0x000B4318 File Offset: 0x000B2518
			public string Status
			{
				get
				{
					return this.string_2;
				}
				set
				{
					this.string_2 = value;
					this.vmethod_0("Status");
				}
			}

			// Token: 0x170005D4 RID: 1492
			// (get) Token: 0x060029DA RID: 10714 RVA: 0x000B432C File Offset: 0x000B252C
			// (set) Token: 0x060029DB RID: 10715 RVA: 0x000B4334 File Offset: 0x000B2534
			public SolidColorBrush StatusColor
			{
				get
				{
					return this.solidColorBrush_0;
				}
				set
				{
					this.solidColorBrush_0 = value;
					this.vmethod_0("StatusColor");
				}
			}

			// Token: 0x170005D5 RID: 1493
			// (get) Token: 0x060029DC RID: 10716 RVA: 0x000B4348 File Offset: 0x000B2548
			// (set) Token: 0x060029DD RID: 10717 RVA: 0x000B4350 File Offset: 0x000B2550
			public double StatusOpacity
			{
				get
				{
					return this.double_0;
				}
				set
				{
					this.double_0 = value;
					this.vmethod_0("StatusOpacity");
				}
			}

			// Token: 0x14000007 RID: 7
			// (add) Token: 0x060029DE RID: 10718 RVA: 0x000B4364 File Offset: 0x000B2564
			// (remove) Token: 0x060029DF RID: 10719 RVA: 0x000B439C File Offset: 0x000B259C
			public event PropertyChangedEventHandler PropertyChanged
			{
				[CompilerGenerated]
				add
				{
					PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
					PropertyChangedEventHandler propertyChangedEventHandler2;
					do
					{
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
					}
					while (propertyChangedEventHandler != propertyChangedEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
					PropertyChangedEventHandler propertyChangedEventHandler2;
					do
					{
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
					}
					while (propertyChangedEventHandler != propertyChangedEventHandler2);
				}
			}

			// Token: 0x060029E0 RID: 10720 RVA: 0x000B43D4 File Offset: 0x000B25D4
			protected void vmethod_0([CallerMemberName] string string_3)
			{
				if (this.propertyChangedEventHandler_0 != null)
				{
					this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(string_3));
				}
			}

			// Token: 0x04001FCE RID: 8142
			private int int_0;

			// Token: 0x04001FCF RID: 8143
			private string string_0;

			// Token: 0x04001FD0 RID: 8144
			private string string_1;

			// Token: 0x04001FD1 RID: 8145
			private bool bool_0;

			// Token: 0x04001FD2 RID: 8146
			private string string_2;

			// Token: 0x04001FD3 RID: 8147
			private SolidColorBrush solidColorBrush_0;

			// Token: 0x04001FD4 RID: 8148
			private double double_0;

			// Token: 0x04001FD5 RID: 8149
			private PropertyChangedEventHandler propertyChangedEventHandler_0;
		}

		// Token: 0x020007F6 RID: 2038
		private sealed class Class845
		{
			// Token: 0x060029E2 RID: 10722 RVA: 0x000B43F8 File Offset: 0x000B25F8
			internal Task method_0()
			{
				dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class845.Struct570 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class845_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class845.Struct570>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x04001FD6 RID: 8150
			public dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GClass230 gclass230_0;

			// Token: 0x04001FD7 RID: 8151
			public string string_0;

			// Token: 0x04001FD8 RID: 8152
			public SolidColorBrush solidColorBrush_0;

			// Token: 0x020007F7 RID: 2039
			[StructLayout(LayoutKind.Auto)]
			private struct Struct570 : IAsyncStateMachine
			{
				// Token: 0x060029E3 RID: 10723 RVA: 0x000B443C File Offset: 0x000B263C
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class845 @class = this.class845_0;
					try
					{
						TaskAwaiter awaiter;
						if (num == 0)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_10B;
						}
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_178;
						}
						IL_1D:
						if (@class.gclass230_0.StatusOpacity == 0.0)
						{
							if (@class.string_0 != null)
							{
								@class.gclass230_0.Status = @class.string_0;
							}
							@class.gclass230_0.StatusColor = @class.solidColorBrush_0;
							goto IL_17F;
						}
						@class.gclass230_0.StatusOpacity -= 0.1;
						if (@class.gclass230_0.StatusOpacity < 0.05)
						{
							@class.gclass230_0.StatusOpacity = 0.0;
						}
						awaiter = Task.Delay(10).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class845.Struct570>(ref awaiter, ref this);
							return;
						}
						IL_10B:
						awaiter.GetResult();
						goto IL_1D;
						IL_178:
						awaiter.GetResult();
						IL_17F:
						if (@class.gclass230_0.StatusOpacity != 1.0)
						{
							@class.gclass230_0.StatusOpacity += 0.13333333333333333;
							if (@class.gclass230_0.StatusOpacity > 0.95)
							{
								@class.gclass230_0.StatusOpacity = 1.0;
							}
							awaiter = Task.Delay(10).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_178;
							}
							this.int_0 = 1;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class845.Struct570>(ref awaiter, ref this);
							return;
						}
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetResult();
				}

				// Token: 0x060029E4 RID: 10724 RVA: 0x000B4678 File Offset: 0x000B2878
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x04001FD9 RID: 8153
				public int int_0;

				// Token: 0x04001FDA RID: 8154
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x04001FDB RID: 8155
				public dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class845 class845_0;

				// Token: 0x04001FDC RID: 8156
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x020007F8 RID: 2040
		private sealed class Class846
		{
			// Token: 0x060029E6 RID: 10726 RVA: 0x000B4690 File Offset: 0x000B2890
			internal void method_0()
			{
				this.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0.itemsControl_0.Items.Clear();
			}

			// Token: 0x060029E7 RID: 10727 RVA: 0x000B46A8 File Offset: 0x000B28A8
			internal void method_1(Guid guid_0)
			{
				dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class847 @class = new dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class847();
				@class.class846_0 = this;
				@class.guid_0 = guid_0;
				this.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0.Dispatcher.Invoke(new Action(@class.method_0));
			}

			// Token: 0x04001FDD RID: 8157
			public dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0;

			// Token: 0x04001FDE RID: 8158
			public int int_0;

			// Token: 0x04001FDF RID: 8159
			public string string_0;
		}

		// Token: 0x020007F9 RID: 2041
		[StructLayout(LayoutKind.Auto)]
		private struct Struct571 : IAsyncStateMachine
		{
			// Token: 0x060029E8 RID: 10728 RVA: 0x000B46E8 File Offset: 0x000B28E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd = this.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						Button button = this.object_0 as Button;
						dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0 = (dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GClass230)dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.itemsControl_0.Items[Convert.ToInt32(button.Tag)];
						if (!dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0.IsActive)
						{
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_9("ADDORDELETEPOWERSCHEME");
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.string_1 = dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0.Guid;
							dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.method_7(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0, Class364.smethod_0("willbesetactivescheme"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_1(true);
							IEnumerator enumerator = ((IEnumerable)dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.itemsControl_0.Items).GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									object obj = enumerator.Current;
									dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GClass230 gclass = (dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GClass230)obj;
									if (dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0 != gclass)
									{
										dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.method_7(gclass, string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									IDisposable disposable = enumerator as IDisposable;
									if (disposable != null)
									{
										disposable.Dispose();
									}
								}
							}
							GClass93.smethod_0().method_10();
							goto IL_1CE;
						}
						dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.method_7(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0, Class364.smethod_0("alreadyactive"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct571>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
					dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.method_7(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0, Class364.smethod_0("activescheme"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1CE:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060029E9 RID: 10729 RVA: 0x000B490C File Offset: 0x000B2B0C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FE0 RID: 8160
			public int int_0;

			// Token: 0x04001FE1 RID: 8161
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001FE2 RID: 8162
			public object object_0;

			// Token: 0x04001FE3 RID: 8163
			public dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0;

			// Token: 0x04001FE4 RID: 8164
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007FA RID: 2042
		private sealed class Class847
		{
			// Token: 0x060029EB RID: 10731 RVA: 0x000B4924 File Offset: 0x000B2B24
			internal void method_0()
			{
				dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GClass230 gclass = new dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GClass230();
				int int_ = this.class846_0.int_0;
				this.class846_0.int_0 = int_ + 1;
				gclass.ID = int_;
				gclass.Name = GClass76.smethod_3(this.guid_0);
				gclass.Guid = this.guid_0.ToString();
				gclass.Status = ((this.guid_0.ToString().ToLower() == this.class846_0.string_0) ? Class364.smethod_0("activescheme") : string.Empty);
				gclass.IsActive = (this.guid_0.ToString().ToLower() == this.class846_0.string_0);
				gclass.StatusOpacity = 0.0;
				gclass.StatusColor = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;
				dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GClass230 gclass2 = gclass;
				this.class846_0.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0.itemsControl_0.Items.Add(gclass2);
				this.class846_0.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0.method_7(gclass2, null, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}

			// Token: 0x04001FE5 RID: 8165
			public Guid guid_0;

			// Token: 0x04001FE6 RID: 8166
			public dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Class846 class846_0;
		}

		// Token: 0x020007FB RID: 2043
		[StructLayout(LayoutKind.Auto)]
		private struct Struct572 : IAsyncStateMachine
		{
			// Token: 0x060029EC RID: 10732 RVA: 0x000B4A40 File Offset: 0x000B2C40
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd = this.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num != 0)
					{
						dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.button_3.IsEnabled = false;
						dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.DataContext = null;
						awaiter = Class588.smethod_2(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GetType(), this.bool_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct572>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						this.int_0 = -1;
					}
					ObservableCollection<Class745> result = awaiter.GetResult();
					dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.SettingItemsCollectionView = CollectionViewSource.GetDefaultView(result);
					if (!dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.bool_1)
					{
						dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.bool_1 = true;
						dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.SettingItemsCollectionView.GroupDescriptions.Add(new PropertyGroupDescription("GroupName"));
						dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.SettingItemsCollectionView.SortDescriptions.Add(new SortDescription("GroupName", ListSortDirection.Ascending));
					}
					dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.DataContext = dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.SettingItemsCollectionView;
					dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.button_3.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060029ED RID: 10733 RVA: 0x000B4B80 File Offset: 0x000B2D80
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FE7 RID: 8167
			public int int_0;

			// Token: 0x04001FE8 RID: 8168
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001FE9 RID: 8169
			public dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0;

			// Token: 0x04001FEA RID: 8170
			public bool bool_0;

			// Token: 0x04001FEB RID: 8171
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
		}

		// Token: 0x020007FC RID: 2044
		[StructLayout(LayoutKind.Auto)]
		private struct Struct573 : IAsyncStateMachine
		{
			// Token: 0x060029EE RID: 10734 RVA: 0x000B4B90 File Offset: 0x000B2D90
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd = this.dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						Button button = this.object_0 as Button;
						dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0 = (dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.GClass230)dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.itemsControl_0.Items[Convert.ToInt32(button.Tag)];
						if (!dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0.IsActive)
						{
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_9("ADDORDELETEPOWERSCHEME");
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_2.Add(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0.Guid);
							dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.method_7(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0, Class364.smethod_0("willbedeleted"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
							dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_1(true);
							GClass93.smethod_0().method_10();
							goto IL_15E;
						}
						dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.method_7(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0, Class364.smethod_0("cantdeleteactive"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.Struct573>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.method_7(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd.gclass230_0, Class364.smethod_0("activescheme"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_15E:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060029EF RID: 10735 RVA: 0x000B4D2C File Offset: 0x000B2F2C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FEC RID: 8172
			public int int_0;

			// Token: 0x04001FED RID: 8173
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001FEE RID: 8174
			public object object_0;

			// Token: 0x04001FEF RID: 8175
			public dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd_0;

			// Token: 0x04001FF0 RID: 8176
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
