using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ns0;

// Token: 0x02000553 RID: 1363
internal sealed class Class754 : GClass211
{
	// Token: 0x06001DA3 RID: 7587 RVA: 0x0007C0D4 File Offset: 0x0007A2D4
	public Class754(Class752 class752_1)
	{
		this.class752_0 = class752_1;
		this.method_1();
	}

	// Token: 0x06001DA4 RID: 7588 RVA: 0x0007C114 File Offset: 0x0007A314
	private void method_1()
	{
		Class754.Struct318 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class754_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class754.Struct318>(ref @struct);
	}

	// Token: 0x17000498 RID: 1176
	// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x0007C14C File Offset: 0x0007A34C
	// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x0007C154 File Offset: 0x0007A354
	public string AppXName
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

	// Token: 0x17000499 RID: 1177
	// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x0007C160 File Offset: 0x0007A360
	// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x0007C168 File Offset: 0x0007A368
	public string AppXUri
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

	// Token: 0x1700049A RID: 1178
	// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x0007C174 File Offset: 0x0007A374
	// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0007C17C File Offset: 0x0007A37C
	public string AppXAverageRating
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("AppXAverageRating");
		}
	}

	// Token: 0x1700049B RID: 1179
	// (get) Token: 0x06001DAB RID: 7595 RVA: 0x0007C190 File Offset: 0x0007A390
	// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0007C198 File Offset: 0x0007A398
	public string AppXProductID
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
			base.method_0("AppXProductID");
		}
	}

	// Token: 0x1700049C RID: 1180
	// (get) Token: 0x06001DAD RID: 7597 RVA: 0x0007C1AC File Offset: 0x0007A3AC
	// (set) Token: 0x06001DAE RID: 7598 RVA: 0x0007C1B4 File Offset: 0x0007A3B4
	public bool AppXIsChecked
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			base.method_0("AppXIsChecked");
			this.method_2(value);
		}
	}

	// Token: 0x06001DAF RID: 7599 RVA: 0x0007C1D0 File Offset: 0x0007A3D0
	private void method_2(bool bool_2)
	{
		if (this.class752_0 == null)
		{
			return;
		}
		if (bool_2)
		{
			this.StatusText = Class364.smethod_0("OnQueue");
			this.StatusColor = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z2NVHWHQTTE97LGZ_ejd;
			this.StatusOpacity = 0.8;
			this.class752_0.AppXsInstallVMs.Add(this);
			return;
		}
		this.class752_0.AppXsInstallVMs.Remove(this);
	}

	// Token: 0x1700049D RID: 1181
	// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x0007C238 File Offset: 0x0007A438
	// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x0007C240 File Offset: 0x0007A440
	public string StatusText
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x1700049E RID: 1182
	// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x0007C254 File Offset: 0x0007A454
	// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x0007C25C File Offset: 0x0007A45C
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

	// Token: 0x1700049F RID: 1183
	// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x0007C270 File Offset: 0x0007A470
	// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x0007C278 File Offset: 0x0007A478
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

	// Token: 0x06001DB6 RID: 7606 RVA: 0x0007C28C File Offset: 0x0007A48C
	public void method_3(string string_6, SolidColorBrush solidColorBrush_1)
	{
		Class754.Struct316 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class754_0 = this;
		@struct.string_0 = string_6;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class754.Struct316>(ref @struct);
	}

	// Token: 0x170004A0 RID: 1184
	// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x0007C2D4 File Offset: 0x0007A4D4
	// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x0007C2DC File Offset: 0x0007A4DC
	public BitmapSource AppXIcon
	{
		[CompilerGenerated]
		get
		{
			return this.bitmapSource_0;
		}
		[CompilerGenerated]
		set
		{
			this.bitmapSource_0 = value;
		}
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x0007C2E8 File Offset: 0x0007A4E8
	private string method_4()
	{
		return this.string_5;
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x0007C2F0 File Offset: 0x0007A4F0
	private void method_5(string string_6)
	{
		this.string_5 = string_6;
	}

	// Token: 0x170004A1 RID: 1185
	// (get) Token: 0x06001DBB RID: 7611 RVA: 0x0007C2FC File Offset: 0x0007A4FC
	// (set) Token: 0x06001DBC RID: 7612 RVA: 0x0007C304 File Offset: 0x0007A504
	public string AppXSize
	{
		get
		{
			return this.method_4();
		}
		set
		{
			this.method_5(value);
			base.method_0("AppXSize");
		}
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x0007C318 File Offset: 0x0007A518
	private Task method_6()
	{
		Class754.Struct319 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class754_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class754.Struct319>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x040014D3 RID: 5331
	private Class752 class752_0;

	// Token: 0x040014D4 RID: 5332
	public bool bool_0;

	// Token: 0x040014D5 RID: 5333
	private string string_0;

	// Token: 0x040014D6 RID: 5334
	private string string_1;

	// Token: 0x040014D7 RID: 5335
	private string string_2;

	// Token: 0x040014D8 RID: 5336
	private string string_3;

	// Token: 0x040014D9 RID: 5337
	private bool bool_1;

	// Token: 0x040014DA RID: 5338
	private string string_4 = Class364.smethod_0("OnQueue");

	// Token: 0x040014DB RID: 5339
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z2NVHWHQTTE97LGZ_ejd;

	// Token: 0x040014DC RID: 5340
	private double double_0 = 0.8;

	// Token: 0x040014DD RID: 5341
	private BitmapSource bitmapSource_0;

	// Token: 0x040014DE RID: 5342
	private string string_5;

	// Token: 0x02000554 RID: 1364
	[StructLayout(LayoutKind.Auto)]
	private struct Struct316 : IAsyncStateMachine
	{
		// Token: 0x06001DBE RID: 7614 RVA: 0x0007C35C File Offset: 0x0007A55C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<Task> awaiter;
				if (num != 0)
				{
					Class754.Class621 @class = new Class754.Class621();
					@class.class754_0 = this.class754_0;
					@class.solidColorBrush_0 = this.solidColorBrush_0;
					@class.string_0 = this.string_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync<Task>(new Func<Task>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class754.Struct316>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Task>);
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

		// Token: 0x06001DBF RID: 7615 RVA: 0x0007C448 File Offset: 0x0007A648
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014DF RID: 5343
		public int int_0;

		// Token: 0x040014E0 RID: 5344
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040014E1 RID: 5345
		public Class754 class754_0;

		// Token: 0x040014E2 RID: 5346
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040014E3 RID: 5347
		public string string_0;

		// Token: 0x040014E4 RID: 5348
		private TaskAwaiter<Task> taskAwaiter_0;
	}

	// Token: 0x02000555 RID: 1365
	private sealed class Class621
	{
		// Token: 0x06001DC1 RID: 7617 RVA: 0x0007C460 File Offset: 0x0007A660
		internal Task method_0()
		{
			Class754.Class621.Struct317 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class621_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class754.Class621.Struct317>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040014E5 RID: 5349
		public Class754 class754_0;

		// Token: 0x040014E6 RID: 5350
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040014E7 RID: 5351
		public string string_0;

		// Token: 0x02000556 RID: 1366
		[StructLayout(LayoutKind.Auto)]
		private struct Struct317 : IAsyncStateMachine
		{
			// Token: 0x06001DC2 RID: 7618 RVA: 0x0007C4A4 File Offset: 0x0007A6A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class754.Class621 @class = this.class621_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_105;
					}
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_177;
					}
					IL_1D:
					if (@class.class754_0.StatusOpacity == 0.0)
					{
						@class.class754_0.StatusColor = @class.solidColorBrush_0;
						@class.class754_0.StatusText = @class.string_0;
						goto IL_17E;
					}
					@class.class754_0.StatusOpacity = @class.class754_0.StatusOpacity - 0.1;
					if (@class.class754_0.StatusOpacity < 0.05)
					{
						@class.class754_0.StatusOpacity = 0.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class754.Class621.Struct317>(ref awaiter, ref this);
						return;
					}
					IL_105:
					awaiter.GetResult();
					goto IL_1D;
					IL_177:
					awaiter.GetResult();
					IL_17E:
					if (@class.class754_0.StatusOpacity != 1.0)
					{
						@class.class754_0.StatusOpacity = @class.class754_0.StatusOpacity + 0.13333333333333333;
						if (@class.class754_0.StatusOpacity > 0.95)
						{
							@class.class754_0.StatusOpacity = 1.0;
						}
						awaiter = Task.Delay(10).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_177;
						}
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class754.Class621.Struct317>(ref awaiter, ref this);
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

			// Token: 0x06001DC3 RID: 7619 RVA: 0x0007C6DC File Offset: 0x0007A8DC
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040014E8 RID: 5352
			public int int_0;

			// Token: 0x040014E9 RID: 5353
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040014EA RID: 5354
			public Class754.Class621 class621_0;

			// Token: 0x040014EB RID: 5355
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x02000557 RID: 1367
	[StructLayout(LayoutKind.Auto)]
	private struct Struct318 : IAsyncStateMachine
	{
		// Token: 0x06001DC4 RID: 7620 RVA: 0x0007C6EC File Offset: 0x0007A8EC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class754 @object = this.class754_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_6)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class754.Struct318>(ref awaiter, ref this);
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

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0007C7AC File Offset: 0x0007A9AC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014EC RID: 5356
		public int int_0;

		// Token: 0x040014ED RID: 5357
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040014EE RID: 5358
		public Class754 class754_0;

		// Token: 0x040014EF RID: 5359
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000558 RID: 1368
	[StructLayout(LayoutKind.Auto)]
	private struct Struct319 : IAsyncStateMachine
	{
		// Token: 0x06001DC6 RID: 7622 RVA: 0x0007C7BC File Offset: 0x0007A9BC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class754 @class = this.class754_0;
			try
			{
				GClass162 gclass;
				if (num != 0)
				{
					if (!@class.AppXAverageRating.smethod_7())
					{
						goto IL_129;
					}
					gclass = new GClass162(Class426.gclass52_0.method_6(), new GClass4(Class426.gclass52_1.method_2(), Class426.gclass52_1.method_4(), true));
				}
				try
				{
					TaskAwaiter<GClass18> awaiter;
					if (num != 0)
					{
						awaiter = gclass.method_1(@class.AppXProductID, (GEnum26)0, null).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass18>, Class754.Struct319>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass18>);
						this.int_0 = -1;
					}
					GClass18 result = awaiter.GetResult();
					@class.AppXAverageRating = result.GClass209_0.List_1[0].List_2[2].Double_0.ToString();
				}
				catch
				{
					@class.AppXAverageRating = "-";
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_129:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x0007C924 File Offset: 0x0007AB24
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014F0 RID: 5360
		public int int_0;

		// Token: 0x040014F1 RID: 5361
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040014F2 RID: 5362
		public Class754 class754_0;

		// Token: 0x040014F3 RID: 5363
		private TaskAwaiter<GClass18> taskAwaiter_0;
	}
}
