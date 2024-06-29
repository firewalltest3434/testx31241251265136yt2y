using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using Material.Icons;
using ns0;

// Token: 0x020005CA RID: 1482
internal sealed class Class758 : GClass211
{
	// Token: 0x0600204E RID: 8270 RVA: 0x000837B4 File Offset: 0x000819B4
	public Class758(Class323 class323_1)
	{
		this.class323_0 = class323_1;
		this.method_1();
	}

	// Token: 0x0600204F RID: 8271 RVA: 0x000837E0 File Offset: 0x000819E0
	private void method_1()
	{
		Class758.Struct348 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class758_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class758.Struct348>(ref @struct);
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x00083818 File Offset: 0x00081A18
	private Task<bool> method_2()
	{
		return this.class323_0.method_2();
	}

	// Token: 0x1700052A RID: 1322
	// (get) Token: 0x06002051 RID: 8273 RVA: 0x00083828 File Offset: 0x00081A28
	public bool Possible
	{
		get
		{
			if (this.nullable_0 == null)
			{
				return false;
			}
			bool? flag = this.nullable_0;
			return flag.GetValueOrDefault() & flag != null;
		}
	}

	// Token: 0x1700052B RID: 1323
	// (get) Token: 0x06002052 RID: 8274 RVA: 0x00083860 File Offset: 0x00081A60
	// (set) Token: 0x06002053 RID: 8275 RVA: 0x00083868 File Offset: 0x00081A68
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

	// Token: 0x1700052C RID: 1324
	// (get) Token: 0x06002054 RID: 8276 RVA: 0x0008387C File Offset: 0x00081A7C
	// (set) Token: 0x06002055 RID: 8277 RVA: 0x00083884 File Offset: 0x00081A84
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

	// Token: 0x1700052D RID: 1325
	// (get) Token: 0x06002056 RID: 8278 RVA: 0x00083898 File Offset: 0x00081A98
	// (set) Token: 0x06002057 RID: 8279 RVA: 0x000838A0 File Offset: 0x00081AA0
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

	// Token: 0x06002058 RID: 8280 RVA: 0x000838B4 File Offset: 0x00081AB4
	private void method_3(string string_1, SolidColorBrush solidColorBrush_1)
	{
		Class758.Struct346 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class758_0 = this;
		@struct.string_0 = string_1;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class758.Struct346>(ref @struct);
	}

	// Token: 0x1700052E RID: 1326
	// (get) Token: 0x06002059 RID: 8281 RVA: 0x000838FC File Offset: 0x00081AFC
	public string Name
	{
		get
		{
			return Class364.smethod_0(this.class323_0.Name);
		}
	}

	// Token: 0x1700052F RID: 1327
	// (get) Token: 0x0600205A RID: 8282 RVA: 0x00083910 File Offset: 0x00081B10
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_4();
		}
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x00083918 File Offset: 0x00081B18
	private MaterialIconKind method_4()
	{
		MaterialIconKind materialIconKind = Class397.smethod_2(this.class323_0.Name);
		if (materialIconKind == null)
		{
			return 2009;
		}
		return materialIconKind;
	}

	// Token: 0x17000530 RID: 1328
	// (get) Token: 0x0600205C RID: 8284 RVA: 0x00083940 File Offset: 0x00081B40
	public string Description
	{
		get
		{
			return Class364.smethod_0(this.class323_0.Name + "Desc");
		}
	}

	// Token: 0x17000531 RID: 1329
	// (get) Token: 0x0600205D RID: 8285 RVA: 0x0008395C File Offset: 0x00081B5C
	public Task FixTask
	{
		get
		{
			return this.class323_0.method_0();
		}
	}

	// Token: 0x17000532 RID: 1330
	// (get) Token: 0x0600205E RID: 8286 RVA: 0x0008396C File Offset: 0x00081B6C
	public GClass134 RunFix
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_5), null));
			}
			return result;
		}
	}

	// Token: 0x0600205F RID: 8287 RVA: 0x000839A0 File Offset: 0x00081BA0
	private void method_5(object object_0)
	{
		Class758.Struct347 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class758_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class758.Struct347>(ref @struct);
	}

	// Token: 0x06002060 RID: 8288 RVA: 0x000839D8 File Offset: 0x00081BD8
	private Task method_6()
	{
		return this.FixTask;
	}

	// Token: 0x04001656 RID: 5718
	private Class323 class323_0;

	// Token: 0x04001657 RID: 5719
	public bool bool_0;

	// Token: 0x04001658 RID: 5720
	private bool? nullable_0;

	// Token: 0x04001659 RID: 5721
	private string string_0 = string.Empty;

	// Token: 0x0400165A RID: 5722
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x0400165B RID: 5723
	private double double_0;

	// Token: 0x0400165C RID: 5724
	public bool bool_1;

	// Token: 0x0400165D RID: 5725
	private GClass134 gclass134_0;

	// Token: 0x020005CB RID: 1483
	[StructLayout(LayoutKind.Auto)]
	private struct Struct346 : IAsyncStateMachine
	{
		// Token: 0x06002061 RID: 8289 RVA: 0x000839E0 File Offset: 0x00081BE0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class758 @class = this.class758_0;
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class758.Struct346>(ref awaiter, ref this);
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class758.Struct346>(ref awaiter, ref this);
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

		// Token: 0x06002062 RID: 8290 RVA: 0x00083BDC File Offset: 0x00081DDC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400165E RID: 5726
		public int int_0;

		// Token: 0x0400165F RID: 5727
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001660 RID: 5728
		public Class758 class758_0;

		// Token: 0x04001661 RID: 5729
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001662 RID: 5730
		public string string_0;

		// Token: 0x04001663 RID: 5731
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005CC RID: 1484
	[StructLayout(LayoutKind.Auto)]
	private struct Struct347 : IAsyncStateMachine
	{
		// Token: 0x06002063 RID: 8291 RVA: 0x00083BEC File Offset: 0x00081DEC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class758 @class = this.class758_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.method_3(Class364.smethod_0("Fixing"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z2NVHWHQTTE97LGZ_ejd);
					awaiter = Task.Run(new Func<Task>(@class.method_6)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class758.Struct347>(ref awaiter, ref this);
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
				@class.method_3(Class364.smethod_0("Fixed"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
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

		// Token: 0x06002064 RID: 8292 RVA: 0x00083CD4 File Offset: 0x00081ED4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001664 RID: 5732
		public int int_0;

		// Token: 0x04001665 RID: 5733
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001666 RID: 5734
		public Class758 class758_0;

		// Token: 0x04001667 RID: 5735
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005CD RID: 1485
	[StructLayout(LayoutKind.Auto)]
	private struct Struct348 : IAsyncStateMachine
	{
		// Token: 0x06002065 RID: 8293 RVA: 0x00083CE4 File Offset: 0x00081EE4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class758 @class = this.class758_0;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					if (@class.method_2() == null)
					{
						@class.bool_0 = true;
						goto IL_AC;
					}
					awaiter = @class.method_2().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class758.Struct348>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<bool>);
					this.int_0 = -1;
				}
				bool result = awaiter.GetResult();
				@class.nullable_0 = new bool?(result);
				@class.bool_0 = true;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_AC:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00083DC0 File Offset: 0x00081FC0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001668 RID: 5736
		public int int_0;

		// Token: 0x04001669 RID: 5737
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400166A RID: 5738
		public Class758 class758_0;

		// Token: 0x0400166B RID: 5739
		private TaskAwaiter<bool> taskAwaiter_0;
	}
}
