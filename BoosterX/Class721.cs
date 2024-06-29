using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ns0;
using WinCopies.Util;

// Token: 0x02000209 RID: 521
internal sealed class Class721 : GClass211
{
	// Token: 0x06000C88 RID: 3208 RVA: 0x00038668 File Offset: 0x00036868
	public Class721(ListView listView_1)
	{
		this.listView_0 = listView_1;
		this.method_1();
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000C89 RID: 3209 RVA: 0x000386D0 File Offset: 0x000368D0
	public GClass134 UpdateCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_9), null));
			}
			return result;
		}
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x00038704 File Offset: 0x00036904
	private void method_1()
	{
		Class721.Struct118 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class721_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class721.Struct118>(ref @struct);
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0003873C File Offset: 0x0003693C
	// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00038744 File Offset: 0x00036944
	public string StatusText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00038758 File Offset: 0x00036958
	// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00038760 File Offset: 0x00036960
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

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00038774 File Offset: 0x00036974
	// (set) Token: 0x06000C90 RID: 3216 RVA: 0x0003877C File Offset: 0x0003697C
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

	// Token: 0x06000C91 RID: 3217 RVA: 0x00038790 File Offset: 0x00036990
	private void method_2(string string_2, SolidColorBrush solidColorBrush_1)
	{
		Class721.Struct117 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class721_0 = this;
		@struct.string_0 = string_2;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class721.Struct117>(ref @struct);
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06000C92 RID: 3218 RVA: 0x000387D8 File Offset: 0x000369D8
	// (set) Token: 0x06000C93 RID: 3219 RVA: 0x000387E0 File Offset: 0x000369E0
	public double AnimationOpacity
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
			base.method_0("AnimationOpacity");
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000C94 RID: 3220 RVA: 0x000387F4 File Offset: 0x000369F4
	// (set) Token: 0x06000C95 RID: 3221 RVA: 0x000387FC File Offset: 0x000369FC
	public Visibility AnimationVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("AnimationVisibility");
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00038810 File Offset: 0x00036A10
	// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00038818 File Offset: 0x00036A18
	public double MainOpacity
	{
		get
		{
			return this.double_2;
		}
		set
		{
			this.double_2 = value;
			base.method_0("MainOpacity");
		}
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x0003882C File Offset: 0x00036A2C
	private void method_3()
	{
		this.MainOpacity = 0.0;
		this.AnimationVisibility = Visibility.Visible;
		this.AnimationOpacity = 1.0;
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x00038854 File Offset: 0x00036A54
	private void method_4()
	{
		Class721.Struct116 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class721_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class721.Struct116>(ref @struct);
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x0003888C File Offset: 0x00036A8C
	private void method_5(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("ColChanged");
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x0003889C File Offset: 0x00036A9C
	private Task method_6()
	{
		Class721.Struct113 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class721_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class721.Struct113>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x000388E0 File Offset: 0x00036AE0
	private Task method_7()
	{
		Class721.Struct115 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class721_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class721.Struct115>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00038924 File Offset: 0x00036B24
	// (set) Token: 0x06000C9E RID: 3230 RVA: 0x0003892C File Offset: 0x00036B2C
	public string Search
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			this.IsPossible = false;
			base.method_0("Search");
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00038948 File Offset: 0x00036B48
	// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00038954 File Offset: 0x00036B54
	public bool IsAll
	{
		get
		{
			return !this.bool_1;
		}
		set
		{
			this.bool_1 = !value;
			base.method_0("IsAll");
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0003896C File Offset: 0x00036B6C
	// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x00038974 File Offset: 0x00036B74
	public bool IsPossible
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			base.method_0("IsPossible");
			base.method_0("IsAll");
			this.method_8(this.string_1);
		}
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x000389A0 File Offset: 0x00036BA0
	private void method_8(string string_2)
	{
		Class721.Struct114 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class721_0 = this;
		@struct.string_0 = string_2;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class721.Struct114>(ref @struct);
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x000389E0 File Offset: 0x00036BE0
	private void method_9(object object_0)
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		this.method_1();
	}

	// Token: 0x040007B3 RID: 1971
	private ListView listView_0;

	// Token: 0x040007B4 RID: 1972
	private bool bool_0;

	// Token: 0x040007B5 RID: 1973
	private GClass134 gclass134_0;

	// Token: 0x040007B6 RID: 1974
	private string string_0 = string.Empty;

	// Token: 0x040007B7 RID: 1975
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x040007B8 RID: 1976
	private double double_0;

	// Token: 0x040007B9 RID: 1977
	private double double_1;

	// Token: 0x040007BA RID: 1978
	private Visibility visibility_0;

	// Token: 0x040007BB RID: 1979
	private double double_2;

	// Token: 0x040007BC RID: 1980
	private ObservableCollection<Class741> observableCollection_0 = new ObservableCollection<Class741>();

	// Token: 0x040007BD RID: 1981
	private ObservableCollection<Class758> observableCollection_1 = new ObservableCollection<Class758>();

	// Token: 0x040007BE RID: 1982
	private List<GClass151> list_0 = new List<GClass151>();

	// Token: 0x040007BF RID: 1983
	private string string_1 = Class364.smethod_0("Search");

	// Token: 0x040007C0 RID: 1984
	private bool bool_1;

	// Token: 0x0200020A RID: 522
	[StructLayout(LayoutKind.Auto)]
	private struct Struct113 : IAsyncStateMachine
	{
		// Token: 0x06000CA5 RID: 3237 RVA: 0x000389F8 File Offset: 0x00036BF8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					goto IL_134;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					goto IL_15C;
				}
				this.class272_0 = new Class721.Class272();
				this.class272_0.class721_0 = this.class721_0;
				this.class272_0.list_0 = Class324.smethod_0();
				this.list_0 = new List<Class758>();
				List<Class323>.Enumerator enumerator = this.class272_0.list_0.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class323 class323_ = enumerator.Current;
						this.list_0.Add(new Class758(class323_));
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				this.int_1 = 0;
				IL_CC:
				if (this.list_0.All(new Func<Class758, bool>(Class721.Class273.class273_0.method_2)))
				{
					int num4 = this.int_1;
					this.int_1 = num4 + 1;
					if (num4 <= 1000)
					{
						awaiter = Task.Delay(20).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_134;
						}
						int num5 = 0;
						num = 0;
						this.int_0 = num5;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class721.Struct113>(ref awaiter, ref this);
						return;
					}
				}
				awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class272_0.method_0)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num6 = 1;
					num = 1;
					this.int_0 = num6;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class721.Struct113>(ref awaiter, ref this);
					return;
				}
				goto IL_15C;
				IL_134:
				awaiter.GetResult();
				goto IL_CC;
				IL_15C:
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class272_0 = null;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class272_0 = null;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00038C64 File Offset: 0x00036E64
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007C1 RID: 1985
		public int int_0;

		// Token: 0x040007C2 RID: 1986
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040007C3 RID: 1987
		public Class721 class721_0;

		// Token: 0x040007C4 RID: 1988
		private Class721.Class272 class272_0;

		// Token: 0x040007C5 RID: 1989
		private List<Class758> list_0;

		// Token: 0x040007C6 RID: 1990
		private int int_1;

		// Token: 0x040007C7 RID: 1991
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200020B RID: 523
	[StructLayout(LayoutKind.Auto)]
	private struct Struct114 : IAsyncStateMachine
	{
		// Token: 0x06000CA7 RID: 3239 RVA: 0x00038C74 File Offset: 0x00036E74
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Class721.Class274 @class = new Class721.Class274();
					@class.class721_0 = this.class721_0;
					@class.string_0 = this.string_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class721.Struct114>(ref awaiter, ref this);
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

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00038D54 File Offset: 0x00036F54
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007C8 RID: 1992
		public int int_0;

		// Token: 0x040007C9 RID: 1993
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007CA RID: 1994
		public Class721 class721_0;

		// Token: 0x040007CB RID: 1995
		public string string_0;

		// Token: 0x040007CC RID: 1996
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200020C RID: 524
	private sealed class Class272
	{
		// Token: 0x06000CAA RID: 3242 RVA: 0x00038D6C File Offset: 0x00036F6C
		internal void method_0()
		{
			List<Class323> list = this.list_0;
			Action<Class323> action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action<Class323>(this.method_1));
			}
			list.ForEach(action);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00038DA4 File Offset: 0x00036FA4
		internal void method_1(Class323 class323_0)
		{
			this.class721_0.observableCollection_1.Add(new Class758(class323_0));
		}

		// Token: 0x040007CD RID: 1997
		public List<Class323> list_0;

		// Token: 0x040007CE RID: 1998
		public Class721 class721_0;

		// Token: 0x040007CF RID: 1999
		public Action<Class323> action_0;
	}

	// Token: 0x0200020D RID: 525
	[StructLayout(LayoutKind.Auto)]
	private struct Struct115 : IAsyncStateMachine
	{
		// Token: 0x06000CAC RID: 3244 RVA: 0x00038DBC File Offset: 0x00036FBC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class721 @class = this.class721_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					goto IL_CA;
				}
				if (num != 1)
				{
					this.class275_0 = new Class721.Class275();
					this.class275_0.class721_0 = this.class721_0;
					@class.list_0 = Class683.smethod_1(true).AllServices;
					awaiter = Class683.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num3 = 0;
						num = 0;
						this.int_0 = num3;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class721.Struct115>(ref awaiter, ref this);
						return;
					}
					goto IL_CA;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
				}
				IL_A2:
				awaiter.GetResult();
				goto IL_302;
				IL_CA:
				awaiter.GetResult();
				Dictionary<string, GClass155> dictionary = GClass139.smethod_0().method_0();
				this.class275_0.list_0 = new List<Class527>();
				Dictionary<string, GClass155>.Enumerator enumerator = dictionary.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, GClass155> keyValuePair = enumerator.Current;
						if (!keyValuePair.Value.List_0[0].smethod_7())
						{
							for (int i = 0; i < keyValuePair.Value.List_0.Count; i++)
							{
								try
								{
									Class721.Class276 class2 = new Class721.Class276();
									class2.string_0 = Class364.smethod_0(keyValuePair.Value.List_0[i]);
									if (this.class275_0.list_0.Any(new Func<Class527, bool>(class2.method_0)))
									{
										this.class275_0.list_0.Find(new Predicate<Class527>(class2.method_1)).Services.Add(keyValuePair.Key);
									}
									else
									{
										List<Class527> list_ = this.class275_0.list_0;
										Class527 class3 = new Class527();
										class3.Name = class2.string_0;
										class3.method_1(Class364.smethod_0(keyValuePair.Value.List_0[i]));
										class3.Services = new List<string>
										{
											keyValuePair.Key
										};
										class3.method_3(@class.list_0);
										list_.Add(class3);
									}
								}
								catch (Exception exception_)
								{
									GClass141.smethod_0(exception_);
								}
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
				this.class275_0.list_0 = this.class275_0.list_0.OrderBy(new Func<Class527, string>(Class721.Class273.class273_0.method_3)).ToList<Class527>();
				awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class275_0.method_0)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num5 = 1;
					num = 1;
					this.int_0 = num5;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class721.Struct115>(ref awaiter, ref this);
					return;
				}
				goto IL_A2;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class275_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_302:
			this.int_0 = -2;
			this.class275_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00039134 File Offset: 0x00037334
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007D0 RID: 2000
		public int int_0;

		// Token: 0x040007D1 RID: 2001
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040007D2 RID: 2002
		public Class721 class721_0;

		// Token: 0x040007D3 RID: 2003
		private Class721.Class275 class275_0;

		// Token: 0x040007D4 RID: 2004
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200020E RID: 526
	[StructLayout(LayoutKind.Auto)]
	private struct Struct116 : IAsyncStateMachine
	{
		// Token: 0x06000CAE RID: 3246 RVA: 0x00039144 File Offset: 0x00037344
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class721 @class = this.class721_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_D1;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_12F;
				}
				IL_1D:
				if (@class.AnimationOpacity == 0.0)
				{
					@class.AnimationVisibility = Visibility.Collapsed;
					goto IL_136;
				}
				@class.AnimationOpacity -= 0.1;
				if (@class.AnimationOpacity < 0.05)
				{
					@class.AnimationOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class721.Struct116>(ref awaiter, ref this);
					return;
				}
				IL_D1:
				awaiter.GetResult();
				goto IL_1D;
				IL_12F:
				awaiter.GetResult();
				IL_136:
				if (@class.MainOpacity != 1.0)
				{
					@class.MainOpacity += 0.13333333333333333;
					if (@class.MainOpacity > 0.95)
					{
						@class.MainOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_12F;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class721.Struct116>(ref awaiter, ref this);
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

		// Token: 0x06000CAF RID: 3247 RVA: 0x00039330 File Offset: 0x00037530
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007D5 RID: 2005
		public int int_0;

		// Token: 0x040007D6 RID: 2006
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007D7 RID: 2007
		public Class721 class721_0;

		// Token: 0x040007D8 RID: 2008
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200020F RID: 527
	[Serializable]
	private sealed class Class273
	{
		// Token: 0x06000CB2 RID: 3250 RVA: 0x00039354 File Offset: 0x00037554
		internal bool method_0(Class741 class741_0)
		{
			return class741_0.Possible;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0003935C File Offset: 0x0003755C
		internal bool method_1(Class758 class758_0)
		{
			return class758_0.Possible;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00039364 File Offset: 0x00037564
		internal bool method_2(Class758 class758_0)
		{
			return class758_0.bool_0;
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0003936C File Offset: 0x0003756C
		internal string method_3(Class527 class527_0)
		{
			return class527_0.Name;
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00039374 File Offset: 0x00037574
		internal bool method_4(Class741 class741_0)
		{
			return class741_0.Possible;
		}

		// Token: 0x040007D9 RID: 2009
		public static readonly Class721.Class273 class273_0 = new Class721.Class273();

		// Token: 0x040007DA RID: 2010
		public static Func<Class741, bool> func_0;

		// Token: 0x040007DB RID: 2011
		public static Func<Class758, bool> func_1;

		// Token: 0x040007DC RID: 2012
		public static Func<Class758, bool> func_2;

		// Token: 0x040007DD RID: 2013
		public static Func<Class527, string> func_3;

		// Token: 0x040007DE RID: 2014
		public static Func<Class741, bool> func_4;
	}

	// Token: 0x02000210 RID: 528
	[StructLayout(LayoutKind.Auto)]
	private struct Struct117 : IAsyncStateMachine
	{
		// Token: 0x06000CB7 RID: 3255 RVA: 0x0003937C File Offset: 0x0003757C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class721 @class = this.class721_0;
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class721.Struct117>(ref awaiter, ref this);
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class721.Struct117>(ref awaiter, ref this);
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

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00039578 File Offset: 0x00037778
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007DF RID: 2015
		public int int_0;

		// Token: 0x040007E0 RID: 2016
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007E1 RID: 2017
		public Class721 class721_0;

		// Token: 0x040007E2 RID: 2018
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040007E3 RID: 2019
		public string string_0;

		// Token: 0x040007E4 RID: 2020
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000211 RID: 529
	private sealed class Class274
	{
		// Token: 0x06000CBA RID: 3258 RVA: 0x00039590 File Offset: 0x00037790
		internal void method_0()
		{
			this.class721_0.listView_0.Items.Clear();
			List<Class741> list = new List<Class741>();
			if (this.class721_0.bool_1)
			{
				list.AddRange(this.class721_0.observableCollection_0.Where(new Func<Class741, bool>(Class721.Class273.class273_0.method_4)));
			}
			else
			{
				list.AddRange(this.class721_0.observableCollection_0);
			}
			if (!this.string_0.smethod_7() && this.string_0 != Class364.smethod_0("Search"))
			{
				IEnumerable<Class741> source = list;
				Func<Class741, bool> predicate;
				if ((predicate = this.func_0) == null)
				{
					predicate = (this.func_0 = new Func<Class741, bool>(this.method_1));
				}
				list = source.Where(predicate).ToList<Class741>();
			}
			IList items = this.class721_0.listView_0.Items;
			IEnumerable enumerable = list;
			Extensions.AddRange(items, ref enumerable);
			this.class721_0.listView_0.Items.Refresh();
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0003968C File Offset: 0x0003788C
		internal bool method_1(Class741 class741_0)
		{
			return class741_0.Name.smethod_2(this.string_0) || class741_0.NameEng.smethod_2(this.string_0) || class741_0.SearchInfo.smethod_2(this.string_0);
		}

		// Token: 0x040007E5 RID: 2021
		public Class721 class721_0;

		// Token: 0x040007E6 RID: 2022
		public string string_0;

		// Token: 0x040007E7 RID: 2023
		public Func<Class741, bool> func_0;
	}

	// Token: 0x02000212 RID: 530
	private sealed class Class275
	{
		// Token: 0x06000CBD RID: 3261 RVA: 0x000396D0 File Offset: 0x000378D0
		internal void method_0()
		{
			this.class721_0.observableCollection_0.Clear();
			List<Class527> list = this.list_0;
			Action<Class527> action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action<Class527>(this.method_1));
			}
			list.ForEach(action);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00039718 File Offset: 0x00037918
		internal void method_1(Class527 class527_0)
		{
			this.class721_0.observableCollection_0.Add(new Class741(class527_0));
		}

		// Token: 0x040007E8 RID: 2024
		public Class721 class721_0;

		// Token: 0x040007E9 RID: 2025
		public List<Class527> list_0;

		// Token: 0x040007EA RID: 2026
		public Action<Class527> action_0;
	}

	// Token: 0x02000213 RID: 531
	private sealed class Class276
	{
		// Token: 0x06000CC0 RID: 3264 RVA: 0x00039738 File Offset: 0x00037938
		internal bool method_0(Class527 class527_0)
		{
			return class527_0.Name == this.string_0;
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0003974C File Offset: 0x0003794C
		internal bool method_1(Class527 class527_0)
		{
			return class527_0.Name == this.string_0;
		}

		// Token: 0x040007EB RID: 2027
		public string string_0;
	}

	// Token: 0x02000214 RID: 532
	[StructLayout(LayoutKind.Auto)]
	private struct Struct118 : IAsyncStateMachine
	{
		// Token: 0x06000CC2 RID: 3266 RVA: 0x00039760 File Offset: 0x00037960
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class721 @class = this.class721_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.method_3();
					awaiter = Task.WhenAll(new List<Task>
					{
						@class.method_7()
					}).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class721.Struct118>(ref awaiter, ref this);
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
				Class721 class2 = @class;
				bool isPossible;
				if (!@class.observableCollection_0.Any(new Func<Class741, bool>(Class721.Class273.class273_0.method_0)))
				{
					isPossible = @class.observableCollection_1.Any(new Func<Class758, bool>(Class721.Class273.class273_0.method_1));
				}
				else
				{
					isPossible = true;
				}
				class2.IsPossible = isPossible;
				@class.method_4();
				@class.bool_0 = false;
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

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00039898 File Offset: 0x00037A98
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007EC RID: 2028
		public int int_0;

		// Token: 0x040007ED RID: 2029
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007EE RID: 2030
		public Class721 class721_0;

		// Token: 0x040007EF RID: 2031
		private TaskAwaiter taskAwaiter_0;
	}
}
