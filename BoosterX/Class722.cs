using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ns0;

// Token: 0x02000215 RID: 533
internal sealed class Class722 : GClass211
{
	// Token: 0x06000CC4 RID: 3268 RVA: 0x000398A8 File Offset: 0x00037AA8
	public Class722(GClass116 gclass116_1)
	{
		this.gclass116_0 = gclass116_1;
		this.TextOpacity = 0.0;
		this.ToDelete = false;
		this.class526_0 = new Class526();
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000398D8 File Offset: 0x00037AD8
	public string Name
	{
		get
		{
			return this.gclass116_0.Name;
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x000398E8 File Offset: 0x00037AE8
	public string Id
	{
		get
		{
			return this.gclass116_0.method_0();
		}
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x000398F8 File Offset: 0x00037AF8
	public BitmapSource Icon
	{
		get
		{
			return GClass160.smethod_1(this.gclass116_0.method_4());
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x0003990C File Offset: 0x00037B0C
	public string Description
	{
		get
		{
			return string.Concat(new string[]
			{
				Class364.smethod_0("RemoveDisconnectedDevices"),
				"\r\n\r\nID: ",
				this.gclass116_0.method_0(),
				"\r\n",
				Class364.smethod_0("Name"),
				": ",
				this.gclass116_0.Name,
				"\r\n",
				Class364.smethod_0("Driver"),
				": ",
				this.gclass116_0.method_8(),
				"\r\n",
				Class364.smethod_0("Status"),
				": ",
				this.gclass116_0.Status
			});
		}
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x000399D0 File Offset: 0x00037BD0
	private bool method_1()
	{
		return this.bool_0;
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x000399D8 File Offset: 0x00037BD8
	private void method_2(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06000CCB RID: 3275 RVA: 0x000399E4 File Offset: 0x00037BE4
	// (set) Token: 0x06000CCC RID: 3276 RVA: 0x000399EC File Offset: 0x00037BEC
	public bool ToDelete
	{
		get
		{
			return this.method_1();
		}
		set
		{
			this.method_2(value);
			this.method_3();
			base.method_0("ToDelete");
		}
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x00039A08 File Offset: 0x00037C08
	private void method_3()
	{
		Class722.Struct119 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class722_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class722.Struct119>(ref @struct);
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x00039A40 File Offset: 0x00037C40
	private SolidColorBrush method_4()
	{
		return this.solidColorBrush_0;
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x00039A48 File Offset: 0x00037C48
	private void method_5(SolidColorBrush solidColorBrush_1)
	{
		this.solidColorBrush_0 = solidColorBrush_1;
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00039A54 File Offset: 0x00037C54
	// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x00039A5C File Offset: 0x00037C5C
	public SolidColorBrush TextColor
	{
		get
		{
			return this.method_4();
		}
		set
		{
			this.method_5(value);
			base.method_0("TextColor");
		}
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x00039A70 File Offset: 0x00037C70
	private double method_6()
	{
		return this.double_0;
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x00039A78 File Offset: 0x00037C78
	private void method_7(double double_1)
	{
		this.double_0 = double_1;
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00039A84 File Offset: 0x00037C84
	// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00039A8C File Offset: 0x00037C8C
	public double TextOpacity
	{
		get
		{
			return this.method_6();
		}
		set
		{
			this.method_7(value);
			base.method_0("TextOpacity");
		}
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x00039AA0 File Offset: 0x00037CA0
	private string method_8()
	{
		return this.string_0;
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x00039AA8 File Offset: 0x00037CA8
	private void method_9(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00039AB4 File Offset: 0x00037CB4
	// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00039ABC File Offset: 0x00037CBC
	public string Text
	{
		get
		{
			return this.method_8();
		}
		set
		{
			this.method_9(value);
			base.method_0("Text");
		}
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x00039AD0 File Offset: 0x00037CD0
	private void method_10(string string_1, SolidColorBrush solidColorBrush_1)
	{
		Class722.Struct120 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class722_0 = this;
		@struct.string_0 = string_1;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class722.Struct120>(ref @struct);
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x00039B18 File Offset: 0x00037D18
	private void method_11()
	{
		if (!this.method_1())
		{
			this.method_10(" ", Brushes.Gray);
			GClass93.smethod_0().method_15(typeof(Class526), this.gclass116_0.method_0());
			return;
		}
		this.method_10(Class364.smethod_0("willbecleared"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
		GClass93.smethod_0().method_9<Class526>(this.gclass116_0.method_0(), new Func<Class526>(this.method_12), this);
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x00039B98 File Offset: 0x00037D98
	private Class526 method_12()
	{
		return this.class526_0;
	}

	// Token: 0x040007F0 RID: 2032
	private GClass116 gclass116_0;

	// Token: 0x040007F1 RID: 2033
	private Class526 class526_0;

	// Token: 0x040007F2 RID: 2034
	private bool bool_0;

	// Token: 0x040007F3 RID: 2035
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x040007F4 RID: 2036
	private double double_0;

	// Token: 0x040007F5 RID: 2037
	private string string_0;

	// Token: 0x02000216 RID: 534
	[StructLayout(LayoutKind.Auto)]
	private struct Struct119 : IAsyncStateMachine
	{
		// Token: 0x06000CDD RID: 3293 RVA: 0x00039BA0 File Offset: 0x00037DA0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class722 @object = this.class722_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_11)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class722.Struct119>(ref awaiter, ref this);
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

		// Token: 0x06000CDE RID: 3294 RVA: 0x00039C60 File Offset: 0x00037E60
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007F6 RID: 2038
		public int int_0;

		// Token: 0x040007F7 RID: 2039
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007F8 RID: 2040
		public Class722 class722_0;

		// Token: 0x040007F9 RID: 2041
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000217 RID: 535
	[StructLayout(LayoutKind.Auto)]
	private struct Struct120 : IAsyncStateMachine
	{
		// Token: 0x06000CDF RID: 3295 RVA: 0x00039C70 File Offset: 0x00037E70
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Class722.Class277 @class = new Class722.Class277();
					@class.class722_0 = this.class722_0;
					@class.string_0 = this.string_0;
					@class.solidColorBrush_0 = this.solidColorBrush_0;
					awaiter = Application.Current.Dispatcher.Invoke<Task>(new Func<Task>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class722.Struct120>(ref awaiter, ref this);
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

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00039D5C File Offset: 0x00037F5C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007FA RID: 2042
		public int int_0;

		// Token: 0x040007FB RID: 2043
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007FC RID: 2044
		public Class722 class722_0;

		// Token: 0x040007FD RID: 2045
		public string string_0;

		// Token: 0x040007FE RID: 2046
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040007FF RID: 2047
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000218 RID: 536
	private sealed class Class277
	{
		// Token: 0x06000CE2 RID: 3298 RVA: 0x00039D74 File Offset: 0x00037F74
		internal Task method_0()
		{
			Class722.Class277.Struct121 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class277_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class722.Class277.Struct121>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000800 RID: 2048
		public Class722 class722_0;

		// Token: 0x04000801 RID: 2049
		public string string_0;

		// Token: 0x04000802 RID: 2050
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x02000219 RID: 537
		[StructLayout(LayoutKind.Auto)]
		private struct Struct121 : IAsyncStateMachine
		{
			// Token: 0x06000CE3 RID: 3299 RVA: 0x00039DB8 File Offset: 0x00037FB8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class722.Class277 @class = this.class277_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_110;
					}
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_182;
					}
					IL_1D:
					if (@class.class722_0.TextOpacity == 0.0)
					{
						if (@class.string_0 != null)
						{
							@class.class722_0.Text = @class.string_0;
						}
						@class.class722_0.TextColor = @class.solidColorBrush_0;
						goto IL_189;
					}
					@class.class722_0.TextOpacity = @class.class722_0.TextOpacity - 0.1;
					if (@class.class722_0.TextOpacity < 0.05)
					{
						@class.class722_0.TextOpacity = 0.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class722.Class277.Struct121>(ref awaiter, ref this);
						return;
					}
					IL_110:
					awaiter.GetResult();
					goto IL_1D;
					IL_182:
					awaiter.GetResult();
					IL_189:
					if (@class.class722_0.TextOpacity != 1.0)
					{
						@class.class722_0.TextOpacity = @class.class722_0.TextOpacity + 0.13333333333333333;
						if (@class.class722_0.TextOpacity > 0.95)
						{
							@class.class722_0.TextOpacity = 1.0;
						}
						awaiter = Task.Delay(10).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_182;
						}
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class722.Class277.Struct121>(ref awaiter, ref this);
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

			// Token: 0x06000CE4 RID: 3300 RVA: 0x00039FFC File Offset: 0x000381FC
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000803 RID: 2051
			public int int_0;

			// Token: 0x04000804 RID: 2052
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000805 RID: 2053
			public Class722.Class277 class277_0;

			// Token: 0x04000806 RID: 2054
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
