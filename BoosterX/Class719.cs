using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Newtonsoft.Json;
using ns0;

// Token: 0x02000196 RID: 406
internal sealed class Class719 : GClass211
{
	// Token: 0x06000A3D RID: 2621 RVA: 0x0002EA6C File Offset: 0x0002CC6C
	public Class719()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		Class755 @class = Class358.smethod_0().list_2.FirstOrDefault(new Func<Page, bool>(Class719.Class227.class227_0.method_0)).DataContext as Class755;
		this.class734_0 = @class.ChoosenForImport;
		this.ProfileName = this.class734_0.Name;
		this.method_2();
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x0002EB1C File Offset: 0x0002CD1C
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("ColChanged");
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0002EB2C File Offset: 0x0002CD2C
	// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0002EB34 File Offset: 0x0002CD34
	public ObservableCollection<Class746> Pages
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("Pages");
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0002EB48 File Offset: 0x0002CD48
	// (set) Token: 0x06000A42 RID: 2626 RVA: 0x0002EB50 File Offset: 0x0002CD50
	public string ProfileName
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("ProfileName");
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000A43 RID: 2627 RVA: 0x0002EB64 File Offset: 0x0002CD64
	// (set) Token: 0x06000A44 RID: 2628 RVA: 0x0002EB6C File Offset: 0x0002CD6C
	public Visibility ButtonsVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("ButtonsVisibility");
		}
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x0002EB80 File Offset: 0x0002CD80
	private void method_1()
	{
		foreach (Class746 @class in this.Pages)
		{
			if (@class.type_0 != null && !@class.ToApply)
			{
				@class.class610_0.method_2()();
			}
			if (@class.Name == Class364.smethod_0("import") && !@class.ToApply)
			{
				Class178.dictionary_0.Remove(Class364.smethod_0("import") + " " + @class.Desc);
			}
			if (@class.bool_0 && !@class.ToApply)
			{
				Class178.dictionary_0.Remove(Class364.smethod_0("storexins5") + " " + @class.Name);
			}
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0002EC6C File Offset: 0x0002CE6C
	public GClass134 ApplyCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_13), null));
			}
			return result;
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0002ECA0 File Offset: 0x0002CEA0
	public GClass134 MoveToOptimizationPage
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_1) == null)
			{
				result = (this.gclass134_1 = new GClass134(new Action<object>(this.method_14), null));
			}
			return result;
		}
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x0002ECD4 File Offset: 0x0002CED4
	private void method_2()
	{
		Class719.Struct90 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class719_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class719.Struct90>(ref @struct);
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x0002ED0C File Offset: 0x0002CF0C
	private void method_3()
	{
		Class719.Class231 @class = new Class719.Class231();
		@class.class719_0 = this;
		try
		{
			if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_3 && this.class734_0.byte_0 != null && this.class734_0.byte_0.Count<byte>() != 0)
			{
				@class.gclass222_0 = Class451.smethod_0(false);
				@class.string_0 = Path.Combine(Class186.string_4, "NvidiaBackUp.nvx");
				File.WriteAllBytes(@class.string_0, this.class734_0.byte_0);
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			}
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
	private Task method_4()
	{
		Class719.Struct89 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class719_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class719.Struct89>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x0002EDFC File Offset: 0x0002CFFC
	private Task method_5()
	{
		Class719.Struct81 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class719_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class719.Struct81>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x0002EE40 File Offset: 0x0002D040
	private Task method_6()
	{
		Class719.Struct82 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class719_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class719.Struct82>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x0002EE84 File Offset: 0x0002D084
	private Task method_7()
	{
		Class719.Struct84 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class719_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class719.Struct84>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x0002EEC8 File Offset: 0x0002D0C8
	private Task method_8()
	{
		Class719.Struct87 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class719_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class719.Struct87>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x0002EF0C File Offset: 0x0002D10C
	private Task method_9(List<Class188> list_0)
	{
		Class719.Struct86 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class719_0 = this;
		@struct.list_0 = list_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class719.Struct86>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x0002EF58 File Offset: 0x0002D158
	private Task method_10(Type type_0, List<Class188> list_0)
	{
		Class719.Struct85 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class719_0 = this;
		@struct.type_0 = type_0;
		@struct.list_0 = list_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class719.Struct85>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x0002EFAC File Offset: 0x0002D1AC
	private void method_11(string string_2)
	{
		Class719.Class234 @class = new Class719.Class234();
		@class.class719_0 = this;
		try
		{
			@class.class571_0 = JsonConvert.DeserializeObject<Class571>(string_2);
			if (!(@class.class571_0.Name == "PowerX v2") && !(@class.class571_0.Guid == "66666666-6666-6666-6666-666666666666"))
			{
				@class.string_0 = Path.Combine(Class186.string_4, "PowerPlan.pow");
				File.WriteAllBytes(@class.string_0, @class.class571_0.Data.smethod_1());
				if (Class178.dictionary_0.Count<KeyValuePair<string, Action>>() > 0 && Class178.dictionary_0.ContainsKey(Class364.smethod_0("import") + " " + @class.class571_0.Name))
				{
					Class178.dictionary_0.Remove(Class364.smethod_0("import") + " " + @class.class571_0.Name);
				}
				Class178.dictionary_0.Add(Class364.smethod_0("import") + " " + @class.class571_0.Name, new Action(@class.method_0));
				Application.Current.Dispatcher.Invoke(new Action(@class.method_1));
			}
		}
		catch (Exception exception_)
		{
			GClass141.smethod_0(exception_);
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0002F110 File Offset: 0x0002D310
	// (set) Token: 0x06000A53 RID: 2643 RVA: 0x0002F118 File Offset: 0x0002D318
	public string StatusText
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0002F12C File Offset: 0x0002D32C
	// (set) Token: 0x06000A55 RID: 2645 RVA: 0x0002F134 File Offset: 0x0002D334
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("StatusColor");
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0002F148 File Offset: 0x0002D348
	// (set) Token: 0x06000A57 RID: 2647 RVA: 0x0002F150 File Offset: 0x0002D350
	public double StatusOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x0002F164 File Offset: 0x0002D364
	private void method_12(string string_2, SolidColorBrush solidColorBrush_1)
	{
		Class719.Struct91 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class719_0 = this;
		@struct.string_0 = string_2;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class719.Struct91>(ref @struct);
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x0002F1AC File Offset: 0x0002D3AC
	private void method_13(object object_0)
	{
		this.method_1();
		Class358.smethod_0().method_3(typeof(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd), Class358.smethod_0().frame_0);
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x0002F1D4 File Offset: 0x0002D3D4
	private void method_14(object object_0)
	{
		this.method_1();
		Class334.bool_0 = true;
		((dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)Window.GetWindow(Class358.smethod_0().list_2.First(new Func<Page, bool>(Class719.Class227.class227_0.method_1)))).radioButton_1.IsChecked = new bool?(true);
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x0002F238 File Offset: 0x0002D438
	private Task method_15()
	{
		Class719.Struct88 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class719_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class719.Struct88>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x0002F27C File Offset: 0x0002D47C
	private void method_16()
	{
		this.Pages.Add(new Class746(typeof(dje_zS47NUGZB4NMDHDGFGZN8R6MZM9NXFQ3K7AD9N3J337SRQSQ3LVXE3ZYYK6XA_ejd), null, string.Empty, string.Empty, false));
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x0002F2A4 File Offset: 0x0002D4A4
	private void method_17()
	{
		this.Pages.Add(new Class746(typeof(dje_zEAHJHJCF7YEVQXCTVJ6ZYLNYMV3GV7DXZT4HM29Y3NNNKUR5WQZEF_ejd), null, string.Empty, string.Empty, false));
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x0002F2CC File Offset: 0x0002D4CC
	private void method_18()
	{
		this.Pages.Add(new Class746(typeof(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd), null, string.Empty, string.Empty, false));
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x0002F2F4 File Offset: 0x0002D4F4
	internal static void smethod_0(ObservableCollection<Class720> observableCollection_1, ref Class719.Struct83 struct83_0)
	{
		using (IEnumerator<Class720> enumerator = observableCollection_1.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class719.Class222 @class = new Class719.Class222();
				@class.class720_0 = enumerator.Current;
				using (List<Class188>.Enumerator enumerator2 = struct83_0.list_0.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Class719.Class236 class2 = new Class719.Class236();
						class2.class222_0 = @class;
						class2.class188_0 = enumerator2.Current;
						if (class2.class188_0.Name.smethod_5() == class2.class222_0.class720_0.NameClean)
						{
							Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
						}
					}
				}
			}
		}
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x0002F3E4 File Offset: 0x0002D5E4
	private void method_19()
	{
		this.Pages.Add(new Class746(typeof(dje_z8NYEPSSJS77QLDRYJP4YDHXMCCZX642R76WUWAX6XD7EC3JPH2Y7TCVK5HRQ_ejd), null, string.Empty, string.Empty, false));
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x0002F40C File Offset: 0x0002D60C
	private void method_20()
	{
		this.Pages.Add(new Class746(typeof(dje_z6JL2QS9NKMEDHKNVWM827E49NK7EF3D5UTLX2SWMV25WYRC4KN7KK6TB245Q_ejd), null, string.Empty, string.Empty, false));
	}

	// Token: 0x04000606 RID: 1542
	private Class734 class734_0;

	// Token: 0x04000607 RID: 1543
	private ObservableCollection<Class746> observableCollection_0 = new ObservableCollection<Class746>();

	// Token: 0x04000608 RID: 1544
	private string string_0;

	// Token: 0x04000609 RID: 1545
	private Visibility visibility_0 = Visibility.Collapsed;

	// Token: 0x0400060A RID: 1546
	private GClass134 gclass134_0;

	// Token: 0x0400060B RID: 1547
	private GClass134 gclass134_1;

	// Token: 0x0400060C RID: 1548
	private string string_1 = string.Empty;

	// Token: 0x0400060D RID: 1549
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x0400060E RID: 1550
	private double double_0;

	// Token: 0x02000197 RID: 407
	private sealed class Class216
	{
		// Token: 0x0400060F RID: 1551
		public Class745 class745_0;
	}

	// Token: 0x02000198 RID: 408
	private sealed class Class217
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x0002F444 File Offset: 0x0002D644
		internal void method_0()
		{
			string state = this.class188_0.State;
			if (state == "DEFAULT")
			{
				this.class216_0.class745_0.method_16();
				return;
			}
			if (state == "BEST")
			{
				this.class216_0.class745_0.method_14();
				return;
			}
			if (!(state == "OPTIMAL"))
			{
				this.class216_0.class745_0.CustomValue = this.class188_0.State;
				return;
			}
			this.class216_0.class745_0.method_15();
		}

		// Token: 0x04000610 RID: 1552
		public Class188 class188_0;

		// Token: 0x04000611 RID: 1553
		public Class719.Class216 class216_0;
	}

	// Token: 0x02000199 RID: 409
	[StructLayout(LayoutKind.Auto)]
	private struct Struct81 : IAsyncStateMachine
	{
		// Token: 0x06000A65 RID: 2661 RVA: 0x0002F4D4 File Offset: 0x0002D6D4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class719 @class = this.class719_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (@class.class734_0.class660_0.method_0(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Affinity, "ThreadsCount") == null && @class.class734_0.class660_0.method_0(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Affinity, "ThreadsCount").State != Class389.class504_0.method_60())
						{
							goto IL_22A;
						}
						this.class760_0 = Class683.smethod_1(false);
						awaiter = Class683.smethod_7().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct81>(ref awaiter, ref this);
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
					List<Class188> list = @class.class734_0.class660_0.method_1(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Service);
					if (list != null)
					{
						List<GClass151>.Enumerator enumerator = this.class760_0.AllServices.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Class719.Class232 class2 = new Class719.Class232();
								class2.gclass151_0 = enumerator.Current;
								List<Class188>.Enumerator enumerator2 = list.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										Class188 class3 = enumerator2.Current;
										if (class3.Name.ToLower() == class2.gclass151_0.ServiceName.ToLower())
										{
											Class719.Class219 class4 = new Class719.Class219();
											class4.class232_0 = class2;
											class4.serviceStartMode_0 = GClass188.smethod_2(class3.State);
											Application.Current.Dispatcher.Invoke(new Action(class4.method_0));
										}
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						Application.Current.Dispatcher.Invoke(new Action(@class.method_16));
						this.class760_0 = null;
					}
				}
				catch (Exception exception_)
				{
					GClass141.smethod_0(exception_);
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_22A:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0002F784 File Offset: 0x0002D984
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000612 RID: 1554
		public int int_0;

		// Token: 0x04000613 RID: 1555
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000614 RID: 1556
		public Class719 class719_0;

		// Token: 0x04000615 RID: 1557
		private Class683.Class760 class760_0;

		// Token: 0x04000616 RID: 1558
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200019A RID: 410
	private sealed class Class218
	{
		// Token: 0x06000A68 RID: 2664 RVA: 0x0002F79C File Offset: 0x0002D99C
		internal void method_0()
		{
			CancellationToken token = new CancellationTokenSource().Token;
			Class426.smethod_4(this.class754_0, null, token).Wait();
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0002F7C8 File Offset: 0x0002D9C8
		internal void method_1()
		{
			this.class235_0.class237_0.class719_0.Pages.Add(new Class746(null, Class397.smethod_0(this.class754_0.AppXIcon), this.class754_0.AppXName, string.Empty, true));
		}

		// Token: 0x04000617 RID: 1559
		public Class754 class754_0;

		// Token: 0x04000618 RID: 1560
		public Class719.Class235 class235_0;
	}

	// Token: 0x0200019B RID: 411
	private sealed class Class219
	{
		// Token: 0x06000A6B RID: 2667 RVA: 0x0002F820 File Offset: 0x0002DA20
		internal void method_0()
		{
			this.class232_0.gclass151_0.WinServiceViewModel.NewStartMode = this.serviceStartMode_0;
		}

		// Token: 0x04000619 RID: 1561
		public ServiceStartMode serviceStartMode_0;

		// Token: 0x0400061A RID: 1562
		public Class719.Class232 class232_0;
	}

	// Token: 0x0200019C RID: 412
	[StructLayout(LayoutKind.Auto)]
	private struct Struct82 : IAsyncStateMachine
	{
		// Token: 0x06000A6C RID: 2668 RVA: 0x0002F840 File Offset: 0x0002DA40
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class719 @class = this.class719_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.gclass223_0 = GClass161.smethod_0(false);
						awaiter = GClass161.smethod_5().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct82>(ref awaiter, ref this);
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
					List<Class188> list = @class.class734_0.class660_0.method_1(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.DevicesMSI);
					List<Class188> list2 = @class.class734_0.class660_0.method_1(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.DevicesDisabled);
					List<Class188> list3 = @class.class734_0.class660_0.method_1(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.DevicesGroupDisabled);
					IEnumerator<GClass221> enumerator = this.gclass223_0.MsiSupportedDevices.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class719.Class223 class2 = new Class719.Class223();
							class2.gclass221_0 = enumerator.Current;
							if (list != null)
							{
								List<Class188>.Enumerator enumerator2 = list.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										Class719.Class230 class3 = new Class719.Class230();
										class3.class223_0 = class2;
										class3.class188_0 = enumerator2.Current;
										if (class3.class188_0.Name == class3.class223_0.gclass221_0.Name)
										{
											Application.Current.Dispatcher.Invoke(new Action(class3.method_0));
										}
									}
									continue;
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
							goto IL_3CD;
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					enumerator = this.gclass223_0.CanBeDisabled.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class719.Class228 class4 = new Class719.Class228();
							class4.gclass221_0 = enumerator.Current;
							if (list2 != null)
							{
								List<Class188>.Enumerator enumerator2 = list2.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										Class719.Class238 class5 = new Class719.Class238();
										class5.class228_0 = class4;
										class5.class188_0 = enumerator2.Current;
										if (class5.class188_0.Name == class5.class228_0.gclass221_0.Name)
										{
											Application.Current.Dispatcher.Invoke(new Action(class5.method_0));
										}
									}
									continue;
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
							goto IL_3CD;
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					IEnumerator<GClass226> enumerator3 = this.gclass223_0.CustomDisableDevices.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							Class719.Class226 class6 = new Class719.Class226();
							class6.gclass226_0 = enumerator3.Current;
							if (list3 != null)
							{
								List<Class188>.Enumerator enumerator2 = list3.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										Class719.Class220 class7 = new Class719.Class220();
										class7.class226_0 = class6;
										class7.class188_0 = enumerator2.Current;
										if (class7.class188_0.Name == class7.class226_0.gclass226_0.Name)
										{
											Application.Current.Dispatcher.Invoke(new Action(class7.method_0));
										}
									}
									continue;
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
							goto IL_3CD;
						}
					}
					finally
					{
						if (num < 0 && enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
					Application.Current.Dispatcher.Invoke(new Action(@class.method_17));
					this.gclass223_0 = null;
				}
				catch (Exception exception_)
				{
					GClass141.smethod_0(exception_);
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_3CD:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0002FCF4 File Offset: 0x0002DEF4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400061B RID: 1563
		public int int_0;

		// Token: 0x0400061C RID: 1564
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400061D RID: 1565
		public Class719 class719_0;

		// Token: 0x0400061E RID: 1566
		private GClass161.GClass223 gclass223_0;

		// Token: 0x0400061F RID: 1567
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200019D RID: 413
	private sealed class Class220
	{
		// Token: 0x06000A6F RID: 2671 RVA: 0x0002FD0C File Offset: 0x0002DF0C
		internal void method_0()
		{
			this.class226_0.gclass226_0.IsDisabled = new bool?(Convert.ToBoolean(this.class188_0.State));
		}

		// Token: 0x04000620 RID: 1568
		public Class188 class188_0;

		// Token: 0x04000621 RID: 1569
		public Class719.Class226 class226_0;
	}

	// Token: 0x0200019E RID: 414
	private sealed class Class221
	{
		// Token: 0x04000622 RID: 1570
		public Class745 class745_0;
	}

	// Token: 0x0200019F RID: 415
	private sealed class Class222
	{
		// Token: 0x04000623 RID: 1571
		public Class720 class720_0;
	}

	// Token: 0x020001A0 RID: 416
	[StructLayout(LayoutKind.Auto)]
	private struct Struct83
	{
		// Token: 0x04000624 RID: 1572
		public List<Class188> list_0;
	}

	// Token: 0x020001A1 RID: 417
	[StructLayout(LayoutKind.Auto)]
	private struct Struct84 : IAsyncStateMachine
	{
		// Token: 0x06000A72 RID: 2674 RVA: 0x0002FD44 File Offset: 0x0002DF44
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class719 @class = this.class719_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (@class.class734_0.class660_0.method_1(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Affinity) == null)
						{
							goto IL_229;
						}
						if (@class.class734_0.class660_0.method_0(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Affinity, "ThreadsCount") == null && @class.class734_0.class660_0.method_0(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Affinity, "ThreadsCount").State != Class389.class504_0.method_60())
						{
							goto IL_229;
						}
						this.class744_0 = Class310.smethod_0(false);
						awaiter = Class310.smethod_4().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct84>(ref awaiter, ref this);
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
					List<Class188> list = @class.class734_0.class660_0.method_1(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Affinity);
					IEnumerator<Class716> enumerator = this.class744_0.DeviceViewModels.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class719.Class224 class2 = new Class719.Class224();
							class2.class716_0 = enumerator.Current;
							List<Class188>.Enumerator enumerator2 = list.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									Class719.Class241 class3 = new Class719.Class241();
									class3.class224_0 = class2;
									class3.class188_0 = enumerator2.Current;
									if (class3.class188_0.Name == class3.class224_0.class716_0.Name)
									{
										Application.Current.Dispatcher.Invoke(new Action(class3.method_0));
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator2).Dispose();
								}
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					Application.Current.Dispatcher.Invoke(new Action(@class.method_18));
					this.class744_0 = null;
				}
				catch (Exception exception_)
				{
					GClass141.smethod_0(exception_);
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_229:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0002FFF4 File Offset: 0x0002E1F4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000625 RID: 1573
		public int int_0;

		// Token: 0x04000626 RID: 1574
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000627 RID: 1575
		public Class719 class719_0;

		// Token: 0x04000628 RID: 1576
		private Class744 class744_0;

		// Token: 0x04000629 RID: 1577
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001A2 RID: 418
	private sealed class Class223
	{
		// Token: 0x0400062A RID: 1578
		public GClass221 gclass221_0;
	}

	// Token: 0x020001A3 RID: 419
	private sealed class Class224
	{
		// Token: 0x0400062B RID: 1579
		public Class716 class716_0;
	}

	// Token: 0x020001A4 RID: 420
	private sealed class Class225
	{
		// Token: 0x06000A77 RID: 2679 RVA: 0x0003001C File Offset: 0x0002E21C
		internal void method_0()
		{
			string state = this.class188_0.State;
			if (state == "DEFAULT")
			{
				this.class233_0.class745_0.method_16();
				return;
			}
			if (state == "BEST")
			{
				this.class233_0.class745_0.method_14();
				return;
			}
			if (!(state == "OPTIMAL"))
			{
				this.class233_0.class745_0.CustomValue = this.class188_0.State;
				return;
			}
			this.class233_0.class745_0.method_15();
		}

		// Token: 0x0400062C RID: 1580
		public Class188 class188_0;

		// Token: 0x0400062D RID: 1581
		public Class719.Class233 class233_0;
	}

	// Token: 0x020001A5 RID: 421
	private sealed class Class226
	{
		// Token: 0x0400062E RID: 1582
		public GClass226 gclass226_0;
	}

	// Token: 0x020001A6 RID: 422
	[StructLayout(LayoutKind.Auto)]
	private struct Struct85 : IAsyncStateMachine
	{
		// Token: 0x06000A79 RID: 2681 RVA: 0x000300B4 File Offset: 0x0002E2B4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<ObservableCollection<Class745>> awaiter;
				if (num != 0)
				{
					this.class239_0 = new Class719.Class239();
					this.class239_0.class719_0 = this.class719_0;
					this.class239_0.type_0 = this.type_0;
					awaiter = Class588.smethod_2(this.class239_0.type_0, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class719.Struct85>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				IEnumerator<Class745> enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class719.Class216 @class = new Class719.Class216();
						@class.class745_0 = enumerator.Current;
						List<Class188>.Enumerator enumerator2 = this.list_0.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								Class719.Class217 class2 = new Class719.Class217();
								class2.class216_0 = @class;
								class2.class188_0 = enumerator2.Current;
								if (class2.class188_0.Name == class2.class216_0.class745_0.NameRaw)
								{
									Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator2).Dispose();
							}
						}
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				Application.Current.Dispatcher.Invoke(new Action(this.class239_0.method_0));
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class239_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class239_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x000302E8 File Offset: 0x0002E4E8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400062F RID: 1583
		public int int_0;

		// Token: 0x04000630 RID: 1584
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000631 RID: 1585
		public Class719 class719_0;

		// Token: 0x04000632 RID: 1586
		public Type type_0;

		// Token: 0x04000633 RID: 1587
		public List<Class188> list_0;

		// Token: 0x04000634 RID: 1588
		private Class719.Class239 class239_0;

		// Token: 0x04000635 RID: 1589
		private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
	}

	// Token: 0x020001A7 RID: 423
	[Serializable]
	private sealed class Class227
	{
		// Token: 0x06000A7D RID: 2685 RVA: 0x0003030C File Offset: 0x0002E50C
		internal bool method_0(Page page_0)
		{
			return page_0.GetType() == typeof(dje_zS47NUGZB4NMDHDGFGZN8R6MZMSTZC22PP5QJMCVY7U78FP549R6VZ_ejd);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00030324 File Offset: 0x0002E524
		internal bool method_1(Page page_0)
		{
			return page_0.GetType() == typeof(dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd);
		}

		// Token: 0x04000636 RID: 1590
		public static readonly Class719.Class227 class227_0 = new Class719.Class227();

		// Token: 0x04000637 RID: 1591
		public static Func<Page, bool> func_0;

		// Token: 0x04000638 RID: 1592
		public static Func<Page, bool> func_1;
	}

	// Token: 0x020001A8 RID: 424
	private sealed class Class228
	{
		// Token: 0x04000639 RID: 1593
		public GClass221 gclass221_0;
	}

	// Token: 0x020001A9 RID: 425
	private sealed class Class229
	{
		// Token: 0x06000A81 RID: 2689 RVA: 0x0003034C File Offset: 0x0002E54C
		internal void method_0()
		{
			string state = this.class188_0.State;
			if (state == "DEFAULT")
			{
				this.class221_0.class745_0.method_16();
				return;
			}
			if (state == "BEST")
			{
				this.class221_0.class745_0.method_14();
				return;
			}
			if (!(state == "OPTIMAL"))
			{
				this.class221_0.class745_0.CustomValue = this.class188_0.State;
				return;
			}
			this.class221_0.class745_0.method_15();
		}

		// Token: 0x0400063A RID: 1594
		public Class188 class188_0;

		// Token: 0x0400063B RID: 1595
		public Class719.Class221 class221_0;
	}

	// Token: 0x020001AA RID: 426
	[StructLayout(LayoutKind.Auto)]
	private struct Struct86 : IAsyncStateMachine
	{
		// Token: 0x06000A82 RID: 2690 RVA: 0x000303DC File Offset: 0x0002E5DC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class719 @object = this.class719_0;
			try
			{
				try
				{
					TaskAwaiter<Class718> awaiter;
					if (num != 0)
					{
						awaiter = Class271.smethod_0(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class718>, Class719.Struct86>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Class718>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					IEnumerator<Class745> enumerator = awaiter.GetResult().Tweaks.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class719.Class233 @class = new Class719.Class233();
							@class.class745_0 = enumerator.Current;
							List<Class188>.Enumerator enumerator2 = this.list_0.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									Class719.Class225 class2 = new Class719.Class225();
									class2.class233_0 = @class;
									class2.class188_0 = enumerator2.Current;
									if (class2.class188_0.Name == class2.class233_0.class745_0.NameRaw)
									{
										Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator2).Dispose();
								}
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					Application.Current.Dispatcher.Invoke(new Action(@object.method_20));
				}
				catch (Exception exception_)
				{
					GClass141.smethod_0(exception_);
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

		// Token: 0x06000A83 RID: 2691 RVA: 0x000305F8 File Offset: 0x0002E7F8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400063C RID: 1596
		public int int_0;

		// Token: 0x0400063D RID: 1597
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400063E RID: 1598
		public List<Class188> list_0;

		// Token: 0x0400063F RID: 1599
		public Class719 class719_0;

		// Token: 0x04000640 RID: 1600
		private TaskAwaiter<Class718> taskAwaiter_0;
	}

	// Token: 0x020001AB RID: 427
	private sealed class Class230
	{
		// Token: 0x06000A85 RID: 2693 RVA: 0x00030610 File Offset: 0x0002E810
		internal void method_0()
		{
			this.class223_0.gclass221_0.MsiStatus = Convert.ToBoolean(this.class188_0.State);
		}

		// Token: 0x04000641 RID: 1601
		public Class188 class188_0;

		// Token: 0x04000642 RID: 1602
		public Class719.Class223 class223_0;
	}

	// Token: 0x020001AC RID: 428
	[StructLayout(LayoutKind.Auto)]
	private struct Struct87 : IAsyncStateMachine
	{
		// Token: 0x06000A86 RID: 2694 RVA: 0x00030634 File Offset: 0x0002E834
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class719 @class = this.class719_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class161_0 = Class150.smethod_0(false);
						awaiter = Class150.smethod_5().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct87>(ref awaiter, ref this);
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
					Class719.Struct83 @struct;
					@struct.list_0 = @class.class734_0.class660_0.method_1(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Autoruns);
					if (@struct.list_0 != null)
					{
						Class719.smethod_0(this.class161_0.RegARModels, ref @struct);
						Class719.smethod_0(this.class161_0.FileARModels, ref @struct);
						Class719.smethod_0(this.class161_0.TaskARModels, ref @struct);
						Class719.smethod_0(this.class161_0.ServiceARModels, ref @struct);
						Application.Current.Dispatcher.Invoke(new Action(@class.method_19));
						this.class161_0 = null;
					}
				}
				catch (Exception exception_)
				{
					GClass141.smethod_0(exception_);
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

		// Token: 0x06000A87 RID: 2695 RVA: 0x000307B4 File Offset: 0x0002E9B4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000643 RID: 1603
		public int int_0;

		// Token: 0x04000644 RID: 1604
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000645 RID: 1605
		public Class719 class719_0;

		// Token: 0x04000646 RID: 1606
		private Class150.Class161 class161_0;

		// Token: 0x04000647 RID: 1607
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001AD RID: 429
	private sealed class Class231
	{
		// Token: 0x06000A89 RID: 2697 RVA: 0x000307CC File Offset: 0x0002E9CC
		internal void method_0()
		{
			this.gclass222_0.method_6(this.string_0);
			this.class719_0.Pages.Add(new Class746(typeof(dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd), null, string.Empty, string.Empty, false));
		}

		// Token: 0x04000648 RID: 1608
		public Class719 class719_0;

		// Token: 0x04000649 RID: 1609
		public GClass222 gclass222_0;

		// Token: 0x0400064A RID: 1610
		public string string_0;
	}

	// Token: 0x020001AE RID: 430
	private sealed class Class232
	{
		// Token: 0x0400064B RID: 1611
		public GClass151 gclass151_0;
	}

	// Token: 0x020001AF RID: 431
	[StructLayout(LayoutKind.Auto)]
	private struct Struct88 : IAsyncStateMachine
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x00030814 File Offset: 0x0002EA14
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class719 @class = this.class719_0;
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
					goto IL_1D1;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_242;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_2C5;
				default:
					awaiter = Class704.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct88>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				if (!@class.class734_0.class660_0.method_2(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Json))
				{
					goto IL_2D3;
				}
				this.list_0 = @class.class734_0.class660_0.method_1(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Json);
				awaiter = Task.WhenAll(new List<Task>
				{
					@class.method_10(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), this.list_0),
					@class.method_10(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd), this.list_0),
					@class.method_10(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd), this.list_0),
					@class.method_10(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd), this.list_0),
					@class.method_10(typeof(dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd), this.list_0),
					@class.method_8(),
					@class.method_7(),
					@class.method_6(),
					@class.method_5(),
					@class.method_9(this.list_0)
				}).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct88>(ref awaiter, ref this);
					return;
				}
				IL_1D1:
				awaiter.GetResult();
				@class.method_3();
				awaiter = @class.method_10(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd), this.list_0).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct88>(ref awaiter, ref this);
					return;
				}
				IL_242:
				awaiter.GetResult();
				try
				{
					string state = @class.class734_0.class660_0.method_0(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Power, "CurrentProfile").State;
					if (state != null)
					{
						@class.method_11(state);
					}
				}
				catch (object obj)
				{
				}
				awaiter = @class.method_4().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct88>(ref awaiter, ref this);
					return;
				}
				IL_2C5:
				awaiter.GetResult();
				this.list_0 = null;
				IL_2D3:;
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

		// Token: 0x06000A8C RID: 2700 RVA: 0x00030B58 File Offset: 0x0002ED58
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400064C RID: 1612
		public int int_0;

		// Token: 0x0400064D RID: 1613
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400064E RID: 1614
		public Class719 class719_0;

		// Token: 0x0400064F RID: 1615
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04000650 RID: 1616
		private List<Class188> list_0;
	}

	// Token: 0x020001B0 RID: 432
	private sealed class Class233
	{
		// Token: 0x04000651 RID: 1617
		public Class745 class745_0;
	}

	// Token: 0x020001B1 RID: 433
	private sealed class Class234
	{
		// Token: 0x06000A8F RID: 2703 RVA: 0x00030B78 File Offset: 0x0002ED78
		internal void method_0()
		{
			Class185.smethod_22("powercfg -import \"" + this.string_0 + "\" " + this.class571_0.Guid);
			Class185.smethod_22("powercfg -setactive " + this.class571_0.Guid);
			File.Delete(this.string_0);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00030BD0 File Offset: 0x0002EDD0
		internal void method_1()
		{
			this.class719_0.Pages.Add(new Class746(null, Class364.smethod_2("PowerSvg"), Class364.smethod_0("import"), this.class571_0.Name, false));
		}

		// Token: 0x04000652 RID: 1618
		public Class719 class719_0;

		// Token: 0x04000653 RID: 1619
		public string string_0;

		// Token: 0x04000654 RID: 1620
		public Class571 class571_0;
	}

	// Token: 0x020001B2 RID: 434
	[StructLayout(LayoutKind.Auto)]
	private struct Struct89 : IAsyncStateMachine
	{
		// Token: 0x06000A91 RID: 2705 RVA: 0x00030C08 File Offset: 0x0002EE08
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class719 @class = this.class719_0;
			try
			{
				if (num > 2)
				{
					this.class237_0 = new Class719.Class237();
					this.class237_0.class719_0 = this.class719_0;
				}
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num - 1 <= 1)
						{
							goto IL_2AF;
						}
						this.class730_0 = Class462.smethod_0(false);
						awaiter = Class462.smethod_4().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct89>(ref awaiter, ref this);
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
					this.list_0 = @class.class734_0.class660_0.method_1(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.APPX);
					List<Class188> list = @class.class734_0.class660_0.method_1(dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.APPXCustom);
					this.class237_0.int_0 = 0;
					IEnumerator<Class713> enumerator = this.class730_0.WinUwpAppsModels.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class719.Class240 class2 = new Class719.Class240();
							class2.class713_0 = enumerator.Current;
							if (this.list_0 == null)
							{
								break;
							}
							if (!this.list_0.Any(new Func<Class188, bool>(class2.method_0)))
							{
								Application.Current.Dispatcher.Invoke(new Action(class2.method_1));
								int num4 = this.class237_0.int_0;
								this.class237_0.int_0 = num4 + 1;
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					IEnumerator<Class745> enumerator2 = this.class730_0.CustomDebloatList.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							Class719.Class221 class3 = new Class719.Class221();
							class3.class745_0 = enumerator2.Current;
							if (list != null)
							{
								List<Class188>.Enumerator enumerator3 = list.GetEnumerator();
								try
								{
									while (enumerator3.MoveNext())
									{
										Class719.Class229 class4 = new Class719.Class229();
										class4.class221_0 = class3;
										class4.class188_0 = enumerator3.Current;
										if (class4.class188_0.Name == class4.class221_0.class745_0.NameRaw)
										{
											Application.Current.Dispatcher.Invoke(new Action(class4.method_0));
										}
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator3).Dispose();
									}
								}
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					Application.Current.Dispatcher.Invoke(new Action(this.class237_0.method_0));
					this.enumerator_0 = this.list_0.GetEnumerator();
					IL_2AF:
					try
					{
						TaskAwaiter<List<Class754>> awaiter2;
						if (num == 1)
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<List<Class754>>);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
							goto IL_37F;
						}
						if (num == 2)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num6 = -1;
							num = -1;
							this.int_0 = num6;
							goto IL_44E;
						}
						IL_2C2:
						if (this.enumerator_0.MoveNext())
						{
							this.class235_0 = new Class719.Class235();
							this.class235_0.class237_0 = this.class237_0;
							this.class235_0.class188_0 = this.enumerator_0.Current;
							if (this.list_0 != null)
							{
								if (this.class730_0.WinUwpAppsModels.Any(new Func<Class713, bool>(this.class235_0.method_0)))
								{
									goto IL_335;
								}
								awaiter2 = Class426.smethod_0(this.class235_0.class188_0.State, null).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num7 = 1;
									num = 1;
									this.int_0 = num7;
									this.taskAwaiter_1 = awaiter2;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class754>>, Class719.Struct89>(ref awaiter2, ref this);
									return;
								}
								goto IL_37F;
							}
						}
						goto IL_59F;
						IL_335:
						this.class235_0 = null;
						goto IL_2C2;
						IL_37F:
						List<Class754> result = awaiter2.GetResult();
						if (result != null && result.Count > 0)
						{
							this.class218_0 = new Class719.Class218();
							this.class218_0.class235_0 = this.class235_0;
							this.class218_0.class754_0 = result.First<Class754>();
							this.int_1 = 0;
							goto IL_467;
						}
						goto IL_335;
						IL_44E:
						awaiter.GetResult();
						if (this.int_1 > 500)
						{
							goto IL_5F0;
						}
						IL_467:
						if (this.class218_0.class754_0.AppXIcon != null)
						{
							if (Class178.dictionary_0.Count<KeyValuePair<string, Action>>() > 0 && Class178.dictionary_0.ContainsKey(Class364.smethod_0("storexins5") + " " + this.class218_0.class754_0.AppXName))
							{
								Class178.dictionary_0.Remove(Class364.smethod_0("storexins5") + " " + this.class218_0.class754_0.AppXName);
							}
							Class178.dictionary_0.Add(Class364.smethod_0("storexins5") + " " + this.class218_0.class754_0.AppXName, new Action(this.class218_0.method_0));
							Application.Current.Dispatcher.Invoke(new Action(this.class218_0.method_1));
							this.class218_0 = null;
							goto IL_335;
						}
						int num4 = this.int_1;
						this.int_1 = num4 + 1;
						awaiter = Task.Delay(20).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_44E;
						}
						int num8 = 2;
						num = 2;
						this.int_0 = num8;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct89>(ref awaiter, ref this);
						return;
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.enumerator_0).Dispose();
						}
					}
					IL_59F:
					this.enumerator_0 = default(List<Class188>.Enumerator);
					this.class730_0 = null;
					this.list_0 = null;
				}
				catch (Exception exception_)
				{
					GClass141.smethod_0(exception_);
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class237_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_5F0:
			this.int_0 = -2;
			this.class237_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x000312B4 File Offset: 0x0002F4B4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000655 RID: 1621
		public int int_0;

		// Token: 0x04000656 RID: 1622
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000657 RID: 1623
		public Class719 class719_0;

		// Token: 0x04000658 RID: 1624
		private Class719.Class237 class237_0;

		// Token: 0x04000659 RID: 1625
		private Class719.Class235 class235_0;

		// Token: 0x0400065A RID: 1626
		private Class719.Class218 class218_0;

		// Token: 0x0400065B RID: 1627
		private Class730 class730_0;

		// Token: 0x0400065C RID: 1628
		private List<Class188> list_0;

		// Token: 0x0400065D RID: 1629
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x0400065E RID: 1630
		private List<Class188>.Enumerator enumerator_0;

		// Token: 0x0400065F RID: 1631
		private TaskAwaiter<List<Class754>> taskAwaiter_1;

		// Token: 0x04000660 RID: 1632
		private int int_1;
	}

	// Token: 0x020001B3 RID: 435
	[StructLayout(LayoutKind.Auto)]
	private struct Struct90 : IAsyncStateMachine
	{
		// Token: 0x06000A93 RID: 2707 RVA: 0x000312C4 File Offset: 0x0002F4C4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class719 @class = this.class719_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.ButtonsVisibility = Visibility.Collapsed;
					@class.method_12(Class364.smethod_0("ReadingProfile"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					awaiter = Task.Run(new Func<Task>(@class.method_15)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct90>(ref awaiter, ref this);
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
				@class.method_12(Class364.smethod_0("BUChoose"), Brushes.White);
				@class.ButtonsVisibility = Visibility.Visible;
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

		// Token: 0x06000A94 RID: 2708 RVA: 0x000313BC File Offset: 0x0002F5BC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000661 RID: 1633
		public int int_0;

		// Token: 0x04000662 RID: 1634
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000663 RID: 1635
		public Class719 class719_0;

		// Token: 0x04000664 RID: 1636
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001B4 RID: 436
	private sealed class Class235
	{
		// Token: 0x06000A96 RID: 2710 RVA: 0x000313D4 File Offset: 0x0002F5D4
		internal bool method_0(Class713 class713_0)
		{
			return class713_0.AppxFriendlyName == this.class188_0.State;
		}

		// Token: 0x04000665 RID: 1637
		public Class188 class188_0;

		// Token: 0x04000666 RID: 1638
		public Class719.Class237 class237_0;
	}

	// Token: 0x020001B5 RID: 437
	private sealed class Class236
	{
		// Token: 0x06000A98 RID: 2712 RVA: 0x000313F4 File Offset: 0x0002F5F4
		internal void method_0()
		{
			bool flag = Convert.ToBoolean(this.class188_0.State);
			if (this.class222_0.class720_0.Status.Value != flag)
			{
				this.class222_0.class720_0.NewStatus = new bool?(flag);
			}
		}

		// Token: 0x04000667 RID: 1639
		public Class188 class188_0;

		// Token: 0x04000668 RID: 1640
		public Class719.Class222 class222_0;
	}

	// Token: 0x020001B6 RID: 438
	private sealed class Class237
	{
		// Token: 0x06000A9A RID: 2714 RVA: 0x00031450 File Offset: 0x0002F650
		internal void method_0()
		{
			this.class719_0.Pages.Add(new Class746(typeof(dje_z4EFBE23NRXT78H3EAL45CK9M5K537HLZVTED9PC5FL6WLE8YYJD3VFKL5QNA_ejd), null, string.Empty, Class364.smethod_0("willbedeleted") + " " + this.int_0.ToString(), false));
		}

		// Token: 0x04000669 RID: 1641
		public Class719 class719_0;

		// Token: 0x0400066A RID: 1642
		public int int_0;
	}

	// Token: 0x020001B7 RID: 439
	private sealed class Class238
	{
		// Token: 0x06000A9C RID: 2716 RVA: 0x000314AC File Offset: 0x0002F6AC
		internal void method_0()
		{
			this.class228_0.gclass221_0.IsEnabled = Convert.ToBoolean(this.class188_0.State);
		}

		// Token: 0x0400066B RID: 1643
		public Class188 class188_0;

		// Token: 0x0400066C RID: 1644
		public Class719.Class228 class228_0;
	}

	// Token: 0x020001B8 RID: 440
	private sealed class Class239
	{
		// Token: 0x06000A9E RID: 2718 RVA: 0x000314D8 File Offset: 0x0002F6D8
		internal void method_0()
		{
			this.class719_0.Pages.Add(new Class746(this.type_0, null, string.Empty, string.Empty, false));
		}

		// Token: 0x0400066D RID: 1645
		public Class719 class719_0;

		// Token: 0x0400066E RID: 1646
		public Type type_0;
	}

	// Token: 0x020001B9 RID: 441
	private sealed class Class240
	{
		// Token: 0x06000AA0 RID: 2720 RVA: 0x0003150C File Offset: 0x0002F70C
		internal bool method_0(Class188 class188_0)
		{
			return class188_0.State.ToLower() == this.class713_0.AppxFriendlyName.ToLower();
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00031530 File Offset: 0x0002F730
		internal void method_1()
		{
			this.class713_0.ToDelete = true;
		}

		// Token: 0x0400066F RID: 1647
		public Class713 class713_0;
	}

	// Token: 0x020001BA RID: 442
	[StructLayout(LayoutKind.Auto)]
	private struct Struct91 : IAsyncStateMachine
	{
		// Token: 0x06000AA2 RID: 2722 RVA: 0x00031540 File Offset: 0x0002F740
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class719 @class = this.class719_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_E2;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_140;
				}
				IL_1D:
				if (@class.StatusOpacity == 0.0)
				{
					@class.StatusColor = this.solidColorBrush_0;
					@class.StatusText = this.string_0;
					goto IL_147;
				}
				@class.StatusOpacity -= 0.1;
				if (@class.StatusOpacity < 0.05)
				{
					@class.StatusOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct91>(ref awaiter, ref this);
					return;
				}
				IL_E2:
				awaiter.GetResult();
				goto IL_1D;
				IL_140:
				awaiter.GetResult();
				IL_147:
				if (@class.StatusOpacity != 1.0)
				{
					@class.StatusOpacity += 0.13333333333333333;
					if (@class.StatusOpacity > 0.95)
					{
						@class.StatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_140;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class719.Struct91>(ref awaiter, ref this);
					return;
				}
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

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0003173C File Offset: 0x0002F93C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000670 RID: 1648
		public int int_0;

		// Token: 0x04000671 RID: 1649
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000672 RID: 1650
		public Class719 class719_0;

		// Token: 0x04000673 RID: 1651
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000674 RID: 1652
		public string string_0;

		// Token: 0x04000675 RID: 1653
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001BB RID: 443
	private sealed class Class241
	{
		// Token: 0x06000AA5 RID: 2725 RVA: 0x00031754 File Offset: 0x0002F954
		internal void method_0()
		{
			this.class224_0.class716_0.NewAffinity = this.class188_0.State;
		}

		// Token: 0x04000676 RID: 1654
		public Class188 class188_0;

		// Token: 0x04000677 RID: 1655
		public Class719.Class224 class224_0;
	}
}
