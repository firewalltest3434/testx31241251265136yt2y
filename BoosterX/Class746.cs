using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x02000435 RID: 1077
internal sealed class Class746 : GClass211
{
	// Token: 0x060017B9 RID: 6073 RVA: 0x00064900 File Offset: 0x00062B00
	public Class746(Type type_1, DrawingImage drawingImage_1 = null, string string_3 = "", string string_4 = "", bool bool_2 = false)
	{
		Class746.Class493 @class = new Class746.Class493();
		@class.type_0 = type_1;
		base..ctor();
		if (@class.type_0 != null)
		{
			this.type_0 = @class.type_0;
			this.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
			this.class610_0 = Class609.smethod_0().First(new Func<Class609.Class610, bool>(@class.method_0));
			this.Name = this.class610_0.Name;
			this.Icon = this.class610_0.Icon;
		}
		else
		{
			this.Margin = new Thickness(20.0, 0.0, 0.0, 0.0);
			this.Icon = drawingImage_1;
			this.Name = string_3;
		}
		this.Desc = string_4;
		this.bool_0 = bool_2;
		this.ToApply = true;
	}

	// Token: 0x1700035E RID: 862
	// (get) Token: 0x060017BA RID: 6074 RVA: 0x00064A14 File Offset: 0x00062C14
	// (set) Token: 0x060017BB RID: 6075 RVA: 0x00064A1C File Offset: 0x00062C1C
	public Thickness Margin
	{
		get
		{
			return this.thickness_0;
		}
		set
		{
			this.thickness_0 = value;
			base.method_0("Margin");
		}
	}

	// Token: 0x1700035F RID: 863
	// (get) Token: 0x060017BC RID: 6076 RVA: 0x00064A30 File Offset: 0x00062C30
	// (set) Token: 0x060017BD RID: 6077 RVA: 0x00064A38 File Offset: 0x00062C38
	public DrawingImage Icon
	{
		get
		{
			return this.drawingImage_0;
		}
		set
		{
			this.drawingImage_0 = value;
			base.method_0("Icon");
		}
	}

	// Token: 0x17000360 RID: 864
	// (get) Token: 0x060017BE RID: 6078 RVA: 0x00064A4C File Offset: 0x00062C4C
	// (set) Token: 0x060017BF RID: 6079 RVA: 0x00064A54 File Offset: 0x00062C54
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x17000361 RID: 865
	// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00064A68 File Offset: 0x00062C68
	// (set) Token: 0x060017C1 RID: 6081 RVA: 0x00064A70 File Offset: 0x00062C70
	public string Desc
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("Desc");
		}
	}

	// Token: 0x17000362 RID: 866
	// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00064A84 File Offset: 0x00062C84
	// (set) Token: 0x060017C3 RID: 6083 RVA: 0x00064A8C File Offset: 0x00062C8C
	public bool ToApply
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			if (this.bool_0)
			{
				this.method_1(value ? Class364.smethod_0("willbeinstalled") : Class364.smethod_0("willnotbeinstalled"), value ? dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd : dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
			}
			else
			{
				this.method_1(value ? Class364.smethod_0("WillBeApplied") : Class364.smethod_0("WillNotBeAppied"), value ? dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd : dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
			}
			base.method_0("ToApply");
		}
	}

	// Token: 0x17000363 RID: 867
	// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00064B30 File Offset: 0x00062D30
	// (set) Token: 0x060017C5 RID: 6085 RVA: 0x00064B38 File Offset: 0x00062D38
	public string StatusText
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x17000364 RID: 868
	// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00064B4C File Offset: 0x00062D4C
	// (set) Token: 0x060017C7 RID: 6087 RVA: 0x00064B54 File Offset: 0x00062D54
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

	// Token: 0x17000365 RID: 869
	// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00064B68 File Offset: 0x00062D68
	// (set) Token: 0x060017C9 RID: 6089 RVA: 0x00064B70 File Offset: 0x00062D70
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

	// Token: 0x060017CA RID: 6090 RVA: 0x00064B84 File Offset: 0x00062D84
	private void method_1(string string_3, SolidColorBrush solidColorBrush_1)
	{
		Class746.Struct234 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class746_0 = this;
		@struct.string_0 = string_3;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class746.Struct234>(ref @struct);
	}

	// Token: 0x040010CE RID: 4302
	public Type type_0;

	// Token: 0x040010CF RID: 4303
	public bool bool_0;

	// Token: 0x040010D0 RID: 4304
	public Class609.Class610 class610_0;

	// Token: 0x040010D1 RID: 4305
	public Thickness thickness_0;

	// Token: 0x040010D2 RID: 4306
	public DrawingImage drawingImage_0;

	// Token: 0x040010D3 RID: 4307
	private string string_0;

	// Token: 0x040010D4 RID: 4308
	public string string_1;

	// Token: 0x040010D5 RID: 4309
	private bool bool_1;

	// Token: 0x040010D6 RID: 4310
	private string string_2 = string.Empty;

	// Token: 0x040010D7 RID: 4311
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x040010D8 RID: 4312
	private double double_0;

	// Token: 0x02000436 RID: 1078
	[StructLayout(LayoutKind.Auto)]
	private struct Struct234 : IAsyncStateMachine
	{
		// Token: 0x060017CB RID: 6091 RVA: 0x00064BCC File Offset: 0x00062DCC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class746 @class = this.class746_0;
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class746.Struct234>(ref awaiter, ref this);
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class746.Struct234>(ref awaiter, ref this);
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

		// Token: 0x060017CC RID: 6092 RVA: 0x00064DC8 File Offset: 0x00062FC8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040010D9 RID: 4313
		public int int_0;

		// Token: 0x040010DA RID: 4314
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040010DB RID: 4315
		public Class746 class746_0;

		// Token: 0x040010DC RID: 4316
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040010DD RID: 4317
		public string string_0;

		// Token: 0x040010DE RID: 4318
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000437 RID: 1079
	private sealed class Class493
	{
		// Token: 0x060017CE RID: 6094 RVA: 0x00064DE0 File Offset: 0x00062FE0
		internal bool method_0(Class609.Class610 class610_0)
		{
			return class610_0.method_0() == this.type_0;
		}

		// Token: 0x040010DF RID: 4319
		public Type type_0;
	}
}
