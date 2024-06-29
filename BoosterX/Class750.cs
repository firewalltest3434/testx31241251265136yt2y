using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x0200046A RID: 1130
internal sealed class Class750 : GClass211
{
	// Token: 0x06001918 RID: 6424 RVA: 0x00067508 File Offset: 0x00065708
	public Class750()
	{
		this.Size = 0.0;
		this.TextOpacity = 0.0;
		this.ToDelete = false;
		this.class526_0 = new Class526();
	}

	// Token: 0x170003C2 RID: 962
	// (get) Token: 0x06001919 RID: 6425 RVA: 0x00067540 File Offset: 0x00065740
	// (set) Token: 0x0600191A RID: 6426 RVA: 0x00067548 File Offset: 0x00065748
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

	// Token: 0x170003C3 RID: 963
	// (get) Token: 0x0600191B RID: 6427 RVA: 0x00067554 File Offset: 0x00065754
	public string Description
	{
		get
		{
			return Class364.smethod_0("DeletedUWPAppsLeftOvers") + " \"" + this.Name + "\"";
		}
	}

	// Token: 0x170003C4 RID: 964
	// (get) Token: 0x0600191C RID: 6428 RVA: 0x00067578 File Offset: 0x00065778
	// (set) Token: 0x0600191D RID: 6429 RVA: 0x00067580 File Offset: 0x00065780
	public double Size
	{
		[CompilerGenerated]
		get
		{
			return this.double_0;
		}
		[CompilerGenerated]
		set
		{
			this.double_0 = value;
		}
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x0006758C File Offset: 0x0006578C
	private bool method_1()
	{
		return this.bool_0;
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x00067594 File Offset: 0x00065794
	private void method_2(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x170003C5 RID: 965
	// (get) Token: 0x06001920 RID: 6432 RVA: 0x000675A0 File Offset: 0x000657A0
	// (set) Token: 0x06001921 RID: 6433 RVA: 0x000675A8 File Offset: 0x000657A8
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

	// Token: 0x06001922 RID: 6434 RVA: 0x000675C4 File Offset: 0x000657C4
	private void method_3()
	{
		Class750.Struct236 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class750_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class750.Struct236>(ref @struct);
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x000675FC File Offset: 0x000657FC
	private SolidColorBrush method_4()
	{
		return this.solidColorBrush_0;
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x00067604 File Offset: 0x00065804
	private void method_5(SolidColorBrush solidColorBrush_1)
	{
		this.solidColorBrush_0 = solidColorBrush_1;
	}

	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x06001925 RID: 6437 RVA: 0x00067610 File Offset: 0x00065810
	// (set) Token: 0x06001926 RID: 6438 RVA: 0x00067618 File Offset: 0x00065818
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

	// Token: 0x06001927 RID: 6439 RVA: 0x0006762C File Offset: 0x0006582C
	private double method_6()
	{
		return this.double_1;
	}

	// Token: 0x06001928 RID: 6440 RVA: 0x00067634 File Offset: 0x00065834
	private void method_7(double double_2)
	{
		this.double_1 = double_2;
	}

	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x06001929 RID: 6441 RVA: 0x00067640 File Offset: 0x00065840
	// (set) Token: 0x0600192A RID: 6442 RVA: 0x00067648 File Offset: 0x00065848
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

	// Token: 0x0600192B RID: 6443 RVA: 0x0006765C File Offset: 0x0006585C
	private string method_8()
	{
		return this.string_1;
	}

	// Token: 0x0600192C RID: 6444 RVA: 0x00067664 File Offset: 0x00065864
	private void method_9(string string_2)
	{
		this.string_1 = string_2;
	}

	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x0600192D RID: 6445 RVA: 0x00067670 File Offset: 0x00065870
	// (set) Token: 0x0600192E RID: 6446 RVA: 0x00067678 File Offset: 0x00065878
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

	// Token: 0x0600192F RID: 6447 RVA: 0x0006768C File Offset: 0x0006588C
	private void method_10(string string_2, SolidColorBrush solidColorBrush_1)
	{
		Class750.Struct237 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class750_0 = this;
		@struct.string_0 = string_2;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class750.Struct237>(ref @struct);
	}

	// Token: 0x06001930 RID: 6448 RVA: 0x000676D4 File Offset: 0x000658D4
	private void method_11()
	{
		if (!this.method_1())
		{
			this.method_10(Class364.smethod_0("Calculating"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			Directory.GetDirectories("C:\\Program Files\\WindowsApps").Where(new Func<string, bool>(this.method_12)).ToList<string>().ForEach(new Action<string>(this.method_13));
			this.method_10(this.Size.ToString() + " MB", Brushes.Gray);
			GClass93.smethod_0().method_15(typeof(Class526), this.Name);
			return;
		}
		if (Class585.struct13_0.method_0())
		{
			this.method_10(Class364.smethod_0("willbecleaned"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			GClass93.smethod_0().method_9<Class526>(this.Name, new Func<Class526>(this.method_14), this);
			return;
		}
		this.method_10(Class364.smethod_0("prorequired"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x000677C8 File Offset: 0x000659C8
	private bool method_12(string string_2)
	{
		return string_2.Split(new char[]
		{
			'\\'
		}).Last<string>().StartsWith(this.Name);
	}

	// Token: 0x06001932 RID: 6450 RVA: 0x000677EC File Offset: 0x000659EC
	private void method_13(string string_2)
	{
		this.Size += Class185.smethod_7(string_2);
	}

	// Token: 0x06001933 RID: 6451 RVA: 0x00067804 File Offset: 0x00065A04
	private Class526 method_14()
	{
		return this.class526_0;
	}

	// Token: 0x04001176 RID: 4470
	private Class526 class526_0;

	// Token: 0x04001177 RID: 4471
	private string string_0;

	// Token: 0x04001178 RID: 4472
	private double double_0;

	// Token: 0x04001179 RID: 4473
	private bool bool_0;

	// Token: 0x0400117A RID: 4474
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x0400117B RID: 4475
	private double double_1;

	// Token: 0x0400117C RID: 4476
	private string string_1;

	// Token: 0x0200046B RID: 1131
	private sealed class Class532
	{
		// Token: 0x06001935 RID: 6453 RVA: 0x00067814 File Offset: 0x00065A14
		internal Task method_0()
		{
			Class750.Class532.Struct235 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class532_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class750.Class532.Struct235>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0400117D RID: 4477
		public Class750 class750_0;

		// Token: 0x0400117E RID: 4478
		public string string_0;

		// Token: 0x0400117F RID: 4479
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x0200046C RID: 1132
		[StructLayout(LayoutKind.Auto)]
		private struct Struct235 : IAsyncStateMachine
		{
			// Token: 0x06001936 RID: 6454 RVA: 0x00067858 File Offset: 0x00065A58
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class750.Class532 @class = this.class532_0;
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
					if (@class.class750_0.TextOpacity == 0.0)
					{
						if (@class.string_0 != null)
						{
							@class.class750_0.Text = @class.string_0;
						}
						@class.class750_0.TextColor = @class.solidColorBrush_0;
						goto IL_189;
					}
					@class.class750_0.TextOpacity = @class.class750_0.TextOpacity - 0.1;
					if (@class.class750_0.TextOpacity < 0.05)
					{
						@class.class750_0.TextOpacity = 0.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class750.Class532.Struct235>(ref awaiter, ref this);
						return;
					}
					IL_110:
					awaiter.GetResult();
					goto IL_1D;
					IL_182:
					awaiter.GetResult();
					IL_189:
					if (@class.class750_0.TextOpacity != 1.0)
					{
						@class.class750_0.TextOpacity = @class.class750_0.TextOpacity + 0.13333333333333333;
						if (@class.class750_0.TextOpacity > 0.95)
						{
							@class.class750_0.TextOpacity = 1.0;
						}
						awaiter = Task.Delay(10).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_182;
						}
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class750.Class532.Struct235>(ref awaiter, ref this);
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

			// Token: 0x06001937 RID: 6455 RVA: 0x00067A9C File Offset: 0x00065C9C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001180 RID: 4480
			public int int_0;

			// Token: 0x04001181 RID: 4481
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001182 RID: 4482
			public Class750.Class532 class532_0;

			// Token: 0x04001183 RID: 4483
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x0200046D RID: 1133
	[StructLayout(LayoutKind.Auto)]
	private struct Struct236 : IAsyncStateMachine
	{
		// Token: 0x06001938 RID: 6456 RVA: 0x00067AAC File Offset: 0x00065CAC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class750 @object = this.class750_0;
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
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class750.Struct236>(ref awaiter, ref this);
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

		// Token: 0x06001939 RID: 6457 RVA: 0x00067B6C File Offset: 0x00065D6C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001184 RID: 4484
		public int int_0;

		// Token: 0x04001185 RID: 4485
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001186 RID: 4486
		public Class750 class750_0;

		// Token: 0x04001187 RID: 4487
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200046E RID: 1134
	[StructLayout(LayoutKind.Auto)]
	private struct Struct237 : IAsyncStateMachine
	{
		// Token: 0x0600193A RID: 6458 RVA: 0x00067B7C File Offset: 0x00065D7C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Class750.Class532 @class = new Class750.Class532();
					@class.class750_0 = this.class750_0;
					@class.string_0 = this.string_0;
					@class.solidColorBrush_0 = this.solidColorBrush_0;
					awaiter = Application.Current.Dispatcher.Invoke<Task>(new Func<Task>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class750.Struct237>(ref awaiter, ref this);
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

		// Token: 0x0600193B RID: 6459 RVA: 0x00067C68 File Offset: 0x00065E68
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001188 RID: 4488
		public int int_0;

		// Token: 0x04001189 RID: 4489
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400118A RID: 4490
		public Class750 class750_0;

		// Token: 0x0400118B RID: 4491
		public string string_0;

		// Token: 0x0400118C RID: 4492
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x0400118D RID: 4493
		private TaskAwaiter taskAwaiter_0;
	}
}
