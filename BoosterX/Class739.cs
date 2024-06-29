using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using BoosterX.Classes.Tweaks.CleanerModel;
using Material.Icons;
using ns0;

// Token: 0x02000388 RID: 904
internal sealed class Class739 : GClass211
{
	// Token: 0x06001463 RID: 5219 RVA: 0x00053A0C File Offset: 0x00051C0C
	public Class739(JsonCleanDto jsonCleanDto_1, bool bool_2)
	{
		this.GetFull = bool_2;
		this.TextOpacity = 0.0;
		this.jsonCleanDto_0 = jsonCleanDto_1;
		this.ToDelete = false;
		this.class526_0 = new Class526();
		this.method_3();
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x00053A4C File Offset: 0x00051C4C
	private MaterialIconKind method_1()
	{
		return this.materialIconKind_0;
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x00053A54 File Offset: 0x00051C54
	private void method_2(MaterialIconKind materialIconKind_1)
	{
		this.materialIconKind_0 = materialIconKind_1;
	}

	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x06001466 RID: 5222 RVA: 0x00053A60 File Offset: 0x00051C60
	// (set) Token: 0x06001467 RID: 5223 RVA: 0x00053A68 File Offset: 0x00051C68
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_1();
		}
		set
		{
			this.method_2(value);
			base.method_0("Icon");
		}
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00053A7C File Offset: 0x00051C7C
	private void method_3()
	{
		Class739.Struct180 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class739_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class739.Struct180>(ref @struct);
	}

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x06001469 RID: 5225 RVA: 0x00053AB4 File Offset: 0x00051CB4
	// (set) Token: 0x0600146A RID: 5226 RVA: 0x00053ABC File Offset: 0x00051CBC
	public bool GetFull
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

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x0600146B RID: 5227 RVA: 0x00053AC8 File Offset: 0x00051CC8
	public string Name
	{
		get
		{
			return Class364.smethod_0(this.jsonCleanDto_0.Name);
		}
	}

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x0600146C RID: 5228 RVA: 0x00053ADC File Offset: 0x00051CDC
	public string Description
	{
		get
		{
			return Class364.smethod_0(this.jsonCleanDto_0.Description);
		}
	}

	// Token: 0x170002CC RID: 716
	// (get) Token: 0x0600146D RID: 5229 RVA: 0x00053AF0 File Offset: 0x00051CF0
	public bool AddToConfig
	{
		get
		{
			return !this.jsonCleanDto_0.IsPRO || Class585.struct13_0.method_0();
		}
	}

	// Token: 0x170002CD RID: 717
	// (get) Token: 0x0600146E RID: 5230 RVA: 0x00053B0C File Offset: 0x00051D0C
	public bool IsPRO
	{
		get
		{
			return this.jsonCleanDto_0.IsPRO;
		}
	}

	// Token: 0x0600146F RID: 5231 RVA: 0x00053B1C File Offset: 0x00051D1C
	private double method_4()
	{
		return this.double_0;
	}

	// Token: 0x06001470 RID: 5232 RVA: 0x00053B24 File Offset: 0x00051D24
	private void method_5(double double_2)
	{
		this.double_0 = double_2;
	}

	// Token: 0x06001471 RID: 5233 RVA: 0x00053B30 File Offset: 0x00051D30
	private bool method_6()
	{
		return this.bool_1;
	}

	// Token: 0x06001472 RID: 5234 RVA: 0x00053B38 File Offset: 0x00051D38
	private void method_7(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	// Token: 0x170002CE RID: 718
	// (get) Token: 0x06001473 RID: 5235 RVA: 0x00053B44 File Offset: 0x00051D44
	// (set) Token: 0x06001474 RID: 5236 RVA: 0x00053B4C File Offset: 0x00051D4C
	public bool ToDelete
	{
		get
		{
			return this.method_6();
		}
		set
		{
			this.method_7(value);
			this.method_8();
			base.method_0("ToDelete");
		}
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x00053B68 File Offset: 0x00051D68
	private void method_8()
	{
		Class739.Struct182 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class739_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class739.Struct182>(ref @struct);
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x00053BA0 File Offset: 0x00051DA0
	private SolidColorBrush method_9()
	{
		return this.solidColorBrush_0;
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x00053BA8 File Offset: 0x00051DA8
	private void method_10(SolidColorBrush solidColorBrush_1)
	{
		this.solidColorBrush_0 = solidColorBrush_1;
	}

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x06001478 RID: 5240 RVA: 0x00053BB4 File Offset: 0x00051DB4
	// (set) Token: 0x06001479 RID: 5241 RVA: 0x00053BBC File Offset: 0x00051DBC
	public SolidColorBrush TextColor
	{
		get
		{
			return this.method_9();
		}
		set
		{
			this.method_10(value);
			base.method_0("TextColor");
		}
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x00053BD0 File Offset: 0x00051DD0
	private double method_11()
	{
		return this.double_1;
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x00053BD8 File Offset: 0x00051DD8
	private void method_12(double double_2)
	{
		this.double_1 = double_2;
	}

	// Token: 0x170002D0 RID: 720
	// (get) Token: 0x0600147C RID: 5244 RVA: 0x00053BE4 File Offset: 0x00051DE4
	// (set) Token: 0x0600147D RID: 5245 RVA: 0x00053BEC File Offset: 0x00051DEC
	public double TextOpacity
	{
		get
		{
			return this.method_11();
		}
		set
		{
			this.method_12(value);
			base.method_0("TextOpacity");
		}
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00053C00 File Offset: 0x00051E00
	private string method_13()
	{
		return this.string_0;
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x00053C08 File Offset: 0x00051E08
	private void method_14(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x06001480 RID: 5248 RVA: 0x00053C14 File Offset: 0x00051E14
	// (set) Token: 0x06001481 RID: 5249 RVA: 0x00053C1C File Offset: 0x00051E1C
	public string Text
	{
		get
		{
			return this.method_13();
		}
		set
		{
			this.method_14(value);
			base.method_0("Text");
		}
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00053C30 File Offset: 0x00051E30
	private void method_15(string string_1, SolidColorBrush solidColorBrush_1)
	{
		Class739.Struct181 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class739_0 = this;
		@struct.string_0 = string_1;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class739.Struct181>(ref @struct);
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x00053C78 File Offset: 0x00051E78
	private void method_16()
	{
		if (this.jsonCleanDto_0.IconPath != null && this.jsonCleanDto_0.IconPath != string.Empty)
		{
			Class739.Class414 @class = new Class739.Class414();
			@class.string_0 = string.Empty;
			this.jsonCleanDto_0.IconPath.Split(new char[]
			{
				'-'
			}).ToList<string>().ForEach(new Action<string>(@class.method_0));
			MaterialIconKind icon;
			if (Enum.TryParse<MaterialIconKind>(@class.string_0, out icon))
			{
				this.Icon = icon;
			}
		}
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00053D04 File Offset: 0x00051F04
	private void method_17()
	{
		if (!this.method_6())
		{
			this.method_15(Class364.smethod_0("Calculating"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			this.method_5((double)Class650.smethod_12(this.jsonCleanDto_0.Paths, this.jsonCleanDto_0.SearchPattern, this.jsonCleanDto_0.IncludeInsideFolders));
			this.method_15(Math.Round(Convert.ToDouble(this.method_4()) / 1024.0 / 1024.0, 2).ToString() + " MB", Brushes.Gray);
			GClass93.smethod_0().method_15(typeof(Class526), this.Name);
			return;
		}
		if (this.AddToConfig)
		{
			this.method_15(Class364.smethod_0("willbecleaned"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			GClass93.smethod_0().method_9<Class526>(this.Name, new Func<Class526>(this.method_18), this.jsonCleanDto_0);
			return;
		}
		this.method_15(Class364.smethod_0("prorequired"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00053E14 File Offset: 0x00052014
	private Class526 method_18()
	{
		return this.class526_0;
	}

	// Token: 0x04000C4D RID: 3149
	private Class526 class526_0;

	// Token: 0x04000C4E RID: 3150
	private JsonCleanDto jsonCleanDto_0;

	// Token: 0x04000C4F RID: 3151
	private MaterialIconKind materialIconKind_0;

	// Token: 0x04000C50 RID: 3152
	private bool bool_0;

	// Token: 0x04000C51 RID: 3153
	private double double_0;

	// Token: 0x04000C52 RID: 3154
	private bool bool_1;

	// Token: 0x04000C53 RID: 3155
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x04000C54 RID: 3156
	private double double_1;

	// Token: 0x04000C55 RID: 3157
	private string string_0;

	// Token: 0x02000389 RID: 905
	private sealed class Class414
	{
		// Token: 0x06001487 RID: 5255 RVA: 0x00053E24 File Offset: 0x00052024
		internal void method_0(string string_1)
		{
			this.string_0 += string_1.smethod_3();
		}

		// Token: 0x04000C56 RID: 3158
		public string string_0;
	}

	// Token: 0x0200038A RID: 906
	[StructLayout(LayoutKind.Auto)]
	private struct Struct180 : IAsyncStateMachine
	{
		// Token: 0x06001488 RID: 5256 RVA: 0x00053E40 File Offset: 0x00052040
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class739 @object = this.class739_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_16)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class739.Struct180>(ref awaiter, ref this);
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

		// Token: 0x06001489 RID: 5257 RVA: 0x00053F00 File Offset: 0x00052100
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C57 RID: 3159
		public int int_0;

		// Token: 0x04000C58 RID: 3160
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000C59 RID: 3161
		public Class739 class739_0;

		// Token: 0x04000C5A RID: 3162
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200038B RID: 907
	[StructLayout(LayoutKind.Auto)]
	private struct Struct181 : IAsyncStateMachine
	{
		// Token: 0x0600148A RID: 5258 RVA: 0x00053F10 File Offset: 0x00052110
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Class739.Class415 @class = new Class739.Class415();
					@class.class739_0 = this.class739_0;
					@class.string_0 = this.string_0;
					@class.solidColorBrush_0 = this.solidColorBrush_0;
					awaiter = Application.Current.Dispatcher.Invoke<Task>(new Func<Task>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class739.Struct181>(ref awaiter, ref this);
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

		// Token: 0x0600148B RID: 5259 RVA: 0x00053FFC File Offset: 0x000521FC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C5B RID: 3163
		public int int_0;

		// Token: 0x04000C5C RID: 3164
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000C5D RID: 3165
		public Class739 class739_0;

		// Token: 0x04000C5E RID: 3166
		public string string_0;

		// Token: 0x04000C5F RID: 3167
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000C60 RID: 3168
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200038C RID: 908
	[StructLayout(LayoutKind.Auto)]
	private struct Struct182 : IAsyncStateMachine
	{
		// Token: 0x0600148C RID: 5260 RVA: 0x0005400C File Offset: 0x0005220C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class739 @class = this.class739_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!@class.GetFull)
					{
						goto IL_7C;
					}
					awaiter = Task.Run(new Action(@class.method_17)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class739.Struct182>(ref awaiter, ref this);
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
				IL_7C:;
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

		// Token: 0x0600148D RID: 5261 RVA: 0x000540D4 File Offset: 0x000522D4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C61 RID: 3169
		public int int_0;

		// Token: 0x04000C62 RID: 3170
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000C63 RID: 3171
		public Class739 class739_0;

		// Token: 0x04000C64 RID: 3172
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200038D RID: 909
	private sealed class Class415
	{
		// Token: 0x0600148F RID: 5263 RVA: 0x000540EC File Offset: 0x000522EC
		internal Task method_0()
		{
			Class739.Class415.Struct183 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class415_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class739.Class415.Struct183>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000C65 RID: 3173
		public Class739 class739_0;

		// Token: 0x04000C66 RID: 3174
		public string string_0;

		// Token: 0x04000C67 RID: 3175
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x0200038E RID: 910
		[StructLayout(LayoutKind.Auto)]
		private struct Struct183 : IAsyncStateMachine
		{
			// Token: 0x06001490 RID: 5264 RVA: 0x00054130 File Offset: 0x00052330
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class739.Class415 @class = this.class415_0;
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
					if (@class.class739_0.TextOpacity == 0.0)
					{
						if (@class.string_0 != null)
						{
							@class.class739_0.Text = @class.string_0;
						}
						@class.class739_0.TextColor = @class.solidColorBrush_0;
						goto IL_189;
					}
					@class.class739_0.TextOpacity = @class.class739_0.TextOpacity - 0.1;
					if (@class.class739_0.TextOpacity < 0.05)
					{
						@class.class739_0.TextOpacity = 0.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class739.Class415.Struct183>(ref awaiter, ref this);
						return;
					}
					IL_110:
					awaiter.GetResult();
					goto IL_1D;
					IL_182:
					awaiter.GetResult();
					IL_189:
					if (@class.class739_0.TextOpacity != 1.0)
					{
						@class.class739_0.TextOpacity = @class.class739_0.TextOpacity + 0.13333333333333333;
						if (@class.class739_0.TextOpacity > 0.95)
						{
							@class.class739_0.TextOpacity = 1.0;
						}
						awaiter = Task.Delay(10).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_182;
						}
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class739.Class415.Struct183>(ref awaiter, ref this);
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

			// Token: 0x06001491 RID: 5265 RVA: 0x00054374 File Offset: 0x00052574
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C68 RID: 3176
			public int int_0;

			// Token: 0x04000C69 RID: 3177
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000C6A RID: 3178
			public Class739.Class415 class415_0;

			// Token: 0x04000C6B RID: 3179
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
