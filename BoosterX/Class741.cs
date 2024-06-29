using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Media;
using Material.Icons;
using ns0;

// Token: 0x020003A8 RID: 936
internal sealed class Class741 : GClass211
{
	// Token: 0x060014EA RID: 5354 RVA: 0x00055804 File Offset: 0x00053A04
	public Class741(Class527 class527_1)
	{
		this.class527_0 = class527_1;
	}

	// Token: 0x170002D8 RID: 728
	// (get) Token: 0x060014EB RID: 5355 RVA: 0x0005582C File Offset: 0x00053A2C
	public bool Possible
	{
		get
		{
			if (this.nullable_0 != null)
			{
				return this.nullable_0.Value;
			}
			this.class527_0.Services.ForEach(new Action<string>(this.method_3));
			this.nullable_0.GetValueOrDefault();
			if (this.nullable_0 == null)
			{
				this.nullable_0 = new bool?(false);
			}
			return this.nullable_0.Value;
		}
	}

	// Token: 0x170002D9 RID: 729
	// (get) Token: 0x060014EC RID: 5356 RVA: 0x000558A0 File Offset: 0x00053AA0
	// (set) Token: 0x060014ED RID: 5357 RVA: 0x000558A8 File Offset: 0x00053AA8
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

	// Token: 0x170002DA RID: 730
	// (get) Token: 0x060014EE RID: 5358 RVA: 0x000558BC File Offset: 0x00053ABC
	// (set) Token: 0x060014EF RID: 5359 RVA: 0x000558C4 File Offset: 0x00053AC4
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

	// Token: 0x170002DB RID: 731
	// (get) Token: 0x060014F0 RID: 5360 RVA: 0x000558D8 File Offset: 0x00053AD8
	// (set) Token: 0x060014F1 RID: 5361 RVA: 0x000558E0 File Offset: 0x00053AE0
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

	// Token: 0x060014F2 RID: 5362 RVA: 0x000558F4 File Offset: 0x00053AF4
	private void method_1(string string_1, SolidColorBrush solidColorBrush_1)
	{
		Class741.Struct196 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class741_0 = this;
		@struct.string_0 = string_1;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class741.Struct196>(ref @struct);
	}

	// Token: 0x170002DC RID: 732
	// (get) Token: 0x060014F3 RID: 5363 RVA: 0x0005593C File Offset: 0x00053B3C
	public string Name
	{
		get
		{
			return this.class527_0.Name;
		}
	}

	// Token: 0x170002DD RID: 733
	// (get) Token: 0x060014F4 RID: 5364 RVA: 0x0005594C File Offset: 0x00053B4C
	public string NameEng
	{
		get
		{
			return this.class527_0.method_0();
		}
	}

	// Token: 0x170002DE RID: 734
	// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0005595C File Offset: 0x00053B5C
	public string SearchInfo
	{
		get
		{
			return string.Join(", ", this.class527_0.Services);
		}
	}

	// Token: 0x170002DF RID: 735
	// (get) Token: 0x060014F6 RID: 5366 RVA: 0x00055974 File Offset: 0x00053B74
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_2();
		}
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x0005597C File Offset: 0x00053B7C
	private MaterialIconKind method_2()
	{
		MaterialIconKind materialIconKind = Class397.smethod_2(this.class527_0.method_0());
		if (materialIconKind == null)
		{
			return 2009;
		}
		return materialIconKind;
	}

	// Token: 0x170002E0 RID: 736
	// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000559A4 File Offset: 0x00053BA4
	public string Description
	{
		get
		{
			return Class364.smethod_0("NextServicesWillBeSetToDefault") + "\n" + string.Join(", ", this.class527_0.Services);
		}
	}

	// Token: 0x170002E1 RID: 737
	// (get) Token: 0x060014F9 RID: 5369 RVA: 0x000559D4 File Offset: 0x00053BD4
	public GClass134 RunFix
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_4), null));
			}
			return result;
		}
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x00055A08 File Offset: 0x00053C08
	private void method_3(string string_1)
	{
		Class741.Class424 @class = new Class741.Class424();
		@class.class741_0 = this;
		@class.string_0 = string_1;
		this.class527_0.method_2().ForEach(new Action<GClass151>(@class.method_0));
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x00055A48 File Offset: 0x00053C48
	private void method_4(object object_0)
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		this.method_1(Class364.smethod_0("Fixing"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z2NVHWHQTTE97LGZ_ejd);
		this.class527_0.Services.ForEach(new Action<string>(this.method_5));
		this.method_1(Class364.smethod_0("Fixed"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
		this.bool_0 = false;
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x00055AB4 File Offset: 0x00053CB4
	private void method_5(string string_1)
	{
		Class741.Class425 @class = new Class741.Class425();
		@class.string_0 = string_1;
		this.class527_0.method_2().ForEach(new Action<GClass151>(@class.method_0));
	}

	// Token: 0x04000CC2 RID: 3266
	private Class527 class527_0;

	// Token: 0x04000CC3 RID: 3267
	private bool? nullable_0;

	// Token: 0x04000CC4 RID: 3268
	private string string_0 = string.Empty;

	// Token: 0x04000CC5 RID: 3269
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x04000CC6 RID: 3270
	private double double_0;

	// Token: 0x04000CC7 RID: 3271
	public bool bool_0;

	// Token: 0x04000CC8 RID: 3272
	private GClass134 gclass134_0;

	// Token: 0x020003A9 RID: 937
	private sealed class Class423
	{
		// Token: 0x060014FE RID: 5374 RVA: 0x00055AF4 File Offset: 0x00053CF4
		internal void method_0()
		{
			GClass188.smethod_19(this.gclass151_0.WinServiceViewModel);
		}

		// Token: 0x04000CC9 RID: 3273
		public GClass151 gclass151_0;
	}

	// Token: 0x020003AA RID: 938
	[StructLayout(LayoutKind.Auto)]
	private struct Struct196 : IAsyncStateMachine
	{
		// Token: 0x060014FF RID: 5375 RVA: 0x00055B08 File Offset: 0x00053D08
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class741 @class = this.class741_0;
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class741.Struct196>(ref awaiter, ref this);
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class741.Struct196>(ref awaiter, ref this);
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

		// Token: 0x06001500 RID: 5376 RVA: 0x00055D04 File Offset: 0x00053F04
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000CCA RID: 3274
		public int int_0;

		// Token: 0x04000CCB RID: 3275
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000CCC RID: 3276
		public Class741 class741_0;

		// Token: 0x04000CCD RID: 3277
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000CCE RID: 3278
		public string string_0;

		// Token: 0x04000CCF RID: 3279
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003AB RID: 939
	private sealed class Class424
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x00055D1C File Offset: 0x00053F1C
		internal void method_0(GClass151 gclass151_0)
		{
			if (GClass188.smethod_16(gclass151_0.WinServiceViewModel.Service.ServiceName).ToLower() == this.string_0.ToLower())
			{
				this.class741_0.nullable_0 = new bool?(gclass151_0.WinServiceViewModel.Service.method_0() == ServiceStartMode.Disabled);
			}
		}

		// Token: 0x04000CD0 RID: 3280
		public string string_0;

		// Token: 0x04000CD1 RID: 3281
		public Class741 class741_0;
	}

	// Token: 0x020003AC RID: 940
	private sealed class Class425
	{
		// Token: 0x06001504 RID: 5380 RVA: 0x00055D80 File Offset: 0x00053F80
		internal void method_0(GClass151 gclass151_0)
		{
			Class741.Class423 @class = new Class741.Class423();
			@class.gclass151_0 = gclass151_0;
			if (GClass188.smethod_16(@class.gclass151_0.WinServiceViewModel.Service.ServiceName).ToLower() == this.string_0.ToLower())
			{
				Task.Run(new Action(@class.method_0));
			}
		}

		// Token: 0x04000CD2 RID: 3282
		public string string_0;
	}
}
