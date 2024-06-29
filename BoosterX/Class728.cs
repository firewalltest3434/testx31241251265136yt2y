using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using ns0;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;

// Token: 0x0200029E RID: 670
internal sealed class Class728 : GClass211
{
	// Token: 0x06000F60 RID: 3936 RVA: 0x00042820 File Offset: 0x00040A20
	public Class728(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd_1)
	{
		this.dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd_0 = dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd_1;
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		this.method_1();
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00042870 File Offset: 0x00040A70
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("ColChande");
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00042880 File Offset: 0x00040A80
	// (set) Token: 0x06000F63 RID: 3939 RVA: 0x00042888 File Offset: 0x00040A88
	public ObservableCollection<Class715> Models
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("Models");
		}
	}

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0004289C File Offset: 0x00040A9C
	// (set) Token: 0x06000F65 RID: 3941 RVA: 0x000428A4 File Offset: 0x00040AA4
	public Class715 Choosen
	{
		get
		{
			return this.class715_0;
		}
		set
		{
			this.class715_0 = value;
			base.method_0("Choosen");
		}
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x000428B8 File Offset: 0x00040AB8
	private void method_1()
	{
		Class728.Struct141 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class728_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class728.Struct141>(ref @struct);
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x06000F67 RID: 3943 RVA: 0x000428F0 File Offset: 0x00040AF0
	public GClass134 NewTestCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_10), null));
			}
			return result;
		}
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00042924 File Offset: 0x00040B24
	// (set) Token: 0x06000F69 RID: 3945 RVA: 0x00042974 File Offset: 0x00040B74
	public PlotModel BarChartModel
	{
		get
		{
			if (this.plotModel_0 == null)
			{
				this.plotModel_0 = new PlotModel
				{
					DefaultFontSize = 16.0,
					IsLegendVisible = true,
					PlotAreaBorderThickness = new OxyThickness(0.0)
				};
			}
			return this.plotModel_0;
		}
		set
		{
			this.plotModel_0 = value;
			base.method_0("BarChartModel");
		}
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x00042988 File Offset: 0x00040B88
	private void method_2()
	{
		this.BarChartModel.Axes.Clear();
		this.BarChartModel.Series.Clear();
		BarSeries barSeries = new BarSeries
		{
			Title = "Avg",
			IsStacked = false,
			LabelPlacement = 1,
			LabelMargin = 10.0,
			FillColor = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_1(dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zVSGWT5CZARZT3FA_ejd),
			LabelFormatString = "{0:.00} ms",
			FontWeight = 700.0
		};
		BarSeries barSeries2 = new BarSeries
		{
			Title = "Min",
			IsStacked = false,
			LabelPlacement = 1,
			LabelMargin = 10.0,
			FillColor = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_1(dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zYZVHBYJ5T5CB86KT5495X_ejd),
			LabelFormatString = "{0:.00} ms",
			FontWeight = 700.0
		};
		BarSeries barSeries3 = new BarSeries
		{
			Title = "Max",
			IsStacked = false,
			LabelPlacement = 1,
			LabelMargin = 10.0,
			FillColor = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_1(dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zHX7XVSYWXX9CBPQ_ejd),
			LabelFormatString = "{0:.00} ms",
			FontWeight = 700.0
		};
		CategoryAxis categoryAxis = new CategoryAxis
		{
			Position = 1,
			TextColor = OxyColors.White,
			FontWeight = 700.0,
			Font = "Jost",
			FontSize = 16.0,
			MinorTickSize = 0.0,
			MajorTickSize = 0.0
		};
		LinearAxis linearAxis = new LinearAxis
		{
			Position = 4,
			MinimumPadding = 0.0,
			MaximumPadding = 0.0,
			TextColor = OxyColors.White,
			FontWeight = 700.0,
			Font = "Jost",
			FontSize = 16.0,
			MinorTickSize = 0.0,
			MajorTickSize = 0.0,
			IsAxisVisible = false
		};
		foreach (Class715 @class in this.list_0)
		{
			categoryAxis.Labels.Add(@class.Name);
			barSeries.Items.Add(new BarItem(@class.Average, -1));
			barSeries2.Items.Add(new BarItem(@class.Min, -1));
			barSeries3.Items.Add(new BarItem(@class.Max, -1));
		}
		this.BarChartModel.Series.Add(barSeries3);
		this.BarChartModel.Series.Add(barSeries2);
		this.BarChartModel.Series.Add(barSeries);
		this.BarChartModel.Axes.Add(categoryAxis);
		this.BarChartModel.Axes.Add(linearAxis);
		this.BarChartModel.Legends.Add(new Legend
		{
			IsLegendVisible = true,
			LegendPosition = 1,
			LegendOrientation = 0
		});
		this.BarChartModel.DefaultFont = "Jost";
		this.BarChartModel.TextColor = OxyColors.White;
		this.BarChartModel.InvalidatePlot(true);
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00042CE8 File Offset: 0x00040EE8
	public void method_3(Class715 class715_1)
	{
		this.list_0.Add(class715_1);
		this.method_2();
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x00042CFC File Offset: 0x00040EFC
	public void method_4(Class715 class715_1)
	{
		this.list_0.Remove(class715_1);
		this.method_2();
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00042D14 File Offset: 0x00040F14
	public void method_5()
	{
		this.list_0.Clear();
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x00042D24 File Offset: 0x00040F24
	private void method_6()
	{
		if (!Directory.Exists(Class186.string_8))
		{
			Directory.CreateDirectory(Class186.string_8);
		}
		Application.Current.Dispatcher.Invoke(new Action(this.method_7));
		string[] files = Directory.GetFiles(Class186.string_8);
		if (files.Count<string>() == 0)
		{
			Application.Current.Dispatcher.Invoke(new Action(this.method_8));
			return;
		}
		List<Class693> list = new List<Class693>();
		foreach (string path in files)
		{
			try
			{
				string text = Class376.smethod_1(File.ReadAllText(path));
				list.Add(JsonConvert.DeserializeObject<Class693>(text));
			}
			catch (object obj)
			{
			}
		}
		if (list.Count<Class693>() == 0)
		{
			Application.Current.Dispatcher.Invoke(new Action(this.method_9));
			return;
		}
		using (List<Class693>.Enumerator enumerator = list.OrderByDescending(new Func<Class693, DateTime>(Class728.Class336.class336_0.method_0)).ToList<Class693>().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class728.Class335 @class = new Class728.Class335();
				@class.class728_0 = this;
				@class.class693_0 = enumerator.Current;
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			}
		}
		this.Models.First<Class715>().IsChoosen = true;
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00042EA4 File Offset: 0x000410A4
	private void method_7()
	{
		this.Models.Clear();
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00042EB4 File Offset: 0x000410B4
	private void method_8()
	{
		this.NewTestCommand.Execute(null);
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00042EC4 File Offset: 0x000410C4
	private void method_9()
	{
		this.NewTestCommand.Execute(null);
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00042ED4 File Offset: 0x000410D4
	private void method_10(object object_0)
	{
		Class715 item = new Class715(this.dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd_0.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0, this, null, "Test " + this.Models.Count<Class715>().ToString());
		this.Models.Add(item);
		List<Class715> list = this.Models.OrderByDescending(new Func<Class715, DateTime>(Class728.Class336.class336_0.method_1)).ToList<Class715>();
		this.Models.Clear();
		foreach (Class715 item2 in list)
		{
			this.Models.Add(item2);
		}
		this.Models.First<Class715>().IsChoosen = true;
	}

	// Token: 0x0400096D RID: 2413
	private dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd_0;

	// Token: 0x0400096E RID: 2414
	public byte byte_0;

	// Token: 0x0400096F RID: 2415
	private ObservableCollection<Class715> observableCollection_0 = new ObservableCollection<Class715>();

	// Token: 0x04000970 RID: 2416
	private Class715 class715_0;

	// Token: 0x04000971 RID: 2417
	private GClass134 gclass134_0;

	// Token: 0x04000972 RID: 2418
	public PlotModel plotModel_0;

	// Token: 0x04000973 RID: 2419
	public List<Class715> list_0 = new List<Class715>();

	// Token: 0x0200029F RID: 671
	[StructLayout(LayoutKind.Auto)]
	private struct Struct141 : IAsyncStateMachine
	{
		// Token: 0x06000F73 RID: 3955 RVA: 0x00042FB0 File Offset: 0x000411B0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class728 @object = this.class728_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_6)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class728.Struct141>(ref awaiter, ref this);
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

		// Token: 0x06000F74 RID: 3956 RVA: 0x00043070 File Offset: 0x00041270
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000974 RID: 2420
		public int int_0;

		// Token: 0x04000975 RID: 2421
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000976 RID: 2422
		public Class728 class728_0;

		// Token: 0x04000977 RID: 2423
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002A0 RID: 672
	private sealed class Class335
	{
		// Token: 0x06000F76 RID: 3958 RVA: 0x00043088 File Offset: 0x00041288
		internal void method_0()
		{
			this.class728_0.Models.Add(new Class715(this.class728_0.dje_zMRNJMY8LXC8JEAZBR27ZQYBV3WHJKPA3GDW5M6XXSBNDWALBDKE5BAF9H7KQ_ejd_0.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0, this.class728_0, this.class693_0, string.Empty));
		}

		// Token: 0x04000978 RID: 2424
		public Class693 class693_0;

		// Token: 0x04000979 RID: 2425
		public Class728 class728_0;
	}

	// Token: 0x020002A1 RID: 673
	[Serializable]
	private sealed class Class336
	{
		// Token: 0x06000F79 RID: 3961 RVA: 0x000430D4 File Offset: 0x000412D4
		internal DateTime method_0(Class693 class693_0)
		{
			return class693_0.DateTime_0;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000430DC File Offset: 0x000412DC
		internal DateTime method_1(Class715 class715_0)
		{
			return class715_0.Date;
		}

		// Token: 0x0400097A RID: 2426
		public static readonly Class728.Class336 class336_0 = new Class728.Class336();

		// Token: 0x0400097B RID: 2427
		public static Func<Class693, DateTime> func_0;

		// Token: 0x0400097C RID: 2428
		public static Func<Class715, DateTime> func_1;
	}
}
