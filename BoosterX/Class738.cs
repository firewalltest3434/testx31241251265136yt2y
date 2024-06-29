using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

// Token: 0x0200037E RID: 894
internal sealed class Class738 : GClass211
{
	// Token: 0x060013E9 RID: 5097 RVA: 0x00052B3C File Offset: 0x00050D3C
	public Class738()
	{
		this.AddCommand = new GClass134(new Action<object>(this.method_3), null);
	}

	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x060013EA RID: 5098 RVA: 0x00052B5C File Offset: 0x00050D5C
	// (set) Token: 0x060013EB RID: 5099 RVA: 0x00052B64 File Offset: 0x00050D64
	public bool IsAdded
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			this.method_1();
			base.method_0("IsAdded");
		}
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x00052B80 File Offset: 0x00050D80
	private void method_1()
	{
		if (this.IsAdded)
		{
			Class294.smethod_2();
			this.FoundIn = Class364.smethod_0("added");
		}
	}

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x060013ED RID: 5101 RVA: 0x00052BA0 File Offset: 0x00050DA0
	// (set) Token: 0x060013EE RID: 5102 RVA: 0x00052BA8 File Offset: 0x00050DA8
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			this.method_2();
			base.method_0("Name");
		}
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x00052BC4 File Offset: 0x00050DC4
	public void method_2()
	{
		Class738.Struct179 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class738_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class738.Struct179>(ref @struct);
	}

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x060013F0 RID: 5104 RVA: 0x00052BFC File Offset: 0x00050DFC
	// (set) Token: 0x060013F1 RID: 5105 RVA: 0x00052C04 File Offset: 0x00050E04
	public GClass134 AddCommand
	{
		[CompilerGenerated]
		get
		{
			return this.gclass134_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass134_0 = value;
		}
	}

	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x060013F2 RID: 5106 RVA: 0x00052C10 File Offset: 0x00050E10
	// (set) Token: 0x060013F3 RID: 5107 RVA: 0x00052C18 File Offset: 0x00050E18
	public string ExeName
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("ExeName");
		}
	}

	// Token: 0x170002A5 RID: 677
	// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00052C2C File Offset: 0x00050E2C
	// (set) Token: 0x060013F5 RID: 5109 RVA: 0x00052C34 File Offset: 0x00050E34
	public string ExeDir
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("ExeDir");
		}
	}

	// Token: 0x170002A6 RID: 678
	// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00052C48 File Offset: 0x00050E48
	// (set) Token: 0x060013F7 RID: 5111 RVA: 0x00052C50 File Offset: 0x00050E50
	public BitmapSource Icon
	{
		get
		{
			return this.bitmapSource_0;
		}
		set
		{
			this.bitmapSource_0 = value;
			base.method_0("Icon");
		}
	}

	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x060013F8 RID: 5112 RVA: 0x00052C64 File Offset: 0x00050E64
	// (set) Token: 0x060013F9 RID: 5113 RVA: 0x00052C6C File Offset: 0x00050E6C
	public string FoundIn
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
			base.method_0("FoundIn");
		}
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x00052C80 File Offset: 0x00050E80
	private void method_3(object object_0)
	{
		Class294.smethod_3(this);
		this.IsAdded = true;
	}

	// Token: 0x04000C21 RID: 3105
	private bool bool_0;

	// Token: 0x04000C22 RID: 3106
	private string string_0;

	// Token: 0x04000C23 RID: 3107
	private GClass134 gclass134_0;

	// Token: 0x04000C24 RID: 3108
	private string string_1;

	// Token: 0x04000C25 RID: 3109
	private string string_2;

	// Token: 0x04000C26 RID: 3110
	private BitmapSource bitmapSource_0;

	// Token: 0x04000C27 RID: 3111
	private string string_3;

	// Token: 0x0200037F RID: 895
	[StructLayout(LayoutKind.Auto)]
	private struct Struct179 : IAsyncStateMachine
	{
		// Token: 0x060013FB RID: 5115 RVA: 0x00052C90 File Offset: 0x00050E90
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class738 @class = this.class738_0;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = Class197.smethod_0(@class.Name.EndsWith(".exe") ? @class.Name.Replace(".exe", string.Empty) : @class.Name).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class738.Struct179>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				string result = awaiter.GetResult();
				if (result != null)
				{
					@class.Icon = Class650.smethod_5(result);
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

		// Token: 0x060013FC RID: 5116 RVA: 0x00052D84 File Offset: 0x00050F84
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C28 RID: 3112
		public int int_0;

		// Token: 0x04000C29 RID: 3113
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000C2A RID: 3114
		public Class738 class738_0;

		// Token: 0x04000C2B RID: 3115
		private TaskAwaiter<string> taskAwaiter_0;
	}
}
